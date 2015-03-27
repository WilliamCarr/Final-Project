Public Class createaccounts

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles createaccount.Click

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()

    End Sub

    Private Sub USERNAMEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles USERNAMEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.USERNAMEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub createaccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.USERNAME' table. You can move, or remove it, as needed.
        Me.USERNAMETableAdapter.Fill(Me.DataSet1.USERNAME)

    End Sub

    Private Sub USERNAMEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles USERNAMEDataGridView.CellContentClick
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Helpform.Show()
    End Sub
End Class