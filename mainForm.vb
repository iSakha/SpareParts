Imports OfficeOpenXml
Imports OfficeOpenXml.Table

Public Class mainForm

    Public sDir As String
    Public sFilePath As String
    Public sFileName As String = "db.xlsx"

    Public dt_Fixtures, dt_SpareParts, dt_Location, dt_Manufactors As DataTable
    Public dt_Personnel, dt_SpareTypes, dt_Action As DataTable

    '===================================================================================
    '             === mainForm_Load ===
    '===================================================================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_manufactor.Text = String.Empty
        lbl_fxt.Text = String.Empty
    End Sub
    '===================================================================================
    '             === File => Load database ===
    '===================================================================================
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        load_db()

    End Sub
    '============================           Claypaky            =================================================================
    Private Sub item_claypaky_Click(sender As Object, e As EventArgs) Handles item_claypaky.Click
        DGV_fxt.DataSource = fillDGV("ClayPaky", dt_Fixtures, "Manufactor")
        formatDGV_fxt(1)
        writeToLabel("ClayPaky")
    End Sub
    Private Sub item_lamp_cp_Click(sender As Object, e As EventArgs) Handles item_lamp_cp.Click
        DGV_fxt.DataSource = fillDGV("Lamp", fillDGV("ClayPaky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt(2)
        writeToLabel("ClayPaky Lamp")
    End Sub
    Private Sub item_led_cp_Click(sender As Object, e As EventArgs) Handles item_led_cp.Click
        DGV_fxt.DataSource = fillDGV("LED", fillDGV("ClayPaky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt(2)
        writeToLabel("ClayPaky LED")
    End Sub
    '============================           PRLighting            =================================================================
    Private Sub item_pr_Click(sender As Object, e As EventArgs) Handles item_pr.Click
        DGV_fxt.DataSource = fillDGV("PR Lighting", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("PR Lighting")
    End Sub

    Private Sub item_lamp_pr_Click(sender As Object, e As EventArgs) Handles item_lamp_pr.Click
        DGV_fxt.DataSource = fillDGV("Lamp", fillDGV("PR Lighting", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt(2)
        writeToLabel("PR Lighting Lamp")
    End Sub

    Private Sub item_led_pr_Click(sender As Object, e As EventArgs) Handles item_led_pr.Click
        DGV_fxt.DataSource = fillDGV("LED", fillDGV("PR Lighting", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt(2)
        writeToLabel("PR Lighting LED")
    End Sub
    '============================           LightSky            =================================================================

    Private Sub item_lightsky_Click(sender As Object, e As EventArgs) Handles item_lightsky.Click
        DGV_fxt.DataSource = fillDGV("LightSky", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("LightSky")
    End Sub
    Private Sub item_lamp_ls_Click(sender As Object, e As EventArgs) Handles item_lamp_ls.Click
        DGV_fxt.DataSource = fillDGV("Lamp", fillDGV("LightSky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt(2)
        writeToLabel("LightSky Lamp")
    End Sub
    Private Sub item_led_ls_Click(sender As Object, e As EventArgs) Handles item_led_ls.Click
        DGV_fxt.DataSource = fillDGV("LED", fillDGV("LightSky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt(2)
        writeToLabel("LightSky LED")
    End Sub
    '============================           Martin            =================================================================

    Private Sub item_martin_Click(sender As Object, e As EventArgs) Handles item_martin.Click
        DGV_fxt.DataSource = fillDGV("Martin", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("Martin")
    End Sub
    '============================           StudioDue            =================================================================
    Private Sub item_studiodue_Click(sender As Object, e As EventArgs) Handles item_studiodue.Click
        DGV_fxt.DataSource = fillDGV("StudioDue", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("StudioDue")
    End Sub

    '============================           Antari            =================================================================

    Private Sub item_antari_Click(sender As Object, e As EventArgs) Handles item_antari.Click
        DGV_fxt.DataSource = fillDGV("Antari", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("Antari")
    End Sub

    '============================           MALighting            =================================================================
    Private Sub item_malighting_Click(sender As Object, e As EventArgs) Handles item_malighting.Click
        DGV_fxt.DataSource = fillDGV("MALighting", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("MALighting ")
    End Sub
    '============================           LDR           =================================================================
    Private Sub item_ldr_Click(sender As Object, e As EventArgs) Handles item_ldr.Click
        DGV_fxt.DataSource = fillDGV("LDR", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("LDR")
    End Sub
    '============================           Showtec            =================================================================
    Private Sub item_showtec_Click(sender As Object, e As EventArgs) Handles item_showtec.Click
        DGV_fxt.DataSource = fillDGV("Showtec", dt_Fixtures, "Manufactor")
        formatDGV_fxt(2)
        writeToLabel("Showtec")
    End Sub

    '============================           All fixtures            =================================================================
    Private Sub item_all_fxt_Click(sender As Object, e As EventArgs) Handles item_all_fxt.Click
        DGV_fxt.DataSource = dt_Fixtures
        formatDGV_fxt(1)
        writeToLabel("All fixtures")
    End Sub


    Private Sub DGV_fxt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_fxt.CellClick
        dgv_clickCell(sender, e)
    End Sub


End Class
