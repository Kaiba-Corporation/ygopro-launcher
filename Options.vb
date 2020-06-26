Imports System
Imports System.IO
Imports System.Text

Public Class Options

    Dim filename As String = ""
    Public Current As String = Directory.GetCurrentDirectory

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If My.Settings.UDX = 1 Then
            UDX.Checked = True
        Else
            UDX.Checked = False
        End If
        If My.Settings.US = 0 Then
            US.Checked = True
        Else
            US.Checked = False
        End If
        If My.Settings.FS = 1 Then
            FS.Checked = True
        Else
            FS.Checked = False
        End If
        If My.Settings.AA = 2 Then
            AA.Checked = True
        Else
            AA.Checked = False
        End If
        If My.Settings.AMCP = 1 Then
            AMCP.Checked = True
        Else
            AMCP.Checked = False
        End If
        If My.Settings.ASTCP = 1 Then
            ASTCP.Checked = True
        Else
            ASTCP.Checked = False
        End If
        If My.Settings.RCP = 1 Then
            RCP.Checked = True
        Else
            RCP.Checked = False
        End If
        If My.Settings.ACO = 1 Then
            ACO.Checked = True
        Else
            ACO.Checked = False
        End If
        If My.Settings.NDFC = 1 Then
            NDFC.Checked = True
        Else
            NDFC.Checked = False
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
        If My.Settings.enableMusic = 1 Then
            enableMusic.Checked = True
        Else
            enableMusic.Checked = False
        End If
        If My.Settings.enableSound = 1 Then
            enableSound.Checked = True
        Else
            enableSound.Checked = False
        End If

        musicTrackBar.Value = My.Settings.MusicVolume
        soundTrackBar.Value = My.Settings.SoundVolume

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

        SetAllImages()
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UDX.Checked = True
        US.Checked = True
        AA.Checked = True
        FS.Checked = False
        AMCP.Checked = True
        RCP.Checked = False
        ACO.Checked = True
        NDFC.Checked = False
        AMCP.Checked = False
        ASTCP.Checked = True
        enableMusic.Checked = True
        enableSound.Checked = True
        musicTrackBar.Value = 30
        soundTrackBar.Value = 30
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

    Private Sub ClearImage()
        pctbAttack.Image = Nothing
        pctbActivatePic.Image = Nothing
        pctbBg.Image = Nothing
        pctbChain.Image = Nothing
        pctbCisor.Image = Nothing
        pctbEquip.Image = Nothing
        pctbField.Image = Nothing
        pctbField2.Image = Nothing
        pctbNegated.Image = Nothing
        pctbPaper.Image = Nothing
        pctbSleeve.Image = Nothing
        pctbStone.Image = Nothing
        pctbTarget.Image = Nothing
        pctbUnknown.Image = Nothing
    End Sub

    Private Sub SetAllImages()
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\Bg.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            pctbBg.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\cover.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            pctbSleeve.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\f1.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            pctbCisor.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\f3.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            pctbPaper.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\f2.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            pctbStone.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\unknown.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            pctbUnknown.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\act.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbActivatePic.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\equip.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbEquip.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\chain.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbChain.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\negated.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbNegated.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\target.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbTarget.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\attack.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbAttack.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\field.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbField.Image = System.Drawing.Image.FromStream(fs)
        End Using
        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\field-transparent.png", IO.FileMode.Open, IO.FileAccess.Read)
            pctbField2.Image = System.Drawing.Image.FromStream(fs)
        End Using
    End Sub

    Sub ChangeJPGImage(ByVal imageName As String)
        'Variable to make the Image Picker
        Dim filepik As New OpenFileDialog

        'Root from where the Image Picker will start
        filepik.InitialDirectory = "C:\Users\Owner\Pictures"
        'Extention available
        filepik.Filter = "jpg file|*.jpg"

        filename = imageName

        'Using the selected image, will change it using the root from appData, concatenating the file's names and concatenating the selected filename
        If filepik.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileCopy(filepik.FileName, Launcher.Current & "\YGOPRO\textures\" & filename.ToString)
        End If

        SetAllImages()
    End Sub

    Sub ChangePNGImage(ByVal imageName As String)
        'Variable to make the Image Picker
        Dim filepik As New OpenFileDialog

        'Root from where the Image Picker will start
        filepik.InitialDirectory = "C:\Users\Owner\Pictures"
        'Extention available
        filepik.Filter = "png file|*.png"

        filename = imageName

        'Using the selected image, will change it using the root from appData, concatenating the file's names and concatenating the selected filename
        If filepik.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileCopy(filepik.FileName, Launcher.Current & "\YGOPRO\textures\" & filename.ToString & ".png")
        End If

        SetAllImages()
    End Sub

    Private Sub pctbBg_Click(sender As Object, e As EventArgs) Handles pctbBg.Click
        ChangeJPGImage("bg.jpg")
    End Sub

    Private Sub pctbPaper_Click(sender As Object, e As EventArgs) Handles pctbPaper.Click
        ChangeJPGImage("f3.jpg")
    End Sub

    Private Sub pctbCisor_Click(sender As Object, e As EventArgs) Handles pctbCisor.Click
        ChangeJPGImage("f1.jpg")
    End Sub

    Private Sub pctbStone_Click(sender As Object, e As EventArgs) Handles pctbStone.Click
        ChangeJPGImage("f2.jpg")
    End Sub

    Private Sub pctbSleeve_Click(sender As Object, e As EventArgs) Handles pctbSleeve.Click
        ChangeJPGImage("cover.jpg")
    End Sub

    Private Sub pctbUnknown_Click(sender As Object, e As EventArgs) Handles pctbUnknown.Click
        ChangeJPGImage("unknown.jpg")
    End Sub

    Private Sub pctbActivatePic_Click(sender As Object, e As EventArgs) Handles pctbActivatePic.Click
        ChangePNGImage("act")
    End Sub

    Private Sub pctbChain_Click(sender As Object, e As EventArgs) Handles pctbChain.Click
        ChangePNGImage("chain")
    End Sub

    Private Sub pctbEquip_Click(sender As Object, e As EventArgs) Handles pctbEquip.Click
        ChangePNGImage("equip")
    End Sub

    Private Sub pctbAttack_Click(sender As Object, e As EventArgs) Handles pctbAttack.Click
        ChangePNGImage("attack")
    End Sub

    Private Sub pctbNegated_Click(sender As Object, e As EventArgs) Handles pctbNegated.Click
        ChangePNGImage("negated")
    End Sub

    Private Sub pctbTarget_Click(sender As Object, e As EventArgs) Handles pctbTarget.Click
        ChangePNGImage("target")
    End Sub

    Private Sub pctbField_Click(sender As Object, e As EventArgs) Handles pctbField.Click
        ChangePNGImage("field")
    End Sub

    Private Sub pctbField2_Click(sender As Object, e As EventArgs) Handles pctbField2.Click
        ChangePNGImage("field-transparent")
    End Sub

    Private Sub btnTestSong_Click(sender As Object, e As EventArgs) Handles btnTestSong.Click
        Dim soundName As String = ""
        If (rbnActivate.Checked) Then
            soundName = "activate.wav"
        ElseIf (rbnAddCounter.Checked) Then
            soundName = "addcounter.wav"
        ElseIf (rbnAttack.Checked) Then
            soundName = "attack.wav"
        ElseIf (rbnCoinFlip.Checked) Then
            soundName = "coinflip.wav"
        ElseIf (rbnChatMsg.Checked) Then
            soundName = "chatmessage.wav"
        ElseIf (rbnDmg.Checked) Then
            soundName = "damage.wav"
        ElseIf (rbnDiceRoll.Checked) Then
            soundName = "diceroll.wav"
        ElseIf (rbnDraw.Checked) Then
            soundName = "draw.wav"
        ElseIf (rbnEquip.Checked) Then
            soundName = "equip.wav"
        ElseIf (rbnFlip.Checked) Then
            soundName = "flip.wav"
        ElseIf (rbnGainLP.Checked) Then
            soundName = "gainlp.wav"
        ElseIf (rbnNextTurn.Checked) Then
            soundName = "nextturn.wav"
        ElseIf (rbnPhase.Checked) Then
            soundName = "phase.wav"
        ElseIf (rbnPlayerEnter.Checked) Then
            soundName = "playerenter.wav"
        ElseIf (rbnRemoveCounter.Checked) Then
            soundName = "removecounter.wav"
        ElseIf (rbnSet.Checked) Then
            soundName = "set.wav"
        ElseIf (rbnShuffle.Checked) Then
            soundName = "shuffle.wav"
        ElseIf (rbnSpecialSummon.Checked) Then
            soundName = "specialsummon.wav"
        ElseIf (rbnSpecSummon2.Checked) Then
            soundName = "specialsummon2.wav"
        ElseIf (rbnSummon.Checked) Then
            soundName = "summon.wav"
        ElseIf (rbnDeckSound.Checked) Then
            soundName = "deck.mp3"
        ElseIf (rbnDeck2Sound.Checked) Then
            soundName = "deck2.mp3"
        ElseIf (rbnDeck3Sound.Checked) Then
            soundName = "deck3.mp3"
        ElseIf (rbnDeck4Sound.Checked) Then
            soundName = "deck4.mp3"
        ElseIf (rbnMenuSound.Checked) Then
            soundName = "menu.mp3"
        ElseIf (rbnMenu2Sound.Checked) Then
            soundName = "menu2.mp3"
        ElseIf (rbnSong.Checked) Then
            soundName = "song.mp3"
        ElseIf (rbnSong2.Checked) Then
            soundName = "song2.mp3"
        ElseIf (rbnSongDisadvantage.Checked) Then
            soundName = "song-disadvantage.mp3"
        ElseIf (rbnSongDisadvantage2.Checked) Then
            soundName = "song-disadvantage2.mp3"
        ElseIf (rbnSongDisadvantage3.Checked) Then
            soundName = "song-disadvantage3.mp3"
        End If

        Using fs As New System.IO.FileStream(Launcher.Current & "\YGOPRO\textures\Bg.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            pctbBg.Image = System.Drawing.Image.FromStream(fs)

        End Using

        Try
            CloseFile()
            OpenFile(Launcher.Current & "\YGOPRO\sound\" & soundName.ToString)
            PlayFile(False)
        Catch
            MsgBox("File doesn't exist!")
        End Try
    End Sub

    Private _command As String
    Private isOpen As Boolean

    <System.Runtime.InteropServices.DllImport("winmm.dll")>
    Private Shared Function mciSendString(strCommand As String, strReturn As StringBuilder, iReturnLength As Integer, hwndCallback As IntPtr) As Long
    End Function

    Public Sub CloseFile()
        _command = "close MediaFile"
        mciSendString(_command, Nothing, 0, IntPtr.Zero)
        isOpen = False
    End Sub

    Public Sub OpenFile(sFileName As String)
        _command = "open """ & sFileName & """ type mpegvideo alias MediaFile"
        mciSendString(_command, Nothing, 0, IntPtr.Zero)
        isOpen = True
    End Sub

    Public Sub PlayFile([loop] As Boolean)
        If isOpen Then
            _command = "play MediaFile"
            If [loop] Then
                _command += " REPEAT"
            End If
            mciSendString(_command, Nothing, 0, IntPtr.Zero)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filesong As New OpenFileDialog

        Dim soundName As String = ""
        If (rbnActivate.Checked) Then
            soundName = "activate.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnAddCounter.Checked) Then
            soundName = "addcounter.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnAttack.Checked) Then
            soundName = "attack.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnCoinFlip.Checked) Then
            soundName = "coinflip.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnChatMsg.Checked) Then
            soundName = "chatmessage.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnDmg.Checked) Then
            soundName = "damage.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnDiceRoll.Checked) Then
            soundName = "diceroll.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnDraw.Checked) Then
            soundName = "draw.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnEquip.Checked) Then
            soundName = "equip.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnFlip.Checked) Then
            soundName = "flip.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnGainLP.Checked) Then
            soundName = "gainlp.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnNextTurn.Checked) Then
            soundName = "nextturn.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnPhase.Checked) Then
            soundName = "phase.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnPlayerEnter.Checked) Then
            soundName = "playerenter.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnRemoveCounter.Checked) Then
            soundName = "removecounter.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnSet.Checked) Then
            soundName = "set.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnShuffle.Checked) Then
            soundName = "shuffle.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnSpecialSummon.Checked) Then
            soundName = "specialsummon.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnSpecSummon2.Checked) Then
            soundName = "specialsummon2.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnSummon.Checked) Then
            soundName = "summon.wav"
            filesong.Filter = "wav file|*.wav"
        ElseIf (rbnDeckSound.Checked) Then
            soundName = "deck.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnDeck2Sound.Checked) Then
            soundName = "deck2.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnDeck3Sound.Checked) Then
            soundName = "deck3.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnDeck4Sound.Checked) Then
            soundName = "deck4.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnMenuSound.Checked) Then
            soundName = "menu.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnMenu2Sound.Checked) Then
            soundName = "menu2.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnSong.Checked) Then
            soundName = "song.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnSong2.Checked) Then
            soundName = "song2.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnSongDisadvantage.Checked) Then
            soundName = "song-disadvantage.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnSongDisadvantage2.Checked) Then
            soundName = "song-disadvantage2.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        ElseIf (rbnSongDisadvantage3.Checked) Then
            soundName = "song-disadvantage3.mp3"
            filesong.Filter = "mp3 file|*.mp3"
        End If

        If filesong.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CloseFile()
            FileCopy(filesong.FileName, Launcher.Current & "\YGOPRO\sound\" & soundName.ToString)
            MsgBox("Sound Changed!")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ColorDialog1.ShowDialog()
        PictureBox1.BackColor = ColorDialog1.Color
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
        If UDX.Checked = True Then
            My.Settings.UDX = 1
        Else
            My.Settings.UDX = 0
        End If
        If US.Checked = True Then
            My.Settings.UDX = 1
            My.Settings.US = 0
        Else
            My.Settings.US = -1
        End If
        If FS.Checked = True Then
            My.Settings.FS = 1
        Else
            My.Settings.FS = 0
        End If
        If AA.Checked = True Then
            My.Settings.AA = 2
        Else
            My.Settings.AA = 0
        End If
        If AMCP.Checked = True Then
            My.Settings.AMCP = 1
        Else
            My.Settings.AMCP = 0
        End If
        If ASTCP.Checked = True Then
            My.Settings.ASTCP = 1
        Else
            My.Settings.ASTCP = 0
        End If
        If RCP.Checked = True Then
            My.Settings.RCP = 1
        Else
            My.Settings.RCP = 0
        End If
        If ACO.Checked = True Then
            My.Settings.ACO = 1
        Else
            My.Settings.ACO = 0
        End If
        If NDFC.Checked = True Then
            My.Settings.NDFC = 1
        Else
            My.Settings.NDFC = 0
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
        If enableMusic.Checked = True Then
            My.Settings.enableMusic = 1
        Else
            My.Settings.enableMusic = 0
        End If
        If enableSound.Checked = True Then
            My.Settings.enableSound = 1
        Else
            My.Settings.enableSound = 0
        End If

        My.Settings.MusicVolume = musicTrackBar.Value
        My.Settings.SoundVolume = soundTrackBar.Value

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