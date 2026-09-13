Public Class taskForm

    Private markComp As New markComplete
    Private editTask As New EditTask
    Private deleteTask As New DeleteTask
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        tblPnl.Controls.Clear()
        markComp.Dock = DockStyle.Fill
        tblPnl.Controls.Add(markComp)
    End Sub

    Private Sub taskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With taskTbl.Rows
            .Add("Play mobile legends", "September 15")
            .Add("Buy groceries", "September 15")
            .Add("Walk the dog", "September 10")
            .Add("Read a book", "September 12")
        End With
        taskTbl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tblPnl.Controls.Clear()
        editTask.Dock = DockStyle.Fill
        tblPnl.Controls.Add(editTask)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        taskTbl.Rows.Add(taskInput.Text, dateInput.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tblPnl.Controls.Clear()
        deleteTask.Dock = DockStyle.Fill
        tblPnl.Controls.Add(deleteTask)
    End Sub
End Class
