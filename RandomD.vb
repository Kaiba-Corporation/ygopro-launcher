﻿Public Class RandomD

    Public gameType As String = "Unranked"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g1 As Integer
        Dim g2 As Integer
        Dim g3 As Integer
        Dim g4 As Integer

        Dim part2 As String

        If gameType = "Ranked" Then
            If Launcher.RankedStatus = 1 Then
                MsgBox("You are not allowed to play ranked games!")
                Return
            End If

            If Launcher.beta = True Then
                MsgBox("Ranked games are disabled during the beta!")
                Return
            End If

            g1 = 1
            rule1.Enabled = False
            rule2.Enabled = False
            rule3.Enabled = False
        Else
            g1 = 0
            rule1.Enabled = True
            rule2.Enabled = True
            rule3.Enabled = True
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

        part2 = g2

        If gameType = "Unranked" Then
            If cardsTCG.Checked = True Then
                g2 += 4
            ElseIf cardsOCG.Checked = True Then
                g2 += 8
            End If

            If g2 = 10 Then
                part2 = "A"
            ElseIf g2 = 11 Then
                part2 = "B"
            End If
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

        Dim objwriter As New System.IO.StreamWriter(Launcher.Current & "\YGOPRO\" & "duel.CONF")
        objwriter.Write("#config file")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("#nickname & gamename should be less than 20 characters")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("skin_index = " & My.Settings.US)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("nickname = " & Launcher.Username)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("gamename = Game")
        objwriter.Write(Environment.NewLine)
        objwriter.Write("roompass = " & g1 & part2 & g3 & g4)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("serverport = " & Launcher.gamePort)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lasthost = " & Launcher.IP)
        objwriter.Write(Environment.NewLine)
        objwriter.Write("lastport = " & Launcher.gamePort)
        If Launcher.Mute = 0 Then
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 0)
        Else
            objwriter.Write(Environment.NewLine)
            objwriter.Write("mute_chat = " & 1)
        End If
        objwriter.Close()

        CardSkinManager.CopyFullCardDatabase()

        Dim proc As New Process()

        ChDir(Launcher.Current & "\YGOPRO")
        proc.StartInfo.FileName = Launcher.ygoproExe
        proc.StartInfo.Arguments = "-j"
        proc.Start()
        Me.Hide()
    End Sub
End Class