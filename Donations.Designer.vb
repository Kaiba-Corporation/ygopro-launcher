<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Donations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donations))
        Me.avatarCardBack = New System.Windows.Forms.PictureBox()
        Me.cardBack = New System.Windows.Forms.PictureBox()
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.donationsLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBarUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.diamondBuyBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.avatarCardBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'avatarCardBack
        '
        Me.avatarCardBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.avatarCardBack.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.Item_AvatarCardBack
        Me.avatarCardBack.Location = New System.Drawing.Point(510, 120)
        Me.avatarCardBack.Name = "avatarCardBack"
        Me.avatarCardBack.Size = New System.Drawing.Size(220, 103)
        Me.avatarCardBack.TabIndex = 12
        Me.avatarCardBack.TabStop = False
        '
        'cardBack
        '
        Me.cardBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cardBack.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.Item_CardBack
        Me.cardBack.Location = New System.Drawing.Point(280, 120)
        Me.cardBack.Name = "cardBack"
        Me.cardBack.Size = New System.Drawing.Size(220, 103)
        Me.cardBack.TabIndex = 11
        Me.cardBack.TabStop = False
        '
        'avatar
        '
        Me.avatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.avatar.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.Item_Avatar
        Me.avatar.Location = New System.Drawing.Point(50, 120)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(220, 103)
        Me.avatar.TabIndex = 10
        Me.avatar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "Monthly Donations:"
        '
        'donationsLabel
        '
        Me.donationsLabel.AutoSize = True
        Me.donationsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donationsLabel.ForeColor = System.Drawing.Color.Cyan
        Me.donationsLabel.Location = New System.Drawing.Point(148, 9)
        Me.donationsLabel.Name = "donationsLabel"
        Me.donationsLabel.Size = New System.Drawing.Size(29, 18)
        Me.donationsLabel.TabIndex = 283
        Me.donationsLabel.Text = "0%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(579, 16)
        Me.Label2.TabIndex = 284
        Me.Label2.Text = "If everyone who is online now donated just $7, our server costs would be covered " &
    "for over a year. "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(21, 246)
        Me.Label3.MaximumSize = New System.Drawing.Size(730, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(729, 48)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'ProgressBarUpdate
        '
        Me.ProgressBarUpdate.Interval = 2
        '
        'diamondBuyBtn
        '
        Me.diamondBuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diamondBuyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diamondBuyBtn.ForeColor = System.Drawing.Color.Gold
        Me.diamondBuyBtn.Image = CType(resources.GetObject("diamondBuyBtn.Image"), System.Drawing.Image)
        Me.diamondBuyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.diamondBuyBtn.Location = New System.Drawing.Point(626, 368)
        Me.diamondBuyBtn.Name = "diamondBuyBtn"
        Me.diamondBuyBtn.Size = New System.Drawing.Size(141, 36)
        Me.diamondBuyBtn.TabIndex = 288
        Me.diamondBuyBtn.Text = "     Donate Now!"
        Me.diamondBuyBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(544, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 24)
        Me.Button1.TabIndex = 289
        Me.Button1.Text = "Not Today"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(21, 337)
        Me.Label4.MaximumSize = New System.Drawing.Size(730, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(588, 16)
        Me.Label4.TabIndex = 290
        Me.Label4.Text = "SPECIAL PROMOTION: GET 20% EXTRA DIAMONDS FOR ALL DONATIONS OF $10 OR MORE!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(620, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 291
        Me.Label5.Text = "What Do These Colors Mean?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(21, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(713, 16)
        Me.Label6.TabIndex = 292
        Me.Label6.Text = "You can disable future reminders from the Settings. The Settings button is locate" &
    "d in the bottom right of the Home screen!"
        '
        'Donations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(779, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.diamondBuyBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.donationsLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.avatarCardBack)
        Me.Controls.Add(Me.cardBack)
        Me.Controls.Add(Me.avatar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Donations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donations"
        Me.TopMost = True
        CType(Me.avatarCardBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents avatarCardBack As System.Windows.Forms.PictureBox
    Friend WithEvents cardBack As System.Windows.Forms.PictureBox
    Friend WithEvents avatar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents donationsLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarUpdate As System.Windows.Forms.Timer
    Friend WithEvents diamondBuyBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
