Imports System.Data.OleDb

Public Class Contact_List
    Dim cnStr As String = Input_Form.connString
    Dim dsY As DataSet
    Dim thrdWait As Threading.Thread

    Private Sub Contact_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim qrU As String = "SELECT * FROM `contct_table`"
        Dim cn3 As New OleDbConnection(cnStr)
        Dim dA2 As New OleDbDataAdapter(qrU, cn3)
        dsY = New DataSet
        dA2.Fill(dsY)
        LoadFromtable(dsY.Tables(0))
        load2()
        LoadCmbDistr()
        changFnt(FontRetrive)
    End Sub
    'Load Datagridview manully from table
    Sub LoadFromtable(ByVal tabl As DataTable)
        Try
            dgrvContact.Rows.Clear()
        Catch ex As Exception
        End Try
        For lcnt As Integer = 0 To tabl.Rows.Count
            Try
                dgrvContact.Rows.Add(tabl.Rows(lcnt).Item("conTctID").ToString, _
                                 tabl.Rows(lcnt).Item("c_Full_name").ToString, _
                                 tabl.Rows(lcnt).Item("c_Addr").ToString, _
                                 tabl.Rows(lcnt).Item("c_City").ToString, _
                                 tabl.Rows(lcnt).Item("c_Distr").ToString, _
                                 tabl.Rows(lcnt).Item("c_PIN").ToString, _
                                 tabl.Rows(lcnt).Item("c_Phn").ToString, _
                                 tabl.Rows(lcnt).Item("c_Mobil").ToString, _
                                 tabl.Rows(lcnt).Item("c_Email").ToString, _
                                 tabl.Rows(lcnt).Item("c_Work").ToString, _
                                 tabl.Rows(lcnt).Item("c_Respnsb").ToString, _
                                 tabl.Rows(lcnt).Item("c_Bdate").ToString _
                                 )
            Catch ex As Exception
            End Try
        Next
    End Sub
    Sub changFnt(ByVal fnt As Font)
        dgrvContact.Font = fnt
        Dim style As New DataGridViewCellStyle
        style.Font = New Font("Arial", FontStyle.Bold)

        For Each col As DataGridViewColumn In dgrvContact.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.HeaderCell.Style.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        For i As Integer = 0 To dgrvContact.Rows.Count - 1
            For j As Integer = 0 To 11
                If Not (j = 1 Or j = 2 Or j = 3 Or j = 4 Or j = 9 Or j = 10) Then
                    dgrvContact.Rows(i).Cells(j).Style.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Pixel)
                Else
                    dgrvContact.Rows(i).Cells(j).Style.Font = fnt
                End If
            Next
        Next

        txtFullName.Font = fnt
        txtAdress.Font = fnt
        txtQual.Font = fnt
        cmbCity.Font = fnt
        cmbDistr.Font = fnt
    End Sub
    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub
    Sub load2()
        For Each wr As String In lstCmb
            cmbCity.Items.Add(wr)
        Next
        Try
            cmbCity.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing City List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub
    Sub LoadCmbDistr()
        For Each wr As String In lstDis
            cmbDistr.Items.Add(wr)
        Next
        Try
            cmbDistr.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Missing District List", MsgBoxStyle.Critical, "Oops . . .")
        End Try
    End Sub

    Private Sub UbuntuButtonGray1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addContct.Click
        adCntct.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cityFiltr As String = ""
        Dim dstrFiltr As String = ""
        Dim addrFiltr As String = ""
        Dim nameFiltr As String = ""
        Dim quolFiltr As String = ""

        If Not dgrvContact.Rows.Count <= 0 Then
            dgrvContact.Rows.Clear()
            If Not cmbCity.SelectedIndex = 0 Then
                cityFiltr = cmbCity.SelectedItem.ToString
            End If
            If Not cmbDistr.SelectedIndex = 0 Then
                dstrFiltr = cmbDistr.SelectedItem.ToString
            End If

            Dim clmn_Name As String = "c_city"
            Dim rows = dsY.Tables(0).Select("conTctID > 0" & _
                                        "AND Convert(c_Full_name, 'System.String') LIKE '*" + txtFullName.Text + "*'" & _
                                        "AND Convert(c_Addr, 'System.String') LIKE '*" + txtAdress.Text + "*'" & _
                                        "AND Convert(c_City, 'System.String') LIKE '*" + cityFiltr + "*'" & _
                                        "AND Convert(c_Distr, 'System.String') LIKE '*" + dstrFiltr + "*'")
            Try
                Dim dt1b As New DataTable
                dt1b = rows.CopyToDataTable
                LoadFromtable(dt1b)
            Catch ex As Exception
                LoadFromtable(dsY.Tables(0))
                MsgBox("No Results Found")
            End Try
        End If
        changFnt(FontRetrive)
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Report_Viewer.studentOrContct = "contact"
        Dim toPrint As Integer = 0
        Dim j As Integer = 0

        For i As Integer = 0 To dgrvContact.RowCount - 1
            If dgrvContact.Rows(i).Cells(12).Value = True Then
                toPrint += 1
                If j = 0 Then
                    Report_Viewer.incomingAry = dgrvContact.Rows(i).Cells(0).Value.ToString
                Else
                    Report_Viewer.incomingAry += "," + dgrvContact.Rows(i).Cells(0).Value.ToString
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

    Private Sub btnSlctAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlctAl.Click
        For Each dgrVRw As DataGridViewRow In dgrvContact.Rows
            dgrVRw.Cells(12).Value = True
        Next
    End Sub
End Class