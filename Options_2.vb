Imports System
Imports System.IO
Imports System.Text

Public Class Options_2

    Dim filename As String = ""
    Public Current As String = Directory.GetCurrentDirectory

    Private Sub Options_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorDialog1.AllowFullOpen = False
        ColorDialog1.FullOpen = False
        PictureBox1.BackColor = My.Settings.Curator
        PictureBox2.BackColor = My.Settings.TypeText
        PictureBox3.BackColor = My.Settings.Moderator
        PictureBox4.BackColor = My.Settings.GlobalModerator
        PictureBox5.BackColor = My.Settings.Administrator
        PictureBox6.BackColor = My.Settings.Owner
        PictureBox7.BackColor = My.Settings.PlatinumMember
        PictureBox8.BackColor = My.Settings.EventManager
        PictureBox9.BackColor = My.Settings.GoldMember
        PictureBox10.BackColor = My.Settings.Bot
        PictureBox11.BackColor = My.Settings.System
        PictureBox12.BackColor = My.Settings.Player
        PictureBox13.BackColor = My.Settings.Userlist
        PictureBox14.BackColor = My.Settings.Search
        PictureBox18.BackColor = My.Settings.TextColor
        PictureBox19.BackColor = My.Settings.FBI
        PictureBox21.BackColor = My.Settings.DiamondMember
        TextBox1.Text = My.Settings.ChatMessages

        If My.Settings.DUC = 0 Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
        If My.Settings.DRC = 0 Then
            CheckBox2.Checked = False
        Else
            CheckBox2.Checked = True
        End If
        If My.Settings.DTC = 0 Then
            CheckBox6.Checked = False
        Else
            CheckBox6.Checked = True
        End If
        If My.Settings.STS = 0 Then
            CheckBox5.Checked = False
        Else
            CheckBox5.Checked = True
        End If
        If My.Settings.showTeam = True Then
            showTeam.Checked = True
        Else
            showTeam.Checked = False
        End If
        If My.Settings.showTitle = True Then
            showTitle.Checked = True
        Else
            showTitle.Checked = False
        End If
        If My.Settings.ColoredMessages = True Then
            CheckBox7.Checked = True
        Else
            CheckBox7.Checked = False
        End If
        If My.Settings.ShowPostDuelMessages = 1 Then
            showPostDuelMessages.Checked = True
        Else
            showPostDuelMessages.Checked = False
        End If
        If My.Settings.showAdvertisements = True Then
            showAdvertisements.Checked = True
        Else
            showAdvertisements.Checked = False
        End If

        banlistCmBox.Text = My.Settings.hostBanlist
        allowedCardsCmBox.Text = My.Settings.hostAllowedCards
        duelModeCmBox.Text = My.Settings.hostDuelMode
        masterRulesCmBox.Text = My.Settings.hostMasterRules

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
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        My.Settings.TypeText = PictureBox2.BackColor
        My.Settings.Moderator = PictureBox3.BackColor
        My.Settings.GlobalModerator = PictureBox4.BackColor
        My.Settings.Administrator = PictureBox5.BackColor
        My.Settings.Owner = PictureBox6.BackColor
        My.Settings.PlatinumMember = PictureBox7.BackColor
        My.Settings.EventManager = PictureBox8.BackColor
        My.Settings.GoldMember = PictureBox9.BackColor
        My.Settings.Bot = PictureBox10.BackColor
        My.Settings.System = PictureBox11.BackColor
        My.Settings.Player = PictureBox12.BackColor
        My.Settings.Userlist = PictureBox13.BackColor
        My.Settings.Search = PictureBox14.BackColor
        My.Settings.TextColor = PictureBox18.BackColor
        My.Settings.FBI = PictureBox19.BackColor
        My.Settings.DiamondMember = PictureBox21.BackColor
        If Val(TextBox1.Text) >= 0 Then
            My.Settings.ChatMessages = Val(TextBox1.Text)
        Else
            My.Settings.ChatMessages = 100
        End If

        If CheckBox1.Checked = True Then
            My.Settings.DUC = 1
        Else
            My.Settings.DUC = 0
        End If
        If CheckBox2.Checked = True Then
            My.Settings.DRC = 1
        Else
            My.Settings.DRC = 0
        End If
        If CheckBox6.Checked = True Then
            My.Settings.DTC = 1
        Else
            My.Settings.DTC = 0
        End If
        If CheckBox5.Checked = True Then
            My.Settings.STS = 1
        Else
            My.Settings.STS = 0
        End If
        If showTeam.Checked = True Then
            My.Settings.showTeam = True
        Else
            My.Settings.showTeam = False
        End If
        If showTitle.Checked = True Then
            My.Settings.showTitle = True
        Else
            My.Settings.showTitle = False
        End If
        If CheckBox7.Checked = True Then
            My.Settings.ColoredMessages = True
        Else
            My.Settings.ColoredMessages = False
        End If
        If showAdvertisements.Checked = True Then
            My.Settings.showAdvertisements = True
        Else
            My.Settings.showAdvertisements = False
        End If

        Launcher.RichTextBox2.BackColor = My.Settings.TypeText
        Launcher.searchbar.BackColor = My.Settings.Search
        Launcher.ListBox1.BackColor = My.Settings.Userlist
        Launcher.ListBox2.BackColor = My.Settings.Userlist
        Launcher.ListBox4.BackColor = My.Settings.Userlist

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
        Me.Hide()
    End Sub

    Private Sub editGameSettingsBtn_Click(sender As Object, e As EventArgs) Handles editGameSettingsBtn.Click
        Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "system.CONF")
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
        objwriter.Write("roompass = Game")
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
        objwriter.Write(Environment.NewLine)
        objwriter.Write("bot_duel = 0")
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
        proc.StartInfo.Arguments = "-o"
        proc.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ColorDialog1.ShowDialog()
        PictureBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ColorDialog1.ShowDialog()
        PictureBox2.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ColorDialog1.ShowDialog()
        PictureBox3.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ColorDialog1.ShowDialog()
        PictureBox4.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        ColorDialog1.ShowDialog()
        PictureBox5.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        ColorDialog1.ShowDialog()
        PictureBox6.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        ColorDialog1.ShowDialog()
        PictureBox7.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        ColorDialog1.ShowDialog()
        PictureBox8.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        ColorDialog1.ShowDialog()
        PictureBox9.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        ColorDialog1.ShowDialog()
        PictureBox10.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        ColorDialog1.ShowDialog()
        PictureBox11.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        ColorDialog1.ShowDialog()
        PictureBox12.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        ColorDialog1.ShowDialog()
        PictureBox13.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        ColorDialog1.ShowDialog()
        PictureBox14.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        ColorDialog1.ShowDialog()
        PictureBox1.BackColor = ColorDialog1.Color
        PictureBox3.BackColor = ColorDialog1.Color
        PictureBox4.BackColor = ColorDialog1.Color
        PictureBox5.BackColor = ColorDialog1.Color
        PictureBox6.BackColor = ColorDialog1.Color
        PictureBox7.BackColor = ColorDialog1.Color
        PictureBox8.BackColor = ColorDialog1.Color
        PictureBox9.BackColor = ColorDialog1.Color
        PictureBox10.BackColor = ColorDialog1.Color
        PictureBox11.BackColor = ColorDialog1.Color
        PictureBox12.BackColor = ColorDialog1.Color
        PictureBox15.BackColor = ColorDialog1.Color
        PictureBox19.BackColor = ColorDialog1.Color
        PictureBox21.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        banlistCmBox.Text = "TCG"
        allowedCardsCmBox.Text = "TCG/OCG"
        duelModeCmBox.Text = "Single Duel"
        masterRulesCmBox.Text = "Rule 5 (April 2020)"
        turnTimerCmBox.SelectedIndex = 0
        dontShuffleDeckChb.Checked = False
        dontCheckDeckChb.Checked = False
        startingLP.Text = "8000"
        startingHand.Text = "5"
        cardsPerDraw.Text = "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.BackColor = My.Settings.DefaultCurator
        PictureBox2.BackColor = Color.White
        PictureBox3.BackColor = Color.Blue
        PictureBox4.BackColor = Color.Green
        PictureBox5.BackColor = Color.Red
        PictureBox6.BackColor = Color.Brown
        PictureBox7.BackColor = Color.Gray
        PictureBox8.BackColor = Color.HotPink
        PictureBox9.BackColor = Color.Goldenrod
        PictureBox10.BackColor = Color.Teal
        PictureBox11.BackColor = Color.Magenta
        PictureBox12.BackColor = Color.Black
        PictureBox13.BackColor = Color.White
        PictureBox14.BackColor = Color.White
        PictureBox18.BackColor = Color.Black
        PictureBox19.BackColor = Color.White
        PictureBox21.BackColor = Color.White
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        ColorDialog1.ShowDialog()
        PictureBox18.BackColor = ColorDialog1.Color
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        ColorDialog1.ShowDialog()
        PictureBox19.BackColor = ColorDialog1.Color
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        ColorDialog1.ShowDialog()
        PictureBox21.BackColor = ColorDialog1.Color
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