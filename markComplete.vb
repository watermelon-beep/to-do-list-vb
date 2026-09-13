Public Class markComplete

    Private Sub markComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmptbl.Rows
            .Add("Play mobile legends", "September 15")
            .Add("Buy groceries", "September 15")
            .Add("Walk the dog", "September 10")
            .Add("Read a book", "September 12")

        End With
        cmptbl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
End Class
