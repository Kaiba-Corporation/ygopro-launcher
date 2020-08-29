<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PostDuelDeckMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostDuelDeckMessage))
        Me.claimPrizeBtn = New System.Windows.Forms.Button()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.viewDeckBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dontShowAgainChb = New System.Windows.Forms.CheckBox()
        Me.refuseBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.diamondRewardLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deckDeleteTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'claimPrizeBtn
        '
        Me.claimPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.claimPrizeBtn.ForeColor = System.Drawing.Color.Gold
        Me.claimPrizeBtn.Location = New System.Drawing.Point(154, 469)
        Me.claimPrizeBtn.Name = "claimPrizeBtn"
        Me.claimPrizeBtn.Size = New System.Drawing.Size(113, 33)
        Me.claimPrizeBtn.TabIndex = 409
        Me.claimPrizeBtn.Text = "CLAIM PRIZE"
        Me.claimPrizeBtn.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Cyan
        Me.Panel18.Location = New System.Drawing.Point(-15, 460)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(580, 1)
        Me.Panel18.TabIndex = 408
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(20, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 18)
        Me.Label1.TabIndex = 411
        Me.Label1.Text = "Your deck has been chosen to be uploaded to one of our YouTube Channels!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(86, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 39)
        Me.Label2.TabIndex = 413
        Me.Label2.Text = "CONGRATULATIONS"
        '
        'viewDeckBtn
        '
        Me.viewDeckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewDeckBtn.ForeColor = System.Drawing.Color.Cyan
        Me.viewDeckBtn.Location = New System.Drawing.Point(12, 472)
        Me.viewDeckBtn.Name = "viewDeckBtn"
        Me.viewDeckBtn.Size = New System.Drawing.Size(90, 28)
        Me.viewDeckBtn.TabIndex = 414
        Me.viewDeckBtn.Text = "VIEW DECK"
        Me.viewDeckBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(170, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 224)
        Me.PictureBox1.TabIndex = 412
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(30, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 32)
        Me.Label3.TabIndex = 415
        Me.Label3.Text = "-  If you accept the reward, you are giving us permission to upload you deck to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "    YouTube along with some of your past duels!"
        '
        'dontShowAgainChb
        '
        Me.dontShowAgainChb.AutoSize = True
        Me.dontShowAgainChb.ForeColor = System.Drawing.Color.Cyan
        Me.dontShowAgainChb.Location = New System.Drawing.Point(434, 477)
        Me.dontShowAgainChb.Name = "dontShowAgainChb"
        Me.dontShowAgainChb.Size = New System.Drawing.Size(108, 17)
        Me.dontShowAgainChb.TabIndex = 410
        Me.dontShowAgainChb.Text = "Don't show again"
        Me.dontShowAgainChb.UseVisualStyleBackColor = True
        '
        'refuseBtn
        '
        Me.refuseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refuseBtn.ForeColor = System.Drawing.Color.Red
        Me.refuseBtn.Location = New System.Drawing.Point(273, 469)
        Me.refuseBtn.Name = "refuseBtn"
        Me.refuseBtn.Size = New System.Drawing.Size(113, 33)
        Me.refuseBtn.TabIndex = 416
        Me.refuseBtn.Text = "REFUSE"
        Me.refuseBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(270, 397)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 40)
        Me.PictureBox2.TabIndex = 417
        Me.PictureBox2.TabStop = False
        '
        'diamondRewardLbl
        '
        Me.diamondRewardLbl.AutoSize = True
        Me.diamondRewardLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diamondRewardLbl.ForeColor = System.Drawing.Color.Linen
        Me.diamondRewardLbl.Location = New System.Drawing.Point(334, 403)
        Me.diamondRewardLbl.Name = "diamondRewardLbl"
        Me.diamondRewardLbl.Size = New System.Drawing.Size(26, 29)
        Me.diamondRewardLbl.TabIndex = 418
        Me.diamondRewardLbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(137, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 29)
        Me.Label5.TabIndex = 419
        Me.Label5.Text = "REWARD:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(30, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(439, 16)
        Me.Label6.TabIndex = 420
        Me.Label6.Text = "- If you refuse, your deck will not be uploaded and you will get no rewards!"
        '
        'deckDeleteTimer
        '
        Me.deckDeleteTimer.Interval = 7000
        '
        'PostDuelDeckMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(549, 512)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.diamondRewardLbl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.refuseBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.viewDeckBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dontShowAgainChb)
        Me.Controls.Add(Me.claimPrizeBtn)
        Me.Controls.Add(Me.Panel18)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PostDuelDeckMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONGRATULATIONS - YOUR DECK HAS BEEN SELECTED"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents claimPrizeBtn As Button
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents viewDeckBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dontShowAgainChb As CheckBox
    Friend WithEvents refuseBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents diamondRewardLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents deckDeleteTimer As Timer
End Class
