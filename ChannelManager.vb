Module ChannelManager
    Public messageList As New List(Of ChatMessage)
    Public channelList As New List(Of ChatChannel)
    Public emoticons As New List(Of Emoticon)

    Public Class ChatMessage
        Public time As String
        Public channel As String
        Public rank As String
        Public team As String
        Public title As String
        Public username As String
        Public message As String
        Public rtf As Boolean
        Public color As Color
        Public usernameColor As Integer
    End Class

    Public Class ChatChannel
        Public name As String
        Public password As String = ""
        Public motd As String
        Public owner As String = ""
        Public userlist As New List(Of String)
    End Class

    Public Class Emoticon
        Public name As String
        Public image As Image
        Public item As Integer = 0
    End Class

    Public Sub AddMessage(channel, rank, team, title, username, message, newColor, Optional rtf = False, Optional usernameColor = 0)
        Dim newMessage As New ChatMessage

        Dim x1Parts() As String
        x1Parts = Split(TimeOfDay, " ")

        newMessage.time = x1Parts(0)
        newMessage.channel = channel
        newMessage.rank = rank
        newMessage.team = team
        newMessage.title = title
        newMessage.username = username
        newMessage.message = message
        newMessage.rtf = rtf
        newMessage.usernameColor = usernameColor

        Dim color As Color

        If newColor = "Black" Then
            color = My.Settings.TextColor
        ElseIf newColor = "Blue" Then
            color = Drawing.Color.Blue
        ElseIf newColor = "Green" Then
            color = Drawing.Color.Green
        ElseIf newColor = "Red" Then
            color = Drawing.Color.Red
        ElseIf newColor = "Pink" Then
            color = Drawing.Color.HotPink
        ElseIf newColor = "FBI" Then
            color = Drawing.Color.Beige
        ElseIf newColor = "Rainbow" Then
            color = Drawing.Color.Bisque
        Else
            Try
                color = color.FromArgb(newColor)
            Catch
                color = My.Settings.System
            End Try
        End If

        newMessage.color = color
        messageList.Add(newMessage)

        If channel = Launcher.SelectedChannel Or rank = "System" Or rank = "Bot" Then
            AddChannelMessage(x1Parts(0), rank, team, title, username, message, color, rtf, usernameColor)
        Else
            newChannelMessage(channel)
        End If
    End Sub

    Public Sub newChannelMessage(channel)
        Dim selectedItem As Integer = 0
        For Each cChannel As String In Launcher.ListBox6.Items
            If cChannel = channel Then
                Launcher.ListBox6.Items(selectedItem) = "(1) " & channel
            ElseIf cChannel.Contains(channel) And cChannel.Contains(") ") Then
                Dim sParts() As String = Split(cChannel, ") ")
                If cChannel.Contains(sParts(1)) Then
                    Dim xParts() As String = Split(sParts(0), "(")
                    Dim messagesMissed As Integer = xParts(1)
                    messagesMissed += 1
                    Launcher.ListBox6.Items(selectedItem) = "(" & messagesMissed & ") " & channel
                End If
            End If
            selectedItem += 1
        Next
    End Sub

    Public Sub AddChannelMessage(time, rank, team, title, username, message, color, rtf, usernameColor)
        If Launcher.ignoreList.Contains(username) Then
            Return
        End If

        If My.Settings.ColoredMessages = True Then
            color = Drawing.Color.Black
        End If

        Dim displayUsername As String = ""
        If My.Settings.STS = True Then
            displayUsername = "[" & time & "]"
        End If
        If My.Settings.showTeam = True Then
            If team <> "" Then
                If displayUsername = "" Then
                    displayUsername = "[" & team & "]"
                Else
                    displayUsername = displayUsername & " [" & team & "]"
                End If
            End If
        End If
        If My.Settings.showTitle = True Then
            If title <> "None" Then
                If displayUsername = "" Then
                    displayUsername = "<" & title & ">"
                Else
                    displayUsername = displayUsername & " <" & title & ">"
                End If
            End If
        End If

        If displayUsername = "" Then
            displayUsername = username
        Else
            displayUsername = displayUsername & " " & username
        End If

        If usernameColor = 0 Then
            If rank = "Owner" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.Owner
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Administrator" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.Administrator
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Curator" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.Curator
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Diamond Member" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                If My.Settings.DiamondMember = color.White Then
                    Dim NextColor As Color = color.DarkViolet
                    displayUsername = displayUsername & ": "
                    For Each letter As Char In displayUsername
                        If letter <> " " Then
                            If NextColor = color.Red Then
                                NextColor = color.Orange
                            ElseIf NextColor = color.Orange Then
                                NextColor = color.Gold
                            ElseIf NextColor = color.Gold Then
                                NextColor = color.Green
                            ElseIf NextColor = color.Green Then
                                NextColor = color.Blue
                            ElseIf NextColor = color.Blue Then
                                NextColor = color.Indigo
                            ElseIf NextColor = color.Indigo Then
                                NextColor = color.DarkViolet
                            ElseIf NextColor = color.DarkViolet Then
                                NextColor = color.Red
                            End If
                            Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                            Launcher.PublicTxt.SelectionColor = NextColor
                            Launcher.PublicTxt.AppendText(letter)
                        Else
                            Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                            Launcher.PublicTxt.SelectionColor = NextColor
                            Launcher.PublicTxt.AppendText(letter)
                        End If
                    Next
                Else
                    Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                    Launcher.PublicTxt.SelectionColor = My.Settings.DiamondMember
                    Launcher.PublicTxt.AppendText(displayUsername & ": ")
                    Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                    Launcher.PublicTxt.SelectionLength = 0
                End If
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "FBI" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                If My.Settings.FBI <> color.White Then
                    Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                    Launcher.PublicTxt.SelectionColor = My.Settings.FBI
                    Launcher.PublicTxt.AppendText(displayUsername & ": ")
                    Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                    Launcher.PublicTxt.SelectionLength = 0
                Else
                    Dim NextColor As Color = color.Red
                    displayUsername = displayUsername & ": "
                    For Each letter As Char In displayUsername
                        If NextColor = color.Red Then
                            NextColor = color.Blue
                        ElseIf NextColor = color.Blue Then
                            NextColor = color.Red
                        End If
                        Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                        Launcher.PublicTxt.SelectionColor = NextColor
                        Launcher.PublicTxt.AppendText(letter)
                        Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                        Launcher.PublicTxt.SelectionLength = 0
                    Next
                End If
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Global Moderator" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.GlobalModerator
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Moderator" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.Moderator
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Gold Member" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.GoldMember
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Platinum Member" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.PlatinumMember
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Player" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.Player
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If Launcher.SelectedChannel <> "Team Channel" And Launcher.SelectedChannel <> "Staff Channel" And Launcher.SelectedChannel <> "Classified Channel" Then
                If rank = "System" Then
                    If Launcher.PublicTxt.Text <> "" Then
                        Launcher.PublicTxt.AppendText(Environment.NewLine)
                    End If
                    Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                    Launcher.PublicTxt.SelectionColor = My.Settings.System
                    Launcher.PublicTxt.AppendText(message)
                End If
            End If
            If rank = "MeCommand" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.System
                Launcher.PublicTxt.AppendText(message)
            End If
            If rank = "Bot" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.Bot
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
            If rank = "Event Manager" Then
                Launcher.PublicTxt.AppendText(Environment.NewLine)
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = My.Settings.EventManager
                Launcher.PublicTxt.AppendText(displayUsername & ": ")
                Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
                Launcher.PublicTxt.SelectionLength = 0
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                    Else
                        Launcher.PublicTxt.SelectionColor = color
                        Launcher.PublicTxt.AppendText(message)
                    End If
                ElseIf (color = Drawing.Color.Beige) Then
                    If rtf = True Then
                        AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddFBIMessage(message)
                    End If
                ElseIf (color = Drawing.Color.Bisque) Then
                    If rtf = True Then
                        AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                    Else
                        AddRainbowMessage(message)
                    End If
                End If
            End If
        Else
            Launcher.PublicTxt.AppendText(Environment.NewLine)
            Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
            Launcher.PublicTxt.SelectionColor = Drawing.Color.FromArgb(usernameColor)
            Launcher.PublicTxt.AppendText(displayUsername & ": ")
            Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
            Launcher.PublicTxt.SelectionLength = 0
            Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
            If (color <> Drawing.Color.Beige And color <> Drawing.Color.Bisque) Then
                If rtf = True Then
                    AppendRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine), color)
                Else
                    Launcher.PublicTxt.SelectionColor = color
                    Launcher.PublicTxt.AppendText(message)
                End If
            ElseIf (color = Drawing.Color.Beige) Then
                If rtf = True Then
                    AppendFbiRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                Else
                    AddFBIMessage(message)
                End If
            ElseIf (color = Drawing.Color.Bisque) Then
                If rtf = True Then
                    AppendRainbowRtf(Launcher.PublicTxt, message.Replace("<(]>", Environment.NewLine))
                Else
                    AddRainbowMessage(message)
                End If
            End If
        End If
        SetEmoticons()

        If Launcher.ChatScroll = True Then
            Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
            Launcher.PublicTxt.ScrollToCaret()
        End If
    End Sub

    Public Sub ChangeChannel(channel)
        Launcher.ListBox1.Items.Clear()

        If Launcher.myChannels.Contains(channel) = False Then
            Launcher.myChannels.Add(channel)
            AddChannel(channel)
            Launcher.JoinChannel(channel)
        End If

        Launcher.ListBox1.Items.Clear()
        Launcher.ListBox1.Items.Add("J.A.R.V.I.S.")
        If channel = "Public Channel" Then
            For Each username In Launcher.onlineuserlist
                If username <> Launcher.Username And Launcher.ListBox1.Items.Contains(username) = False Then
                    Launcher.ListBox1.Items.Add(username)
                End If
            Next
        ElseIf channel = "Team Channel" Then
            For Each user As String In Launcher.ListBox4.Items
                If Launcher.onlineuserlist.Contains(user) Then
                    Launcher.ListBox1.Items.Add(user)
                End If
            Next
        ElseIf channel = "Staff Channel" Then
            For Each user As String In Launcher.AdminList
                If user.Contains(":Player") = False And user.Contains(":Gold Member") = False And user.Contains(":Platinum Member") = False And user.Contains(":Diamond Member") = False And user.Contains(":FBI") = False And user.Contains(":Bot") = False Then
                    Dim yParts() As String = Split(user, ":")
                    If Launcher.onlineuserlist.Contains(yParts(0)) And Launcher.ListBox1.Items.Contains(yParts(0)) = False Then
                        Launcher.ListBox1.Items.Add(yParts(0))
                    End If
                End If
            Next
        Else
            For Each cChannel In channelList
                If cChannel.name = channel Then
                    For Each username In cChannel.userlist
                        If username <> Launcher.Username Then
                            If Launcher.ListBox1.Items.Contains(username) = False Then
                                Launcher.ListBox1.Items.Add(username)
                            End If
                        End If
                    Next
                End If
            Next
        End If

        Launcher.PublicTxt.Clear()
        Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
        Launcher.PublicTxt.SelectionColor = My.Settings.Bot
        Launcher.PublicTxt.AppendText("J.A.R.V.I.S. : ")
        Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
        Launcher.PublicTxt.SelectionColor = My.Settings.TextColor

        For Each cChannel As ChatChannel In channelList
            If cChannel.name = channel Then
                Launcher.PublicTxt.AppendText(cChannel.motd)
                Exit For
            End If
        Next


        Dim messageCount As Integer = 0
        For Each cMessage As ChatMessage In messageList
            If cMessage.channel = channel Or cMessage.rank = "System" Then
                messageCount += 1
            End If
        Next

        For Each chatMessage In messageList
            If My.Settings.ChatMessages <> 0 Then
                If chatMessage.channel = channel Or chatMessage.rank = "System" Then
                    If messageCount <= My.Settings.ChatMessages Then
                        AddChannelMessage(chatMessage.time, chatMessage.rank, chatMessage.team, chatMessage.title, chatMessage.username, chatMessage.message, chatMessage.color, chatMessage.rtf, chatMessage.usernameColor)
                        messageCount -= 1
                    Else
                        messageCount -= 1
                    End If
                End If
            Else
                If chatMessage.channel = channel Or chatMessage.rank = "System" Then
                    AddChannelMessage(chatMessage.time, chatMessage.rank, chatMessage.team, chatMessage.title, chatMessage.username, chatMessage.message, chatMessage.color, chatMessage.rtf, chatMessage.usernameColor)
                End If
            End If
        Next
    End Sub

    Public Sub AddChannel(channel)
        Dim channelList As New List(Of String)

        For Each ChatChannel As String In Launcher.ListBox6.Items
            If Launcher.myChannels.Contains(ChatChannel) = False Then
                channelList.Add(ChatChannel)
            End If
        Next
        For Each ChatChannel As String In channelList
            Launcher.ListBox6.Items.Remove(ChatChannel)
        Next

        For Each ChatChannel As String In channelList
            Launcher.ListBox6.Items.Add(ChatChannel)
        Next
    End Sub

    Public Sub ClearChannel(channel)
        Dim removeMessages As New List(Of ChatMessage)
        Try
            For Each chatMessage In messageList
                If chatMessage.channel = channel Then
                    removeMessages.Add(chatMessage)
                End If
            Next
            For Each chatMessage In removeMessages
                messageList.Remove(chatMessage)
            Next
        Catch
        End Try
    End Sub

    Public Sub SetEmoticons()
        'Try
        '    For Each emoticonX As Emoticon In emoticons
        '        While Launcher.PublicTxt.Text.Contains(emoticonX.name)
        '            Launcher.PublicTxt.ReadOnly = False
        '            Dim x As Integer

        '            If Clipboard.ContainsText Then
        '                Data = Clipboard.GetText
        '                DataType = ClipType.Text
        '            ElseIf Clipboard.ContainsImage Then
        '                Data = Clipboard.GetImage
        '                DataType = ClipType.Image
        '            ElseIf Clipboard.ContainsAudio Then
        '                Data = Clipboard.GetAudioStream
        '                DataType = ClipType.Audio
        '            ElseIf Clipboard.ContainsFileDropList Then
        '                Data = Clipboard.GetFileDropList
        '                DataType = ClipType.FileList
        '            Else
        '                Data = Nothing
        '                DataType = ClipType.Empty
        '            End If

        '            x = Launcher.PublicTxt.Text.IndexOf(emoticonX.name)
        '            Launcher.PublicTxt.Select(x, (emoticonX.name).Length)
        '            Clipboard.SetImage(emoticonX.image)
        '            Launcher.PublicTxt.Paste()

        '            Select Case DataType
        '                Case ClipType.Text
        '                    Clipboard.SetText(DirectCast(Data, String))
        '                Case ClipType.Image
        '                    Clipboard.SetImage(DirectCast(Data, Image))
        '                Case ClipType.FileList
        '                    Clipboard.SetFileDropList(DirectCast(Data, Specialized.StringCollection))
        '                Case ClipType.Audio
        '                    Clipboard.SetAudio(DirectCast(Data, IO.Stream))
        '                Case ClipType.Empty
        '                    Clipboard.Clear()
        '            End Select

        '            Launcher.PublicTxt.ReadOnly = True
        '        End While
        '    Next
        'Catch
        'End Try
    End Sub

    Sub AddFBIMessage(message)
        Dim NextColor As Color = Color.Red
        For Each letter As Char In message
            If NextColor = Color.Red Then
                NextColor = Color.Blue
            ElseIf NextColor = Color.Blue Then
                NextColor = Color.Red
            End If
            Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
            Launcher.PublicTxt.SelectionColor = NextColor
            Launcher.PublicTxt.AppendText(letter)
            Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
            Launcher.PublicTxt.SelectionLength = 0
        Next
    End Sub

    Sub AddRainbowMessage(message)
        Dim NextColor As Color = Color.DarkViolet
        For Each letter As Char In message
            If letter <> " " Then
                If NextColor = Color.Red Then
                    NextColor = Color.Orange
                ElseIf NextColor = Color.Orange Then
                    NextColor = Color.Gold
                ElseIf NextColor = Color.Gold Then
                    NextColor = Color.Green
                ElseIf NextColor = Color.Green Then
                    NextColor = Color.Blue
                ElseIf NextColor = Color.Blue Then
                    NextColor = Color.Indigo
                ElseIf NextColor = Color.Indigo Then
                    NextColor = Color.DarkViolet
                ElseIf NextColor = Color.DarkViolet Then
                    NextColor = Color.Red
                End If
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = NextColor
                Launcher.PublicTxt.AppendText(letter)
            Else
                Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
                Launcher.PublicTxt.SelectionColor = NextColor
                Launcher.PublicTxt.AppendText(letter)
            End If
        Next
    End Sub

    Public Sub AppendRtf(ByVal rtbTextBox As RichTextBox, ByVal strRtf As String, ByVal textColor As Color)
        Dim temporaryRichTextBox As New RichTextBox
        temporaryRichTextBox.Rtf = strRtf

        temporaryRichTextBox.Select(0, temporaryRichTextBox.Text.Length)
        temporaryRichTextBox.SelectionColor = textColor

        Dim newRtf As String = temporaryRichTextBox.Rtf.Replace("\pard", "")
        newRtf = newRtf.Replace("\par", "")

        rtbTextBox.SelectionStart = rtbTextBox.Text.Length
        rtbTextBox.SelectionLength = 0
        rtbTextBox.SelectedRtf = newRtf
    End Sub

    Public Sub AppendFbiRtf(ByVal rtbTextBox As RichTextBox, ByVal strRtf As String)
        Dim temporaryRichTextBox As New RichTextBox
        temporaryRichTextBox.Rtf = strRtf

        Dim x As Integer = 0
        Dim NextColor As Color = Color.Red
        For Each letter As Char In temporaryRichTextBox.Text
            If NextColor = Color.Red Then
                NextColor = Color.Blue
            ElseIf NextColor = Color.Blue Then
                NextColor = Color.Red
            End If
            temporaryRichTextBox.Select(x, 1)
            temporaryRichTextBox.SelectionColor = NextColor
            x += 1
        Next

        Dim newRtf As String = temporaryRichTextBox.Rtf.Replace("\pard", "")
        newRtf = newRtf.Replace("\par", "")

        rtbTextBox.SelectionStart = rtbTextBox.Text.Length
        rtbTextBox.SelectionLength = 0
        rtbTextBox.SelectedRtf = newRtf
    End Sub

    Public Sub AppendRainbowRtf(ByVal rtbTextBox As RichTextBox, ByVal strRtf As String)
        Dim temporaryRichTextBox As New RichTextBox
        temporaryRichTextBox.Rtf = strRtf

        Dim x As Integer = 0
        Dim NextColor As Color = Color.Red
        For Each letter As Char In temporaryRichTextBox.Text
            If NextColor = Color.Red Then
                NextColor = Color.Orange
            ElseIf NextColor = Color.Orange Then
                NextColor = Color.Gold
            ElseIf NextColor = Color.Gold Then
                NextColor = Color.Green
            ElseIf NextColor = Color.Green Then
                NextColor = Color.Blue
            ElseIf NextColor = Color.Blue Then
                NextColor = Color.Indigo
            ElseIf NextColor = Color.Indigo Then
                NextColor = Color.DarkViolet
            ElseIf NextColor = Color.DarkViolet Then
                NextColor = Color.Red
            End If
            temporaryRichTextBox.Select(x, 1)
            temporaryRichTextBox.SelectionColor = NextColor
            x += 1
        Next

        Dim newRtf As String = temporaryRichTextBox.Rtf.Replace("\pard", "")
        newRtf = newRtf.Replace("\par", "")

        rtbTextBox.SelectionStart = rtbTextBox.Text.Length
        rtbTextBox.SelectionLength = 0
        rtbTextBox.SelectedRtf = newRtf
    End Sub
End Module