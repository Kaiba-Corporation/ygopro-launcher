Imports MBGlassStyleProgressBar.MBProgressBar
Public Class Donations
    Dim donationProgressBar As New MBGlassStyleProgressBar.MBProgressBar
    Public donationValue As Integer

    Private Sub Donations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donationsLabel.Text = Launcher.currentMonthlyDonations & "%"

        If Launcher.currentMonthlyDonations <= 100 Then
            donationValue = Launcher.currentMonthlyDonations
        Else
            donationValue = 100
        End If

        donationProgressBar.Size = New Size(755, 26)
        donationProgressBar.Location = New Point(12, 36)
        Controls.Add(donationProgressBar)

        ProgressBarUpdate.Start()
    End Sub

    Private Sub ProgressBarUpdate_Tick(sender As Object, e As EventArgs) Handles ProgressBarUpdate.Tick
        If donationProgressBar.Value <= 7.5 Then
            donationProgressBar.Color = Color.Red
        ElseIf donationProgressBar.Value > 7.5 And donationProgressBar.Value <= 15 Then
            donationProgressBar.Color = Color.DarkOrange
        ElseIf donationProgressBar.Value > 15 And donationProgressBar.Value <= 70 Then
            donationProgressBar.Color = Color.Gold
        ElseIf donationProgressBar.Value > 70 And donationProgressBar.Value < 100 Then
            donationProgressBar.Color = Color.GreenYellow
        Else
            donationProgressBar.Color = Color.LimeGreen
        End If

        If donationProgressBar.Value < donationValue Then
            donationProgressBar.Value += 1
        Else
            ProgressBarUpdate.Stop()
        End If
    End Sub

    Private Sub diamondBuyBtn_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn.Click
        OpenStore()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("We would greatly appreciate your support in covering the server costs by purchasing one of these items. Help us today by making a small donation. Your donations help us keep the servers up and release new updates! You can click on ""What Do These Colors Mean?"" to get more information on how your donation will be used! Thanks again for your support!")
        Me.Close()
    End Sub

    Private Sub avatar_Click(sender As Object, e As EventArgs) Handles avatar.Click
        OpenStore()
    End Sub

    Private Sub cardBack_Click(sender As Object, e As EventArgs) Handles cardBack.Click
        OpenStore()
    End Sub

    Private Sub avatarCardBack_Click(sender As Object, e As EventArgs) Handles avatarCardBack.Click
        OpenStore()
    End Sub

    Public Sub OpenStore()
        Launcher.storeControl = New StoreControl
        Launcher.HomePanel.Controls.Add(Launcher.storeControl)
        Launcher.storeControl.BringToFront()

        Launcher.HomePanel.Show()
        Launcher.HomePanel.BringToFront()
        Launcher.DuelPanel.Hide()
        Launcher.ChatPanel.Hide()

        Me.Close()
    End Sub

    Private Sub avatar_MouseMove(sender As Object, e As MouseEventArgs) Handles avatar.MouseMove
        avatar.Image = My.Resources.Item_AvatarH

        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
    End Sub

    Private Sub cardBack_MouseMove(sender As Object, e As MouseEventArgs) Handles cardBack.MouseMove
        cardBack.Image = My.Resources.Item_CardBackH

        avatar.Image = My.Resources.Item_Avatar
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
    End Sub

    Private Sub avatarCardBack_MouseMove(sender As Object, e As MouseEventArgs) Handles avatarCardBack.MouseMove
        avatarCardBack.Image = My.Resources.Item_AvatarCardBackH

        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Label1.MouseMove, Label2.MouseMove, Label3.MouseMove, donationsLabel.MouseMove, diamondBuyBtn.MouseMove, Button1.MouseMove
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Process.Start("http://ygopro.club/index.php?/topic/7717-donation-system-explained/")
    End Sub
End Class