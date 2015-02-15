Public Class WaitScreen
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        ' This call is required by the designer.
        Me.BackColor = Color.Transparent
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Load_Form(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class