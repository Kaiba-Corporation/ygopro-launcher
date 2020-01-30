Public Class JARVIS
    Public ix1 As Integer = 1
    Private Sub JARVIS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ix1 = 0 Then
            PictureBox1.Image = My.Resources.arcr1
            ix1 = 1
        Else
            PictureBox1.Image = My.Resources.arcr2
            ix1 = 0
        End If
    End Sub

#Region "Interface"
    Private Sub JARVIS_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Panel6.BackColor = Color.Cyan
        Panel7.BackColor = Color.Cyan
        Panel8.BackColor = Color.Cyan
        Panel9.BackColor = Color.Cyan
        Label12.ForeColor = Color.Cyan
        Panel10.BackColor = Color.Cyan
        Panel11.BackColor = Color.Cyan
        Panel12.BackColor = Color.Cyan
        Panel13.BackColor = Color.Cyan
        Label13.ForeColor = Color.Cyan
        Panel13.BackColor = Color.Cyan
        Panel6.BackColor = Color.Cyan
        Panel7.BackColor = Color.Cyan
        Panel8.BackColor = Color.Cyan
        Panel9.BackColor = Color.Cyan
        Label12.ForeColor = Color.Cyan
        Panel10.BackColor = Color.Cyan
        Panel11.BackColor = Color.Cyan
        Panel12.BackColor = Color.Cyan
        Panel13.BackColor = Color.Cyan
        Label13.ForeColor = Color.Cyan
        Panel26.BackColor = Color.Cyan
        Panel27.BackColor = Color.Cyan
        Panel28.BackColor = Color.Cyan
        Panel29.BackColor = Color.Cyan
        Label9.ForeColor = Color.Cyan
        Panel22.BackColor = Color.Cyan
        Panel23.BackColor = Color.Cyan
        Panel24.BackColor = Color.Cyan
        Panel25.BackColor = Color.Cyan
        Label8.ForeColor = Color.Cyan
        Panel18.BackColor = Color.Cyan
        Panel19.BackColor = Color.Cyan
        Panel20.BackColor = Color.Cyan
        Panel21.BackColor = Color.Cyan
        Label7.ForeColor = Color.Cyan
        Panel30.BackColor = Color.Cyan
        Panel31.BackColor = Color.Cyan
        Panel32.BackColor = Color.Cyan
        Panel33.BackColor = Color.Cyan
        Label10.ForeColor = Color.Cyan
        Panel34.BackColor = Color.Cyan
        Panel35.BackColor = Color.Cyan
        Panel36.BackColor = Color.Cyan
        Panel37.BackColor = Color.Cyan
        Label11.ForeColor = Color.Cyan
        Panel38.BackColor = Color.Cyan
        Panel39.BackColor = Color.Cyan
        Panel40.BackColor = Color.Cyan
        Panel41.BackColor = Color.Cyan
        Label15.ForeColor = Color.Cyan
        Panel14.BackColor = Color.Cyan
        Panel15.BackColor = Color.Cyan
        Panel16.BackColor = Color.Cyan
        Panel17.BackColor = Color.Cyan
        Label14.ForeColor = Color.Cyan
    End Sub

    Private Sub Label12_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.MouseMove
        Panel6.BackColor = Color.Teal
        Panel7.BackColor = Color.Teal
        Panel8.BackColor = Color.Teal
        Panel9.BackColor = Color.Teal
        Label12.ForeColor = Color.Teal
    End Sub

    Private Sub Label13_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.MouseMove
        Panel10.BackColor = Color.Teal
        Panel11.BackColor = Color.Teal
        Panel12.BackColor = Color.Teal
        Panel13.BackColor = Color.Teal
        Label13.ForeColor = Color.Teal
    End Sub

    Private Sub Label14_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.MouseMove
        Panel14.BackColor = Color.Teal
        Panel15.BackColor = Color.Teal
        Panel16.BackColor = Color.Teal
        Panel17.BackColor = Color.Teal
        Label14.ForeColor = Color.Teal
    End Sub

    Private Sub Label9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label9.MouseMove
        Panel26.BackColor = Color.Teal
        Panel27.BackColor = Color.Teal
        Panel28.BackColor = Color.Teal
        Panel29.BackColor = Color.Teal
        Label9.ForeColor = Color.Teal
    End Sub

    Private Sub Label8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseMove
        Panel22.BackColor = Color.Teal
        Panel23.BackColor = Color.Teal
        Panel24.BackColor = Color.Teal
        Panel25.BackColor = Color.Teal
        Label8.ForeColor = Color.Teal
    End Sub

    Private Sub Label7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseMove
        Panel18.BackColor = Color.Teal
        Panel19.BackColor = Color.Teal
        Panel20.BackColor = Color.Teal
        Panel21.BackColor = Color.Teal
        Label7.ForeColor = Color.Teal
    End Sub

    Private Sub Label14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label14.MouseMove
        Panel14.BackColor = Color.Teal
        Panel15.BackColor = Color.Teal
        Panel16.BackColor = Color.Teal
        Panel17.BackColor = Color.Teal
        Label14.ForeColor = Color.Teal
    End Sub

    Private Sub Label10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label10.MouseMove
        Panel30.BackColor = Color.Teal
        Panel31.BackColor = Color.Teal
        Panel32.BackColor = Color.Teal
        Panel33.BackColor = Color.Teal
        Label10.ForeColor = Color.Teal
    End Sub

    Private Sub Label11_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label11.MouseMove
        Panel34.BackColor = Color.Teal
        Panel35.BackColor = Color.Teal
        Panel36.BackColor = Color.Teal
        Panel37.BackColor = Color.Teal
        Label11.ForeColor = Color.Teal
    End Sub

    Private Sub Label15_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label15.MouseMove
        Panel38.BackColor = Color.Teal
        Panel39.BackColor = Color.Teal
        Panel40.BackColor = Color.Teal
        Panel41.BackColor = Color.Teal
        Label15.ForeColor = Color.Teal
    End Sub
