<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamsStorePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeamsStorePage))
        Me.itemCantBuy = New System.Windows.Forms.Label()
        Me.itemNameOnlyLabel = New System.Windows.Forms.Label()
        Me.moreInfoLink = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DiamondLabel = New System.Windows.Forms.Label()
        Me.goldLabel = New System.Windows.Forms.Label()
        Me.itemNameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.teamQuote = New System.Windows.Forms.PictureBox()
        Me.teamMembersBonus = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.diamondBuyBtn = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.goldBuyBtn = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.itemImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel7.SuspendLayout()
        CType(Me.teamQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teamMembersBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemCantBuy
        '
        Me.itemCantBuy.AutoSize = True
        Me.itemCantBuy.ForeColor = System.Drawing.Color.Red
        Me.itemCantBuy.Location = New System.Drawing.Point(73, 210)
        Me.itemCantBuy.Name = "itemCantBuy"
        Me.itemCantBuy.Size = New System.Drawing.Size(105, 13)
        Me.itemCantBuy.TabIndex = 292
        Me.itemCantBuy.Text = "Item Already Owned!"
        Me.itemCantBuy.Visible = False
        '
        'itemNameOnlyLabel
        '
        Me.itemNameOnlyLabel.AutoSize = True
        Me.itemNameOnlyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemNameOnlyLabel.ForeColor = System.Drawing.Color.Cyan
        Me.itemNameOnlyLabel.Location = New System.Drawing.Point(17, 239)
        Me.itemNameOnlyLabel.Name = "itemNameOnlyLabel"
        Me.itemNameOnlyLabel.Size = New System.Drawing.Size(160, 18)
        Me.itemNameOnlyLabel.TabIndex = 290
        Me.itemNameOnlyLabel.Text = "Team Members Bonus"
        Me.itemNameOnlyLabel.Visible = False
        '
        'moreInfoLink
        '
        Me.moreInfoLink.AutoSize = True
        Me.moreInfoLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moreInfoLink.ForeColor = System.Drawing.Color.Cyan
        Me.moreInfoLink.Location = New System.Drawing.Point(17, 262)
        Me.moreInfoLink.Name = "moreInfoLink"
        Me.moreInfoLink.Size = New System.Drawing.Size(417, 18)
        Me.moreInfoLink.TabIndex = 289
        Me.moreInfoLink.Text = "http://ygopro.club/index.php?/topic/3513-team-members-bonus/"
        Me.moreInfoLink.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Cyan
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(121, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 24)
        Me.Button2.TabIndex = 288
        Me.Button2.Text = "View More Information"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DiamondLabel
        '
        Me.DiamondLabel.AutoSize = True
        Me.DiamondLabel.BackColor = System.Drawing.Color.Transparent
        Me.DiamondLabel.ForeColor = System.Drawing.Color.Cyan
        Me.DiamondLabel.Location = New System.Drawing.Point(156, 177)
        Me.DiamondLabel.Name = "DiamondLabel"
        Me.DiamondLabel.Size = New System.Drawing.Size(25, 13)
        Me.DiamondLabel.TabIndex = 286
        Me.DiamondLabel.Text = "290"
        '
        'goldLabel
        '
        Me.goldLabel.AutoSize = True
        Me.goldLabel.BackColor = System.Drawing.Color.Transparent
        Me.goldLabel.ForeColor = System.Drawing.Color.Cyan
        Me.goldLabel.Location = New System.Drawing.Point(63, 177)
        Me.goldLabel.Name = "goldLabel"
        Me.goldLabel.Size = New System.Drawing.Size(31, 13)
        Me.goldLabel.TabIndex = 283
        Me.goldLabel.Text = "7000"
        '
        'itemNameLabel
        '
        Me.itemNameLabel.AutoSize = True
        Me.itemNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemNameLabel.ForeColor = System.Drawing.Color.Cyan
        Me.itemNameLabel.Location = New System.Drawing.Point(17, 132)
        Me.itemNameLabel.Name = "itemNameLabel"
        Me.itemNameLabel.Size = New System.Drawing.Size(240, 18)
        Me.itemNameLabel.TabIndex = 281
        Me.itemNameLabel.Text = "Item Name: Team Members Bonus"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 1)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Cyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(259, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 296)
        Me.Panel3.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 296)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(260, 1)
        Me.Panel5.TabIndex = 3
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Cyan
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(1, 296)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(520, 1)
        Me.Panel11.TabIndex = 6
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Cyan
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(521, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 296)
        Me.Panel10.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Cyan
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1, 296)
        Me.Panel9.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Cyan
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(522, 1)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Controls.Add(Me.teamQuote)
        Me.Panel7.Controls.Add(Me.teamMembersBonus)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(522, 297)
        Me.Panel7.TabIndex = 272
        '
        'teamQuote
        '
        Me.teamQuote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.teamQuote.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.Item_TeamQuote
        Me.teamQuote.Location = New System.Drawing.Point(245, 18)
        Me.teamQuote.Name = "teamQuote"
        Me.teamQuote.Size = New System.Drawing.Size(220, 103)
        Me.teamQuote.TabIndex = 8
        Me.teamQuote.TabStop = False
        Me.teamQuote.Visible = False
        '
        'teamMembersBonus
        '
        Me.teamMembersBonus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.teamMembersBonus.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.Item_TeamMembersBonus
        Me.teamMembersBonus.Location = New System.Drawing.Point(19, 18)
        Me.teamMembersBonus.Name = "teamMembersBonus"
        Me.teamMembersBonus.Size = New System.Drawing.Size(220, 103)
        Me.teamMembersBonus.TabIndex = 7
        Me.teamMembersBonus.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.itemCantBuy)
        Me.Panel1.Controls.Add(Me.itemNameOnlyLabel)
        Me.Panel1.Controls.Add(Me.moreInfoLink)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.diamondBuyBtn)
        Me.Panel1.Controls.Add(Me.DiamondLabel)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.goldBuyBtn)
        Me.Panel1.Controls.Add(Me.goldLabel)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.itemNameLabel)
        Me.Panel1.Controls.Add(Me.itemImagePictureBox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(528, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 297)
        Me.Panel1.TabIndex = 273
        '
        'diamondBuyBtn
        '
        Me.diamondBuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diamondBuyBtn.ForeColor = System.Drawing.Color.Cyan
        Me.diamondBuyBtn.Image = CType(resources.GetObject("diamondBuyBtn.Image"), System.Drawing.Image)
        Me.diamondBuyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.diamondBuyBtn.Location = New System.Drawing.Point(137, 204)
        Me.diamondBuyBtn.Name = "diamondBuyBtn"
        Me.diamondBuyBtn.Size = New System.Drawing.Size(58, 24)
        Me.diamondBuyBtn.TabIndex = 287
        Me.diamondBuyBtn.Text = "     Buy"
        Me.diamondBuyBtn.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(137, 175)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox7.TabIndex = 285
        Me.PictureBox7.TabStop = False
        '
        'goldBuyBtn
        '
        Me.goldBuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.goldBuyBtn.ForeColor = System.Drawing.Color.Cyan
        Me.goldBuyBtn.Image = CType(resources.GetObject("goldBuyBtn.Image"), System.Drawing.Image)
        Me.goldBuyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goldBuyBtn.Location = New System.Drawing.Point(45, 204)
        Me.goldBuyBtn.Name = "goldBuyBtn"
        Me.goldBuyBtn.Size = New System.Drawing.Size(58, 24)
        Me.goldBuyBtn.TabIndex = 284
        Me.goldBuyBtn.Text = "     Buy"
        Me.goldBuyBtn.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(44, 175)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox6.TabIndex = 282
        Me.PictureBox6.TabStop = False
        '
        'itemImagePictureBox
        '
        Me.itemImagePictureBox.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.Item_TeamMembersBonus
        Me.itemImagePictureBox.Location = New System.Drawing.Point(20, 18)
        Me.itemImagePictureBox.Name = "itemImagePictureBox"
        Me.itemImagePictureBox.Size = New System.Drawing.Size(220, 103)
        Me.itemImagePictureBox.TabIndex = 9
        Me.itemImagePictureBox.TabStop = False
        '
        'TeamsStorePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TeamsStorePage"
        Me.Size = New System.Drawing.Size(788, 297)
        Me.Panel7.ResumeLayout(False)
        CType(Me.teamQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teamMembersBonus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents itemCantBuy As System.Windows.Forms.Label
    Friend WithEvents itemNameOnlyLabel As System.Windows.Forms.Label
    Friend WithEvents moreInfoLink As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents diamondBuyBtn As System.Windows.Forms.Button
    Friend WithEvents DiamondLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents goldBuyBtn As System.Windows.Forms.Button
    Friend WithEvents goldLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents itemNameLabel As System.Windows.Forms.Label
    Friend WithEvents itemImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents teamMembersBonus As System.Windows.Forms.PictureBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents teamQuote As System.Windows.Forms.PictureBox

End Class
