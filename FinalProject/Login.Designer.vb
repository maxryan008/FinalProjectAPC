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
        btnLogin = New Button()
        txtbxPassword = New TextBox()
        txtbxUsername = New TextBox()
        panelHeader = New Panel()
        lblTitle = New Label()
        btnRegister = New Button()
        panelMain.SuspendLayout()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.SeaShell
        panelMain.Controls.Add(btnLogin)
        panelMain.Controls.Add(txtbxPassword)
        panelMain.Controls.Add(txtbxUsername)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 67)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(804, 385)
        panelMain.TabIndex = 3
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
        ' txtbxPassword
        ' 
        txtbxPassword.BackColor = Color.DarkGray
        txtbxPassword.BorderStyle = BorderStyle.None
        txtbxPassword.Font = New Font("Segoe UI", 20F)
        txtbxPassword.Location = New Point(253, 181)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.Size = New Size(313, 36)
        txtbxPassword.TabIndex = 1
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.BackColor = Color.DarkGray
        txtbxUsername.BorderStyle = BorderStyle.None
        txtbxUsername.Font = New Font("Segoe UI", 20F)
        txtbxUsername.Location = New Point(253, 76)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(313, 36)
        txtbxUsername.TabIndex = 0
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
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.LightSkyBlue
        btnRegister.Location = New Point(737, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(64, 62)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Back"
        btnRegister.UseVisualStyleBackColor = False
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
    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents btnRegister As Button
End Class
