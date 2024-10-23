Public Class AboutHistory
    Private Sub btnAbout_Click_1(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
        Me.Hide()
    End Sub
    Private Sub btnInmate_Click(sender As Object, e As EventArgs) Handles btnInmate.Click
        Inmate.Show()
        Me.Hide()
    End Sub
    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        Contact.Show()
        Me.Hide()
    End Sub

    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        Locations.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        AccountProfile.Show()
        Me.Hide()

    End Sub
End Class