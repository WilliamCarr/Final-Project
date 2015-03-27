<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchjournal
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
        Me.components = New System.ComponentModel.Container()
        Me.Searchlblname = New System.Windows.Forms.Label()
        Me.searchtxtname = New System.Windows.Forms.TextBox()
        Me.srchbuttonname = New System.Windows.Forms.Button()
        Me.DataSet1 = New Project1.DataSet1()
        Me.ARTICLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICLETableAdapter = New Project1.DataSet1TableAdapters.ARTICLETableAdapter()
        Me.TableAdapterManager = New Project1.DataSet1TableAdapters.TableAdapterManager()
        Me.ARTICLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.searchjournalkeywordslbl = New System.Windows.Forms.Label()
        Me.searchjournalkeywordstxt = New System.Windows.Forms.TextBox()
        Me.SearchJournalKeywordsbtn = New System.Windows.Forms.Button()
        Me.Searchjournalauthorlbl = New System.Windows.Forms.Label()
        Me.Searchjournalauthortxt = New System.Windows.Forms.TextBox()
        Me.searchjournalauthorbtn = New System.Windows.Forms.Button()
        Me.searchcmbxlbl = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Help = New System.Windows.Forms.Button()
        Me.Mainmenubtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Searchlblname
        '
        Me.Searchlblname.AutoSize = True
        Me.Searchlblname.Location = New System.Drawing.Point(267, 321)
        Me.Searchlblname.Name = "Searchlblname"
        Me.Searchlblname.Size = New System.Drawing.Size(109, 13)
        Me.Searchlblname.TabIndex = 7
        Me.Searchlblname.Text = "Search Journal Name"
        '
        'searchtxtname
        '
        Me.searchtxtname.Location = New System.Drawing.Point(400, 317)
        Me.searchtxtname.Name = "searchtxtname"
        Me.searchtxtname.Size = New System.Drawing.Size(100, 20)
        Me.searchtxtname.TabIndex = 6
        '
        'srchbuttonname
        '
        Me.srchbuttonname.Location = New System.Drawing.Point(516, 315)
        Me.srchbuttonname.Name = "srchbuttonname"
        Me.srchbuttonname.Size = New System.Drawing.Size(75, 23)
        Me.srchbuttonname.TabIndex = 5
        Me.srchbuttonname.Text = "Search"
        Me.srchbuttonname.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARTICLEBindingSource
        '
        Me.ARTICLEBindingSource.DataMember = "ARTICLE"
        Me.ARTICLEBindingSource.DataSource = Me.DataSet1
        '
        'ARTICLETableAdapter
        '
        Me.ARTICLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARTICLE_HISTORYTableAdapter = Nothing
        Me.TableAdapterManager.ARTICLE_REVIEWTableAdapter = Nothing
        Me.TableAdapterManager.ARTICLETableAdapter = Me.ARTICLETableAdapter
        Me.TableAdapterManager.AUTHORTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RESEARCH_GROUPTableAdapter = Nothing
        Me.TableAdapterManager.RESEARCHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERNAMETableAdapter = Nothing
        '
        'ARTICLEDataGridView
        '
        Me.ARTICLEDataGridView.AutoGenerateColumns = False
        Me.ARTICLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ARTICLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ARTICLEDataGridView.DataSource = Me.ARTICLEBindingSource
        Me.ARTICLEDataGridView.Location = New System.Drawing.Point(12, 82)
        Me.ARTICLEDataGridView.Name = "ARTICLEDataGridView"
        Me.ARTICLEDataGridView.ReadOnly = True
        Me.ARTICLEDataGridView.Size = New System.Drawing.Size(843, 157)
        Me.ARTICLEDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ARTICLE_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ARTICLE_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ARTICLE_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ARTICLE_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ARTICLE_AUTHOR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ARTICLE_AUTHOR"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ARTICLE_ABSTRACT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ARTICLE_ABSTRACT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DATE_PUBLISHED"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DATE_PUBLISHED"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ISSUE_NUMBER"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ISSUE_NUMBER"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "KEYWORDS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "KEYWORDS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Journal Name", "Journal Author", "Journal Keywords"})
        Me.ComboBox1.Location = New System.Drawing.Point(470, 267)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'searchjournalkeywordslbl
        '
        Me.searchjournalkeywordslbl.AutoSize = True
        Me.searchjournalkeywordslbl.Location = New System.Drawing.Point(267, 396)
        Me.searchjournalkeywordslbl.Name = "searchjournalkeywordslbl"
        Me.searchjournalkeywordslbl.Size = New System.Drawing.Size(127, 13)
        Me.searchjournalkeywordslbl.TabIndex = 12
        Me.searchjournalkeywordslbl.Text = "Search Journal Keywords"
        '
        'searchjournalkeywordstxt
        '
        Me.searchjournalkeywordstxt.Location = New System.Drawing.Point(400, 394)
        Me.searchjournalkeywordstxt.Name = "searchjournalkeywordstxt"
        Me.searchjournalkeywordstxt.Size = New System.Drawing.Size(100, 20)
        Me.searchjournalkeywordstxt.TabIndex = 11
        '
        'SearchJournalKeywordsbtn
        '
        Me.SearchJournalKeywordsbtn.Location = New System.Drawing.Point(516, 391)
        Me.SearchJournalKeywordsbtn.Name = "SearchJournalKeywordsbtn"
        Me.SearchJournalKeywordsbtn.Size = New System.Drawing.Size(75, 23)
        Me.SearchJournalKeywordsbtn.TabIndex = 10
        Me.SearchJournalKeywordsbtn.Text = "Search"
        Me.SearchJournalKeywordsbtn.UseVisualStyleBackColor = True
        '
        'Searchjournalauthorlbl
        '
        Me.Searchjournalauthorlbl.AutoSize = True
        Me.Searchjournalauthorlbl.Location = New System.Drawing.Point(267, 358)
        Me.Searchjournalauthorlbl.Name = "Searchjournalauthorlbl"
        Me.Searchjournalauthorlbl.Size = New System.Drawing.Size(112, 13)
        Me.Searchjournalauthorlbl.TabIndex = 15
        Me.Searchjournalauthorlbl.Text = "Search Journal Author"
        '
        'Searchjournalauthortxt
        '
        Me.Searchjournalauthortxt.Location = New System.Drawing.Point(400, 356)
        Me.Searchjournalauthortxt.Name = "Searchjournalauthortxt"
        Me.Searchjournalauthortxt.Size = New System.Drawing.Size(100, 20)
        Me.Searchjournalauthortxt.TabIndex = 14
        '
        'searchjournalauthorbtn
        '
        Me.searchjournalauthorbtn.Location = New System.Drawing.Point(516, 354)
        Me.searchjournalauthorbtn.Name = "searchjournalauthorbtn"
        Me.searchjournalauthorbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchjournalauthorbtn.TabIndex = 13
        Me.searchjournalauthorbtn.Text = "Search"
        Me.searchjournalauthorbtn.UseVisualStyleBackColor = True
        '
        'searchcmbxlbl
        '
        Me.searchcmbxlbl.AutoSize = True
        Me.searchcmbxlbl.Location = New System.Drawing.Point(334, 270)
        Me.searchcmbxlbl.Name = "searchcmbxlbl"
        Me.searchcmbxlbl.Size = New System.Drawing.Size(115, 13)
        Me.searchcmbxlbl.TabIndex = 16
        Me.searchcmbxlbl.Text = "Choose Search Criteria"
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Clear.Location = New System.Drawing.Point(607, 381)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(98, 33)
        Me.Clear.TabIndex = 17
        Me.Clear.Text = "Clear Search"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(297, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 39)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Search for Journal"
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(12, 388)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(84, 26)
        Me.Help.TabIndex = 19
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Mainmenubtn
        '
        Me.Mainmenubtn.Location = New System.Drawing.Point(768, 398)
        Me.Mainmenubtn.Name = "Mainmenubtn"
        Me.Mainmenubtn.Size = New System.Drawing.Size(97, 26)
        Me.Mainmenubtn.TabIndex = 20
        Me.Mainmenubtn.Text = "Main Menu"
        Me.Mainmenubtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 26)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Search must be done by choosing the exact name of the journal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or by adding %to e" & _
    "ither side of the query to give full result"
        '
        'searchjournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 436)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mainmenubtn)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.searchcmbxlbl)
        Me.Controls.Add(Me.Searchjournalauthorlbl)
        Me.Controls.Add(Me.Searchjournalauthortxt)
        Me.Controls.Add(Me.searchjournalauthorbtn)
        Me.Controls.Add(Me.searchjournalkeywordslbl)
        Me.Controls.Add(Me.searchjournalkeywordstxt)
        Me.Controls.Add(Me.SearchJournalKeywordsbtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ARTICLEDataGridView)
        Me.Controls.Add(Me.Searchlblname)
        Me.Controls.Add(Me.searchtxtname)
        Me.Controls.Add(Me.srchbuttonname)
        Me.Name = "searchjournal"
        Me.Text = "Search Journal"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Searchlblname As System.Windows.Forms.Label
    Friend WithEvents searchtxtname As System.Windows.Forms.TextBox
    Friend WithEvents srchbuttonname As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As Project1.DataSet1
    Friend WithEvents ARTICLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICLETableAdapter As Project1.DataSet1TableAdapters.ARTICLETableAdapter
    Friend WithEvents TableAdapterManager As Project1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ARTICLEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents searchjournalkeywordslbl As System.Windows.Forms.Label
    Friend WithEvents searchjournalkeywordstxt As System.Windows.Forms.TextBox
    Friend WithEvents SearchJournalKeywordsbtn As System.Windows.Forms.Button
    Friend WithEvents Searchjournalauthorlbl As System.Windows.Forms.Label
    Friend WithEvents Searchjournalauthortxt As System.Windows.Forms.TextBox
    Friend WithEvents searchjournalauthorbtn As System.Windows.Forms.Button
    Friend WithEvents searchcmbxlbl As System.Windows.Forms.Label
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents Mainmenubtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
