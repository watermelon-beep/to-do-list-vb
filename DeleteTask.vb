Public Class DeleteTask
    Private Sub DeleteTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dltTbl.Rows
            .Add("Play mobile legends", "September 15")
            .Add("Buy groceries", "September 15")
            .Add("Walk the dog", "September 10")
            .Add("Read a book", "September 12")
        End With
        Column3.UseColumnTextForButtonValue = True
        dltTbl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Column3.Text = "Delete"
    End Sub
End Class
