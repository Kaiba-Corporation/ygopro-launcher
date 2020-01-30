<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TournamentList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TournamentList))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.separatorPanel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TournamentPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Buttons1 = New YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(927, 69)
        Me.PictureBox2.TabIndex = 326
        Me.PictureBox2.TabStop = False
        '
        'separatorPanel
        '
        Me.separatorPanel.BackColor = System.Drawing.Color.Cyan
        Me.separatorPanel.Location = New System.Drawing.Point(-8, 384)
        Me.separatorPanel.Name = "separatorPanel"
        Me.separatorPanel.Size = New System.Drawing.Size(950, 1)
        Me.separatorPanel.TabIndex = 328
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.BackB
        Me.BackButton.Location = New System.Drawing.Point(3, 414)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(43, 49)
        Me.BackButton.TabIndex = 331
        Me.BackButton.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(924, 69)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 333
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 69)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 332
        Me.PictureBox4.TabStop = False
        '
        'TournamentPanel
        '
        Me.TournamentPanel.Location = New System.Drawing.Point(5, 70)
        Me.TournamentPanel.Name = "TournamentPanel"
        Me.TournamentPanel.Size = New System.Drawing.Size(896, 310)
        Me.TournamentPanel.TabIndex = 335
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Location = New System.Drawing.Point(-8, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 1)
        Me.Panel1.TabIndex = 336
        '
        'Buttons1
        '
        Me.Buttons1.BackColor = System.Drawing.Color.Black
        Me.Buttons1.Location = New System.Drawing.Point(101, 400)
        Me.Buttons1.Name = "Buttons1"
        Me.Buttons1.Size = New System.Drawing.Size(733, 64)
        Me.Buttons1.TabIndex = 330
        Me.Buttons1.Type = "Duel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(318, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 13)
        Me.Label2.TabIndex = 337
        Me.Label2.Text = "These tournaments are brought to you by Fleur Delacour"
        '
        'TournamentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.separatorPanel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TournamentPanel)
        Me.Controls.Add(Me.Buttons1)
        Me.Name = "TournamentList"
        Me.Size = New System.Drawing.Size(927, 467)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents separatorPanel As System.Windows.Forms.Panel
    Friend WithEvents Buttons1 As YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TournamentPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
