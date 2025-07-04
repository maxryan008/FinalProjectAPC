Public Class Profile

    ' Redirect to main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormRedirectionManager.redirect(Me, MainMenu)
    End Sub

    '' Every time form is reloaded / reshown / visibility changed
    ' refresh all user details
    Private Sub FormWindowOpenedOrClosed(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        lblName.Text = MainMenu.session.data.strName
        lblSurname.Text = MainMenu.session.data.strSurname
        lblUsername.Text = MainMenu.session.data.strUsername
        lblEmail.Text = MainMenu.session.data.strEmail
        lblAge.Text = MainMenu.session.data.intAge
        lblAccountType.Text = MainMenu.session.data.strAccountType
    End Sub

    ' Redirect to main menu when form is closed
    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        'Already closed so dont close again otherwise crash will occur
        FormRedirectionManager.redirect(Me, MainMenu)
    End Sub
End Class