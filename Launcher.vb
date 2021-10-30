Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Threading.Thread
Imports System.Management
Imports System.Environment

Public Class Launcher
    Public storeControl As StoreControl
    Public teamPage As TeamPage
    Public frontDuelPage As New FrontDuelPage
    Public singlePlayerDuelPage As SinglePlayerDuelPage
    Public duelingRobot As DuelingRobot
    Public skillTests As SkillTests
    Public pvpDuelPage As PvPDuelPage
    Public gameList As GameList
    Public tournamentPage As TournamentList

    Public Splitter As String = "<{]>"

    Public GameCount As Integer
    Public GameCountX As Integer
    Public Current As String = Directory.GetCurrentDirectory
    Public UserID As String
    Public Username As String
    Public Token As String
    Public MyTeam As String
    Public MyRating As String
    Public MyGold As String
    Public MyWin As String
    Public MyDraw As String
    Public MyLost As String
    Public MyTRating As String
    Public MyTWin As String
    Public MyTDraw As String
    Public MyTLost As String
    Public MyMRating As String
    Public MyMWin As String
    Public MyMDraw As String
    Public MyMLost As String
    Public MyQualification As String
    Public MyA1 As String
    Public MyA2 As String
    Public MyA3 As String
    Public MyTitle As String
    Public JD1 As String = 0
    Public Mute As String
    Public RankedStatus As Integer = 0
    Public MeItem As String = 0
    Public ForumBooster As String = 0
    Public ForumTurboCharger As String = 0
    Public ExtraForumPayout As String = 0
    Public LunarLantern As String = 0
    Public HeartOfFire As String = 0
    Public Stormborn As String = 0
    Public Rexterra As String = 0
    Public Tidemaster As String = 0
    Public TournamentHosting As String = 0
    Public boldItem As String = 0
    Public italicItem As String = 0
    Public underlineItem As String = 0
    Public strikeoutItem As String = 0
    Public fontItem As String = 0
    Public customTitle As String = 0
    Public emoticonPackOne As String = 0
    Public emoticonPackTwo As String = 0
    Public TournamentItem As String = 0
    Public XP As String
    Public TeamLeader As Boolean = False
    Public TeamLeaderUsername As String
    Public TeamColeader As Boolean = False
    Public extraMemberItem As Integer = 0
    Public teamQuote As Integer = 0
    Public NewUsernameN As Integer = 0
    Dim pusername As String
    Public Rank As String = "Player"
    Public Servers As New List(Of String)
    Public IP As String = "127.0.0.1"
    Public BannedWordList As New List(Of String)
    Public WP As Integer = 0
    Public AdminList As New List(Of String)
    Dim formnumber As Integer = -1
    Dim newForm As New List(Of PrivateChat)
    Public SecureCode As String
    Public CustomUsernameColor As String = 0
    Public AvatarItem As String = 0
    Public CardBackItem As String = 0
    Public Nightshade As String = 0
    Public LordOfLight As String = 0
    Public AdBlock As String = 0
    Public CustomBorder As String = 0

    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As TcpClient
    Private t As Threading.Thread
    Private Delegate Sub DAddItem(ByVal s As String)

    Dim x As Integer = 0
    Public LoadAd As Boolean = False
    Public ChallengeUser As String = ""
    Public ServerConnectionStatus As Boolean = False
    Public mutechat As Integer = 0
    Public Link1 As String
    Public Link2 As String
    Public SelectedChannel As String = "Public Channel"
    Public myChannels As New List(Of String)
    Public classifiedRank As Integer = 0
    Public GoldSarcophagus As Integer = 0
    Public onlineuserlist As New List(Of String)
    Public achievements As New List(Of String)
    Public multiusers As New List(Of String)
    Public ChatScroll As Boolean = True
    Public strikes As Integer = 0

    Public BlueChatColor As Integer = 0
    Public GreenChatColor As Integer = 0
    Public RedChatColor As Integer = 0
    Public PinkChatColor As Integer = 0
    Public FBIChatColor As Integer = 0
    Public RainbowChatColor As Integer = 0

    Public LastKaibaDeck As Integer = 8
    Public LastYugiDeck As Integer = 5
    Public LastMarikDeck As Integer = 5

    Dim newCheck As Boolean = True
    Dim ipList As New List(Of String)
    Dim macList As New List(Of String)
    Dim uniqueidList As New List(Of String)

    Public ticketList As New List(Of Ticket)
    Public staffTicketList As New List(Of Ticket)
    Public tournamentList As New List(Of TournamentControl)
    Public itemList As New List(Of Item)

    Public timedWordList As New List(Of Double)

    Public disposeStoreControl As Boolean = False

    Public ignoreList As New List(Of String)
    Public ignoreMessage As String = ""

    Public chatMessage1 As String
    Public chatMessage2 As String

    Public loggedIn As Boolean = False

    Public rtfUsed As Boolean = False

    Public ownedCardSkins As New List(Of String)

    Public DefaultDeckWatcher As FileSystemWatcher

    Public rankedQueueTime As Integer = 0
    Public inQueue As Boolean = False

    Public CampaignProgress As Integer = 1

    Public serverTime As New DateTime

    Public customTextColor As String = 0
    Public customPrivateChat As String = 0

    Public privateChatImageLink As String
    Public privateChatImageOpacity As Integer
    Public privateChatBorderColor As String
    Public privateChatMyTextColor As String
    Public privateChatPartnerTextColor As String
    Public privateChatTypingTextColor As String
    Public privateChatTopBorderVisible As Integer
    Public privateChatBottomBorderVisible As Integer

    Public lightStatus As Integer = 0

    Public country As String

    Public socialMediaPMsSent As Integer = 0

    Public pmType As Integer = 0
    Public pmStep As Integer = 0
    Public pmStep2 As Integer = 0
    Public currentMonthlyDonations As Double = 0

    Dim sessionStatus As String

    Dim Version As String = "5.35.0.5374"
    Dim Version_2 As String = "1.25.0.1974"

    Public chatPort As Integer = 2080
    Public gamePort As Integer = 7000

    Public beta As Boolean = False

    Public launcherEdition As Integer = 1
    Public ygoproExe As String = "YGOPRO.exe "
    Public ygoproUrl1 As String = "http://ygopro.org/TDOANE.php"
    Public ygoproUrl2 As String = "http://tdoane.com/TDOANE.php"
    Public ygoproUrl3 As String = "http://playugioh.com/TDOANE.php"

    Private Sub Launcher_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Launcher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()

        Try
            If My.Settings.US = 1 Then
                My.Settings.US = 0
            End If

            ListBox2.Items.Clear()
            ListBox4.Items.Clear()
        Catch
        End Try

        If launcherEdition = 2 Then
            Version = Version_2

            If System.Environment.Is64BitOperatingSystem = True Then
                ygoproExe = "YGOPRO_64.exe "
            Else
                ygoproExe = "YGOPRO_32.exe "
            End If

            ygoproUrl1 = "http://ygopro.org/TDOANE2.php"
            ygoproUrl2 = "http://tdoane.com/TDOANE2.php"
            ygoproUrl3 = "http://playugioh.com/TDOANE2.php"
        End If

        gameVersion.Text = "Version: " & Version
        gameVersion.Location = New Point(Me.Width - (gameVersion.Size.Width + 7), gameVersion.Location.Y)

        AdminList.Add("J.A.R.V.I.S.:Bot")

        If (My.Settings.Language = "German") Then
            ComboBox1.SelectedIndex = 1
        ElseIf (My.Settings.Language = "French") Then
            ComboBox1.SelectedIndex = 2
        ElseIf (My.Settings.Language = "Spanish") Then
            ComboBox1.SelectedIndex = 3
        Else
            ComboBox1.SelectedIndex = 0
        End If

        If My.Settings.ToS = 0 Then
            CheckBox2.Checked = False
        Else
            CheckBox2.Checked = True
        End If

        If My.Settings.SavedCheck = 0 Then
            CheckBox4.Checked = False
        Else
            TextBox1.Text = My.Settings.SavedUsername
            TextBox2.Text = My.Settings.SavedPassword
            sessionStatus = My.Settings.SessionStatus
            CheckBox4.Checked = True
        End If

        RichTextBox2.BackColor = My.Settings.TypeText
        searchbar.BackColor = My.Settings.Search
        ListBox1.BackColor = My.Settings.Userlist
        ListBox2.BackColor = My.Settings.Userlist
        ListBox4.BackColor = My.Settings.Userlist
    End Sub

    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        Try
            Label12.Text = "Connecting..."
            If My.Settings.SavedCheck = 1 Then
                My.Settings.SavedUsername = TextBox1.Text
                My.Settings.Save()
            End If
            If CheckBox2.Checked = True Then
                If My.Settings.NRun = 1 Then
                    My.Settings.NRun = 2
                    My.Settings.Administrator = Color.Red
                    My.Settings.FBI = Color.White
                    My.Settings.System = Color.Magenta
                End If
                My.Settings.ToS = 1

                My.Settings.Save()
                Username = TextBox1.Text
                If ServerConnectionStatus = False Then
                    DownloadData()
                    ServerConnectionStatus = True
                End If
            Else
                MsgBox("You must agree to Terms of Use!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Please visit our forum http://ygopro.club for more information!")
        End Try
    End Sub

    Sub DownloadData()
        Try
            Dim Client As New WebClient()
            Dim Url As String
            Dim HTML As String
            Dim sParts() As String
            Try
                Url = ygoproUrl1
                HTML = Client.DownloadString(New Uri(Url))
            Catch
                Try
                    Url = ygoproUrl2
                    HTML = Client.DownloadString(New Uri(Url))
                Catch
                    Url = ygoproUrl3
                    HTML = Client.DownloadString(New Uri(Url))
                End Try
            End Try
            sParts = Split(HTML, ",")
            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                If sParts(0) = Version Then
                    IP = sParts(1)
                    country = sParts(2)
                    CheckBannedWords.CreateBannedWords()
                    ComputerCode()
                    ConnectToLoginServer()
                Else
                    Try
                        File.Create(Current & "\CurrentVersion.txt").Dispose()
                    Catch
                    End Try
                    If System.IO.File.Exists(Current & "\CurrentVersion.txt") = True Then
                        Dim objWriter As New System.IO.StreamWriter(Current & "\CurrentVersion.txt")
                        Dim zParts() As String
                        zParts = Split(Version, ".")
                        objWriter.Write(zParts(3))
                        objWriter.Close()
                    End If
                    Try
                        Dim proc As New Process()
                        proc.StartInfo.FileName = Current & "\Auto Updater.exe"
                        proc.Start()
                        Application.Exit()
                    Catch
                        MsgBox("Unable to load the Auto Updater, please download the full version of them game from www.playugioh.com!")
                    End Try
                End If
            Else
                MsgBox("Please enter your username and password!")
            End If
        Catch
            MessageBox.Show("Unable to check for updates or download the server list, Please try again in 30 seconds, if the problem persists please check http://tdoane.com or http://playugioh.com for asistance, there might be a new version available!")
        End Try
    End Sub
    Sub DownloadDataRegister()
        Try
            Dim Client As New WebClient()
            Dim Url As String
            Dim HTML As String
            Dim sParts() As String
            Try
                Url = ygoproUrl1
                HTML = Client.DownloadString(New Uri(Url))
            Catch
                Try
                    Url = ygoproUrl2
                    HTML = Client.DownloadString(New Uri(Url))
                Catch
                    Url = ygoproUrl3
                    HTML = Client.DownloadString(New Uri(Url))
                End Try
            End Try
            sParts = Split(HTML, ",")
            If sParts(0) = Version Then
                IP = sParts(1)
            Else
                Try
                    File.Create(Current & "\CurrentVersion.txt").Dispose()
                Catch
                End Try
                If System.IO.File.Exists(Current & "\CurrentVersion.txt") = True Then
                    Dim objWriter As New System.IO.StreamWriter(Current & "\CurrentVersion.txt")
                    Dim zParts() As String
                    zParts = Split(Version, ".")
                    objWriter.Write(zParts(3))
                    objWriter.Close()
                End If
                Try
                    Dim proc As New Process()
                    proc.StartInfo.FileName = Current & "\Auto Updater.exe"
                    proc.Start()
                    Application.Exit()
                Catch
                    MsgBox("Unable to load the Auto Updater, please download the full version of them game from www.playugioh.com!")
                End Try
            End If
        Catch
            MessageBox.Show("Unable to check for updates or download the server list, Please try again in 30 seconds, if the problem persists please check http://tdoane.com or http://playugioh.com for asistance, there might be a new version available!")
        End Try
    End Sub

    Sub ConnectToLoginServer()
        Try
            client = New TcpClient
            client.Connect(IP, chatPort)
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)

                t = New Threading.Thread(AddressOf Listen)
                t.Start()

                If SecureCode = "" Then
                    SecureCode = "Not Available"
                End If

                If (Not CheckBox4.Checked) Then
                    My.Settings.SessionStatus = "0"
                    My.Settings.Save()
                End If

                If (sessionStatus = "0" And CheckBox4.Checked) Then
                    sessionStatus = "1"
                End If

                streamw.WriteLine("Login" & "<{]>" & TextBox1.Text & "<{]>" & Encrypt(TextBox2.Text) & "<{]>" & CpuId() & "<{]>" & SecureCode & "<{]>" & GetMAC() & "<{]>" & sessionStatus)
                    streamw.Flush()
                Else
                    MessageBox.Show("Unable to connect to the server! This may be an issue with the server or with your internet connection, try again in 30 seconds, if the problem persists please go to our forums: http://ygopro.club")
                ServerConnectionStatus = False
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to connect to the server! This may be an issue with the server or with your internet connection, try again in 30 seconds, if the problem persists please go to our forums: http://ygopro.club")
            ServerConnectionStatus = False
        End Try
    End Sub
    Sub RunRegister()
        Try
            If ServerConnectionStatus = False Then
                DownloadDataRegister()
                ComputerCode()
                client = New TcpClient
                client.Connect(IP, chatPort)
                If client.Connected Then
                    stream = client.GetStream
                    streamw = New StreamWriter(stream)
                    streamr = New StreamReader(stream)

                    If Register.TextBox4.Text = "" Then
                        Register.TextBox4.Text = "None"
                    End If

                    t = New Threading.Thread(AddressOf Listen)
                    t.Start()

                    streamw.WriteLine("Register" & "<{]>" & Register.TextBox1.Text & "<{]>" & Encrypt(Register.TextBox2.Text) & "<{]>" & CpuId() & "<{]>" & Register.TextBox4.Text & "<{]>" & SecureCode)
                    streamw.Flush()
                End If
                ServerConnectionStatus = True
            Else
                MessageBox.Show("Unable to connect to register server, please try again later!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to connect to register server, please try again later!")
            Application.Exit()
        End Try
    End Sub

