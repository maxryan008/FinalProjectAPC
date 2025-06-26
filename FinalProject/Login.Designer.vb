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
        Label2 = New Label()
        Label1 = New Label()
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
        panelMain.Controls.Add(Label2)
        panelMain.Controls.Add(Label1)
        panelMain.Controls.Add(btnLogin)
        panelMain.Controls.Add(txtPassword)
        panelMain.Controls.Add(txtUsername)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 67)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(804, 385)
        panelMain.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.Location = New Point(111, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 37)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(105, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 37)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LightSkyBlue
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(317, 283)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(197, 42)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.DarkGray
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 20F)
        txtPassword.Location = New Point(253, 181)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(313, 36)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.DarkGray
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 20F)
        txtUsername.Location = New Point(253, 76)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(313, 36)
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
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
