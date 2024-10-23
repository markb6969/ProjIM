Public Class CreatePass

    'HINT FOR TEXTBOX
    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "Enter your Email" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            txtEmail.Text = "Enter your Email"
            txtEmail.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        If txtUser.Text = "Enter your Username" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then
            txtUser.Text = "Enter your Username"
            txtUser.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        If txtPass.Text = "Enter your Password" Then
            txtPass.Text = ""
            txtPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then
            txtPass.Text = "Enter your Password"
            txtPass.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtCPass_Enter(sender As Object, e As EventArgs) Handles txtCPass.Enter
        If txtCPass.Text = "Confirm your Password" Then
            txtCPass.Text = ""
            txtCPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCPass_Leave(sender As Object, e As EventArgs) Handles txtCPass.Leave
        If txtCPass.Text = "" Then
            txtCPass.Text = "Confirm your Password"
            txtCPass.ForeColor = Color.DarkGray
        End If
    End Sub


    Private Function AreFieldsFilled() As Boolean
        Dim fields As TextBox() = {txtEmail, txtUser, txtPass, txtCPass}
        Dim hints As String() = {"Enter your Email", "Enter your Username", "Enter your Password", "Confirm your password"}

        For i As Integer = 0 To fields.Length - 1
            If fields(i).Text = "" OrElse fields(i).Text = hints(i) Then
                MessageBox.Show($"Please enter your {hints(i).Replace("Enter your ", "")}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                fields(i).Focus()
                Return False
            End If
        Next

        If txtPass.Text <> txtCPass.Text Then
            MessageBox.Show("Passwords do not match. Please confirm your password.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCPass.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        If AreFieldsFilled() Then

            CreateAccImage.Show()
            Me.Hide()
        End If
    End Sub


End Class