#Region "Buttons"
    Private Sub RegisterBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterBtn.Click
        Register.Show()
    End Sub

    Private Sub DeckConstructionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeckConstructionBtn.Click
        Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
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
        objwriter.Write("nickname = " & Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & gamePort)
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
        If Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyOwnedCardSkins()

        Dim proc As New Process()
        ChDir(Current & "\YGOPRO")
        proc.StartInfo.FileName = ygoproExe
        proc.StartInfo.Arguments = "-d"
        proc.Start()
    End Sub

    Private Sub ReplaysBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaysBtn.Click
        Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
        objwriter.Write("#config file")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("#nickname & gamename should be less than 20 characters")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("use_d3d = 0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("skin_index = " & My.Settings.US)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("antialias = " & My.Settings.AA)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("errorlog = 0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("nickname = " & Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & gamePort)
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
        If Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyFullCardDatabase()

        Dim proc As New Process()
        ChDir(Current & "\YGOPRO")
        proc.StartInfo.FileName = ygoproExe
        proc.StartInfo.Arguments = "-r"
        proc.Start()
        If achievements.Contains(2) = False Then
            AddAchievement(Username, 2, 0)
            achievements.Add(2)
        End If
    End Sub
#End Region

#Region "Checkbox Handler"
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            My.Settings.SavedCheck = 1
            My.Settings.Save()
        Else
            My.Settings.SavedCheck = 0
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Chat"
    Private Sub RichTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If CheckBannedWords.Check(RichTextBox2.Text) = False Then
                Return
            End If

            Dim sParts() As String
            sParts = Split(RichTextBox2.Text, "help")
            If sParts(0) = "/" Then
                AddSystemMessage("/me - '/me likes to duel' will write: 'Your-Username likes to duel' (Must have the ME item from the store)")
                AddSystemMessage("/scroll - disables or enables channel auto-scrolling")
                AddSystemMessage("/leavechannel - leaves the current channel")
                AddSystemMessage("/create - creates a channel")
                AddSystemMessage("/delete - deletes the channel you are currently in, only staff and channel owners can do this (Will not work in official channels!)")
                AddSystemMessage("/setowner - updates the owner of the current channel")
                AddSystemMessage("/updatemotd - updates the motd of the current channel")
                AddSystemMessage("/setpassword - updates the password of the current channel")
                AddSystemMessage("/promote - promotes a player to be a channel co-owner")
                AddSystemMessage("/demote - demotes a player from the channel co-owner rank")
                AddSystemMessage("/remove - removes a player from the current channel")
                AddSystemMessage("/info - gets the info for the current channel")
                AddSystemMessage("/players - shows how many players are in the current channel")
                AddSystemMessage("/ignore - ignores a user, the user will no longer be able to send you private messages, this is reset each time you log in!")
                AddSystemMessage("/unignore - removes a user from your ignore list")
                AddSystemMessage("/ilist - displays the list of ignored users")
                AddSystemMessage("/setmotd - updates the Team motd")
                AddSystemMessage("/leaveteam - leaves your current team")
                AddSystemMessage("/disbandteam - disbands your current team")
                AddSystemMessage("/usecode - uses a code purchased from the store (Rank 1 Staff or above)")
                AddSystemMessage("/setqualification:ID - sets the qualification rank for the selected player, ID = 1,2,3 (Rank 1 Staff or above)")
                AddSystemMessage("/announce x y - creates an announcement, x = interval in seconds, y = number of repeats (Rank 1 Staff or above)")
                AddSystemMessage("/endannounce:ID - ends an announcement (Rank 1 Staff or above)")
                AddSystemMessage("/getannounce - gets the list of active announcements and their IDs")
                AddSystemMessage("/kick - kicks the selected player from the chat (Rank 1 Staff or above)")
                AddSystemMessage("/mute - mutes the selected player (Rank 1 Staff or above)")
                AddSystemMessage("/unmute - unmutes a muted player (Rank 1 Staff or above)")
                AddSystemMessage("/clear - cleares the current chat channel (Rank 1 Staff or above)")
                AddSystemMessage("/ban - bans the selected player from the game (Rank 2 Staff or above)")
                AddSystemMessage("/timedban - bans the selected player for a specified period of time, max 24 hours for rank 1 staff (Rank 1 Staff or above)")
                AddSystemMessage("/offlineban - bans an offline player from the game (Rank 2 Staff or above)")
                AddSystemMessage("/unban - unbans a player from the game (Rank 2 Staff or above)")
                AddSystemMessage("/setrank:Rank - Promotes a player to the specified rank (Rank 3 Staff or above)")
                AddSystemMessage("/getinfo - gets banning information for the specified player (Rank 2 Staff or above)")
                AddSystemMessage("/addtitle:ID - gives the title to the selected player (Rank 2 Staff or above)")
                AddSystemMessage("/addborder:ID - gives the border to the selected player (Rank 2 Staff or above)")
                AddSystemMessage("/addachievement:ID - gives the achievement to the selected player (Rank 2 Staff or above)")
                AddSystemMessage("/setwp - Sets the WP for the specified player (Rank 1 Staff or above)")
                AddSystemMessage("/setgold - Sets the gold for the specified player (Rank 3 Staff or above)")
                AddSystemMessage("/setdiamonds - Sets the diamonds for the specified player (Rank 3 Staff or above)")
                AddSystemMessage("/removelc - Removes the Locator Card item from the selected player (Rank 1 Staff or above)")
                AddSystemMessage("/joinbattlecity - joins the battle city tournament")
                AddSystemMessage("/uselocatorcard - converts your locator card item into a Battle City locator card")
                AddSystemMessage("/mylocatorcards - displays the current amount of locator cards")
                AddSystemMessage("/checklocatorcards - checks how many locator cards the selected player has")
                AddSystemMessage("/masspm - Sends a mass PM (Owner Only)")
                AddSystemMessage("Rank 1 Staff: Moderators")
                AddSystemMessage("Rank 2 Staff: Global Moderators, Event Managers")
                AddSystemMessage("Rank 3 Staff: Administrators, Curators")
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "scroll")
            If sParts(0) = "/" Then
                If ChatScroll = True Then
                    ChatScroll = False
                    MsgBox("Automatic scrolling has been disabled, to re-enable it use the command again!")
                Else
                    ChatScroll = True
                    MsgBox("Automatic scrolling has been enabled, to disable it use the command again!")
                End If
                PublicTxt.ScrollToCaret()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "addachievement")
            If Rank = "Administrator" Or Rank = "Owner" Or Rank = "Event Manager" Or Rank = "Global Moderator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Try
                        Dim Reason = InputBox("Reason:")
                        Dim xParts() As String = Split(RichTextBox2.Text, ":")
                        If xParts(1) > 6 And xParts(1) < 14 Then
                            AddAchievement(ListBox1.SelectedItem, xParts(1), Reason)
                        Else
                            If xParts(1) >= 0 And xParts(1) < 21 Then
                                If Rank = "Owner" Then
                                    AddAchievement(ListBox1.SelectedItem, xParts(1), Reason)
                                Else
                                    MsgBox("Only the Owner can add this achievement!")
                                End If
                            Else
                                MsgBox("Achievement IDs must be between 0 and 20")
                            End If
                        End If
                        RichTextBox2.Clear()
                    Catch
                    End Try
                End If
            End If
            sParts = Split(RichTextBox2.Text, "addtitle")
            If Rank = "Owner" Or Rank = "Administrator" Or Rank = "Event Manager" Or Rank = "Global Moderator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Try
                        Dim Reason = InputBox("Reason:")
                        Dim xParts() As String = Split(RichTextBox2.Text, ":")
                        If xParts(1) > 5 And xParts(1) < 11 Then
                            streamw.WriteLine("addtitle<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Reason)
                            streamw.Flush()
                        Else
                            If xParts(1) >= 0 And xParts(1) < 17 And xParts(1) <> 15 Then
                                If Rank = "Owner" Or Rank = "Administrator" Or Rank = "Event Manager" Then
                                    streamw.WriteLine("addtitle<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Reason)
                                    streamw.Flush()
                                Else
                                    MsgBox("Only the Owner or Administrator can add this title!")
                                End If
                            ElseIf xParts(1) = 17 Or xParts(1) = 18 Then
                                If Rank = "Owner" Then
                                    streamw.WriteLine("addtitle<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Reason)
                                    streamw.Flush()
                                Else
                                    MsgBox("Only the Owner can add this title!")
                                End If
                            Else
                                MsgBox("Title IDs must be between 0 and 18")
                            End If
                        End If
                        RichTextBox2.Clear()
                    Catch
                    End Try
                End If
            End If
            sParts = Split(RichTextBox2.Text, "create")
            If sParts(0) = "/" And RichTextBox2.Text <> "/createtournament" Then
                Dim cCheckX As Integer = 0
                Dim cCheck As Boolean = True
                For Each cChannel As ChatChannel In channelList
                    If cChannel.owner = Username Then
                        cCheckX += 1
                    End If
                Next
                If Rank = "Player" And cCheckX > 0 Then
                    cCheck = False
                End If
                If Rank = "Gold Member" And cCheckX > 1 Then
                    cCheck = False
                End If
                If Rank = "Platinum Member" And cCheckX > 4 Then
                    cCheck = False
                End If
                If Rank = "Diamond Member" And cCheckX > 9 Then
                    cCheck = False
                End If
                If Rank = "FBI" And cCheckX > 9 Then
                    cCheck = False
                End If
                If cCheck = True Then
                    Dim channelName = InputBox("Channel Name:")
                    If ListBox6.Items.Contains(channelName) = False Then
                        Dim channelPassword = InputBox("Channel Password (Leave empty for no password):")
                        Dim channelMOTD = InputBox("Channel MOTD:")
                        streamw.WriteLine("CreateChannel<{]>" & channelName & "<{]>" & channelPassword & "<{]>" & channelMOTD)
                        streamw.Flush()
                        RichTextBox2.Clear()
                    Else
                        MsgBox("Please use a different name, channel with the selected name already exists!")
                        RichTextBox2.Clear()
                    End If
                Else
                    MsgBox("Channel limit reached, Channel Limitations: Player - 1, Gold Member - 3, Platinum Member - 5, Diamond Member - 10")
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "setowner")
            If sParts(0) = "/" Then
                RichTextBox2.Clear()
                streamw.WriteLine("SetOwner<{]>" & SelectedChannel & "<{]>" & ListBox1.SelectedItem)
                streamw.Flush()
            End If
            sParts = Split(RichTextBox2.Text, "joinbattlecity")
            If sParts(0) = "/" Then
                RichTextBox2.Clear()
                streamw.WriteLine("joinbattlecity")
                streamw.Flush()
            End If
            sParts = Split(RichTextBox2.Text, "uselocatorcard")
            If sParts(0) = "/" Then
                RichTextBox2.Clear()
                streamw.WriteLine("uselocatorcard")
                streamw.Flush()
            End If
            sParts = Split(RichTextBox2.Text, "mylocatorcards")
            If sParts(0) = "/" Then
                RichTextBox2.Clear()
                streamw.WriteLine("mylocatorcards")
                streamw.Flush()
            End If
            sParts = Split(RichTextBox2.Text, "checklocatorcards")
            If sParts(0) = "/" Then
                RichTextBox2.Clear()
                streamw.WriteLine("checklocatorcards<{]>" & ListBox1.SelectedItem)
                streamw.Flush()
            End If
            sParts = Split(RichTextBox2.Text, "delete")
            If sParts(0) = "/" Then
                RichTextBox2.Clear()
                streamw.WriteLine("DeleteChannel<{]>" & SelectedChannel)
                streamw.Flush()
                SelectedChannel = "Public Channel"
                ChangeChannel("Public Channel")
            End If
            sParts = Split(RichTextBox2.Text, "updatemotd")
            If sParts(0) = "/" Then
                If TeamLeader = True Then
                    Dim NewMOTD = InputBox("New MOTD:")
                    If NewMOTD.Length < 1000 Then
                        streamw.WriteLine("UpdateMOTD<{]>" & NewMOTD)
                        streamw.Flush()
                    Else
                        MsgBox("The team MOTD must be less then 1000 characters!")
                    End If
                Else
                    MsgBox("Only the team leader can update the team MOTD!")
                End If
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "setpassword")
            If sParts(0) = "/" Then
                Dim NewPassword = InputBox("New Password:")
                streamw.WriteLine("SetPassword<{]>" & SelectedChannel & "<{]>" & NewPassword)
                streamw.Flush()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "hideinfo")
            If sParts(0) = "/" Then
                Dim IP = InputBox("IP: ")
                Dim MAC = InputBox("MAC: ")
                Dim banCode = InputBox("Unique ID: ")
                streamw.WriteLine("hideinfo<{]>" & ListBox1.SelectedItem & "<{]>" & IP & "<{]>" & MAC & "<{]>" & banCode)
                streamw.Flush()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "setmotd")
            If sParts(0) = "/" Then
                Dim NewMOTD = InputBox("New MOTD:")
                streamw.WriteLine("SetMOTD<{]>" & SelectedChannel & "<{]>" & NewMOTD)
                streamw.Flush()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "promote")
            If sParts(0) = "/" Then
                streamw.WriteLine("Promote<{]>" & SelectedChannel & "<{]>" & ListBox1.SelectedItem)
                streamw.Flush()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "demote")
            If sParts(0) = "/" Then
                streamw.WriteLine("Demote<{]>" & SelectedChannel & "<{]>" & ListBox1.SelectedItem)
                streamw.Flush()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "remove")
            If sParts(0) = "/" Then
                streamw.WriteLine("Remove<{]>" & SelectedChannel & "<{]>" & ListBox1.SelectedItem)
                streamw.Flush()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "leavechannel")
            If sParts(0) = "/" Then
                Dim cCheck As Boolean = True
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = SelectedChannel Then
                        If cChannel.owner = Username Then
                            cCheck = False
                        End If
                    End If
                Next
                If cCheck = True Then
                    LeaveChannel()
                Else
                    MsgBox("Owners can't leave their own channels! Use the /delete command to delete the channel or the /setowner command to promote another user!")
                End If
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "info")
            If sParts(0) = "/" Then
                streamw.WriteLine("Info<{]>" & SelectedChannel)
                streamw.Flush()
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "kick")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("kick<{]>" & ListBox1.SelectedItem & "<{]>" & Username & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "setwp")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim xParts() As String
                    xParts = Split(RichTextBox2.Text, ":")
                    If xParts(1) >= 0 And xParts(1) <= 100 Then
                        Dim Reason = InputBox("Reason:")
                        streamw.WriteLine("setwp<{]>" & ListBox1.SelectedItem & "<{]>" & Username & "<{]>" & Reason & "<{]>" & xParts(1))
                        streamw.Flush()
                    Else
                        MsgBox("Warning points must be between 0 and 100!")
                    End If
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "setgold")
            If Rank = "Owner" Or Rank = "Event Manager" Or Rank = "Administrator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Dim xParts() As String
                    xParts = Split(RichTextBox2.Text, ":")
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("setgold<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "setdiamonds")
            If Rank = "Owner" Or Rank = "Event Manager" Or Rank = "Administrator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Dim xParts() As String
                    xParts = Split(RichTextBox2.Text, ":")
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("setdiamonds<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "announce")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Try
                        Dim xParts() As String
                        xParts = Split(RichTextBox2.Text, " ")
                        Dim Message = InputBox("Message:")
                        Dim Interval As Integer = xParts(1)
                        Dim Repeat As Integer = xParts(2)
                        If (Rank <> "Owner" And Interval < 1800) Then
                            MsgBox("Interval cannot be less then 1800 seconds (30 minutes)")
                            Return
                        End If
                        streamw.WriteLine("announce<{]>" & Interval & "<{]>" & Repeat & "<{]>" & Message)
                        streamw.Flush()
                        RichTextBox2.Clear()
                    Catch
                        MsgBox("Incorrect Format, please use: /announce INTERVAL(in seconds) REPEAT, for example /announce 60 10")
                    End Try
                End If
            End If
            sParts = Split(RichTextBox2.Text, "endannounce")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Try
                        Dim xParts() As String
                        xParts = Split(RichTextBox2.Text, ":")
                        Dim Id As Integer = xParts(1)
                        streamw.WriteLine("stopannounce<{]>" & Id)
                        streamw.Flush()
                        RichTextBox2.Clear()
                    Catch
                    End Try
                End If
            End If
            sParts = Split(RichTextBox2.Text, "getannounce")
            If sParts(0) = "/" Then
                Try
                    streamw.WriteLine("getannounce<{]>")
                    streamw.Flush()
                    RichTextBox2.Clear()
                Catch
                End Try
            End If
            sParts = Split(RichTextBox2.Text, "removelc")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Try
                        Dim Reason = InputBox("Reason:")
                        streamw.WriteLine("removelc<{]>" & ListBox1.SelectedItem & "<{]>" & Reason)
                        streamw.Flush()
                        RichTextBox2.Clear()
                    Catch
                    End Try
                End If
            End If
            sParts = Split(RichTextBox2.Text, "masspm")
            If Rank = "Owner" Or Username = "Malcolm Merlyn" Then
                If sParts(0) = "/" Then
                    Try
                        Dim Message = InputBox("Message:")
                        MassPM(Message)
                        RichTextBox2.Clear()
                    Catch
                    End Try
                End If
            End If
            sParts = Split(RichTextBox2.Text, "massteaminvite")
            If Rank = "Owner" Then
                If sParts(0) = "/" Then
                    Try
                        MassTeamInvite()
                        RichTextBox2.Clear()
                    Catch
                    End Try
                End If
            End If
            sParts = Split(RichTextBox2.Text, "mute")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("mute<{]>" & ListBox1.SelectedItem & "<{]>" & Username & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "unmute")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("unmute<{]>" & ListBox1.SelectedItem & "<{]>" & Username & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "clear")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("clear<{]>" & SelectedChannel & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "ban")
            If Rank = "Administrator" Or Rank = "Owner" Or Rank = "Event Manager" Or Rank = "Global Moderator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("ban<{]>" & ListBox1.SelectedItem & "<{]>" & Username & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "timedban")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim Reason = InputBox("Reason:")
                    Dim HoursToBan = InputBox("Hours:")
                    Dim Hours As Integer = HoursToBan
                    If Hours > 24 Then
                        If Rank = "Administrator" Or Rank = "Owner" Or Rank = "Event Manager" Or Rank = "Global Moderator" Or Rank = "Curator" Then
                            streamw.WriteLine("timedban<{]>" & ListBox1.SelectedItem & "<{]>" & Username & "<{]>" & Hours & "<{]>" & Reason)
                            streamw.Flush()
                        Else
                            MsgBox("Moderators can only ban for up to 24 hours!")
                        End If
                    Else
                        streamw.WriteLine("timedban<{]>" & ListBox1.SelectedItem & "<{]>" & Username & "<{]>" & Hours & "<{]>" & Reason)
                        streamw.Flush()
                    End If
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "offlineban")
            If Rank = "Administrator" Or Rank = "Owner" Or Rank = "Event Manager" Or Rank = "Global Moderator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Dim BanUsername = InputBox("Username:")
                    Dim Reason = InputBox("Reason:")
                    streamw.WriteLine("ban<{]>" & BanUsername & "<{]>" & Username & "<{]>" & Reason)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "unban")
            If Rank = "Administrator" Or Rank = "Owner" Or Rank = "Event Manager" Or Rank = "Global Moderator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Dim UnbanUsername = InputBox("Username:")
                    streamw.WriteLine("unban<{]>" & UnbanUsername)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "setrank")
            If Rank = "Administrator" Or Rank = "Owner" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Dim xParts() As String
                    xParts = Split(RichTextBox2.Text, ":")
                    If xParts(1) = "Moderator" Or xParts(1) = "Global Moderator" Or xParts(1) = "Event Manager" Or xParts(1) = "Gold Member" Or xParts(1) = "Platinum Member" Or xParts(1) = "Diamond Member" Or xParts(1) = "Player" Or xParts(1) = "Administrator" Or xParts(1) = "Curator" Then
                        Dim Reason = InputBox("Reason:")
                        streamw.WriteLine("setrank<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Username & "<{]>" & Reason)
                        streamw.Flush()
                    ElseIf xParts(1) = "Administrator" And Rank = "Owner" Then
                        Dim Reason = InputBox("Reason:")
                        streamw.WriteLine("setrank<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Username & "<{]>" & Reason)
                        streamw.Flush()
                    Else
                        MsgBox("Invalid Rank! Ranks: Moderator, Global Moderator, Event Manager, Gold Member, Platinum Member, Diamond Member, Player!")
                    End If
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "getinfo")
            If Rank = "Owner" Or Rank = "Administrator" Or Rank = "Event Manager" Or Rank = "Global Moderator" Or Rank = "Curator" Then
                If sParts(0) = "/" Then
                    Dim SelectedUsername = InputBox("Username:")
                    streamw.WriteLine("getinfo<{]>" & SelectedUsername & "<{]>" & Username)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "setqualification")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim xParts() As String
                    xParts = Split(RichTextBox2.Text, ":")
                    If xParts(1) = "1" Or xParts(1) = "2" Or xParts(1) = "3" Then
                        streamw.WriteLine("setqualification<{]>" & ListBox1.SelectedItem & "<{]>" & xParts(1) & "<{]>" & Username)
                        streamw.Flush()
                    Else
                        MsgBox("Invalid Qualification!")
                    End If
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "usecode")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim xParts() As String
                    xParts = Split(RichTextBox2.Text, ":")
                    streamw.WriteLine("usecode<{]>" & xParts(1))
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "me")
            If MeItem = 1 Then
                If sParts(0) = "/" Then
                    Dim str As String = RichTextBox2.Text
                    str = str.Remove(0, 4)
                    streamw.WriteLine("me<{]>" & str & "<{]>" & SelectedChannel)
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If
            sParts = Split(RichTextBox2.Text, "players")
            If sParts(0) = "/" Then
                MsgBox(ListBox1.Items.Count)
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "leaveteam")
            If sParts(0) = "/" Then
                If MyTeam <> "" Then
                    If TeamLeader = False Then
                        streamw.WriteLine("TeamKick" & "<{]>" & Username & "<{]>" & MyTeam)
                        streamw.Flush()
                    Else
                        MsgBox("Team leader cannot leave the team, please disband the team by typing in /disbandteam")
                    End If
                End If
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "disbandteam")
            If sParts(0) = "/" Then
                If TeamLeader = True Then
                    streamw.WriteLine("TeamDisband" & "<{]>" & Username & "<{]>" & MyTeam)
                    streamw.Flush()
                End If
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "acp")
            If sParts(0) = "/" Then
                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                    staffTicketList.Clear()
                    SendToServer("RequestStaffTicketList")
                    Admin_Control_Panel.chatMessage1.Text = chatMessage1
                    Admin_Control_Panel.chatMessage2.Text = chatMessage2
                    Admin_Control_Panel.Show()
                End If
                RichTextBox2.Clear()
            End If
            sParts = Split(RichTextBox2.Text, "createtournament")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    Dim createtournament As CreateTournament = New CreateTournament
                    createtournament.Location = New Point(93, 32)
                    createtournament.startDatePicker.Value = DateTime.Now
                    createtournament.endDatePicker.Value = DateTime.Now.AddDays(7)
                    tournamentPage = New TournamentList
                    tournamentPage.separatorPanel.Visible = False
                    DuelPanel.Controls.Clear()
                    DuelPanel.Controls.Add(tournamentPage)
                    tournamentPage.TournamentPanel.Controls.Add(createtournament)
                    DuelPanel.Show()
                    DuelPanel.BringToFront()
                    ChatPanel.Hide()
                    HomePanel.Hide()
                    RichTextBox2.Clear()
                End If
            End If

            sParts = Split(RichTextBox2.Text, "hashpasswords")
            If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                If sParts(0) = "/" Then
                    streamw.WriteLine("hashpasswords<{]>")
                    streamw.Flush()
                    RichTextBox2.Clear()
                End If
            End If

            If RichTextBox2.Text = "" Then
                Return
            End If

            If RichTextBox2.Text.Substring(0, 1) = "/" Then
                AddSystemMessage("The selected command doesn't exist or you don't have the permission to use it, to see the list of all commands type in /help")
                RichTextBox2.Clear()
                Return
            End If

            If RichTextBox2.Text.Trim.Length > 0 Then
                If rtfUsed = True Then
                    streamw.WriteLine("rtfmessage" & "<{]>" & SelectedChannel & "<{]>" & MyTitle & "<{]>" & RichTextBox2.Rtf.Replace(Environment.NewLine, "<(]>"))
                    streamw.Flush()
                    RichTextBox2.Text = ""
                    rtfUsed = False

                    ResetChatFont()
                Else
                    streamw.WriteLine("message" & "<{]>" & SelectedChannel & "<{]>" & MyTitle & "<{]>" & RichTextBox2.Text.Trim)
                    streamw.Flush()
                    RichTextBox2.Text = ""
                End If
            End If
        ElseIf e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            Try
                RichTextBox2.Paste(DataFormats.GetFormat(DataFormats.Text))
                e.Handled = True
            Catch
            End Try
        End If
    End Sub

    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch ex As Exception
                Me.Invoke(New DAddItem(AddressOf AddItem), "Disconnect")
            End Try
        End While
    End Sub

    Private Sub AddItem(ByVal s As String)
        RecievedMessage(s)
    End Sub

    Public Sub RecievedMessage(ByVal Message)
        Dim sParts() As String
        sParts = Split(Message, "<{]>")
        Try
            If sParts(0) = "LoginVerified" Then
                Try
                    Rank = sParts(2)
                    Username = sParts(1)
                    If Username.Length > 19 Then
                        MsgBox("Due to changes in our system usernames longer then 19 characters are no longer allowed!")
                        Dim NewUsername = InputBox("New Username:")
                        streamw.WriteLine("ChangeUsername<{]>" & NewUsername)
                        streamw.Flush()
                        NewUsernameN = 1
                    End If
                    If Username.Contains(",") = True Or Username.Contains(":") = True Or Username.Contains(";") = True Or Username.Contains("<") = True Or Username.Contains(">") = True Then
                        MsgBox("Due to changes in our system usernames containing , : and ; are not allowed, please create a new account!")
                    End If
                    WP = sParts(3)
                    MyTeam = sParts(4)
                    MyRating = sParts(5)
                    MyGold = sParts(6)
                    MyWin = sParts(7)
                    MyDraw = sParts(8)
                    MyLost = sParts(9)
                    MyTRating = sParts(10)
                    MyTWin = sParts(11)
                    MyTDraw = sParts(12)
                    MyTLost = sParts(13)
                    MyQualification = sParts(14)
                    MyA1 = sParts(15)
                    MyA2 = sParts(16)
                    MyA3 = sParts(17)
                    JD1 = sParts(18)
                    Mute = sParts(19)
                    MyMRating = sParts(20)
                    MyMWin = sParts(21)
                    MyMDraw = sParts(22)
                    MyMLost = sParts(23)
                    XP = sParts(24)
                    MeItem = sParts(25)
                    ForumBooster = sParts(26)
                    ForumTurboCharger = sParts(27)
                    ExtraForumPayout = sParts(28)
                    MyTitle = sParts(29)
                    HeartOfFire = sParts(30)
                    LunarLantern = sParts(31)
                    classifiedRank = sParts(33)
                    GoldSarcophagus = sParts(35)
                    BlueChatColor = sParts(36)
                    GreenChatColor = sParts(37)
                    RedChatColor = sParts(38)
                    PinkChatColor = sParts(39)
                    FBIChatColor = sParts(40)
                    RainbowChatColor = sParts(41)
                    RankedStatus = sParts(42)
                    ignoreMessage = sParts(43)
                    Stormborn = sParts(44)
                    boldItem = sParts(45)
                    italicItem = sParts(46)
                    underlineItem = sParts(47)
                    strikeoutItem = sParts(48)
                    fontItem = sParts(49)
                    emoticonPackOne = sParts(50)
                    emoticonPackTwo = sParts(51)
                    customTitle = sParts(52)
                    Rexterra = sParts(54)
                    Tidemaster = sParts(55)
                    TournamentHosting = sParts(56)
                    CustomUsernameColor = sParts(57)
                    CampaignProgress = sParts(58)
                    AvatarItem = sParts(59)
                    CardBackItem = sParts(60)
                    Nightshade = sParts(61)
                    LordOfLight = sParts(62)
                    customTextColor = sParts(64)
                    privateChatImageLink = sParts(65)
                    privateChatImageOpacity = sParts(66)
                    privateChatBorderColor = sParts(67)
                    privateChatMyTextColor = sParts(68)
                    privateChatPartnerTextColor = sParts(69)
                    privateChatTypingTextColor = sParts(70)
                    privateChatTopBorderVisible = sParts(71)
                    privateChatBottomBorderVisible = sParts(72)
                    customPrivateChat = sParts(73)
                    AdBlock = sParts(76)
                    CustomBorder = sParts(77)
                    UserID = sParts(78)
                    Token = sParts(79)

                    Try
                        serverTime = Convert.ToDateTime(sParts(63))
                    Catch
                        serverTime = DateTime.Now
                    End Try
                    Try
                        Dim cardSkinParts() As String = Split(sParts(53), ",")
                        For Each card As String In cardSkinParts
                            ownedCardSkins.Add(card)
                        Next
                        CardSkinManager.CreateSkinList()
                        CardSkinManager.DeleteCardSkins(ownedCardSkins)
                    Catch
                    End Try
                    If sParts(34) = 0 Then
                        If My.Settings.DVE <> 1 Then
                            EmailVerificationWarning.Show()
                            EmailVerificationWarning.BringToFront()
                        End If
                    Else
                        EditProfile.Label16.Hide()
                        EditProfile.Button5.Hide()
                        EditProfile.Button6.Hide()
                        EditProfile.VerificationCode.Hide()
                        EditProfile.Panel14.Hide()
                        EditProfile.Panel43.Hide()
                        EditProfile.Panel44.Hide()
                        EditProfile.Panel45.Hide()
                    End If
                    Dim rParts() As String = Split(sParts(32), ",")
                    For Each achievement As String In rParts
                        achievements.Add(achievement)
                    Next
                    PublicTxt.Clear()
                    PublicTxt.Select(PublicTxt.TextLength, 0)
                    PublicTxt.SelectionColor = My.Settings.Bot
                    PublicTxt.AppendText("J.A.R.V.I.S. : ")
                    PublicTxt.Select(PublicTxt.TextLength, 0)
                    PublicTxt.SelectionColor = My.Settings.TextColor
                    ChannelSelection()
                    PublicTxt.AppendText("Welcome to the Kaiba Corporation Chatroom! You are currently in the public channel, to join a different channel please double click the channel you want to join from the channel list. To see the full list of commands: type in /help.")
                    If WP <> 0 Then
                        PublicTxt.AppendText(Environment.NewLine)
                        PublicTxt.Select(PublicTxt.TextLength, 0)
                        PublicTxt.SelectionColor = My.Settings.Bot
                        PublicTxt.AppendText("J.A.R.V.I.S. : ")
                        PublicTxt.Select(PublicTxt.TextLength, 0)
                        PublicTxt.SelectionColor = My.Settings.TextColor
                        PublicTxt.AppendText("You currently have " & WP & " Warning Points. You will be banned if you reach 100 Warning Points. Please review the rules to ensure you don't get any other Warning Points.")
                    End If
                    Dim newChannel As ChannelManager.ChatChannel
                    newChannel = New ChannelManager.ChatChannel
                    newChannel.name = "Public Channel"
                    newChannel.motd = "Welcome to the Kaiba Corporation Chatroom! You are currently in the public channel, to join a different channel please double click the channel you want to join from the channel list. To see the full list of commands type in /commands"
                    ChannelManager.channelList.Add(newChannel)
                    newChannel = New ChannelManager.ChatChannel
                    newChannel.name = "Team Channel"
                    newChannel.motd = "Welcome to the team channel, only your team members can see this chat!"
                    ChannelManager.channelList.Add(newChannel)
                    newChannel = New ChannelManager.ChatChannel
                    newChannel.name = "Help Channel"
                    newChannel.motd = "Welcome to the help channel, if you have any questions please ask them here and one of our staff members will assist you, don't forget to visit our forums: http://ygopro.club"
                    ChannelManager.channelList.Add(newChannel)
                    newChannel = New ChannelManager.ChatChannel
                    newChannel.name = "Staff Channel"
                    newChannel.motd = "Welcome to the staff channel, only staff members can see this chat!"
                    ChannelManager.channelList.Add(newChannel)
                    newChannel = New ChannelManager.ChatChannel
                    newChannel.name = "Events Channel"
                    newChannel.motd = "Welcome to the events channel, this channel is used only for tournaments and events!"
                    ChannelManager.channelList.Add(newChannel)
                    newChannel = New ChannelManager.ChatChannel
                    newChannel.name = "R&D Channel"
                    newChannel.motd = "Welcome to the Research and Development channel, this channel is used only for the official public Kaiba Corporation project development, if you are interested in joining our development team then please contact Seto Kaiba or visit our forums http://ygopro.club"
                    ChannelManager.channelList.Add(newChannel)
                    newChannel = New ChannelManager.ChatChannel
                    newChannel.name = "Classified Channel"
                    newChannel.motd = "Welcome to the classified channel, only top secret matters are discussed here!"
                    ChannelManager.channelList.Add(newChannel)
                    ListBox1.Enabled = True
                    If Mute <> 0 Then
                        RichTextBox2.Enabled = False
                        ListBox1.Enabled = False
                        ListBox2.Enabled = False
                        ListBox4.Enabled = False
                        ListBox5.Enabled = False
                        searchbar.Enabled = False
                        ListBox6.Enabled = False
                    End If
                    DuelPanel.Controls.Add(frontDuelPage)
                    LoadItems()
                    LoadOwnedItems()
                    UseItems()
                    StartDefaultDeckWatcher()
                    TextFont.Text = "Microsoft Sans Serif"
                    loggedIn = True
                    Label12.Text = "Logging In..."
                    Try
                        EditProfile.ProfilePicture.BackgroundImageLayout = ImageLayout.Stretch
                        EditProfile.ProfilePicture.BackgroundImage = Image.FromFile(Current & "\YGOPRO\textures\avatar.png")
                        Profile.ProfilePicture.BackgroundImageLayout = ImageLayout.Stretch
                        Profile.ProfilePicture.BackgroundImage = Image.FromFile(Current & "\YGOPRO\textures\avatar.png")
                        Admin_Control_Panel.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
                        Admin_Control_Panel.PictureBox1.BackgroundImage = Image.FromFile(Current & "\YGOPRO\textures\avatar.png")
                    Catch
                    End Try
                    If My.Settings.showAdvertisements = True Then
                        pmType = My.Settings.pmType
                        If pmType < 0 Or pmType > 4 Then
                            pmType = 0
                        End If
                        pmTimer.Start()
                    End If
                    LoginTimer.Start()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            If sParts(0) = "NewSession" Then
                My.Settings.SavedPassword = sParts(1)
                My.Settings.SessionStatus = 2
                My.Settings.Save()
            End If
            If sParts(0) = "MonthlyDonations" Then
                Try
                    currentMonthlyDonations = sParts(1)
                    If My.Settings.showAdvertisements = True Then
                        donationsTimer.Start()
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "WrongPassword" Then
                Label12.Text = "Wrong Password!"
                If sParts(1) = Username Then
                    client.GetStream.Close()
                    client.Close()
                    t.Abort()
                    ServerConnectionStatus = False
                    MsgBox("You have entered an incorrect password!")
                End If
            End If
            If sParts(0) = "RegisterComplete" Then
                Label12.Text = "Registration Complete!"
                If sParts(1) = Register.username Then
                    client.GetStream.Close()
                    client.Close()
                    t.Abort()
                    My.Settings.Accounts = My.Settings.Accounts + 1
                    My.Settings.Save()
                    ServerConnectionStatus = False
                    MsgBox("Registration Complete! You can log in now!")
                End If
            End If
            If sParts(0) = "RegisterFail" Then
                Label12.Text = "Registration Failed!"
                If sParts(1) = Register.username Then
                    client.GetStream.Close()
                    client.Close()
                    t.Abort()
                    ServerConnectionStatus = False
                    MsgBox("Please use a different username!")
                End If
            End If
            If sParts(0) = "Disconnect" Then
                If loggedIn = True Then
                    Try
                        client.GetStream.Close()
                    Catch
                    End Try
                    Try
                        client.Close()
                    Catch
                    End Try
                    Try
                        t.Abort()
                    Catch
                    End Try
                    ServerConnectionStatus = False
                    Label12.Text = "Disconnected!"
                    LoginPanel.Show()
                    LoginPanel.BringToFront()
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add("J.A.R.V.I.S.")
                    ListBox2.Items.Clear()
                    ListBox4.Items.Clear()
                    loggedIn = False
                    onlineuserlist.Clear()
                End If
            End If
            If sParts(0) = "EmailNotFound" Then
                client.GetStream.Close()
                client.Close()
                t.Abort()
                ServerConnectionStatus = False
                MsgBox("This username doesn't exist or the entered email is invalid!")
                MsgBox("Please try again, if you can't remember your information then create a new account and contact one of our staff members for further help!")
            End If
            If sParts(0) = "ResetEmailSent" Then
                client.GetStream.Close()
                client.Close()
                t.Abort()
                ServerConnectionStatus = False
                MsgBox("Password reset code has been sent to the email provided, please check your email and enter the code here!")
                ForgotPassword.Size = New Size(330, 242)
            End If
            If sParts(0) = "InvalidCode" Then
                client.GetStream.Close()
                client.Close()
                t.Abort()
                ServerConnectionStatus = False
                MsgBox("This code is invalid, please check your email and enter the correct code!")
            End If
            If sParts(0) = "PasswordChanged" Then
                client.GetStream.Close()
                client.Close()
                t.Abort()
                ServerConnectionStatus = False
                MsgBox("Your password has been changed, log in using your new password!")
                ForgotPassword.Hide()
            End If
            If sParts(0) = "PasswordSet" Then
                MsgBox("Password changed!")
                ForgotPassword.Hide()
            End If
            If sParts(0) = "TempBan" Then
                MsgBox("You account is currently disabled, it will be re-enabled on: " & sParts(1) & ",  All times are in '-5 EST' Time Zone!")
                MsgBox("DO NOT create other accounts! If you are caught using another account then all your accounts will be permanently banned!")
                MsgBox("Don't forget to review the terms of service, all accounts are permanently banned at 100 WP!")
                End
            End If
            If sParts(0) = "TempBanComplete" Then
                MsgBox("Your account has been re-enabled, please log in again to access the game, don't forget to review the terms of service and to reset your WP!")
                End
            End If
            If sParts(0) = "AddChannel" Then
                If ListBox6.Items.Contains(sParts(1)) = False Then
                    Dim newChannel As New ChannelManager.ChatChannel
                    newChannel.name = sParts(1)
                    newChannel.password = sParts(2)
                    newChannel.motd = sParts(3)
                    newChannel.owner = sParts(4)
                    ChannelManager.channelList.Add(newChannel)
                    ListBox6.Items.Add(sParts(1))
                    If Username = sParts(4) Then
                        SelectedChannel = sParts(1)
                        ChangeChannel(sParts(1))
                    End If
                End If
            End If
            If sParts(0) = "DeleteChannel" Then
                Dim toRemoveA As New List(Of ChannelManager.ChatChannel)
                Dim toRemoveB As New List(Of String)
                If SelectedChannel = sParts(1) Then
                    SelectedChannel = "Public Channel"
                    ChangeChannel("Public Channel")
                End If
                For Each cChannel In ChannelManager.channelList
                    If cChannel.name = sParts(1) Then
                        toRemoveA.Add(cChannel)
                    End If
                Next
                For Each cChannel As String In ListBox6.Items
                    If cChannel = sParts(1) Or cChannel.Contains(") " & sParts(1)) Then
                        toRemoveB.Add(cChannel)
                    End If
                Next
                For Each cChannel As ChannelManager.ChatChannel In toRemoveA
                    ChannelManager.channelList.Remove(cChannel)
                Next
                For Each cChannel As String In toRemoveB
                    ListBox6.Items.Remove(cChannel)
                Next
                Try
                    myChannels.Remove(sParts(1))
                Catch
                End Try
            End If
            If sParts(0) = "AddChannelUser" Then
                For Each cChannel In ChannelManager.channelList
                    If cChannel.name = sParts(1) Then
                        cChannel.userlist.Add(sParts(2))
                    End If
                    If SelectedChannel = sParts(1) And sParts(2) <> Username And ListBox1.Items.Contains(sParts(2)) = False Then
                        ListBox1.Items.Add(sParts(2))
                    End If
                Next
            End If
            If sParts(0) = "RemoveChannelUser" Then
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = sParts(1) Then
                        Try
                            cChannel.userlist.Remove(sParts(2))
                        Catch
                        End Try
                    End If
                    If SelectedChannel = sParts(1) Then
                        Try
                            ListBox1.Items.Remove(sParts(2))
                        Catch
                        End Try
                    End If
                Next
            End If
            If sParts(0) = "AddList" Then
                AddList("AddList<{]>" & sParts(1))
            End If
            If sParts(0) = "AddListAll" Then
                Try
                    Dim aParts() As String = Split(sParts(1), "<(]>")
                    For Each user As String In aParts
                        AddList("AddList<{]>" & user)
                    Next
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            If sParts(0) = "UpdatePassword" Then
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = sParts(1) Then
                        cChannel.password = sParts(2)
                    End If
                Next
            End If
            If sParts(0) = "UpdateMOTD" Then
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = "Team Channel" Then
                        cChannel.motd = sParts(1)
                    End If
                Next
            End If
            If sParts(0) = "NewOwner" Then
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = sParts(1) Then
                        cChannel.owner = sParts(2)
                    End If
                Next
                If Username = sParts(2) Then
                    MsgBox("You are now the owner of: " & sParts(1))
                End If
            End If
            If sParts(0) = "UpdateMOTD" Then
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = sParts(1) Then
                        cChannel.motd = sParts(2)
                    End If
                Next
            End If
            If sParts(0) = "Promoted" Then
                If sParts(2) = Username Then
                    MsgBox("You have been promoted to channel manager in: " & sParts(1))
                End If
            End If
            If sParts(0) = "Demoted" Then
                If sParts(2) = Username Then
                    MsgBox("You have been demoted from channel manager in: " & sParts(1))
                End If
            End If
            If sParts(0) = "Removed" Then
                If sParts(2) = Username Then
                    MsgBox("You have been removed from: " & sParts(1))
                    SelectedChannel = "Public Channel"
                    ChangeChannel("Public Channel")
                End If
            End If
            If sParts(0) = "Info" Then
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = sParts(1) Then
                        MsgBox("Information for channel: " & sParts(1) & ", the owner is: " & cChannel.owner & ", channel managers: " & sParts(2))
                    End If
                Next
            End If
            If sParts(0) = "AddFriend" Then
                ListBox2.Items.Add(sParts(1))
                RefreshTimer.Start()
            End If
            If sParts(0) = "AddFriendAll" Then
                Dim aParts() As String = Split(sParts(1), "<(]>")
                For Each user As String In aParts
                    ListBox2.Items.Add(user)
                Next
                RefreshTimer.Start()
            End If
            If sParts(0) = "AddTeam" Then
                If sParts(1) <> Username Then
                    If ListBox4.Items.Contains(sParts(1)) = False Then
                        ListBox4.Items.Add(sParts(1))
                    End If
                End If
                RefreshTimer.Start()
            End If
            If sParts(0) = "AddTeamAll" Then
                Dim aParts() As String = Split(sParts(1), "<(]>")
                For Each user As String In aParts
                    If user <> Username Then
                        If ListBox4.Items.Contains(user) = False Then
                            ListBox4.Items.Add(user)
                        End If
                    End If
                Next
                RefreshTimer.Start()
            End If
            If sParts(0) = "SendTeam" Then
                If sParts(1) = Username Then
                    TeamLeaderUsername = sParts(2)
                    If sParts(1) = sParts(2) Then
                        TeamLeader = True
                    Else
                        ListBox4.Items.Add(sParts(2))
                    End If
                End If
                Dim txParts() As String = Split(sParts(3), "+/|")
                For Each coleader As String In txParts
                    If Username = coleader Then
                        TeamColeader = True
                    End If
                Next
                For Each cChannel As ChatChannel In channelList
                    If cChannel.name = "Team Channel" Then
                        cChannel.motd = sParts(4)
                    End If
                Next
                extraMemberItem = sParts(5)
                RefreshTimer.Start()
            End If
            If sParts(0) = "ChatMessage" Then
                If myChannels.Contains(sParts(1)) Then
                    ChannelManager.AddMessage(sParts(1), sParts(2), sParts(3), sParts(4), sParts(5), sParts(6), sParts(7), False, sParts(8))
                End If
            End If
            If sParts(0) = "RtfChatMessage" Then
                If myChannels.Contains(sParts(1)) Then
                    ChannelManager.AddMessage(sParts(1), sParts(2), sParts(3), sParts(4), sParts(5), sParts(6), sParts(7), True, sParts(8))
                End If
            End If
            If sParts(0) = "RmvList" Then
                Try
                    For Each cChannel In channelList
                        Try
                            cChannel.userlist.Remove(sParts(1))
                        Catch
                        End Try
                    Next
                    ListBox1.Items.Remove(sParts(1))
                    onlineuserlist.Remove(sParts(1))
                Catch
                End Try
            End If
            If sParts(0) = "privatechat" Then
                If Mute <> 0 Then
                    Return
                End If

                If Username = sParts(1) Then
                    If ignoreList.Contains(sParts(2)) = False Then
                        Dim xparts() As String
                        xparts = Split(TimeOfDay, " ")
                        Dim x As Integer = 0
                        Dim y As Integer = 0
                        While x <= formnumber
                            If newForm(x).Text = sParts(2) Then
                                If sParts(4) = 1 Then
                                    newForm(x).UpdateWindow(sParts(4), sParts(5), sParts(6), sParts(7), sParts(8), sParts(9), sParts(10), sParts(11), sParts(12), True)
                                End If
                                newForm(x).RichTextBox3.Select(newForm(x).RichTextBox3.TextLength, 0)
                                If newForm(x).RichTextBox3.Text <> "" Then
                                    newForm(x).RichTextBox3.AppendText(Environment.NewLine)
                                End If
                                newForm(x).RichTextBox3.SelectionColor = Color.FromArgb(newForm(x).lastPartnerTextColor)
                                newForm(x).RichTextBox3.AppendText("[" & xparts(0) & "]  >>    " & sParts(3))
                                newForm(x).RichTextBox3.SelectionStart = newForm(x).RichTextBox3.TextLength
                                newForm(x).RichTextBox3.SelectionLength = 0
                                newForm(x).RichTextBox3.ScrollToCaret()
                                newForm(x).Show()
                                y = 1
                            End If
                            x = x + 1
                        End While
                        If y = 0 Then
                            CreatePrivateChat(sParts(2), sParts(4))
                            If sParts(4) = 1 Then
                                newForm(x).UpdateWindow(sParts(4), sParts(5), sParts(6), sParts(7), sParts(8), sParts(9), sParts(10), sParts(11), sParts(12), True)
                            End If
                            newForm(x).RichTextBox3.Select(newForm(x).RichTextBox3.TextLength, 0)
                            If newForm(x).RichTextBox3.Text <> "" Then
                                newForm(x).RichTextBox3.AppendText(Environment.NewLine)
                            End If
                            newForm(x).RichTextBox3.SelectionColor = Color.FromArgb(newForm(x).lastPartnerTextColor)
                            newForm(x).RichTextBox3.AppendText("[" & xparts(0) & "]  >>    " & sParts(3))
                            newForm(x).RichTextBox3.SelectionStart = newForm(x).RichTextBox3.TextLength
                            newForm(x).RichTextBox3.SelectionLength = 0
                            newForm(x).RichTextBox3.ScrollToCaret()
                            newForm(x).Show()
                        End If
                    ElseIf ignoreMessage <> "" Then
                        SendPrivateMessage(sParts(2), ignoreMessage)
                    End If
                End If
            End If
            If sParts(0) = "me" Then
                If sParts(3) = "Team Channel" Then
                    If MyTeam = sParts(4) Then
                        ChannelManager.AddMessage(sParts(3), "MeCommand", sParts(4), "", "", sParts(1) & " " & sParts(2), "")
                    End If
                ElseIf myChannels.Contains(sParts(3)) Then
                    ChannelManager.AddMessage(sParts(3), "MeCommand", sParts(4), "", "", sParts(1) & " " & sParts(2), "")
                End If
            End If
            If sParts(0) = "kick" Then
                Try
                    If sParts(1) = Username Then
                        MsgBox("You have been kicked by " & sParts(2) & ", Reason: " & sParts(3))
                        End
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has kicked: " & sParts(1) & ", Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "setwp" Then
                Try
                    If sParts(1) = Username Then
                        MsgBox("You have been given " & sParts(4) & " WP by " & sParts(2) & ", Reason: " & sParts(3))
                        End
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has given: " & sParts(1) & " " & sParts(4) & " WP, Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "mute" Then
                Try
                    If sParts(1) = Username Then
                        For Each chatForm As PrivateChat In newForm
                            chatForm.Close()
                        Next

                        MsgBox("You have been muted by " & sParts(2) & ", Reason: " & sParts(3))
                        Mute = 1
                        RichTextBox2.Enabled = False
                        ListBox1.Enabled = False
                        ListBox2.Enabled = False
                        ListBox4.Enabled = False
                        ListBox5.Enabled = False
                        searchbar.Enabled = False
                        ListBox6.Enabled = False
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has muted: " & sParts(1) & ", Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "timedmute" Then
                Try
                    If sParts(1) = Username Then
                        For Each chatForm As PrivateChat In newForm
                            chatForm.Close()
                        Next

                        MsgBox("You have been muted for: " & sParts(4) & ", by " & sParts(2) & ", Reason: " & sParts(3))
                        Mute = 1
                        RichTextBox2.Enabled = False
                        ListBox1.Enabled = False
                        ListBox2.Enabled = False
                        ListBox4.Enabled = False
                        ListBox5.Enabled = False
                        searchbar.Enabled = False
                        ListBox6.Enabled = False
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has muted: " & sParts(1) & " for: " & sParts(4) & ", Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "unmute" Then
                Try
                    If sParts(1) = Username Then
                        MsgBox("You have been unmuted by " & sParts(2) & ", Reason: " & sParts(3))
                        Mute = 0
                        RichTextBox2.Enabled = True
                        ListBox1.Enabled = True
                        ListBox2.Enabled = True
                        ListBox4.Enabled = True
                        ListBox5.Enabled = True
                        searchbar.Enabled = True
                        ListBox6.Enabled = True
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has unmuted: " & sParts(1) & ", Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "disableranked" Then
                Try
                    If sParts(1) = Username Then
                        MsgBox("You have been blocked from playing ranked games by " & sParts(2) & ", Reason: " & sParts(3))
                        RankedStatus = 1
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has blocked: " & sParts(1) & " from playing ranked games, Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "enableranked" Then
                Try
                    If sParts(1) = Username Then
                        MsgBox("You are no longer blocked from playing ranked games by " & sParts(2) & ", Reason: " & sParts(3))
                        RankedStatus = 0
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has unblocked: " & sParts(1) & " from playing ranked games, Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "clear" Then
                If SelectedChannel = sParts(1) Then
                    PublicTxt.Clear()
                End If
                ChannelManager.ClearChannel(sParts(1))
                ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has cleared the chat, Reason: " & sParts(3), "")
            End If
            If sParts(0) = "ban" Then
                Try
                    If sParts(1) = Username Then
                        End
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(2) & " has banned: " & sParts(1) & ", Reason: " & sParts(3), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "announce" Then
                ChannelManager.AddMessage("", "System", "", "", "", "ANNOUNCEMENT: " & sParts(1), "")
            End If
            If sParts(0) = "setrank" Then
                Try
                    If sParts(1) = Username Then
                        MsgBox("Your rank has been modified, Reason : " & sParts(4) & ". Game will now exit, please relog to see your new rank!")
                        End
                    Else
                        ChannelManager.AddMessage("", "System", "", "", "", "ANNOUNCEMENT: " & sParts(1) & " has been given the rank: " & sParts(2) & ", by: " & sParts(3) & ", Reason: " & sParts(4), "")
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "TeamInvite" Then
                If Username = sParts(2) Then
                    If MyTeam = "" Then
                        Dim MBXResult﻿ As DialogResult = MessageBox.Show(sParts(1) & " has invited you to join: " & sParts(3), "Team Invite", MessageBoxButtons.YesNo)
                        If MBXResult﻿ = MsgBoxResult.Yes Then
                            streamw.WriteLine("TeamInvConfrm" & "<{]>" & Username & "<{]>" & sParts(3))
                            streamw.Flush()
                            If achievements.Contains(1) = False Then
                                AddAchievement(Username, 1, 0)
                                achievements.Add(1)
                            End If
                            MsgBox("The game will now close, please relog!")
                            End
                        End If
                    Else
                        streamw.WriteLine("TeamInviteFailed" & "<{]>" & sParts(1) & "<{]>" & Username)
                        streamw.Flush()
                    End If
                End If
            End If
            If sParts(0) = "TeamInviteFailed" Then
                If Username = sParts(1) Then
                    MsgBox("User: " & sParts(2) & " is already a member of a team, please tell them to leave their current team by typing /leaveteam")
                End If
            End If
            If sParts(0) = "TeamInvConfrm" Then
                If MyTeam = sParts(2) Then
                    If sParts(1) <> Username Then
                        ListBox4.Items.Add(sParts(1))
                    End If
                End If
            End If
            If sParts(0) = "TeamKick" Then
                If sParts(2) = MyTeam Then
                    Try
                        ListBox4.Items.Remove(sParts(1))
                    Catch
                    End Try
                End If
                If sParts(1) = Username Then
                    MsgBox("You have been removed from your team, game will now exit, please relog!")
                    End
                End If
            End If
            If sParts(0) = "TeamDisband" Then
                If sParts(2) = MyTeam Then
                    MsgBox("Your team has been disbanded")
                    End
                End If
            End If
            If sParts(0) = "TeamCreateComplete" Then
                If sParts(1) = Username Then
                    If achievements.Contains(1) = False Then
                        AddAchievement(Username, 1, 0)
                        achievements.Add(1)
                    End If
                    MsgBox("Your team has been created, game will now exit, please relog!")
                    End
                End If
            End If
            If sParts(0) = "TeamCreateFail" Then
                If sParts(1) = Username Then
                    MsgBox("Team name already in use, please select a different team name!")
                End If
            End If
            If sParts(0) = "RequestMyProfile" Then
                If sParts(1) = Username Then
                    Try
                        EditProfile.LoadDecks()
                        EditProfile.ComboBox1.Text = sParts(2)
                        EditProfile.NumericUpDown1.Text = sParts(3)
                        EditProfile.TextBox2.Text = sParts(4)
                        EditProfile.TextBox4.Text = sParts(5)
                        EditProfile.TextBox6.Text = sParts(6)
                        EditProfile.TextBox5.Text = sParts(7)
                        EditProfile.TextBox7.Text = sParts(8)
                        EditProfile.Username.Text = Username
                        EditProfile.Rank.Text = Rank
                        EditProfile.Team.Text = MyTeam
                        EditProfile.Rating.Text = sParts(10)
                        EditProfile.KCGold.Text = sParts(11)
                        EditProfile.Win.Text = sParts(12)
                        EditProfile.Draw.Text = sParts(13)
                        EditProfile.Lost.Text = sParts(14)
                        EditProfile.TRating.Text = sParts(15)
                        EditProfile.Twin.Text = sParts(16)
                        EditProfile.TDraw.Text = sParts(17)
                        EditProfile.TLost.Text = sParts(18)
                        EditProfile.MRating.Text = sParts(23)
                        EditProfile.MWin.Text = sParts(24)
                        EditProfile.MDraw.Text = sParts(25)
                        EditProfile.MLost.Text = sParts(26)
                        Dim updatelevel As Integer = 1
                        While (updatelevel * 500) < sParts(27)
                            sParts(27) = sParts(27) - (updatelevel * 500)
                            updatelevel = updatelevel + 1
                        End While
                        EditProfile.Level.Text = updatelevel
                        EditProfile.XP.Text = sParts(27) & "/" & updatelevel * 500
                        EditProfile.WP.Text = WP
                        If sParts(19) = 1 Then
                            EditProfile.Qualification.Image = My.Resources.Qualified1
                        End If
                        If sParts(19) = 2 Then
                            EditProfile.Qualification.Image = My.Resources.Qualified2
                        End If
                        If sParts(19) = 3 Then
                            EditProfile.Qualification.Image = My.Resources.Qualified3
                        End If
                        If sParts(20) = 1 And sParts(21) = 1 And sParts(22) = 1 Then
                            'EditProfile.A1.Image = My.Resources.A1
                            EditProfile.A2.Image = My.Resources.C1
                            EditProfile.A3.Image = My.Resources.W1
                        ElseIf sParts(20) = 1 And sParts(21) = 1 And sParts(22) = 0 Then
                            'EditProfile.A1.Image = My.Resources.A1
                            EditProfile.A2.Image = My.Resources.C1
                        ElseIf sParts(20) = 1 And sParts(21) = 0 And sParts(22) = 1 Then
                            'EditProfile.A1.Image = My.Resources.A1
                            EditProfile.A2.Image = My.Resources.W1
                        ElseIf sParts(20) = 0 And sParts(21) = 1 And sParts(22) = 1 Then
                            EditProfile.A1.Image = My.Resources.C1
                            EditProfile.A2.Image = My.Resources.W1
                        ElseIf sParts(20) = 1 And sParts(21) = 0 And sParts(22) = 0 Then
                            'EditProfile.A1.Image = My.Resources.A1
                        ElseIf sParts(20) = 0 And sParts(21) = 1 And sParts(22) = 0 Then
                            EditProfile.A1.Image = My.Resources.C1
                        ElseIf sParts(20) = 0 And sParts(21) = 0 And sParts(22) = 1 Then
                            EditProfile.A1.Image = My.Resources.W1
                        End If
                        EditProfile.Label35.Text = sParts(28)
                        EditProfile.Label37.Text = sParts(29)
                        EditProfile.Label42.Text = sParts(30)
                        EditProfile.Label44.Text = sParts(31)
                        EditProfile.Label39.Text = sParts(32)
                        EditProfile.Label48.Text = sParts(33)
                        EditProfile.Label350.Text = sParts(34)
                        EditProfile.Label34.Text = sParts(35)
                        EditProfile.Label18.Text = sParts(36)
                        EditProfile.auw = sParts(28)
                        EditProfile.buw = sParts(34)
                        EditProfile.cuw = sParts(31)
                        Try
                            Dim textColor As Double = sParts(77)
                            EditProfile.Label96.Text = "Custom"
                        Catch ex As Exception
                            EditProfile.Label96.Text = sParts(77)
                        End Try


                        EditProfile.RankedSeasons.Clear()
                        EditProfile.selectSeasonComboBox.Items.Clear()

                        EditProfile.AddRankedSeason(0, sParts(56), sParts(57), sParts(58), sParts(59), 1500, 0, 0, 0, 1500, 0, 0, 0)
                        EditProfile.AddRankedSeason(1, sParts(44), sParts(45), sParts(46), sParts(47), sParts(48), sParts(49), sParts(50), sParts(51), sParts(52), sParts(53), sParts(54), sParts(55))
                        EditProfile.AddRankedSeason(2, sParts(62), sParts(63), sParts(64), sParts(65), sParts(66), sParts(67), sParts(68), sParts(69), sParts(70), sParts(71), sParts(72), sParts(73))

                        Dim nextSeason As Integer = 3
                        Dim nextValueID As Integer = 78
                        While (nextValueID + 12) <= sParts.Count
                            EditProfile.AddRankedSeason(nextSeason, sParts(nextValueID), sParts(nextValueID + 1), sParts(nextValueID + 2), sParts(nextValueID + 3), sParts(nextValueID + 4), sParts(nextValueID + 5), sParts(nextValueID + 6), sParts(nextValueID + 7), sParts(nextValueID + 8), sParts(nextValueID + 9), sParts(nextValueID + 10), sParts(nextValueID + 11))
                            nextSeason += 1
                            nextValueID += 12
                        End While

                        EditProfile.AddRankedSeason(nextSeason, sParts(10), sParts(12), sParts(13), sParts(14), sParts(15), sParts(16), sParts(17), sParts(18), sParts(23), sParts(24), sParts(25), sParts(26))

                        EditProfile.UpdateRankedSeasonDisplay(nextSeason)

                        HeartOfFire = sParts(38)
                        LunarLantern = sParts(39)
                        EditProfile.Label55.Text = sParts(41)
                        MyTitle = sParts(37)
                        EditProfile.Label82.Text = MyTitle
                        EditProfile.RichTextBox1.Text = sParts(42)
                        If sParts(9) <> "" Then
                            EditProfile.setImageFunction(sParts(9))
                        End If
                        If sParts(76) = 1 Then
                            EditProfile.Label16.Hide()
                            EditProfile.Button5.Hide()
                            EditProfile.Button6.Hide()
                            EditProfile.VerificationCode.Hide()
                            EditProfile.Panel14.Hide()
                            EditProfile.Panel43.Hide()
                            EditProfile.Panel44.Hide()
                            EditProfile.Panel45.Hide()
                        End If
                    Catch
                    End Try
                    EditProfile.Text = Username
                    EditProfile.Show()
                    Try
                        EditProfile.LoadBorders(sParts(60), sParts(61))
                        EditProfile.achievements = sParts(43)
                        EditProfile.LoadAchievements("General")
                        If sParts(40) <> "" Then
                            EditProfile.AddTitles(sParts(40))
                        End If
                        EditProfile.LoadTitles()
                    Catch
                    End Try
                End If
            End If
            If sParts(0) = "RequestProfile" Then
                If sParts(1) = Username Then
                    Try
                        Profile.ProfilePicture.BackgroundImageLayout = ImageLayout.Stretch
                        Profile.ProfilePicture.BackgroundImage = Image.FromFile(Current & "\YGOPRO\textures\avatar.png")
                    Catch
                    End Try
                    Profile.Gender.Text = sParts(2)
                    Profile.Age.Text = sParts(3)
                    Profile.Location.Text = sParts(4)
                    Profile.FavouriteCard.Text = sParts(5)
                    Profile.JobHobbies.Text = sParts(6)
                    Profile.Email.Text = sParts(7)
                    Profile.Skype.Text = sParts(8)
                    Profile.Username.Text = sParts(10)
                    Profile.Rank.Text = sParts(11)
                    Profile.Team.Text = sParts(12)
                    Profile.Rating.Text = sParts(13)
                    Profile.KCGold.Text = sParts(14)
                    Profile.Win.Text = sParts(15)
                    Profile.Draw.Text = sParts(16)
                    Profile.Lost.Text = sParts(17)
                    Profile.WP.Text = sParts(18)
                    Profile.TRating.Text = sParts(19)
                    Profile.TWin.Text = sParts(20)
                    Profile.TDraw.Text = sParts(21)
                    Profile.TLost.Text = sParts(22)
                    Profile.MRating.Text = sParts(27)
                    Profile.MWin.Text = sParts(28)
                    Profile.MDraw.Text = sParts(29)
                    Profile.MLost.Text = sParts(30)
                    Profile.Title.Text = sParts(32)
                    Dim updatelevel As Integer = 1
                    While (updatelevel * 500) < sParts(31)
                        sParts(31) = sParts(31) - (updatelevel * 500)
                        updatelevel = updatelevel + 1
                    End While
                    Profile.Level.Text = updatelevel
                    Profile.XP.Text = sParts(31) & "/" & updatelevel * 500
                    If sParts(23) = 1 Then
                        Profile.Qualification.Image = My.Resources.Qualified1
                    End If
                    If sParts(23) = 2 Then
                        MyQualification = 2
                        Profile.Qualification.Image = My.Resources.Qualified2
                    End If
                    If sParts(23) = 3 Then
                        MyQualification = 3
                        Profile.Qualification.Image = My.Resources.Qualified3
                    End If
                    If sParts(24) = 1 And sParts(25) = 1 And sParts(26) = 1 Then
                        'Profile.A1.Image = My.Resources.A1
                        Profile.A2.Image = My.Resources.C1
                        Profile.A3.Image = My.Resources.W1
                    ElseIf sParts(24) = 1 And sParts(25) = 1 And sParts(26) = 0 Then
                        'Profile.A1.Image = My.Resources.A1
                        Profile.A2.Image = My.Resources.C1
                    ElseIf sParts(24) = 1 And sParts(25) = 0 And sParts(26) = 1 Then
                        'Profile.A1.Image = My.Resources.A1
                        Profile.A2.Image = My.Resources.W1
                    ElseIf sParts(24) = 0 And sParts(25) = 1 And sParts(26) = 1 Then
                        Profile.A1.Image = My.Resources.C1
                        Profile.A2.Image = My.Resources.W1
                    ElseIf sParts(24) = 1 And sParts(25) = 0 And sParts(26) = 0 Then
                        'Profile.A1.Image = My.Resources.A1
                    ElseIf sParts(24) = 0 And sParts(25) = 1 And sParts(26) = 0 Then
                        Profile.A1.Image = My.Resources.C1
                    ElseIf sParts(24) = 0 And sParts(25) = 0 And sParts(26) = 1 Then
                        Profile.A1.Image = My.Resources.W1
                    End If
                    Profile.ProfilePicture.Image = Nothing
                    If sParts(9) <> "" Then
                        Try
                            Profile.setImageFunction(sParts(9))
                        Catch
                        End Try
                    End If
                    Profile.Text = sParts(10)
                    Profile.Show()
                    Profile.auw = sParts(49)
                    Profile.buw = sParts(50)
                    Profile.cuw = sParts(51)
                    Profile.MyQualification = sParts(23)
                    Profile.MyA1 = sParts(24)
                    Profile.JD1 = sParts(52)
                    Profile.ForumBooster = sParts(53)
                    Profile.ForumTurboCharger = sParts(54)
                    Profile.HeartOfFire = sParts(55)
                    Profile.LunarLantern = sParts(56)
                    Profile.MeItem = sParts(57)
                    Profile.achievements = sParts(58)
                    Profile.Label11.Text = sParts(59)
                    Profile.RichTextBox1.Text = sParts(60)
                    Profile.LoadAchievements("General")

                    Profile.RankedSeasons.Clear()
                    Profile.selectSeasonComboBox.Items.Clear()

                    Profile.AddRankedSeason(0, sParts(45), sParts(46), sParts(47), sParts(48), 1500, 0, 0, 0, 1500, 0, 0, 0)
                    Profile.AddRankedSeason(1, sParts(33), sParts(34), sParts(35), sParts(36), sParts(37), sParts(38), sParts(39), sParts(40), sParts(41), sParts(42), sParts(43), sParts(44))

                    Dim nextSeason As Integer = 2
                    Dim nextValueID As Integer = 61
                    While (nextValueID + 12) <= sParts.Count
                        Profile.AddRankedSeason(nextSeason, sParts(nextValueID), sParts(nextValueID + 1), sParts(nextValueID + 2), sParts(nextValueID + 3), sParts(nextValueID + 4), sParts(nextValueID + 5), sParts(nextValueID + 6), sParts(nextValueID + 7), sParts(nextValueID + 8), sParts(nextValueID + 9), sParts(nextValueID + 10), sParts(nextValueID + 11))
                        nextSeason += 1
                        nextValueID += 12
                    End While

                    Profile.AddRankedSeason(nextSeason, sParts(13), sParts(15), sParts(16), sParts(17), sParts(19), sParts(20), sParts(21), sParts(22), sParts(27), sParts(28), sParts(29), sParts(30))

                    Profile.UpdateRankedSeasonDisplay(nextSeason)
                End If
            End If
            If sParts(0) = "RequestTeamProfile" Then
                teamPage = New TeamPage

                teamPage.setImageFunction(sParts(1))
                teamPage.Rating.Text = "Single: " & sParts(2)
                teamPage.Win.Text = "Won: " & sParts(3)
                teamPage.Draw.Text = "Drew: " & sParts(4)
                teamPage.Lost.Text = "Lost: " & sParts(5)
                teamPage.TRating.Text = "Tag: " & sParts(6)
                teamPage.Twin.Text = "Won: " & sParts(7)
                teamPage.TDraw.Text = "Drew: " & sParts(8)
                teamPage.TLost.Text = "Lost: " & sParts(9)
                teamPage.MRating.Text = "Match: " & sParts(10)
                teamPage.MWin.Text = "Won: " & sParts(11)
                teamPage.MDraw.Text = "Drew: " & sParts(12)
                teamPage.MLost.Text = "Lost: " & sParts(13)
                teamPage.Gold.Text = "Gold: " & sParts(15)

                Dim allowedMembers As Integer = 20
                Dim extraMemberItem As Integer = sParts(17)

                If (sParts(14) > 50000) Then
                    allowedMembers += 5
                End If
                If (sParts(14) > 225000) Then
                    allowedMembers += 5
                End If
                If (sParts(14) > 525000) Then
                    allowedMembers += 5
                End If
                If (sParts(14) > 950000) Then
                    allowedMembers += 5
                End If

                allowedMembers = allowedMembers + (10 * extraMemberItem)
                teamPage.Members.Text = "Members: " & ListBox4.Items.Count & "/" & allowedMembers

                Dim txParts() As String = Split(sParts(16), "+/|")
                For Each coleader As String In txParts
                    If ListBox4.Items.Contains(coleader) = True Or Username = coleader Then
                        If teamPage.coleaderList.Contains(coleader) = False Then
                            teamPage.coleaderList.Add(coleader)
                        End If
                    End If
                Next
                Dim updatelevel As Integer = 1
                While (updatelevel * 5000) < sParts(14)
                    sParts(14) = sParts(14) - (updatelevel * 5000)
                    updatelevel = updatelevel + 1
                End While
                teamPage.Level.Text = "Level: " & updatelevel
                teamPage.XP.Text = "XP: " & (Math.Floor(Convert.ToDouble(sParts(14) / 100)) / 10) & "k/" & Math.Floor(Convert.ToInt32((updatelevel * 5000) / 1000)) & "k"
                If TeamLeader = True Or TeamColeader = True Then
                    teamPage.Button2.Enabled = True
                End If

                HomePanel.Controls.Add(teamPage)
                teamPage.BringToFront()
                HomePanel.Show()
                HomePanel.BringToFront()
                DuelPanel.Hide()
                ChatPanel.Hide()

                Try
                    If disposeStoreControl = True Then
                        storeControl.Dispose()
                        disposeStoreControl = False
                    End If
                Catch
                End Try

                SetTeamRankingImages(sParts(2), sParts(10), sParts(6))
            End If
            If sParts(0) = "TicketCreated" Then
                Try
                    Dim newTicket As New Ticket(sParts(2), sParts(3) & " (ID: " & sParts(2) & ")", sParts(3), sParts(4), sParts(5), 0, 0, DateTime.Now.ToString("M'/'d'/'yyyy"), DateTime.Now.ToString("M'/'d'/'yyyy"))

                    If Username = sParts(1) Then
                        ticketList.Add(newTicket)

                        CommunityCenter.ListBox1.Items.Insert(0, newTicket.Title)
                    End If

                    If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(1) & " has made a new ticket!", "")

                        If staffTicketList.Contains(newTicket) = False Then
                            staffTicketList.Add(newTicket)
                        End If

                        If Admin_Control_Panel.ListBox1.Items.Contains(newTicket.Title) = False Then
                            Admin_Control_Panel.ListBox1.Items.Insert(0, newTicket.Title)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If
            If sParts(0) = "AddTicket" Then
                Dim aParts() As String = Split(sParts(1), "<(]>")

                For Each receivedTicket As String In aParts
                    Dim bParts() As String = Split(receivedTicket, "<{)>")

                    Dim newTicket As Ticket

                    If bParts(5) = "1" Then
                        newTicket = New Ticket(bParts(0), "(CLOSED) " & bParts(1) & " (ID: " & bParts(0) & ")", bParts(1), bParts(2), bParts(3), bParts(4), bParts(5), bParts(6), bParts(7))
                    Else
                        newTicket = New Ticket(bParts(0), bParts(1) & " (ID: " & bParts(0) & ")", bParts(1), bParts(2), bParts(3), bParts(4), bParts(5), bParts(6), bParts(7))
                    End If
                    ticketList.Add(newTicket)

                    CommunityCenter.ListBox1.Items.Insert(0, newTicket.Title)
                Next
            End If
            If sParts(0) = "AddStaffTicket" Then
                Dim aParts() As String = Split(sParts(1), "<(]>")

                For Each receivedTicket As String In aParts
                    Dim bParts() As String = Split(receivedTicket, "<{)>")

                    Dim newTicket As Ticket
                    newTicket = New Ticket(bParts(0), bParts(1) & " (ID: " & bParts(0) & ")", bParts(1), bParts(2), bParts(3), bParts(4), 0, bParts(5), bParts(6))

                    If staffTicketList.Contains(newTicket) = False Then
                        staffTicketList.Add(newTicket)
                    End If

                    If Admin_Control_Panel.ListBox1.Items.Contains(newTicket.Title) = False Then
                        Admin_Control_Panel.ListBox1.Items.Insert(0, newTicket.Title)
                    End If
                Next
            End If
            If sParts(0) = "TicketUpdated" Then
                If Username = sParts(1) Then
                    For Each myTicket As Ticket In ticketList
                        If myTicket.ID = sParts(2) Then
                            myTicket.Messages = sParts(3)

                            If CommunityCenter.ListBox1.SelectedItem = myTicket.Title Then
                                CommunityCenter.UpdateTicket()
                            End If

                            Exit For
                        End If
                    Next
                End If

                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                    For Each myTicket As Ticket In staffTicketList
                        If myTicket.ID = sParts(2) Then
                            myTicket.Messages = sParts(3)
                            myTicket.DateUpdated = DateTime.Now.ToString("M'/'d'/'yyyy")

                            If Admin_Control_Panel.ListBox1.SelectedItem = myTicket.Title Then
                                Admin_Control_Panel.UpdateTicket()
                            End If

                            Exit For
                        End If
                    Next

                    ChannelManager.AddMessage("", "System", "", "", "", sParts(1) & " has updated their ticket!", "")
                End If
            End If
            If sParts(0) = "StaffTicketUpdated" Then
                Dim ticketCheck As Boolean = True

                For Each myTicket As Ticket In ticketList
                    If myTicket.ID = sParts(2) Then
                        myTicket.Messages = sParts(3)

                        If CommunityCenter.ListBox1.SelectedItem = myTicket.Title Then
                            CommunityCenter.UpdateTicket()
                            ChannelManager.AddMessage("", "System", "", "", "", sParts(1) & " has updated your ticket!", "")
                            ticketCheck = False
                        End If

                        Exit For
                    End If
                Next

                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                    For Each myTicket As Ticket In staffTicketList
                        If myTicket.ID = sParts(2) Then
                            myTicket.Messages = sParts(3)

                            If Admin_Control_Panel.ListBox1.SelectedItem = myTicket.Title Then
                                Admin_Control_Panel.UpdateTicket()
                            End If

                            Exit For
                        End If
                    Next

                    If ticketCheck = True Then
                        ChannelManager.AddMessage("", "System", "", "", "", sParts(1) & " has updated a ticket!", "")
                    End If
                End If
            End If
            If sParts(0) = "TicketClosed" Then
                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                    Dim ticketsRemoveList As New List(Of Ticket)
                    For Each myTicket As Ticket In staffTicketList
                        If myTicket.Title = Admin_Control_Panel.ListBox1.SelectedItem Then
                            Admin_Control_Panel.Panel63.Show()
                        End If

                        If myTicket.ID = sParts(2) Then
                            Admin_Control_Panel.ListBox1.Items.Remove(myTicket.Title)

                            ticketsRemoveList.Add(myTicket)
                        End If
                    Next

                    For Each myTicket As Ticket In ticketsRemoveList
                        If staffTicketList.Contains(myTicket) Then
                            staffTicketList.Remove(myTicket)
                        End If
                    Next

                    ChannelManager.AddMessage("", "System", "", "", "", sParts(1) & " has closed their ticket!", "")
                End If
            End If
            If sParts(0) = "StaffTicketClosed" Then
                If sParts(3) = Username Then
                    For Each myTicket As Ticket In ticketList
                        If myTicket.ID = sParts(2) Then

                            myTicket.Closed = 1

                            If myTicket.Title = CommunityCenter.ListBox1.SelectedItem Then
                                CommunityCenter.Button2.Enabled = False
                                CommunityCenter.Button3.Enabled = False
                                CommunityCenter.RichTextBox3.Enabled = False
                            End If

                            Dim x As Integer = 0
                            While x < CommunityCenter.ListBox1.Items.Count
                                If CommunityCenter.ListBox1.Items(x) = myTicket.Title Then
                                    CommunityCenter.ListBox1.Items(x) = "(CLOSED) " & CommunityCenter.ListBox1.Items(x)
                                    Exit While
                                End If
                                x += 1
                            End While

                            Exit For
                        End If
                    Next
                    ChannelManager.AddMessage("", "System", "", "", "", "Your ticket has been closed by " & sParts(1), "")
                End If

                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                    Dim removeItem As Integer = -1
                    Dim counter As Integer = 0

                    While counter < Admin_Control_Panel.ListBox1.Items.Count
                        If Admin_Control_Panel.ListBox1.Items(counter).Contains("(ID: " & sParts(2) & ")") Then
                            removeItem = counter
                            Exit While
                        End If
                        counter += 1
                    End While

                    If removeItem <> -1 Then
                        Try
                            Admin_Control_Panel.ListBox1.Items.Remove(Admin_Control_Panel.ListBox1.Items(counter))
                        Catch
                        End Try
                    End If
                End If
            End If
            If sParts(0) = "TicketLocked" Then
                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then

                    For Each myTicket As Ticket In staffTicketList
                        If myTicket.ID = sParts(2) Then
                            myTicket.LockedBy = sParts(1)
                            If Admin_Control_Panel.ListBox1.Items(Admin_Control_Panel.ListBox1.SelectedIndex) = myTicket.Title Then
                                Admin_Control_Panel.UpdateTicket()
                            End If
                        End If
                    Next
                End If
            End If
            If sParts(0) = "RequestUserInfoUsername" Then
                Message = Message.Replace("{NL]", Environment.NewLine)
                sParts = Split(Message, "<{]>")

                Try
                    Admin_Control_Panel.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
                    Admin_Control_Panel.PictureBox1.BackgroundImage = Image.FromFile(Current & "\YGOPRO\textures\avatar.png")
                Catch
                End Try
                Admin_Control_Panel.Panel64.Hide()
                Admin_Control_Panel.PictureBox1.Image = Nothing
                Admin_Control_Panel.usernameSearch = sParts(1)
                Admin_Control_Panel.Username.Text = "Username: " & sParts(1)
                Admin_Control_Panel.Rank.Text = "Rank: " & sParts(2)
                Admin_Control_Panel.rankTextBox.Text = sParts(2)
                Dim updatelevel As Integer = 1
                While (updatelevel * 500) < sParts(3)
                    sParts(3) = sParts(3) - (updatelevel * 500)
                    updatelevel = updatelevel + 1
                End While
                Admin_Control_Panel.Level.Text = "Level: " & updatelevel
                Admin_Control_Panel.Gold.Text = "Gold: " & sParts(10)
                Admin_Control_Panel.Diamonds.Text = "Diamonds: " & sParts(11)

                Admin_Control_Panel.TextBox5.Text = sParts(7)
                Admin_Control_Panel.TextBox3.Text = sParts(10)
                Admin_Control_Panel.TextBox4.Text = sParts(11)

                Dim registrationDate As String = sParts(4)
                Dim lastLoginDate As String = sParts(5)
                Dim muted As String = sParts(8)
                Dim banned As String = sParts(9)

                If registrationDate = "0" Then
                    registrationDate = "Before February 19, 2015"
                End If

                If lastLoginDate = "0" Then
                    lastLoginDate = "Before February 19, 2015"
                End If

                If lastLoginDate = "1" Then
                    lastLoginDate = "Never"
                End If

                If banned = 0 Then
                    banned = "Not Banned"
                ElseIf banned = 1 Then
                    banned = "Permanently Banned"
                ElseIf banned = 2 Then
                    Dim bannedUntil As DateTime = Convert.ToDateTime(sParts(16))
                    Dim span As TimeSpan = DateTime.Now - bannedUntil
                    If span.Milliseconds > 0 Then
                        banned = "Not Banned"
                    Else
                        banned = "Banned until " & sParts(16).Substring(0, 10)
                    End If
                End If

                If muted = 0 Then
                    muted = "Not Muted"
                ElseIf muted = 1 Then
                    muted = "Permanently Muted"
                ElseIf muted = 2 Then
                    Dim mutedUntil As DateTime = Convert.ToDateTime(sParts(24))
                    Dim span As TimeSpan = DateTime.Now - mutedUntil
                    If span.Milliseconds > 0 Then
                        muted = "Not Muted"
                    Else
                        muted = "Muted until " & sParts(24).Substring(0, 10)
                    End If
                End If

                Dim timeOnlineOverall As String
                Dim timeOnlineOverallHours As Double = Math.Round((sParts(17) / 60) / 60, 1)

                If timeOnlineOverallHours > 24 Then
                    Dim daysPrefix As String = "Days"
                    Dim hoursPrefix As String = "Hours"

                    Dim timeOnlineOverallDays As Double = Math.Floor(timeOnlineOverallHours / 24)
                    timeOnlineOverallHours = Math.Round(timeOnlineOverallHours - (timeOnlineOverallDays * 24), 1)

                    If timeOnlineOverallDays = 1 Then
                        daysPrefix = "Day"
                    End If

                    If timeOnlineOverallHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineOverall = timeOnlineOverallDays & " " & daysPrefix & ", " & timeOnlineOverallHours & " " & hoursPrefix
                Else
                    Dim hoursPrefix As String = "Hours"

                    If timeOnlineOverallHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineOverall = timeOnlineOverallHours & " Hours"
                End If

                Dim timeOnlineLastWeek As String
                Dim timeOnlineLastWeekHours As Double = Math.Round((sParts(18) / 60) / 60, 1)

                If timeOnlineLastWeekHours > 24 Then
                    Dim daysPrefix As String = "Days"
                    Dim hoursPrefix As String = "Hours"

                    Dim timeOnlineLastWeekDays As Double = Math.Floor(timeOnlineLastWeekHours / 24)
                    timeOnlineLastWeekHours = Math.Round(timeOnlineLastWeekHours - (timeOnlineLastWeekDays * 24), 1)

                    If timeOnlineLastWeekDays = 1 Then
                        daysPrefix = "Day"
                    End If

                    If timeOnlineLastWeekHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineLastWeek = timeOnlineLastWeekDays & " " & daysPrefix & ", " & timeOnlineLastWeekHours & " " & hoursPrefix
                Else
                    Dim hoursPrefix As String = "Hours"

                    If timeOnlineLastWeekHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineLastWeek = timeOnlineLastWeekHours & " Hours"
                End If

                Dim timeOnlineLastMonth As String
                Dim timeOnlineLastMonthHours As Double = Math.Round((sParts(19) / 60) / 60, 1)

                If timeOnlineLastMonthHours > 24 Then
                    Dim daysPrefix As String = "Days"
                    Dim hoursPrefix As String = "Hours"

                    Dim timeOnlineLastMonthDays As Double = Math.Floor(timeOnlineLastMonthHours / 24)
                    timeOnlineLastMonthHours = Math.Round(timeOnlineLastMonthHours - (timeOnlineLastMonthDays * 24), 1)

                    If timeOnlineLastMonthDays = 1 Then
                        daysPrefix = "Day"
                    End If

                    If timeOnlineLastMonthHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineLastMonth = timeOnlineLastMonthDays & " " & daysPrefix & ", " & timeOnlineLastMonthHours & " " & hoursPrefix
                Else
                    Dim hoursPrefix As String = "Hours"

                    If timeOnlineLastMonthHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineLastMonth = timeOnlineLastMonthHours & " Hours"
                End If

                Dim timeOnlineThisMonth As String
                Dim timeOnlineThisMonthHours As Double = Math.Round((sParts(20) / 60) / 60, 1)

                If timeOnlineThisMonthHours > 24 Then
                    Dim daysPrefix As String = "Days"
                    Dim hoursPrefix As String = "Hours"

                    Dim timeOnlineThisMonthDays As Double = Math.Floor(timeOnlineThisMonthHours / 24)
                    timeOnlineThisMonthHours = Math.Round(timeOnlineThisMonthHours - (timeOnlineThisMonthDays * 24), 1)

                    If timeOnlineThisMonthDays = 1 Then
                        daysPrefix = "Day"
                    End If

                    If timeOnlineThisMonthHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineThisMonth = timeOnlineThisMonthDays & " " & daysPrefix & ", " & timeOnlineThisMonthHours & " " & hoursPrefix
                Else
                    Dim hoursPrefix As String = "Hours"

                    If timeOnlineThisMonthHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineThisMonth = timeOnlineThisMonthHours & " Hours"
                End If

                Dim timeOnlineThisWeek As String
                Dim timeOnlineThisWeekHours As Double = Math.Round((sParts(21) / 60) / 60, 1)

                If timeOnlineThisWeekHours > 24 Then
                    Dim daysPrefix As String = "Days"
                    Dim hoursPrefix As String = "Hours"

                    Dim timeOnlineThisWeekDays As Double = Math.Floor(timeOnlineThisWeekHours / 24)
                    timeOnlineThisWeekHours = Math.Round(timeOnlineThisWeekHours - (timeOnlineThisWeekDays * 24), 1)

                    If timeOnlineThisWeekDays = 1 Then
                        daysPrefix = "Day"
                    End If

                    If timeOnlineThisWeekHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineThisWeek = timeOnlineThisWeekDays & " " & daysPrefix & ", " & timeOnlineThisWeekHours & " " & hoursPrefix
                Else
                    Dim hoursPrefix As String = "Hours"

                    If timeOnlineThisWeekHours = 1 Then
                        hoursPrefix = "Hour"
                    End If

                    timeOnlineThisWeek = timeOnlineThisWeekHours & " Hours"
                End If


                Admin_Control_Panel.RegistrationDate.Text = "Registration Date: " & registrationDate
                Admin_Control_Panel.LastLoginDate.Text = "Last Login Date: " & lastLoginDate
                Admin_Control_Panel.QualificationLevel.Text = "Qualification Level: " & sParts(6)
                Admin_Control_Panel.WarningPoints.Text = "Warning Points: " & sParts(7)
                Admin_Control_Panel.BanStatus.Text = "Ban Status: " & banned
                Admin_Control_Panel.MuteStatus.Text = "Mute Status: " & muted
                Admin_Control_Panel.IP.Text = sParts(12)
                Admin_Control_Panel.MAC.Text = sParts(13)
                Admin_Control_Panel.UniqueID.Text = sParts(14)
                Admin_Control_Panel.timeonlineoverall.Text = "Time Online (Overall): " & timeOnlineOverall
                Admin_Control_Panel.timeonlinelastweek.Text = "Time Online (Last Week): " & timeOnlineLastWeek
                Admin_Control_Panel.timeonlinelastmonth.Text = "Time Online (Last Month): " & timeOnlineLastMonth
                Admin_Control_Panel.timeonlinethisweek.Text = "Time Online (This Week): " & timeOnlineThisWeek
                Admin_Control_Panel.timeonlinethismonth.Text = "Time Online (This Month): " & timeOnlineThisMonth
                Admin_Control_Panel.staffnotes.Text = sParts(22)

                If sParts(23) = 0 Then
                    sParts(23) = "Enabled"
                    Admin_Control_Panel.Button15.Text = "Disable Ranked"
                ElseIf sParts(23) = 1 Then
                    sParts(23) = "Disabled"
                    Admin_Control_Panel.Button15.Text = "Enable Ranked"
                End If

                If sParts(25) = 0 Then
                    Admin_Control_Panel.disableTickets.Text = "Disable Tickets"
                ElseIf sParts(25) = 1 Then
                    Admin_Control_Panel.disableTickets.Text = "Enable Tickets"
                End If

                Admin_Control_Panel.rankedstatus.Text = "Ranked Status: " & sParts(23)

                If (Admin_Control_Panel.BanStatus.Text.Contains("Permanently Banned")) Or (Admin_Control_Panel.BanStatus.Text.Contains("Banned until")) Then
                    Admin_Control_Panel.Button5.Text = "Unban"
                Else
                    Admin_Control_Panel.Button5.Text = "Ban"
                End If

                If (Admin_Control_Panel.MuteStatus.Text.Contains("Permanently Muted")) Or (Admin_Control_Panel.MuteStatus.Text.Contains("Muted until")) Then
                    Admin_Control_Panel.Button3.Text = "Unmute"
                Else
                    Admin_Control_Panel.Button3.Text = "Mute"
                End If

                Admin_Control_Panel.usersKicked.Text = "Users Kicked: " & sParts(26)
                Admin_Control_Panel.usersMuted.Text = "Users Muted: " & sParts(27)
                Admin_Control_Panel.usersBanned.Text = "Users Banned: " & sParts(28)
                Admin_Control_Panel.usersQualified.Text = "Users Qualified: " & sParts(29)
                Admin_Control_Panel.codesUsed.Text = "Codes Used: " & sParts(30)
                Admin_Control_Panel.wpset.Text = "WP Set: " & sParts(31)
                Admin_Control_Panel.ticketsAnswered.Text = "Tickets Answered: " & sParts(32)
                Admin_Control_Panel.flaggedrankgedgames.Text = "Flagged Ranked Games: " & sParts(33)

                Admin_Control_Panel.setImageFunction(sParts(15))
            End If
            If sParts(0) = "ShowAdminLogs" Then
                Admin_Control_Panel.AdminLogListView.Items.Clear()
                Dim xParts() As String = Split(sParts(1), "<(]>")

                For Each logEntry As String In xParts
                    Dim logInfo() As String = Split(logEntry, "<{)>")

                    If logInfo(5) = "" Then
                        logInfo(5) = "None"
                    End If

                    Dim newAdminLogEntry As ListViewItem
                    Admin_Control_Panel.AdminLogListView.BeginUpdate()

                    newAdminLogEntry = Admin_Control_Panel.AdminLogListView.Items.Add(logInfo(0).Substring(0, 11))
                    newAdminLogEntry.SubItems.Add(logInfo(1))
                    newAdminLogEntry.SubItems.Add(logInfo(2))
                    newAdminLogEntry.SubItems.Add(logInfo(3))
                    newAdminLogEntry.SubItems.Add(logInfo(4))
                    newAdminLogEntry.SubItems.Add(logInfo(5))

                    Dim logColor As New Color
                    If logInfo(1) = "Set Diamonds" Or logInfo(1) = "Set Gold" Or logInfo(1) = "Ticket Answered" Or logInfo(1) = "Unban" Or logInfo(1) = "Set Rank" Or
                        logInfo(1) = "Unmute" Or logInfo(1) = "Unban IP" Or logInfo(1) = "Unban Computer" Or logInfo(1) = "Enable Ranked" Or
                        logInfo(1) = "Enable Tickets" Or logInfo(1) = "Add Title" Or logInfo(1) = "Add Achievement" Or logInfo(1) = "Use Code" Then
                        logColor = Color.FromArgb(192, 255, 192)
                    ElseIf logInfo(1) = "Kick" Or logInfo(1) = "Set WP" Or logInfo(1) = "Update Staff Notes" Or logInfo(1) = "Clear Chat" Then
                        logColor = Color.FromArgb(255, 255, 192)
                    ElseIf logInfo(1) = "Mute" Or logInfo(1) = "Disable Ranked" Or logInfo(1) = "Disable Tickets" Then
                        logColor = Color.FromArgb(255, 217, 179)
                    Else
                        logColor = Color.FromArgb(255, 210, 210)
                    End If
                    newAdminLogEntry.BackColor = logColor

                    Admin_Control_Panel.AdminLogListView.Update()
                    Admin_Control_Panel.AdminLogListView.EndUpdate()
                Next
            End If
            If sParts(0) = "ShowStaffList" Then
                Admin_Control_Panel.StaffListView.Items.Clear()
                Dim xParts() As String = Split(sParts(1), "<(]>")
                Dim staffMemberList As New List(Of Admin_Control_Panel.StaffMember)

                For Each staffMember As String In xParts
                    Dim staffMemberInfo() As String = Split(staffMember, "<{)>")
                    Dim newStaffMember As New Admin_Control_Panel.StaffMember(staffMemberInfo(0), staffMemberInfo(1), staffMemberInfo(2), staffMemberInfo(3), staffMemberInfo(4), staffMemberInfo(5), staffMemberInfo(6), staffMemberInfo(7))
                    staffMemberList.Add(newStaffMember)
                Next

                staffMemberList = staffMemberList.OrderBy(Function(x) x.staffLevel).ToList()
                staffMemberList.Reverse()

                For Each staffMember As Admin_Control_Panel.StaffMember In staffMemberList
                    Dim newStaffListViewEntry As ListViewItem
                    Admin_Control_Panel.StaffListView.BeginUpdate()
                    newStaffListViewEntry = Admin_Control_Panel.StaffListView.Items.Add(staffMember.username)
                    newStaffListViewEntry.SubItems.Add(staffMember.rank)
                    newStaffListViewEntry.SubItems.Add(staffMember.lastLoginDate)
                    newStaffListViewEntry.SubItems.Add(staffMember.totalActions)
                    newStaffListViewEntry.SubItems.Add(staffMember.timeOnlineThisWeek)
                    newStaffListViewEntry.SubItems.Add(staffMember.timeOnlineThisMonth)
                    newStaffListViewEntry.SubItems.Add(staffMember.timeOnlineLastMonth)
                    newStaffListViewEntry.SubItems.Add(staffMember.timeOnlineTotal)


                    Dim logColor As New Color
                    Dim textColor As New Color
                    textColor = Color.FromArgb(0, 0, 0)

                    If staffMember.rank = "Owner" Then
                        logColor = Color.FromArgb(122, 53, 0)
                        textColor = Color.FromArgb(255, 255, 255)
                    ElseIf staffMember.rank = "Curator" Then
                        logColor = Color.FromArgb(255, 48, 103)
                    ElseIf staffMember.rank = "Administrator" Then
                        logColor = Color.FromArgb(255, 43, 43)
                    ElseIf staffMember.rank = "Event Manager" Then
                        logColor = Color.FromArgb(255, 105, 180)
                    ElseIf staffMember.rank = "Global Moderator" Then
                        logColor = Color.FromArgb(192, 255, 192)
                    ElseIf staffMember.rank = "Moderator" Then
                        logColor = Color.FromArgb(50, 129, 255)
                    Else
                        logColor = Color.FromArgb(242, 84, 153)
                    End If

                    newStaffListViewEntry.BackColor = logColor
                    newStaffListViewEntry.ForeColor = textColor
                    Admin_Control_Panel.StaffListView.Update()
                    Admin_Control_Panel.StaffListView.EndUpdate()
                Next
            End If
            If sParts(0) = "ShowFlaggedRankedGames" Then
                Admin_Control_Panel.FlaggedRankedGamesListView.Items.Clear()
                Dim xParts() As String = Split(sParts(1), "<(]>")

                For Each flaggedGame As String In xParts
                    Try
                        Dim flaggedGameInfo() As String = Split(flaggedGame, "<{)>")

                        Dim newAdminLogEntry As ListViewItem
                        Admin_Control_Panel.FlaggedRankedGamesListView.BeginUpdate()

                        newAdminLogEntry = Admin_Control_Panel.FlaggedRankedGamesListView.Items.Add(flaggedGameInfo(0).Substring(0, 11))
                        newAdminLogEntry.SubItems.Add(flaggedGameInfo(1))
                        newAdminLogEntry.SubItems.Add(flaggedGameInfo(2))
                        newAdminLogEntry.SubItems.Add(flaggedGameInfo(3))
                        newAdminLogEntry.SubItems.Add(flaggedGameInfo(4))
                        newAdminLogEntry.SubItems.Add(flaggedGameInfo(5))
                        newAdminLogEntry.SubItems.Add(flaggedGameInfo(6))

                        Dim flaggedGameColor As New Color
                        If flaggedGameInfo(1) = "Single" Then
                            flaggedGameColor = Color.FromArgb(192, 255, 192)
                        ElseIf flaggedGameInfo(1) = "Match" Then
                            flaggedGameColor = Color.FromArgb(192, 255, 255)
                        ElseIf flaggedGameInfo(1) = "Tag" Then
                            flaggedGameColor = Color.FromArgb(255, 255, 192)
                        End If
                        newAdminLogEntry.BackColor = flaggedGameColor

                        Admin_Control_Panel.FlaggedRankedGamesListView.Update()
                        Admin_Control_Panel.FlaggedRankedGamesListView.EndUpdate()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Next
            End If
            If sParts(0) = "ShowPendingDeck" Then
                Try
                    Pending_Deck.deckId = sParts(1)
                    Pending_Deck.deckNameTxt.Text = sParts(2)

                    If sParts(3) = 0 Then
                        Pending_Deck.deckTypeLbl.Text = "Meta"
                    ElseIf sParts(3) = 1 Then
                        Pending_Deck.deckTypeLbl.Text = "Non-Meta"
                    Else
                        Pending_Deck.deckTypeLbl.Text = "Anime"
                    End If

                    Pending_Deck.uploadDateLbl.Text = sParts(4)
                    Pending_Deck.banlistLbl.Text = sParts(5)
                    Pending_Deck.uploadedByLbl.Text = sParts(6)
                    Pending_Deck.deckDescriptionRtxt.Text = sParts(7)
                    Pending_Deck.mainDeckList = Split(sParts(8), ",")
                    Pending_Deck.sideDeckList = Split(sParts(9), ",")
                    Pending_Deck.extraDeckList = Split(sParts(10), ",")
                    Pending_Deck.Show()
                    Pending_Deck.BringToFront()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            If sParts(0) = "ShowPendingDeckList" Then
                Try
                    Admin_Control_Panel.PendingDecksListView.Items.Clear()

                    If sParts(1) = "" Then
                        Return
                    End If

                    Dim pendingDecks() As String = Split(sParts(1), "<(}>")
                    Dim pendingDeckList As New List(Of String)(pendingDecks)
                    pendingDeckList.RemoveAt(pendingDeckList.Count - 1)

                    For Each pendingDeck As String In pendingDeckList
                        Try
                            Dim newPandingDeck As ListViewItem
                            Admin_Control_Panel.PendingDecksListView.BeginUpdate()

                            Dim pendingDeckParts() As String = Split(pendingDeck, "<(]>")

                            newPandingDeck = Admin_Control_Panel.PendingDecksListView.Items.Add(pendingDeckParts(0))
                            newPandingDeck.SubItems.Add(pendingDeckParts(1))

                            If pendingDeckParts(2) = 0 Then
                                newPandingDeck.SubItems.Add("Meta")
                            ElseIf pendingDeckParts(2) = 1 Then
                                newPandingDeck.SubItems.Add("Non-Meta")
                            Else
                                newPandingDeck.SubItems.Add("Anime")
                            End If

                            newPandingDeck.SubItems.Add(pendingDeckParts(3))
                            newPandingDeck.SubItems.Add(pendingDeckParts(4))
                            newPandingDeck.SubItems.Add(pendingDeckParts(5))
                            newPandingDeck.SubItems.Add(pendingDeckParts(6))

                            newPandingDeck.BackColor = Color.FromArgb(192, 255, 192)

                            Admin_Control_Panel.PendingDecksListView.Update()
                            Admin_Control_Panel.PendingDecksListView.EndUpdate()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    Next

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            If sParts(0) = "ApproveDeck" Then
                MsgBox("Deck has been approved! J.A.R.V.I.S. will now create a page for it on https://ygopro.org")
                SendToServer("ShowPendingDeckList")
            End If
            If sParts(0) = "DenyDeck" Then
                MsgBox("Deck has been denied! It will not be added to https://ygopro.org/")
                SendToServer("ShowPendingDeckList")
            End If
            If sParts(0) = "RequestACPActionList" Then
                Message = Message.Replace("{NL]", Environment.NewLine)
                sParts = Split(Message, "<{]>")

                Dim aParts() As String = Split(sParts(1), "<(]>")

                For Each action As String In aParts
                    Dim bparts() As String = Split(action, "<{)>")

                    If Admin_Control_Panel.RichTextBox1.Text <> "" Then
                        Admin_Control_Panel.RichTextBox1.Text = Environment.NewLine & Admin_Control_Panel.RichTextBox1.Text
                    End If

                    bparts(1) = bparts(1).Substring(0, 19)

                    If bparts(5) = "" Then
                        bparts(5) = "None"
                    End If

                    If bparts(4) = "None" Then
                        Admin_Control_Panel.RichTextBox1.Text = "    Date: " & bparts(1) & "    Action: " & bparts(2) & "    Staff Member: " & bparts(3) & "    Reason: " & bparts(5) & Admin_Control_Panel.RichTextBox1.Text
                    Else
                        Admin_Control_Panel.RichTextBox1.Text = "    Date: " & bparts(1) & "    Action: " & bparts(2) & "    Staff Member: " & bparts(3) & "    Value: " & bparts(4) & "    Reason: " & bparts(5) & Admin_Control_Panel.RichTextBox1.Text
                    End If
                Next
            End If
            If sParts(0) = "RequestACPStaffActionList" Then
                Message = Message.Replace("{NL]", Environment.NewLine)
                sParts = Split(Message, "<{]>")

                Dim aParts() As String = Split(sParts(1), "<(]>")

                For Each action As String In aParts
                    Dim bParts() As String = Split(action, "<{)>")

                    If Admin_Control_Panel.RichTextBox1.Text <> "" Then
                        Admin_Control_Panel.RichTextBox1.Text += Environment.NewLine
                    End If

                    bParts(1) = bParts(1).Substring(0, 19)

                    If bParts(5) = "" Then
                        bParts(5) = "None"
                    End If

                    If bParts(4) = "None" Then
                        Admin_Control_Panel.RichTextBox1.Text += "    Date: " & bParts(1) & "    Action: " & bParts(2) & "    Target: " & bParts(3) & "    Reason: " & bParts(5)
                    Else
                        Admin_Control_Panel.RichTextBox1.Text += "    Date: " & bParts(1) & "    Action: " & bParts(2) & "    Target: " & bParts(3) & "    Value: " & bParts(4) & "    Reason: " & bParts(5)
                    End If
                Next
            End If
            If sParts(0) = "ShowRankedHistory" Then
                Dim aParts() As String = Split(sParts(1), "<(]>")

                For Each rankedGame As String In aParts
                    Dim bParts() As String = Split(rankedGame, "<{)>")

                    If Admin_Control_Panel.RichTextBox1.Text <> "" Then
                        Admin_Control_Panel.RichTextBox1.Text += Environment.NewLine
                    End If

                    bParts(1) = bParts(1).Substring(0, 19)

                    If bParts(8) = "0" Then
                        bParts(8) = "No"
                    Else
                        bParts(8) = "Yes"
                    End If

                    If bParts(2) = "Tag" Then
                        Admin_Control_Panel.RichTextBox1.Text += "    Date: " & bParts(1) & "    Game Type: " & bParts(2) & "    Player 1: " & bParts(3) & "    Player 2: " & bParts(4) & "    Player 3: " & bParts(5) & "    Player 4: " & bParts(6) & "    Winners: " & bParts(7) & "    Flagged: " & bParts(8)
                    Else
                        Admin_Control_Panel.RichTextBox1.Text += "    Date: " & bParts(1) & "    Game Type: " & bParts(2) & "    Player 1: " & bParts(3) & "    Player 2: " & bParts(4) & "    Winner: " & bParts(7) & "    Flagged: " & bParts(8)
                    End If
                Next
            End If
            If sParts(0) = "FindAllAccounts" Then
                If newCheck = True Then
                    ipList.Clear()
                    macList.Clear()
                    uniqueidList.Clear()
                    newCheck = False
                End If

                Dim aParts() As String = Split(sParts(1), "<(]>")
                For Each account As String In aParts
                    ipList.Add(account)
                Next
                aParts = Split(sParts(2), "<(]>")
                For Each account As String In aParts
                    macList.Add(account)
                Next
                aParts = Split(sParts(3), "<(]>")
                For Each account As String In aParts
                    uniqueidList.Add(account)
                Next

                newCheck = True

                Admin_Control_Panel.Panel48.Show()
                Admin_Control_Panel.Panel48.BringToFront()

                Dim usernameList As New List(Of String)

                For Each user As String In ipList
                    Dim finalUsername As String = user & "       Same IP"
                    If macList.Contains(user) Then
                        finalUsername = finalUsername & "       Same MAC"
                    End If
                    If uniqueidList.Contains(user) Then
                        finalUsername = finalUsername & "       Same Unique ID"
                    End If

                    usernameList.Add(finalUsername)
                Next

                For Each user As String In macList
                    Dim finalUsername As String = user & "       Same MAC"
                    If uniqueidList.Contains(user) Then
                        finalUsername = finalUsername & "       Same Unique ID"
                    End If

                    If ipList.Contains(user) = False Then
                        usernameList.Add(finalUsername)
                    End If
                Next

                For Each user As String In uniqueidList
                    Dim finalUsername As String = user & "       Same Unique ID"

                    If ipList.Contains(user) = False And macList.Contains(user) = False Then
                        usernameList.Add(finalUsername)
                    End If
                Next

                For Each user As String In usernameList
                    If Admin_Control_Panel.RichTextBox3.Text <> "" Then
                        Admin_Control_Panel.RichTextBox3.Text = Environment.NewLine & Admin_Control_Panel.RichTextBox3.Text
                    End If

                    Admin_Control_Panel.RichTextBox3.Text = "Username: " & user & Admin_Control_Panel.RichTextBox3.Text
                Next

                Admin_Control_Panel.Panel64.Hide()
            End If
            If sParts(0) = "FindAllAccountsFull" Then
                If newCheck = True Then
                    ipList.Clear()
                    macList.Clear()
                    uniqueidList.Clear()
                    newCheck = False
                End If

                Dim aParts() As String = Split(sParts(2), "<(]>")
                For Each account As String In aParts
                    If sParts(1) = "IP" Then
                        ipList.Add(account)
                    ElseIf sParts(1) = "MAC" Then
                        macList.Add(account)
                    ElseIf sParts(1) = "UniqueID" Then
                        uniqueidList.Add(account)
                    End If
                Next

                newCheck = True

                Admin_Control_Panel.Panel48.Show()
                Admin_Control_Panel.Panel48.BringToFront()

                Dim usernameList As New List(Of String)

                For Each user As String In ipList
                    Dim finalUsername As String = user & "       Same IP"
                    If macList.Contains(user) Then
                        finalUsername = finalUsername & "       Same MAC"
                    End If
                    If uniqueidList.Contains(user) Then
                        finalUsername = finalUsername & "       Same Unique ID"
                    End If

                    usernameList.Add(finalUsername)
                Next

                For Each user As String In macList
                    Dim finalUsername As String = user & "       Same MAC"
                    If uniqueidList.Contains(user) Then
                        finalUsername = finalUsername & "       Same Unique ID"
                    End If

                    If ipList.Contains(user) = False Then
                        usernameList.Add(finalUsername)
                    End If
                Next

                For Each user As String In uniqueidList
                    Dim finalUsername As String = user & "       Same Unique ID"

                    If ipList.Contains(user) = False And macList.Contains(user) = False Then
                        usernameList.Add(finalUsername)
                    End If
                Next

                For Each user As String In usernameList
                    If Admin_Control_Panel.RichTextBox3.Text <> "" Then
                        Admin_Control_Panel.RichTextBox3.Text = Environment.NewLine & Admin_Control_Panel.RichTextBox3.Text
                    End If

                    Admin_Control_Panel.RichTextBox3.Text = "Username: " & user & Admin_Control_Panel.RichTextBox3.Text
                Next

                Admin_Control_Panel.Panel64.Hide()
            End If
            If sParts(0) = "Error2051" Then
                If sParts(1) = Username Then
                    MsgBox("TDOANE.dll is missing or corrupted!")
                End If
            End If
            If sParts(0) = "ChallengeConfirm" Then
                Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
                objwriter.Write("#config file")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("#nickname & gamename should be less than 20 characters")
                objwriter.Write(Environment.NewLine)
                If sParts(1).Contains("001") = False And sParts(1).Contains("011") = False And sParts(1).Contains("101") = False And sParts(1).Contains("111") = False Then
                    objwriter.Write("use_d3d = " & My.Settings.UDX)
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("skin_index = " & My.Settings.US)
                Else
                    objwriter.Write("use_d3d = 0")
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("skin_index = -1")
                End If
                objwriter.Write(Environment.NewLine)
                objwriter.Write("antialias = " & My.Settings.AA)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("errorlog = 0")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("nickname = " & Username)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("gamename = Game")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("roompass = " & sParts(1))
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("textfont = fonts/simhei.ttf 14")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("numfont = fonts/arialbd.ttf")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("serverport = " & gamePort)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastip = " & IP)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastport = " & gamePort)
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
                If Mute = 0 Then
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 0)
                Else
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 1)
                End If
                objwriter.Close()

                CardSkinManager.CopyFullCardDatabase()

                Dim proc As New Process()

                ChDir(Current & "\YGOPRO")
                proc.StartInfo.FileName = ygoproExe
                proc.StartInfo.Arguments = "-j"
                proc.Start()
            End If
            If sParts(0) = "ChallengeUser" Then
                If ignoreList.Contains(sParts(1)) Then
                    Return
                End If

                Try
                    Dim MBXResult﻿ As DialogResult
                    Dim info As String = sParts(2)
                    Dim gametypex As String = "X"

                    If info(0) = "0" Then
                        gametypex = "unranked "
                        If My.Settings.DUC = True Then
                            Return
                        End If
                    ElseIf info(0) = "1" Then
                        If RankedStatus = 1 Then
                            MsgBox("You are not allowed to play ranked games!")
                            Return
                        End If

                        If beta = True Then
                            MsgBox("Ranked games are disabled during the beta!")
                            Return
                        End If

                        gametypex = "ranked "
                        If My.Settings.DRC = True Then
                            Return
                        End If
                    End If

                    If info(2) = "0" Then
                        gametypex = gametypex & "single duel, "
                    ElseIf info(2) = "1" Then
                        gametypex = gametypex & "match duel, "
                    Else
                        gametypex = gametypex & "tag duel, "
                    End If

                    If info(1) = "0" Or info(1) = "4" Or info(1) = "8" Then
                        gametypex = gametypex & "Banlist: Traditional, "
                    ElseIf info(1) = "1" Or info(1) = "5" Or info(1) = "9" Then
                        gametypex = gametypex & "Banlist: OCG, "
                    ElseIf info(1) = "2" Or info(1) = "6" Or info(1) = "A" Then
                        gametypex = gametypex & "Banlist: TCG, "
                    Else
                        gametypex = gametypex & "Banlist: No Banlist, "
                    End If

                    If info(1) = "0" Or info(1) = "1" Or info(1) = "2" Or info(1) = "3" Then
                        gametypex = gametypex & "Allowed Cards = TCG/OCG"
                    ElseIf info(1) = "4" Or info(1) = "5" Or info(1) = "6" Or info(1) = "7" Then
                        gametypex = gametypex & "Allowed Cards = TCG"
                    Else
                        gametypex = gametypex & "Allowed Cards = OCG"
                    End If

                    If info(3) = "1" Then
                        gametypex = gametypex & ", Master Rule 1 (Original)"
                    ElseIf info(3) = "2" Then
                        gametypex = gametypex & ", Master Rule 2 (Synchro / XYZ)"
                    ElseIf info(3) = "3" Then
                        gametypex = gametypex & ", Master Rule 3 (Pendulum)"
                    ElseIf info(3) = "4" Then
                        gametypex = gametypex & ", Master Rule 4 (Links)"
                    End If

                    If gametypex <> "X" Then
                        MBXResult﻿ = MessageBox.Show(sParts(1) & " has challenged you to an " & gametypex & "!", "Duel Challenge", MessageBoxButtons.YesNo)
                    End If

                    If MBXResult﻿ = MsgBoxResult.Yes Then
                        streamw.WriteLine("ChallengeConfirm" & "<{]>" & sParts(1) & "<{]>" & sParts(2))
                        streamw.Flush()
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "ChallengeUserTournament" Then
                Try
                    Dim MBXResult﻿ As DialogResult
                    MBXResult﻿ = MessageBox.Show(sParts(1) & " has challenged you to a " & sParts(3) & " duel!", "Duel Challenge", MessageBoxButtons.YesNo)

                    If MBXResult﻿ = MsgBoxResult.Yes Then
                        streamw.WriteLine("ChallengeConfirm" & "<{]>" & sParts(1) & "<{]>" & sParts(2))
                        streamw.Flush()
                    End If
                Catch
                End Try
            End If
            If sParts(0) = "J.A.R.V.I.S." Then
                Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
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
                objwriter.Write("nickname = " & Username)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("gamename = Game")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("roompass = " & sParts(1))
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("textfont = fonts/simhei.ttf 14")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("numfont = fonts/arialbd.ttf")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("serverport = " & gamePort)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastip = " & IP)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastport = " & gamePort)
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
                If Mute = 0 Then
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 0)
                Else
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 1)
                End If
                objwriter.Close()

                JarvisTimer.Start()
            End If
            If sParts(0) = "NotEnoughGold" Then
                MsgBox("You don't have enough gold to buy that item!")
            End If
            If sParts(0) = "NotEnoughDiamonds" Then
                MsgBox("You don't have enough diamonds to buy that item!")
            End If
            If sParts(0) = "SendNotEnoughDiamonds" Then
                MsgBox("You don't have enough diamonds!")
            End If
            If sParts(0) = "DiamondsSent" Then
                MsgBox("Diamonds sent!")
            End If
            If sParts(0) = "DiamondsRecieved" Then
                MsgBox("You recieved " & sParts(1) & " Diamonds from: " & sParts(2))
            End If
            If sParts(0) = "Redeem" Then
                MsgBox("Code Used, you gained: " & sParts(1) & " Gold and " & sParts(2) & " Diamonds!")
            End If
            If sParts(0) = "CodeFailure" Then
                MsgBox("This code doesn't exist!")
            End If
            If sParts(0) = "BorderOwned" Then
                MsgBox("You already own this border!")
            End If
            If sParts(0) = "BorderPurchased" Then
                MsgBox("Border Purchased!")
            End If
            If sParts(0) = "DiamondsConverted" Then
                MsgBox("Your diamonds have been converted into gold!")
            End If
            If sParts(0) = "Code" Then
                MsgBox("Congratulations on your new code that allows you to duel Seto Kaiba!")
                MsgBox("Write your code down and send it to Seto Kaiba when you see him online in order to duel him!")
                MsgBox("Your Code: " & sParts(1))
                MsgBox("If you lose your code create a ticket and we will find it for you!")
                My.Settings.MyLastCode = sParts(1)
                My.Settings.Save()
            End If
            If sParts(0) = "Relog" Then
                MsgBox("Game will now restart, please relog!")
                End
            End If
            If sParts(0) = "Code0" Then
                MsgBox("Code doesn't exist!")
            End If
            If sParts(0) = "Code1" Then
                MsgBox("Code use Successful! Begin the duel!")
            End If
            If sParts(0) = "UpdateQualification" Then
                If sParts(1) = Username Then
                    MsgBox("You have been qualified! Game will now exit, please relog!")
                    End
                End If
            End If
            If sParts(0) = "JD1" Then
                JD1 = 1
                MsgBox("Open the J.A.R.V.I.S. request duel panel, you should now be able to see new decks!")
            End If
            If sParts(0) = "LL" Then
                LunarLantern = 1
                LoadOwnedItems()
                MsgBox("You are now a Starcaller!")
            End If
            If sParts(0) = "Firelord" Then
                HeartOfFire = 1
                LoadOwnedItems()
                MsgBox("You are now a Firelord!")
            End If
            If sParts(0) = "Stormborn" Then
                Stormborn = 1
                LoadOwnedItems()
                MsgBox("You are now a Stormborn!")
            End If
            If sParts(0) = "Rexterra" Then
                Rexterra = 1
                LoadOwnedItems()
                MsgBox("Rexterra has been purchased!")
            End If
            If sParts(0) = "Tidemaster" Then
                Tidemaster = 1
                LoadOwnedItems()
                MsgBox("You are now a Tidemaster!")
            End If
            If sParts(0) = "TournamentHostingItem" Then
                TournamentHosting = 1
                LoadOwnedItems()
                MsgBox("Tournament Hosting Item has been purchased!")
            End If
            If sParts(0) = "ExtraMemberItem" Then
                extraMemberItem += 1
                MsgBox("Team Members Bonus Purchased!")
            End If
            If sParts(0) = "Team Quote" Then
                teamQuote += 1
                LoadOwnedItems()
            End If
            If sParts(0) = "GoldSarcophagus" Then
                GoldSarcophagus = 1
                LoadOwnedItems()
                MsgBox("You now own the Gold Sarcophagus!")
            End If
            If sParts(0) = "BoldFontStyle" Then
                boldItem = 1
                UseItems()
                LoadOwnedItems()
                MsgBox("Bold Font Style Purchased!")
            End If
            If sParts(0) = "ItalicFontStyle" Then
                italicItem = 1
                UseItems()
                LoadOwnedItems()
                MsgBox("Italic   Font Style Purchased!")
            End If
            If sParts(0) = "UnderlineFontStyle" Then
                underlineItem = 1
                UseItems()
                LoadOwnedItems()
                MsgBox("Underline Font Style Purchased!")
            End If
            If sParts(0) = "StrikeoutFontStyle" Then
                strikeoutItem = 1
                UseItems()
                LoadOwnedItems()
                MsgBox("Strikeout Font Style Purchased!")
            End If
            If sParts(0) = "ChatFontBundle" Then
                boldItem = 1
                italicItem = 1
                underlineItem = 1
                UseItems()
                LoadOwnedItems()
                MsgBox("Chat Font Bundle Purchased!")
            End If
            If sParts(0) = "EmoticonPackOne" Then
                emoticonPackOne = 1
                LoadOwnedItems()
                MsgBox("Emoticon Pack One Purchased!")
            End If
            If sParts(0) = "EmoticonPackTwo" Then
                emoticonPackTwo = 1
                LoadOwnedItems()
                MsgBox("Emoticon Pack Two Purchased")
            End If
            If sParts(0) = "CustomTextFont" Then
                fontItem = 1
                UseItems()
                LoadOwnedItems()
                MsgBox("Custom Text Font Purchased!")
            End If
            If sParts(0) = "CustomTitle" Then
                customTitle = 1
                LoadOwnedItems()
                MsgBox("Custom Title Purchased!")
            End If
            If sParts(0) = "CardSkinOwned" Then
                MsgBox("You already own that card skin!")
            End If
            If sParts(0) = "CardSkinPurchased" Then
                ownedCardSkins.Add(sParts(1))
                CardSkinManager.DeleteCardSkins(ownedCardSkins)
                MsgBox("Card Skin Purchased!")
            End If
            If sParts(0) = "PurchasedBlueChatColor" Then
                BlueChatColor = 1
                LoadOwnedItems()
                MsgBox("Blue chat color purchased!")
            End If
            If sParts(0) = "PurchasedGreenChatColor" Then
                GreenChatColor = 1
                LoadOwnedItems()
                MsgBox("Green chat color purchased!")
            End If
            If sParts(0) = "PurchasedRedChatColor" Then
                RedChatColor = 1
                LoadOwnedItems()
                MsgBox("Red chat color purchased!")
            End If
            If sParts(0) = "PurchasedPinkChatColor" Then
                PinkChatColor = 1
                LoadOwnedItems()
                MsgBox("Pink chat color purchased!")
            End If
            If sParts(0) = "PurchasedFBIChatColor" Then
                FBIChatColor = 1
                LoadOwnedItems()
                MsgBox("FBI chat color purchased!")
            End If
            If sParts(0) = "PurchasedRainbowChatColor" Then
                RainbowChatColor = 1
                LoadOwnedItems()
                MsgBox("Rainbow chat color purchased!")
            End If
            If sParts(0) = "Classified" Then
                classifiedRank = 1
                LoadOwnedItems()
                MsgBox("Access to classified channels granted!")
            End If
            If sParts(0) = "WPR" Then
                WP = sParts(1)
                MsgBox("Your warning points have been reset!")
            End If
            If sParts(0) = "ME1" Then
                MeItem = 1
                LoadOwnedItems()
                MsgBox("You have successfully purchased the ME command, type in '/me does something' to test!")
            End If
            If sParts(0) = "BS1" Then
                ForumBooster = 1
                MsgBox("You have successfully purchased the forum booster!")
            End If
            If sParts(0) = "FB1" Then
                ForumTurboCharger = 1
                MsgBox("You have successfully purchased the forum turbo charger!")
            End If
            If sParts(0) = "ChangeUsername.Error" Then
                MsgBox("Username already exists or is too long, all usernames must be less then 19 characters!")
                If NewUsernameN = 1 Then
                    Dim NewUsername = InputBox("New Username:")
                    streamw.WriteLine("ChangeUsername<{]>" & NewUsername)
                    streamw.Flush()
                End If
            End If
            If sParts(0) = "ChangeUsername" Then
                If Username = sParts(1) Then
                    MsgBox("You username has been changed, game will now exit, please relog!")
                    MsgBox("Use your new username when logging in!")
                    End
                End If
            End If
            If sParts(0) = "TournamentChallenge" Then
                If My.Settings.DTC = 0 Then
                    If Username = sParts(2) Then
                        Dim MBXResult﻿ As DialogResult = MessageBox.Show("You have been challenged to a tournament duel!", "Tournament Duel", MessageBoxButtons.YesNo)
                        If MBXResult﻿ = MsgBoxResult.Yes Then
                            streamw.WriteLine("TMChallengeConfirm" & "<{]>" & Username & "<{]>" & sParts(1))
                            streamw.Flush()
                            MsgBox("You have accepted the challenge from: " & sParts(1))
                        End If
                    End If
                End If
            End If
            If sParts(0) = "TMChallengeConfirm" Then
                If sParts(2) = Username Then
                    PublicTxt.AppendText(Environment.NewLine)
                    PublicTxt.Select(PublicTxt.TextLength, 0)
                    PublicTxt.SelectionColor = My.Settings.System
                    PublicTxt.AppendText(sParts(1) & " has accepted your tournament challenge, please host the game and invite a staff member to watch!")
                    PublicTxt.SelectionStart = PublicTxt.TextLength
                    PublicTxt.SelectionLength = 0
                    PublicTxt.ScrollToCaret()
                End If
            End If

            If sParts(0) = "GetInfo" Then
                If sParts(1) = Username Then
                    If Rank = "Owner" Then
                        MsgBox("Information for user: " & sParts(2) & ", IP: " & sParts(3) & ", MAC: " & sParts(4) & ", Ban Code: " & sParts(5))
                    Else
                        MsgBox("Information for user: " & sParts(2) & ", IP: " & sParts(3) & ", MAC: " & sParts(4))
                    End If
                End If
            End If
            If sParts(0) = "GoldAdded" Then
                Try
                    teamPage.Gold.Text = "Gold: " & sParts(1)
                Catch
                End Try
            End If
            If sParts(0) = "GoldNotAdded" Then
                MsgBox("Not enough gold!")
            End If
            If sParts(0) = "UpdateTeamRank" Then
                If sParts(1) = 0 Then
                    TeamColeader = False
                    MsgBox("You are no longer a team Co-Leader!")
                ElseIf sParts(1) = 1 Then
                    TeamColeader = True
                    MsgBox("You have been promoted to a team Co-Leader!")
                End If
            End If
            If sParts(0) = "TeamInvConfirm" Then
                If sParts(1) = MyTeam Then
                    ListBox4.Items.Add(sParts(2))
                End If
            End If
            If sParts(0) = "ReturnAnnouncement" Then
                PublicTxt.AppendText(Environment.NewLine)
                PublicTxt.Select(PublicTxt.TextLength, 0)
                PublicTxt.SelectionColor = My.Settings.System
                PublicTxt.AppendText("ID: " & sParts(1) & ", ANNOUNCEMENT: " & sParts(2))
                PublicTxt.SelectionStart = PublicTxt.TextLength
                PublicTxt.SelectionLength = 0
                PublicTxt.ScrollToCaret()
            End If
            If sParts(0) = "EmailInUse" Then
                MsgBox("This email is already registered!")
            End If
            If sParts(0) = "ConfirmationEmailSent" Then
                MsgBox("The verification code has been sent to the email provided!")
                MsgBox("Enter the verification code in Profile under Settings!")
            End If
            If sParts(0) = "CodeAccepted" Then
                MsgBox("Your email has been verified!")
                EditProfile.Label16.Hide()
                EditProfile.Button5.Hide()
                EditProfile.Button6.Hide()
                EditProfile.VerificationCode.Hide()
                EditProfile.Panel14.Hide()
                EditProfile.Panel43.Hide()
                EditProfile.Panel44.Hide()
                EditProfile.Panel45.Hide()
            End If
            If sParts(0) = "WrongCode" Then
                MsgBox("You have entered an invalid verification code!")
            End If
            If sParts(0) = "ServerMessage" Then
                MsgBox(sParts(1))
            End If
            If sParts(0) = "DeckUploaded" Then
                CommunityCenter.NewSearch()
                CommunityCenter.newUploadDeckControl.Dispose()
            End If
            If sParts(0) = "UserNotExist" Then
                MsgBox("User: " & sParts(1) & " doesn't exist!")
            End If
            If sParts(0) = "InvalidDeckUpload" Then
                MsgBox("This deck has already been uploaded!")
            End If
            If sParts(0) = "UploadingTooFast" Then
                MsgBox("Please wait 60 seconds before uploading a new deck!")
            End If
            If sParts(0) = "AddDeck" Then
                CommunityCenter.AddDeck(sParts(1), sParts(2), sParts(3), sParts(4), sParts(5), sParts(6), sParts(7), sParts(8), sParts(9), sParts(10), sParts(11), sParts(12))
            End If
            If sParts(0) = "AddAllDecks" Then
                If sParts(1) = 0 Then
                    CommunityCenter.NotFound.Text = "No Decks Found!"
                    CommunityCenter.NotFound.Visible = True
                End If

                Dim pages As Integer = 0
                While sParts(1) > (pages * 15)
                    pages += 1
                End While

                CommunityCenter.CreatePages(sParts(1), pages)

                Dim aParts() As String = Split(sParts(2), "<(}>")
                For Each deck As String In aParts
                    Dim bParts() As String = Split(deck, "<(]>")
                    CommunityCenter.AddDeck(bParts(0), bParts(1), bParts(2), bParts(3), bParts(4), bParts(5), bParts(6), bParts(7), bParts(8), bParts(9), bParts(10), bParts(11))
                Next

                Dim cParts() As String = Split(sParts(3), "<(}>")
                For Each deckRating As String In cParts
                    For Each deck As DeckProfileUC In CommunityCenter.DeckProfileList
                        If deck.id = deckRating Then
                            deck.ratedByMe = False
                        End If
                    Next
                Next
            End If
            If sParts(0) = "DownloadDeck" Then
                Dim newDownload As New DownloadDeckReplay
                newDownload.type = "Deck"
                newDownload.deckName = sParts(1)
                newDownload.mainDeck = sParts(2)
                newDownload.extraDeck = sParts(3)
                newDownload.sideDeck = sParts(4)
                newDownload.createdBy = sParts(5)
                newDownload.LoadForm()
                newDownload.Show()
            End If
            If sParts(0) = "InvalidDeck" Then
                MsgBox("Deck has been erased or is no longer available!")
            End If
            If sParts(0) = "PostDuelMessage" Then
                If My.Settings.ShowPostDuelMessages = 0 Then
                    Return
                End If

                Dim rn As New Random
                If sParts(3).Contains("Win") Then
                    PostDuelMessage.Text = "You Win!!"

                    PostDuelMessage.gold.Location = New Point(104, 193)
                    PostDuelMessage.xp.Location = New Point(216, 193)
                    PostDuelMessage.image.Location = New Point(18, 137)
                    PostDuelMessage.newRating.Location = New Point(66, 145)
                    PostDuelMessage.unrankedDuel.Location = New Point(78, 133)

                    Dim result As Integer = rn.Next(0, 10)
                    If result < 3 Then
                        PostDuelMessage.BackgroundImage = My.Resources.postDuelWin0
                    ElseIf result >= 3 And result < 6 Then
                        PostDuelMessage.BackgroundImage = My.Resources.postDuelWin1
                    Else
                        PostDuelMessage.BackgroundImage = My.Resources.postDuelWin2
                    End If
                ElseIf sParts(3).Contains("Lost") Then
                    PostDuelMessage.Text = "You Lose!!"

                    PostDuelMessage.gold.Location = New Point(292, 193)
                    PostDuelMessage.xp.Location = New Point(405, 193)
                    PostDuelMessage.image.Location = New Point(210, 129)
                    PostDuelMessage.newRating.Location = New Point(258, 137)
                    PostDuelMessage.unrankedDuel.Location = New Point(220, 136)

                    Dim result As Integer = rn.Next(0, 10)
                    If result < 3 Then
                        PostDuelMessage.BackgroundImage = My.Resources.postDuelLose0
                    ElseIf result >= 3 And result < 6 Then
                        PostDuelMessage.BackgroundImage = My.Resources.postDuelLose1
                    Else
                        PostDuelMessage.BackgroundImage = My.Resources.postDuelLose2
                    End If
                Else
                    PostDuelMessage.Text = "You Draw!?"

                    PostDuelMessage.gold.Location = New Point(104, 193)
                    PostDuelMessage.xp.Location = New Point(216, 193)
                    PostDuelMessage.image.Location = New Point(18, 137)
                    PostDuelMessage.newRating.Location = New Point(66, 145)
                    PostDuelMessage.unrankedDuel.Location = New Point(78, 133)

                    PostDuelMessage.BackgroundImage = My.Resources.postDuelDraw
                End If

                PostDuelMessage.xp.Text = sParts(4)
                PostDuelMessage.gold.Text = sParts(4)

                If sParts.Length = 7 Then
                    PostDuelMessage.image.Visible = True
                    PostDuelMessage.newRating.Visible = True
                    PostDuelMessage.unrankedDuel.Visible = False

                    PostDuelMessage.newRating.Text = "New Rating: " & sParts(5)

                    If sParts(5) <= 1400 Then
                        PostDuelMessage.image.Image = My.Resources._1s
                    ElseIf sParts(5) <= 1550 Then
                        PostDuelMessage.image.Image = My.Resources._2s
                    ElseIf sParts(5) <= 1700 Then
                        PostDuelMessage.image.Image = My.Resources._3s
                    ElseIf sParts(5) <= 1850 Then
                        PostDuelMessage.image.Image = My.Resources._4s
                    ElseIf sParts(5) <= 2000 Then
                        PostDuelMessage.image.Image = My.Resources._5s
                    ElseIf sParts(5) <= 2150 Then
                        PostDuelMessage.image.Image = My.Resources._6s
                    Else
                        PostDuelMessage.image.Image = My.Resources._7s
                    End If
                Else
                    PostDuelMessage.image.Visible = False
                    PostDuelMessage.newRating.Visible = False
                    PostDuelMessage.unrankedDuel.Visible = True
                End If

                postDuelMessageTimer.Start()
            End If
            If sParts(0) = "PostDuelDeckMessage" Then
                Try
                    If My.Settings.ShowPostDuelDeckMessages = 0 Then
                        Return
                    End If

                    PostDuelDeckMessage.deckId = sParts(1)
                    PostDuelDeckMessage.deckName = sParts(2)
                    PostDuelDeckMessage.mainDeck = Split(sParts(3), ",")
                    PostDuelDeckMessage.extraDeck = Split(sParts(4), ",")
                    PostDuelDeckMessage.sideDeck = Split(sParts(5), ",")

                    PostDuelDeckMessage.diamondRewardLbl.Text = sParts(7)

                    PostDuelDeckMessage.Show()
                Catch
                End Try
            End If
            If sParts(0) = "Rooms" Then
                Try
                    gameList.GameListView.Items.Clear()
                    gameList.gameList.Clear()

                    refreshGameListTimer.Stop()
                    gameList.refreshGameListPanel.Visible = False

                    Dim games() As String = Split(sParts(1), ";")

                    For Each game As String In games
                        Try
                            Dim gameParts() As String = Split(game, ":")
                            Dim newGame As New Game(gameParts)
                            gameList.AddGame(newGame)
                            gameList.gameList.Add(newGame)
                        Catch
                        End Try
                    Next

                    If gameList.banlistCmBox.Text <> "All" Or gameList.duelTypeCmBox.Text <> "All" Or gameList.gameModeCmBox.Text <> "All" Or gameList.playersTxt.Text <> "" Then
                        If gameList.FilterActiveGames.Checked Then
                            gameList.gameCount.Text = "Sorted Available " & gameList.gameListType & " Games: " & gameList.GameListView.Items.Count
                        Else
                            gameList.gameCount.Text = "Sorted " & gameList.gameListType & " Games: " & gameList.GameListView.Items.Count
                        End If
                    Else
                        If gameList.FilterActiveGames.Checked Then
                            gameList.gameCount.Text = "Available " & gameList.gameListType & " Games: " & gameList.GameListView.Items.Count
                        Else
                            gameList.gameCount.Text = "All " & gameList.gameListType & " Games: " & gameList.GameListView.Items.Count
                        End If
                    End If

                    refreshGameListTimer.Start()
                Catch
                End Try
            End If
            If sParts(0) = "LoadNews" Then
                If sParts(7) = 0 Then
                    CommunityCenter.NewsControl1.Visible = True

                    CommunityCenter.NewsControl1.newsId.Text = sParts(1)
                    CommunityCenter.NewsControl1.newsTitle.Text = "Title: " & sParts(2)
                    Dim dateParts() As String = Split(sParts(3), " ")
                    CommunityCenter.NewsControl1.newsDate.Text = "Date: " & dateParts(0)
                    CommunityCenter.NewsControl1.newsPost.Text = sParts(4)
                    If sParts(5) = "Kaiba Corporation" Then
                        CommunityCenter.NewsControl1.newsPicture.Image = My.Resources.News1
                    ElseIf sParts(5) = "Gold Star" Then
                        CommunityCenter.NewsControl1.newsPicture.Image = My.Resources.News2
                    ElseIf sParts(5) = "Paper" Then
                        CommunityCenter.NewsControl1.newsPicture.Image = My.Resources.News3
                    ElseIf sParts(5) = "Platinum Stars" Then
                        CommunityCenter.NewsControl1.newsPicture.Image = My.Resources.News4
                    Else
                        CommunityCenter.NewsControl1.newsPicture.Image = My.Resources.News5
                    End If

                    CommunityCenter.NewsControl1.readMoreLink = sParts(6)

                    If sParts(6) <> "" Then
                        CommunityCenter.NewsControl1.newsReadMore.Visible = True
                    Else
                        CommunityCenter.NewsControl1.newsReadMore.Visible = False
                    End If

                    If Rank = "Owner" Or Rank = "Administrator" Or Rank = "Global Moderator" Or Rank = "Event Manager" Or Rank = "Curator" Then
                        CommunityCenter.NewsControl1.newsDelete.Visible = True
                    End If
                Else
                    CommunityCenter.NewsControl2.Visible = True

                    CommunityCenter.NewsControl2.newsId.Text = sParts(1)
                    CommunityCenter.NewsControl2.newsTitle.Text = "Title: " & sParts(2)
                    Dim dateParts() As String = Split(sParts(3), " ")
                    CommunityCenter.NewsControl2.newsDate.Text = "Date: " & dateParts(0)
                    CommunityCenter.NewsControl2.newsPost.Text = sParts(4)
                    If sParts(5) = "Kaiba Corporation" Then
                        CommunityCenter.NewsControl2.newsPicture.Image = My.Resources.News1
                    ElseIf sParts(5) = "Gold Star" Then
                        CommunityCenter.NewsControl2.newsPicture.Image = My.Resources.News2
                    ElseIf sParts(5) = "Paper" Then
                        CommunityCenter.NewsControl2.newsPicture.Image = My.Resources.News3
                    ElseIf sParts(5) = "Platinum Stars" Then
                        CommunityCenter.NewsControl2.newsPicture.Image = My.Resources.News4
                    Else
                        CommunityCenter.NewsControl2.newsPicture.Image = My.Resources.News5
                    End If

                    CommunityCenter.NewsControl2.readMoreLink = sParts(6)

                    If sParts(6) <> "" Then
                        CommunityCenter.NewsControl2.newsReadMore.Visible = True
                    Else
                        CommunityCenter.NewsControl2.newsReadMore.Visible = False
                    End If

                    If Rank = "Owner" Or Rank = "Administrator" Or Rank = "Global Moderator" Or Rank = "Event Manager" Or Rank = "Curator" Then
                        CommunityCenter.NewsControl2.newsDelete.Visible = True
                    End If
                End If
            End If
            If sParts(0) = "TotalNews" Then
                If sParts(1) > 2 Then
                    CommunityCenter.newsButtonRight.Visible = True
                    CommunityCenter.NewsPageCount.Text = "Page: " & CommunityCenter.newsPage & "/" & Math.Ceiling(sParts(1) / 2)
                    If CommunityCenter.newsPage < (sParts(1) / 2) Then
                        CommunityCenter.newsButtonRight.Enabled = True
                    Else
                        CommunityCenter.newsButtonRight.Enabled = False
                    End If
                    CommunityCenter.NewsPageButtonLocation()
                    CommunityCenter.NewsPageCount.Visible = True
                    If CommunityCenter.newsPage <> 1 Then
                        CommunityCenter.newsButtonLeft.Enabled = True
                        CommunityCenter.newsButtonLeft.Visible = True
                    Else
                        CommunityCenter.newsButtonLeft.Enabled = False
                        CommunityCenter.newsButtonLeft.Visible = False
                    End If
                End If
            End If
            If sParts(0) = "AddIgnored" Then
                If sParts(1) = "" Then
                    Return
                End If

                ignoreList.Add(sParts(1))
            End If
            If sParts(0) = "AddIgnoredAll" Then
                If sParts(1) = "" Then
                    Return
                End If

                Dim aParts() As String = Split(sParts(1), "<(]>")
                For Each user As String In aParts
                    ignoreList.Add(user)
                Next
            End If
            If sParts(0) = "FeaturedPlayer" Then
                Try
                    CommunityCenter.featuredPlayer.Text = "Featured Player: " & sParts(1)
                    CommunityCenter.featuredSingle.Text = "Single: " & sParts(2)
                    CommunityCenter.featuredMatch.Text = "Match: " & sParts(3)
                    CommunityCenter.featuredTag.Text = "Tag: " & sParts(4)
                    CommunityCenter.featuredTeam.Text = "Team: " & sParts(5)
                    CommunityCenter.LoadFeaturedImage(sParts(6))
                    CommunityCenter.featuredDescription.Text = sParts(7)

                    Dim updatelevel As Integer = 1
                    While (updatelevel * 500) < sParts(8)
                        sParts(8) = sParts(8) - (updatelevel * 500)
                        updatelevel = updatelevel + 1
                    End While
                    CommunityCenter.featuredLevel.Text = "Level: " & updatelevel

                    CommunityCenter.hidePlayerInformation.Visible = False
                Catch
                End Try
            End If
            If sParts(0) = "SetChatMessages" Then
                chatMessage1 = sParts(1)
                chatMessage2 = sParts(2)

                serverMessage1.Text = chatMessage1
                serverMessage2.Text = chatMessage2
            End If
            If sParts(0) = "SearchStarted" Then
                inQueue = True
                gameList.rankedQueue.Hide()
                gameList.hidePanel.Show()
                RankedQueue.Visible = True
                RankedQueue.BringToFront()
                rankedQueueTime = 0
                rankedQueueTimer.Start()
                rankedTime.Text = "Time: 0"
            End If
            If sParts(0) = "UnableToJoinQueue" Then
                MsgBox("Unable to join the ranked queue, you are already in queue!")
            End If
            If sParts(0) = "RankedOpponentFound" Then
                AcceptQueue.Label2.Text = 10
                AcceptQueue.Panel1.Hide()
                AcceptQueue.Label3.Text = "Waiting for opponent!"
                AcceptQueue.accepted = False
                AcceptQueue.Show()
                AcceptQueue.AcceptTimer.Start()
            End If
            If sParts(0) = "OpponentDeclinedQueue" Then
                AcceptQueue.Label3.Text = "Opponent Declined Queue"
                AcceptQueue.Panel1.Show()
                AcceptQueue.AcceptTimer.Stop()
                AcceptQueue.CloseTimer.Start()
            End If
            If sParts(0) = "RankedGameInfo" Then
                AcceptQueue.AcceptTimer.Stop()
                AcceptQueue.CloseTimer.Start()
                AcceptQueue.Hide()
                rankedQueueTimer.Stop()
                RankedQueue.SendToBack()
                inQueue = False

                StartGame(sParts(1))
            End If
            If sParts(0) = "RankingList" Then
                CommunityCenter.rankedList.Items.Clear()
                Dim rank As Integer = 1
                Dim xParts() As String = Split(sParts(1), "<(]>")
                For Each user As String In xParts
                    Try
                        Dim userInfo() As String = Split(user, "<{)>")
                        Dim winRatio As Double = Math.Round((Convert.ToDouble(userInfo(1)) / (Convert.ToDouble(userInfo(1)) + Convert.ToDouble(userInfo(2)) + Convert.ToDouble(userInfo(3))) * 100), 2)

                        Dim newUser As ListViewItem
                        newUser = CommunityCenter.rankedList.Items.Add(rank)
                        newUser.SubItems.Add(userInfo(0))
                        newUser.SubItems.Add(userInfo(1))
                        newUser.SubItems.Add(userInfo(2))
                        newUser.SubItems.Add(userInfo(3))
                        newUser.SubItems.Add(userInfo(4))
                        newUser.SubItems.Add(winRatio & "%")

                        rank += 1
                    Catch
                    End Try
                Next
            End If
            If sParts(0) = "CampaignChallenge" Then
                Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
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
                objwriter.Write("nickname = " & Username)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("gamename = Game")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("roompass = " & "030" & sParts(1))
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("textfont = fonts/simhei.ttf 14")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("numfont = fonts/arialbd.ttf")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("serverport = " & gamePort)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastip = " & IP)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastport = " & gamePort)
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
                If Mute = 0 Then
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 0)
                Else
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 1)
                End If
                objwriter.Close()

                JarvisTimer.Start()
            End If
            If sParts(0) = "StartBotDuel" Then
                Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
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
                objwriter.Write("nickname = " & Username)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("gamename = Game")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("roompass = " & "0")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("textfont = fonts/simhei.ttf 14")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("numfont = fonts/arialbd.ttf")
                objwriter.Write(Environment.NewLine)
                objwriter.Write("serverport = " & sParts(1))
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastip = " & IP)
                objwriter.Write(Environment.NewLine)
                objwriter.Write("lastport = " & sParts(1))
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
                objwriter.Write("bot_duel = 1")
                If Mute = 0 Then
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 0)
                Else
                    objwriter.Write(Environment.NewLine)
                    objwriter.Write("mute_chat = " & 1)
                End If
                objwriter.Close()

                JarvisTimer.Start()
            End If
            If sParts(0) = "Avatar" Then
                AvatarItem = 1
                LoadOwnedItems()
                MsgBox("Avatar Item Purchased!")
            End If
            If sParts(0) = "CardBack" Then
                CardBackItem = 1
                LoadOwnedItems()
                MsgBox("Card Back Item Purchased!")
            End If
            If sParts(0) = "Nightshade" Then
                Nightshade = 1
                LoadOwnedItems()
                MsgBox("Nightshade Purchased!")
            End If
            If sParts(0) = "LordOfLight" Then
                LordOfLight = 1
                LoadOwnedItems()
                MsgBox("Lord of Light Purchased!")
            End If
            If sParts(0) = "CustomUsernameColor" Then
                CustomUsernameColor = 1
                LoadOwnedItems()
                MsgBox("Custom Username Color Purchased!")
            End If
            If sParts(0) = "MysteryBox" Then
                If sParts(1) = "LL" Then
                    LunarLantern = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_Starcaller
                ElseIf sParts(1) = "HoF" Then
                    HeartOfFire = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_Firelord
                ElseIf sParts(1) = "Stormborn" Then
                    Stormborn = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_Stormborn
                ElseIf sParts(1) = "Rexterra" Then
                    Rexterra = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_Rexterra
                ElseIf sParts(1) = "Tidemaster" Then
                    Tidemaster = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_Tidemaster
                ElseIf sParts(1) = "gs" Then
                    GoldSarcophagus = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_GoldSarcophagus
                ElseIf sParts(1) = "CustomTitle" Then
                    customTitle = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_CustomTitle
                ElseIf sParts(1) = "Classified" Then
                    classifiedRank = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_ClassifiedAccess
                ElseIf sParts(1) = "Ime" Then
                    MeItem = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_MeCommand
                ElseIf sParts(1) = "ItalicItem" Then
                    italicItem = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_ItalicChatFont
                ElseIf sParts(1) = "BoldItem" Then
                    boldItem = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_BoldChatFont
                ElseIf sParts(1) = "UnderlineItem" Then
                    underlineItem = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_UnderlineChatFont
                ElseIf sParts(1) = "CustomTextFont" Then
                    fontItem = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_CustomFont
                ElseIf sParts(1) = "BlueChatColor" Then
                    BlueChatColor = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_BlueChatColor
                ElseIf sParts(1) = "GreenChatColor" Then
                    GreenChatColor = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_GreenChatColor
                ElseIf sParts(1) = "PinkChatColor" Then
                    PinkChatColor = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_PinkChatColor
                ElseIf sParts(1) = "RedChatColor" Then
                    RedChatColor = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_RedChatColor
                ElseIf sParts(1) = "RainbowChatColor" Then
                    RainbowChatColor = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_RainbowChatColor
                ElseIf sParts(1) = "FBIChatColor" Then
                    FBIChatColor = 1
                    MysteryBoxItems.item1.Image = My.Resources.Item_FBIChatColor
                ElseIf sParts(1) = "DuelSetoKaiba" Then
                    MysteryBoxItems.item1.Image = My.Resources.Item_DuelSetoKaiba
                Else
                    MysteryBoxItems.item1.Image = My.Resources.Blank_Item
                End If

                If sParts(2) = "LL" Then
                    LunarLantern = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_Starcaller
                ElseIf sParts(2) = "HoF" Then
                    HeartOfFire = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_Firelord
                ElseIf sParts(2) = "Stormborn" Then
                    Stormborn = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_Stormborn
                ElseIf sParts(2) = "Rexterra" Then
                    Rexterra = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_Rexterra
                ElseIf sParts(2) = "Tidemaster" Then
                    Tidemaster = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_Tidemaster
                ElseIf sParts(2) = "gs" Then
                    GoldSarcophagus = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_GoldSarcophagus
                ElseIf sParts(2) = "CustomTitle" Then
                    customTitle = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_CustomTitle
                ElseIf sParts(2) = "Classified" Then
                    classifiedRank = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_ClassifiedAccess
                ElseIf sParts(2) = "Ime" Then
                    MeItem = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_MeCommand
                ElseIf sParts(2) = "ItalicItem" Then
                    italicItem = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_ItalicChatFont
                ElseIf sParts(2) = "BoldItem" Then
                    boldItem = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_BoldChatFont
                ElseIf sParts(2) = "UnderlineItem" Then
                    underlineItem = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_UnderlineChatFont
                ElseIf sParts(2) = "CustomTextFont" Then
                    fontItem = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_CustomFont
                ElseIf sParts(2) = "BlueChatColor" Then
                    BlueChatColor = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_BlueChatColor
                ElseIf sParts(2) = "GreenChatColor" Then
                    GreenChatColor = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_GreenChatColor
                ElseIf sParts(2) = "PinkChatColor" Then
                    PinkChatColor = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_PinkChatColor
                ElseIf sParts(2) = "RedChatColor" Then
                    RedChatColor = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_RedChatColor
                ElseIf sParts(2) = "RainbowChatColor" Then
                    RainbowChatColor = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_RainbowChatColor
                ElseIf sParts(2) = "FBIChatColor" Then
                    FBIChatColor = 1
                    MysteryBoxItems.item2.Image = My.Resources.Item_FBIChatColor
                ElseIf sParts(2) = "DuelSetoKaiba" Then
                    MysteryBoxItems.item2.Image = My.Resources.Item_DuelSetoKaiba
                Else
                    MysteryBoxItems.item2.Image = My.Resources.Blank_Item
                End If

                Dim cardSkins() As String = Split(sParts(3), ",")

                Try
                    MysteryBoxItems.card1.Image = Image.FromFile(Current & "\YGOPRO\pics\" & cardSkins(0) & ".jpg")
                    ownedCardSkins.Add(cardSkins(0))
                Catch
                    MysteryBoxItems.card1.Image = Image.FromFile(Current & "\YGOPRO\textures\cover.jpg")
                End Try

                Try
                    MysteryBoxItems.card2.Image = Image.FromFile(Current & "\YGOPRO\pics\" & cardSkins(1) & ".jpg")
                    ownedCardSkins.Add(cardSkins(1))
                Catch
                    MysteryBoxItems.card2.Image = Image.FromFile(Current & "\YGOPRO\textures\cover.jpg")
                End Try

                Try
                    MysteryBoxItems.card3.Image = Image.FromFile(Current & "\YGOPRO\pics\" & cardSkins(2) & ".jpg")
                    ownedCardSkins.Add(cardSkins(2))
                Catch
                    MysteryBoxItems.card3.Image = Image.FromFile(Current & "\YGOPRO\textures\cover.jpg")
                End Try

                Try
                    MysteryBoxItems.card4.Image = Image.FromFile(Current & "\YGOPRO\pics\" & cardSkins(3) & ".jpg")
                    ownedCardSkins.Add(cardSkins(3))
                Catch
                    MysteryBoxItems.card4.Image = Image.FromFile(Current & "\YGOPRO\textures\cover.jpg")
                End Try

                Try
                    MysteryBoxItems.card5.Image = Image.FromFile(Current & "\YGOPRO\pics\" & cardSkins(4) & ".jpg")
                    ownedCardSkins.Add(cardSkins(4))
                Catch
                    MysteryBoxItems.card5.Image = Image.FromFile(Current & "\YGOPRO\textures\cover.jpg")
                End Try

                MysteryBoxItems.gold.Text = "Gold: " & sParts(4)

                CardSkinManager.DeleteCardSkins(ownedCardSkins)
                LoadOwnedItems()
                MysteryBoxItems.Show()
            End If
            If sParts(0) = "UnblockRanked" Then
                RankedStatus = 0
                MsgBox("You are now able to play ranked duels!")
                LoadOwnedItems()
            End If
            If sParts(0) = "CustomPrivateChat" Then
                customPrivateChat = 1
                LoadOwnedItems()
                MsgBox("Custom private chat has been unlocked!")
            End If
            If sParts(0) = "CustomTextColor" Then
                customTextColor = 1
                LoadOwnedItems()
                MsgBox("Custom text color has been unlocked!")
            End If
            If sParts(0) = "AdBlock" Then
                AdBlock = 1
                LoadOwnedItems()
                MsgBox("AdBlock Purchased!")
                MsgBox("Restart the launcher to activate AdBlock!")
            End If
            If sParts(0) = "CustomBorder" Then
                CustomBorder = 1
                LoadOwnedItems()
                MsgBox("Custom Border Purchased!")
                MsgBox("Please create and email your custom border along with your username to: setokaibakc@live.com, your border will become available in the next update!")
            End If
            If sParts(0) = "JoinBattleCity" Then
                SendToServer("GetBattleCityList")
            End If
            If sParts(0) = "RequestTournamentList" Then
                Dim xParts() As String = Split(sParts(1), "<{)>")

                Dim lastLocationY As Integer = -105

                For Each tournament As String In xParts
                    Dim tournamentParts() As String = Split(tournament, "<(]>")

                    Dim newTournament As TournamentControl = New TournamentControl
                    newTournament.tournamentNameLbl.Text = tournamentParts(1)

                    If tournamentParts(2) = "1" Then
                        newTournament.tournamentImg.Image = My.Resources.News1
                    ElseIf tournamentParts(2) = "2" Then
                        newTournament.tournamentImg.Image = My.Resources.News2
                    ElseIf tournamentParts(2) = "3" Then
                        newTournament.tournamentImg.Image = My.Resources.News3
                    ElseIf tournamentParts(2) = "4" Then
                        newTournament.tournamentImg.Image = My.Resources.News4
                    ElseIf tournamentParts(2) = "5" Then
                        newTournament.tournamentImg.Image = My.Resources.News5
                    End If

                    newTournament.hostedByLbl.Text = tournamentParts(3)
                    newTournament.typeLbl.Text = tournamentParts(4)
                    newTournament.playersLbl.Text = tournamentParts(5)
                    newTournament.startDateLbl.Text = tournamentParts(6).Substring(0, 10)
                    newTournament.endDateLbl.Text = tournamentParts(7).Substring(0, 10)
                    newTournament.rulesLink = tournamentParts(8)
                    If tournamentParts(9) <> "0" Then
                        newTournament.crownOneImg.Visible = True
                    End If
                    If tournamentParts(10) <> "0" Then
                        newTournament.crownTwoImg.Visible = True
                    End If
                    If tournamentParts(11) <> "0" Then
                        newTournament.crownThreeImg.Visible = True
                    End If
                    If tournamentParts(12) <> "0" Then
                        newTournament.crownFourImg.Visible = True
                    End If
                    If tournamentParts(13) <> "0" Then
                        newTournament.cardSkinOneImg.Visible = True
                    End If
                    If tournamentParts(14) <> "0" Then
                        newTournament.cardSkinTwoImg.Visible = True
                    End If
                    If tournamentParts(15) <> "0" Then
                        newTournament.cardSkinThreeImg.Visible = True
                    End If
                    If tournamentParts(16) <> "0" Then
                        newTournament.cardSkinFourImg.Visible = True
                    End If
                    If tournamentParts(17) <> "0" Then
                        newTournament.goldOneImg.Visible = True
                        newTournament.goldOneLbl.Visible = True
                        newTournament.goldOneLbl.Text = tournamentParts(17)
                    End If
                    If tournamentParts(18) <> "0" Then
                        newTournament.goldTwoImg.Visible = True
                        newTournament.goldTwoLbl.Visible = True
                        newTournament.goldTwoLbl.Text = tournamentParts(18)
                    End If
                    If tournamentParts(19) <> "0" Then
                        newTournament.goldThreeImg.Visible = True
                        newTournament.goldThreeLbl.Visible = True
                        newTournament.goldThreeLbl.Text = tournamentParts(19)
                    End If
                    If tournamentParts(20) <> "0" Then
                        newTournament.goldFourImg.Visible = True
                        newTournament.goldFourLbl.Visible = True
                        newTournament.goldFourLbl.Text = tournamentParts(20)
                    End If
                    If tournamentParts(21) <> "0" Then
                        newTournament.diamondsOneImg.Visible = True
                        newTournament.diamondsOneLbl.Visible = True
                        newTournament.diamondsOneLbl.Text = tournamentParts(21)
                    End If
                    If tournamentParts(22) <> "0" Then
                        newTournament.diamondsTwoImg.Visible = True
                        newTournament.diamondsTwoLbl.Visible = True
                        newTournament.diamondsTwoLbl.Text = tournamentParts(22)
                    End If
                    If tournamentParts(23) <> "0" Then
                        newTournament.diamondsThreeImg.Visible = True
                        newTournament.diamondsThreeLbl.Visible = True
                        newTournament.diamondsThreeLbl.Text = tournamentParts(23)
                    End If
                    If tournamentParts(24) <> "0" Then
                        newTournament.diamondsFourImg.Visible = True
                        newTournament.diamondsFourLbl.Visible = True
                        newTournament.diamondsFourLbl.Text = tournamentParts(24)
                    End If

                    lastLocationY += 105
                    newTournament.Location = New Point(0, lastLocationY)
                    tournamentPage.TournamentPanel.Controls.Add(newTournament)

                    If lastLocationY + 105 > tournamentPage.TournamentPanel.Size.Height Then
                        tournamentPage.TournamentPanel.Size = New Size(896, lastLocationY + 105)
                    End If
                Next
            End If
        Catch
        End Try
    End Sub

    Public Sub AddList(ByVal InputUsername)
        Dim sParts() As String
        sParts = Split(InputUsername, "<{]>")

        If sParts(1).Contains("<FBI>") Then
            If sParts(1).Substring(5, sParts(1).Length - 5) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(5, sParts(1).Length - 5)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(5, sParts(1).Length - 5))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(5, sParts(1).Length - 5))
                    End If
                    AdminList.Add(sParts(1).Substring(5, sParts(1).Length - 5) & ":FBI")
                    If SelectedChannel = "Help Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(5, sParts(1).Length - 5))
                    End If
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(5, sParts(1).Length - 5)) Then
                            ListBox1.Items.Add(sParts(1).Substring(5, sParts(1).Length - 5))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Owner>") Then
            If sParts(1).Substring(7, sParts(1).Length - 7) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(7, sParts(1).Length - 7)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(7, sParts(1).Length - 7))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(7, sParts(1).Length - 7))
                    End If
                    AdminList.Add(sParts(1).Substring(7, sParts(1).Length - 7) & ":Owner")
                    If SelectedChannel = "Help Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(7, sParts(1).Length - 7))
                    End If
                    If SelectedChannel = "Staff Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(7, sParts(1).Length - 7))
                    End If
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(7, sParts(1).Length - 7)) Then
                            ListBox1.Items.Add(sParts(1).Substring(7, sParts(1).Length - 7))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Player>") Then
            If sParts(1).Substring(8, sParts(1).Length - 8) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(8, sParts(1).Length - 8)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(8, sParts(1).Length - 8))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(8, sParts(1).Length - 8))
                    End If
                    AdminList.Add(sParts(1).Substring(8, sParts(1).Length - 8) & ":Player")
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(8, sParts(1).Length - 8)) Then
                            ListBox1.Items.Add(sParts(1).Substring(8, sParts(1).Length - 8))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Curator>") Then
            If sParts(1).Substring(9, sParts(1).Length - 9) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(9, sParts(1).Length - 9)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(9, sParts(1).Length - 9))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(9, sParts(1).Length - 9))
                    End If
                    AdminList.Add(sParts(1).Substring(9, sParts(1).Length - 9) & ":Curator")
                    If SelectedChannel = "Help Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(9, sParts(1).Length - 9))
                    End If
                    If SelectedChannel = "Staff Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(9, sParts(1).Length - 9))
                    End If
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(9, sParts(1).Length - 9)) Then
                            ListBox1.Items.Add(sParts(1).Substring(9, sParts(1).Length - 9))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Moderator>") Then
            If sParts(1).Substring(11, sParts(1).Length - 11) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(11, sParts(1).Length - 11)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(11, sParts(1).Length - 11))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(11, sParts(1).Length - 11))
                    End If
                    AdminList.Add(sParts(1).Substring(11, sParts(1).Length - 11) & ":Moderator")
                    If SelectedChannel = "Help Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(11, sParts(1).Length - 11))
                    End If
                    If SelectedChannel = "Staff Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(11, sParts(1).Length - 11))
                    End If
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(11, sParts(1).Length - 11)) Then
                            ListBox1.Items.Add(sParts(1).Substring(11, sParts(1).Length - 11))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Gold Member>") Then
            If sParts(1).Substring(13, sParts(1).Length - 13) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(13, sParts(1).Length - 13)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(13, sParts(1).Length - 13))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(13, sParts(1).Length - 13))
                    End If
                    AdminList.Add(sParts(1).Substring(13, sParts(1).Length - 13) & ":Gold Member")
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(13, sParts(1).Length - 13)) Then
                            ListBox1.Items.Add(sParts(1).Substring(13, sParts(1).Length - 13))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Administrator>") Then
            If sParts(1).Substring(15, sParts(1).Length - 15) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(15, sParts(1).Length - 15)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    End If
                    AdminList.Add(sParts(1).Substring(15, sParts(1).Length - 15) & ":Administrator")
                    If SelectedChannel = "Help Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    End If
                    If SelectedChannel = "Staff Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    End If
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(15, sParts(1).Length - 15)) Then
                            ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Event Manager>") Then
            If sParts(1).Substring(15, sParts(1).Length - 15) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(15, sParts(1).Length - 15)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    End If
                    AdminList.Add(sParts(1).Substring(15, sParts(1).Length - 15) & ":Event Manager")
                    If SelectedChannel = "Help Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    End If
                    If SelectedChannel = "Staff Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                    End If
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(15, sParts(1).Length - 15)) Then
                            ListBox1.Items.Add(sParts(1).Substring(15, sParts(1).Length - 15))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Diamond Member>") Then
            If sParts(1).Substring(16, sParts(1).Length - 16) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(16, sParts(1).Length - 16)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(16, sParts(1).Length - 16))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(16, sParts(1).Length - 16))
                    End If
                    AdminList.Add(sParts(1).Substring(16, sParts(1).Length - 16) & ":Diamond Member")
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(16, sParts(1).Length - 16)) Then
                            ListBox1.Items.Add(sParts(1).Substring(16, sParts(1).Length - 16))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Platinum Member>") Then
            If sParts(1).Substring(17, sParts(1).Length - 17) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(17, sParts(1).Length - 17)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(17, sParts(1).Length - 17))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(17, sParts(1).Length - 17))
                    End If
                    AdminList.Add(sParts(1).Substring(17, sParts(1).Length - 17) & ":Platinum Member")
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(17, sParts(1).Length - 17)) Then
                            ListBox1.Items.Add(sParts(1).Substring(17, sParts(1).Length - 17))
                        End If
                    End If
                End If
            End If
        End If
        If sParts(1).Contains("<Global Moderator>") Then
            If sParts(1).Substring(18, sParts(1).Length - 18) <> Username Then
                If onlineuserlist.Contains(sParts(1).Substring(18, sParts(1).Length - 18)) = False Then
                    onlineuserlist.Add(sParts(1).Substring(18, sParts(1).Length - 18))
                    If SelectedChannel = "Public Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(18, sParts(1).Length - 18))
                    End If
                    AdminList.Add(sParts(1).Substring(18, sParts(1).Length - 18) & ":Global Moderator")
                    If SelectedChannel = "Help Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(18, sParts(1).Length - 18))
                    End If
                    If SelectedChannel = "Staff Channel" Then
                        ListBox1.Items.Add(sParts(1).Substring(18, sParts(1).Length - 18))
                    End If
                    If SelectedChannel = "Team Channel" Then
                        If ListBox4.Items.Contains(sParts(1).Substring(18, sParts(1).Length - 18)) Then
                            ListBox1.Items.Add(sParts(1).Substring(18, sParts(1).Length - 18))
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CreatePrivateChat(ByVal pusername As String, ByVal partnerCustomPrivateChat As String)
        If pusername <> Username Then
            Dim x As Integer = 0
            Dim y As Integer = 0
            While x <= formnumber
                If pusername = newForm(x).Text Then
                    y = 1
                End If
                x = x + 1
            End While

            If y <> 1 Then
                formnumber = formnumber + 1

                newForm.Add(New PrivateChat)

                newForm(formnumber).Text = pusername
                If partnerCustomPrivateChat = "0" Then
                    newForm(formnumber).LoadPrivateChat()
                End If
                newForm(formnumber).Show()
            End If
        End If
    End Sub

    Public Sub CreatePrivateChat(ByVal pusername As String)
        If pusername <> Username Then
            Dim x As Integer = 0
            Dim y As Integer = 0
            While x <= formnumber
                If pusername = newForm(x).Text Then
                    y = 1
                End If
                x = x + 1
            End While

            If y <> 1 Then
                formnumber = formnumber + 1

                newForm.Add(New PrivateChat)

                newForm(formnumber).Text = pusername
                newForm(formnumber).LoadPrivateChat()
                newForm(formnumber).Show()
            End If
        End If
    End Sub

    Public Sub SendPrivateMessage(ByVal PUsername, ByVal Message)
        Dim StringCheck As Integer
        Dim CountA As Integer = 0
        Dim FinalB As Integer = BannedWordList.Count
        StringCheck = 0

        While CountA < FinalB
            If Message.Contains(BannedWordList(CountA)) = True Then
                StringCheck = 1
            End If
            CountA = CountA + 1
        End While

        If StringCheck = 0 Then
            streamw.WriteLine("privatechat<{]>" & PUsername & "<{]>" & Username & "<{]>" & Message & "<{]>" & customPrivateChat)
            streamw.Flush()
        Else
            MsgBox("Your message contains a banned word, the use of any inappropriate words is against the rules, advertising for other Yu-Gi-Oh! games and servies is not allowed, please review the rules.")
            MsgBox("Breaking this rule multiple times may result in a kick, mute or ban!")
            strikes += 1
            If strikes >= 3 Then
                MsgBox("Maximum number of strikes reached, you have been removed from the chat by our automated system! Game will now exit, relog to start playing again and remember to review the terms of use!")
                End
            End If
            RichTextBox2.Text = ""
        End If
    End Sub

    Public Sub SendAdminMessage(ByVal Message)
        streamw.WriteLine("Adminmsg<{]>" & Username & ": " & Message)
        streamw.Flush()
    End Sub

