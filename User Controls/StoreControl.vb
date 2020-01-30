Public Class StoreControl
    Dim homeStorePage As HomeStorePage
    Dim profileStorePage As ProfileStorePage
    Dim chatStorePage As ChatStorePage
    Dim teamsStorePage As TeamsStorePage
    Dim prestigeStorePage As PrestigeStorePage
    Dim forumStorePage As MysteryBox
    Dim bordersStorePage As BordersStorePage
    Dim getDiamondsStorePage As GetDiamondsStorePage
    Dim mysteryStorePage As MysteryStorePage

    Private Sub StoreControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homeStorePage = New HomeStorePage
        homeStorePage.Location = New Point(130, 97)
        Controls.Add(homeStorePage)
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        DisposeControls()

        homeStorePage = New HomeStorePage
        homeStorePage.Location = New Point(130, 97)
        Controls.Add(homeStorePage)
    End Sub

    Private Sub MysteryBox_Click(sender As Object, e As EventArgs) Handles MysteryBox.Click
        DisposeControls()

        mysteryStorePage = New MysteryStorePage
        mysteryStorePage.Location = New Point(130, 97)
        Controls.Add(mysteryStorePage)
    End Sub

    Private Sub ProfileBtn_Click(sender As Object, e As EventArgs) Handles ProfileBtn.Click
        DisposeControls()

        profileStorePage = New ProfileStorePage
        profileStorePage.Location = New Point(130, 97)
        Controls.Add(profileStorePage)
    End Sub

    Private Sub ChatBtn_Click(sender As Object, e As EventArgs) Handles ChatBtn.Click
        DisposeControls()

        chatStorePage = New ChatStorePage
        chatStorePage.Location = New Point(130, 97)
        Controls.Add(chatStorePage)
    End Sub

    Private Sub TeamsBtn_Click(sender As Object, e As EventArgs) Handles TeamsBtn.Click
        DisposeControls()

        teamsStorePage = New TeamsStorePage
        teamsStorePage.Location = New Point(130, 97)
        Controls.Add(teamsStorePage)
    End Sub

    Private Sub PrestigeBtn_Click(sender As Object, e As EventArgs) Handles PrestigeBtn.Click
        DisposeControls()

        prestigeStorePage = New PrestigeStorePage
        prestigeStorePage.Location = New Point(130, 97)
        Controls.Add(prestigeStorePage)
    End Sub

    Private Sub ForumBtn_Click(sender As Object, e As EventArgs) Handles CardSkinsBtn.Click
        DisposeControls()

        forumStorePage = New MysteryBox
        forumStorePage.Location = New Point(130, 97)
        Controls.Add(forumStorePage)
    End Sub

    Private Sub GetDiamondsBtn_Click(sender As Object, e As EventArgs) Handles GetDiamondsBtn.Click
        DisposeControls()

        getDiamondsStorePage = New GetDiamondsStorePage
        getDiamondsStorePage.Location = New Point(130, 97)
        Controls.Add(getDiamondsStorePage)
    End Sub

    Private Sub Borders_Click(sender As Object, e As EventArgs) Handles Borders.Click
        DisposeControls()

        bordersStorePage = New BordersStorePage
        bordersStorePage.Location = New Point(130, 97)
        Controls.Add(bordersStorePage)
    End Sub

    Sub DisposeControls()
        Try
            homeStorePage.Dispose()
        Catch
        End Try
        Try
            mysteryStorePage.Dispose()
        Catch
        End Try
        Try
            profileStorePage.Dispose()
        Catch
        End Try
        Try
            chatStorePage.Dispose()
        Catch
        End Try
        Try
            teamsStorePage.Dispose()
        Catch
        End Try
        Try
            prestigeStorePage.Dispose()
        Catch
        End Try
        Try
            forumStorePage.Dispose()
        Catch
        End Try
        Try
            bordersStorePage.Dispose()
        Catch
        End Try
        Try
            getDiamondsStorePage.Dispose()
        Catch
        End Try
    End Sub
End Class
