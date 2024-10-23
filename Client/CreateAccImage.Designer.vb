<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccImage
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblUploadImg = New System.Windows.Forms.Label()
        Me.pnlTxtUsername = New System.Windows.Forms.Panel()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnChooseImg = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbID = New System.Windows.Forms.PictureBox()
        Me.btnChooseId = New System.Windows.Forms.Button()
        Me.pnlTxtUsername.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmit.Location = New System.Drawing.Point(482, 634)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(274, 49)
        Me.btnSubmit.TabIndex = 47
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(592, 266)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(110, 21)
        Me.lblID.TabIndex = 42
        Me.lblID.Text = "Upload a valid ID"
        '
        'lblUploadImg
        '
        Me.lblUploadImg.AutoSize = True
        Me.lblUploadImg.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUploadImg.Location = New System.Drawing.Point(238, 266)
        Me.lblUploadImg.Name = "lblUploadImg"
        Me.lblUploadImg.Size = New System.Drawing.Size(94, 21)
        Me.lblUploadImg.TabIndex = 40
        Me.lblUploadImg.Text = "Upload Image"
        '
        'pnlTxtUsername
        '
        Me.pnlTxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.pnlTxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTxtUsername.Controls.Add(Me.pbImage)
        Me.pnlTxtUsername.Location = New System.Drawing.Point(242, 290)
        Me.pnlTxtUsername.Name = "pnlTxtUsername"
        Me.pnlTxtUsername.Size = New System.Drawing.Size(222, 194)
        Me.pnlTxtUsername.TabIndex = 39
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(8, 7)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(204, 177)
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 33)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Finishing up"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 56)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Create account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login.My.Resources.Resources.Screenshot__950_
        Me.PictureBox1.Location = New System.Drawing.Point(343, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(569, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'btnChooseImg
        '
        Me.btnChooseImg.BackColor = System.Drawing.Color.Gainsboro
        Me.btnChooseImg.FlatAppearance.BorderSize = 0
        Me.btnChooseImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseImg.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImg.ForeColor = System.Drawing.Color.Black
        Me.btnChooseImg.Location = New System.Drawing.Point(281, 500)
        Me.btnChooseImg.Name = "btnChooseImg"
        Me.btnChooseImg.Size = New System.Drawing.Size(139, 42)
        Me.btnChooseImg.TabIndex = 48
        Me.btnChooseImg.Text = "Browse"
        Me.btnChooseImg.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pbID)
        Me.Panel1.Location = New System.Drawing.Point(597, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 194)
        Me.Panel1.TabIndex = 39
        '
        'pbID
        '
        Me.pbID.Location = New System.Drawing.Point(8, 7)
        Me.pbID.Name = "pbID"
        Me.pbID.Size = New System.Drawing.Size(204, 177)
        Me.pbID.TabIndex = 0
        Me.pbID.TabStop = False
        '
        'btnChooseId
        '
        Me.btnChooseId.BackColor = System.Drawing.Color.Gainsboro
        Me.btnChooseId.FlatAppearance.BorderSize = 0
        Me.btnChooseId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseId.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseId.ForeColor = System.Drawing.Color.Black
        Me.btnChooseId.Location = New System.Drawing.Point(643, 500)
        Me.btnChooseId.Name = "btnChooseId"
        Me.btnChooseId.Size = New System.Drawing.Size(139, 42)
        Me.btnChooseId.TabIndex = 48
        Me.btnChooseId.Text = "Browse"
        Me.btnChooseId.UseVisualStyleBackColor = False
        '
        'CreateAccImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 760)
        Me.Controls.Add(Me.btnChooseId)
        Me.Controls.Add(Me.btnChooseImg)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblUploadImg)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CreateAccImage"
        Me.pnlTxtUsername.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblUploadImg As Label
    Friend WithEvents pnlTxtUsername As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnChooseImg As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbID As PictureBox
    Friend WithEvents btnChooseId As Button
End Class
