Public Class BookAppointment
    Private Sub Form_Closed(sender As Object, e As EventArgs)
        'Already closed so dont close again otherwise crash will occur
        redirect(Me, MainMenu)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormRedirectionManager.redirect(Me, MainMenu)
    End Sub

    Private Sub btnCheckAvailability_Click(sender As Object, e As EventArgs) Handles btnCheckAvailability.Click
        ' Format date to match the CSV (first column is yyyy-MM-dd)
        Dim selectedDate As String = dtpDate.Value.ToString("yyyy-MM-dd")
        Dim filePath As String = IO.Path.Combine(Application.StartupPath, "appointments.csv")

        If IO.File.Exists(filePath) Then
            Dim lines() As String = IO.File.ReadAllLines(filePath)

            ' Check if any line starts with the selected date (first column match)
            Dim dateTaken As Boolean = lines.Any(Function(line)
                                                     Dim parts = line.Split(","c)
                                                     Return parts.Length > 0 AndAlso parts(0).Trim() = selectedDate
                                                 End Function)

            If dateTaken Then
                MessageBox.Show("That date is already taken.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                createAppointment()
            End If
        Else
            ' File doesn't exist — create the first appointment
            createAppointment()
        End If
    End Sub

    Private Sub createAppointment()
        lblSubheading.Hide()
        dtpDate.Hide()
        btnCheckAvailability.Hide()

        lblDate.Show()
        cmbLocation.Show()
        btnPickVet.Show()
        cmbAppointmentType.Show()
        txtSpecialRequirements.Show()
        btnScheduleAppointment.Show()
        lblLocationheading.Show()
        lblAppointmentTypeHeading.Show()
        lblOtherInformationHeading.Show()

        ' Set formatted date label
        lblDate.Text = "Date: " & dtpDate.Value.ToString("dd/MM/yy")

        ' Load vet locations into cmbLocation
        cmbLocation.Items.Clear()

        Dim xmlPath As String = IO.Path.Combine(Application.StartupPath, "vets.xml")
        If IO.File.Exists(xmlPath) Then
            Dim doc As New Xml.XmlDocument()
            doc.Load(xmlPath)

            Dim locations = doc.SelectNodes("//location")
            For Each location As Xml.XmlNode In locations
                Dim name = location.Attributes("name")?.Value
                If Not String.IsNullOrEmpty(name) Then
                    cmbLocation.Items.Add(name)
                End If
            Next
        Else
            MessageBox.Show("vets.xml not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Load appointment types from CSV
        cmbAppointmentType.Items.Clear()
        Dim typesPath As String = IO.Path.Combine(Application.StartupPath, "appointment_types.csv")
        If IO.File.Exists(typesPath) Then
            Dim lines() As String = IO.File.ReadAllLines(typesPath)
            For Each line As String In lines
                cmbAppointmentType.Items.Add(line.Trim())
            Next
        Else
            MessageBox.Show("appointment_types.csv not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPickVet_Click(sender As Object, e As EventArgs) Handles btnPickVet.Click
        If cmbLocation.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a location first.")
            Return
        End If

        Dim location = cmbLocation.SelectedItem.ToString()
        Dim vetXmlPath = IO.Path.Combine(Application.StartupPath, "vets.xml")
        If Not IO.File.Exists(vetXmlPath) Then
            MessageBox.Show("vets.xml not found.")
            Return
        End If

        Dim doc As New Xml.XmlDocument()
        doc.Load(vetXmlPath)

        Dim locationNode = doc.SelectSingleNode($"//location[@name='{location}']")
        If locationNode Is Nothing Then
            MessageBox.Show("No vets found for this location.")
            Return
        End If

        Dim rows As New List(Of Dictionary(Of String, String))
        For Each vetNode As Xml.XmlNode In locationNode.SelectNodes("vet")
            Dim name = vetNode.Attributes("name")?.Value
            Dim spec = vetNode.SelectSingleNode("specialisation")?.InnerText
            If Not String.IsNullOrEmpty(name) Then
                rows.Add(New Dictionary(Of String, String) From {
                {"Vet Name", name},
                {"Specialisation", spec}
            })
            End If
        Next

        If rows.Count = 0 Then
            MessageBox.Show("No vets listed under this location.")
            Return
        End If

        Dim listView As New ListView()
        listView.Title = "Pick a Vet"
        listView.Initialize(
        headers:=New List(Of String) From {"Vet Name", "Specialisation"},
        rows:=rows,
        sortKey:="Vet Name",
        enableSort:=True
    )

        listView.SetSortOptions(New List(Of String) From {
        "Sort A-Z",
        "Sort Z-A"
    })

        listView.OnRowSelected = Sub(selected)
                                     VetSelectionManager.SelectedVetName = selected("Vet Name")
                                     VetSelectionManager.SelectedVetSpecialisation = selected("Specialisation")
                                     lblChosenVet.Text = "Chosen Vet: " & VetSelectionManager.SelectedVetName
                                 End Sub

        listView.ShowDialog()
    End Sub

    Private Sub btnScheduleAppointment_Click(sender As Object, e As EventArgs) Handles btnScheduleAppointment.Click
        ' Validation
        If String.IsNullOrEmpty(lblDate.Text) Then
            MessageBox.Show("Please select a date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbLocation.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbAppointmentType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an appointment type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(VetSelectionManager.SelectedVetName) Then
            MessageBox.Show("Please select a vet.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get username from MainMenu.session
        If MainMenu.session Is Nothing OrElse MainMenu.session.data Is Nothing Then
            MessageBox.Show("You must be logged in to book an appointment.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim username As String = MainMenu.session.data.strUsername
        Dim dateText As String = dtpDate.Value.ToString("yyyy-MM-dd")
        Dim location As String = cmbLocation.SelectedItem.ToString()
        Dim appointmentType As String = cmbAppointmentType.SelectedItem.ToString()
        Dim vetName As String = VetSelectionManager.SelectedVetName
        Dim vetSpec As String = VetSelectionManager.SelectedVetSpecialisation
        Dim specialReqs As String = txtSpecialRequirements.Text

        ' Save appointment to CSV
        Dim outputPath As String = IO.Path.Combine(Application.StartupPath, "appointments.csv")
        Dim line As String = $"{dateText},{username},{location},{appointmentType},{vetName},{vetSpec},{specialReqs}"
        IO.File.AppendAllText(outputPath, line & Environment.NewLine)

        MessageBox.Show("Appointment scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class