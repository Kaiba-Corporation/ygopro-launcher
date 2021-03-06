﻿Public Class DuelingRobot

    Private Sub BackButton_MouseMove(sender As Object, e As EventArgs) Handles BackButton.MouseMove
        BackButton.Image = My.Resources.BackR
    End Sub

    Private Sub DuelingRobot_MouseMove(sender As Object, e As EventArgs) Handles Me.MouseMove, Buttons1.MouseMove, PictureBox1.MouseMove
        Buttons1.ResetButtons()
        BackButton.Image = My.Resources.BackB
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Launcher.singlePlayerDuelPage = New SinglePlayerDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.singlePlayerDuelPage)
        Me.Dispose()
    End Sub

    Private Sub Duel_Click(sender As Object, e As EventArgs) Handles Duel.Click
        If duelingRobotDeckListBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select a deck!", "Deck Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If startingHandCmBox.SelectedIndex = 0 And cardsPerDrawCmBox.SelectedIndex = 0 Then
            MessageBox.Show("Starting hand and cards per draw can't both be 0!", "Invalid Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim duelMode As String = duelModeCmBox.SelectedIndex
        Dim duelStartingHand As String = startingHandCmBox.SelectedIndex
        Dim duelCardsPerDraw As String = cardsPerDrawCmBox.SelectedIndex
        Dim duelLifePoints As String = lifePointsCmBox.SelectedItem

        Dim duelTimer As String = "3"
        If (turnTimerCmBox.SelectedIndex = 1) Then
            duelTimer = "7"
        End If

        Dim dontShuffle As String = "false"
        If dontShuffleChb.Checked Then
            dontShuffle = "true"
        End If

        Dim additionalSettings As String = "<{]>" & duelMode & "<{]>" & duelLifePoints & "<{]>" & duelStartingHand & "<{]>" & duelCardsPerDraw & "<{]>" & duelTimer & "<{]>" & dontShuffle

        If duelingRobotDeckListBox.SelectedItem = "Blue-Eyes White Dragon" Then
            Launcher.SendToServer("DuelingRobot<{]>Blue-Eyes<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Blue-Eyes Max Dragon" Then
            Launcher.SendToServer("DuelingRobot<{]>BlueEyesMaxDragon<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Chain Burn" Then
            Launcher.SendToServer("DuelingRobot<{]>ChainBurn<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Cyber Dragon" Then
            Launcher.SendToServer("DuelingRobot<{]>CyberDragon<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Dark Magician" Then
            Launcher.SendToServer("DuelingRobot<{]>DarkMagician<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Gren Maju Thunder Boarder" Then
            Launcher.SendToServer("DuelingRobot<{]>GrenMajuThunderBoarder<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Level VIII" Then
            Launcher.SendToServer("DuelingRobot<{]>Level8<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Mokey Mokey" Then
            Launcher.SendToServer("DuelingRobot<{]>MokeyMokey<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Mokey Mokey King" Then
            Launcher.SendToServer("DuelingRobot<{]>MokeyMokeyKing<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Rank V" Then
            Launcher.SendToServer("DuelingRobot<{]>Rank5<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Shaddoll Dinosaur" Then
            Launcher.SendToServer("DuelingRobot<{]>LightswornShaddoldinosour<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Sky Striker" Then
            Launcher.SendToServer("DuelingRobot<{]>SkyStriker<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Toadally Awesome" Then
            Launcher.SendToServer("DuelingRobot<{]>ToadallyAwesome<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Zexal Weapons" Then
            Launcher.SendToServer("DuelingRobot<{]>ZexalWeapons<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        Else
            Launcher.SendToServer("DuelingRobot<{]>" & duelingRobotDeckListBox.SelectedItem & "<{]>" & masterRulesCmBox.SelectedItem & additionalSettings)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim randomDeck As Integer = CInt(Int((5 * Rnd()) + 1))

        If randomDeck = Launcher.LastYugiDeck Then
            If randomDeck = 5 Then
                randomDeck = 1
            Else
                randomDeck += 1
            End If
        End If

        Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Yugi" & randomDeck)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim randomDeck As Integer = CInt(Int((8 * Rnd()) + 1))

        If randomDeck = Launcher.LastKaibaDeck Then
            If randomDeck = 8 Then
                randomDeck = 1
            Else
                randomDeck += 1
            End If
        End If

        Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Kaiba" & randomDeck)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Joey")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Dartz")
    End Sub

    Private Sub masterRulesCmBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles masterRulesCmBox.SelectedIndexChanged
        duelingRobotDeckListBox.Items.Clear()

        If masterRulesCmBox.SelectedItem = "3" Then
            duelingRobotDeckListBox.Items.AddRange(New Object() {"Blackwing", "Blue-Eyes Max Dragon", "Blue-Eyes White Dragon", "Burn", "Chain Burn", "Cyber Dragon", "Dark Magician", "Dragunity", "Evilswarm", "Frog", "Gravekeeper", "Horus", "Level VIII", "Lightsworn", "Mokey Mokey", "Mokey Mokey King", "Nekroz", "Phantasm", "Qliphort", "Rainbow", "Rank V", "Shaddoll Dinosaur", "Toadally Awesome", "Yosenju", "Zexal Weapons", "Zoodiac"})
        ElseIf masterRulesCmBox.SelectedItem = "4" Then
            duelingRobotDeckListBox.Items.AddRange(New Object() {"Altergeist", "Blackwing", "Blue-Eyes Max Dragon", "Blue-Eyes White Dragon", "Burn", "Chain Burn", "Cyber Dragon", "Dark Magician", "Dragun", "Dragunity", "Evilswarm", "Frog", "Gravekeeper", "Gren Maju Thunder Boarder", "Horus", "Level VIII", "Lightsworn", "Mokey Mokey", "Mokey Mokey King", "Nekroz", "Orcust", "Phantasm", "Qliphort", "Rainbow", "Rank V", "ST1732", "Salamangreat", "Shaddoll Dinosaur", "Sky Striker", "Trickstar", "Yosenju", "Zexal Weapons"})
        Else
            duelingRobotDeckListBox.Items.AddRange(New Object() {"Altergeist", "Blackwing", "Blue-Eyes Max Dragon", "Blue-Eyes White Dragon", "Burn", "Chain Burn", "Cyber Dragon", "Dark Magician", "Dragun", "Dragunity", "Evilswarm", "Frog", "Gravekeeper", "Gren Maju Thunder Boarder", "Horus", "Level VIII", "Lightsworn", "Mokey Mokey", "Mokey Mokey King", "Nekroz", "Orcust", "Phantasm", "Qliphort", "Rainbow", "Rank V", "ST1732", "Salamangreat", "Shaddoll Dinosaur", "Sky Striker", "Toadally Awesome", "Trickstar", "Yosenju", "Zexal Weapons", "Zoodiac"})
        End If
    End Sub
End Class
