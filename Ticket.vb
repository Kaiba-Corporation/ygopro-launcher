Public Class Ticket

    Public ID As Integer
    Public Title As String
    Public TitleOnly As String
    Public Section As String
    Public Messages As String
    Public LockedBy As String
    Public Closed As Integer
    Public DateCreated As String
    Public DateUpdated As String

    Sub New(inputID As Integer, inputTitle As String, inputTitleOnly As String, inputSection As String, inputMessages As String, inputLockedBy As String, inputClosed As String, inputDateCreated As String, inputDateUpdated As String)
        ID = inputID
        Title = inputTitle
        TitleOnly = inputTitleOnly
        Section = inputSection
        Messages = inputMessages
        LockedBy = inputLockedBy
        Closed = inputClosed
        DateCreated = inputDateCreated
        DateUpdated = inputDateUpdated
    End Sub
End Class
