<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SinglePlayerDuelPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SinglePlayerDuelPage))
        Me.Buttons1 = New YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.Puzzles = New System.Windows.Forms.PictureBox()
        Me.SkillTests = New System.Windows.Forms.PictureBox()
        Me.DuelingRobot = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Puzzles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkillTests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuelingRobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttons1
        '
        Me.Buttons1.BackColor = System.Drawing.Color.Black
        Me.Buttons1.Location = New System.Drawing.Point(101, 400)
        Me.Buttons1.Name = "Buttons1"
        Me.Buttons1.Size = New System.Drawing.Size(733, 64)
        Me.Buttons1.TabIndex = 5
        Me.Buttons1.Type = "Duel"
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
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(3, 414)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(43, 49)
        Me.BackButton.TabIndex = 9
        Me.BackButton.TabStop = False
        '
        'Puzzles
        '
        Me.Puzzles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Puzzles.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.PuzzlesB
        Me.Puzzles.Location = New System.Drawing.Point(630, 107)
        Me.Puzzles.Name = "Puzzles"
        Me.Puzzles.Size = New System.Drawing.Size(272, 288)
        Me.Puzzles.TabIndex = 7
        Me.Puzzles.TabStop = False
        '
        'SkillTests
        '
        Me.SkillTests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SkillTests.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.SkillTestsB
        Me.SkillTests.Location = New System.Drawing.Point(328, 107)
        Me.SkillTests.Name = "SkillTests"
        Me.SkillTests.Size = New System.Drawing.Size(272, 288)
        Me.SkillTests.TabIndex = 6
        Me.SkillTests.TabStop = False
        '
        'DuelingRobot
        '
        Me.DuelingRobot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DuelingRobot.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.DuelingRobotB
        Me.DuelingRobot.Location = New System.Drawing.Point(25, 107)
        Me.DuelingRobot.Name = "DuelingRobot"
        Me.DuelingRobot.Size = New System.Drawing.Size(272, 288)
        Me.DuelingRobot.TabIndex = 1
        Me.DuelingRobot.TabStop = False
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
        'SinglePlayerDuelPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Puzzles)
        Me.Controls.Add(Me.SkillTests)
        Me.Controls.Add(Me.Buttons1)
        Me.Controls.Add(Me.DuelingRobot)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SinglePlayerDuelPage"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Size = New System.Drawing.Size(927, 467)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Puzzles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkillTests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuelingRobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DuelingRobot As System.Windows.Forms.PictureBox
    Friend WithEvents Buttons1 As YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons
    Friend WithEvents SkillTests As System.Windows.Forms.PictureBox
    Friend WithEvents Puzzles As System.Windows.Forms.PictureBox
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox

End Class
