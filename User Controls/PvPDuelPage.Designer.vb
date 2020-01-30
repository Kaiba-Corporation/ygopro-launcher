<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PvPDuelPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PvPDuelPage))
        Me.Buttons1 = New YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons()
        Me.Tournaments = New System.Windows.Forms.PictureBox()
        Me.Ranked = New System.Windows.Forms.PictureBox()
        Me.Unranked = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Tournaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ranked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Unranked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttons1
        '
        Me.Buttons1.BackColor = System.Drawing.Color.Black
        Me.Buttons1.Location = New System.Drawing.Point(101, 400)
        Me.Buttons1.Name = "Buttons1"
        Me.Buttons1.Size = New System.Drawing.Size(733, 64)
        Me.Buttons1.TabIndex = 92
        Me.Buttons1.Type = "Duel"
        '
        'Tournaments
        '
        Me.Tournaments.BackColor = System.Drawing.Color.Black
        Me.Tournaments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tournaments.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.TournamentB
        Me.Tournaments.Location = New System.Drawing.Point(635, 107)
        Me.Tournaments.Name = "Tournaments"
        Me.Tournaments.Size = New System.Drawing.Size(284, 288)
        Me.Tournaments.TabIndex = 96
        Me.Tournaments.TabStop = False
        '
        'Ranked
        '
        Me.Ranked.BackColor = System.Drawing.Color.Black
        Me.Ranked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ranked.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.RankedB
        Me.Ranked.Location = New System.Drawing.Point(330, 107)
        Me.Ranked.Name = "Ranked"
        Me.Ranked.Size = New System.Drawing.Size(284, 288)
        Me.Ranked.TabIndex = 95
        Me.Ranked.TabStop = False
        '
        'Unranked
        '
        Me.Unranked.BackColor = System.Drawing.Color.Black
        Me.Unranked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Unranked.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.UnrankedB
        Me.Unranked.Location = New System.Drawing.Point(20, 107)
        Me.Unranked.Name = "Unranked"
        Me.Unranked.Size = New System.Drawing.Size(284, 288)
        Me.Unranked.TabIndex = 94
        Me.Unranked.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(3, 414)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(43, 49)
        Me.BackButton.TabIndex = 93
        Me.BackButton.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(924, 69)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 91
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 69)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 90
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
        'PvPDuelPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Buttons1)
        Me.Controls.Add(Me.Tournaments)
        Me.Controls.Add(Me.Ranked)
        Me.Controls.Add(Me.Unranked)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PvPDuelPage"
        Me.Size = New System.Drawing.Size(927, 467)
        CType(Me.Tournaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ranked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Unranked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents Buttons1 As YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons
    Friend WithEvents Unranked As System.Windows.Forms.PictureBox
    Friend WithEvents Ranked As System.Windows.Forms.PictureBox
    Friend WithEvents Tournaments As System.Windows.Forms.PictureBox

End Class
