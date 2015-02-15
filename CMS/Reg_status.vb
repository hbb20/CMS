Imports System.Data.OleDb

Public Class Reg_status
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim a1, a2 As Date
    Public tabl1, tabl2, tabl3, tabl4, tabl5 As New DataTable
    Public totalRegs As Integer = 0
    Public male, female As Integer
    Public enableDating As Boolean
    Public fromDate As String = "Begining"
    Public toDate As String = "End"


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
    Sub clear()
        Try
            dgrvDistr.DataSource = Nothing
            dgrvEdu.DataSource = Nothing
            dgrvQuol.DataSource = Nothing
            dgrvState.DataSource = Nothing
            dgrvContct.DataSource = Nothing
        Catch ex As Exception
        End Try
        lblMale.Text = "-"
        lblFemale.Text = "-"
        lblTotal.Text = "-"

        tabl1 = New DataTable
        tabl2 = New DataTable
        tabl3 = New DataTable
        tabl4 = New DataTable
        tabl4 = New DataTable
        tabl5 = New DataTable

        lblTotal.Text = "-"
        lblMale.Text = "-"
        lblFemale.Text = "-"
      
    End Sub
    Private Sub Reg_status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a1 = dtPkrFrm.Value.ToShortDateString
        a2 = dtPkrTo.Value.ToShortDateString
        If a1.Date.ToShortDateString = Date.Now.ToShortDateString And a1.Date.ToShortDateString = Date.Now.ToShortDateString Then
            enableDating = False
        End If
        totalRegs = Convert.ToInt32(CountTotal())
       InitCount()
        As_Font()
        Try
            Input_Form.thrdBuffr.Abort()

        Catch ex As Exception

        End Try
      
End Sub
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        clear()
        a1 = dtPkrFrm.Value.ToShortDateString
        a2 = dtPkrTo.Value.ToShortDateString
        If a1.Date.ToShortDateString = Date.Now.ToShortDateString And a1.Date.ToShortDateString = Date.Now.ToShortDateString Then
            MsgBox("Please select date interval")
            enableDating = False
        Else
            enableDating = True
        End If

        totalRegs = Convert.ToInt32(CountTotal())
        InitCount()
        As_Font()
    End Sub
    Sub As_Font()
        Dim fnt As Font = FontRetrive()
        Dim style As New DataGridViewCellStyle
        style.Font = New Font("Consolas", 12, FontStyle.Regular)
        dgrvEdu.Font = fnt
        dgrvQuol.Font = fnt
        dgrvDistr.Font = fnt
        dgrvState.Font = fnt
        dgrvContct.Font = fnt

        dgrvEdu.Columns(0).HeaderText = "Education"
        dgrvEdu.Columns(1).HeaderText = "Count"
        dgrvEdu.Columns(0).HeaderCell.Style = style
        dgrvEdu.Columns(1).HeaderCell.Style = style

        dgrvQuol.Columns(0).HeaderText = "Qucalification"
        dgrvQuol.Columns(1).HeaderText = "Count"
        dgrvQuol.Columns(0).HeaderCell.Style = style
        dgrvQuol.Columns(1).HeaderCell.Style = style

        dgrvDistr.Columns(0).HeaderText = "District"
        dgrvDistr.Columns(1).HeaderText = "Count"
        dgrvDistr.Columns(0).HeaderCell.Style = style
        dgrvDistr.Columns(1).HeaderCell.Style = style

        dgrvState.Columns(0).HeaderText = "State"
        dgrvState.Columns(1).HeaderText = "Count"
        dgrvState.Columns(0).HeaderCell.Style = style
        dgrvState.Columns(1).HeaderCell.Style = style

        dgrvContct.Columns(0).HeaderText = "Contact ID"
        dgrvContct.Columns(1).HeaderText = "Count"
        dgrvContct.Columns(0).HeaderCell.Style = style
        dgrvContct.Columns(1).HeaderCell.Style = style

    End Sub
    Sub RenameTable()
        tabl1.Columns(0).ColumnName = "Educol1"
        tabl1.Columns(1).ColumnName = "Educol2"
        tabl2.Columns(0).ColumnName = "Quolcol1"
        tabl2.Columns(1).ColumnName = "Quolcol2"
        tabl3.Columns(0).ColumnName = "Statecol1"
        tabl3.Columns(1).ColumnName = "Statecol2"
        tabl4.Columns(0).ColumnName = "Distrcol1"
        tabl4.Columns(1).ColumnName = "Distrcol2"
        tabl5.Columns(0).ColumnName = "ContactCol1"
        tabl5.Columns(1).ColumnName = "ContactCol2"
    End Sub
    Public Sub InitCount()
        tabl1 = TablCreaTor(tabl1, "Educol1", "Educol2")
        tabl2 = TablCreaTor(tabl2, "Quolcol1", "Quolcol2")
        tabl3 = TablCreaTor(tabl3, "Statecol1", "Statecol2")
        tabl4 = TablCreaTor(tabl4, "Distrcol1", "Distrcol2")
        tabl5 = TablCreaTor(tabl5, "ContactCol1", "ContactCol2")

        CountMaleFemale()
     
        Educ_Count()
        QualWise()
        statEWise()
        DistrWise()
        ContactIdgroup()

        RenameTable()

        dgrvEdu.DataSource = tabl1
        dgrvQuol.DataSource = tabl2
        dgrvState.DataSource = tabl3
        dgrvDistr.DataSource = tabl4
        dgrvContct.DataSource = tabl5

        As_Font()
        Try
            lblTotal.Text = totalRegs.ToString
            lblMale.Text = male.ToString
            lblFemale.Text = female.ToString
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub Educ_Count()
        Dim qr1 As String = ""
        qr1 = "SELECT `Education` , Count(`Education`) AS `Count` FROM reg_table"
        If enableDating = True Then
            qr1 += " WHERE (`regn_Date` between #" & a1 & "# AND #" & a2 & "#)"
        End If
        qr1 += " GROUP BY `Education` ORDER BY Count(`Education`) DESC"
       
        Dim dTabl As DataTable = QryExcut(qr1)
        tabl1 = dTabl
