Public Class CellBlockThree
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        AdminHome.Show()
        Me.Hide()

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