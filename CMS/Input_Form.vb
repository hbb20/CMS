Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class Input_Form
    'CityName text File
    'Access Database
    'RESET AUTONUMBER / ALTER TABLE `reg_table` ALTER `Regn_ID` COUNTER(1,1)
    Dim qrY As String = String.Empty
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim srchTxtc As Boolean = False
    Dim tmr As New Timer
    Dim tmrEfctW As Boolean = True
    Dim cntFs As Integer = 0

    Public thrdBuffr As Threading.Thread
    'Multiple form
    Dim frm2 As New Exm_frm
    Dim frm3 As New Student_srch
    Dim frm4 As New UpkmngExm

    Public UpcomingBithdays As String = 0

    Sub ComBoBoxLoadModule()
        FillCity()
        FillState()
        FillCountry()
        FillDistr()
        FillActVt()
        FillEducation()
        FillQualific()
    End Sub
    Sub LoadComboBox()
        LoadCmbCity()
        LoadCmbState()
        LoadCmbCountry()
        LoadCmbDistr()
        LoadCmbActVt()
        LoadCmbEduc()
        LoadCmbQuol()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dTimepik.Format = DateTimePickerFormat.Custom
        dTimepik.CustomFormat = "dd-MM-yyyy"
        dtPkrBdate.Format = DateTimePickerFormat.Custom
        dtPkrBdate.CustomFormat = "dd-MM-yyyy"
        dtPkrbks.Format = DateTimePickerFormat.Custom
        dtPkrbks.CustomFormat = "dd-MM-yyyy"


        Control.CheckForIllegalCrossThreadCalls = False

        ComBoBoxLoadModule()
        LoadComboBox()
        txtRegnId.Focus()
        cntFs += 1
        Dim pthChk As String = Application.StartupPath & "\db_users.accdb"
        If Not File.Exists(pthChk) Then
            MsgBox("Database File Missing Application Should Not Work", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim CN1 As New OleDbConnection(connString)
        'Load Combobox

        txtRegnId.Enabled = False
        'Load Upcoming Registration ID
        LoadUpcmng()
        cmbGendr.SelectedIndex = 0
        changFFF(FontRetrive)

        focusBirthday()
        If UpcomingBithdays > 0 Then
            MsgBox("There's " + UpcomingBithdays.ToString + " Upcoming birthdays in this week" + vbCrLf + "View in Birthdays Section")
        End If
    End Sub
    'Load Upcoming Registration ID
    Sub LoadUpcmng()
        Dim qrU As String = "SELECT MAX(`Regn_ID`) FROM `reg_table`"
        Dim cncTn2 As New OleDbConnection(connString)
        Dim dAd2 As New OleDbDataAdapter(qrU, cncTn2)
        Dim DtS2 As New DataSet
        dAd2.Fill(DtS2)
        Try
            If DtS2.Tables(0).Rows.Count <> 0 Then
                txtRegnId.Text = DtS2.Tables(0).Rows(0).Item(0).ToString + 1
            Else
                txtRegnId.Text = 1
            End If
        Catch ex As Exception
            txtRegnId.Text = 1
        End Try
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
    'To Load City Name From TextFile
#Region "Load Combobox"
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
    Sub LoadCmbActVt()
        For Each wr As String In lstActVt
            cmbAct.Items.Add(wr)
        Next
        Try
            cmbAct.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing Activity List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Private Sub LoadCmbCountry()
        For Each wr As String In lstCntr
            cmbCntry.Items.Add(wr)
        Next
        Try
            cmbCntry.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing Country List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Private Sub LoadCmbState()
        For Each wr As String In lstStat
            cmbState.Items.Add(wr)
        Next
        Try
            cmbState.SelectedIndex = 6
        Catch ex As Exception
            MsgBox("Missing State List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Private Sub LoadCmbDistr()
        For Each wr As String In lstDis
            cmbDistr.Items.Add(wr)
        Next
        Try
            cmbDistr.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing District List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Private Sub LoadCmbEduc()
        For Each wr As String In lstEduca
            cmbEdu.Items.Add(wr)
        Next
        Try
            cmbEdu.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing Education List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Private Sub LoadCmbQuol()
        For Each wr As String In lstQuolf
            cmbQuol.Items.Add(wr)
        Next
        Try
            cmbQuol.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing Qualification List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
#End Region

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If rdoModify.Checked = True Then
            Uodate()
            Exit Sub
        End If
        'use function to remove inverted comma from query
        Dim FullNm As String = Corrector(txtFullName.Text)
        Dim Adr As String = Corrector(txtAdr.Text)
        Dim Email As String = Corrector(txtEmail.Text)
        Dim Education As String = Corrector(cmbEdu.SelectedItem.ToString)
        Dim Qualification As String = Corrector(cmbQuol.SelectedItem.ToString)
        If txtCityName.Text = "" Then
            txtCityName.Text = cmbCity.SelectedItem.ToString
        End If
        If FullNm.Length = 0 Or Adr.Length = 0 Then
            MsgBox("Mendatory Fields Required", MsgBoxStyle.Exclamation, "Hmmm . . . . ")
            Exit Sub
        End If

        'build query for insert record
        qrY = "INSERT INTO `reg_table` (`Regn_ID`,`Full_name`, `Addr`, `City`, `distr`, `b_date`, `Gender`,`bk_sndng`, `PIN Code`, `Email`, `Contact_No`,`state`,`country`,`Education`,`Qualification`,`regn_Date`, `Activt`, `conTctID`, `Medium_of`) VALUES "
        'Reg ID
        qrY += "(" & txtRegnId.Text & ","
        'Full Name
        qrY += "'" & FullNm & "',"
        'Address
        qrY += "'" & Adr & "',"
        'City From combobox
        qrY += "'" & txtCityName.Text.ToString.Replace("'", "''") & "',"
        'qrY += "'" & cmbCity.SelectedItem.ToString.Replace("'", "''") & "',"
        'District
        qrY += "'" & cmbDistr.SelectedItem.ToString.Replace("'", "''") & "',"
        'Birth date from datetime picker
        qrY += "'" & dtPkrBdate.Value.Date.ToShortDateString & "',"
        'Gender
        qrY += "'" & cmbGendr.SelectedItem.ToString & "',"
        'Book Sending Date
        qrY += "'" & dtPkrbks.Value.Date.ToShortDateString & "',"
        'PIN Code
        qrY += "'" & txtPincode.Text & "',"
        'Email Address
        qrY += "'" & Email & "',"
        'Telephone No.
        qrY += "'" & txtTelNo.Text & "',"
        'State
        qrY += "'" & cmbState.SelectedItem.ToString.Replace("'", "''") & "',"
        'Country
        qrY += "'" & cmbCntry.SelectedItem.ToString.Replace("'", "''") & "',"
        'Education
        qrY += "'" & Education & "',"
        'Qualification
        qrY += "'" & Qualification & "',"
        'Registration Date
        qrY += "'" & dTimepik.Value.Date.ToShortDateString & "',"
        'Activity
        qrY += "'" & cmbAct.SelectedItem.ToString.Replace("'", "''") & "',"
        'Contact ID
        qrY += "'" & txtContcId.Text & "',"
        'Medium
        qrY += "'" & txtMidium.Text & "'"
        'Finished
        qrY += " )"
        Try
            Dim cncTn1 As New OleDbConnection(connString)
            Try
                Dim dAd1 As New OleDbDataAdapter(qrY, cncTn1)
                Dim DtS As New DataSet
                dAd1.Fill(DtS)
            Catch ex As Exception
                MsgBox("Data Cannot bee inserted Please check for illegal characters in textboxes" + vbCrLf + " such as '/*.", MsgBoxStyle.Critical, "Whoops")
                Exit Sub
            End Try
            Dim qrM As String = "SELECT MAX(`Regn_ID`) FROM `reg_table`"
            Dim dAdM As New OleDbDataAdapter(qrM, cncTn1)
            Dim DtM As New DataSet
            dAdM.Fill(DtM)

            Dim QrExm As String = "INSERT INTO `ex_1_table`(`Regn_ID`,`finalExmDat`) VALUES ('" & DtM.Tables(0).Rows(0).Item(0).ToString() & "','" & Date.Now.AddMonths(6).ToShortDateString & "')"
            Dim dAd2 As New OleDbDataAdapter(QrExm, cncTn1)
            Dim DtS2 As New DataSet
            dAd2.Fill(DtS2)

            Dim QrBook_Flooup As String = "INSERT INTO `book_info` (`Regn_ID`,`exam_Part`,`Book_dispatch`) VALUES ("
            QrBook_Flooup += "'" & DtM.Tables(0).Rows(0).Item(0).ToString() & "',"
            QrBook_Flooup += "'Part 1',"
            QrBook_Flooup += "'" & dtPkrbks.Value.ToShortDateString & "')"
            Dim dAFlo As New OleDbDataAdapter(QrBook_Flooup, cncTn1)
            Dim DtSFlo As New DataSet
            dAFlo.Fill(DtSFlo)

            MsgBox("Record Inserted SuccessFully", MsgBoxStyle.Information, "Success")
            ClearTxtBoxes()
            LoadUpcmng()
            rdoInsrt.Checked = True

            '//Want to Enter Data In Exam Window ?
            Dim response = MsgBox("Insert Exam Info In Exam Field", MsgBoxStyle.YesNo, "Go For . . .")
            If response = MsgBoxResult.Yes Then
                Exm_frm.Show()
            ElseIf response = MsgBoxResult.No Then
                MsgBox("Ok, you can do it later . . ^_^")
                'બરાબર, તમે પછીથી પણ​ તે કરી શકો છો
            End If
        Catch ex As Exception
            MsgBox("There Was An Error " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Contact System Administrator")
        End Try
    End Sub
    Function MandatField() As Boolean
        Dim blRtn As Boolean

        If txtFullName.Text.Length > 0 And txtAdr.Text.Length > 0 Then
            blRtn = True
        Else
            blRtn = False
        End If
        Return blRtn
    End Function
    'Record Update Query
    Sub Uodate()
        Dim FullNm As String = Corrector(txtFullName.Text)
        Dim Adr As String = Corrector(txtAdr.Text)
        Dim Email As String = Corrector(txtEmail.Text)
        Dim bolEans As Boolean = MandatField()

        If bolEans = False Then
            MsgBox("Mendatory Fields Required" + vbCrLf + "Name,Address,PINCODE", MsgBoxStyle.Exclamation, "Hmmm . . . . ")
            Exit Sub
        End If
        Dim activt As String = ""
        If Not (lblActvt.Text.Contains(cmbAct.SelectedItem.ToString.Replace("'", "''"))) Then
            activt = lblActvt.Text + "," + cmbAct.SelectedItem.ToString.Replace("'", "''")
        Else
            activt = lblActvt.Text
        End If
       
        'Build query for update records
        '"`City`='" & cmbCity.SelectedItem.ToString.Replace("'", "''") & "'," & _
        If txtCityName.Text = "" Then
            txtCityName.Text = cmbCity.SelectedItem.ToString
        End If
        Dim uPdQuery As String = "UPDATE `reg_table` SET " & _
                                 "`Full_name`='" & FullNm & "'," & _
                                 "`Addr`='" & Adr & "'," & _
                                 "`City`='" & txtCityName.Text.ToString.Replace("'", "''") & "'," & _
                                 "`distr`='" & cmbDistr.SelectedItem.ToString.Replace("'", "''") & "'," & _
                                 "`b_date`='" & dtPkrBdate.Value.Date.ToShortDateString & "'," & _
                                 "`Gender`='" & cmbGendr.SelectedItem.ToString & "'," & _
                                 "`bk_sndng`='" & dtPkrbks.Value.Date.ToShortDateString & "'," & _
                                 "`PIN Code`='" & txtPincode.Text & "'," & _
                                 "`Email`='" & Email & "'," & _
                                 "`Contact_No`='" & txtTelNo.Text & "'," & _
                                 "`state`='" & cmbState.SelectedItem.ToString.Replace("'", "''") & "'," & _
                                 "`country`='" & cmbCntry.SelectedItem.ToString.Replace("'", "''") & "'," & _
                                 "`Education`='" & Corrector(cmbEdu.SelectedItem.ToString) & "'," & _
                                 "`Qualification`='" & Corrector(cmbQuol.SelectedItem.ToString) & "'," & _
                                 "`regn_Date`='" & dTimepik.Value.Date.ToShortDateString & "'," & _
                                 "`Activt`='" & activt & "'," & _
                                 "`conTctID`='" & txtContcId.Text & "'," & _
                                 "`Medium_of`='" & Corrector(txtMidium.Text) & "'" & _
                                 " WHERE `Regn_ID` LIKE '" & txtRegnId.Text & "'"
        Dim cnUpd As New OleDbConnection(connString)
        Dim dA21 As New OleDbDataAdapter(uPdQuery, cnUpd)
        Try
            Dim ds21 As New DataSet
            dA21.Fill(ds21)
            MsgBox("Records Updated Successfully", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
           MsgBox("Data Cannot bee inserted Please check for illegal characters in textboxes" + vbCrLf + " such as '/*.[]", MsgBoxStyle.Critical, "Whoops")
        End Try

    End Sub
    'Calculate Age
    Public Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    'Use This Function Because Query does not allowed inverted comma
    Private Function Corrector(ByVal st As String) As String
        Dim rtN As String
        If st.Contains("'") Then
            rtN = st.Replace("'", "''")
        Else
            rtN = st
        End If
        Return rtN
    End Function
    'Allow Only Numbers in Some Field

#Region "Allow Numbers"
    Private Sub txtPincode_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtPincode.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtContcId_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtContcId.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtRegnId_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtRegnId.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
#End Region

    'clear textboxes to avoid duplicate entries
    Sub ClearTxtBoxes()
        Try
            txtAdr.Text = ""
            txtEmail.Text = ""
            txtFullName.Text = ""
            txtPincode.Text = ""
            txtTelNo.Text = ""
            txtMidium.Text = ""
            txtContcId.Text = ""
            cmbQuol.SelectedIndex = 0
            cmbEdu.SelectedIndex = 0
            lblActvt.Text = ""
            cmbAct.SelectedIndex = 0
            cmbGendr.SelectedIndex = 0
            txtCityName.Text = ""
            cmbCity.SelectedIndex = 0
            cmbDistr.SelectedIndex = 0
            cmbState.SelectedIndex = 0
            dtPkrBdate.Value = "01-01-1990"
            dTimepik.Value = "01-01-" + DateTime.Now.Year.ToString
            dtPkrbks.Value = "01-01-" + DateTime.Now.Year.ToString
        Catch ex As Exception

        End Try
    End Sub
    'Show Contact List
    Private Sub ContactListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactListToolStripMenuItem.Click
        Contact_List.Show()
    End Sub

    'Change Wheather to search or insert record
    Private Sub rdoInsrt_CheckedChanged(ByVal sender As System.Object) Handles rdoInsrt.CheckedChanged
        If rdoInsrt.Checked = True Then
            If Not cntFs = 0 Then
                txtRegnId.Enabled = False
                LoadUpcmng()
                ClearTxtBoxes()
                btnSave.Text = "&Insert Records (alt+I)"
                Me.Refresh()
                cntFs += 1
            End If
        End If
    End Sub
    Private Sub rdoModify_CheckedChanged(ByVal sender As System.Object) Handles rdoModify.CheckedChanged
        If rdoModify.Checked = True Then
            txtRegnId.Enabled = True
            txtRegnId.Text = ""
            ClearTxtBoxes()
            btnSave.Text = "&Modify Records (alt+M)"
            Me.Refresh()
        End If
    End Sub
  
    'For Searching In Existing Database
    Private Sub txtRegnId_TextChand(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegnId.TextChanged
        If txtRegnId.Text.Length > 0 Then
            txtStdntID.Enabled = False
        Else
            txtStdntID.Enabled = True
        End If
        If txtRegnId.Text.Length = 0 Then
            grp1.Enabled = False
            grp2.Enabled = False
            grp3.Enabled = False
        Else
            grp1.Enabled = True
            grp2.Enabled = True
            grp3.Enabled = True
        End If

        ClearTxtBoxes()
        Dim qrC As String = "SELECT * FROM `reg_table` WHERE `Regn_ID` LIKE '" & txtRegnId.Text & "'"
        Dim cn4 As New OleDbConnection(connString)
        Dim da32 As New OleDbDataAdapter(qrC, cn4)
        Dim ds32 As New DataSet
        da32.Fill(ds32)
        If ds32.Tables(0).Rows.Count <> 0 Then
            changeItmOnload(ds32.Tables(0))
            Fee_Details.regId = ds32.Tables(0).Rows(0).Item("Regn_ID").ToString
            btnFeeNew.Visible = True
            btnDelete.Visible = True
        Else
            If Not txtRegnId.Text.Length = 0 And txtRegnId.Enabled = True Then
                btnFeeNew.Visible = False
                btnDelete.Visible = False
                MsgBox("No such Record found", MsgBoxStyle.Exclamation, "Please Check ID")
            End If
            btnFeeNew.Visible = False
            btnDelete.Visible = False
        End If
    End Sub
    Private Sub txtStdntID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStdntID.TextChanged
        If txtStdntID.Text.Length > 0 Then
            txtRegnId.Enabled = False
        Else
            txtRegnId.Enabled = True
        End If
        If txtStdntID.Text.Length = 0 Then
            grp1.Enabled = False
            grp2.Enabled = False
            grp3.Enabled = False
        Else
            grp1.Enabled = True
            grp2.Enabled = True
            grp3.Enabled = True
        End If

        ClearTxtBoxes()
        Dim qrC As String = "SELECT * FROM `reg_table` WHERE `Student_ID` LIKE '" & txtStdntID.Text & "'"
        Dim cn4 As New OleDbConnection(connString)
        Dim da32 As New OleDbDataAdapter(qrC, cn4)
        Dim ds32 As New DataSet
        da32.Fill(ds32)
        If ds32.Tables(0).Rows.Count <> 0 Then
            changeItmOnload(ds32.Tables(0))
            Fee_Details.regId = ds32.Tables(0).Rows(0).Item("Regn_ID").ToString
            btnFeeNew.Visible = True
            btnDelete.Visible = True
        Else
            If Not txtStdntID.Text.Length = 0 And txtStdntID.Enabled = True Then
                btnFeeNew.Visible = False
                btnDelete.Visible = False
                MsgBox("No such Record found", MsgBoxStyle.Exclamation, "Please Check ID")
            End If
            btnFeeNew.Visible = False
            btnDelete.Visible = False
        End If
    End Sub

    'Count Year Month And Days From Days
    Public Sub CountDays(ByVal length As Integer, ByRef years As Integer, ByRef months As Integer, ByRef days As Integer)
        Dim remain As Double
        Dim amount As Double
        remain = CType(length, Double)
        amount = remain / 365.25
        years = Math.Truncate(amount)
        remain = remain - years * 365.25
        amount = remain / 30.4375
        months = Math.Truncate(amount)
        remain = remain - months * 30.4375
        days = Math.Truncate(remain)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim rsp = MsgBox("Are Sure You want to exit", MsgBoxStyle.YesNo, "Hmmm . . . .")
        If rsp = MsgBoxResult.Ok Then
            Me.Close()
            Me.Close()
            Me.Dispose()
        ElseIf rsp = MsgBoxResult.No Then
            MsgBox("Okk Keep working")
        End If
    End Sub
    Private Sub ExamlistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamlistToolStripMenuItem.Click
        Exm_frm.Show()
    End Sub
    Private Sub StudentLisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentLisToolStripMenuItem.Click
        thrdBuffr = New Threading.Thread(Sub()
                                             Using frm As New WaitScreen
                                                 Application.Run(frm)
                                             End Using
                                         End Sub)
        thrdBuffr.Start()
        Student_srch.Show()

    End Sub
    Sub changeItmOnload(ByVal dTable As DataTable)
        ClearTxtBoxes()
        Try
            txtFullName.Text = dTable.Rows(0).Item("Full_name").ToString
        Catch ex As Exception
        End Try
        Try
            txtAdr.Text = dTable.Rows(0).Item("Addr").ToString
        Catch ex As Exception
        End Try
        Try
            For k As Integer = 0 To cmbState.Items.Count - 1
                If cmbState.Items(k).ToString = dTable.Rows(0).Item("state").ToString Then
                    cmbState.SelectedIndex = k
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            For k As Integer = 0 To cmbCntry.Items.Count - 1
                If cmbCntry.Items(k).ToString = dTable.Rows(0).Item("country").ToString Then
                    cmbCntry.SelectedIndex = k
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            For k As Integer = 0 To cmbEdu.Items.Count - 1
                If cmbEdu.Items(k).ToString = dTable.Rows(0).Item("Education").ToString Then
                    cmbEdu.SelectedIndex = k
                End If
            Next
            'txtEducation.Text = dTable.Rows(0).Item("Education").ToString
        Catch ex As Exception
        End Try
        Try
            For k As Integer = 0 To cmbQuol.Items.Count - 1
                If cmbQuol.Items(k).ToString = dTable.Rows(0).Item("Qualification").ToString Then
                    cmbQuol.SelectedIndex = k
                End If
            Next
            'txtQualification.Text = dTable.Rows(0).Item("Qualification").ToString
        Catch ex As Exception
        End Try
        Try
            txtCityName.Text = dTable.Rows(0).Item("City").ToString
            For k As Integer = 0 To cmbCity.Items.Count - 1
                If cmbCity.Items(k).ToString = dTable.Rows(0).Item("City").ToString Then
                    cmbCity.SelectedIndex = k
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            For k As Integer = 0 To cmbDistr.Items.Count - 1
                If cmbDistr.Items(k).ToString = dTable.Rows(0).Item("distr").ToString Then
                    cmbDistr.SelectedIndex = k
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            txtMidium.Text = dTable.Rows(0).Item("Medium_of").ToString
        Catch ex As Exception
        End Try
        Try
            txtPincode.Text = dTable.Rows(0).Item("PIN Code").ToString
        Catch ex As Exception
        End Try
        Try
            txtEmail.Text = dTable.Rows(0).Item("Email").ToString
        Catch ex As Exception
        End Try
        Try
            txtTelNo.Text = dTable.Rows(0).Item("Contact_No").ToString
        Catch ex As Exception
        End Try
        Try
            txtEmail.Text = dTable.Rows(0).Item("Email").ToString
        Catch ex As Exception
        End Try
        Try
            Dim dStr As Date = dTable.Rows(0).Item("regn_Date").ToString
            dTimepik.Value = dStr
        Catch ex As Exception
        End Try
        Try
            Dim dStr1 As Date = dTable.Rows(0).Item("b_date").ToString
            dtPkrBdate.Value = dStr1
        Catch ex As Exception
        End Try
        Try
            Dim dStr2 As Date = dTable.Rows(0).Item("bk_sndng").ToString
            dtPkrbks.Value = dStr2
        Catch ex As Exception
        End Try
        Try
            txtContcId.Text = dTable.Rows(0).Item("conTctID").ToString
        Catch ex As Exception
        End Try
        Try
            For k As Integer = 0 To cmbGendr.Items.Count - 1
                If cmbGendr.Items(k).ToString = dTable.Rows(0).Item("Gender").ToString Then
                    cmbGendr.SelectedIndex = k
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            lblActvt.Text = dTable.Rows(0).Item("Activt").ToString
        Catch ex As Exception
        End Try

    End Sub

    Private Sub HbbtryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim hbb_try_frm As try_by_hbb
        hbb_try_frm = New try_by_hbb()
        hbb_try_frm.Show()
        hbb_try_frm = Nothing
    End Sub

    Private Sub btnFeeNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeNew.Click
        Fee_Details.ShowDialog()
    End Sub
    Private Sub ChangeFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFontToolStripMenuItem.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            changFFF(FontDialog1.Font)
            FontSav(FontDialog1.Font)
        End If
    End Sub
    Sub changFFF(ByVal fnt As Font)
        Dim textBoxList As New List(Of Control)
        textBoxList = GetAllControls(Of TextBox)(Me)
        For index As Integer = 0 To textBoxList.Count - 1
            If textBoxList.Item(index).Name = "txtEmail" Or
                textBoxList.Item(index).Name = "txtPincode" Or
                textBoxList.Item(index).Name = "txtRegnId" Or
                textBoxList.Item(index).Name = "txtStdntID" Then
            Else
                lblActvt.Font = fnt
                textBoxList.Item(index).Font = fnt
                cmbCntry.Font = fnt
                cmbAct.Font = fnt
                txtCityName.Font = fnt
                cmbCity.Font = fnt
                cmbDistr.Font = fnt
                cmbQuol.Font = fnt
                cmbEdu.Font = fnt
                'cmbGendr.Font = fnt
                cmbState.Font = fnt
            End If
        Next
    End Sub
    Private Sub EditComboboxListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditComboboxListToolStripMenuItem.Click
        EditCity.ShowDialog()
    End Sub
    Private Sub UpcomingExamsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpcomingExamsToolStripMenuItem.Click
        UpkmngExm.Show()
    End Sub
    Private Sub RefreshComboboxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshComboboxToolStripMenuItem.Click
        LoadComboBox()
    End Sub

    Private Sub GenerateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormReport.Show()
    End Sub

    Private Sub RegistrationStatusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationStatusToolStripMenuItem1.Click
        thrdBuffr = New Threading.Thread(Sub()
                                             Using frm As New WaitScreen
                                                 Application.Run(frm)
                                             End Using
                                         End Sub)
        thrdBuffr.Start()
        Reg_status.Show()
    End Sub
    Private Sub FolloUpReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolloUpReportToolStripMenuItem.Click
        FollowUpReport.Show()
    End Sub

#Region "Add Items"
    Private Sub btnAdContr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdContr.Click
        EditCity.Show()
        EditCity.CountryListToolStripMenuItem.PerformClick()
    End Sub
    Private Sub btnAdState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdState.Click
        EditCity.Show()
        EditCity.StateListToolStripMenuItem.PerformClick()
    End Sub
    Private Sub btnAdCity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdCity.Click
        EditCity.Show()
        EditCity.CityListToolStripMenuItem.PerformClick()
    End Sub
    Private Sub btnAdDistr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdDistr.Click
        EditCity.Show()
        EditCity.DistrictListToolStripMenuItem.PerformClick()
    End Sub
    Private Sub btnAdEdu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdEdu.Click
        EditCity.Show()
        EditCity.EditEducationToolStripMenuItem.PerformClick()
    End Sub
    Private Sub btnAdQul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdQul.Click
        EditCity.Show()
        EditCity.QuolificationToolStripMenuItem.PerformClick()
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmNew As New EditCity
        frmNew.TopLevel = False
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub txtCityName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCityName.TextChanged
        'For Each itm As String In cmbCity.Items
        '    If txtCityName.Text = itm Then
        '        cmbCity.SelectedItem = itm
        '    End If
        'Next
        For k As Integer = 0 To cmbCity.Items.Count - 1
            If txtCityName.Text = cmbCity.Items(k).ToString Then
                cmbCity.SelectedIndex = k
            End If
        Next
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCity.SelectedIndexChanged
        txtCityName.Text = cmbCity.SelectedItem.ToString
    End Sub

    Private Sub btnIncharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncharge.Click
        Contact_List.Show()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim notice As String = "Are you sure you want to delete this records from data" + vbCrLf + vbCrLf + "All data related to this records will be erased " + vbCrLf + vbCrLf + "Note: Fee details will be remain"
        Dim response = MsgBox(notice, MsgBoxStyle.YesNo, "Warning")

        If response = MsgBoxResult.Yes Then
            If txtRegnId.Enabled = True Then
                Dim qr As String = txtRegnId.Text
                If qr.Length = 0 Then
                    GoTo falsei
                Else
                    DeleteI(txtRegnId.Text)
                End If
            Else
falsei:
                MsgBox("Not Posssible -_-" + "Dont Erase Regn Id")
            End If
        ElseIf response = MsgBoxResult.No Then

        End If
    End Sub
    Sub DeleteI(ByVal rgnId As String)
        Dim delT As String = ""
        'Regn_ID
        'reg_table ex_1_table
        delT = "DELETE * FROM reg_table WHERE Regn_ID = " & rgnId
        Dim dsDlt As New DataSet
        Dim daAdp As New OleDbDataAdapter(delT, connString)
        daAdp.Fill(dsDlt)

        Dim delT2 As String = ""
        delT2 = "DELETE * FROM ex_1_table WHERE Regn_ID = '" & rgnId & "'"
        Dim dsDlt2 As New DataSet
        Dim daAdp2 As New OleDbDataAdapter(delT2, connString)
        daAdp2.Fill(dsDlt2)
        ClearTxtBoxes()

        MsgBox("Success")
    End Sub
    Public Sub TabPageChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbCntrl1.SelectedIndexChanged
        Select Case TbCntrl1.SelectedIndex
            Case 0

            Case 1
                Exm_frm.Show()
                'frm2.TopLevel = False
                'frm2.Parent = TabPage2
                'frm2.Enabled = False
                'frm2.Show()
            Case 2
                Student_srch.Show()
                'frm3.TopLevel = False
                'frm3.Parent = TabPage3
                'frm3.Enabled = False
                'frm3.Show()
            Case 3
                UpkmngExm.Show()
                'frm4.TopLevel = False
                'frm4.Parent = TabPage4
                'frm4.Enabled = False
                'frm4.Show()
            Case 4
                focusBirthday()
            Case 5
                FollowUpReport.Show()
            Case 6
                Reg_status.Show()
        End Select

    End Sub
    Sub focusBirthday()
        Try
            dgrvBday.DataSource = Nothing
            dgrvBday.Rows.Clear()
        Catch ex As Exception
        End Try

        Dim a1, a2 As DateTime
        a1 = DateTime.Now.Date.ToShortDateString
        a2 = DateTime.Now.Date.AddDays(7).ToShortDateString

        Dim sqltr As String
        If a1.Year.ToString = a2.Year.ToString Then
            If a2.Month.ToString = a1.Month.ToString Then
                sqltr = "SELECT Regn_ID,Full_name,Addr & "" - "" & City AS [Address],Email,Contact_No,b_date AS [B Date] FROM reg_table WHERE (Day(`b_date`) between " & a1.Day.ToString & " And " & a2.Day.ToString & ") And Month(`b_date`) = " & a1.Month.ToString
            Else
                sqltr = "SELECT Regn_ID,Full_name,Addr & "" - "" & City AS [Address],Email,Contact_No,b_date AS [B Date] FROM reg_table WHERE ((Day(`b_date`) between " & a1.Day.ToString & " And 31) Or (Day(`b_date`) between 1 And " & a2.Day.ToString & ")) And (Month(`b_date`) between " & a1.Month.ToString & " And " & a2.Month.ToString & ")"
            End If
        Else
            sqltr = "SELECT Regn_ID,Full_name,Addr & "" - "" & City AS [Address],Email,Contact_No,b_date AS [B Date] FROM reg_table WHERE ((Day(`b_date`) between " & a1.Day.ToString & " And 31) Or (Day(`b_date`) between 1 And " & a2.Day.ToString & ")) And ((Month(`b_date`) between " & a1.Month.ToString & " And 12) Or (Month(`b_date`) between 1 And " & a2.Month.ToString & "))"
        End If
      

        sqltr += " ORDER BY Day(`b_date`),Month(`b_date`) ASC"
        Dim ds As New DataSet
        Dim dqq As New OleDbDataAdapter(sqltr, connString)
        dqq.Fill(ds)
        Dim finlfont As Font = FontRetrive()

       
        dgrvBday.DataSource = ds.Tables(0)
        If Not dgrvBday.Rows.Count > 0 Then
            dgrvBday.Visible = False
            MsgBox("No Upcoming Birthdays in next Weeks")
            Exit Sub
        Else
            UpcomingBithdays = ds.Tables(0).Rows.Count
            dgrvBday.Visible = True
        End If

        With dgrvBday
            For l As Integer = 0 To .RowCount - 1
                .Rows(l).DefaultCellStyle.Font = finlfont
            Next
            .Columns(4).DefaultCellStyle.Font = New Font("Consolas", 12)
        End With
    End Sub
    Private Sub Input_Form_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        TbCntrl1.SelectedIndex = 0
    End Sub

    Private Sub Input_Form_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub Input_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Me.Close()

    End Sub
End Class