'---------------------------------------------------------------------------------------------------------------------------------------------'
'Title: Vet Appointment Booker'
'Purpose: To allow easy booking and management of pets at vets'
'Programmer: Max Ryan'
'Version: 1.0'
'---------------------------------------------------------------------------------------------------------------------------------------------'

'---------------------------------------------------------------------------------------------------------------------------------------------'
'This form is designed to allow forms to safely redirect to another form aswell as for instantiating new forms such as login forms with
'differant elements depending on the form argument state.
'---------------------------------------------------------------------------------------------------------------------------------------------'
Module FormRedirectionManager
    ' Safe form redirection using a from and to argument. This does not close the form and should be used between forms
    ' that are the same no matter what button calls them or if the form is closed.
    Sub redirect(frmCurrent As Form, frmRedirect As Form)
        frmRedirect.Show()
        frmCurrent.Hide()
    End Sub

    ' Login form instatioator that takes a param called intArgument.
    ' intArgument determines if the Login.vb form should be displayed as a register form or a login form
    Sub redirectLoginForm(frmCurrent As Form, intArgument As Integer)
        If intArgument = 0 Then
            'Login form creation
            Dim frmLogin = New Login
            frmLogin.Text = "Login Form"
            frmLogin.intType = 0
            'Call a redirect to redirect from current to the new form instance
            redirect(frmCurrent, frmLogin)
            Return
        ElseIf intArgument = 1 Then
            'Register form creation
            Dim frmRegister = New Login
            frmRegister.btnLogin.Text = "Register"
            frmRegister.Text = "Register Form"
            frmRegister.intType = 1
            'Call a redirect to redirect from current to the new form instance
            redirect(frmCurrent, frmRegister)
            Return
        End If
        'This shouldnt happen. if the intArgument variable exceeds its range which is 1-2 inclusive then
        'this code will throw an exception because it cant handle it.
        Throw New ArgumentException("Redirect Form argument out of bounds!")
    End Sub

    'Safe form redirection that closes the current form. This should be used when trying to redirect from a form that was
    'instantiated because simply hiding the form means there is now a form with no reference that cant be accessed anymore.
    'This will crash if the current form is already closed so if trying to redirect on form closed then use the normal
    'redirect() method.
    Sub redirectAndClose(frmCurrent As Form, frmRedirect As Form)
        frmCurrent.Close()
        frmRedirect.Show()
    End Sub
End Module
