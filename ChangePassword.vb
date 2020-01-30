Public Class ChangePassword

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (password.Text <> confirmPassword.Text) Then
            MsgBox("Passwords don't match!")
            Return
        End If

        Launcher.SendToServer("SetAccountPassword<{]>" & Launcher.Encrypt(password.Text))
    End Sub
End Class