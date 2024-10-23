Public Class InmateSendingInfo
    Private Sub CenterAlignRichText(ParamArray richTextboxes() As RichTextBox)
        For Each rtxt In richTextboxes
            rtxt.SelectAll()
            rtxt.SelectionAlignment = HorizontalAlignment.Center
        Next
    End Sub

    Private Sub CenterAllRichTextboxes()
        CenterAlignRichText(RichTextBox1, RichTextBox2, RichTextBox3, RichTextBox4, RichTextBox5, RichTextBox6, RichTextBox7, RichTextBox8, RichTextBox9, RichTextBox10, RichTextBox11, RichTextBox12, RichTextBox13)
    End Sub

    Private Sub InmateSendingInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterAllRichTextboxes()
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