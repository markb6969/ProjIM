Public Class CreateAcc

    'HINT FOR TEXTBOX
    Private Sub txtFirstName_Enter(sender As Object, e As EventArgs) Handles txtFirstName.Enter
        If txtFirstName.Text = "Enter your First Name" Then
            txtFirstName.Text = ""
            txtFirstName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        If txtFirstName.Text = "" Then
            txtFirstName.Text = "Enter your First Name"
            txtFirstName.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtMiddleName_Enter(sender As Object, e As EventArgs) Handles txtMiddleName.Enter
        If txtMiddleName.Text = "Enter your Middle Name" Then
            txtMiddleName.Text = ""
            txtMiddleName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtMiddleName_Leave(sender As Object, e As EventArgs) Handles txtMiddleName.Leave
        If txtMiddleName.Text = "" Then
            txtMiddleName.Text = "Enter your Middle Name"
            txtMiddleName.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtLastName_Enter(sender As Object, e As EventArgs) Handles txtLastName.Enter
        If txtLastName.Text = "Enter your Last Name" Then
            txtLastName.Text = ""
            txtLastName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        If txtLastName.Text = "" Then
            txtLastName.Text = "Enter your Last Name"
            txtLastName.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtSuffix_Enter(sender As Object, e As EventArgs) Handles txtSuffix.Enter
        If txtSuffix.Text = "--" Then
            txtSuffix.Text = ""
            txtSuffix.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtSuffix_Leave(sender As Object, e As EventArgs) Handles txtSuffix.Leave
        If txtSuffix.Text = "" Then
            txtSuffix.Text = "--"
            txtSuffix.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtStreet_Enter(sender As Object, e As EventArgs) Handles txtStreet.Enter
        If txtStreet.Text = "Street" Then
            txtStreet.Text = ""
            txtStreet.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtStreet_Leave(sender As Object, e As EventArgs) Handles txtStreet.Leave
        If txtStreet.Text = "" Then
            txtStreet.Text = "Street"
            txtStreet.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtMunicipality_Enter(sender As Object, e As EventArgs) Handles txtMunicipality.Enter
        If txtMunicipality.Text = "Municipality" Then
            txtMunicipality.Text = ""
            txtMunicipality.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtMunicipality_Leave(sender As Object, e As EventArgs) Handles txtMunicipality.Leave
        If txtMunicipality.Text = "" Then
            txtMunicipality.Text = "Municipality"
            txtMunicipality.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtCity_Enter(sender As Object, e As EventArgs) Handles txtCity.Enter
        If txtCity.Text = "City/District" Then
            txtCity.Text = ""
            txtCity.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtCity_Leave(sender As Object, e As EventArgs) Handles txtCity.Leave
        If txtCity.Text = "" Then
            txtCity.Text = "City/District"
            txtCity.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtRegion_Enter(sender As Object, e As EventArgs) Handles txtRegion.Enter
        If txtRegion.Text = "Region" Then
            txtRegion.Text = ""
            txtRegion.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtRegion_Leave(sender As Object, e As EventArgs) Handles txtRegion.Leave
        If txtRegion.Text = "" Then
            txtRegion.Text = "Region"
            txtRegion.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtZip_Enter(sender As Object, e As EventArgs) Handles txtZip.Enter
        If txtZip.Text = "ZIP Code" Then
            txtZip.Text = ""
            txtZip.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtZip_Leave(sender As Object, e As EventArgs) Handles txtZip.Leave
        If txtZip.Text = "" Then
            txtZip.Text = "ZIP Code"
            txtZip.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtCountry_Enter(sender As Object, e As EventArgs) Handles txtCountry.Enter
        If txtCountry.Text = "Country" Then
            txtCountry.Text = ""
            txtCountry.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtCountry_Leave(sender As Object, e As EventArgs) Handles txtCountry.Leave
        If txtCountry.Text = "" Then
            txtCountry.Text = "Country"
            txtCountry.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txtPhone_Enter(sender As Object, e As EventArgs) Handles txtPhone.Enter
        If txtPhone.Text = "+63 123-4567-890" Then
            txtPhone.Text = ""
            txtPhone.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If txtPhone.Text = "" Then
            txtPhone.Text = "+63 123-4567-890"
            txtPhone.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Function AreFieldsFilled() As Boolean
        Dim fields As TextBox() = {txtFirstName, txtLastName, txtStreet, txtCity, txtRegion, txtZip, txtCountry, txtPhone}
        Dim hints As String() = {"Enter your First Name", "Enter your Last Name", "Enter your Last Name", "Street", "City/District", "Region", "ZIP Code", "Country", "+63 123-4567-890"}

        For i As Integer = 0 To fields.Length - 1
            If fields(i).Text = "" OrElse fields(i).Text = hints(i) Then
                MessageBox.Show($"Please enter your {hints(i).Replace("Enter your ", "").Replace("+63 123-4567-890", "Phone Number")}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                fields(i).Focus()
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        If AreFieldsFilled() Then

            CreatePass.Show()
            Me.Hide()
        End If
    End Sub

End Class