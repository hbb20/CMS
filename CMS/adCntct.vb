'I Really Love Her yaar
Imports System.IO
Imports System.Data.OleDb

Public Class adCntct
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"

    Private Sub adCntct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCmbDistr()
        LoadCmbCity()
        LoadCmbQual()

        changFFF(FontRetrive)
    End Sub
    Sub changFFF(ByVal fnt As Font)
        Dim textBoxList As New List(Of Control)
        textBoxList = GetAllControls(Of TextBox)(Me)
        Dim sb As New System.Text.StringBuilder
        For index As Integer = 0 To textBoxList.Count - 1
            If textBoxList.Item(index).Name = "txtCntctID" Or
                textBoxList.Item(index).Name = "txtPin" Or
                 textBoxList.Item(index).Name = "txtPhone" Or
                textBoxList.Item(index).Name = "txtMail" Then
            Else
                textBoxList.Item(index).Font = fnt
            End If
        Next
        cmbCity.Font = fnt
        cmbDistr.Font = fnt
    End Sub
    Sub LoadCmbDistr()
        For Each wr As String In lstDis
            cmbDistr.Items.Add(wr)
        Next
        Try
            cmbDistr.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing District List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Sub LoadCmbCity()
        For Each wr As String In lstCmb
            cmbCity.Items.Add(wr)
        Next
        Try
            cmbCity.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing City List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Sub LoadCmbQual()
        For Each wr As String In lstQuolf
            cmbQuol.Items.Add(wr)
        Next
        Try
            cmbQuol.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing Qualification List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub

    Private Sub btnInsrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsrt.Click
        If txtFullName.Text.Length = 0 Or txtAdr.Text.Length = 0 Then
            MsgBox("Mendatory Fields Required")
            Exit Sub
        End If
        If btnInsrt.Text = "Modify" Then
            UpdateQry()
            Exit Sub
        End If

        Dim iQr As String = String.Empty
        Dim FullNm As String = Corrector(txtFullName.Text)
        Dim Adrs As String = Corrector(txtAdr.Text)
        Dim PIN As String = Corrector(txtPin.Text)
        Dim phn As String = Corrector(txtPhone.Text)
        Dim Mobil As String = Corrector(txtMobil.Text)
        Dim Email As String = Corrector(txtMail.Text)
        Dim wrk As String = Corrector(cmbQuol.SelectedItem.ToString)
        Dim reSpns As String = Corrector(txtRespns.Text)
        iQr = "INSERT INTO `contct_table` (`c_Full_name`, `c_Addr`, `c_city`, `c_Distr`, `c_PIN`, `c_Phn`, `c_Mobil`, `c_Email`, `c_Work`, `c_Respnsb`, `c_Bdate`) VALUES "
        iQr += "('" & FullNm & "',"
        iQr += "'" & Adrs & "',"
        iQr += "'" & cmbCity.SelectedItem.ToString & "',"
        iQr += "'" & cmbDistr.SelectedItem.ToString & "',"
        iQr += "'" & PIN & "',"
        iQr += "'" & phn & "',"
        iQr += "'" & Mobil & "',"
        iQr += "'" & Email & "',"
        iQr += "'" & wrk & "',"
        iQr += "'" & reSpns & "',"
        iQr += "'" & dtPkrBdate.Value.Date.ToShortDateString & "'"
        iQr += " )"

        Dim cNx As New OleDbConnection(connString)
        Try
            Dim dAdp As New OleDbDataAdapter(iQr, cNx)
            Dim dts As New DataSet
            dAdp.Fill(dts)
            MsgBox("Records inerted successfully", MsgBoxStyle.Information, "Success")
            clear()
        Catch ex As Exception
            MsgBox("Somethign Went wrong" + vbCrLf + ex.Message, MsgBoxStyle.Critical, "contact administrator")
        End Try

    End Sub
    Private Function Corrector(ByVal st As String) As String
        Dim rtN As String
        If st.Contains("'") Then
            rtN = st.Replace("'", "''")
        Else
            rtN = st
        End If
        Return rtN
    End Function

    Private Sub txtPin_TextChng(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtPin.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtCntctID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCntctID.TextChanged
        clear()

        If txtCntctID.Text.Length <> 0 Then
            btnInsrt.Text = "Modify"
        ElseIf txtCntctID.Text.Length = 0 Then
            btnInsrt.Text = "Add"
        End If

        txtCntctID.Text.Replace("'", "")
        Dim Cnqr As String = ""
        Cnqr = "SELECT * FROM `contct_table` WHERE `conTctID` LIKE '" & txtCntctID.Text & "'"
        Dim cnCn As New OleDbConnection(connString)
        Dim dAdP As New OleDbDataAdapter(Cnqr, cnCn)
        Dim dtSt As New DataSet
        dAdP.Fill(dtSt)

        If dtSt.Tables(0).Rows.Count <> 0 Then
            txtFullName.Text = dtSt.Tables(0).Rows(0).Item("c_Full_name").ToString
            txtAdr.Text = dtSt.Tables(0).Rows(0).Item("c_Addr").ToString
            For l As Integer = 0 To cmbCity.Items.Count - 1
                If cmbCity.Items(l).ToString = dtSt.Tables(0).Rows(0).Item("c_city").ToString Then
                    cmbCity.SelectedIndex = l
                End If
            Next
            For l As Integer = 0 To cmbDistr.Items.Count - 1
                If cmbDistr.Items(l).ToString = dtSt.Tables(0).Rows(0).Item("c_Distr").ToString Then
                    cmbDistr.SelectedIndex = l
                End If
            Next
            txtPin.Text = dtSt.Tables(0).Rows(0).Item("c_PIN").ToString
            txtPhone.Text = dtSt.Tables(0).Rows(0).Item("c_Phn").ToString
            txtMobil.Text = dtSt.Tables(0).Rows(0).Item("c_Mobil").ToString
            txtMail.Text = dtSt.Tables(0).Rows(0).Item("c_Email").ToString
            Try
                For k As Integer = 0 To cmbQuol.Items.Count - 1
                    If cmbQuol.Items(k).ToString = dtSt.Tables(0).Rows(0).Item("c_Work").ToString Then
                        cmbQuol.SelectedIndex = k
                    End If
                Next
            Catch ex As Exception
            End Try
         
            txtRespns.Text = dtSt.Tables(0).Rows(0).Item("c_Respnsb").ToString
            Dim dAt As Date = dtSt.Tables(0).Rows(0).Item("c_Bdate").ToString
            dtPkrBdate.Value = dAt.ToShortDateString
        End If
    End Sub
    Sub UpdateQry()
        'iQr = "INSERT INTO `contct_table` (`c_Full_name`, `c_Addr`, `c_city`, `c_Distr`, `c_PIN`, `c_Phn`, `c_Mobil`, `c_Email`, `c_Work`, `c_Respnsb`, `c_Bdate`) VALUES "
        Dim FullNm As String = Corrector(txtFullName.Text)
        Dim Adr As String = Corrector(txtAdr.Text)
        Dim PiN As String = Corrector(txtPin.Text)
        Dim pHN As String = Corrector(txtPhone.Text)
        Dim mBL As String = Corrector(txtMobil.Text)
        Dim Mail As String = Corrector(txtMail.Text)
        Dim Wrk As String = Corrector(cmbQuol.SelectedItem.ToString)
        Dim RspnsB As String = Corrector(txtRespns.Text)

        Dim qrS As String = "UPDATE `contct_table` SET " & _
                    "`c_Full_name`='" & FullNm & "'," & _
                    "`c_Addr`='" & Adr & "'," & _
                    "`c_city`='" & cmbCity.SelectedItem.ToString & "'," & _
                    "`c_Distr`='" & cmbDistr.SelectedItem.ToString & "'," & _
                    "`c_PIN`='" & PiN & "'," & _
                    "`c_Phn`='" & pHN & "'," & _
                    "`c_Mobil`='" & mBL & "'," & _
                    "`c_Email`='" & Mail & "'," & _
                    "`c_Work`='" & Wrk & "'," & _
                    "`c_Respnsb`='" & RspnsB & "'," & _
                    "`c_Bdate`='" & dtPkrBdate.Value.Date.ToShortDateString & "'" & _
                    " WHERE `conTctID` LIKE '" & txtCntctID.Text & "'"

        Dim cn5 As New OleDbConnection(connString)
        Dim dAdP As New OleDbDataAdapter(qrS, cn5)
        Try
            Dim dTS As New DataSet
            dAdP.Fill(dTS)
            MsgBox("Records Updated successfully", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("Somethign Went wrong" + vbCrLf + ex.Message, MsgBoxStyle.Critical, "contact administrator")
        End Try

    End Sub
    Sub clear()
        txtAdr.Text = ""
        txtFullName.Text = ""
        txtMail.Text = ""
        txtMobil.Text = ""
        txtPhone.Text = ""
        txtPin.Text = ""
        txtRespns.Text = ""
        cmbQuol.SelectedIndex = 0
        dtPkrBdate.Value = "01-01-1994"
    End Sub
    Sub changFon(ByVal fonts As Font)
        Dim textBoxList As New List(Of Control)
        textBoxList = GetAllControls(Of TextBox)(Me)
        For index As Integer = 0 To textBoxList.Count - 1
            textBoxList.Item(index).Font = fonts
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim textBoxList As New List(Of Control)
            textBoxList = GetAllControls(Of TextBox)(Me)
            For index As Integer = 0 To textBoxList.Count - 1
                textBoxList.Item(index).Font = FontDialog1.Font
                cmbCity.Font = FontDialog1.Font
            Next
            cmbCity.Font = FontDialog1.Font
            cmbDistr.Font = FontDialog1.Font
        End If
    End Sub
End Class