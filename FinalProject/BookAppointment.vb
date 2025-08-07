Public Class BookAppointment
    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        'Already closed so dont close again otherwise crash will occur
        FormRedirectionManager.redirect(Me, MainMenu)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormRedirectionManager.redirect(Me, MainMenu)
    End Sub

    Private Sub btnCheckAvailability_Click(sender As Object, e As EventArgs) Handles btnCheckAvailability.Click

    End Sub
End Class