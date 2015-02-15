<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FollowUpReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FollowUpReport))
        Me.dgrvFoloup = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbExmPart1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAnsSheet = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtmQpapr = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCmnt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt5th = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt4th = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt3rd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt2nd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtImBkDispatch = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbExmPart2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRegnID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoUpdate = New System.Windows.Forms.RadioButton()
        Me.rdoInsrt = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLastPage = New System.Windows.Forms.Button()
        Me.txtDisplayPageNo = New System.Windows.Forms.TextBox()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.btnPreviousPage = New System.Windows.Forms.Button()
        Me.btnFirstPage = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtPkrBkFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtPkrBkTo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtPkrQpprTo = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtPkrQpprFrom = New System.Windows.Forms.DateTimePicker()
        Me.rdoBkDipatch = New System.Windows.Forms.CheckBox()
        Me.rdoExmPrt = New System.Windows.Forms.CheckBox()
        Me.rdoQppr = New System.Windows.Forms.CheckBox()
        CType(Me.dgrvFoloup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrvFoloup
        '
        Me.dgrvFoloup.AllowUserToAddRows = False
        Me.dgrvFoloup.AllowUserToDeleteRows = False
        Me.dgrvFoloup.AllowUserToResizeRows = False
        Me.dgrvFoloup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrvFoloup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrvFoloup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrvFoloup.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgrvFoloup.Location = New System.Drawing.Point(7, 3)
        Me.dgrvFoloup.MultiSelect = False
        Me.dgrvFoloup.Name = "dgrvFoloup"
        Me.dgrvFoloup.ReadOnly = True
        Me.dgrvFoloup.RowHeadersVisible = False
        Me.dgrvFoloup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvFoloup.Size = New System.Drawing.Size(1290, 431)
        Me.dgrvFoloup.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 97)
        Me.Panel1.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(874, 36)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(49, 56)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoBkDipatch)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.dtPkrBkTo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dtPkrBkFrom)
        Me.GroupBox2.Location = New System.Drawing.Point(158, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 70)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter 2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoExmPrt)
        Me.GroupBox1.Controls.Add(Me.cmbExmPart1)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 70)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter 1"
        '
        'cmbExmPart1
        '
        Me.cmbExmPart1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExmPart1.FormattingEnabled = True
        Me.cmbExmPart1.Items.AddRange(New Object() {"Part 1", "Part 2", "Part 3", "Part 4"})
        Me.cmbExmPart1.Location = New System.Drawing.Point(12, 38)
        Me.cmbExmPart1.Name = "cmbExmPart1"
        Me.cmbExmPart1.Size = New System.Drawing.Size(102, 23)
        Me.cmbExmPart1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Follow Up Short By :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtAnsSheet)
        Me.Panel2.Controls.Add(Me.btnGo)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.dtmQpapr)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtCmnt)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt5th)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txt4th)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt3rd)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt2nd)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dtImBkDispatch)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmbExmPart2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtRegnID)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.rdoUpdate)
        Me.Panel2.Controls.Add(Me.rdoInsrt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1290, 95)
        Me.Panel2.TabIndex = 2
        '
        'txtAnsSheet
        '
        Me.txtAnsSheet.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsSheet.Location = New System.Drawing.Point(1133, 45)
        Me.txtAnsSheet.Name = "txtAnsSheet"
        Me.txtAnsSheet.Size = New System.Drawing.Size(137, 23)
        Me.txtAnsSheet.TabIndex = 22
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(1136, 73)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(137, 22)
        Me.btnGo.TabIndex = 23
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1133, -3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 38)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "AnswerSheet Received"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtmQpapr
        '
        Me.dtmQpapr.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmQpapr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmQpapr.Location = New System.Drawing.Point(997, 47)
        Me.dtmQpapr.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtmQpapr.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtmQpapr.Name = "dtmQpapr"
        Me.dtmQpapr.Size = New System.Drawing.Size(130, 23)
        Me.dtmQpapr.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(994, -3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 40)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Question Paper Disptch Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCmnt
        '
        Me.txtCmnt.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmnt.Location = New System.Drawing.Point(854, 45)
        Me.txtCmnt.Multiline = True
        Me.txtCmnt.Name = "txtCmnt"
        Me.txtCmnt.Size = New System.Drawing.Size(137, 47)
        Me.txtCmnt.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(886, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Comment"
        '
        'txt5th
        '
        Me.txt5th.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5th.Location = New System.Drawing.Point(738, 45)
        Me.txt5th.Name = "txt5th"
        Me.txt5th.Size = New System.Drawing.Size(110, 23)
        Me.txt5th.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(752, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "5th Folloup"
        '
        'txt4th
        '
        Me.txt4th.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4th.Location = New System.Drawing.Point(622, 45)
        Me.txt4th.Name = "txt4th"
        Me.txt4th.Size = New System.Drawing.Size(110, 23)
        Me.txt4th.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(634, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "4th Folloup"
        '
        'txt3rd
        '
        Me.txt3rd.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3rd.Location = New System.Drawing.Point(506, 45)
        Me.txt3rd.Name = "txt3rd"
        Me.txt3rd.Size = New System.Drawing.Size(110, 23)
        Me.txt3rd.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(518, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "3rd Folloup"
        '
        'txt2nd
        '
        Me.txt2nd.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2nd.Location = New System.Drawing.Point(390, 45)
        Me.txt2nd.Name = "txt2nd"
        Me.txt2nd.Size = New System.Drawing.Size(110, 23)
        Me.txt2nd.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(404, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "2nd Folloup"
        '
        'dtImBkDispatch
        '
        Me.dtImBkDispatch.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtImBkDispatch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtImBkDispatch.Location = New System.Drawing.Point(245, 45)
        Me.dtImBkDispatch.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtImBkDispatch.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtImBkDispatch.Name = "dtImBkDispatch"
        Me.dtImBkDispatch.Size = New System.Drawing.Size(130, 23)
        Me.dtImBkDispatch.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(242, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Book Dispatch Date"
        '
        'cmbExmPart2
        '
        Me.cmbExmPart2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExmPart2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExmPart2.FormattingEnabled = True
        Me.cmbExmPart2.Items.AddRange(New Object() {"Part 1", "Part 2", "Part 3", "Part 4"})
        Me.cmbExmPart2.Location = New System.Drawing.Point(121, 47)
        Me.cmbExmPart2.Name = "cmbExmPart2"
        Me.cmbExmPart2.Size = New System.Drawing.Size(102, 23)
        Me.cmbExmPart2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Exam Part"
        '
        'txtRegnID
        '
        Me.txtRegnID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegnID.Location = New System.Drawing.Point(15, 47)
        Me.txtRegnID.Name = "txtRegnID"
        Me.txtRegnID.Size = New System.Drawing.Size(100, 23)
        Me.txtRegnID.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Regn ID"
        '
        'rdoUpdate
        '
        Me.rdoUpdate.AutoSize = True
        Me.rdoUpdate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoUpdate.Location = New System.Drawing.Point(182, 3)
        Me.rdoUpdate.Name = "rdoUpdate"
        Me.rdoUpdate.Size = New System.Drawing.Size(61, 17)
        Me.rdoUpdate.TabIndex = 2
        Me.rdoUpdate.Text = "UPDATE"
        Me.rdoUpdate.UseVisualStyleBackColor = True
        '
        'rdoInsrt
        '
        Me.rdoInsrt.AutoSize = True
        Me.rdoInsrt.Checked = True
        Me.rdoInsrt.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInsrt.Location = New System.Drawing.Point(115, 3)
        Me.rdoInsrt.Name = "rdoInsrt"
        Me.rdoInsrt.Size = New System.Drawing.Size(61, 17)
        Me.rdoInsrt.TabIndex = 1
        Me.rdoInsrt.TabStop = True
        Me.rdoInsrt.Text = "INSERT"
        Me.rdoInsrt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select Action :"
        '
        'btnLastPage
        '
        Me.btnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLastPage.Location = New System.Drawing.Point(737, 440)
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(75, 23)
        Me.btnLastPage.TabIndex = 88
        Me.btnLastPage.Text = "&Last"
        Me.btnLastPage.UseVisualStyleBackColor = True
        '
        'txtDisplayPageNo
        '
        Me.txtDisplayPageNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDisplayPageNo.Location = New System.Drawing.Point(544, 440)
        Me.txtDisplayPageNo.Name = "txtDisplayPageNo"
        Me.txtDisplayPageNo.Size = New System.Drawing.Size(100, 20)
        Me.txtDisplayPageNo.TabIndex = 89
        '
        'btnNextPage
        '
        Me.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNextPage.Location = New System.Drawing.Point(656, 440)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(75, 23)
        Me.btnNextPage.TabIndex = 87
        Me.btnNextPage.Text = "&Next"
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPreviousPage.Location = New System.Drawing.Point(462, 440)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(75, 23)
        Me.btnPreviousPage.TabIndex = 86
        Me.btnPreviousPage.Text = "&Previous"
        Me.btnPreviousPage.UseVisualStyleBackColor = True
        '
        'btnFirstPage
        '
        Me.btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFirstPage.Location = New System.Drawing.Point(381, 440)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(75, 23)
        Me.btnFirstPage.TabIndex = 85
        Me.btnFirstPage.Text = "&First"
        Me.btnFirstPage.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.dgrvFoloup)
        Me.Panel3.Controls.Add(Me.btnLastPage)
        Me.Panel3.Controls.Add(Me.txtDisplayPageNo)
        Me.Panel3.Controls.Add(Me.btnFirstPage)
        Me.Panel3.Controls.Add(Me.btnNextPage)
        Me.Panel3.Controls.Add(Me.btnPreviousPage)
        Me.Panel3.Location = New System.Drawing.Point(0, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1314, 466)
        Me.Panel3.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1314, 210)
        Me.Panel4.TabIndex = 90
        '
        'dtPkrBkFrom
        '
        Me.dtPkrBkFrom.CalendarFont = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrBkFrom.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrBkFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPkrBkFrom.Location = New System.Drawing.Point(58, 38)
        Me.dtPkrBkFrom.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtPkrBkFrom.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtPkrBkFrom.Name = "dtPkrBkFrom"
        Me.dtPkrBkFrom.Size = New System.Drawing.Size(119, 23)
        Me.dtPkrBkFrom.TabIndex = 5
        Me.dtPkrBkFrom.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "From :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(183, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 15)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "To :"
        '
        'dtPkrBkTo
        '
        Me.dtPkrBkTo.CalendarFont = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrBkTo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrBkTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPkrBkTo.Location = New System.Drawing.Point(220, 38)
        Me.dtPkrBkTo.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtPkrBkTo.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtPkrBkTo.Name = "dtPkrBkTo"
        Me.dtPkrBkTo.Size = New System.Drawing.Size(119, 23)
        Me.dtPkrBkTo.TabIndex = 7
        Me.dtPkrBkTo.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoQppr)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtPkrQpprTo)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.dtPkrQpprFrom)
        Me.GroupBox3.Location = New System.Drawing.Point(516, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 70)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter 3"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(183, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "To :"
        '
        'dtPkrQpprTo
        '
        Me.dtPkrQpprTo.CalendarFont = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrQpprTo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrQpprTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPkrQpprTo.Location = New System.Drawing.Point(220, 38)
        Me.dtPkrQpprTo.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtPkrQpprTo.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtPkrQpprTo.Name = "dtPkrQpprTo"
        Me.dtPkrQpprTo.Size = New System.Drawing.Size(119, 23)
        Me.dtPkrQpprTo.TabIndex = 7
        Me.dtPkrQpprTo.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 15)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "From :"
        '
        'dtPkrQpprFrom
        '
        Me.dtPkrQpprFrom.CalendarFont = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrQpprFrom.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrQpprFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPkrQpprFrom.Location = New System.Drawing.Point(58, 38)
        Me.dtPkrQpprFrom.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtPkrQpprFrom.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtPkrQpprFrom.Name = "dtPkrQpprFrom"
        Me.dtPkrQpprFrom.Size = New System.Drawing.Size(119, 23)
        Me.dtPkrQpprFrom.TabIndex = 5
        Me.dtPkrQpprFrom.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        '
        'rdoBkDipatch
        '
        Me.rdoBkDipatch.AutoSize = True
        Me.rdoBkDipatch.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBkDipatch.Location = New System.Drawing.Point(10, 17)
        Me.rdoBkDipatch.Name = "rdoBkDipatch"
        Me.rdoBkDipatch.Size = New System.Drawing.Size(208, 19)
        Me.rdoBkDipatch.TabIndex = 10
        Me.rdoBkDipatch.Text = "Book Dispatch Date Between"
        Me.rdoBkDipatch.UseVisualStyleBackColor = True
        '
        'rdoExmPrt
        '
        Me.rdoExmPrt.AutoSize = True
        Me.rdoExmPrt.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoExmPrt.Location = New System.Drawing.Point(11, 17)
        Me.rdoExmPrt.Name = "rdoExmPrt"
        Me.rdoExmPrt.Size = New System.Drawing.Size(103, 19)
        Me.rdoExmPrt.TabIndex = 11
        Me.rdoExmPrt.Text = "Exam Part :"
        Me.rdoExmPrt.UseVisualStyleBackColor = True
        '
        'rdoQppr
        '
        Me.rdoQppr.AutoSize = True
        Me.rdoQppr.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoQppr.Location = New System.Drawing.Point(15, 13)
        Me.rdoQppr.Name = "rdoQppr"
        Me.rdoQppr.Size = New System.Drawing.Size(278, 19)
        Me.rdoQppr.TabIndex = 11
        Me.rdoQppr.Text = "Question paper Dispatch Date Between"
        Me.rdoQppr.UseVisualStyleBackColor = True
        '
        'FollowUpReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 682)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FollowUpReport"
        Me.Text = "Follow Up Info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgrvFoloup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgrvFoloup As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbExmPart1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoUpdate As System.Windows.Forms.RadioButton
    Friend WithEvents rdoInsrt As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRegnID As System.Windows.Forms.TextBox
    Friend WithEvents cmbExmPart2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtImBkDispatch As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt2nd As System.Windows.Forms.TextBox
    Friend WithEvents txt5th As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt4th As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCmnt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtmQpapr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAnsSheet As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txt3rd As System.Windows.Forms.TextBox
    Friend WithEvents btnLastPage As System.Windows.Forms.Button
    Friend WithEvents txtDisplayPageNo As System.Windows.Forms.TextBox
    Friend WithEvents btnNextPage As System.Windows.Forms.Button
    Friend WithEvents btnPreviousPage As System.Windows.Forms.Button
    Friend WithEvents btnFirstPage As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtPkrBkFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtPkrBkTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtPkrQpprTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtPkrQpprFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdoBkDipatch As System.Windows.Forms.CheckBox
    Friend WithEvents rdoExmPrt As System.Windows.Forms.CheckBox
    Friend WithEvents rdoQppr As System.Windows.Forms.CheckBox
End Class
