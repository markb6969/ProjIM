Public Class SuperLogin
    Public username As String = "superadmin"
    Public passWord As String = "password"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsername.Text = username AndAlso txtPassword.Text = passWord Then
                AdminHome.Show()
                Me.Hide()
            ElseIf txtUsername.Text <> username AndAlso txtPassword.Text <> passWord Then
                MsgBox("Both username and password are incorrect.", MsgBoxStyle.Exclamation, "Login Error")
            ElseIf txtUsername.Text <> username Then
                MsgBox("The username is incorrect.", MsgBoxStyle.Exclamation, "Login Error")
            ElseIf txtPassword.Text <> passWord Then
                MsgBox("The password is incorrect.", MsgBoxStyle.Exclamation, "Login Error")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        SuperCreateAcc.Show()
    End Sub

End Class