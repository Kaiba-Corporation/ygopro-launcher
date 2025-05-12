Imports System.Drawing

Public Class GameList

    Property gameListType As String = "Unranked"

    Public gameList As New List(Of Game)

    Private Sub GameList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gameListType = "Ranked" Then
            randomDuelBtn.Hide()
            refreshBtn.Location = New Point(753, 260)
        End If

        'If gameListType = "Unranked" Then
        Panel2.Hide()
        Label4.Hide()
        duelBtn.Enabled = False
        'Else
        '    AutoRefresh.Location = New Point(464, 372)
        '    FilterActiveGames.Visible = False
        '    FilterActiveGames.Checked = False
        '    Panel2.Controls.Add(refreshBtn)
        '    refreshBtn.Location = New Point(31, 5)
        '    randomDuelBtn.Enabled = False
        '    hostBtn.Enabled = False
        '    joinBtn.Text = "Spectate"
        'End If

        banlistCmBox.SelectedIndex = 0
        duelTypeCmBox.SelectedIndex = 0
        gameModeCmBox.SelectedIndex = 0

        RequestRooms()
    End Sub

    Public Sub AddGame(game As Game)
        If game.gameType <> gameListType Then
            If Not (game.gameType = "Battle City" And gameListType = "Unranked") And Not (game.gameType = "Rush" And gameListType = "Unranked") Then
                Return
            End If
        End If

        If banlistCmBox.Text <> "All" Then
            If banlistCmBox.Text <> game.banlist Then
                Return
            End If
        End If

        If duelTypeCmBox.Text <> "All" Then
            If duelTypeCmBox.Text <> game.type Then
                Return
            End If
        End If

        If gameModeCmBox.Text <> "All" Then
            If gameModeCmBox.Text <> game.mode Then
                Return
            End If
        End If

        If playersTxt.Text <> "" Then
            Dim usernameLC As String = playersTxt.Text.ToLower
            Dim gameUsernameLC As String = game.players.ToLower

            If gameUsernameLC.Contains(usernameLC) = False Then
                Return
            End If
        End If

        If game.status = "Hosting" Then
            If game.host = "Seto Kaiba " Or game.host = "Yugi Moto " Or game.host = "Joey Wheeler " Or game.host = "Marik Ishtar " Or game.host = "Dartz " Or game.host = "Dueling Robot " Or game.host = "J.A.R.V.I.S." Then
                Return
            End If
        End If

        Dim newGame As ListViewItem
        GameListView.BeginUpdate()

        newGame = GameListView.Items.Add(game.name)
        newGame.SubItems.Add(game.type)
        newGame.SubItems.Add(game.masterRules)
        newGame.SubItems.Add(game.banlist)
        newGame.SubItems.Add(game.mode)
        newGame.SubItems.Add(game.host)
        newGame.SubItems.Add(game.status)

        Dim gameColor As New Color
        If game.status = "Dueling" Then
            gameColor = Color.FromArgb(228, 228, 228)
        ElseIf game.gameType = "Rush" Then
            gameColor = Color.FromArgb(238, 191, 238)
        ElseIf game.banlist = "No Banlist" Or (game.additionalRules <> "Additional Rules: None" And game.additionalRules <> "Rules: 7 Minute Timer") Then
            gameColor = Color.FromArgb(255, 210, 210)
        ElseIf game.type = "Single" Then
            gameColor = Color.FromArgb(192, 255, 192)
        ElseIf game.type = "Match" Then
            gameColor = Color.FromArgb(192, 255, 255)
        ElseIf game.type = "Tag" Then
            gameColor = Color.FromArgb(255, 255, 192)
        End If
        newGame.BackColor = gameColor

        GameListView.Update()
        GameListView.EndUpdate()
    End Sub

    Public Sub RequestRooms()
        If FilterActiveGames.Checked = True Then
            Launcher.SendToServer("GetRooms<{]>0")
        Else
            Launcher.SendToServer("GetRooms<{]>1")
        End If
    End Sub

    Private Sub GameListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GameListView.SelectedIndexChanged
        hidePanel.Visible = False
        rankedQueue.Visible = False

        Try
            gameNameLabel.Text = GameListView.SelectedItems(0).Text
            duelTypeLabel.Text = "Duel Type: " & GameListView.SelectedItems(0).SubItems(1).Text
            banlistLabel.Text = "Banlist: " & GameListView.SelectedItems(0).SubItems(3).Text
            gameModeLabel.Text = "Game Mode: " & GameListView.SelectedItems(0).SubItems(4).Text
            hostedByLabel.Text = "Hosted By: " & GameListView.SelectedItems(0).SubItems(5).Text

            For Each game As Game In gameList
                If game.name = gameNameLabel.Text Then
                    playerslabel.Text = "Players: " & game.players
                    additionalRulesLabel.Text = game.additionalRules
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub FilterActiveGames_Click(sender As Object, e As EventArgs) Handles FilterActiveGames.Click
        RequestRooms()
    End Sub

    Private Sub GameListView_DoubleClick(sender As Object, e As EventArgs) Handles GameListView.DoubleClick, joinBtn.Click
        JoinGame()
    End Sub

    Private Sub JoinGame()
        Try
            Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "duel.CONF")
            objwriter.WriteLine("#config file")
            objwriter.WriteLine("#nickname & gamename should be less than 20 characters")
            objwriter.WriteLine("skin_index = " & My.Settings.US)
            objwriter.WriteLine("nickname = " & Launcher.Username)
            objwriter.WriteLine("gamename = Game")
            objwriter.WriteLine("roompass = " & gameNameLabel.Text)
            objwriter.WriteLine("serverport = " & Launcher.gamePort)
            objwriter.WriteLine("lasthost = " & Launcher.IP)
            objwriter.WriteLine("lastport = " & Launcher.gamePort)
            If Launcher.Mute = 0 Then
                objwriter.WriteLine("mute_chat = " & 0)
            Else
                objwriter.WriteLine("mute_chat = " & 1)
            End If
            objwriter.Close()

            CardSkinManager.CopyFullCardDatabase()

            Dim proc As New Process()

            ChDir(Launcher.Current & "\YGOPRO")
            proc.StartInfo.FileName = Launcher.ygoproExe
            proc.StartInfo.Arguments = "-j"
            proc.Start()
        Catch
        End Try
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        RequestRooms()
    End Sub

    Private Sub duelTypeCmBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles duelTypeCmBox.SelectedIndexChanged, gameModeCmBox.SelectedIndexChanged, banlistCmBox.SelectedIndexChanged, playersTxt.TextChanged
        GameListView.Items.Clear()

        For Each game As Game In gameList
            AddGame(game)
        Next

        If banlistCmBox.Text <> "All" Or duelTypeCmBox.Text <> "All" Or gameModeCmBox.Text <> "All" Or playersTxt.Text <> "" Then
            If FilterActiveGames.Checked Then
                gameCount.Text = "Sorted Available " & gameListType & " Games: " & GameListView.Items.Count
            Else
                gameCount.Text = "Sorted " & gameListType & " Games: " & GameListView.Items.Count
            End If
        Else
            If FilterActiveGames.Checked Then
                gameCount.Text = "Available " & gameListType & " Games: " & GameListView.Items.Count
            Else
                gameCount.Text = "All " & gameListType & " Games: " & GameListView.Items.Count
            End If
        End If
    End Sub

    Private Sub hostBtn_Click(sender As Object, e As EventArgs) Handles hostBtn.Click
        Dim newHostForm As New HostForm
        newHostForm.gameType = gameListType
        newHostForm.Show()
    End Sub

    Private Sub randomDuelBtn_Click(sender As Object, e As EventArgs) Handles randomDuelBtn.Click
        RandomD.gameType = gameListType
        If gameListType <> "Unranked" Then
            RandomD.cardsAll.Enabled = False
            RandomD.cardsTCG.Enabled = False
            RandomD.cardsOCG.Enabled = False
            RandomD.banlistNo.Enabled = False
        Else
            RandomD.cardsAll.Enabled = True
            RandomD.cardsTCG.Enabled = True
            RandomD.cardsOCG.Enabled = True
            RandomD.banlistNo.Enabled = True
        End If
        RandomD.Show()
    End Sub

    Private Sub BackButton_MouseMove(sender As Object, e As MouseEventArgs) Handles BackButton.MouseMove
        BackButton.Image = My.Resources.BackR
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Launcher.pvpDuelPage = New PvPDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.pvpDuelPage)
        Me.Dispose()
    End Sub

    Private Sub GameList_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Buttons1.MouseMove
        BackButton.Image = My.Resources.BackB
    End Sub

    Private Sub duelBtn_Click(sender As Object, e As EventArgs) Handles duelBtn.Click
        tcgSingle.Enabled = True
        tcgMatch.Enabled = True
        ocgSingle.Enabled = True
        ocgMatch.Enabled = True
        moreInfo.Enabled = True
        rankedQueue.Show()
    End Sub

    Private Sub tcgSingle_Click(sender As Object, e As EventArgs) Handles tcgSingle.Click
        If ExtendedSearch.Checked Then
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "TCG" & Launcher.Splitter & "Single" & Launcher.Splitter & 1)
        Else
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "TCG" & Launcher.Splitter & "Single" & Launcher.Splitter & 0)
        End If
    End Sub

    Private Sub tcgMatch_Click(sender As Object, e As EventArgs) Handles tcgMatch.Click
        If ExtendedSearch.Checked Then
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "TCG" & Launcher.Splitter & "Match" & Launcher.Splitter & 1)
        Else
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "TCG" & Launcher.Splitter & "Match" & Launcher.Splitter & 0)
        End If
    End Sub

    Private Sub ocgSingle_Click(sender As Object, e As EventArgs) Handles ocgSingle.Click
        If ExtendedSearch.Checked Then
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "OCG" & Launcher.Splitter & "Single" & Launcher.Splitter & 1)
        Else
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "OCG" & Launcher.Splitter & "Single" & Launcher.Splitter & 0)
        End If
    End Sub

    Private Sub ocgMatch_Click(sender As Object, e As EventArgs) Handles ocgMatch.Click
        If ExtendedSearch.Checked Then
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "OCG" & Launcher.Splitter & "Match" & Launcher.Splitter & 1)
        Else
            Launcher.SendToServer("SearchForDuel" & Launcher.Splitter & "OCG" & Launcher.Splitter & "Match" & Launcher.Splitter & 0)
        End If
    End Sub

    Private Sub moreInfo_Click(sender As Object, e As EventArgs) Handles moreInfo.Click
        MsgBox("Extended search looks for opponents in a higher rating range, an opponent may be found faster however your opponent may have a significantly higher or lower rating than you.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RequestRooms()
    End Sub
End Class