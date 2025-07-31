Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

'---------------------------------------------------------------------------------------------------------------------------------------------'
'Title: Vet Appointment Booker'
'Purpose: To allow easy booking and management of pets at vets'
'Programmer: Max Ryan'
'Version: 1.0'
'---------------------------------------------------------------------------------------------------------------------------------------------'

'---------------------------------------------------------------------------------------------------------------------------------------------'
'Form used for managing users, allows account creation, account login, and in future account modifications
'---------------------------------------------------------------------------------------------------------------------------------------------'
Module UserManager
    'The name of the user file
    Public strUserFileLocation As String = "users.csv"

    'Simple hash algoriuthm for joining a value with a salt and hashing them with SHA256 encryption
    Function hashStringWithSalt(strValue As String, strSalt As String) As String
        Dim algorithm As SHA256 = SHA256.Create
        Dim hash As Byte() = (algorithm.ComputeHash(Encoding.UTF8.GetBytes(strValue + strSalt)))
        Return Convert.ToBase64String(hash)
    End Function

    'This is the attempt to login method that returns true if successful and false if failed
    Function tryLoginUser(strUsername As String, strPassword As String) As Boolean
        '' check file location is not empty
        If strUserFileLocation <> "" Then
            '' check if file exists
            If Not File.Exists(strUserFileLocation) Then
                File.Create(strUserFileLocation).Close()
            End If
            '' stream reader open
            Dim srUserFile As New StreamReader(strUserFileLocation)
            Dim i As Integer = 0
            Dim boolFoundUser = False
            Dim userDetails() As String
            Do Until srUserFile.EndOfStream
                Dim line() As String = srUserFile.ReadLine.Split(",")
                '' line must have correct length to be valid
                If line.Length = 8 Then
                    If strUsername = line(2) Then
                        boolFoundUser = True
                        userDetails = line
                        Exit Do
                    End If
                End If
                i += 1
            Loop
            '' close stream reader
            srUserFile.Close()

            If boolFoundUser = True Then
                '' get user salt and hashed password
                Dim strSalt As String = userDetails(5)
                Dim strHashedPassword As String = userDetails(4)

                Dim strUserInputHashed As String = hashStringWithSalt(strPassword, strSalt)
                '' check if expected password matches inputs
                If strUserInputHashed = strHashedPassword Then
                    MsgBox("Correct password and username")
                    MainMenu.session = New UserSession()
                    If Not IsNumeric(userDetails(6)) Then
                        '' fall back to 0
                        userDetails(6) = "0"
                    End If
                    MainMenu.session.data = New UserData(userDetails(0), userDetails(1), userDetails(2), userDetails(3), userDetails(4), userDetails(5), CInt(userDetails(6)), userDetails(7))
                    Return True
                Else
                    MsgBox("Username and/or password is incorrect!")
                    Return False
                End If
            Else
                MsgBox("Username and/or password is incorrect!")
                Return False
            End If

        End If
        Return False
    End Function

    'This is the attempt to register method that returns true if registration worked otherwise return false and failed to register
    Function tryTregisterUser(strUsername As String, strPassword As String, strName As String, strSurname As String, strEmail As String, strAge As String) As Boolean
        '' check file location is not empty
        If strUserFileLocation <> "" Then
            '' check if file exists
            If Not File.Exists(strUserFileLocation) Then
                File.Create(strUserFileLocation).Close()
            End If

            Dim srUserFile As New StreamReader(strUserFileLocation)

            Do Until srUserFile.EndOfStream
                Dim line() As String = srUserFile.ReadLine.Split(",")
                If line.Length >= 3 Then
                    If strUsername = line(2) Then
                        MsgBox("Username " + strUsername + " already exists. Try logging in instead.")
                        srUserFile.Close()
                        Return False
                    End If
                End If
            Loop

            srUserFile.Close()
            ''may want to tweak in future the size of salt. 16 seemed like an alright number for demonstration purposes
            Dim strSalt As String = generateSalt(16)

            Dim strHashedPassword As String = hashStringWithSalt(strPassword, strSalt)

            ''Save details to user file

            Dim swUserFile As New StreamWriter(strUserFileLocation, True)

            swUserFile.WriteLine(strName + "," + strSurname + "," + strUsername + "," + strEmail + "," + strHashedPassword + "," + strSalt + "," + strAge + "," + "User")

            swUserFile.Close()

            MsgBox("User succesfully created. Please Login")

            Return True
        End If
        Return False
    End Function

    ''Reference https://stackoverflow.com/questions/292254/vb6-how-do-i-make-a-random-string-of-0-9-and-a-z-of-x-characters
    'This is a method that generates a random set of A-Z or 0-9 characters with a certain string length
    Function generateSalt(intLength As Integer) As String
        Dim strSalt As String = ""
        Randomize()
        Dim rgch As String
        rgch = "abcdefghijklmnopqrstuvwxyz"
        rgch = rgch & UCase(rgch) & "0123456789"

        Dim i As Long
        For i = 1 To intLength
            strSalt = strSalt & Mid$(rgch, Int(Rnd() * Len(rgch) + 1), 1)
        Next
        Return strSalt
    End Function
End Module
