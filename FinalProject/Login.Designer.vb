<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        lblAge = New Label()
        lblEmail = New Label()
        lblSurname = New Label()
        lblName = New Label()
        txtAge = New TextBox()
        txtEmail = New TextBox()
        txtSurname = New TextBox()
        txtName = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
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
        panelMain.Controls.Add(lblAge)
        panelMain.Controls.Add(lblEmail)
        panelMain.Controls.Add(lblSurname)
        panelMain.Controls.Add(lblName)
        panelMain.Controls.Add(txtAge)
        panelMain.Controls.Add(txtEmail)
        panelMain.Controls.Add(txtSurname)
        panelMain.Controls.Add(txtName)
        panelMain.Controls.Add(lblPassword)
        panelMain.Controls.Add(lblUsername)
        panelMain.Controls.Add(btnLogin)
        panelMain.Controls.Add(txtPassword)
        panelMain.Controls.Add(txtUsername)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 89)
        panelMain.Margin = New Padding(3, 4, 3, 4)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(919, 513)
        panelMain.TabIndex = 3
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI", 20F)
        lblAge.Location = New Point(315, 284)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(87, 46)
        lblAge.TabIndex = 12
        lblAge.Text = "Age:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 20F)
        lblEmail.Location = New Point(182, 228)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(106, 46)
        lblEmail.TabIndex = 11
        lblEmail.Text = "Email:"
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Font = New Font("Segoe UI", 20F)
        lblSurname.Location = New Point(137, 169)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(159, 46)
        lblSurname.TabIndex = 10
        lblSurname.Text = "Surname:"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 20F)
        lblName.Location = New Point(175, 120)
        lblName.Name = "lblName"
        lblName.Size = New Size(116, 46)
        lblName.TabIndex = 9
        lblName.Text = "Name:"
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.DarkGray
        txtAge.BorderStyle = BorderStyle.None
        txtAge.Font = New Font("Segoe UI", 20F)
        txtAge.Location = New Point(402, 288)
        txtAge.Margin = New Padding(3, 4, 3, 4)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(143, 45)
        txtAge.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.DarkGray
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Segoe UI", 20F)
        txtEmail.Location = New Point(289, 232)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(358, 45)
        txtEmail.TabIndex = 7
        ' 
        ' txtSurname
        ' 
        txtSurname.BackColor = Color.DarkGray
        txtSurname.BorderStyle = BorderStyle.None
        txtSurname.Font = New Font("Segoe UI", 20F)
        txtSurname.Location = New Point(289, 176)
        txtSurname.Margin = New Padding(3, 4, 3, 4)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(358, 45)
        txtSurname.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.DarkGray
        txtName.BorderStyle = BorderStyle.None
        txtName.Font = New Font("Segoe UI", 20F)
        txtName.Location = New Point(289, 120)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(358, 45)
        txtName.TabIndex = 5
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 20F)
        lblPassword.Location = New Point(129, 63)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(167, 46)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 20F)
        lblUsername.Location = New Point(120, 8)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(177, 46)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LightSkyBlue
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(362, 377)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(225, 56)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.DarkGray
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 20F)
        txtPassword.Location = New Point(289, 64)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(358, 45)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.DarkGray
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 20F)
        txtUsername.Location = New Point(289, 8)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(358, 45)
        txtUsername.TabIndex = 0
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
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        Text = "Login"
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        panelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
End Class
