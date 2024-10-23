<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSuperAdmin = New System.Windows.Forms.Button()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblSuperAdmin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.DarkGray
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.Location = New System.Drawing.Point(473, 282)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(158, 157)
        Me.btnAdmin.TabIndex = 13
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnClient
        '
        Me.btnClient.BackColor = System.Drawing.Color.DarkGray
        Me.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClient.Image = CType(resources.GetObject("btnClient.Image"), System.Drawing.Image)
        Me.btnClient.Location = New System.Drawing.Point(684, 282)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(158, 157)
        Me.btnClient.TabIndex = 12
        Me.btnClient.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 51)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Logging in as"
        '
        'btnSuperAdmin
        '
        Me.btnSuperAdmin.BackColor = System.Drawing.Color.DarkGray
        Me.btnSuperAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSuperAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdmin.Image = CType(resources.GetObject("btnSuperAdmin.Image"), System.Drawing.Image)
        Me.btnSuperAdmin.Location = New System.Drawing.Point(254, 282)
        Me.btnSuperAdmin.Name = "btnSuperAdmin"
        Me.btnSuperAdmin.Size = New System.Drawing.Size(158, 157)
        Me.btnSuperAdmin.TabIndex = 14
        Me.btnSuperAdmin.UseVisualStyleBackColor = False
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.Location = New System.Drawing.Point(731, 455)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(59, 28)
        Me.lblClient.TabIndex = 11
        Me.lblClient.Text = "Client"
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(515, 455)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(66, 28)
        Me.lblAdmin.TabIndex = 11
        Me.lblAdmin.Text = "Admin"
        '
        'lblSuperAdmin
        '
        Me.lblSuperAdmin.AutoSize = True
        Me.lblSuperAdmin.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperAdmin.Location = New System.Drawing.Point(273, 455)
        Me.lblSuperAdmin.Name = "lblSuperAdmin"
        Me.lblSuperAdmin.Size = New System.Drawing.Size(122, 28)
        Me.lblSuperAdmin.TabIndex = 11
        Me.lblSuperAdmin.Text = "Super Admin "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 711)
        Me.Controls.Add(Me.btnSuperAdmin)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.lblSuperAdmin)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnClient As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSuperAdmin As Button
    Friend WithEvents lblClient As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblSuperAdmin As Label
End Class
