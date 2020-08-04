Public Class EditProfile
    Public titleList As New List(Of String)
    Public unrankedWins As Integer
    Public rankedWins As Integer
    Public allWins As Integer
    Public achievements As String
    Dim achievementcount As Integer = 0
    Public Award1 As String
    Public auw As Integer
    Public buw As Integer
    Public cuw As Integer
    Dim newTitle As String
    Dim borderList As New List(Of String)

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UpdateProfile(True)
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("cmd /c start http://ygopro.org/howtouploadvideo.htm")
    End Sub

    Public Sub LoadTitles()
        unrankedWins = auw + buw + cuw

        rankedWins = 0
        For Each season As RankedSeason In RankedSeasons
            rankedWins += season.singleWin
            rankedWins += season.matchWin
            rankedWins += season.tagWin
        Next

        allWins = unrankedWins + rankedWins

        If Level.Text >= 10 Then
            AddTitle("Rival")
        End If
        If Level.Text >= 20 Then
            AddTitle("Gladiator")
        End If
        If Level.Text >= 30 Then
            AddTitle("Conqueror")
        End If
        If Level.Text >= 40 Then
            AddTitle("Vanquisher")
        End If
        If Level.Text >= 50 Then
            AddTitle("TITAN")
        End If
        If unrankedWins >= 100 Then
            AddTitle("Duelist")
        End If
        If unrankedWins >= 500 Then
            AddTitle("Expert Duelist")
        End If
        If unrankedWins >= 750 Then
            AddTitle("Senior Duelist")
        End If
        If unrankedWins >= 1500 Then
            AddTitle("Professional Duelist")
        End If
        If unrankedWins >= 2000 Then
            AddTitle("Master Duelist")
        End If
        If allWins >= 7500 Then
            AddTitle("The Immortal")
        End If
        If allWins >= 10000 Then
            AddTitle("Legendary Duelist")
        End If
        If Launcher.MyQualification = 2 Then
            AddTitle("Supreme")
        End If
        If Launcher.HeartOfFire = 1 Then
            AddTitle("Firelord")
        End If
        If Launcher.LunarLantern = 1 Then
            AddTitle("Starcaller")
        End If
        If Launcher.Stormborn = 1 Then
            AddTitle("Stormborn")
        End If
        If Launcher.Rexterra = 1 Then
            AddTitle("Rexterra")
        End If
        If Launcher.Tidemaster = 1 Then
            AddTitle("Tidemaster")
        End If
        If Launcher.HeartOfFire = 1 And Launcher.Stormborn = 1 And Launcher.Rexterra = 1 And Launcher.Tidemaster = 1 Then
            AddTitle("Master of Elements")
        End If
        If Launcher.Nightshade = 1 Then
            AddTitle("Nightshade")
        End If
        If Launcher.LordOfLight = 1 Then
            AddTitle("Lord of Light")
        End If
    End Sub

    Public Sub AddTitles(titles)
        Dim sParts() As String = Split(titles, ",")

        For Each title As Integer In sParts
            If title = 0 Then
                AddTitle("King of Games")
            End If
            If title = 1 Then
                AddTitle("Queen of Games")
            End If
            If title = 2 Then
                AddTitle("Battle City Challenger")
            End If
            If title = 3 Then
                AddTitle("High Warlord")
            End If
            If title = 4 Then
                AddTitle("Warlord")
            End If
            If title = 5 Then
                AddTitle("Kaiser")
            End If
            If title = 6 Then
                AddTitle("Champion")
            End If
            If title = 7 Then
                AddTitle("Master")
            End If
            If title = 8 Then
                AddTitle("Grand Master")
            End If
            If title = 9 Then
                AddTitle("Judge")
            End If
            If title = 10 Then
                AddTitle("The Light of Dawn")
            End If
            If title = 11 Then
                AddTitle("Head Moderator")
            End If
            If title = 12 Then
                AddTitle("Head Global Moderator")
            End If
            If title = 13 Then
                AddTitle("Head FBI")
            End If
            If title = 14 Then
                AddTitle("Event Manager")
            End If
            If title = 15 Then
                AddTitle("CEO")
            End If
            If title = 16 Then
                AddTitle("Gen King")
            End If
            If title = 17 Then
                AddTitle("TDOANE Challenger")
            End If
            If title = 18 Then
                AddTitle("TDOANE Champion")
            End If
            If title = 19 Then
                AddTitle("Moon Ruler")
            End If
        Next
    End Sub

    Public Sub LoadAchievements(type)
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
            If Launcher.MyQualification >= 1 Then
                ListBox3.Items.Add("Qualified (Completed)")
            Else
                ListBox3.Items.Add("Qualified")
            End If
            If Launcher.MyQualification >= 2 Then
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
            If Launcher.MyA1 = "1" Then
                ListBox3.Items.Add("The Locator Card (Completed)")
            Else
                ListBox3.Items.Add("The Locator Card")
            End If
            If Launcher.JD1 = "1" Then
                ListBox3.Items.Add("J.A.R.V.I.S. Decks (Completed)")
            Else
                ListBox3.Items.Add("J.A.R.V.I.S. Decks")
            End If
            If Launcher.ForumBooster = "1" Then
                ListBox3.Items.Add("Forum Booster (Completed)")
            Else
                ListBox3.Items.Add("Forum Booster")
            End If
            If Launcher.MeItem = "1" Then
                ListBox3.Items.Add("Me Command (Completed)")
            Else
                ListBox3.Items.Add("Me Command")
            End If
            If Launcher.ForumTurboCharger = "1" Then
                ListBox3.Items.Add("Forum TurboCharger (Completed)")
            Else
                ListBox3.Items.Add("Forum TurboCharger")
            End If
            If Launcher.HeartOfFire = "1" Then
                ListBox3.Items.Add("Firelord (Completed)")
            Else
                ListBox3.Items.Add("Firelord")
            End If
            If Launcher.LunarLantern = "1" Then
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
        If Launcher.MyQualification >= 1 Then
            achievementcount += 1
        End If
        If Launcher.MyQualification >= 2 Then
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
        If Launcher.MyA1 = "1" Then
            achievementcount += 1
        End If
        If Launcher.JD1 = "1" Then
            achievementcount += 1
        End If
        If Launcher.ForumBooster = "1" Then
            achievementcount += 1
        End If
        If Launcher.MeItem = "1" Then
            achievementcount += 1
        End If
        If Launcher.ForumTurboCharger = "1" Then
            achievementcount += 1
        End If
        If Launcher.HeartOfFire = "1" Then
            achievementcount += 1
        End If
        If Launcher.LunarLantern = "1" Then
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

    Sub AddTitle(title)
        If titleList.Contains(title) = False Then
            titleList.Add(title)
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Try
            LoadAchievements(ListBox2.SelectedItem)
        Catch
            LoadAchievements("General")
        End Try
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim border As Integer

        If ListBox1.SelectedItem = "Player" Then
            border = 0
        ElseIf ListBox1.SelectedItem = "Gold Member" Then
            border = 1
        ElseIf ListBox1.SelectedItem = "Platinum Member" Then
            border = 2
        ElseIf ListBox1.SelectedItem = "Diamond Member" Then
            border = 3
        ElseIf ListBox1.SelectedItem = "Blue Border" Then
            border = 4
        ElseIf ListBox1.SelectedItem = "Green Border" Then
            border = 5
        ElseIf ListBox1.SelectedItem = "Red Border" Then
            border = 6
        ElseIf ListBox1.SelectedItem = "Cyan Border" Then
            border = 7
        ElseIf ListBox1.SelectedItem = "Starcaller" Then
            border = 8
        ElseIf ListBox1.SelectedItem = "Firelord" Then
            border = 9
        ElseIf ListBox1.SelectedItem = "King of Games" Then
            border = 10
        ElseIf ListBox1.SelectedItem = "Light Border" Then
            border = 11
        ElseIf ListBox1.SelectedItem = "Dark Border" Then
            border = 12
        ElseIf ListBox1.SelectedItem = "Water Border" Then
            border = 13
        ElseIf ListBox1.SelectedItem = "Earth Border" Then
            border = 14
        ElseIf ListBox1.SelectedItem = "Wind Border" Then
            border = 15
        ElseIf ListBox1.SelectedItem = "Blue-Eyes White Dragon" Then
            border = 16
        ElseIf ListBox1.SelectedItem = "5ds Border" Then
            border = 17
        ElseIf ListBox1.SelectedItem = "Exodia the Forbidden One" Then
            border = 18
        ElseIf ListBox1.SelectedItem = "United States of America" Then
            border = 19
        ElseIf ListBox1.SelectedItem = "The Seal of Orichalcos" Then
            border = 20
        ElseIf ListBox1.SelectedItem = "Millennium Border" Then
            border = 21
        ElseIf ListBox1.SelectedItem = "Moderator" Then
            border = 22
        ElseIf ListBox1.SelectedItem = "Global Moderator" Then
            border = 25
        ElseIf ListBox1.SelectedItem = "FBI" Then
            border = 27
        ElseIf ListBox1.SelectedItem = "Administrator" Then
            border = 28
        ElseIf ListBox1.SelectedItem = "CEO" Then
            border = 29
        ElseIf ListBox1.SelectedItem = "Luna Border I" Then
            border = 45
        ElseIf ListBox1.SelectedItem = "Luna Border II" Then
            border = 46
        ElseIf ListBox1.SelectedItem = "Luna Border III" Then
            border = 47
        ElseIf ListBox1.SelectedItem = "Luna Border IV" Then
            border = 48
        ElseIf ListBox1.SelectedItem = "Water Border II" Then
            border = 62
        ElseIf ListBox1.SelectedItem = "Alexis Border" Then
            border = 31
        ElseIf ListBox1.SelectedItem = "ARC-V Border" Then
            border = 32
        ElseIf ListBox1.SelectedItem = "Akiza Border" Then
            border = 33
        ElseIf ListBox1.SelectedItem = "Akiza Border II" Then
            border = 34
        ElseIf ListBox1.SelectedItem = "Chazz Border" Then
            border = 35
        ElseIf ListBox1.SelectedItem = "Crow Border" Then
            border = 36
        ElseIf ListBox1.SelectedItem = "The Green Leaf" Then
            border = 37
        ElseIf ListBox1.SelectedItem = "The Fire Border" Then
            border = 38
        ElseIf ListBox1.SelectedItem = "Gundam Border" Then
            border = 39
        ElseIf ListBox1.SelectedItem = "The Star" Then
            border = 71
        ElseIf ListBox1.SelectedItem = "Ancient Bird" Then
            border = 72
        ElseIf ListBox1.SelectedItem = "GX Border" Then
            border = 40
        ElseIf ListBox1.SelectedItem = "Sub Zero" Then
            border = 41
        ElseIf ListBox1.SelectedItem = "Jack Border" Then
            border = 42
        ElseIf ListBox1.SelectedItem = "Jaden Border" Then
            border = 43
        ElseIf ListBox1.SelectedItem = "Jesse Border" Then
            border = 44
        ElseIf ListBox1.SelectedItem = "Ninja Border" Then
            border = 49
        ElseIf ListBox1.SelectedItem = "Regi Border" Then
            border = 50
        ElseIf ListBox1.SelectedItem = "The Rose Border" Then
            border = 51
        ElseIf ListBox1.SelectedItem = "Hatsune Miku" Then
            border = 52
        ElseIf ListBox1.SelectedItem = "Hatsune Miku II" Then
            border = 53
        ElseIf ListBox1.SelectedItem = "Hatsune Miku III" Then
            border = 54
        ElseIf ListBox1.SelectedItem = "Kaiba Border" Then
            border = 55
        ElseIf ListBox1.SelectedItem = "Shark Border" Then
            border = 56
        ElseIf ListBox1.SelectedItem = "Leo Border" Then
            border = 57
        ElseIf ListBox1.SelectedItem = "Sora Border" Then
            border = 58
        ElseIf ListBox1.SelectedItem = "Golem Fury" Then
            border = 59
        ElseIf ListBox1.SelectedItem = "Susanoo Border" Then
            border = 60
        ElseIf ListBox1.SelectedItem = "Venom Border" Then
            border = 61
        ElseIf ListBox1.SelectedItem = "Sylvan Frenzy" Then
            border = 63
        ElseIf ListBox1.SelectedItem = "Yugo Border" Then
            border = 64
        ElseIf ListBox1.SelectedItem = "Yugi Border" Then
            border = 65
        ElseIf ListBox1.SelectedItem = "Yusei Border" Then
            border = 66
        ElseIf ListBox1.SelectedItem = "Yuya Border" Then
            border = 67
        ElseIf ListBox1.SelectedItem = "Yuri Border I" Then
            border = 76
        ElseIf ListBox1.SelectedItem = "Yuri Border II" Then
            border = 77
        ElseIf ListBox1.SelectedItem = "Zane Border" Then
            border = 68
        ElseIf ListBox1.SelectedItem = "Zexal Border" Then
            border = 69
        ElseIf ListBox1.SelectedItem = "The Colorful Border" Then
            border = 70
        ElseIf ListBox1.SelectedItem = "Sherry LeBlanc Border" Then
            border = 73
        ElseIf ListBox1.SelectedItem = "Baby Dragon Border" Then
            border = 74
        ElseIf ListBox1.SelectedItem = "Guts Border" Then
            border = 75
        ElseIf ListBox1.SelectedItem = "Hata no Kokoro Border I" Then
            border = 78
        ElseIf ListBox1.SelectedItem = "Hata no Kokoro Border II" Then
            border = 79
        ElseIf ListBox1.SelectedItem = "PowerPuff Girls Border" Then
            border = 80
        ElseIf ListBox1.SelectedItem = "Reimu Hakurei Border I" Then
            border = 81
        ElseIf ListBox1.SelectedItem = "Reimu Hakurei Border II" Then
            border = 82
        ElseIf ListBox1.SelectedItem = "Sakuya Izayoi Border I" Then
            border = 83
        ElseIf ListBox1.SelectedItem = "Sakuya Izayoi Border II" Then
            border = 84
        ElseIf ListBox1.SelectedItem = "Totally Spies Border" Then
            border = 85
        ElseIf ListBox1.SelectedItem = "Bakura Border I" Then
            border = 86
        ElseIf ListBox1.SelectedItem = "Bakura Border II" Then
            border = 87
        ElseIf ListBox1.SelectedItem = "Christmas Border I" Then
            border = 88
        ElseIf ListBox1.SelectedItem = "Christmas Border II" Then
            border = 89
        ElseIf ListBox1.SelectedItem = "Christmas Border III" Then
            border = 90
        ElseIf ListBox1.SelectedItem = "Christmas Border IV" Then
            border = 91
        ElseIf ListBox1.SelectedItem = "Christmas Border V" Then
            border = 92
        ElseIf ListBox1.SelectedItem = "Christmas Border VI" Then
            border = 93
        ElseIf ListBox1.SelectedItem = "Ishizu Border I" Then
            border = 94
        ElseIf ListBox1.SelectedItem = "Ishizu Border II" Then
            border = 95
        ElseIf ListBox1.SelectedItem = "Lazar Border" Then
            border = 96
        ElseIf ListBox1.SelectedItem = "Mai Border I" Then
            border = 97
        ElseIf ListBox1.SelectedItem = "Mai Border II" Then
            border = 98
        ElseIf ListBox1.SelectedItem = "Mai Border III" Then
            border = 99
        ElseIf ListBox1.SelectedItem = "Mako Border" Then
            border = 100
        ElseIf ListBox1.SelectedItem = "Marik Border I" Then
            border = 101
        ElseIf ListBox1.SelectedItem = "Marik Border II" Then
            border = 102
        ElseIf ListBox1.SelectedItem = "Odion Border" Then
            border = 103
        ElseIf ListBox1.SelectedItem = "Pegasus Border" Then
            border = 104
        ElseIf ListBox1.SelectedItem = "Reji Border" Then
            border = 105
        ElseIf ListBox1.SelectedItem = "Thief King Border I" Then
            border = 106
        ElseIf ListBox1.SelectedItem = "Thief King Border II" Then
            border = 107
        ElseIf ListBox1.SelectedItem = "Yori Border" Then
            border = 108
        ElseIf ListBox1.SelectedItem = "Yubel Border" Then
            border = 109
        ElseIf ListBox1.SelectedItem = "Yami Border I" Then
            border = 110
        ElseIf ListBox1.SelectedItem = "Yami Border II" Then
            border = 111
        ElseIf ListBox1.SelectedItem = "Yami Border III" Then
            border = 112
        ElseIf ListBox1.SelectedItem = "Yami Border IV" Then
            border = 113
        ElseIf ListBox1.SelectedItem = "Yami Border V" Then
            border = 114
        ElseIf ListBox1.SelectedItem = "Yugo Border" Then
            border = 115
        ElseIf ListBox1.SelectedItem = "Yusei Border I" Then
            border = 116
        ElseIf ListBox1.SelectedItem = "Yusei Border II" Then
            border = 117
        ElseIf ListBox1.SelectedItem = "Yuto Border I" Then
            border = 118
        ElseIf ListBox1.SelectedItem = "Yuto Border II" Then
            border = 119
        ElseIf ListBox1.SelectedItem = "Yuto Border III" Then
            border = 120
        ElseIf ListBox1.SelectedItem = "Suzaku Kururugii Border" Then
            border = 121
        ElseIf ListBox1.SelectedItem = "Pinkie Pie Border" Then
            border = 122
        ElseIf ListBox1.SelectedItem = "Yubelious! Border" Then
            border = 123
        ElseIf ListBox1.SelectedItem = "Utopia God Border" Then
            border = 124
        ElseIf ListBox1.SelectedItem = "Jeduraiya Border" Then
            border = 125
        ElseIf ListBox1.SelectedItem = "IronDragonSlayer Border" Then
            border = 126
        ElseIf ListBox1.SelectedItem = "Cavallier Border" Then
            border = 127
        ElseIf ListBox1.SelectedItem = "Motoko Border" Then
            border = 128
        ElseIf ListBox1.SelectedItem = "Nep-Nep Border" Then
            border = 129
        ElseIf ListBox1.SelectedItem = "Diablox73 Border" Then
            border = 130
        ElseIf ListBox1.SelectedItem = "CottonBuds Border" Then
            border = 131
        ElseIf ListBox1.SelectedItem = "raditz Border" Then
            border = 132
        ElseIf ListBox1.SelectedItem = "DeharaRules Border" Then
            border = 133
        ElseIf ListBox1.SelectedItem = "SupremeKingOfGames Border" Then
            border = 134
        ElseIf ListBox1.SelectedItem = "Divine Halo Border I" Then
            border = 135
        ElseIf ListBox1.SelectedItem = "n00b_of_legend Border" Then
            border = 136
        ElseIf ListBox1.SelectedItem = "MeiMei Border" Then
            border = 137
        ElseIf ListBox1.SelectedItem = "Old Yama Border" Then
            border = 138
        ElseIf ListBox1.SelectedItem = "Astrike7 Border" Then
            border = 139
        ElseIf ListBox1.SelectedItem = "leonesshadow Border" Then
            border = 140
        ElseIf ListBox1.SelectedItem = "Cloudie Border" Then
            border = 141
        ElseIf ListBox1.SelectedItem = "BreadedShark Border" Then
            border = 142
        ElseIf ListBox1.SelectedItem = "casx Border" Then
            border = 143
        ElseIf ListBox1.SelectedItem = "TigranxDaddy Border" Then
            border = 144
        ElseIf ListBox1.SelectedItem = "theoldman Border" Then
            border = 145
        ElseIf ListBox1.SelectedItem = "Heralds Border" Then
            border = 146
        ElseIf ListBox1.SelectedItem = "Lotus Border" Then
            border = 147
        ElseIf ListBox1.SelectedItem = "Kor Saiyajinkami Border" Then
            border = 148
        ElseIf ListBox1.SelectedItem = "AbyssDuelist Border" Then
            border = 149
        ElseIf ListBox1.SelectedItem = "duke_of_dice Border" Then
            border = 150
        ElseIf ListBox1.SelectedItem = "Shindou Yuuki Border" Then
            border = 151
        ElseIf ListBox1.SelectedItem = "Kamyu Border" Then
            border = 152
        ElseIf ListBox1.SelectedItem = "Shén-MörderX Border" Then
            border = 153
        ElseIf ListBox1.SelectedItem = "JaemReach Border I" Then
            border = 154
        ElseIf ListBox1.SelectedItem = "ShaddollWendigo Border" Then
            border = 155
        ElseIf ListBox1.SelectedItem = "Specialiskid1 Border" Then
            border = 156
        ElseIf ListBox1.SelectedItem = "Melibell Border I" Then
            border = 157
        ElseIf ListBox1.SelectedItem = "Unixez Border" Then
            border = 158
        ElseIf ListBox1.SelectedItem = "Melibell Border II" Then
            border = 159
        ElseIf ListBox1.SelectedItem = "Melibell Border III" Then
            border = 160
        ElseIf ListBox1.SelectedItem = "Pumpkinstraw09 Border" Then
            border = 161
        ElseIf ListBox1.SelectedItem = "Magician7 Border" Then
            border = 162
        ElseIf ListBox1.SelectedItem = "Zappy Border" Then
            border = 163
        ElseIf ListBox1.SelectedItem = "ThePROtagonist Border" Then
            border = 164
        ElseIf ListBox1.SelectedItem = "Divine Halo Border II" Then
            border = 165
        ElseIf ListBox1.SelectedItem = "Amine Border I" Then
            border = 166
        ElseIf ListBox1.SelectedItem = "Amine Border II" Then
            border = 167
        ElseIf ListBox1.SelectedItem = "Amine Border III" Then
            border = 168
        ElseIf ListBox1.SelectedItem = "WindMillCrow Border" Then
            border = 169
        ElseIf ListBox1.SelectedItem = "JaemReach Border II" Then
            border = 170
        End If

        If borderList.Contains(border) Then
            Launcher.UpdateBorder(border)
        ElseIf Launcher.Rank <> "Player" And Launcher.Rank <> "Gold Member" And Launcher.Rank <> "Platinum Member" And Launcher.Rank <> "Diamond Member" And Launcher.Rank <> "FBI" Then
            Launcher.UpdateBorder(border)
        Else
            MsgBox("You don't own this border, please check the store!")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim border As Integer

        If ListBox1.SelectedItem = "Player" Then
            border = 0
        ElseIf ListBox1.SelectedItem = "Gold Member" Then
            border = 1
        ElseIf ListBox1.SelectedItem = "Platinum Member" Then
            border = 2
        ElseIf ListBox1.SelectedItem = "Diamond Member" Then
            border = 3
        ElseIf ListBox1.SelectedItem = "Blue Border" Then
            border = 4
        ElseIf ListBox1.SelectedItem = "Green Border" Then
            border = 5
        ElseIf ListBox1.SelectedItem = "Red Border" Then
            border = 6
        ElseIf ListBox1.SelectedItem = "Cyan Border" Then
            border = 7
        ElseIf ListBox1.SelectedItem = "Starcaller" Then
            border = 8
        ElseIf ListBox1.SelectedItem = "Firelord" Then
            border = 9
        ElseIf ListBox1.SelectedItem = "King of Games" Then
            border = 10
        ElseIf ListBox1.SelectedItem = "Light Border" Then
            border = 11
        ElseIf ListBox1.SelectedItem = "Dark Border" Then
            border = 12
        ElseIf ListBox1.SelectedItem = "Water Border" Then
            border = 13
        ElseIf ListBox1.SelectedItem = "Earth Border" Then
            border = 14
        ElseIf ListBox1.SelectedItem = "Wind Border" Then
            border = 15
        ElseIf ListBox1.SelectedItem = "Blue-Eyes White Dragon" Then
            border = 16
        ElseIf ListBox1.SelectedItem = "5ds Border" Then
            border = 17
        ElseIf ListBox1.SelectedItem = "Exodia the Forbidden One" Then
            border = 18
        ElseIf ListBox1.SelectedItem = "United States of America" Then
            border = 19
        ElseIf ListBox1.SelectedItem = "The Seal of Orichalcos" Then
            border = 20
        ElseIf ListBox1.SelectedItem = "Millennium Border" Then
            border = 21
        ElseIf ListBox1.SelectedItem = "Moderator" Then
            border = 22
        ElseIf ListBox1.SelectedItem = "Global Moderator" Then
            border = 25
        ElseIf ListBox1.SelectedItem = "FBI" Then
            border = 27
        ElseIf ListBox1.SelectedItem = "Administrator" Then
            border = 28
        ElseIf ListBox1.SelectedItem = "CEO" Then
            border = 29
        ElseIf ListBox1.SelectedItem = "Luna Border I" Then
            border = 45
        ElseIf ListBox1.SelectedItem = "Luna Border II" Then
            border = 46
        ElseIf ListBox1.SelectedItem = "Luna Border III" Then
            border = 47
        ElseIf ListBox1.SelectedItem = "Luna Border IV" Then
            border = 48
        ElseIf ListBox1.SelectedItem = "Water Border II" Then
            border = 62
        ElseIf ListBox1.SelectedItem = "Alexis Border" Then
            border = 31
        ElseIf ListBox1.SelectedItem = "ARC-V Border" Then
            border = 32
        ElseIf ListBox1.SelectedItem = "Akiza Border" Then
            border = 33
        ElseIf ListBox1.SelectedItem = "Akiza Border II" Then
            border = 34
        ElseIf ListBox1.SelectedItem = "Chazz Border" Then
            border = 35
        ElseIf ListBox1.SelectedItem = "Crow Border" Then
            border = 36
        ElseIf ListBox1.SelectedItem = "The Green Leaf" Then
            border = 37
        ElseIf ListBox1.SelectedItem = "The Fire Border" Then
            border = 38
        ElseIf ListBox1.SelectedItem = "Gundam Border" Then
            border = 39
        ElseIf ListBox1.SelectedItem = "The Star" Then
            border = 71
        ElseIf ListBox1.SelectedItem = "Ancient Bird" Then
            border = 72
        ElseIf ListBox1.SelectedItem = "GX Border" Then
            border = 40
        ElseIf ListBox1.SelectedItem = "Sub Zero" Then
            border = 41
        ElseIf ListBox1.SelectedItem = "Jack Border" Then
            border = 42
        ElseIf ListBox1.SelectedItem = "Jaden Border" Then
            border = 43
        ElseIf ListBox1.SelectedItem = "Jesse Border" Then
            border = 44
        ElseIf ListBox1.SelectedItem = "Ninja Border" Then
            border = 49
        ElseIf ListBox1.SelectedItem = "Regi Border" Then
            border = 50
        ElseIf ListBox1.SelectedItem = "The Rose Border" Then
            border = 51
        ElseIf ListBox1.SelectedItem = "Hatsune Miku" Then
            border = 52
        ElseIf ListBox1.SelectedItem = "Hatsune Miku II" Then
            border = 53
        ElseIf ListBox1.SelectedItem = "Hatsune Miku III" Then
            border = 54
        ElseIf ListBox1.SelectedItem = "Kaiba Border" Then
            border = 55
        ElseIf ListBox1.SelectedItem = "Shark Border" Then
            border = 56
        ElseIf ListBox1.SelectedItem = "Leo Border" Then
            border = 57
        ElseIf ListBox1.SelectedItem = "Sora Border" Then
            border = 58
        ElseIf ListBox1.SelectedItem = "Golem Fury" Then
            border = 59
        ElseIf ListBox1.SelectedItem = "Susanoo Border" Then
            border = 60
        ElseIf ListBox1.SelectedItem = "Venom Border" Then
            border = 61
        ElseIf ListBox1.SelectedItem = "Sylvan Frenzy" Then
            border = 63
        ElseIf ListBox1.SelectedItem = "Yugo Border" Then
            border = 64
        ElseIf ListBox1.SelectedItem = "Yugi Border" Then
            border = 65
        ElseIf ListBox1.SelectedItem = "Yusei Border" Then
            border = 66
        ElseIf ListBox1.SelectedItem = "Yuya Border" Then
            border = 67
        ElseIf ListBox1.SelectedItem = "Yuri Border I" Then
            border = 76
        ElseIf ListBox1.SelectedItem = "Yuri Border II" Then
            border = 77
        ElseIf ListBox1.SelectedItem = "Zane Border" Then
            border = 68
        ElseIf ListBox1.SelectedItem = "Zexal Border" Then
            border = 69
        ElseIf ListBox1.SelectedItem = "The Colorful Border" Then
            border = 70
        ElseIf ListBox1.SelectedItem = "Sherry LeBlanc Border" Then
            border = 73
        ElseIf ListBox1.SelectedItem = "Baby Dragon Border" Then
            border = 74
        ElseIf ListBox1.SelectedItem = "Guts Border" Then
            border = 75
        ElseIf ListBox1.SelectedItem = "Hata no Kokoro Border I" Then
            border = 78
        ElseIf ListBox1.SelectedItem = "Hata no Kokoro Border II" Then
            border = 79
        ElseIf ListBox1.SelectedItem = "PowerPuff Girls Border" Then
            border = 80
        ElseIf ListBox1.SelectedItem = "Reimu Hakurei Border I" Then
            border = 81
        ElseIf ListBox1.SelectedItem = "Reimu Hakurei Border II" Then
            border = 82
        ElseIf ListBox1.SelectedItem = "Sakuya Izayoi Border I" Then
            border = 83
        ElseIf ListBox1.SelectedItem = "Sakuya Izayoi Border II" Then
            border = 84
        ElseIf ListBox1.SelectedItem = "Totally Spies Border" Then
            border = 85
        ElseIf ListBox1.SelectedItem = "Bakura Border I" Then
            border = 86
        ElseIf ListBox1.SelectedItem = "Bakura Border II" Then
            border = 87
        ElseIf ListBox1.SelectedItem = "Christmas Border I" Then
            border = 88
        ElseIf ListBox1.SelectedItem = "Christmas Border II" Then
            border = 89
        ElseIf ListBox1.SelectedItem = "Christmas Border III" Then
            border = 90
        ElseIf ListBox1.SelectedItem = "Christmas Border IV" Then
            border = 91
        ElseIf ListBox1.SelectedItem = "Christmas Border V" Then
            border = 92
        ElseIf ListBox1.SelectedItem = "Christmas Border VI" Then
            border = 93
        ElseIf ListBox1.SelectedItem = "Ishizu Border I" Then
            border = 94
        ElseIf ListBox1.SelectedItem = "Ishizu Border II" Then
            border = 95
        ElseIf ListBox1.SelectedItem = "Lazar Border" Then
            border = 96
        ElseIf ListBox1.SelectedItem = "Mai Border I" Then
            border = 97
        ElseIf ListBox1.SelectedItem = "Mai Border II" Then
            border = 98
        ElseIf ListBox1.SelectedItem = "Mai Border III" Then
            border = 99
        ElseIf ListBox1.SelectedItem = "Mako Border" Then
            border = 100
        ElseIf ListBox1.SelectedItem = "Marik Border I" Then
            border = 101
        ElseIf ListBox1.SelectedItem = "Marik Border II" Then
            border = 102
        ElseIf ListBox1.SelectedItem = "Odion Border" Then
            border = 103
        ElseIf ListBox1.SelectedItem = "Pegasus Border" Then
            border = 104
        ElseIf ListBox1.SelectedItem = "Reji Border" Then
            border = 105
        ElseIf ListBox1.SelectedItem = "Thief King Border I" Then
            border = 106
        ElseIf ListBox1.SelectedItem = "Thief King Border II" Then
            border = 107
        ElseIf ListBox1.SelectedItem = "Yori Border" Then
            border = 108
        ElseIf ListBox1.SelectedItem = "Yubel Border" Then
            border = 109
        ElseIf ListBox1.SelectedItem = "Yami Border I" Then
            border = 110
        ElseIf ListBox1.SelectedItem = "Yami Border II" Then
            border = 111
        ElseIf ListBox1.SelectedItem = "Yami Border III" Then
            border = 112
        ElseIf ListBox1.SelectedItem = "Yami Border IV" Then
            border = 113
        ElseIf ListBox1.SelectedItem = "Yami Border V" Then
            border = 114
        ElseIf ListBox1.SelectedItem = "Yugo Border" Then
            border = 115
        ElseIf ListBox1.SelectedItem = "Yusei Border I" Then
            border = 116
        ElseIf ListBox1.SelectedItem = "Yusei Border II" Then
            border = 117
        ElseIf ListBox1.SelectedItem = "Yuto Border I" Then
            border = 118
        ElseIf ListBox1.SelectedItem = "Yuto Border II" Then
            border = 119
        ElseIf ListBox1.SelectedItem = "Yuto Border III" Then
            border = 120
        ElseIf ListBox1.SelectedItem = "Suzaku Kururugii Border" Then
            border = 121
        ElseIf ListBox1.SelectedItem = "Pinkie Pie Border" Then
            border = 122
        ElseIf ListBox1.SelectedItem = "Yubelious! Border" Then
            border = 123
        ElseIf ListBox1.SelectedItem = "Utopia God Border" Then
            border = 124
        ElseIf ListBox1.SelectedItem = "Jeduraiya Border" Then
            border = 125
        ElseIf ListBox1.SelectedItem = "IronDragonSlayer Border" Then
            border = 126
        ElseIf ListBox1.SelectedItem = "Cavallier Border" Then
            border = 127
        ElseIf ListBox1.SelectedItem = "Motoko Border" Then
            border = 128
        ElseIf ListBox1.SelectedItem = "Nep-Nep Border" Then
            border = 129
        ElseIf ListBox1.SelectedItem = "Diablox73 Border" Then
            border = 130
        ElseIf ListBox1.SelectedItem = "CottonBuds Border" Then
            border = 131
        ElseIf ListBox1.SelectedItem = "raditz Border" Then
            border = 132
        ElseIf ListBox1.SelectedItem = "DeharaRules Border" Then
            border = 133
        ElseIf ListBox1.SelectedItem = "SupremeKingOfGames Border" Then
            border = 134
        ElseIf ListBox1.SelectedItem = "Divine Halo Border I" Then
            border = 135
        ElseIf ListBox1.SelectedItem = "n00b_of_legend Border" Then
            border = 136
        ElseIf ListBox1.SelectedItem = "MeiMei Border" Then
            border = 137
        ElseIf ListBox1.SelectedItem = "Old Yama Border" Then
            border = 138
        ElseIf ListBox1.SelectedItem = "Astrike7 Border" Then
            border = 139
        ElseIf ListBox1.SelectedItem = "leonesshadow Border" Then
            border = 140
        ElseIf ListBox1.SelectedItem = "Cloudie Border" Then
            border = 141
        ElseIf ListBox1.SelectedItem = "BreadedShark Border" Then
            border = 142
        ElseIf ListBox1.SelectedItem = "casx Border" Then
            border = 143
        ElseIf ListBox1.SelectedItem = "TigranxDaddy Border" Then
            border = 144
        ElseIf ListBox1.SelectedItem = "theoldman Border" Then
            border = 145
        ElseIf ListBox1.SelectedItem = "Heralds Border" Then
            border = 146
        ElseIf ListBox1.SelectedItem = "Lotus Border" Then
            border = 147
        ElseIf ListBox1.SelectedItem = "Kor Saiyajinkami Border" Then
            border = 148
        ElseIf ListBox1.SelectedItem = "AbyssDuelist Border" Then
            border = 149
        ElseIf ListBox1.SelectedItem = "duke_of_dice Border" Then
            border = 150
        ElseIf ListBox1.SelectedItem = "Shindou Yuuki Border" Then
            border = 151
        ElseIf ListBox1.SelectedItem = "Kamyu Border" Then
            border = 152
        ElseIf ListBox1.SelectedItem = "Shén-MörderX Border" Then
            border = 153
        ElseIf ListBox1.SelectedItem = "JaemReach Border I" Then
            border = 154
        ElseIf ListBox1.SelectedItem = "ShaddollWendigo Border" Then
            border = 155
        ElseIf ListBox1.SelectedItem = "Specialiskid1 Border" Then
            border = 156
        ElseIf ListBox1.SelectedItem = "Melibell Border I" Then
            border = 157
        ElseIf ListBox1.SelectedItem = "Unixez Border" Then
            border = 158
        ElseIf ListBox1.SelectedItem = "Melibell Border II" Then
            border = 159
        ElseIf ListBox1.SelectedItem = "Melibell Border III" Then
            border = 160
        ElseIf ListBox1.SelectedItem = "Pumpkinstraw09 Border" Then
            border = 161
        ElseIf ListBox1.SelectedItem = "Magician7 Border" Then
            border = 162
        ElseIf ListBox1.SelectedItem = "Zappy Border" Then
            border = 163
        ElseIf ListBox1.SelectedItem = "ThePROtagonist Border" Then
            border = 164
        ElseIf ListBox1.SelectedItem = "Divine Halo Border II" Then
            border = 165
        ElseIf ListBox1.SelectedItem = "Amine Border I" Then
            border = 166
        ElseIf ListBox1.SelectedItem = "Amine Border II" Then
            border = 167
        ElseIf ListBox1.SelectedItem = "Amine Border III" Then
            border = 168
        ElseIf ListBox1.SelectedItem = "WindMillCrow Border" Then
            border = 169
        ElseIf ListBox1.SelectedItem = "JaemReach Border II" Then
            border = 170
        End If

        Try
            PictureBox1.Image = Image.FromFile("YGOPRO\textures\borders\" & border & ".png")
            PictureBox2.Image = Image.FromFile("YGOPRO\textures\borders\" & border & " 2.png")

            Label62.Text = "Border: " & ListBox1.SelectedItem
            If borderList.Contains(border) Then
                Label67.Text = "Owned"
                Label67.ForeColor = Color.LightGreen
            Else
                Label67.Text = "Not Owned"
                Label67.ForeColor = Color.Red
            End If
        Catch
        End Try
    End Sub

    Public Sub LoadBorders(myBorder, borders)
        borderList.Clear()
        borderList.Add(0)

        If Launcher.Rank = "Gold Member" Then
            borderList.Add(1)
        End If
        If Launcher.Rank = "Platinum Member" Then
            borderList.Add(1)
            borderList.Add(2)
        End If
        If Launcher.Rank = "Diamond Member" Then
            borderList.Add(1)
            borderList.Add(2)
            borderList.Add(3)
        End If
        If Launcher.Rank = "Moderator" Then
            borderList.Add(22)
        End If
        If Launcher.Rank = "Global Moderator" Then
            borderList.Add(25)
        End If
        If Launcher.Rank = "FBI" Then
            borderList.Add(27)
        End If
        If Launcher.Rank = "Administrator" Then
            borderList.Add(28)
        End If
        If Launcher.Rank = "Owner" Then
            borderList.Add(29)
        End If
        If Launcher.LunarLantern = 1 Then
            borderList.Add(8)
        End If
        If Launcher.HeartOfFire = 1 Then
            borderList.Add(9)
        End If

        If borders <> "" Then
            Dim sParts() As String = Split(borders, ",")
            For Each border As Integer In sParts
                borderList.Add(border)
            Next
        End If

        Try
            ChDir(Launcher.Current)
            PictureBox1.Image = Image.FromFile("YGOPRO\textures\borders\" & myBorder & ".png")
            PictureBox2.Image = Image.FromFile("YGOPRO\textures\borders\" & myBorder & " 2.png")

            Label62.Text = "Current Border"
            Label67.Text = "Owned"
            Label67.ForeColor = Color.LightGreen
        Catch
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim email As String = InputBox("Please enter your email address:", "Email Address")
        If email = "" Then
            Return
        End If
        Launcher.SendToServer("RequestEmailVerification<{]>" & email)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If VerificationCode.Text = "" Then
            MsgBox("Please enter a verification code!")
            Return
        End If

        Launcher.SendToServer("EmailVerification<{]>" & VerificationCode.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Set_Title.ComboBox1.Text = Launcher.MyTitle

        Set_Title.ComboBox1.Items.Clear()
        For Each title As String In titleList
            If Set_Title.ComboBox1.Items.Contains(title) = False Then
                Set_Title.ComboBox1.Items.Add(title)
            End If
        Next

        If Launcher.customTitle = "1" Then
            Set_Title.ComboBox1.Items.Add("Custom")
        End If

        If titleList.Contains(Launcher.MyTitle) = False Then
            Set_Title.ComboBox1.Text = "Custom"
        Else
            Set_Title.ComboBox1.Text = Launcher.MyTitle
        End If

        Set_Title.Show()
    End Sub

    Public Sub UpdateProfile(ByVal close As Boolean)
        If ComboBox1.Text = "Male" Or ComboBox1.Text = "Female" Then
            If avatarURLTxt.Text <> "" Or cardBackURLTxt.Text <> "" Then
                If Launcher.achievements.Contains(0) = False Then
                    Launcher.AddAchievement(Launcher.Username, 0, 0)
                    Launcher.achievements.Add(0)
                End If
            End If
            If titleList.Contains(Label82.Text) Then
                newTitle = Label82.Text
                Launcher.MyTitle = Label82.Text
            ElseIf Launcher.customTitle = "1" Then
                If Label82.Text = "" Or Label82.Text = "<>" Then
                    newTitle = "None"
                    Launcher.MyTitle = "None"
                Else
                    newTitle = Label82.Text
                    Launcher.MyTitle = Label82.Text
                End If
            Else
                newTitle = "None"
                Launcher.MyTitle = "None"
            End If
            Launcher.UpdateProfile(ComboBox1.Text, Val(NumericUpDown1.Text), TextBox2.Text, TextBox4.Text, TextBox6.Text, TextBox5.Text, TextBox7.Text, avatarURLTxt.Text, cardBackURLTxt.Text, RichTextBox1.Text, newTitle)
            If close = True Then
                Hide()
            End If
        Else
            MsgBox("Gender must be Male or Female!")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Set_Chat_Color.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ChangePassword.Show()
    End Sub

    Public Sub LoadDecks()
        Try
            ChDir(Launcher.Current)
            Dim di As New IO.DirectoryInfo(Launcher.Current & "\YGOPRO\deck\")
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            For Each dra In diar1
                Dim newDeck As String = dra.ToString
                newDeck = newDeck.Substring(0, newDeck.Length - 4)

                defaultDeck.Items.Add(newDeck)
            Next

            Try
                defaultDeck.Text = defaultDeck.Items(0)
            Catch
                defaultDeck.Text = "Error - No Decks"
            End Try
        Catch
            MsgBox("Error 2000: There was a problem loading your deck list!")
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Settings.DefaultDeck = defaultDeck.SelectedItem
        My.Settings.Save()

        MsgBox("Default Deck Updated!")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If friendList.SelectedIndex <> -1 Then
            Launcher.RequestProfile(friendList.SelectedItem)
        Else
            MsgBox("Please select a friend!")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If friendList.SelectedIndex <> -1 Then
            If Launcher.Mute <> 0 Then
                MsgBox("You are muted!")
                Return
            End If

            If Launcher.ListBox1.Items.Contains(friendList.SelectedItem) = False Then
                MsgBox("User is offline!")
                Return
            End If

            Launcher.CreatePrivateChat(friendList.SelectedItem)
        Else
            MsgBox("Please select a friend!")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If friendList.SelectedIndex <> -1 Then
            Launcher.SendToServer("RmvFrnd" & "<{]>" & Launcher.Username & "<{]>" & friendList.SelectedItem)
            Launcher.ListBox2.Items.Remove(friendList.SelectedItem)
            friendList.Items.Remove(friendList.SelectedItem)
        Else
            MsgBox("Please select a friend!")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If ignoreList.SelectedIndex <> -1 Then
            Launcher.RequestProfile(ignoreList.SelectedItem)
        Else
            MsgBox("Please select one of the ignored users!")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        If ignoreList.SelectedIndex <> -1 Then
            Launcher.CreatePrivateChat(ignoreList.SelectedItem)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If ignoreList.SelectedIndex <> -1 Then
            Launcher.SendToServer("RmvIgnore" & "<{]>" & ignoreList.SelectedItem)
            Try
                Launcher.ignoreList.Remove(ignoreList.SelectedItem)
                ignoreList.Items.Remove(ignoreList.SelectedItem)
            Catch
            End Try
        Else
            MsgBox("Please select one of the ignored users!")
        End If
    End Sub

    Private Sub ignoreCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ignoreCheckBox.CheckedChanged
        If ignoreCheckBox.Checked = True Then
            chatMessage2.Text = ""
            chatMessage2.ReadOnly = False
        Else
            chatMessage2.Text = ""
            chatMessage2.ReadOnly = True
            Launcher.ignoreMessage = ""
            Launcher.SendToServer("UpdateIgnoreMessage" & Launcher.Splitter)
        End If
    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        friendList.Items.Clear()
        ignoreList.Items.Clear()

        For Each user As String In Launcher.ListBox2.Items
            friendList.Items.Add(user)
        Next

        For Each user As String In Launcher.ignoreList
            ignoreList.Items.Add(user)
        Next

        If Launcher.ignoreMessage = "" Then
            chatMessage2.ReadOnly = True
        Else
            ignoreCheckBox.Checked = True
            chatMessage2.Text = Launcher.ignoreMessage
        End If

        If Launcher.AvatarItem = 0 Then
            avatarURLTxt.Enabled = False
        End If
        If Launcher.CardBackItem = 0 Then
            cardBackURLTxt.Enabled = False
        End If

        If Launcher.Username = "*Luna*" Then
            ListBox1.Items.Add("Luna Border I")
            ListBox1.Items.Add("Luna Border II")
            ListBox1.Items.Add("Luna Border III")
            ListBox1.Items.Add("Luna Border IV")
        End If
        If Launcher.Username = "Sherry LeBlanc" Then
            ListBox1.Items.Add("Sherry LeBlanc Border")
        End If
        If Launcher.Username = "Baby Dragon" Then
            ListBox1.Items.Add("Baby Dragon Border")
        End If
        If Launcher.Username = "Guts" Then
            ListBox1.Items.Add("Guts Border")
        End If
        If Launcher.Username = "Suzaku Kururugii" Then
            ListBox1.Items.Add("Suzaku Kururugii Border")
        End If
        If Launcher.Username = "Yubelious!" Then
            ListBox1.Items.Add("Yubelious! Border")
        End If
        If Launcher.Username = "Utopia God" Then
            ListBox1.Items.Add("Utopia God Border")
        End If
        If Launcher.Username = "Jeduraiya" Then
            ListBox1.Items.Add("Jeduraiya Border")
        End If
        If Launcher.Username = "IronDragonSlayer" Then
            ListBox1.Items.Add("IronDragonSlayer Border")
        End If
        If Launcher.Username = "Cavallier" Then
            ListBox1.Items.Add("Cavallier Border")
        End If
        If Launcher.Username = "Motoko" Then
            ListBox1.Items.Add("Motoko Border")
        End If
        If Launcher.Username = "Nep-Nep" Then
            ListBox1.Items.Add("Nep-Nep Border")
        End If
        If Launcher.Username = "Diablox73" Then
            ListBox1.Items.Add("Diablox73 Border")
        End If
        If Launcher.Username = "CottonBuds" Then
            ListBox1.Items.Add("CottonBuds Border")
        End If
        If Launcher.Username = "raditz" Then
            ListBox1.Items.Add("raditz Border")
        End If
        If Launcher.Username = "DeharaRules" Then
            ListBox1.Items.Add("DeharaRules Border")
        End If
        If Launcher.Username = "SupremeKingOfGames" Then
            ListBox1.Items.Add("SupremeKingOfGames Border")
        End If
        If Launcher.Username = "Divine Halo" Then
            ListBox1.Items.Add("Divine Halo Border I")
            ListBox1.Items.Add("Divine Halo Border II")
        End If
        If Launcher.Username = "n00b_of_legend" Then
            ListBox1.Items.Add("n00b_of_legend Border")
        End If
		If Launcher.Username = "MeiMei" Then
            ListBox1.Items.Add("MeiMei Border")
        End If
		If Launcher.Username = "Old Yama" Then
            ListBox1.Items.Add("Old Yama Border")
        End If
        If Launcher.Username = "Astrike7" Then
            ListBox1.Items.Add("Astrike7 Border")
        End If
        If Launcher.Username = "leonesshadow" Then
            ListBox1.Items.Add("leonesshadow Border")
        End If
        If Launcher.Username = "Cloudie" Then
            ListBox1.Items.Add("Cloudie Border")
        End If
		If Launcher.Username = "BreadedShark" Then
            ListBox1.Items.Add("BreadedShark Border")
        End If
		If Launcher.Username = "casx" Then
            ListBox1.Items.Add("casx Border")
        End If
        If Launcher.Username = "TigranxDaddy" Then
            ListBox1.Items.Add("TigranxDaddy Border")
        End If
        If Launcher.Username = "theoldman" Then
            ListBox1.Items.Add("theoldman Border")
        End If
        If Launcher.Username = "Heralds" Then
            ListBox1.Items.Add("Heralds Border")
        End If
        If Launcher.Username = "Lotus" Then
            ListBox1.Items.Add("Lotus Border")
        End If
        If Launcher.Username = "Kor Saiyajinkami" Then
            ListBox1.Items.Add("Kor Saiyajinkami Border")
        End If
        If Launcher.Username = "AbyssDuelist" Then
            ListBox1.Items.Add("AbyssDuelist Border")
        End If
        If Launcher.Username = "duke_of_dice" Then
            ListBox1.Items.Add("duke_of_dice Border")
        End If
        If Launcher.Username = "Shindou Yuuki" Then
            ListBox1.Items.Add("Shindou Yuuki Border")
        End If
        If Launcher.Username = "Kamyu" Then
            ListBox1.Items.Add("Kamyu Border")
        End If
        If Launcher.Username = "Shén-MörderX" Then
            ListBox1.Items.Add("Shén-MörderX Border")
        End If
        If Launcher.Username = "JaemReach" Then
            ListBox1.Items.Add("JaemReach Border I")
            ListBox1.Items.Add("JaemReach Border II")
        End If
        If Launcher.Username = "ShaddollWendigo" Then
            ListBox1.Items.Add("ShaddollWendigo Border")
        End If
        If Launcher.Username = "Specialiskid1" Then
            ListBox1.Items.Add("Specialiskid1 Border")
        End If
        If Launcher.Username = "Melibell" Then
            ListBox1.Items.Add("Melibell Border I")
            ListBox1.Items.Add("Melibell Border II")
            ListBox1.Items.Add("Melibell Border III")
        End If
        If Launcher.Username = "Unixez" Then
            ListBox1.Items.Add("Unixez Border")
        End If
        If Launcher.Username = "Pumpkinstraw09" Then
            ListBox1.Items.Add("Pumpkinstraw09 Border")
        End If
		If Launcher.Username = "Magician7" Then
            ListBox1.Items.Add("Magician7 Border")
        End If
        If Launcher.Username = "Zappy" Then
            ListBox1.Items.Add("Zappy Border")
        End If
        If Launcher.Username = "ThePROtagonist" Then
            ListBox1.Items.Add("ThePROtagonist Border")
        End If
        If Launcher.Username = "Amine" Then
            ListBox1.Items.Add("Amine Border I")
            ListBox1.Items.Add("Amine Border II")
            ListBox1.Items.Add("Amine Border III")
        End If
        If Launcher.Username = "WindMillCrow" Then
            ListBox1.Items.Add("WindMillCrow Border")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If CheckBannedWords.CheckSwearingAdvertising(chatMessage2.Text) = False Then
            Return
        End If

        Launcher.ignoreMessage = chatMessage2.Text
        Launcher.SendToServer("UpdateIgnoreMessage" & Launcher.Splitter & chatMessage2.Text)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            PictureBox7.Size = New Size(3, 6)
        Else
            PictureBox7.Size = New Size(3, 19)
        End If
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        If Launcher.customPrivateChat = 1 Then
            Custom_Private_Chat.Show()
        Else
            MsgBox("You are not able to use custom private chat, please check the store for more details!")
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