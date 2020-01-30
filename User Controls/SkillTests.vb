Public Class SkillTests

    Private Sub BackButton_MouseMove(sender As Object, e As EventArgs) Handles BackButton.MouseMove
        BackButton.Image = My.Resources.BackR
    End Sub

    Private Sub DuelingRobot_MouseMove(sender As Object, e As EventArgs) Handles Me.MouseMove, Buttons1.MouseMove
        BackButton.Image = My.Resources.BackB
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Launcher.singlePlayerDuelPage = New SinglePlayerDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.singlePlayerDuelPage)
        Me.Dispose()
    End Sub


    Private Sub additionalInformation_Click(sender As Object, e As EventArgs) Handles additionalInformation.Click
        If currentLevel.Text = "Current Qualification Level: 1" Then
            Shell("cmd /c start http://ygopro.club/index.php?/topic/266-qualification-request/")
        ElseIf currentLevel.Text = "Current Qualification Level: 2" Then
            Shell("cmd /c start http://ygopro.club/index.php?/topic/267-supreme-qualification-request/")
        Else
            Shell("cmd /c start http://ygopro.club/index.php?/topic/2899-ultimate-qualification-request/")
        End If
    End Sub

    Private Sub practiceDuel_Click(sender As Object, e As EventArgs) Handles practiceDuel.Click
        Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "QualificationPractice")
    End Sub

    Private Sub startTest_Click(sender As Object, e As EventArgs) Handles startTest.Click
        MsgBox("This feature is currently disabled, you can still do practice duels for free!")
    End Sub
End Class
