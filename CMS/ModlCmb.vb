Imports System.IO

'use thid module to load some items from text files etc
Module mdleCMbBx
    Dim FileCity As String = Application.StartupPath + "\City_name.txt"
    Dim FileDistr As String = Application.StartupPath + "\district_name.txt"
    Dim FileState As String = Application.StartupPath + "\State_Name.txt"
    Dim FileCountry As String = Application.StartupPath + "\Country_Name.txt"
    Dim FIleActvt As String = Application.StartupPath + "\Activity.txt"
    Dim FIleEduc As String = Application.StartupPath + "\Educat.txt"
    Dim FIleQuol As String = Application.StartupPath + "\Quolif.txt"
    Dim FIleMedium As String = Application.StartupPath + "\Medium.txt"

    Public lstCmb As New List(Of String)
    Public lstDis As New List(Of String)
    Public lstStat As New List(Of String)
    Public lstCntr As New List(Of String)
    Public lstActVt As New List(Of String)
    Public lstEduca As New List(Of String)
    Public lstQuolf As New List(Of String)
    Public lstMedium As New List(Of String)

    Sub FillCity()
        lstCmb = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FileCity)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstCmb.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub
    Sub FillMedium()
        lstMedium = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FIleMedium)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstMedium.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub

    Sub FillActVt()
        lstActVt = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FIleActvt)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstActVt.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub
    Sub FillEducation()
        lstEduca = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FIleEduc)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstEduca.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub
    Sub FillQualific()
        lstQuolf = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FIleQuol)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstQuolf.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub
    Sub FillState()
        lstStat = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FileState)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstStat.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub
    'Sub FillState()
    '    Dim sRdr As New StreamReader(FileState, True)
    '    Dim se() As String = sRdr.ReadToEnd.Split(vbCrLf)
    '    For Each wr As String In se
    '        lstStat.Add(wr)
    '    Next
    '    Try
    '        sRdr.Dispose()
    '        sRdr.Close()
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Sub FillCountry()
        lstCntr = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FileCountry)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstCntr.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub
    Sub FillDistr()
        lstDis = New List(Of String)
        Dim objStreamReader As StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(FileDistr)
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            lstDis.Add(strLine + vbCrLf)
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
    End Sub

End Module
