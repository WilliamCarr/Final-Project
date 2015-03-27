Public Class review

    Private Sub ARTICLE_REVIEWBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ARTICLE_REVIEWBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ARTICLE_REVIEW' table. You can move, or remove it, as needed.
        Label3.Hide()
        reviewbtn.Hide()
        Me.ARTICLE_REVIEWTableAdapter.ScalarQuery.ToString()




    End Sub

    Private Sub reviewbtn_Click(sender As Object, e As EventArgs) Handles reviewbtn.Click

        'ARTICLEDataGridView.DataSource = Me.DataSet1.ARTICLE.Select("Keywords like'" & searchjournalkeywordstxt.Text & "'")'

        MsgBox(Me.ARTICLE_REVIEWTableAdapter.ScalarQuery)

    End Sub

   

   

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Helpform.Show()
    End Sub

    Private Sub Mainmenubtn_Click(sender As Object, e As EventArgs) Handles Mainmenubtn.Click
        Me.Close()
    End Sub

    Private Sub ARTICLE_REVIEWDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ARTICLE_REVIEWDataGridView.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = ("Search Quality and Revenue Cannibalization by Competing Search Engines") Then
            Me.ARTICLE_REVIEWTableAdapter.Fill(Me.DataSet1.ARTICLE_REVIEW)
            Label3.Show()
            reviewbtn.Show()
        End If

    End Sub
End Class