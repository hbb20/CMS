Imports System.IO
Imports System.Text

Public Class EditCity
    Dim FileCity As String = Application.StartupPath + "\City_name.txt"
    Dim FileDistr As String = Application.StartupPath + "\district_name.txt"
    Dim FileState As String = Application.StartupPath + "\State_Name.txt"
    Dim FileCountry As String = Application.StartupPath + "\Country_Name.txt"
    Dim Actvt As String = Application.StartupPath + "\Activity.txt"
    Dim FIleEduc As String = Application.StartupPath + "\Educat.txt"
    Dim FIleQuol As String = Application.StartupPath + "\Quolif.txt"

    Dim loadedFile As String
    Sub loadFIle(ByVal FileNm As String)
        RichTextBox1.Text = ""
        loadedFile = FileNm
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FileNm)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            If Not strLine = Nothing Then
                RichTextBox1.Text += strLine + vbCrLf
            End If
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub
    Private Sub CityListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityListToolStripMenuItem.Click
        loadFIle(FileCity)
        Me.Text = "Edit List (City)"
    End Sub
    Private Sub DistrictListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictListToolStripMenuItem.Click
        loadFIle(FileDistr)
        Me.Text = "Edit List (District)"
    End Sub
    Private Sub StateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StateListToolStripMenuItem.Click
        loadFIle(FileState)
        Me.Text = "Edit List (State)"
    End Sub
    Private Sub CountryListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryListToolStripMenuItem.Click
        loadFIle(FileCountry)
        Me.Text = "Edit List (Country)"
    End Sub
    Private Sub DiscardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscardToolStripMenuItem.Click
        RichTextBox1.Text = ""
        loadedFile = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        If loadedFile.Length = 0 Then
            Exit Sub
        End If

        Dim objStreamWriter As StreamWriter
        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(loadedFile, False, Encoding.Unicode)
        'Write a line of text.
        Dim sFor As String() = RichTextBox1.Text.Split(vbCrLf)
        For Each sOn As String In sFor
            objStreamWriter.WriteLine(sOn)
            ', Encoding.Unicode)
        Next
        'Close the file.
        objStreamWriter.Close()
        MsgBox("Data Updated Successfully", MsgBoxStyle.Information, "Done")
    End Sub
    Private Sub ActvyItms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActvyItms.Click
        loadFIle(Actvt)
        Me.Text = "Edit List (Activity)"
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Sub chnGFon(ByVal fnt As Font)
        RichTextBox1.Font = fnt
    End Sub
    Private Sub EditCity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chnGFon(FontRetrive)
    End Sub

    Private Sub EditEducationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEducationToolStripMenuItem.Click
        loadFIle(FIleEduc)
        Me.Text = "Edit List (Education)"
    End Sub
    Private Sub QuolificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuolificationToolStripMenuItem.Click
        loadFIle(FIleQuol)
        Me.Text = "Edit List (Quolification)"
    End Sub

    Private Sub CHangeFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHangeFontToolStripMenuItem.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            changFFF(FontDialog1.Font)
        End If
    End Sub
    Sub changFFF(ByVal Font1 As Font)
        RichTextBox1.Font = Font1
    End Sub
End Class