public Class Register
    Public username As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox4.Text = "Ex. Google, YouTube..." Or TextBox4.Text = "" Then
            TextBox4.Text = "Not Specified"
        End If

        If My.Settings.Accounts < 5 Then
            If TextBox1.Text.Contains("<") = False And TextBox1.Text.Contains(">") = False And TextBox1.Text.Contains(",") = False And TextBox1.Text.Contains(":") = False And TextBox1.Text.Contains(";") = False Then
                If TextBox2.Text = TextBox3.Text Then
                    Launcher.Label12.Text = "Connecting..."
                    username = TextBox1.Text
                    Try
                        Launcher.RunRegister()
                    Catch
                        MsgBox("Can't connect to register server!")
                    End Try
                Else
                    MsgBox("Passwords don't match!")
                End If
            Else
                MsgBox("Username can't contain < > , : and ;")
            End If
        End If
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        If TextBox4.Text = "Ex. Google, YouTube..." Then
            TextBox4.ForeColor = Color.Black
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseMove
        If PictureBox8.Tag = "blue" Then
            PictureBox8.Image = My.Resources.Logo_Red
            PictureBox8.Tag = "red"
        End If
    End Sub

    Private Sub Register_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If PictureBox8.Tag = "red" Then
            PictureBox8.Image = My.Resources.Logo_Blue
            PictureBox8.Tag = "blue"
        End If
    End Sub
End Class