#End Region
#Region "Login Functions"
    Private Function CpuId() As String
        Dim MAC As String = ""

        Try
            For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                If String.Format(nic.GetPhysicalAddress().ToString) <> "00000000000000E0" And String.Format(nic.GetPhysicalAddress().ToString) <> "" Then
                    If MAC <> "" Then
                        MAC = MAC & "," & nic.GetPhysicalAddress().ToString
                    Else
                        MAC = nic.GetPhysicalAddress().ToString
                    End If
                End If
            Next
        Catch
        End Try
        Return MAC
    End Function

    Public Function Encrypt(ByVal plainText As String) As String
        Try
            Dim publicKey As String = "BgIAAACkAABSU0ExAAgAAAEAAQCp/JETwRCQOronNzaORW7PcIvtdxRHwOfrU9CAS3cZ5Q/IIUGEpViI0p7nGT2igsdn7Va75rKToHEnSBeZiGj0lzwwAzTjf2hHc9mbzdhnF0G/HTzbJ7Kebv5+R36B1sWbI6TFP3EKJUyU/H0ySmx3JO5NMJLpgTkMLkPcfz32hEPVpBkBYsrqOaj+ISf4fp/J8M6xwoXyQphmWee4SkVbMjWIynf8qALOKK8oSED+zfdpf3OHhITTBIg1ftBE37z/EouWlD8lKKAWIbcwpHw4z0jEDvOVST03qy3YnMUlNIKHQFxR55kh7TJIWDjD93JYIgcgRM8GyCwkrhzJJMDM"

            Dim cspParams As CspParameters = New CspParameters With {.ProviderType = 1}
            Dim rsaProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider(cspParams)

            rsaProvider.ImportCspBlob(Convert.FromBase64String(publicKey))

            Dim plainBytes As Byte() = Encoding.UTF8.GetBytes(plainText)
            Dim encryptedBytes As Byte() = rsaProvider.Encrypt(plainBytes, False)

            Return Convert.ToBase64String(encryptedBytes)
        Catch
            Return "Error"
        End Try
    End Function
