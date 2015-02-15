Imports System.Data.OleDb
Public Class FollowUpReport

    'Paging
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private dtSource As DataTable
    Private PageCount As Integer
    Private maxRec As Integer
    Private pageSize As Integer
    Private currentPage As Integer
    Private recNo As Integer


    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;" 'Input_Form.connString
    Dim th As Threading.Thread
    Dim ds1 As DataSet
    Dim con1 As New OleDbConnection(constr)
    Dim book_columns As String = "`Regn_ID`,`exam_Part`,`Book_dispatch`,`2ndFollowup`,`3rdFollowup`,`4thFollowup`,`5thFollowup`,`more_Coments`,`Q_paper_disp`,`Ans_Sheet_receive`"
    Sub Loopy()

        Control.CheckForIllegalCrossThreadCalls = False
        Dim full As String = "SELECT Regn_ID,bk_sndng FROM `reg_table`"

        Dim da1 As New OleDbDataAdapter(full, con1)
        ds1 = New DataSet
        da1.Fill(ds1)

        th = New Threading.Thread(AddressOf Loopy)
        th.Start()
        For j As Integer = 0 To ds1.Tables(0).Rows.Count - 1
            Dim INSRT As String = "INSERT INTO `book_info` (`Regn_ID`,`exam_Part`,`Book_dispatch`) VALUES ("
            INSRT += "'" & ds1.Tables(0).Rows(j).Item(0).ToString & "',"
            INSRT += "'Part 1',"
            INSRT += "'" & ds1.Tables(0).Rows(j).Item(1).ToString & "')"

            Dim da2 As New OleDbDataAdapter(INSRT, con1)
            Dim ds2 As New DataSet
            da2.Fill(ds2)
            rdoBkDipatch.Text = j.ToString & "_Point"
        Next
    End Sub

    Private Sub FollowUpReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Dim sQr As String = "SELECT " & book_columns & " FROM book_info"
        sQr += " ORDER BY Regn_ID ASC"

        ExtrTime(sQr)


       

        'Dim con1d As New OleDbConnection(constr)
        'Dim da As New OleDbDataAdapter(sQr, con1d)
        'Dim ds As New DataSet
        'da.Fill(ds)
        'dgrvFoloup.DataSource = ds.Tables(0)
    End Sub

    Private Sub dgvPertlCl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrvFoloup.CellClick
        Dim itm As String
        Try
            itm = dgrvFoloup.Rows.Item(e.RowIndex).Cells(0).Value
        Catch ex As Exception
            Exit Sub
        End Try
        If Not itm.ToString = "" Then
            Dim row As DataGridViewRow = dgrvFoloup.Rows.Item(e.RowIndex)
            Try
                subclear()
                txtRegnID.Text = row.Cells(0).Value
                rdoUpdate.Checked = True
                txtRegnID.Enabled = False
                cmbExmPart2.Enabled = False
            Catch ex As Exception
            End Try
            Try
                For j As Integer = 0 To cmbExmPart2.Items.Count - 1
                    If cmbExmPart2.Items(j).ToString = row.Cells(1).Value Then
                        cmbExmPart2.SelectedIndex = j
                    End If
                Next
            Catch ex As Exception
            End Try
            Try
                Dim datBk As Date = row.Cells(2).Value
                dtImBkDispatch.Value = datBk
            Catch ex As Exception
            End Try
            Try
                txt2nd.Text = row.Cells(3).Value
            Catch ex As Exception
            End Try
            Try
                txt3rd.Text = row.Cells(4).Value
            Catch ex As Exception
            End Try
            Try
                txt4th.Text = row.Cells(5).Value
            Catch ex As Exception
            End Try
            Try
                txt5th.Text = row.Cells(6).Value
            Catch ex As Exception
            End Try
            Try
                txtCmnt.Text = row.Cells(7).Value
            Catch ex As Exception
            End Try
            Try
                Dim datQp As Date = row.Cells(8).Value
                dtmQpapr.Value = datQp
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub rdoInsrt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoInsrt.CheckedChanged
        If rdoInsrt.Checked = True Then
            subclear()
            txtRegnID.Enabled = True
            cmbExmPart2.Enabled = True
        End If
    End Sub
    Sub subclear()
        cmbExmPart2.SelectedIndex = 0
        txtRegnID.Text = ""
        txt2nd.Text = ""
        txt3rd.Text = ""
        txt4th.Text = ""
        txt5th.Text = ""
        txtCmnt.Text = ""
        txtAnsSheet.Text = ""
        Dim dA As Date = "01-01-2014"
        dtImBkDispatch.Value = dA
        dtmQpapr.Value = dA
    End Sub
    Private Sub rdoUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUpdate.CheckedChanged
        If rdoUpdate.Checked = True Then
            If Not txtRegnID.Text = "" Then
                txtRegnID.Enabled = False
                cmbExmPart2.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If txtRegnID.Text = "" Then
            MsgBox("Please Enter valid Registration ID", MsgBoxStyle.Critical, "Error")
        End If
        Dim qrY As String
        If rdoInsrt.Checked = True Then
            If txtRegnID.Text.Length = 0 Or cmbExmPart2.SelectedItem.ToString = "" Then
                qrY = ""
            Else
                qrY = "INSERT INTO `book_info` (`Regn_ID`,`exam_Part`,`Book_dispatch`,`2ndFollowup`,`3rdFollowup`,`4thFollowup`,`5thFollowup`,`more_Coments`,`Q_paper_disp`,`Ans_Sheet_receive`) VALUES "
                qrY += "("
                qrY += "'" & txtRegnID.Text.Replace("'", "") & "',"
                qrY += "'" & cmbExmPart2.SelectedItem.ToString & "',"
                qrY += "'" & dtImBkDispatch.Value.ToShortDateString & "',"
                qrY += "'" & txt2nd.Text.Replace("'", "") & "',"
                qrY += "'" & txt3rd.Text.Replace("'", "") & "',"
                qrY += "'" & txt4th.Text.Replace("'", "") & "',"
                qrY += "'" & txt5th.Text.Replace("'", "") & "',"
                qrY += "'" & txtCmnt.Text.Replace("'", "") & "',"
                qrY += "'" & dtmQpapr.Value.ToShortDateString & "',"
                qrY += "'" & txtAnsSheet.Text.Replace("'", "") & "'"
                qrY += ")"
            End If
        ElseIf rdoUpdate.Checked = True And txtRegnID.Text.Length > 0 Then
            If txtRegnID.Text.Length = 0 Or cmbExmPart2.SelectedItem.ToString = "" Then
                qrY = ""
            Else
                qrY = "UPDATE book_info SET " & _
                    "`Book_dispatch` = '" & dtImBkDispatch.Value.ToShortDateString & "'," & _
                    "`2ndFollowup` = '" & txt2nd.Text.Replace("'", "") & "'," & _
                    "`3rdFollowup` = '" & txt3rd.Text.Replace("'", "") & "'," & _
                    "`4thFollowup` = '" & txt4th.Text.Replace("'", "") & "'," & _
                    "`5thFollowup` = '" & txt5th.Text.Replace("'", "") & "'," & _
                    "`more_Coments` = '" & txtCmnt.Text.Replace("'", "") & "'," & _
                    "`Q_paper_disp` = '" & dtmQpapr.Value.ToShortDateString & "'," & _
                    "`Ans_Sheet_receive` = '" & txtAnsSheet.Text.Replace("'", "") & "'" & _
                    " WHERE `Regn_ID` = " & txtRegnID.Text.Replace("'", "") & " AND `exam_Part` = '" & cmbExmPart2.SelectedItem.ToString & "'"
            End If
        Else
            qrY = ""
        End If

        If Not qrY = "" Then
            Dim daGo As New OleDbDataAdapter(qrY, con1)
            Dim dsGo As New DataSet

            daGo.Fill(dsGo)
            Dim pgNoExtrct As String = txtDisplayPageNo.Text
            Dim ar As String()
            Dim pgNo As Integer
            Dim totlPg As Integer

            Try
                If pgNoExtrct.Length > 0 Then
                    Try
                        ar = pgNoExtrct.Split("/")
                        pgNo = ar(0).Replace("Page ", "")
                        totlPg = ar(1).Replace("  ", "")
                    Catch ex As Exception
                    End Try
                End If
            Catch ex As Exception
            End Try
            Call_QryBuilder()


            Try
                If pgNo > 0 And pgNo <= totlPg Then
                    For k As Integer = 1 To pgNo - 1
                        btnNextPage.PerformClick()
                    Next
                    For k As Integer = 0 To dgrvFoloup.RowCount - 1
                        If txtRegnID.Text = dgrvFoloup.Rows(k).Cells(0).Value And dgrvFoloup.Rows(k).Cells(1).Value = cmbExmPart2.SelectedItem.ToString Then
                            dgrvFoloup.Rows(k).Selected = True
                        End If
                    Next
                End If
            Catch ex As Exception
            End Try
            MsgBox("Data Updated Successfully")
            subclear()
        Else
            MsgBox("Null Query ! ! ! " & vbCrLf & " Might be any field is empty", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub
    Sub Call_QryBuilder()
        Dim executeToEnable As String = "SELECT " & book_columns & " FROM book_info WHERE Regn_ID > 0 "
        If rdoExmPrt.Enabled = True And cmbExmPart1.SelectedIndex >= 0 Then
            executeToEnable += " AND exam_Part = '" & cmbExmPart1.SelectedItem.ToString & "'"
        End If
        Dim b1, b2, q1, q2 As Date
again:
        b1 = dtPkrBkFrom.Value.ToShortDateString
        b2 = dtPkrBkTo.Value.ToShortDateString
        q1 = dtPkrQpprFrom.Value.ToShortDateString
        q2 = dtPkrQpprTo.Value.ToShortDateString

        If b1 > b2 Then
            dtPkrBkFrom.Value = b2
            dtPkrBkTo.Value = b1
            GoTo again
        End If
        If q1 > q2 Then
            dtPkrQpprFrom.Value = q2
            dtPkrQpprTo.Value = q1
            GoTo again
        End If

        If rdoBkDipatch.Checked = True Then
            executeToEnable += " AND `Book_dispatch` between #" & b1 & "# AND #" & b2 & "#"
        End If
        If rdoQppr.Checked = True Then
            executeToEnable += " AND `Q_paper_disp` between #" & q1 & "# AND #" & q2 & "#"
        End If
        executeToEnable += " ORDER BY Regn_ID ASC"
        ExtrTime(executeToEnable)
    End Sub
    Private Sub txtRegnID_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtRegnID.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub ExtrTime(ByVal sSQLx As String)
        Dim cnString As String = constr
        'Open Connection.
        Dim conn As New OleDbConnection(cnString)
        conn.Open()
        Dim cmd As New OleDbCommand(sSQLx, conn)
        cmd.CommandTimeout = 300
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        cmd.CommandTimeout = 300
        Dim dt As New DataTable
        dt.Load(reader)
        conn.Close()
        ds = New DataSet
        ds.Tables.Add(dt)
        dtSource = ds.Tables(0)
        FillGrid()
    End Sub

#Region "Paging Gridview"
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

        'If currentPage = PageCount Then
        '    recNo = pageSize * (currentPage - 2)
        'End If

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

        dgrvFoloup.DataSource = dtTemp

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
        pageSize = 20 'txtPageSize.Text
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
#End Region
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Call_QryBuilder()
    End Sub
End Class