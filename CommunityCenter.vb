Imports System.IO
Imports System.Net

Public Class CommunityCenter

    Public DeckProfileList As New List(Of DeckProfileUC)
    Public newUploadDeckControl As UploadDeck

    Public lastLocation As String

    Public page As Integer
    Dim pageCount As Integer

    Dim loaded As Boolean = False

    Public newSortingOptions As DeckSorting
    Public deckSortBy As String = "Newest"
    Public deckSortType As String = "All"
    Public deckSortBanlist As String = "All"
    Public deckSortSharedWith As String = "Everyone"

    Dim topicList() As String
    Dim topicIdList(10) As Integer

    Dim infoList() As String

    Public newsPage As Integer = 1

    Public imageLink As String = ""

    Public rankedPage As Integer = 1

    Public Sub LoadFeaturedImage(ByVal link As String)
        imageLink = link

        Dim setImageThread As New Threading.Thread(AddressOf setImage)
        setImageThread.Start()
    End Sub

    Private Delegate Sub setImageDelegate()
    Private Sub setImage()
        Try
            Dim downloadedImage As Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(imageLink)))
            If featuredImage.InvokeRequired Then
                featuredImage.Invoke(New setImageDelegate(AddressOf setImage))
            Else
                featuredImage.Image = downloadedImage
            End If
        Catch
        End Try
    End Sub

    Public Sub DownloadInformationFunction()
        Dim DownloadForumTopics As New Threading.Thread(AddressOf SetDownloadedForumTopics)
        DownloadForumTopics.Start()
        Dim DownloadBestPlayers As New Threading.Thread(AddressOf SetDownloadedBestPlayers)
        DownloadBestPlayers.Start()
    End Sub

    Private Delegate Sub SetDownloadedForumTopicsDelegate()
    Private Sub SetDownloadedForumTopics()
        Try
            If topicList Is Nothing Then
                Dim client As New WebClient()
                Dim downloadedTopics As String = client.DownloadString(New Uri("http://ygopro.club/topics.php"))
                downloadedTopics = downloadedTopics.Replace("#39;", "'")

                topicList = Split(downloadedTopics, "<>{]<>")
            End If

            If hidePanel.InvokeRequired Then
                hidePanel.Invoke(New SetDownloadedForumTopicsDelegate(AddressOf SetDownloadedForumTopics))
            Else
                hidePanel.Hide()
            End If

            Dim topicInfo() As String = Split(topicList(0), "<{]>")
            topic1.Text = topicInfo(0)
            lastPoster1.Text = topicInfo(1)

            Dim dtDateTime1 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime1 = dtDateTime1.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate1.Text = Format(dtDateTime1, "yyyy/M/dd HH:mm:ss")
            topicIdList(0) = topicInfo(3)

            topicInfo = Split(topicList(1), "<{]>")
            topic2.Text = topicInfo(0)
            lastPoster2.Text = topicInfo(1)

            Dim dtDateTime2 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime2 = dtDateTime2.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate2.Text = Format(dtDateTime2, "yyyy/M/dd HH:mm:ss")
            topicIdList(1) = topicInfo(3)

            topicInfo = Split(topicList(2), "<{]>")
            topic3.Text = topicInfo(0)
            lastPoster3.Text = topicInfo(1)

            Dim dtDateTime3 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime3 = dtDateTime3.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate3.Text = Format(dtDateTime3, "yyyy/M/dd HH:mm:ss")
            topicIdList(2) = topicInfo(3)

            topicInfo = Split(topicList(3), "<{]>")
            topic4.Text = topicInfo(0)
            lastPoster4.Text = topicInfo(1)

            Dim dtDateTime4 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime4 = dtDateTime4.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate4.Text = Format(dtDateTime4, "yyyy/M/dd HH:mm:ss")
            topicIdList(3) = topicInfo(3)

            topicInfo = Split(topicList(4), "<{]>")
            topic5.Text = topicInfo(0)
            lastPoster5.Text = topicInfo(1)

            Dim dtDateTime5 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime5 = dtDateTime5.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate5.Text = Format(dtDateTime5, "yyyy/M/dd HH:mm:ss")
            topicIdList(4) = topicInfo(3)

            topicInfo = Split(topicList(5), "<{]>")
            topic6.Text = topicInfo(0)
            lastPoster6.Text = topicInfo(1)

            Dim dtDateTime6 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime6 = dtDateTime6.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate6.Text = Format(dtDateTime6, "yyyy/M/dd HH:mm:ss")
            topicIdList(5) = topicInfo(3)

            topicInfo = Split(topicList(6), "<{]>")
            topic7.Text = topicInfo(0)
            lastPoster7.Text = topicInfo(1)

            Dim dtDateTime7 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime7 = dtDateTime7.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate7.Text = Format(dtDateTime7, "yyyy/M/dd HH:mm:ss")
            topicIdList(6) = topicInfo(3)

            topicInfo = Split(topicList(7), "<{]>")
            topic8.Text = topicInfo(0)
            lastPoster8.Text = topicInfo(1)

            Dim dtDateTime8 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime8 = dtDateTime8.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate8.Text = Format(dtDateTime8, "yyyy/M/dd HH:mm:ss")
            topicIdList(7) = topicInfo(3)

            topicInfo = Split(topicList(8), "<{]>")
            topic9.Text = topicInfo(0)
            lastPoster9.Text = topicInfo(1)

            Dim dtDateTime9 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime9 = dtDateTime9.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate9.Text = Format(dtDateTime9, "yyyy/M/dd HH:mm:ss")
            topicIdList(8) = topicInfo(3)

            topicInfo = Split(topicList(9), "<{]>")
            topic10.Text = topicInfo(0)
            lastPoster10.Text = topicInfo(1)

            Dim dtDateTime10 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            dtDateTime10 = dtDateTime10.AddSeconds(topicInfo(2)).ToLocalTime()
            postDate10.Text = Format(dtDateTime10, "yyyy/M/dd HH:mm:ss")
            topicIdList(9) = topicInfo(3)
        Catch
        End Try
    End Sub

    Private Delegate Sub SetDownloadedBestPlayersDelegate()
    Private Sub SetDownloadedBestPlayers()
        Try
            If infoList Is Nothing Then
                Dim client As New WebClient()
                Dim downloadedInformation As String = client.DownloadString(New Uri("http://ygopro.org/newsinfo.php"))

                infoList = Split(downloadedInformation, "<{(]}>")
            End If

            If kingOfGames.InvokeRequired Then
                kingOfGames.Invoke(New SetDownloadedBestPlayersDelegate(AddressOf SetDownloadedBestPlayers))
            Else
                kingOfGames.Text = "King of Games: " & infoList(0)
            End If

            topSingle.Text = "Top Single: " & infoList(1)
            ratingSingle.Text = "Rating: " & infoList(2)
            topMatch.Text = "Top Match: " & infoList(3)
            ratingMatch.Text = "Rating: " & infoList(4)
            topTag.Text = "Top Tag: " & infoList(5)
            ratingTag.Text = "Rating: " & infoList(6)
            topGoldUser.Text = infoList(7)
            goldLabel.Text = infoList(8)
            topDiamondUser.Text = infoList(9)
            diamondLabel.Text = infoList(10)

            hidePanel2.Hide()
        Catch
        End Try
    End Sub

