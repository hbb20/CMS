Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 50000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function
    End Class

    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim errA As String = e.Exception.Message.ToString + vbCrLf + " Continue ?"
            Dim ans = MessageBox.Show(errA, "Continue ?", MessageBoxButtons.YesNo)
            If ans = MsgBoxResult.No Then
                e.ExitApplication = True
            End If

        End Sub
    End Class

End Namespace

