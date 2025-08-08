Public Class ListView
    Private columnHeaders As List(Of String)
    Private dataRows As List(Of Dictionary(Of String, String))
    Private allowSort As Boolean
    Private sortKey As String
    Private customSortOptions As List(Of String) = Nothing

    Public Property Title As String = "Select an item"
    Public Property OnRowSelected As Action(Of Dictionary(Of String, String))

    ' Initialize the list view
    Public Sub Initialize(headers As List(Of String), rows As List(Of Dictionary(Of String, String)), Optional sortKey As String = "", Optional enableSort As Boolean = True)
        dgvList.AllowUserToAddRows = False
        Me.columnHeaders = headers
        Me.dataRows = rows
        Me.sortKey = sortKey
        Me.allowSort = enableSort
    End Sub

    ' Optional: provide custom sort options (e.g., for appointment history)
    Public Sub SetSortOptions(options As List(Of String))
        customSortOptions = options
    End Sub

    Private Sub ListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Title
        dgvList.Rows.Clear()
        dgvList.Columns.Clear()

        ' Create columns
        For Each header In columnHeaders
            dgvList.Columns.Add(header, header)
        Next

        ' Populate sort options
        cmbSortParameter.Items.Clear()
        If allowSort Then
            If customSortOptions IsNot Nothing Then
                For Each optionText In customSortOptions
                    cmbSortParameter.Items.Add(optionText)
                Next
            ElseIf Not String.IsNullOrEmpty(sortKey) Then
                cmbSortParameter.Items.Add("Sort A-Z")
                cmbSortParameter.Items.Add("Sort Z-A")
            End If

            If cmbSortParameter.Items.Count > 0 Then
                cmbSortParameter.SelectedIndex = 0
            End If
        Else
            cmbSortParameter.Enabled = False
        End If

        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        dgvList.Rows.Clear()

        Dim searchText As String = txtSearchBox.Text.Trim().ToLower()
        Dim filteredRows As List(Of Dictionary(Of String, String)) = dataRows

        ' Apply search filter
        If Not String.IsNullOrEmpty(searchText) Then
            filteredRows = filteredRows.Where(Function(row) _
                row.Values.Any(Function(value) value.ToLower().Contains(searchText))
            ).ToList()
        End If

        Dim displayRows As List(Of Dictionary(Of String, String)) = filteredRows

        ' Apply sorting
        If allowSort AndAlso cmbSortParameter.SelectedItem IsNot Nothing Then
            Select Case cmbSortParameter.SelectedItem.ToString()
                Case "Sort A-Z"
                    If Not String.IsNullOrEmpty(sortKey) Then
                        displayRows = displayRows.OrderBy(Function(d) d(sortKey)).ToList()
                    End If
                Case "Sort Z-A"
                    If Not String.IsNullOrEmpty(sortKey) Then
                        displayRows = displayRows.OrderByDescending(Function(d) d(sortKey)).ToList()
                    End If
                Case "Sort by Date (Newest)"
                    displayRows = displayRows.OrderByDescending(Function(d) Date.Parse(d("Date"))).ToList()
                Case "Sort by Date (Oldest)"
                    displayRows = displayRows.OrderBy(Function(d) Date.Parse(d("Date"))).ToList()
                Case "Sort by Doctor (A-Z)"
                    displayRows = displayRows.OrderBy(Function(d) d("Doctor")).ToList()
                Case "Sort by Doctor (Z-A)"
                    displayRows = displayRows.OrderByDescending(Function(d) d("Doctor")).ToList()
                Case "Sort by Pet (A-Z)"
                    displayRows = displayRows.OrderBy(Function(d) d("Pet")).ToList()
                Case "Sort by Pet (Z-A)"
                    displayRows = displayRows.OrderByDescending(Function(d) d("Pet")).ToList()
                Case "Sort by Location (A-Z)"
                    displayRows = displayRows.OrderBy(Function(d) d("Location")).ToList()
                Case "Sort by Location (Z-A)"
                    displayRows = displayRows.OrderByDescending(Function(d) d("Location")).ToList()
            End Select
        End If

        ' Populate DataGridView
        For Each row In displayRows
            Dim values = columnHeaders.Select(Function(h) If(row.ContainsKey(h), row(h), "")).ToArray()
            dgvList.Rows.Add(values)
        Next

        dgvList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub cmbSortParameter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSortParameter.SelectedIndexChanged
        LoadGrid()
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        LoadGrid()
    End Sub

    Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvList.Rows.Count Then
            Dim selectedRow As New Dictionary(Of String, String)
            For i = 0 To columnHeaders.Count - 1
                selectedRow(columnHeaders(i)) = dgvList.Rows(e.RowIndex).Cells(i).Value?.ToString()
            Next

            OnRowSelected?.Invoke(selectedRow)
            Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class