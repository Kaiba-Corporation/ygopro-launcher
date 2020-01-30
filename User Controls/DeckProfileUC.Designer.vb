<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeckProfileUC
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RatingTxt = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.featuredImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.deckNameTxt = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.featuredImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.RatingTxt)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.featuredImagePictureBox)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.deckNameTxt)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 143)
        Me.Panel2.TabIndex = 2
        '
        'RatingTxt
        '
        Me.RatingTxt.AutoSize = True
        Me.RatingTxt.ForeColor = System.Drawing.Color.Cyan
        Me.RatingTxt.Location = New System.Drawing.Point(2, 120)
        Me.RatingTxt.Name = "RatingTxt"
        Me.RatingTxt.Size = New System.Drawing.Size(93, 13)
        Me.RatingTxt.TabIndex = 8
        Me.RatingTxt.Text = "Rating: Not Rated"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Cyan
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(1, 142)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(98, 1)
        Me.Panel8.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Cyan
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(99, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1, 142)
        Me.Panel6.TabIndex = 6
        '
        'featuredImagePictureBox
        '
        Me.featuredImagePictureBox.Location = New System.Drawing.Point(19, 6)
        Me.featuredImagePictureBox.Name = "featuredImagePictureBox"
        Me.featuredImagePictureBox.Size = New System.Drawing.Size(60, 87)
        Me.featuredImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.featuredImagePictureBox.TabIndex = 0
        Me.featuredImagePictureBox.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 142)
        Me.Panel5.TabIndex = 5
        '
        'deckNameTxt
        '
        Me.deckNameTxt.AutoSize = True
        Me.deckNameTxt.ForeColor = System.Drawing.Color.Cyan
        Me.deckNameTxt.Location = New System.Drawing.Point(2, 101)
        Me.deckNameTxt.Name = "deckNameTxt"
        Me.deckNameTxt.Size = New System.Drawing.Size(74, 13)
        Me.deckNameTxt.TabIndex = 1
        Me.deckNameTxt.Text = "Burning Abyss"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 1)
        Me.Panel4.TabIndex = 4
        '
        'DeckProfileUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel2)
        Me.Name = "DeckProfileUC"
        Me.Size = New System.Drawing.Size(100, 143)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.featuredImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RatingTxt As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents featuredImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents deckNameTxt As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel

End Class
