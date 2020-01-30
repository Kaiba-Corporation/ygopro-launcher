Public Class DeckProfileUC

    Public id As Integer
    Public deckName As String
    Public downloads As String
    Public positiveRating As Integer
    Public negativeRating As Integer
    Public ratedByMe As Boolean = True
    Public deckType As String
    Public sharedWith As String
    Public datePosted As String
    Public banlist As String
    Public uploadedBy As String
    Public description As String

    Public featuredImage As Image

    Private Sub ClickOnElement(sender As Object, e As EventArgs) Handles Panel2.Click, Panel4.Click, Panel5.Click, Panel6.Click, Panel8.Click, featuredImagePictureBox.Click, deckNameTxt.Click, RatingTxt.Click
        CommunityCenter.deckName.Text = "Deck Name: " & deckName
        CommunityCenter.rating.Text = RatingTxt.Text
        If RatingTxt.Text <> "Rating: Not Rated" Then
            CommunityCenter.rating.Text = CommunityCenter.rating.Text & " Rated By: " & positiveRating + negativeRating
        End If

        CommunityCenter.deckId.Text = id
        CommunityCenter.deckType.Text = "Deck Type: " & deckType
        CommunityCenter.downloads.Text = "Downloads: " & downloads
        CommunityCenter.sharedWith.Text = "Uploaded By: " & uploadedBy
        CommunityCenter.datePosted.Text = "Date Posted: " & datePosted
        CommunityCenter.banlist.Text = "Banlist: " & banlist
        CommunityCenter.deckDescription.Text = description

        CommunityCenter.deckFeaturedImage.Image = featuredImage

        If (uploadedBy = Launcher.Username) Or (Launcher.Rank <> "Player" And Launcher.Rank <> "Gold Member" And Launcher.Rank <> "Platinum Member" And Launcher.Rank <> "Diamond Member") Then
            CommunityCenter.RemoveBtn.Visible = True
        Else
            CommunityCenter.RemoveBtn.Visible = False
        End If

        If ratedByMe = False Then
            CommunityCenter.LikeBtn.Visible = True
            CommunityCenter.DislikeBtn.Visible = True
        Else
            CommunityCenter.LikeBtn.Visible = False
            CommunityCenter.DislikeBtn.Visible = False
        End If

        CommunityCenter.HideDeckInfo.Visible = False
    End Sub

    Public Sub UpdateRating()
        If (positiveRating + negativeRating) = 0 Then
            RatingTxt.Text = "Rating: Not Rated"
        Else
            Dim rating As Integer = (positiveRating / (positiveRating + negativeRating)) * 100
            RatingTxt.Text = "Rating: " & rating & "%"
        End If

        CommunityCenter.rating.Text = RatingTxt.Text
        If RatingTxt.Text <> "Rating: Not Rated" Then
            CommunityCenter.rating.Text = CommunityCenter.rating.Text & " Rated By: " & positiveRating + negativeRating
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        For Each DeckProfile In CommunityCenter.DeckProfileList
            DeckProfile.Panel4.BackColor = Color.Cyan
            DeckProfile.Panel5.BackColor = Color.Cyan
            DeckProfile.Panel6.BackColor = Color.Cyan
            DeckProfile.Panel8.BackColor = Color.Cyan
            DeckProfile.deckNameTxt.ForeColor = Color.Cyan
            DeckProfile.RatingTxt.ForeColor = Color.Cyan
        Next

        Panel4.BackColor = Color.Crimson
        Panel5.BackColor = Color.Crimson
        Panel6.BackColor = Color.Crimson
        Panel8.BackColor = Color.Crimson
        deckNameTxt.ForeColor = Color.Crimson
        RatingTxt.ForeColor = Color.Crimson
    End Sub

    Public Sub RevertColor()
        Panel4.BackColor = Color.Cyan
        Panel5.BackColor = Color.Cyan
        Panel6.BackColor = Color.Cyan
        Panel8.BackColor = Color.Cyan
        deckNameTxt.ForeColor = Color.Cyan
        RatingTxt.ForeColor = Color.Cyan
    End Sub

    Public Function CalculateNextLocation(currentLocation As String)
        Dim newLocation As String = "17, 50"

        If currentLocation = "17, 50" Then
            newLocation = "130, 50"
        ElseIf currentLocation = "130, 50" Then
            newLocation = "243, 50"
        ElseIf currentLocation = "243, 50" Then
            newLocation = "356, 50"
        ElseIf currentLocation = "356, 50" Then
            newLocation = "469, 50"
        ElseIf currentLocation = "469, 50" Then
            newLocation = "17, 202"
        ElseIf currentLocation = "17, 202" Then
            newLocation = "130, 202"
        ElseIf currentLocation = "130, 202" Then
            newLocation = "243, 202"
        ElseIf currentLocation = "243, 202" Then
            newLocation = "356, 202"
        ElseIf currentLocation = "356, 202" Then
            newLocation = "469, 202"
        ElseIf currentLocation = "469, 202" Then
            newLocation = "17, 354"
        ElseIf currentLocation = "17, 354" Then
            newLocation = "130, 354"
        ElseIf currentLocation = "130, 354" Then
            newLocation = "243, 354"
        ElseIf currentLocation = "243, 354" Then
            newLocation = "356, 354"
        ElseIf currentLocation = "356, 354" Then
            newLocation = "469, 354"
        End If

        Return newLocation
    End Function
End Class
