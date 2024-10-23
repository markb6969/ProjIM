Imports Microsoft.VisualBasic.ApplicationServices

Public Class Home

    Dim images(2) As Bitmap
    Dim descriptions(2) As String
    Dim pos As Integer = 0

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtxtHeadline.SelectAll()
        rtxtHeadline.SelectionAlignment = HorizontalAlignment.Center

        images(0) = My.Resources.Report1
        images(1) = My.Resources.Report2
        images(2) = My.Resources.Report3

        descriptions(0) = "MANILA, Philippines — Lawmakers believe that dismissed Bamban, Tarlac mayor Alice Guo’s agitation during the latest House of Representatives’ quad committee hearing was a sign that something about her true personality was revealed."
        descriptions(1) = "MANILA, Philippines – Authorities made a breakthrough on Thursday, October 10, when they caught Chinese national Lyu Dong, believed to be one of the big bosses of shady Philippine Offshore Gaming Operators (POGOs), particularly the scam hubs in Bamban, Tarlac and in Porac, Pampanga in Central Luzon."
        descriptions(2) = "MANILA, Philippines — The Philippine National Police (PNP) has released footage of the surrender and subsequent arrest of Apollo Quiboloy on Sunday evening, ending the weeks-long search for the Kingdom of Jesus Christ leader. Quiboloy peacefully surrendered after being cornered by police, and following numerous negotiations with authorities, according to the PNP."

        UpdateImagePositions()
    End Sub

    Private Sub UpdateImagePositions()
        pbMainImage.Image = images(pos)

        Dim prevPos As Integer = If(pos - 1 < 0, images.Length - 1, pos - 1)
        pbPrevImage.Image = images(prevPos)

        Dim nextPos As Integer = If(pos + 1 > images.Length - 1, 0, pos + 1)
        pbNextImage.Image = images(nextPos)

        rtxtHeadline.Text = descriptions(pos)
    End Sub

    Private Sub btnNextImg_Click(sender As Object, e As EventArgs) Handles btnNextImg.Click
        pos += 1
        If pos > images.Length - 1 Then
            pos = 0
        End If

        UpdateImagePositions()
    End Sub

    Private Sub btnPreviousImg_Click(sender As Object, e As EventArgs) Handles btnPreviousImg.Click

        pos -= 1
        If pos < 0 Then
            pos = images.Length - 1
        End If

        UpdateImagePositions()
    End Sub

    Private Sub btnAbout1_Click_1(sender As Object, e As EventArgs) Handles btnAbout1.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub btnInmate1_Click_1(sender As Object, e As EventArgs) Handles btnInmate1.Click
        Inmate.Show()
        Me.Hide()
    End Sub

    Private Sub btnLocation1_Click_1(sender As Object, e As EventArgs) Handles btnLocation1.Click
        Locations.Show()
        Me.Hide()
    End Sub

    Private Sub btnContact1_Click_1(sender As Object, e As EventArgs) Handles btnContact1.Click
        Contact.Show()
        Me.Hide()
    End Sub
    Private Sub btnExpand3_Click(sender As Object, e As EventArgs) Handles btnExpand3.Click
        rxtFaqText.Text = "As a client, you can access an offender's status, criminal history, facility information, reentry program updates, and progress reports. You will only have access to data that is legally permitted under your clearance level."
    End Sub
    Private Sub btnExpand_Click(sender As Object, e As EventArgs) Handles btnExpand.Click
        rxtFaqText.Text = "Yes, there are data access limits based on your assigned role within the system. Admins and clients have different access levels and processing capabilities, ensuring that data is managed securely and responsibly according to your permissions."
    End Sub

    Private Sub btnExpand2_Click(sender As Object, e As EventArgs) Handles btnExpand2.Click
        rxtFaqText.Text = "Yes, you can submit requests or inquiries directly through the system. Depending on your role, these may include data access requests, support inquiries, or administrative actions, all of which are managed within the platform."
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        AccountProfile.Show()
        Me.Hide()

    End Sub
End Class