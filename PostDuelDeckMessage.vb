﻿Imports System.IO

Public Class PostDuelDeckMessage

    Public deckId As String
    Public deckName As String

    Public mainDeck() As String
    Public extraDeck() As String
    Public sideDeck() As String

    Private Sub PostDuelDeckMessage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        BringToFront()
    End Sub

    Private Sub viewDeckBtn_Click(sender As Object, e As EventArgs) Handles viewDeckBtn.Click
        If Not File.Exists(Launcher.Current & "\YGOPRO\deck\" & deckName & "-" & deckId & ".ydk") Then
            File.Create(Launcher.Current & "\YGOPRO\deck\" & deckName & "-" & deckId & ".ydk").Dispose()

            Dim objwriter As New StreamWriter(Launcher.Current & "\YGOPRO\deck\" & deckName & "-" & deckId & ".ydk")
            objwriter.WriteLine("#created by " & Launcher.Username)
            objwriter.WriteLine("#main")
            For Each card As String In mainDeck
                objwriter.WriteLine(card)
            Next
            objwriter.WriteLine("#extra")
            For Each card As String In extraDeck
                objwriter.WriteLine(card)
            Next
            objwriter.WriteLine("!side")
            For Each card As String In sideDeck
                objwriter.WriteLine(card)
            Next
            objwriter.Close()

            OpenDeckEditor(deckName & "-" & deckId)
            deckDeleteTimer.Start()
        Else
            MessageBox.Show("An error occurred while trying to view the deck, the deck with the same file name already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub claimPrizeBtn_Click(sender As Object, e As EventArgs) Handles claimPrizeBtn.Click
        Launcher.SendToServer("ClaimDeckReward" & Launcher.Splitter & deckId)
        Me.Hide()
    End Sub

    Private Sub refuseBtn_Click(sender As Object, e As EventArgs) Handles refuseBtn.Click
        Launcher.SendToServer("RefuseDeckReward" & Launcher.Splitter & deckId)
        Me.Hide()
    End Sub

    Sub OpenDeckEditor(ByVal deck As String)
        Dim objwriter As New StreamWriter(Launcher.Current & "\YGOPRO\" & "system.CONF")
        objwriter.Write("#config file")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("#nickname & gamename should be less than 20 characters")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("use_d3d = " & My.Settings.UDX)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("skin_index = " & My.Settings.US)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("antialias = " & My.Settings.AA)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("errorlog = 0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("nickname = " & Launcher.Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & deck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & Launcher.gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & Launcher.IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & Launcher.gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("fullscreen = " & My.Settings.FS)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("enable_sound = " & My.Settings.enableSound)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("sound_volume = " & My.Settings.SoundVolume)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("enable_music = " & My.Settings.enableMusic)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("music_volume = " & My.Settings.MusicVolume)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("auto_monster_placing = " & My.Settings.AMCP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("auto_spelltrap_placing = " & My.Settings.ASTCP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("random_card_placing = " & My.Settings.RCP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("auto_chain_order = " & My.Settings.ACO)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("no_delay_for_chain = " & My.Settings.NDFC)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("mute_chat = " & 1)
        objwriter.Close()

        CardSkinManager.CopyOwnedCardSkins()

        Dim proc As New Process()

        ChDir(Launcher.Current & "\YGOPRO")
        proc.StartInfo.FileName = Launcher.ygoproExe
        proc.StartInfo.Arguments = "-d"
        proc.Start()
    End Sub

    Private Sub deckDeleteTimer_Tick(sender As Object, e As EventArgs) Handles deckDeleteTimer.Tick
        Try
            File.Delete(Launcher.Current & "\YGOPRO\deck\" & deckName & "-" & deckId & ".ydk")
        Catch
        End Try

        deckDeleteTimer.Stop()
    End Sub

    Private Sub dontShowAgainChb_CheckedChanged(sender As Object, e As EventArgs) Handles dontShowAgainChb.CheckedChanged
        If dontShowAgainChb.Checked = True Then
            MsgBox("You can re-enable this feature from the Options!")
            My.Settings.ShowPostDuelDeckMessages = 0
            My.Settings.Save()
        Else
            My.Settings.ShowPostDuelDeckMessages = 1
            My.Settings.Save()
        End If
    End Sub
End Class