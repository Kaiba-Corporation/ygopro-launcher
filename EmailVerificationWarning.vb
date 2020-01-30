Public Class EmailVerificationWarning

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim email As String = InputBox("Please enter your email address:", "Email Address")
        If email = "" Then
            Return
        End If
        Launcher.SendToServer("RequestEmailVerification<{]>" & email)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MessageBox.Show("It's recommended to verify your email address, if you don't verify your email you won't be able to reset your password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Settings.DVE = 1
        My.Settings.Save()
    End Sub
End Class