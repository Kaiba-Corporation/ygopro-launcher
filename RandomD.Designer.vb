<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RandomD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RandomD))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SingleG = New System.Windows.Forms.RadioButton()
        Me.MatchG = New System.Windows.Forms.RadioButton()
        Me.TagG = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cardsOCG = New System.Windows.Forms.RadioButton()
        Me.cardsAll = New System.Windows.Forms.RadioButton()
        Me.cardsTCG = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.banlistTraditional = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.banlistNo = New System.Windows.Forms.RadioButton()
        Me.banlistTCG = New System.Windows.Forms.RadioButton()
        Me.banlistOCG = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rule3 = New System.Windows.Forms.RadioButton()
        Me.rule4 = New System.Windows.Forms.RadioButton()
        Me.rule1 = New System.Windows.Forms.RadioButton()
        Me.rule2 = New System.Windows.Forms.RadioButton()
        Me.rule5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(412, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Find Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.SingleG)
        Me.GroupBox3.Controls.Add(Me.MatchG)
        Me.GroupBox3.Controls.Add(Me.TagG)
        Me.GroupBox3.Location = New System.Drawing.Point(399, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 102)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Game Type:"
        '
        'SingleG
        '
        Me.SingleG.AutoSize = True
        Me.SingleG.Checked = True
        Me.SingleG.ForeColor = System.Drawing.Color.White
        Me.SingleG.Location = New System.Drawing.Point(20, 30)
        Me.SingleG.Name = "SingleG"
        Me.SingleG.Size = New System.Drawing.Size(54, 17)
        Me.SingleG.TabIndex = 7
        Me.SingleG.TabStop = True
        Me.SingleG.Text = "Single"
        Me.SingleG.UseVisualStyleBackColor = True
        '
        'MatchG
        '
        Me.MatchG.AutoSize = True
        Me.MatchG.ForeColor = System.Drawing.Color.White
        Me.MatchG.Location = New System.Drawing.Point(20, 53)
        Me.MatchG.Name = "MatchG"
        Me.MatchG.Size = New System.Drawing.Size(55, 17)
        Me.MatchG.TabIndex = 8
        Me.MatchG.Text = "Match"
        Me.MatchG.UseVisualStyleBackColor = True
        '
        'TagG
        '
        Me.TagG.AutoSize = True
        Me.TagG.ForeColor = System.Drawing.Color.White
        Me.TagG.Location = New System.Drawing.Point(20, 76)
        Me.TagG.Name = "TagG"
        Me.TagG.Size = New System.Drawing.Size(44, 17)
        Me.TagG.TabIndex = 11
        Me.TagG.Text = "Tag"
        Me.TagG.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cardsOCG)
        Me.GroupBox2.Controls.Add(Me.cardsAll)
        Me.GroupBox2.Controls.Add(Me.cardsTCG)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 102)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Allowed Cards:"
        '
        'cardsOCG
        '
        Me.cardsOCG.AutoSize = True
        Me.cardsOCG.ForeColor = System.Drawing.Color.White
        Me.cardsOCG.Location = New System.Drawing.Point(18, 76)
        Me.cardsOCG.Name = "cardsOCG"
        Me.cardsOCG.Size = New System.Drawing.Size(48, 17)
        Me.cardsOCG.TabIndex = 11
        Me.cardsOCG.Text = "OCG"
        Me.cardsOCG.UseVisualStyleBackColor = True
        '
        'cardsAll
        '
        Me.cardsAll.AutoSize = True
        Me.cardsAll.Checked = True
        Me.cardsAll.ForeColor = System.Drawing.Color.White
        Me.cardsAll.Location = New System.Drawing.Point(18, 30)
        Me.cardsAll.Name = "cardsAll"
        Me.cardsAll.Size = New System.Drawing.Size(75, 17)
        Me.cardsAll.TabIndex = 9
        Me.cardsAll.TabStop = True
        Me.cardsAll.Text = "TCG/OCG"
        Me.cardsAll.UseVisualStyleBackColor = True
        '
        'cardsTCG
        '
        Me.cardsTCG.AutoSize = True
        Me.cardsTCG.ForeColor = System.Drawing.Color.White
        Me.cardsTCG.Location = New System.Drawing.Point(18, 53)
        Me.cardsTCG.Name = "cardsTCG"
        Me.cardsTCG.Size = New System.Drawing.Size(47, 17)
        Me.cardsTCG.TabIndex = 10
        Me.cardsTCG.Text = "TCG"
        Me.cardsTCG.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.banlistTraditional)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.banlistNo)
        Me.GroupBox1.Controls.Add(Me.banlistTCG)
        Me.GroupBox1.Controls.Add(Me.banlistOCG)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 124)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'banlistTraditional
        '
        Me.banlistTraditional.AutoSize = True
        Me.banlistTraditional.ForeColor = System.Drawing.Color.White
        Me.banlistTraditional.Location = New System.Drawing.Point(19, 76)
        Me.banlistTraditional.Name = "banlistTraditional"
        Me.banlistTraditional.Size = New System.Drawing.Size(74, 17)
        Me.banlistTraditional.TabIndex = 12
        Me.banlistTraditional.Text = "Traditional"
        Me.banlistTraditional.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Banlist:"
        '
        'banlistNo
        '
        Me.banlistNo.AutoSize = True
        Me.banlistNo.ForeColor = System.Drawing.Color.White
        Me.banlistNo.Location = New System.Drawing.Point(19, 99)
        Me.banlistNo.Name = "banlistNo"
        Me.banlistNo.Size = New System.Drawing.Size(73, 17)
        Me.banlistNo.TabIndex = 10
        Me.banlistNo.Text = "No Banlist"
        Me.banlistNo.UseVisualStyleBackColor = True
        '
        'banlistTCG
        '
        Me.banlistTCG.AutoSize = True
        Me.banlistTCG.Checked = True
        Me.banlistTCG.ForeColor = System.Drawing.Color.White
        Me.banlistTCG.Location = New System.Drawing.Point(19, 30)
        Me.banlistTCG.Name = "banlistTCG"
        Me.banlistTCG.Size = New System.Drawing.Size(47, 17)
        Me.banlistTCG.TabIndex = 7
        Me.banlistTCG.TabStop = True
        Me.banlistTCG.Text = "TCG"
        Me.banlistTCG.UseVisualStyleBackColor = True
        '
        'banlistOCG
        '
        Me.banlistOCG.AutoSize = True
        Me.banlistOCG.ForeColor = System.Drawing.Color.White
        Me.banlistOCG.Location = New System.Drawing.Point(19, 53)
        Me.banlistOCG.Name = "banlistOCG"
        Me.banlistOCG.Size = New System.Drawing.Size(48, 17)
        Me.banlistOCG.TabIndex = 8
        Me.banlistOCG.Text = "OCG"
        Me.banlistOCG.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rule5)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.rule3)
        Me.GroupBox4.Controls.Add(Me.rule4)
        Me.GroupBox4.Controls.Add(Me.rule1)
        Me.GroupBox4.Controls.Add(Me.rule2)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(167, 150)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Master Rules:"
        '
        'rule3
        '
        Me.rule3.AutoSize = True
        Me.rule3.ForeColor = System.Drawing.Color.White
        Me.rule3.Location = New System.Drawing.Point(19, 76)
        Me.rule3.Name = "rule3"
        Me.rule3.Size = New System.Drawing.Size(112, 17)
        Me.rule3.TabIndex = 9
        Me.rule3.Text = "Rule 3 (Pendulum)"
        Me.rule3.UseVisualStyleBackColor = True
        '
        'rule4
        '
        Me.rule4.AutoSize = True
        Me.rule4.Checked = True
        Me.rule4.ForeColor = System.Drawing.Color.White
        Me.rule4.Location = New System.Drawing.Point(19, 99)
        Me.rule4.Name = "rule4"
        Me.rule4.Size = New System.Drawing.Size(90, 17)
        Me.rule4.TabIndex = 10
        Me.rule4.TabStop = True
        Me.rule4.Text = "Rule 4 (Links)"
        Me.rule4.UseVisualStyleBackColor = True
        '
        'rule1
        '
        Me.rule1.AutoSize = True
        Me.rule1.ForeColor = System.Drawing.Color.White
        Me.rule1.Location = New System.Drawing.Point(19, 30)
        Me.rule1.Name = "rule1"
        Me.rule1.Size = New System.Drawing.Size(100, 17)
        Me.rule1.TabIndex = 7
        Me.rule1.Text = "Rule 1 (Original)"
        Me.rule1.UseVisualStyleBackColor = True
        '
        'rule2
        '
        Me.rule2.AutoSize = True
        Me.rule2.ForeColor = System.Drawing.Color.White
        Me.rule2.Location = New System.Drawing.Point(19, 53)
        Me.rule2.Name = "rule2"
        Me.rule2.Size = New System.Drawing.Size(136, 17)
        Me.rule2.TabIndex = 8
        Me.rule2.Text = "Rule 2 (Synchro / XYZ)"
        Me.rule2.UseVisualStyleBackColor = True
        '
        'rule5
        '
        Me.rule5.AutoSize = True
        Me.rule5.ForeColor = System.Drawing.Color.White
        Me.rule5.Location = New System.Drawing.Point(19, 122)
        Me.rule5.Name = "rule5"
        Me.rule5.Size = New System.Drawing.Size(112, 17)
        Me.rule5.TabIndex = 14
        Me.rule5.Text = "Rule 5 (April 2020)"
        Me.rule5.UseVisualStyleBackColor = True
        '
        'RandomD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(495, 157)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RandomD"
        Me.Text = "Random Duel"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SingleG As System.Windows.Forms.RadioButton
    Friend WithEvents MatchG As System.Windows.Forms.RadioButton
    Friend WithEvents TagG As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cardsOCG As System.Windows.Forms.RadioButton
    Friend WithEvents cardsAll As System.Windows.Forms.RadioButton
    Friend WithEvents cardsTCG As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents banlistNo As System.Windows.Forms.RadioButton
    Friend WithEvents banlistTCG As System.Windows.Forms.RadioButton
    Friend WithEvents banlistOCG As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rule3 As RadioButton
    Friend WithEvents rule4 As RadioButton
    Friend WithEvents rule1 As RadioButton
    Friend WithEvents rule2 As RadioButton
    Friend WithEvents banlistTraditional As RadioButton
    Friend WithEvents rule5 As RadioButton
End Class
