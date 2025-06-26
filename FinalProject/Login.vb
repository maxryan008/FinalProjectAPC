Public Class Login
    Public intType As Integer
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If intType = 0 Then
            MsgBox(UserManager.tryLoginUser(txtUsername.Text, txtPassword.Text))
        ElseIf intType = 1 Then
            Dim boolRegistered As Boolean = UserManager.tryTregisterUser(txtUsername.Text, txtPassword.Text)
            FormRedirectionManager.redirectAndClose(Me, MainMenu)
        Else
            FormRedirectionManager.redirectAndClose(Me, MainMenu)
            MsgBox("Form error occured. Redirected to MainMenu.")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormRedirectionManager.redirectAndClose(Me, MainMenu)
    End Sub
End Class