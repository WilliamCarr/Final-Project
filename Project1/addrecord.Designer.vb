<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addrecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addrecord))
        Me.Addrecordlbl = New System.Windows.Forms.Label()
        Me.Help = New System.Windows.Forms.Button()
        Me.Mainmenubtn = New System.Windows.Forms.Button()
        Me.DataSet12 = New Project1.DataSet1()
        Me.ARTICLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICLETableAdapter2 = New Project1.DataSet1TableAdapters.ARTICLETableAdapter()
        Me.TableAdapterManager2 = New Project1.DataSet1TableAdapters.TableAdapterManager()
        Me.ARTICLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ARTICLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ARTICLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ARTICLEBindingNavigator.SuspendLayout()
        CType(Me.ARTICLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Addrecordlbl
        '
        Me.Addrecordlbl.AutoSize = True
        Me.Addrecordlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Addrecordlbl.Location = New System.Drawing.Point(74, 44)
        Me.Addrecordlbl.Name = "Addrecordlbl"
        Me.Addrecordlbl.Size = New System.Drawing.Size(233, 46)
        Me.Addrecordlbl.TabIndex = 0
        Me.Addrecordlbl.Text = "Add Journal"
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(12, 523)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(84, 26)
        Me.Help.TabIndex = 9
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Mainmenubtn
        '
        Me.Mainmenubtn.Location = New System.Drawing.Point(1353, 523)
        Me.Mainmenubtn.Name = "Mainmenubtn"
        Me.Mainmenubtn.Size = New System.Drawing.Size(97, 26)
        Me.Mainmenubtn.TabIndex = 10
        Me.Mainmenubtn.Text = "Main Menu"
        Me.Mainmenubtn.UseVisualStyleBackColor = True
        '
        'DataSet12
        '
        Me.DataSet12.DataSetName = "DataSet1"
        Me.DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARTICLEBindingSource
        '
        Me.ARTICLEBindingSource.DataMember = "ARTICLE"
        Me.ARTICLEBindingSource.DataSource = Me.DataSet12
        '
        'ARTICLETableAdapter2
        '
        Me.ARTICLETableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.ARTICLE_HISTORYTableAdapter = Nothing
        Me.TableAdapterManager2.ARTICLE_REVIEWTableAdapter = Nothing
        Me.TableAdapterManager2.ARTICLETableAdapter = Me.ARTICLETableAdapter2
        Me.TableAdapterManager2.AUTHORTableAdapter = Nothing
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.RESEARCH_GROUPTableAdapter = Nothing
        Me.TableAdapterManager2.RESEARCHERTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = Project1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.USERNAMETableAdapter = Nothing
        '
        'ARTICLEBindingNavigator
        '
        Me.ARTICLEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ARTICLEBindingNavigator.BindingSource = Me.ARTICLEBindingSource
        Me.ARTICLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ARTICLEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ARTICLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ARTICLEBindingNavigatorSaveItem})
        Me.ARTICLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ARTICLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ARTICLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ARTICLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ARTICLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ARTICLEBindingNavigator.Name = "ARTICLEBindingNavigator"
        Me.ARTICLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ARTICLEBindingNavigator.Size = New System.Drawing.Size(1462, 25)
        Me.ARTICLEBindingNavigator.TabIndex = 28
        Me.ARTICLEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ARTICLEBindingNavigatorSaveItem
        '
        Me.ARTICLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ARTICLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("ARTICLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ARTICLEBindingNavigatorSaveItem.Name = "ARTICLEBindingNavigatorSaveItem"
        Me.ARTICLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ARTICLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ARTICLEDataGridView
        '
        Me.ARTICLEDataGridView.AutoGenerateColumns = False
        Me.ARTICLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ARTICLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.ARTICLEDataGridView.DataSource = Me.ARTICLEBindingSource
        Me.ARTICLEDataGridView.Location = New System.Drawing.Point(12, 165)
        Me.ARTICLEDataGridView.Name = "ARTICLEDataGridView"
        Me.ARTICLEDataGridView.Size = New System.Drawing.Size(1411, 352)
        Me.ARTICLEDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ARTICLE_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ARTICLE_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ARTICLE_NAME"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ARTICLE_NAME"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ARTICLE_AUTHOR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ARTICLE_AUTHOR"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ARTICLE_ABSTRACT"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ARTICLE_ABSTRACT"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 140
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DATE_PUBLISHED"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DATE_PUBLISHED"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ISSUE_NUMBER"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ISSUE_NUMBER"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "KEYWORDS"
        Me.DataGridViewTextBoxColumn15.HeaderText = "KEYWORDS"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 95
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "If you wish to input a new journal, fill in all data fields and press the add but" & _
    "ton in the hotbar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "for additional help press the help button"
        '
        'addrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 677)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ARTICLEDataGridView)
        Me.Controls.Add(Me.ARTICLEBindingNavigator)
        Me.Controls.Add(Me.Mainmenubtn)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.Addrecordlbl)
        Me.Name = "addrecord"
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ARTICLEBindingNavigator.ResumeLayout(False)
        Me.ARTICLEBindingNavigator.PerformLayout()
        CType(Me.ARTICLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Addrecordlbl As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Project1.DataSet1
    Friend WithEvents ARTICLETableAdapter As Project1.DataSet1TableAdapters.ARTICLETableAdapter
    Friend WithEvents TableAdapterManager As Project1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents Mainmenubtn As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSet11 As Project1.DataSet1
    Friend WithEvents ARTICLETableAdapter1 As Project1.DataSet1TableAdapters.ARTICLETableAdapter
    Friend WithEvents TableAdapterManager1 As Project1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DataSet12 As Project1.DataSet1
    Friend WithEvents ARTICLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICLETableAdapter2 As Project1.DataSet1TableAdapters.ARTICLETableAdapter
    Friend WithEvents TableAdapterManager2 As Project1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ARTICLEBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ARTICLEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ARTICLEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
