Imports System.Data.OleDb
Imports System.Threading

Public Class UpkmngExm
    Public exmPr As String
    Public fnt As Font
    Dim thrd(4) As Thread
    Dim bl(5) As Boolean

    Dim clearrenceIf(4) As Boolean
    Dim tltip As New ToolTip

    Private Sub NewUpcoming()
        Dim dTbl As New DataTable
        Try
            dgrVexm.DataSource = Nothing
            dgrVexm.Rows.Clear()
        Catch ex As Exception
        End Try
        Dim a1, a2 As Date
        If rdoDur1.Checked = True Then
            a1 = dtPicker1.Value.Date.ToShortDateString
            a2 = dtPicker2.Value.Date.ToShortDateString
        Else
            a1 = Date.Now
            a2 = a1.AddMonths(6)
        End If
        Dim sql As String
        If cmbExmPrt.SelectedIndex = 0 Then
            sql = "SELECT ex_1_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_1_table.exam_Name AS [Exam Part],ex_1_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_1_table, reg_table WHERE (`ex_1_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_1_table.Regn_ID) UNION "
            sql += "SELECT ex_2_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_2_table.exam_Name AS [Exam Part],ex_2_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_2_table, reg_table WHERE (`ex_2_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_2_table.Regn_ID) UNION "
            sql += "SELECT ex_3_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_3_table.exam_Name AS [Exam Part],ex_3_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_3_table, reg_table WHERE (`ex_3_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_3_table.Regn_ID) UNION "
            sql += "SELECT ex_4_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_4_table.exam_Name AS [Exam Part],ex_4_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_4_table, reg_table WHERE (`ex_4_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_4_table.Regn_ID) "
        ElseIf cmbExmPrt.SelectedIndex = 1 Then
            sql = "SELECT ex_1_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_1_table.exam_Name AS [Exam Part],ex_1_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_1_table, reg_table WHERE (`ex_1_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_1_table.Regn_ID) "
        ElseIf cmbExmPrt.SelectedIndex = 2 Then
            sql = "SELECT ex_2_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_2_table.exam_Name AS [Exam Part],ex_2_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_2_table, reg_table WHERE (`ex_2_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_2_table.Regn_ID) "
        ElseIf cmbExmPrt.SelectedIndex = 3 Then
            sql = "SELECT ex_3_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_3_table.exam_Name AS [Exam Part],ex_3_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_3_table, reg_table WHERE (`ex_3_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_3_table.Regn_ID) "
        ElseIf cmbExmPrt.SelectedIndex = 4 Then
            sql = "SELECT ex_4_table.Regn_ID AS [Regn ID], reg_table.Full_name AS [Name], reg_table.Addr AS [Address], reg_table.City AS [City],reg_table.state AS [State],ex_4_table.exam_Name AS [Exam Part],ex_4_table.finalExmDat AS [Exam Date]"
            sql += " FROM ex_4_table, reg_table WHERE (`ex_4_table`.`finalExmDat` between #" & a1 & "# AND #" & a2 & "#) AND reg_table.Regn_ID = CInt(ex_4_table.Regn_ID) "
        Else
            sql = ""
            Exit Sub
        End If
        Dim cnX As New OleDbConnection(Input_Form.connString)
        Dim dadpt As New OleDbDataAdapter(sql, cnX)
        Dim dtSt As New DataSet
        dadpt.Fill(dtSt)
        dTbl = dtSt.Tables(0)
        AddRows(dTbl)
    End Sub
    Private Sub btnOnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnGo.Click
        Try
            For i As Integer = 0 To 3
                thrd(i).Abort()
            Next
        Catch ex As Exception
        End Try
        NewUpcoming()
        lblTotal.Text = dgrVexm.RowCount
        fnt = FontRetrive()
        Control.CheckForIllegalCrossThreadCalls = False
        For i As Integer = 0 To 3
            Dim thrd(i) As Thread
        Next
        thrd(0) = New Thread(AddressOf changFnt1)
        thrd(1) = New Thread(AddressOf changFnt2)
        thrd(2) = New Thread(AddressOf changFnt3)
        thrd(3) = New Thread(AddressOf changFnt4)
        For i As Integer = 0 To 3
            thrd(i).Start()
        Next
    End Sub
    Sub AddRows(ByVal dtable As DataTable)
        For i As Integer = 0 To dtable.Rows.Count - 1
            dgrVexm.Rows.Add(dtable.Rows(i).Item("Regn ID").ToString,
                             dtable.Rows(i).Item("Name").ToString,
                             dtable.Rows(i).Item("Address").ToString,
                             dtable.Rows(i).Item("City").ToString,
                             dtable.Rows(i).Item("State").ToString,
                             dtable.Rows(i).Item("Exam Part").ToString,
                             dtable.Rows(i).Item("Exam Date").ToString)
        Next
    End Sub
    Private Sub dtPicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtPicker2.ValueChanged
        If dtPicker2.Value.Date < dtPicker1.Value.Date Then
            MsgBox("last date cannot be less than first date")
            btnOnGo.Enabled = False
        Else
            btnOnGo.Enabled = True
        End If
    End Sub
    Private Sub UpkmngExm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtPicker1.Format = DateTimePickerFormat.Custom
        dtPicker1.CustomFormat = "dd-MM-yyyy"
        dtPicker1.Value = DateTime.Now.Date.ToShortDateString
        dtPicker2.Format = DateTimePickerFormat.Custom
        dtPicker2.CustomFormat = "dd-MM-yyyy"
        dtPicker2.Value = DateTime.Now.Date.AddMonths(1).ToShortDateString

        cmbExmPrt.SelectedIndex = 0
        For j As Integer = 1 To 4
            bl(j) = New Boolean
            clearrenceIf(j) = New Boolean
            bl(j) = False
            clearrenceIf(j) = False
        Next
        Setprogress()
    End Sub

