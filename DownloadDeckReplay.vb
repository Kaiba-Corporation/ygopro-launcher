Imports System.IO

Public Class DownloadDeckReplay

    Dim deckList As New List(Of String)

    Public type As String
    Public deckName As String
    Public createdBy As String
    Public mainDeck As String
    Public extraDeck As String
    Public sideDeck As String

    Dim mainDeckList As New List(Of String)
    Dim extraDeckList As New List(Of String)
    Dim sideDeckList As New List(Of String)

    Public Sub LoadForm()
        If type = "Deck" Then
            Try
                ChDir(Launcher.Current)
                Dim di As New IO.DirectoryInfo(Launcher.Current & "\YGOPRO\deck\")
                Dim diar1 As IO.FileInfo() = di.GetFiles()
                Dim dra As IO.FileInfo

                For Each dra In diar1
                    Dim newDeck As String = dra.ToString
                    newDeck = newDeck.Substring(0, newDeck.Length - 4)

                    deckList.Add(newDeck)
                Next
            Catch
                MsgBox("Error 2000: There was a problem loading your deck list!")
                Me.Close()
            End Try

            Dim sParts() As String = Split(mainDeck, ",")
            For Each card As String In sParts
                mainDeckList.Add(card)
            Next

            sParts = Split(extraDeck, ",")
            For Each card As String In sParts
                extraDeckList.Add(card)
            Next

            sParts = Split(sideDeck, ",")
            For Each card As String In sParts
                sideDeckList.Add(card)
            Next

            fileName.Text = deckName
            If deckList.Contains(deckName) Then
                deckExists.Show()
                Save.Text = "Overwrite"
            End If
        End If
    End Sub

    Private Sub upload_Click(sender As Object, e As EventArgs) Handles Save.Click
        If type = "Deck" Then
            If Not System.IO.File.Exists(Launcher.Current & "\YGOPRO\deck\" & fileName.Text & ".ydk") Then
                System.IO.File.Create(Launcher.Current & "\YGOPRO\deck\" & fileName.Text & ".ydk").Dispose()
            Else
                Dim MGResult As DialogResult
                MGResult = MessageBox.Show("Are you sure you want to overwrite: " & fileName.Text, "Deck Overwrite", MessageBoxButtons.YesNo)

                If MGResult = MsgBoxResult.No Then
                    Return
                End If
            End If

            Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\deck\" & fileName.Text & ".ydk")
            objwriter.WriteLine("#created by " & createdBy)
            objwriter.WriteLine("#main")
            For Each card As String In mainDeckList
                objwriter.WriteLine(card)
            Next
            objwriter.WriteLine("#extra")
            For Each card As String In extraDeckList
                objwriter.WriteLine(card)
            Next
            objwriter.WriteLine("!side")
            For Each card As String In sideDeckList
                objwriter.WriteLine(card)
            Next
            objwriter.Close()

            If (CommunityCenter.openWhenDownloaded.Checked = True) Then
                OpenDeckEditor(fileName.Text)
            End If

            Me.Hide()
        End If
    End Sub

    Sub OpenDeckEditor(ByVal deck As String)
        Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "system.CONF")
        objwriter.Write("#config file")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("#nickname & gamename should be less than 20 characters")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("use_d3d = " & My.Settings.UDX)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("skin_index = " & My.Settings.US)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("antialias = " & My.Settings.AA)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("errorlog = 0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("nickname = " & Launcher.Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & deck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & Launcher.gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & Launcher.IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & Launcher.gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("fullscreen = " & My.Settings.FS)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("enable_sound = " & My.Settings.enableSound)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("sound_volume = " & My.Settings.SoundVolume)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("enable_music = " & My.Settings.enableMusic)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("music_volume = " & My.Settings.MusicVolume)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("auto_monster_placing = " & My.Settings.AMCP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("auto_spelltrap_placing = " & My.Settings.ASTCP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("random_card_placing = " & My.Settings.RCP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("auto_chain_order = " & My.Settings.ACO)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("no_delay_for_chain = " & My.Settings.NDFC)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("mute_chat = " & 1)
        objwriter.Close()

        CardSkinManager.CopyOwnedCardSkins()

        Dim proc As New Process()

        ChDir(Launcher.Current & "\YGOPRO")
        proc.StartInfo.FileName = Launcher.ygoproExe
        proc.StartInfo.Arguments = "-d"
        proc.Start()
    End Sub

    Private Sub fileName_TextChanged(sender As Object, e As EventArgs) Handles fileName.TextChanged
        If deckList.Contains(fileName.Text) Then
            deckExists.Show()
            Save.Text = "Overwrite"
        Else
            deckExists.Hide()
            Save.Text = "Save"
        End If
    End Sub
End Class