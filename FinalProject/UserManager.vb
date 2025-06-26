Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module UserManager
    Public strUserFileLocation As String = "users.csv"
    Function hashStringWithSalt(strValue As String, strSalt As String) As String
        Dim algorithm As SHA256 = SHA256.Create
        Dim hash As Byte() = (algorithm.ComputeHash(Encoding.UTF8.GetBytes(strValue + strSalt)))
        Return Convert.ToBase64String(hash)
    End Function
    Function tryLoginUser(strUsername As String, strPassword As String) As Boolean
        '' check file location is not empty
        If strUserFileLocation <> "" Then
            '' check if file exists
            If Not File.Exists(strUserFileLocation) Then
                File.Create(strUserFileLocation).Close()
            End If
            Dim srUserFile As New StreamReader(strUserFileLocation)
            Dim i As Integer = 0
            Dim boolFoundUser = False
            Dim userDetails() As String
            Do Until srUserFile.EndOfStream
                Dim line() As String = srUserFile.ReadLine.Split(",")
                If line.Length = 8 Then
                    If strUsername = line(2) Then
                        boolFoundUser = True
                        userDetails = line
                        Exit Do
                    End If
                End If
                i += 1
            Loop
            srUserFile.Close()

            If boolFoundUser = True Then
                Dim strSalt As String = userDetails(5)
                Dim strHashedPassword As String = userDetails(4)

                Dim strUserInputHashed As String = hashStringWithSalt(strPassword, strSalt)

                If strUserInputHashed = strHashedPassword Then
                    MsgBox("Correct password and username")
                    Return True
                Else
                    MsgBox("Incorrect password and username")
                    Return False
                End If
            Else
                    MsgBox("Username and/or password is incorrect!")
                Return False
            End If

        End If
        Return False
    End Function

    Function tryTregisterUser(strUsername As String, strPassword As String) As Boolean
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

            swUserFile.WriteLine("name" + "," + "surname" + "," + strUsername + "," + "email" + "," + strHashedPassword + "," + strSalt + "," + "age" + "," + "accountType")

            swUserFile.Close()

            MsgBox("User succesfully created. Please Login")

            Return True
        End If
        Return False
    End Function

    ''Reference https://stackoverflow.com/questions/292254/vb6-how-do-i-make-a-random-string-of-0-9-and-a-z-of-x-characters
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
