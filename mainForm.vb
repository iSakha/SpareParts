Imports OfficeOpenXml
Imports OfficeOpenXml.Table

Public Class mainForm

    Public sDir As String
    Public sFilePath As String
    Public sFileName As String = "db.xlsx"

    Public dt_Fixtures, dt_SpareParts, dt_Location, dt_Manufactors, dt_SpareTypes As DataTable



    '===================================================================================
    '             === File => Load database ===
    '===================================================================================
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        load_db()

    End Sub

    Private Sub item_lighting_Click(sender As Object, e As EventArgs) Handles item_lighting.Click

        DGV_fxt.DataSource = dt_Fixtures
        DGV_fxt.Columns(2).Visible = False
        DGV_fxt.Columns(3).Visible = False
        DGV_fxt.Columns(0).Width = 40
        DGV_fxt.Columns(1).Width = 130
        DGV_fxt.RowHeadersVisible = False

    End Sub

End Class
