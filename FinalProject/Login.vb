'---------------------------------------------------------------------------------------------------------------------------------------------'
'Title: Vet Appointment Booker'
'Purpose: To allow easy booking and management of pets at vets'
'Programmer: Max Ryan'
'Version: 1.0'
'---------------------------------------------------------------------------------------------------------------------------------------------'

'---------------------------------------------------------------------------------------------------------------------------------------------'
'This form is the form for both registration and login of a user. FormRedirectionManager.vb handles the differances
'---------------------------------------------------------------------------------------------------------------------------------------------'
Public Class Login
    'This is the type of form that is shown; 0 = login form, 1 = register form
    Public intType As Integer

    'On login/register button clicked try to login/register the user.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If intType = 0 Then
            'attempt to login with username and password
            MsgBox(UserManager.tryLoginUser(txtUsername.Text, txtPassword.Text))
        ElseIf intType = 1 Then
            'attempt to register with username and password
            '(In future this will take more than just username and password. email, name etc)
            Dim boolRegistered As Boolean = UserManager.tryTregisterUser(txtUsername.Text, txtPassword.Text)
            FormRedirectionManager.redirectAndClose(Me, MainMenu)
        Else
            'type out of range so redirect to mainmenu and invalidate the form.
            FormRedirectionManager.redirectAndClose(Me, MainMenu)
            MsgBox("Form error occured. Redirected to MainMenu.")
        End If
    End Sub

    'Redirect to main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormRedirectionManager.redirectAndClose(Me, MainMenu)
    End Sub

    'Redirect to main menu
    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        'Already closed so dont close again otherwise crash will occur
        FormRedirectionManager.redirect(Me, MainMenu)
    End Sub
End Class