<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        txtSpecialRequirements = New RichTextBox()
        lblSpecialRequirementsHeading = New Label()
        lblAnimalType = New Label()
        lblAnimalTypeSubheading = New Label()
        lblPetTypeHeading = New Label()
        lblVetSpecifications = New Label()
        lblVetName = New Label()
        lblNameSubheading = New Label()
        lblSpecificationsSubheading = New Label()
        lblDate = New Label()
        lblLocation = New Label()
        lblVetHeading = New Label()
        lblDateHeading = New Label()
        lblLocationHeading = New Label()
        panelHeader = New Panel()
        btnRegister = New Button()
        lblTitle = New Label()
        panelMain.SuspendLayout()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.SeaShell
        panelMain.Controls.Add(txtSpecialRequirements)
        panelMain.Controls.Add(lblSpecialRequirementsHeading)
        panelMain.Controls.Add(lblAnimalType)
        panelMain.Controls.Add(lblAnimalTypeSubheading)
        panelMain.Controls.Add(lblPetTypeHeading)
        panelMain.Controls.Add(lblVetSpecifications)
        panelMain.Controls.Add(lblVetName)
        panelMain.Controls.Add(lblNameSubheading)
        panelMain.Controls.Add(lblSpecificationsSubheading)
        panelMain.Controls.Add(lblDate)
        panelMain.Controls.Add(lblLocation)
        panelMain.Controls.Add(lblVetHeading)
        panelMain.Controls.Add(lblDateHeading)
        panelMain.Controls.Add(lblLocationHeading)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 67)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(804, 385)
        panelMain.TabIndex = 3
        ' 
        ' txtSpecialRequirements
        ' 
        txtSpecialRequirements.Location = New Point(23, 164)
        txtSpecialRequirements.Name = "txtSpecialRequirements"
        txtSpecialRequirements.Size = New Size(100, 96)
        txtSpecialRequirements.TabIndex = 14
        txtSpecialRequirements.Text = ""
        ' 
        ' lblSpecialRequirementsHeading
        ' 
        lblSpecialRequirementsHeading.AutoSize = True
        lblSpecialRequirementsHeading.Location = New Point(23, 146)
        lblSpecialRequirementsHeading.Name = "lblSpecialRequirementsHeading"
        lblSpecialRequirementsHeading.Size = New Size(123, 15)
        lblSpecialRequirementsHeading.TabIndex = 13
        lblSpecialRequirementsHeading.Text = "Special Requirements:"
        ' 
        ' lblAnimalType
        ' 
        lblAnimalType.AutoSize = True
        lblAnimalType.Location = New Point(145, 121)
        lblAnimalType.Name = "lblAnimalType"
        lblAnimalType.Size = New Size(47, 15)
        lblAnimalType.TabIndex = 12
        lblAnimalType.Text = "Label12"
        ' 
        ' lblAnimalTypeSubheading
        ' 
        lblAnimalTypeSubheading.AutoSize = True
        lblAnimalTypeSubheading.Location = New Point(64, 121)
        lblAnimalTypeSubheading.Name = "lblAnimalTypeSubheading"
        lblAnimalTypeSubheading.Size = New Size(76, 15)
        lblAnimalTypeSubheading.TabIndex = 11
        lblAnimalTypeSubheading.Text = "Animal Type:"
        ' 
        ' lblPetTypeHeading
        ' 
        lblPetTypeHeading.AutoSize = True
        lblPetTypeHeading.Location = New Point(23, 121)
        lblPetTypeHeading.Name = "lblPetTypeHeading"
        lblPetTypeHeading.Size = New Size(35, 15)
        lblPetTypeHeading.TabIndex = 10
        lblPetTypeHeading.Text = "Type:"
        ' 
        ' lblVetSpecifications
        ' 
        lblVetSpecifications.AutoSize = True
        lblVetSpecifications.Location = New Point(145, 98)
        lblVetSpecifications.Name = "lblVetSpecifications"
        lblVetSpecifications.Size = New Size(41, 15)
        lblVetSpecifications.TabIndex = 9
        lblVetSpecifications.Text = "Label9"
        ' 
        ' lblVetName
        ' 
        lblVetName.AutoSize = True
        lblVetName.Location = New Point(103, 74)
        lblVetName.Name = "lblVetName"
        lblVetName.Size = New Size(41, 15)
        lblVetName.TabIndex = 8
        lblVetName.Text = "Label8"
        ' 
        ' lblNameSubheading
        ' 
        lblNameSubheading.AutoSize = True
        lblNameSubheading.Location = New Point(55, 74)
        lblNameSubheading.Name = "lblNameSubheading"
        lblNameSubheading.Size = New Size(42, 15)
        lblNameSubheading.TabIndex = 7
        lblNameSubheading.Text = "Name:"
        ' 
        ' lblSpecificationsSubheading
        ' 
        lblSpecificationsSubheading.AutoSize = True
        lblSpecificationsSubheading.Location = New Point(56, 98)
        lblSpecificationsSubheading.Name = "lblSpecificationsSubheading"
        lblSpecificationsSubheading.Size = New Size(83, 15)
        lblSpecificationsSubheading.TabIndex = 6
        lblSpecificationsSubheading.Text = "Specifications:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(63, 47)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(41, 15)
        lblDate.TabIndex = 5
        lblDate.Text = "Label5"
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Location = New Point(82, 21)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(41, 15)
        lblLocation.TabIndex = 4
        lblLocation.Text = "Label4"
        ' 
        ' lblVetHeading
        ' 
        lblVetHeading.AutoSize = True
        lblVetHeading.Location = New Point(23, 74)
        lblVetHeading.Name = "lblVetHeading"
        lblVetHeading.Size = New Size(26, 15)
        lblVetHeading.TabIndex = 3
        lblVetHeading.Text = "Vet:"
        ' 
        ' lblDateHeading
        ' 
        lblDateHeading.AutoSize = True
        lblDateHeading.Location = New Point(23, 47)
        lblDateHeading.Name = "lblDateHeading"
        lblDateHeading.Size = New Size(34, 15)
        lblDateHeading.TabIndex = 2
        lblDateHeading.Text = "Date:"
        ' 
        ' lblLocationHeading
        ' 
        lblLocationHeading.AutoSize = True
        lblLocationHeading.Location = New Point(23, 21)
        lblLocationHeading.Name = "lblLocationHeading"
        lblLocationHeading.Size = New Size(56, 15)
        lblLocationHeading.TabIndex = 1
        lblLocationHeading.Text = "Location:"
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.CornflowerBlue
        panelHeader.BackgroundImageLayout = ImageLayout.None
        panelHeader.Controls.Add(btnRegister)
        panelHeader.Controls.Add(lblTitle)
        panelHeader.ImeMode = ImeMode.NoControl
        panelHeader.Location = New Point(-2, -1)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(804, 68)
        panelHeader.TabIndex = 2
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.LightSkyBlue
        btnRegister.Location = New Point(737, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(64, 62)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Back"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTitle.Location = New Point(3, 3)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(202, 65)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Vet Booker"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Appointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        Name = "Appointment"
        Text = "Appointment"
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        panelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSpecificationsSubheading As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblVetHeading As Label
    Friend WithEvents lblDateHeading As Label
    Friend WithEvents lblLocationHeading As Label
    Friend WithEvents lblNameSubheading As Label
    Friend WithEvents txtSpecialRequirements As RichTextBox
    Friend WithEvents lblSpecialRequirementsHeading As Label
    Friend WithEvents lblAnimalType As Label
    Friend WithEvents lblAnimalTypeSubheading As Label
    Friend WithEvents lblPetTypeHeading As Label
    Friend WithEvents lblVetSpecifications As Label
    Friend WithEvents lblVetName As Label
    Friend WithEvents btnRegister As Button
End Class
