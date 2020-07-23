<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spareForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGV_in = New System.Windows.Forms.DataGridView()
        Me.DGV_out = New System.Windows.Forms.DataGridView()
        Me.panel_spare = New System.Windows.Forms.Panel()
        Me.txt_id_action = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_fxt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_in, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_out, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_spare.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1177, 507)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGV_in)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(876, 481)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INcoming"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGV_out)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1169, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OUTgoing"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGV_in
        '
        Me.DGV_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_in.Location = New System.Drawing.Point(0, 0)
        Me.DGV_in.Name = "DGV_in"
        Me.DGV_in.Size = New System.Drawing.Size(1173, 481)
        Me.DGV_in.TabIndex = 0
        '
        'DGV_out
        '
        Me.DGV_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_out.Location = New System.Drawing.Point(0, 0)
        Me.DGV_out.Name = "DGV_out"
        Me.DGV_out.Size = New System.Drawing.Size(876, 481)
        Me.DGV_out.TabIndex = 1
        '
        'panel_spare
        '
        Me.panel_spare.Controls.Add(Me.Label5)
        Me.panel_spare.Controls.Add(Me.Label4)
        Me.panel_spare.Controls.Add(Me.cmb_fxt)
        Me.panel_spare.Controls.Add(Me.Label3)
        Me.panel_spare.Controls.Add(Me.Label2)
        Me.panel_spare.Controls.Add(Me.Label1)
        Me.panel_spare.Controls.Add(Me.ComboBox1)
        Me.panel_spare.Controls.Add(Me.DateTimePicker1)
        Me.panel_spare.Controls.Add(Me.TextBox12)
        Me.panel_spare.Controls.Add(Me.TextBox11)
        Me.panel_spare.Controls.Add(Me.TextBox10)
        Me.panel_spare.Controls.Add(Me.TextBox9)
        Me.panel_spare.Controls.Add(Me.TextBox8)
        Me.panel_spare.Controls.Add(Me.TextBox7)
        Me.panel_spare.Controls.Add(Me.TextBox6)
        Me.panel_spare.Controls.Add(Me.TextBox5)
        Me.panel_spare.Controls.Add(Me.txt_id_action)
        Me.panel_spare.Location = New System.Drawing.Point(4, 509)
        Me.panel_spare.Name = "panel_spare"
        Me.panel_spare.Size = New System.Drawing.Size(1173, 134)
        Me.panel_spare.TabIndex = 1
        '
        'txt_id_action
        '
        Me.txt_id_action.Location = New System.Drawing.Point(22, 35)
        Me.txt_id_action.Name = "txt_id_action"
        Me.txt_id_action.Size = New System.Drawing.Size(44, 20)
        Me.txt_id_action.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(390, 35)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(496, 35)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(168, 20)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(22, 70)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(140, 70)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(246, 70)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 8
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(352, 70)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 9
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(458, 70)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 10
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(564, 70)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(73, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"IN", "OUT"})
        Me.ComboBox1.Location = New System.Drawing.Point(188, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(68, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Action"
        '
        'cmb_fxt
        '
        Me.cmb_fxt.FormattingEnabled = True
        Me.cmb_fxt.Location = New System.Drawing.Point(263, 35)
        Me.cmb_fxt.Name = "cmb_fxt"
        Me.cmb_fxt.Size = New System.Drawing.Size(121, 21)
        Me.cmb_fxt.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fixture"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(390, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Manufactor"
        '
        'spareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 647)
        Me.Controls.Add(Me.panel_spare)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "spareForm"
        Me.Text = "spareForm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGV_in, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_out, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_spare.ResumeLayout(False)
        Me.panel_spare.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGV_in As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGV_out As DataGridView
    Friend WithEvents panel_spare As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_fxt As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txt_id_action As TextBox
End Class
