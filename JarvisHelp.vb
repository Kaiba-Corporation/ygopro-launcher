Module JarvisHelp
    Public Sub ChangeSection(ByVal newSection As String)
        CommunityCenter.helpQuestion.Items.Clear()

        If newSection = "General" Then
            CommunityCenter.helpQuestion.Items.Add("How do I make a deck?")
            CommunityCenter.helpQuestion.Items.Add("How do I duel?")
            CommunityCenter.helpQuestion.Items.Add("How do I earn gold?")
            CommunityCenter.helpQuestion.Items.Add("How do I level up and earn XP?")
            CommunityCenter.helpQuestion.Items.Add("How do I add a friend?")
            CommunityCenter.helpQuestion.Items.Add("How do I change the game music?")
            CommunityCenter.helpQuestion.Items.Add("How do I change the textures of my game?")
            CommunityCenter.helpQuestion.Items.Add("How do I make a Forum account?")
            CommunityCenter.helpQuestion.Items.Add("Where can I find the terms of service?")
        ElseIf newSection = "Dueling" Then
            CommunityCenter.helpQuestion.Items.Add("How do I challenge other players?")
            CommunityCenter.helpQuestion.Items.Add("How do I mute opponents/spectators?")
            CommunityCenter.helpQuestion.Items.Add("How do ranking stars work?")
            CommunityCenter.helpQuestion.Items.Add("How do I save a replay?")
            CommunityCenter.helpQuestion.Items.Add("What is the difference between Single, Match and Tag Duels?")
            CommunityCenter.helpQuestion.Items.Add("What is the difference between Unranked and Ranked Duels?")
        ElseIf newSection = "Teams" Then
            CommunityCenter.helpQuestion.Items.Add("How do I make a team?")
            CommunityCenter.helpQuestion.Items.Add("How do I delete a team?")
            CommunityCenter.helpQuestion.Items.Add("How do I leave a team?")
            CommunityCenter.helpQuestion.Items.Add("How do I invite people to join my team?")
            CommunityCenter.helpQuestion.Items.Add("How do I kick people from my team?")
            CommunityCenter.helpQuestion.Items.Add("How do I set the team profile picture?")
            CommunityCenter.helpQuestion.Items.Add("How do I use the team bank?")
        ElseIf newSection = "Errors" Then
            CommunityCenter.helpQuestion.Items.Add("YGOPRO.exe has stopped working!")
            CommunityCenter.helpQuestion.Items.Add("The system cannot find the file specified!")
            CommunityCenter.helpQuestion.Items.Add("Forum: The administrator is currently not accepting new membership registrations.")
        End If

        CommunityCenter.helpQuestion.SelectedIndex = 0
    End Sub

    Public Sub ChangeQuestion(ByVal newQuestion As String)
        If newQuestion = "How do I make a deck?" Then
            CommunityCenter.helpAnswer.Text = "You can create a deck by clicking the 'Decks' from the home page, a window should open where you can search for cards, click 'New Search' and a list of cards will appear. If you want to save a new deck enter the name in the box to the left of 'Save As', then click 'Save As'. If you just want to save changes to a current deck then click 'Save'."
        ElseIf newQuestion = "How do I duel?" Then
            CommunityCenter.helpAnswer.Text = "You can duel by clicking 'Duel' from the home page, then follow the on-screen instructions and chose which form of a duel do you want to play."
        ElseIf newQuestion = "How do I earn gold?" Then
            CommunityCenter.helpAnswer.Text = "Your earn Gold from playing singleplayer and multiplayer games."
        ElseIf newQuestion = "How do I level up and earn XP?" Then
            CommunityCenter.helpAnswer.Text = "Your earn XP from playing singleplayer and multiplayer games, you level up when you reach enough XP for the next level, you can check how much XP you are missing by clicking 'Profile' from the home page."
        ElseIf newQuestion = "How do I add a friend?" Then
            CommunityCenter.helpAnswer.Text = "Right click a player's name in the chat and click 'Add Friend'."
        ElseIf newQuestion = "How do I change the game music?" Then
            CommunityCenter.helpAnswer.Text = "Click 'Customize' from the home page and then go to 'Sounds'."
        ElseIf newQuestion = "How do I change the textures of my game?" Then
            CommunityCenter.helpAnswer.Text = "Click 'Customize' from the home page, select the image you want to change and click on it, a window will pop-up asking you to select the new image from your computer."
        ElseIf newQuestion = "How do I make a Forum account?" Then
            CommunityCenter.helpAnswer.Text = "Your forum account is created automatically when you create your game account, use your game username and password to log in on the forum. If you changed your game password after creating your account, you must use your original password, if you can't remember your original password then create a ticket and a staff member will assist you."
        ElseIf newQuestion = "Where can I find the terms of service?" Then
            CommunityCenter.helpAnswer.Text = "You can find them here: http://ygopro.club/index.php?/topic/2602-yu-gi-oh-the-dawn-of-a-new-era-rules/"
        ElseIf newQuestion = "How do I challenge other players?" Then
            CommunityCenter.helpAnswer.Text = "Right click a player's name in the chat and click 'Challenge'."
        ElseIf newQuestion = "How do I mute opponents/spectators?" Then
            CommunityCenter.helpAnswer.Text = "In a duel click settings and select 'Mute Opponent'/'Mute Spectator'."
        ElseIf newQuestion = "How do ranking stars work?" Then
            CommunityCenter.helpAnswer.Text = "Your ranked star is displayed based on your current best rating from Single/Match/Tag, if your rating is under 1400 you will get a bronze star, 1400-1549 is silver, 1550-1699 is gold, 1700-1849 is platinum, 1850-1999 is diamond, 2000-2149 is master, 2150 and above is grand master. To get a full star you must pass the supreme qualification challenge."
        ElseIf newQuestion = "How do I save a replay?" Then
            CommunityCenter.helpAnswer.Text = "After a duel a tab should pop out asking you if you want to save the replay. Enter a name and click save you can access replays by going to home and clicking 'Replays'."
        ElseIf newQuestion = "What is the difference between Single, Match and Tag Duels?" Then
            CommunityCenter.helpAnswer.Text = "Single Duels are 1 game duels that is usually favored by players because it is the quickest. Match Duels are games that consist of 2-3 games, the winner is the person who wins 2 out of 3 games. Tag duels are 2v2 games, usually with 16000 life points."
        ElseIf newQuestion = "What is the difference between Unranked and Ranked Duels?" Then
            CommunityCenter.helpAnswer.Text = "You earn rating by playing ranked games, you do not earn rating for playing unranked games."
        ElseIf newQuestion = "How do I make a team?" Then
            CommunityCenter.helpAnswer.Text = "Click 'Teams' from the home page."
        ElseIf newQuestion = "How do I delete a team?" Then
            CommunityCenter.helpAnswer.Text = "Type /disbandteam in public chat"
        ElseIf newQuestion = "How do I leave a team?" Then
            CommunityCenter.helpAnswer.Text = "Type /leaveteam in chat"
        ElseIf newQuestion = "How do I invite people to join my team?" Then
            CommunityCenter.helpAnswer.Text = "Right click on the person's name and click invite."
        ElseIf newQuestion = "How do I kick people from my team?" Then
            CommunityCenter.helpAnswer.Text = "Go to team list and right click on the person's name that you want to kick and press kick."
        ElseIf newQuestion = "How do I set the team profile picture?" Then
            CommunityCenter.helpAnswer.Text = "Enter the image URL and click 'Save' in the team window."
        ElseIf newQuestion = "How do I use the team bank?" Then
            CommunityCenter.helpAnswer.Text = "Team bank is located in team window. You can deposit gold and the team leader can send gold to team members."
        ElseIf newQuestion = "YGOPRO.exe has stopped working!" Then
            CommunityCenter.helpAnswer.Text = "You must have an audio device plugged in, such as speakers or headphones, or have a virtual audio device installed."
        ElseIf newQuestion = "The system cannot find the file specified!" Then
            CommunityCenter.helpAnswer.Text = "YGOPRO.exe was erased, either by a corrupted installation or your anti-virus, re-installed the game and exlude the entire folder from being scanned."
        ElseIf newQuestion = "Forum: The administrator is currently not accepting new membership registrations." Then
            CommunityCenter.helpAnswer.Text = "Your forum account is created automatically when you create your game account, use your game username and password to log in on the forum. If you changed your game password after creating your account, you must use your original password, if you can't remember your original password then create a ticket and a staff member will assist you."
        End If
    End Sub
End Module
