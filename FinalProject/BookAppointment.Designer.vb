<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookAppointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        panelMain = New Panel()
        lblOtherInformationHeading = New Label()
        lblAppointmentTypeHeading = New Label()
        lblLocationheading = New Label()
        lblChosenVet = New Label()
        btnScheduleAppointment = New Button()
        txtSpecialRequirements = New TextBox()
        cmbAppointmentType = New ComboBox()
        btnPickVet = New Button()
        cmbLocation = New ComboBox()
        lblDate = New Label()
        btnCheckAvailability = New Button()
        dtpDate = New DateTimePicker()
        lblSubheading = New Label()
        panelHeader = New Panel()
        btnBack = New Button()
        lblTitle = New Label()
        panelMain.SuspendLayout()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.SeaShell
        panelMain.Controls.Add(lblOtherInformationHeading)
        panelMain.Controls.Add(lblAppointmentTypeHeading)
        panelMain.Controls.Add(lblLocationheading)
        panelMain.Controls.Add(lblChosenVet)
        panelMain.Controls.Add(btnScheduleAppointment)
        panelMain.Controls.Add(txtSpecialRequirements)
        panelMain.Controls.Add(cmbAppointmentType)
        panelMain.Controls.Add(btnPickVet)
        panelMain.Controls.Add(cmbLocation)
        panelMain.Controls.Add(lblDate)
        panelMain.Controls.Add(btnCheckAvailability)
        panelMain.Controls.Add(dtpDate)
        panelMain.Controls.Add(lblSubheading)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 89)
        panelMain.Margin = New Padding(3, 4, 3, 4)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(919, 513)
        panelMain.TabIndex = 3
        ' 
        ' lblOtherInformationHeading
        ' 
        lblOtherInformationHeading.AutoSize = True
        lblOtherInformationHeading.Location = New Point(4, 151)
        lblOtherInformationHeading.Name = "lblOtherInformationHeading"
        lblOtherInformationHeading.Size = New Size(79, 20)
        lblOtherInformationHeading.TabIndex = 12
        lblOtherInformationHeading.Text = "Other Info:"
        lblOtherInformationHeading.Visible = False
        ' 
        ' lblAppointmentTypeHeading
        ' 
        lblAppointmentTypeHeading.AutoSize = True
        lblAppointmentTypeHeading.Location = New Point(34, 117)
        lblAppointmentTypeHeading.Name = "lblAppointmentTypeHeading"
        lblAppointmentTypeHeading.Size = New Size(43, 20)
        lblAppointmentTypeHeading.TabIndex = 11
        lblAppointmentTypeHeading.Text = "Type:"
        lblAppointmentTypeHeading.Visible = False
        ' 
        ' lblLocationheading
        ' 
        lblLocationheading.AutoSize = True
        lblLocationheading.Location = New Point(14, 48)
        lblLocationheading.Name = "lblLocationheading"
        lblLocationheading.Size = New Size(69, 20)
        lblLocationheading.TabIndex = 10
        lblLocationheading.Text = "Location:"
        lblLocationheading.Visible = False
        ' 
        ' lblChosenVet
        ' 
        lblChosenVet.AutoSize = True
        lblChosenVet.Location = New Point(183, 83)
        lblChosenVet.Name = "lblChosenVet"
        lblChosenVet.Size = New Size(0, 20)
        lblChosenVet.TabIndex = 9
        ' 
        ' btnScheduleAppointment
        ' 
        btnScheduleAppointment.Location = New Point(58, 178)
        btnScheduleAppointment.Name = "btnScheduleAppointment"
        btnScheduleAppointment.Size = New Size(176, 29)
        btnScheduleAppointment.TabIndex = 8
        btnScheduleAppointment.Text = "Schedule Appointment"
        btnScheduleAppointment.UseVisualStyleBackColor = True
        btnScheduleAppointment.Visible = False
        ' 
        ' txtSpecialRequirements
        ' 
        txtSpecialRequirements.Location = New Point(83, 148)
        txtSpecialRequirements.Name = "txtSpecialRequirements"
        txtSpecialRequirements.Size = New Size(125, 27)
        txtSpecialRequirements.TabIndex = 7
        txtSpecialRequirements.Visible = False
        ' 
        ' cmbAppointmentType
        ' 
        cmbAppointmentType.FormattingEnabled = True
        cmbAppointmentType.Location = New Point(83, 114)
        cmbAppointmentType.Name = "cmbAppointmentType"
        cmbAppointmentType.Size = New Size(151, 28)
        cmbAppointmentType.TabIndex = 6
        cmbAppointmentType.Visible = False
        ' 
        ' btnPickVet
        ' 
        btnPickVet.Location = New Point(83, 79)
        btnPickVet.Name = "btnPickVet"
        btnPickVet.Size = New Size(94, 29)
        btnPickVet.TabIndex = 5
        btnPickVet.Text = "Pick Vet"
        btnPickVet.UseVisualStyleBackColor = True
        btnPickVet.Visible = False
        ' 
        ' cmbLocation
        ' 
        cmbLocation.FormattingEnabled = True
        cmbLocation.Location = New Point(83, 45)
        cmbLocation.Name = "cmbLocation"
        cmbLocation.Size = New Size(151, 28)
        cmbLocation.TabIndex = 4
        cmbLocation.Visible = False
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(14, 22)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(41, 20)
        lblDate.TabIndex = 3
        lblDate.Text = "Date"
        lblDate.Visible = False
        ' 
        ' btnCheckAvailability
        ' 
        btnCheckAvailability.Location = New Point(370, 172)
        btnCheckAvailability.Margin = New Padding(3, 4, 3, 4)
        btnCheckAvailability.Name = "btnCheckAvailability"
        btnCheckAvailability.Size = New Size(162, 31)
        btnCheckAvailability.TabIndex = 2
        btnCheckAvailability.Text = "Check Date Availability"
        btnCheckAvailability.UseVisualStyleBackColor = True
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(338, 133)
        dtpDate.Margin = New Padding(3, 4, 3, 4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(228, 27)
        dtpDate.TabIndex = 1
        ' 
        ' lblSubheading
        ' 
        lblSubheading.AutoSize = True
        lblSubheading.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblSubheading.Location = New Point(325, 92)
        lblSubheading.Name = "lblSubheading"
        lblSubheading.Size = New Size(281, 35)
        lblSubheading.TabIndex = 0
        lblSubheading.Text = "Book An Appointment"
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.CornflowerBlue
        panelHeader.BackgroundImageLayout = ImageLayout.None
        panelHeader.Controls.Add(btnBack)
        panelHeader.Controls.Add(lblTitle)
        panelHeader.ImeMode = ImeMode.NoControl
        panelHeader.Location = New Point(-2, -1)
        panelHeader.Margin = New Padding(3, 4, 3, 4)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(919, 91)
        panelHeader.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.LightSkyBlue
        btnBack.Location = New Point(842, 4)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(73, 83)
        btnBack.TabIndex = 5
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTitle.Location = New Point(3, 4)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(231, 87)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Vet Booker"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BookAppointment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "BookAppointment"
        Text = "BookAppointment"
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        panelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblSubheading As Label
    Friend WithEvents btnCheckAvailability As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents txtSpecialRequirements As TextBox
    Friend WithEvents cmbAppointmentType As ComboBox
    Friend WithEvents btnPickVet As Button
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents btnScheduleAppointment As Button
    Friend WithEvents lblChosenVet As Label
    Friend WithEvents lblOtherInformationHeading As Label
    Friend WithEvents lblAppointmentTypeHeading As Label
    Friend WithEvents lblLocationheading As Label
End Class
