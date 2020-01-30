Public Class TeamsStorePage


    Private Sub teamMembersBonus_Click(sender As Object, e As EventArgs) Handles teamMembersBonus.Click
        Launcher.SetItemInfo("Team Members Bonus", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub teamQuote_Click(sender As Object, e As EventArgs) Handles teamQuote.Click
        Launcher.SetItemInfo("Team Quote", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub teamMembersBonus_MouseMove(sender As Object, e As MouseEventArgs) Handles teamMembersBonus.MouseMove
        teamMembersBonus.Image = My.Resources.Item_TeamMembersBonusH

        teamQuote.Image = My.Resources.Item_TeamQuote
    End Sub

    Private Sub teamQuote_MouseMove(sender As Object, e As MouseEventArgs) Handles teamQuote.MouseMove
        teamQuote.Image = My.Resources.Item_TeamQuoteH

        teamMembersBonus.Image = My.Resources.Item_TeamMembersBonus
    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove
        teamMembersBonus.Image = My.Resources.Item_TeamMembersBonus
        teamQuote.Image = My.Resources.Item_TeamQuote
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

    Private Sub TeamsStorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Launcher.SetItemInfo("Team Members Bonus", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub
End Class
