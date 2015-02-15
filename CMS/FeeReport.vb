Imports System.Data.OleDb

Public Class FeeReport
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"

    Private Sub FeeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sQry As String = "SELECT Recpt_No AS [Receipt No.] FROM fee_table ORDER BY ID"
        Dim con As New OleDbConnection(connString)
        Dim da As New OleDbDataAdapter(sQry, con)
        Dim ds As New DataSet
        da.Fill(ds)
        dgrvFee.DataSource = ds.Tables(0)
    End Sub
    Sub loopFor()
        For l As Integer = 0 To dgrvFee.RowCount - 1

        Next
    End Sub


End Class