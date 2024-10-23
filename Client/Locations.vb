Public Class Locations
    Private Sub Locations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox2.SelectAll()
        RichTextBox2.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox3.SelectAll()
        RichTextBox3.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
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

    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        LocationMap.Show()
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