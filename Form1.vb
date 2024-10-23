Imports Admin

Public Class Form1
    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        LoginClient.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminLogin.Show()

        Me.Hide()
    End Sub
End Class