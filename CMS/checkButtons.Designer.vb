<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkButtons
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
        Me.chkAddr = New System.Windows.Forms.CheckBox()
        Me.chkQuol = New System.Windows.Forms.CheckBox()
        Me.chkEduc = New System.Windows.Forms.CheckBox()
        Me.chkBdate = New System.Windows.Forms.CheckBox()
        Me.chkContctNo = New System.Windows.Forms.CheckBox()
        Me.chkRgnDate = New System.Windows.Forms.CheckBox()
        Me.chkContctId = New System.Windows.Forms.CheckBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkAddr
        '
        Me.chkAddr.AutoSize = True
        Me.chkAddr.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddr.Location = New System.Drawing.Point(12, 12)
        Me.chkAddr.Name = "chkAddr"
        Me.chkAddr.Size = New System.Drawing.Size(91, 23)
        Me.chkAddr.TabIndex = 0
        Me.chkAddr.Text = "Address"
        Me.chkAddr.UseVisualStyleBackColor = True
        '
        'chkQuol
        '
        Me.chkQuol.AutoSize = True
        Me.chkQuol.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuol.Location = New System.Drawing.Point(12, 41)
        Me.chkQuol.Name = "chkQuol"
        Me.chkQuol.Size = New System.Drawing.Size(145, 23)
        Me.chkQuol.TabIndex = 2
        Me.chkQuol.Text = "Qualification"
        Me.chkQuol.UseVisualStyleBackColor = True
        '
        'chkEduc
        '
        Me.chkEduc.AutoSize = True
        Me.chkEduc.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEduc.Location = New System.Drawing.Point(12, 70)
        Me.chkEduc.Name = "chkEduc"
        Me.chkEduc.Size = New System.Drawing.Size(109, 23)
        Me.chkEduc.TabIndex = 4
        Me.chkEduc.Text = "Education"
        Me.chkEduc.UseVisualStyleBackColor = True
        '
        'chkBdate
        '
        Me.chkBdate.AutoSize = True
        Me.chkBdate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBdate.Location = New System.Drawing.Point(179, 12)
        Me.chkBdate.Name = "chkBdate"
        Me.chkBdate.Size = New System.Drawing.Size(109, 23)
        Me.chkBdate.TabIndex = 1
        Me.chkBdate.Text = "Birthdate"
        Me.chkBdate.UseVisualStyleBackColor = True
        '
        'chkContctNo
        '
        Me.chkContctNo.AutoSize = True
        Me.chkContctNo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContctNo.Location = New System.Drawing.Point(179, 41)
        Me.chkContctNo.Name = "chkContctNo"
        Me.chkContctNo.Size = New System.Drawing.Size(127, 23)
        Me.chkContctNo.TabIndex = 3
        Me.chkContctNo.Text = "Contact No."
        Me.chkContctNo.UseVisualStyleBackColor = True
        '
        'chkRgnDate
        '
        Me.chkRgnDate.AutoSize = True
        Me.chkRgnDate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRgnDate.Location = New System.Drawing.Point(12, 99)
        Me.chkRgnDate.Name = "chkRgnDate"
        Me.chkRgnDate.Size = New System.Drawing.Size(118, 23)
        Me.chkRgnDate.TabIndex = 6
        Me.chkRgnDate.Text = "Regn. Date"
        Me.chkRgnDate.UseVisualStyleBackColor = True
        '
        'chkContctId
        '
        Me.chkContctId.AutoSize = True
        Me.chkContctId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContctId.Location = New System.Drawing.Point(179, 70)
        Me.chkContctId.Name = "chkContctId"
        Me.chkContctId.Size = New System.Drawing.Size(118, 23)
        Me.chkContctId.TabIndex = 5
        Me.chkContctId.Text = "Contact Id"
        Me.chkContctId.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(179, 99)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(91, 29)
        Me.btnCheck.TabIndex = 7
        Me.btnCheck.Text = "Go"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'checkButtons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 142)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.chkContctId)
        Me.Controls.Add(Me.chkRgnDate)
        Me.Controls.Add(Me.chkContctNo)
        Me.Controls.Add(Me.chkBdate)
        Me.Controls.Add(Me.chkEduc)
        Me.Controls.Add(Me.chkQuol)
        Me.Controls.Add(Me.chkAddr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "checkButtons"
        Me.Text = "Show Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAddr As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuol As System.Windows.Forms.CheckBox
    Friend WithEvents chkEduc As System.Windows.Forms.CheckBox
    Friend WithEvents chkBdate As System.Windows.Forms.CheckBox
    Friend WithEvents chkContctNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkRgnDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkContctId As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
End Class
