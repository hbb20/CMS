<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCity))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistrictListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StateListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActvyItms = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditEducationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuolificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CityListToolStripMenuItem, Me.DistrictListToolStripMenuItem, Me.StateListToolStripMenuItem, Me.CountryListToolStripMenuItem, Me.ActvyItms, Me.EditEducationToolStripMenuItem, Me.QuolificationToolStripMenuItem, Me.MediumToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CityListToolStripMenuItem
        '
        Me.CityListToolStripMenuItem.Name = "CityListToolStripMenuItem"
        Me.CityListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CityListToolStripMenuItem.Text = "&City List"
        '
        'DistrictListToolStripMenuItem
        '
        Me.DistrictListToolStripMenuItem.Name = "DistrictListToolStripMenuItem"
        Me.DistrictListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DistrictListToolStripMenuItem.Text = "&District List"
        '
        'StateListToolStripMenuItem
        '
        Me.StateListToolStripMenuItem.Name = "StateListToolStripMenuItem"
        Me.StateListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StateListToolStripMenuItem.Text = "&State List"
        '
        'CountryListToolStripMenuItem
        '
        Me.CountryListToolStripMenuItem.Name = "CountryListToolStripMenuItem"
        Me.CountryListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CountryListToolStripMenuItem.Text = "&Country List"
        '
        'ActvyItms
        '
        Me.ActvyItms.Name = "ActvyItms"
        Me.ActvyItms.Size = New System.Drawing.Size(152, 22)
        Me.ActvyItms.Text = "Activity"
        '
        'EditEducationToolStripMenuItem
        '
        Me.EditEducationToolStripMenuItem.Name = "EditEducationToolStripMenuItem"
        Me.EditEducationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditEducationToolStripMenuItem.Text = "&Education List"
        '
        'QuolificationToolStripMenuItem
        '
        Me.QuolificationToolStripMenuItem.Name = "QuolificationToolStripMenuItem"
        Me.QuolificationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuolificationToolStripMenuItem.Text = "&Quolification"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.DiscardToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'DiscardToolStripMenuItem
        '
        Me.DiscardToolStripMenuItem.Name = "DiscardToolStripMenuItem"
        Me.DiscardToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DiscardToolStripMenuItem.Text = "&Discard"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHangeFontToolStripMenuItem})
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'CHangeFontToolStripMenuItem
        '
        Me.CHangeFontToolStripMenuItem.Name = "CHangeFontToolStripMenuItem"
        Me.CHangeFontToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CHangeFontToolStripMenuItem.Text = "&Change Font"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(576, 454)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MediumToolStripMenuItem.Text = "&Medium"
        '
        'EditCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 478)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "EditCity"
        Me.Text = "Edit List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CityListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DistrictListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StateListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountryListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiscardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHangeFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ActvyItms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditEducationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuolificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
