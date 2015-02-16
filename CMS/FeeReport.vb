Imports System.Data.OleDb

Public Class FeeReport
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"

    Private Sub FeeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sQry As String = "SELECT ID,Recpt_No AS [Receipt No],Regn_ID AS [Regn ID],Fee,Pay_mode AS [Pay Mode],Ch_dr_no AS [Cheque Or Draft No],chk_date AS [Date],Stage,BankName FROM fee_table ORDER BY ID ASC"
        Dim con As New OleDbConnection(connString)
        Dim da As New OleDbDataAdapter(sQry, con)
        Dim ds As New DataSet
        da.Fill(ds)
        dgrvFee.DataSource = ds.Tables(0)
        dgrvFee.Columns(0).Width = 100
        dgrvFee.Columns(1).Width = 100
        dgrvFee.Columns(2).Width = 100
        dgrvFee.Columns(3).Width = 100

    End Sub
    Sub loopFor()
        For l As Integer = 0 To dgrvFee.RowCount - 1
            If dgrvFee.Rows(l).Cells(2).Value.ToString = "-1" Then
                dgrvFee.Rows(l).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub


End Class