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
        lbl_sparename.Text = String.Empty
        lbl_qty.Text = String.Empty
    End Sub
    '===================================================================================
    '             === File => Load database ===
    '===================================================================================
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        load_db()

    End Sub

#Region "Manufactors"
    '============================           Claypaky            =================================================================
    Private Sub item_claypaky_Click(sender As Object, e As EventArgs) Handles item_claypaky.Click
        DGV_fxt.DataSource = fillDGV("ClayPaky", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("ClayPaky")
    End Sub
    Private Sub item_lamp_cp_Click(sender As Object, e As EventArgs) Handles item_lamp_cp.Click
        DGV_fxt.DataSource = fillDGV("Lamp", fillDGV("ClayPaky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt()
        writeToLabel("ClayPaky Lamp")
    End Sub
    Private Sub item_led_cp_Click(sender As Object, e As EventArgs) Handles item_led_cp.Click
        DGV_fxt.DataSource = fillDGV("LED", fillDGV("ClayPaky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt()
        writeToLabel("ClayPaky LED")
    End Sub
    '============================           PRLighting            =================================================================
    Private Sub item_pr_Click(sender As Object, e As EventArgs) Handles item_pr.Click
        DGV_fxt.DataSource = fillDGV("PR Lighting", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("PR Lighting")
    End Sub

    Private Sub item_lamp_pr_Click(sender As Object, e As EventArgs) Handles item_lamp_pr.Click
        DGV_fxt.DataSource = fillDGV("Lamp", fillDGV("PR Lighting", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt()
        writeToLabel("PR Lighting Lamp")
    End Sub

    Private Sub item_led_pr_Click(sender As Object, e As EventArgs) Handles item_led_pr.Click
        DGV_fxt.DataSource = fillDGV("LED", fillDGV("PR Lighting", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt()
        writeToLabel("PR Lighting LED")
    End Sub
    '============================           LightSky            =================================================================

    Private Sub item_lightsky_Click(sender As Object, e As EventArgs) Handles item_lightsky.Click
        DGV_fxt.DataSource = fillDGV("LightSky", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("LightSky")
    End Sub
    Private Sub item_lamp_ls_Click(sender As Object, e As EventArgs) Handles item_lamp_ls.Click
        DGV_fxt.DataSource = fillDGV("Lamp", fillDGV("LightSky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt()
        writeToLabel("LightSky Lamp")
    End Sub
    Private Sub item_led_ls_Click(sender As Object, e As EventArgs) Handles item_led_ls.Click
        DGV_fxt.DataSource = fillDGV("LED", fillDGV("LightSky", dt_Fixtures, "Manufactor"), "Type")
        formatDGV_fxt()
        writeToLabel("LightSky LED")
    End Sub
    '============================           Martin            =================================================================
    Private Sub item_martin_Click(sender As Object, e As EventArgs) Handles item_martin.Click
        DGV_fxt.DataSource = fillDGV("Martin", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("Martin")
    End Sub
    '============================           StudioDue            =================================================================
    Private Sub item_studiodue_Click(sender As Object, e As EventArgs) Handles item_studiodue.Click
        DGV_fxt.DataSource = fillDGV("StudioDue", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("StudioDue")
    End Sub
    '============================           Antari            =================================================================

    Private Sub item_antari_Click(sender As Object, e As EventArgs) Handles item_antari.Click
        DGV_fxt.DataSource = fillDGV("Antari", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("Antari")
    End Sub

    '============================           MALighting            =================================================================
    Private Sub item_malighting_Click(sender As Object, e As EventArgs) Handles item_malighting.Click
        DGV_fxt.DataSource = fillDGV("MALighting", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("MALighting ")
    End Sub
    '============================           LDR           =================================================================
    Private Sub item_ldr_Click(sender As Object, e As EventArgs) Handles item_ldr.Click
        DGV_fxt.DataSource = fillDGV("LDR", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("LDR")
    End Sub
    '============================           Showtec            =================================================================
    Private Sub item_showtec_Click(sender As Object, e As EventArgs) Handles item_showtec.Click
        DGV_fxt.DataSource = fillDGV("Showtec", dt_Fixtures, "Manufactor")
        formatDGV_fxt()
        writeToLabel("Showtec")
    End Sub

    '============================           All fixtures            =================================================================
    Private Sub item_all_fxt_Click(sender As Object, e As EventArgs) Handles item_all_fxt.Click
        DGV_fxt.DataSource = dt_Fixtures
        formatDGV_fxt()
        writeToLabel("All fixtures")
    End Sub
#End Region

#Region "SpareParts Types"
    Private Sub item_pwr_Click(sender As Object, e As EventArgs) Handles item_pwr.Click
        filtermainForm("Power,high voltage")
        formatDGV_spare(2)
    End Sub

    Private Sub item_electronics_Click(sender As Object, e As EventArgs) Handles item_electronics.Click
        filtermainForm("Electronics")
        formatDGV_spare(2)
    End Sub

    Private Sub item_optics_Click(sender As Object, e As EventArgs) Handles item_optics.Click
        filtermainForm("Optics")
        formatDGV_spare(2)
    End Sub

    Private Sub item_plastic_Click(sender As Object, e As EventArgs) Handles item_plastic.Click
        filtermainForm("Plastic")
        formatDGV_spare(2)
    End Sub

    Private Sub item_mechanics_Click(sender As Object, e As EventArgs) Handles item_mechanics.Click
        filtermainForm("Mechanics")
        formatDGV_spare(2)
    End Sub

    Private Sub item_fans_Click(sender As Object, e As EventArgs) Handles item_fans.Click
        filtermainForm("Fans")
        formatDGV_spare(2)
    End Sub

    Private Sub item_others_Click(sender As Object, e As EventArgs) Handles item_others.Click
        filtermainForm("Others")
        formatDGV_spare(2)
    End Sub

    Private Sub item_allSpare_Click(sender As Object, e As EventArgs) Handles item_allSpare.Click
        DGV_spare.DataSource = dt_SpareParts
        formatDGV_spare(2)
    End Sub
#End Region

    '===================================================================================
    '             === CellClick on DGV_fxt ===
    '===================================================================================
    Private Sub DGV_fxt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_fxt.CellClick
        dgv_clickCell_fxt(sender, e)
        DGV_spare.DataSource = fillDGV(lbl_fxt.Text, dt_SpareParts, "Fixture")
        formatDGV_spare(1)
        lbl_sparename.Text = String.Empty
        lbl_qty.Text = String.Empty
    End Sub
    '===================================================================================
    '             === CellClick on DGV_spare ===
    '===================================================================================
    Private Sub DGV_spare_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_spare.CellClick
        dgv_clickCell_spare(sender, e)
    End Sub


End Class
