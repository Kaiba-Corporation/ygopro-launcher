<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HostForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HostForm))
        Me.banlistCmBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gamename = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cardsPerDraw = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.startingHand = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.startingLP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dontShuffleDeckChb = New System.Windows.Forms.CheckBox()
        Me.dontCheckDeckChb = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.duelModeCmBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.allowedCardsCmBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.masterRulesCmBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dontRecoverTimeChb = New System.Windows.Forms.CheckBox()
        Me.setAsDefaultBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'banlistCmBox
        '
        Me.banlistCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.banlistCmBox.FormattingEnabled = True
        Me.banlistCmBox.Items.AddRange(New Object() {"TCG", "OCG", "Traditional", "No Banlist"})
        Me.banlistCmBox.Location = New System.Drawing.Point(95, 9)
        Me.banlistCmBox.Name = "banlistCmBox"
        Me.banlistCmBox.Size = New System.Drawing.Size(147, 21)
        Me.banlistCmBox.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Banlist:"
        '
        'gamename
        '
        Me.gamename.Location = New System.Drawing.Point(99, 277)
        Me.gamename.MaxLength = 10
        Me.gamename.Name = "gamename"
        Me.gamename.Size = New System.Drawing.Size(143, 20)
        Me.gamename.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(10, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Game Name:"
        '
        'cardsPerDraw
        '
        Me.cardsPerDraw.Location = New System.Drawing.Point(99, 251)
        Me.cardsPerDraw.Name = "cardsPerDraw"
        Me.cardsPerDraw.Size = New System.Drawing.Size(57, 20)
        Me.cardsPerDraw.TabIndex = 36
        Me.cardsPerDraw.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(10, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Cards per Draw:"
        '
        'startingHand
        '
        Me.startingHand.Location = New System.Drawing.Point(99, 225)
        Me.startingHand.Name = "startingHand"
        Me.startingHand.Size = New System.Drawing.Size(57, 20)
        Me.startingHand.TabIndex = 34
        Me.startingHand.Text = "5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Starting Hand:"
        '
        'startingLP
        '
        Me.startingLP.Location = New System.Drawing.Point(99, 199)
        Me.startingLP.Name = "startingLP"
        Me.startingLP.Size = New System.Drawing.Size(57, 20)
        Me.startingLP.TabIndex = 32
        Me.startingLP.Text = "8000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Starting LP:"
        '
        'dontShuffleDeckChb
        '
        Me.dontShuffleDeckChb.AutoSize = True
        Me.dontShuffleDeckChb.BackColor = System.Drawing.Color.Transparent
        Me.dontShuffleDeckChb.ForeColor = System.Drawing.Color.White
        Me.dontShuffleDeckChb.Location = New System.Drawing.Point(13, 172)
        Me.dontShuffleDeckChb.Name = "dontShuffleDeckChb"
        Me.dontShuffleDeckChb.Size = New System.Drawing.Size(116, 17)
        Me.dontShuffleDeckChb.TabIndex = 30
        Me.dontShuffleDeckChb.Text = "Don't Shuffle Deck"
        Me.dontShuffleDeckChb.UseVisualStyleBackColor = False
        '
        'dontCheckDeckChb
        '
        Me.dontCheckDeckChb.AutoSize = True
        Me.dontCheckDeckChb.BackColor = System.Drawing.Color.Transparent
        Me.dontCheckDeckChb.ForeColor = System.Drawing.Color.White
        Me.dontCheckDeckChb.Location = New System.Drawing.Point(128, 172)
        Me.dontCheckDeckChb.Name = "dontCheckDeckChb"
        Me.dontCheckDeckChb.Size = New System.Drawing.Size(114, 17)
        Me.dontCheckDeckChb.TabIndex = 29
        Me.dontCheckDeckChb.Text = "Don't Check Deck"
        Me.dontCheckDeckChb.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Additional Options:"
        '
        'duelModeCmBox
        '
        Me.duelModeCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.duelModeCmBox.FormattingEnabled = True
        Me.duelModeCmBox.Items.AddRange(New Object() {"Single Duel", "Match Duel", "Tag Duel"})
        Me.duelModeCmBox.Location = New System.Drawing.Point(95, 63)
        Me.duelModeCmBox.Name = "duelModeCmBox"
        Me.duelModeCmBox.Size = New System.Drawing.Size(147, 21)
        Me.duelModeCmBox.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Duel Mode:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(164, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 34)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Host"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'allowedCardsCmBox
        '
        Me.allowedCardsCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.allowedCardsCmBox.FormattingEnabled = True
        Me.allowedCardsCmBox.Items.AddRange(New Object() {"TCG/OCG", "TCG", "OCG"})
        Me.allowedCardsCmBox.Location = New System.Drawing.Point(95, 36)
        Me.allowedCardsCmBox.Name = "allowedCardsCmBox"
        Me.allowedCardsCmBox.Size = New System.Drawing.Size(147, 21)
        Me.allowedCardsCmBox.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(9, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Allowed Cards:"
        '
        'masterRulesCmBox
        '
        Me.masterRulesCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.masterRulesCmBox.FormattingEnabled = True
        Me.masterRulesCmBox.Items.AddRange(New Object() {"Rule 1 (Original)", "Rule 2 (Synchro / XYZ)", "Rule 3 (Pendulum)", "Rule 4 (Links)", "Rule 5 (April 2020)"})
        Me.masterRulesCmBox.Location = New System.Drawing.Point(95, 90)
        Me.masterRulesCmBox.Name = "masterRulesCmBox"
        Me.masterRulesCmBox.Size = New System.Drawing.Size(147, 21)
        Me.masterRulesCmBox.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Master Rules:"
        '
        'dontRecoverTimeChb
        '
        Me.dontRecoverTimeChb.AutoSize = True
        Me.dontRecoverTimeChb.BackColor = System.Drawing.Color.Transparent
        Me.dontRecoverTimeChb.ForeColor = System.Drawing.Color.White
        Me.dontRecoverTimeChb.Location = New System.Drawing.Point(13, 149)
        Me.dontRecoverTimeChb.Name = "dontRecoverTimeChb"
        Me.dontRecoverTimeChb.Size = New System.Drawing.Size(121, 17)
        Me.dontRecoverTimeChb.TabIndex = 51
        Me.dontRecoverTimeChb.Text = "Don't Recover Time"
        Me.dontRecoverTimeChb.UseVisualStyleBackColor = False
        '
        'setAsDefaultBtn
        '
        Me.setAsDefaultBtn.BackColor = System.Drawing.Color.Silver
        Me.setAsDefaultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.setAsDefaultBtn.ForeColor = System.Drawing.Color.Black
        Me.setAsDefaultBtn.Location = New System.Drawing.Point(74, 316)
        Me.setAsDefaultBtn.Name = "setAsDefaultBtn"
        Me.setAsDefaultBtn.Size = New System.Drawing.Size(85, 23)
        Me.setAsDefaultBtn.TabIndex = 52
        Me.setAsDefaultBtn.Text = "Set As Default"
        Me.setAsDefaultBtn.UseVisualStyleBackColor = False
        Me.setAsDefaultBtn.Visible = False
        '
        'HostForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(252, 348)
        Me.Controls.Add(Me.setAsDefaultBtn)
        Me.Controls.Add(Me.dontRecoverTimeChb)
        Me.Controls.Add(Me.masterRulesCmBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.allowedCardsCmBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.banlistCmBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gamename)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cardsPerDraw)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.startingHand)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.startingLP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dontShuffleDeckChb)
        Me.Controls.Add(Me.dontCheckDeckChb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.duelModeCmBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HostForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Host"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents banlistCmBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gamename As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cardsPerDraw As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents startingHand As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents startingLP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dontShuffleDeckChb As System.Windows.Forms.CheckBox
    Friend WithEvents dontCheckDeckChb As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents duelModeCmBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents allowedCardsCmBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents masterRulesCmBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dontRecoverTimeChb As CheckBox
    Friend WithEvents setAsDefaultBtn As Button
End Class
