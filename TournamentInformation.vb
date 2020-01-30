Public Class TournamentInformation

    Public duelList As New List(Of Duel)

    Public Class Duel
        Public Player1 As String
        Public Player2 As String
        Public Winner As String
        Public Round As Integer

        Public Sub New(playerOne As String, playerTwo As String, winPlayer As String, roundNumber As Integer)
            Player1 = playerOne
            Player2 = playerTwo
            Winner = winPlayer
            Round = roundNumber
        End Sub
    End Class

    Public Function CheckIfDueled(playerOne As String, playerTwo As String)
        For Each playedDuel As Duel In duelList
            If (playedDuel.Player1 = playerOne And playedDuel.Player2 = playerTwo) Or (playedDuel.Player1 = playerTwo And playedDuel.Player2 = playerOne) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub TournamentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class