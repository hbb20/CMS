Imports System.Data.OleDb

Public Class Exm_frm
    Dim qr1 As String
    Dim qr2 As String
    Dim qr3 As String
    Dim qr4 As String
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim exStnc As Boolean = False
    Dim exStTabl As DataTable
    Dim srChTb As String = ""
    Dim doQr As Boolean = False


    Private Sub Exm_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtExmNm_1.Enabled = False
        cmbExmStt_1.SelectedIndex = 1
        cmbExmPrt.SelectedIndex = 0
        ChngExmFont(FontRetrive)
    End Sub
    Sub ChngExmFont(ByVal fnt As Font)
        lblStdntNm_1.Font = fnt
    End Sub
    Private Sub txtRegnId_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegnId_1.TextChanged
        clearAll()
        If txtRegnId_1.Text.Length = 0 Then
            lblStdntNm_1.Text = ""
            lblSdBdate_1.Text = ""
            lblGvExm.Text = ""
            clearAll()
            Exit Sub
        End If

        txtRegnId_1.Text.Replace("'", "")

        qr1 = "SELECT * FROM `reg_table` WHERE `Regn_ID` LIKE '" & txtRegnId_1.Text & "'"
        Dim cnA1 As New OleDbConnection(connString)
        Dim dA1 As New OleDbDataAdapter(qr1, cnA1)
        Dim ds1 As New DataSet
        dA1.Fill(ds1)
        If ds1.Tables(0).Rows.Count <> 0 Then
            Try
                lblStdntNm_1.Text = ds1.Tables(0).Rows(0).Item("Full_name").ToString
            Catch ex As Exception
            End Try
            Try
                Dim d As Date = ds1.Tables(0).Rows(0).Item("b_date").ToString
                lblSdBdate_1.Text = d.ToShortDateString
            Catch ex As Exception
            End Try
            Try
                Dim qr2 As String
                qr2 = "SELECT * FROM `" & srChTb & "` WHERE `Regn_ID` = '" & txtRegnId_1.Text & "'"
                Dim cnEm1 As New OleDbConnection(connString)
                Dim dAem1 As New OleDbDataAdapter(qr2, cnEm1)
                Dim dsEm1 As New DataSet
                dAem1.Fill(dsEm1)
                loadtxtBxFmTbl(dsEm1.Tables(0))

                exStTabl = dsEm1.Tables(0)
                If exStTabl.Rows.Count <> 0 Then
                    rdoModfy_1.Checked = True
                Else
                    rdoInsrt_1.Checked = True
                End If
                lblSum.Text = SumMarks()
            Catch ex As Exception
                MsgBox("No exams Given")
            End Try
        End If
        chkGvnExms()
    End Sub
    Function SumMarks() As String
        Dim Total As Integer = 0
        Try
            Total += CInt(txtMrks1_1.Text)
        Catch ex As Exception
        End Try
        Try
            Total += CInt(txtMrks2_1.Text)
        Catch ex As Exception
        End Try
        Try

            Total += CInt(txtMrks3_1.Text)
        Catch ex As Exception
        End Try
        Try

            Total += CInt(txtMrks4_1.Text)
        Catch ex As Exception
        End Try
        Try

            Total += CInt(txtMrks5_1.Text)
        Catch ex As Exception
        End Try
        Try

            Total += CInt(txtMrks6_1.Text)
        Catch ex As Exception
        End Try
        Try

            Total += CInt(txtMrks7_1.Text)
        Catch ex As Exception
        End Try
        Try

            Total += CInt(txtMrks8_1.Text)
        Catch ex As Exception
        End Try
        Try

            Total += CInt(txtMrks9_1.Text)
        Catch ex As Exception
        End Try
        Try
            Total += CInt(txtMrks10_1.Text)
        Catch ex As Exception
        End Try
        Try
            Total += CInt(txtFnlExm.Text)
        Catch ex As Exception
        End Try
       

        Return Total.ToString
    End Function
    Sub doQry()
        Dim qrC1 As String = "SELECT * FROM `ex_1_table` WHERE `Regn_ID` LIKE '" & txtRegnId_1.Text & "'"
        Dim cnE1 As New OleDbConnection(connString)
        Dim daE1 As New OleDbDataAdapter(qrC1, cnE1)
        Dim dsE1 As New DataSet
        daE1.Fill(dsE1)
    End Sub
    'Use this to load textboxex from table if value alredy exists
    Sub loadtxtBxFmTbl(ByVal tbl As DataTable)
        Try
            txtExmNm_1.Text = tbl.Rows(0).Item("exam_Name").ToString
        Catch ex As Exception
        End Try
        Try
            txtMrks1_1.Text = tbl.Rows(0).Item("lesson1_mrk").ToString
            txtMrks2_1.Text = tbl.Rows(0).Item("lesson2_mrk").ToString
            txtMrks3_1.Text = tbl.Rows(0).Item("lesson3_mrk").ToString
            txtMrks4_1.Text = tbl.Rows(0).Item("lesson4_mrk").ToString
            txtMrks5_1.Text = tbl.Rows(0).Item("lesson5_mrk").ToString
            txtMrks6_1.Text = tbl.Rows(0).Item("lesson6_mrk").ToString
            txtMrks7_1.Text = tbl.Rows(0).Item("lesson7_mrk").ToString
            txtMrks8_1.Text = tbl.Rows(0).Item("lesson8_mrk").ToString
            txtMrks9_1.Text = tbl.Rows(0).Item("lesson9_mrk").ToString
            txtMrks10_1.Text = tbl.Rows(0).Item("lesson10_mrk").ToString
        Catch ex As Exception
        End Try
        Try
            Dim dStrFn As Date = tbl.Rows(0).Item("finalExmDat").ToString
            dtPkFnlExm.Value = dStrFn.ToShortDateString

            Dim dStr1 As Date = tbl.Rows(0).Item("lesson1_date").ToString
            dtPkrExmDt1_1.Value = dStr1.ToShortDateString
            Dim dStr2 As Date = tbl.Rows(0).Item("lesson2_date").ToString
            dtPkrExmDt2_1.Value = dStr2.ToShortDateString
            Dim dStr3 As Date = tbl.Rows(0).Item("lesson3_date").ToString
            dtPkrExmDt3_1.Value = dStr3.ToShortDateString
            Dim dStr4 As Date = tbl.Rows(0).Item("lesson4_date").ToString
            dtPkrExmDt4_1.Value = dStr4.ToShortDateString
            Dim dStr5 As Date = tbl.Rows(0).Item("lesson5_date").ToString
            dtPkrExmDt5_1.Value = dStr5.ToShortDateString
            Dim dStr6 As Date = tbl.Rows(0).Item("lesson6_date").ToString
            dtPkrExmDt6_1.Value = dStr6.ToShortDateString
            Dim dStr7 As Date = tbl.Rows(0).Item("lesson7_date").ToString
            dtPkrExmDt7_1.Value = dStr7.ToShortDateString
            Dim dStr8 As Date = tbl.Rows(0).Item("lesson8_date").ToString
            dtPkrExmDt8_1.Value = dStr8.ToShortDateString
            Dim dStr9 As Date = tbl.Rows(0).Item("lesson9_date").ToString
            dtPkrExmDt9_1.Value = dStr9.ToShortDateString
            Dim dStr10 As Date = tbl.Rows(0).Item("lesson10_date").ToString
            dtPkrExmDt10_1.Value = dStr10.ToShortDateString

        Catch ex As Exception
        End Try
        Try
            Dim YorN As String = tbl.Rows(0).Item("finalExmElgb").ToString
            If YorN = "Yes" Then
                rdoY.Checked = True
            ElseIf YorN = "No" Then
                rdoN.Checked = True
            End If
            txtFnlExm.Text = tbl.Rows(0).Item("finalExmMrks").ToString
            
        Catch ex As Exception
        End Try

        Try
            If tbl.Rows(0).Item("upkmng").ToString = "Pass" Then
                cmbExmStt_1.SelectedIndex = 0
            ElseIf tbl.Rows(0).Item("upkmng").ToString = "Fail" Then
                cmbExmStt_1.SelectedIndex = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdoModfy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoModfy_1.CheckedChanged
        If rdoInsrt_1.Checked = True Then
            btnIns_1.Text = "Add"
        Else
            btnIns_1.Text = "Modify"
        End If
    End Sub
    Private Sub btnIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIns_1.Click
        If btnIns_1.Text = "Add" Then
            'MsgBox("ઉમેરો")
            If exStTabl.Rows.Count <> 0 Then
                MsgBox("Cnnot Enter Data Record Alredy Exists")
                Exit Sub
            End If
            inSrtQry()
            txtRegnId_1_TextChanged(sender, e)
        ElseIf btnIns_1.Text = "Modify" Then
            If exStTabl.Rows.Count = 0 Then
                MsgBox("Cnnot Enter Data Record Doesn't Exists")
                Exit Sub
            End If
            'MsgBox("સુધારો")
            UpdtQry()
        End If
        lblSum.Text = SumMarks()
    End Sub
    Sub inSrtQry()
        Dim inQr As String = String.Empty
        Dim elgbl As String
        If rdoY.Checked = True Then
            elgbl = "Yes"
        Else
            elgbl = "No"
        End If
        inQr = "INSERT INTO `" & srChTb & "` " & _
            "(`Regn_ID`, `exam_Name`, `cert_date`," & _
            " `lesson1_mrk`, `lesson1_date`, `lesson2_mrk`, `lesson2_date`, `lesson3_mrk`, `lesson3_date`," & _
            " `lesson4_mrk`, `lesson4_date`, `lesson5_mrk`, `lesson5_date`, `lesson6_mrk`, `lesson6_date`," & _
            " `lesson7_mrk`, `lesson7_date`, `lesson8_mrk`, `lesson8_date`, `lesson9_mrk`, `lesson9_date`," & _
            " `lesson10_mrk`, `lesson10_date`,`upkmng`," & _
            " `finalExmElgb`, `finalExmMrks`, `finalExmDat`" & _
           ") VALUES "
        inQr += "('" & txtRegnId_1.Text & "','" & txtExmNm_1.Text & "','" & dtPkrCrt_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks1_1.Text & "','" & dtPkrExmDt1_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks2_1.Text & "','" & dtPkrExmDt2_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks3_1.Text & "','" & dtPkrExmDt3_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks4_1.Text & "','" & dtPkrExmDt4_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks5_1.Text & "','" & dtPkrExmDt5_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks6_1.Text & "','" & dtPkrExmDt6_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks7_1.Text & "','" & dtPkrExmDt7_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks8_1.Text & "','" & dtPkrExmDt8_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks9_1.Text & "','" & dtPkrExmDt9_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & txtMrks10_1.Text & "','" & dtPkrExmDt10_1.Value.Date.ToShortDateString & "',"
        inQr += "'" & cmbExmStt_1.SelectedItem.ToString & "',"
        inQr += "'" & elgbl & "','" & txtFnlExm.Text & "','" & dtPkFnlExm.Value.Date.ToShortDateString & "'"
        inQr += " )"

        'Try
        Dim cnEnt As New OleDbConnection(connString)
        Dim dAdpEn As New OleDbDataAdapter(inQr, cnEnt)
        Dim dtSet As New DataSet
        dAdpEn.Fill(dtSet)
        MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Success")
        'Catch ex As Exception
        MsgBox("Something Not Right", MsgBoxStyle.Critical, "Error . . ")
        'End Try
    End Sub
    Sub UpdtQry()
        Dim elgbl As String
        If rdoY.Checked = True Then
            elgbl = "Yes"
        Else
            elgbl = "No"
        End If
        Dim uPdQuery As String = "UPDATE `" & srChTb & "` SET " & _
                    "`cert_date` = '" & dtPkrCrt_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson1_mrk` = '" & txtMrks1_1.Text & "',`lesson1_date` = '" & dtPkrExmDt1_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson2_mrk` = '" & txtMrks2_1.Text & "',`lesson2_date` = '" & dtPkrExmDt2_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson3_mrk` = '" & txtMrks3_1.Text & "',`lesson3_date` = '" & dtPkrExmDt3_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson4_mrk` = '" & txtMrks4_1.Text & "',`lesson4_date` = '" & dtPkrExmDt4_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson5_mrk` = '" & txtMrks5_1.Text & "',`lesson5_date` = '" & dtPkrExmDt5_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson6_mrk` = '" & txtMrks6_1.Text & "',`lesson6_date` = '" & dtPkrExmDt6_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson7_mrk` = '" & txtMrks7_1.Text & "',`lesson7_date` = '" & dtPkrExmDt7_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson8_mrk` = '" & txtMrks8_1.Text & "',`lesson8_date` = '" & dtPkrExmDt8_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson9_mrk` = '" & txtMrks9_1.Text & "',`lesson9_date` = '" & dtPkrExmDt9_1.Value.Date.ToShortDateString & "'," & _
                    "`lesson10_mrk` = '" & txtMrks10_1.Text & "',`lesson10_date` = '" & dtPkrExmDt10_1.Value.Date.ToShortDateString & "'," & _
                    "`upkmng` = '" & cmbExmStt_1.SelectedItem.ToString & "'," & _
                    "`finalExmElgb` = '" & elgbl & "',`finalExmMrks` = '" & txtFnlExm.Text & "',`finalExmDat` = '" & dtPkFnlExm.Value.Date.ToShortDateString & "'" & _
                    " WHERE `Regn_ID` LIKE '" & txtRegnId_1.Text & "'"
   
        Dim cnUp1 As New OleDbConnection(connString)
        Dim dAUp1 As New OleDbDataAdapter(uPdQuery, cnUp1)
        'Try
        Dim dtSUp1 As New DataSet
        dAUp1.Fill(dtSUp1)
        MsgBox("Record Updated Successfully", MsgBoxStyle.Information, "Success")

    End Sub

    Private Sub cmbExmPrt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExmPrt.SelectedIndexChanged
        If cmbExmPrt.SelectedIndex = 0 Then
            doQr = True
            srChTb = "ex_1_table"
            txtExmNm_1.Text = "प्रवेशः"
            clearAll()
            txtRegnId_1_TextChanged(sender, e)
        ElseIf cmbExmPrt.SelectedIndex = 1 Then
            doQr = True
            srChTb = "ex_2_table"
            txtExmNm_1.Text = "परिचयः"
            clearAll()
            txtRegnId_1_TextChanged(sender, e)
        ElseIf cmbExmPrt.SelectedIndex = 2 Then
            doQr = True
            srChTb = "ex_3_table"
            txtExmNm_1.Text = "शिक्षा"
            clearAll()
            txtRegnId_1_TextChanged(sender, e)
        ElseIf cmbExmPrt.SelectedIndex = 3 Then
            doQr = True
            srChTb = "ex_4_table"
            txtExmNm_1.Text = "कोविदः"
            clearAll()
            txtRegnId_1_TextChanged(sender, e)
        End If
    End Sub
    'Check For Available Data
    Public Sub chkGvnExms()
        Dim qr(4) As String
        qr(0) = "SELECT `Regn_ID` FROM `ex_1_table` WHERE `Regn_ID` = '" & txtRegnId_1.Text & "'"
        qr(1) = "SELECT `Regn_ID` FROM `ex_2_table` WHERE `Regn_ID` = '" & txtRegnId_1.Text & "'"
        qr(2) = "SELECT `Regn_ID` FROM `ex_3_table` WHERE `Regn_ID` = '" & txtRegnId_1.Text & "'"
        qr(3) = "SELECT `Regn_ID` FROM `ex_4_table` WHERE `Regn_ID` = '" & txtRegnId_1.Text & "'"
        lblGvExm.Text = ""
        Dim j As Integer = 0
        For i As Integer = 0 To 3
            Dim cnO As New OleDbConnection(connString)
            Dim dAo As New OleDbDataAdapter(qr(i), cnO)
            Dim dTs As New DataSet
            dAo.Fill(dTs)
            If dTs.Tables(0).Rows.Count <> 0 Then
                j += 1
                If i = 0 Then
                    lblGvExm.Text += "1"
                ElseIf i = 1 Then
                    lblGvExm.Text += ", 2"
                ElseIf i = 2 Then
                    lblGvExm.Text += ", 3"
                ElseIf i = 3 Then
                    lblGvExm.Text += ", 4"
                End If
            End If
        Next
        If j = 1 Then
            pctrPrt1.Image = My.Resources.Res_prg.green
            pctrPrt2.Image = My.Resources.Res_prg.red
            pctrPrt3.Image = My.Resources.Res_prg.red
            pctrPrt4.Image = My.Resources.Res_prg.red
        ElseIf j = 2 Then
            pctrPrt1.Image = My.Resources.Res_prg.green
            pctrPrt2.Image = My.Resources.Res_prg.green
            pctrPrt3.Image = My.Resources.Res_prg.red
            pctrPrt4.Image = My.Resources.Res_prg.red
        ElseIf j = 3 Then
            pctrPrt1.Image = My.Resources.Res_prg.green
            pctrPrt2.Image = My.Resources.Res_prg.green
            pctrPrt3.Image = My.Resources.Res_prg.green
            pctrPrt4.Image = My.Resources.Res_prg.red
        ElseIf j = 4 Then
            pctrPrt1.Image = My.Resources.Res_prg.green
            pctrPrt2.Image = My.Resources.Res_prg.green
            pctrPrt3.Image = My.Resources.Res_prg.green
            pctrPrt4.Image = My.Resources.Res_prg.green
        End If
    End Sub
    Sub clearAll()
        rdoN.Checked = True

        txtMrks1_1.Text = ""
        txtMrks2_1.Text = ""
        txtMrks3_1.Text = ""
        txtMrks4_1.Text = ""
        txtMrks5_1.Text = ""
        txtMrks6_1.Text = ""
        txtMrks7_1.Text = ""
        txtMrks8_1.Text = ""
        txtMrks9_1.Text = ""
        txtMrks10_1.Text = ""
        txtFnlExm.Text = ""
        Dim dt As Date = "01-01-2014"
        dtPkrExmDt1_1.Value = dt
        dtPkrExmDt2_1.Value = dt
        dtPkrExmDt3_1.Value = dt
        dtPkrExmDt4_1.Value = dt
        dtPkrExmDt5_1.Value = dt
        dtPkrExmDt6_1.Value = dt
        dtPkrExmDt7_1.Value = dt
        dtPkrExmDt8_1.Value = dt
        dtPkrExmDt9_1.Value = dt
        dtPkrExmDt10_1.Value = dt
        dtPkFnlExm.Value = dt
        lblSum.Text = ""
        cmbExmStt_1.SelectedIndex = 1
    End Sub

    'Allow only numbers
#Region "Allow Only Numeric Value"
    Private Sub txtMrks1_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks1_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks2_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks2_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks4_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks4_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks5_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks5_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks6_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks6_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks7_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks7_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks8_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks8_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks9_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks9_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks10_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtMrks10_1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks11_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtMrks12_1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
#End Region

    Function ExamCheck() As String
        Dim OutPut As String = ""
        Dim int_pls As Integer
        int_pls = chkTextBox()
        If lblGvExm.Text = "1" Then
            OutPut += "1" + " " + int_pls.ToString
        End If
        If lblGvExm.Text = "1, 2" Then
            OutPut += "2" + " " + int_pls.ToString
        End If
        If lblGvExm.Text = "1, 2, 3" Then
            OutPut += "3" + " " + int_pls.ToString
        End If
        If lblGvExm.Text = "1, 2, 3, 4" Then
            OutPut += "4" + " " + int_pls.ToString
        End If
        
        Return OutPut
    End Function
    Function chkTextBox() As Integer
        Dim intFill As String = ""
        If txtMrks1_1.Text.Length > 0 Then
            intFill += "1"
        End If
        If txtMrks2_1.Text.Length > 0 Then
            intFill += "2"
        End If
        If txtMrks3_1.Text.Length > 0 Then
            intFill += "3"
        End If
        If txtMrks4_1.Text.Length > 0 Then
            intFill += "4"
        End If
        If txtMrks5_1.Text.Length > 0 Then
            intFill += "5"
        End If
        If txtMrks6_1.Text.Length > 0 Then
            intFill += "6"
        End If
        If txtMrks7_1.Text.Length > 0 Then
            intFill += "7"
        End If
        If txtMrks8_1.Text.Length > 0 Then
            intFill += "8"
        End If
        If txtMrks9_1.Text.Length > 0 Then
            intFill += "9"
        End If
        If txtMrks10_1.Text.Length > 0 Then
            intFill += "10"
        End If
        Return intFill
    End Function

    Private Sub rdoN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoN.CheckedChanged
        If rdoY.Checked = True Then
            lblFnlExm.Visible = True
            txtFnlExm.Visible = True
            dtPkFnlExm.Visible = True
        ElseIf rdoN.Checked = True Then
            lblFnlExm.Visible = False
            txtFnlExm.Visible = False
            dtPkFnlExm.Visible = False
        End If
    End Sub
    Private Sub rdoY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoY.CheckedChanged
        If rdoN.Checked = True Then
            lblFnlExm.Visible = False
            txtFnlExm.Visible = False
            dtPkFnlExm.Visible = False
            lblFnlMrk.Visible = False
            btnGenExam.Visible = False
        ElseIf rdoY.Checked = True Then
            lblFnlExm.Visible = True
            txtFnlExm.Visible = True
            dtPkFnlExm.Visible = True
            lblFnlMrk.Visible = True
            btnGenExam.Visible = True
        End If
    End Sub
    Private Sub btnGenExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenExam.Click
        If Report_Viewer.Visible = True Then
            Report_Viewer.Close()
        End If
        Report_Viewer.wway = 3
        Report_Viewer.rgnId = txtRegnId_1.Text.Replace("'", "")
        Report_Viewer.exmPart = cmbExmPrt.SelectedIndex.ToString
        Report_Viewer.StudntName = lblStdntNm_1.Text
        Report_Viewer.exmMarks = txtFnlExm.Text
        Report_Viewer.Show()
    End Sub
    Private Sub btnMarkSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkSheet.Click
        MsgBox("Report Development In Process")
    End Sub
End Class