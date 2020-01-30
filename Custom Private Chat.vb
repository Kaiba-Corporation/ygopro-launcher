Public Class Custom_Private_Chat

    Private Sub Custom_Private_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrivateChatImageLink.Text = Launcher.privateChatImageLink
        PrivateChatImageOpacity.Text = Launcher.privateChatImageOpacity
        PrivateChatBorderColor.BackColor = Color.FromArgb(Launcher.privateChatBorderColor)
        PrivateChatMyTextColor.BackColor = Color.FromArgb(Launcher.privateChatMyTextColor)
        PrivateChatPartnerTextColor.BackColor = Color.FromArgb(Launcher.privateChatPartnerTextColor)
        PrivateChatTypingTextColor.BackColor = Color.FromArgb(Launcher.privateChatTypingTextColor)
        If Launcher.privateChatTopBorderVisible = 1 Then
            PrivateChatTopBorderVisible.Checked = True
        Else
            PrivateChatTopBorderVisible.Checked = False
        End If
        If Launcher.privateChatBottomBorderVisible = 1 Then
            PrivateChatBottomBorderVisible.Checked = True
        Else
            PrivateChatBottomBorderVisible.Checked = False
        End If
    End Sub

    Private Sub PrivateChatBorderColor_Click(sender As Object, e As EventArgs) Handles PrivateChatBorderColor.Click
        ColorDialog1.ShowDialog()
        PrivateChatBorderColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub PrivateChatMyTextColor_Click(sender As Object, e As EventArgs) Handles PrivateChatMyTextColor.Click
        ColorDialog1.ShowDialog()
        PrivateChatMyTextColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub PrivateChatPartnerTextColor_Click(sender As Object, e As EventArgs) Handles PrivateChatPartnerTextColor.Click
        ColorDialog1.ShowDialog()
        PrivateChatPartnerTextColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub PrivateChatTypingTextColor_Click(sender As Object, e As EventArgs) Handles PrivateChatTypingTextColor.Click
        ColorDialog1.ShowDialog()
        PrivateChatTypingTextColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim previewPrivateChat As New PrivateChat
        Try
            Dim imageOpacity As Integer = PrivateChatImageOpacity.Text
            If imageOpacity < 0 Or imageOpacity > 255 Then
                MsgBox("Image Opacity must be between 0 and 255")
            Else
                previewPrivateChat.UpdateWindow(1, PrivateChatImageLink.Text, PrivateChatImageOpacity.Text, PrivateChatBorderColor.BackColor.ToArgb, PrivateChatMyTextColor.BackColor.ToArgb, PrivateChatPartnerTextColor.BackColor.ToArgb, PrivateChatTypingTextColor.BackColor.ToArgb, Convert.ToInt32(PrivateChatTopBorderVisible.Checked), Convert.ToInt32(PrivateChatBottomBorderVisible.Checked))
                previewPrivateChat.Text = Launcher.Username
                previewPrivateChat.Show()
            End If
        Catch ex As Exception
            MsgBox("Image Opacity must be between 0 and 255")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim imageOpacity As Integer = PrivateChatImageOpacity.Text
            If imageOpacity < 0 Or imageOpacity > 255 Then
                MsgBox("Image Opacity must be between 0 and 255")
            Else
                Launcher.privateChatImageLink = PrivateChatImageLink.Text
                Launcher.privateChatImageOpacity = PrivateChatImageOpacity.Text
                Launcher.privateChatBorderColor = PrivateChatBorderColor.BackColor.ToArgb
                Launcher.privateChatMyTextColor = PrivateChatMyTextColor.BackColor.ToArgb
                Launcher.privateChatPartnerTextColor = PrivateChatPartnerTextColor.BackColor.ToArgb
                Launcher.privateChatTypingTextColor = PrivateChatTypingTextColor.BackColor.ToArgb
                Launcher.privateChatTopBorderVisible = Convert.ToInt32(PrivateChatTopBorderVisible.Checked)
                Launcher.privateChatBottomBorderVisible = Convert.ToInt32(PrivateChatBottomBorderVisible.Checked)

                Launcher.SendToServer("UpdateCustomPrivateChat" & Launcher.Splitter & Launcher.privateChatImageLink & Launcher.Splitter & Launcher.privateChatImageOpacity & Launcher.Splitter & Launcher.privateChatBorderColor & Launcher.Splitter & Launcher.privateChatMyTextColor & Launcher.Splitter & Launcher.privateChatPartnerTextColor & Launcher.Splitter & Launcher.privateChatTypingTextColor & Launcher.Splitter & Launcher.privateChatTopBorderVisible & Launcher.Splitter & Launcher.privateChatBottomBorderVisible)
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Image Opacity must be between 0 and 255")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Launcher.privateChatImageLink = "0"
        Launcher.SendToServer("UpdateCustomPrivateChat" & Launcher.Splitter & 0 & Launcher.Splitter & 0 & Launcher.Splitter & Launcher.privateChatBorderColor & Launcher.Splitter & Launcher.privateChatMyTextColor & Launcher.Splitter & Launcher.privateChatPartnerTextColor & Launcher.Splitter & Launcher.privateChatTypingTextColor & Launcher.Splitter & Launcher.privateChatTopBorderVisible & Launcher.Splitter & Launcher.privateChatBottomBorderVisible)
        Me.Hide()
    End Sub
End Class