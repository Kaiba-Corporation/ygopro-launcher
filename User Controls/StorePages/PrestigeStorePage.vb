Public Class PrestigeStorePage

    Dim currentClicks As Integer = 0

    Private Sub goldMembership_Click(sender As Object, e As EventArgs) Handles goldMembership.Click
        Launcher.SetItemInfo("Gold Membership", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub platinumMembership_Click(sender As Object, e As EventArgs) Handles platinumMembership.Click
        Launcher.SetItemInfo("Platinum Membership", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub diamondMembership_Click(sender As Object, e As EventArgs) Handles diamondMembership.Click
        Launcher.SetItemInfo("Diamond Membership", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub duelSetoKaiba_Click(sender As Object, e As EventArgs) Handles duelSetoKaiba.Click
        Launcher.SetItemInfo("Duel Seto Kaiba", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub amethystMembership_Click(sender As Object, e As EventArgs) Handles amethystMembership.Click
        Launcher.SetItemInfo("Amethyst Membership", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub avatar_Click(sender As Object, e As EventArgs) Handles avatar.Click
        Launcher.SetItemInfo("Avatar", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub cardBack_Click(sender As Object, e As EventArgs) Handles cardBack.Click
        Launcher.SetItemInfo("Card Back", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub avatarCardBack_Click(sender As Object, e As EventArgs) Handles avatarCardBack.Click
        Launcher.SetItemInfo("Avatar & Card Back", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub tdoaneChallenge_Click(sender As Object, e As EventArgs)
        Launcher.SetItemInfo("TDOANE Challenge", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub customTextColor_Click(sender As Object, e As EventArgs) Handles customTextColor.Click
        Launcher.SetItemInfo("Custom Text Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub customPrivateChat_Click(sender As Object, e As EventArgs) Handles customPrivateChat.Click
        Launcher.SetItemInfo("Custom Private Chat", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub goldMembership_MouseMove(sender As Object, e As MouseEventArgs) Handles goldMembership.MouseMove
        goldMembership.Image = My.Resources.Item_GoldMembershipH

        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub platinumMembership_MouseMove(sender As Object, e As MouseEventArgs) Handles platinumMembership.MouseMove
        platinumMembership.Image = My.Resources.Item_PlatinumMembershipH

        goldMembership.Image = My.Resources.Item_GoldMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub diamondMembership_MouseMove(sender As Object, e As MouseEventArgs) Handles diamondMembership.MouseMove
        diamondMembership.Image = My.Resources.Item_DiamondMembershipH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub duelSetoKaiba_MouseMove(sender As Object, e As MouseEventArgs) Handles duelSetoKaiba.MouseMove
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaibaH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub amethystMembership_MouseMove(sender As Object, e As MouseEventArgs) Handles amethystMembership.MouseMove
        amethystMembership.Image = My.Resources.Item_AmethystMembershipH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub avatar_MouseMove(sender As Object, e As MouseEventArgs) Handles avatar.MouseMove
        avatar.Image = My.Resources.Item_AvatarH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub cardBack_MouseMove(sender As Object, e As MouseEventArgs) Handles cardBack.MouseMove
        cardBack.Image = My.Resources.Item_CardBackH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub avatarCardBack_MouseMove(sender As Object, e As MouseEventArgs) Handles avatarCardBack.MouseMove
        avatarCardBack.Image = My.Resources.Item_AvatarCardBackH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub customTextColor_MouseMove(sender As Object, e As MouseEventArgs) Handles customTextColor.MouseMove
        customTextColor.Image = My.Resources.Item_CustomTextColorH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub customPrivateChat_MouseMove(sender As Object, e As MouseEventArgs) Handles customPrivateChat.MouseMove
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChatH

        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove
        goldMembership.Image = My.Resources.Item_GoldMembership
        platinumMembership.Image = My.Resources.Item_PlatinumMembership
        diamondMembership.Image = My.Resources.Item_DiamondMembership
        duelSetoKaiba.Image = My.Resources.Item_DuelSetoKaiba
        amethystMembership.Image = My.Resources.Item_AmethystMembership
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        customTextColor.Image = My.Resources.Item_CustomTextColor
        customPrivateChat.Image = My.Resources.Item_CustomPrivateChat
    End Sub

    Private Sub goldBuyBtn_Click(sender As Object, e As EventArgs) Handles goldBuyBtn.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & itemNameOnlyLabel.Text & Launcher.Splitter & "Gold")

        goldBuyBtn.Visible = False
        diamondBuyBtn.Visible = False
    End Sub

    Private Sub diamondBuyBtn_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & itemNameOnlyLabel.Text & Launcher.Splitter & "Diamonds")

        goldBuyBtn.Visible = False
        diamondBuyBtn.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("cmd /c start " & moreInfoLink.Text)
    End Sub

    Private Sub PrestigeStorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Launcher.SetItemInfo("Avatar", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub UpBtn_Click_1(sender As Object, e As EventArgs) Handles UpBtn.Click
        If currentClicks = 0 Then
            Return
        End If

        currentClicks -= 1
        Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y + 30)
    End Sub

    Private Sub DownBtn_Click_1(sender As Object, e As EventArgs) Handles DownBtn.Click
        If currentClicks = 1 Then
            Return
        End If

        currentClicks += 1
        Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y - 30)
    End Sub
End Class
