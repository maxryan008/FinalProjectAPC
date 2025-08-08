<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListView
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
        lblSearchHeading = New Panel()
        Label1 = New Label()
        txtSearchBox = New TextBox()
        cmbSortParameter = New ComboBox()
        dgvList = New DataGridView()
        panelHeader = New Panel()
        btnBack = New Button()
        lblTitle = New Label()
        lblSearchHeading.SuspendLayout()
        CType(dgvList, ComponentModel.ISupportInitialize).BeginInit()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblSearchHeading
        ' 
        lblSearchHeading.BackColor = Color.SeaShell
        lblSearchHeading.Controls.Add(Label1)
        lblSearchHeading.Controls.Add(txtSearchBox)
        lblSearchHeading.Controls.Add(cmbSortParameter)
        lblSearchHeading.Controls.Add(dgvList)
        lblSearchHeading.ImeMode = ImeMode.NoControl
        lblSearchHeading.Location = New Point(-2, 89)
        lblSearchHeading.Margin = New Padding(3, 4, 3, 4)
        lblSearchHeading.Name = "lblSearchHeading"
        lblSearchHeading.Size = New Size(919, 513)
        lblSearchHeading.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 3
        Label1.Text = "Search:"
        ' 
        ' txtSearchBox
        ' 
        txtSearchBox.Location = New Point(76, 3)
        txtSearchBox.Name = "txtSearchBox"
        txtSearchBox.Size = New Size(125, 27)
        txtSearchBox.TabIndex = 2
        ' 
        ' cmbSortParameter
        ' 
        cmbSortParameter.FormattingEnabled = True
        cmbSortParameter.Location = New Point(753, 3)
        cmbSortParameter.Name = "cmbSortParameter"
        cmbSortParameter.Size = New Size(151, 28)
        cmbSortParameter.TabIndex = 1
        ' 
        ' dgvList
        ' 
        dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvList.Location = New Point(14, 33)
        dgvList.Name = "dgvList"
        dgvList.RowHeadersWidth = 51
        dgvList.Size = New Size(890, 466)
        dgvList.TabIndex = 0
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
        btnBack.Location = New Point(846, 4)
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
        ' ListView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(lblSearchHeading)
        Controls.Add(panelHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ListView"
        Text = "ListView"
        lblSearchHeading.ResumeLayout(False)
        lblSearchHeading.PerformLayout()
        CType(dgvList, ComponentModel.ISupportInitialize).EndInit()
        panelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblSearchHeading As Panel
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbSortParameter As ComboBox
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents Label1 As Label
End Class
