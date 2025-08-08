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
    Private Sub formWindowOpenedOrClosed(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
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

    Private Sub btnCalender_Click(sender As Object, e As EventArgs) Handles btnCalender.Click
        If session Is Nothing Then
            MsgBox("Please Login First!")
        Else
            FormRedirectionManager.redirect(Me, Calendar)
        End If
    End Sub

    Private Sub btnBookAppointment_Click(sender As Object, e As EventArgs) Handles btnBookAppointment.Click
        If session Is Nothing Then
            MsgBox("Please Login First!")
        Else
            FormRedirectionManager.redirect(Me, BookAppointment)
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        If session Is Nothing OrElse session.data Is Nothing Then
            MessageBox.Show("Please login to view appointment history.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim username As String = session.data.strUsername
        Dim appointmentsPath As String = IO.Path.Combine(Application.StartupPath, "appointments.csv")

        If Not IO.File.Exists(appointmentsPath) Then
            MessageBox.Show("No appointments found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim userAppointments As New List(Of Dictionary(Of String, String))
        Dim lines() As String = IO.File.ReadAllLines(appointmentsPath)

        For Each line In lines
            Dim parts = line.Split(","c)
            If parts.Length >= 7 AndAlso parts(1).Trim().ToLower() = username.ToLower() Then
                userAppointments.Add(New Dictionary(Of String, String) From {
                {"Date", parts(0).Trim()},
                {"Location", parts(2).Trim()},
                {"Pet", parts(3).Trim()},
                {"Doctor", parts(4).Trim()},
                {"Specialisation", parts(5).Trim()},
                {"Notes", parts(6).Trim()}
            })
            End If
        Next

        If userAppointments.Count = 0 Then
            MessageBox.Show("You have no appointment history.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim listView As New ListView()
        listView.Title = "Your Appointment History"
        listView.Initialize(
        headers:=New List(Of String) From {"Date", "Location", "Pet", "Doctor", "Specialisation", "Notes"},
        rows:=userAppointments,
        sortKey:="Date",
        enableSort:=True
    )

        listView.SetSortOptions(New List(Of String) From {
        "Sort by Date (Newest)",
        "Sort by Date (Oldest)",
        "Sort by Doctor (A-Z)",
        "Sort by Doctor (Z-A)",
        "Sort by Pet (A-Z)",
        "Sort by Pet (Z-A)",
        "Sort by Location (A-Z)",
        "Sort by Location (Z-A)"
    })

        listView.ShowDialog()
    End Sub

    Private Sub btnRecommendations_Click(sender As Object, e As EventArgs) Handles btnRecommendations.Click
        If session Is Nothing Then
            MsgBox("Please Login First!")
        Else
            FormRedirectionManager.redirect(Me, Recommendations)
        End If
    End Sub

    Private Sub btnAllVets_Click(sender As Object, e As EventArgs) Handles btnAllVets.Click

    End Sub
End Class
