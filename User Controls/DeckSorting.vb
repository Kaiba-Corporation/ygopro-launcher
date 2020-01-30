Imports System.IO

Public Class DeckSorting

    Sub CreateBanlist()
        banlist.Items.Clear()

        Dim banlistFile As String
        If Launcher.launcherEdition = 2 Then
            banlistFile = Launcher.Current & "\YGOPRO\config\lflist.conf"
        Else
            banlistFile = Launcher.Current & "\YGOPRO\lflist.conf"
        End If

        banlist.Items.Add("All")

        If System.IO.File.Exists(banlistFile) = True Then
            Dim objReader As New System.IO.StreamReader(banlistFile)

            Do While objReader.Peek() <> -1
                Dim newLine As String = objReader.ReadLine

                Try
                    If newLine(0) = "!" Then
                        newLine = newLine.Remove(0, 1)
                        banlist.Items.Add(newLine)
                    End If
                Catch
                End Try
            Loop

            banlist.Text = banlist.Items(0)
        Else
            MsgBox("Error 2002: Can't find the banlist file!")
        End If
    End Sub

    Private Sub typeDeckReplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeDeckReplay.SelectedIndexChanged
        CommunityCenter.Button4.Text = "Sort By: " & typeDeckReplay.SelectedItem
        CommunityCenter.decksortby = typeDeckReplay.SelectedItem
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CommunityCenter.deckSortType = ComboBox1.SelectedItem
    End Sub

    Private Sub banlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles banlist.SelectedIndexChanged
        CommunityCenter.deckSortBanlist = banlist.SelectedItem
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CommunityCenter.page = 1
        CommunityCenter.NewSearch()
        Me.Dispose()
    End Sub

    Private Sub DeckSorting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateBanlist()

        Try
            typeDeckReplay.SelectedItem = CommunityCenter.deckSortBy
        Catch
            typeDeckReplay.SelectedIndex = 0
        End Try

        Try
            ComboBox1.SelectedItem = CommunityCenter.deckSortType
        Catch
            ComboBox1.SelectedIndex = 0
        End Try

        Try
            banlist.SelectedItem = CommunityCenter.deckSortBanlist
        Catch
            banlist.SelectedIndex = 0
        End Try

        Try
            sharedWith.SelectedItem = CommunityCenter.deckSortSharedWith
        Catch
            sharedWith.SelectedIndex = 0
        End Try
    End Sub

    Private Sub sharedWith_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sharedWith.SelectedIndexChanged
        CommunityCenter.deckSortSharedWith = sharedWith.SelectedItem
    End Sub
End Class