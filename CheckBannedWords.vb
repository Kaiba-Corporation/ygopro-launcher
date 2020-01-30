Imports System.Text
Module CheckBannedWords
    Dim extendedAlphabet() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " "}

    Dim SimpleSwearWordList As New List(Of String)
    Dim ComplexSwearWordList As New List(Of String)
    Dim SimpleAdvertisingWordList As New List(Of String)
    Dim ComplexAdvertisingWordList As New List(Of String)

    Dim olddate As New DateTime(1970, 1, 1)

    Public Function Check(ByVal inputLine As String)
        If CheckFlooding() = False Then
            Return False
        End If
        If CheckSwearingAdvertising(inputLine) = False Then
            Return False
        End If

        Return True
    End Function

    Public Function CheckFlooding()
        Dim currentTime As Double = (DateTime.Now - olddate).TotalMilliseconds
        Launcher.timedWordList.Add((DateTime.Now - olddate).TotalMilliseconds)

        If Launcher.timedWordList.Count >= 6 Then
            Dim span As Double = currentTime - (Launcher.timedWordList(Launcher.timedWordList.Count - 6))

            If span < 10000 Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 0)
                Launcher.DisableTextBox()
                Return False
            End If
        End If

        Return True
    End Function

    Public Function CheckSwearingAdvertising(ByVal inputLine As String)
        Dim line As String = inputLine.ToLower

        Dim lastCharacter As Char
        Dim builder As StringBuilder = New StringBuilder(line.Length)
        For Each c As Char In line
            If extendedAlphabet.Contains(c) Then
                If lastCharacter <> c Then
                    builder.Append(c)
                    lastCharacter = c
                End If
            End If
        Next

        line = builder.ToString()

        For Each word As String In SimpleSwearWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 1)
                Launcher.RichTextBox2.Clear()
                MsgBox("Using swear words is not allowed!")
                Return False
            End If
        Next

        For Each word As String In ComplexSwearWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 1)
                Launcher.RichTextBox2.Clear()
                MsgBox("Using swear words is not allowed!")
                Return False
            End If
        Next

        For Each word As String In SimpleAdvertisingWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 2)
                Launcher.RichTextBox2.Clear()
                MsgBox("Advertising is not allowed!")
                MsgBox("Mentioning the names of other Yu-Gi-Oh! games is not allowed!")
                Return False
            End If
        Next

        For Each word As String In ComplexAdvertisingWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 2)
                Launcher.RichTextBox2.Clear()
                MsgBox("Advertising is not allowed!")
                MsgBox("Mentioning the names of other Yu-Gi-Oh! games is not allowed!")
                Return False
            End If
        Next

        Dim lineWithoutSpace As String = line.Replace(" ", "")

        For Each word As String In ComplexSwearWordList
            If lineWithoutSpace.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 1)
                Launcher.RichTextBox2.Clear()
                MsgBox("Using swear words is not allowed!")
                Return False
            End If
        Next

        For Each word As String In ComplexAdvertisingWordList
            If lineWithoutSpace.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 2)
                Launcher.RichTextBox2.Clear()
                MsgBox("Advertising is not allowed!")
                MsgBox("Mentioning the names of other Yu-Gi-Oh! games is not allowed!")
                Return False
            End If
        Next


        inputLine = inputLine.Replace("0", "o")
        inputLine = inputLine.Replace("1", "i")
        inputLine = inputLine.Replace("8", "ate")
        inputLine = inputLine.Replace("$", "s")
        inputLine = inputLine.Replace("@", "a")

        line = inputLine.ToLower

        lastCharacter = ""
        builder = New StringBuilder(line.Length)
        For Each c As Char In line
            If extendedAlphabet.Contains(c) Then
                If lastCharacter <> c Then
                    builder.Append(c)
                    lastCharacter = c
                End If
            End If
        Next

        line = builder.ToString()

        For Each word As String In SimpleSwearWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 1)
                Launcher.RichTextBox2.Clear()
                MsgBox("Using swear words is not allowed!")
                Return False
            End If
        Next

        For Each word As String In ComplexSwearWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 1)
                Launcher.RichTextBox2.Clear()
                MsgBox("Using swear words is not allowed!")
                Return False
            End If
        Next

        For Each word As String In SimpleAdvertisingWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 2)
                Launcher.RichTextBox2.Clear()
                MsgBox("Advertising is not allowed!")
                MsgBox("Mentioning the names of other Yu-Gi-Oh! games is not allowed!")
                Return False
            End If
        Next

        For Each word As String In ComplexAdvertisingWordList
            If line.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 2)
                Launcher.RichTextBox2.Clear()
                MsgBox("Advertising is not allowed!")
                MsgBox("Mentioning the names of other Yu-Gi-Oh! games is not allowed!")
                Return False
            End If
        Next

        lineWithoutSpace = line.Replace(" ", "")

        For Each word As String In ComplexSwearWordList
            If lineWithoutSpace.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 1)
                Launcher.RichTextBox2.Clear()
                MsgBox("Using swear words is not allowed!")
                Return False
            End If
        Next

        For Each word As String In ComplexAdvertisingWordList
            If lineWithoutSpace.Contains(word) Then
                Launcher.SendToServer("AddFlag" & Launcher.Splitter & 2)
                Launcher.RichTextBox2.Clear()
                MsgBox("Advertising is not allowed!")
                MsgBox("Mentioning the names of other Yu-Gi-Oh! games is not allowed!")
                Return False
            End If
        Next

        Return True
    End Function

    Public Sub CreateBannedWords()
        SimpleSwearWordList.Add("cum ")
        SimpleSwearWordList.Add("jiz ")
        SimpleSwearWordList.Add("fck ")
        SimpleSwearWordList.Add("fuk ")
        SimpleSwearWordList.Add("fag ")
        SimpleSwearWordList.Add(" cum")
        SimpleSwearWordList.Add(" jiz")
        SimpleSwearWordList.Add(" fck")
        SimpleSwearWordList.Add(" fuk")
        SimpleSwearWordList.Add(" fag")
        SimpleSwearWordList.Add("anal ")
        SimpleSwearWordList.Add("porn ")
        SimpleSwearWordList.Add(" porn")
        SimpleSwearWordList.Add("shit ")
        SimpleSwearWordList.Add(" shit")

        ComplexSwearWordList.Add("fuck")
        ComplexSwearWordList.Add("pusy")
        ComplexSwearWordList.Add("cock")
        ComplexSwearWordList.Add("cunt")
        ComplexSwearWordList.Add("dick")

        ComplexSwearWordList.Add("ashole")
        ComplexSwearWordList.Add("aswipe")
        ComplexSwearWordList.Add("bastard")
        ComplexSwearWordList.Add("bitch")
        ComplexSwearWordList.Add("blowjob")
        ComplexSwearWordList.Add("dumbas")
        ComplexSwearWordList.Add("gloryhole")
        ComplexSwearWordList.Add("hentai")
        ComplexSwearWordList.Add("imbecile")
        ComplexSwearWordList.Add("jerkof")
        ComplexSwearWordList.Add("masterbate")
        ComplexSwearWordList.Add("masturbate")
        ComplexSwearWordList.Add("niger")
        ComplexSwearWordList.Add("penis")
        ComplexSwearWordList.Add("retard")
        ComplexSwearWordList.Add("vagina")

        SimpleAdvertisingWordList.Add("devp ")
        SimpleAdvertisingWordList.Add(" devp")

        ComplexAdvertisingWordList.Add("devpro")
        ComplexAdvertisingWordList.Add("duelingnetw")
        ComplexAdvertisingWordList.Add("jackpro")
        ComplexAdvertisingWordList.Add("mackpro")
        ComplexAdvertisingWordList.Add("ygoproco")
        ComplexAdvertisingWordList.Add("ygoprode")
        ComplexAdvertisingWordList.Add("ygopronet")
        ComplexAdvertisingWordList.Add("ygoprosalv")
        ComplexAdvertisingWordList.Add("ygoprous")
    End Sub
End Module