#Region "Font Changes"
    Sub changFnt1()
        For i As Integer = 0 To dgrVexm.Rows.Count - 1
Retun:
            Try
                dgrVexm.Rows(i).Cells(1).Style.Font = fnt
            Catch ex As Exception
                GoTo Retun
            End Try
        Next
    End Sub
    Sub changFnt2()
        For i As Integer = 0 To dgrVexm.Rows.Count - 1
Retun:
            Try
                dgrVexm.Rows(i).Cells(2).Style.Font = fnt
            Catch ex As Exception
                GoTo Retun
            End Try
        Next
    End Sub
    Sub changFnt3()
        For i As Integer = 0 To dgrVexm.Rows.Count - 1
Retun:
            Try
                dgrVexm.Rows(i).Cells(3).Style.Font = fnt
            Catch ex As Exception
                GoTo Retun
            End Try
        Next
    End Sub
    Sub changFnt4()
        For i As Integer = 0 To dgrVexm.Rows.Count - 1
Retun:
            Try
                dgrVexm.Rows(i).Cells(4).Style.Font = fnt
            Catch ex As Exception
                GoTo Retun
            End Try
        Next
    End Sub
#End Region

    Private Sub UpkmngExm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            For i As Integer = 0 To 3
                thrd(i).Abort()
            Next
        Catch ex As Exception
        End Try
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        Try
            For i As Integer = 0 To 3
                thrd(i).Abort()
            Next
        Catch ex As Exception
        End Try
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub btnlblPrnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlblPrnt.Click
        Dim toPrint As Integer = 0

        Dim j As Integer = 0
        For i As Integer = 0 To dgrVexm.RowCount - 1
            toPrint += 1
            If j = 0 Then
                Report_Viewer.incomingAry = dgrVexm.Rows(i).Cells(0).Value.ToString
            Else
                Report_Viewer.incomingAry += "," + dgrVexm.Rows(i).Cells(0).Value.ToString
            End If
            j += 1
        Next
        If toPrint > 0 Then
            Report_Viewer.studentOrContct = "student"
            Report_Viewer.Show()
        Else
            MsgBox("Please Select Atleast one contact from checkbox", MsgBoxStyle.Exclamation, "Alert")
        End If
    End Sub
    Private Sub dtPicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtPicker1.ValueChanged
        If dtPicker1.Value > dtPicker2.Value Then
            dtPicker2.Value = dtPicker1.Value.Date.AddMonths(1)
        End If
    End Sub
    Private Sub txtPincode_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtRgnID.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtRgnID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRgnID.TextChanged
        Dim regnId As String = txtRgnID.Text.Replace("'", "")
        Dim qry As String
        qry = "SELECT * FROM ex_1_table WHERE Regn_ID = '" & regnId & "' UNION "
        qry += "SELECT * FROM ex_2_table WHERE Regn_ID = '" & regnId & "' UNION "
        qry += "SELECT * FROM ex_3_table WHERE Regn_ID = '" & regnId & "' UNION "
        qry += "SELECT * FROM ex_4_table WHERE Regn_ID = '" & regnId & "'"

        Dim cnX As New OleDbConnection(Input_Form.connString)
        Dim dadpt As New OleDbDataAdapter(qry, cnX)
        Dim dtSt As New DataSet
        dadpt.Fill(dtSt)
        FillDataExams(dtSt.Tables(0))
    End Sub
    Private Sub FillDataExams(ByVal daTatable As DataTable)
        For j As Integer = 1 To 4
            bl(j) = New Boolean
            clearrenceIf(j) = New Boolean
            bl(j) = False
            clearrenceIf(j) = False
        Next
        For Each datRow As DataRow In daTatable.Rows
            If datRow.Item("exam_Name").ToString = "प्रवेशः" Then
                bl(1) = True
                p1l1.Text = datRow.Item("lesson1_mrk").ToString
                p1l2.Text = datRow.Item("lesson2_mrk").ToString
                p1l3.Text = datRow.Item("lesson3_mrk").ToString
                p1l4.Text = datRow.Item("lesson4_mrk").ToString
                p1l5.Text = datRow.Item("lesson5_mrk").ToString
                p1l6.Text = datRow.Item("lesson6_mrk").ToString
                p1l7.Text = datRow.Item("lesson7_mrk").ToString
                p1l8.Text = datRow.Item("lesson8_mrk").ToString
                p1l9.Text = datRow.Item("lesson9_mrk").ToString
                p1l10.Text = datRow.Item("lesson10_mrk").ToString
                p1fex.Text = datRow.Item("finalExmMrks").ToString
                p1fexSts.Text = datRow.Item("upkmng").ToString
                If datRow.Item("upkmng").ToString = "Pass" Then
                    pctr1.Image = My.Resources.Res_prg.success
                    clearrenceIf(1) = True
                ElseIf datRow.Item("upkmng").ToString = "Fail" Then
                    pctr1.Image = My.Resources.Res_prg.fail
                End If
            ElseIf datRow.Item("exam_Name").ToString = "परिचयः" Then
                bl(2) = True
                p2l1.Text = datRow.Item("lesson1_mrk").ToString
                p2l2.Text = datRow.Item("lesson2_mrk").ToString
                p2l3.Text = datRow.Item("lesson3_mrk").ToString
                p2l4.Text = datRow.Item("lesson4_mrk").ToString
                p2l5.Text = datRow.Item("lesson5_mrk").ToString
                p2l6.Text = datRow.Item("lesson6_mrk").ToString
                p2l7.Text = datRow.Item("lesson7_mrk").ToString
                p2l8.Text = datRow.Item("lesson8_mrk").ToString
                p2l9.Text = datRow.Item("lesson9_mrk").ToString
                p2l10.Text = datRow.Item("lesson10_mrk").ToString
                p2fex.Text = datRow.Item("finalExmMrks").ToString
                p2fexSts.Text = datRow.Item("upkmng").ToString
                If datRow.Item("upkmng").ToString = "Pass" Then
                    clearrenceIf(2) = True
                    pctr2.Image = My.Resources.Res_prg.success
                ElseIf datRow.Item("upkmng").ToString = "Fail" Then
                    pctr2.Image = My.Resources.Res_prg.fail
                End If
            ElseIf datRow.Item("exam_Name").ToString = "शिक्षा" Then
                bl(3) = True
                p3l1.Text = datRow.Item("lesson1_mrk").ToString
                p3l2.Text = datRow.Item("lesson2_mrk").ToString
                p3l3.Text = datRow.Item("lesson3_mrk").ToString
                p3l4.Text = datRow.Item("lesson4_mrk").ToString
                p3l5.Text = datRow.Item("lesson5_mrk").ToString
                p3l6.Text = datRow.Item("lesson6_mrk").ToString
                p3l7.Text = datRow.Item("lesson7_mrk").ToString
                p3l8.Text = datRow.Item("lesson8_mrk").ToString
                p3l9.Text = datRow.Item("lesson9_mrk").ToString
                p3l10.Text = datRow.Item("lesson10_mrk").ToString
                p3fex.Text = datRow.Item("finalExmMrks").ToString
                p3fexSts.Text = datRow.Item("upkmng").ToString
                If datRow.Item("upkmng").ToString = "Pass" Then
                    clearrenceIf(3) = True
                    pctr3.Image = My.Resources.Res_prg.success
                ElseIf datRow.Item("upkmng").ToString = "Fail" Then
                    pctr3.Image = My.Resources.Res_prg.fail
                End If
            ElseIf datRow.Item("exam_Name").ToString = "कोविदः" Then
                bl(4) = True
                p4l1.Text = datRow.Item("lesson1_mrk").ToString
                p4l2.Text = datRow.Item("lesson2_mrk").ToString
                p4l3.Text = datRow.Item("lesson3_mrk").ToString
                p4l4.Text = datRow.Item("lesson4_mrk").ToString
                p4l5.Text = datRow.Item("lesson5_mrk").ToString
                p4l6.Text = datRow.Item("lesson6_mrk").ToString
                p4l7.Text = datRow.Item("lesson7_mrk").ToString
                p4l8.Text = datRow.Item("lesson8_mrk").ToString
                p4l9.Text = datRow.Item("lesson9_mrk").ToString
                p4l10.Text = datRow.Item("lesson10_mrk").ToString
                p4fex.Text = datRow.Item("finalExmMrks").ToString
                p4fexSts.Text = datRow.Item("upkmng").ToString
                If datRow.Item("upkmng").ToString = "Pass" Then
                    clearrenceIf(4) = True
                    pctr4.Image = My.Resources.Res_prg.success
                ElseIf datRow.Item("upkmng").ToString = "Fail" Then
                    pctr4.Image = My.Resources.Res_prg.fail
                End If
            End If
        Next
        Highlightblanks()
        Clear()
        Setprogress()
    End Sub
    Private Sub Highlightblanks()
        Dim labelList As New List(Of Control)
        labelList = GetAllControls(Of Label)(Me)
        For index As Integer = 0 To labelList.Count - 1
            For k As Integer = 1 To 4
                For j As Integer = 1 To 10
                    If (labelList.Item(index).Name = "p" & k.ToString & "l" & j.ToString) Or
                        (labelList.Item(index).Name = "p" & k.ToString & "fex") Or
                        (labelList.Item(index).Name = "p" & k.ToString & "fexSts") Then
                        If labelList.Item(index).Text = "" Then
                            labelList.Item(index).BackColor = Color.LightGray
                        End If
                        If labelList.Item(index).Text = "Fail" Then
                            labelList.Item(index).ForeColor = Color.DarkRed
                            labelList.Item(index).Font = New Font("Consolas", 10, FontStyle.Bold)
                        End If
                    End If
                Next
            Next
        Next
    End Sub
    Sub Clear()
        Dim labelList As New List(Of Control)
        labelList = GetAllControls(Of Label)(Me)
        Dim newClear As New List(Of Integer)
        If bl(1) = False Then
            For index As Integer = 0 To labelList.Count - 1
                For j As Integer = 1 To 10
                    If (labelList.Item(index).Name = "p1l" & j.ToString) Or
                        (labelList.Item(index).Name = "p1fex") Or
                        (labelList.Item(index).Name = "p1fexSts") Then
                        labelList.Item(index).Text = ""
                        labelList.Item(index).BackColor = Color.White
                        labelList.Item(index).ForeColor = Color.Black
                        labelList.Item(index).Font = New Font("Consolas", 10, FontStyle.Regular)
                    End If
                Next
            Next
            pctr1.Image = My.Resources.Res_prg.fail
        End If
        If bl(2) = False Then
            For index As Integer = 0 To labelList.Count - 1
                For j As Integer = 1 To 10
                    If (labelList.Item(index).Name = "p2l" & j.ToString) Or
                        (labelList.Item(index).Name = "p2fex") Or
                        (labelList.Item(index).Name = "p2fexSts") Then
                        labelList.Item(index).Text = ""
                        labelList.Item(index).BackColor = Color.White
                        labelList.Item(index).ForeColor = Color.Black
                        labelList.Item(index).Font = New Font("Consolas", 10, FontStyle.Regular)
                    End If
                Next
            Next
            pctr2.Image = My.Resources.Res_prg.fail
        End If
        If bl(3) = False Then
            For index As Integer = 0 To labelList.Count - 1
                For j As Integer = 1 To 10
                    If (labelList.Item(index).Name = "p3l" & j.ToString) Or
                        (labelList.Item(index).Name = "p3fex") Or
                        (labelList.Item(index).Name = "p3fexSts") Then
                        labelList.Item(index).Text = ""
                        labelList.Item(index).BackColor = Color.White
                        labelList.Item(index).ForeColor = Color.Black
                        labelList.Item(index).Font = New Font("Consolas", 10, FontStyle.Regular)
                    End If
                Next
            Next
            pctr3.Image = My.Resources.Res_prg.fail
        End If
        If bl(4) = False Then
            For index As Integer = 0 To labelList.Count - 1
                For j As Integer = 1 To 10
                    If (labelList.Item(index).Name = "p4l" & j.ToString) Or
                        (labelList.Item(index).Name = "p4fex") Or
                        (labelList.Item(index).Name = "p4fexSts") Then
                        labelList.Item(index).Text = ""
                        labelList.Item(index).BackColor = Color.White
                        labelList.Item(index).ForeColor = Color.Black
                        labelList.Item(index).Font = New Font("Consolas", 10, FontStyle.Regular)
                    End If
                Next
            Next
            pctr4.Image = My.Resources.Res_prg.fail
        End If
    End Sub
    Sub Setprogress()
        If clearrenceIf(1) = True Then
            pctrPrt1.Image = My.Resources.Res_prg.green
        Else
            pctrPrt1.Image = My.Resources.Res_prg.red
        End If
        If clearrenceIf(2) = True Then
            pctrPrt2.Image = My.Resources.Res_prg.green
        Else
            pctrPrt2.Image = My.Resources.Res_prg.red
        End If
        If clearrenceIf(3) = True Then
            pctrPrt3.Image = My.Resources.Res_prg.green
        Else
            pctrPrt3.Image = My.Resources.Res_prg.red
        End If
        If clearrenceIf(4) = True Then
            pctrPrt4.Image = My.Resources.Res_prg.green
        Else
            pctrPrt4.Image = My.Resources.Res_prg.red
        End If
        If (bl(1) = False) And (bl(2) = False) And (bl(3) = False) And (bl(4) = False) Then
            'MsgBox("No Exam Given or invalid Registration ID", MsgBoxStyle.Exclamation, "Sorry")
        End If
        If bl(1) = False Then
            DrawLineFloat(97, 55)
        Else
            RemoveLineFloat(97, 55)
        End If
        If bl(2) = False Then
            DrawLineFloat(333, 55)
        Else
            RemoveLineFloat(333, 55)
        End If
        If bl(3) = False Then
            DrawLineFloat(576, 55)
        Else
            RemoveLineFloat(576, 55)
        End If
        If bl(4) = False Then
            DrawLineFloat(821, 55)
        Else
            RemoveLineFloat(821, 55)
        End If

        DrawLine()
    End Sub
    Public Sub DrawLineFloat(ByVal x As Integer, ByVal y As Integer)
        Dim blackPen As New Pen(Color.Black, 2)
        Dim g As Graphics = TabPage2.CreateGraphics
        g.DrawEllipse(blackPen, x, y, 23, 23)
        blackPen.Dispose()
        '101, 59  16,16
    End Sub
    Public Sub RemoveLineFloat(ByVal x As Integer, ByVal y As Integer)
        Dim blackPen As New Pen(Color.White, 2)
        Dim g As Graphics = TabPage2.CreateGraphics
        g.DrawEllipse(blackPen, x, y, 23, 23)
        blackPen.Dispose()
        '101, 59  16,16
    End Sub
    Public Sub DrawLine()
        Dim blackPen As New Pen(Color.Black, 1)
        Dim g As Graphics = TabPage2.CreateGraphics
        g.DrawLine(blackPen, 114, 66, 334, 66)
        g.DrawLine(blackPen, 350, 66, 580, 66)
        g.DrawLine(blackPen, 592, 66, 822, 66)
        blackPen.Dispose()
    End Sub
    '101, 59
    '16 16
