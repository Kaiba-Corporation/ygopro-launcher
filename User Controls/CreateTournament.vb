Public Class CreateTournament

    Public Class Award
        Public gold As Integer = 0
        Public diamonds As Integer = 0
        Public crown As Integer = 0
        Public cardSkin As Integer = 0
        Public title As String = "No Title"
    End Class

    Dim winner As New Award
    Dim secondPlace As New Award
    Dim thirdPlace As New Award
    Dim fourthPlace As New Award

    Private Sub goldAward_TextChanged(sender As Object, e As EventArgs) Handles goldAward.TextChanged
        Try
            If goldAward.Text < 0 Then
                MsgBox("Gold must be a number: 0 or larger!")
                Return
            End If

            If player.SelectedItem = "Winner" Then
                winner.gold = goldAward.Text
            ElseIf player.SelectedItem = "2nd Place" Then
                secondPlace.gold = goldAward.Text
            ElseIf player.SelectedItem = "3rd Place" Then
                thirdPlace.gold = goldAward.Text
            ElseIf player.SelectedItem = "4th Place" Then
                fourthPlace.gold = goldAward.Text
            End If
        Catch
            If goldAward.Text <> "" Then
                MsgBox("Gold must be a number: 0 or larger!")
            End If
        End Try
    End Sub

    Private Sub diamondAward_TextChanged(sender As Object, e As EventArgs) Handles diamondAward.TextChanged
        Try
            If diamondAward.Text < 0 Then
                MsgBox("Diamonds must be a number: 0 or larger!")
                Return
            End If

            If player.SelectedItem = "Winner" Then
                winner.diamonds = diamondAward.Text
            ElseIf player.SelectedItem = "2nd Place" Then
                secondPlace.diamonds = diamondAward.Text
            ElseIf player.SelectedItem = "3rd Place" Then
                thirdPlace.diamonds = diamondAward.Text
            ElseIf player.SelectedItem = "4th Place" Then
                fourthPlace.diamonds = diamondAward.Text
            End If
        Catch
            If diamondAward.Text <> "" Then
                MsgBox("Diamonds must be a number: 0 or larger!")
            End If
        End Try
    End Sub

    Private Sub titleAward_SelectedIndexChanged(sender As Object, e As EventArgs) Handles titleAward.SelectedIndexChanged
        If player.SelectedItem = "Winner" Then
            winner.title = titleAward.Text
        ElseIf player.SelectedItem <> "Winner" And titleAward.Text = "Champion" Then
            MsgBox("Only the Winner can receive this title!")
            titleAward.SelectedIndex = 0
        End If
    End Sub

    Private Sub player_SelectedIndexChanged(sender As Object, e As EventArgs) Handles player.SelectedIndexChanged
        If player.Text = "Winner" Then
            goldAward.Text = winner.gold
            diamondAward.Text = winner.diamonds
            titleAward.Text = winner.title
            If winner.cardSkin <> 0 Then
                cardSkinChBox.Checked = True
            Else
                cardSkinChBox.Checked = False
            End If
            If winner.crown <> 0 Then
                crownChBox.Checked = True
            Else
                crownChBox.Checked = False
            End If
        ElseIf player.Text = "2nd Place" Then
            goldAward.Text = secondPlace.gold
            diamondAward.Text = secondPlace.diamonds
            titleAward.Text = secondPlace.title
            If secondPlace.cardSkin <> 0 Then
                cardSkinChBox.Checked = True
            Else
                cardSkinChBox.Checked = False
            End If
            If secondPlace.crown <> 0 Then
                crownChBox.Checked = True
            Else
                crownChBox.Checked = False
            End If
        ElseIf player.Text = "3rd Place" Then
            goldAward.Text = thirdPlace.gold
            diamondAward.Text = thirdPlace.diamonds
            titleAward.Text = thirdPlace.title
            If thirdPlace.cardSkin <> 0 Then
                cardSkinChBox.Checked = True
            Else
                cardSkinChBox.Checked = False
            End If
            If thirdPlace.crown <> 0 Then
                crownChBox.Checked = True
            Else
                crownChBox.Checked = False
            End If
        ElseIf player.Text = "4th Place" Then
            goldAward.Text = fourthPlace.gold
            diamondAward.Text = fourthPlace.diamonds
            titleAward.Text = fourthPlace.title
            If fourthPlace.cardSkin <> 0 Then
                cardSkinChBox.Checked = True
            Else
                cardSkinChBox.Checked = False
            End If
            If fourthPlace.crown <> 0 Then
                crownChBox.Checked = True
            Else
                crownChBox.Checked = False
            End If
        End If
    End Sub

    Private Sub numberic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles goldAward.KeyPress, diamondAward.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub createTournamentBtn_Click(sender As Object, e As EventArgs) Handles createTournamentBtn.Click
        If tournamentName.Text = "" Then
            MsgBox("Tournament name can't be empty!")
            Return
        End If

        If CheckBannedWords.Check(tournamentName.Text) = False Then
            MsgBox("Tournament name can't contain banned words!")
            Return
        End If

        If startDatePicker.Value.Date < DateTime.Now.Date Then
            MsgBox("Starting date can't be in the past!")
            Return
        End If

        If endDatePicker.Value.Date < startDatePicker.Value.Date Then
            MsgBox("Ending date must be larger than the starting date!")
            Return
        End If

        Launcher.SendToServer("CreateTournament" & Launcher.Splitter & tournamentName.Text & Launcher.Splitter & tournamentType.Text & Launcher.Splitter & maximumPlayers.Text _
                              & Launcher.Splitter & banlist.Text & Launcher.Splitter & qualificationList.Text & Launcher.Splitter & startDatePicker.Value.Date.ToString _
                              & Launcher.Splitter & endDatePicker.Value.Date.ToString & Launcher.Splitter & winner.gold & Launcher.Splitter & winner.diamonds _
                              & Launcher.Splitter & winner.title & Launcher.Splitter & secondPlace.gold & Launcher.Splitter & secondPlace.diamonds _
                              & Launcher.Splitter & thirdPlace.gold & Launcher.Splitter & thirdPlace.diamonds & Launcher.Splitter & fourthPlace.gold _
                              & Launcher.Splitter & fourthPlace.diamonds & Launcher.Splitter & tournamentImg.Tag & Launcher.Splitter & rulesTxt.Text)

        Launcher.tournamentList.Clear()
        Launcher.SendToServer("RequestTournamentList")
        Me.Dispose()
    End Sub

    Private Sub CreateTournament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Launcher.Rank <> "Player" And Launcher.Rank <> "Gold Member" And Launcher.Rank <> "Platinum Member" And Launcher.Rank <> "Diamond Member" Then
            tournamentType.Items.Add("Kaiba Corporation Weekly")
            titleAward.Items.Add("Champion")
        End If

        If Launcher.TeamLeader = True Then
            tournamentType.Items.Add("Team War")
        End If

        tournamentType.SelectedIndex = 0
        banlist.SelectedIndex = 0
        qualificationList.SelectedIndex = 0
        titleAward.SelectedIndex = 0
        player.SelectedIndex = 0
    End Sub

    Private Sub cardSkinChBox_CheckedChanged(sender As Object, e As EventArgs) Handles cardSkinChBox.CheckedChanged
        If player.SelectedItem = "Winner" Then
            winner.cardSkin = 1
        ElseIf player.SelectedItem = "2nd Place" Then
            secondPlace.cardSkin = 1
        ElseIf player.SelectedItem = "3rd Place" Then
            thirdPlace.cardSkin = 1
        ElseIf player.SelectedItem = "4th Place" Then
            fourthPlace.cardSkin = 1
        End If
    End Sub

    Private Sub crownChBox_CheckedChanged(sender As Object, e As EventArgs) Handles crownChBox.CheckedChanged
        If player.SelectedItem = "Winner" Then
            winner.crown = 1
        ElseIf player.SelectedItem = "2nd Place" Then
            secondPlace.crown = 1
        ElseIf player.SelectedItem = "3rd Place" Then
            thirdPlace.crown = 1
        ElseIf player.SelectedItem = "4th Place" Then
            fourthPlace.crown = 1
        End If
    End Sub

    Private Sub leftBtn_Click(sender As Object, e As EventArgs) Handles leftBtn.Click
        If tournamentImg.Tag = 1 Then
            tournamentImg.Image = My.Resources.News5
            tournamentImg.Tag = 5
        ElseIf tournamentImg.Tag = 2 Then
            tournamentImg.Image = My.Resources.News1
            tournamentImg.Tag = 1
        ElseIf tournamentImg.Tag = 3 Then
            tournamentImg.Image = My.Resources.News2
            tournamentImg.Tag = 2
        ElseIf tournamentImg.Tag = 4 Then
            tournamentImg.Image = My.Resources.News3
            tournamentImg.Tag = 3
        ElseIf tournamentImg.Tag = 5 Then
            tournamentImg.Image = My.Resources.News4
            tournamentImg.Tag = 4
        End If
    End Sub

    Private Sub rightBtn_Click(sender As Object, e As EventArgs) Handles rightBtn.Click
        If tournamentImg.Tag = 1 Then
            tournamentImg.Image = My.Resources.News2
            tournamentImg.Tag = 2
        ElseIf tournamentImg.Tag = 2 Then
            tournamentImg.Image = My.Resources.News3
            tournamentImg.Tag = 3
        ElseIf tournamentImg.Tag = 3 Then
            tournamentImg.Image = My.Resources.News4
            tournamentImg.Tag = 4
        ElseIf tournamentImg.Tag = 4 Then
            tournamentImg.Image = My.Resources.News5
            tournamentImg.Tag = 5
        ElseIf tournamentImg.Tag = 5 Then
            tournamentImg.Image = My.Resources.News1
            tournamentImg.Tag = 1
        End If
    End Sub
End Class