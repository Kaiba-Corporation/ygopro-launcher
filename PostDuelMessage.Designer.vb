<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostDuelMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostDuelMessage))
        Me.xp = New System.Windows.Forms.Label()
        Me.gold = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.okButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.unrankedDuel = New System.Windows.Forms.Label()
        Me.newRating = New System.Windows.Forms.Label()
        Me.image = New System.Windows.Forms.PictureBox()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xp
        '
        Me.xp.AutoSize = True
        Me.xp.BackColor = System.Drawing.Color.Transparent
        Me.xp.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xp.ForeColor = System.Drawing.Color.Gold
        Me.xp.Location = New System.Drawing.Point(405, 193)
        Me.xp.Name = "xp"
        Me.xp.Size = New System.Drawing.Size(48, 26)
        Me.xp.TabIndex = 403
        Me.xp.Text = "999"
        '
        'gold
        '
        Me.gold.AutoSize = True
        Me.gold.BackColor = System.Drawing.Color.Transparent
        Me.gold.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gold.ForeColor = System.Drawing.Color.Gold
        Me.gold.Location = New System.Drawing.Point(292, 193)
        Me.gold.Name = "gold"
        Me.gold.Size = New System.Drawing.Size(48, 26)
        Me.gold.TabIndex = 404
        Me.gold.Text = "999"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Cyan
        Me.Panel18.Location = New System.Drawing.Point(0, 230)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(451, 1)
        Me.Panel18.TabIndex = 405
        '
        'okButton
        '
        Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.okButton.ForeColor = System.Drawing.Color.Cyan
        Me.okButton.Location = New System.Drawing.Point(194, 237)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(40, 28)
        Me.okButton.TabIndex = 406
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Cyan
        Me.CheckBox1.Location = New System.Drawing.Point(331, 244)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox1.TabIndex = 407
        Me.CheckBox1.Text = "Don't show again"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'unrankedDuel
        '
        Me.unrankedDuel.AutoSize = True
        Me.unrankedDuel.BackColor = System.Drawing.Color.Black
        Me.unrankedDuel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unrankedDuel.ForeColor = System.Drawing.Color.Gold
        Me.unrankedDuel.Location = New System.Drawing.Point(220, 136)
        Me.unrankedDuel.Name = "unrankedDuel"
        Me.unrankedDuel.Size = New System.Drawing.Size(156, 29)
        Me.unrankedDuel.TabIndex = 408
        Me.unrankedDuel.Text = "Unranked Duel"
        Me.unrankedDuel.Visible = False
        '
        'newRating
        '
        Me.newRating.AutoSize = True
        Me.newRating.BackColor = System.Drawing.Color.Black
        Me.newRating.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newRating.ForeColor = System.Drawing.Color.Gold
        Me.newRating.Location = New System.Drawing.Point(258, 137)
        Me.newRating.Name = "newRating"
        Me.newRating.Size = New System.Drawing.Size(168, 26)
        Me.newRating.TabIndex = 0
        Me.newRating.Text = "New Rating: 1500"
        Me.newRating.Visible = False
        '
        'image
        '
        Me.image.BackColor = System.Drawing.Color.Black
        Me.image.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources._2s
        Me.image.Location = New System.Drawing.Point(210, 129)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(42, 42)
        Me.image.TabIndex = 402
        Me.image.TabStop = False
        Me.image.Visible = False
        '
        'PostDuelMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(451, 272)
        Me.Controls.Add(Me.unrankedDuel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.gold)
        Me.Controls.Add(Me.xp)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.newRating)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PostDuelMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xp As System.Windows.Forms.Label
    Friend WithEvents gold As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents unrankedDuel As System.Windows.Forms.Label
    Friend WithEvents newRating As System.Windows.Forms.Label
    Friend WithEvents image As System.Windows.Forms.PictureBox
End Class
