<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItem_department = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_lighting = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_movHeads = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_strobes = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_screen = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_modules = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_servers = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_commutation = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_pwrdistr = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_comm = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_truss_and_motors = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_construction = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_sound = New System.Windows.Forms.ToolStripMenuItem()
        Me.MALightingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LDRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowtecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItem_company = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_belimlight = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_PRLighting = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_blackout = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_vision = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_stage = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_summary = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.DGV_fxt = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_spare = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGV_fxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_spare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.menuItem_department, Me.menuItem_company})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExportToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.OpenToolStripMenuItem.Text = "&Load database"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(190, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExportToolStripMenuItem.Text = "&Export to Excel"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'menuItem_department
        '
        Me.menuItem_department.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.item_lighting, Me.item_screen, Me.item_commutation, Me.item_truss_and_motors, Me.item_construction, Me.item_sound, Me.MALightingToolStripMenuItem, Me.LDRToolStripMenuItem, Me.ShowtecToolStripMenuItem})
        Me.menuItem_department.Name = "menuItem_department"
        Me.menuItem_department.Size = New System.Drawing.Size(81, 20)
        Me.menuItem_department.Text = "Manufactor"
        '
        'item_lighting
        '
        Me.item_lighting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.item_movHeads, Me.item_strobes})
        Me.item_lighting.Name = "item_lighting"
        Me.item_lighting.Size = New System.Drawing.Size(180, 22)
        Me.item_lighting.Text = "&ClayPaky"
        '
        'item_movHeads
        '
        Me.item_movHeads.Name = "item_movHeads"
        Me.item_movHeads.Size = New System.Drawing.Size(180, 22)
        Me.item_movHeads.Text = "&Lamp"
        '
        'item_strobes
        '
        Me.item_strobes.Name = "item_strobes"
        Me.item_strobes.Size = New System.Drawing.Size(180, 22)
        Me.item_strobes.Text = "&LED"
        '
        'item_screen
        '
        Me.item_screen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.item_modules, Me.item_servers})
        Me.item_screen.Name = "item_screen"
        Me.item_screen.Size = New System.Drawing.Size(180, 22)
        Me.item_screen.Text = "&PR Lighting"
        '
        'item_modules
        '
        Me.item_modules.Name = "item_modules"
        Me.item_modules.Size = New System.Drawing.Size(104, 22)
        Me.item_modules.Text = "&Lamp"
        '
        'item_servers
        '
        Me.item_servers.Name = "item_servers"
        Me.item_servers.Size = New System.Drawing.Size(104, 22)
        Me.item_servers.Text = "&LED"
        '
        'item_commutation
        '
        Me.item_commutation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.item_pwrdistr, Me.item_comm})
        Me.item_commutation.Name = "item_commutation"
        Me.item_commutation.Size = New System.Drawing.Size(180, 22)
        Me.item_commutation.Text = "&LightSky"
        '
        'item_pwrdistr
        '
        Me.item_pwrdistr.Name = "item_pwrdistr"
        Me.item_pwrdistr.Size = New System.Drawing.Size(104, 22)
        Me.item_pwrdistr.Text = "&Lamp"
        '
        'item_comm
        '
        Me.item_comm.Name = "item_comm"
        Me.item_comm.Size = New System.Drawing.Size(104, 22)
        Me.item_comm.Text = "&LED"
        '
        'item_truss_and_motors
        '
        Me.item_truss_and_motors.Name = "item_truss_and_motors"
        Me.item_truss_and_motors.Size = New System.Drawing.Size(180, 22)
        Me.item_truss_and_motors.Text = "&Martin"
        '
        'item_construction
        '
        Me.item_construction.Name = "item_construction"
        Me.item_construction.Size = New System.Drawing.Size(180, 22)
        Me.item_construction.Text = "&StudioDue"
        '
        'item_sound
        '
        Me.item_sound.Name = "item_sound"
        Me.item_sound.Size = New System.Drawing.Size(180, 22)
        Me.item_sound.Text = "&Antari"
        '
        'MALightingToolStripMenuItem
        '
        Me.MALightingToolStripMenuItem.Name = "MALightingToolStripMenuItem"
        Me.MALightingToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MALightingToolStripMenuItem.Text = "&MALighting"
        '
        'LDRToolStripMenuItem
        '
        Me.LDRToolStripMenuItem.Name = "LDRToolStripMenuItem"
        Me.LDRToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LDRToolStripMenuItem.Text = "&LDR"
        '
        'ShowtecToolStripMenuItem
        '
        Me.ShowtecToolStripMenuItem.Name = "ShowtecToolStripMenuItem"
        Me.ShowtecToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowtecToolStripMenuItem.Text = "&Showtec"
        '
        'menuItem_company
        '
        Me.menuItem_company.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.item_belimlight, Me.item_PRLighting, Me.item_blackout, Me.item_vision, Me.item_stage, Me.item_summary, Me.OthersToolStripMenuItem})
        Me.menuItem_company.Name = "menuItem_company"
        Me.menuItem_company.Size = New System.Drawing.Size(74, 20)
        Me.menuItem_company.Text = "SpareParts"
        '
        'item_belimlight
        '
        Me.item_belimlight.Name = "item_belimlight"
        Me.item_belimlight.Size = New System.Drawing.Size(180, 22)
        Me.item_belimlight.Text = "&Power,high voltage"
        '
        'item_PRLighting
        '
        Me.item_PRLighting.Name = "item_PRLighting"
        Me.item_PRLighting.Size = New System.Drawing.Size(180, 22)
        Me.item_PRLighting.Text = "&Electronics"
        '
        'item_blackout
        '
        Me.item_blackout.Name = "item_blackout"
        Me.item_blackout.Size = New System.Drawing.Size(180, 22)
        Me.item_blackout.Text = "&Optics"
        '
        'item_vision
        '
        Me.item_vision.Name = "item_vision"
        Me.item_vision.Size = New System.Drawing.Size(180, 22)
        Me.item_vision.Text = "&Plastic"
        '
        'item_stage
        '
        Me.item_stage.Name = "item_stage"
        Me.item_stage.Size = New System.Drawing.Size(180, 22)
        Me.item_stage.Text = "&Mechanics"
        '
        'item_summary
        '
        Me.item_summary.Name = "item_summary"
        Me.item_summary.Size = New System.Drawing.Size(180, 22)
        Me.item_summary.Text = "&Fans"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OthersToolStripMenuItem.Text = "&Others"
        '
        'DGV_fxt
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGV_fxt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_fxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_fxt.Location = New System.Drawing.Point(3, 51)
        Me.DGV_fxt.Name = "DGV_fxt"
        Me.DGV_fxt.Size = New System.Drawing.Size(190, 402)
        Me.DGV_fxt.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGV_spare)
        Me.Panel1.Controls.Add(Me.DGV_fxt)
        Me.Panel1.Location = New System.Drawing.Point(12, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 473)
        Me.Panel1.TabIndex = 11
        '
        'DGV_spare
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGV_spare.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_spare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_spare.Location = New System.Drawing.Point(215, 51)
        Me.DGV_spare.Name = "DGV_spare"
        Me.DGV_spare.Size = New System.Drawing.Size(558, 402)
        Me.DGV_spare.TabIndex = 11
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 586)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "mainForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGV_fxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_spare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItem_department As ToolStripMenuItem
    Friend WithEvents item_lighting As ToolStripMenuItem
    Friend WithEvents item_movHeads As ToolStripMenuItem
    Friend WithEvents item_strobes As ToolStripMenuItem
    Friend WithEvents item_screen As ToolStripMenuItem
    Friend WithEvents item_modules As ToolStripMenuItem
    Friend WithEvents item_servers As ToolStripMenuItem
    Friend WithEvents item_commutation As ToolStripMenuItem
    Friend WithEvents item_pwrdistr As ToolStripMenuItem
    Friend WithEvents item_comm As ToolStripMenuItem
    Friend WithEvents item_truss_and_motors As ToolStripMenuItem
    Friend WithEvents item_construction As ToolStripMenuItem
    Friend WithEvents item_sound As ToolStripMenuItem
    Friend WithEvents MALightingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LDRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowtecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItem_company As ToolStripMenuItem
    Friend WithEvents item_belimlight As ToolStripMenuItem
    Friend WithEvents item_PRLighting As ToolStripMenuItem
    Friend WithEvents item_blackout As ToolStripMenuItem
    Friend WithEvents item_vision As ToolStripMenuItem
    Friend WithEvents item_stage As ToolStripMenuItem
    Friend WithEvents item_summary As ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FBD As FolderBrowserDialog
    Friend WithEvents DGV_fxt As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_spare As DataGridView
End Class
