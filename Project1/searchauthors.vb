Public Class Searchauthors

    Private Sub AUTHORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AUTHORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Searchauthors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.AUTHOR' table. You can move, or remove it, as needed.
        Me.AUTHORTableAdapter.Fill(Me.DataSet1.AUTHOR)
        'TODO: This line of code loads data into the 'DataSet1.AUTHOR' table. You can move, or remove it, as needed.
        Me.AUTHORTableAdapter.Fill(Me.DataSet1.AUTHOR)

    End Sub

    Private Sub searchjournalauthorbtn_Click(sender As Object, e As EventArgs) Handles searchjournalauthorbtn.Click
        AUTHORDataGridView.DataSource = Me.DataSet1.AUTHOR.Select("Author_surname like'" & Searchjournalauthortxt.Text & "'")
    End Sub

    Private Sub AUTHORBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles AUTHORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AUTHORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Helpform.Show()
    End Sub

    Private Sub Mainmenubtn_Click(sender As Object, e As EventArgs) Handles Mainmenubtn.Click
        Me.Close()
    End Sub

    Private Sub AUTHORDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AUTHORDataGridView.CellContentClick

    End Sub
End Class