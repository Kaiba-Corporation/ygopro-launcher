Public Class PvPDuelPage

    Private Sub Unranked_MouseMove(sender As Object, e As EventArgs) Handles Unranked.MouseEnter
        Unranked.Image = My.Resources.UnrankedR
        Unranked.Tag = "R"

        If Ranked.Tag = "R" Then
            Ranked.Image = My.Resources.RankedB
            Ranked.Tag = ""
        End If
        If Tournaments.Tag = "R" Then
            Tournaments.Image = My.Resources.TournamentB
            Tournaments.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub Ranked_MouseMove(sender As Object, e As EventArgs) Handles Ranked.MouseEnter
        Ranked.Image = My.Resources.RankedR
        Ranked.Tag = "R"

        If Unranked.Tag = "R" Then
            Unranked.Image = My.Resources.UnrankedB
            Unranked.Tag = ""
        End If
        If Tournaments.Tag = "R" Then
            Tournaments.Image = My.Resources.TournamentB
            Tournaments.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub Tournaments_MouseMove(sender As Object, e As EventArgs) Handles Tournaments.MouseEnter
        Tournaments.Image = My.Resources.TournamentR
        Tournaments.Tag = "R"

        If Unranked.Tag = "R" Then
            Unranked.Image = My.Resources.UnrankedB
            Unranked.Tag = ""
        End If
        If Ranked.Tag = "R" Then
            Ranked.Image = My.Resources.RankedB
            Ranked.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub PvPDuelPage_MouseMove(sender As Object, e As EventArgs) Handles Me.MouseMove, PictureBox1.MouseEnter
        If Unranked.Tag = "R" Then
            Unranked.Image = My.Resources.UnrankedB
            Unranked.Tag = ""
        End If
        If Ranked.Tag = "R" Then
            Ranked.Image = My.Resources.RankedB
            Ranked.Tag = ""
        End If
        If Tournaments.Tag = "R" Then
            Tournaments.Image = My.Resources.TournamentB
            Tournaments.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub Buttons1_MouseMove(sender As Object, e As EventArgs) Handles Buttons1.MouseEnter
        If Unranked.Tag = "R" Then
            Unranked.Image = My.Resources.UnrankedB
            Unranked.Tag = ""
        End If
        If Ranked.Tag = "R" Then
            Ranked.Image = My.Resources.RankedB
            Ranked.Tag = ""
        End If
        If Tournaments.Tag = "R" Then
            Tournaments.Image = My.Resources.TournamentB
            Tournaments.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If
    End Sub

    Private Sub BackButton_MouseMove(sender As Object, e As EventArgs) Handles BackButton.MouseEnter
        BackButton.Image = My.Resources.BackR
        BackButton.Tag = "R"

        If Unranked.Tag = "R" Then
            Unranked.Image = My.Resources.UnrankedB
            Unranked.Tag = ""
        End If
        If Ranked.Tag = "R" Then
            Ranked.Image = My.Resources.RankedB
            Ranked.Tag = ""
        End If
        If Tournaments.Tag = "R" Then
            Tournaments.Image = My.Resources.TournamentB
            Tournaments.Tag = ""
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Launcher.frontDuelPage = New FrontDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.frontDuelPage)
        Me.Dispose()
    End Sub

    Private Sub Unranked_Click(sender As Object, e As EventArgs) Handles Unranked.Click
        Launcher.gameList = New GameList
        Launcher.gameList.gameListType = "Unranked"
        Launcher.gameList.banner.Image = My.Resources.UnrankedBanner
        Launcher.DuelPanel.Controls.Add(Launcher.gameList)
        Me.Dispose()
    End Sub

    Private Sub Ranked_Click(sender As Object, e As EventArgs) Handles Ranked.Click
        If Launcher.RankedStatus = 1 Then
            MsgBox("You are not allowed to play ranked games!")
            Return
        End If

        If Launcher.beta = True Then
            MsgBox("Ranked games are disabled during the beta!")
            Return
        End If

        Launcher.gameList = New GameList
        Launcher.gameList.gameListType = "Ranked"
        Launcher.gameList.banner.Image = My.Resources.RankedBanner
        Launcher.DuelPanel.Controls.Add(Launcher.gameList)
        Me.Dispose()
    End Sub

    Private Sub Tournaments_Click(sender As Object, e As EventArgs) Handles Tournaments.Click
        MsgBox("Tournament Mode is currently in development!")
        Return

        Launcher.tournamentPage = New TournamentList
        Launcher.tournamentPage.separatorPanel.Visible = True
        Launcher.DuelPanel.Controls.Add(Launcher.tournamentPage)
        Launcher.SendToServer("RequestTournamentList")
        Me.Dispose()
    End Sub
End Class
