Public NotInheritable Class Start_Up

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Start_Up_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim gfx As Drawing.Graphics = e.Graphics

        gfx.DrawImage(My.Resources.Res_prg.init_image2, New Rectangle(0, 0, Me.Width, Me.Height))
    End Sub
End Class
