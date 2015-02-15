Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Threading

Public Class Student_srch
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim unVrsltbl As New DataTable
    Dim fulDatatbl As New DataTable
    Dim maiNHandler As New DataTable

    Public finlfont As Font = FontRetrive()
    Public thrdWait As Thread
    Dim clrBtn As Color
    Dim selctd As Integer = 0
    Public ClickedRegnId As Integer = 0
    Dim slctAll As Boolean = False

    Public fromVal As String = 0
    Public toLimit As String = 100
    Dim panelState As Boolean = False

    Public EndNum As String = 0
    Public totalCount As String

    Dim publicThrd As Thread

    Dim isSearchEnable As Boolean = False
    Private PageCount As Integer
    Private maxRec As Integer
    Private pageSize As Integer
    Private currentPage As Integer
    Private recNo As Integer
    Private dtSource As DataTable
    Public FirstTime As Boolean = True
    Public displayPageSize As String = 100


#Region "Show Columns"
    Public alowAddr As Boolean = True
    Public alowBrthdate As Boolean = True
    Public alowQuol As Boolean = True
    Public alowContctNo As Boolean = True
    Public alowContctId As Boolean = True
    Public alowRgnDate As Boolean = True
    Public alowEduc As Boolean = True
#End Region



    Public Shared Sub OnThreadException(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)

    End Sub
    Private Sub ThreadException(ByVal ex As Exception)
        Throw ex
    End Sub


    Sub onLoadTotal()
        Dim count As String = "SELECT Count(Regn_ID) AS CountNum FROM reg_table"
        Dim cnCtn2 As New OleDbConnection(connString)
        Dim dAdptR2 As New OleDbDataAdapter(count, cnCtn2)
        Dim dTst9 As New DataSet

        dAdptR2.Fill(dTst9)
        totalCount = dTst9.Tables(0).Rows(0).Item(0).ToString
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Student_srch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dTimepik.Format = DateTimePickerFormat.Custom
        dTimepik.CustomFormat = "dd-MM-yyyy"


        chkAplyFont.Checked = False
        Control.CheckForIllegalCrossThreadCalls = False
        FillCity()
        FillDistr()
        FillState()
        FillCountry()

        Me.StartPosition = FormStartPosition.CenterScreen
        LoadCmbState()
        LoadCmbCity()
        LoadCmbDistr()
        onLoadTotal()
        btnDisabled()


        finlfont = FontRetrive()

        publicThrd = New Thread(AddressOf newLoadFunc)

        AddHandler Application.ThreadException, AddressOf OnThreadException

        publicThrd.IsBackground = True
        publicThrd.Start()
        changFnt()
        Try
            Input_Form.thrdBuffr.Abort()
        Catch ex As Exception
        End Try
        cmbCount.SelectedIndex = 0
        FirstTime = False
    End Sub
    Sub newSubFont()

       Try
            With DataGridView1
                For l As Integer = 0 To .RowCount - 1
                    .Rows(l).DefaultCellStyle.Font = finlfont
                Next
            End With
            DataGridView1.Columns(12).DisplayIndex = 0
        Catch ex As Exception
            'Me.BeginInvoke(New Action(Of Exception)(AddressOf ThreadException), ex)
        End Try
        DataGridView1.PerformLayout()
        DataGridView1.Refresh()
        btnEnabled()
    End Sub
    Sub Disabler()
        If alowAddr = False Then
            txtAdress.Enabled = False
        End If
        If alowBrthdate = False Then
            unVrsltbl.Columns.RemoveAt(6)
        End If
        If alowContctId = False Then
            unVrsltbl.Columns.RemoveAt(11)
        End If
        If alowContctNo = False Then
            unVrsltbl.Columns.RemoveAt(7)
        End If
        If alowEduc = False Then
            unVrsltbl.Columns.RemoveAt(9)
        End If
        If alowQuol = False Then
            unVrsltbl.Columns.RemoveAt(10)
        End If
        If alowRgnDate = False Then
            unVrsltbl.Columns.RemoveAt(8)
        End If
    End Sub
    Public Sub ColumnsHandler()

        unVrsltbl = maiNHandler

        If alowAddr = False Then
            unVrsltbl.Columns.Remove("Address")
        End If
        If alowBrthdate = False Then
            unVrsltbl.Columns.Remove("B Date")
        End If
        If alowContctId = False Then
            unVrsltbl.Columns.Remove("Contact Id")
        End If
        If alowContctNo = False Then
            unVrsltbl.Columns.Remove("Contact No")
        End If
        If alowEduc = False Then
            unVrsltbl.Columns.Remove("Education")
        End If
        If alowQuol = False Then
            unVrsltbl.Columns.Remove("Qualification")
        End If
        If alowRgnDate = False Then
            unVrsltbl.Columns.Remove("Regn Date")
        End If
        unVrsltbl.AcceptChanges()

        FillGrid()
    End Sub
    Sub newLoadFunc()

        Me.Text = "Student Search (Loading)"
        Dim slct As String = "SELECT " & _
                                 "[Regn_ID],[Full_name] As [Name],[Addr] As [Address],[City],[distr] As [District],[state],[b_date] As [B Date]," & _
                                 "[Contact_No] As [Contact No],[regn_Date] As [Regn Date],[Education],[Qualification],[conTctID] As [Contact Id],[IsSelect] As [Select]" & _
                                 " FROM `reg_table` ORDER BY Regn_ID ASC" '[Email],
        Try
            Dim cnCtn As New OleDbConnection(connString)
            Dim dAdptR As New OleDbDataAdapter(slct, cnCtn)
            Dim dTst1 As New DataSet

            dAdptR.Fill(dTst1)
            unVrsltbl = dTst1.Tables(0)
            maiNHandler = dTst1.Tables(0)

            lblNUms.Text = "0 To 200"
            Dim dtempTbl As New DataTable

            dtempTbl = datatableCopy(unVrsltbl, 0)
            dtSource = unVrsltbl
            FillGrid()
            'DataGridView1.DataSource = dtempTbl
            Me.Text = "Student Search"
            btnEnabled()
            'newSubFont()
        Catch ex As Exception
            'Me.BeginInvoke(New Action(Of Exception)(AddressOf ThreadException), ex)
        End Try
    End Sub
    Sub changFnt()

        Dim fnt As Font = finlfont
        'DataGridView1.Font = fnt
        Dim textBoxList As New List(Of Control)
        textBoxList = GetAllControls(Of TextBox)(Me)
        Dim sb As New System.Text.StringBuilder
        Try
            For index As Integer = 0 To textBoxList.Count - 1
                textBoxList.Item(index).Font = fnt
            Next
        Catch ex As Exception
        End Try

        cmbCity.Font = fnt
        txtCity.Font = fnt
        cmbDistr.Font = fnt
        cmbState.Font = fnt

    End Sub

