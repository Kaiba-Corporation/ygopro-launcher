<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameList))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.banlistCmBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gameModeCmBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.duelTypeCmBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.playersTxt = New System.Windows.Forms.TextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.hidePanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gameNameLabel = New System.Windows.Forms.Label()
        Me.playerslabel = New System.Windows.Forms.Label()
        Me.additionalRulesLabel = New System.Windows.Forms.Label()
        Me.joinBtn = New System.Windows.Forms.Button()
        Me.hostedByLabel = New System.Windows.Forms.Label()
        Me.banlistLabel = New System.Windows.Forms.Label()
        Me.gameModeLabel = New System.Windows.Forms.Label()
        Me.duelTypeLabel = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hostBtn = New System.Windows.Forms.Button()
        Me.randomDuelBtn = New System.Windows.Forms.Button()
        Me.gameCount = New System.Windows.Forms.Label()
        Me.FilterActiveGames = New System.Windows.Forms.CheckBox()
        Me.GameListView = New System.Windows.Forms.ListView()
        Me.GameName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MasterRules = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banlist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Host = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.duelBtn = New System.Windows.Forms.Button()
        Me.rankedQueue = New System.Windows.Forms.Panel()
        Me.moreInfo = New System.Windows.Forms.Button()
        Me.ExtendedSearch = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ocgTag = New System.Windows.Forms.Button()
        Me.ocgSingle = New System.Windows.Forms.Button()
        Me.ocgMatch = New System.Windows.Forms.Button()
        Me.tcgTag = New System.Windows.Forms.Button()
        Me.tcgSingle = New System.Windows.Forms.Button()
        Me.tcgMatch = New System.Windows.Forms.Button()
        Me.Buttons1 = New YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons()
        Me.refreshGameListPanel = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel14.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.hidePanel.SuspendLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.rankedQueue.SuspendLayout()
        Me.refreshGameListPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(569, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = "Sort:"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.banlistCmBox)
        Me.Panel14.Controls.Add(Me.Label10)
        Me.Panel14.Controls.Add(Me.gameModeCmBox)
        Me.Panel14.Controls.Add(Me.Label9)
        Me.Panel14.Controls.Add(Me.duelTypeCmBox)
        Me.Panel14.Controls.Add(Me.Label6)
        Me.Panel14.Controls.Add(Me.Label5)
        Me.Panel14.Controls.Add(Me.Panel44)
        Me.Panel14.Controls.Add(Me.Panel45)
        Me.Panel14.Controls.Add(Me.Panel46)
        Me.Panel14.Controls.Add(Me.Panel47)
        Me.Panel14.Controls.Add(Me.playersTxt)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Controls.Add(Me.Panel17)
        Me.Panel14.Controls.Add(Me.Panel18)
        Me.Panel14.Location = New System.Drawing.Point(572, 312)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(335, 78)
        Me.Panel14.TabIndex = 265
        '
        'banlistCmBox
        '
        Me.banlistCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.banlistCmBox.FormattingEnabled = True
        Me.banlistCmBox.Items.AddRange(New Object() {"All", "TCG", "OCG", "Traditional", "No Banlist"})
        Me.banlistCmBox.Location = New System.Drawing.Point(49, 39)
        Me.banlistCmBox.Name = "banlistCmBox"
        Me.banlistCmBox.Size = New System.Drawing.Size(90, 21)
        Me.banlistCmBox.TabIndex = 270
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Cyan
        Me.Label10.Location = New System.Drawing.Point(6, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 271
        Me.Label10.Text = "Banlist:"
        '
        'gameModeCmBox
        '
        Me.gameModeCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gameModeCmBox.FormattingEnabled = True
        Me.gameModeCmBox.Items.AddRange(New Object() {"All", "TCG/OCG", "TCG", "OCG"})
        Me.gameModeCmBox.Location = New System.Drawing.Point(237, 8)
        Me.gameModeCmBox.Name = "gameModeCmBox"
        Me.gameModeCmBox.Size = New System.Drawing.Size(91, 21)
        Me.gameModeCmBox.TabIndex = 268
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(166, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 269
        Me.Label9.Text = "Game Mode:"
        '
        'duelTypeCmBox
        '
        Me.duelTypeCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.duelTypeCmBox.FormattingEnabled = True
        Me.duelTypeCmBox.Items.AddRange(New Object() {"All", "Single", "Match", "Tag"})
        Me.duelTypeCmBox.Location = New System.Drawing.Point(68, 8)
        Me.duelTypeCmBox.Name = "duelTypeCmBox"
        Me.duelTypeCmBox.Size = New System.Drawing.Size(81, 21)
        Me.duelTypeCmBox.TabIndex = 260
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(6, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 267
        Me.Label6.Text = "Duel Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(162, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Player:"
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.Cyan
        Me.Panel44.Location = New System.Drawing.Point(327, 39)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(1, 19)
        Me.Panel44.TabIndex = 252
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.Cyan
        Me.Panel45.Location = New System.Drawing.Point(205, 39)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(1, 19)
        Me.Panel45.TabIndex = 251
        '
        'Panel46
        '
        Me.Panel46.BackColor = System.Drawing.Color.Cyan
        Me.Panel46.Location = New System.Drawing.Point(206, 57)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(122, 1)
        Me.Panel46.TabIndex = 250
        '
        'Panel47
        '
        Me.Panel47.BackColor = System.Drawing.Color.Cyan
        Me.Panel47.Location = New System.Drawing.Point(206, 39)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(122, 1)
        Me.Panel47.TabIndex = 249
        '
        'playersTxt
        '
        Me.playersTxt.BackColor = System.Drawing.Color.Black
        Me.playersTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.playersTxt.ForeColor = System.Drawing.Color.Cyan
        Me.playersTxt.Location = New System.Drawing.Point(208, 42)
        Me.playersTxt.MaxLength = 17
        Me.playersTxt.Name = "playersTxt"
        Me.playersTxt.Size = New System.Drawing.Size(117, 13)
        Me.playersTxt.TabIndex = 248
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Cyan
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Location = New System.Drawing.Point(1, 77)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(333, 1)
        Me.Panel15.TabIndex = 6
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Cyan
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel16.Location = New System.Drawing.Point(334, 1)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1, 77)
        Me.Panel16.TabIndex = 5
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Cyan
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 1)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1, 77)
        Me.Panel17.TabIndex = 4
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Cyan
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(335, 1)
        Me.Panel18.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.hidePanel)
        Me.Panel7.Controls.Add(Me.gameNameLabel)
        Me.Panel7.Controls.Add(Me.playerslabel)
        Me.Panel7.Controls.Add(Me.additionalRulesLabel)
        Me.Panel7.Controls.Add(Me.joinBtn)
        Me.Panel7.Controls.Add(Me.hostedByLabel)
        Me.Panel7.Controls.Add(Me.banlistLabel)
        Me.Panel7.Controls.Add(Me.gameModeLabel)
        Me.Panel7.Controls.Add(Me.duelTypeLabel)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(572, 103)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(335, 150)
        Me.Panel7.TabIndex = 264
        '
        'hidePanel
        '
        Me.hidePanel.Controls.Add(Me.Label4)
        Me.hidePanel.Controls.Add(Me.Label3)
        Me.hidePanel.Location = New System.Drawing.Point(3, 3)
        Me.hidePanel.Name = "hidePanel"
        Me.hidePanel.Size = New System.Drawing.Size(329, 144)
        Me.hidePanel.TabIndex = 278
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(3, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 13)
        Me.Label4.TabIndex = 269
        Me.Label4.Text = "Double click on a game to spectate!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 13)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "Select a game to display more information!"
        '
        'gameNameLabel
        '
        Me.gameNameLabel.AutoSize = True
        Me.gameNameLabel.ForeColor = System.Drawing.Color.Cyan
        Me.gameNameLabel.Location = New System.Drawing.Point(234, 126)
        Me.gameNameLabel.Name = "gameNameLabel"
        Me.gameNameLabel.Size = New System.Drawing.Size(0, 13)
        Me.gameNameLabel.TabIndex = 282
        Me.gameNameLabel.Visible = False
        '
        'playerslabel
        '
        Me.playerslabel.AutoSize = True
        Me.playerslabel.ForeColor = System.Drawing.Color.Cyan
        Me.playerslabel.Location = New System.Drawing.Point(6, 127)
        Me.playerslabel.Name = "playerslabel"
        Me.playerslabel.Size = New System.Drawing.Size(47, 13)
        Me.playerslabel.TabIndex = 281
        Me.playerslabel.Text = "Players: "
        '
        'additionalRulesLabel
        '
        Me.additionalRulesLabel.AutoSize = True
        Me.additionalRulesLabel.ForeColor = System.Drawing.Color.Cyan
        Me.additionalRulesLabel.Location = New System.Drawing.Point(6, 103)
        Me.additionalRulesLabel.Name = "additionalRulesLabel"
        Me.additionalRulesLabel.Size = New System.Drawing.Size(86, 13)
        Me.additionalRulesLabel.TabIndex = 277
        Me.additionalRulesLabel.Text = "Additional Rules:"
        '
        'joinBtn
        '
        Me.joinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.joinBtn.ForeColor = System.Drawing.Color.Cyan
        Me.joinBtn.Location = New System.Drawing.Point(251, 7)
        Me.joinBtn.Name = "joinBtn"
        Me.joinBtn.Size = New System.Drawing.Size(77, 23)
        Me.joinBtn.TabIndex = 268
        Me.joinBtn.Text = "Join"
        Me.joinBtn.UseVisualStyleBackColor = True
        '
        'hostedByLabel
        '
        Me.hostedByLabel.AutoSize = True
        Me.hostedByLabel.ForeColor = System.Drawing.Color.Cyan
        Me.hostedByLabel.Location = New System.Drawing.Point(6, 7)
        Me.hostedByLabel.Name = "hostedByLabel"
        Me.hostedByLabel.Size = New System.Drawing.Size(59, 13)
        Me.hostedByLabel.TabIndex = 276
        Me.hostedByLabel.Text = "Hosted By:"
        '
        'banlistLabel
        '
        Me.banlistLabel.AutoSize = True
        Me.banlistLabel.ForeColor = System.Drawing.Color.Cyan
        Me.banlistLabel.Location = New System.Drawing.Point(6, 79)
        Me.banlistLabel.Name = "banlistLabel"
        Me.banlistLabel.Size = New System.Drawing.Size(41, 13)
        Me.banlistLabel.TabIndex = 272
        Me.banlistLabel.Text = "Banlist:"
        '
        'gameModeLabel
        '
        Me.gameModeLabel.AutoSize = True
        Me.gameModeLabel.ForeColor = System.Drawing.Color.Cyan
        Me.gameModeLabel.Location = New System.Drawing.Point(6, 55)
        Me.gameModeLabel.Name = "gameModeLabel"
        Me.gameModeLabel.Size = New System.Drawing.Size(68, 13)
        Me.gameModeLabel.TabIndex = 271
        Me.gameModeLabel.Text = "Game Mode:"
        '
        'duelTypeLabel
        '
        Me.duelTypeLabel.AutoSize = True
        Me.duelTypeLabel.ForeColor = System.Drawing.Color.Cyan
        Me.duelTypeLabel.Location = New System.Drawing.Point(6, 31)
        Me.duelTypeLabel.Name = "duelTypeLabel"
        Me.duelTypeLabel.Size = New System.Drawing.Size(59, 13)
        Me.duelTypeLabel.TabIndex = 268
        Me.duelTypeLabel.Text = "Duel Type:"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Cyan
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(1, 149)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(333, 1)
        Me.Panel11.TabIndex = 6
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Cyan
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(334, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 149)
        Me.Panel10.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Cyan
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1, 149)
        Me.Panel9.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Cyan
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(335, 1)
        Me.Panel8.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(569, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 267
        Me.Label1.Text = "Game Information:"
        '
        'hostBtn
        '
        Me.hostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hostBtn.ForeColor = System.Drawing.Color.Cyan
        Me.hostBtn.Location = New System.Drawing.Point(833, 260)
        Me.hostBtn.Name = "hostBtn"
        Me.hostBtn.Size = New System.Drawing.Size(74, 23)
        Me.hostBtn.TabIndex = 269
        Me.hostBtn.Text = "Host"
        Me.hostBtn.UseVisualStyleBackColor = True
        '
        'randomDuelBtn
        '
        Me.randomDuelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.randomDuelBtn.ForeColor = System.Drawing.Color.Cyan
        Me.randomDuelBtn.Location = New System.Drawing.Point(725, 260)
        Me.randomDuelBtn.Name = "randomDuelBtn"
        Me.randomDuelBtn.Size = New System.Drawing.Size(102, 23)
        Me.randomDuelBtn.TabIndex = 270
        Me.randomDuelBtn.Text = "Random Duel"
        Me.randomDuelBtn.UseVisualStyleBackColor = True
        '
        'gameCount
        '
        Me.gameCount.AutoSize = True
        Me.gameCount.ForeColor = System.Drawing.Color.Cyan
        Me.gameCount.Location = New System.Drawing.Point(24, 371)
        Me.gameCount.Name = "gameCount"
        Me.gameCount.Size = New System.Drawing.Size(70, 13)
        Me.gameCount.TabIndex = 273
        Me.gameCount.Text = "Games: 1250"
        '
        'FilterActiveGames
        '
        Me.FilterActiveGames.AutoSize = True
        Me.FilterActiveGames.Checked = True
        Me.FilterActiveGames.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FilterActiveGames.ForeColor = System.Drawing.Color.Cyan
        Me.FilterActiveGames.Location = New System.Drawing.Point(435, 372)
        Me.FilterActiveGames.Name = "FilterActiveGames"
        Me.FilterActiveGames.Size = New System.Drawing.Size(117, 17)
        Me.FilterActiveGames.TabIndex = 274
        Me.FilterActiveGames.Text = "Filter Active Games"
        Me.FilterActiveGames.UseVisualStyleBackColor = True
        '
        'GameListView
        '
        Me.GameListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GameListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GameName, Me.Type, Me.MasterRules, Me.Banlist, Me.Mode, Me.Host, Me.Status})
        Me.GameListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.GameListView.FullRowSelect = True
        Me.GameListView.HideSelection = False
        Me.GameListView.Location = New System.Drawing.Point(20, 86)
        Me.GameListView.MultiSelect = False
        Me.GameListView.Name = "GameListView"
        Me.GameListView.Size = New System.Drawing.Size(532, 280)
        Me.GameListView.TabIndex = 276
        Me.GameListView.UseCompatibleStateImageBehavior = False
        Me.GameListView.View = System.Windows.Forms.View.Details
        '
        'GameName
        '
        Me.GameName.Text = " Game Name"
        Me.GameName.Width = 128
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 43
        '
        'MasterRules
        '
        Me.MasterRules.Text = "MR"
        Me.MasterRules.Width = 30
        '
        'Banlist
        '
        Me.Banlist.Text = "Banlist"
        Me.Banlist.Width = 70
        '
        'Mode
        '
        Me.Mode.Text = "Mode"
        Me.Mode.Width = 73
        '
        'Host
        '
        Me.Host.Text = "Host"
        Me.Host.Width = 116
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 55
        '
        'refreshBtn
        '
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.ForeColor = System.Drawing.Color.Cyan
        Me.refreshBtn.Location = New System.Drawing.Point(645, 260)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(74, 23)
        Me.refreshBtn.TabIndex = 277
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(5, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(18, 324)
        Me.Panel1.TabIndex = 279
        '
        'banner
        '
        Me.banner.Location = New System.Drawing.Point(0, 0)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(927, 69)
        Me.banner.TabIndex = 278
        Me.banner.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.BackB
        Me.BackButton.Location = New System.Drawing.Point(3, 414)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(43, 49)
        Me.BackButton.TabIndex = 280
        Me.BackButton.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 69)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 283
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(926, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 284
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.duelBtn)
        Me.Panel2.Location = New System.Drawing.Point(722, 255)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 34)
        Me.Panel2.TabIndex = 285
        '
        'duelBtn
        '
        Me.duelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.duelBtn.ForeColor = System.Drawing.Color.Cyan
        Me.duelBtn.Location = New System.Drawing.Point(111, 5)
        Me.duelBtn.Name = "duelBtn"
        Me.duelBtn.Size = New System.Drawing.Size(74, 23)
        Me.duelBtn.TabIndex = 286
        Me.duelBtn.Text = "Duel"
        Me.duelBtn.UseVisualStyleBackColor = True
        '
        'rankedQueue
        '
        Me.rankedQueue.Controls.Add(Me.moreInfo)
        Me.rankedQueue.Controls.Add(Me.ExtendedSearch)
        Me.rankedQueue.Controls.Add(Me.Label7)
        Me.rankedQueue.Controls.Add(Me.ocgTag)
        Me.rankedQueue.Controls.Add(Me.ocgSingle)
        Me.rankedQueue.Controls.Add(Me.ocgMatch)
        Me.rankedQueue.Controls.Add(Me.tcgTag)
        Me.rankedQueue.Controls.Add(Me.tcgSingle)
        Me.rankedQueue.Controls.Add(Me.tcgMatch)
        Me.rankedQueue.Location = New System.Drawing.Point(575, 107)
        Me.rankedQueue.Name = "rankedQueue"
        Me.rankedQueue.Size = New System.Drawing.Size(327, 140)
        Me.rankedQueue.TabIndex = 286
        Me.rankedQueue.Visible = False
        '
        'moreInfo
        '
        Me.moreInfo.Enabled = False
        Me.moreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.moreInfo.ForeColor = System.Drawing.Color.Cyan
        Me.moreInfo.Location = New System.Drawing.Point(112, 115)
        Me.moreInfo.Name = "moreInfo"
        Me.moreInfo.Size = New System.Drawing.Size(21, 21)
        Me.moreInfo.TabIndex = 292
        Me.moreInfo.Text = "?"
        Me.moreInfo.UseVisualStyleBackColor = True
        '
        'ExtendedSearch
        '
        Me.ExtendedSearch.AutoSize = True
        Me.ExtendedSearch.Checked = True
        Me.ExtendedSearch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExtendedSearch.ForeColor = System.Drawing.Color.Cyan
        Me.ExtendedSearch.Location = New System.Drawing.Point(6, 118)
        Me.ExtendedSearch.Name = "ExtendedSearch"
        Me.ExtendedSearch.Size = New System.Drawing.Size(108, 17)
        Me.ExtendedSearch.TabIndex = 291
        Me.ExtendedSearch.Text = "Extended Search"
        Me.ExtendedSearch.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Cyan
        Me.Label7.Location = New System.Drawing.Point(3, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 290
        Me.Label7.Text = "Select Game Type:"
        '
        'ocgTag
        '
        Me.ocgTag.Enabled = False
        Me.ocgTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ocgTag.ForeColor = System.Drawing.Color.Cyan
        Me.ocgTag.Location = New System.Drawing.Point(169, 86)
        Me.ocgTag.Name = "ocgTag"
        Me.ocgTag.Size = New System.Drawing.Size(113, 23)
        Me.ocgTag.TabIndex = 289
        Me.ocgTag.Text = "OCG Tag"
        Me.ocgTag.UseVisualStyleBackColor = True
        '
        'ocgSingle
        '
        Me.ocgSingle.Enabled = False
        Me.ocgSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ocgSingle.ForeColor = System.Drawing.Color.Cyan
        Me.ocgSingle.Location = New System.Drawing.Point(169, 28)
        Me.ocgSingle.Name = "ocgSingle"
        Me.ocgSingle.Size = New System.Drawing.Size(113, 23)
        Me.ocgSingle.TabIndex = 288
        Me.ocgSingle.Text = "OCG Single"
        Me.ocgSingle.UseVisualStyleBackColor = True
        '
        'ocgMatch
        '
        Me.ocgMatch.Enabled = False
        Me.ocgMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ocgMatch.ForeColor = System.Drawing.Color.Cyan
        Me.ocgMatch.Location = New System.Drawing.Point(169, 57)
        Me.ocgMatch.Name = "ocgMatch"
        Me.ocgMatch.Size = New System.Drawing.Size(113, 23)
        Me.ocgMatch.TabIndex = 287
        Me.ocgMatch.Text = "OCG Match"
        Me.ocgMatch.UseVisualStyleBackColor = True
        '
        'tcgTag
        '
        Me.tcgTag.Enabled = False
        Me.tcgTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tcgTag.ForeColor = System.Drawing.Color.Cyan
        Me.tcgTag.Location = New System.Drawing.Point(50, 86)
        Me.tcgTag.Name = "tcgTag"
        Me.tcgTag.Size = New System.Drawing.Size(113, 23)
        Me.tcgTag.TabIndex = 286
        Me.tcgTag.Text = "TCG Tag"
        Me.tcgTag.UseVisualStyleBackColor = True
        '
        'tcgSingle
        '
        Me.tcgSingle.Enabled = False
        Me.tcgSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tcgSingle.ForeColor = System.Drawing.Color.Cyan
        Me.tcgSingle.Location = New System.Drawing.Point(50, 28)
        Me.tcgSingle.Name = "tcgSingle"
        Me.tcgSingle.Size = New System.Drawing.Size(113, 23)
        Me.tcgSingle.TabIndex = 285
        Me.tcgSingle.Text = "TCG Single"
        Me.tcgSingle.UseVisualStyleBackColor = True
        '
        'tcgMatch
        '
        Me.tcgMatch.Enabled = False
        Me.tcgMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tcgMatch.ForeColor = System.Drawing.Color.Cyan
        Me.tcgMatch.Location = New System.Drawing.Point(50, 57)
        Me.tcgMatch.Name = "tcgMatch"
        Me.tcgMatch.Size = New System.Drawing.Size(113, 23)
        Me.tcgMatch.TabIndex = 284
        Me.tcgMatch.Text = "TCG Match"
        Me.tcgMatch.UseVisualStyleBackColor = True
        '
        'Buttons1
        '
        Me.Buttons1.BackColor = System.Drawing.Color.Black
        Me.Buttons1.Location = New System.Drawing.Point(101, 400)
        Me.Buttons1.Name = "Buttons1"
        Me.Buttons1.Size = New System.Drawing.Size(733, 64)
        Me.Buttons1.TabIndex = 271
        Me.Buttons1.Type = "Duel"
        '
        'refreshGameListPanel
        '
        Me.refreshGameListPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.refreshGameListPanel.Controls.Add(Me.Label11)
        Me.refreshGameListPanel.Controls.Add(Me.Panel12)
        Me.refreshGameListPanel.Controls.Add(Me.Panel6)
        Me.refreshGameListPanel.Controls.Add(Me.Panel5)
        Me.refreshGameListPanel.Controls.Add(Me.Panel4)
        Me.refreshGameListPanel.Controls.Add(Me.Button1)
        Me.refreshGameListPanel.Controls.Add(Me.Label8)
        Me.refreshGameListPanel.Location = New System.Drawing.Point(20, 86)
        Me.refreshGameListPanel.Name = "refreshGameListPanel"
        Me.refreshGameListPanel.Size = New System.Drawing.Size(532, 280)
        Me.refreshGameListPanel.TabIndex = 287
        Me.refreshGameListPanel.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(154, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 13)
        Me.Label11.TabIndex = 283
        Me.Label11.Text = "Game List does not refresh automatically!"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.ForeColor = System.Drawing.Color.Black
        Me.Panel12.Location = New System.Drawing.Point(1, 279)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(530, 1)
        Me.Panel12.TabIndex = 282
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(531, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1, 279)
        Me.Panel6.TabIndex = 281
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 279)
        Me.Panel5.TabIndex = 280
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(532, 1)
        Me.Panel4.TabIndex = 279
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(292, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 36)
        Me.Button1.TabIndex = 278
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Refresh the Game List: "
        '
        'GameList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.refreshGameListPanel)
        Me.Controls.Add(Me.rankedQueue)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.gameCount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.GameListView)
        Me.Controls.Add(Me.FilterActiveGames)
        Me.Controls.Add(Me.Buttons1)
        Me.Controls.Add(Me.randomDuelBtn)
        Me.Controls.Add(Me.hostBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "GameList"
        Me.Size = New System.Drawing.Size(927, 467)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.hidePanel.ResumeLayout(False)
        Me.hidePanel.PerformLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.rankedQueue.ResumeLayout(False)
        Me.rankedQueue.PerformLayout()
        Me.refreshGameListPanel.ResumeLayout(False)
        Me.refreshGameListPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents duelTypeCmBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents banlistLabel As System.Windows.Forms.Label
    Friend WithEvents gameModeLabel As System.Windows.Forms.Label
    Friend WithEvents duelTypeLabel As System.Windows.Forms.Label
    Friend WithEvents additionalRulesLabel As System.Windows.Forms.Label
    Friend WithEvents hostedByLabel As System.Windows.Forms.Label
    Friend WithEvents joinBtn As System.Windows.Forms.Button
    Friend WithEvents hostBtn As System.Windows.Forms.Button
    Friend WithEvents randomDuelBtn As System.Windows.Forms.Button
    Friend WithEvents banlistCmBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gameModeCmBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel44 As System.Windows.Forms.Panel
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents Panel46 As System.Windows.Forms.Panel
    Friend WithEvents Panel47 As System.Windows.Forms.Panel
    Friend WithEvents playersTxt As System.Windows.Forms.TextBox
    Friend WithEvents Buttons1 As YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons
    Friend WithEvents gameCount As System.Windows.Forms.Label
    Friend WithEvents FilterActiveGames As System.Windows.Forms.CheckBox
    Friend WithEvents GameListView As System.Windows.Forms.ListView
    Friend WithEvents GameName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents Banlist As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mode As System.Windows.Forms.ColumnHeader
    Friend WithEvents Host As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents refreshBtn As System.Windows.Forms.Button
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents hidePanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gameNameLabel As System.Windows.Forms.Label
    Friend WithEvents playerslabel As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents duelBtn As System.Windows.Forms.Button
    Friend WithEvents rankedQueue As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ocgTag As System.Windows.Forms.Button
    Friend WithEvents ocgSingle As System.Windows.Forms.Button
    Friend WithEvents ocgMatch As System.Windows.Forms.Button
    Friend WithEvents tcgTag As System.Windows.Forms.Button
    Friend WithEvents tcgSingle As System.Windows.Forms.Button
    Friend WithEvents tcgMatch As System.Windows.Forms.Button
    Friend WithEvents ExtendedSearch As System.Windows.Forms.CheckBox
    Friend WithEvents moreInfo As System.Windows.Forms.Button
    Friend WithEvents MasterRules As ColumnHeader
    Friend WithEvents refreshGameListPanel As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
End Class
