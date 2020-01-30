Public Class MysteryStorePage

    Private Sub MysteryStorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckOwnedItems()

        If DateTime.Now.DayOfWeek = DayOfWeek.Sunday Then
            mysteryBoxImage.Image = My.Resources.LargeMysteryBox
            mysteryBoxImage.Tag = "LargeMysteryBox"
            itemName.Text = "Large Mystery Box"
            itemPrice.Text = "Price: 75 Diamonds"
        End If

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateTime.Now.DayOfWeek <> DayOfWeek.Sunday Then
            Dim totalSeconds As Integer = (Launcher.serverTime.DayOfWeek * 24 * 60 * 60) + (Launcher.serverTime.TimeOfDay.Hours * 60 * 60) + (Launcher.serverTime.TimeOfDay.Minutes * 60) + Launcher.serverTime.TimeOfDay.Seconds
            Dim remainingSeconds As Double = 604800 - totalSeconds
            Dim nextSunday As DateTime = Launcher.serverTime.AddSeconds(remainingSeconds)
            Dim remainingTime As TimeSpan = nextSunday - DateTime.Now

            Dim labelText As String = ""
            If remainingTime.Days > 0 Then
                labelText &= remainingTime.Days & " Days, "
            End If
            If remainingTime.Hours > 0 Then
                labelText &= remainingTime.Hours & " Hours, "
            End If
            If remainingTime.Minutes > 0 Then
                labelText &= remainingTime.Minutes & " Minutes, "
            End If
            labelText &= remainingTime.Seconds & " Seconds until the Large Mystery Box becomes available!"

            If remainingTime.Days = 1 Then
                labelText = labelText.Replace("Days", "Day")
            End If
            If remainingTime.Hours = 1 Then
                labelText = labelText.Replace("Hours", "Hours")
            End If
            If remainingTime.Minutes = 1 Then
                labelText = labelText.Replace("Minutes", "Minutes")
            End If
            If remainingTime.Seconds = 1 Then
                labelText = labelText.Replace("Seconds", "Second")
            End If

            Label4.Text = labelText

            If mysteryBoxImage.Tag = "LargeMysteryBox" Then
                mysteryBoxImage.Image = My.Resources.MysteryBox
                mysteryBoxImage.Tag = "MysteryBox"
                itemName.Text = "Mystery Box"
                itemPrice.Text = "Price: 50 Diamonds"
            End If
        Else
            Dim totalSeconds As Integer = (Launcher.serverTime.TimeOfDay.Hours * 60 * 60) + (Launcher.serverTime.TimeOfDay.Minutes * 60) + Launcher.serverTime.TimeOfDay.Seconds
            Dim remainingSeconds As Double = 90000 - totalSeconds
            Dim nextMonday As DateTime = Launcher.serverTime.AddSeconds(remainingSeconds)
            Dim remainingTime As TimeSpan = nextMonday - DateTime.Now

            Dim labelText As String = "Large Mystery Box is available for: "
            If remainingTime.Hours > 0 Then
                labelText &= remainingTime.Hours & " Hours, "
            End If
            If remainingTime.Minutes > 0 Then
                labelText &= remainingTime.Minutes & " Minutes, "
            End If
            labelText &= remainingTime.Seconds & " Seconds"

            If remainingTime.Days = 1 Then
                labelText.Replace("Days", "Day")
            End If
            If remainingTime.Hours = 1 Then
                labelText.Replace("Hours", "Hours")
            End If
            If remainingTime.Minutes = 1 Then
                labelText.Replace("Minutes", "Minutes")
            End If
            If remainingTime.Seconds = 1 Then
                labelText.Replace("Seconds", "Second")
            End If

            Label4.Text = labelText

            If mysteryBoxImage.Tag = "MysteryBox" Then
                mysteryBoxImage.Image = My.Resources.LargeMysteryBox
                mysteryBoxImage.Tag = "LargeMysteryBox"
                itemName.Text = "Large Mystery Box"
                itemPrice.Text = "Price: 75 Diamonds"
            End If
        End If

        CheckOwnedItems()
    End Sub

    Private Sub diamondBuyBtn1_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn1.Click
        Launcher.SendToServer("MysteryBox")
    End Sub

    Public Sub CheckOwnedItems()
        If Launcher.LunarLantern <> "0" Then
            Starcaller.Font = New Font(Starcaller.Font, Starcaller.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.HeartOfFire <> "0" Then
            Firelord.Font = New Font(Firelord.Font, Firelord.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.Stormborn <> "0" Then
            Stormborn.Font = New Font(Stormborn.Font, Stormborn.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.Rexterra <> "0" Then
            Rexterra.Font = New Font(Rexterra.Font, Rexterra.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.Tidemaster <> "0" Then
            Tidemaster.Font = New Font(Tidemaster.Font, Tidemaster.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.GoldSarcophagus <> "0" Then
            GoldSarchopagus.Font = New Font(GoldSarchopagus.Font, GoldSarchopagus.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.customTitle <> "0" Then
            CustomTitle.Font = New Font(CustomTitle.Font, CustomTitle.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.classifiedRank <> "0" Then
            ClassifiedAccess.Font = New Font(ClassifiedAccess.Font, ClassifiedAccess.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.MeItem <> "0" Then
            MeCommand.Font = New Font(MeCommand.Font, MeCommand.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.italicItem <> "0" Then
            ItalicChatFont.Font = New Font(ItalicChatFont.Font, ItalicChatFont.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.boldItem <> "0" Then
            BoldChatFont.Font = New Font(BoldChatFont.Font, BoldChatFont.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.fontItem <> "0" Then
            CustomFont.Font = New Font(CustomFont.Font, CustomFont.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.underlineItem <> "0" Then
            UnderlineChatFont.Font = New Font(UnderlineChatFont.Font, UnderlineChatFont.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.BlueChatColor <> "0" Then
            BlueChatColor.Font = New Font(BlueChatColor.Font, BlueChatColor.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.GreenChatColor <> "0" Then
            GreenChatColor.Font = New Font(GreenChatColor.Font, GreenChatColor.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.PinkChatColor <> "0" Then
            PinkChatColor.Font = New Font(PinkChatColor.Font, PinkChatColor.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.RedChatColor <> "0" Then
            RedChatColor.Font = New Font(RedChatColor.Font, RedChatColor.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.RainbowChatColor <> "0" Then
            RainbowChatColor.Font = New Font(RainbowChatColor.Font, RainbowChatColor.Font.Style Or FontStyle.Strikeout)
        End If
        If Launcher.FBIChatColor <> "0" Then
            FBIChatColor.Font = New Font(FBIChatColor.Font, FBIChatColor.Font.Style Or FontStyle.Strikeout)
        End If
    End Sub
End Class