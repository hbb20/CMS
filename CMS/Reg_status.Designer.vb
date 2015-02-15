<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reg_status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reg_status))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtPkrFrm = New System.Windows.Forms.DateTimePicker()
        Me.dtPkrTo = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.panOverly = New System.Windows.Forms.Panel()
        Me.panContain = New System.Windows.Forms.Panel()
        Me.dgrvContct = New System.Windows.Forms.DataGridView()
        Me.dgrvDistr = New System.Windows.Forms.DataGridView()
        Me.dgrvState = New System.Windows.Forms.DataGridView()
        Me.dgrvEdu = New System.Windows.Forms.DataGridView()
        Me.dgrvQuol = New System.Windows.Forms.DataGridView()
        Me.btnGenrtRpt = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.panOverly.SuspendLayout()
        Me.panContain.SuspendLayout()
        CType(Me.dgrvContct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrvDistr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrvState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrvEdu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrvQuol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total :-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Male :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Female :-"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(101, 51)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 15)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "-"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.Location = New System.Drawing.Point(98, 23)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(14, 15)
        Me.lblMale.TabIndex = 5
        Me.lblMale.Text = "-"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.Location = New System.Drawing.Point(98, 55)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(14, 15)
        Me.lblFemale.TabIndex = 6
        Me.lblFemale.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblFemale)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblMale)
        Me.GroupBox1.Location = New System.Drawing.Point(644, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 88)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender Wise"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Select Interval"
        '
        'dtPkrFrm
        '
        Me.dtPkrFrm.CustomFormat = ""
        Me.dtPkrFrm.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrFrm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPkrFrm.Location = New System.Drawing.Point(239, 15)
        Me.dtPkrFrm.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtPkrFrm.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtPkrFrm.Name = "dtPkrFrm"
        Me.dtPkrFrm.Size = New System.Drawing.Size(123, 26)
        Me.dtPkrFrm.TabIndex = 1
        '
        'dtPkrTo
        '
        Me.dtPkrTo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPkrTo.Location = New System.Drawing.Point(401, 15)
        Me.dtPkrTo.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtPkrTo.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtPkrTo.Name = "dtPkrTo"
        Me.dtPkrTo.Size = New System.Drawing.Size(119, 26)
        Me.dtPkrTo.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(188, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 19)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "From"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(368, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 19)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "To"
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(539, 15)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 29
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'panOverly
        '
        Me.panOverly.Controls.Add(Me.Panel1)
        Me.panOverly.Controls.Add(Me.panContain)
        Me.panOverly.Controls.Add(Me.lblTotal)
        Me.panOverly.Controls.Add(Me.btnGo)
        Me.panOverly.Controls.Add(Me.Label2)
        Me.panOverly.Controls.Add(Me.GroupBox1)
        Me.panOverly.Controls.Add(Me.Label18)
        Me.panOverly.Controls.Add(Me.Label17)
        Me.panOverly.Controls.Add(Me.dtPkrFrm)
        Me.panOverly.Controls.Add(Me.dtPkrTo)
        Me.panOverly.Controls.Add(Me.Label8)
        Me.panOverly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panOverly.Location = New System.Drawing.Point(0, 0)
        Me.panOverly.Name = "panOverly"
        Me.panOverly.Size = New System.Drawing.Size(1224, 692)
        Me.panOverly.TabIndex = 30
        '
        'panContain
        '
        Me.panContain.AutoScroll = True
        Me.panContain.Controls.Add(Me.dgrvContct)
        Me.panContain.Controls.Add(Me.dgrvDistr)
        Me.panContain.Controls.Add(Me.dgrvState)
        Me.panContain.Controls.Add(Me.dgrvEdu)
        Me.panContain.Controls.Add(Me.dgrvQuol)
        Me.panContain.Location = New System.Drawing.Point(3, 145)
        Me.panContain.Name = "panContain"
        Me.panContain.Size = New System.Drawing.Size(1166, 465)
        Me.panContain.TabIndex = 30
        '
        'dgrvContct
        '
        Me.dgrvContct.AllowUserToAddRows = False
        Me.dgrvContct.AllowUserToDeleteRows = False
        Me.dgrvContct.AllowUserToResizeRows = False
        Me.dgrvContct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrvContct.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrvContct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrvContct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrvContct.Location = New System.Drawing.Point(1027, 3)
        Me.dgrvContct.Name = "dgrvContct"
        Me.dgrvContct.ReadOnly = True
        Me.dgrvContct.RowHeadersVisible = False
        Me.dgrvContct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvContct.Size = New System.Drawing.Size(250, 359)
        Me.dgrvContct.TabIndex = 4
        '
        'dgrvDistr
        '
        Me.dgrvDistr.AllowUserToAddRows = False
        Me.dgrvDistr.AllowUserToDeleteRows = False
        Me.dgrvDistr.AllowUserToResizeRows = False
        Me.dgrvDistr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrvDistr.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrvDistr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrvDistr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrvDistr.Location = New System.Drawing.Point(771, 4)
        Me.dgrvDistr.Name = "dgrvDistr"
        Me.dgrvDistr.ReadOnly = True
        Me.dgrvDistr.RowHeadersVisible = False
        Me.dgrvDistr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvDistr.Size = New System.Drawing.Size(250, 359)
        Me.dgrvDistr.TabIndex = 3
        '
        'dgrvState
        '
        Me.dgrvState.AllowUserToAddRows = False
        Me.dgrvState.AllowUserToDeleteRows = False
        Me.dgrvState.AllowUserToResizeRows = False
        Me.dgrvState.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrvState.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrvState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrvState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrvState.Location = New System.Drawing.Point(515, 4)
        Me.dgrvState.Name = "dgrvState"
        Me.dgrvState.ReadOnly = True
        Me.dgrvState.RowHeadersVisible = False
        Me.dgrvState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvState.Size = New System.Drawing.Size(250, 359)
        Me.dgrvState.TabIndex = 2
        '
        'dgrvEdu
        '
        Me.dgrvEdu.AllowUserToAddRows = False
        Me.dgrvEdu.AllowUserToDeleteRows = False
        Me.dgrvEdu.AllowUserToResizeRows = False
        Me.dgrvEdu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrvEdu.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrvEdu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrvEdu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrvEdu.Location = New System.Drawing.Point(3, 4)
        Me.dgrvEdu.Name = "dgrvEdu"
        Me.dgrvEdu.ReadOnly = True
        Me.dgrvEdu.RowHeadersVisible = False
        Me.dgrvEdu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvEdu.Size = New System.Drawing.Size(250, 359)
        Me.dgrvEdu.TabIndex = 0
        '
        'dgrvQuol
        '
        Me.dgrvQuol.AllowUserToAddRows = False
        Me.dgrvQuol.AllowUserToDeleteRows = False
        Me.dgrvQuol.AllowUserToResizeRows = False
        Me.dgrvQuol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrvQuol.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrvQuol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrvQuol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrvQuol.Location = New System.Drawing.Point(259, 4)
        Me.dgrvQuol.Name = "dgrvQuol"
        Me.dgrvQuol.ReadOnly = True
        Me.dgrvQuol.RowHeadersVisible = False
        Me.dgrvQuol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvQuol.Size = New System.Drawing.Size(250, 359)
        Me.dgrvQuol.TabIndex = 1
        '
        'btnGenrtRpt
        '
        Me.btnGenrtRpt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGenrtRpt.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenrtRpt.Location = New System.Drawing.Point(783, 30)
        Me.btnGenrtRpt.Name = "btnGenrtRpt"
        Me.btnGenrtRpt.Size = New System.Drawing.Size(167, 34)
        Me.btnGenrtRpt.TabIndex = 2
        Me.btnGenrtRpt.Text = "Generate Report"
        Me.btnGenrtRpt.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGenrtRpt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 616)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1224, 76)
        Me.Panel1.TabIndex = 31
        '
        'Reg_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 692)
        Me.Controls.Add(Me.panOverly)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reg_status"
        Me.Text = "Registration Status"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panOverly.ResumeLayout(False)
        Me.panOverly.PerformLayout()
        Me.panContain.ResumeLayout(False)
        CType(Me.dgrvContct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrvDistr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrvState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrvEdu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrvQuol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtPkrFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPkrTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents panOverly As System.Windows.Forms.Panel
    Friend WithEvents dgrvEdu As System.Windows.Forms.DataGridView
    Friend WithEvents dgrvQuol As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenrtRpt As System.Windows.Forms.Button
    Friend WithEvents panContain As System.Windows.Forms.Panel
    Friend WithEvents dgrvState As System.Windows.Forms.DataGridView
    Friend WithEvents dgrvDistr As System.Windows.Forms.DataGridView
    Friend WithEvents dgrvContct As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
