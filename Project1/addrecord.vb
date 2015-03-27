Public Class addrecord



    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Helpform.Show()
    End Sub

    Private Sub Mainmenubtn_Click(sender As Object, e As EventArgs) Handles Mainmenubtn.Click
        Me.Close()
    End Sub


   

  
    Private Sub Addrecordbtn_Click(sender As Object, e As EventArgs)
        Dim data As New DataSet1
        data.ARTICLE.NewARTICLERow()
    End Sub

    Private Sub ARTICLEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ARTICLEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ARTICLEBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.DataSet12)

    End Sub

    Private Sub addrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet12.ARTICLE' table. You can move, or remove it, as needed.
        Me.ARTICLETableAdapter2.Fill(Me.DataSet12.ARTICLE)

    End Sub

    Private Sub ARTICLEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ARTICLEDataGridView.CellContentClick

    End Sub
End Class