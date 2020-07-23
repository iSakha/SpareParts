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

        mainForm.dt_Action = loadDatatables("Action", "Action")
        mainForm.dt_SpareParts = loadDatatables("Spare", "SpareParts")
        mainForm.dt_Fixtures = loadDatatables("Fixtures", "Fixtures")
        mainForm.dt_SpareTypes = loadDatatables("Spare", "SpareTypes")
        mainForm.dt_Location = loadDatatables("Spare", "Location")
        mainForm.dt_Manufactors = loadDatatables("Fixtures", "Manufactors")
        mainForm.dt_Personnel = loadDatatables("Fixtures", "Personnel")

        'mainForm.DGV_spare.DataSource = mainForm.dt_SpareParts
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

            Case = "Action"

                dt.Columns(0).DataType = System.Type.GetType("System.Int32")                 ' id_action
                dt.Columns(1).DataType = System.Type.GetType("System.DateTime")              ' Date
                dt.Columns(2).DataType = System.Type.GetType("System.String")                ' Action
                dt.Columns(3).DataType = System.Type.GetType("System.String")                ' Type
                dt.Columns(4).DataType = System.Type.GetType("System.String")                ' Name
                dt.Columns(5).DataType = System.Type.GetType("System.String")                ' PartName
                dt.Columns(6).DataType = System.Type.GetType("System.String")                ' PartNumber
                dt.Columns(7).DataType = System.Type.GetType("System.String")                ' Fixture
                dt.Columns(8).DataType = System.Type.GetType("System.String")                ' Manufactor
                dt.Columns(8).DataType = System.Type.GetType("System.Int32")                 ' Qty
                dt.Columns(8).DataType = System.Type.GetType("System.Boolean")               ' MultiFixture
                dt.Columns(8).DataType = System.Type.GetType("System.String")                ' Notes
                dt.Columns(8).DataType = System.Type.GetType("System.String")                ' Pers

            Case = "SpareParts"

                dt.Columns(0).DataType = System.Type.GetType("System.Int32")                 ' id_spare
                dt.Columns(1).DataType = System.Type.GetType("System.String")                ' Type
                dt.Columns(2).DataType = System.Type.GetType("System.String")                ' Name
                dt.Columns(3).DataType = System.Type.GetType("System.String")                ' PartName
                dt.Columns(4).DataType = System.Type.GetType("System.String")                ' PartNumber
                dt.Columns(5).DataType = System.Type.GetType("System.String")                ' Fixture
                dt.Columns(6).DataType = System.Type.GetType("System.String")                ' Manufactor
                dt.Columns(7).DataType = System.Type.GetType("System.String")                ' FixtureType
                dt.Columns(8).DataType = System.Type.GetType("System.Boolean")               ' MultiFixture
                dt.Columns(8).DataType = System.Type.GetType("System.Int32")                 ' Qty
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
                'If (j = 1) Then
                'row.Item(j) = Date.FromOADate(rng.Value(i, j))
                'Else
                row.Item(j) = rng.Value(i, j)
                'End If
            Next j
        Next i

        Return dt

    End Function

    '===================================================================================
    '             === Fill Spare datagridview ===
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
    Sub formatDGV_fxt()
        mainForm.DGV_fxt.Columns(2).Visible = False
        mainForm.DGV_fxt.Columns(3).Visible = False
        mainForm.DGV_fxt.Columns(0).Width = 40
        mainForm.DGV_fxt.RowHeadersVisible = False
        mainForm.DGV_fxt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    '===================================================================================
    '             === Write to label ===
    '===================================================================================

    Sub writeToLabel(_lbl As String)
        mainForm.lbl_manufactor.Text = _lbl
    End Sub

    '===================================================================================
    '             === CellClick on DGV_fxt ===
    '===================================================================================
    Sub dgv_clickCell_fxt(_sender As Object, _e As DataGridViewCellEventArgs)
        Dim index As Integer
        index = _e.RowIndex
        mainForm.lbl_fxt.Text = mainForm.DGV_fxt.Rows(index).Cells(1).Value
        mainForm.DGV_spare.DataSource = mainForm.dt_SpareParts

        mainForm.DGV_fxt.Rows(index).Selected = True
    End Sub
    '===================================================================================
    '             === Format DGV_spare ===
    '===================================================================================
    Sub formatDGV_spare(_case As Integer)
        mainForm.DGV_spare.RowHeadersVisible = False
        mainForm.DGV_spare.Columns(0).Width = 40                    ' id_spare
        mainForm.DGV_spare.Columns(1).Width = 100                   ' Type
        mainForm.DGV_spare.Columns(2).Width = 190                   ' Name
        mainForm.DGV_spare.Columns(3).Visible = False               ' PartName
        mainForm.DGV_spare.Columns(4).Visible = False               ' PartNumber
        Select Case _case
            Case 1
                mainForm.DGV_spare.Columns(5).Visible = False               ' Fixture
            Case 2
                mainForm.DGV_spare.Columns(5).Visible = True
                mainForm.DGV_spare.Columns(5).Width = 100
        End Select

        mainForm.DGV_spare.Columns(6).Visible = False               ' Manufactor
        mainForm.DGV_spare.Columns(7).Visible = False               ' FixtureType
        mainForm.DGV_spare.Columns(8).Visible = False               ' MultiFixture
        mainForm.DGV_spare.Columns(9).Width = 40                    ' Qty
        mainForm.DGV_spare.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill           ' Notes
    End Sub

    '===================================================================================
    '             === CellClick on DGV_fxt ===
    '===================================================================================
    Sub dgv_clickCell_spare(_sender As Object, _e As DataGridViewCellEventArgs)
        Dim index As Integer
        index = _e.RowIndex
        mainForm.lbl_sparename.Text = mainForm.DGV_spare.Rows(index).Cells(2).Value
        mainForm.lbl_qty.Text = "В наличии:  " & mainForm.DGV_spare.Rows(index).Cells(9).Value
        mainForm.lbl_fxt.Text = mainForm.DGV_spare.Rows(index).Cells(5).Value

        mainForm.DGV_spare.Rows(index).Selected = True

    End Sub
    '===================================================================================
    '             === Filter DGV_spare by type ===
    '===================================================================================
    Sub filtermainForm(_type As String)
        Dim filterTable As DataTable
        Dim foundRows() As DataRow
        Dim expression As String

        expression = "Type = " & "'" & _type & "'"

        filterTable = mainForm.dt_SpareParts.Copy
        filterTable.Clear()

        foundRows = mainForm.dt_SpareParts.Select(expression)

        For i As Integer = 0 To foundRows.GetUpperBound(0)
            filterTable.ImportRow(foundRows(i))
        Next i

        mainForm.DGV_spare.DataSource = filterTable
    End Sub

    '===================================================================================
    '             === Format DGV_IN/OUT ===
    '===================================================================================
    Sub formatDGV_IN_OUT(_dgv As DataGridView)

        _dgv.RowHeadersVisible = False

        _dgv.Columns(0).Width = 40                  ' id_action
        _dgv.Columns(1).Width = 70                  ' Date
        _dgv.Columns(2).Width = 40                  ' Action
        _dgv.Columns(3).Width = 90                  ' Spare Type
        _dgv.Columns(4).Width = 160                 ' Spare Name
        _dgv.Columns(5).Width = 130                 ' PartName
        _dgv.Columns(6).Width = 90                  ' PartNumber
        _dgv.Columns(7).Width = 110                 ' Fixture
        _dgv.Columns(8).Width = 90                  ' Manufactor
        _dgv.Columns(9).Width = 40                  ' Qty
        _dgv.Columns(10).Width = 40                 ' MultiFixture  
        _dgv.Columns(11).Width = 180                ' Notes

        _dgv.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill         ' Pers

    End Sub


End Module
