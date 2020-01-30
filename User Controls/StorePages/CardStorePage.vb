Public Class MysteryBox

    Dim page As Integer
    Dim pages As Double

    Private Sub CardStorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cardType.SelectedIndex = 0

        page = 1
        pages = 1

        Try
            Dim skinCount As Integer = 0
            For Each skin As CardSkinManager.CardSkin In CardSkinManager.CardSkinList
                If skin.skinId < 850000000 Or skin.skinId >= 870000000 Then
                    If showOwned.Checked Then
                        If skinCount = 6 Then
                            skinCount = 0
                            pages += 1
                        End If
                        skinCount += 1
                    Else
                        If Not Launcher.ownedCardSkins.Contains(skin.skinId) Then
                            If skinCount = 6 Then
                                skinCount = 0
                                pages += 1
                            End If
                            skinCount += 1
                        End If
                    End If
                End If
            Next
        Catch
        End Try

        NewSearch()
    End Sub

    Private Sub card800000000_Click(sender As Object, e As EventArgs) Handles card4.Click, card2.Click, card5.Click, card3.Click, card1.Click
        Shell("cmd /c start http://ygopro.club/index.php?/topic/3680-custom-card-skins/")
    End Sub

    Private Sub goldBuyBtn_Click(sender As Object, e As EventArgs) Handles goldBuyBtn1.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card1.Tag & Launcher.Splitter & "Gold")
    End Sub

    Private Sub diamondBuyBtn_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn1.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card1.Tag & Launcher.Splitter & "Diamonds")
    End Sub

    Private Sub goldBuyBtn3_Click(sender As Object, e As EventArgs) Handles goldBuyBtn3.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card3.Tag & Launcher.Splitter & "Gold")
    End Sub

    Private Sub diamondBuyBtn3_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn3.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card3.Tag & Launcher.Splitter & "Diamonds")
    End Sub

    Private Sub goldBuyBtn5_Click(sender As Object, e As EventArgs) Handles goldBuyBtn5.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card5.Tag & Launcher.Splitter & "Gold")
    End Sub

    Private Sub diamondBuyBtn5_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn5.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card5.Tag & Launcher.Splitter & "Diamonds")
    End Sub

    Private Sub goldBuyBtn2_Click(sender As Object, e As EventArgs) Handles goldBuyBtn2.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card2.Tag & Launcher.Splitter & "Gold")
    End Sub

    Private Sub diamondBuyBtn2_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn2.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card2.Tag & Launcher.Splitter & "Diamonds")
    End Sub

    Private Sub goldBuyBtn4_Click(sender As Object, e As EventArgs) Handles goldBuyBtn4.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card4.Tag & Launcher.Splitter & "Gold")
    End Sub

    Private Sub diamondBuyBtn4_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn4.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card4.Tag & Launcher.Splitter & "Diamonds")
    End Sub

    Private Sub goldBuyBtn6_Click(sender As Object, e As EventArgs) Handles goldBuyBtn6.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card6.Tag & Launcher.Splitter & "Gold")
    End Sub

    Private Sub diamondBuyBtn6_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn6.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & "CardSkin" & Launcher.Splitter & card6.Tag & Launcher.Splitter & "Diamonds")
    End Sub

    Public Sub CreatePages()
        If page <> 1 And pages > 1 Then
            LeftBtn.Enabled = True
        Else
            LeftBtn.Enabled = False
        End If
        If page <> pages And pages > 1 Then
            RightBtn.Enabled = True
        Else
            RightBtn.Enabled = False
        End If

        If pages > 1 Then
            pageDisplay.Visible = True
            LeftBtn.Visible = True
            RightBtn.Visible = True
        Else
            pageDisplay.Visible = False
            LeftBtn.Visible = False
            RightBtn.Visible = False
        End If

        pageDisplay.Text = "Page: " & page & "/" & pages

        pageDisplay.Location = New Point(RightBtn.Location.X - pageDisplay.Size.Width - 3, pageDisplay.Location.Y)
        LeftBtn.Location = New Point(pageDisplay.Location.X - 19, LeftBtn.Location.Y)
    End Sub

    Private Sub LeftBtn_Click(sender As Object, e As EventArgs) Handles LeftBtn.Click
        page -= 1
        NewSearch()
    End Sub

    Private Sub RightBtn_Click(sender As Object, e As EventArgs) Handles RightBtn.Click
        page += 1
        NewSearch()
    End Sub

    Private Sub showOwned_CheckedChanged(sender As Object, e As EventArgs) Handles showOwned.CheckedChanged
        page = 1
        pages = 1

        Try
            Dim skinCount As Integer = 0
            For Each skin As CardSkinManager.CardSkin In CardSkinManager.CardSkinList
                If skin.skinId < 850000000 Or skin.skinId >= 870000000 Then
                    If cardType.SelectedIndex = 0 Or cardType.SelectedIndex = skin.type Then
                        If skin.name.ToLower.Contains(cardName.Text.ToLower) Then
                            If showOwned.Checked Then
                                If skinCount = 6 Then
                                    skinCount = 0
                                    pages += 1
                                End If
                                skinCount += 1
                            Else
                                If Not Launcher.ownedCardSkins.Contains(skin.skinId) Then
                                    If skinCount = 6 Then
                                        skinCount = 0
                                        pages += 1
                                    End If
                                    skinCount += 1
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Catch
        End Try

        NewSearch()
    End Sub

    Public Sub NewSearch()
        HideAllElements()

        Try
            Dim counter As Integer = 0
            For Each skin As CardSkinManager.CardSkin In CardSkinManager.CardSkinList
                If skin.skinId < 850000000 Or skin.skinId >= 870000000 Then
                    If cardType.SelectedIndex = 0 Or cardType.SelectedIndex = skin.type Then
                        If skin.name.ToLower.Contains(cardName.Text.ToLower) Then
                            If showOwned.Checked Then
                                If counter >= (page - 1) * 6 Then
                                    Try
                                        If counter - ((page - 1) * 6) = 0 Then
                                            SetInfo(card1, cardname1, goldIcon1, diamondIcon1, gold1, diamonds1, goldBuyBtn1, diamondBuyBtn1, skin)
                                        ElseIf counter - ((page - 1) * 6) = 1 Then
                                            SetInfo(card2, cardname2, goldIcon2, diamondIcon2, gold2, diamonds2, goldBuyBtn2, diamondBuyBtn2, skin)
                                        ElseIf counter - ((page - 1) * 6) = 2 Then
                                            SetInfo(card3, cardname3, goldIcon3, diamondIcon3, gold3, diamonds3, goldBuyBtn3, diamondBuyBtn3, skin)
                                        ElseIf counter - ((page - 1) * 6) = 3 Then
                                            SetInfo(card4, cardname4, goldIcon4, diamondIcon4, gold4, diamonds4, goldBuyBtn4, diamondBuyBtn4, skin)
                                        ElseIf counter - ((page - 1) * 6) = 4 Then
                                            SetInfo(card5, cardname5, goldIcon5, diamondIcon5, gold5, diamonds5, goldBuyBtn5, diamondBuyBtn5, skin)
                                        ElseIf counter - ((page - 1) * 6) = 5 Then
                                            SetInfo(card6, cardname6, goldIcon6, diamondIcon6, gold6, diamonds6, goldBuyBtn6, diamondBuyBtn6, skin)
                                            Exit For
                                        End If
                                    Catch
                                    End Try
                                End If
                                counter += 1
                            Else
                                If Not Launcher.ownedCardSkins.Contains(skin.skinId) Then
                                    If counter >= (page - 1) * 6 Then
                                        Try
                                            If counter - ((page - 1) * 6) = 0 Then
                                                SetInfo(card1, cardname1, goldIcon1, diamondIcon1, gold1, diamonds1, goldBuyBtn1, diamondBuyBtn1, skin)
                                            ElseIf counter - ((page - 1) * 6) = 1 Then
                                                SetInfo(card2, cardname2, goldIcon2, diamondIcon2, gold2, diamonds2, goldBuyBtn2, diamondBuyBtn2, skin)
                                            ElseIf counter - ((page - 1) * 6) = 2 Then
                                                SetInfo(card3, cardname3, goldIcon3, diamondIcon3, gold3, diamonds3, goldBuyBtn3, diamondBuyBtn3, skin)
                                            ElseIf counter - ((page - 1) * 6) = 3 Then
                                                SetInfo(card4, cardname4, goldIcon4, diamondIcon4, gold4, diamonds4, goldBuyBtn4, diamondBuyBtn4, skin)
                                            ElseIf counter - ((page - 1) * 6) = 4 Then
                                                SetInfo(card5, cardname5, goldIcon5, diamondIcon5, gold5, diamonds5, goldBuyBtn5, diamondBuyBtn5, skin)
                                            ElseIf counter - ((page - 1) * 6) = 5 Then
                                                SetInfo(card6, cardname6, goldIcon6, diamondIcon6, gold6, diamonds6, goldBuyBtn6, diamondBuyBtn6, skin)
                                                Exit For
                                            End If
                                        Catch
                                        End Try
                                    End If
                                    counter += 1
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Catch
        End Try

        CreatePages()
    End Sub

    Public Sub SetInfo(cardImagePictureBox As PictureBox, cardNameLabel As Label, goldIcon As PictureBox, diamondIcon As PictureBox, goldPrice As Label, diamondPrice As Label, goldBuyButton As Button, diamondBuyButton As Button, inputSkin As Object)
        Dim skin As CardSkinManager.CardSkin = inputSkin

        cardImagePictureBox.Visible = True
        cardNameLabel.Visible = True
        goldIcon.Visible = True
        diamondIcon.Visible = True
        goldPrice.Visible = True
        diamondPrice.Visible = True

        cardImagePictureBox.Image = Image.FromFile(Launcher.Current & "\YGOPRO\pics\" & skin.skinId & ".jpg")
        cardImagePictureBox.Tag = skin.skinId
        cardNameLabel.Text = skin.name
        If skin.skinId >= 800000000 And skin.skinId < 810000000 Then
            goldPrice.Text = 7000
            diamondPrice.Text = 100
        ElseIf skin.skinId >= 810000000 And skin.skinId < 820000000 Then
            goldPrice.Text = 3000
            diamondPrice.Text = 50
        ElseIf skin.skinId >= 820000000 And skin.skinId < 830000000 Then
            goldPrice.Text = 15000
            diamondPrice.Text = 250
        ElseIf skin.skinId >= 830000000 And skin.skinId < 840000000 Then
            goldPrice.Text = 10000
            diamondPrice.Text = 150
        ElseIf skin.skinId >= 840000000 And skin.skinId < 850000000 Then
            goldPrice.Text = 12500
            diamondPrice.Text = 200
        End If

        If Launcher.ownedCardSkins.Contains(skin.skinId) Then
            goldBuyButton.Visible = False
            diamondBuyButton.Visible = False
        Else
            goldBuyButton.Visible = True
            diamondBuyButton.Visible = True
        End If
    End Sub

    Public Sub HideAllElements()
        card1.Visible = False
        card2.Visible = False
        card3.Visible = False
        card4.Visible = False
        card5.Visible = False
        card6.Visible = False

        cardname1.Visible = False
        cardname2.Visible = False
        cardname3.Visible = False
        cardname4.Visible = False
        cardname5.Visible = False
        cardname6.Visible = False

        goldIcon1.Visible = False
        goldIcon2.Visible = False
        goldIcon3.Visible = False
        goldIcon4.Visible = False
        goldIcon5.Visible = False
        goldIcon6.Visible = False

        diamondIcon1.Visible = False
        diamondIcon2.Visible = False
        diamondIcon3.Visible = False
        diamondIcon4.Visible = False
        diamondIcon5.Visible = False
        diamondIcon6.Visible = False

        gold1.Visible = False
        gold2.Visible = False
        gold3.Visible = False
        gold4.Visible = False
        gold5.Visible = False
        gold6.Visible = False

        diamonds1.Visible = False
        diamonds2.Visible = False
        diamonds3.Visible = False
        diamonds4.Visible = False
        diamonds5.Visible = False
        diamonds6.Visible = False

        goldBuyBtn1.Visible = False
        goldBuyBtn2.Visible = False
        goldBuyBtn3.Visible = False
        goldBuyBtn4.Visible = False
        goldBuyBtn5.Visible = False
        goldBuyBtn6.Visible = False

        diamondBuyBtn1.Visible = False
        diamondBuyBtn2.Visible = False
        diamondBuyBtn3.Visible = False
        diamondBuyBtn4.Visible = False
        diamondBuyBtn5.Visible = False
        diamondBuyBtn6.Visible = False
    End Sub

    Private Sub cardName_TextChanged(sender As Object, e As EventArgs) Handles cardName.TextChanged
        page = 1
        pages = 1

        Try
            Dim skinCount As Integer = 0
            For Each skin As CardSkinManager.CardSkin In CardSkinManager.CardSkinList
                If skin.skinId < 850000000 Or skin.skinId >= 870000000 Then
                    If cardType.SelectedIndex = 0 Or cardType.SelectedIndex = skin.type Then
                        If skin.name.ToLower.Contains(cardName.Text.ToLower) Then
                            If showOwned.Checked Then
                                If skinCount = 6 Then
                                    skinCount = 0
                                    pages += 1
                                End If
                                skinCount += 1
                            Else
                                If Not Launcher.ownedCardSkins.Contains(skin.skinId) Then
                                    If skinCount = 6 Then
                                        skinCount = 0
                                        pages += 1
                                    End If
                                    skinCount += 1
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Catch
        End Try

        NewSearch()
    End Sub

    Private Sub cardType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cardType.SelectedIndexChanged
        page = 1
        pages = 1

        Try
            Dim skinCount As Integer = 0
            For Each skin As CardSkinManager.CardSkin In CardSkinManager.CardSkinList
                If skin.skinId < 850000000 Or skin.skinId >= 870000000 Then
                    If cardType.SelectedIndex = 0 Or cardType.SelectedIndex = skin.type Then
                        If skin.name.ToLower.Contains(cardName.Text.ToLower) Then
                            If showOwned.Checked Then
                                If skinCount = 6 Then
                                    skinCount = 0
                                    pages += 1
                                End If
                                skinCount += 1
                            Else
                                If Not Launcher.ownedCardSkins.Contains(skin.skinId) Then
                                    If skinCount = 6 Then
                                        skinCount = 0
                                        pages += 1
                                    End If
                                    skinCount += 1
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Catch
        End Try

        NewSearch()
    End Sub
End Class