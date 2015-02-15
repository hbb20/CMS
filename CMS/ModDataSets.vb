Imports System.Data.OleDb

Module ModDataSets
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_users.accdb;Jet OLEDB:Database Password=;"
    Dim con As New OleDbConnection(connString)
    'Process of dataset
    Function DataSet_ForFeeRpt(ByVal Studentid As Integer) As DataSet
        'Query
        Dim qry As String = "SELECT reg_table.Full_name,reg_table.Addr,City,distr,reg_table.`PIN Code`," +
                            "reg_table.Email,reg_table.Contact_No,fee_table.Recpt_No,fee_table.Fee,fee_table.Pay_mode," +
                            "fee_table.Ch_dr_no,fee_table.chk_date,fee_table.Stage FROM reg_table,fee_table " +
                            "WHERE fee_table.Regn_ID = reg_table.Regn_ID AND  reg_table.Regn_ID=" + Studentid
        'Define data adapter
        'Arguments are qury and connection
        Dim da As New OleDbDataAdapter(qry, con)
        'Define dataset
        Dim ds As New DataSet
        'fill dataset with datadapter
        da.Fill(ds)
        Return ds
    End Function
    Function DataSet_ForAddress(ByVal Studentid As Integer) As DataSet
        Dim qry As String = "SELECT Full_name,Addr,City,distr,`PIN Code`,state,Contact_No FROM reg_table WHERE Regn_ID=" + Studentid
        Dim da As New OleDbDataAdapter(qry, con)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Function dataSetTable1(ByVal Studentid As String, ByVal tablName As String) As DataTable
        If tablName = "student" Then
            Dim qry As String = "SELECT CStr(Regn_ID) AS [Rgn_ID],Full_name AS [Name],Addr AS [Address],City AS [City],distr AS [District],`PIN Code` AS [PINCODE],state AS [State],Contact_No AS [ContactNo] FROM reg_table"
            qry += " WHERE Regn_ID IN (" & Studentid & ")"
            Dim da As New OleDbDataAdapter(qry, con)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Else
            Dim qry As String = "SELECT CStr(conTctID) AS [Rgn_ID],c_Full_name AS [Name],c_Addr AS [Address],c_city AS [City],c_Distr AS [District],`c_PIN` AS [PINCODE],c_Mobil AS [ContactNo] FROM contct_table"
            qry += " WHERE conTctID IN (" & Studentid & ")"
            Dim da As New OleDbDataAdapter(qry, con)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        End If
    End Function
    'Here is dataset maker 
    'Enter Qry AS String And you will get dataset AS output
    'Eg 
    'Dim ds As New DataSet
    'ds = DataSetMaker("SELECT * FROM reg_table")
    Function DataSetMaker(ByVal Query As String) As DataSet
        Dim da As New OleDbDataAdapter(Query, con)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
End Module
