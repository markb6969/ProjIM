Public Class AdminHome
    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnInmate_Click(sender As Object, e As EventArgs) Handles btnInmate.Click
        CellBlockOne.Show()
        Me.Hide()

    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

    End Sub
End Class