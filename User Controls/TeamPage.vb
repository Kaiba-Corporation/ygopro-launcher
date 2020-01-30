Public Class TeamPage

    Public imageLink As String = ""

    Public coleaderList As New List(Of String)

    Public Sub setImageFunction(ByVal link As String)
        imageLink = link
        TextBox1.Text = link

        Dim setImageThread As New Threading.Thread(AddressOf setImage)
        setImageThread.Start()
    End Sub

    Private Delegate Sub setImageDelegate()
    Private Sub setImage()
        Try
            Dim downloadedImage As Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(imageLink)))
            If ProfilePicture.InvokeRequired Then
                ProfilePicture.Invoke(New setImageDelegate(AddressOf setImage))
            Else
                ProfilePicture.Image = downloadedImage
            End If
        Catch
        End Try
    End Sub

    Private Sub TeamPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each username As String In Launcher.ListBox4.Items
            ListBox2.Items.Add(username)
        Next
        ListBox2.Items.Add(Launcher.Username)

        If Launcher.TeamLeader = True Or coleaderList.Contains(Launcher.Username) Then
            Button4.Enabled = True
            kickButton.Visible = True
        End If
        If Launcher.TeamLeader = True Then
            promoteButton.Enabled = True
            promoteButton.Visible = True
            demoteButton.Enabled = True
            demoteButton.Visible = True
            leaveDisbandTeam.Text = "Disband Team"
        End If

        ListBox2.SelectedItem = Launcher.Username
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        selectedUsername.Text = "Username: " & ListBox2.SelectedItem

        If ListBox2.SelectedItem = Launcher.TeamLeaderUsername Then
            selectedRank.Text = "Rank: Leader"
            promoteButton.Enabled = False
            demoteButton.Enabled = False
            If Launcher.TeamLeader = True Or coleaderList.Contains(Launcher.Username) = True Then
                kickButton.Enabled = False
            End If
        ElseIf coleaderList.Contains(ListBox2.SelectedItem) Then
            selectedRank.Text = "Rank: Co-Leader"
            promoteButton.Enabled = False
            demoteButton.Enabled = True
            If Launcher.TeamLeader = True Or coleaderList.Contains(Launcher.Username) = True Then
                kickButton.Enabled = True
            End If
        Else
            selectedRank.Text = "Rank: Member"
            promoteButton.Enabled = True
            demoteButton.Enabled = False
            If Launcher.TeamLeader = True Or coleaderList.Contains(Launcher.Username) = True Then
                kickButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Launcher.TeamLeader = True Then
            Launcher.UpdateTeamImage(TextBox1.Text)
            setImageFunction(TextBox1.Text)
        Else
            MsgBox("Only the team leader can set the team profile image!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim goldSend As Integer

        Try
            goldSend = TextBox3.Text
            Launcher.SendString("DonateTeamGold<{]>" & goldSend)
        Catch
            MsgBox("Please enter a number!")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Launcher.TeamLeader = False And coleaderList.Contains(Launcher.Username) = False Then
            MsgBox("Only the team leader and co-leaders can send gold!")
        End If

        Dim goldSend As Integer

        Try
            goldSend = TextBox5.Text

            If ListBox2.SelectedIndex > -1 Then
                Dim goldNumber() As String = Split(Gold.Text, " ")

                If goldNumber(1) >= goldSend Then
                    Launcher.SendString("SendTeamGold<{]>" & ListBox2.SelectedItem & "<{]>" & goldSend)
                    Gold.Text = "Gold: " & (goldNumber(1) - goldSend)
                Else
                    MsgBox("Not enough gold in the team bank!")
                End If
            Else
                MsgBox("User must be a member of your team!")
            End If

        Catch
            MsgBox("Please enter a number!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles promoteButton.Click
        If Launcher.TeamLeader = False Then
            MsgBox("Only the team leader can promote players!")
        End If

        If ListBox2.SelectedIndex > -1 Then
            If ListBox2.SelectedItem = Launcher.Username Then
                MsgBox("You are the team leader!")
                Return
            End If

            If coleaderList.Contains(ListBox2.SelectedItem) = False Then
                Launcher.SendString("TeamPromote<{]>" & ListBox2.SelectedItem)
                coleaderList.Add(ListBox2.SelectedItem)
                selectedRank.Text = "Rank: Co-Leader"
                promoteButton.Enabled = False
                demoteButton.Enabled = True
            Else
                MsgBox("User is already promoted!")
            End If
        Else
            MsgBox("You must select a player!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles demoteButton.Click
        If Launcher.TeamLeader = False Then
            MsgBox("Only the team leader can demote players!")
        End If

        If ListBox2.SelectedIndex > -1 Then
            If ListBox2.SelectedItem = Launcher.Username Then
                MsgBox("You are the team leader!")
                Return
            End If

            If coleaderList.Contains(ListBox2.SelectedItem) Then
                Launcher.SendString("TeamDemote<{]>" & ListBox2.SelectedItem)
                coleaderList.Remove(ListBox2.SelectedItem)
                selectedRank.Text = "Rank: Member"
                promoteButton.Enabled = True
                demoteButton.Enabled = False
            Else
                MsgBox("User is already a member!")
            End If
        Else
            MsgBox("You must select a player!")
        End If
    End Sub

    Private Sub kickButton_Click(sender As Object, e As EventArgs) Handles kickButton.Click
        If ListBox2.SelectedIndex > -1 Then
            Launcher.SendToServer("TeamKick" & "<{]>" & ListBox2.SelectedItem & "<{]>" & Launcher.MyTeam)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            ListBox2.SelectedItem = Launcher.Username
        End If
    End Sub

    Private Sub leaveTeam_Click(sender As Object, e As EventArgs) Handles leaveDisbandTeam.Click
        If leaveDisbandTeam.Text = "Leave Team" Then
            Dim MBXResult﻿ As DialogResult = MessageBox.Show("Leave Team?", "Leave Team?", MessageBoxButtons.YesNo)
            If MBXResult﻿ = MsgBoxResult.Yes Then
                If Launcher.TeamLeader = False Then
                    Launcher.SendToServer("TeamKick" & "<{]>" & Launcher.Username & "<{]>" & Launcher.MyTeam)
                Else
                    MsgBox("Team leader cannot leave the team, please disband the team by typing in /disbandteam")
                End If
            End If
        End If

        If leaveDisbandTeam.Text = "Disband Team" Then
            Dim DisbandTeam = InputBox("Please write 'DISBAND' to disband the team:", "Disband Team")
            If DisbandTeam.ToLower = "disband" Or DisbandTeam.ToLower = "'disband'" Then
                If Launcher.TeamLeader = True Then
                    Launcher.SendToServer("TeamDisband" & "<{]>" & Launcher.Username & "<{]>" & Launcher.MyTeam)
                    Launcher.HomePanel.Show()
                    Launcher.HomePanel.BringToFront()
                    Launcher.ChatPanel.Hide()
                    Launcher.DuelPanel.Hide()
                    Me.Dispose()
                End If
            Else
                MsgBox("Team has not been disbanded!")
            End If
        End If
    End Sub
End Class