#End Region

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Shell("cmd /c start https://www.youtube.com/user/YGOProKC")
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Shell("cmd /c start https://www.facebook.com/YGOPro")
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Shell("cmd /c start http://ygopro.club/index.php?/topic/2718-common-issues/")
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Shell("cmd /c start https://twitter.com/KC_TDOANE")
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Shell("cmd /c start http://ygopro.club/index.php?/forum/20-card-issues/")
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Shell("cmd /c start http://ygopro.club/index.php?/forum/21-report-players/")
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Launcher.PublicTxt.AppendText(Environment.NewLine)
        Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
        Launcher.PublicTxt.SelectionColor = Color.Teal
        Launcher.PublicTxt.AppendText("J.A.R.V.I.S: My name means 'Just A Rather Very Intelligent System'")
        Launcher.PublicTxt.AppendText(Environment.NewLine)
        Launcher.PublicTxt.Select(Launcher.PublicTxt.TextLength, 0)
        Launcher.PublicTxt.SelectionColor = Color.Teal
        Launcher.PublicTxt.AppendText("J.A.R.V.I.S: Using my control panel you can check for upcoming tournaments, report bugs and players, as well as find the links to our official pages and channels!")
        Launcher.PublicTxt.SelectionStart = Launcher.PublicTxt.TextLength
        Launcher.PublicTxt.SelectionLength = 0
        Launcher.PublicTxt.ScrollToCaret()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Shell("cmd /c start http://ygopro.club/index.php?/forum/34-dueling/")
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        If Launcher.achievements.Contains(6) = False Then
            Launcher.AddAchievement(Launcher.Username, 6, 0)
            Launcher.achievements.Add(6)
        End If

        Launcher.SendToServer("J.A.R.V.I.S.<{]>" & "Original")
        Me.Hide()
    End Sub
End Class