Imports System.IO
Imports System.Data.SQLite
Module CardSkinManager

    Public CardSkinList As New List(Of CardSkin)

    Public Class CardSkin
        Public id As Double
        Public skinId As Double
        Public type As Integer
        Public name As String

        Public Sub New(newId As Double, newSkinId As Double, newType As Integer)
            id = newId
            skinId = newSkinId
            type = newType
        End Sub
    End Class

    Public Sub AddAllCardSkins()
        Try
            If Launcher.launcherEdition = 2 Then
                If Launcher.ComboBox1.Text = "Spanish" Then
                    My.Settings.Language = "Spanish"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\Spanish", Launcher.Current & "\YGOPRO\cdb", True)
                ElseIf Launcher.ComboBox1.Text = "French" Then
                    My.Settings.Language = "French"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\French", Launcher.Current & "\YGOPRO\cdb", True)
                ElseIf Launcher.ComboBox1.Text = "German" Then
                    My.Settings.Language = "German"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\German", Launcher.Current & "\YGOPRO\cdb", True)
                Else
                    My.Settings.Language = "English"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\English", Launcher.Current & "\YGOPRO\cdb", True)
                End If
            Else
                If Launcher.ComboBox1.Text = "Spanish" Then
                    My.Settings.Language = "Spanish"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\Spanish", Launcher.Current & "\YGOPRO", True)
                ElseIf Launcher.ComboBox1.Text = "French" Then
                    My.Settings.Language = "French"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\French", Launcher.Current & "\YGOPRO", True)
                ElseIf Launcher.ComboBox1.Text = "German" Then
                    My.Settings.Language = "German"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\German", Launcher.Current & "\YGOPRO", True)
                Else
                    My.Settings.Language = "English"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\English", Launcher.Current & "\YGOPRO", True)
                End If
            End If
        Catch
        End Try

        For Each skin As CardSkin In CardSkinList
            Try
                Dim db As New SQLiteDatabase()
                Dim recipe As DataTable
                Dim query As [String] = "select id ""id"", ot ""ot"", alias ""alias"", setcode ""setcode"", type ""type"", atk ""atk"", def ""def"", level ""level"", race ""race"", attribute ""attribute"", category ""category"" from datas where id = " & skin.id & ";"
                recipe = db.GetDataTable(query)

                Dim r As DataRow = recipe.Rows(0)
                Dim idb As New SQLiteDatabase()
                Dim data As New Dictionary(Of [String], [String])()
                data.Add("id", skin.skinId)
                data.Add("ot", r("ot").ToString())
                data.Add("alias", skin.id)
                data.Add("setcode", r("setcode").ToString())
                data.Add("type", r("type").ToString())
                data.Add("atk", r("atk").ToString())
                data.Add("def", r("def").ToString())
                data.Add("level", r("level").ToString())
                data.Add("race", r("race").ToString())
                data.Add("attribute", r("attribute").ToString())
                data.Add("category", r("category").ToString())
                idb.Insert("datas", data)
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox(skin.skinId)
            End Try
        Next

        For Each skin As CardSkin In CardSkinList
            Try
                Dim db As New SQLiteDatabase()
                Dim recipe As DataTable
                Dim query As [String] = "select id ""id"", name ""name"", desc ""desc"", str1 ""str1"", str2 ""str2"", str3 ""str3"", str4 ""str4"", str5 ""str5"", str6 ""str6"", str7 ""str7"", str8 ""str8"", str9 ""str9"", str10 ""str10"", str11 ""str11"", str12 ""str12"", str13 ""str13"", str14 ""str14"", str15 ""str15"", str16 ""str16"" from texts where id = " & skin.id & ";"
                recipe = db.GetDataTable(query)

                Dim sourceLocation As String
                If Launcher.launcherEdition = 2 Then
                    sourceLocation = "Data Source= " & Launcher.Current & "\YGOPRO\cdb\cards.cdb"
                Else
                    sourceLocation = "Data Source= " & Launcher.Current & "\YGOPRO\cards.cdb"
                End If
                Dim connection = New SQLiteConnection(sourceLocation)
                Dim command As SQLiteCommand

                Dim r As DataRow = recipe.Rows(0)
                connection.Open()
                command = DatabaseHelper.CreateCommand("INSERT INTO texts (id,name,desc,str1,str2,str3,str4,str5,str6,str7,str8,str9,str10,str11,str12,str13,str14,str15,str16)" + " VALUES (@id,@name,@des,@str1,@str2,@str3,@str4,@str5,@str6,@str7,@str8,@str9,@str10,@str11,@str12,@str13,@str14,@str15,@str16)", connection)
                command.Parameters.Add(New SQLiteParameter("@id", skin.skinId))
                command.Parameters.Add(New SQLiteParameter("@name", r("name").ToString()))
                command.Parameters.Add(New SQLiteParameter("@des", r("desc").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str1", r("str1").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str2", r("str2").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str3", r("str3").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str4", r("str4").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str5", r("str5").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str6", r("str6").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str7", r("str7").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str8", r("str8").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str9", r("str9").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str10", r("str10").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str11", r("str11").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str12", r("str12").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str13", r("str13").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str14", r("str14").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str15", r("str15").ToString()))
                command.Parameters.Add(New SQLiteParameter("@str16", r("str16").ToString()))
                DatabaseHelper.ExecuteNonCommand(command)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox(skin.skinId)
            End Try
        Next
    End Sub

    Public Sub DeleteCardSkins(ByVal skinList As List(Of String))
        If Launcher.ComboBox1.Text = "Spanish" Then
            My.Settings.Language = "Spanish"
            My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\Spanish", Launcher.Current & "\YGOPRO\MultiLanguage\DeckEditor", True)
        ElseIf Launcher.ComboBox1.Text = "French" Then
            My.Settings.Language = "French"
            My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\French", Launcher.Current & "\YGOPRO\MultiLanguage\DeckEditor", True)
        ElseIf Launcher.ComboBox1.Text = "German" Then
            My.Settings.Language = "German"
            My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\German", Launcher.Current & "\YGOPRO\MultiLanguage\DeckEditor", True)
        Else
            My.Settings.Language = "English"
            My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\English", Launcher.Current & "\YGOPRO\MultiLanguage\DeckEditor", True)
        End If

        Dim db As New SQLiteDatabase(Launcher.Current & "\YGOPRO\MultiLanguage\DeckEditor\cards.cdb")

        Dim deleteIds As String = ""
        For Each skin As CardSkin In cardSkinList
            If Not skinList.Contains(skin.skinId) Then
                If deleteIds = "" Then
                    deleteIds += "ID = " & skin.skinId
                Else
                    deleteIds += " or ID = " & skin.skinId
                End If
            End If
        Next

        If Not skinList.Contains(3) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 3
            Else
                deleteIds += " or ID = " & 3
            End If
        End If
        If Not skinList.Contains(4) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 4
            Else
                deleteIds += " or ID = " & 4
            End If
        End If
        If Not skinList.Contains(7) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 7
            Else
                deleteIds += " or ID = " & 7
            End If
        End If
        If Not skinList.Contains(8) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 8
            Else
                deleteIds += " or ID = " & 8
            End If
        End If
        If Not skinList.Contains(11) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 11
            Else
                deleteIds += " or ID = " & 11
            End If
        End If
        If Not skinList.Contains(12) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 12
            Else
                deleteIds += " or ID = " & 12
            End If
        End If
        If Not skinList.Contains(13) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 13
            Else
                deleteIds += " or ID = " & 13
            End If
        End If
        If Not skinList.Contains(14) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 14
            Else
                deleteIds += " or ID = " & 14
            End If
        End If
        If Not skinList.Contains(16) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 16
            Else
                deleteIds += " or ID = " & 16
            End If
        End If
        If Not skinList.Contains(17) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 17
            Else
                deleteIds += " or ID = " & 17
            End If
        End If
        If Not skinList.Contains(22) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 22
            Else
                deleteIds += " or ID = " & 22
            End If
        End If
        If Not skinList.Contains(23) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 23
            Else
                deleteIds += " or ID = " & 23
            End If
        End If
        If Not skinList.Contains(24) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 24
            Else
                deleteIds += " or ID = " & 24
            End If
        End If
        If Not skinList.Contains(69) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 69
            Else
                deleteIds += " or ID = " & 69
            End If
        End If
        If Not skinList.Contains(70) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 70
            Else
                deleteIds += " or ID = " & 70
            End If
        End If
        If Not skinList.Contains(420) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 420
            Else
                deleteIds += " or ID = " & 420
            End If
        End If
		If Not skinList.Contains(500) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 500
            Else
                deleteIds += " or ID = " & 500
            End If
        End If
		If Not skinList.Contains(55555) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 55555
            Else
                deleteIds += " or ID = " & 55555
            End If
        End If
		If Not skinList.Contains(19558409) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 19558409
            Else
                deleteIds += " or ID = " & 19558409
            End If
        End If
		If Not skinList.Contains(26630260) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 26630260
            Else
                deleteIds += " or ID = " & 26630260
            End If
        End If
		If Not skinList.Contains(1234512345) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 1234512345
            Else
                deleteIds += " or ID = " & 1234512345
            End If
        End If
		If Not skinList.Contains(1234512346) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 1234512346
            Else
                deleteIds += " or ID = " & 1234512346
            End If
        End If
		If Not skinList.Contains(1234612345) Then
            If deleteIds = "" Then
                deleteIds += "ID = " & 1234612345
            Else
                deleteIds += " or ID = " & 1234612345
            End If
        End If

        If deleteIds <> "" Then
            Try
                db.Delete("DATAS", deleteIds)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Public Sub CopyFullCardDatabase()
        Try
            If Launcher.launcherEdition = 2 Then
                If Launcher.ComboBox1.Text = "Spanish" Then
                    My.Settings.Language = "Spanish"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\Spanish", Launcher.Current & "\YGOPRO\cdb", True)
                ElseIf Launcher.ComboBox1.Text = "French" Then
                    My.Settings.Language = "French"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\French", Launcher.Current & "\YGOPRO\cdb", True)
                ElseIf Launcher.ComboBox1.Text = "German" Then
                    My.Settings.Language = "German"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\German", Launcher.Current & "\YGOPRO\cdb", True)
                Else
                    My.Settings.Language = "English"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\English", Launcher.Current & "\YGOPRO\cdb", True)
                End If
            Else
                If Launcher.ComboBox1.Text = "Spanish" Then
                    My.Settings.Language = "Spanish"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\Spanish", Launcher.Current & "\YGOPRO", True)
                ElseIf Launcher.ComboBox1.Text = "French" Then
                    My.Settings.Language = "French"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\French", Launcher.Current & "\YGOPRO", True)
                ElseIf Launcher.ComboBox1.Text = "German" Then
                    My.Settings.Language = "German"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\German", Launcher.Current & "\YGOPRO", True)
                Else
                    My.Settings.Language = "English"
                    My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\English", Launcher.Current & "\YGOPRO", True)
                End If
            End If
        Catch
        End Try
    End Sub

    Public Sub CopyOwnedCardSkins()
        Try
            If Launcher.launcherEdition = 2 Then
                My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\DeckEditor", Launcher.Current & "\YGOPRO\cdb", True)
            Else
                My.Computer.FileSystem.CopyDirectory(Launcher.Current & "\YGOPRO\MultiLanguage\DeckEditor", Launcher.Current & "\YGOPRO", True)
            End If
        Catch
        End Try
    End Sub

    Public Sub CreateSkinList()
        Dim skin As New CardSkin(74677422, 800000000, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(89631139, 800000001, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(89631139, 800000002, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(89631139, 800000003, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(23995346, 800000004, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(24696097, 800000005, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(82044279, 800000006, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(82044279, 800000007, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(93717133, 800000008, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(89943723, 800000009, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(89463537, 800000010, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(25857246, 800000011, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(74122412, 800000012, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(26674724, 800000013, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(27782503, 800000014, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(38033121, 800000015, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(58481572, 800000016, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(12744567, 800000017, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(45349196, 800000018, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(72378329, 800000019, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(16691074, 800000020, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(44508094, 800000021, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(45037489, 800000022, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(79856792, 800000023, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(80696379, 800000024, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(38033121, 800000025, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(86346643, 800000026, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(71921856, 800000027, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(50091196, 800000028, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(12014404, 800000029, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(46986414, 800000030, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(84013237, 800000031, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(2009101, 800000032, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(50720316, 800000033, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(90953320, 800000034, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(94415058, 800000035, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(20409757, 800000036, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(29981921, 800000037, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(92125819, 800000038, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(73580471, 800000039, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(3580032, 800000040, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(88264978, 800000041, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(16178681, 800000042, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(1516510, 800000043, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(48739166, 800000044, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(53183600, 800000045, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(84749824, 800000046, 3)
        cardSkinList.Add(skin)

        skin = New CardSkin(12580477, 800000047, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(5133471, 800000048, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(5318639, 800000049, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(44095762, 800000050, 3)
        cardSkinList.Add(skin)

        skin = New CardSkin(53582587, 800000051, 3)
        cardSkinList.Add(skin)

        skin = New CardSkin(29267084, 800000052, 3)
        cardSkinList.Add(skin)

        skin = New CardSkin(98645731, 800000053, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(62279055, 800000054, 3)
        cardSkinList.Add(skin)

        skin = New CardSkin(70368879, 800000055, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(81674782, 800000056, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(70342110, 800000057, 3)
        cardSkinList.Add(skin)

        skin = New CardSkin(50078509, 800000058, 3)
        cardSkinList.Add(skin)

        skin = New CardSkin(54447022, 800000059, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(53129443, 800000060, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(36553319, 800000061, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(84764038, 800000062, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(734741, 800000063, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(20758643, 800000064, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(57143342, 800000065, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(73213494, 800000066, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(47728740, 800000067, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(62957424, 800000068, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(81992475, 800000069, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(68144350, 800000070, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(32750341, 800000071, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(32750341, 800000072, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(24184846, 800000073, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(23232295, 800000074, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(23232295, 800000075, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(61679541, 800000076, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(79867938, 800000077, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(79867938, 800000078, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(4549095, 800000079, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(86325573, 800000080, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(13313278, 800000081, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(91907707, 800000082, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(37991342, 800000083, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(13073850, 800000084, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(51194046, 800000085, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(64496451, 800000086, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(90885155, 800000087, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(65518099, 800000088, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(87588741, 800000089, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(27279764, 800000090, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(80666118, 800000091, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(60800381, 800000092, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(60800381, 800000093, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(27279764, 800000094, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(27279764, 800000095, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(88177324, 800000096, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(60862676, 800000097, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(58818411, 800000098, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(10802915, 800000099, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(74416224, 800000100, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(60800381, 800000101, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(8561192, 800000102, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(10000020, 800000103, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97268402, 800000104, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97268402, 800000105, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(55428242, 800000106, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(74892653, 800000107, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(6142488, 800000108, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(6142488, 800000109, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(64631466, 800000110, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(39765958, 800000111, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11868731, 800000112, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11868731, 800000113, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(37164373, 800000114, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(37164373, 800000115, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(36857073, 800000116, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(9753964, 800000117, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(62242678, 800000118, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(80666118, 800000119, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(80666118, 800000120, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(70902743, 800000121, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(70902743, 800000122, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(65247798, 800000123, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(92246806, 800000124, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(28630501, 800000125, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(32013448, 800000126, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(6628343, 800000127, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(13764881, 800000128, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(77360173, 800000129, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40975574, 800000130, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40159926, 800000131, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97021916, 800000132, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(25244515, 800000133, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(89127526, 800000134, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(77087109, 800000135, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(5780210, 800000136, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40583194, 800000137, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(14785765, 800000138, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(58820853, 800000139, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16516630, 800000140, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(49003716, 800000141, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(6628343, 800000142, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(73652465, 800000143, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(55610595, 800000144, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(22835145, 800000145, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(2009101, 800000146, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(46710683, 800000147, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(33236860, 800000148, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(69031175, 800000149, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(95040215, 800000150, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(76913983, 800000151, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11613567, 800000152, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(75498415, 800000153, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(81105204, 800000154, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(81983656, 800000155, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(60950180, 800000156, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(31314549, 800000157, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(5929801, 800000158, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(8785161, 800000159, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(45184165, 800000160, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(52323874, 800000161, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(73887236, 800000162, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(73347079, 800000163, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97219708, 800000164, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(83236601, 800000165, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(96345188, 800000166, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(45533023, 800000167, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(51814159, 800000168, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(81927732, 800000169, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(53251824, 800000170, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(23603403, 800000171, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(23603403, 800000172, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(20366274, 800000173, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(34408491, 800000174, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(8763963, 800000175, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(85545073, 800000176, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(85545073, 800000177, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(464362, 800000178, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(464362, 800000179, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(78371393, 800000180, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(78371393, 800000181, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(95929069, 800000182, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(68535320, 800000183, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(87118301, 800000184, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(87118301, 800000185, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(52068432, 800000186, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(22174866, 800000187, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(58569561, 800000188, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(52687916, 800000189, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(20409757, 800000190, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(78371393, 800000191, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(63176202, 800000192, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(63176202, 800000193, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(29981921, 800000194, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(65685470, 800000195, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(61737116, 800000196, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(64398890, 800000197, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(10000000, 800000198, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(83531441, 800000199, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(83531441, 800000200, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(72989439, 800000201, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(80117527, 800000202, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16195942, 800000203, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97489701, 800000204, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(59616123, 800000205, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(33782437, 800000206, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(51452091, 800000207, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(24094653, 800000208, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(5650082, 800000209, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(56747793, 800000210, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(51452091, 800000211, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(53129443, 800000212, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(74848038, 800000213, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(97077563, 800000214, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(99423156, 800000215, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(56532353, 800000216, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(92246806, 800000217, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(94693857, 800000218, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(83283063, 800000219, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(59368956, 800000220, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40908371, 800000221, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(75944053, 800000222, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(22227683, 800000223, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(8240199, 800000224, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11317977, 800000225, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(10117149, 800000226, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(55106249, 800000227, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97588916, 800000228, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(23064604, 800000229, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(10000000, 800000230, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(24573625, 800000231, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(59463312, 800000232, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(25494711, 800000233, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(24550676, 800000234, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(1845204, 800000235, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(88935103, 800000236, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(9753964, 800000237, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(15146890, 800000238, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(70902743, 800000239, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(94919024, 800000240, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(36857073, 800000241, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(89127526, 800000242, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(12215894, 800000243, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(71039903, 800000244, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(45467446, 800000245, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(78193831, 800000246, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(89631139, 800000247, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(80335817, 800000248, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(3428069, 800000249, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(62242678, 800000250, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(23008320, 800000251, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(13764881, 800000252, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(77087109, 800000253, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(5780210, 800000254, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(10000020, 800000255, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(46986414, 800000256, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97021916, 800000257, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(76218313, 800000258, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11790356, 800000259, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(72714461, 800000260, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(71692913, 800000261, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(63767246, 800000262, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(79814787, 800000263, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(2129638, 800000264, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(13708425, 800000265, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40583194, 800000266, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(41940225, 800000267, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(86240887, 800000268, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(35818851, 800000269, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16195942, 800000270, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11439455, 800000271, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(89544521, 800000272, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(24094653, 800000273, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(18239909, 800000274, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(65247798, 800000275, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(59822133, 800000276, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(78348934, 800000277, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(53208660, 800000278, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(51531505, 800000279, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(62038047, 800000280, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(23171610, 800000281, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(96570609, 800000282, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40159926, 800000283, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(21565445, 800000284, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(97489701, 800000285, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(10000010, 800000286, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16178681, 800000287, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(28630501, 800000288, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(44095762, 800000289, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(88241506, 800000290, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(45644898, 800000291, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(29401950, 800000292, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(16172067, 800000293, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(36630403, 800000294, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40975574, 800000295, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(38601126, 800000296, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(80666118, 800000297, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(45644898, 800000298, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(47705572, 800000299, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40605147, 800000300, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(44508094, 800000301, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(4333086, 800000302, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(17086528, 800000303, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(77360173, 800000304, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(84812868, 800000305, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(95457011, 800000306, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(25244515, 800000307, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(18963306, 800000308, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(48427163, 800000309, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(43898403, 800000310, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(14920218, 800000311, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(83190280, 800000312, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(1621413, 800000313, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(72855441, 800000314, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(84013237, 800000315, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(57288064, 800000316, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(88757791, 800000317, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(31222701, 800000318, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(49823708, 800000319, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(2602411, 800000320, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(38517737, 800000321, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11193246, 800000322, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(40005099, 800000323, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(97165977, 800000324, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(51777272, 800000325, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(89943723, 800000326, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(44508094, 810000000, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(93717133, 810000001, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(93717133, 810000002, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(93717133, 820000000, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(46986414, 820000001, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(44508094, 820000002, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(24696097, 820000003, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(35952884, 820000004, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(35952884, 820000005, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(44508094, 820000006, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(57774843, 820000007, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(44405066, 820000008, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(86346643, 820000009, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(58481572, 820000010, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(22061412, 820000011, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(40854197, 820000012, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(46986414, 820000013, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(38033121, 820000014, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(43892408, 820000015, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(72989439, 820000016, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(10613952, 820000017, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(46772449, 820000018, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(50091196, 820000019, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(12014404, 820000020, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(20366274, 820000021, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(88241506, 820000022, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(70095154, 820000023, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(10443957, 820000024, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(84013237, 820000025, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(74641045, 820000026, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(89474727, 820000027, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(2511717, 820000028, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(95519486, 820000029, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(90397998, 820000030, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(31904181, 820000031, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(49721904, 820000032, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(75116619, 820000033, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(29981921, 820000034, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(11522979, 820000035, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(83039729, 820000036, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(1498130, 820000037, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(29587993, 820000038, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(7845138, 820000039, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(61441708, 820000040, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(30079770, 820000041, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(89943723, 830000000, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(89943723, 830000001, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(12580477, 830000002, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(12580477, 830000003, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(10443957, 830000004, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(23893227, 830000005, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(1710476, 830000006, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(70095154, 830000007, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(59281922, 830000008, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(1546123, 830000009, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(84058253, 830000010, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(79229522, 830000011, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(75064463, 840000000, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(76812113, 840000001, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(34100324, 840000002, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(56585883, 840000003, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(68815132, 840000004, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(12206212, 840000005, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(80316585, 840000006, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(90238142, 840000007, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(37742478, 840000008, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(22061412, 840000009, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(65192027, 840000010, 1)
        cardSkinList.Add(skin)

        skin = New CardSkin(12580477, 840000011, 2)
        cardSkinList.Add(skin)

        skin = New CardSkin(54447022, 840000012, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(20366274, 850000000, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(72714461, 850000001, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(34408491, 850000002, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(12580477, 850000003, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(88757791, 850000004, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(72714461, 850000005, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(72714461, 850000006, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(53208660, 850000007, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(7845138, 850000008, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(34408491, 850000009, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(31036355, 850000010, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(51531505, 850000011, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(51531505, 850000012, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(51531505, 850000013, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(51531505, 850000014, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(58577036, 850000015, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(58577036, 850000016, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(7845138, 850000017, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(29587993, 850000018, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(29587993, 850000019, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(29587993, 850000020, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(48739166, 850000024, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(40318957, 850000025, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(56747793, 850000026, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(30079770, 850000027, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(30079770, 850000028, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16195942, 850000029, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(53262004, 850000030, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(44405066, 850000031, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(44405066, 850000032, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(83746708, 850000033, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(45627618, 850000034, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16691074, 850000035, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(71692913, 850000036, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(71692913, 850000037, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16178681, 850000038, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16178681, 850000039, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16178681, 850000040, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(50732780, 850000041, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(50732780, 850000042, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(50732780, 850000043, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(50954680, 850000044, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(1686814, 850000045, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(42566602, 850000046, 1)
        CardSkinList.Add(skin)
		
		skin = New CardSkin(1686814, 850000047, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(11705261, 850000048, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(12580477, 850000049, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(12580477, 850000050, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(21521304, 850000051, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(23434538, 850000052, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(40605147, 850000053, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(40838625, 850000054, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(45950291, 850000055, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(49456901, 850000056, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(52653092, 850000057, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(53129443, 850000058, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(56832966, 850000059, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(57734012, 850000060, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(66970002, 850000061, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(84013237, 850000062, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(86532744, 850000063, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(87911394, 850000064, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(90809975, 850000065, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(92365601, 850000066, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(1621413, 850000067, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(3298689, 850000068, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(16195942, 850000069, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(25542642, 850000070, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(36426778, 850000071, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(61936647, 850000072, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(62709239, 850000073, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(63821877, 850000074, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(90432163, 850000075, 1)
        CardSkinList.Add(skin)
		
        skin = New CardSkin(98431356, 850000076, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(20366274, 860000000, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(123123, 860000001, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(96471335, 860000002, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(94515289, 860000003, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(34408491, 860000004, 1)
        CardSkinList.Add(skin)

        skin = New CardSkin(68462976, 860000005, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(12393, 860000006, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(33017655, 860000007, 2)
        CardSkinList.Add(skin)

        skin = New CardSkin(35027493, 860000008, 3)
        CardSkinList.Add(skin)

        skin = New CardSkin(900000000, 860000009, 1)
        CardSkinList.Add(skin)

        GetCardNames()
    End Sub

    Public Sub GetCardNames()
        For Each skin As CardSkin In CardSkinList
            Try
                Dim db As New SQLiteDatabase()
                Dim recipe As DataTable
                Dim query As [String] = "select id ""id"", name ""name"" from texts where id = " & skin.id & ";"
                recipe = db.GetDataTable(query)
                Dim r As DataRow = recipe.Rows(0)
                skin.name = r("name").ToString()
            Catch
            End Try
        Next
    End Sub

    Public Sub CreateCardScripts()
        For Each skin As CardSkin In CardSkinList
            Try
                Dim cardScript As String = File.ReadAllText(Launcher.Current & "\YGOPRO\script\c" & skin.id & ".lua")
                cardScript = cardScript.Replace(skin.id, skin.skinId)
                File.WriteAllText(Launcher.Current & "\YGOPRO\script\c" & skin.skinId & ".lua", cardScript)
            Catch
            End Try
        Next
    End Sub
End Module