Public Class EditTask
    Private Sub EditTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With editTbl.Rows
            .Add("Play mobile legends", "September 15")
            .Add("Buy groceries", "September 15")
            .Add("Walk the dog", "September 10")
            .Add("Read a book", "September 12")
        End With
        Column3.UseColumnTextForButtonValue = True
        editTbl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Column3.Text = "Edit"
    End Sub

End Class
