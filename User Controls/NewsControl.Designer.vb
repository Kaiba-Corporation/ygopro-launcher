<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewsControl
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
        Me.Panel50 = New System.Windows.Forms.Panel()
        Me.newsId = New System.Windows.Forms.Label()
        Me.newsDelete = New System.Windows.Forms.Button()
        Me.newsReadMore = New System.Windows.Forms.Button()
        Me.newsPost = New System.Windows.Forms.RichTextBox()
        Me.newsDate = New System.Windows.Forms.Label()
        Me.newsTitle = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel52 = New System.Windows.Forms.Panel()
        Me.Panel53 = New System.Windows.Forms.Panel()
        Me.Panel54 = New System.Windows.Forms.Panel()
        Me.Panel55 = New System.Windows.Forms.Panel()
        Me.newsPicture = New System.Windows.Forms.PictureBox()
        Me.Panel50.SuspendLayout()
        CType(Me.newsPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel50
        '
        Me.Panel50.Controls.Add(Me.newsId)
        Me.Panel50.Controls.Add(Me.newsDelete)
        Me.Panel50.Controls.Add(Me.newsReadMore)
        Me.Panel50.Controls.Add(Me.newsPost)
        Me.Panel50.Controls.Add(Me.newsDate)
        Me.Panel50.Controls.Add(Me.newsTitle)
        Me.Panel50.Controls.Add(Me.Panel18)
        Me.Panel50.Controls.Add(Me.Panel1)
        Me.Panel50.Controls.Add(Me.Panel52)
        Me.Panel50.Controls.Add(Me.Panel53)
        Me.Panel50.Controls.Add(Me.Panel54)
        Me.Panel50.Controls.Add(Me.Panel55)
        Me.Panel50.Controls.Add(Me.newsPicture)
        Me.Panel50.Location = New System.Drawing.Point(0, 0)
        Me.Panel50.Name = "Panel50"
        Me.Panel50.Size = New System.Drawing.Size(615, 98)
        Me.Panel50.TabIndex = 280
        '
        'newsId
        '
        Me.newsId.AutoSize = True
        Me.newsId.ForeColor = System.Drawing.Color.Cyan
        Me.newsId.Location = New System.Drawing.Point(462, 6)
        Me.newsId.Name = "newsId"
        Me.newsId.Size = New System.Drawing.Size(0, 13)
        Me.newsId.TabIndex = 284
        Me.newsId.Visible = False
        '
        'newsDelete
        '
        Me.newsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newsDelete.ForeColor = System.Drawing.Color.Cyan
        Me.newsDelete.Location = New System.Drawing.Point(438, 70)
        Me.newsDelete.Name = "newsDelete"
        Me.newsDelete.Size = New System.Drawing.Size(83, 23)
        Me.newsDelete.TabIndex = 283
        Me.newsDelete.Text = "Delete"
        Me.newsDelete.UseVisualStyleBackColor = True
        Me.newsDelete.Visible = False
        '
        'newsReadMore
        '
        Me.newsReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newsReadMore.ForeColor = System.Drawing.Color.Cyan
        Me.newsReadMore.Location = New System.Drawing.Point(527, 70)
        Me.newsReadMore.Name = "newsReadMore"
        Me.newsReadMore.Size = New System.Drawing.Size(83, 23)
        Me.newsReadMore.TabIndex = 282
        Me.newsReadMore.Text = "Read More"
        Me.newsReadMore.UseVisualStyleBackColor = True
        Me.newsReadMore.Visible = False
        '
        'newsPost
        '
        Me.newsPost.BackColor = System.Drawing.Color.Black
        Me.newsPost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.newsPost.ForeColor = System.Drawing.Color.Cyan
        Me.newsPost.Location = New System.Drawing.Point(104, 27)
        Me.newsPost.Name = "newsPost"
        Me.newsPost.ReadOnly = True
        Me.newsPost.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.newsPost.Size = New System.Drawing.Size(508, 64)
        Me.newsPost.TabIndex = 281
        Me.newsPost.Text = ""
        '
        'newsDate
        '
        Me.newsDate.AutoSize = True
        Me.newsDate.ForeColor = System.Drawing.Color.Cyan
        Me.newsDate.Location = New System.Drawing.Point(520, 5)
        Me.newsDate.Name = "newsDate"
        Me.newsDate.Size = New System.Drawing.Size(33, 13)
        Me.newsDate.TabIndex = 280
        Me.newsDate.Text = "Date:"
        '
        'newsTitle
        '
        Me.newsTitle.AutoSize = True
        Me.newsTitle.ForeColor = System.Drawing.Color.Cyan
        Me.newsTitle.Location = New System.Drawing.Point(100, 5)
        Me.newsTitle.Name = "newsTitle"
        Me.newsTitle.Size = New System.Drawing.Size(27, 13)
        Me.newsTitle.TabIndex = 279
        Me.newsTitle.Text = "Title"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Cyan
        Me.Panel18.Location = New System.Drawing.Point(98, 22)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(517, 1)
        Me.Panel18.TabIndex = 278
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Location = New System.Drawing.Point(97, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 97)
        Me.Panel1.TabIndex = 7
        '
        'Panel52
        '
        Me.Panel52.BackColor = System.Drawing.Color.Cyan
        Me.Panel52.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel52.Location = New System.Drawing.Point(1, 97)
        Me.Panel52.Name = "Panel52"
        Me.Panel52.Size = New System.Drawing.Size(613, 1)
        Me.Panel52.TabIndex = 6
        '
        'Panel53
        '
        Me.Panel53.BackColor = System.Drawing.Color.Cyan
        Me.Panel53.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel53.Location = New System.Drawing.Point(614, 1)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(1, 97)
        Me.Panel53.TabIndex = 5
        '
        'Panel54
        '
        Me.Panel54.BackColor = System.Drawing.Color.Cyan
        Me.Panel54.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel54.Location = New System.Drawing.Point(0, 1)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(1, 97)
        Me.Panel54.TabIndex = 4
        '
        'Panel55
        '
        Me.Panel55.BackColor = System.Drawing.Color.Cyan
        Me.Panel55.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel55.Location = New System.Drawing.Point(0, 0)
        Me.Panel55.Name = "Panel55"
        Me.Panel55.Size = New System.Drawing.Size(615, 1)
        Me.Panel55.TabIndex = 3
        '
        'newsPicture
        '
        Me.newsPicture.Location = New System.Drawing.Point(0, 0)
        Me.newsPicture.Name = "newsPicture"
        Me.newsPicture.Size = New System.Drawing.Size(98, 98)
        Me.newsPicture.TabIndex = 8
        Me.newsPicture.TabStop = False
        '
        'NewsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel50)
        Me.Name = "NewsControl"
        Me.Size = New System.Drawing.Size(615, 98)
        Me.Panel50.ResumeLayout(False)
        Me.Panel50.PerformLayout()
        CType(Me.newsPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel50 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel52 As System.Windows.Forms.Panel
    Friend WithEvents Panel53 As System.Windows.Forms.Panel
    Friend WithEvents Panel54 As System.Windows.Forms.Panel
    Friend WithEvents Panel55 As System.Windows.Forms.Panel
    Friend WithEvents newsPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents newsDate As System.Windows.Forms.Label
    Friend WithEvents newsTitle As System.Windows.Forms.Label
    Friend WithEvents newsReadMore As System.Windows.Forms.Button
    Friend WithEvents newsDelete As System.Windows.Forms.Button
    Friend WithEvents newsId As System.Windows.Forms.Label
    Friend WithEvents newsPost As System.Windows.Forms.RichTextBox

End Class
