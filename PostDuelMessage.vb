Public Class PostDuelMessage

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        If CheckBox1.Checked = True Then
            My.Settings.ShowPostDuelMessages = 0
            My.Settings.Save()
        End If

        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            MsgBox("You can re-enable this feature from the Options!")
            My.Settings.ShowPostDuelMessages = 0
            My.Settings.Save()
        Else
            My.Settings.ShowPostDuelMessages = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub PostDuelMessage_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BringToFront()
    End Sub
End Class