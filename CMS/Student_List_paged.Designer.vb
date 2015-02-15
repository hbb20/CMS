<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_List_paged
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnGo = New CMS.UbuntuButtonGray()
        Me.lblSlctd = New System.Windows.Forms.Label()
        Me.lblDisplayTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSlctAl = New CMS.UbuntuButtonGray()
        Me.btnSearch = New CMS.UbuntuButtonGray()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.cmbDistr = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkboxReg = New System.Windows.Forms.CheckBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEdu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCntry = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dTimepik = New System.Windows.Forms.DateTimePicker()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgrvStdnt = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.editInInputForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.examProgress = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLastPage = New System.Windows.Forms.Button()
        Me.txtDisplayPageNo = New System.Windows.Forms.TextBox()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.btnPreviousPage = New System.Windows.Forms.Button()
        Me.btnFirstPage = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrvStdnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.Transparent
        Me.btnGo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnGo.Location = New System.Drawing.Point(540, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(146, 24)
        Me.btnGo.TabIndex = 29
        Me.btnGo.Text = "Show All Records"
        '
        'lblSlctd
        '
        Me.lblSlctd.AutoSize = True
        Me.lblSlctd.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlctd.Location = New System.Drawing.Point(982, 75)
        Me.lblSlctd.Name = "lblSlctd"
        Me.lblSlctd.Size = New System.Drawing.Size(66, 15)
        Me.lblSlctd.TabIndex = 69
        Me.lblSlctd.Text = "Selected :- "
        '
        'lblDisplayTotal
        '
        Me.lblDisplayTotal.AutoSize = True
        Me.lblDisplayTotal.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayTotal.Location = New System.Drawing.Point(982, 51)
        Me.lblDisplayTotal.Name = "lblDisplayTotal"
        Me.lblDisplayTotal.Size = New System.Drawing.Size(118, 15)
        Me.lblDisplayTotal.TabIndex = 68
        Me.lblDisplayTotal.Text = "Displaying Results : -"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(700, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 15)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Or By "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSlctd)
        Me.GroupBox1.Controls.Add(Me.lblDisplayTotal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnSlctAl)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnGenerate)
        Me.GroupBox1.Controls.Add(Me.cmbDistr)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ChkboxReg)
        Me.GroupBox1.Controls.Add(Me.txtAdress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEdu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbCntry)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbState)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbCity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dTimepik)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1282, 139)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Student"
        '
        'btnSlctAl
        '
        Me.btnSlctAl.BackColor = System.Drawing.Color.Transparent
        Me.btnSlctAl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSlctAl.Location = New System.Drawing.Point(1159, 100)
        Me.btnSlctAl.Name = "btnSlctAl"
        Me.btnSlctAl.Size = New System.Drawing.Size(88, 25)
        Me.btnSlctAl.TabIndex = 66
        Me.btnSlctAl.Text = "Select All"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(704, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 33)
        Me.btnSearch.TabIndex = 65
        Me.btnSearch.Text = "Search"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnGenerate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(985, 101)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(168, 25)
        Me.btnGenerate.TabIndex = 64
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'cmbDistr
        '
        Me.cmbDistr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistr.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDistr.FormattingEnabled = True
        Me.cmbDistr.Items.AddRange(New Object() {"सर्वं"})
        Me.cmbDistr.Location = New System.Drawing.Point(534, 95)
        Me.cmbDistr.Name = "cmbDistr"
        Me.cmbDistr.Size = New System.Drawing.Size(150, 34)
        Me.cmbDistr.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(532, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "District :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(1021, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Enter Criterian in Textbox then Hit seaarch to search"
        '
        'ChkboxReg
        '
        Me.ChkboxReg.AutoSize = True
        Me.ChkboxReg.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkboxReg.Location = New System.Drawing.Point(748, 83)
        Me.ChkboxReg.Name = "ChkboxReg"
        Me.ChkboxReg.Size = New System.Drawing.Size(106, 17)
        Me.ChkboxReg.TabIndex = 60
        Me.ChkboxReg.Text = "Reg Date :"
        Me.ChkboxReg.UseVisualStyleBackColor = True
        '
        'txtAdress
        '
        Me.txtAdress.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdress.Location = New System.Drawing.Point(178, 32)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(167, 33)
        Me.txtAdress.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Address :"
        '
        'txtQual
        '
        Me.txtQual.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQual.Location = New System.Drawing.Point(179, 96)
        Me.txtQual.Name = "txtQual"
        Me.txtQual.Size = New System.Drawing.Size(167, 33)
        Me.txtQual.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Qualification :"
        '
        'txtEdu
        '
        Me.txtEdu.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdu.Location = New System.Drawing.Point(6, 95)
        Me.txtEdu.Name = "txtEdu"
        Me.txtEdu.Size = New System.Drawing.Size(167, 33)
        Me.txtEdu.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Education :"
        '
        'cmbCntry
        '
        Me.cmbCntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCntry.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCntry.FormattingEnabled = True
        Me.cmbCntry.Items.AddRange(New Object() {"सर्वं"})
        Me.cmbCntry.Location = New System.Drawing.Point(359, 96)
        Me.cmbCntry.Name = "cmbCntry"
        Me.cmbCntry.Size = New System.Drawing.Size(150, 34)
        Me.cmbCntry.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(356, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "City:"
        '
        'cmbState
        '
        Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbState.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"सर्वं"})
        Me.cmbState.Location = New System.Drawing.Point(534, 32)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(150, 34)
        Me.cmbState.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(531, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "State :"
        '
        'cmbCity
        '
        Me.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCity.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Items.AddRange(New Object() {"सर्वं"})
        Me.cmbCity.Location = New System.Drawing.Point(359, 32)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(150, 34)
        Me.cmbCity.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Country :"
        '
        'dTimepik
        '
        Me.dTimepik.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dTimepik.Location = New System.Drawing.Point(704, 109)
        Me.dTimepik.Name = "dTimepik"
        Me.dTimepik.Size = New System.Drawing.Size(167, 20)
        Me.dTimepik.TabIndex = 8
        Me.dTimepik.Value = New Date(2014, 1, 1, 9, 6, 0, 0)
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(6, 32)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(167, 33)
        Me.txtFullName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name : (contents)"
        '
        'dgrvStdnt
        '
        Me.dgrvStdnt.AllowUserToAddRows = False
        Me.dgrvStdnt.AllowUserToDeleteRows = False
        Me.dgrvStdnt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgrvStdnt.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgrvStdnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrvStdnt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgrvStdnt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrvStdnt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrvStdnt.ColumnHeadersHeight = 30
        Me.dgrvStdnt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgrvStdnt.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrvStdnt.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgrvStdnt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgrvStdnt.Location = New System.Drawing.Point(0, 0)
        Me.dgrvStdnt.MultiSelect = False
        Me.dgrvStdnt.Name = "dgrvStdnt"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrvStdnt.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgrvStdnt.RowHeadersVisible = False
        Me.dgrvStdnt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvStdnt.Size = New System.Drawing.Size(1312, 420)
        Me.dgrvStdnt.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = "Regn ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Full Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Address"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "City"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "District"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "State"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 140
        '
        'Column7
        '
        Me.Column7.HeaderText = "B_date"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 110
        '
        'Column8
        '
        Me.Column8.HeaderText = "Email"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 120
        '
        'Column9
        '
        Me.Column9.HeaderText = "Contact No"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 110
        '
        'Column10
        '
        Me.Column10.HeaderText = "Regn Date"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 120
        '
        'Column11
        '
        Me.Column11.HeaderText = "Education"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 140
        '
        'Column12
        '
        Me.Column12.HeaderText = "Qualification"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 140
        '
        'Column13
        '
        Me.Column13.HeaderText = "ContactID"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 70
        '
        'Column14
        '
        Me.Column14.HeaderText = "AddToReport"
        Me.Column14.Name = "Column14"
        Me.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editInInputForm, Me.examProgress})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 48)
        '
        'editInInputForm
        '
        Me.editInInputForm.Name = "editInInputForm"
        Me.editInInputForm.Size = New System.Drawing.Size(178, 22)
        Me.editInInputForm.Text = "Edit In Input Form ?"
        '
        'examProgress
        '
        Me.examProgress.Name = "examProgress"
        Me.examProgress.Size = New System.Drawing.Size(178, 22)
        Me.examProgress.Text = "View Exam Progress"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1288, 145)
        Me.Panel1.TabIndex = 27
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1312, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'btnLastPage
        '
        Me.btnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLastPage.Location = New System.Drawing.Point(854, 9)
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(75, 23)
        Me.btnLastPage.TabIndex = 88
        Me.btnLastPage.Text = "&Last"
        Me.btnLastPage.UseVisualStyleBackColor = True
        '
        'txtDisplayPageNo
        '
        Me.txtDisplayPageNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDisplayPageNo.Location = New System.Drawing.Point(661, 9)
        Me.txtDisplayPageNo.Name = "txtDisplayPageNo"
        Me.txtDisplayPageNo.Size = New System.Drawing.Size(100, 20)
        Me.txtDisplayPageNo.TabIndex = 89
        '
        'btnNextPage
        '
        Me.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNextPage.Location = New System.Drawing.Point(773, 9)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(75, 23)
        Me.btnNextPage.TabIndex = 87
        Me.btnNextPage.Text = "&Next"
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPreviousPage.Location = New System.Drawing.Point(579, 9)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(75, 23)
        Me.btnPreviousPage.TabIndex = 86
        Me.btnPreviousPage.Text = "&Previous"
        Me.btnPreviousPage.UseVisualStyleBackColor = True
        '
        'btnFirstPage
        '
        Me.btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFirstPage.Location = New System.Drawing.Point(498, 9)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(75, 23)
        Me.btnFirstPage.TabIndex = 85
        Me.btnFirstPage.Text = "&First"
        Me.btnFirstPage.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPreviousPage)
        Me.Panel2.Controls.Add(Me.btnFirstPage)
        Me.Panel2.Controls.Add(Me.btnLastPage)
        Me.Panel2.Controls.Add(Me.btnNextPage)
        Me.Panel2.Controls.Add(Me.txtDisplayPageNo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 619)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1312, 43)
        Me.Panel2.TabIndex = 90
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgrvStdnt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 199)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1312, 420)
        Me.Panel3.TabIndex = 91
        '
        'Student_List_paged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 662)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Student_List_paged"
        Me.Text = "Student_List_paged"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrvStdnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As CMS.UbuntuButtonGray
    Friend WithEvents lblSlctd As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTotal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSlctAl As CMS.UbuntuButtonGray
    Friend WithEvents btnSearch As CMS.UbuntuButtonGray
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents cmbDistr As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChkboxReg As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQual As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEdu As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCntry As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dTimepik As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgrvStdnt As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents editInInputForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents examProgress As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLastPage As System.Windows.Forms.Button
    Friend WithEvents btnNextPage As System.Windows.Forms.Button
    Friend WithEvents btnPreviousPage As System.Windows.Forms.Button
    Friend WithEvents btnFirstPage As System.Windows.Forms.Button
    Friend WithEvents txtDisplayPageNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