again:
        For m As Integer = 0 To tabl1.Rows.Count - 1
            If tabl1.Rows(m).Item(1).ToString = "0" Or tabl1.Rows(m).Item(1).ToString = "" Then
                tabl1.Rows.RemoveAt(m)
                GoTo again
            End If
            If tabl1.Rows(m).Item(0).ToString = "" Then
                tabl1.Rows(m).Item(0) = "अन्य"
            End If
        Next
        tabl1.AcceptChanges()
    End Sub
    Sub statEWise()
        Dim qr1 As String = ""
        qr1 = "SELECT `state` AS `State`, Count(`state`) AS `Count` FROM reg_table"
        If enableDating = True Then
            qr1 += " WHERE (`regn_Date` between #" & a1 & "# AND #" & a2 & "#)"
        End If
        qr1 += " GROUP BY `state` ORDER BY Count(`state`) DESC"
        Dim dTabl As DataTable = QryExcut(qr1)
        Dim countOthr As String = 0
        tabl3 = dTabl
again:
        For m As Integer = 0 To tabl3.Rows.Count - 1
            If tabl3.Rows(m).Item(1).ToString = "0" Or tabl3.Rows(m).Item(1).ToString = "" Then
                tabl3.Rows.RemoveAt(m)
                GoTo again
            End If
            If tabl3.Rows(m).Item(0).ToString = "" Then
                tabl3.Rows(m).Item(0) = "अन्य"
            End If
        Next
        tabl3.AcceptChanges()

    End Sub
    Sub DistrWise()
        Dim qr1 As String = ""
        qr1 = "SELECT `distr` AS `District`, Count(`distr`) AS `Count` FROM reg_table"
        If enableDating = True Then
            qr1 += " WHERE (`regn_Date` between #" & a1 & "# AND #" & a2 & "#)"
        End If
        qr1 += " GROUP BY `distr` ORDER BY Count(`distr`) DESC"
        Dim dTabl As DataTable = QryExcut(qr1)
        tabl4 = dTabl
again:
        For m As Integer = 0 To tabl4.Rows.Count - 1
            If tabl4.Rows(m).Item(1).ToString = "0" Or tabl4.Rows(m).Item(1).ToString = "" Then
                tabl4.Rows.RemoveAt(m)
                GoTo again
            End If
            If tabl4.Rows(m).Item(0).ToString = "" Then
                tabl4.Rows(m).Item(0) = "अन्य"
            End If
        Next
        tabl4.AcceptChanges()
    End Sub
    Sub QualWise()
        Dim qr1 As String = ""
        qr1 = "SELECT `Qualification` , Count(`Qualification`) AS `Count` FROM reg_table"
        If enableDating = True Then
            qr1 += " WHERE (`regn_Date` between #" & a1 & "# AND #" & a2 & "#)"
        End If
        qr1 += " GROUP BY `Qualification` ORDER BY Count(`Qualification`) DESC"
        Dim dTabl As DataTable = QryExcut(qr1)
        tabl2 = dTabl
again:
        For m As Integer = 0 To tabl2.Rows.Count - 1
            If tabl2.Rows(m).Item(1).ToString = "0" Or tabl2.Rows(m).Item(1).ToString = "" Then
                tabl2.Rows.RemoveAt(m)
                GoTo again
            End If
            If tabl2.Rows(m).Item(0).ToString = "" Then
                tabl2.Rows(m).Item(0) = "अन्य"
            End If
        Next
        tabl2.AcceptChanges()
    End Sub
    Sub ContactIdgroup()
        Dim qr1 As String = ""
        qr1 = "SELECT `conTctID` AS `ContactID`, Count(`conTctID`) AS `Count` FROM reg_table"
        If enableDating = True Then
            qr1 += " WHERE (`regn_Date` between #" & a1 & "# AND #" & a2 & "#)"
        End If
        qr1 += " GROUP BY `conTctID` ORDER BY Count(`conTctID`) DESC"
        Dim dTabl As DataTable = QryExcut(qr1)
        Dim countOthr As String = 0
        tabl5 = dTabl
