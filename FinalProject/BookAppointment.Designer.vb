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
        panelHeader = New Panel()
        btnBack = New Button()
        lblTitle = New Label()
        lblSubheading = New Label()
        dtpDate = New DateTimePicker()
        btnCheckAvailability = New Button()
        panelMain.SuspendLayout()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.SeaShell
        panelMain.Controls.Add(btnCheckAvailability)
        panelMain.Controls.Add(dtpDate)
        panelMain.Controls.Add(lblSubheading)
        panelMain.ImeMode = ImeMode.NoControl
        panelMain.Location = New Point(-2, 67)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(804, 385)
        panelMain.TabIndex = 3
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
        ' lblSubheading
        ' 
        lblSubheading.AutoSize = True
        lblSubheading.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblSubheading.Location = New Point(284, 69)
        lblSubheading.Name = "lblSubheading"
        lblSubheading.Size = New Size(223, 28)
        lblSubheading.TabIndex = 0
        lblSubheading.Text = "Book An Appointment"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(296, 100)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 23)
        dtpDate.TabIndex = 1
        ' 
        ' btnCheckAvailability
        ' 
        btnCheckAvailability.Location = New Point(324, 129)
        btnCheckAvailability.Name = "btnCheckAvailability"
        btnCheckAvailability.Size = New Size(142, 23)
        btnCheckAvailability.TabIndex = 2
        btnCheckAvailability.Text = "Check Date Availability"
        btnCheckAvailability.UseVisualStyleBackColor = True
        ' 
        ' BookAppointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
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
End Class