#Region "Button Change Pages"
    Sub Clear()
        Try
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()
        Catch ex As Exception
            Try
                DataGridView1.DataSource = Nothing
                DataGridView1.Rows.Clear()
                DataGridView1.Columns.Clear()
            Catch ex2 As Exception
            End Try
        End Try
    End Sub
#Region "Next Prev"
    Private Sub btnNxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNxt.Click

        'If the user did not click the "Fill Grid" button then Return
        If Not CheckFillButton() Then Return

        'Check if the user clicked the "Fill Grid" button.
        If pageSize = 0 Then
            MessageBox.Show("Set the Page Size, and then click the ""Fill Grid"" button!")
            Return
        End If

        currentPage = currentPage + 1

        If currentPage > PageCount Then
            currentPage = PageCount

            'Check if you are already at the last page.
            If recNo = maxRec Then
                MessageBox.Show("You are at the Last Page!")
                Return
            End If
        End If

        LoadPage()
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        If Not CheckFillButton() Then Return

        currentPage = currentPage - 1

        'Check if you are already at the first page.
        If currentPage < 1 Then
            MessageBox.Show("You are at the First Page!")
            currentPage = 1
            Return
        Else
            recNo = pageSize * (currentPage - 1)
        End If

        LoadPage()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click

        If Not CheckFillButton() Then Return

        ' Check if you are already at the last page.
        If recNo = maxRec Then
            MessageBox.Show("You are at the Last Page!")
            Return
        End If

        currentPage = PageCount

        recNo = pageSize * (currentPage - 1)

        LoadPage()
    End Sub

    Private Sub btnFrst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrst.Click


        If Not CheckFillButton() Then Return

        ' Check if you are already at the first page.
        If currentPage = 1 Then
            MessageBox.Show("You are at the First Page!")
            Return
        End If

        currentPage = 1
        recNo = 0

        LoadPage()

    End Sub
    Private Sub cmbCount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCount.SelectedIndexChanged
        If cmbCount.SelectedItem.ToString = "All" Then
            displayPageSize = unVrsltbl.Rows.Count.ToString
        Else
            displayPageSize = cmbCount.SelectedItem.ToString
        End If
        If FirstTime = False Then
            FillGrid()
        End If

    End Sub
    Private Sub LoadPage()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSource.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo
        If dtSource.Rows.Count > 0 Then
            'Copy the rows from the source table to fill the temporary table.
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSource.Rows(i))
                recNo = recNo + 1
            Next
        End If
        DataGridView1.DataSource = dtTemp
        DisplayPageInfo()
        If chkAplyFont.Checked = True Then
            newSubFont()
        End If
        lblDisplayTotal.Text = "Displaying Results : - " & dtSource.Rows.Count
        'DataGridView1.Columns(12).DisplayIndex = 0
    End Sub
    Private Function CheckFillButton() As Boolean
        'Check if the user clicks the "Fill Grid" button.
        If pageSize = 0 Then
            MessageBox.Show("Set the Page Size, and then click the ""Fill Grid"" button!")
            CheckFillButton = False
        Else
            CheckFillButton = True
        End If
    End Function
    Private Sub DisplayPageInfo()
        lblNUms.Text = "Page " & currentPage.ToString & "/ " & PageCount.ToString
    End Sub
    Private Sub FillGrid()
        'Set the start and max records. 
        pageSize = displayPageSize  'txtPageSize.Text
        maxRec = dtSource.Rows.Count
        PageCount = maxRec \ pageSize
        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If
        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPage()
    End Sub
