Public Class checkButtons

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        If chkAddr.Checked = True Then
            Student_srch.alowAddr = True
        Else
            Student_srch.alowAddr = False
        End If
        If chkBdate.Checked = True Then
            Student_srch.alowBrthdate = True
        Else
            Student_srch.alowBrthdate = False
        End If
        If chkContctId.Checked = True Then
            Student_srch.alowContctId = True
        Else
            Student_srch.alowContctId = False
        End If
        If chkContctNo.Checked = True Then
            Student_srch.alowContctNo = True
        Else
            Student_srch.alowContctNo = False
        End If
        If chkQuol.Checked = True Then
            Student_srch.alowQuol = True
        Else
            Student_srch.alowQuol = False
        End If
        If chkRgnDate.Checked = True Then
            Student_srch.alowRgnDate = True
        Else
            Student_srch.alowRgnDate = False
        End If
        If chkEduc.Checked = True Then
            Student_srch.alowEduc = True
        Else
            Student_srch.alowEduc = False
        End If

        Student_srch.ColumnsHandler()
        MsgBox("Work")
        Me.Close()
    End Sub

    Private Sub checkButtons_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Student_srch.alowAddr = True Then
            chkAddr.Checked = True
        End If
        If Student_srch.alowBrthdate = True Then
            chkBdate.Checked = True
        End If
        If Student_srch.alowContctId = True Then
            chkContctId.Checked = True
        End If
        If Student_srch.alowContctNo = True Then
            chkContctNo.Checked = True
        End If
        If Student_srch.alowQuol = True Then
            chkQuol.Checked = True
        End If
        If Student_srch.alowRgnDate = True Then
            chkRgnDate.Checked = True
        End If
        If Student_srch.alowEduc = True Then
            chkEduc.Checked = True
        End If
    End Sub
End Class