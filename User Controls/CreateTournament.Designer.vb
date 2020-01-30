<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTournament
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateTournament))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tournamentType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maximumPlayers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tournamentName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.banlist = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.createTournamentBtn = New System.Windows.Forms.Button()
        Me.diamondAward = New System.Windows.Forms.TextBox()
        Me.goldAward = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.titleAward = New System.Windows.Forms.ComboBox()
        Me.qualificationList = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.player = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.startDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.endDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.cardSkinOneImg = New System.Windows.Forms.PictureBox()
        Me.crownOneImg = New System.Windows.Forms.PictureBox()
        Me.diamondsOneImg = New System.Windows.Forms.PictureBox()
        Me.goldOneImg = New System.Windows.Forms.PictureBox()
        Me.crownChBox = New System.Windows.Forms.CheckBox()
        Me.cardSkinChBox = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tournamentImg = New System.Windows.Forms.PictureBox()
        Me.leftBtn = New System.Windows.Forms.Button()
        Me.rightBtn = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rulesTxt = New System.Windows.Forms.TextBox()
        CType(Me.cardSkinOneImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crownOneImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diamondsOneImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goldOneImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tournamentImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(14, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 261
        Me.Label8.Text = "Tournament Type:"
        '
        'tournamentType
        '
        Me.tournamentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tournamentType.FormattingEnabled = True
        Me.tournamentType.Items.AddRange(New Object() {"Duel League", "Single Elimination"})
        Me.tournamentType.Location = New System.Drawing.Point(122, 207)
        Me.tournamentType.Name = "tournamentType"
        Me.tournamentType.Size = New System.Drawing.Size(117, 21)
        Me.tournamentType.TabIndex = 260
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(269, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 262
        Me.Label1.Text = "Maximum Players:"
        '
        'maximumPlayers
        '
        Me.maximumPlayers.Location = New System.Drawing.Point(392, 95)
        Me.maximumPlayers.Name = "maximumPlayers"
        Me.maximumPlayers.Size = New System.Drawing.Size(122, 20)
        Me.maximumPlayers.TabIndex = 263
        Me.maximumPlayers.Text = "32"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(14, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "Tournament Name:"
        '
        'tournamentName
        '
        Me.tournamentName.Location = New System.Drawing.Point(122, 173)
        Me.tournamentName.MaxLength = 30
        Me.tournamentName.Name = "tournamentName"
        Me.tournamentName.Size = New System.Drawing.Size(117, 20)
        Me.tournamentName.TabIndex = 265
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(269, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "Banlist:"
        '
        'banlist
        '
        Me.banlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.banlist.FormattingEnabled = True
        Me.banlist.Items.AddRange(New Object() {"TCG", "OCG", "No Banlist"})
        Me.banlist.Location = New System.Drawing.Point(392, 128)
        Me.banlist.Name = "banlist"
        Me.banlist.Size = New System.Drawing.Size(122, 21)
        Me.banlist.TabIndex = 266
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(269, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 274
        Me.Label5.Text = "Required Qualification:"
        '
        'createTournamentBtn
        '
        Me.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createTournamentBtn.ForeColor = System.Drawing.Color.Cyan
        Me.createTournamentBtn.Location = New System.Drawing.Point(596, 226)
        Me.createTournamentBtn.Name = "createTournamentBtn"
        Me.createTournamentBtn.Size = New System.Drawing.Size(120, 24)
        Me.createTournamentBtn.TabIndex = 278
        Me.createTournamentBtn.Text = "Create Tournament"
        Me.createTournamentBtn.UseVisualStyleBackColor = True
        '
        'diamondAward
        '
        Me.diamondAward.Location = New System.Drawing.Point(684, 94)
        Me.diamondAward.Name = "diamondAward"
        Me.diamondAward.Size = New System.Drawing.Size(32, 20)
        Me.diamondAward.TabIndex = 282
        Me.diamondAward.Text = "0"
        '
        'goldAward
        '
        Me.goldAward.Location = New System.Drawing.Point(625, 94)
        Me.goldAward.Name = "goldAward"
        Me.goldAward.Size = New System.Drawing.Size(32, 20)
        Me.goldAward.TabIndex = 285
        Me.goldAward.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Cyan
        Me.Label7.Location = New System.Drawing.Point(566, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 289
        Me.Label7.Text = "Title:"
        '
        'titleAward
        '
        Me.titleAward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.titleAward.FormattingEnabled = True
        Me.titleAward.Items.AddRange(New Object() {"No Title"})
        Me.titleAward.Location = New System.Drawing.Point(602, 162)
        Me.titleAward.Name = "titleAward"
        Me.titleAward.Size = New System.Drawing.Size(114, 21)
        Me.titleAward.TabIndex = 288
        '
        'qualificationList
        '
        Me.qualificationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.qualificationList.FormattingEnabled = True
        Me.qualificationList.Items.AddRange(New Object() {"None", "Q1", "Q2", "Q3"})
        Me.qualificationList.Location = New System.Drawing.Point(392, 60)
        Me.qualificationList.Name = "qualificationList"
        Me.qualificationList.Size = New System.Drawing.Size(122, 21)
        Me.qualificationList.TabIndex = 290
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(537, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 291
        Me.Label9.Text = "Awards:"
        '
        'player
        '
        Me.player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.player.FormattingEnabled = True
        Me.player.Items.AddRange(New Object() {"Winner", "2nd Place", "3rd Place", "4th Place"})
        Me.player.Location = New System.Drawing.Point(602, 60)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(114, 21)
        Me.player.TabIndex = 292
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 1)
        Me.Panel1.TabIndex = 299
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 266)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(733, 1)
        Me.Panel2.TabIndex = 300
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Cyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 265)
        Me.Panel3.TabIndex = 301
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(732, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 265)
        Me.Panel4.TabIndex = 302
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(269, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 304
        Me.Label4.Text = "Start Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Cyan
        Me.Label10.Location = New System.Drawing.Point(269, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 305
        Me.Label10.Text = "End Date:"
        '
        'startDatePicker
        '
        Me.startDatePicker.Location = New System.Drawing.Point(392, 162)
        Me.startDatePicker.Name = "startDatePicker"
        Me.startDatePicker.Size = New System.Drawing.Size(122, 20)
        Me.startDatePicker.TabIndex = 306
        '
        'endDatePicker
        '
        Me.endDatePicker.Location = New System.Drawing.Point(392, 195)
        Me.endDatePicker.Name = "endDatePicker"
        Me.endDatePicker.Size = New System.Drawing.Size(122, 20)
        Me.endDatePicker.TabIndex = 307
        Me.endDatePicker.Value = New Date(2018, 5, 15, 0, 0, 0, 0)
        '
        'cardSkinOneImg
        '
        Me.cardSkinOneImg.BackColor = System.Drawing.Color.Transparent
        Me.cardSkinOneImg.Location = New System.Drawing.Point(620, 128)
        Me.cardSkinOneImg.Name = "cardSkinOneImg"
        Me.cardSkinOneImg.Size = New System.Drawing.Size(20, 20)
        Me.cardSkinOneImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardSkinOneImg.TabIndex = 380
        Me.cardSkinOneImg.TabStop = False
        '
        'crownOneImg
        '
        Me.crownOneImg.BackColor = System.Drawing.Color.Transparent
        Me.crownOneImg.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.C1
        Me.crownOneImg.Location = New System.Drawing.Point(674, 128)
        Me.crownOneImg.Name = "crownOneImg"
        Me.crownOneImg.Size = New System.Drawing.Size(20, 20)
        Me.crownOneImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.crownOneImg.TabIndex = 379
        Me.crownOneImg.TabStop = False
        '
        'diamondsOneImg
        '
        Me.diamondsOneImg.BackColor = System.Drawing.Color.Transparent
        Me.diamondsOneImg.Image = CType(resources.GetObject("diamondsOneImg.Image"), System.Drawing.Image)
        Me.diamondsOneImg.Location = New System.Drawing.Point(661, 94)
        Me.diamondsOneImg.Name = "diamondsOneImg"
        Me.diamondsOneImg.Size = New System.Drawing.Size(20, 20)
        Me.diamondsOneImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.diamondsOneImg.TabIndex = 378
        Me.diamondsOneImg.TabStop = False
        '
        'goldOneImg
        '
        Me.goldOneImg.BackColor = System.Drawing.Color.Transparent
        Me.goldOneImg.Image = CType(resources.GetObject("goldOneImg.Image"), System.Drawing.Image)
        Me.goldOneImg.Location = New System.Drawing.Point(602, 94)
        Me.goldOneImg.Name = "goldOneImg"
        Me.goldOneImg.Size = New System.Drawing.Size(20, 20)
        Me.goldOneImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goldOneImg.TabIndex = 377
        Me.goldOneImg.TabStop = False
        '
        'crownChBox
        '
        Me.crownChBox.AutoSize = True
        Me.crownChBox.Location = New System.Drawing.Point(656, 131)
        Me.crownChBox.Name = "crownChBox"
        Me.crownChBox.Size = New System.Drawing.Size(15, 14)
        Me.crownChBox.TabIndex = 381
        Me.crownChBox.UseVisualStyleBackColor = True
        '
        'cardSkinChBox
        '
        Me.cardSkinChBox.AutoSize = True
        Me.cardSkinChBox.Location = New System.Drawing.Point(602, 131)
        Me.cardSkinChBox.Name = "cardSkinChBox"
        Me.cardSkinChBox.Size = New System.Drawing.Size(15, 14)
        Me.cardSkinChBox.TabIndex = 382
        Me.cardSkinChBox.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.Location = New System.Drawing.Point(0, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(733, 1)
        Me.Panel5.TabIndex = 383
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(247, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 25)
        Me.Label6.TabIndex = 384
        Me.Label6.Text = "CREATE TOURNAMENT"
        '
        'tournamentImg
        '
        Me.tournamentImg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tournamentImg.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.News1
        Me.tournamentImg.Location = New System.Drawing.Point(0, 0)
        Me.tournamentImg.Name = "tournamentImg"
        Me.tournamentImg.Size = New System.Drawing.Size(100, 100)
        Me.tournamentImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tournamentImg.TabIndex = 385
        Me.tournamentImg.TabStop = False
        Me.tournamentImg.Tag = "1"
        '
        'leftBtn
        '
        Me.leftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leftBtn.ForeColor = System.Drawing.Color.Cyan
        Me.leftBtn.Location = New System.Drawing.Point(52, 73)
        Me.leftBtn.Name = "leftBtn"
        Me.leftBtn.Size = New System.Drawing.Size(23, 64)
        Me.leftBtn.TabIndex = 386
        Me.leftBtn.Text = "<"
        Me.leftBtn.UseVisualStyleBackColor = True
        '
        'rightBtn
        '
        Me.rightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rightBtn.ForeColor = System.Drawing.Color.Cyan
        Me.rightBtn.Location = New System.Drawing.Point(187, 73)
        Me.rightBtn.Name = "rightBtn"
        Me.rightBtn.Size = New System.Drawing.Size(23, 64)
        Me.rightBtn.TabIndex = 387
        Me.rightBtn.Text = ">"
        Me.rightBtn.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.tournamentImg)
        Me.Panel6.Location = New System.Drawing.Point(81, 53)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(100, 100)
        Me.Panel6.TabIndex = 390
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Cyan
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1, 98)
        Me.Panel9.TabIndex = 392
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Cyan
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(99, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 98)
        Me.Panel10.TabIndex = 393
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Cyan
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 99)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(100, 1)
        Me.Panel8.TabIndex = 392
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Cyan
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(100, 1)
        Me.Panel7.TabIndex = 391
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Cyan
        Me.Label13.Location = New System.Drawing.Point(269, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 393
        Me.Label13.Text = "Rules:"
        '
        'rulesTxt
        '
        Me.rulesTxt.Location = New System.Drawing.Point(392, 230)
        Me.rulesTxt.Name = "rulesTxt"
        Me.rulesTxt.Size = New System.Drawing.Size(122, 20)
        Me.rulesTxt.TabIndex = 394
        Me.rulesTxt.Text = "http://"
        '
        'CreateTournament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.rulesTxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.rightBtn)
        Me.Controls.Add(Me.leftBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.cardSkinChBox)
        Me.Controls.Add(Me.crownChBox)
        Me.Controls.Add(Me.cardSkinOneImg)
        Me.Controls.Add(Me.crownOneImg)
        Me.Controls.Add(Me.diamondsOneImg)
        Me.Controls.Add(Me.goldOneImg)
        Me.Controls.Add(Me.endDatePicker)
        Me.Controls.Add(Me.startDatePicker)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.qualificationList)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.titleAward)
        Me.Controls.Add(Me.goldAward)
        Me.Controls.Add(Me.diamondAward)
        Me.Controls.Add(Me.createTournamentBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.banlist)
        Me.Controls.Add(Me.tournamentName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maximumPlayers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tournamentType)
        Me.Name = "CreateTournament"
        Me.Size = New System.Drawing.Size(733, 267)
        CType(Me.cardSkinOneImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crownOneImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diamondsOneImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goldOneImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tournamentImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tournamentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents maximumPlayers As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tournamentName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents banlist As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents createTournamentBtn As System.Windows.Forms.Button
    Friend WithEvents diamondAward As System.Windows.Forms.TextBox
    Friend WithEvents goldAward As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents titleAward As System.Windows.Forms.ComboBox
    Friend WithEvents qualificationList As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents player As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents startDatePicker As DateTimePicker
    Friend WithEvents endDatePicker As DateTimePicker
    Friend WithEvents cardSkinOneImg As PictureBox
    Friend WithEvents crownOneImg As PictureBox
    Friend WithEvents diamondsOneImg As PictureBox
    Friend WithEvents goldOneImg As PictureBox
    Friend WithEvents crownChBox As CheckBox
    Friend WithEvents cardSkinChBox As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tournamentImg As PictureBox
    Friend WithEvents leftBtn As Button
    Friend WithEvents rightBtn As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents rulesTxt As TextBox
End Class
