Public Class MainMenu
    Public session As UserSession = Nothing
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '' open new login form
        FormRedirectionManager.redirectLoginForm(Me, 0)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        '' open new register form
        FormRedirectionManager.redirectLoginForm(Me, 1)
    End Sub

    ''show user profile button. opens the users profile when clicked. must be logged in to do this
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        If Not IsNothing(session) Then
            ' user is logged in so redirect
            FormRedirectionManager.redirect(Me, Profile)
        End If
    End Sub

    '' Every time form reloads this runs. this is how we determine what buttons to show
    Private Sub formWindowOpenedOrClosed(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If IsNothing(session) Then
            ' user is not logged in. display normal login/register buttons and hide profile button
            btnProfile.Hide()
            btnLogout.Hide()
            btnLogin.Show()
            btnRegister.Show()
        Else
            ' User is logged in. hide login/register buttons. show a logout button and show profile button
            btnLogin.Hide()
            btnRegister.Hide()
            btnProfile.Show()
            btnLogout.Show()
        End If
    End Sub

    ' Clear user session and show buttons to login/register
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnLogout.Hide()
        btnProfile.Hide()
        btnLogin.Show()
        btnRegister.Show()
        Me.session = Nothing
    End Sub
End Class
