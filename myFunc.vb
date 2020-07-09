Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Module myFunc
    '===================================================================================
    '             === check expiration date ===
    '===================================================================================
    Sub checkExpirationDate()

        Dim currentDate As Date = Date.Now
        Dim lastRunDate As Date = My.Settings.lastRun
        Dim daysStayed As Int32 = My.Settings.expireDate.Subtract(currentDate).Days

        mainForm.menuItem_manufactor.Enabled = False
        mainForm.menuItem_company.Enabled = False

        If lastRunDate.Subtract(currentDate).Days > 0 Then
            MsgBox("Check date and time settings!")
            mainForm.Close()
        Else
            My.Settings.lastRun = currentDate
            My.Settings.Save()
        End If

        If daysStayed > 0 Then
            Return
        Else
            MsgBox("This app has expired!")
            mainForm.Close()
        End If
    End Sub

    '===================================================================================
    '             === Load database ===
    '===================================================================================

    Sub load_db()

        ' Show the FolderBrowserDialog.
        mainForm.FBD.SelectedPath = Directory.GetCurrentDirectory()
        Dim result As DialogResult = mainForm.FBD.ShowDialog()
        If (result = DialogResult.OK) Then
            mainForm.sDir = mainForm.FBD.SelectedPath
            mainForm.sFilePath = mainForm.sDir & "\" & mainForm.sFileName
        Else
            Exit Sub
        End If

        ' mainForm.dt_SpareParts = loadDatatables("Spare", "SpareParts")
        mainForm.dt_Fixtures = loadDatatables("Fixtures", "Fixtures")
        'mainForm.dt_SpareTypes = loadDatatables("Spare", "SpareTypes")
        'mainForm.dt_Location = loadDatatables("Spare", "Location")
        'mainForm.dt_Manufactors = loadDatatables("Fixtures", "Manufactors")

        'mainForm.DGV.DataSource = mainForm.dt_Manufactors
    End Sub

    '===================================================================================
    '             === Load datatables ===
    '===================================================================================

    Function loadDatatables(_wsName As String, _tableName As String)

        Dim ws As ExcelWorksheet
        Dim excelFile = New FileInfo(mainForm.sFilePath)
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)


        Dim dt As DataTable

        Dim xlTable As ExcelTable
        Dim adr As String
        Dim row As DataRow

        Dim r_xlTable, c_xlTable As Integer
        Dim rng As ExcelRange

        ws = Excel.Workbook.Worksheets(_wsName)
        xlTable = ws.Tables(_tableName)
        c_xlTable = xlTable.Address.Columns
        r_xlTable = xlTable.Address.Rows

        adr = xlTable.Address.Address
        rng = ws.Cells(adr)

        dt = New DataTable
        dt.TableName = xlTable.Name

        'Adding the Columns
        For i = 0 To c_xlTable - 1
            dt.Columns.Add(rng.Value(0, i))
        Next i

        Select Case _tableName

            Case = "SpareParts"

                dt.Columns(0).DataType = System.Type.GetType("System.Int32")                 ' id_spare
                dt.Columns(1).DataType = System.Type.GetType("System.String")                ' Type
                dt.Columns(2).DataType = System.Type.GetType("System.String")                ' Name
                dt.Columns(3).DataType = System.Type.GetType("System.String")                ' PartName
                dt.Columns(4).DataType = System.Type.GetType("System.String")                ' PartNumber
                dt.Columns(5).DataType = System.Type.GetType("System.String")                ' Fixture
                dt.Columns(6).DataType = System.Type.GetType("System.String")                ' Manufactor
                dt.Columns(7).DataType = System.Type.GetType("System.Boolean")               ' MultiFixture
                dt.Columns(8).DataType = System.Type.GetType("System.String")                ' Notes

            Case = "Fixtures"

                dt.Columns(0).DataType = System.Type.GetType("System.Int32")                 ' id
                dt.Columns(1).DataType = System.Type.GetType("System.String")                ' Fixtures
                dt.Columns(2).DataType = System.Type.GetType("System.String")                ' Manufactor
                dt.Columns(3).DataType = System.Type.GetType("System.String")                ' Type

            Case Else

                dt.Columns(0).DataType = System.Type.GetType("System.Int32")                 ' id
                dt.Columns(1).DataType = System.Type.GetType("System.String")                ' Type/Location/Manufactor

        End Select

        For i = 1 To r_xlTable - 1

            row = dt.Rows.Add()

            For j = 0 To c_xlTable - 1

                row.Item(j) = rng.Value(i, j)

            Next j
        Next i

        Return dt

    End Function

    '===================================================================================
    '             === Fill datagridview ===
    '===================================================================================

    Function fillDGV(_expression As String, _dt As DataTable, _columnName As String)

        Dim filterTable As DataTable
        Dim foundRows() As DataRow
        Dim expression As String

        expression = _columnName & " = " & " '" & _expression & "'"

        filterTable = _dt.Copy
        filterTable.Clear()

        foundRows = _dt.Select(expression)

        For i As Integer = 0 To foundRows.GetUpperBound(0)
            filterTable.ImportRow(foundRows(i))
        Next i

        Return filterTable

    End Function
    '===================================================================================
    '             === Format DGV_fxt ===
    '===================================================================================
    Sub formatDGV_fxt(_case As Integer)
        mainForm.DGV_fxt.Columns(2).Visible = False
        mainForm.DGV_fxt.Columns(3).Visible = False
        mainForm.DGV_fxt.Columns(0).Width = 40
        mainForm.DGV_fxt.RowHeadersVisible = False
        Select Case _case
            Case = 1
                mainForm.DGV_fxt.Columns(1).Width = 130
            Case = 2
                mainForm.DGV_fxt.Columns(1).Width = 147
        End Select
    End Sub

End Module
