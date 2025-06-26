<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar
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
        btbnViewAppointment = New Button()
        clndrAppointments = New MonthCalendar()
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
        panelMain.Controls.Add(btbnViewAppointment)
        panelMain.Controls.Add(clndrAppointments)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 67)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(804, 385)
        panelMain.TabIndex = 3
        ' 
        ' btbnViewAppointment
        ' 
        btbnViewAppointment.Location = New Point(323, 297)
        btbnViewAppointment.Name = "btbnViewAppointment"
        btbnViewAppointment.Size = New Size(144, 39)
        btbnViewAppointment.TabIndex = 8
        btbnViewAppointment.Text = "View Appointment"
        btbnViewAppointment.UseVisualStyleBackColor = True
        ' 
        ' clndrAppointments
        ' 
        clndrAppointments.Font = New Font("Segoe UI", 20F)
        clndrAppointments.Location = New Point(273, 103)
        clndrAppointments.Name = "clndrAppointments"
        clndrAppointments.TabIndex = 7
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
        btnRegister.TabIndex = 5
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
        ' Calendar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        Name = "Calendar"
        Text = "Calendar"
        panelMain.ResumeLayout(False)
        panelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents clndrAppointments As MonthCalendar
    Friend WithEvents btbnViewAppointment As Button
    Friend WithEvents btnRegister As Button
End Class
