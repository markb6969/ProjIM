<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocationSearch))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnInmate = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTxtUsername = New System.Windows.Forms.Panel()
        Me.txtSearchLoc = New System.Windows.Forms.TextBox()
        Me.btnSearchLoc = New System.Windows.Forms.Button()
        Me.pbFacilityImage = New System.Windows.Forms.PictureBox()
        Me.rtxtMapDescription = New System.Windows.Forms.RichTextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTxtUsername.SuspendLayout()
        CType(Me.pbFacilityImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.btnAccount)
        Me.Panel2.Controls.Add(Me.btnContact)
        Me.Panel2.Controls.Add(Me.btnLocation)
        Me.Panel2.Controls.Add(Me.btnInmate)
        Me.Panel2.Controls.Add(Me.btnAbout)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1236, 158)
        Me.Panel2.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Poppins Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(525, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(244, 48)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "ellBlock Central"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox6.Image = Global.Login.My.Resources.Resources.cellblock_central
        Me.PictureBox6.Location = New System.Drawing.Point(438, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Image = CType(resources.GetObject("btnAccount.Image"), System.Drawing.Image)
        Me.btnAccount.Location = New System.Drawing.Point(281, 109)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(49, 46)
        Me.btnAccount.TabIndex = 1
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnContact
        '
        Me.btnContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContact.FlatAppearance.BorderSize = 0
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContact.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContact.Location = New System.Drawing.Point(815, 117)
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
        Me.btnLocation.ForeColor = System.Drawing.Color.Teal
        Me.btnLocation.Location = New System.Drawing.Point(691, 117)
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
        Me.btnInmate.Location = New System.Drawing.Point(574, 117)
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
        Me.btnAbout.ForeColor = System.Drawing.Color.Black
        Me.btnAbout.Location = New System.Drawing.Point(465, 117)
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
        Me.btnHome.Location = New System.Drawing.Point(359, 117)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 32)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login.My.Resources.Resources._243322008_190892826490082_368692
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1236, 290)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'pnlTxtUsername
        '
        Me.pnlTxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.pnlTxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTxtUsername.Controls.Add(Me.txtSearchLoc)
        Me.pnlTxtUsername.Location = New System.Drawing.Point(346, 503)
        Me.pnlTxtUsername.Name = "pnlTxtUsername"
        Me.pnlTxtUsername.Size = New System.Drawing.Size(408, 44)
        Me.pnlTxtUsername.TabIndex = 24
        '
        'txtSearchLoc
        '
        Me.txtSearchLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtSearchLoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchLoc.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchLoc.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchLoc.Location = New System.Drawing.Point(12, 9)
        Me.txtSearchLoc.Name = "txtSearchLoc"
        Me.txtSearchLoc.Size = New System.Drawing.Size(391, 24)
        Me.txtSearchLoc.TabIndex = 0
        Me.txtSearchLoc.Text = "Search for a location"
        '
        'btnSearchLoc
        '
        Me.btnSearchLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSearchLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchLoc.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLoc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchLoc.Location = New System.Drawing.Point(760, 503)
        Me.btnSearchLoc.Name = "btnSearchLoc"
        Me.btnSearchLoc.Size = New System.Drawing.Size(120, 44)
        Me.btnSearchLoc.TabIndex = 25
        Me.btnSearchLoc.Text = "Search"
        Me.btnSearchLoc.UseVisualStyleBackColor = False
        '
        'pbFacilityImage
        '
        Me.pbFacilityImage.Location = New System.Drawing.Point(247, 590)
        Me.pbFacilityImage.Name = "pbFacilityImage"
        Me.pbFacilityImage.Size = New System.Drawing.Size(742, 315)
        Me.pbFacilityImage.TabIndex = 26
        Me.pbFacilityImage.TabStop = False
        '
        'rtxtMapDescription
        '
        Me.rtxtMapDescription.BackColor = System.Drawing.SystemColors.Control
        Me.rtxtMapDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtMapDescription.Location = New System.Drawing.Point(346, 969)
        Me.rtxtMapDescription.Name = "rtxtMapDescription"
        Me.rtxtMapDescription.Size = New System.Drawing.Size(534, 185)
        Me.rtxtMapDescription.TabIndex = 27
        Me.rtxtMapDescription.Text = ""
        '
        'LocationSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1234, 760)
        Me.Controls.Add(Me.rtxtMapDescription)
        Me.Controls.Add(Me.pbFacilityImage)
        Me.Controls.Add(Me.btnSearchLoc)
        Me.Controls.Add(Me.pnlTxtUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "LocationSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTxtUsername.ResumeLayout(False)
        Me.pnlTxtUsername.PerformLayout()
        CType(Me.pbFacilityImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnLocation As Button
    Friend WithEvents btnInmate As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlTxtUsername As Panel
    Friend WithEvents txtSearchLoc As TextBox
    Friend WithEvents btnSearchLoc As Button
    Friend WithEvents pbFacilityImage As PictureBox
    Friend WithEvents rtxtMapDescription As RichTextBox
End Class
