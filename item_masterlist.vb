Public Class item_masterlist

    Public Sub loaddata()
        Try
            ' Clear the DataGridView before reloading data to avoid duplication
            datagrid1.Rows.Clear()

            ' Reload the data into the DataGridView
            reload("SELECT `id`, `partno`, `partname`, `model`, `process`, `material`, `moldno`, `supplier` FROM `item_masterlist`", datagrid1)

            ' Add the image column if it doesn't already exist
            If Not datagrid1.Columns.Contains("StatusIcon") Then
                Dim imgCol As New DataGridViewImageColumn()
                imgCol.Name = "StatusIcon"
                imgCol.HeaderText = "Action"
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                imgCol.Width = 40
                imgCol.Image = My.Resources.printer ' Ensure that My.Resources.printer exists
                datagrid1.Columns.Add(imgCol)

            End If
            datagrid1.Columns("id").Visible = False
        Catch ex As Exception
            ' Display the error message
            display_error("Error: " & ex.Message)

        Finally
            ' Close the connection only if it's open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim print As New print_labelform
            print.loaddata(datagrid1.Rows(e.RowIndex).Cells("id").Value())
            display_formsub(print, "Print Label")
        End If
    End Sub

    Private Sub item_masterlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class