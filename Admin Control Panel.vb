Public Class Admin_Control_Panel

    Public imageLink As String = ""
    Public usernameSearch As String = ""

    Public Class StaffMember
        Public username As String
        Public rank As String
        Public lastLoginDate As String
        Public totalActions As Integer
        Public timeOnlineThisMonth As String
        Public timeOnlineLastMonth As String
        Public timeOnlineTotal As String
        Public timeOnlineThisWeek As String
        Public staffLevel As Integer

        Sub New(newUsername, newRank, newLastLoginDate, newTimeOnlineThisMonth, newTimeOnlineLastMonth, newTimeOnlineTotal, newTimeOnlineThisWeek, newTotalActions)
            username = newUsername
            rank = newRank
            totalActions = newTotalActions

            Dim sParts() As String = Split(newLastLoginDate, " ")
            lastLoginDate = sParts(0)

            Dim timeSpanThisMonth As TimeSpan = TimeSpan.FromSeconds(newTimeOnlineThisMonth)
            timeOnlineThisMonth = timeSpanThisMonth.Days & " Days  " & AddZero(timeSpanThisMonth.Hours) & ":" & AddZero(timeSpanThisMonth.Minutes) & ":" & AddZero(timeSpanThisMonth.Seconds)
            Dim timeSpanLastMonth As TimeSpan = TimeSpan.FromSeconds(newTimeOnlineLastMonth)
            timeOnlineLastMonth = timeSpanLastMonth.Days & " Days  " & AddZero(timeSpanLastMonth.Hours) & ":" & AddZero(timeSpanLastMonth.Minutes) & ":" & AddZero(timeSpanLastMonth.Seconds)
            Dim timeSpantimeOnlineTotal As TimeSpan = TimeSpan.FromSeconds(newTimeOnlineTotal)
            timeOnlineTotal = timeSpantimeOnlineTotal.Days & " Days  " & AddZero(timeSpantimeOnlineTotal.Hours) & ":" & AddZero(timeSpantimeOnlineTotal.Minutes) & ":" & AddZero(timeSpantimeOnlineTotal.Seconds)
            Dim timeSpanThisWeek As TimeSpan = TimeSpan.FromSeconds(newTimeOnlineThisWeek)
            timeOnlineThisWeek = timeSpanThisWeek.Days & " Days  " & AddZero(timeSpanThisWeek.Hours) & ":" & AddZero(timeSpanThisWeek.Minutes) & ":" & AddZero(timeSpanThisWeek.Seconds)

            If rank = "Moderator" Then
                staffLevel = 0
            ElseIf rank = "Global Moderator" Then
                staffLevel = 1
            ElseIf rank = "Event Manager" Then
                staffLevel = 2
            ElseIf rank = "Curator" Then
                staffLevel = 3
            ElseIf rank = "Administrator" Then
                staffLevel = 4
            ElseIf rank = "Owner" Then
                staffLevel = 5
            End If
        End Sub
        Public Function AddZero(input As Integer)
            Dim output As String

            If input < 10 Then
                output = "0" & input
            Else
                output = input
            End If

            Return output
        End Function
    End Class

    Public Sub setImageFunction(ByVal link As String)
        imageLink = link

        Dim setImageThread As New Threading.Thread(AddressOf setImage)
        setImageThread.Start()
    End Sub

    Private Delegate Sub setImageDelegate()
    Private Sub setImage()
        Try
            Dim downloadedImage As Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(imageLink)))
            If PictureBox1.InvokeRequired Then
                PictureBox1.Invoke(New setImageDelegate(AddressOf setImage))
            Else
                PictureBox1.Image = downloadedImage
            End If
        Catch
        End Try
    End Sub

    Private Sub Admin_Control_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Launcher.Rank = "Player" Or Launcher.Rank = "Gold Member" Or Launcher.Rank = "Platinum Member" Or Launcher.Rank = "Diamond Member" Then
            Return
        End If

        Button16.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button9.Enabled = True
        Button15.Enabled = True
        disableTickets.Enabled = True

        If Launcher.Rank = "Owner" Or Launcher.Rank = "Administrator" Or Launcher.Rank = "Global Moderator" Or Launcher.Rank = "Event Manager" Or Launcher.Rank = "Curator" Then
            Button14.Enabled = True
            Button13.Enabled = True
            Button12.Enabled = True
            banIPBtn.Enabled = True
            banComputerBtn.Enabled = True
            reveseBanIPBtn.Enabled = True
            reverseBanComputerBtn.Enabled = True
        End If

        If Launcher.Rank = "Owner" Or Launcher.Rank = "Administrator" Or Launcher.Rank = "Curator" Or Launcher.Rank = "Event Manager" Then
            Button10.Enabled = True
            Button11.Enabled = True
        End If

        If Launcher.Rank = "Owner" Or Launcher.Rank = "Administrator" Or Launcher.Rank = "Curator" Then
            rankTextBox.ReadOnly = False
            setRankBtn.Enabled = True
            disbandTeamBtn.Enabled = True
            newPasswordTxt.ReadOnly = False
            resetPasswordBtn.Enabled = True
        End If

        newsImage.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchForUser()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox1.Clear()
        Launcher.SendToServer("ShowStaffActions" + Launcher.Splitter + usernameSearch + Launcher.Splitter + TextBox11.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox3.Clear()
        Launcher.SendToServer("FindAllAccounts" + Launcher.Splitter + IP.Text + Launcher.Splitter + MAC.Text + Launcher.Splitter + UniqueID.Text)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to use this code?", "Use Code", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        Launcher.SendToServer("usecode<{]>" & TextBox12.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to " + Button15.Text.ToLower + " games for " + usernameSearch + "?", Button15.Text + " Games", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If Reason.Text = "" Then
            Reason.Text = "None"
        End If

        If Button15.Text = "Disable Ranked" Then
            Launcher.SendToServer("disableranked<{]>" & usernameSearch & Launcher.Splitter & Reason.Text)
        Else
            Launcher.SendToServer("enableranked<{]>" & usernameSearch & Launcher.Splitter & Reason.Text)
        End If
        SearchForUser()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to kick " + usernameSearch + "?", "Kick User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If Reason.Text = "" Then
            Reason.Text = "None"
        End If

        Launcher.SendToServer("kick<{]>" & usernameSearch & "<{]>" & Launcher.Username & "<{]>" & Reason.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to " + Button3.Text.ToLower + " " + usernameSearch + "?", Button3.Text + " User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If Reason.Text = "" Then
            Reason.Text = "None"
        End If

        If Button3.Text = "Mute" Then
            If TextBox6.Text = "0" Then
                Launcher.SendToServer("mute<{]>" & usernameSearch & "<{]>" & Launcher.Username & "<{]>" & Reason.Text)
            Else
                Try
                    Dim muteUntil As Double = TextBox6.Text
                    Launcher.SendToServer("timedmute<{]>" & usernameSearch & "<{]>" & muteUntil & "<{]>" & Reason.Text)
                Catch
                    MsgBox("Please enter a number!")
                End Try
            End If
        Else
            Launcher.SendToServer("unmute<{]>" & usernameSearch & "<{]>" & Launcher.Username & "<{]>" & Reason.Text)
        End If

        SearchForUser()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to change warning points for " + usernameSearch + "?", "Change Warning Points", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If Reason.Text = "" Then
            Reason.Text = "None"
        End If

        Launcher.SendToServer("setwp<{]>" & usernameSearch & "<{]>" & Launcher.Username & "<{]>" & Reason.Text & "<{]>" & TextBox5.Text)
        SearchForUser()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to " + Button5.Text.ToLower + " " + usernameSearch + "?", Button5.Text + " User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        Dim time As Integer = 0

        If Button5.Text = "Ban" Then
            Try
                time = TextBox7.Text

                If time < 0 Then
                    MsgBox("Please enter 0 or a larger number for hours, 0 for permanent ban!")
                End If

                If time = 0 Then
                    If Launcher.Rank = "Administrator" Or Launcher.Rank = "Owner" Or Launcher.Rank = "Global Moderator" Or Launcher.Rank = "Event Manager" Or Launcher.Rank = "Curator" Then
                        Launcher.SendToServer("ban<{]>" & usernameSearch & "<{]>" & Launcher.Username & "<{]>" & Reason.Text)
                        SearchForUser()
                    Else
                        MsgBox("Moderators cannot permanently ban!")
                    End If
                Else
                    If time > 24 Then
                        If Launcher.Rank = "Administrator" Or Launcher.Rank = "Owner" Or Launcher.Rank = "Global Moderator" Or Launcher.Rank = "Event Manager" Or Launcher.Rank = "Curator" Then
                            Launcher.SendToServer("timedban<{]>" & usernameSearch & "<{]>" & Launcher.Username & "<{]>" & time & "<{]>" & Reason.Text)
                            SearchForUser()
                        Else
                            MsgBox("Moderators can only ban for up to 24 hours!")
                        End If
                    Else
                        Launcher.SendToServer("timedban<{]>" & usernameSearch & "<{]>" & Launcher.Username & "<{]>" & time & "<{]>" & Reason.Text)
                        SearchForUser()
                    End If
                End If
            Catch
                MsgBox("Please enter 0 or a larger number for hours, 0 for permanent ban!")
            End Try
        Else
            If Launcher.Rank = "Administrator" Or Launcher.Rank = "Owner" Or Launcher.Rank = "Global Moderator" Or Launcher.Rank = "Event Manager" Or Launcher.Rank = "Curator" Then
                Launcher.SendToServer("unban<{]>" & usernameSearch)
                SearchForUser()
            Else
                MsgBox("Moderators cannot unban!")
            End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        UpdateTicket()
    End Sub

    Public Sub UpdateTicket()
        For Each myTicket As Ticket In Launcher.staffTicketList
            If myTicket.Title = ListBox1.SelectedItem Then
                ticketTitle.Text = "Title: " & myTicket.TitleOnly
                ticketSection.Text = "Section: " & myTicket.Section
                ticketDateCreated.Text = "Date Created: " & myTicket.DateCreated
                ticketDateUpdated.Text = "Last Updated by Player: " & myTicket.DateUpdated

                RichTextBox2.Text = ""

                Dim sParts() As String = Split(myTicket.Messages, "<n>")
                For Each line As String In sParts
                    If RichTextBox2.Text <> "" And line <> "" Then
                        RichTextBox2.Text = RichTextBox2.Text & Environment.NewLine
                    End If
                    If line <> "" Then
                        RichTextBox2.Text = RichTextBox2.Text & line
                    End If
                Next

                If myTicket.LockedBy = "0" Then
                    closeBtn.Enabled = True
                    lock.Enabled = True
                ElseIf myTicket.LockedBy = Launcher.Username Then
                    closeBtn.Enabled = True
                    lock.Enabled = False
                Else
                    closeBtn.Enabled = False
                    lock.Enabled = True
                End If

                Panel63.Hide()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If RichTextBox4.Text = "" Then
            MsgBox("Message can't be empty!")
            Return
        End If

        For Each myTicket As Ticket In Launcher.staffTicketList
            If myTicket.Title = ListBox1.SelectedItem Then
                Launcher.SendToServer("StaffUpdateTicket" & Launcher.Splitter & myTicket.ID & Launcher.Splitter & myTicket.Messages & Launcher.Username & ": " & RichTextBox4.Text & "<n>")
            End If
        Next

        RichTextBox4.Clear()
    End Sub

    Private Sub lock_Click(sender As Object, e As EventArgs) Handles Lock.Click
        For Each myTicket As Ticket In Launcher.staffTicketList
            If myTicket.Title = ListBox1.SelectedItem Then
                Launcher.SendToServer("LockTicket" & Launcher.Splitter & myTicket.ID)
            End If
        Next
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        For Each myTicket As Ticket In Launcher.staffTicketList
            If myTicket.Title = ListBox1.SelectedItem Then
                ListBox1.Items.Remove(ListBox1.Items(ListBox1.SelectedIndex))
                Launcher.SendToServer("StaffCloseTicket" & Launcher.Splitter & myTicket.ID)

                Panel63.Show()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Launcher.SendToServer("RequestProfile<{]>" & Launcher.Username & "<{]>" & usernameSearch)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If staffnotes.Text.Length > 1000 Then
            MsgBox("Staff Notes must be 1000 or less characters!")
            Return
        End If
        Launcher.SendToServer("UpdateStaffNotes" & Launcher.Splitter & usernameSearch & Launcher.Splitter & staffnotes.Text)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text.Contains("-1") Then
            Button3.Text = "Unmute"
        Else
            Button3.Text = "Mute"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to add a title for " + usernameSearch + "?", "Add Title", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If Launcher.Rank = "Administrator" Or Launcher.Rank = "Owner" Or Launcher.Rank = "Global Moderator" Or Launcher.Rank = "Event Manager" Or Launcher.Rank = "Curator" Then
            Try
                If TextBox10.Text > 5 And TextBox10.Text < 11 Then
                    Launcher.SendToServer("addtitle<{]>" & usernameSearch & "<{]>" & TextBox10.Text & "<{]>" & Reason.Text)
                Else
                    If TextBox10.Text >= 0 And TextBox10.Text < 17 And TextBox10.Text <> 15 Then
                        If Launcher.Rank = "Owner" Or Launcher.Rank = "Administrator" Then
                            Launcher.SendToServer("addtitle<{]>" & usernameSearch & "<{]>" & TextBox10.Text & "<{]>" & Reason.Text)
                        Else
                            MsgBox("Only the Owner and Administrators can add this title!")
                        End If
                    ElseIf TextBox10.Text = 17 Or TextBox10.Text = 18 Or TextBox10.Text = 19 Then
                        If Launcher.Rank = "Owner" Then
                            Launcher.SendToServer("addtitle<{]>" & usernameSearch & "<{]>" & TextBox10.Text & "<{]>" & Reason.Text)
                        Else
                            MsgBox("Only the Owner can add this title!")
                        End If
                    Else
                        MsgBox("Title IDs must be between 0 and 19")
                    End If
                End If
            Catch
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RichTextBox1.Clear()
        Launcher.SendToServer("ShowRankedHistory" + Launcher.Splitter + usernameSearch + Launcher.Splitter + TextBox11.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to change the gold amount for " + usernameSearch + "?", "Change Gold Amount", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        Launcher.SendToServer("setgold<{]>" & usernameSearch & "<{]>" & TextBox3.Text & "<{]>" & Reason.Text)
        SearchForUser()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to change the diamonds amount for " + usernameSearch + "?", "Change Diamond Amount", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        Launcher.SendToServer("setdiamonds<{]>" & usernameSearch & "<{]>" & TextBox4.Text & "<{]>" & Reason.Text)
        SearchForUser()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to change the qualification status for " + usernameSearch + "?", "Change Qualification Status", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        Launcher.SendToServer("setqualification<{]>" & usernameSearch & "<{]>" & TextBox2.Text)
        SearchForUser()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MsgBox("This feature is currently disabled!")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to add an achievement for " + usernameSearch + "?", "Add Achievement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If Launcher.Rank = "Administrator" Or Launcher.Rank = "Owner" Or Launcher.Rank = "Global Moderator" Or Launcher.Rank = "Event Manager" Or Launcher.Rank = "Curator" Then
            Try
                If TextBox8.Text > 6 And TextBox8.Text < 14 Then
                    Launcher.AddAchievement(usernameSearch, TextBox8.Text, Reason.Text)
                Else
                    If TextBox8.Text >= 0 And TextBox8.Text < 21 Then
                        If Launcher.Rank = "Owner" Then
                            Launcher.AddAchievement(usernameSearch, TextBox8.Text, Reason.Text)
                        Else
                            MsgBox("Only the Owner can add this achievement!")
                        End If
                    Else
                        MsgBox("Achievement IDs must be between 0 and 20")
                    End If
                End If
            Catch
            End Try
        End If
    End Sub

    Public Sub SearchForUser()
        RichTextBox1.Clear()

        Dim RequestType As String = "Username"
        Dim RequestInfo As String = TextBox1.Text

        If RadioButton2.Checked = True Then
            RequestType = "Username"
            usernameSearch = TextBox1.Text
            Panel48.Hide()
            Panel48.Location = New Point(1, 57)
            Panel48.SendToBack()
        ElseIf RadioButton1.Checked = True Then
            RequestType = "IP"
            RichTextBox3.Clear()
            Panel48.Hide()
            Panel48.Location = New Point(1, 57)
            Panel48.SendToBack()
        ElseIf RadioButton3.Checked = True Then
            RequestType = "MAC"
            Try
                RequestInfo = TextBox1.Text
                RichTextBox3.Clear()
                Panel48.Hide()
                Panel48.Location = New Point(1, 57)
                Panel48.SendToBack()
            Catch
                MsgBox("Please enter the full MAC address!")
                Return
            End Try
        Else
            RequestType = "UniqueID"
            Try
                RequestInfo = TextBox1.Text
                RichTextBox3.Clear()
                Panel48.Hide()
                Panel48.Location = New Point(1, 57)
                Panel48.SendToBack()
            Catch
                MsgBox("Please enter the full Unique ID!")
                Return
            End Try
        End If

        Launcher.SendToServer("RequestUserInfo" + Launcher.Splitter + RequestType + Launcher.Splitter + RequestInfo)
    End Sub

    Private Sub disableTickets_Click(sender As Object, e As EventArgs) Handles disableTickets.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to " + disableTickets.Text.ToLower + " for " + usernameSearch + "?", disableTickets.Text + " User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If disableTickets.Text = "Disable Tickets" Then
            Launcher.SendToServer("disabletickets<{]>" & usernameSearch & Launcher.Splitter & Reason.Text)
        Else
            Launcher.SendToServer("enabletickets<{]>" & usernameSearch & Launcher.Splitter & Reason.Text)
        End If

        SearchForUser()
    End Sub

    Private Sub createNews_Click(sender As Object, e As EventArgs) Handles createNews.Click
        If newsPost.Text.Contains(Launcher.Splitter) = False Then
            Launcher.SendToServer("AddNews" & Launcher.Splitter & newsTitle.Text & Launcher.Splitter & newsPost.Text & Launcher.Splitter & newsImage.Text & Launcher.Splitter & newsReadMoreLink.Text)

            newsTitle.Text = ""
            newsPost.Text = ""
            newsImage.SelectedIndex = 0
            newsReadMoreLink.Text = ""
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Launcher.SendToServer("SetFeaturedPlayer" & Launcher.Splitter & newFeaturedPlayer.Text & Launcher.Splitter & featuredPlayerDescription.Text)
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Launcher.SendToServer("SetChatMessages" & Launcher.Splitter & chatMessage1.Text & Launcher.Splitter & chatMessage2.Text)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Launcher.SendToServer("EnableCustomTextColor<{]>" & usernameSearch)
        SearchForUser()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Launcher.SendToServer("EnableCustomPrivateChat<{]>" & usernameSearch)
        SearchForUser()
    End Sub

    Private Sub setRankBtn_Click(sender As Object, e As EventArgs) Handles setRankBtn.Click
        If Launcher.Rank = "Administrator" Or Launcher.Rank = "Owner" Or Launcher.Rank = "Curator" Then
            Dim check As DialogResult = MessageBox.Show("Are you sure you want to change rank?", "Change Rank", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If check = DialogResult.No Then
                Return
            End If

            If Reason.Text = "" Then
                Reason.Text = "None"
            End If

            If rankTextBox.Text = "Moderator" Or rankTextBox.Text = "Global Moderator" Or rankTextBox.Text = "Event Manager" Or rankTextBox.Text = "Gold Member" Or rankTextBox.Text = "Platinum Member" Or rankTextBox.Text = "Diamond Member" Or rankTextBox.Text = "Player" Or rankTextBox.Text = "Administrator" Or rankTextBox.Text = "Curator" Then
                Launcher.SendToServer("setrank<{]>" & usernameSearch & "<{]>" & rankTextBox.Text & "<{]>" & Launcher.Username & "<{]>" & Reason.Text)
            ElseIf rankTextBox.Text = "Administrator" And Launcher.Rank = "Owner" Then
                Launcher.SendToServer("setrank<{]>" & usernameSearch & "<{]>" & rankTextBox.Text & "<{]>" & Launcher.Username & "<{]>" & Reason.Text)
            Else
                MsgBox("Invalid Rank! Ranks: Moderator, Global Moderator, Event Manager, Gold Member, Platinum Member, Diamond Member, Player!")
            End If
        End If
        SearchForUser()
    End Sub

    Private Sub banIPBtn_Click(sender As Object, e As EventArgs) Handles banIPBtn.Click
        Dim question As String = "Are you sure you want to ban IP?"
        If banIPBtn.Text.ToLower.Contains("unban") Then
            question = "Are you sure you want to unban IP?"
        End If
        Dim check As DialogResult = MessageBox.Show(question, "Change IP Ban", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        If Reason.Text = "" Then
            Reason.Text = "None"
        End If

        If banIPBtn.Text.ToLower.Contains("unban") Then
            Launcher.SendToServer("unbanip<{]>" & usernameSearch & Launcher.Splitter & IP.Text & Launcher.Splitter & Reason.Text)
        Else
            Launcher.SendToServer("banip<{]>" & usernameSearch & Launcher.Splitter & IP.Text & Launcher.Splitter & Reason.Text)
        End If
    End Sub

    Private Sub banComputerBtn_Click(sender As Object, e As EventArgs) Handles banComputerBtn.Click
        Dim question As String = "Are you sure you want To ban computer?"
        If banComputerBtn.Text.ToLower.Contains("unban") Then
            question = "Are you sure you want to unban computer?"
        End If
        Dim check As DialogResult = MessageBox.Show(question, "Change Computer Ban", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

        If check = DialogResult.No Then
            Return
        End If

        If Reason.Text = "" Then
            Reason.Text = "None"
        End If

        If banComputerBtn.Text.ToLower.Contains("unban") Then
            Launcher.SendToServer("unbancomputer<{]>" & usernameSearch & Launcher.Splitter & MAC.Text & Launcher.Splitter & UniqueID.Text & Launcher.Splitter & Reason.Text)
        Else
            Launcher.SendToServer("bancomputer<{]>" & usernameSearch & Launcher.Splitter & MAC.Text & Launcher.Splitter & UniqueID.Text & Launcher.Splitter & Reason.Text)
        End If
    End Sub

    Private Sub reveseBanIPBtn_Click(sender As Object, e As EventArgs) Handles reveseBanIPBtn.Click
        If banIPBtn.Text.ToLower.Contains("unban") Then
            banIPBtn.Text = "     Ban IP"
        Else
            banIPBtn.Text = "      Unban IP"
        End If
    End Sub

    Private Sub reverseBanComputerBtn_Click(sender As Object, e As EventArgs) Handles reverseBanComputerBtn.Click
        If banComputerBtn.Text.ToLower.Contains("unban") Then
            banComputerBtn.Text = "      Ban PC"
        Else
            banComputerBtn.Text = "      Unban PC"
        End If
    End Sub

    Private Sub showActionsBtn_Click(sender As Object, e As EventArgs) Handles showActionsBtn.Click
        Launcher.SendToServer("ShowAdminLogs<{]>" & Convert.ToInt32(lastActionsTxt.Text).ToString & Launcher.Splitter & actionTxt.Text & Launcher.Splitter & userTxt.Text & Launcher.Splitter & targetTxt.Text)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 3 Then
            Launcher.SendToServer("ShowAdminLogs<{]>" & Convert.ToInt32(lastActionsTxt.Text).ToString & Launcher.Splitter & actionTxt.Text & Launcher.Splitter & userTxt.Text & Launcher.Splitter & targetTxt.Text)
        ElseIf TabControl1.SelectedIndex = 4 Then
            Launcher.SendToServer("ShowStaffList")
        ElseIf TabControl1.SelectedIndex = 5 Then
            Launcher.SendToServer("ShowFlaggedRankedGames<{]>" & flaggedGamesUser.Text & Launcher.Splitter & Convert.ToInt32(lastFlaggedGames.Text).ToString)
        ElseIf TabControl1.SelectedIndex = 6 Then
            Launcher.SendToServer("ShowPendingDeckList")
        End If
    End Sub

    Private Sub StaffListView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles StaffListView.MouseDoubleClick
        Try
            TextBox1.Text = StaffListView.SelectedItems(0).Text
            RadioButton2.Checked = True
            SearchForUser()
            TabControl1.SelectTab(0)
        Catch
        End Try
    End Sub

    Private Sub showFlaggedGames_Click(sender As Object, e As EventArgs) Handles showFlaggedGames.Click
        Launcher.SendToServer("ShowFlaggedRankedGames<{]>" & flaggedGamesUser.Text & Launcher.Splitter & Convert.ToInt32(lastFlaggedGames.Text).ToString)
    End Sub

    Private Sub disbandTeamBtn_Click(sender As Object, e As EventArgs) Handles disbandTeamBtn.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to disband this team?", "Disband Team", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

        If check = DialogResult.No Then
            Return
        End If

        Launcher.SendToServer("StaffTeamDisband<{]>" & usernameSearch & Launcher.Splitter & Reason.Text)
    End Sub

    Private Sub resetPasswordBtn_Click(sender As Object, e As EventArgs) Handles resetPasswordBtn.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure you want to change the password?", "Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If check = DialogResult.No Then
            Return
        End If

        Launcher.SendToServer("resetpassword<{]>" & usernameSearch & Launcher.Splitter & Launcher.Encrypt(newPasswordTxt.Text) & Launcher.Splitter & Reason.Text)
    End Sub

    Private Sub PendingDecksListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PendingDecksListView.DoubleClick
        Try
            Dim selectedPendingDeck As ListViewItem = PendingDecksListView.SelectedItems(0)
            Launcher.SendToServer("ShowPendingDeck" & Launcher.Splitter & selectedPendingDeck.SubItems(0).Text)
        Catch
        End Try
    End Sub
End Class