Public Class AcceptQueue

    Public accepted As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        accepted = True
        Launcher.SendToServer("AcceptQueue")
        Panel1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Launcher.SendToServer("DeclineQueue")
        Launcher.inQueue = False
        Me.Hide()
        AcceptTimer.Stop()
        Launcher.rankedQueueTimer.Stop()
        Launcher.RankedQueue.SendToBack()
    End Sub

    Private Sub AcceptTimer_Tick(sender As Object, e As EventArgs) Handles AcceptTimer.Tick
        Label2.Text -= 1
        If Label2.Text = 0 And accepted Then
            CloseTimer.Start()
            AcceptTimer.Stop()
        ElseIf Label2.Text = 0 Then
            Launcher.SendToServer("DeclineQueue")
            Launcher.inQueue = False
            AcceptTimer.Stop()
            Launcher.rankedQueueTimer.Stop()
            Launcher.RankedQueue.SendToBack()
            Me.Hide()
        End If
    End Sub

    Private Sub CloseTimer_Tick(sender As Object, e As EventArgs) Handles CloseTimer.Tick
        Me.Hide()
        CloseTimer.Stop()
    End Sub

    Private Sub AcceptQueue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not accepted Then
            Launcher.SendToServer("DeclineQueue")
            Launcher.inQueue = False
        End If

        AcceptTimer.Stop()
        CloseTimer.Stop()
    End Sub
End Class