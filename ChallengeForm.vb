Public Class ChallengeForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g1 As Integer
        Dim g2 As Integer
        Dim g3 As Integer
        Dim g4 As Integer

        Dim part2 As String

        If challengeUnranked.Checked Then
            g1 = 0
        ElseIf challengeRanked.Checked Then
            If Launcher.RankedStatus = 1 Then
                MsgBox("You are not allowed to play ranked games!")
                Return
            End If

            If Launcher.beta = True Then
                MsgBox("Ranked games are disabled during the beta!")
                Return
            End If

            g1 = 1
        Else
            g1 = 4
        End If

        If banlistTCG.Checked Then
            g2 = 0
        ElseIf banlistOCG.Checked Then
            g2 = 1
        ElseIf banlistTraditional.Checked Then
            g2 = 2
        Else
            g2 = 3
        End If

        If cardsTCG.Checked = True Then
            g2 += 4
        ElseIf cardsOCG.Checked = True Then
            g2 += 8
        End If

        part2 = g2
        If g2 = 10 Then
            part2 = "A"
        ElseIf g2 = 11 Then
            part2 = "B"
        End If

        If SingleG.Checked = True Then
            g3 = 0
        ElseIf MatchG.Checked = True Then
            g3 = 1
        Else
            g3 = 2
        End If

        If rule1.Checked = True Then
            g4 = 1
        ElseIf rule2.Checked = True Then
            g4 = 2
        ElseIf rule3.Checked = True Then
            g4 = 3
        ElseIf rule3.Checked = True Then
            g4 = 4
        Else
            g4 = 5
        End If

        If g3 <> 2 Then
            Launcher.ChallengeUserToGame(g1 & part2 & g3 & g4)
        Else
            Launcher.ChallengeUserToTagGame(tptxt.Text, g1 & part2 & g3 & g4, to1txt.Text, to2txt.Text)
        End If

        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        tptxt.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        to1txt.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        to2txt.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If to1txt.Text <> Launcher.ListBox1.SelectedItem And to2txt.Text <> Launcher.ListBox1.SelectedItem Then
            tptxt.Text = Launcher.ListBox1.SelectedItem
        Else
            MsgBox("User already selected for a different position")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        If to1txt.Text = "" Then
            If tptxt.Text <> Launcher.ListBox1.SelectedItem And to2txt.Text <> Launcher.ListBox1.SelectedItem Then
                to1txt.Text = Launcher.ListBox1.SelectedItem
            Else
                MsgBox("User already selected for a different position")
            End If
        ElseIf to2txt.Text = "" Then
            If to1txt.Text <> Launcher.ListBox1.SelectedItem And tptxt.Text <> Launcher.ListBox1.SelectedItem Then
                to2txt.Text = Launcher.ListBox1.SelectedItem
            Else
                MsgBox("User already selected for a different position")
            End If
        End If
    End Sub

    Private Sub SingleG_CheckedChanged(sender As Object, e As EventArgs) Handles SingleG.CheckedChanged
        If SingleG.Checked = True Or MatchG.Checked = True Then
            Button1.Location = New Point(532, 132)
            Me.Size = New Size(630, 203)
        Else
            Button1.Location = New Point(532, 274)
            Me.Size = New Size(630, 345)
        End If
    End Sub

    Private Sub MatchG_CheckedChanged(sender As Object, e As EventArgs) Handles MatchG.CheckedChanged
        If SingleG.Checked = True Or MatchG.Checked = True Then
            Button1.Location = New Point(532, 132)
            Me.Size = New Size(630, 203)
        Else
            Button1.Location = New Point(532, 274)
            Me.Size = New Size(630, 345)
        End If
    End Sub

    Private Sub TagG_CheckedChanged(sender As Object, e As EventArgs) Handles TagG.CheckedChanged
        If SingleG.Checked = True Or MatchG.Checked = True Then
            Button1.Location = New Point(532, 132)
            Me.Size = New Size(630, 203)
        Else
            Button1.Location = New Point(532, 274)
            Me.Size = New Size(630, 345)
        End If
    End Sub

    Private Sub challengeUnranked_CheckedChanged(sender As Object, e As EventArgs) Handles challengeUnranked.CheckedChanged
        Try
            If challengeUnranked.Checked Then
                TagG.Visible = True
            ElseIf challengeRanked.Checked Then
                TagG.Visible = True
            Else
                TagG.Visible = False
            End If
        Catch
        End Try
        Try
            rule1.Enabled = True
            rule2.Enabled = True
            rule3.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub challengeRanked_CheckedChanged(sender As Object, e As EventArgs) Handles challengeRanked.CheckedChanged
        Try
            If challengeUnranked.Checked Then
                TagG.Visible = True
            ElseIf challengeRanked.Checked Then
                TagG.Visible = True
            Else
                TagG.Visible = False
            End If
        Catch
        End Try
        Try
            rule1.Enabled = False
            rule2.Enabled = False
            rule3.Enabled = False
        Catch
        End Try
    End Sub

    Private Sub challengeBattleCity_CheckedChanged(sender As Object, e As EventArgs)
        Try
            If challengeUnranked.Checked Then
                TagG.Visible = True
            ElseIf challengeRanked.Checked Then
                TagG.Visible = True
            Else
                TagG.Visible = False
            End If
        Catch
        End Try
    End Sub
End Class