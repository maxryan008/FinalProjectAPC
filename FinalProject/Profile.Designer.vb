<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        lblAccountType = New Label()
        lblAge = New Label()
        lblEmail = New Label()
        lblUsername = New Label()
        lblSurname = New Label()
        lblName = New Label()
        lblAccountTypeHeading = New Label()
        lblAgeHeading = New Label()
        lblEmailHeading = New Label()
        lblUsernameHeading = New Label()
        lblSurnameHeading = New Label()
        lblNameHeading = New Label()
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
        panelMain.Controls.Add(lblAccountType)
        panelMain.Controls.Add(lblAge)
        panelMain.Controls.Add(lblEmail)
        panelMain.Controls.Add(lblUsername)
        panelMain.Controls.Add(lblSurname)
        panelMain.Controls.Add(lblName)
        panelMain.Controls.Add(lblAccountTypeHeading)
        panelMain.Controls.Add(lblAgeHeading)
        panelMain.Controls.Add(lblEmailHeading)
        panelMain.Controls.Add(lblUsernameHeading)
        panelMain.Controls.Add(lblSurnameHeading)
        panelMain.Controls.Add(lblNameHeading)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 67)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(804, 385)
        panelMain.TabIndex = 3
        ' 
        ' lblAccountType
        ' 
        lblAccountType.AutoSize = True
        lblAccountType.Location = New Point(103, 87)
        lblAccountType.Name = "lblAccountType"
        lblAccountType.Size = New Size(10, 15)
        lblAccountType.TabIndex = 17
        lblAccountType.Text = "."
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(43, 72)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(10, 15)
        lblAge.TabIndex = 16
        lblAge.Text = "."
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(51, 57)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(10, 15)
        lblEmail.TabIndex = 15
        lblEmail.Text = "."
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(77, 42)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(10, 15)
        lblUsername.TabIndex = 14
        lblUsername.Text = "."
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(71, 27)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(10, 15)
        lblSurname.TabIndex = 13
        lblSurname.Text = "."
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(55, 12)
        lblName.Name = "lblName"
        lblName.Size = New Size(10, 15)
        lblName.TabIndex = 12
        lblName.Text = "."
        ' 
        ' lblAccountTypeHeading
        ' 
        lblAccountTypeHeading.AutoSize = True
        lblAccountTypeHeading.Location = New Point(14, 87)
        lblAccountTypeHeading.Name = "lblAccountTypeHeading"
        lblAccountTypeHeading.Size = New Size(83, 15)
        lblAccountTypeHeading.TabIndex = 11
        lblAccountTypeHeading.Text = "Account Type:"
        ' 
        ' lblAgeHeading
        ' 
        lblAgeHeading.AutoSize = True
        lblAgeHeading.Location = New Point(14, 72)
        lblAgeHeading.Name = "lblAgeHeading"
        lblAgeHeading.Size = New Size(31, 15)
        lblAgeHeading.TabIndex = 10
        lblAgeHeading.Text = "Age:"
        ' 
        ' lblEmailHeading
        ' 
        lblEmailHeading.AutoSize = True
        lblEmailHeading.Location = New Point(14, 57)
        lblEmailHeading.Name = "lblEmailHeading"
        lblEmailHeading.Size = New Size(39, 15)
        lblEmailHeading.TabIndex = 9
        lblEmailHeading.Text = "Email:"
        ' 
        ' lblUsernameHeading
        ' 
        lblUsernameHeading.AutoSize = True
        lblUsernameHeading.Location = New Point(14, 42)
        lblUsernameHeading.Name = "lblUsernameHeading"
        lblUsernameHeading.Size = New Size(63, 15)
        lblUsernameHeading.TabIndex = 8
        lblUsernameHeading.Text = "Username:"
        ' 
        ' lblSurnameHeading
        ' 
        lblSurnameHeading.AutoSize = True
        lblSurnameHeading.Location = New Point(14, 27)
        lblSurnameHeading.Name = "lblSurnameHeading"
        lblSurnameHeading.Size = New Size(57, 15)
        lblSurnameHeading.TabIndex = 7
        lblSurnameHeading.Text = "Surname:"
        ' 
        ' lblNameHeading
        ' 
        lblNameHeading.AutoSize = True
        lblNameHeading.Location = New Point(14, 12)
        lblNameHeading.Name = "lblNameHeading"
        lblNameHeading.Size = New Size(42, 15)
        lblNameHeading.TabIndex = 6
        lblNameHeading.Text = "Name:"
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.CornflowerBlue
        panelHeader.BackgroundImageLayout = ImageLayout.None
        panelHeader.Controls.Add(btnBack)
        panelHeader.Controls.Add(lblTitle)
        panelHeader.ImeMode = ImeMode.NoControl
        panelHeader.Location = New Point(-2, -1)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(804, 68)
        panelHeader.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.LightSkyBlue
        btnBack.Location = New Point(737, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(64, 62)
        btnBack.TabIndex = 5
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
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
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        Name = "Profile"
        Text = "Profile"
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        panelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblNameHeading As Label
    Friend WithEvents lblSurnameHeading As Label
    Friend WithEvents lblUsernameHeading As Label
    Friend WithEvents lblEmailHeading As Label
    Friend WithEvents lblAgeHeading As Label
    Friend WithEvents lblAccountTypeHeading As Label
    Friend WithEvents lblAccountType As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
End Class
