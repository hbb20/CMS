Imports System.Data.OleDb

Public Class FormReport
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim Address_DatSet As DataSet
    Private Sub FormReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Address_DatSet = AddressQuery()
    End Sub
    'DataSet Can Be Retrived Like This

    'Declare Function This Returns -v Specific type
    Function AddressQuery() As DataSet
        'Build Query
        Dim Qry As String = "SELECT `Full_name`,`Addr`,`City`,`distr`,`state`,`PIN Code`,`Contact_No` FROM `reg_table`"
        'Declare Connrection
        Dim cncTn1 As New OleDbConnection(connString)
        'Declare DataAdapter Arguments Of DataAdapter Query And Connection
        Dim dAd1 As New OleDbDataAdapter(Qry, cncTn1)
        'Declare DataSet
        Dim DtS As New DataSet
        'Fill DataSet From DataAdapter
        dAd1.Fill(DtS)
        'And You have Done congo . . . .
        Return DtS
        'Return The Value
    End Function

    Private Sub btnFeeRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeRpt.Click
        'Using Single String And Parameter You want to built Address String Like This
        'vbcrlf Used For New Line In String
        Dim Adress_build As String = AddressQuery.Tables(0).Rows(0).Item(0).ToString + vbCrLf +
                                        AddressQuery.Tables(0).Rows(0).Item(1).ToString + vbCrLf +
                                            AddressQuery.Tables(0).Rows(0).Item(2).ToString + vbCrLf +
                                                AddressQuery.Tables(0).Rows(0).Item(3).ToString

        Dim rd As New CrystalReport1
        rd.SetParameterValue(0, AddressQuery.Tables(0).Rows(0).Item(0).ToString)

    End Sub
End Class