Public Class UserData
    Public strName As String
    Public strSurname As String
    Public strUsername As String
    Public strEmail As String
    Public strPassword As String
    Public strSalt As String
    Public intAge As Integer
    Public strAccountType As String

    Public Sub New(strName As String, strSurname As String, strUsername As String, strEmail As String, strPassword As String, strSalt As String, intAge As Integer, strAccountType As String)
        Me.strName = strName
        Me.strSurname = strSurname
        Me.strUsername = strUsername
        Me.strEmail = strEmail
        Me.strPassword = strPassword
        Me.strSalt = strSalt
        Me.intAge = intAge
        Me.strAccountType = strAccountType
    End Sub
End Class

Public Class UserSession
    Public data As UserData
End Class
