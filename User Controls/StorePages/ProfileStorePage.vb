Public Class ProfileStorePage

    Dim currentClicks As Integer = 0

    Private Sub UpBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DownBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub changeUsername_Click(sender As Object, e As EventArgs) Handles changeUsername.Click
        Launcher.SetItemInfo("Change Username", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub starcaller_Click(sender As Object, e As EventArgs) Handles starcaller.Click
        Launcher.SetItemInfo("Starcaller", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub firelord_Click(sender As Object, e As EventArgs) Handles firelord.Click
        Launcher.SetItemInfo("Firelord", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub stormborn_Click(sender As Object, e As EventArgs) Handles stormborn.Click
        Launcher.SetItemInfo("Stormborn", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub goldSarcophagus_Click(sender As Object, e As EventArgs) Handles goldSarcophagus.Click
        Launcher.SetItemInfo("Gold Sarcophagus", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub customTitle_Click(sender As Object, e As EventArgs) Handles customTitle.Click
        Launcher.SetItemInfo("Custom Title", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub rexterra_Click(sender As Object, e As EventArgs) Handles rexterra.Click
        Launcher.SetItemInfo("Rexterra", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub tidemaster_Click(sender As Object, e As EventArgs) Handles tidemaster.Click
        Launcher.SetItemInfo("Tidemaster", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub tournamentHosting_Click(sender As Object, e As EventArgs) Handles tournamentHosting.Click
        Launcher.SetItemInfo("Tournament Hosting", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub customUsernameColor_Click(sender As Object, e As EventArgs) Handles customUsernameColor.Click
        Launcher.SetItemInfo("Username Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub nightshade_Click(sender As Object, e As EventArgs) Handles nightshade.Click
        Launcher.SetItemInfo("Nightshade", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub lordOfLight_Click(sender As Object, e As EventArgs) Handles lordOfLight.Click
        Launcher.SetItemInfo("Lord of Light", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub unblockRanked_Click(sender As Object, e As EventArgs) Handles unblockRanked.Click
        Launcher.SetItemInfo("Unblock Ranked", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub customBorder_Click(sender As Object, e As EventArgs) Handles customBorder.Click
        Launcher.SetItemInfo("Custom Border", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub adBlock_Click(sender As Object, e As EventArgs)
        Launcher.SetItemInfo("AdBlock", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub changeUsername_MouseMove(sender As Object, e As MouseEventArgs) Handles changeUsername.MouseMove
        changeUsername.Image = My.Resources.Item_ChangeUsernameH

        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub starcaller_MouseMove(sender As Object, e As MouseEventArgs) Handles starcaller.MouseMove
        starcaller.Image = My.Resources.Item_StarcallerH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub firelord_MouseMove(sender As Object, e As MouseEventArgs) Handles firelord.MouseMove
        firelord.Image = My.Resources.Item_FirelordH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub stormborn_MouseMove(sender As Object, e As MouseEventArgs) Handles stormborn.MouseMove
        stormborn.Image = My.Resources.Item_StormbornH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub goldSarcophagus_MouseMove(sender As Object, e As MouseEventArgs) Handles goldSarcophagus.MouseMove
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagusH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub customTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles customTitle.MouseMove
        customTitle.Image = My.Resources.Item_CustomTitleH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub rexterra_MouseMove(sender As Object, e As MouseEventArgs) Handles rexterra.MouseMove
        rexterra.Image = My.Resources.Item_RexterraH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub tidemaster_MouseMove(sender As Object, e As MouseEventArgs) Handles tidemaster.MouseMove
        tidemaster.Image = My.Resources.Item_TidemasterH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub tournamentHosting_MouseMove(sender As Object, e As MouseEventArgs) Handles tournamentHosting.MouseMove
        tournamentHosting.Image = My.Resources.Item_TournamentHostingH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub customUsernameColor_MouseMove(sender As Object, e As MouseEventArgs) Handles customUsernameColor.MouseMove
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColorH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub nightshade_MouseMove(sender As Object, e As MouseEventArgs) Handles nightshade.MouseMove
        nightshade.Image = My.Resources.Item_NightshadeH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub lordOfLight_MouseMove(sender As Object, e As MouseEventArgs) Handles lordOfLight.MouseMove
        lordOfLight.Image = My.Resources.Item_LordOfLightH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub unblockRanked_MouseMove(sender As Object, e As MouseEventArgs) Handles unblockRanked.MouseMove
        unblockRanked.Image = My.Resources.Item_UnblockRankedH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub customBorder_MouseMove(sender As Object, e As MouseEventArgs) Handles customBorder.MouseMove
        customBorder.Image = My.Resources.Item_CustomBorderH

        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove
        changeUsername.Image = My.Resources.Item_ChangeUsername
        starcaller.Image = My.Resources.Item_Starcaller
        firelord.Image = My.Resources.Item_Firelord
        stormborn.Image = My.Resources.Item_Stormborn
        goldSarcophagus.Image = My.Resources.Item_GoldSarcophagus
        customTitle.Image = My.Resources.Item_CustomTitle
        rexterra.Image = My.Resources.Item_Rexterra
        tidemaster.Image = My.Resources.Item_Tidemaster
        tournamentHosting.Image = My.Resources.Item_TournamentHosting
        customUsernameColor.Image = My.Resources.Item_CustomUsernameColor
        nightshade.Image = My.Resources.Item_Nightshade
        lordOfLight.Image = My.Resources.Item_LordOfLight
        unblockRanked.Image = My.Resources.Item_UnblockRanked
        customBorder.Image = My.Resources.Item_CustomBorder
    End Sub

    Private Sub goldBuyBtn_Click(sender As Object, e As EventArgs) Handles goldBuyBtn.Click
        Launcher.SendToServer("Buy" & Launcher.Splitter & itemNameOnlyLabel.Text & Launcher.Splitter & "Gold")

        goldBuyBtn.Visible = False
        diamondBuyBtn.Visible = False
    End Sub

    Private Sub diamondBuyBtn_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn.Click
        If itemNameOnlyLabel.Text = "Change Username" Then
            Dim NewUsername = InputBox("New Username: ")
            Launcher.SendToServer("Buy" & Launcher.Splitter & itemNameOnlyLabel.Text & Launcher.Splitter & NewUsername)
            Return
        End If

        Launcher.SendToServer("Buy" & Launcher.Splitter & itemNameOnlyLabel.Text & Launcher.Splitter & "Diamonds")

        goldBuyBtn.Visible = False
        diamondBuyBtn.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("cmd /c start " & moreInfoLink.Text)
    End Sub

    Private Sub ProfileStorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Launcher.SetItemInfo("Username Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, itemCantBuy)
    End Sub

    Private Sub UpBtn_Click_1(sender As Object, e As EventArgs) Handles UpBtn.Click
        If currentClicks = 0 Then
            Return
        End If

        currentClicks -= 1
        Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y + 110)
    End Sub

    Private Sub DownBtn_Click_1(sender As Object, e As EventArgs) Handles DownBtn.Click
        If currentClicks = 1 Then
            Return
        End If

        currentClicks += 1
        Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y - 110)
    End Sub
End Class
