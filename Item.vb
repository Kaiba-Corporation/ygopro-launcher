Public Class Item

    Public name As String
    Public goldPrice As Integer
    Public diamondPrice As Integer
    Public moreInformationLink As String
    Public picture As Image
    Public highlightedPicture As Image
    Public owned As Boolean = False
    Public ownMultiEnabled As Boolean = False

    Sub New(inputName As String, inputGoldPrice As Integer, inputDiamondPrice As Integer, inputMoreInformationLink As String, inputPicture As Image, inputHighlightedPicture As Image)
        name = inputName
        goldPrice = inputGoldPrice
        diamondPrice = inputDiamondPrice
        moreInformationLink = inputMoreInformationLink
        picture = inputPicture
        highlightedPicture = inputHighlightedPicture

        If name = "Reset WP" Then
            ownMultiEnabled = True
        End If
    End Sub
End Class