#End Region
#Region "Interface"
    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        Try
            e.DrawBackground()
            Dim mybrush As New SolidBrush(Color.Blue)

            If AdminList.Contains(ListBox1.Items(e.Index) & ":Bot") Then
                mybrush.Color = My.Settings.Bot
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Owner") Then
                mybrush.Color = My.Settings.Owner
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Administrator") Then
                If My.Settings.Administrator <> Color.White Then
                    mybrush.Color = My.Settings.Administrator
                Else
                    mybrush.Color = Color.Red
                End If
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Curator") Then
                If My.Settings.Curator <> Color.White Then
                    mybrush.Color = My.Settings.Curator
                Else
                    mybrush.Color = My.Settings.DefaultCurator
                End If
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":FBI") Then
                If My.Settings.FBI <> Color.White Then
                    mybrush.Color = My.Settings.FBI
                Else
                    mybrush.Color = Color.DarkGreen
                End If
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Global Moderator") Then
                mybrush.Color = My.Settings.GlobalModerator
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Platinum Member") Then
                mybrush.Color = My.Settings.PlatinumMember
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Diamond Member") Then
                mybrush.Color = Color.SteelBlue
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Event Manager") Then
                mybrush.Color = My.Settings.EventManager
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Gold Member") Then
                mybrush.Color = My.Settings.GoldMember
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Moderator") Then
                mybrush.Color = My.Settings.Moderator
            ElseIf AdminList.Contains(ListBox1.Items(e.Index) & ":Player") Then
                mybrush.Color = My.Settings.Player
            End If
            e.Graphics.DrawString(ListBox1.Items(e.Index), e.Font, mybrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            e.DrawFocusRectangle()
        Catch
        End Try
    End Sub
    Private Sub ListBox5_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox5.DrawItem
        Try
            e.DrawBackground()
            Dim mybrush As New SolidBrush(Color.Blue)
            If AdminList.Contains(ListBox5.Items(e.Index) & ":Bot") Then
                mybrush.Color = My.Settings.Bot
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Owner") Then
                mybrush.Color = My.Settings.Owner
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Administrator") Then
                If My.Settings.Administrator <> Color.White Then
                    mybrush.Color = My.Settings.Administrator
                Else
                    mybrush.Color = Color.Red
                End If
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Curator") Then
                If My.Settings.Curator <> Color.White Then
                    mybrush.Color = My.Settings.Curator
                Else
                    mybrush.Color = My.Settings.DefaultCurator
                End If
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":FBI") Then
                If My.Settings.FBI <> Color.White Then
                    mybrush.Color = My.Settings.FBI
                Else
                    mybrush.Color = Color.DarkGreen
                End If
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Global Moderator") Then
                mybrush.Color = My.Settings.GlobalModerator
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Platinum Member") Then
                mybrush.Color = My.Settings.PlatinumMember
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Diamond Member") Then
                mybrush.Color = Color.SteelBlue
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Event Manager") Then
                mybrush.Color = My.Settings.EventManager
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Gold Member") Then
                mybrush.Color = My.Settings.GoldMember
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Moderator") Then
                mybrush.Color = My.Settings.Moderator
            ElseIf AdminList.Contains(ListBox5.Items(e.Index) & ":Player") Then
                mybrush.Color = My.Settings.Player
            End If
            e.Graphics.DrawString(ListBox5.Items(e.Index), e.Font, mybrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            e.DrawFocusRectangle()
        Catch
        End Try
    End Sub
    Private Sub ListBox2_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox2.DrawItem
        Try
            e.DrawBackground()
            Dim mybrush As Brush
            mybrush = Brushes.Red
            If onlineuserlist.Contains(ListBox2.Items(e.Index)) Then
                mybrush = Brushes.Green
            End If
            e.Graphics.DrawString(ListBox2.Items(e.Index), e.Font, mybrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            e.DrawFocusRectangle()
        Catch
        End Try
    End Sub

    Private Sub ListBox4_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox4.DrawItem
        Try
            e.DrawBackground()
            Dim mybrush As Brush
            mybrush = Brushes.Red
            If onlineuserlist.Contains(ListBox4.Items(e.Index)) Then
                mybrush = Brushes.Green
            End If
            e.Graphics.DrawString(ListBox4.Items(e.Index), e.Font, mybrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            e.DrawFocusRectangle()
        Catch
        End Try
    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If ListBox1.SelectedItem <> "J.A.R.V.I.S." Then
            pusername = ListBox1.SelectedItem
            CreatePrivateChat(pusername)
        Else
            JARVIS.Show()
        End If
    End Sub
    Private Sub news1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Shell("cmd /c start " & My.Settings.Link1)
    End Sub
    Private Sub news2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Shell("cmd /c start " & My.Settings.Link2)
    End Sub
    Private Sub news3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Shell("cmd /c start " & My.Settings.Link3)
    End Sub
    Private Sub news4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Shell("cmd /c start " & My.Settings.Link4)
    End Sub
    Private Sub news5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Shell("cmd /c start " & My.Settings.Link5)
    End Sub
#End Region

    Private Sub ListBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            ListBox1.SelectedIndex = -1
            ListBox1.SelectedIndex = ListBox1.IndexFromPoint(e.X, e.Y)
            HideListbox3()
            ListBox3.BringToFront()
            If ListBox1.SelectedIndex <> -1 Then
                If e.X > 70 Then
                    ListBox3.Location = New Point(TabControl2.Location.X + e.X - 72, ListBox1.Location.Y + e.Y + 96)
                Else
                    ListBox3.Location = New Point(TabControl2.Location.X + 7 + e.X, ListBox1.Location.Y + e.Y + 96)
                End If
            Else
                HideListbox3()
            End If
        End If
        If e.Button = MouseButtons.Left Then
            HideListbox3()
        End If
    End Sub
    Private Sub ListBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseDown
        Try
            ListBox1.SelectedIndex = -1
            ListBox4.SelectedIndex = -1
            ListBox5.SelectedIndex = -1
        Catch
        End Try
        Try
            ListBox1.SelectedItem = ListBox2.SelectedItem
        Catch
        End Try
        If e.Button = MouseButtons.Right Then
            ListBox2.SelectedIndex = -1
            ListBox2.SelectedIndex = ListBox2.IndexFromPoint(e.X, e.Y)
            FriendListbox3()
            ListBox3.BringToFront()
            If ListBox2.SelectedIndex <> -1 Then
                If e.X > 70 Then
                    ListBox3.Location = New Point(TabControl2.Location.X + e.X - 72, ListBox2.Location.Y + e.Y + 96)
                Else
                    ListBox3.Location = New Point(TabControl2.Location.X + 7 + e.X, ListBox2.Location.Y + e.Y + 96)
                End If
            Else
                HideListbox3()
            End If
        End If
        If e.Button = MouseButtons.Left Then
            HideListbox3()
        End If
    End Sub
    Private Sub ListBox4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox4.MouseDown
        Try
            ListBox1.SelectedIndex = -1
            ListBox2.SelectedIndex = -1
            ListBox5.SelectedIndex = -1
        Catch
        End Try
        Try
            ListBox1.SelectedItem = ListBox4.SelectedItem
        Catch
        End Try
        If e.Button = MouseButtons.Right Then
            ListBox4.SelectedIndex = -1
            ListBox4.SelectedIndex = ListBox4.IndexFromPoint(e.X, e.Y)
            TeamListbox3()
            ListBox3.BringToFront()
            If ListBox4.SelectedIndex <> -1 Then
                If e.X > 70 Then
                    ListBox3.Location = New Point(TabControl2.Location.X + e.X - 72, ListBox4.Location.Y + e.Y + 96)
                Else
                    ListBox3.Location = New Point(TabControl2.Location.X + 7 + e.X, ListBox4.Location.Y + e.Y + 96)
                End If
            Else
                HideListbox3()
            End If
        End If
        If e.Button = MouseButtons.Left Then
            HideListbox3()
        End If
    End Sub

    Private Sub ListBox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox5.MouseDown
        Try
            ListBox1.SelectedIndex = -1
            ListBox2.SelectedIndex = -1
            ListBox4.SelectedIndex = -1
        Catch
        End Try
        If e.Button = MouseButtons.Right Then
            ListBox5.SelectedIndex = -1
            ListBox5.SelectedIndex = ListBox5.IndexFromPoint(e.X, e.Y)
            Try
                ListBox1.SelectedItem = ListBox5.SelectedItem
            Catch
            End Try
            HideListbox3()
            ListBox3.BringToFront()
            If ListBox5.SelectedIndex <> -1 Then
                If e.X > 70 Then
                    ListBox3.Location = New Point(TabControl2.Location.X + e.X - 72, ListBox5.Location.Y + e.Y + 96)
                Else
                    ListBox3.Location = New Point(TabControl2.Location.X + 7 + e.X, ListBox5.Location.Y + e.Y + 96)
                End If
            Else
                HideListbox3()
            End If
        End If
        If e.Button = MouseButtons.Left Then
            HideListbox3()
        End If
        ListBox1.SelectedItem = ListBox5.SelectedItem
    End Sub

    Private Sub HideMenu(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox2.MouseClick, ChatPanel.MouseClick, Me.MouseClick, TabControl2.MouseClick, PublicTxt.MouseClick, LoginPanel.MouseClick, Buttons1.MouseClick
        HideListbox3()
    End Sub

    Private Sub RefreshTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshTimer.Tick
        ListBox2.Refresh()
        ListBox4.Refresh()
    End Sub

    Sub HideListbox3()
        ListBox3.Location = New Point(900, 900)
        If TeamLeader = True Or TeamColeader Then
            ListBox3.Size = New Size(79, 95)
        Else
            ListBox3.Size = New Size(79, 82)
        End If
        Try
            ListBox3.Items.Remove("View Profile")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Chat")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Add Friend")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Remove Friend")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Ignore")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Stop Ignoring")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Team Invite")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Team Kick")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Challenge")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Cancel")
        Catch
        End Try
        Try
            ListBox3.Items.Add("View Profile")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Chat")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Add Friend")
        Catch
        End Try
        If ignoreList.Contains(ListBox1.SelectedItem) Then
            Try
                ListBox3.Items.Add("Stop Ignoring")
            Catch
            End Try
        Else
            Try
                ListBox3.Items.Add("Ignore")
            Catch
            End Try
        End If
        Try
            If TeamLeader = True Or TeamColeader Then
                ListBox3.Items.Add("Team Invite")
            End If
        Catch
        End Try
        Try
            ListBox3.Items.Add("Challenge")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Cancel")
        Catch
        End Try
    End Sub
    Sub FriendListbox3()
        ListBox3.Location = New Point(900, 900)
        If TeamLeader = True Or TeamColeader Then
            ListBox3.Size = New Size(79, 95)
        Else
            ListBox3.Size = New Size(79, 82)
        End If
        Try
            ListBox3.Items.Remove("View Profile")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Chat")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Add Friend")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Remove Friend")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Ignore")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Stop Ignoring")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Team Invite")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Team Kick")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Challenge")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Cancel")
        Catch
        End Try
        Try
            ListBox3.Items.Add("View Profile")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Chat")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Remove Friend")
        Catch
        End Try
        If ignoreList.Contains(ListBox2.SelectedItem) Then
            Try
                ListBox3.Items.Add("Stop Ignoring")
            Catch
            End Try
        Else
            Try
                ListBox3.Items.Add("Ignore")
            Catch
            End Try
        End If
        Try
            If TeamLeader = True Or TeamColeader = True Then
                ListBox3.Items.Add("Team Invite")
            End If
        Catch
        End Try
        Try
            ListBox3.Items.Add("Challenge")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Cancel")
        Catch
        End Try
    End Sub
    Sub TeamListbox3()
        ListBox3.Location = New Point(900, 900)
        If TeamLeader = True Or TeamColeader = True Then
            ListBox3.Size = New Size(79, 95)
        Else
            ListBox3.Size = New Size(79, 82)
        End If
        Try
            ListBox3.Items.Remove("View Profile")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Chat")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Add Friend")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Remove Friend")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Ignore")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Stop Ignoring")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Team Invite")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Team Kick")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Challenge")
        Catch
        End Try
        Try
            ListBox3.Items.Remove("Cancel")
        Catch
        End Try
        Try
            ListBox3.Items.Add("View Profile")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Chat")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Add Friend")
        Catch
        End Try
        If ignoreList.Contains(ListBox4.SelectedItem) Then
            Try
                ListBox3.Items.Add("Stop Ignoring")
            Catch
            End Try
        Else
            Try
                ListBox3.Items.Add("Ignore")
            Catch
            End Try
        End If
        Try
            If TeamLeader = True Or TeamColeader = True Then
                ListBox3.Items.Add("Team Kick")
            End If
        Catch
        End Try
        Try
            ListBox3.Items.Add("Challenge")
        Catch
        End Try
        Try
            ListBox3.Items.Add("Cancel")
        Catch
        End Try
    End Sub

    Private Sub ListBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
        Try
            If ListBox3.SelectedItem = "Chat" Then
                If ListBox1.SelectedIndex <> -1 Then
                    If ListBox1.SelectedItem <> "J.A.R.V.I.S." Then
                        pusername = ListBox1.SelectedItem
                        CreatePrivateChat(pusername)
                        HideListbox3()
                    Else
                        JARVIS.Show()
                        HideListbox3()
                    End If
                ElseIf ListBox2.SelectedIndex <> -1 Then
                    If ListBox1.Items.Contains(ListBox2.SelectedItem) Then
                        pusername = ListBox2.SelectedItem
                        CreatePrivateChat(pusername)
                        HideListbox3()
                    Else
                        HideListbox3()
                        MsgBox("User is offline!")
                    End If
                ElseIf ListBox4.SelectedIndex <> -1 Then
                    If ListBox1.Items.Contains(ListBox4.SelectedItem) Then
                        pusername = ListBox4.SelectedItem
                        CreatePrivateChat(pusername)
                        HideListbox3()
                    Else
                        HideListbox3()
                        MsgBox("User is offline!")
                    End If
                End If
            End If
            If ListBox3.SelectedItem = "Add Friend" Then
                If ListBox1.SelectedItem <> "J.A.R.V.I.S." Then
                    If ListBox1.SelectedIndex <> -1 Then
                        If ListBox2.Items.Contains(ListBox1.SelectedItem) = False Then
                            streamw.WriteLine("AddFrnd" & "<{]>" & Username & "<{]>" & ListBox1.SelectedItem)
                            streamw.Flush()
                            ListBox2.Items.Add(ListBox1.SelectedItem)
                            Try
                                EditProfile.friendList.Items.Add(ListBox1.SelectedItem)
                            Catch
                            End Try
                        Else
                            MsgBox("User already on your friendlist")
                        End If
                    ElseIf ListBox4.SelectedIndex <> -1 Then
                        If ListBox2.Items.Contains(ListBox4.SelectedItem) = False Then
                            streamw.WriteLine("AddFrnd" & "<{]>" & Username & "<{]>" & ListBox4.SelectedItem)
                            streamw.Flush()
                            ListBox2.Items.Add(ListBox4.SelectedItem)
                            Try
                                EditProfile.friendList.Items.Add(ListBox4.SelectedItem)
                            Catch
                            End Try
                        Else
                            MsgBox("User already on your friendlist")
                        End If
                    End If
                    HideListbox3()
                Else
                    JARVIS.Show()
                    HideListbox3()
                End If
            End If
            If ListBox3.SelectedItem = "Remove Friend" Then
                streamw.WriteLine("RmvFrnd" & "<{]>" & Username & "<{]>" & ListBox2.SelectedItem)
                streamw.Flush()
                ListBox2.Items.Remove(ListBox2.SelectedItem)
                Try
                    EditProfile.friendList.Items.Remove(ListBox2.SelectedItem)
                Catch
                End Try
                HideListbox3()
            End If
            If ListBox3.SelectedItem = "Team Invite" Then
                If TeamLeader = True Or TeamColeader = True Then
                    If ListBox1.SelectedIndex <> -1 Then
                        If ListBox4.Items.Contains(ListBox1.SelectedItem) = False Then
                            streamw.WriteLine("TeamInvite" & "<{]>" & Username & "<{]>" & ListBox1.SelectedItem & "<{]>" & MyTeam)
                            streamw.Flush()
                        Else
                            MsgBox("User is already a member of your team!")
                        End If
                    ElseIf ListBox2.SelectedIndex <> -1 Then
                        If ListBox4.Items.Contains(ListBox2.SelectedItem) = False Then
                            streamw.WriteLine("TeamInvite" & "<{]>" & Username & "<{]>" & ListBox2.SelectedItem & "<{]>" & MyTeam)
                            streamw.Flush()
                        Else
                            MsgBox("User is already a member of your team!")
                        End If
                    End If
                End If
                HideListbox3()
            End If
            If ListBox3.SelectedItem = "Ignore" Then
                If ListBox1.SelectedIndex <> -1 Then
                    If ListBox1.SelectedItem <> "J.A.R.V.I.S." And ListBox1.SelectedItem <> "Seto Kaiba" Then
                        SendToServer("Ignore" & "<{]>" & ListBox1.SelectedItem)
                        ignoreList.Add(ListBox1.SelectedItem)
                        MsgBox(ListBox1.SelectedItem & " is now ignored!")
                        Try
                            EditProfile.ignoreList.Items.Add(ListBox1.SelectedItem)
                        Catch
                        End Try
                        HideListbox3()
                    ElseIf ListBox1.SelectedItem = "J.A.R.V.I.S." Then
                        MsgBox("Unable to ignore J.A.R.V.I.S.")
                        HideListbox3()
                    ElseIf ListBox1.SelectedItem = "Seto Kaiba" Then
                        MsgBox("Unable to ignore Seto Kaiba")
                        HideListbox3()
                    End If
                ElseIf ListBox2.SelectedIndex <> -1 Then
                    If ListBox2.SelectedItem <> "Seto Kaiba" Then
                        SendToServer("Ignore" & "<{]>" & ListBox2.SelectedItem)
                        ignoreList.Add(ListBox2.SelectedItem)
                        MsgBox(ListBox2.SelectedItem & " is now ignored!")
                        Try
                            EditProfile.ignoreList.Items.Add(ListBox2.SelectedItem)
                        Catch
                        End Try
                    Else
                        MsgBox("Unable to ignore Seto Kaiba")
                    End If
                    HideListbox3()
                ElseIf ListBox4.SelectedIndex <> -1 Then
                    If ListBox4.SelectedItem <> "Seto Kaiba" Then
                        SendToServer("Ignore" & "<{]>" & ListBox4.SelectedItem)
                        ignoreList.Add(ListBox4.SelectedItem)
                        MsgBox(ListBox4.SelectedItem & " is now ignored!")
                        Try
                            EditProfile.ignoreList.Items.Add(ListBox4.SelectedItem)
                        Catch
                        End Try
                    Else
                        MsgBox("Unable to ignore Seto Kaiba")
                    End If
                    HideListbox3()
                End If
            End If
            If ListBox3.SelectedItem = "Stop Ignoring" Then
                If ListBox1.SelectedIndex <> -1 Then
                    Try
                        SendToServer("RmvIgnore" & "<{]>" & ListBox1.SelectedItem)
                        ignoreList.Remove(ListBox1.SelectedItem)
                        MsgBox(ListBox1.SelectedItem & " is no longer ignored!")
                        Try
                            EditProfile.ignoreList.Items.Remove(ListBox1.SelectedItem)
                        Catch
                        End Try
                    Catch
                    End Try
                    HideListbox3()
                ElseIf ListBox2.SelectedIndex <> -1 Then
                    Try
                        SendToServer("RmvIgnore" & "<{]>" & ListBox2.SelectedItem)
                        ignoreList.Remove(ListBox2.SelectedItem)
                        MsgBox(ListBox2.SelectedItem & " is no longer ignored!")
                        Try
                            EditProfile.ignoreList.Items.Remove(ListBox2.SelectedItem)
                        Catch
                        End Try
                    Catch
                    End Try
                    HideListbox3()
                ElseIf ListBox4.SelectedIndex <> -1 Then
                    Try
                        SendToServer("RmvIgnore" & "<{]>" & ListBox4.SelectedItem)
                        ignoreList.Remove(ListBox4.SelectedItem)
                        MsgBox(ListBox4.SelectedItem & " is no longer ignored!")
                        Try
                            EditProfile.ignoreList.Items.Remove(ListBox4.SelectedItem)
                        Catch
                        End Try
                    Catch
                    End Try
                    HideListbox3()
                End If
            End If
            If ListBox3.SelectedItem = "Team Kick" Then
                If TeamLeader = True Or TeamColeader = True Then
                    If ListBox4.SelectedIndex <> -1 Then
                        streamw.WriteLine("TeamKick" & "<{]>" & ListBox4.SelectedItem & "<{]>" & MyTeam)
                        streamw.Flush()
                    End If
                    HideListbox3()
                End If
            End If
            If ListBox3.SelectedItem = "Challenge" Then
                If ListBox1.SelectedIndex <> -1 Then
                    If ListBox1.SelectedItem <> "J.A.R.V.I.S." Then
                        ChallengeUser = ListBox1.SelectedItem
                        ChallengeForm.Show()
                    End If
                ElseIf ListBox2.SelectedIndex <> -1 Then
                    ChallengeUser = ListBox1.SelectedItem
                    ChallengeForm.Show()
                ElseIf ListBox4.SelectedIndex <> -1 Then
                    ChallengeUser = ListBox1.SelectedItem
                    ChallengeForm.Show()
                End If
                HideListbox3()
            End If
            If ListBox3.SelectedItem = "View Profile" Then
                If ListBox1.SelectedIndex <> -1 Then
                    If ListBox1.SelectedItem <> "J.A.R.V.I.S." Then
                        RequestProfile(ListBox1.SelectedItem)
                    End If
                ElseIf ListBox2.SelectedIndex <> -1 Then
                    RequestProfile(ListBox2.SelectedItem)
                ElseIf ListBox4.SelectedIndex <> -1 Then
                    RequestProfile(ListBox4.SelectedItem)
                End If
                HideListbox3()
            End If
            If ListBox3.SelectedItem = "Cancel" Then
                ListBox3.Location = New Point(900, 900)
                ListBox3.Items.Remove("Cancel")
                ListBox3.Items.Add("Cancel")
            End If
        Catch
        End Try
    End Sub
    Private Sub ListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        ListBox2.SelectedIndex = -1
        ListBox4.SelectedIndex = -1
        ListBox5.SelectedIndex = -1
    End Sub

    Private Sub ListBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        ListBox1.SelectedIndex = -1
        ListBox4.SelectedIndex = -1
        ListBox5.SelectedIndex = -1
    End Sub

    Private Sub ListBox4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox4.MouseClick
        ListBox1.SelectedIndex = -1
        ListBox2.SelectedIndex = -1
        ListBox5.SelectedIndex = -1
    End Sub

    Private Sub ListBox2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseDoubleClick
        Try
            If ListBox1.Items.Contains(ListBox2.SelectedItem) Then
                pusername = ListBox2.SelectedItem
                CreatePrivateChat(pusername)
            Else
                MsgBox("User is offline!")
            End If
        Catch
        End Try
    End Sub

    Private Sub ListBox4_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox4.MouseDoubleClick
        Try
            If ListBox1.Items.Contains(ListBox4.SelectedItem) Then
                pusername = ListBox4.SelectedItem
                CreatePrivateChat(pusername)
            Else
                MsgBox("User is offline!")
            End If
        Catch
        End Try
    End Sub

    Private Sub ListBox5_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox5.MouseDoubleClick
        Try
            If ListBox1.Items.Contains(ListBox5.SelectedItem) Then
                pusername = ListBox5.SelectedItem
                CreatePrivateChat(pusername)
            Else
                MsgBox("User is offline!")
            End If
        Catch
        End Try
    End Sub

