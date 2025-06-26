Module FormRedirectionManager
    Sub redirect(frmCurrent As Form, frmRedirect As Form)
        frmRedirect.Show()
        frmCurrent.Hide()
    End Sub

    Sub redirectLoginForm(frmCurrent As Form, intArgument As Integer)
        If intArgument = 0 Then
            Dim frmLogin = New Login
            frmLogin.Text = "Login Form"
            frmLogin.intType = 0
            redirect(frmCurrent, frmLogin)
            Return
        ElseIf intArgument = 1 Then
            Dim frmRegister = New Login
            frmRegister.btnLogin.Text = "Register"
            frmRegister.Text = "Register Form"
            frmRegister.intType = 1
            redirect(frmCurrent, frmRegister)
            Return
        End If
        Throw New ArgumentException("Redirect Form argument out of bounds!")
    End Sub

    Sub redirectAndClose(frmCurrent As Form, frmRedirect As Form)
        frmCurrent.Close()
        frmRedirect.Show()
    End Sub
End Module
