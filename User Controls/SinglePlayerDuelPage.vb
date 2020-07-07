Imports System.IO

Public Class SinglePlayerDuelPage

    Private Sub DuelingRobot_MouseMove(sender As Object, e As EventArgs) Handles DuelingRobot.MouseEnter
        DuelingRobot.Image = My.Resources.DuelingRobotR
        DuelingRobot.Tag = "R"

        If SkillTests.Tag = "R" Then
            SkillTests.Image = My.Resources.SkillTestsB
            SkillTests.Tag = ""
        End If
        If Puzzles.Tag = "R" Then
            Puzzles.Image = My.Resources.PuzzlesB
            Puzzles.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub SkillTests_MouseMove(sender As Object, e As EventArgs) Handles SkillTests.MouseEnter
        SkillTests.Image = My.Resources.SkillTestsR
        SkillTests.Tag = "R"

        If DuelingRobot.Tag = "R" Then
            DuelingRobot.Image = My.Resources.DuelingRobotB
            DuelingRobot.Tag = ""
        End If
        If Puzzles.Tag = "R" Then
            Puzzles.Image = My.Resources.PuzzlesB
            Puzzles.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub Puzzles_MouseMove(sender As Object, e As EventArgs) Handles Puzzles.MouseEnter
        Puzzles.Image = My.Resources.PuzzlesR
        Puzzles.Tag = "R"

        If DuelingRobot.Tag = "R" Then
            DuelingRobot.Image = My.Resources.DuelingRobotB
            DuelingRobot.Tag = ""
        End If
        If SkillTests.Tag = "R" Then
            SkillTests.Image = My.Resources.SkillTestsB
            SkillTests.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub SinglePlayerDuelPage_MouseMove(sender As Object, e As EventArgs) Handles Me.MouseMove, PictureBox1.MouseEnter
        If DuelingRobot.Tag = "R" Then
            DuelingRobot.Image = My.Resources.DuelingRobotB
            DuelingRobot.Tag = ""
        ElseIf SkillTests.Tag = "R" Then
            SkillTests.Image = My.Resources.SkillTestsB
            SkillTests.Tag = ""
        Else
            Puzzles.Image = My.Resources.PuzzlesB
            Puzzles.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub
    Private Sub Buttons1_MouseMove(sender As Object, e As EventArgs) Handles Buttons1.MouseEnter
        If DuelingRobot.Tag = "R" Then
            DuelingRobot.Image = My.Resources.DuelingRobotB
            DuelingRobot.Tag = ""
        End If
        If SkillTests.Tag = "R" Then
            SkillTests.Image = My.Resources.SkillTestsB
            SkillTests.Tag = ""
        End If
        If Puzzles.Tag = "R" Then
            Puzzles.Image = My.Resources.PuzzlesB
            Puzzles.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If
    End Sub

    Private Sub BackButton_MouseMove(sender As Object, e As EventArgs) Handles BackButton.MouseEnter
        BackButton.Image = My.Resources.BackR
        BackButton.Tag = "R"

        If DuelingRobot.Tag = "R" Then
            DuelingRobot.Image = My.Resources.DuelingRobotB
            DuelingRobot.Tag = ""
        End If
        If SkillTests.Tag = "R" Then
            SkillTests.Image = My.Resources.SkillTestsB
            SkillTests.Tag = ""
        End If
        If Puzzles.Tag = "R" Then
            Puzzles.Image = My.Resources.PuzzlesB
            Puzzles.Tag = ""
        End If
        Buttons1.ResetButtons()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Launcher.frontDuelPage = New FrontDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.frontDuelPage)
        Me.Dispose()
    End Sub

    Private Sub Puzzles_Click(sender As Object, e As EventArgs) Handles Puzzles.Click
        If Launcher.launcherEdition = 2 Then
            MsgBox("Puzzles are not available in YGOPRO 2!")
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
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
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
        objwriter.Write("bot_duel = 0")
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
        proc.StartInfo.Arguments = "-s"
        proc.Start()
        If Launcher.achievements.Contains(3) = False Then
            Launcher.AddAchievement(Launcher.Username, 3, 0)
            Launcher.achievements.Add(3)
        End If

        If DuelingRobot.Tag = "R" Then
            DuelingRobot.Image = My.Resources.DuelingRobotB
            DuelingRobot.Tag = ""
        ElseIf SkillTests.Tag = "R" Then
            SkillTests.Image = My.Resources.SkillTestsB
            SkillTests.Tag = ""
        Else
            Puzzles.Image = My.Resources.PuzzlesB
            Puzzles.Tag = ""
        End If
        If BackButton.Tag = "R" Then
            BackButton.Image = My.Resources.BackB
            BackButton.Tag = ""
        End If

        Buttons1.ResetButtons()
    End Sub

    Private Sub DuelingRobot_Click(sender As Object, e As EventArgs) Handles DuelingRobot.Click
        Launcher.duelingRobot = New DuelingRobot
        Launcher.DuelPanel.Controls.Add(Launcher.duelingRobot)
        Launcher.duelingRobot.masterRulesCmBox.SelectedIndex = 2
        Launcher.duelingRobot.duelModeCmBox.SelectedIndex = 0
        Launcher.duelingRobot.lifePointsCmBox.SelectedIndex = 5
        Launcher.duelingRobot.startingHandCmBox.SelectedIndex = 5
        Launcher.duelingRobot.cardsPerDrawCmBox.SelectedIndex = 1
        Launcher.duelingRobot.turnTimerCmBox.SelectedIndex = 4
        Me.Dispose()
    End Sub

    Private Sub SkillTests_Click(sender As Object, e As EventArgs) Handles SkillTests.Click
        Launcher.skillTests = New SkillTests
        Launcher.DuelPanel.Controls.Add(Launcher.skillTests)
        Me.Dispose()
    End Sub
End Class