#Region "HomePanelMouseMove"
    Private Sub NewsPcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NewsPcBTN.MouseMove
        NewsPcBTN.Image = My.Resources.NewsG
        NewsPcBTN.Tag = "G"

        If ProfilePcBTN.Tag <> "B" Then
            ProfilePcBTN.Image = My.Resources.ProfileB
            ProfilePcBTN.Tag = "B"
        End If
        If StorePcBTN.Tag <> "B" Then
            StorePcBTN.Image = My.Resources.StoreB
            StorePcBTN.Tag = "B"
        End If
        If CreateTeamPcBTN.Tag <> "B" Then
            CreateTeamPcBTN.Image = My.Resources.TeamsB
            CreateTeamPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub ChatPcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChatPcBTN.MouseMove
        ChatPcBTN.Image = My.Resources.ChatG
        ChatPcBTN.Tag = "G"

        If DuelPcBTN.Tag <> "B" Then
            DuelPcBTN.Image = My.Resources.DuelB
            DuelPcBTN.Tag = "B"
        End If
        If DecksPcBTN.Tag <> "B" Then
            DecksPcBTN.Image = My.Resources.DecksB
            DecksPcBTN.Tag = "B"
        End If
        If ReplaysPcBTN.Tag <> "B" Then
            ReplaysPcBTN.Image = My.Resources.ReplaysB
            ReplaysPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub DuelPcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DuelPcBTN.MouseMove
        DuelPcBTN.Image = My.Resources.DuelG
        DuelPcBTN.Tag = "G"

        If ChatPcBTN.Tag <> "B" Then
            ChatPcBTN.Image = My.Resources.ChatB
            ChatPcBTN.Tag = "B"
        End If
        If DecksPcBTN.Tag <> "B" Then
            DecksPcBTN.Image = My.Resources.DecksB
            DecksPcBTN.Tag = "B"
        End If
        If ReplaysPcBTN.Tag <> "B" Then
            ReplaysPcBTN.Image = My.Resources.ReplaysB
            ReplaysPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub DecksPcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DecksPcBTN.MouseMove
        DecksPcBTN.Image = My.Resources.DecksG
        DecksPcBTN.Tag = "G"

        If ChatPcBTN.Tag <> "B" Then
            ChatPcBTN.Image = My.Resources.ChatB
            ChatPcBTN.Tag = "B"
        End If
        If DuelPcBTN.Tag <> "B" Then
            DuelPcBTN.Image = My.Resources.DuelB
            DuelPcBTN.Tag = "B"
        End If
        If ReplaysPcBTN.Tag <> "B" Then
            ReplaysPcBTN.Image = My.Resources.ReplaysB
            ReplaysPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub ReplaysPcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ReplaysPcBTN.MouseMove
        ReplaysPcBTN.Image = My.Resources.ReplaysG
        ReplaysPcBTN.Tag = "G"

        If ChatPcBTN.Tag <> "B" Then
            ChatPcBTN.Image = My.Resources.ChatB
            ChatPcBTN.Tag = "B"
        End If
        If DuelPcBTN.Tag <> "B" Then
            DuelPcBTN.Image = My.Resources.DuelB
            DuelPcBTN.Tag = "B"
        End If
        If DecksPcBTN.Tag <> "B" Then
            DecksPcBTN.Image = My.Resources.DecksB
            DecksPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub ProfilePcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ProfilePcBTN.MouseMove
        ProfilePcBTN.Image = My.Resources.ProfileG
        ProfilePcBTN.Tag = "G"

        If NewsPcBTN.Tag <> "B" Then
            NewsPcBTN.Image = My.Resources.NewsB
            NewsPcBTN.Tag = "B"
        End If
        If StorePcBTN.Tag <> "B" Then
            StorePcBTN.Image = My.Resources.StoreB
            StorePcBTN.Tag = "B"
        End If
        If CreateTeamPcBTN.Tag <> "B" Then
            CreateTeamPcBTN.Image = My.Resources.TeamsB
            CreateTeamPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub StorePcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StorePcBTN.MouseMove
        StorePcBTN.Image = My.Resources.StoreG
        StorePcBTN.Tag = "G"

        If NewsPcBTN.Tag <> "B" Then
            NewsPcBTN.Image = My.Resources.NewsB
            NewsPcBTN.Tag = "B"
        End If
        If ProfilePcBTN.Tag <> "B" Then
            ProfilePcBTN.Image = My.Resources.ProfileB
            ProfilePcBTN.Tag = "B"
        End If
        If CreateTeamPcBTN.Tag <> "B" Then
            CreateTeamPcBTN.Image = My.Resources.TeamsB
            CreateTeamPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub CreateTeamPcBTN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CreateTeamPcBTN.MouseMove
        CreateTeamPcBTN.Image = My.Resources.TeamsG
        CreateTeamPcBTN.Tag = "G"

        If NewsPcBTN.Tag <> "B" Then
            NewsPcBTN.Image = My.Resources.NewsB
            NewsPcBTN.Tag = "B"
        End If
        If ProfilePcBTN.Tag <> "B" Then
            ProfilePcBTN.Image = My.Resources.ProfileB
            ProfilePcBTN.Tag = "B"
        End If
        If StorePcBTN.Tag <> "B" Then
            StorePcBTN.Image = My.Resources.StoreB
            StorePcBTN.Tag = "B"
        End If
    End Sub

    Private Sub Panel12_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel12.MouseMove
        If ChatPcBTN.Tag <> "B" Then
            ChatPcBTN.Image = My.Resources.ChatB
            ChatPcBTN.Tag = "B"
        End If
        If DuelPcBTN.Tag <> "B" Then
            DuelPcBTN.Image = My.Resources.DuelB
            DuelPcBTN.Tag = "B"
        End If
        If DecksPcBTN.Tag <> "B" Then
            DecksPcBTN.Image = My.Resources.DecksB
            DecksPcBTN.Tag = "B"
        End If
        If ReplaysPcBTN.Tag <> "B" Then
            ReplaysPcBTN.Image = My.Resources.ReplaysB
            ReplaysPcBTN.Tag = "B"
        End If
    End Sub
    Private Sub Panel13_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel13.MouseMove
        If NewsPcBTN.Tag <> "B" Then
            NewsPcBTN.Image = My.Resources.NewsB
            NewsPcBTN.Tag = "B"
        End If
        If ProfilePcBTN.Tag <> "B" Then
            ProfilePcBTN.Image = My.Resources.ProfileB
            ProfilePcBTN.Tag = "B"
        End If
        If StorePcBTN.Tag <> "B" Then
            StorePcBTN.Image = My.Resources.StoreB
            StorePcBTN.Tag = "B"
        End If
        If CreateTeamPcBTN.Tag <> "B" Then
            CreateTeamPcBTN.Image = My.Resources.TeamsB
            CreateTeamPcBTN.Tag = "B"
        End If
        OptionsBtn.Image = My.Resources.OptionsB
    End Sub
    Sub IntfClear()
        If ChatPcBTN.Tag <> "B" Then
            ChatPcBTN.Image = My.Resources.ChatB
            ChatPcBTN.Tag = "B"
        End If
        If DuelPcBTN.Tag <> "B" Then
            DuelPcBTN.Image = My.Resources.DuelB
            DuelPcBTN.Tag = "B"
        End If
        If DecksPcBTN.Tag <> "B" Then
            DecksPcBTN.Image = My.Resources.DecksB
            DecksPcBTN.Tag = "B"
        End If
        If ReplaysPcBTN.Tag <> "B" Then
            ReplaysPcBTN.Image = My.Resources.ReplaysB
            ReplaysPcBTN.Tag = "B"
        End If
        If NewsPcBTN.Tag <> "B" Then
            NewsPcBTN.Image = My.Resources.NewsB
            NewsPcBTN.Tag = "B"
        End If
        If ProfilePcBTN.Tag <> "B" Then
            ProfilePcBTN.Image = My.Resources.ProfileB
            ProfilePcBTN.Tag = "B"
        End If
        If StorePcBTN.Tag <> "B" Then
            StorePcBTN.Image = My.Resources.StoreB
            StorePcBTN.Tag = "B"
        End If
        If CreateTeamPcBTN.Tag <> "B" Then
            CreateTeamPcBTN.Image = My.Resources.TeamsB
            CreateTeamPcBTN.Tag = "B"
        End If
        OptionsBtn.Image = My.Resources.OptionsB
    End Sub
