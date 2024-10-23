Public Class LocationMap
    Private Sub btnListLoc_Click(sender As Object, e As EventArgs) Handles btnListLoc.Click
        Locations.Show()
        Me.Hide()

    End Sub

    Private Sub btnSearchLoc_Click(sender As Object, e As EventArgs) Handles btnSearchLoc.Click
        LocationSearch.Show()
        Me.Hide()

    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        AccountProfile.Show()
        Me.Hide()

    End Sub
End Class