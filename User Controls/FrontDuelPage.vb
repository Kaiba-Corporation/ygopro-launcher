Public Class FrontDuelPage

    Dim questionList As New List(Of String)
    Dim answerList As New List(Of String)
    Private Sub SinglePlayer_MouseMove(sender As Object, e As MouseEventArgs) Handles SinglePlayer.MouseMove
        SinglePlayer.Image = My.Resources.SinglePlayerR
        SinglePlayer.Tag = "R"

        If PvP.Tag = "R" Then
            PvP.Image = My.Resources.PvPB
            PvP.Tag = ""
        End If
        Buttons1.ResetButtons()
    End Sub

    Private Sub PvP_MouseMove(sender As Object, e As MouseEventArgs) Handles PvP.MouseMove
        PvP.Image = My.Resources.PvPR
        PvP.Tag = "R"

        If SinglePlayer.Tag = "R" Then
            SinglePlayer.Image = My.Resources.SinglePlayerB
            SinglePlayer.Tag = ""
        End If
        Buttons1.ResetButtons()
    End Sub

    Private Sub FrontDuelPage_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ResetButtons()
        Buttons1.ResetButtons()
    End Sub

    Private Sub Buttons1_MouseMove(sender As Object, e As MouseEventArgs) Handles Buttons1.MouseMove, PictureBox1.MouseMove
        ResetButtons()
    End Sub

    Public Sub ResetButtons()
        If SinglePlayer.Tag = "R" Then
            SinglePlayer.Image = My.Resources.SinglePlayerB
            SinglePlayer.Tag = ""
        End If
        If PvP.Tag = "R" Then
            PvP.Image = My.Resources.PvPB
            PvP.Tag = ""
        End If
    End Sub

    Private Sub SinglePlayer_Click(sender As Object, e As EventArgs) Handles SinglePlayer.Click
        Launcher.singlePlayerDuelPage = New SinglePlayerDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.singlePlayerDuelPage)
        Me.Dispose()
    End Sub

    Private Sub PvP_Click(sender As Object, e As EventArgs) Handles PvP.Click
        Launcher.pvpDuelPage = New PvPDuelPage
        Launcher.DuelPanel.Controls.Add(Launcher.pvpDuelPage)
        Me.Dispose()
    End Sub

    Private Sub FrontDuelPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        questionList.Add("Brother , I want a card like Kalut but for my Light monsters!")
        questionList.Add("Hey Skull , How do you beat Tower?")
        questionList.Add("Whats a good card for an OTK deck?")
        questionList.Add("Need a card to stop Justice Dragon?")
        questionList.Add("What do I do when my fields empty and my opponent's isnt?")
        questionList.Add("Ever dueled a good Nekroz deck and won?")
        questionList.Add("I really wanna gain some Gold , help me out?")
        questionList.Add("Hey Skull , whats the deck of the day ")
        questionList.Add("Lost a duel the other day, devastated..")
        questionList.Add("Deck of the Day , Oh wise Mr.Skull?")
        questionList.Add("Can I duel my relative in the same house in a ranked duel?")
        questionList.Add("Do you think we're being watched while we duel?")
        questionList.Add("Strong defence against a meta deck?")
        questionList.Add("In a tough bind in a duel?")
        questionList.Add("How do I stop all these indestructable synchros?")
        questionList.Add("Whatever Skull says is the truth!")
        questionList.Add("Hey, what was your first card?")
        questionList.Add("Hey Skull, what do J.A.R.V.I.S and I have in common?")
        questionList.Add("Ohh Skull, How do i make a forum account??")
        questionList.Add("Hey Skull, What happens if I hold S while dueling?")

        answerList.Add("Honest-ly , I wouldn't even know!")
        answerList.Add("Well Skell, You don't , You survive it!")
        answerList.Add("Two words , Ben Kei!")
        answerList.Add("Try putting Light Imprisoning Mirror in your deck!")
        answerList.Add("Top deck like crazy!!!")
        answerList.Add("Yeah , but then I woke up!")
        answerList.Add("Keep duelling my friend , gain gold whether you lose or win.")
        answerList.Add("Blackwings , Blackwings Everywhere")
        answerList.Add("Chin up! You could've ended up like us!")
        answerList.Add("Naturia , Naturia Everywhere!")
        answerList.Add("I strongly suggest you don't.")
        answerList.Add("If you count Jarvis stalking your every move, then yes.")
        answerList.Add("Simple, anti- meta!")
        answerList.Add("Let the duel spirits guide you!")
        answerList.Add("Well my friend, welcome to XYZ 101!!")
        answerList.Add("Whatever Skell says is a lie!")
        answerList.Add("uhm...King of Skull..")
        answerList.Add("No Heart!")
        answerList.Add("Simple , use your in-game account to log into the forum!")
        answerList.Add("Game won't ask you to activate your effects!")

        Dim rn As New Random
        Dim result As Integer = rn.Next(0, 20)

        questionTxt.Text = questionList(result)
        answerTxt.Text = answerList(result)
    End Sub
End Class
