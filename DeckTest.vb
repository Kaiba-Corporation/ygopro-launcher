Public Class DeckTest

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Launcher.SendToServer("J.A.R.V.I.S.<{]>" & TextBox1.Text)
    End Sub
End Class