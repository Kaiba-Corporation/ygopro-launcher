Public Class Set_Chat_Color

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newColor As String = ComboBox1.Text
        If (newColor <> "Black" And newColor <> "Blue" And newColor <> "Green" And newColor <> "Red" And newColor <> "Pink" And newColor <> "FBI" And newColor <> "Rainbow") Then
            newColor = "Black"
        End If

        If newColor = "Blue" And Launcher.BlueChatColor = 0 Then
            MsgBox("You don't own the selected color, please purchase it from the store!")
            Return
        End If
        If newColor = "Green" And Launcher.GreenChatColor = 0 Then
            MsgBox("You don't own the selected color, please purchase it from the store!")
            Return
        End If
        If newColor = "Red" And Launcher.RedChatColor = 0 Then
            MsgBox("You don't own the selected color, please purchase it from the store!")
            Return
        End If
        If newColor = "Pink" And Launcher.PinkChatColor = 0 Then
            MsgBox("You don't own the selected color, please purchase it from the store!")
            Return
        End If
        If newColor = "FBI" And Launcher.FBIChatColor = 0 Then
            MsgBox("You don't own the selected color, please purchase it from the store!")
            Return
        End If
        If newColor = "Rainbow" And Launcher.RainbowChatColor = 0 Then
            MsgBox("You don't own the selected color, please purchase it from the store!")
            Return
        End If

        EditProfile.Label96.Text = newColor
        Launcher.SendToServer("SetColor<{]>" & newColor)
        Hide()
    End Sub

    Private Sub Set_Chat_Color_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Launcher.CustomUsernameColor = 0 Then
            Label2.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Me.Size = New Size(230, 105)
        Else
            Label2.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Me.Size = New Size(230, 170)
        End If

        If Launcher.customTextColor = 1 Then
            Panel1.Visible = True
            Button4.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usernameColorDialog As New ColorDialog
        usernameColorDialog.ShowDialog()
        Dim usernameColor As New Color
        usernameColor = usernameColorDialog.Color

        Launcher.SendToServer("SetUsernameColor" & Launcher.Splitter & usernameColor.ToArgb)
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Launcher.SendToServer("SetUsernameColor" & Launcher.Splitter & "0")
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim textColorDialog As New ColorDialog
        textColorDialog.ShowDialog()
        Dim textColor As New Color
        textColor = textColorDialog.Color

        Launcher.SendToServer("SetCustomTextColor" & Launcher.Splitter & textColor.ToArgb)
        Hide()
    End Sub
End Class