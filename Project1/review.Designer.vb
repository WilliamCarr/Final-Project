<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class review
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
        Me.DataSet1 = New Project1.DataSet1()
        Me.ARTICLE_REVIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICLE_REVIEWTableAdapter = New Project1.DataSet1TableAdapters.ARTICLE_REVIEWTableAdapter()
        Me.TableAdapterManager = New Project1.DataSet1TableAdapters.TableAdapterManager()
        Me.ARTICLE_REVIEWDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reviewbtn = New System.Windows.Forms.Button()
        Me.Help = New System.Windows.Forms.Button()
        Me.Mainmenubtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICLE_REVIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICLE_REVIEWDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARTICLE_REVIEWBindingSource
        '
        Me.ARTICLE_REVIEWBindingSource.DataMember = "ARTICLE_REVIEW"
        Me.ARTICLE_REVIEWBindingSource.DataSource = Me.DataSet1
        '
        'ARTICLE_REVIEWTableAdapter
        '
        Me.ARTICLE_REVIEWTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARTICLE_HISTORYTableAdapter = Nothing
        Me.TableAdapterManager.ARTICLE_REVIEWTableAdapter = Me.ARTICLE_REVIEWTableAdapter
        Me.TableAdapterManager.ARTICLETableAdapter = Nothing
        Me.TableAdapterManager.AUTHORTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RESEARCH_GROUPTableAdapter = Nothing
        Me.TableAdapterManager.RESEARCHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERNAMETableAdapter = Nothing
        '
        'ARTICLE_REVIEWDataGridView
        '
        Me.ARTICLE_REVIEWDataGridView.AutoGenerateColumns = False
        Me.ARTICLE_REVIEWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ARTICLE_REVIEWDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ARTICLE_REVIEWDataGridView.DataSource = Me.ARTICLE_REVIEWBindingSource
        Me.ARTICLE_REVIEWDataGridView.Location = New System.Drawing.Point(26, 143)
        Me.ARTICLE_REVIEWDataGridView.Name = "ARTICLE_REVIEWDataGridView"
        Me.ARTICLE_REVIEWDataGridView.Size = New System.Drawing.Size(544, 108)
        Me.ARTICLE_REVIEWDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "REVIEW_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "REVIEW_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "REVIEW_SCORE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "REVIEW_SCORE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "REVIEW_DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "REVIEW_DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ARTICLE_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ARTICLE_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'reviewbtn
        '
        Me.reviewbtn.Location = New System.Drawing.Point(476, 270)
        Me.reviewbtn.Name = "reviewbtn"
        Me.reviewbtn.Size = New System.Drawing.Size(94, 34)
        Me.reviewbtn.TabIndex = 2
        Me.reviewbtn.Text = "ReviewScore"
        Me.reviewbtn.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(26, 348)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(84, 26)
        Me.Help.TabIndex = 9
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Mainmenubtn
        '
        Me.Mainmenubtn.Location = New System.Drawing.Point(568, 348)
        Me.Mainmenubtn.Name = "Mainmenubtn"
        Me.Mainmenubtn.Size = New System.Drawing.Size(97, 26)
        Me.Mainmenubtn.TabIndex = 11
        Me.Mainmenubtn.Text = "Main Menu"
        Me.Mainmenubtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(40, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Review Journals "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Search Quality and Revenue Cannibalization by Competing Search Engines"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Search Quality and Revenue Cannibalization by Competing Search Engines"})
        Me.ComboBox1.Location = New System.Drawing.Point(306, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(318, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Research Journal"
        '
        'review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 395)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mainmenubtn)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.reviewbtn)
        Me.Controls.Add(Me.ARTICLE_REVIEWDataGridView)
        Me.Name = "review"
        Me.Text = "review"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICLE_REVIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICLE_REVIEWDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As Project1.DataSet1
    Friend WithEvents ARTICLE_REVIEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICLE_REVIEWTableAdapter As Project1.DataSet1TableAdapters.ARTICLE_REVIEWTableAdapter
    Friend WithEvents TableAdapterManager As Project1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ARTICLE_REVIEWDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reviewbtn As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents Mainmenubtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
