<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadDeckReplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadDeckReplay))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.fileName = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.deckExists = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(16, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "Deck Name:"
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.Cyan
        Me.Panel44.Location = New System.Drawing.Point(262, 9)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(1, 19)
        Me.Panel44.TabIndex = 252
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.Cyan
        Me.Panel45.Location = New System.Drawing.Point(106, 9)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(1, 19)
        Me.Panel45.TabIndex = 251
        '
        'Panel46
        '
        Me.Panel46.BackColor = System.Drawing.Color.Cyan
        Me.Panel46.Location = New System.Drawing.Point(107, 27)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(155, 1)
        Me.Panel46.TabIndex = 250
        '
        'Panel47
        '
        Me.Panel47.BackColor = System.Drawing.Color.Cyan
        Me.Panel47.Location = New System.Drawing.Point(107, 9)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(155, 1)
        Me.Panel47.TabIndex = 249
        '
        'fileName
        '
        Me.fileName.BackColor = System.Drawing.Color.Black
        Me.fileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fileName.ForeColor = System.Drawing.Color.Cyan
        Me.fileName.Location = New System.Drawing.Point(109, 12)
        Me.fileName.MaxLength = 17
        Me.fileName.Name = "fileName"
        Me.fileName.Size = New System.Drawing.Size(152, 13)
        Me.fileName.TabIndex = 248
        '
        'Save
        '
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ForeColor = System.Drawing.Color.Cyan
        Me.Save.Location = New System.Drawing.Point(189, 34)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(74, 24)
        Me.Save.TabIndex = 256
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'deckExists
        '
        Me.deckExists.AutoSize = True
        Me.deckExists.ForeColor = System.Drawing.Color.Red
        Me.deckExists.Location = New System.Drawing.Point(82, 40)
        Me.deckExists.Name = "deckExists"
        Me.deckExists.Size = New System.Drawing.Size(101, 13)
        Me.deckExists.TabIndex = 257
        Me.deckExists.Text = "Deck Already Exists"
        Me.deckExists.Visible = False
        '
        'DownloadDeckReplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(278, 73)
        Me.Controls.Add(Me.deckExists)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel44)
        Me.Controls.Add(Me.Panel45)
        Me.Controls.Add(Me.Panel46)
        Me.Controls.Add(Me.Panel47)
        Me.Controls.Add(Me.fileName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DownloadDeckReplay"
        Me.Text = "Confirm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel44 As System.Windows.Forms.Panel
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents Panel46 As System.Windows.Forms.Panel
    Friend WithEvents Panel47 As System.Windows.Forms.Panel
    Friend WithEvents fileName As System.Windows.Forms.TextBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents deckExists As System.Windows.Forms.Label
End Class
