<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Searchauthors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Searchauthors))
        Me.Searchjournalauthorlbl = New System.Windows.Forms.Label()
        Me.Searchjournalauthortxt = New System.Windows.Forms.TextBox()
        Me.searchjournalauthorbtn = New System.Windows.Forms.Button()
        Me.DataSet1 = New Project1.DataSet1()
        Me.AUTHORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUTHORTableAdapter = New Project1.DataSet1TableAdapters.AUTHORTableAdapter()
        Me.TableAdapterManager = New Project1.DataSet1TableAdapters.TableAdapterManager()
        Me.AUTHORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AUTHORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AUTHORDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Help = New System.Windows.Forms.Button()
        Me.Mainmenubtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUTHORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUTHORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AUTHORBindingNavigator.SuspendLayout()
        CType(Me.AUTHORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Searchjournalauthorlbl
        '
        Me.Searchjournalauthorlbl.AutoSize = True
        Me.Searchjournalauthorlbl.Location = New System.Drawing.Point(69, 209)
        Me.Searchjournalauthorlbl.Name = "Searchjournalauthorlbl"
        Me.Searchjournalauthorlbl.Size = New System.Drawing.Size(112, 13)
        Me.Searchjournalauthorlbl.TabIndex = 18
        Me.Searchjournalauthorlbl.Text = "Search Journal Author"
        '
        'Searchjournalauthortxt
        '
        Me.Searchjournalauthortxt.Location = New System.Drawing.Point(202, 207)
        Me.Searchjournalauthortxt.Name = "Searchjournalauthortxt"
        Me.Searchjournalauthortxt.Size = New System.Drawing.Size(100, 20)
        Me.Searchjournalauthortxt.TabIndex = 17
        '
        'searchjournalauthorbtn
        '
        Me.searchjournalauthorbtn.Location = New System.Drawing.Point(318, 205)
        Me.searchjournalauthorbtn.Name = "searchjournalauthorbtn"
        Me.searchjournalauthorbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchjournalauthorbtn.TabIndex = 16
        Me.searchjournalauthorbtn.Text = "Search"
        Me.searchjournalauthorbtn.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AUTHORBindingSource
        '
        Me.AUTHORBindingSource.DataMember = "AUTHOR"
        Me.AUTHORBindingSource.DataSource = Me.DataSet1
        '
        'AUTHORTableAdapter
        '
        Me.AUTHORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARTICLE_HISTORYTableAdapter = Nothing
        Me.TableAdapterManager.ARTICLE_REVIEWTableAdapter = Nothing
        Me.TableAdapterManager.ARTICLETableAdapter = Nothing
        Me.TableAdapterManager.AUTHORTableAdapter = Me.AUTHORTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RESEARCH_GROUPTableAdapter = Nothing
        Me.TableAdapterManager.RESEARCHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERNAMETableAdapter = Nothing
        '
        'AUTHORBindingNavigator
        '
        Me.AUTHORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AUTHORBindingNavigator.BindingSource = Me.AUTHORBindingSource
        Me.AUTHORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AUTHORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AUTHORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AUTHORBindingNavigatorSaveItem})
        Me.AUTHORBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AUTHORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AUTHORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AUTHORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AUTHORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AUTHORBindingNavigator.Name = "AUTHORBindingNavigator"
        Me.AUTHORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AUTHORBindingNavigator.Size = New System.Drawing.Size(472, 25)
        Me.AUTHORBindingNavigator.TabIndex = 19
        Me.AUTHORBindingNavigator.Text = "BindingNavigator1"
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
        'AUTHORBindingNavigatorSaveItem
        '
        Me.AUTHORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AUTHORBindingNavigatorSaveItem.Image = CType(resources.GetObject("AUTHORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AUTHORBindingNavigatorSaveItem.Name = "AUTHORBindingNavigatorSaveItem"
        Me.AUTHORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AUTHORBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AUTHORDataGridView
        '
        Me.AUTHORDataGridView.AutoGenerateColumns = False
        Me.AUTHORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AUTHORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.AUTHORDataGridView.DataSource = Me.AUTHORBindingSource
        Me.AUTHORDataGridView.Location = New System.Drawing.Point(12, 44)
        Me.AUTHORDataGridView.Name = "AUTHORDataGridView"
        Me.AUTHORDataGridView.Size = New System.Drawing.Size(351, 109)
        Me.AUTHORDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AUTHOR_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AUTHOR_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AUTHOR_FIRST_NAME_INITIAL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AUTHOR_FIRST_NAME_INITIAL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AUTHOR_SURNAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AUTHOR_SURNAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(12, 239)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(84, 26)
        Me.Help.TabIndex = 20
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Mainmenubtn
        '
        Me.Mainmenubtn.Location = New System.Drawing.Point(375, 239)
        Me.Mainmenubtn.Name = "Mainmenubtn"
        Me.Mainmenubtn.Size = New System.Drawing.Size(97, 26)
        Me.Mainmenubtn.TabIndex = 21
        Me.Mainmenubtn.Text = "Main Menu"
        Me.Mainmenubtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 26)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Search must be done by choosing the exact name of the journal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or by adding %to e" & _
    "ither side of the query to give full result"
        '
        'Searchauthors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 271)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mainmenubtn)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.AUTHORDataGridView)
        Me.Controls.Add(Me.AUTHORBindingNavigator)
        Me.Controls.Add(Me.Searchjournalauthorlbl)
        Me.Controls.Add(Me.Searchjournalauthortxt)
        Me.Controls.Add(Me.searchjournalauthorbtn)
        Me.Name = "Searchauthors"
        Me.Text = "search authors"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUTHORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUTHORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AUTHORBindingNavigator.ResumeLayout(False)
        Me.AUTHORBindingNavigator.PerformLayout()
        CType(Me.AUTHORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Searchjournalauthorlbl As System.Windows.Forms.Label
    Friend WithEvents Searchjournalauthortxt As System.Windows.Forms.TextBox
    Friend WithEvents searchjournalauthorbtn As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As Project1.DataSet1
    Friend WithEvents AUTHORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AUTHORTableAdapter As Project1.DataSet1TableAdapters.AUTHORTableAdapter
    Friend WithEvents TableAdapterManager As Project1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AUTHORBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AUTHORBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AUTHORDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents Mainmenubtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
