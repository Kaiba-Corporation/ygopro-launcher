﻿Public Class Buttons

    Property Type As String

    Private Sub Home_MouseMove(sender As Object, e As MouseEventArgs) Handles Home.MouseMove
        Home.Image = My.Resources.HomeC_HL

        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Deck.Image = My.Resources.DeckC
        Replays.Image = My.Resources.ReplaysC
        Profile.Image = My.Resources.ProfileC
        Team.Image = My.Resources.TeamC
        Store.Image = My.Resources.StoreC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub ChatDuel_MouseMove(sender As Object, e As MouseEventArgs) Handles ChatDuel.MouseMove
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC_HL
        Else
            ChatDuel.Image = My.Resources.DuelC_HL
        End If

        Home.Image = My.Resources.HomeC
        Deck.Image = My.Resources.DeckC
        Replays.Image = My.Resources.ReplaysC
        Profile.Image = My.Resources.ProfileC
        Team.Image = My.Resources.TeamC
        Store.Image = My.Resources.StoreC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub Deck_MouseMove(sender As Object, e As MouseEventArgs) Handles Deck.MouseMove
        Deck.Image = My.Resources.DeckC_HL

        Home.Image = My.Resources.HomeC
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Replays.Image = My.Resources.ReplaysC
        Profile.Image = My.Resources.ProfileC
        Team.Image = My.Resources.TeamC
        Store.Image = My.Resources.StoreC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub Replays_MouseMove(sender As Object, e As MouseEventArgs) Handles Replays.MouseMove
        Replays.Image = My.Resources.ReplaysC_HL

        Home.Image = My.Resources.HomeC
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Deck.Image = My.Resources.DeckC
        Profile.Image = My.Resources.ProfileC
        Team.Image = My.Resources.TeamC
        Store.Image = My.Resources.StoreC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub Profile_MouseMove(sender As Object, e As MouseEventArgs) Handles Profile.MouseMove
        Profile.Image = My.Resources.ProfileC_HL

        Home.Image = My.Resources.HomeC
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Deck.Image = My.Resources.DeckC
        Replays.Image = My.Resources.ReplaysC
        Team.Image = My.Resources.TeamC
        Store.Image = My.Resources.StoreC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub Team_MouseMove(sender As Object, e As MouseEventArgs) Handles Team.MouseMove
        Team.Image = My.Resources.TeamC_HL

        Home.Image = My.Resources.HomeC
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Deck.Image = My.Resources.DeckC
        Replays.Image = My.Resources.ReplaysC
        Profile.Image = My.Resources.ProfileC
        Store.Image = My.Resources.StoreC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub Store_MouseMove(sender As Object, e As MouseEventArgs) Handles Store.MouseMove
        Store.Image = My.Resources.StoreC_HL

        Home.Image = My.Resources.HomeC
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Deck.Image = My.Resources.DeckC
        Replays.Image = My.Resources.ReplaysC
        Profile.Image = My.Resources.ProfileC
        Team.Image = My.Resources.TeamC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub Conclave_MouseMove(sender As Object, e As MouseEventArgs) Handles Conclave.MouseMove
        Conclave.Image = My.Resources.ConclaveC_HL

        Home.Image = My.Resources.HomeC
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Deck.Image = My.Resources.DeckC
        Replays.Image = My.Resources.ReplaysC
        Profile.Image = My.Resources.ProfileC
        Team.Image = My.Resources.TeamC
        Store.Image = My.Resources.StoreC
    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ResetButtons()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Launcher.HomePanel.Show()
        Launcher.HomePanel.BringToFront()
        Launcher.DuelPanel.Hide()
        Launcher.ChatPanel.Hide()

        If Launcher.inQueue = True Then
            Launcher.RankedQueue.BringToFront()
        End If

        ResetButtons()
    End Sub

    Private Sub Duel_Click(sender As Object, e As EventArgs) Handles ChatDuel.Click
        If Type = "Duel" Then
            Launcher.ChatPanel.Show()
            Launcher.ChatPanel.BringToFront()
            Launcher.DuelPanel.Hide()
            Launcher.HomePanel.Hide()
        Else
            Try
                Launcher.gameList.GameListView.Items.Clear()
                Launcher.gameList.refreshGameListPanel.Hide()
            Catch
            End Try
            Launcher.DuelPanel.Show()
            Launcher.DuelPanel.BringToFront()
            Launcher.ChatPanel.Hide()
            Launcher.HomePanel.Hide()
            Try
                Launcher.gameList.RequestRooms()
            Catch
            End Try
        End If

        If Launcher.inQueue = True Then
            Launcher.RankedQueue.BringToFront()
        End If

        ResetButtons()
    End Sub

    Private Sub Deck_Click(sender As Object, e As EventArgs) Handles Deck.Click
        Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "duel.CONF")
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
        If Launcher.Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyOwnedCardSkins()

        Dim proc As New Process()
        ChDir(Launcher.Current & "\YGOPRO")
        proc.StartInfo.FileName = Launcher.ygoproExe
        proc.StartInfo.Arguments = "-d"
        proc.Start()

        ResetButtons()
    End Sub

    Private Sub Replays_Click(sender As Object, e As EventArgs) Handles Replays.Click
        Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "duel.CONF")
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
        If Launcher.Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyFullCardDatabase()

        Dim proc As New Process()
        ChDir(Launcher.Current & "\YGOPRO")
        proc.StartInfo.FileName = Launcher.ygoproExe
        proc.StartInfo.Arguments = "-r"
        proc.Start()
        If Launcher.achievements.Contains(2) = False Then
            Launcher.AddAchievement(Launcher.Username, 2, 0)
            Launcher.achievements.Add(2)
        End If

        ResetButtons()
    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click
        Launcher.SendToServer("RequestMyProfile")

        ResetButtons()
    End Sub

    Private Sub Team_Click(sender As Object, e As EventArgs) Handles Team.Click
        If Launcher.MyTeam = "" Then
            Dim CreateTeamName = InputBox("Team Name: ", "Create Team")
            If CreateTeamName <> "" Then
                Launcher.SendToServer("CreateTeam<{]>" & Launcher.Username & "<{]>" & CreateTeamName)
            End If
        Else
            Launcher.SendToServer("RequestTeamProfile<{]>" & Launcher.MyTeam)
        End If

        If Launcher.inQueue = True Then
            Launcher.RankedQueue.BringToFront()
        End If

        ResetButtons()
    End Sub

    Private Sub Store_Click(sender As Object, e As EventArgs) Handles Store.Click
        Launcher.storeControl = New StoreControl
        Launcher.HomePanel.Controls.Add(Launcher.storeControl)
        Launcher.storeControl.BringToFront()

        Launcher.HomePanel.Show()
        Launcher.HomePanel.BringToFront()
        Launcher.DuelPanel.Hide()
        Launcher.ChatPanel.Hide()

        If Launcher.inQueue = True Then
            Launcher.RankedQueue.BringToFront()
        End If

        ResetButtons()
    End Sub

    Private Sub Conclave_Click(sender As Object, e As EventArgs) Handles Conclave.Click
        CommunityCenter.DownloadInformationFunction()
        CommunityCenter.ListBox1.Items.Clear()
        Launcher.ticketList.Clear()
        Launcher.SendToServer("RequestTickets")
        CommunityCenter.Show()

        ResetButtons()
    End Sub

    Public Sub ResetButtons()
        Home.Image = My.Resources.HomeC
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        Else
            ChatDuel.Image = My.Resources.DuelC
        End If
        Deck.Image = My.Resources.DeckC
        Replays.Image = My.Resources.ReplaysC
        Profile.Image = My.Resources.ProfileC
        Team.Image = My.Resources.TeamC
        Store.Image = My.Resources.StoreC
        Conclave.Image = My.Resources.ConclaveC
    End Sub

    Private Sub Buttons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Type = "Duel" Then
            ChatDuel.Image = My.Resources.ChatC
        End If
    End Sub
End Class
