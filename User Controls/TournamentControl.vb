Public Class TournamentControl

    Public rulesLink As String = ""

    Private Sub rulesBtn_Click(sender As Object, e As EventArgs) Handles rulesBtn.Click
        Process.Start(rulesLink)
    End Sub

    Private Sub TournamentControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
