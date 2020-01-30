Public Class Qualification_Challenge

    Public qualificationLevel As Integer
    Public freeTestsLeft As Integer

    Public Sub LoadQualification()
        Dim price As Integer

        If qualificationLevel = 0 Then
            Q1Panel.Show()
            price = 500
        ElseIf qualificationLevel = 1 Then
            Q2Panel.Show()
            price = 1000
        Else
            Q3Panel.Show()
            price = 1500
        End If

        currentLevel.Text = "Current Qualification Level: " & qualificationLevel

        If freeTestsLeft > 0 Then
            levelPrice.Text = "Level " & (qualificationLevel + 1) & " Price: 0 Gold"
        Else
            levelPrice.Text = "Level " & (qualificationLevel + 1) & " Price: " & price & " Gold"
        End If

        freeAttemptsLeft.Text = "Free Attempts Left Today: " & freeTestsLeft
    End Sub

    Private Sub startTest_Click(sender As Object, e As EventArgs) Handles startTest.Click
        If qualificationLevel = 0 Then
            Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Qualification1")
        ElseIf qualificationLevel = 1 Then
            Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Qualification2")
        Else
            Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Qualification3")
        End If
    End Sub

    Private Sub additionalInformation_Click(sender As Object, e As EventArgs) Handles additionalInformation.Click
        If qualificationLevel = 0 Then
            Shell("cmd /c start http://ygopro.club/index.php?/topic/266-qualification-request/")
        ElseIf qualificationLevel = 1 Then
            Shell("cmd /c start http://ygopro.club/index.php?/topic/267-supreme-qualification-request/")
        Else
            Shell("cmd /c start http://ygopro.club/index.php?/topic/2899-ultimate-qualification-request/")
        End If
    End Sub
End Class