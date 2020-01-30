Public Class ForgotPassword

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Launcher.RunPasswordReset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If newpassword.Text <> confirmpassword.Text Then
            MsgBox("Passwords don't match!")
            Return
        End If

        Launcher.RunChangePassword()
    End Sub
End Class