#Region "Tickets"

    Private Sub Tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        helpSection.SelectedIndex = 0
        helpQuestion.SelectedIndex = 0
        gameType.SelectedIndex = 0
        season.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ticketTitleTxt.Text = "" Then
            MsgBox("Title can't be empty!")
            Return
        End If
        If ticketMessageTxt.Text = "" Then
            MsgBox("Ticket can't be empty!")
            Return
        End If
        If ticketMessageTxt.Text.Contains("<n>") = True Then
            MsgBox("Message is now allowed to contain <n>")
            Return
        End If

        Dim openTickets As Integer = 0

        For Each myTicket As Ticket In Launcher.ticketList
            If myTicket.Closed = 0 Then
                openTickets += 1
            End If
        Next

        If openTickets <= 3 Then
            Launcher.SendToServer("CreateTicket<{]>" & ticketTitleTxt.Text & Launcher.Splitter & ComboBox1.Text & Launcher.Splitter & ticketMessageTxt.Text)
            MsgBox("Your ticket has been created, you will receive a notification once a staff member responds!")
            ticketTitleTxt.Text = ""
            ticketMessageTxt.Text = ""
            Try
                ComboBox1.SelectedIndex = 0
            Catch
            End Try
            Try
                ListBox1.SelectedIndex = 0
            Catch
            End Try
            Panel1.Hide()
            Try
                TabControl1.SelectedIndex = 0
            Catch
            End Try
        Else
            MsgBox("You are only allowed to have 3 open tickets!")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        UpdateTicket()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each myTicket As Ticket In Launcher.ticketList
            If myTicket.Title = ListBox1.SelectedItem Then
                Launcher.SendToServer("CloseTicket" & Launcher.Splitter & myTicket.ID)
                ListBox1.Items(ListBox1.SelectedIndex) = "(CLOSED) " & ListBox1.Items(ListBox1.SelectedIndex)
                Button2.Enabled = False
                Button3.Enabled = False
                RichTextBox3.Enabled = False

                myTicket.Closed = 1

                Exit For
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RichTextBox3.Text = "" Then
            MsgBox("Message can't be empty!")
            Return
        End If

        For Each myTicket As Ticket In Launcher.ticketList
            If myTicket.Title = ListBox1.SelectedItem Then
                Launcher.SendToServer("UpdateTicket" & Launcher.Splitter & myTicket.ID & Launcher.Splitter & myTicket.Messages & Launcher.Username & ": " & RichTextBox3.Text & "<n>")
            End If
        Next

        RichTextBox3.Clear()
    End Sub

    Public Sub UpdateTicket()
        For Each myTicket As Ticket In Launcher.ticketList
            If myTicket.Title = ListBox1.SelectedItem Then
                title.Text = "Title: " & myTicket.TitleOnly
                section.Text = "Section: " & myTicket.Section

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

                If myTicket.Closed = 1 Then
                    RichTextBox3.Enabled = False
                    Button2.Enabled = False
                    Button3.Enabled = False
                Else
                    RichTextBox3.Enabled = True
                    Button2.Enabled = True
                    Button3.Enabled = True
                End If

                Panel1.Hide()
                Exit For
            End If
        Next
    End Sub

