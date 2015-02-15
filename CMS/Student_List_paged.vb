Imports System.Data.OleDb
Imports System.Threading

Public Class Student_List_paged

    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim unVrsltbl As New DataTable
    Dim fulDatatbl As New DataTable
    Public finlfont As Font = FontRetrive()
    Public thrdWait As Thread
    Dim clrBtn As Color
    Dim selctd As Integer = 0
    Public ClickedRegnId As Integer = 0
    Dim slctAll As Boolean = False


    'Paging
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private dtSource As DataTable
    Private PageCount As Integer
    Private maxRec As Integer
    Private pageSize As Integer
    Private currentPage As Integer
    Private recNo As Integer

    'Dim conn As New OleDbConnection
    Dim sSql As String
    Dim ReceiptID As Integer
    Dim intSelectedRow As Integer
    Dim timmer As Timer

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Student_srch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clrBtn = btnGenerate.BackColor
        Control.CheckForIllegalCrossThreadCalls = False
        FillCity()
        FillDistr()
        FillState()
        FillCountry()

        Me.StartPosition = FormStartPosition.CenterScreen
        LoadCmbState()
        LoadCmbCountry()
        LoadCmbCity()
        LoadCmbDistr()
        LoadQry()
        finlfont = FontRetrive()
        changFnt()

        'Dim thr As New Thread(AddressOf changFnt)
        'thr.Start()
        'Input_Form.thrdBuffr.Abort()
    End Sub
    Sub changFnt()

        Dim fnt As Font = finlfont
        dgrvStdnt.Font = fnt
        Dim textBoxList As New List(Of Control)
        textBoxList = GetAllControls(Of TextBox)(Me)
        Dim sb As New System.Text.StringBuilder
        Try
            For index As Integer = 0 To textBoxList.Count - 1
                If textBoxList.Item(index).Name = "txtDisplayPageNo" Then
                Else
                    textBoxList.Item(index).Font = fnt
                End If

            Next
        Catch ex As Exception
        End Try

        Dim style As New DataGridViewCellStyle
        style.Font = New Font("Arial", FontStyle.Bold)
        Try
            For Each col As DataGridViewColumn In dgrvStdnt.Columns
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                col.HeaderCell.Style.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Pixel)
            Next
        Catch ex As Exception
        End Try

        dgrvStdnt.Columns(0).DefaultCellStyle.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        Try
            For i As Integer = 6 To 9
                dgrvStdnt.Columns(i).DefaultCellStyle.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Pixel)
            Next
        Catch ex As Exception
        End Try

        cmbCity.Font = fnt
        cmbCntry.Font = fnt
        cmbDistr.Font = fnt
        cmbState.Font = fnt

    End Sub
    Private Sub LoadQry()
        Dim qr As String = String.Empty
        Dim City As String
        If cmbCity.SelectedIndex = 0 Then
            City = ""
        Else
            City = cmbCity.SelectedItem.ToString.Replace("'", "''")
        End If
        Dim State As String
        If cmbState.SelectedIndex = 0 Then
            State = ""
        Else
            State = cmbState.SelectedItem.ToString.Replace("'", "''")
        End If
        Dim Country As String
        If cmbCntry.SelectedIndex = 0 Then
            Country = ""
        Else
            Country = cmbCntry.SelectedItem.ToString.Replace("'", "''")
        End If

        qr = "SELECT * FROM `reg_table` ORDER BY Regn_ID ASC"
        ExtrTime(qr)
        'Dim cnCtn As New OleDbConnection(connString)
        'Dim dAdptR As New OleDbDataAdapter(qr, cnCtn)
        'Dim dTst1 As New DataSet

        'dAdptR.Fill(dTst1)
        'dgRvFromTable(dTst1.Tables(0))
        'fulDatatbl = dTst1.Tables(0)

    End Sub
    Sub dgRvFromTable(ByVal tbls As DataTable)
        Try
            dgrvStdnt.Rows.Clear()
        Catch ex As Exception
        End Try
        For lcnt As Integer = 0 To tbls.Rows.Count
            Try
                Dim adR As String = tbls.Rows(lcnt).Item("Addr").ToString + " " + vbCrLf + tbls.Rows(lcnt).Item("PIN Code").ToString
                Dim Regdat As Date = tbls.Rows(lcnt).Item("regn_Date").ToString
                Regdat = Regdat.Date.ToShortDateString
                Dim Bdat As Date = tbls.Rows(lcnt).Item("b_date").ToString
                Bdat = Bdat.Date.ToShortDateString

                dgrvStdnt.Rows.Add(
                                 tbls.Rows(lcnt).Item("Regn_ID").ToString, _
                                 tbls.Rows(lcnt).Item("Full_name").ToString, _
                                 adR, _
                                 tbls.Rows(lcnt).Item("City").ToString, _
                                 tbls.Rows(lcnt).Item("distr").ToString, _
                                 tbls.Rows(lcnt).Item("state").ToString, _
                                 Bdat, _
                                 tbls.Rows(lcnt).Item("Email").ToString, _
                                 tbls.Rows(lcnt).Item("Contact_No").ToString, _
                                 Regdat, _
                                 tbls.Rows(lcnt).Item("Education").ToString, _
                                 tbls.Rows(lcnt).Item("Qualification").ToString, _
                                 tbls.Rows(lcnt).Item("conTctID").ToString, _
                                 False)
            Catch ex As Exception
            End Try
        Next
        Try
            lblDisplayTotal.Text = "Displaying Results : - " & dgrvStdnt.RowCount
        Catch ex As Exception
        End Try
        selctd = 0
    End Sub

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
    Private Sub LoadCmbCountry()
        For Each wr As String In lstCntr
            cmbCntry.Items.Add(wr)
        Next
        Try
            cmbCntry.SelectedIndex = 0
        Catch ex As Exception
            'MsgBox("Missing Country List", MsgBoxStyle.Critical, "Oops . . .")
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
        If cmbCity.SelectedIndex = 0 Then
            City = ""
        Else
            City = cmbCity.SelectedItem.ToString.Replace("'", "''")
            City = City.Substring(0, City.Length - 2)
        End If
        Dim State As String
        If cmbState.SelectedIndex = 0 Then
            State = ""
        Else
            State = cmbState.SelectedItem.ToString.Replace("'", "''")
            State = State.Substring(0, State.Length - 2)
        End If
        Dim Country As String
        If cmbCntry.SelectedIndex = 0 Then
            Country = ""
        Else
            Country = cmbCntry.SelectedItem.ToString.Replace("'", "''")
            Country = Country.Substring(0, Country.Length - 2)
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

        If Not unVrsltbl.Rows.Count <= 0 Then
            Dim rows = unVrsltbl.Select("Regn_ID > 0" & _
                                         "AND Convert(Full_name, 'System.String') LIKE '*" + txtFullName.Text + "*'" & _
                                         "AND Convert(Addr, 'System.String') LIKE '*" + txtAdress.Text + "*'" & _
                                         "AND Convert(City, 'System.String') LIKE '*" + City + "*'" & _
                                         "AND Convert(state, 'System.String') LIKE '*" + State + "*'" & _
                                         "AND Convert(country, 'System.String') LIKE '*" + Country + "*'" & _
                                         "AND Convert(Education, 'System.String') LIKE '*" + txtEdu.Text + "*'" & _
                                         "AND Convert(Qualification, 'System.String') LIKE '*" + txtQual.Text + "*'" & _
                                         "AND Convert(distr, 'System.String') LIKE '*" + Ditr + "*'" & _
                                         "AND Convert(bk_sndng, 'System.String') LIKE '*" + datRg + "*'")
            Try
                dgRvFromTable(rows.CopyToDataTable)
            Catch ex As Exception
                MsgBox("No Results Found")
            End Try
        End If

        changFnt()
    End Sub


    Private Sub dTimepik_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dTimepik.ValueChanged
        chkalnull()
        If Not unVrsltbl.Rows.Count <= 0 Then
            Dim clmn_Name As String = "regn_Date"
            Dim rows = unVrsltbl.Select("Convert(" & clmn_Name & ", 'System.String') LIKE '%" + dTimepik.Value.Date.ToShortDateString + "%'")
            Try
                dgRvFromTable(rows.CopyToDataTable)
            Catch ex As Exception
                MsgBox("No Results Found")
            End Try
        End If
    End Sub
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Try
            dgRvFromTable(unVrsltbl)
            changFnt()
            Try
                cmbState.SelectedIndex = 0
            Catch ex As Exception
            End Try
            Try
                cmbCity.SelectedIndex = 0
            Catch ex As Exception
            End Try
            Try
                cmbCntry.SelectedIndex = 0
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
    End Sub
    Sub chkalnull()
        If txtAdress.TextLength = 0 And txtEdu.TextLength = 0 And txtFullName.TextLength = 0 And txtQual.TextLength = 0 Then
            unVrsltbl = fulDatatbl
            dgRvFromTable(fulDatatbl)
        End If
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
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Report_Viewer.studentOrContct = "student"
        Dim toPrint As Integer = 0
        Dim j As Integer = 0

        For i As Integer = 0 To dgrvStdnt.RowCount - 1
            If dgrvStdnt.Rows(i).Cells(13).Value = True Then
                toPrint += 1
                If j = 0 Then
                    Report_Viewer.incomingAry = dgrvStdnt.Rows(i).Cells(0).Value.ToString
                Else
                    Report_Viewer.incomingAry += "," + dgrvStdnt.Rows(i).Cells(0).Value.ToString
                End If
                j += 1
            End If
        Next
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
    Private Sub DataGridView1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgrvStdnt.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim ht As DataGridView.HitTestInfo
            ht = Me.dgrvStdnt.HitTest(e.X, e.Y)
            If ht.Type = DataGridViewHitTestType.Cell Then
                If ht.RowIndex <> 0 Then
                    ClickedRegnId = dgrvStdnt.Rows(ht.RowIndex).Cells(0).Value
                    'dgrvStdnt.ContextMenuStrip = ContextMenuStrip1
                    ContextMenuStrip1.Show()
                    'MsgBox(dgrvStdnt.Rows(ht.RowIndex).Cells(0).Value)
                End If
                'mnuCell.Items(0).Text = String.Format("This is the cell at {0}, {1}", ht.ColumnIndex, ht.RowIndex)
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
        Dim City As String
        If cmbCity.SelectedIndex = 0 Then
            City = ""
        Else
            City = cmbCity.SelectedItem.ToString.Replace("'", "''")
            City = City.Substring(0, City.Length - 2)
        End If
        Dim State As String
        If cmbState.SelectedIndex = 0 Then
            State = ""
        Else
            State = cmbState.SelectedItem.ToString.Replace("'", "''")
            State = State.Substring(0, State.Length - 2)
        End If
        Dim Country As String
        If cmbCntry.SelectedIndex = 0 Then
            Country = ""
        Else
            Country = cmbCntry.SelectedItem.ToString.Replace("'", "''")
            Country = Country.Substring(0, Country.Length - 2)
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

        If Not unVrsltbl.Rows.Count <= 0 Then
            Dim rows = unVrsltbl.Select("Regn_ID > 0" & _
                                         "AND Convert(Full_name, 'System.String') LIKE '*" + txtFullName.Text + "*'" & _
                                         "AND Convert(Addr, 'System.String') LIKE '*" + txtAdress.Text + "*'" & _
                                         "AND Convert(City, 'System.String') LIKE '*" + City + "*'" & _
                                         "AND Convert(state, 'System.String') LIKE '*" + State + "*'" & _
                                         "AND Convert(country, 'System.String') LIKE '*" + Country + "*'" & _
                                         "AND Convert(Education, 'System.String') LIKE '*" + txtEdu.Text + "*'" & _
                                         "AND Convert(Qualification, 'System.String') LIKE '*" + txtQual.Text + "*'" & _
                                         "AND Convert(distr, 'System.String') LIKE '*" + Ditr + "*'" & _
                                         "AND Convert(bk_sndng, 'System.String') LIKE '*" + datRg + "*'")
            Try
                dgrvStdnt.Rows.Clear()
                dgRvFromTable(rows.CopyToDataTable)
            Catch ex As Exception
                MsgBox("No Results Found" + ex.Message)
            End Try
        End If

        changFnt()
    End Sub

    Private Sub btnSlctAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlctAl.Click
        If slctAll = False Then
            For i As Integer = 0 To dgrvStdnt.RowCount - 1
                dgrvStdnt.Rows(i).Cells(13).Value = True
            Next
            slctAll = True
            btnSlctAl.Text = "Deselect All"
        Else
            For i As Integer = 0 To dgrvStdnt.RowCount - 1
                dgrvStdnt.Rows(i).Cells(13).Value = False
            Next
            slctAll = False
            btnSlctAl.Text = "Select All"
        End If
        MsgBox("Done", MsgBoxStyle.Information, "Popup")
    End Sub

    Private Sub btnGenerate_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.MouseHover
        btnGenerate.BackColor = Color.LightGray
    End Sub

    Private Sub btnGenerate_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.MouseLeave
        btnGenerate.BackColor = clrBtn
    End Sub




    Private Sub LoadDS(ByVal sSQL As String)
     
                ExtrTime(sSQL)
 
    End Sub
    Private Sub ExtrTime(ByVal sSQLx As String)

        'Open Connection.
        Dim conn As New OleDbConnection(connString)
        conn.Open()

        Dim cmd As New OleDbCommand
        cmd.CommandTimeout = 300
        cmd = New OleDbCommand(sSQLx, conn)
        cmd.CommandTimeout = 300
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        cmd.CommandTimeout = 300
        Dim dt As New DataTable
        dt.Load(reader)
        conn.Close()

        ds = New DataSet
        ds.Tables.Add(dt)
        dtSource = ds.Tables(0)
        unVrsltbl = dtSource
        FillGrid()

    End Sub
    Private Sub btnNextPage_Click(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles btnNextPage.Click

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

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnPreviousPage.Click

        If Not CheckFillButton() Then Return

        currentPage = currentPage - 1

        If currentPage < 1 Then
            MessageBox.Show("You are at the First Page!")
            currentPage = 1
            Return
        Else
            recNo = pageSize * (currentPage - 1)
        End If

        LoadPage()
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

        dgRvFromTable(dtTemp)

        DisplayPageInfo()
    End Sub

    Private Sub btnFirstPage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnFirstPage.Click

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

    Private Sub btnLastPage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnLastPage.Click

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

    Private Sub DisplayPageInfo()
        txtDisplayPageNo.Text = "Page " & currentPage.ToString & "/ " & PageCount.ToString
    End Sub

    Private Sub FillGrid()

        'Set the start and max records. 
        pageSize = 24 'txtPageSize.Text
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

    Private Function CheckFillButton() As Boolean
        'Check if the user clicks the "Fill Grid" button.
        If pageSize = 0 Then
            MessageBox.Show("Set the Page Size, and then click the ""Fill Grid"" button!")
            CheckFillButton = False
        Else
            CheckFillButton = True
        End If
    End Function
End Class