Public Class Main

    Public name As String
    Public description As String
    Public image As String
    Public bio As String
    Public contactmessage As String
    Public email As String
    Public phone As String
    Public github As String
    Public project As String

    Public address As Address
    Public website As String
    Public resumedownload As String
    Public social() As Social


    Public Sub New()

        name = String.Empty
        description = String.Empty
        image = String.Empty
        bio = String.Empty
        contactmessage = String.Empty
        email = String.Empty
        phone = String.Empty
        github = String.Empty
        project = String.Empty
        address = New Address
        website = String.Empty
        resumedownload = String.Empty


    End Sub



End Class
