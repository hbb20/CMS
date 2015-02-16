<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fee_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fee_Details))
        Me.cmbExmPrt = New System.Windows.Forms.ComboBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.grp3 = New System.Windows.Forms.GroupBox()
        Me.txtBnkNm = New System.Windows.Forms.TextBox()
        Me.lblBnkNm = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblregId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtPkrChkDat = New System.Windows.Forms.DateTimePicker()
        Me.lblDat = New System.Windows.Forms.Label()
        Me.cmbPayTyp = New System.Windows.Forms.ComboBox()
        Me.txtChqDDno = New System.Windows.Forms.TextBox()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.lblDrNo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRcptNo = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtRgnId = New System.Windows.Forms.TextBox()
        Me.grp3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbExmPrt
        '
        Me.cmbExmPrt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExmPrt.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExmPrt.FormattingEnabled = True
        Me.cmbExmPrt.Items.AddRange(New Object() {"First Part (प्रवेशः)", "Second Part (परिचयः)", "Third Part (शिक्षा)", "Fourth Part​ (कोविदः)"})
        Me.cmbExmPrt.Location = New System.Drawing.Point(9, 68)
        Me.cmbExmPrt.Name = "cmbExmPrt"
        Me.cmbExmPrt.Size = New System.Drawing.Size(151, 21)
        Me.cmbExmPrt.TabIndex = 120
        '
        'Label114
        '
        Me.Label114.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(32, 9)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(113, 56)
        Me.Label114.TabIndex = 121
        Me.Label114.Text = "Select Exam Part"
        Me.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp3
        '
        Me.grp3.Controls.Add(Me.txtRgnId)
        Me.grp3.Controls.Add(Me.txtBnkNm)
        Me.grp3.Controls.Add(Me.lblBnkNm)
        Me.grp3.Controls.Add(Me.btnGo)
        Me.grp3.Controls.Add(Me.lblregId)
        Me.grp3.Controls.Add(Me.Label1)
        Me.grp3.Controls.Add(Me.dtPkrChkDat)
        Me.grp3.Controls.Add(Me.lblDat)
        Me.grp3.Controls.Add(Me.cmbPayTyp)
        Me.grp3.Controls.Add(Me.txtChqDDno)
        Me.grp3.Controls.Add(Me.txtFee)
        Me.grp3.Controls.Add(Me.lblDrNo)
        Me.grp3.Controls.Add(Me.Label8)
        Me.grp3.Controls.Add(Me.Label9)
        Me.grp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp3.Location = New System.Drawing.Point(166, 12)
        Me.grp3.Name = "grp3"
        Me.grp3.Size = New System.Drawing.Size(426, 217)
        Me.grp3.TabIndex = 48
        Me.grp3.TabStop = False
        Me.grp3.Text = "Fees Details"
        '
        'txtBnkNm
        '
        Me.txtBnkNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBnkNm.Location = New System.Drawing.Point(164, 181)
        Me.txtBnkNm.Name = "txtBnkNm"
        Me.txtBnkNm.Size = New System.Drawing.Size(212, 24)
        Me.txtBnkNm.TabIndex = 48
        Me.txtBnkNm.Visible = False
        '
        'lblBnkNm
        '
        Me.lblBnkNm.AutoSize = True
        Me.lblBnkNm.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBnkNm.Location = New System.Drawing.Point(23, 181)
        Me.lblBnkNm.Name = "lblBnkNm"
        Me.lblBnkNm.Size = New System.Drawing.Size(95, 13)
        Me.lblBnkNm.TabIndex = 49
        Me.lblBnkNm.Text = "Bank Name :"
        '
        'btnGo
        '
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGo.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(382, 123)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(38, 55)
        Me.btnGo.TabIndex = 5
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblregId
        '
        Me.lblregId.AutoSize = True
        Me.lblregId.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregId.Location = New System.Drawing.Point(161, 33)
        Me.lblregId.Name = "lblregId"
        Me.lblregId.Size = New System.Drawing.Size(15, 13)
        Me.lblregId.TabIndex = 47
        Me.lblregId.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Reg. Id"
        '
        'dtPkrChkDat
        '
        Me.dtPkrChkDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPkrChkDat.Location = New System.Drawing.Point(164, 121)
        Me.dtPkrChkDat.Name = "dtPkrChkDat"
        Me.dtPkrChkDat.Size = New System.Drawing.Size(166, 24)
        Me.dtPkrChkDat.TabIndex = 3
        Me.dtPkrChkDat.Value = New Date(2014, 1, 1, 10, 9, 0, 0)
        '
        'lblDat
        '
        Me.lblDat.AutoSize = True
        Me.lblDat.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDat.Location = New System.Drawing.Point(23, 123)
        Me.lblDat.Name = "lblDat"
        Me.lblDat.Size = New System.Drawing.Size(127, 13)
        Me.lblDat.TabIndex = 44
        Me.lblDat.Text = "Date on Cheque:"
        '
        'cmbPayTyp
        '
        Me.cmbPayTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayTyp.FormattingEnabled = True
        Me.cmbPayTyp.Items.AddRange(New Object() {"Cash", "Cheque", "Draft", "NEFT"})
        Me.cmbPayTyp.Location = New System.Drawing.Point(164, 87)
        Me.cmbPayTyp.Name = "cmbPayTyp"
        Me.cmbPayTyp.Size = New System.Drawing.Size(212, 26)
        Me.cmbPayTyp.TabIndex = 2
        '
        'txtChqDDno
        '
        Me.txtChqDDno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqDDno.Location = New System.Drawing.Point(164, 151)
        Me.txtChqDDno.Name = "txtChqDDno"
        Me.txtChqDDno.Size = New System.Drawing.Size(212, 24)
        Me.txtChqDDno.TabIndex = 4
        '
        'txtFee
        '
        Me.txtFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.Location = New System.Drawing.Point(164, 55)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(212, 24)
        Me.txtFee.TabIndex = 1
        '
        'lblDrNo
        '
        Me.lblDrNo.AutoSize = True
        Me.lblDrNo.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrNo.Location = New System.Drawing.Point(23, 151)
        Me.lblDrNo.Name = "lblDrNo"
        Me.lblDrNo.Size = New System.Drawing.Size(135, 13)
        Me.lblDrNo.TabIndex = 9
        Me.lblDrNo.Text = "Cheque/Draft no:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fees Amount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Payment Mode:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 38)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Receipt No."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRcptNo
        '
        Me.txtRcptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRcptNo.Location = New System.Drawing.Point(22, 157)
        Me.txtRcptNo.Name = "txtRcptNo"
        Me.txtRcptNo.Size = New System.Drawing.Size(120, 24)
        Me.txtRcptNo.TabIndex = 48
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(467, 235)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(125, 23)
        Me.btnGenerate.TabIndex = 123
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtRgnId
        '
        Me.txtRgnId.Location = New System.Drawing.Point(220, 22)
        Me.txtRgnId.Name = "txtRgnId"
        Me.txtRgnId.Size = New System.Drawing.Size(133, 24)
        Me.txtRgnId.TabIndex = 50
        '
        'Fee_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 267)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtRcptNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grp3)
        Me.Controls.Add(Me.Label114)
        Me.Controls.Add(Me.cmbExmPrt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fee_Details"
        Me.Text = "Fee_Details"
        Me.grp3.ResumeLayout(False)
        Me.grp3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbExmPrt As System.Windows.Forms.ComboBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents grp3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtPkrChkDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDat As System.Windows.Forms.Label
    Friend WithEvents cmbPayTyp As System.Windows.Forms.ComboBox
    Friend WithEvents txtChqDDno As System.Windows.Forms.TextBox
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents lblDrNo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblregId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRcptNo As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtBnkNm As System.Windows.Forms.TextBox
    Friend WithEvents lblBnkNm As System.Windows.Forms.Label
    Friend WithEvents txtRgnId As System.Windows.Forms.TextBox
End Class
