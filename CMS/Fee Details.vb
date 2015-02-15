Imports System.Data.OleDb
Imports System.Threading

Public Class Fee_Details
    Public regId As String
    Dim str As String
    Dim chk As Boolean
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim con As New OleDbConnection(connString)
    Dim unVrsltbl As New DataTable
    Public recptTabl As New DataTable


    Public thrdWait As Thread

    Private Sub Fee_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblregId.Text = regId
        cmbExmPrt.SelectedIndex = 0
        txtRcptNo.Text = ""
        UpcmngRcpt()
        DoCheck()
    End Sub
    Sub DoCheck()
        Clear()

        str = "SELECT * FROM `fee_table` WHERE `Regn_ID` = " & regId & " AND `Stage` = '" & cmbExmPrt.SelectedItem.ToString & "'"
        Dim dA1 As New OleDbDataAdapter(str, con)
        Dim dtS1 As New DataSet()
        dA1.Fill(dtS1)
        If dtS1.Tables(0).Rows.Count <> 0 Then
            chk = False
            txtChqDDno.Text = dtS1.Tables(0).Rows(0).Item("Ch_dr_no").ToString
            txtFee.Text = dtS1.Tables(0).Rows(0).Item("Fee").ToString
            Try
                For k As Integer = 0 To cmbPayTyp.Items.Count - 1
                    If cmbPayTyp.Items(k).ToString = dtS1.Tables(0).Rows(0).Item("Pay_mode").ToString Then
                        cmbPayTyp.SelectedIndex = k
                    End If
                Next
            Catch ex As Exception
            End Try
            Try
                Dim dStr4 As Date = dtS1.Tables(0).Rows(0).Item("chk_date").ToString
                dtPkrChkDat.Value = dStr4
            Catch ex As Exception
            End Try
            txtRcptNo.Text = dtS1.Tables(0).Rows(0).Item("Recpt_No").ToString
            txtBnkNm.Text = dtS1.Tables(0).Rows(0).Item("BankName").ToString
            txtRcptNo.Enabled = False
        Else
            chk = True
            UpcmngRcpt()
            txtRcptNo.Enabled = True
        End If
    End Sub
    Function QryRunr(ByVal qryRnr As String) As DataTable
        Dim dtRtn As DataTable

        Dim cncRNr As New OleDbConnection(connString)
        Dim dArnr As New OleDbDataAdapter(qryRnr, cncRNr)
        Dim DtSrnr As New DataSet
        Try
            dArnr.Fill(DtSrnr)
            dtRtn = DtSrnr.Tables(0)
        Catch ex As Exception
            dtRtn = New DataTable
        End Try
        Return dtRtn
    End Function
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim Qry As String = ""

        If chk = True Then
            If ChekExist() = True Then
                MsgBox("Recept No. Alredy exists", MsgBoxStyle.Exclamation, "Error . . .")
                Exit Sub
            End If
            Qry = "INSERT INTO `fee_table` (`Recpt_No`,`Regn_ID`,`Fee`,`Pay_mode`,`Ch_dr_no`,`chk_date`,`Stage`,`BankName`) VALUES "
            Qry += "("
            'Recept No.
            Qry += "'" & txtRcptNo.Text.Replace("'", "''") & "',"
            'Reg ID
            Qry += "" & regId & ","
            'Fee Paid
            Qry += "'" & txtFee.Text.Replace("'", "''") & "',"
            'Payment mode
            Qry += "'" & cmbPayTyp.SelectedItem.ToString & "',"
            'Chk or draft no.
            Qry += "'" & txtChqDDno.Text.Replace("'", "''") & "',"
            'Cheque date
            Qry += "'" & dtPkrChkDat.Value.Date.ToShortDateString & "',"
            'Exam part
            Qry += "'" & cmbExmPrt.SelectedItem.ToString & "',"
            'Bank Name
            Qry += "'" & txtBnkNm.Text.Replace("'", "''") & "'"
            Qry += ")"
        Else
            Qry = "UPDATE `fee_table` SET "
            'Recept No.
            Qry += "`Recpt_No`='" & txtRcptNo.Text & "',"
            'Reg ID
            Qry += "`Regn_ID`=" & regId & ","
            'Fee Paid
            Qry += "`Fee`='" & txtFee.Text.Replace("'", "''") & "',"
            'Payment mode
            Qry += "`Pay_mode`='" & cmbPayTyp.SelectedItem.ToString & "',"
            'Cheque date
            Qry += "`Ch_dr_no`='" & txtChqDDno.Text.Replace("'", "''") & "',"
            'Chk or draft no.
            Qry += "`chk_date`='" & dtPkrChkDat.Value.Date.ToShortDateString & "',"
            'Exam part
            Qry += "`Stage`= '" & cmbExmPrt.SelectedItem.ToString & "',"
            'Bank Nmae
            Qry += "`BankName`= '" & txtBnkNm.Text.Replace("'", "''") & "'"
            'Where
            Qry += " WHERE `Regn_ID` = " & regId & " AND `Stage` = '" & cmbExmPrt.SelectedItem.ToString & "'"
        End If
        Dim dA2 As New OleDbDataAdapter(Qry, con)
        Dim dtS2 As New DataSet()
        dA2.Fill(dtS2)
        MsgBox("Record Inserted SuccessFully", MsgBoxStyle.Information, "Success")
    End Sub
    Function ChekExist() As Boolean
        Dim dtAabEx As DataTable = QryRunr("SELECT * FROM `fee_table` WHERE `Recpt_No` = '" + txtRcptNo.Text + "'")
        If dtAabEx.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub UpcmngRcpt()
        Dim dtAb As DataTable = QryRunr("SELECT MAX(`Recpt_No`) FROM `fee_table`")
        Try
            txtRcptNo.Text = Convert.ToInt32(dtAb.Rows(0).Item(0).ToString) + 1
        Catch ex As Exception
            txtRcptNo.Text = 1
        End Try
    End Sub
    Private Sub cmbExmPrt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExmPrt.SelectedIndexChanged
        DoCheck()
    End Sub
    Sub Clear()
        txtBnkNm.Text = ""
        txtChqDDno.Text = ""
        txtFee.Text = ""
        txtRcptNo.Text = ""
        dtPkrChkDat.Value = "01-01-2014"
    End Sub

    Private Sub cmbPayTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayTyp.SelectedIndexChanged
        Select Case cmbPayTyp.SelectedIndex
            Case 0
                txtChqDDno.Visible = False
                lblDrNo.Visible = False
                dtPkrChkDat.Visible = True
                lblDat.Text = "Cash Send Date"
                txtBnkNm.Visible = False
                lblBnkNm.Visible = False
            Case 1
                txtChqDDno.Visible = True
                lblDrNo.Visible = True
                lblDrNo.Text = "Cheque No."
                lblDat.Text = "Date On Cheque"
                txtBnkNm.Visible = True
                lblBnkNm.Visible = True
            Case 2
                txtChqDDno.Visible = True
                lblDrNo.Visible = True
                lblDrNo.Text = "Draft No."
                lblDat.Text = "Date On Daraft"
                txtBnkNm.Visible = False
                lblBnkNm.Visible = False
            Case 3
                txtChqDDno.Visible = True
                lblDrNo.Visible = True
                lblDrNo.Text = "NEFT id."
                lblDat.Text = "Date Of NEFT"
                txtBnkNm.Visible = False
                lblBnkNm.Visible = False
        End Select
        UpcmngRcpt()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If Report_Viewer.Visible = True Then
            Report_Viewer.Close()
        End If
        Report_Viewer.wway = 1
        If txtFee.Text.Length > 0 Then
            str = "SELECT * FROM `fee_table`,`reg_table` WHERE `fee_table`.`Regn_ID` = " & regId & " AND `fee_table`.`Stage` = '" & cmbExmPrt.SelectedItem.ToString & "' AND reg_table.Regn_ID = fee_table.Regn_ID"
            recptTabl = QryRunr(str)
            If recptTabl.Rows.Count > 0 Then
                thrdWait = New Thread(Sub()
                                          Using frm As New WaitScreen
                                              Application.Run(frm)
                                          End Using
                                      End Sub)
                thrdWait.Start()
                Report_Viewer.Show()
                thrdWait.Abort()
            Else
                MsgBox("No Fee Info inserted", MsgBoxStyle.Exclamation, "Heyy")
            End If
        End If

    End Sub
End Class