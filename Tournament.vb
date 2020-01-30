Public Class Tournament
    Public ID As Integer
    Public Name As String
    Public Type As String
    Public MaximumPlayers As Integer
    Public Banlist As String
    Public Password As String
    Public qualification As String
    Public entryFee As Integer
    Public duelType As String
    Public datePosted As String
    Public dateStarted As String
    Public status As Boolean = False
    Public officialTournament As Boolean = False
    Public tournamentLength As Integer
    Public hostedbyMe As Boolean = False
    Public winnerGoldAward As Integer
    Public winnerDiamondAward As Integer
    Public winnerTitleAward As String
    Public secondPlaceGoldAward As Integer
    Public secondPlaceDiamondAward As Integer
    Public thirdPlaceGoldAward As Integer
    Public thirdPlaceDiamondAward As Integer
    Public fourthPlaceGoldAward As Integer
    Public fourthPlaceDiamondAward As Integer
    Public fifthToEightPlaceGoldAward As Integer
    Public fifthToEightPlaceDiamondAward As Integer

    Sub New(args() As String)
        ID = args(0)
        Name = args(1)
        Type = args(2)
        MaximumPlayers = args(3)
        Banlist = args(4)
        duelType = args(5)
        qualification = args(6)
        Password = args(8)
        winnerGoldAward = args(9)
        winnerDiamondAward = args(10)
        winnerTitleAward = args(11)
        secondPlaceGoldAward = args(12)
        secondPlaceDiamondAward = args(13)
        thirdPlaceGoldAward = args(14)
        thirdPlaceDiamondAward = args(15)
        fourthPlaceGoldAward = args(16)
        fourthPlaceDiamondAward = args(17)
        fifthToEightPlaceGoldAward = args(18)
        fifthToEightPlaceDiamondAward = args(19)
        datePosted = args(21)
        tournamentLength = args(22)
        dateStarted = args(23)

        If args(7) = -1 Then
            entryFee = 0
        Else
            entryFee = args(7)
        End If

        If args(20) = 1 Then
            officialTournament = True
        End If

        If args(24) = 1 Then
            hostedbyMe = True
        End If
    End Sub
End Class
