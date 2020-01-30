Public Class HomeStorePage

    Private Sub starcaller_Click(sender As Object, e As EventArgs) Handles avatar.Click
        Launcher.SetItemInfo("Avatar", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub goldMembership_Click(sender As Object, e As EventArgs) Handles cardBack.Click
        Launcher.SetItemInfo("Card Back", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub classifiedAccess_Click(sender As Object, e As EventArgs) Handles avatarCardBack.Click
        Launcher.SetItemInfo("Avatar & Card Back", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub blueChatColor_Click(sender As Object, e As EventArgs) Handles diamondMembership.Click
        Launcher.SetItemInfo("Diamond Membership", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub starcaller_MouseMove(sender As Object, e As MouseEventArgs) Handles avatar.MouseMove
        avatar.Image = My.Resources.Item_AvatarH

        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        diamondMembership.Image = My.Resources.Item_DiamondMembership
    End Sub

    Private Sub goldMembership_MouseMove(sender As Object, e As MouseEventArgs) Handles cardBack.MouseMove
        cardBack.Image = My.Resources.Item_CardBackH

        avatar.Image = My.Resources.Item_Avatar
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        diamondMembership.Image = My.Resources.Item_DiamondMembership
    End Sub

    Private Sub classifiedAccess_MouseMove(sender As Object, e As MouseEventArgs) Handles avatarCardBack.MouseMove
        avatarCardBack.Image = My.Resources.Item_AvatarCardBackH

        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        diamondMembership.Image = My.Resources.Item_DiamondMembership
    End Sub

    Private Sub blueChatColor_MouseMove(sender As Object, e As MouseEventArgs) Handles diamondMembership.MouseMove
        diamondMembership.Image = My.Resources.Item_DiamondMembershipH

        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove
        avatar.Image = My.Resources.Item_Avatar
        cardBack.Image = My.Resources.Item_CardBack
        avatarCardBack.Image = My.Resources.Item_AvatarCardBack
        diamondMembership.Image = My.Resources.Item_DiamondMembership
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

    Private Sub HomeStorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Launcher.SetItemInfo("Avatar", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub
End Class