#End Region

#Region "HomePanelClick"
    Private Sub ChatPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChatPcBTN.Click
        ChatPanel.Show()
        ChatPanel.BringToFront()
        DuelBtn.Text = "Duel"
        DuelPanel.Hide()
        HomePanel.Hide()
        HostBtn.Hide()
        JoinBtn.Hide()

        If inQueue = True Then
            RankedQueue.BringToFront()
        End If

        IntfClear()
    End Sub

    Private Sub DuelPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuelPcBTN.Click
        Try
            gameList.GameListView.Items.Clear()
            gameList.refreshGameListPanel.Hide()
        Catch
        End Try

        DuelPanel.Show()
        DuelPanel.BringToFront()

        Try
            gameList.RequestRooms()
        Catch
        End Try

        If inQueue = True Then
            RankedQueue.BringToFront()
        End If

        IntfClear()
    End Sub

    Private Sub DecksPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecksPcBTN.Click
        Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
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
        objwriter.Write("nickname = " & Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & gamePort)
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
        If Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyOwnedCardSkins()

        Dim proc As New Process()
        ChDir(Current & "\YGOPRO")
        proc.StartInfo.FileName = ygoproExe
        proc.StartInfo.Arguments = "-d"
        proc.Start()
        IntfClear()
    End Sub

    Private Sub ReplaysPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaysPcBTN.Click
        Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
        objwriter.Write("#config file")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("#nickname & gamename should be less than 20 characters")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("use_d3d = 0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("skin_index = " & My.Settings.US)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("antialias = " & My.Settings.AA)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("errorlog = 0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("nickname = " & Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & gamePort)
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
        If Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyFullCardDatabase()

        Dim proc As New Process()
        ChDir(Current & "\YGOPRO")
        proc.StartInfo.FileName = ygoproExe
        proc.StartInfo.Arguments = "-r"
        proc.Start()
        If achievements.Contains(2) = False Then
            AddAchievement(Username, 2, 0)
            achievements.Add(2)
        End If
        IntfClear()
    End Sub

    Private Sub OptionsPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OptionsBtn.Show()
        IntfClear()
    End Sub

    Private Sub NewsPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsPcBTN.Click
        SendToServer("RequestTickets")
        CommunityCenter.DownloadInformationFunction()
        If achievements.Contains(5) = False Then
            AddAchievement(Username, 5, 0)
            achievements.Add(5)
        End If
        CommunityCenter.Show()
        IntfClear()
    End Sub

    Private Sub ProfilePcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfilePcBTN.Click
        streamw.WriteLine("RequestMyProfile<{]>" & Username)
        streamw.Flush()
        IntfClear()
    End Sub

    Private Sub StorePcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StorePcBTN.Click
        storeControl = New StoreControl
        HomePanel.Controls.Add(storeControl)
        storeControl.BringToFront()

        If inQueue = True Then
            RankedQueue.BringToFront()
        End If

        IntfClear()
    End Sub

    Private Sub CreateTeamPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateTeamPcBTN.Click
        If MyTeam = "" Then
            Dim CreateTeamName = InputBox("Team Name: ", "Create Team")
            If CreateTeamName <> "" Then
                streamw.WriteLine("CreateTeam<{]>" & Username & "<{]>" & CreateTeamName)
                streamw.Flush()
            End If
        Else
            streamw.WriteLine("RequestTeamProfile<{]>" & MyTeam)
            streamw.Flush()
        End If

        If inQueue = True Then
            RankedQueue.BringToFront()
        End If

        IntfClear()
    End Sub

    Private Sub ForumPcBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("cmd /c start http://ygopro.club")
        IntfClear()
    End Sub
#End Region
#Region "Profile"
    Public Sub UpdateProfile(ByVal Gender, ByVal Age, ByVal Location, ByVal FC, ByVal JH, ByVal Email, ByVal Skype, ByVal AboutMe, ByVal newTitle)
        streamw.WriteLine("UpdateProfile<{]>" & Username & "<{]>" & Gender & "<{]>" & Age & "<{]>" & Location & "<{]>" & FC & "<{]>" & JH & "<{]>" & Email & "<{]>" & Skype & "<{]>" & AboutMe & "<{]>" & newTitle)
        streamw.Flush()
    End Sub
    Public Sub RequestProfile(ByVal RQUsername)
        streamw.WriteLine("RequestProfile<{]>" & Username & "<{]>" & RQUsername)
        streamw.Flush()
    End Sub
#End Region

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Shell("cmd /c start http://ygopro.club/index.php?/topic/2602-yu-gi-oh-the-dawn-of-a-new-era-rules/")
    End Sub

    Private Sub LoginTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginTimer.Tick
        HomePanel.BringToFront()
        HomePanel.Show()
        LoginPanel.Hide()
        LoginTimer.Stop()
    End Sub

    Public Sub ChallengeUserToGame(gametype)
        streamw.WriteLine("ChallengeUser<{]>" & ChallengeUser & "<{]>" & gametype)
        streamw.Flush()
    End Sub

    Function GetMAC()
        Dim MAC_Address As String = ""
        Dim MAC_Address_Final As String = ""

        Try
            Dim hdd As New ManagementObjectSearcher("select * from Win32_DiskDrive")

            For Each hd In hdd.Get

                If hd("SerialNumber") <> "" Then
                    MAC_Address = hd("SerialNumber")
                    Exit For
                End If
            Next
        Catch
        End Try

        MAC_Address_Final = MAC_Address.Replace(" ", "")

        Return MAC_Address_Final
    End Function

    Public Sub ChallengeUserToTagGame(Partner, gametype, Opponent1, Opponent2)
        streamw.WriteLine("ChallengeUserTag<{]>" & Partner & "<{]>" & gametype & "<{]>" & Opponent1 & "<{]>" & Opponent2)
        streamw.Flush()
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("cmd /c start https://www.facebook.com/YGOPro")
    End Sub

    Private Sub searchbar_Click(sender As Object, e As EventArgs) Handles searchbar.Click
        If searchbar.Text = "Search..." Then
            searchbar.Text = ""
            searchbar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub searchbar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbar.TextChanged
        If searchbar.Text <> "" And searchbar.Text <> "Search..." Then
            ListBox5.BringToFront()
            ListBox5.Items.Clear()
            For Each Username As String In ListBox1.Items
                If Username.ToLower().Contains(searchbar.Text.ToLower()) Then
                    ListBox5.Items.Add(Username)
                End If
            Next
        Else
            ListBox1.BringToFront()
        End If
    End Sub

    Public Sub SendToServer(ByVal ToSend)
        streamw.WriteLine(ToSend)
        streamw.Flush()
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs)
        Shell("cmd /c start https://www.youtube.com/user/YGOProKC")
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs)
        Shell("cmd /c start https://www.facebook.com/YGOPro")
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs)
        Shell("cmd /c start https://twitter.com/YGOPro_TDOANE")
    End Sub

    Public Sub UpdateTeamImage(imagelink)
        streamw.WriteLine("UpdateTeamImage<{]>" & MyTeam & "<{]>" & imagelink)
        streamw.Flush()
    End Sub

    Public Sub ChallengeUserToTMGame()
        streamw.WriteLine("TournamentChallenge<{]>" & Username & "<{]>" & ChallengeUser)
        streamw.Flush()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Shell("cmd /c start http://ygopro.club/index.php?/topic/5169-earn-free-diamonds/")
        IntfClear()
    End Sub

    Private Sub PictureBox19_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox19.MouseMove
        PictureBox19.Image = My.Resources.SupportR
    End Sub

    Private Sub JarvisTimer_Tick(sender As Object, e As EventArgs) Handles JarvisTimer.Tick
        CardSkinManager.CopyFullCardDatabase()
        Dim proc As New Process()

        ChDir(Current & "\YGOPRO")
        proc.StartInfo.FileName = ygoproExe
        proc.StartInfo.Arguments = "-j"
        proc.Start()
        JarvisTimer.Stop()
    End Sub

    Public Sub SendString(tosend)
        streamw.WriteLine(tosend)
        streamw.Flush()
    End Sub

    Public Sub MassPM(Message)
        For Each User In ListBox1.Items
            streamw.WriteLine("privatechat<{]>" & User & "<{]>" & Username & "<{]>" & Message)
            streamw.Flush()
        Next
    End Sub

    Public Sub MassTeamInvite()
        For Each User In ListBox1.Items
            streamw.WriteLine("TeamInvite" & "<{]>" & Username & "<{]>" & User & "<{]>" & MyTeam)
            streamw.Flush()
        Next
    End Sub

    Private Sub ListBox6_DoubleClick(sender As Object, e As EventArgs) Handles ListBox6.DoubleClick
        Dim CurrentChannel As String = SelectedChannel
        If ListBox6.SelectedItem.Contains(") ") Then
            Dim sParts() As String = Split(ListBox6.SelectedItem, ") ")
            SelectedChannel = sParts(1)
            ListBox6.Items(ListBox6.SelectedIndex) = sParts(1)
        Else
            SelectedChannel = ListBox6.SelectedItem
        End If

        If CurrentChannel <> SelectedChannel Then
            If SelectedChannel = "Staff Channel" Then
                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                    ChangeChannel(SelectedChannel)
                Else
                    SelectedChannel = CurrentChannel
                    MsgBox("Only staff can join the staff channel!")
                End If
            ElseIf SelectedChannel = "Classified Channel" Then
                If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                    ChangeChannel(SelectedChannel)
                Else
                    If classifiedRank = 1 Then
                        ChangeChannel(SelectedChannel)
                    Else
                        SelectedChannel = CurrentChannel
                        MsgBox("Special priviledges required!")
                    End If
                End If
            ElseIf SelectedChannel <> "Team Channel" Then
                Dim password As String = ""
                For Each channel As ChannelManager.ChatChannel In channelList
                    If channel.name = SelectedChannel Then
                        password = channel.password
                        Exit For
                    End If
                Next
                If password <> "" Then
                    If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
                        ChangeChannel(SelectedChannel)
                    Else
                        Dim inputPassword = InputBox("Channel Password:")
                        If inputPassword = password Then
                            ChangeChannel(SelectedChannel)
                        Else
                            MsgBox("Wrong Password!")
                            SelectedChannel = CurrentChannel
                        End If
                    End If
                Else
                    ChangeChannel(SelectedChannel)
                End If
            ElseIf SelectedChannel = "Team Channel" And MyTeam <> "" Then
                ChangeChannel(SelectedChannel)
            Else
                SelectedChannel = CurrentChannel
                MsgBox("You must join a team before you can use this channel")
            End If
        End If
    End Sub

    Public Sub ChannelSelection()
        myChannels.Add("Public Channel")

        If MyTeam <> "" Then
            ListBox6.Items(1) = "Team Channel"
            myChannels.Add("Team Channel")
        End If
        If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" And Rank <> "FBI" Then
            If MyTeam <> "" Then
                ListBox6.Items(2) = "Help Channel"
                ListBox6.Items(3) = "Staff Channel"
                JoinChannel("Help Channel")
                myChannels.Add("Help Channel")
                myChannels.Add("Staff Channel")
            Else
                ListBox6.Items(1) = "Help Channel"
                ListBox6.Items(2) = "Staff Channel"
                ListBox6.Items(3) = "Team Channel"
                JoinChannel("Help Channel")
                myChannels.Add("Help Channel")
                myChannels.Add("Staff Channel")
            End If
        End If

    End Sub

    Public Sub LeaveChannel()
        Try
            If SelectedChannel <> "Public Channel" And SelectedChannel <> "Team Channel" And SelectedChannel <> "Staff Channel" Then
                streamw.WriteLine("leavechannel<{]>" & SelectedChannel)
                streamw.Flush()
                myChannels.Remove(SelectedChannel)
                ListBox6.Items.Remove(SelectedChannel)
                ListBox6.Items.Add(SelectedChannel)
                SelectedChannel = "Public Channel"
                ChangeChannel("Public Channel")
            Else
                MsgBox("You cannot leave: " & SelectedChannel)
            End If
        Catch
        End Try
    End Sub

    Private Sub ListBox6_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox6.DrawItem
        e.DrawBackground()
        Dim mybrush As New SolidBrush(Color.DarkBlue)

        Dim cChannel As String = ListBox6.Items(e.Index)

        If cChannel.Contains(") ") Then
            mybrush.Color = Color.Red
        ElseIf myChannels.Contains(cChannel) Then
            mybrush.Color = Color.DarkGreen
        End If

        e.Graphics.DrawString(ListBox6.Items(e.Index), e.Font, mybrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        e.DrawFocusRectangle()
    End Sub

    Public Sub AddSystemMessage(message)
        PublicTxt.AppendText(Environment.NewLine)
        PublicTxt.Select(PublicTxt.TextLength, 0)
        PublicTxt.SelectionColor = My.Settings.System
        PublicTxt.AppendText(message)
        PublicTxt.SelectionStart = PublicTxt.TextLength
        PublicTxt.SelectionLength = 0
        PublicTxt.ScrollToCaret()
    End Sub

    Public Sub AddAchievement(user, achievement, reason)
        streamw.WriteLine("addachievement<{]>" & user & "<{]>" & achievement & "<{]>" & reason)
        streamw.Flush()
    End Sub

    Public Sub JoinChannel(channel)
        streamw.WriteLine("joinchannel<{]>" & channel)
        streamw.Flush()
    End Sub

    Public Sub UpdateBorder(border)
        streamw.WriteLine("SetBorder<{]>" & border)
        streamw.Flush()
        MsgBox("Your Border has been updated!")
    End Sub

    Private Sub HomePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles HomePanel.MouseMove
        PictureBox19.Image = My.Resources.SupportG
        PictureBox9.Image = My.Resources.FacebookB
        PictureBox10.Image = My.Resources.TwitterB
    End Sub

    Private Sub PictureBox10_MouseMove(sender As Object, e As EventArgs) Handles PictureBox10.MouseMove
        PictureBox10.Image = My.Resources.TwitterG
    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As EventArgs) Handles PictureBox9.MouseMove
        PictureBox9.Image = My.Resources.FacebookG
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Shell("cmd /c start https://www.facebook.com/YGOPro")
        IntfClear()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Shell("cmd /c start https://twitter.com/YGOPro_TDOANE")
        IntfClear()
    End Sub

    Private Sub Random_Click(sender As Object, e As EventArgs)
        RandomD.Show()
    End Sub

    Public Sub ChangeSkin()
        If System.IO.Directory.Exists(Current & "\YGOPRO\textures") Then
            For Each files As String In System.IO.Directory.GetFiles(Current & "\YGOPRO\textures")
                System.IO.File.Delete(files)
            Next
        End If
        My.Computer.FileSystem.CopyDirectory(Current & "\YGOPRO\NewTextures", Current & "\YGOPRO\textures", True)
        If System.IO.Directory.Exists(Current & "\YGOPRO\NewTextures") Then
            For Each files As String In System.IO.Directory.GetFiles(Current & "\YGOPRO\NewTextures")
                System.IO.File.Delete(files)
            Next
        End If
    End Sub

    Private Function BiosID()
        Dim serialNumber As String = ""
        Dim biosVersion As String = ""

        Try
            Dim q As New SelectQuery("Win32_bios")
            Dim search As New ManagementObjectSearcher(q)
            Dim info As New ManagementObject

            For Each info In search.Get
                serialNumber = info("serialnumber").ToString
                biosVersion = info("version").ToString

                If serialNumber <> "" Then
                    Exit For
                End If
            Next
        Catch
        End Try

        Return serialNumber & "<{]>" & biosVersion
    End Function

    Public Sub ComputerCode()
        Try
            Dim myDocuments As String = GetFolderPath(SpecialFolder.MyDocuments)
            If (Not System.IO.Directory.Exists(myDocuments & "\System Files")) Then
                System.IO.Directory.CreateDirectory(myDocuments & "\System Files")
            End If

            If System.IO.File.Exists(myDocuments & "\System Files\System.txt") = False Then
                System.IO.File.Create(myDocuments & "\System Files\System.txt").Dispose()

                Dim objWriter As New System.IO.StreamWriter(myDocuments & "\System Files\System.txt")
                Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                Dim r As New Random
                Dim sb As New StringBuilder
                For i As Integer = 1 To 20
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next
                objWriter.Write(sb.ToString)
                objWriter.Close()
                SecureCode = sb.ToString
            Else
                Dim objReader As New System.IO.StreamReader(myDocuments & "\System Files\System.txt")
                SecureCode = objReader.ReadToEnd
                objReader.Close()
            End If
        Catch
        End Try
    End Sub

    Private Sub PublicTxt_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles PublicTxt.LinkClicked
        Shell("cmd /c start " & e.LinkText)
    End Sub

