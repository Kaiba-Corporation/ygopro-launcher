Imports System.IO

Public Class UploadDeck

    Dim mainDeck As New List(Of String)
    Dim extraDeck As New List(Of String)
    Dim sideDeck As New List(Of String)
    Dim cardList As New List(Of String)
    Dim fieldImageList As New List(Of String)
    Dim specialImageList As New List(Of String)

    Dim currentImageIndex As Integer = 0
    Dim currentFieldImageIndex As Integer = 0
    Dim currentSpecialImageIndex As Integer = 0

    Private Sub UploadDeck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeckList()
        CreateBanList()
        CreateFieldImageList()
        CreateSpecialImageList()
        LoadDeck()
        SetDefaults()
    End Sub

    Public Sub SetDefaults()
        featuredImage.Text = featuredImage.Items(0)
        deckType.Text = deckType.Items(0)
        shareWith.Text = shareWith.Items(0)
    End Sub

    Public Sub CreateBanList()
        banlist.Items.Clear()
        ChDir(Launcher.Current)

        Dim banlistFile As String
        If Launcher.launcherEdition = 2 Then
            banlistFile = Launcher.Current & "\YGOPRO\config\lflist.conf"
        Else
            banlistFile = Launcher.Current & "\YGOPRO\lflist.conf"
        End If

        If System.IO.File.Exists(banlistFile) = True Then
            Dim objReader As New System.IO.StreamReader(banlistFile)

            Do While objReader.Peek() <> -1
                Dim newLine As String = objReader.ReadLine

                Try
                    If newLine(0) = "!" Then
                        newLine = newLine.Remove(0, 1)
                        banlist.Items.Add(newLine)
                    End If
                Catch
                End Try
            Loop

            banlist.Items.Add("Other")
            banlist.Text = banlist.Items(0)
        Else
            MsgBox("Error 2002: Can't find the banlist file!")
        End If
    End Sub

    Public Sub CreateFieldImageList()
        Try
            ChDir(Launcher.Current)

            Dim pictureDirectory As String
            If Launcher.launcherEdition = 2 Then
                pictureDirectory = Launcher.Current & "\YGOPRO\picture\field\"
            Else
                pictureDirectory = Launcher.Current & "\YGOPRO\pics\field\"
            End If

            Dim di As New IO.DirectoryInfo(pictureDirectory)
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            For Each dra In diar1
                Dim newImage As String = dra.ToString
                fieldImageList.Add(newImage)
            Next
        Catch
            MsgBox("Error 2003: There was a problem loading your field image list!")
        End Try
    End Sub

    Public Sub CreateSpecialImageList()
        specialImageList.Add("cover.jpg")
        specialImageList.Add("Gold Member.jpg")
        specialImageList.Add("Platinium Member.jpg")
        specialImageList.Add("paper.jpg")
        specialImageList.Add("scissors.jpg")
        specialImageList.Add("stone.jpg")
        specialImageList.Add("unknown.jpg")

        If Launcher.Rank <> "Player" And Launcher.Rank <> "Gold Member" And Launcher.Rank <> "Platinum Member" And Launcher.Rank <> "Diamond Member" Then
            specialImageList.Add("Locator Card.jpg")
        End If
    End Sub

    Public Sub LoadDeck()
        ChDir(Launcher.Current)
        mainDeck.Clear()
        extraDeck.Clear()
        sideDeck.Clear()
        cardList.Clear()
        currentImageIndex = 0

        Dim selectedDeckName As String = selectDeck.Text
        If selectedDeckName.Length > 17 Then
            selectedDeckName = selectedDeckName.Remove(17)
        End If

        deckName.Text = selectedDeckName

        Dim deckFile As String = Launcher.Current & "\YGOPRO\deck\" & selectDeck.Text & ".ydk"

        If System.IO.File.Exists(deckFile) = True Then
            Dim objReader As New System.IO.StreamReader(deckFile)
            Dim currentDeckType As Integer = -1

            Do While objReader.Peek() <> -1
                Dim newLine As String = objReader.ReadLine

                If newLine = "#main" Then
                    currentDeckType = 0
                ElseIf newLine = "#extra" Then
                    currentDeckType = 1
                ElseIf newLine = "!side" Then
                    currentDeckType = 2
                Else
                    If currentDeckType = 0 Then
                        mainDeck.Add(newLine)
                    ElseIf currentDeckType = 1 Then
                        extraDeck.Add(newLine)
                    ElseIf currentDeckType = 2 Then
                        sideDeck.Add(newLine)
                    End If
                End If
            Loop
        Else
            MsgBox("Error 2001: File doesn't exist!")
        End If

        For Each card As String In mainDeck
            If cardList.Contains(card) = False Then
                cardList.Add(card)
            End If
        Next

        For Each card As String In extraDeck
            If cardList.Contains(card) = False Then
                cardList.Add(card)
            End If
        Next

        For Each card As String In sideDeck
            If cardList.Contains(card) = False Then
                cardList.Add(card)
            End If
        Next
    End Sub

    Public Sub SetImage(ByVal imageIndex As Integer)
        ChDir(Launcher.Current)

        Try
            If Launcher.launcherEdition = 2 Then
                If featuredImage.Text = "Card Image" Then
                    If File.Exists(Launcher.Current & "\YGOPRO\picture\card\" & cardList(imageIndex) & ".png") Then
                        deckImage.Image = Image.FromFile(Launcher.Current & "\YGOPRO\picture\card\" & cardList(imageIndex) & ".png")
                    ElseIf File.Exists(Launcher.Current & "\YGOPRO\picture\card\" & cardList(imageIndex) & ".jpg") Then
                        deckImage.Image = Image.FromFile(Launcher.Current & "\YGOPRO\picture\card\" & cardList(imageIndex) & ".jpg")
                    End If
                ElseIf featuredImage.Text = "Field Image" Then
                        deckImage.Image = Image.FromFile(Launcher.Current & "\YGOPRO\picture\field\" & fieldImageList(imageIndex))
                    ElseIf featuredImage.Text = "Special Image" Then
                        deckImage.Image = Image.FromFile(Launcher.Current & "\YGOPRO\texture\TDOANE\" & specialImageList(imageIndex))
                End If
            Else
                If featuredImage.Text = "Card Image" Then
                    deckImage.Image = Image.FromFile(Launcher.Current & "\YGOPRO\pics\" & cardList(imageIndex) & ".jpg")
                ElseIf featuredImage.Text = "Field Image" Then
                    deckImage.Image = Image.FromFile(Launcher.Current & "\YGOPRO\pics\field\" & fieldImageList(imageIndex))
                ElseIf featuredImage.Text = "Special Image" Then
                    deckImage.Image = Image.FromFile(Launcher.Current & "\YGOPRO\textures\" & specialImageList(imageIndex))
                End If
            End If
        Catch
            MsgBox("Error 2004: There was a problem loading the deck image!")
        End Try
    End Sub

    Public Sub LoadDeckList()
        Try
            ChDir(Launcher.Current)
            Dim di As New IO.DirectoryInfo(Launcher.Current & "\YGOPRO\deck\")
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            For Each dra In diar1
                Dim newDeck As String = dra.ToString
                newDeck = newDeck.Substring(0, newDeck.Length - 4)

                selectDeck.Items.Add(newDeck)
            Next

            Try
                selectDeck.Text = selectDeck.Items(0)
            Catch
                selectDeck.Text = "Error - No Decks"
                upload.Enabled = False
            End Try
        Catch
            MsgBox("Error 2000: There was a problem loading your deck list!")
            Me.Dispose()
        End Try
    End Sub

    Private Sub leftImageButton_Click(sender As Object, e As EventArgs) Handles leftImageButton.Click
        If featuredImage.Text = "Card Image" Then
            currentImageIndex = currentImageIndex - 1

            rightImageButton.Enabled = True
            If currentImageIndex = 0 Then
                leftImageButton.Enabled = False
            End If

            SetImage(currentImageIndex)
        ElseIf featuredImage.Text = "Field Image" Then
            currentFieldImageIndex = currentFieldImageIndex - 1

            rightImageButton.Enabled = True
            If currentFieldImageIndex = 0 Then
                leftImageButton.Enabled = False
            End If

            SetImage(currentFieldImageIndex)
        ElseIf featuredImage.Text = "Special Image" Then
            currentSpecialImageIndex = currentSpecialImageIndex - 1

            rightImageButton.Enabled = True
            If currentSpecialImageIndex = 0 Then
                leftImageButton.Enabled = False
            End If

            SetImage(currentSpecialImageIndex)
        End If
    End Sub

    Private Sub rightImageButton_Click(sender As Object, e As EventArgs) Handles rightImageButton.Click
        If featuredImage.Text = "Card Image" Then
            currentImageIndex = currentImageIndex + 1

            leftImageButton.Enabled = True
            If currentImageIndex = cardList.Count - 1 Then
                rightImageButton.Enabled = False
            End If

            SetImage(currentImageIndex)
        ElseIf featuredImage.Text = "Field Image" Then
            currentFieldImageIndex = currentFieldImageIndex + 1

            leftImageButton.Enabled = True
            If currentFieldImageIndex = fieldImageList.Count - 1 Then
                rightImageButton.Enabled = False
            End If

            SetImage(currentFieldImageIndex)
        ElseIf featuredImage.Text = "Special Image" Then
            currentSpecialImageIndex = currentSpecialImageIndex + 1

            leftImageButton.Enabled = True
            If currentSpecialImageIndex = specialImageList.Count - 1 Then
                rightImageButton.Enabled = False
            End If

            SetImage(currentSpecialImageIndex)
        End If
    End Sub

    Private Sub shareWith_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shareWith.SelectedIndexChanged
        If shareWith.Text = "Specific User" Then
            hidePanel.Hide()
        Else
            hidePanel.Show()
        End If
    End Sub

    Private Sub banlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles banlist.SelectedIndexChanged
        If banlist.Text = "Other" Then
            hidePanel2.Hide()
        Else
            hidePanel2.Show()
        End If
    End Sub

    Private Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        If CheckBannedWords.CheckSwearingAdvertising(deckName.Text) = False Then
            Return
        End If

        If CheckBannedWords.CheckSwearingAdvertising(deckDescription.Text) = False Then
            Return
        End If

        Dim banlistToSend As String
        Dim deckTypeToSend As Integer
        Dim sharedWithToSend As Integer
        Dim featuredImageToSend As String = ""

        Dim mainDeckString As String = ""
        Dim extraDeckString As String = ""
        Dim sideDeckString As String = ""

        If mainDeck.Count < 40 Then
            MsgBox("Your main deck must contain atleast 40 cards!")
            Return
        End If

        For Each card As String In mainDeck
            mainDeckString = mainDeckString & card & ","
        Next
        For Each card As String In extraDeck
            extraDeckString = extraDeckString & card & ","
        Next
        For Each card As String In sideDeck
            sideDeckString = sideDeckString & card & ","
        Next

        If deckType.Text = "Meta" Then
            deckTypeToSend = 0
        ElseIf deckType.Text = "Non-Meta" Then
            deckTypeToSend = 1
        Else
            deckTypeToSend = 2
        End If

        If shareWith.Text = "Everyone" Then
            sharedWithToSend = 0
        ElseIf shareWith.Text = "Team" Then
            sharedWithToSend = 1
        ElseIf shareWith.Text = "Friends" Then
            sharedWithToSend = 2
        Else
            sharedWithToSend = 3
        End If

        mainDeckString = mainDeckString.Substring(0, mainDeckString.Length - 1)
        Try
            extraDeckString = extraDeckString.Substring(0, extraDeckString.Length - 1)
        Catch
        End Try
        Try
            sideDeckString = sideDeckString.Substring(0, sideDeckString.Length - 1)
        Catch
        End Try

        If banlist.Text <> "Other" Then
            banlistToSend = banlist.Text
        Else
            banlistToSend = banlistTxt.Text
        End If

        If featuredImage.Text = "Card Image" Then
            featuredImageToSend = "0:" & cardList(currentImageIndex)
        ElseIf featuredImage.Text = "Field Image" Then
            featuredImageToSend = "1:" & fieldImageList(currentFieldImageIndex)
        Else
            featuredImageToSend = "2:" & specialImageList(currentSpecialImageIndex)
        End If

        Launcher.SendToServer("UploadDeck" & Launcher.Splitter & deckName.Text & Launcher.Splitter & featuredImageToSend & Launcher.Splitter & banlistToSend & Launcher.Splitter & deckTypeToSend & Launcher.Splitter & sharedWithToSend & Launcher.Splitter & deckDescription.Text & Launcher.Splitter & mainDeckString & Launcher.Splitter & extraDeckString & Launcher.Splitter & sideDeckString & Launcher.Splitter & sharedTxt.Text & Launcher.Splitter & deckDescription.Text)
    End Sub

    Private Sub featuredImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles featuredImage.SelectedIndexChanged
        If featuredImage.Text = "Card Image" Then
            If currentImageIndex <> 0 Then
                leftImageButton.Enabled = True
            Else
                leftImageButton.Enabled = False
            End If
            If currentImageIndex <> cardList.Count - 1 Then
                rightImageButton.Enabled = True
            Else
                rightImageButton.Enabled = False
            End If

            SetImage(currentImageIndex)
        ElseIf featuredImage.Text = "Field Image" Then
            If currentFieldImageIndex <> 0 Then
                leftImageButton.Enabled = True
            Else
                leftImageButton.Enabled = False
            End If
            If currentFieldImageIndex <> fieldImageList.Count - 1 Then
                rightImageButton.Enabled = True
            Else
                rightImageButton.Enabled = False
            End If

            SetImage(currentFieldImageIndex)
        ElseIf featuredImage.Text = "Special Image" Then
            If currentSpecialImageIndex <> 0 Then
                leftImageButton.Enabled = True
            Else
                leftImageButton.Enabled = False
            End If
            If currentSpecialImageIndex <> specialImageList.Count - 1 Then
                rightImageButton.Enabled = True
            Else
                rightImageButton.Enabled = False
            End If

            SetImage(currentSpecialImageIndex)
        End If
    End Sub

    Private Sub selectDeck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectDeck.SelectedIndexChanged
        LoadDeck()

        If featuredImage.Text = "Card Image" Then
            leftImageButton.Enabled = False
            SetImage(currentImageIndex)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub deckDescription_TextChanged(sender As Object, e As EventArgs) Handles deckDescription.TextChanged
        charactersLbl.Text = "Characters: " & deckDescription.Text.Count & "/50"
    End Sub
End Class
