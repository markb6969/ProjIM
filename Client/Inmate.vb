Public Class Inmate
    Private Sub Inmate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox2.SelectAll()
        RichTextBox2.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox3.SelectAll()
        RichTextBox3.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox4.SelectAll()
        RichTextBox4.SelectionAlignment = HorizontalAlignment.Center
    End Sub




    Private Sub HandleButtonClick(sender As Object, e As EventArgs) Handles btnCall.Click, btnSendMail.Click, btnSendPackage.Click, btnVisit.Click
        InmateSendingInfo.Show()
        Me.Hide()
    End Sub

    Private Sub btnConcern_Click(sender As Object, e As EventArgs) Handles btnConcern.Click
        Report.Show()
        Me.Hide()

    End Sub

    Private Sub btnFindInmate_Click(sender As Object, e As EventArgs) Handles btnFindInmate.Click
        FindInmate.Show()
        Me.Hide()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
        Me.Hide()

    End Sub

    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        Locations.Show()
        Me.Hide()

    End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        Contact.Show()
        Me.Hide()

    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        AccountProfile.Show()
        Me.Hide()

    End Sub
End Class