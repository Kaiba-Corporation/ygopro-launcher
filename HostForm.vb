Imports System.IO
Imports System.Text
Public Class HostForm
    Dim Current As String
    Dim a As String
    Dim b As String
    Dim c As String
    Dim d As String
    Dim f As String
    Dim g As String
    Dim h As String
    Dim gnfinal As String
    Dim port As String = 0
    Dim NewIP As String = 0
    Public gameType As String = "Unranked"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If gamename.Text.Contains(",") = False And gamename.Text.Contains(":") = False And gamename.Text.Contains(";") = False Then
            If gamename.Text <> "" Then

                If gameType = "Unranked" Then
                    a = 0
                Else
                    a = 1
                End If

                If a = 1 And Launcher.RankedStatus = 1 Then
                    MsgBox("You are not allowed to play ranked games!")
                    Return
                End If

                If a = 1 And Launcher.beta = True Then
                    MsgBox("Ranked games are disabled during the beta!")
                    Return
                End If

                If allowedCardsCmBox.Text = "TCG/OCG" Or allowedCardsCmBox.Text = "Same as Banlist" Then
                    If banlistCmBox.Text = "TCG" Then
                        b = 0
                    ElseIf banlistCmBox.Text = "OCG" Then
                        b = 1
                    ElseIf banlistCmBox.Text = "Traditional" Then
                        If gameType = "Ranked" Then
                            b = 0
                        Else
                            b = 2
                        End If
                    ElseIf banlistCmBox.Text = "No Banlist" Then
                        b = 3
                    Else
                        b = 0
                    End If
                ElseIf allowedCardsCmBox.Text = "TCG" Then
                    If banlistCmBox.Text = "TCG" Then
                        b = 4
                    ElseIf banlistCmBox.Text = "OCG" Then
                        b = 5
                    ElseIf banlistCmBox.Text = "Traditional" Then
                        b = 6
                    ElseIf banlistCmBox.Text = "No Banlist" Then
                        b = 7
                    Else
                        b = 4
                    End If
                ElseIf allowedCardsCmBox.Text = "OCG" Then
                    If banlistCmBox.Text = "TCG" Then
                        b = 8
                    ElseIf banlistCmBox.Text = "OCG" Then
                        b = 9
                    ElseIf banlistCmBox.Text = "Traditional" Then
                        b = "A"
                    ElseIf banlistCmBox.Text = "No Banlist" Then
                        b = "B"
                    Else
                        b = 8
                    End If
                Else
                    b = 0
                End If


                If duelModeCmBox.Text = "Single Duel" Then
                    c = 0
                ElseIf duelModeCmBox.Text = "Match Duel" Then
                    c = 1
                ElseIf duelModeCmBox.Text = "Tag Duel" Then
                    c = 2
                Else
                    c = 0
                End If

                d = 0
                If (dontCheckDeckChb.Checked) Then d += 1
                If (dontShuffleDeckChb.Checked) Then d += 2
                If (turnTimerCmBox.SelectedIndex = 1) Then d += 4

                If masterRulesCmBox.Text = "Rule 1 (Original)" Then
                    h = 1
                ElseIf masterRulesCmBox.Text = "Rule 2 (Synchro / XYZ)" Then
                    h = 2
                ElseIf masterRulesCmBox.Text = "Rule 3 (Pendulum)" Then
                    h = 3
                ElseIf masterRulesCmBox.Text = "Rule 4 (Links)" Then
                    h = 4
                ElseIf masterRulesCmBox.Text = "Rule 5 (April 2020)" Then
                    h = 5
                Else
                    a = 5
                    h = 2
                    b = 3
                End If

                Try
                    If startingHand.Text >= 0 And startingHand.Text < 16 Then
                        If startingHand.Text >= 0 And startingHand.Text < 10 Then
                            f = startingHand.Text
                        ElseIf startingHand.Text = 10 Then
                            f = "A"
                        ElseIf startingHand.Text = 11 Then
                            f = "B"
                        ElseIf startingHand.Text = 12 Then
                            f = "C"
                        ElseIf startingHand.Text = 13 Then
                            f = "D"
                        ElseIf startingHand.Text = 14 Then
                            f = "E"
                        ElseIf startingHand.Text = 15 Then
                            f = "F"
                        Else
                            MsgBox("This must be between 0 and 15")
                        End If
                    End If
                Catch
                    MsgBox("Starting hand must be a number!")
                End Try

                Try
                    If cardsPerDraw.Text >= 0 And cardsPerDraw.Text < 16 Then
                        If cardsPerDraw.Text >= 0 And cardsPerDraw.Text < 10 Then
                            g = cardsPerDraw.Text
                        ElseIf cardsPerDraw.Text = 10 Then
                            g = "A"
                        ElseIf cardsPerDraw.Text = 11 Then
                            g = "B"
                        ElseIf cardsPerDraw.Text = 12 Then
                            g = "C"
                        ElseIf cardsPerDraw.Text = 13 Then
                            g = "D"
                        ElseIf cardsPerDraw.Text = 14 Then
                            g = "E"
                        ElseIf cardsPerDraw.Text = 15 Then
                            g = "F"
                        Else
                            MsgBox("This must be between 0 and 15")
                        End If
                    End If
                Catch
                    MsgBox("Cards per draw must be a number!")
                End Try

                If gameType = "Ranked" Then
                    gnfinal = a & b & c & h & gamename.Text
                Else
                    gnfinal = a & b & c & h & d & f & g & "," & startingLP.Text & "," & gamename.Text
                End If

                Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "system.CONF")
                objwriter.Write("#config file")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("#nickname & gamename should be less than 20 characters")
                objwriter.Write(Environment.NewLine)
                If duelModeCmBox.Text = "Match Duel" Then
                    objwriter.Write("use_d3d = 0")
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("skin_index = -1")
                Else
                    objwriter.Write("use_d3d = " & My.Settings.UDX)
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("skin_index = " & My.Settings.US)
                End If
                objwriter.Write(Environment.NewLine)
                objwriter.Write("antialias = " & My.Settings.AA)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("errorlog = 0")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("nickname = " & Launcher.Username)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("gamename = Game")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("roompass = " & gnfinal)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
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
                If Launcher.Mute = 0 Then
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 0)
                Else
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 1)
                End If
                objwriter.Close()

                CardSkinManager.CopyFullCardDatabase()

                Dim proc As New Process()

                ChDir(Launcher.Current & "\YGOPRO")
                proc.StartInfo.FileName = Launcher.ygoproExe
                proc.StartInfo.Arguments = "-j"
                proc.Start()
                Me.Hide()

                Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                Dim r As New Random
                Dim sb As New StringBuilder
                For i As Integer = 1 To 7
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next
                gamename.Text = sb.ToString()
            Else
                MsgBox("The game name can't be empty!")
            End If
        Else
            MsgBox("Game Name shouldn't contain: ,:;")
        End If
    End Sub

    Private Sub Host_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 6
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        gamename.Text = sb.ToString()

        If gameType = "Ranked" Then
            banlistCmBox.Items.Clear()
            banlistCmBox.Items.Add("TCG")
            banlistCmBox.Items.Add("OCG")
            allowedCardsCmBox.Items.Clear()
            allowedCardsCmBox.Items.Add("Same as Banlist")
            masterRulesCmBox.Items.Clear()
            masterRulesCmBox.Items.Add("Rule 5 (April 2020)")
            masterRulesCmBox.SelectedIndex = 0
            duelModeCmBox.SelectedIndex = 0
            banlistCmBox.SelectedIndex = 0
            allowedCardsCmBox.SelectedIndex = 0
            turnTimerCmBox.SelectedIndex = 0

            allowedCardsCmBox.Enabled = False
            masterRulesCmBox.Enabled = False
            turnTimerCmBox.Enabled = False
            dontShuffleDeckChb.Enabled = False
            dontCheckDeckChb.Enabled = False
            startingLP.Enabled = False
            startingHand.Enabled = False
            cardsPerDraw.Enabled = False
        Else
            masterRulesCmBox.Text = My.Settings.hostMasterRules
            banlistCmBox.Text = My.Settings.hostBanlist
            allowedCardsCmBox.Text = My.Settings.hostAllowedCards
            duelModeCmBox.Text = My.Settings.hostDuelMode

            If My.Settings.hostDontRecoverTime Then
                turnTimerCmBox.SelectedIndex = 1
            Else
                turnTimerCmBox.SelectedIndex = 0
            End If
            If My.Settings.hostDontShuffleDeck Then
                dontShuffleDeckChb.Checked = True
            Else
                dontShuffleDeckChb.Checked = False
            End If
            If My.Settings.HostDontCheckDeck Then
                dontCheckDeckChb.Checked = True
            Else
                dontCheckDeckChb.Checked = False
            End If

            startingLP.Text = My.Settings.hostStartingLP
            startingHand.Text = My.Settings.hostStartingHand
            cardsPerDraw.Text = My.Settings.hostCardsPerDraw

            setAsDefaultBtn.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles setAsDefaultBtn.Click
        My.Settings.hostBanlist = banlistCmBox.Text
        My.Settings.hostAllowedCards = allowedCardsCmBox.Text
        My.Settings.hostDuelMode = duelModeCmBox.Text
        My.Settings.hostMasterRules = masterRulesCmBox.Text

        If turnTimerCmBox.SelectedIndex = 1 Then
            My.Settings.hostDontRecoverTime = True
        Else
            My.Settings.hostDontRecoverTime = False
        End If
        If dontShuffleDeckChb.Checked Then
            My.Settings.hostDontShuffleDeck = True
        Else
            My.Settings.hostDontShuffleDeck = False
        End If
        If dontCheckDeckChb.Checked Then
            My.Settings.HostDontCheckDeck = True
        Else
            My.Settings.HostDontCheckDeck = False
        End If

        My.Settings.hostStartingLP = startingLP.Text
        My.Settings.hostStartingHand = startingHand.Text
        My.Settings.hostCardsPerDraw = cardsPerDraw.Text

        My.Settings.Save()
        MsgBox("Settings have been saved as default!")
    End Sub

    Private Sub duelModeCmBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles duelModeCmBox.SelectedIndexChanged
        If gameType = "Ranked" Or (My.Settings.hostStartingLP = "8000" And My.Settings.hostDuelMode = "Single Duel") Or (My.Settings.hostStartingLP = "8000" And My.Settings.hostDuelMode = "Match Duel") Or (My.Settings.hostStartingLP = "16000" And My.Settings.hostDuelMode = "Tag Duel") Then
            If duelModeCmBox.SelectedIndex = 0 Or duelModeCmBox.SelectedIndex = 1 Then
                startingLP.Text = "8000"
            Else
                startingLP.Text = "16000"
            End If
        End If
    End Sub

    Private Sub masterRulesCmBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles masterRulesCmBox.SelectedIndexChanged
        If (masterRulesCmBox.SelectedIndex = 5) Then
            banlistCmBox.Enabled = False
            allowedCardsCmBox.Enabled = False

            banlistCmBox.Items.Clear()
            banlistCmBox.Items.Add("RUSH")
            banlistCmBox.SelectedIndex = 0
            allowedCardsCmBox.Items.Clear()
            allowedCardsCmBox.Items.Add("RUSH")
            allowedCardsCmBox.SelectedIndex = 0
            startingHand.Text = 4
        Else
            banlistCmBox.Enabled = True
            allowedCardsCmBox.Enabled = True

            banlistCmBox.Items.Clear()
            banlistCmBox.Items.Add("TCG")
            banlistCmBox.Items.Add("OCG")
            banlistCmBox.Items.Add("Traditional")
            banlistCmBox.Items.Add("No Banlist")
            banlistCmBox.SelectedIndex = 0
            allowedCardsCmBox.Items.Clear()
            allowedCardsCmBox.Items.Add("TCG/OCG")
            allowedCardsCmBox.Items.Add("TCG")
            allowedCardsCmBox.Items.Add("OCG")
            allowedCardsCmBox.SelectedIndex = 0
            startingHand.Text = 5
        End If
    End Sub
End Class