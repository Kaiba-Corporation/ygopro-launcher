Public Class PrivateChat

    Public lastEnabled As Integer = -1
    Public lastImageLink As String = ""
    Public lastImageOpacity As String = ""
    Public lastBorderColor As String = ""
    Public lastMyTextColor As String = ""
    Public lastPartnerTextColor As String = ""
    Public lastTypingTextColor As String = ""
    Public lastTopBorderVisible As Integer = -1
    Public lastBottomBorderVisible As Integer = -1

    Public Sub LoadPrivateChat()
        UpdateWindow(Launcher.customPrivateChat, Launcher.privateChatImageLink, Launcher.privateChatImageOpacity, Launcher.privateChatBorderColor, Launcher.privateChatMyTextColor, Launcher.privateChatPartnerTextColor, Launcher.privateChatTypingTextColor, Launcher.privateChatTopBorderVisible, Launcher.privateChatBottomBorderVisible)
    End Sub

    Private Sub PrivateChat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    Private Sub RichTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If CheckBannedWords.CheckSwearingAdvertising(RichTextBox2.Text) = False Then
                RichTextBox2.Text = ""
                Return
            End If

            If RichTextBox2.Text <> "" Then
                If RichTextBox3.Text <> "" Then
                    RichTextBox3.AppendText(Environment.NewLine)
                End If
                Dim xparts() As String
                xparts = Split(TimeOfDay, " ")
                RichTextBox3.Select(RichTextBox3.TextLength, 0)
                RichTextBox3.SelectionColor = Color.FromArgb(lastMyTextColor)
                RichTextBox3.AppendText("[" & xparts(0) & "]  <<    " & RichTextBox2.Text.Trim())
                RichTextBox3.SelectionStart = RichTextBox3.TextLength
                RichTextBox3.SelectionLength = 0
                RichTextBox3.ScrollToCaret()
                If Me.Text <> "Seto Kaiba " Or Me.Text <> "Malcolm Merlyn " Then
                    Launcher.SendPrivateMessage(Me.Text, RichTextBox2.Text.Trim())
                End If
                RichTextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub RichTextBox3_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox3.LinkClicked
        Shell("cmd /c start " & e.LinkText)
    End Sub

    Public Sub UpdateWindow(ByVal enabled As Integer, ByVal imageLink As String, ByVal imageOpacity As String, ByVal borderColor As String, ByVal myTextColor As String, ByVal partnerTextColor As String, ByVal typingTextColor As String, ByVal topBorderVisible As Integer, ByVal bottomBorderVisible As Integer, Optional partnerCreated As Boolean = False)
        If partnerCreated = True And (enabled = 0 Or imageLink = "0") Then
            enabled = Launcher.customPrivateChat
            imageLink = Launcher.privateChatImageLink
            imageOpacity = Launcher.privateChatImageOpacity
            borderColor = Launcher.privateChatBorderColor
            myTextColor = Launcher.privateChatMyTextColor
            partnerTextColor = Launcher.privateChatPartnerTextColor
            typingTextColor = Launcher.privateChatTypingTextColor
            topBorderVisible = Launcher.privateChatTopBorderVisible
            bottomBorderVisible = Launcher.privateChatBottomBorderVisible
        End If

        If enabled = lastEnabled And enabled = 0 Then
            Return
        End If

        If enabled = 1 And imageLink <> "0" Then
            RichTextBox2.BorderStyle = BorderStyle.None
            RichTextBox3.BorderStyle = BorderStyle.None

            If lastImageLink <> imageLink Then
                lastImageLink = imageLink
                If imageLink <> "" Then
                    Dim setImageThread As New Threading.Thread(AddressOf setImage)
                    setImageThread.Start()
                Else
                    Me.BackgroundImage = My.Resources.Default_Private_Chat_Background
                End If
            End If

            If lastImageOpacity <> imageOpacity Then
                TranslucentPanel1.BackColor = Color.FromArgb(imageOpacity, 0, 0, 0)
                lastImageOpacity = imageOpacity
            End If

            If borderColor <> lastBorderColor Then
                Panel1.BackColor = Color.FromArgb(borderColor)
                Panel2.BackColor = Color.FromArgb(borderColor)
                Panel3.BackColor = Color.FromArgb(borderColor)
                Panel4.BackColor = Color.FromArgb(borderColor)
                Panel5.BackColor = Color.FromArgb(borderColor)
                Panel6.BackColor = Color.FromArgb(borderColor)
                Panel7.BackColor = Color.FromArgb(borderColor)
                Panel8.BackColor = Color.FromArgb(borderColor)
                lastBorderColor = borderColor
            End If

            If myTextColor <> lastMyTextColor Then
                lastMyTextColor = myTextColor
            End If

            If partnerTextColor <> lastPartnerTextColor Then
                lastPartnerTextColor = partnerTextColor
            End If

            If typingTextColor <> lastTypingTextColor Then
                lastTypingTextColor = typingTextColor
                RichTextBox2.ForeColor = Color.FromArgb(typingTextColor)
            End If

            If topBorderVisible <> lastTopBorderVisible Then
                lastTopBorderVisible = topBorderVisible
                If topBorderVisible = 1 Then
                    Panel1.Visible = True
                    Panel2.Visible = True
                    Panel5.Visible = True
                    Panel7.Visible = True
                Else
                    Panel1.Visible = False
                    Panel2.Visible = False
                    Panel5.Visible = False
                    Panel7.Visible = False
                End If
            End If

            If bottomBorderVisible <> lastBottomBorderVisible Then
                lastBottomBorderVisible = bottomBorderVisible
                If bottomBorderVisible = 1 Then
                    Panel3.Visible = True
                    Panel4.Visible = True
                    Panel6.Visible = True
                    Panel8.Visible = True
                Else
                    Panel3.Visible = False
                    Panel4.Visible = False
                    Panel6.Visible = False
                    Panel8.Visible = False
                End If
            End If
        Else
            Me.BackgroundImage = My.Resources.Default_Private_Chat_Background
            RichTextBox2.BorderStyle = BorderStyle.Fixed3D
            RichTextBox3.BorderStyle = BorderStyle.Fixed3D
            TranslucentPanel1.BackColor = Color.FromArgb(0, 0, 0, 0)
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
            lastMyTextColor = Color.Blue.ToArgb
            lastPartnerTextColor = Color.Green.ToArgb
            lastTypingTextColor = Color.Black.ToArgb
        End If
    End Sub

    Private Delegate Sub setImageDelegate()
    Private Sub setImage()
        Try
            Dim downloadedImage As Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(lastImageLink)))
            If Me.InvokeRequired Then
                Me.Invoke(New setImageDelegate(AddressOf setImage))
            Else
                Me.BackgroundImage = downloadedImage
            End If
        Catch
        End Try
    End Sub
End Class