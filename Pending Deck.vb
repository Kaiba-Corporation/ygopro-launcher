Public Class Pending_Deck

    Public deckId As Integer
    Public mainDeckList() As String
    Public sideDeckList() As String
    Public extraDeckList() As String

    Private Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        If deckDescriptionRtxt.Text.Contains(ControlChars.Lf) Then
            MsgBox("Description must not contain any new line characters! Do not press ENTER or create multiple paragraphs, keep everything as one paragraph!")
            Return
        End If

        If youTubeIdTxt.Text.Length > 0 And youTubeIdTxt.Text.Length <> 11 Then
            If youTubeIdTxt.Text.Contains("watch?v=") Then
                Dim sParts() As String = Split(youTubeIdTxt.Text, "watch?v=")
                If (sParts(1).Length >= 11) Then
                    youTubeIdTxt.Text = sParts(1).Substring(0, 11)
                Else
                    MessageBox.Show("Please enter a valid YouTube ID or a valid YouTube link, or leave the YouTube ID box empty!", "Invalid YouTube ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("Please enter a valid YouTube ID or a valid YouTube link, or leave the YouTube ID box empty!", "Invalid YouTube ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Launcher.SendToServer("ApproveDeck" & Launcher.Splitter & deckId.ToString & Launcher.Splitter & deckNameTxt.Text & Launcher.Splitter & deckDescriptionRtxt.Text & Launcher.Splitter & youTubeIdTxt.Text)
        Me.Close()
    End Sub

    Private Sub denyBtn_Click(sender As Object, e As EventArgs) Handles denyBtn.Click
        Launcher.SendToServer("DenyDeck" & Launcher.Splitter & deckId.ToString)
        Me.Close()
    End Sub

    Private Sub viewDeckBtn_Click(sender As Object, e As EventArgs) Handles viewDeckBtn.Click
        Dim fileName As String = deckNameTxt.Text & "_" & deckId.ToString
        If Not System.IO.File.Exists(Launcher.Current & "\YGOPRO\deck\" & fileName & ".ydk") Then
            System.IO.File.Create(Launcher.Current & "\YGOPRO\deck\" & fileName & ".ydk").Dispose()
        End If

        Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\deck\" & fileName & ".ydk")
        objwriter.WriteLine("#created by " & uploadedByLbl.Text)
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

        objwriter = New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "duel.CONF")
        objwriter.Write("#config file")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("#nickname & gamename should be less than 20 characters")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("skin_index = " & My.Settings.US)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("nickname = " & Launcher.Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & Launcher.gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lasthost = " & Launcher.IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & Launcher.gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("mute_chat = " & 1)
        objwriter.Close()

        CardSkinManager.CopyOwnedCardSkins()

        Dim proc As New Process()

        ChDir(Launcher.Current & "\YGOPRO")
        proc.StartInfo.FileName = Launcher.ygoproExe
        proc.StartInfo.Arguments = "-d"
        proc.Start()

        Dim deleteDeckThread As New Threading.Thread(AddressOf DeleteDeck)
        deleteDeckThread.Start(Launcher.Current & "\YGOPRO\deck\" & fileName & ".ydk")
    End Sub

    Private Sub DeleteDeck(deck As String)
        Try
            Threading.Thread.Sleep(7000)
            My.Computer.FileSystem.DeleteFile(deck)
        Catch
        End Try
    End Sub
End Class