#End Region

#End Region
    Function datatableCopy(ByVal dtableIn As DataTable, ByVal LimitFrom As String) As DataTable
        Dim dtableNew As DataTable = dtableIn.Clone
        Try
            For i As Integer = LimitFrom To (LimitFrom + 199)
                dtableNew.ImportRow(dtableIn.Rows(i))
            Next
        Catch ex As Exception
        End Try
        Return dtableNew
    End Function
  
#Region "Combobox Filled Here"
    Sub LoadCmbCity()
        For Each wr As String In lstCmb
            cmbCity.Items.Add(wr)
        Next
        Try
            cmbCity.SelectedIndex = 0
        Catch ex As Exception
            'MsgBox("Missing City List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Private Sub LoadCmbState()
        For Each wr As String In lstStat
            cmbState.Items.Add(wr)
        Next
        Try
            cmbState.SelectedIndex = 0
        Catch ex As Exception
            'MsgBox("Missing State List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Private Sub LoadCmbDistr()
        For Each wr As String In lstDis
            cmbDistr.Items.Add(wr)
        Next
        Try
            cmbDistr.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing State List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
#End Region

    Sub doQry()
        Dim City As String
        If cmbCity.SelectedIndex = 0 And (txtCity.Text.Length = 0 Or txtCity.Text.Contains("सर्वं")) Then
            City = ""
        Else
            City = txtCity.Text.ToString.Replace("'", "''")
            City = City.Substring(0, City.Length - 2)
        End If
        Dim State As String
        If cmbState.SelectedIndex = 0 Then
            State = ""
        Else
            State = cmbState.SelectedItem.ToString.Replace("'", "''")
            State = State.Substring(0, State.Length - 2)
        End If
      
        Dim Ditr As String
        If cmbDistr.SelectedIndex = 0 Then
            Ditr = ""
        Else
            Ditr = cmbDistr.SelectedItem.ToString.Replace("'", "''")
            Ditr = Ditr.Substring(0, Ditr.Length - 2)
        End If
        Dim datRg As New Date
        If ChkboxReg.Checked = True Then
            datRg = dTimepik.Value.ToShortDateString
        Else
            datRg = Nothing
        End If
        'District

        If Not unVrsltbl.Rows.Count <= 0 Then
            Dim rows = unVrsltbl.Select("Regn_ID > 0" & _
                                         "AND Convert(Name, 'System.String') LIKE '*" + txtFullName.Text + "*'" & _
                                         "AND Convert(Address, 'System.String') LIKE '*" + txtAdress.Text + "*'" & _
                                         "AND Convert(City, 'System.String') LIKE '*" + City + "*'" & _
                                         "AND Convert(state, 'System.String') LIKE '*" + State + "*'" & _
                                         "AND Convert(District, 'System.String') LIKE '*" + Ditr + "*'" & _
                                         "AND Convert(Education, 'System.String') LIKE '*" + txtEdu.Text + "*'" & _
                                         "AND Convert(Qualification, 'System.String') LIKE '*" + txtQual.Text + "*'")
            Try

                fulDatatbl = New DataTable
                fulDatatbl = unVrsltbl.Clone
                fulDatatbl = rows.CopyToDataTable()
                If fulDatatbl.Rows.Count > 0 Then
                    dtSource = fulDatatbl
                    FillGrid()
                End If
                'dgRvFromTable(rows.CopyToDataTable)
            Catch ex As Exception
                MsgBox("No Results Found")
            End Try
        End If

        changFnt()
    End Sub


    Private Sub dTimepik_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dTimepik.ValueChanged
       If Not unVrsltbl.Rows.Count <= 0 Then
            Dim clmn_Name As String = "Regn Date"
            Dim rows = unVrsltbl.Select("'" & clmn_Name & "' LIKE '#" + dTimepik.Value.Date.ToShortDateString + "#'")
            Try
                fulDatatbl = rows.CopyToDataTable()
                isSearchEnable = True
                btnDisabled()
                EndNum = 0
                totalCount = fulDatatbl.Rows.Count
            Catch ex As Exception
                MsgBox("No Results Found")
            End Try
        End If
    End Sub

    Sub btnEnabled()
        btnSearch.Enabled = True
        btnNxt.Enabled = True
        btnPrev.Enabled = True
        btnGo.Enabled = True
        btnSlctAl.Enabled = True
    End Sub
    Sub btnDisabled()
        btnSearch.Enabled = False
        btnNxt.Enabled = False
        btnPrev.Enabled = False
        btnGo.Enabled = False
        btnSlctAl.Enabled = False
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Try
            btnDisabled()
            isSearchEnable = False
            fulDatatbl = unVrsltbl
            totalCount = unVrsltbl.Rows.Count
            Try
                cmbState.SelectedIndex = 0
            Catch ex As Exception
            End Try
            Try
                cmbCity.SelectedIndex = 0
            Catch ex As Exception
            End Try
            Try
                txtCity.Text = ""
            Catch ex As Exception
            End Try
            Try
                cmbDistr.SelectedIndex = 0
            Catch ex As Exception
            End Try
            Try
                txtAdress.Text = ""
                txtEdu.Text = ""
                txtFullName.Text = ""
                txtQual.Text = ""
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
        dtSource = unVrsltbl
        FillGrid()
        btnEnabled()
        'publicThrd = New Thread(AddressOf LoadFromtable)
        'publicThrd.IsBackground = True
        'publicThrd.Start()
    End Sub
  
