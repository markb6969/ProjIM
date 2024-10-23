Public Class AccountChangePass
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Close()

    End Sub

    Private Sub btnAccountDetails_Click(sender As Object, e As EventArgs) Handles btnAccountDetails.Click
        AccountProfile.Show()
        Me.Hide()

    End Sub

    Private Sub btnUpdateInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateInfo.Click
        AccountUpdate.Show()
        Me.Close()

    End Sub

    Private Sub btnQuickGuide_Click(sender As Object, e As EventArgs) Handles btnQuickGuide.Click

    End Sub

    Private Sub btnGetHelp_Click(sender As Object, e As EventArgs) Handles btnGetHelp.Click

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LogoutClient.Show()
        Me.Hide()

    End Sub
End Class