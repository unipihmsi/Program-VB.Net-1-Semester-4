<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLogin
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
        Me.cbBagian = New System.Windows.Forms.ComboBox
        Me.tbPassword = New System.Windows.Forms.TextBox
        Me.tbIDUser = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnLogin = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cbBagian
        '
        Me.cbBagian.BackColor = System.Drawing.Color.DarkGray
        Me.cbBagian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBagian.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBagian.FormattingEnabled = True
        Me.cbBagian.Items.AddRange(New Object() {"ADM", "SPV", "IT"})
        Me.cbBagian.Location = New System.Drawing.Point(231, 151)
        Me.cbBagian.Name = "cbBagian"
        Me.cbBagian.Size = New System.Drawing.Size(139, 21)
        Me.cbBagian.TabIndex = 24
        '
        'tbPassword
        '
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassword.Location = New System.Drawing.Point(231, 115)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(139, 20)
        Me.tbPassword.TabIndex = 23
        '
        'tbIDUser
        '
        Me.tbIDUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbIDUser.Location = New System.Drawing.Point(231, 76)
        Me.tbIDUser.Name = "tbIDUser"
        Me.tbIDUser.Size = New System.Drawing.Size(139, 20)
        Me.tbIDUser.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Bagian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ID User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "LOGIN APLIKASI"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Lavender
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Location = New System.Drawing.Point(129, 197)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(155, 34)
        Me.btnLogin.TabIndex = 25
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'MenuLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(429, 296)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cbBagian)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbIDUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuLogin"
        Me.Text = "MenuLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbBagian As System.Windows.Forms.ComboBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbIDUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
End Class