#Region "Change Events Fired here"
    'Private Sub txtFullName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFullName.KeyPress
    '    doQry()
    'End Sub
    'Private Sub txtAdress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdress.KeyPress
    '    doQry()
    'End Sub
    'Private Sub txtEdu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdu.KeyPress
    '    doQry()
    'End Sub
    'Private Sub cmbCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCity.SelectedIndexChanged
    '    doQry()
    'End Sub
    'Private Sub cmbState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbState.SelectedIndexChanged
    '    doQry()
    'End Sub
    'Private Sub cmbCntry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCntry.SelectedIndexChanged
    '    doQry()
    'End Sub
    'Private Sub cmbDistr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDistr.SelectedIndexChanged
    '    doQry()
    'End Sub
#End Region
    Private Sub DataGridView1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim ht As DataGridView.HitTestInfo
            ht = Me.DataGridView1.HitTest(e.X, e.Y)
            If ht.Type = DataGridViewHitTestType.Cell Then
                If ht.RowIndex <> 0 Then
                    ClickedRegnId = DataGridView1.Rows(ht.RowIndex).Cells(0).Value
                    'DataGridView1.ContextMenuStrip = ContextMenuStrip1
                    ContextMenuStrip1.Show()
                    'MsgBox(DataGridView1.Rows(ht.RowIndex).Cells(0).Value)
                End If
             End If
        End If
    End Sub
    Public Sub editInInputForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles editInInputForm.Click
        Input_Form.rdoModify.Checked = True
        Input_Form.txtRegnId.Text = ClickedRegnId
        Input_Form.Focus()
    End Sub
    Public Sub examProgress_Click(ByVal sender As Object, ByVal e As EventArgs) Handles examProgress.Click
        If examProgress.Visible = True Then
            UpkmngExm.txtRgnID.Text = ClickedRegnId
            UpkmngExm.DotNetBarTabcontrol1.SelectedTab = UpkmngExm.TabPage2
            UpkmngExm.Focus()
        Else
            UpkmngExm.Show()
            UpkmngExm.txtRgnID.Text = ClickedRegnId
            UpkmngExm.DotNetBarTabcontrol1.SelectedTab = UpkmngExm.TabPage2
            UpkmngExm.Focus()
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        doQry()
    End Sub
    Private Sub btnSlctAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlctAl.Click
        'Dim ans = MessageBox.Show("Be Aware You are about to slect " + .ToString + " Records", "Warning", MessageBoxButtons.YesNo)
        'If ans = MsgBoxResult.No Then
        '    Exit Sub
        'End If
        If slctAll = False Then
            For i As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(i).Cells(12).Value = True
            Next
            slctAll = True
            btnSlctAl.Text = "Deselect All"
        Else
            For i As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(i).Cells(12).Value = False
            Next
            slctAll = False
            btnSlctAl.Text = "Select All"
        End If
        MsgBox("Done", MsgBoxStyle.Information, "Popup")
  
    End Sub

    Private Sub GenerateReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateReportToolStripMenuItem.Click
        Report_Viewer.studentOrContct = "student"
        Dim toPrint As Integer = 0
        Dim j As Integer = 0

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells(12).Value = True Then
                toPrint += 1
                If j = 0 Then
                    Report_Viewer.incomingAry = DataGridView1.Rows(i).Cells(0).Value.ToString
                Else
                    Report_Viewer.incomingAry += "," + DataGridView1.Rows(i).Cells(0).Value.ToString
                End If
                j += 1
            End If

        Next
        Dim incomingAry As String = Report_Viewer.incomingAry
        If toPrint > 0 Then
            thrdWait = New System.Threading.Thread(Sub()
                                                       Using frm As New WaitScreen
                                                           Application.Run(frm)
                                                       End Using
                                                   End Sub)
            thrdWait.Start()
            Report_Viewer.Show()
            thrdWait.Abort()
        Else
            MsgBox("Please Select Atleast one contact from checkbox", MsgBoxStyle.Exclamation, "Alert")
        End If
    End Sub

    Private Sub Student_srch_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If publicThrd.ThreadState = ThreadState.Running Then
                MsgBox("Please Wait for current process to finish")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Student_srch_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If publicThrd.ThreadState = ThreadState.Running Then
                MsgBox("Please Wait for current process to finish")
                e.Cancel = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCity.SelectedIndexChanged
        txtCity.Text = cmbCity.SelectedItem.ToString
    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged
        For kl As Integer = 0 To cmbCity.Items.Count - 1
            If cmbCity.Items(kl).ToString = txtCity.Text Then
                cmbCity.SelectedIndex = kl
            End If
        Next
    End Sub

    Private Sub chkAplyFont_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAplyFont.CheckedChanged
        If chkAplyFont.Checked = True Then
            DataGridView1.ReadOnly = False
            MsgBox("This can take bit longer time to load" + vbCrLf + "इदम् इतऊति !!", MsgBoxStyle.OkOnly, "Warning / प्रबोधन")
            newSubFont()
          ElseIf chkAplyFont.Checked = False Then
            If FirstTime = True Then
                FirstTime = False
            Else

            End If
        End If
    End Sub
    Private Sub ViewFieldsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewFieldsToolStripMenuItem.Click
        checkButtons.ShowDialog()
    End Sub
End Class
