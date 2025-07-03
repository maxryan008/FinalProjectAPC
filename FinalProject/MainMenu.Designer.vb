<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        panelHeader = New Panel()
        btnLogout = New Button()
        lblTitle = New Label()
        btnProfile = New Button()
        btnRegister = New Button()
        btnLogin = New Button()
        panelMain = New Panel()
        btnAllVets = New Button()
        btnRecommendations = New Button()
        btnHistory = New Button()
        btnBookAppointment = New Button()
        btnCalender = New Button()
        panelHeader.SuspendLayout()
        panelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.CornflowerBlue
        panelHeader.BackgroundImageLayout = ImageLayout.None
        panelHeader.Controls.Add(btnLogout)
        panelHeader.Controls.Add(lblTitle)
        panelHeader.Controls.Add(btnProfile)
        panelHeader.Controls.Add(btnRegister)
        panelHeader.Controls.Add(btnLogin)
        panelHeader.ImeMode = ImeMode.NoControl
        panelHeader.Location = New Point(-3, -2)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(804, 68)
        panelHeader.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightSkyBlue
        btnLogout.Location = New Point(737, 3)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(64, 62)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
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
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.LightSkyBlue
        btnProfile.Location = New Point(667, 3)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(64, 62)
        btnProfile.TabIndex = 3
        btnProfile.Text = "Profile"
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.LightSkyBlue
        btnRegister.Location = New Point(667, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(64, 62)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LightSkyBlue
        btnLogin.Location = New Point(737, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(64, 62)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.SeaShell
        panelMain.Controls.Add(btnAllVets)
        panelMain.Controls.Add(btnRecommendations)
        panelMain.Controls.Add(btnHistory)
        panelMain.Controls.Add(btnBookAppointment)
        panelMain.Controls.Add(btnCalender)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-3, 66)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(804, 385)
        panelMain.TabIndex = 1
        ' 
        ' btnAllVets
        ' 
        btnAllVets.BackColor = Color.LightSkyBlue
        btnAllVets.Location = New Point(15, 182)
        btnAllVets.Name = "btnAllVets"
        btnAllVets.Size = New Size(120, 38)
        btnAllVets.TabIndex = 5
        btnAllVets.Text = "All Vets"
        btnAllVets.UseVisualStyleBackColor = False
        ' 
        ' btnRecommendations
        ' 
        btnRecommendations.BackColor = Color.LightSkyBlue
        btnRecommendations.Location = New Point(15, 138)
        btnRecommendations.Name = "btnRecommendations"
        btnRecommendations.Size = New Size(120, 38)
        btnRecommendations.TabIndex = 4
        btnRecommendations.Text = "Recommendations"
        btnRecommendations.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.LightSkyBlue
        btnHistory.Location = New Point(15, 94)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(120, 38)
        btnHistory.TabIndex = 2
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' btnBookAppointment
        ' 
        btnBookAppointment.BackColor = Color.LightSkyBlue
        btnBookAppointment.Location = New Point(15, 50)
        btnBookAppointment.Name = "btnBookAppointment"
        btnBookAppointment.Size = New Size(120, 38)
        btnBookAppointment.TabIndex = 1
        btnBookAppointment.Text = "Book Appointment"
        btnBookAppointment.UseVisualStyleBackColor = False
        ' 
        ' btnCalender
        ' 
        btnCalender.BackColor = Color.LightSkyBlue
        btnCalender.Location = New Point(15, 6)
        btnCalender.Name = "btnCalender"
        btnCalender.Size = New Size(120, 38)
        btnCalender.TabIndex = 0
        btnCalender.Text = "Calender"
        btnCalender.UseVisualStyleBackColor = False
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        Name = "MainMenu"
        Text = "MainMenu"
        panelHeader.ResumeLayout(False)
        panelMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRecommendations As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnBookAppointment As Button
    Friend WithEvents btnCalender As Button
    Friend WithEvents btnAllVets As Button
    Friend WithEvents btnLogout As Button

End Class
