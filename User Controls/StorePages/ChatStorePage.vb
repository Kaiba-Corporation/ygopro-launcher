Public Class ChatStorePage

    Dim currentClicks As Integer = 0

    Private Sub UpBtn_Click(sender As Object, e As EventArgs) Handles UpBtn.Click
        If currentClicks = 0 Then
            Return
        End If

        currentClicks -= 1
        Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y + 110)
    End Sub

    Private Sub DownBtn_Click(sender As Object, e As EventArgs) Handles DownBtn.Click
        If currentClicks = 1 Then
            Return
        End If

        currentClicks += 1
        Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y - 110)
    End Sub

    Private Sub resetWp_Click(sender As Object, e As EventArgs) Handles resetWp.Click
        Launcher.SetItemInfo("Reset WP", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub MeCommand_Click(sender As Object, e As EventArgs) Handles MeCommand.Click
        Launcher.SetItemInfo("Me Command", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub blueChatColor_Click(sender As Object, e As EventArgs) Handles blueChatColor.Click
        Launcher.SetItemInfo("Blue Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub greenChatColor_Click(sender As Object, e As EventArgs) Handles greenChatColor.Click
        Launcher.SetItemInfo("Green Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub redChatColor_Click(sender As Object, e As EventArgs) Handles redChatColor.Click
        Launcher.SetItemInfo("Red Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub pinkChatColor_Click(sender As Object, e As EventArgs) Handles pinkChatColor.Click
        Launcher.SetItemInfo("Pink Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub fbiChatColor_Click(sender As Object, e As EventArgs) Handles fbiChatColor.Click
        Launcher.SetItemInfo("FBI Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub rainbowChatColor_Click(sender As Object, e As EventArgs) Handles rainbowChatColor.Click
        Launcher.SetItemInfo("Rainbow Color", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub classifiedAccess_Click(sender As Object, e As EventArgs) Handles classifiedAccess.Click
        Launcher.SetItemInfo("Classified Access", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub chatFontBundle_Click(sender As Object, e As EventArgs) Handles chatFontBundle.Click
        Launcher.SetItemInfo("Chat Font Bundle", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub boldChatStyle_Click(sender As Object, e As EventArgs) Handles boldChatStyle.Click
        Launcher.SetItemInfo("Bold Font Style", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub italicChatStyle_Click(sender As Object, e As EventArgs) Handles italicChatStyle.Click
        Launcher.SetItemInfo("Italic Font Style", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub underlineChatStyle_Click(sender As Object, e As EventArgs) Handles underlineChatStyle.Click
        Launcher.SetItemInfo("Underline Font Style", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub strikeoutChatStyle_Click(sender As Object, e As EventArgs) Handles strikeoutChatStyle.Click
        Launcher.SetItemInfo("Strikeout Font Style", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub customTextFont_Click(sender As Object, e As EventArgs) Handles customTextFont.Click
        Launcher.SetItemInfo("Custom Text Font", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub emoticonPack1_Click(sender As Object, e As EventArgs)
        Launcher.SetItemInfo("Emoticon Pack 1", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub emoticonPack2_Click(sender As Object, e As EventArgs)
        Launcher.SetItemInfo("Emoticon Pack 2", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub

    Private Sub resetWp_MouseMove(sender As Object, e As MouseEventArgs) Handles resetWp.MouseMove
        resetWp.Image = My.Resources.Item_ResetWPH

        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub MeCommand_MouseMove(sender As Object, e As MouseEventArgs) Handles MeCommand.MouseMove
        MeCommand.Image = My.Resources.Item_MeCommandH

        resetWp.Image = My.Resources.Item_ResetWP
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub blueChatColor_MouseMove(sender As Object, e As MouseEventArgs) Handles blueChatColor.MouseMove
        blueChatColor.Image = My.Resources.Item_BlueChatColorH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub greenChatColor_MouseMove(sender As Object, e As MouseEventArgs) Handles greenChatColor.MouseMove
        greenChatColor.Image = My.Resources.Item_GreenChatColorH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub redChatColor_MouseMove(sender As Object, e As MouseEventArgs) Handles redChatColor.MouseMove
        redChatColor.Image = My.Resources.Item_RedChatColorH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub pinkChatColor_MouseMove(sender As Object, e As MouseEventArgs) Handles pinkChatColor.MouseMove
        pinkChatColor.Image = My.Resources.Item_PinkChatColorH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub fbiChatColor_MouseMove(sender As Object, e As MouseEventArgs) Handles fbiChatColor.MouseMove
        fbiChatColor.Image = My.Resources.Item_FBIChatColorH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub rainbowChatColor_MouseMove(sender As Object, e As MouseEventArgs) Handles rainbowChatColor.MouseMove
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColorH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub classifiedAccess_MouseMove(sender As Object, e As MouseEventArgs) Handles classifiedAccess.MouseMove
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccessH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub chatFontBundle_MouseMove(sender As Object, e As MouseEventArgs) Handles chatFontBundle.MouseMove
        chatFontBundle.Image = My.Resources.Item_ChatBundleH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub boldChatStyle_MouseMove(sender As Object, e As MouseEventArgs) Handles boldChatStyle.MouseMove
        boldChatStyle.Image = My.Resources.Item_BoldChatFontH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub italicChatStyle_MouseMove(sender As Object, e As MouseEventArgs) Handles italicChatStyle.MouseMove
        italicChatStyle.Image = My.Resources.Item_ItalicChatFontH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub underlineChatStyle_MouseMove(sender As Object, e As MouseEventArgs) Handles underlineChatStyle.MouseMove
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFontH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub strikeoutChatStyle_MouseMove(sender As Object, e As MouseEventArgs) Handles strikeoutChatStyle.MouseMove
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFontH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub customTextFont_MouseMove(sender As Object, e As MouseEventArgs) Handles customTextFont.MouseMove
        customTextFont.Image = My.Resources.Item_CustomFontH

        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove
        resetWp.Image = My.Resources.Item_ResetWP
        MeCommand.Image = My.Resources.Item_MeCommand
        blueChatColor.Image = My.Resources.Item_BlueChatColor
        greenChatColor.Image = My.Resources.Item_GreenChatColor
        redChatColor.Image = My.Resources.Item_RedChatColor
        pinkChatColor.Image = My.Resources.Item_PinkChatColor
        fbiChatColor.Image = My.Resources.Item_FBIChatColor
        rainbowChatColor.Image = My.Resources.Item_RainbowChatColor
        classifiedAccess.Image = My.Resources.Item_ClassifiedAccess
        chatFontBundle.Image = My.Resources.Item_ChatBundle
        boldChatStyle.Image = My.Resources.Item_BoldChatFont
        italicChatStyle.Image = My.Resources.Item_ItalicChatFont
        underlineChatStyle.Image = My.Resources.Item_UnderlineChatFont
        strikeoutChatStyle.Image = My.Resources.Item_StrikeoutChatFont
        customTextFont.Image = My.Resources.Item_CustomFont
    End Sub

    Private Sub goldBuyBtn_Click(sender As Object, e As EventArgs) Handles goldBuyBtn.Click
        If itemNameOnlyLabel.Text = "Reset WP" Then
            Dim wp As Integer = buyMultiTxt.Text
            If wp < 1 Or wp > 100 Then
                Return
            End If

            Launcher.SendToServer("Buy" & Launcher.Splitter & itemNameOnlyLabel.Text & Launcher.Splitter & buyMultiTxt.Text)
            Return
        End If

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

    Private Sub ChatStorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Launcher.SetItemInfo("Reset WP", itemNameLabel, itemNameOnlyLabel, goldLabel, DiamondLabel, moreInfoLink, itemImagePictureBox, goldBuyBtn, diamondBuyBtn, bp1, bp2, bp3, bp4, buyMultiTxt, itemCantBuy)
    End Sub
End Class
