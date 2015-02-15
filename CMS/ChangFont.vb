Module ChangFont

    Dim File = Application.StartupPath + "\CMS_Settings.ini"
    Function FontRetrive() As Font
        Dim Section = ""
        Dim Heder = ""
        Dim Fname As String
        Dim FSize As Integer
        Dim FontType As FontStyle
        Section = "FontDetail"
        Heder = "FontName"
        Fname = ReadIni(File, Section, Heder, "")
        Heder = "FontSize"
        FSize = ReadIni(File, Section, Heder, "")
        Heder = "FontType"
        FontType = ReadIni(File, Section, Heder, "")

        Dim f As New System.Drawing.Font(Fname, FSize)
        Return f
    End Function
    Sub FontSav(ByVal fnt As Font)
        Dim Sectn = "FontDetail"
        Dim fntStyle = "FontType"
        Dim Fname = "FontName"
        Dim FSize = "FontSize"
        writeIni(File, Sectn, Fname, fnt.Name)
        writeIni(File, Sectn, fntStyle, fnt.Style)
        writeIni(File, Sectn, FSize, fnt.Size)
    End Sub
End Module
