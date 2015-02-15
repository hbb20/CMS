Imports System.Data.OleDb

Module mdl_upcmngexm
    Public Function UpcmgExm(ByVal a1 As Date, ByVal a2 As Date, ByVal exmP As String) As DataTable
        Dim Eqr As String = String.Empty

        Eqr = "SELECT * FROM `" & exmP & "` WHERE "
        Eqr += "(`lesson1_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson2_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson3_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson4_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson5_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson6_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson7_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson8_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson9_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson10_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson11_date` between #" & a1 & "# AND #" & a2 & "#) OR "
        Eqr += "(`lesson12_date` between #" & a1 & "# AND #" & a2 & "#) ORDER BY `Regn_ID` DESC"

        Dim cnX As New OleDbConnection(Input_Form.connString)
        Dim dadpt As New OleDbDataAdapter(Eqr, cnX)
        Dim dtSt As New DataSet
        dadpt.Fill(dtSt)
        Return dtSt.Tables(0)
    End Function
    Function DerivMaxBelow(ByVal dRw1 As DataRow)
        Dim datF As Date = "01-01-2040"
        Dim datG As New Date

        For i As Integer = 1 To 12
            datG = dRw1.Item("lesson" & i.ToString & "_date").ToString
            If datG > Date.Now.ToShortDateString Then
                If datF < datG Then datF = datG
            End If
        Next

        Return datF
    End Function
End Module
