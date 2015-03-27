<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginscreen
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
        Me.Login = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.CreateAccount = New System.Windows.Forms.Button()
        Me.namebox = New System.Windows.Forms.TextBox()
        Me.loginsys = New System.Windows.Forms.Label()
        Me.Passwordbox = New System.Windows.Forms.TextBox()
        Me.Help = New System.Windows.Forms.Button()
        Me.UsernameTableAdapter1 = New Project1.DataSet1TableAdapters.USERNAMETableAdapter()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(60, 214)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(75, 23)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Log In"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(57, 109)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(57, 149)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(53, 13)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(141, 214)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 3
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'CreateAccount
        '
        Me.CreateAccount.Location = New System.Drawing.Point(222, 214)
        Me.CreateAccount.Name = "CreateAccount"
        Me.CreateAccount.Size = New System.Drawing.Size(75, 23)
        Me.CreateAccount.TabIndex = 4
        Me.CreateAccount.Text = "Create Account"
        Me.CreateAccount.UseVisualStyleBackColor = True
        '
        'namebox
        '
        Me.namebox.Location = New System.Drawing.Point(141, 106)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(142, 20)
        Me.namebox.TabIndex = 5
        '
        'loginsys
        '
        Me.loginsys.AutoSize = True
        Me.loginsys.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.loginsys.Location = New System.Drawing.Point(30, 20)
        Me.loginsys.Name = "loginsys"
        Me.loginsys.Size = New System.Drawing.Size(307, 46)
        Me.loginsys.TabIndex = 6
        Me.loginsys.Text = "Login to System"
        '
        'Passwordbox
        '
        Me.Passwordbox.Location = New System.Drawing.Point(141, 146)
        Me.Passwordbox.Name = "Passwordbox"
        Me.Passwordbox.Size = New System.Drawing.Size(142, 20)
        Me.Passwordbox.TabIndex = 7
        Me.Passwordbox.UseSystemPasswordChar = True
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(12, 283)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(84, 26)
        Me.Help.TabIndex = 8
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'UsernameTableAdapter1
        '
        Me.UsernameTableAdapter1.ClearBeforeFill = True
        '
        'loginscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 380)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.Passwordbox)
        Me.Controls.Add(Me.loginsys)
        Me.Controls.Add(Me.CreateAccount)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.namebox)
        Me.Name = "loginscreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents CreateAccount As System.Windows.Forms.Button
    Friend WithEvents namebox As System.Windows.Forms.TextBox
    Friend WithEvents loginsys As System.Windows.Forms.Label
    Friend WithEvents Passwordbox As System.Windows.Forms.TextBox
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents UsernameTableAdapter1 As Project1.DataSet1TableAdapters.USERNAMETableAdapter

End Class
