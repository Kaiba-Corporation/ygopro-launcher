Public Class DuelingRobot

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

        Dim duelTimer As String = "240"
        If (turnTimerCmBox.SelectedIndex = 0) Then
            duelTimer = "30"
        ElseIf (turnTimerCmBox.SelectedIndex = 1) Then
            duelTimer = "60"
        ElseIf (turnTimerCmBox.SelectedIndex = 2) Then
            duelTimer = "120"
        ElseIf (turnTimerCmBox.SelectedIndex = 3) Then
            duelTimer = "180"
        ElseIf (turnTimerCmBox.SelectedIndex = 5) Then
            duelTimer = "300"
        ElseIf (turnTimerCmBox.SelectedIndex = 6) Then
            duelTimer = "600"
        ElseIf (turnTimerCmBox.SelectedIndex = 7) Then
            duelTimer = "1800"
        ElseIf (turnTimerCmBox.SelectedIndex = 8) Then
            duelTimer = "3600"
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

    Private Sub DuelingRobot_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, MyBase.MouseMove, Buttons1.MouseMove

    End Sub

    Private Sub addBotBtn_Click(sender As Object, e As EventArgs) Handles addBotBtn.Click
        If duelingRobotDeckListBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select a deck!", "Deck Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If portTxt.Text = "" Or Not IsNumeric(portTxt.Text) Then
            MessageBox.Show("Please enter a valid port!", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If portTxt.Text < 30000 Or portTxt.Text > 40000 Then
            MessageBox.Show("Port must be between 30000 and 40000!", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If duelingRobotDeckListBox.SelectedItem = "Blue-Eyes White Dragon" Then
            Launcher.SendToServer("AddBot<{]>Blue-Eyes<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Blue-Eyes Max Dragon" Then
            Launcher.SendToServer("AddBot<{]>BlueEyesMaxDragon<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Chain Burn" Then
            Launcher.SendToServer("AddBot<{]>ChainBurn<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Cyber Dragon" Then
            Launcher.SendToServer("AddBot<{]>CyberDragon<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Dark Magician" Then
            Launcher.SendToServer("AddBot<{]>DarkMagician<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Gren Maju Thunder Boarder" Then
            Launcher.SendToServer("AddBot<{]>GrenMajuThunderBoarder<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Level VIII" Then
            Launcher.SendToServer("AddBot<{]>Level8<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Mokey Mokey" Then
            Launcher.SendToServer("AddBot<{]>MokeyMokey<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Mokey Mokey King" Then
            Launcher.SendToServer("AddBot<{]>MokeyMokeyKing<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Rank V" Then
            Launcher.SendToServer("AddBot<{]>Rank5<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Shaddoll Dinosaur" Then
            Launcher.SendToServer("AddBot<{]>LightswornShaddoldinosour<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Sky Striker" Then
            Launcher.SendToServer("AddBot<{]>SkyStriker<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Toadally Awesome" Then
            Launcher.SendToServer("AddBot<{]>ToadallyAwesome<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        ElseIf duelingRobotDeckListBox.SelectedItem = "Zexal Weapons" Then
            Launcher.SendToServer("AddBot<{]>ZexalWeapons<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        Else
            Launcher.SendToServer("AddBot<{]>" & duelingRobotDeckListBox.SelectedItem & "<{]>" & portTxt.Text & "<{]>" & masterRulesCmBox.SelectedItem)
        End If
    End Sub

    Private Sub joinBtn_Click(sender As Object, e As EventArgs) Handles joinBtn.Click
        If portTxt.Text = "" Or Not IsNumeric(portTxt.Text) Then
            MessageBox.Show("Please enter a valid port!", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If portTxt.Text < 30000 Or portTxt.Text > 40000 Then
            MessageBox.Show("Port must be between 30000 and 40000", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

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
        objwriter.Write("roompass = " & "0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & portTxt.Text)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & Launcher.IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & portTxt.Text)
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
        objwriter.Write("bot_duel = 1")
        If Launcher.Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        Launcher.JarvisTimer.Start()
    End Sub
End Class