#Region "Remove Tootltip"
    Private Sub pctrPrt1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt1.MouseHover
        tltip.RemoveAll()
        pctrPrt1.Size = New Size(18, 18)
        pctrPrt1.Location = New Point(100, 58)
        pctrPrt1.SizeMode = PictureBoxSizeMode.StretchImage
        If bl(1) = True And clearrenceIf(1) = True Then
            tltip.SetToolTip(pctrPrt1, "Exam First Part Exam Cleared")
        ElseIf bl(1) = True And clearrenceIf(1) = False Then
            tltip.SetToolTip(pctrPrt1, "Exam First Part Exam Failed")
        ElseIf bl(1) = False Then
            tltip.SetToolTip(pctrPrt1, "Exam First Part Exam Yet to be given")
        End If
    End Sub
    Private Sub pctrPrt1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt1.MouseLeave
        pctrPrt1.Size = New Size(16, 16)
        pctrPrt1.Location = New Point(101, 59)
        Setprogress()
    End Sub
    Private Sub pctrPrt2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt2.MouseHover
        tltip.RemoveAll()
        pctrPrt2.Size = New Size(18, 18)
        pctrPrt2.Location = New Point(336, 58)
        pctrPrt2.SizeMode = PictureBoxSizeMode.StretchImage
        If bl(2) = True And clearrenceIf(2) = True Then
            tltip.SetToolTip(pctrPrt2, "Exam Second Part Exam Cleared")
        ElseIf bl(2) = True And clearrenceIf(2) = False Then
            tltip.SetToolTip(pctrPrt2, "Exam Second Part Exam Failed")
        ElseIf bl(2) = False Then
            tltip.SetToolTip(pctrPrt2, "Exam Second Part Exam Yet to be given")
        End If
    End Sub
    Private Sub pctrPrt2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt2.MouseLeave
        pctrPrt2.Size = New Size(16, 16)
        pctrPrt2.Location = New Point(337, 59)
        Setprogress()
    End Sub

    Private Sub pctrPrt3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt3.MouseHover
        tltip.RemoveAll()
        pctrPrt3.Size = New Size(18, 18)
        pctrPrt3.Location = New Point(579, 58)
        pctrPrt3.SizeMode = PictureBoxSizeMode.StretchImage
        If bl(3) = True And clearrenceIf(3) = True Then
            tltip.SetToolTip(pctrPrt3, "Exam Third Part Exam Cleared")
        ElseIf bl(3) = True And clearrenceIf(3) = False Then
            tltip.SetToolTip(pctrPrt3, "Exam Third Part Exam Failed")
        ElseIf bl(3) = False Then
            tltip.SetToolTip(pctrPrt3, "Exam Third Part Exam Yet to be given")
        End If
    End Sub
    Private Sub pctrPrt3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt3.MouseLeave
        pctrPrt3.Size = New Size(16, 16)
        pctrPrt3.Location = New Point(580, 59)
        Setprogress()
    End Sub


    Private Sub pctrPrt4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt4.MouseHover
        tltip.RemoveAll()
        pctrPrt4.Size = New Size(18, 18)
        pctrPrt4.Location = New Point(824, 58)
        pctrPrt4.SizeMode = PictureBoxSizeMode.StretchImage
        If bl(3) = True And clearrenceIf(3) = True Then
            tltip.SetToolTip(pctrPrt4, "Exam Fourth Part Exam Cleared")
        ElseIf bl(3) = True And clearrenceIf(3) = False Then
            tltip.SetToolTip(pctrPrt4, "Exam Fourth Part Exam Failed")
        ElseIf bl(3) = False Then
            tltip.SetToolTip(pctrPrt4, "Exam Fourth Part Exam Yet to be given")
        End If
    End Sub
    Private Sub pctrPrt4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPrt4.MouseLeave
        pctrPrt4.Size = New Size(16, 16)
        pctrPrt4.Location = New Point(825, 59)
        Setprogress()
    End Sub
#End Region

End Class