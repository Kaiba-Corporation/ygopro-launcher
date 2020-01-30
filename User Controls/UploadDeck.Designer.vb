<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadDeck
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
        Me.DeckFile = New System.Windows.Forms.OpenFileDialog()
        Me.banlist = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.deckType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.shareWith = New System.Windows.Forms.ComboBox()
        Me.deckImage = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.featuredImage = New System.Windows.Forms.ComboBox()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.deckName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.sharedTxt = New System.Windows.Forms.TextBox()
        Me.hidePanel = New System.Windows.Forms.Panel()
        Me.upload = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.selectDeck = New System.Windows.Forms.ComboBox()
        Me.leftImageButton = New System.Windows.Forms.Button()
        Me.rightImageButton = New System.Windows.Forms.Button()
        Me.hidePanel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.banlistTxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.deckDescription = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.charactersLbl = New System.Windows.Forms.Label()
        CType(Me.deckImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeckFile
        '
        Me.DeckFile.FileName = "Deck"
        '
        'banlist
        '
        Me.banlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.banlist.FormattingEnabled = True
        Me.banlist.Location = New System.Drawing.Point(309, 104)
        Me.banlist.Name = "banlist"
        Me.banlist.Size = New System.Drawing.Size(157, 21)
        Me.banlist.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(219, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 221
        Me.Label9.Text = "Banlist:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(219, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 234
        Me.Label2.Text = "Deck Type:"
        '
        'deckType
        '
        Me.deckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deckType.FormattingEnabled = True
        Me.deckType.Items.AddRange(New Object() {"Meta", "Non-Meta", "Anime"})
        Me.deckType.Location = New System.Drawing.Point(309, 131)
        Me.deckType.Name = "deckType"
        Me.deckType.Size = New System.Drawing.Size(157, 21)
        Me.deckType.TabIndex = 233
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(219, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 236
        Me.Label3.Text = "Share With:"
        '
        'shareWith
        '
        Me.shareWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.shareWith.FormattingEnabled = True
        Me.shareWith.Items.AddRange(New Object() {"Everyone", "Specific User"})
        Me.shareWith.Location = New System.Drawing.Point(309, 158)
        Me.shareWith.Name = "shareWith"
        Me.shareWith.Size = New System.Drawing.Size(157, 21)
        Me.shareWith.TabIndex = 235
        '
        'deckImage
        '
        Me.deckImage.Location = New System.Drawing.Point(19, 19)
        Me.deckImage.Name = "deckImage"
        Me.deckImage.Size = New System.Drawing.Size(177, 254)
        Me.deckImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deckImage.TabIndex = 239
        Me.deckImage.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(219, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 241
        Me.Label5.Text = "Featured Image:"
        '
        'featuredImage
        '
        Me.featuredImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.featuredImage.FormattingEnabled = True
        Me.featuredImage.Items.AddRange(New Object() {"Card Image", "Field Image", "Special Image"})
        Me.featuredImage.Location = New System.Drawing.Point(309, 77)
        Me.featuredImage.Name = "featuredImage"
        Me.featuredImage.Size = New System.Drawing.Size(157, 21)
        Me.featuredImage.TabIndex = 240
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.Cyan
        Me.Panel44.Location = New System.Drawing.Point(465, 50)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(1, 19)
        Me.Panel44.TabIndex = 246
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.Cyan
        Me.Panel45.Location = New System.Drawing.Point(309, 50)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(1, 19)
        Me.Panel45.TabIndex = 245
        '
        'Panel46
        '
        Me.Panel46.BackColor = System.Drawing.Color.Cyan
        Me.Panel46.Location = New System.Drawing.Point(310, 68)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(155, 1)
        Me.Panel46.TabIndex = 244
        '
        'Panel47
        '
        Me.Panel47.BackColor = System.Drawing.Color.Cyan
        Me.Panel47.Location = New System.Drawing.Point(310, 50)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(155, 1)
        Me.Panel47.TabIndex = 243
        '
        'deckName
        '
        Me.deckName.BackColor = System.Drawing.Color.Black
        Me.deckName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.deckName.ForeColor = System.Drawing.Color.Cyan
        Me.deckName.Location = New System.Drawing.Point(312, 53)
        Me.deckName.MaxLength = 17
        Me.deckName.Name = "deckName"
        Me.deckName.Size = New System.Drawing.Size(152, 13)
        Me.deckName.TabIndex = 242
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(219, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 247
        Me.Label4.Text = "Deck Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(488, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 253
        Me.Label6.Text = "Username:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Location = New System.Drawing.Point(662, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 19)
        Me.Panel1.TabIndex = 252
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Location = New System.Drawing.Point(552, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 19)
        Me.Panel2.TabIndex = 251
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Cyan
        Me.Panel3.Location = New System.Drawing.Point(553, 176)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(109, 1)
        Me.Panel3.TabIndex = 250
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.Location = New System.Drawing.Point(553, 158)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(109, 1)
        Me.Panel4.TabIndex = 249
        '
        'sharedTxt
        '
        Me.sharedTxt.BackColor = System.Drawing.Color.Black
        Me.sharedTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sharedTxt.ForeColor = System.Drawing.Color.Cyan
        Me.sharedTxt.Location = New System.Drawing.Point(555, 161)
        Me.sharedTxt.Name = "sharedTxt"
        Me.sharedTxt.Size = New System.Drawing.Size(105, 13)
        Me.sharedTxt.TabIndex = 248
        '
        'hidePanel
        '
        Me.hidePanel.Location = New System.Drawing.Point(472, 146)
        Me.hidePanel.Name = "hidePanel"
        Me.hidePanel.Size = New System.Drawing.Size(208, 31)
        Me.hidePanel.TabIndex = 254
        '
        'upload
        '
        Me.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.upload.ForeColor = System.Drawing.Color.Cyan
        Me.upload.Location = New System.Drawing.Point(402, 279)
        Me.upload.Name = "upload"
        Me.upload.Size = New System.Drawing.Size(64, 24)
        Me.upload.TabIndex = 255
        Me.upload.Text = "Upload"
        Me.upload.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(219, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 259
        Me.Label8.Text = "Select Deck:"
        '
        'selectDeck
        '
        Me.selectDeck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectDeck.FormattingEnabled = True
        Me.selectDeck.Location = New System.Drawing.Point(309, 23)
        Me.selectDeck.Name = "selectDeck"
        Me.selectDeck.Size = New System.Drawing.Size(157, 21)
        Me.selectDeck.TabIndex = 258
        '
        'leftImageButton
        '
        Me.leftImageButton.Enabled = False
        Me.leftImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leftImageButton.ForeColor = System.Drawing.Color.Cyan
        Me.leftImageButton.Location = New System.Drawing.Point(19, 279)
        Me.leftImageButton.Name = "leftImageButton"
        Me.leftImageButton.Size = New System.Drawing.Size(34, 24)
        Me.leftImageButton.TabIndex = 260
        Me.leftImageButton.Text = "<"
        Me.leftImageButton.UseVisualStyleBackColor = True
        '
        'rightImageButton
        '
        Me.rightImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rightImageButton.ForeColor = System.Drawing.Color.Cyan
        Me.rightImageButton.Location = New System.Drawing.Point(162, 279)
        Me.rightImageButton.Name = "rightImageButton"
        Me.rightImageButton.Size = New System.Drawing.Size(34, 24)
        Me.rightImageButton.TabIndex = 261
        Me.rightImageButton.Text = ">"
        Me.rightImageButton.UseVisualStyleBackColor = True
        '
        'hidePanel2
        '
        Me.hidePanel2.Location = New System.Drawing.Point(472, 104)
        Me.hidePanel2.Name = "hidePanel2"
        Me.hidePanel2.Size = New System.Drawing.Size(208, 31)
        Me.hidePanel2.TabIndex = 268
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(505, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 267
        Me.Label1.Text = "Banlist:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Cyan
        Me.Panel6.Location = New System.Drawing.Point(662, 104)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1, 19)
        Me.Panel6.TabIndex = 266
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Cyan
        Me.Panel7.Location = New System.Drawing.Point(552, 104)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 19)
        Me.Panel7.TabIndex = 265
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Cyan
        Me.Panel8.Location = New System.Drawing.Point(553, 122)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(109, 1)
        Me.Panel8.TabIndex = 264
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Cyan
        Me.Panel9.Location = New System.Drawing.Point(553, 104)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(109, 1)
        Me.Panel9.TabIndex = 263
        '
        'banlistTxt
        '
        Me.banlistTxt.BackColor = System.Drawing.Color.Black
        Me.banlistTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.banlistTxt.ForeColor = System.Drawing.Color.Cyan
        Me.banlistTxt.Location = New System.Drawing.Point(555, 107)
        Me.banlistTxt.Name = "banlistTxt"
        Me.banlistTxt.Size = New System.Drawing.Size(105, 13)
        Me.banlistTxt.TabIndex = 262
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Cyan
        Me.Label15.Location = New System.Drawing.Point(219, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 275
        Me.Label15.Text = "Deck Description:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.Location = New System.Drawing.Point(222, 271)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(244, 1)
        Me.Panel5.TabIndex = 274
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Cyan
        Me.Panel10.Location = New System.Drawing.Point(465, 208)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 63)
        Me.Panel10.TabIndex = 273
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Cyan
        Me.Panel11.Location = New System.Drawing.Point(222, 208)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(243, 1)
        Me.Panel11.TabIndex = 272
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Cyan
        Me.Panel12.Location = New System.Drawing.Point(222, 208)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1, 63)
        Me.Panel12.TabIndex = 271
        '
        'deckDescription
        '
        Me.deckDescription.BackColor = System.Drawing.Color.Black
        Me.deckDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.deckDescription.ForeColor = System.Drawing.Color.Cyan
        Me.deckDescription.Location = New System.Drawing.Point(225, 210)
        Me.deckDescription.Multiline = False
        Me.deckDescription.Name = "deckDescription"
        Me.deckDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.deckDescription.Size = New System.Drawing.Size(239, 60)
        Me.deckDescription.TabIndex = 270
        Me.deckDescription.Text = ""
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(332, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 276
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'charactersLbl
        '
        Me.charactersLbl.AutoSize = True
        Me.charactersLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.charactersLbl.ForeColor = System.Drawing.Color.Cyan
        Me.charactersLbl.Location = New System.Drawing.Point(219, 279)
        Me.charactersLbl.Name = "charactersLbl"
        Me.charactersLbl.Size = New System.Drawing.Size(87, 13)
        Me.charactersLbl.TabIndex = 277
        Me.charactersLbl.Text = "Characters: 0/50"
        '
        'UploadDeck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.charactersLbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.deckDescription)
        Me.Controls.Add(Me.hidePanel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.banlistTxt)
        Me.Controls.Add(Me.rightImageButton)
        Me.Controls.Add(Me.leftImageButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.selectDeck)
        Me.Controls.Add(Me.upload)
        Me.Controls.Add(Me.hidePanel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.sharedTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel44)
        Me.Controls.Add(Me.Panel45)
        Me.Controls.Add(Me.Panel46)
        Me.Controls.Add(Me.Panel47)
        Me.Controls.Add(Me.deckName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.featuredImage)
        Me.Controls.Add(Me.deckImage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.shareWith)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.deckType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.banlist)
        Me.Name = "UploadDeck"
        Me.Size = New System.Drawing.Size(982, 592)
        CType(Me.deckImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeckFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents banlist As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents deckType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents shareWith As System.Windows.Forms.ComboBox
    Friend WithEvents deckImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents featuredImage As System.Windows.Forms.ComboBox
    Friend WithEvents Panel44 As System.Windows.Forms.Panel
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents Panel46 As System.Windows.Forms.Panel
    Friend WithEvents Panel47 As System.Windows.Forms.Panel
    Friend WithEvents deckName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents sharedTxt As System.Windows.Forms.TextBox
    Friend WithEvents hidePanel As System.Windows.Forms.Panel
    Friend WithEvents upload As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents selectDeck As System.Windows.Forms.ComboBox
    Friend WithEvents leftImageButton As System.Windows.Forms.Button
    Friend WithEvents rightImageButton As System.Windows.Forms.Button
    Friend WithEvents hidePanel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents banlistTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents deckDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents charactersLbl As Label
End Class
