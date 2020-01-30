Public Class Set_Title

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Custom" Then
            EditProfile.Label82.Text = "<" & TextBox1.Text & ">"
        Else
            EditProfile.Label82.Text = ComboBox1.Text
        End If

        EditProfile.UpdateProfile(False)
        Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Custom" Then
            TextBox1.Visible = True
            Label1.Visible = True
        Else
            TextBox1.Visible = False
            Label1.Visible = False
        End If
    End Sub
End Class