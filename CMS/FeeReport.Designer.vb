<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeeReport))
        Me.dgrvFee = New System.Windows.Forms.DataGridView()
        CType(Me.dgrvFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrvFee
        '
        Me.dgrvFee.AllowUserToAddRows = False
        Me.dgrvFee.AllowUserToDeleteRows = False
        Me.dgrvFee.AllowUserToResizeRows = False
        Me.dgrvFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrvFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrvFee.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgrvFee.Location = New System.Drawing.Point(0, 162)
        Me.dgrvFee.MultiSelect = False
        Me.dgrvFee.Name = "dgrvFee"
        Me.dgrvFee.ReadOnly = True
        Me.dgrvFee.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrvFee.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrvFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvFee.Size = New System.Drawing.Size(1344, 520)
        Me.dgrvFee.TabIndex = 0
        '
        'FeeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1344, 682)
        Me.Controls.Add(Me.dgrvFee)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FeeReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeeReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgrvFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgrvFee As System.Windows.Forms.DataGridView
End Class
