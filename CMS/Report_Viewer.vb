Public Class Report_Viewer
    Public incomingAry As String
    Public wway As Integer = 0
    Public studentOrContct As String

    Public rgnId As String
    Public exmPart As String
    Public StudntName As String
    Public exmMarks As String

    Private Sub Report_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If wway = 0 Then
            Dim rptv As New CrystalReport1
            If studentOrContct = "student" Then
                rptv.SetDataSource(dataSetTable1(incomingAry, "student"))
            Else
                rptv.SetDataSource(dataSetTable1(incomingAry, "contact"))
            End If
            CrystalReportViewer1.ReportSource = rptv

        ElseIf wway = 1 Then
            If Fee_Details.recptTabl.Rows.Count <= 0 Then
                Exit Sub
            End If
            Dim dtAbl As New DataTable
            dtAbl = Fee_Details.recptTabl
            Dim rcptNo As String = dtAbl.Rows(0).Item("Recpt_No").ToString
            Dim receipt_date As String = dtAbl.Rows(0).Item("chk_date").ToString

            Dim prefix As String
            If dtAbl.Rows(0).Item("Gender").ToString = "Male" Then
                prefix = "श्री"
            Else
                prefix = "श्रीमती"
            End If

            Dim fullname As String = dtAbl.Rows(0).Item("Full_name").ToString

            Dim exmName As String
            If dtAbl.Rows(0).Item("Stage").ToString.Contains("First Part (प्रवेशः)") Then
                exmName = "Ðí±ïà¢:"
            ElseIf dtAbl.Rows(0).Item("Stage").ToString.Contains("Second Part (परिचयः)") Then
                exmName = "ÐçÚ™²:"
            ElseIf dtAbl.Rows(0).Item("Stage").ToString.Contains("Third Part (शिक्षा)") Then
                exmName = "çà¢ÿ¢¢"
            Else
                exmName = "ÜU¢ïç±Î:"
            End If

            Dim amount As String = dtAbl.Rows(0).Item("Fee").ToString
            Dim clss As New clsConversion
            Dim amountInWord = UppercaseFirstLetter(clss.ConvertNumberToWords(amount).ToString) + " Rs. Only"

            Dim chqNo As String = dtAbl.Rows(0).Item("Ch_dr_no").ToString
            Dim chqDate As String = dtAbl.Rows(0).Item("chk_date").ToString
            Dim bkDisptch As String = dtAbl.Rows(0).Item("bk_sndng").ToShortDateString

            Dim initMonth As Date = dtAbl.Rows(0).Item("regn_Date").ToShortDateString
            Dim initMnthStr As String = initMonth.Month.ToString + "-" + initMonth.Year.ToString
            Dim frmMnth As String = initMnthStr

            Dim endMonth As Date = initMonth.AddMonths(6)
            Dim endMonthStr As String = endMonth.Month.ToString + "-" + endMonth.Year.ToString
            Dim toMnth As String = endMonthStr

            Dim regnId As String = dtAbl.Rows(0).Item("reg_table.Regn_ID").ToString
            Dim bankBranch As String = dtAbl.Rows(0).Item("BankName").ToString

            Dim inBltcmd As String = regnId.ToString
            Dim bokParam As String = bkDisptch.ToString

            Dim rptv As New CrystalReport2
            rptv.SetParameterValue(0, rcptNo)
            rptv.SetParameterValue(1, receipt_date.ToString)
            rptv.SetParameterValue(2, prefix)
            rptv.SetParameterValue(3, fullname)
            rptv.SetParameterValue(4, exmName)
            rptv.SetParameterValue(6, amount)
            rptv.SetParameterValue(8, chqNo)
            rptv.SetParameterValue(9, chqDate.ToString)
            rptv.SetParameterValue(10, bokParam)
            rptv.SetParameterValue(11, frmMnth)
            rptv.SetParameterValue(12, toMnth)
            rptv.SetParameterValue(13, inBltcmd)
            rptv.SetParameterValue(14, bankBranch)
            rptv.SetParameterValue(15, amountInWord)
            CrystalReportViewer1.ReportSource = rptv
        ElseIf wway = 2 Then
            Dim rptv As New CrystalReport3
            Dim dDs As New DataSet
            dDs = New DataSet
            Dim tabl1 As New DataTable
            tabl1 = Reg_status.tabl1.Copy
            Dim tabl2 As New DataTable
            tabl2 = Reg_status.tabl2.Copy
            Dim tabl3 As New DataTable
            tabl3 = Reg_status.tabl3.Copy
            Dim tabl4 As New DataTable
            tabl4 = Reg_status.tabl4.Copy
            Dim tabl5 As New DataTable
            tabl5 = Reg_status.tabl5.Copy


            dDs.Tables.Add(tabl1)
            dDs.Tables(0).TableName = "tabl1"
            dDs.Tables.Add(tabl2)
            dDs.Tables(1).TableName = "tabl2"
            dDs.Tables.Add(tabl3)
            dDs.Tables(2).TableName = "tabl3"
            dDs.Tables.Add(tabl4)
            dDs.Tables(3).TableName = "tabl4"
            dDs.Tables.Add(tabl5)
            dDs.Tables(4).TableName = "tabl5"

            rptv.SetDataSource(dDs)
            rptv.SetParameterValue("total_registr", Reg_status.totalRegs.ToString)
            rptv.SetParameterValue("gen_male_param", Reg_status.male.ToString)
            rptv.SetParameterValue("gen_female_param", Reg_status.female.ToString)
            rptv.SetParameterValue("fromDate", Reg_status.fromDate)
            rptv.SetParameterValue("toDate", Reg_status.toDate)
            CrystalReportViewer1.ReportSource = rptv
        ElseIf wway = 3 Then
            If Not (rgnId.Length > 0 And exmPart.Length > 0) Then
                Exit Sub
            End If
            Dim exmName As String
            If exmPart = 0 Then
                exmName = "प्रवेशः"
            ElseIf exmPart = 1 Then
                exmName = "परिचयः"
            ElseIf exmPart = 2 Then
                exmName = "शिक्षा"
            Else
                exmName = "कोविदः"
            End If

            Dim dateIn As String = DateTime.Now.ToShortDateString
            Dim rptv As New Certificate_exam1
            rptv.SetParameterValue(0, exmName)
            rptv.SetParameterValue(1, dateIn)
            rptv.SetParameterValue(2, rgnId)
            rptv.SetParameterValue(3, StudntName)
            rptv.SetParameterValue(4, "A")
            CrystalReportViewer1.ReportSource = rptv
        End If

    End Sub
    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If
        ' Convert to character array.
        Dim array() As Char = val.ToCharArray
        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))
        ' Return new string.
        Return New String(array)
    End Function
    Sub ReportDataSetRetival()
        Dim ds As New DataSet
        ds = DataSet_ForFeeRpt(1)
        Dim ds1 As New DataSet
        ds1 = DataSet_ForAddress(1)

    End Sub
End Class