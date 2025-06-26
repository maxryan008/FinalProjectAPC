Public Class MainMenu
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormRedirectionManager.redirectLoginForm(Me, 0)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        FormRedirectionManager.redirectLoginForm(Me, 1)
    End Sub
End Class
