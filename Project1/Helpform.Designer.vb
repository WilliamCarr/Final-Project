<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Helpform
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
        Dim createaccountlbl As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Helpform))
        Me.helpscreentabmenu = New System.Windows.Forms.TabControl()
        Me.loginscreenhelptab = New System.Windows.Forms.TabPage()
        Me.loginlbl = New System.Windows.Forms.Label()
        Me.createaccounttab = New System.Windows.Forms.TabPage()
        Me.Searchtab = New System.Windows.Forms.TabPage()
        Me.srchlbl = New System.Windows.Forms.Label()
        Me.Addrecordtab = New System.Windows.Forms.TabPage()
        Me.addjournallbl = New System.Windows.Forms.Label()
        Me.addJournal = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        createaccountlbl = New System.Windows.Forms.Label()
        Me.helpscreentabmenu.SuspendLayout()
        Me.loginscreenhelptab.SuspendLayout()
        Me.createaccounttab.SuspendLayout()
        Me.Searchtab.SuspendLayout()
        Me.Addrecordtab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'createaccountlbl
        '
        createaccountlbl.AutoSize = True
        createaccountlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        createaccountlbl.Location = New System.Drawing.Point(6, 0)
        createaccountlbl.Name = "createaccountlbl"
        createaccountlbl.Size = New System.Drawing.Size(436, 120)
        createaccountlbl.TabIndex = 0
        createaccountlbl.Text = resources.GetString("createaccountlbl.Text")
        AddHandler createaccountlbl.Click, AddressOf Me.createaccountlbl_Click
        '
        'helpscreentabmenu
        '
        Me.helpscreentabmenu.Controls.Add(Me.loginscreenhelptab)
        Me.helpscreentabmenu.Controls.Add(Me.createaccounttab)
        Me.helpscreentabmenu.Controls.Add(Me.Searchtab)
        Me.helpscreentabmenu.Controls.Add(Me.Addrecordtab)
        Me.helpscreentabmenu.Controls.Add(Me.TabPage1)
        Me.helpscreentabmenu.Controls.Add(Me.TabPage2)
        Me.helpscreentabmenu.Location = New System.Drawing.Point(3, 12)
        Me.helpscreentabmenu.Name = "helpscreentabmenu"
        Me.helpscreentabmenu.SelectedIndex = 0
        Me.helpscreentabmenu.Size = New System.Drawing.Size(502, 273)
        Me.helpscreentabmenu.TabIndex = 0
        '
        'loginscreenhelptab
        '
        Me.loginscreenhelptab.Controls.Add(Me.loginlbl)
        Me.loginscreenhelptab.Location = New System.Drawing.Point(4, 22)
        Me.loginscreenhelptab.Name = "loginscreenhelptab"
        Me.loginscreenhelptab.Padding = New System.Windows.Forms.Padding(3)
        Me.loginscreenhelptab.Size = New System.Drawing.Size(438, 235)
        Me.loginscreenhelptab.TabIndex = 0
        Me.loginscreenhelptab.Text = "Login Screen Help"
        Me.loginscreenhelptab.UseVisualStyleBackColor = True
        '
        'loginlbl
        '
        Me.loginlbl.AutoSize = True
        Me.loginlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.loginlbl.Location = New System.Drawing.Point(3, 3)
        Me.loginlbl.Name = "loginlbl"
        Me.loginlbl.Size = New System.Drawing.Size(367, 221)
        Me.loginlbl.TabIndex = 0
        Me.loginlbl.Text = resources.GetString("loginlbl.Text")
        '
        'createaccounttab
        '
        Me.createaccounttab.Controls.Add(createaccountlbl)
        Me.createaccounttab.Location = New System.Drawing.Point(4, 22)
        Me.createaccounttab.Name = "createaccounttab"
        Me.createaccounttab.Padding = New System.Windows.Forms.Padding(3)
        Me.createaccounttab.Size = New System.Drawing.Size(494, 247)
        Me.createaccounttab.TabIndex = 1
        Me.createaccounttab.Text = "Create Account Help"
        Me.createaccounttab.UseVisualStyleBackColor = True
        '
        'Searchtab
        '
        Me.Searchtab.Controls.Add(Me.srchlbl)
        Me.Searchtab.Location = New System.Drawing.Point(4, 22)
        Me.Searchtab.Name = "Searchtab"
        Me.Searchtab.Padding = New System.Windows.Forms.Padding(3)
        Me.Searchtab.Size = New System.Drawing.Size(494, 247)
        Me.Searchtab.TabIndex = 2
        Me.Searchtab.Text = "Search Help"
        Me.Searchtab.UseVisualStyleBackColor = True
        '
        'srchlbl
        '
        Me.srchlbl.AutoSize = True
        Me.srchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.srchlbl.Location = New System.Drawing.Point(3, 0)
        Me.srchlbl.Name = "srchlbl"
        Me.srchlbl.Size = New System.Drawing.Size(420, 96)
        Me.srchlbl.TabIndex = 0
        Me.srchlbl.Text = resources.GetString("srchlbl.Text")
        '
        'Addrecordtab
        '
        Me.Addrecordtab.Controls.Add(Me.addjournallbl)
        Me.Addrecordtab.Controls.Add(Me.addJournal)
        Me.Addrecordtab.Location = New System.Drawing.Point(4, 22)
        Me.Addrecordtab.Name = "Addrecordtab"
        Me.Addrecordtab.Padding = New System.Windows.Forms.Padding(3)
        Me.Addrecordtab.Size = New System.Drawing.Size(494, 247)
        Me.Addrecordtab.TabIndex = 3
        Me.Addrecordtab.Text = "Add Record"
        Me.Addrecordtab.UseVisualStyleBackColor = True
        '
        'addjournallbl
        '
        Me.addjournallbl.AutoSize = True
        Me.addjournallbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.addjournallbl.Location = New System.Drawing.Point(5, 3)
        Me.addjournallbl.Name = "addjournallbl"
        Me.addjournallbl.Size = New System.Drawing.Size(398, 195)
        Me.addjournallbl.TabIndex = 1
        Me.addjournallbl.Text = resources.GetString("addjournallbl.Text")
        '
        'addJournal
        '
        Me.addJournal.AutoSize = True
        Me.addJournal.Location = New System.Drawing.Point(26, 60)
        Me.addJournal.Name = "addJournal"
        Me.addJournal.Size = New System.Drawing.Size(0, 13)
        Me.addJournal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(494, 247)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Search Author"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(494, 247)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "View Review"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 68)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Helpform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 297)
        Me.Controls.Add(Me.helpscreentabmenu)
        Me.Name = "Helpform"
        Me.Text = "Helpform"
        Me.helpscreentabmenu.ResumeLayout(False)
        Me.loginscreenhelptab.ResumeLayout(False)
        Me.loginscreenhelptab.PerformLayout()
        Me.createaccounttab.ResumeLayout(False)
        Me.createaccounttab.PerformLayout()
        Me.Searchtab.ResumeLayout(False)
        Me.Searchtab.PerformLayout()
        Me.Addrecordtab.ResumeLayout(False)
        Me.Addrecordtab.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents helpscreentabmenu As System.Windows.Forms.TabControl
    Friend WithEvents loginscreenhelptab As System.Windows.Forms.TabPage
    Friend WithEvents createaccounttab As System.Windows.Forms.TabPage
    Friend WithEvents loginlbl As System.Windows.Forms.Label
    Friend WithEvents Searchtab As System.Windows.Forms.TabPage
    Friend WithEvents srchlbl As System.Windows.Forms.Label
    Friend WithEvents Addrecordtab As System.Windows.Forms.TabPage
    Friend WithEvents addJournal As System.Windows.Forms.Label
    Friend WithEvents addjournallbl As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
