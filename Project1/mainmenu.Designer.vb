<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Me.rsrchjrnlsys = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Addjournal = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Help = New System.Windows.Forms.Button()
        Me.UploadJournalbtn = New System.Windows.Forms.Button()
        Me.reviewopen = New System.Windows.Forms.Button()
        Me.Searchauthor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rsrchjrnlsys
        '
        Me.rsrchjrnlsys.AutoSize = True
        Me.rsrchjrnlsys.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.rsrchjrnlsys.Location = New System.Drawing.Point(-5, 9)
        Me.rsrchjrnlsys.Name = "rsrchjrnlsys"
        Me.rsrchjrnlsys.Size = New System.Drawing.Size(477, 46)
        Me.rsrchjrnlsys.TabIndex = 0
        Me.rsrchjrnlsys.Text = "Research Journal System"
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(364, 308)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(75, 23)
        Me.Logout.TabIndex = 1
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Addjournal
        '
        Me.Addjournal.Location = New System.Drawing.Point(49, 112)
        Me.Addjournal.Name = "Addjournal"
        Me.Addjournal.Size = New System.Drawing.Size(98, 48)
        Me.Addjournal.TabIndex = 2
        Me.Addjournal.Text = "Add Journal"
        Me.Addjournal.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(164, 112)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(122, 48)
        Me.Search.TabIndex = 3
        Me.Search.Text = "Search for Journal"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(12, 308)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(84, 26)
        Me.Help.TabIndex = 9
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'UploadJournalbtn
        '
        Me.UploadJournalbtn.Location = New System.Drawing.Point(306, 112)
        Me.UploadJournalbtn.Name = "UploadJournalbtn"
        Me.UploadJournalbtn.Size = New System.Drawing.Size(122, 48)
        Me.UploadJournalbtn.TabIndex = 10
        Me.UploadJournalbtn.Text = "Upload a journal"
        Me.UploadJournalbtn.UseVisualStyleBackColor = True
        '
        'reviewopen
        '
        Me.reviewopen.Location = New System.Drawing.Point(245, 192)
        Me.reviewopen.Name = "reviewopen"
        Me.reviewopen.Size = New System.Drawing.Size(122, 48)
        Me.reviewopen.TabIndex = 11
        Me.reviewopen.Text = "review a journal"
        Me.reviewopen.UseVisualStyleBackColor = True
        '
        'Searchauthor
        '
        Me.Searchauthor.Location = New System.Drawing.Point(85, 192)
        Me.Searchauthor.Name = "Searchauthor"
        Me.Searchauthor.Size = New System.Drawing.Size(122, 48)
        Me.Searchauthor.TabIndex = 12
        Me.Searchauthor.Text = "Search an author"
        Me.Searchauthor.UseVisualStyleBackColor = True
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 346)
        Me.Controls.Add(Me.Searchauthor)
        Me.Controls.Add(Me.reviewopen)
        Me.Controls.Add(Me.UploadJournalbtn)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Addjournal)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.rsrchjrnlsys)
        Me.Name = "mainmenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rsrchjrnlsys As System.Windows.Forms.Label
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents Addjournal As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents UploadJournalbtn As System.Windows.Forms.Button
    Friend WithEvents reviewopen As System.Windows.Forms.Button
    Friend WithEvents Searchauthor As System.Windows.Forms.Button
End Class
