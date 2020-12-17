<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuelingRobot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DuelingRobot))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Duel = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.duelingRobotDeckListBox = New System.Windows.Forms.ListBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.masterRulesCmBox = New System.Windows.Forms.ComboBox()
        Me.duelModeCmBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lifePointsCmBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cardsPerDrawCmBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.startingHandCmBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.turnTimerCmBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dontShuffleChb = New System.Windows.Forms.CheckBox()
        Me.Buttons1 = New YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(367, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 340
        Me.Label9.Text = "Dueling Robot"
        '
        'Duel
        '
        Me.Duel.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.Duel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Duel.ForeColor = System.Drawing.Color.Cyan
        Me.Duel.Location = New System.Drawing.Point(576, 347)
        Me.Duel.Name = "Duel"
        Me.Duel.Size = New System.Drawing.Size(86, 22)
        Me.Duel.TabIndex = 335
        Me.Duel.Text = "Duel"
        Me.Duel.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Cyan
        Me.Button7.Location = New System.Drawing.Point(812, 353)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 22)
        Me.Button7.TabIndex = 354
        Me.Button7.Text = "Duel"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Cyan
        Me.Button5.Location = New System.Drawing.Point(706, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 22)
        Me.Button5.TabIndex = 348
        Me.Button5.Text = "Duel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Cyan
        Me.Button4.Location = New System.Drawing.Point(812, 210)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 22)
        Me.Button4.TabIndex = 346
        Me.Button4.Text = "Duel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(706, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 22)
        Me.Button3.TabIndex = 343
        Me.Button3.Text = "Duel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(677, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 356
        Me.Label1.Text = "Character Simulator:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Location = New System.Drawing.Point(367, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 1)
        Me.Panel1.TabIndex = 362
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Location = New System.Drawing.Point(366, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 1)
        Me.Panel2.TabIndex = 363
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Cyan
        Me.Panel6.Location = New System.Drawing.Point(367, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 1)
        Me.Panel6.TabIndex = 367
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Cyan
        Me.Panel9.Location = New System.Drawing.Point(366, 78)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1, 297)
        Me.Panel9.TabIndex = 370
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Cyan
        Me.Panel10.Location = New System.Drawing.Point(667, 78)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 297)
        Me.Panel10.TabIndex = 371
        '
        'duelingRobotDeckListBox
        '
        Me.duelingRobotDeckListBox.BackColor = System.Drawing.Color.Black
        Me.duelingRobotDeckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.duelingRobotDeckListBox.ForeColor = System.Drawing.Color.Cyan
        Me.duelingRobotDeckListBox.FormattingEnabled = True
        Me.duelingRobotDeckListBox.Items.AddRange(New Object() {"Altergeist", "Blackwing", "Blue-Eyes Max Dragon", "Blue-Eyes White Dragon", "Burn", "Chain Burn", "Cyber Dragon", "Dark Magician", "Dragun", "Dragunity", "Evilswarm", "Frog", "Gravekeeper", "Gren Maju Thunder Boarder", "Horus", "Level VIII", "Lightsworn", "Mokey Mokey", "Mokey Mokey King", "Nekroz", "Orcust", "Phantasm", "Qliphort", "Rainbow", "Rank V", "ST1732", "Salamangreat", "Shaddoll Dinosaur", "Sky Striker", "Trickstar", "Yosenju", "Zexal Weapons"})
        Me.duelingRobotDeckListBox.Location = New System.Drawing.Point(368, 101)
        Me.duelingRobotDeckListBox.Name = "duelingRobotDeckListBox"
        Me.duelingRobotDeckListBox.Size = New System.Drawing.Size(190, 273)
        Me.duelingRobotDeckListBox.TabIndex = 380
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(806, 247)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.TabIndex = 355
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(700, 104)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox7.TabIndex = 349
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(806, 104)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox8.TabIndex = 347
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(700, 247)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox9.TabIndex = 344
        Me.PictureBox9.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.BackB
        Me.BackButton.Location = New System.Drawing.Point(3, 414)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(43, 49)
        Me.BackButton.TabIndex = 332
        Me.BackButton.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(924, 69)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 93
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 69)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 92
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(927, 69)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(356, 341)
        Me.PictureBox2.TabIndex = 341
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Cyan
        Me.Panel3.Location = New System.Drawing.Point(558, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 274)
        Me.Panel3.TabIndex = 381
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(554, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 382
        Me.Label2.Text = "Master Rules:"
        '
        'masterRulesCmBox
        '
        Me.masterRulesCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.masterRulesCmBox.FormattingEnabled = True
        Me.masterRulesCmBox.Items.AddRange(New Object() {"3", "4", "5"})
        Me.masterRulesCmBox.Location = New System.Drawing.Point(629, 79)
        Me.masterRulesCmBox.Name = "masterRulesCmBox"
        Me.masterRulesCmBox.Size = New System.Drawing.Size(38, 21)
        Me.masterRulesCmBox.TabIndex = 383
        '
        'duelModeCmBox
        '
        Me.duelModeCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.duelModeCmBox.FormattingEnabled = True
        Me.duelModeCmBox.Items.AddRange(New Object() {"Single Duel", "Match Duel"})
        Me.duelModeCmBox.Location = New System.Drawing.Point(565, 122)
        Me.duelModeCmBox.Name = "duelModeCmBox"
        Me.duelModeCmBox.Size = New System.Drawing.Size(96, 21)
        Me.duelModeCmBox.TabIndex = 385
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(562, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 384
        Me.Label3.Text = "Duel Mode:"
        '
        'lifePointsCmBox
        '
        Me.lifePointsCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lifePointsCmBox.FormattingEnabled = True
        Me.lifePointsCmBox.Items.AddRange(New Object() {"1", "100", "1000", "2000", "4000", "8000", "16000", "32000", "64000", "100000"})
        Me.lifePointsCmBox.Location = New System.Drawing.Point(565, 164)
        Me.lifePointsCmBox.Name = "lifePointsCmBox"
        Me.lifePointsCmBox.Size = New System.Drawing.Size(96, 21)
        Me.lifePointsCmBox.TabIndex = 387
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(562, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 386
        Me.Label4.Text = "Life Points:"
        '
        'cardsPerDrawCmBox
        '
        Me.cardsPerDrawCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cardsPerDrawCmBox.FormattingEnabled = True
        Me.cardsPerDrawCmBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cardsPerDrawCmBox.Location = New System.Drawing.Point(565, 248)
        Me.cardsPerDrawCmBox.Name = "cardsPerDrawCmBox"
        Me.cardsPerDrawCmBox.Size = New System.Drawing.Size(96, 21)
        Me.cardsPerDrawCmBox.TabIndex = 395
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Cyan
        Me.Label7.Location = New System.Drawing.Point(562, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 394
        Me.Label7.Text = "Cards Per Draw:"
        '
        'startingHandCmBox
        '
        Me.startingHandCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.startingHandCmBox.FormattingEnabled = True
        Me.startingHandCmBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.startingHandCmBox.Location = New System.Drawing.Point(565, 206)
        Me.startingHandCmBox.Name = "startingHandCmBox"
        Me.startingHandCmBox.Size = New System.Drawing.Size(96, 21)
        Me.startingHandCmBox.TabIndex = 393
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(562, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 392
        Me.Label8.Text = "Starting Hand:"
        '
        'turnTimerCmBox
        '
        Me.turnTimerCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.turnTimerCmBox.FormattingEnabled = True
        Me.turnTimerCmBox.Items.AddRange(New Object() {"3 Minutes", "7 Minutes"})
        Me.turnTimerCmBox.Location = New System.Drawing.Point(565, 290)
        Me.turnTimerCmBox.Name = "turnTimerCmBox"
        Me.turnTimerCmBox.Size = New System.Drawing.Size(96, 21)
        Me.turnTimerCmBox.TabIndex = 397
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Cyan
        Me.Label11.Location = New System.Drawing.Point(562, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 396
        Me.Label11.Text = "Turn Timer:"
        '
        'dontShuffleChb
        '
        Me.dontShuffleChb.AutoSize = True
        Me.dontShuffleChb.ForeColor = System.Drawing.Color.Cyan
        Me.dontShuffleChb.Location = New System.Drawing.Point(565, 316)
        Me.dontShuffleChb.Name = "dontShuffleChb"
        Me.dontShuffleChb.Size = New System.Drawing.Size(87, 17)
        Me.dontShuffleChb.TabIndex = 408
        Me.dontShuffleChb.Text = "Don't Shuffle"
        Me.dontShuffleChb.UseVisualStyleBackColor = True
        '
        'Buttons1
        '
        Me.Buttons1.BackColor = System.Drawing.Color.Black
        Me.Buttons1.Location = New System.Drawing.Point(101, 400)
        Me.Buttons1.Name = "Buttons1"
        Me.Buttons1.Size = New System.Drawing.Size(733, 64)
        Me.Buttons1.TabIndex = 333
        Me.Buttons1.Type = "Duel"
        '
        'DuelingRobot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.dontShuffleChb)
        Me.Controls.Add(Me.turnTimerCmBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cardsPerDrawCmBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.startingHandCmBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lifePointsCmBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.duelModeCmBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.masterRulesCmBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Duel)
        Me.Controls.Add(Me.Buttons1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.duelingRobotDeckListBox)
        Me.Name = "DuelingRobot"
        Me.Size = New System.Drawing.Size(927, 467)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents Buttons1 As YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Duel As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents duelingRobotDeckListBox As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents masterRulesCmBox As ComboBox
    Friend WithEvents duelModeCmBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lifePointsCmBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cardsPerDrawCmBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents startingHandCmBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents turnTimerCmBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dontShuffleChb As CheckBox
End Class
