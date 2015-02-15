Public Class Startt_Up

    Dim _sec As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        Timer1.Enabled = True
    End Sub
    Public Sub New()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        InitializeComponent()
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim gfx As Drawing.Graphics = e.Graphics
        gfx.DrawImage(My.Resources.Res_prg.init_image2, New Rectangle(0, 0, Me.Width, Me.Height))
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _sec += 1
        If _sec = 3 Then
            Input_Form.Show()
            Timer1.Enabled = False
            Me.Close()
        End If
    End Sub
End Class