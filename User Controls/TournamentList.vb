Public Class TournamentList

    Private Sub GameList_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        BackButton.Image = My.Resources.BackB
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Launcher.pvpDuelPage = New PvPDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.pvpDuelPage)
        Me.Dispose()
    End Sub

    Private Sub BackButton_MouseMove(sender As Object, e As MouseEventArgs) Handles BackButton.MouseMove
        BackButton.Image = My.Resources.BackR
    End Sub
End Class