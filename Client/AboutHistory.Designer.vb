﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutHistory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnInmate = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1234, 764)
        Me.Panel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.RichTextBox1.Location = New System.Drawing.Point(281, 582)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(705, 723)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login.My.Resources.Resources.BBRB_Cebu1
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1236, 290)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.btnAccount)
        Me.Panel2.Controls.Add(Me.btnContact)
        Me.Panel2.Controls.Add(Me.btnLocation)
        Me.Panel2.Controls.Add(Me.btnInmate)
        Me.Panel2.Controls.Add(Me.btnAbout)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1236, 158)
        Me.Panel2.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Poppins Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(526, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(244, 48)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "ellBlock Central"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox6.Image = Global.Login.My.Resources.Resources.cellblock_central
        Me.PictureBox6.Location = New System.Drawing.Point(439, 3)
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
        Me.btnAbout.ForeColor = System.Drawing.Color.Teal
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(457, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 48)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Historical Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 521)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "A System Designed for Protection and Rehabilitation"
        '
        'AboutHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 764)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AboutHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnLocation As Button
    Friend WithEvents btnInmate As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