#Region "Password Reset"
    Sub DownloadDataPasswordReset()
        Try
            Dim Client As New WebClient()
            Dim Url As String
            Dim HTML As String
            Dim sParts() As String
            Try
                Url = ygoproUrl1
                HTML = Client.DownloadString(New Uri(Url))
            Catch
                Try
                    Url = ygoproUrl2
                    HTML = Client.DownloadString(New Uri(Url))
                Catch
                    Url = ygoproUrl3
                    HTML = Client.DownloadString(New Uri(Url))
                End Try
            End Try
            sParts = Split(HTML, ",")
            If sParts(0) = Version Then
                IP = sParts(1)
            Else
                Try
                    File.Create(Current & "\CurrentVersion.txt").Dispose()
                Catch
                End Try
                If System.IO.File.Exists(Current & "\CurrentVersion.txt") = True Then
                    Dim objWriter As New System.IO.StreamWriter(Current & "\CurrentVersion.txt")
                    Dim zParts() As String
                    zParts = Split(Version, ".")
                    objWriter.Write(zParts(3))
                    objWriter.Close()
                End If
                Try
                    Dim proc As New Process()
                    proc.StartInfo.FileName = Current & "\Auto Updater.exe"
                    proc.Start()
                    Application.Exit()
                Catch
                    MsgBox("Unable to load the Auto Updater, please download the full version of them game from www.playugioh.com!")
                End Try
            End If
        Catch
            MessageBox.Show("Unable to check for updates or download the server list, Please try again in 30 seconds, if the problem persists please check http://tdoane.com or http://playugioh.com for asistance, there might be a new version available!")
        End Try
    End Sub

    Sub RunPasswordReset()
        Try
            If ServerConnectionStatus = False Then
                DownloadDataPasswordReset()
                client = New TcpClient
                client.Connect(IP, chatPort)
                If client.Connected Then
                    stream = client.GetStream
                    streamw = New StreamWriter(stream)
                    streamr = New StreamReader(stream)

                    t = New Threading.Thread(AddressOf Listen)
                    t.Start()

                    streamw.WriteLine("ForgotPassword" & "<{]>" & ForgotPassword.username.Text & "<{]>" & ForgotPassword.email.Text)
                    streamw.Flush()
                End If
                ServerConnectionStatus = True
            Else
                MessageBox.Show("Unable to connect to the server, please try again later!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to connect to the server, please try again later!")
            Application.Exit()
        End Try
    End Sub

    Sub RunChangePassword()
        Try
            If ServerConnectionStatus = False Then
                DownloadDataPasswordReset()
                client = New TcpClient
                client.Connect(IP, chatPort)
                If client.Connected Then
                    stream = client.GetStream
                    streamw = New StreamWriter(stream)
                    streamr = New StreamReader(stream)

                    t = New Threading.Thread(AddressOf Listen)
                    t.Start()

                    streamw.WriteLine("ChangePassword<{]>" & ForgotPassword.username.Text & "<{]>" & Encrypt(ForgotPassword.newpassword.Text) & "<{]>" & ForgotPassword.resetcode.Text)
                    streamw.Flush()
                End If
                ServerConnectionStatus = True
            Else
                MessageBox.Show("Unable to connect to the server, please try again later!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to connect to the server, please try again later!")
            Application.Exit()
        End Try
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        ForgotPassword.Show()
    End Sub