again:
        For m As Integer = 0 To tabl5.Rows.Count - 1
            If tabl5.Rows(m).Item(1).ToString = "0" Or tabl5.Rows(m).Item(1).ToString = "" Then
                tabl5.Rows.RemoveAt(m)
                GoTo again
            End If
            If tabl5.Rows(m).Item(0).ToString = "" Then
                tabl5.Rows(m).Item(0) = "अन्य"
            End If
        Next
        tabl5.AcceptChanges()
    End Sub

    Function TablCreaTor(ByVal tablName As DataTable, ByVal col1 As String, ByVal col2 As String) As DataTable
        tablName.Columns.Add(col1)
        tablName.Columns.Add(col2)
        Return tablName
    End Function
    Function qryitemTrim(ByVal inStr As String) As String
        inStr = inStr.Replace(vbLf, "")
        inStr = inStr.Replace(vbCrLf, "")
        inStr = inStr.Replace(vbNewLine, "")
        inStr = inStr.Replace(vbTab, "")
        inStr = inStr.Replace(vbCr, "")
        Return inStr
    End Function
    Function qryitemTrim2(ByVal inStr As String) As String
        inStr = inStr.Replace(vbLf, "")
        inStr = inStr.Replace(vbCrLf, "")
        inStr = inStr.Replace(vbNewLine, "")
        inStr = inStr.Replace(vbTab, "")
        inStr = inStr.Replace(vbCr, "")
        Try
            inStr = inStr.Substring(Len(inStr), Len(inStr) - 2)
        Catch ex As Exception
        End Try
        Return inStr
    End Function
    Private Sub btnGenrtRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenrtRpt.Click
        Report_Viewer.wway = 2
        If dtPkrFrm.Value.ToShortDateString = DateTime.Now.ToShortDateString And dtPkrTo.Value.ToShortDateString = DateTime.Now.ToShortDateString Then
        Else

            fromDate = dtPkrFrm.Value.ToShortDateString
            toDate = dtPkrTo.Value.ToShortDateString
        End If
        Report_Viewer.Show()
    End Sub
    Function CountTotal() As String
        Dim qr As String = ""
        qr = "SELECT COUNT(*) FROM reg_table"
        If enableDating = True Then
            qr += " WHERE (`regn_Date` between #" & a1 & "# AND #" & a2 & "#)"
        End If

        Dim dTabl As DataTable = QryExcut(qr)
        Dim count As String
        Try
            count = dTabl.Rows(0).Item(0).ToString
        Catch ex As Exception
            count = 0
        End Try
        Return count
    End Function
    Function CountMaleFemale() As List(Of String)
        Dim qrAl As String = ""
        qrAl += "SELECT SUM(Switch(`Gender` Like 'Female', 1)) AS [Females],SUM(Switch(`Gender` Like 'Male', 1)) AS [Males]  FROM reg_table"
        If enableDating = True Then
            qrAl += " WHERE (`regn_Date` between #" & a1 & "# AND #" & a2 & "#)"
        End If
        Dim dTabl As DataTable = QryExcut(qrAl)

        Dim count As New List(Of String)
        Try
            If Not dTabl.Rows(0).Item(0).ToString = "" Then
                count.Add(dTabl.Rows(0).Item(0).ToString)
            Else
                count.Add("0")
            End If
            If Not dTabl.Rows(0).Item(1).ToString = "" Then
                count.Add(dTabl.Rows(0).Item(1).ToString)
            Else
                count.Add("0")
            End If

        Catch ex As Exception
            count.Add("0")
            count.Add("0")
        End Try
        Try
            female = count.Item(0)
        Catch ex As Exception
            female = 0
        End Try
        male = count.Item(1)
        Return count
    End Function
   
    Function QryExcut(ByVal qr As String) As DataTable
        Dim con As New OleDbConnection(connString)
        Dim da As New OleDbDataAdapter(qr, con)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Class

Public Class MyTooltip
    Inherits ToolTip
    Sub New()
        MyBase.New()
        Me.OwnerDraw = True
        AddHandler Me.Draw, AddressOf OnDraw
    End Sub
    Public Sub New(ByVal Cont As System.ComponentModel.IContainer)
        MyBase.New(Cont)
        Me.OwnerDraw = True
        AddHandler Me.Draw, AddressOf OnDraw
    End Sub
    Private Sub OnDraw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
        Dim newArgs As DrawToolTipEventArgs = New DrawToolTipEventArgs( _
           e.Graphics, _
           e.AssociatedWindow, _
           e.AssociatedControl, _
           e.Bounds, _
           e.ToolTipText, _
           Color.LightGray, _
           Me.ForeColor, _
           New Font("B Bharati Kautilya", 14))

        newArgs.DrawBackground()
        'newArgs.DrawBorder()
        newArgs.DrawText()
    End Sub
End Class