Public Class AccountGetHelp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub btnAccountDetails_Click(sender As Object, e As EventArgs) Handles btnAccountDetails.Click
        AccountProfile.Show()
        Me.Hide()

    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        AccountChangePass.Show()
        Me.Hide()

    End Sub

    Private Sub btnUpdateInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateInfo.Click
        AccountUpdate.Show()
        Me.Hide()

    End Sub

    Private Sub btnQuickGuide_Click(sender As Object, e As EventArgs) Handles btnQuickGuide.Click
        AccountQuickGuide.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LogoutClient.Show()
        Me.Hide()

    End Sub
End Class