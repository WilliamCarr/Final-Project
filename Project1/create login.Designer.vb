<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createaccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createaccounts))
        Me.createaccount = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.DataSet1 = New Project1.DataSet1()
        Me.USERNAMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Project1.DataSet1TableAdapters.TableAdapterManager()
        Me.USERNAMETableAdapter = New Project1.DataSet1TableAdapters.USERNAMETableAdapter()
        Me.USERNAMEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.USERNAMEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Help = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERNAMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERNAMEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.USERNAMEBindingNavigator.SuspendLayout()
        CType(Me.USERNAMEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'createaccount
        '
        Me.createaccount.AutoSize = True
        Me.createaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.createaccount.Location = New System.Drawing.Point(47, 28)
        Me.createaccount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.createaccount.Name = "createaccount"
        Me.createaccount.Size = New System.Drawing.Size(281, 44)
        Me.createaccount.TabIndex = 0
        Me.createaccount.Text = "Create Account"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(593, 274)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(99, 31)
        Me.Back.TabIndex = 3
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USERNAMEBindingSource
        '
        Me.USERNAMEBindingSource.DataMember = "USERNAME"
        Me.USERNAMEBindingSource.DataSource = Me.DataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARTICLE_HISTORYTableAdapter = Nothing
        Me.TableAdapterManager.ARTICLE_REVIEWTableAdapter = Nothing
        Me.TableAdapterManager.ARTICLETableAdapter = Nothing
        Me.TableAdapterManager.AUTHORTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RESEARCH_GROUPTableAdapter = Nothing
        Me.TableAdapterManager.RESEARCHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERNAMETableAdapter = Me.USERNAMETableAdapter
        '
        'USERNAMETableAdapter
        '
        Me.USERNAMETableAdapter.ClearBeforeFill = True
        '
        'USERNAMEBindingNavigator
        '
        Me.USERNAMEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.USERNAMEBindingNavigator.BindingSource = Me.USERNAMEBindingSource
        Me.USERNAMEBindingNavigator.CountItem = Nothing
        Me.USERNAMEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.USERNAMEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.USERNAMEBindingNavigatorSaveItem})
        Me.USERNAMEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.USERNAMEBindingNavigator.MoveFirstItem = Nothing
        Me.USERNAMEBindingNavigator.MoveLastItem = Nothing
        Me.USERNAMEBindingNavigator.MoveNextItem = Nothing
        Me.USERNAMEBindingNavigator.MovePreviousItem = Nothing
        Me.USERNAMEBindingNavigator.Name = "USERNAMEBindingNavigator"
        Me.USERNAMEBindingNavigator.PositionItem = Nothing
        Me.USERNAMEBindingNavigator.Size = New System.Drawing.Size(705, 25)
        Me.USERNAMEBindingNavigator.TabIndex = 4
        Me.USERNAMEBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'USERNAMEBindingNavigatorSaveItem
        '
        Me.USERNAMEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.USERNAMEBindingNavigatorSaveItem.Image = CType(resources.GetObject("USERNAMEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.USERNAMEBindingNavigatorSaveItem.Name = "USERNAMEBindingNavigatorSaveItem"
        Me.USERNAMEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.USERNAMEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(25, 274)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(84, 26)
        Me.Help.TabIndex = 9
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RESEARCHER_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 148
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "USER_FULL_NAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "USER_FULL_NAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 160
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PASSWORD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PASSWORD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 113
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "USERNAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "USERNAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "USERNAME_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "USERNAME_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 131
        '
        'USERNAMEDataGridView
        '
        Me.USERNAMEDataGridView.AutoGenerateColumns = False
        Me.USERNAMEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.USERNAMEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.USERNAMEDataGridView.DataSource = Me.USERNAMEBindingSource
        Me.USERNAMEDataGridView.Location = New System.Drawing.Point(13, 132)
        Me.USERNAMEDataGridView.Name = "USERNAMEDataGridView"
        Me.USERNAMEDataGridView.Size = New System.Drawing.Size(680, 120)
        Me.USERNAMEDataGridView.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 34)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "To Create an new Account simply input your: Name, Password and Username " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and pre" & _
    "ss the Plus symbol in the topleftcorner"
        '
        'createaccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 330)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.USERNAMEDataGridView)
        Me.Controls.Add(Me.USERNAMEBindingNavigator)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.createaccount)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "createaccounts"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERNAMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERNAMEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.USERNAMEBindingNavigator.ResumeLayout(False)
        Me.USERNAMEBindingNavigator.PerformLayout()
        CType(Me.USERNAMEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createaccount As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As Project1.DataSet1
    Friend WithEvents USERNAMEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Project1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents USERNAMEBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents USERNAMEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents USERNAMETableAdapter As Project1.DataSet1TableAdapters.USERNAMETableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
