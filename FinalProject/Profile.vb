Public Class Profile

    ' Redirect to main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormRedirectionManager.redirect(Me, MainMenu)
    End Sub

    '' Every time form is reloaded / reshown / visibility changed
    Private Sub formWindowOpenedOrClosed(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Label1.Text = MainMenu.session.data.strUsername
    End Sub
End Class