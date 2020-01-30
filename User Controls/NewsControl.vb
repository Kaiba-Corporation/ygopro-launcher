Public Class NewsControl

    Public readMoreLink As String = ""

    Private Sub newsReadMore_Click(sender As Object, e As EventArgs) Handles newsReadMore.Click
        Process.Start(readMoreLink)
    End Sub

    Private Sub newsDelete_Click(sender As Object, e As EventArgs) Handles newsDelete.Click
        Launcher.SendToServer("DeleteNews" & Launcher.Splitter & newsId.Text)
        Visible = False
    End Sub
End Class
