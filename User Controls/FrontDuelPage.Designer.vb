<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontDuelPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontDuelPage))
        Me.Buttons1 = New YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons()
        Me.PvP = New System.Windows.Forms.PictureBox()
        Me.SinglePlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.questionTxt = New System.Windows.Forms.RichTextBox()
        Me.answerTxt = New System.Windows.Forms.RichTextBox()
        CType(Me.PvP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinglePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttons1
        '
        Me.Buttons1.BackColor = System.Drawing.Color.Black
        Me.Buttons1.Location = New System.Drawing.Point(101, 414)
        Me.Buttons1.Name = "Buttons1"
        Me.Buttons1.Size = New System.Drawing.Size(733, 64)
        Me.Buttons1.TabIndex = 3
        Me.Buttons1.Type = "Duel"
        '
        'PvP
        '
        Me.PvP.BackColor = System.Drawing.Color.Black
        Me.PvP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PvP.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.PvPB
        Me.PvP.Location = New System.Drawing.Point(534, 105)
        Me.PvP.Name = "PvP"
        Me.PvP.Size = New System.Drawing.Size(298, 320)
        Me.PvP.TabIndex = 2
        Me.PvP.TabStop = False
        '
        'SinglePlayer
        '
        Me.SinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SinglePlayer.Image = Global.YGOPRO_The_Dawn_of_a_New_Era_Launcher.My.Resources.Resources.SinglePlayerB
        Me.SinglePlayer.Location = New System.Drawing.Point(65, 105)
        Me.SinglePlayer.Name = "SinglePlayer"
        Me.SinglePlayer.Size = New System.Drawing.Size(298, 320)
        Me.SinglePlayer.TabIndex = 1
        Me.SinglePlayer.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(927, 103)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 89
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(924, 103)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(3, 389)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 90
        Me.PictureBox5.TabStop = False
        '
        'questionTxt
        '
        Me.questionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.questionTxt.Location = New System.Drawing.Point(239, 60)
        Me.questionTxt.Name = "questionTxt"
        Me.questionTxt.Size = New System.Drawing.Size(177, 28)
        Me.questionTxt.TabIndex = 91
        Me.questionTxt.Text = ""
        '
        'answerTxt
        '
        Me.answerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.answerTxt.Location = New System.Drawing.Point(542, 52)
        Me.answerTxt.Name = "answerTxt"
        Me.answerTxt.Size = New System.Drawing.Size(177, 28)
        Me.answerTxt.TabIndex = 92
        Me.answerTxt.Text = ""
        '
        'FrontDuelPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.answerTxt)
        Me.Controls.Add(Me.questionTxt)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Buttons1)
        Me.Controls.Add(Me.SinglePlayer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PvP)
        Me.Name = "FrontDuelPage"
        Me.Size = New System.Drawing.Size(927, 467)
        CType(Me.PvP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinglePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SinglePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents PvP As System.Windows.Forms.PictureBox
    Friend WithEvents Buttons1 As YGOPRO_The_Dawn_of_a_New_Era_Launcher.Buttons
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents questionTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents answerTxt As System.Windows.Forms.RichTextBox

End Class
