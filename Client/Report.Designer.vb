<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.btnReportSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtReportLocation = New System.Windows.Forms.TextBox()
        Me.lblEmailAdress = New System.Windows.Forms.Label()
        Me.pnlTxtUsername = New System.Windows.Forms.Panel()
        Me.txtReportEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtxtMessageConcern = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnInmate = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTxtUsername.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReportSubmit
        '
        Me.btnReportSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnReportSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportSubmit.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportSubmit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReportSubmit.Location = New System.Drawing.Point(513, 823)
        Me.btnReportSubmit.Name = "btnReportSubmit"
        Me.btnReportSubmit.Size = New System.Drawing.Size(274, 49)
        Me.btnReportSubmit.TabIndex = 41
        Me.btnReportSubmit.Text = "Submit"
        Me.btnReportSubmit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(446, 573)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Your concern"
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.ForeColor = System.Drawing.Color.Gray
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Inmate Concern", "Staff misconduct"})
        Me.cmbStatus.Location = New System.Drawing.Point(450, 275)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(400, 31)
        Me.cmbStatus.TabIndex = 25
        Me.cmbStatus.Text = "Type of Concern"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.rtxtMessageConcern)
        Me.Panel3.Location = New System.Drawing.Point(450, 597)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 207)
        Me.Panel3.TabIndex = 33
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(446, 493)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(54, 21)
        Me.lblSubject.TabIndex = 36
        Me.lblSubject.Text = "Subject"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtSubject)
        Me.Panel2.Location = New System.Drawing.Point(450, 517)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 44)
        Me.Panel2.TabIndex = 32
        '
        'txtSubject
        '
        Me.txtSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubject.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSubject.Location = New System.Drawing.Point(13, 9)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(382, 24)
        Me.txtSubject.TabIndex = 0
        Me.txtSubject.Text = "Please enter in the Subject of your Concern"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(448, 413)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(61, 21)
        Me.lblLocation.TabIndex = 31
        Me.lblLocation.Text = "Location"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtReportLocation)
        Me.Panel1.Location = New System.Drawing.Point(451, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 44)
        Me.Panel1.TabIndex = 30
        '
        'txtReportLocation
        '
        Me.txtReportLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtReportLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReportLocation.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportLocation.ForeColor = System.Drawing.Color.DarkGray
        Me.txtReportLocation.Location = New System.Drawing.Point(12, 9)
        Me.txtReportLocation.Name = "txtReportLocation"
        Me.txtReportLocation.Size = New System.Drawing.Size(382, 24)
        Me.txtReportLocation.TabIndex = 0
        Me.txtReportLocation.Text = "Enter the location"
        '
        'lblEmailAdress
        '
        Me.lblEmailAdress.AutoSize = True
        Me.lblEmailAdress.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAdress.Location = New System.Drawing.Point(447, 332)
        Me.lblEmailAdress.Name = "lblEmailAdress"
        Me.lblEmailAdress.Size = New System.Drawing.Size(84, 21)
        Me.lblEmailAdress.TabIndex = 29
        Me.lblEmailAdress.Text = "Email Adress"
        '
        'pnlTxtUsername
        '
        Me.pnlTxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.pnlTxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTxtUsername.Controls.Add(Me.txtReportEmail)
        Me.pnlTxtUsername.Location = New System.Drawing.Point(451, 356)
        Me.pnlTxtUsername.Name = "pnlTxtUsername"
        Me.pnlTxtUsername.Size = New System.Drawing.Size(399, 44)
        Me.pnlTxtUsername.TabIndex = 28
        '
        'txtReportEmail
        '
        Me.txtReportEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtReportEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReportEmail.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportEmail.ForeColor = System.Drawing.Color.DarkGray
        Me.txtReportEmail.Location = New System.Drawing.Point(12, 9)
        Me.txtReportEmail.Name = "txtReportEmail"
        Me.txtReportEmail.Size = New System.Drawing.Size(382, 24)
        Me.txtReportEmail.TabIndex = 0
        Me.txtReportEmail.Text = "Enter your email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 56)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Report a Concern"
        '
        'rtxtMessageConcern
        '
        Me.rtxtMessageConcern.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtMessageConcern.Location = New System.Drawing.Point(3, 3)
        Me.rtxtMessageConcern.Name = "rtxtMessageConcern"
        Me.rtxtMessageConcern.Size = New System.Drawing.Size(392, 199)
        Me.rtxtMessageConcern.TabIndex = 0
        Me.rtxtMessageConcern.Text = ""
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.PictureBox6)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.btnContact)
        Me.Panel4.Controls.Add(Me.btnLocation)
        Me.Panel4.Controls.Add(Me.btnInmate)
        Me.Panel4.Controls.Add(Me.btnAbout)
        Me.Panel4.Controls.Add(Me.btnHome)
        Me.Panel4.Location = New System.Drawing.Point(0, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1221, 158)
        Me.Panel4.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Poppins Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(524, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(244, 48)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "ellBlock Central"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox6.Image = Global.Login.My.Resources.Resources.cellblock_central
        Me.PictureBox6.Location = New System.Drawing.Point(437, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(277, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnContact
        '
        Me.btnContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContact.FlatAppearance.BorderSize = 0
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContact.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContact.Location = New System.Drawing.Point(811, 114)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(103, 32)
        Me.btnContact.TabIndex = 0
        Me.btnContact.Text = "Contact"
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'btnLocation
        '
        Me.btnLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLocation.FlatAppearance.BorderSize = 0
        Me.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocation.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocation.Location = New System.Drawing.Point(687, 114)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(103, 32)
        Me.btnLocation.TabIndex = 0
        Me.btnLocation.Text = "Location"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'btnInmate
        '
        Me.btnInmate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInmate.FlatAppearance.BorderSize = 0
        Me.btnInmate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInmate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInmate.ForeColor = System.Drawing.Color.Teal
        Me.btnInmate.Location = New System.Drawing.Point(570, 114)
        Me.btnInmate.Name = "btnInmate"
        Me.btnInmate.Size = New System.Drawing.Size(83, 32)
        Me.btnInmate.TabIndex = 0
        Me.btnInmate.Text = "Inmate"
        Me.btnInmate.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(461, 114)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 32)
        Me.btnAbout.TabIndex = 0
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Location = New System.Drawing.Point(355, 114)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 32)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(12, 906)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 10)
        Me.Panel5.TabIndex = 43
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1233, 752)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.btnReportSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblEmailAdress)
        Me.Controls.Add(Me.pnlTxtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlTxtUsername.ResumeLayout(False)
        Me.pnlTxtUsername.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReportSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSubject As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtReportLocation As TextBox
    Friend WithEvents lblEmailAdress As Label
    Friend WithEvents pnlTxtUsername As Panel
    Friend WithEvents txtReportEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtxtMessageConcern As RichTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnLocation As Button
    Friend WithEvents btnInmate As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel5 As Panel
End Class
