Public Class Game
    Public name As String
    Public type As String
    Public masterRules As String
    Public banlist As String
    Public mode As String = "TCG/OCG"
    Public host As String
    Public players As String
    Public status As String
    Public additionalRules As String = "Additional Rules: None"
    Public gameType As String = "Unranked"

    Sub New(gameParts() As String)
        name = gameParts(0)

        If gameParts(1) = 0 Then
            status = "Hosting"
        Else
            status = "Dueling"
        End If

        If name.Substring(1, 1) = "0" Then
            banlist = "TCG"
            mode = "TCG/OCG"
        ElseIf name.Substring(1, 1) = "1" Then
            banlist = "OCG"
            mode = "TCG/OCG"
        ElseIf name.Substring(1, 1) = "2" Then
            banlist = "Traditional"
            mode = "TCG/OCG"
        ElseIf name.Substring(1, 1) = "3" Then
            banlist = "No Banlist"
            mode = "TCG/OCG"
        ElseIf name.Substring(1, 1) = "4" Then
            banlist = "TCG"
            mode = "TCG"
        ElseIf name.Substring(1, 1) = "5" Then
            banlist = "OCG"
            mode = "TCG"
        ElseIf name.Substring(1, 1) = "6" Then
            banlist = "Traditional"
            mode = "TCG"
        ElseIf name.Substring(1, 1) = "7" Then
            banlist = "No Banlist"
            mode = "TCG"
        ElseIf name.Substring(1, 1) = "8" Then
            banlist = "TCG"
            mode = "OCG"
        ElseIf name.Substring(1, 1) = "9" Then
            banlist = "OCG"
            mode = "OCG"
        ElseIf name.Substring(1, 1) = "A" Then
            banlist = "Traditional"
            mode = "OCG"
        Else
            banlist = "No Banlist"
            mode = "OCG"
        End If

        If name.Substring(2, 1) = "0" Then
            type = "Single"
        ElseIf name.Substring(2, 1) = "1" Then
            type = "Match"
        Else
            type = "Tag"
        End If

        If name.Substring(3, 1) = "1" Then
            masterRules = "1"
        ElseIf name.Substring(3, 1) = "2" Then
            masterRules = "2"
        ElseIf name.Substring(3, 1) = "3" Then
            masterRules = "3"
        ElseIf name.Substring(3, 1) = "4" Then
            masterRules = "4"
        Else
            masterRules = "5"
        End If

        If name.Substring(0, 1) = "1" Then
            gameType = "Ranked"
            If name.Substring(1, 1) = "0" Then
                mode = "TCG"
            ElseIf name.Substring(1, 1) = "1" Then
                mode = "OCG"
            End If
        ElseIf name.Substring(0, 1) = "2" Then
            gameType = "Tournament"
        ElseIf name.Substring(0, 1) = "4" Then
            gameType = "Battle City"
        End If

        If name.Length > 7 Then
            If name(7) = "," Then
                If name(4) = "1" Then
                    additionalRules = "Rules: Don't Check Deck"
                ElseIf name(4) = "2" Then
                    additionalRules = "Rules: Don't Shuffle Deck"
                ElseIf name(4) = "3" Then
                    additionalRules = "Rules: Don't Check Deck, Don't Shuffle Deck"
                ElseIf name(4) = "4" Then
                    additionalRules = "Rules: Don't Recover Time"
                ElseIf name(4) = "5" Then
                    additionalRules = "Rules: Don't Check Deck, Don't Recover Time"
                ElseIf name(4) = "6" Then
                    additionalRules = "Rules: Don't Shuffle Deck, Don't Recover Time"
                ElseIf name(4) = "7" Then
                    additionalRules = "Rules: Don't Check Deck, Don't Shuffle Deck, Don't Recover Time"
                End If
            End If
        End If

        host = gameParts(2)
        players = gameParts(2)

        Dim counter As Integer = 0
        While counter < gameParts.Length
            If counter > 2 Then
                players = players & ", " & gameParts(counter)
            End If

            counter += 1
        End While
    End Sub
End Class