#End Region

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try


        deckSortBy = "Newest"
        deckSortType = "All"
        deckSortBanlist = "All"

        page = 1
        NewSearch()
    End Sub

    Public Sub AddDeck(id As Integer, deckName As String, featuredImage As String, positiveRating As Integer, negativeRating As Integer, deckType As String, sharedWith As String, datePosted As String, banlist As String, uploadedBy As String, description As String, downloads As String)
        Dim newUserControl As New DeckProfileUC

        newUserControl.id = id
        newUserControl.deckName = deckName
        newUserControl.positiveRating = positiveRating
        newUserControl.negativeRating = negativeRating

        If deckType = 0 Then
            deckType = "Meta"
        ElseIf deckType = 1 Then
            deckType = "Non-Meta"
        Else
            deckType = "Anime"
        End If

        newUserControl.deckType = deckType

        If sharedWith = 0 Then
            sharedWith = "Everyone"
        ElseIf sharedWith = 1 Then
            sharedWith = "Team"
        ElseIf sharedWith = 2 Then
            sharedWith = "Friends"
        Else
            sharedWith = Launcher.Username
        End If

        newUserControl.sharedWith = sharedWith
        newUserControl.datePosted = datePosted
        newUserControl.downloads = downloads
        newUserControl.banlist = banlist
        newUserControl.uploadedBy = uploadedBy
        newUserControl.description = description

        newUserControl.deckNameTxt.Text = deckName

        If (positiveRating + negativeRating) = 0 Then
            newUserControl.RatingTxt.Text = "Rating: Not Rated"
        Else
            Dim rating As Integer = (positiveRating / (positiveRating + negativeRating)) * 100
            newUserControl.RatingTxt.Text = "Rating: " & rating & "%"
        End If

        Try
            Dim featuredImg() As String = Split(featuredImage, ":")

            If Launcher.launcherEdition = 2 Then
                If featuredImg(0) = 0 Then
                    If File.Exists(Launcher.Current & "\YGOPRO\picture\card\" & featuredImg(1) & ".png") Then
                        newUserControl.featuredImage = Image.FromFile(Launcher.Current & "\YGOPRO\picture\card\" & featuredImg(1) & ".png")
                    ElseIf File.Exists(Launcher.Current & "\YGOPRO\picture\card\" & featuredImg(1) & ".jpg") Then
                        newUserControl.featuredImage = Image.FromFile(Launcher.Current & "\YGOPRO\picture\card\" & featuredImg(1) & ".jpg")
                    End If
                ElseIf featuredImg(0) = 1 Then
                    If File.Exists(Launcher.Current & "\YGOPRO\picture\field\" & featuredImg(1).Replace(".jpg", ".png")) Then
                        newUserControl.featuredImage = Image.FromFile(Launcher.Current & "\YGOPRO\picture\field\" & featuredImg(1).Replace(".jpg", ".png"))
                    End If
                ElseIf featuredImg(0) = 2 Then
                    If File.Exists(Launcher.Current & "\YGOPRO\texture\TDOANE\" & featuredImg(1)) Then
                        newUserControl.featuredImage = Image.FromFile(Launcher.Current & "\YGOPRO\texture\TDOANE\" & featuredImg(1))
                    End If
                End If
            Else
                If featuredImg(0) = 0 Then
                    If File.Exists(Launcher.Current & "\YGOPRO\pics\" & featuredImg(1) & ".jpg") Then
                        newUserControl.featuredImage = Image.FromFile(Launcher.Current & "\YGOPRO\pics\" & featuredImg(1) & ".jpg")
                    End If
                ElseIf featuredImg(0) = 1 Then
                    If File.Exists(Launcher.Current & "\YGOPRO\pics\field\" & featuredImg(1)) Then
                        newUserControl.featuredImage = Image.FromFile(Launcher.Current & "\YGOPRO\pics\field\" & featuredImg(1))
                    End If
                ElseIf featuredImg(0) = 2 Then
                    If File.Exists(Launcher.Current & "\YGOPRO\textures\" & featuredImg(1)) Then
                        newUserControl.featuredImage = Image.FromFile(Launcher.Current & "\YGOPRO\textures\" & featuredImg(1))
                    End If
                End If
            End If

            newUserControl.featuredImagePictureBox.Image = newUserControl.featuredImage
        Catch
        End Try

        Dim newLocation() As String = Split(newUserControl.CalculateNextLocation(lastLocation), ", ")
        lastLocation = newLocation(0) & ", " & newLocation(1)
        newUserControl.Location = New Point(newLocation(0), newLocation(1))
        TabPage4.Controls.Add(newUserControl)
        DeckProfileList.Add(newUserControl)
    End Sub

    Private Sub TabPage4_MouseMove(sender As Object, e As MouseEventArgs) Handles TabPage4.MouseMove
        For Each DeckProfile In DeckProfileList
            DeckProfile.RevertColor()
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        newUploadDeckControl = New UploadDeck
        newUploadDeckControl.Location = New Point(0, 41)
        TabPage4.Controls.Add(newUploadDeckControl)
        newUploadDeckControl.BringToFront()
    End Sub

    Private Sub LikeBtn_Click(sender As Object, e As EventArgs) Handles LikeBtn.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        LikeBtn.Visible = False
        DislikeBtn.Visible = False

        Launcher.SendToServer("RateDeck" & Launcher.Splitter & deckId.Text & Launcher.Splitter & "Like")

        For Each deck As DeckProfileUC In DeckProfileList
            If deck.id = deckId.Text Then
                deck.ratedByMe = True
                deck.positiveRating = deck.positiveRating + 1
                deck.UpdateRating()
            End If
        Next
    End Sub

    Private Sub DislikeBtn_Click(sender As Object, e As EventArgs) Handles DislikeBtn.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        LikeBtn.Visible = False
        DislikeBtn.Visible = False

        Launcher.SendToServer("RateDeck" & Launcher.Splitter & deckId.Text & Launcher.Splitter & "Dislike")

        For Each deck As DeckProfileUC In DeckProfileList
            If deck.id = deckId.Text Then
                deck.ratedByMe = True
                deck.negativeRating = deck.negativeRating + 1
                deck.UpdateRating()
            End If
        Next
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        HideDeckInfo.Show()
        Launcher.SendToServer("RemoveDeck" & Launcher.Splitter & deckId.Text)
        NewSearch()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        Launcher.SendToServer("DownloadDeck" & Launcher.Splitter & deckId.Text)
    End Sub

    Public Sub CreatePages(ByVal deckNumber As Integer, ByVal pages As Integer)
        pageCount = pages

        If page <> 1 And pages <> 1 Then
            LeftBtn.Enabled = True
        Else
            LeftBtn.Enabled = False
        End If
        If page <> pages Then
            RightBtn.Enabled = True
        Else
            RightBtn.Enabled = False
        End If

        If deckNumber <> 0 Then
            pageDisplay.Visible = True
            LeftBtn.Visible = True
            RightBtn.Visible = True
        Else
            pageDisplay.Visible = False
            LeftBtn.Visible = False
            RightBtn.Visible = False
        End If

        pageDisplay.Text = "Page: " & page & "/" & pages

        RightBtn.Location = New Point(pageDisplay.Location.X + pageDisplay.Size.Width + 3, RightBtn.Location.Y)
    End Sub

    Private Sub LeftBtn_Click(sender As Object, e As EventArgs) Handles LeftBtn.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        page -= 1
        NewSearch()
    End Sub

    Private Sub RightBtn_Click(sender As Object, e As EventArgs) Handles RightBtn.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        page += 1
        NewSearch()
    End Sub

    Public Sub NewSearch()
        If page < 1 Then
            page = 1
        End If

        NotFound.Visible = False
        lastLocation = ""
        For Each deckProfile As DeckProfileUC In DeckProfileList
            deckProfile.Dispose()
        Next
        DeckProfileList.Clear()

        Dim sortType As Integer = -1
        If deckSortType = "Meta" Then
            sortType = 0
        ElseIf deckSortType = "Non-Meta" Then
            sortType = 1
        ElseIf deckSortType = "Anime" Then
            sortType = 2
        End If

        Dim banlistType As String = -1
        If deckSortBanlist <> "All" Then
            banlistType = deckSortBanlist
        End If

        Launcher.SendToServer("LoadDeckList" & Launcher.Splitter & searchBox.Text & Launcher.Splitter & (page * 15) - 15 & "," & page * 15 & Launcher.Splitter & deckSortBy & Launcher.Splitter & sortType & Launcher.Splitter & banlistType & Launcher.Splitter & deckSortSharedWith)
    End Sub

    Private Sub TabControl_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl2.Selected
        If loaded = True Then
            Return
        End If

        If TabControl2.SelectedTab.Name = "TabPage4" Then
            NewSearch()
            loaded = True
        ElseIf TabControl2.SelectedTab.Name = "RankList" Then
            Launcher.SendToServer("GetRankingList" & Launcher.Splitter & gameType.Text & Launcher.Splitter & season.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try

        newSortingOptions = New DeckSorting
        newSortingOptions.Location = New Point(280, 30)

        TabPage4.Controls.Add(newSortingOptions)

        newSortingOptions.BringToFront()
    End Sub

    Private Sub openWhenDownloaded_CheckedChanged(sender As Object, e As EventArgs) Handles openWhenDownloaded.CheckedChanged
        Try
            newSortingOptions.Dispose()
        Catch
        End Try
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        Try
            newSortingOptions.Dispose()
        Catch
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Try
            newSortingOptions.Dispose()
        Catch
        End Try
    End Sub

    Private Sub helpSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles helpSection.SelectedIndexChanged
        JarvisHelp.ChangeSection(helpSection.SelectedItem)
    End Sub

    Private Sub helpQuestion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles helpQuestion.SelectedIndexChanged
        JarvisHelp.ChangeQuestion(helpQuestion.SelectedItem)
    End Sub

    Private Sub Panel20_Click(sender As Object, e As EventArgs) Handles Panel20.Click, topic1.Click, lastPoster1.Click, postDate1.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(0) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel20_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel20.MouseMove
        Panel20.BackColor = Color.DimGray

        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel13_Click(sender As Object, e As EventArgs) Handles Panel13.Click, topic2.Click, lastPoster2.Click, postDate2.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(1) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel13_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel13.MouseMove
        Panel13.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel17_Click(sender As Object, e As EventArgs) Handles Panel17.Click, topic3.Click, lastPoster3.Click, postDate3.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(2) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel17_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel17.MouseMove
        Panel17.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel23_Click(sender As Object, e As EventArgs) Handles Panel23.Click, topic4.Click, lastPoster4.Click, postDate4.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(3) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel23_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel23.MouseMove
        Panel23.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel25_Click(sender As Object, e As EventArgs) Handles Panel25.Click, topic5.Click, lastPoster5.Click, postDate5.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(4) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel25_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel25.MouseMove
        Panel25.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel27_Click(sender As Object, e As EventArgs) Handles Panel27.Click, topic6.Click, lastPoster6.Click, postDate6.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(5) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel27_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel27.MouseMove
        Panel27.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel29_Click(sender As Object, e As EventArgs) Handles Panel29.Click, topic7.Click, lastPoster7.Click, postDate7.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(6) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel29_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel29.MouseMove
        Panel29.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel42_Click(sender As Object, e As EventArgs) Handles Panel42.Click, topic8.Click, lastPoster8.Click, postDate8.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(7) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel42_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel42.MouseMove
        Panel42.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel44_Click(sender As Object, e As EventArgs) Handles Panel44.Click, topic9.Click, lastPoster9.Click, postDate9.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(8) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel44_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel44.MouseMove
        Panel44.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Private Sub Panel46_Click(sender As Object, e As EventArgs) Handles Panel46.Click, topic10.Click, lastPoster10.Click, postDate10.Click
        Try
            Process.Start("http://ygopro.club/index.php?/topic/" & topicIdList(9) & "-TDOANE")
        Catch
        End Try
    End Sub

    Private Sub Panel46_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel46.MouseMove
        Panel46.BackColor = Color.DimGray

        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
    End Sub

    Private Sub TabPage3_MouseMove(sender As Object, e As MouseEventArgs) Handles TabPage3.MouseMove, Panel48.MouseMove, Label7.MouseMove, Label8.MouseMove, Label10.MouseMove
        Panel20.BackColor = Color.Black
        Panel13.BackColor = Color.Black
        Panel17.BackColor = Color.Black
        Panel23.BackColor = Color.Black
        Panel25.BackColor = Color.Black
        Panel27.BackColor = Color.Black
        Panel29.BackColor = Color.Black
        Panel42.BackColor = Color.Black
        Panel44.BackColor = Color.Black
        Panel46.BackColor = Color.Black
    End Sub

    Public Sub NewsPageButtonLocation()
        NewsPageCount.Location = New Point(597 - NewsPageCount.Size.Width, 237)
        newsButtonLeft.Location = New Point(NewsPageCount.Location.X - 39, 234)
    End Sub

    Private Sub newsButtonRight_Click(sender As Object, e As EventArgs) Handles newsButtonRight.Click
        NewsControl1.Hide()
        NewsControl2.Hide()

        Launcher.SendToServer("LoadNews" & Launcher.Splitter & newsPage * 2 & ",2")
        newsPage += 1
    End Sub

    Private Sub newsButtonLeft_Click(sender As Object, e As EventArgs) Handles newsButtonLeft.Click
        NewsControl1.Hide()
        NewsControl2.Hide()

        Launcher.SendToServer("LoadNews" & Launcher.Splitter & (newsPage * 2) - 4 & ",2")
        newsPage -= 1
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        If TabControl2.SelectedIndex = 0 Then
            PictureBox3.Size = New Size(3, 3)
        Else
            PictureBox3.Size = New Size(3, 19)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Launcher.SendToServer("GetRankingList" & Launcher.Splitter & gameType.Text & Launcher.Splitter & season.Text)
    End Sub
End Class