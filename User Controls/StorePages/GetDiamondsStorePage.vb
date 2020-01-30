Public Class GetDiamondsStorePage

    Private Sub diamondBuyBtn_Click(sender As Object, e As EventArgs) Handles diamondBuyBtn.Click
        Process.Start("http://ygopro.org/donate.php?userid=" & Launcher.UserID)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Launcher.SendToServer("Redeem<{]>" & TextBox5.Text)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim x As Integer = TextBox3.Text
        Launcher.SendToServer("SendDiamonds<{]>" & x & "<{]>" & TextBox4.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Launcher.SendToServer("Buy<{]>ConvertDiamonds<{]>" & TextBox1.Text)
    End Sub
End Class
