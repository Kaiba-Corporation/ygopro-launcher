Public Class Profile
    Public unrankedWins As Integer
    Public rankedWins As Integer
    Public allWins As Integer
    Public achievements As String
    Dim achievementcount As Integer = 0
    Public Award1 As String
    Public auw As Integer
    Public buw As Integer
    Public cuw As Integer
    Public MyQualification As Integer
    Public MyA1 As Integer
    Public JD1 As Integer
    Public ForumBooster As Integer
    Public ForumTurboCharger As Integer
    Public HeartOfFire As Integer
    Public LunarLantern As Integer
    Public MeItem As Integer

    Public imageLink As String = ""

    Public RankedSeasons As List(Of RankedSeason) = New List(Of RankedSeason)

    Public Class RankedSeason
        Public season As Integer
        Public singleRating As Integer
        Public singleWin As Integer
        Public singleDraw As Integer
        Public singleLose As Integer
        Public matchRating As Integer
        Public matchWin As Integer
        Public matchDraw As Integer
        Public matchLose As Integer
        Public tagRating As Integer
        Public tagWin As Integer
        Public tagDraw As Integer
        Public tagLose As Integer

        Public Sub New(newSeason As Integer, sRating As Integer, sWin As Integer, sDraw As Integer, sLose As Integer, mRating As Integer, mWin As Integer, mDraw As Integer, mLose As Integer, tRating As Integer, tWin As Integer, tDraw As Integer, tLose As Integer)
            season = newSeason
            singleRating = sRating
            singleWin = sWin
            singleDraw = sDraw
            singleLose = sLose
            matchRating = mRating
            matchWin = mWin
            matchDraw = mDraw
            matchLose = mLose
            tagRating = tRating
            tagWin = tWin
            tagDraw = tDraw
            tagLose = tLose
        End Sub
    End Class

    Public Sub AddRankedSeason(newSeason As Integer, sRating As Integer, sWin As Integer, sDraw As Integer, sLose As Integer, tRating As Integer, tWin As Integer, tDraw As Integer, tLose As Integer, mRating As Integer, mWin As Integer, mDraw As Integer, mLose As Integer)
        Dim newRankedSeason As New RankedSeason(newSeason, sRating, sWin, sDraw, sLose, mRating, mWin, mDraw, mLose, tRating, tWin, tDraw, tLose)
        RankedSeasons.Add(newRankedSeason)
        selectSeasonComboBox.Text = "Season " & newSeason
        selectSeasonComboBox.Items.Add("Season " & newSeason)
    End Sub

    Public Sub setImageFunction(ByVal link As String)
        imageLink = link

        Dim setImageThread As New Threading.Thread(AddressOf setImage)
        setImageThread.Start()
    End Sub

    Private Delegate Sub setImageDelegate()
    Private Sub setImage()
        Try
            Dim downloadedImage As Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(imageLink)))
            If ProfilePicture.InvokeRequired Then
                ProfilePicture.Invoke(New setImageDelegate(AddressOf setImage))
            Else
                ProfilePicture.Image = downloadedImage
            End If
        Catch
        End Try
    End Sub

    Public Sub LoadAchievements(type As String)
        unrankedWins = auw + buw + cuw

        rankedWins = 0
        For Each season As RankedSeason In RankedSeasons
            rankedWins += season.singleWin
            rankedWins += season.matchWin
            rankedWins += season.tagWin
        Next

        allWins = unrankedWins + rankedWins
        Dim sParts() As String = Split(achievements, ",")

        ListBox3.Items.Clear()

        If type = "General" Then
            If sParts.Contains(0) Then
                ListBox3.Items.Add("Unique Duelist (Completed)")
            Else
                ListBox3.Items.Add("Unique Duelist")
            End If
            If sParts.Contains(1) Then
                ListBox3.Items.Add("Together with a group (Completed)")
            Else
                ListBox3.Items.Add("Together with a group")
            End If
            If sParts.Contains(2) Then
                ListBox3.Items.Add("Save and watch later! (Completed)")
            Else
                ListBox3.Items.Add("Save and watch later!")
            End If
            If sParts.Contains(3) Then
                ListBox3.Items.Add("Yu-Gi-Oh! - Now With Puzzles (Completed)")
            Else
                ListBox3.Items.Add("Yu-Gi-Oh! - Now With Puzzles")
            End If
            If sParts.Contains(4) Then
                ListBox3.Items.Add("Don't want to make a deck, Download One! (Completed)")
            Else
                ListBox3.Items.Add("Don't want to make a deck, Download One!")
            End If
            If sParts.Contains(5) Then
                ListBox3.Items.Add("News - From Kaiba Corporation (Completed)")
            Else
                ListBox3.Items.Add("News - From Kaiba Corporation")
            End If
            If MyQualification >= 1 Then
                ListBox3.Items.Add("Qualified (Completed)")
            Else
                ListBox3.Items.Add("Qualified")
            End If
            If MyQualification >= 2 Then
                ListBox3.Items.Add("Supreme Qualified (Completed)")
            Else
                ListBox3.Items.Add("Supreme Qualified")
            End If
            If Level.Text >= 5 Then
                ListBox3.Items.Add("Level Five (Completed)")
            Else
                ListBox3.Items.Add("Level Five")
            End If
            If Level.Text >= 10 Then
                ListBox3.Items.Add("Rival (Completed)")
            Else
                ListBox3.Items.Add("Rival")
            End If
            If Level.Text >= 15 Then
                ListBox3.Items.Add("Level Fifteen (Completed)")
            Else
                ListBox3.Items.Add("Level Fifteen")
            End If
            If Level.Text >= 20 Then
                ListBox3.Items.Add("Gladiator (Completed)")
            Else
                ListBox3.Items.Add("Gladiator")
            End If
            If Level.Text >= 25 Then
                ListBox3.Items.Add("Level Twenty-Five (Completed)")
            Else
                ListBox3.Items.Add("Level Twenty-Five")
            End If
            If Level.Text >= 30 Then
                ListBox3.Items.Add("Conqueror (Completed)")
            Else
                ListBox3.Items.Add("Conqueror")
            End If
            If Level.Text >= 35 Then
                ListBox3.Items.Add("Level Thirty-Five (Completed)")
            Else
                ListBox3.Items.Add("Level Thirty-Five")
            End If
            If Level.Text >= 40 Then
                ListBox3.Items.Add("Vanquisher (Completed)")
            Else
                ListBox3.Items.Add("Vanquisher")
            End If
            If Level.Text >= 45 Then
                ListBox3.Items.Add("Level Fourty-Five (Completed)")
            Else
                ListBox3.Items.Add("Level Fourty-Five")
            End If
            If Level.Text >= 50 Then
                ListBox3.Items.Add("Titan (Completed)")
            Else
                ListBox3.Items.Add("Titan")
            End If
        ElseIf type = "Dueling" Then
            If sParts.Contains(6) Then
                ListBox3.Items.Add("Duel J.A.R.V.I.S. (Completed)")
            Else
                ListBox3.Items.Add("Duel J.A.R.V.I.S.")
            End If
            If unrankedWins > 1 Then
                ListBox3.Items.Add("Just Starting (Completed)")
            Else
                ListBox3.Items.Add("Just Starting")
            End If
            If unrankedWins > 10 Then
                ListBox3.Items.Add("Long way to go (Completed)")
            Else
                ListBox3.Items.Add("Long way to go")
            End If
            If unrankedWins > 50 Then
                ListBox3.Items.Add("Becoming a duelist! (Completed)")
            Else
                ListBox3.Items.Add("Becoming a duelist!")
            End If
            If unrankedWins > 100 Then
                ListBox3.Items.Add("A Real Duelist (Completed)")
            Else
                ListBox3.Items.Add("A Real Duelist")
            End If
            If unrankedWins > 250 Then
                ListBox3.Items.Add("A Better Duelist (Completed)")
            Else
                ListBox3.Items.Add("A Better Duelist")
            End If
            If unrankedWins > 500 Then
                ListBox3.Items.Add("Expert Duelist (Completed)")
            Else
                ListBox3.Items.Add("Expert Duelist")
            End If
            If unrankedWins > 750 Then
                ListBox3.Items.Add("Senior Duelist (Completed)")
            Else
                ListBox3.Items.Add("Senior Duelist")
            End If
            If unrankedWins > 1000 Then
                ListBox3.Items.Add("Time to join the elite (Completed)")
            Else
                ListBox3.Items.Add("Time to join the elite")
            End If
            If unrankedWins > 1500 Then
                ListBox3.Items.Add("Professional Duelist (Completed)")
            Else
                ListBox3.Items.Add("Professional Duelist")
            End If
            If unrankedWins > 2000 Then
                ListBox3.Items.Add("Master Duelist (Completed)")
            Else
                ListBox3.Items.Add("Master Duelist")
            End If
            If unrankedWins > 3000 Then
                ListBox3.Items.Add("Best of the masters (Completed)")
            Else
                ListBox3.Items.Add("Best of the masters")
            End If
            If unrankedWins > 5000 Then
                ListBox3.Items.Add("They will remember me.. (Completed)")
            Else
                ListBox3.Items.Add("They will remember me..")
            End If
            If unrankedWins > 7500 Then
                ListBox3.Items.Add("The Immortal (Completed)")
            Else
                ListBox3.Items.Add("The Immortal")
            End If
            If unrankedWins > 9000 Then
                ListBox3.Items.Add("Its OVER 9000!! (Completed)")
            Else
                ListBox3.Items.Add("Its OVER 9000!!")
            End If
            If unrankedWins > 10000 Then
                ListBox3.Items.Add("Legendary Duelist (Completed)")
            Else
                ListBox3.Items.Add("Legendary Duelist")
            End If
            If auw > 1000 Then
                ListBox3.Items.Add("Why don't they play matches Anime? (Completed)")
            Else
                ListBox3.Items.Add("Why don't they play matches Anime?")
            End If
            If buw > 1000 Then
                ListBox3.Items.Add("Best out of 3! (Completed)")
            Else
                ListBox3.Items.Add("Best out of 3!")
            End If
            If cuw > 1000 Then
                ListBox3.Items.Add("More players should tag! (Completed)")
            Else
                ListBox3.Items.Add("More players should tag!")
            End If
        ElseIf type = "Elite" Then
            If rankedWins > 1 Then
                ListBox3.Items.Add("Joining the Elite (Completed)")
            Else
                ListBox3.Items.Add("Joining the Elite")
            End If
            If rankedWins > 10 Then
                ListBox3.Items.Add("To reach the Master League..: (Completed)")
            Else
                ListBox3.Items.Add("To reach the Master League..:")
            End If
            If rankedWins > 50 Then
                ListBox3.Items.Add("This is harder then it looks! (Completed)")
            Else
                ListBox3.Items.Add("This is harder then it looks!")
            End If
            If rankedWins > 100 Then
                ListBox3.Items.Add("If only J.A.R.V.I.S. played ranked (Completed)")
            Else
                ListBox3.Items.Add("If only J.A.R.V.I.S. played ranked")
            End If
            If rankedWins > 250 Then
                ListBox3.Items.Add("Now I am the elite (Completed)")
            Else
                ListBox3.Items.Add("Now I am the elite")
            End If
            If rankedWins > 500 Then
                ListBox3.Items.Add("I need more gold now (Completed)")
            Else
                ListBox3.Items.Add("I need more gold now")
            End If
            If rankedWins > 750 Then
                ListBox3.Items.Add("There is none who can defeat me. (Completed)")
            Else
                ListBox3.Items.Add("There is none who can defeat me.")
            End If
            If rankedWins > 1000 Then
                ListBox3.Items.Add("The Warlord is born (Completed)")
            Else
                ListBox3.Items.Add("The Warlord is born")
            End If
            If rankedWins > 1500 Then
                ListBox3.Items.Add("Life as a Warlord is.... Good (Completed)")
            Else
                ListBox3.Items.Add("Life as a Warlord is.... Good")
            End If
            If rankedWins > 2000 Then
                ListBox3.Items.Add("Warlord vs High Warlord  (Completed)")
            Else
                ListBox3.Items.Add("Warlord vs Hig  h Warlord")
            End If
            If rankedWins > 3000 Then
                ListBox3.Items.Add("I will be a High Warlord.... mark my words. (Completed)")
            Else
                ListBox3.Items.Add("I will be a High Warlord.... mark my words.")
            End If
        ElseIf type = "Items" Then
            If MyA1 = "1" Then
                ListBox3.Items.Add("The Locator Card (Completed)")
            Else
                ListBox3.Items.Add("The Locator Card")
            End If
            If JD1 = "1" Then
                ListBox3.Items.Add("J.A.R.V.I.S. Decks (Completed)")
            Else
                ListBox3.Items.Add("J.A.R.V.I.S. Decks")
            End If
            If ForumBooster = "1" Then
                ListBox3.Items.Add("Forum Booster (Completed)")
            Else
                ListBox3.Items.Add("Forum Booster")
            End If
            If MeItem = "1" Then
                ListBox3.Items.Add("Me Command (Completed)")
            Else
                ListBox3.Items.Add("Me Command")
            End If
            If ForumTurboCharger = "1" Then
                ListBox3.Items.Add("Forum TurboCharger (Completed)")
            Else
                ListBox3.Items.Add("Forum TurboCharger")
            End If
            If HeartOfFire = "1" Then
                ListBox3.Items.Add("Firelord (Completed)")
            Else
                ListBox3.Items.Add("Firelord")
            End If
            If LunarLantern = "1" Then
                ListBox3.Items.Add("Starcaller (Completed)")
            Else
                ListBox3.Items.Add("Starcaller")
            End If
        ElseIf type = "Events" Then
            If sParts.Contains(7) Then
                ListBox3.Items.Add("Duelist of Light (Completed)")
            Else
                ListBox3.Items.Add("Duelist of Light")
            End If
            If sParts.Contains(8) Then
                ListBox3.Items.Add("The Lightbringer (Completed)")
            Else
                ListBox3.Items.Add("The Lightbringer")
            End If
            If sParts.Contains(9) Then
                ListBox3.Items.Add("The Light of Dawn (Completed)")
            Else
                ListBox3.Items.Add("The Light of Dawn")
            End If
        ElseIf type = "Tournaments" Then
            If sParts.Contains(10) Then
                ListBox3.Items.Add("Challenge (Completed)")
            Else
                ListBox3.Items.Add("Challenge")
            End If
            If Award1 = 1 Then
                ListBox3.Items.Add("Tournament Champion (Completed)")
            Else
                ListBox3.Items.Add("Tournament Champion")
            End If
            If sParts.Contains(11) Then
                ListBox3.Items.Add("Tournament Master (Completed)")
            Else
                ListBox3.Items.Add("Tournament Master")
            End If
            If sParts.Contains(12) Then
                ListBox3.Items.Add("Tournament Grand Master (Completed)")
            Else
                ListBox3.Items.Add("Tournament Grand Master")
            End If
            If sParts.Contains(13) Then
                ListBox3.Items.Add("Bane of the fallen King (Completed)")
            Else
                ListBox3.Items.Add("Bane of the fallen King")
            End If
        ElseIf type = "Feats of Strength" Then
            If sParts.Contains(14) Then
                ListBox3.Items.Add("Battle City Judge (Completed)")
            Else
                ListBox3.Items.Add("Battle City Judge")
            End If
            If sParts.Contains(15) Then
                ListBox3.Items.Add("Battle City Participant (Completed)")
            Else
                ListBox3.Items.Add("Battle City Participant")
            End If
            If sParts.Contains(16) Then
                ListBox3.Items.Add("Battle City Challenger (Completed)")
            Else
                ListBox3.Items.Add("Battle City Challenger")
            End If
            If sParts.Contains(17) Then
                ListBox3.Items.Add("King of Games (Completed)")
            ElseIf sParts.Contains(18) Then
                ListBox3.Items.Add("Queen of Games (Completed)")
            Else
                ListBox3.Items.Add("King/Queen of Games")
            End If
            If sParts.Contains(19) Then
                ListBox3.Items.Add("Duel Seto Kaiba (Completed)")
            Else
                ListBox3.Items.Add("Duel Seto Kaiba")
            End If
            If sParts.Contains(20) Then
                ListBox3.Items.Add("TDOANE 2 Year Anniversary (Completed)")
            Else
                ListBox3.Items.Add("TDOANE 2 Year Anniversary")
            End If
        End If

        achievementcount = 0
        If sParts.Contains(0) Then
            achievementcount += 1
        End If
        If sParts.Contains(1) Then
            achievementcount += 1
        End If
        If sParts.Contains(2) Then
            achievementcount += 1
        End If
        If sParts.Contains(3) Then
            achievementcount += 1
        End If
        If sParts.Contains(4) Then
            achievementcount += 1
        End If
        If sParts.Contains(5) Then
            achievementcount += 1
        End If
        If MyQualification >= 1 Then
            achievementcount += 1
        End If
        If MyQualification >= 2 Then
            achievementcount += 1
        End If
        If Level.Text >= 5 Then
            achievementcount += 1
        End If
        If Level.Text >= 10 Then
            achievementcount += 1
        End If
        If Level.Text >= 15 Then
            achievementcount += 1
        End If
        If Level.Text >= 20 Then
            achievementcount += 1
        End If
        If Level.Text >= 25 Then
            achievementcount += 1
        End If
        If Level.Text >= 30 Then
            achievementcount += 1
        End If
        If Level.Text >= 35 Then
            achievementcount += 1
        End If
        If Level.Text >= 40 Then
            achievementcount += 1
        End If
        If Level.Text >= 45 Then
            achievementcount += 1
        End If
        If Level.Text >= 50 Then
            achievementcount += 1
        End If
        If sParts.Contains(6) Then
            achievementcount += 1
        End If
        If unrankedWins > 1 Then
            achievementcount += 1
        End If
        If unrankedWins > 10 Then
            achievementcount += 1
        End If
        If unrankedWins > 50 Then
            achievementcount += 1
        End If
        If unrankedWins > 100 Then
            achievementcount += 1
        End If
        If unrankedWins > 250 Then
            achievementcount += 1
        End If
        If unrankedWins > 500 Then
            achievementcount += 1
        End If
        If unrankedWins > 750 Then
            achievementcount += 1
        End If
        If unrankedWins > 1000 Then
            achievementcount += 1
        End If
        If unrankedWins > 1500 Then
            achievementcount += 1
        End If
        If unrankedWins > 2000 Then
            achievementcount += 1
        End If
        If unrankedWins > 3000 Then
            achievementcount += 1
        End If
        If unrankedWins > 5000 Then
            achievementcount += 1
        End If
        If unrankedWins > 7500 Then
            achievementcount += 1
        End If
        If unrankedWins > 9000 Then
            achievementcount += 1
        End If
        If unrankedWins > 10000 Then
            achievementcount += 1
        End If
        If auw > 1000 Then
            achievementcount += 1
        End If
        If buw > 1000 Then
            achievementcount += 1
        End If
        If cuw > 1000 Then
            achievementcount += 1
        End If
        If rankedWins > 1 Then
            achievementcount += 1
        End If
        If rankedWins > 10 Then
            achievementcount += 1
        End If
        If rankedWins > 50 Then
            achievementcount += 1
        End If
        If rankedWins > 100 Then
            achievementcount += 1
        End If
        If rankedWins > 250 Then
            achievementcount += 1
        End If
        If rankedWins > 500 Then
            achievementcount += 1
        End If
        If rankedWins > 750 Then
            achievementcount += 1
        End If
        If rankedWins > 1000 Then
            achievementcount += 1
        End If
        If rankedWins > 1500 Then
            achievementcount += 1
        End If
        If rankedWins > 2000 Then
            achievementcount += 1
        End If
        If rankedWins > 3000 Then
            achievementcount += 1
        End If
        If MyA1 = "1" Then
            achievementcount += 1
        End If
        If JD1 = "1" Then
            achievementcount += 1
        End If
        If ForumBooster = "1" Then
            achievementcount += 1
        End If
        If MeItem = "1" Then
            achievementcount += 1
        End If
        If ForumTurboCharger = "1" Then
            achievementcount += 1
        End If
        If HeartOfFire = "1" Then
            achievementcount += 1
        End If
        If LunarLantern = "1" Then
            achievementcount += 1
        End If
        If sParts.Contains(7) Then
            achievementcount += 1
        End If
        If sParts.Contains(8) Then
            achievementcount += 1
        End If
        If sParts.Contains(9) Then
            achievementcount += 1
        End If
        If sParts.Contains(10) Then
            achievementcount += 1
        End If
        If Award1 = 1 Then
            achievementcount += 1
        End If
        If sParts.Contains(11) Then
            achievementcount += 1
        End If
        If sParts.Contains(12) Then
            achievementcount += 1
        End If
        If sParts.Contains(13) Then
            achievementcount += 1
        End If
        If sParts.Contains(14) Then
            achievementcount += 1
        End If
        If sParts.Contains(15) Then
            achievementcount += 1
        End If
        If sParts.Contains(16) Then
            achievementcount += 1
        End If
        If sParts.Contains(17) Then
            achievementcount += 1
        ElseIf sParts.Contains(18) Then
            achievementcount += 1
        End If
        If sParts.Contains(19) Then
            achievementcount += 1
        End If
        If sParts.Contains(20) Then
            achievementcount += 1
        End If

        Label56.Text = "Achievements:  " & achievementcount & "/70"
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If ListBox3.SelectedItem.Contains("Level Five") Then
            RichTextBox2.Text = "Reach level 5!"
        ElseIf ListBox3.SelectedItem.Contains("Rival") Then
            RichTextBox2.Text = "Reach level 10!"
        ElseIf ListBox3.SelectedItem.Contains("Level Fifteen") Then
            RichTextBox2.Text = "Reach level 15!"
        ElseIf ListBox3.SelectedItem.Contains("Gladiator") Then
            RichTextBox2.Text = "Reach level 20!"
        ElseIf ListBox3.SelectedItem.Contains("Level Twenty-Five") Then
            RichTextBox2.Text = "Reach level 25!"
        ElseIf ListBox3.SelectedItem.Contains("Conqueror") Then
            RichTextBox2.Text = "Reach level 30"
        ElseIf ListBox3.SelectedItem.Contains("Level Thirty-Five") Then
            RichTextBox2.Text = "Reach level 35"
        ElseIf ListBox3.SelectedItem.Contains("Vanquisher") Then
            RichTextBox2.Text = "Reach level 40"
        ElseIf ListBox3.SelectedItem.Contains("Level Fourty-Five") Then
            RichTextBox2.Text = "Reach level 45"
        ElseIf ListBox3.SelectedItem.Contains("Titan") Then
            RichTextBox2.Text = "Reach level 50"
        ElseIf ListBox3.SelectedItem.Contains("Unique Duelist") Then
            RichTextBox2.Text = "Upload an avatar picture."
        ElseIf ListBox3.SelectedItem.Contains("Qualified") Then
            RichTextBox2.Text = "Complete the qualification challenge."
        ElseIf ListBox3.SelectedItem.Contains("Supreme Qualified") Then
            RichTextBox2.Text = "Complete the supreme qualification challenge."
        ElseIf ListBox3.SelectedItem.Contains("Together with a group") Then
            RichTextBox2.Text = "Join or create a team."
        ElseIf ListBox3.SelectedItem.Contains("Save and watch later!") Then
            RichTextBox2.Text = "Watch a replay."
        ElseIf ListBox3.SelectedItem.Contains("Yu-Gi-Oh! - Now With Puzzles") Then
            RichTextBox2.Text = "Play a dueling puzzle."
        ElseIf ListBox3.SelectedItem.Contains("Don't want to make a deck, Download One!") Then
            RichTextBox2.Text = "Check out our list of downloadable decks."
        ElseIf ListBox3.SelectedItem.Contains("News - From Kaiba Corporation") Then
            RichTextBox2.Text = "Check out our News section, where you can find the latest updates and upcoming events."
        ElseIf ListBox3.SelectedItem.Contains("Duel J.A.R.V.I.S.") Then
            RichTextBox2.Text = "Play a duel against J.A.R.V.I.S. - The automatic dueling robot."
        ElseIf ListBox3.SelectedItem.Contains("Random Duel") Then
            RichTextBox2.Text = "Join a random duel."
        ElseIf ListBox3.SelectedItem.Contains("Just Starting") Then
            RichTextBox2.Text = "Win an unranked duel."
        ElseIf ListBox3.SelectedItem.Contains("Long way to go") Then
            RichTextBox2.Text = "Win 10 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Becoming a duelist!") Then
            RichTextBox2.Text = "Win 50 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("A Real Duelist") Then
            RichTextBox2.Text = "Win 100 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("A Better Duelist") Then
            RichTextBox2.Text = "Win 250 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Expert Duelist") Then
            RichTextBox2.Text = "Win 500 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Senior Duelist") Then
            RichTextBox2.Text = "Win 750 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Time to join the elite") Then
            RichTextBox2.Text = "Win 1000 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Professional Duelist") Then
            RichTextBox2.Text = "Win 1500 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Master Duelist") Then
            RichTextBox2.Text = "Win 2000 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Best of the masters") Then
            RichTextBox2.Text = "Win 3000 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("They will remember me..") Then
            RichTextBox2.Text = "Win 5000 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("The Immortal") Then
            RichTextBox2.Text = "Win 7500 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Its OVER 9000!!") Then
            RichTextBox2.Text = "Win 9000 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Legendary Duelist") Then
            RichTextBox2.Text = "Win 10000 unranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Why don't they play matches Anime?") Then
            RichTextBox2.Text = "Win 1000 unranked single duels."
        ElseIf ListBox3.SelectedItem.Contains("Best out of 3!") Then
            RichTextBox2.Text = "Win 1000 unranked match duels."
        ElseIf ListBox3.SelectedItem.Contains("More players should tag!") Then
            RichTextBox2.Text = "Win 1000 unranked tag duels."
        ElseIf ListBox3.SelectedItem.Contains("Joining the Elite") Then
            RichTextBox2.Text = "Win a ranked duel."
        ElseIf ListBox3.SelectedItem.Contains("To reach the Master League..") Then
            RichTextBox2.Text = "Win 10 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("This is harder then it looks!") Then
            RichTextBox2.Text = "Win 50 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("If only J.A.R.V.I.S. played ranked") Then
            RichTextBox2.Text = "Win 100 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Now I am the elite") Then
            RichTextBox2.Text = "Win 250 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("I need more gold now") Then
            RichTextBox2.Text = "Win 500 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("There is none who can defeat me.") Then
            RichTextBox2.Text = "Win 750 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("The Warlord is born") Then
            RichTextBox2.Text = "Win 1000 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Life as a Warlord is.... Good") Then
            RichTextBox2.Text = "Win 1500 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("Warlord vs High Warlord") Then
            RichTextBox2.Text = "Win 2000 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("I will be a High Warlord.... mark my words.") Then
            RichTextBox2.Text = "Win 3000 ranked duels."
        ElseIf ListBox3.SelectedItem.Contains("The Locator Card") Then
            RichTextBox2.Text = "Buy the Locator card from the store."
        ElseIf ListBox3.SelectedItem.Contains("J.A.R.V.I.S. Decks") Then
            RichTextBox2.Text = "Unlock extra J.A.R.V.I.S. decks."
        ElseIf ListBox3.SelectedItem.Contains("Forum Booster") Then
            RichTextBox2.Text = "Buy the Forum Booster item."
        ElseIf ListBox3.SelectedItem.Contains("Me Command") Then
            RichTextBox2.Text = "Buy the Me Command."
        ElseIf ListBox3.SelectedItem.Contains("Forum TurboCharger") Then
            RichTextBox2.Text = "Buy the Forum TurboCharger item."
        ElseIf ListBox3.SelectedItem.Contains("Firelord") Then
            RichTextBox2.Text = "Buy the 'Heart of Fire'"
        ElseIf ListBox3.SelectedItem.Contains("Starcaller") Then
            RichTextBox2.Text = "Buy the Lunar Lantern item."
        ElseIf ListBox3.SelectedItem.Contains("Duelist of Light") Then
            RichTextBox2.Text = "Defeat a shadow duelist."
        ElseIf ListBox3.SelectedItem.Contains("The Lightbringer") Then
            RichTextBox2.Text = "Defeat 10 shadow duelists."
        ElseIf ListBox3.SelectedItem.Contains("The Light of Dawn") Then
            RichTextBox2.Text = "Defeat a hard shadow duelist."
        ElseIf ListBox3.SelectedItem.Contains("Challenge") Then
            RichTextBox2.Text = "Send a tournament challenge."
        ElseIf ListBox3.SelectedItem.Contains("Tournament Champion") Then
            RichTextBox2.Text = "Win a tournament hosted by Kaiba Corporation."
        ElseIf ListBox3.SelectedItem.Contains("Tournament Master") Then
            RichTextBox2.Text = "Win 5 tournaments hosted by Kaiba Corporation."
        ElseIf ListBox3.SelectedItem.Contains("Tournament Grand Master") Then
            RichTextBox2.Text = "Win 10 tournaments hosted by Kaiba Corporation."
        ElseIf ListBox3.SelectedItem.Contains("Bane of the fallen King") Then
            RichTextBox2.Text = "Defeat the King of Games in the Rebellion event."
        ElseIf ListBox3.SelectedItem.Contains("Battle City Judge") Then
            RichTextBox2.Text = "Was an official judge for the Battle City tournament."
        ElseIf ListBox3.SelectedItem.Contains("Battle City Participant") Then
            RichTextBox2.Text = "Participated in the Battle City tournament."
        ElseIf ListBox3.SelectedItem.Contains("Battle City Challenger") Then
            RichTextBox2.Text = "Reached top 16 in the Battle City tournament."
        ElseIf ListBox3.SelectedItem.Contains(" of Games") Then
            RichTextBox2.Text = "Won the Battle City Tournament."
        ElseIf ListBox3.SelectedItem.Contains("Duel Seto Kaiba") Then
            RichTextBox2.Text = "Purchased the 'Duel Seto Kaiba' item from the store and complete a duel against Seto Kaiba."
        ElseIf ListBox3.SelectedItem.Contains("TDOANE 2 Year Anniversary") Then
            RichTextBox2.Text = "Logged in during the second TDOANE Anniversary week (April 7th 2014 - April 14th 2014) "
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Try
            LoadAchievements(ListBox2.SelectedItem)
        Catch
            LoadAchievements("General")
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            PictureBox5.Size = New Size(3, 2)
        Else
            PictureBox5.Size = New Size(3, 19)
        End If
    End Sub

    Private Sub selectSeasonComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectSeasonComboBox.SelectedIndexChanged
        Dim season As Integer = Convert.ToInt32(selectSeasonComboBox.Text.Replace("Season ", ""))
        UpdateRankedSeasonDisplay(season)
    End Sub

    Public Sub UpdateRankedSeasonDisplay(season As Integer)
        For Each rankedSeason As RankedSeason In RankedSeasons
            If rankedSeason.season = season Then
                selectSeasonComboBox.Text = "Season " & rankedSeason.season
                seasonNameLbl.Text = "Season " & rankedSeason.season
                singleRatingLbl.Text = rankedSeason.singleRating
                singleWinLbl.Text = rankedSeason.singleWin
                singleDrawLbl.Text = rankedSeason.singleDraw
                singleLostLbl.Text = rankedSeason.singleLose
                matchRatingLbl.Text = rankedSeason.matchRating
                matchWinLbl.Text = rankedSeason.matchWin
                matchDrawLbl.Text = rankedSeason.matchDraw
                matchLostLbl.Text = rankedSeason.matchLose
                tagRatingLbl.Text = rankedSeason.tagRating
                tagWinLbl.Text = rankedSeason.tagWin
                tagDrawLbl.Text = rankedSeason.tagDraw
                tagLostLbl.Text = rankedSeason.tagLose

                If rankedSeason.singleRating <= 1400 Then
                    singleRankedImage.Image = My.Resources._1s
                ElseIf rankedSeason.singleRating <= 1550 Then
                    singleRankedImage.Image = My.Resources._2s
                ElseIf rankedSeason.singleRating <= 1700 Then
                    singleRankedImage.Image = My.Resources._3s
                ElseIf rankedSeason.singleRating <= 1850 Then
                    singleRankedImage.Image = My.Resources._4s
                ElseIf rankedSeason.singleRating <= 2000 Then
                    singleRankedImage.Image = My.Resources._5s
                ElseIf rankedSeason.singleRating <= 2150 Then
                    singleRankedImage.Image = My.Resources._6s
                Else
                    singleRankedImage.Image = My.Resources._7s
                End If
                If rankedSeason.matchRating <= 1400 Then
                    matchRankedImage.Image = My.Resources._1s
                ElseIf rankedSeason.matchRating <= 1550 Then
                    matchRankedImage.Image = My.Resources._2s
                ElseIf rankedSeason.matchRating <= 1700 Then
                    matchRankedImage.Image = My.Resources._3s
                ElseIf rankedSeason.matchRating <= 1850 Then
                    matchRankedImage.Image = My.Resources._4s
                ElseIf rankedSeason.matchRating <= 2000 Then
                    matchRankedImage.Image = My.Resources._5s
                ElseIf rankedSeason.matchRating <= 2150 Then
                    matchRankedImage.Image = My.Resources._6s
                Else
                    matchRankedImage.Image = My.Resources._7s
                End If
                If rankedSeason.tagRating <= 1400 Then
                    tagRankedImage.Image = My.Resources._1s
                ElseIf rankedSeason.tagRating <= 1550 Then
                    tagRankedImage.Image = My.Resources._2s
                ElseIf rankedSeason.tagRating <= 1700 Then
                    tagRankedImage.Image = My.Resources._3s
                ElseIf rankedSeason.tagRating <= 1850 Then
                    tagRankedImage.Image = My.Resources._4s
                ElseIf rankedSeason.tagRating <= 2000 Then
                    tagRankedImage.Image = My.Resources._5s
                ElseIf rankedSeason.tagRating <= 2150 Then
                    tagRankedImage.Image = My.Resources._6s
                Else
                    tagRankedImage.Image = My.Resources._7s
                End If

                Exit For
            End If
        Next
    End Sub
End Class