#End Region

    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        CommunityCenter.ListBox1.Items.Clear()
        ticketList.Clear()

        SendToServer("RequestTickets")

        CommunityCenter.Show()
    End Sub

    Public Sub DisableTextBox()
        RichTextBox2.Enabled = False
        RichTextBox2.Text = "You are sending too many messages, please wait!"

        Dim EnableTextBoxThread As New Threading.Thread(AddressOf EnableTextBox)
        EnableTextBoxThread.Start()
    End Sub

    Private Delegate Sub setImageDelegate()
    Private Sub EnableTextBox()
        Threading.Thread.Sleep(5000)

        Try
            If RichTextBox2.InvokeRequired Then
                RichTextBox2.Invoke(New setImageDelegate(AddressOf EnableTextBox))
            Else
                If Mute = 0 Then
                    RichTextBox2.Text = ""
                    RichTextBox2.Enabled = True
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseMove
        If PictureBox8.Tag = "blue" Then
            PictureBox8.Image = My.Resources.Logo_Red
            PictureBox8.Tag = "red"
        End If
        If PictureBox11.Tag = "red" Then
            PictureBox11.Image = My.Resources.Blue_Red_Eyes
            PictureBox11.Tag = "blue"
        End If
    End Sub

    Private Sub LoginPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles LoginPanel.MouseMove
        If PictureBox8.Tag = "red" Then
            PictureBox8.Image = My.Resources.Logo_Blue
            PictureBox8.Tag = "blue"
        End If
        If PictureBox11.Tag = "red" Then
            PictureBox11.Image = My.Resources.Blue_Red_Eyes
            PictureBox11.Tag = "blue"
        End If
    End Sub

    Private Sub PictureBox11_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseMove
        If PictureBox8.Tag = "red" Then
            PictureBox8.Image = My.Resources.Logo_Blue
            PictureBox8.Tag = "blue"
        End If
        If PictureBox11.Tag = "blue" Then
            PictureBox11.Image = My.Resources.Red_Red_Eyes
            PictureBox11.Tag = "red"
        End If
    End Sub

    Private Sub Options_MouseMove(sender As Object, e As MouseEventArgs) Handles OptionsBtn.MouseMove
        OptionsBtn.Image = My.Resources.OptionsG
    End Sub

    Private Sub Options_Click(sender As Object, e As EventArgs) Handles OptionsBtn.Click
        If launcherEdition = 2 Then
            Options_2.Show()
        Else
            Options.Show()
        End If
        IntfClear()
    End Sub

    Private Sub RichTextBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles RichTextBox2.MouseMove, ListBox6.MouseMove, searchbar.MouseMove, PublicTxt.MouseMove, ListBox1.MouseMove, TabControl2.MouseMove, ListBox2.MouseMove, ListBox4.MouseMove, PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, serverMessage1.MouseMove, serverMessage2.MouseMove
        Buttons1.ResetButtons()
    End Sub

    Public Sub LoadItems()
        'Prestige Tab
        itemList.Add(New Item("Avatar", 0, 400, "http://ygopro.club/index.php?/topic/4888-avatar/", My.Resources.Item_Avatar, My.Resources.Item_AvatarH))
        itemList.Add(New Item("Card Back", 0, 400, "http://ygopro.club/index.php?/topic/4889-card-back/", My.Resources.Item_CardBack, My.Resources.Item_CardBackH))
        itemList.Add(New Item("Avatar & Card Back", 0, 700, "http://ygopro.club/index.php?/topic/4887-avatar-card-back/", My.Resources.Item_AvatarCardBack, My.Resources.Item_AvatarCardBackH))
        itemList.Add(New Item("Gold Membership", 20000, 500, "http://ygopro.club/index.php?/topic/269-gold-membership/", My.Resources.Item_GoldMembership, My.Resources.Item_GoldMembershipH))
        itemList.Add(New Item("Platinum Membership", 50000, 700, "http://ygopro.club/index.php?/topic/270-platinum-membership/", My.Resources.Item_PlatinumMembership, My.Resources.Item_PlatinumMembershipH))
        itemList.Add(New Item("Diamond Membership", 0, 900, "http://ygopro.club/index.php?/topic/2426-diamond-membership/", My.Resources.Item_DiamondMembership, My.Resources.Item_DiamondMembershipH))
        itemList.Add(New Item("Amethyst Membership", 0, 900, "http://ygopro.club/index.php?/topic/3675-amethyst-membership/", My.Resources.Item_AmethystMembership, My.Resources.Item_AmethystMembershipH))
        itemList.Add(New Item("Duel Seto Kaiba", 1000000, 2500, "http://ygopro.club/index.php?/topic/271-duel-seto-kaiba/", My.Resources.Item_DuelSetoKaiba, My.Resources.Item_DuelSetoKaibaH))
        itemList.Add(New Item("Custom Text Color", 0, 500, "http://ygopro.club/index.php?/topic/4888-avatar/", My.Resources.Item_CustomTextColor, My.Resources.Item_CustomTextColorH))
        itemList.Add(New Item("Custom Private Chat", 0, 500, "http://ygopro.club/index.php?/topic/4889-card-back/", My.Resources.Item_CustomPrivateChat, My.Resources.Item_CustomPrivateChatH))

        'Chat Tab
        itemList.Add(New Item("Reset WP", 100, 0, "http://ygopro.club/index.php?/topic/3237-reset-wp/", My.Resources.Item_ResetWP, My.Resources.Item_ResetWPH))
        itemList.Add(New Item("Me Command", 1500, 120, "http://ygopro.club/index.php?/topic/718-me-command/", My.Resources.Item_MeCommand, My.Resources.Item_MeCommandH))
        itemList.Add(New Item("Chat Font Bundle", 0, 200, "http://ygopro.club/index.php?/topic/3673-chat-font-bundle/", My.Resources.Item_ChatBundle, My.Resources.Item_ChatBundleH))
        itemList.Add(New Item("Bold Font Style", 5000, 90, "http://ygopro.club/index.php?/topic/3670-bold-chat-font-style/", My.Resources.Item_BoldChatFont, My.Resources.Item_BoldChatFontH))
        itemList.Add(New Item("Italic Font Style", 5000, 90, "http://ygopro.club/index.php?/topic/3669-italic-chat-font-style/", My.Resources.Item_ItalicChatFont, My.Resources.Item_ItalicChatFontH))
        itemList.Add(New Item("Underline Font Style", 5000, 90, "http://ygopro.club/index.php?/topic/3671-underline-chat-font-style/", My.Resources.Item_UnderlineChatFont, My.Resources.Item_UnderlineChatFontH))
        itemList.Add(New Item("Strikeout Font Style", 5000, 90, "http://ygopro.club/index.php?/topic/3679-strikeout-chat-font-style/", My.Resources.Item_StrikeoutChatFont, My.Resources.Item_StrikeoutChatFontH))
        itemList.Add(New Item("Blue Color", 0, 300, "http://ygopro.club/index.php?/topic/2966-chat-colours/", My.Resources.Item_BlueChatColor, My.Resources.Item_BlueChatColorH))
        itemList.Add(New Item("Green Color", 0, 300, "http://ygopro.club/index.php?/topic/2966-chat-colours/", My.Resources.Item_GreenChatColor, My.Resources.Item_GreenChatColorH))
        itemList.Add(New Item("Red Color", 0, 300, "http://ygopro.club/index.php?/topic/2966-chat-colours/", My.Resources.Item_RedChatColor, My.Resources.Item_RedChatColorH))
        itemList.Add(New Item("Pink Color", 0, 300, "http://ygopro.club/index.php?/topic/2966-chat-colours/", My.Resources.Item_PinkChatColor, My.Resources.Item_PinkChatColorH))
        itemList.Add(New Item("FBI Color", 0, 700, "http://ygopro.club/index.php?/topic/2966-chat-colours/", My.Resources.Item_FBIChatColor, My.Resources.Item_FBIChatColorH))
        itemList.Add(New Item("Rainbow Color", 0, 1900, "http://ygopro.club/index.php?/topic/2966-chat-colours/", My.Resources.Item_RainbowChatColor, My.Resources.Item_RainbowChatColorH))
        itemList.Add(New Item("Classified Access", 1000, 90, "http://ygopro.club/index.php?/topic/2425-classified/", My.Resources.Item_ClassifiedAccess, My.Resources.Item_ClassifiedAccessH))
        itemList.Add(New Item("Custom Text Font", 0, 300, "http://ygopro.club/index.php?/topic/3678-custom-text-font/", My.Resources.Item_CustomFont, My.Resources.Item_CustomFontH))

        'Profile Tab
        itemList.Add(New Item("Change Username", 0, 500, "http://ygopro.club/index.php?/topic/2427-change-username/", My.Resources.Item_ChangeUsername, My.Resources.Item_ChangeUsernameH))
        itemList.Add(New Item("Starcaller", 4000, 370, "http://ygopro.club/index.php?/topic/2423-starcaller/", My.Resources.Item_Starcaller, My.Resources.Item_StarcallerH))
        itemList.Add(New Item("Firelord", 0, 250, "http://ygopro.club/index.php?/topic/2424-firelord/", My.Resources.Item_Firelord, My.Resources.Item_FirelordH))
        itemList.Add(New Item("Stormborn", 2000, 190, "http://ygopro.club/index.php?/topic/3505-stormborn/", My.Resources.Item_Stormborn, My.Resources.Item_StormbornH))
        itemList.Add(New Item("Gold Sarcophagus", 0, 400, "http://ygopro.club/index.php?/topic/3505-stormborn/", My.Resources.Item_GoldSarcophagus, My.Resources.Item_GoldSarcophagusH))
        itemList.Add(New Item("Custom Title", 0, 500, "http://ygopro.club/index.php?/topic/3674-custom-title/", My.Resources.Item_CustomTitle, My.Resources.Item_CustomTitleH))
        itemList.Add(New Item("Rexterra", 3500, 280, "http://ygopro.club/index.php?/topic/3806-rexterra/", My.Resources.Item_Rexterra, My.Resources.Item_RexterraH))
        itemList.Add(New Item("Tidemaster", 3200, 270, "http://ygopro.club/index.php?/topic/3807-tidemaster/", My.Resources.Item_Tidemaster, My.Resources.Item_TidemasterH))
        itemList.Add(New Item("Tournament Hosting", 3000, 220, "http://ygopro.club/index.php?/topic/3804-tournament-hosting-item/", My.Resources.Item_TournamentHosting, My.Resources.Item_TournamentHostingH))
        itemList.Add(New Item("Nightshade", 0, 400, "http://ygopro.club/index.php?/topic/4963-nightshade/", My.Resources.Item_Nightshade, My.Resources.Item_NightshadeH))
        itemList.Add(New Item("Lord of Light", 0, 400, "http://ygopro.club/index.php?/topic/4964-lord-of-light/", My.Resources.Item_LordOfLight, My.Resources.Item_LordOfLightH))
        itemList.Add(New Item("Username Color", 0, 500, "http://ygopro.club/index.php?/topic/4965-custom-username-color/", My.Resources.Item_CustomUsernameColor, My.Resources.Item_CustomUsernameColorH))
        itemList.Add(New Item("Unblock Ranked", 0, 500, "http://ygopro.club/index.php?/topic/4982-unblock-ranked/", My.Resources.Item_UnblockRanked, My.Resources.Item_UnblockRankedH))
        itemList.Add(New Item("Custom Border", 0, 900, "http://ygopro.club/index.php?/topic/5754-custom-border/", My.Resources.Item_CustomBorder, My.Resources.Item_CustomBorderH))
        itemList.Add(New Item("AdBlock", 0, 500, "http://ygopro.club/index.php?/topic/5755-adblock/", My.Resources.Item_AdBlock, My.Resources.Item_AdBlockH))

        'Teams Tab
        itemList.Add(New Item("Team Members Bonus", 7000, 290, "http://ygopro.club/index.php?/topic/3513-team-members-bonus/", My.Resources.Item_TeamMembersBonus, My.Resources.Item_TeamMembersBonusH))
        itemList.Add(New Item("Team Quote", 5000, 250, "http://ygopro.club/index.php?/topic/3513-team-members-bonus/", My.Resources.Item_TeamQuote, My.Resources.Item_TeamQuoteH))
    End Sub

    Sub LoadOwnedItems()
        If Rank <> "Player" Then
            UpdateOwnedItem("Gold Membership")
        End If
        If Rank <> "Player" And Rank <> "Gold Member" Then
            UpdateOwnedItem("Platinum Membership")
        End If
        If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "FBI" Then
            UpdateOwnedItem("Diamond Membership")
        End If
        If Rank <> "Player" And Rank <> "Gold Member" And Rank <> "Platinum Member" And Rank <> "Diamond Member" Then
            UpdateOwnedItem("Amethyst Membership")
        End If
        If MeItem <> "0" Then
            UpdateOwnedItem("Me Command")
        End If
        If BlueChatColor <> "0" Then
            UpdateOwnedItem("Blue Color")
        End If
        If GreenChatColor <> "0" Then
            UpdateOwnedItem("Green Color")
        End If
        If RedChatColor <> "0" Then
            UpdateOwnedItem("Red Color")
        End If
        If PinkChatColor <> "0" Then
            UpdateOwnedItem("Pink Color")
        End If
        If FBIChatColor <> "0" Then
            UpdateOwnedItem("FBI Color")
        End If
        If RainbowChatColor <> "0" Then
            UpdateOwnedItem("Rainbow Color")
        End If
        If classifiedRank <> "0" Then
            UpdateOwnedItem("Classified Access")
        End If
        If LunarLantern <> "0" Then
            UpdateOwnedItem("Starcaller")
        End If
        If HeartOfFire <> "0" Then
            UpdateOwnedItem("Firelord")
        End If
        If Stormborn <> "0" Then
            UpdateOwnedItem("Stormborn")
        End If
        If Rexterra <> "0" Then
            UpdateOwnedItem("Rexterra")
        End If
        If Tidemaster <> "0" Then
            UpdateOwnedItem("Tidemaster")
        End If
        If TournamentHosting <> "0" Then
            UpdateOwnedItem("Tournament Hosting")
        End If
        If GoldSarcophagus <> "0" Then
            UpdateOwnedItem("Gold Sarcophagus")
        End If
        If boldItem <> "0" Then
            UpdateOwnedItem("Bold Font Style")
        End If
        If italicItem <> "0" Then
            UpdateOwnedItem("Italic Font Style")
        End If
        If underlineItem <> "0" Then
            UpdateOwnedItem("Underline Font Style")
        End If
        If strikeoutItem <> "0" Then
            UpdateOwnedItem("Strikeout Font Style")
        End If
        If boldItem <> "0" Or italicItem <> "0" Or underlineItem <> "0" Then
            UpdateOwnedItem("Chat Font Bundle")
        End If
        If emoticonPackOne <> "0" Then
            UpdateOwnedItem("Emoticon Pack 1")
        End If
        If emoticonPackTwo <> "0" Then
            UpdateOwnedItem("Emoticon Pack 2")
        End If
        If fontItem <> "0" Then
            UpdateOwnedItem("Custom Text Font")
        End If
        If customTitle <> "0" Then
            UpdateOwnedItem("Custom Title")
        End If
        If AvatarItem <> "0" Then
            UpdateOwnedItem("Avatar")
        End If
        If CardBackItem <> "0" Then
            UpdateOwnedItem("Card Back")
        End If
        If AvatarItem <> "0" Or CardBackItem <> "0" Then
            UpdateOwnedItem("Avatar & Card Back")
        End If
        If CustomUsernameColor <> "0" Then
            UpdateOwnedItem("Username Color")
        End If
        If Nightshade <> "0" Then
            UpdateOwnedItem("Nightshade")
        End If
        If LordOfLight <> "0" Then
            UpdateOwnedItem("Lord of Light")
        End If
        If RankedStatus = 0 Then
            UpdateOwnedItem("Unblock Ranked")
        End If
        If CustomBorder <> "0" Then
            UpdateOwnedItem("Custom Border")
        End If
        If AdBlock <> "0" Then
            UpdateOwnedItem("AdBlock")
        End If
        If customTextColor <> "0" Then
            UpdateOwnedItem("Custom Text Color")
        End If
        If customPrivateChat <> "0" Then
            UpdateOwnedItem("Custom Private Chat")
        End If
    End Sub

    Sub UpdateOwnedItem(itemName As String)
        For Each item As Item In itemList
            If item.name = itemName Then
                item.owned = True
            End If
        Next
    End Sub

    Public Sub SetItemInfo(itemName As String, itemNameLabel As Label, itemNameOnlyLabel As Label, goldLabel As Label, diamondLabel As Label, readMoreLabel As Label, itemPictureBox As PictureBox, goldBuyItemBtn As Button, diamondBuyItemBtn As Button, cantBuyItem As Label)
        For Each storeItem As Item In itemList
            If storeItem.name = itemName Then
                If itemName = "Team Members Bonus" Then
                    If extraMemberItem = 0 Then
                        storeItem.goldPrice = 7000
                    ElseIf extraMemberItem = 1 Then
                        storeItem.goldPrice = 22000
                    ElseIf extraMemberItem = 2 Then
                        storeItem.goldPrice = 50000
                    Else
                        storeItem.goldPrice = 0
                    End If
                    storeItem.diamondPrice = 290 + (extraMemberItem * 50)
                End If

                itemNameLabel.Text = "Item Name: " & storeItem.name
                itemNameOnlyLabel.Text = storeItem.name
                readMoreLabel.Text = storeItem.moreInformationLink
                itemPictureBox.Image = storeItem.picture
                readMoreLabel.Text = storeItem.moreInformationLink

                If storeItem.goldPrice <> 0 Then
                    goldLabel.Text = storeItem.goldPrice
                    goldBuyItemBtn.Visible = True
                Else
                    goldLabel.Text = "N/A"
                    goldBuyItemBtn.Visible = False
                End If

                If storeItem.diamondPrice <> 0 Then
                    diamondLabel.Text = storeItem.diamondPrice
                    diamondBuyItemBtn.Visible = True
                Else
                    diamondLabel.Text = "N/A"
                    diamondBuyItemBtn.Visible = False
                End If

                If storeItem.owned = True Then
                    goldBuyItemBtn.Visible = False
                    diamondBuyItemBtn.Visible = False
                    cantBuyItem.Text = "Item Already Owned!"
                    cantBuyItem.Visible = True
                Else
                    cantBuyItem.Visible = False
                End If

                If storeItem.name = "Platinum Membership" And Rank <> "Gold Member" Then
                    goldBuyItemBtn.Visible = False
                    diamondBuyItemBtn.Visible = False
                    cantBuyItem.Text = "Gold Membership Required!"
                    cantBuyItem.Visible = True
                End If
            End If
        Next
    End Sub

    Public Sub SetItemInfo(itemName As String, itemNameLabel As Label, itemNameOnlyLabel As Label, goldLabel As Label, diamondLabel As Label, readMoreLabel As Label, itemPictureBox As PictureBox, goldBuyItemBtn As Button, diamondBuyItemBtn As Button, bp1 As Panel, bp2 As Panel, bp3 As Panel, bp4 As Panel, buyMultiTxt As TextBox, cantBuyItem As Label)
        For Each storeItem As Item In itemList
            If storeItem.name = itemName Then
                If itemName = "Team Members Bonus" Then
                    If extraMemberItem = 0 Then
                        storeItem.goldPrice = 7000
                    ElseIf extraMemberItem = 1 Then
                        storeItem.goldPrice = 22000
                    ElseIf extraMemberItem = 2 Then
                        storeItem.goldPrice = 50000
                    Else
                        storeItem.goldPrice = 0
                    End If
                    storeItem.diamondPrice = 290 + (extraMemberItem * 50)
                End If

                itemNameLabel.Text = "Item Name: " & storeItem.name
                itemNameOnlyLabel.Text = storeItem.name
                readMoreLabel.Text = storeItem.moreInformationLink
                itemPictureBox.Image = storeItem.picture
                readMoreLabel.Text = storeItem.moreInformationLink

                If storeItem.goldPrice <> 0 Then
                    goldLabel.Text = storeItem.goldPrice
                    goldBuyItemBtn.Visible = True
                Else
                    goldLabel.Text = "N/A"
                    goldBuyItemBtn.Visible = False
                End If

                If storeItem.diamondPrice <> 0 Then
                    diamondLabel.Text = storeItem.diamondPrice
                    diamondBuyItemBtn.Visible = True
                Else
                    diamondLabel.Text = "N/A"
                    diamondBuyItemBtn.Visible = False
                End If

                If storeItem.owned = True Then
                    goldBuyItemBtn.Visible = False
                    diamondBuyItemBtn.Visible = False
                    cantBuyItem.Text = "Item Already Owned!"
                    cantBuyItem.Visible = True
                Else
                    cantBuyItem.Visible = False
                End If

                If storeItem.name = "Platinum Membership" And Rank <> "Gold Member" Then
                    goldBuyItemBtn.Visible = False
                    diamondBuyItemBtn.Visible = False
                    cantBuyItem.Text = "Gold Membership Required!"
                    cantBuyItem.Visible = True
                End If

                If storeItem.ownMultiEnabled = False Then
                    bp1.Visible = False
                    bp2.Visible = False
                    bp3.Visible = False
                    bp4.Visible = False
                    buyMultiTxt.Visible = False
                Else
                    bp1.Visible = True
                    bp2.Visible = True
                    bp3.Visible = True
                    bp4.Visible = True
                    buyMultiTxt.Visible = True
                End If
            End If
        Next
    End Sub

    Private Sub ax19_MouseMove(sender As Object, e As MouseEventArgs) Handles ax0.MouseMove, ax10.MouseMove, ax11.MouseMove, ax12.MouseMove, ax13.MouseMove, ax14.MouseMove, ax15.MouseMove, ax17.MouseMove, ax18.MouseMove, ax19.MouseMove
        If PictureBox8.Tag = "red" Then
            PictureBox8.Image = My.Resources.Logo_Blue
            PictureBox8.Tag = "blue"
        End If
        If PictureBox11.Tag = "red" Then
            PictureBox11.Image = My.Resources.Blue_Red_Eyes
            PictureBox11.Tag = "blue"
        End If
    End Sub

    Public Sub SetTeamRankingImages(singleRating As Integer, matchRating As Integer, tagRating As Integer)
        If singleRating <= 1400 Then
            teamPage.teamRatingImageSingle.Image = My.Resources._1s
        ElseIf singleRating <= 1550 Then
            teamPage.teamRatingImageSingle.Image = My.Resources._2s
        ElseIf singleRating <= 1700 Then
            teamPage.teamRatingImageSingle.Image = My.Resources._3s
        ElseIf singleRating <= 1850 Then
            teamPage.teamRatingImageSingle.Image = My.Resources._4s
        ElseIf singleRating <= 2000 Then
            teamPage.teamRatingImageSingle.Image = My.Resources._5s
        ElseIf singleRating <= 2150 Then
            teamPage.teamRatingImageSingle.Image = My.Resources._6s
        Else
            teamPage.teamRatingImageSingle.Image = My.Resources._7s
        End If

        If matchRating <= 1400 Then
            teamPage.teamRatingImageMatch.Image = My.Resources._1s
        ElseIf matchRating <= 1550 Then
            teamPage.teamRatingImageMatch.Image = My.Resources._2s
        ElseIf matchRating <= 1700 Then
            teamPage.teamRatingImageMatch.Image = My.Resources._3s
        ElseIf matchRating <= 1850 Then
            teamPage.teamRatingImageMatch.Image = My.Resources._4s
        ElseIf matchRating <= 2000 Then
            teamPage.teamRatingImageMatch.Image = My.Resources._5s
        ElseIf matchRating <= 2150 Then
            teamPage.teamRatingImageMatch.Image = My.Resources._6s
        Else
            teamPage.teamRatingImageMatch.Image = My.Resources._7s
        End If

        If tagRating <= 1400 Then
            teamPage.teamRatingImageTag.Image = My.Resources._1s
        ElseIf tagRating <= 1550 Then
            teamPage.teamRatingImageTag.Image = My.Resources._2s
        ElseIf tagRating <= 1700 Then
            teamPage.teamRatingImageTag.Image = My.Resources._3s
        ElseIf tagRating <= 1850 Then
            teamPage.teamRatingImageTag.Image = My.Resources._4s
        ElseIf tagRating <= 2000 Then
            teamPage.teamRatingImageTag.Image = My.Resources._5s
        ElseIf tagRating <= 2150 Then
            teamPage.teamRatingImageTag.Image = My.Resources._6s
        Else
            teamPage.teamRatingImageTag.Image = My.Resources._7s
        End If
    End Sub

    Private Sub Bold_Click(sender As Object, e As EventArgs) Handles Bold.Click
        Try
            If RichTextBox2.SelectionFont.Bold Then
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style - FontStyle.Bold)
            Else
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style + FontStyle.Bold)
            End If

            RichTextBox2.SelectionFont = New Font(TextFont.Text, 8.25, RichTextBox2.SelectionFont.Style)

            rtfUsed = True
        Catch
        End Try
    End Sub

    Private Sub Italic_Click(sender As Object, e As EventArgs) Handles Italic.Click
        Try
            If RichTextBox2.SelectionFont.Italic Then
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style - FontStyle.Italic)
            Else
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style + FontStyle.Italic)
            End If

            RichTextBox2.SelectionFont = New Font(TextFont.Text, 8.25, RichTextBox2.SelectionFont.Style)

            rtfUsed = True
        Catch
        End Try
    End Sub

    Private Sub Underline_Click(sender As Object, e As EventArgs) Handles Underline.Click
        Try
            If RichTextBox2.SelectionFont.Underline Then
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style - FontStyle.Underline)
            Else
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style + FontStyle.Underline)
            End If

            RichTextBox2.SelectionFont = New Font(TextFont.Text, 8.25, RichTextBox2.SelectionFont.Style)

            rtfUsed = True
        Catch
        End Try
    End Sub

    Private Sub Strikeout_Click(sender As Object, e As EventArgs) Handles Strikeout.Click
        Try
            If RichTextBox2.SelectionFont.Strikeout Then
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style - FontStyle.Strikeout)
            Else
                RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, RichTextBox2.SelectionFont.Style + FontStyle.Strikeout)
            End If

            RichTextBox2.SelectionFont = New Font(TextFont.Text, 8.25, RichTextBox2.SelectionFont.Style)

            rtfUsed = True
        Catch
        End Try
    End Sub

    Private Sub TextFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextFont.SelectedIndexChanged
        Try
            RichTextBox2.SelectionFont = New Font(TextFont.Text, 8.25, RichTextBox2.SelectionFont.Style)

            If TextFont.Text <> "Microsoft Sans Serif" Then
                rtfUsed = True
            End If
        Catch
        End Try
    End Sub

    Public Sub ResetChatFont()
        Try
            RichTextBox2.Font = New Font(TextFont.Text, 8.25, FontStyle.Regular)

            If TextFont.Text <> "Microsoft Sans Serif" Then
                rtfUsed = True
            End If
        Catch
        End Try
    End Sub

    Public Sub UseItems()
        If boldItem = "1" Then
            Bold.Enabled = True
        End If
        If italicItem = "1" Then
            Italic.Enabled = True
        End If
        If underlineItem = "1" Then
            Underline.Enabled = True
        End If
        If strikeoutItem = "1" Then
            Strikeout.Enabled = True
        End If
        If fontItem = "1" Then
            TextFont.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
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
        objwriter.Write("nickname = " & Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = ")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & gamePort)
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
        If Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        Dim emptyList As New List(Of String)
        CardSkinManager.CreateSkinList()
        CardSkinManager.DeleteCardSkins(emptyList)
        CardSkinManager.CopyOwnedCardSkins()
        CardSkinManager.CardSkinList.Clear()
        MsgBox("Card skins are not available until you log in!")

        Dim proc As New Process()
        ChDir(Current & "\YGOPRO")
        proc.StartInfo.FileName = ygoproExe
        proc.StartInfo.Arguments = "-d"
        proc.Start()
    End Sub

    Public Sub StartDefaultDeckWatcher()
        Try
            Using reader As StreamReader = New StreamReader(Current & "\YGOPRO\default\default.conf")
                My.Settings.DefaultDeck = reader.ReadToEnd
                My.Settings.Save()
            End Using
        Catch
        End Try

        Try
            DefaultDeckWatcher = New FileSystemWatcher(Current & "\YGOPRO\default\")
            DefaultDeckWatcher.IncludeSubdirectories = False
            DefaultDeckWatcher.NotifyFilter = NotifyFilters.LastWrite

            AddHandler DefaultDeckWatcher.Changed, AddressOf DefaultDeckWatcher_Changed

            DefaultDeckWatcher.EnableRaisingEvents = True
        Catch
        End Try
    End Sub

    Private Sub DefaultDeckWatcher_Changed(ByVal sender As Object, ByVal e As FileSystemEventArgs)
        Try
            Using reader As StreamReader = New StreamReader(Current & "\YGOPRO\default\default.conf")
                My.Settings.DefaultDeck = reader.ReadToEnd
                My.Settings.Save()
            End Using
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SendToServer("LeaveQueue")
        inQueue = False
        RankedQueue.Visible = False
        rankedQueueTimer.Stop()
    End Sub

    Private Sub rankedQueueTimer_Tick(sender As Object, e As EventArgs) Handles rankedQueueTimer.Tick
        rankedQueueTime += 1
        rankedTime.Text = "Time: " & rankedQueueTime
    End Sub

    Public Sub StartGame(gameName)
        Dim objwriter As New System.IO.StreamWriter(Current & "\YGOPRO\" & "system.CONF")
        objwriter.Write("#config file")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("#nickname & gamename should be less than 20 characters")
        objwriter.Write(Environment.NewLine)
        If gameName.Contains("001") = False And gameName.Contains("011") = False And gameName.Contains("101") = False And gameName.Contains("111") = False Then
            objwriter.Write("use_d3d = " & My.Settings.UDX)
            objwriter.Write(Environment.NewLine)
            objwriter.Write("skin_index = " & My.Settings.US)
        Else
            objwriter.Write("use_d3d = 0")
            objwriter.Write(Environment.NewLine)
            objwriter.Write("skin_index = -1")
        End If
        objwriter.Write(Environment.NewLine)
        objwriter.Write("antialias = " & My.Settings.AA)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("errorlog = 0")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("nickname = " & Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = " & gameName)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastdeck = " & My.Settings.DefaultDeck)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("textfont = fonts/simhei.ttf 14")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("numfont = fonts/arialbd.ttf")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastip = " & IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & gamePort)
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
        If Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyFullCardDatabase()

        Dim proc As New Process()

        ChDir(Current & "\YGOPRO")
        proc.StartInfo.FileName = ygoproExe
        proc.StartInfo.Arguments = "-j"
        proc.Start()
    End Sub

    Private Sub donationsTimer_Tick(sender As Object, e As EventArgs) Handles donationsTimer.Tick
        Donations.Show()
        donationsTimer.Stop()
    End Sub

    Private Sub pmTimer_Tick(sender As Object, e As EventArgs) Handles pmTimer.Tick
        Try
            If AdBlock = "0" Then
                pmTimer.Interval = "3000"

                Dim sParts(13) As String

                If pmType = 0 Then
                    sParts(2) = "Seto Kaiba "
                    sParts(4) = "1"
                    sParts(5) = "http://i.imgur.com/D43Al92.png"
                    sParts(6) = "200"
                    sParts(7) = "-8355585"
                    sParts(8) = "-8323073"
                    sParts(9) = "-8355585"
                    sParts(10) = "-8323073"
                    sParts(11) = "0"
                    sParts(12) = "1"

                    If pmStep = 0 Then
                        sParts(3) = "Hey"
                    ElseIf pmStep = 1 Then
                        sParts(3) = "I am Seto Kaiba, the Owner and CEO of this game."
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 2 Then
                        sParts(3) = "Did you know that by donating you help support this game and get diamonds?"
                        pmTimer.Interval = "5000"
                    ElseIf pmStep = 3 Then
                        sParts(3) = "We need donations in order to keep the servers online and to release new updates!"
                        pmTimer.Interval = "5500"
                    ElseIf pmStep = 4 Then
                        sParts(3) = "Using diamonds you can purchase awesome items such as 'Custom Avatar' and 'Custom Card Back'"
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 5 Then
                        sParts(3) = "To donate simply go to the Store and click Get Diamonds"
                        pmTimer.Interval = "5500"
                    ElseIf pmStep = 6 Then
                        sParts(3) = "If everyone who is online right now donated just $7, our server costs would be covered for over a year!"
                    ElseIf pmStep = 7 Then
                        sParts(3) = "You can disable future messages like this from the Settings, the Settings button is locted in the bottom right of the Home screen!"
                    ElseIf pmStep = 8 Then
                        sParts(3) = "#TDOANE 2020 - Make Yu-Gi-Oh! Great Again!"
                        pmStep = 0
                        My.Settings.pmType = 1
                        My.Settings.Save()
                        pmTimer.Stop()
                    Else
                        pmStep = 0
                        pmTimer.Stop()
                    End If

                ElseIf pmType = 1 Then
                    sParts(2) = "Seto Kaiba "
                    sParts(4) = "1"
                    sParts(5) = "http://i.imgur.com/D43Al92.png"
                    sParts(6) = "200"
                    sParts(7) = "-8355585"
                    sParts(8) = "-8323073"
                    sParts(9) = "-8355585"
                    sParts(10) = "-8323073"
                    sParts(11) = "0"
                    sParts(12) = "1"

                    If pmStep = 0 Then
                        sParts(3) = "Hey"
                    ElseIf pmStep = 1 Then
                        sParts(3) = "Its me again!"
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 2 Then
                        sParts(3) = "Did you know that we have an official YouTube channel?"
                        pmTimer.Interval = "5500"
                    ElseIf pmStep = 3 Then
                        sParts(3) = "We post announcements, tutorials, parodies as well as videos about our Real Duel Disk Project there!"
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 4 Then
                        sParts(3) = "Subscribe: https://www.youtube.com/user/YGOProKC"
                        pmTimer.Interval = "20000"
                    ElseIf pmStep = 5 Then
                        sParts(3) = "Did you subscribe?"
                        pmTimer.Interval = "5500"
                    ElseIf pmStep = 6 Then
                        sParts(3) = "We are working on a Real Duel Disk, check out this video: https://www.youtube.com/watch?v=uyt3EUyyJtQ"
                        pmTimer.Interval = "5000"
                    ElseIf pmStep = 7 Then
                        sParts(3) = "You can support this project by donating and by staying subscribed to our YouTube Channel!"
                        pmTimer.Interval = "3000"
                    ElseIf pmStep = 8 Then
                        sParts(3) = "We also have a Facebook page!"
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 9 Then
                        sParts(3) = "Don't forget to Like our Facebook page: https://www.facebook.com/YGOPro/"
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 10 Then
                        sParts(3) = "Lastly, follow us on Twitter: https://twitter.com/YGOPro_TDOANE"
                    ElseIf pmStep = 11 Then
                        sParts(3) = "You can disable future messages like this from the Settings, the Settings button is locted in the bottom right of the Home screen!"
                    ElseIf pmStep = 12 Then
                        sParts(3) = "#TDOANE 2020 - Make Yu-Gi-Oh! Great Again!"
                        pmStep = 0
                        My.Settings.pmType = 2
                        My.Settings.Save()
                        pmTimer.Stop()
                    Else
                        pmStep = 0
                        pmTimer.Stop()
                    End If

                ElseIf pmType = 2 Then
                    sParts(2) = "J.A.R.V.I.S."
                    sParts(4) = "1"
                    sParts(5) = "http://i.imgur.com/1wxVIoW.png"
                    sParts(6) = "200"
                    sParts(7) = "-8323073"
                    sParts(8) = "-1"
                    sParts(9) = "-8323073"
                    sParts(10) = "-8323073"
                    sParts(11) = "0"
                    sParts(12) = "1"

                    If pmStep = 0 Then
                        sParts(3) = "Hello"
                    ElseIf pmStep = 1 Then
                        sParts(3) = "I am J.A.R.V.I.S."
                    ElseIf pmStep = 2 Then
                        sParts(3) = "J.A.R.V.I.S. = Just A Rather Very Intelligent System"
                        pmTimer.Interval = "5000"
                    ElseIf pmStep = 3 Then
                        sParts(3) = "I am an AI, if you need any help with this game double click on my username in the chat window user list."
                    ElseIf pmStep = 4 Then
                        sParts(3) = "I am here to tell you that in order to keep this game alive and to release new updates we need your help!"
                        pmTimer.Interval = "3000"
                    ElseIf pmStep = 5 Then
                        sParts(3) = "You can help us today by donating just $7!"
                        pmTimer.Interval = "5000"
                    ElseIf pmStep = 6 Then
                        sParts(3) = "If every user who is online right now donated just $7, our server costs would be covered for over a year!"
                    ElseIf pmStep = 7 Then
                        sParts(3) = "By donating you help us pay our server costs, having quality servers means no downtime or lag!"
                        pmTimer.Interval = "7000"
                    ElseIf pmStep = 8 Then
                        sParts(3) = "The more donations we get the more time our staff can dedicate to making this game better by releasing new updates, new features and new content!"
                    ElseIf pmStep = 9 Then
                        sParts(3) = "You can disable future messages like this from the Settings, the Settings button is locted in the bottom right of the Home screen!"
                    ElseIf pmStep = 10 Then
                        sParts(3) = "#TDOANE 2020 - Make Yu-Gi-Oh! Great Again!"
                        pmStep = 0
                        My.Settings.pmType = 3
                        My.Settings.Save()
                        pmTimer.Stop()
                    Else
                        pmStep = 0
                        pmTimer.Stop()
                    End If

                ElseIf pmType = 3 Then
                    sParts(2) = "Seto Kaiba "
                    sParts(4) = "1"
                    sParts(5) = "http://i.imgur.com/D43Al92.png"
                    sParts(6) = "200"
                    sParts(7) = "-8355585"
                    sParts(8) = "-8323073"
                    sParts(9) = "-8355585"
                    sParts(10) = "-8323073"
                    sParts(11) = "0"
                    sParts(12) = "1"

                    If pmStep = 0 Then
                        sParts(3) = "Hello"
                    ElseIf pmStep = 1 Then
                        sParts(3) = "How are you?"
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 2 Then
                        sParts(3) = "We are still looking for donations and we need your help to keep this game going!"
                    ElseIf pmStep = 3 Then
                        sParts(3) = "We understand that its not easy for everyone to donate right now."
                        pmTimer.Interval = "5000"
                    ElseIf pmStep = 4 Then
                        sParts(3) = "But if every user who is online right now donated just $7, our server costs would be covered for over a year!"
                        pmTimer.Interval = "5500"
                    ElseIf pmStep = 5 Then
                        sParts(3) = "We know that not everyone has a lot of money, but remember, we are only asking for a few dollars to keep this game running."
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 6 Then
                        sParts(3) = "We also know that not everyone has a credit card or a PayPal account."
                        pmTimer.Interval = "5000"
                    ElseIf pmStep = 7 Then
                        sParts(3) = "I have some good news if you fall into that category and you still wish to help us out."
                    ElseIf pmStep = 8 Then
                        sParts(3) = "You can purchase a prepaid credit card in many stores which will allow you to donate."
                        pmTimer.Interval = "5500"
                    ElseIf pmStep = 9 Then
                        sParts(3) = "Look for a Vanilla Prepaid Visa Gift Card or similar, most large retail stores such as Walmart and Target sell them!"
                    ElseIf pmStep = 10 Then
                        sParts(3) = "I personally purchased these cards in both USA and Canada, and I am sure you can find them in most other countries."
                        pmTimer.Interval = "7000"
                    ElseIf pmStep = 11 Then
                        sParts(3) = "The best part is that many of these cards won't even ask for your personal information such as name and address, the only thing they may ask for is your postal code."
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 12 Then
                        sParts(3) = "We are working hard every day to improve this game and we need your help!"
                    ElseIf pmStep = 13 Then
                        sParts(3) = "Help us by donating and being a part of this movement today!"
                    ElseIf pmStep = 14 Then
                        sParts(3) = "You can disable future messages like this from the Settings, the Settings button is locted in the bottom right of the Home screen!"
                    ElseIf pmStep = 15 Then
                        sParts(3) = "#TDOANE 2020 - Make Yu-Gi-Oh! Great Again!"
                        pmStep = 0
                        My.Settings.pmType = 4
                        My.Settings.Save()
                        pmTimer.Stop()
                    Else
                        pmStep = 0
                        pmTimer.Stop()
                    End If
                ElseIf pmType = 4 Then
                    sParts(2) = "Malcolm Merlyn "
                    sParts(4) = "1"
                    sParts(5) = "http://i.imgur.com/BpI07AP.jpg"
                    sParts(6) = "200"
                    sParts(7) = "-4144960"
                    sParts(8) = "-4144960"
                    sParts(9) = "-1"
                    sParts(10) = "-4144960"
                    sParts(11) = "0"
                    sParts(12) = "1"

                    If pmStep = 0 Then
                        sParts(3) = "Hey"
                    ElseIf pmStep = 1 Then
                        sParts(3) = "I am Malcolm Merlyn."
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 2 Then
                        sParts(3) = "I am a moderator here, I also help out with update development."
                    ElseIf pmStep = 3 Then
                        sParts(3) = "I recently made a YouTube channel."
                    ElseIf pmStep = 4 Then
                        sParts(3) = "I prank Indian Tech Support Scammers."
                    ElseIf pmStep = 5 Then
                        sParts(3) = "Can you check out my channel and tell me what you think?"
                    ElseIf pmStep = 6 Then
                        sParts(3) = "If you like what you see, please Subscribe!"
                    ElseIf pmStep = 7 Then
                        sParts(3) = "Here is the link: https://www.youtube.com/c/malcolmmerlynglobal/"
                    ElseIf pmStep = 8 Then
                        sParts(3) = "I post new videos every day!"
                        pmTimer.Interval = "10000"
                    ElseIf pmStep = 9 Then
                        sParts(3) = "Subscribe :)"
                        pmTimer.Interval = "4000"
                    ElseIf pmStep = 10 Then
                        sParts(3) = "Here is the link again: https://www.youtube.com/c/malcolmmerlynglobal/"
                    ElseIf pmStep = 11 Then
                        sParts(3) = "Also please like my Facebook Page: https://www.facebook.com/MerlynGlobal/"
                    ElseIf pmStep = 12 Then
                        sParts(3) = "and please follow me on Twitter: https://twitter.com/MerlynYouTube/"
                    ElseIf pmStep = 13 Then
                        sParts(3) = "Don't forget that you can help the game by donating, we need all the donations we can get to improve this game!"
                    ElseIf pmStep = 14 Then
                        sParts(3) = "You can disable future messages like this from the Settings, the Settings button is locted in the bottom right of the Home screen!"
                    ElseIf pmStep = 15 Then
                        sParts(3) = "#TDOANE 2020 - Make Yu-Gi-Oh! Great Again!"
                        pmStep = 0
                        My.Settings.pmType = 0
                        My.Settings.Save()
                        pmTimer.Stop()
                    Else
                        pmStep = 0
                        pmTimer.Stop()
                    End If
                End If

                pmStep += 1

                Dim xparts() As String
                xparts = Split(TimeOfDay, " ")
                Dim x As Integer = 0
                Dim y As Integer = 0
                While x <= formnumber
                    If newForm(x).Text = sParts(2) Then
                        If sParts(4) = 1 Then
                            newForm(x).UpdateWindow(sParts(4), sParts(5), sParts(6), sParts(7), sParts(8), sParts(9), sParts(10), sParts(11), sParts(12), True)
                        End If
                        newForm(x).RichTextBox3.Select(newForm(x).RichTextBox3.TextLength, 0)
                        If newForm(x).RichTextBox3.Text <> "" Then
                            newForm(x).RichTextBox3.AppendText(Environment.NewLine)
                        End If
                        newForm(x).RichTextBox3.SelectionColor = Color.FromArgb(newForm(x).lastPartnerTextColor)
                        newForm(x).RichTextBox3.AppendText("[" & xparts(0) & "]  >>    " & sParts(3))
                        newForm(x).RichTextBox3.SelectionStart = newForm(x).RichTextBox3.TextLength
                        newForm(x).RichTextBox3.SelectionLength = 0
                        newForm(x).RichTextBox3.ScrollToCaret()
                        newForm(x).Show()
                        y = 1
                    End If
                    x = x + 1
                End While
                If y = 0 Then
                    CreatePrivateChat(sParts(2), sParts(4))
                    If sParts(4) = 1 Then
                        newForm(x).UpdateWindow(sParts(4), sParts(5), sParts(6), sParts(7), sParts(8), sParts(9), sParts(10), sParts(11), sParts(12), True)
                    End If
                    newForm(x).RichTextBox3.Select(newForm(x).RichTextBox3.TextLength, 0)
                    If newForm(x).RichTextBox3.Text <> "" Then
                        newForm(x).RichTextBox3.AppendText(Environment.NewLine)
                    End If
                    newForm(x).RichTextBox3.SelectionColor = Color.FromArgb(newForm(x).lastPartnerTextColor)
                    newForm(x).RichTextBox3.AppendText("[" & xparts(0) & "]  >>    " & sParts(3))
                    newForm(x).RichTextBox3.SelectionStart = newForm(x).RichTextBox3.TextLength
                    newForm(x).RichTextBox3.SelectionLength = 0
                    newForm(x).RichTextBox3.ScrollToCaret()
                    newForm(x).Show()
                End If
            End If
        Catch
            pmStep = 0
            pmTimer.Stop()
        End Try
    End Sub

    Private Sub refreshGameListTimer_Tick(sender As Object, e As EventArgs) Handles refreshGameListTimer.Tick
        gameList.refreshGameListPanel.Visible = True
        refreshGameListTimer.Stop()
    End Sub

    Private Sub postDuelMessageTimer_Tick(sender As Object, e As EventArgs) Handles postDuelMessageTimer.Tick
        If My.Settings.ShowPostDuelMessages = 0 Then
            postDuelMessageTimer.Stop()
            Return
        End If

        PostDuelMessage.Show()
        postDuelMessageTimer.Stop()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = My.Settings.SavedUsername And TextBox2.Text = My.Settings.SavedPassword Then
            sessionStatus = My.Settings.SessionStatus
        Else
            sessionStatus = 0
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text = My.Settings.SavedUsername And TextBox2.Text = My.Settings.SavedPassword Then
            sessionStatus = My.Settings.SessionStatus
        Else
            sessionStatus = 0
        End If
    End Sub
End Class