Public Class searchjournal

    Private Sub Searchlbl_Click(sender As Object, e As EventArgs) Handles Searchlblname.Click

    End Sub

    Private Sub ARTICLEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ARTICLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ARTICLE' table. You can move, or remove it, as needed.
        srchbuttonname.Hide()
        Searchlblname.Hide()
        searchtxtname.Hide()

        searchjournalkeywordstxt.Hide()
        searchjournalkeywordslbl.Hide()
        SearchJournalKeywordsbtn.Hide()

        searchjournalauthorbtn.Hide()
        Searchjournalauthorlbl.Hide()
        Searchjournalauthortxt.Hide()

        Me.ARTICLETableAdapter.Fill(Me.DataSet1.ARTICLE)

    End Sub

    Private Sub ARTICLEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ARTICLEDataGridView.CellContentClick

    End Sub

    Private Sub srchbutton_Click(sender As Object, e As EventArgs) Handles srchbuttonname.Click
        ARTICLEDataGridView.DataSource = Me.DataSet1.ARTICLE.Select("ARTICLE_NAME like'" & searchtxtname.Text & "'")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "Journal Name" Then
            srchbuttonname.Show()
            Searchlblname.Show()
            searchtxtname.Show()
            searchjournalkeywordstxt.Hide()
            searchjournalkeywordslbl.Hide()
            SearchJournalKeywordsbtn.Hide()
            searchjournalauthorbtn.Hide()
            Searchjournalauthorlbl.Hide()
            Searchjournalauthortxt.Hide()
            Searchjournalauthortxt.Clear()
            searchjournalkeywordstxt.Clear()
        ElseIf ComboBox1.Text = "Journal Author" Then

            srchbuttonname.Hide()
            Searchlblname.Hide()
            searchtxtname.Hide()
            searchjournalkeywordstxt.Hide()
            searchjournalkeywordslbl.Hide()
            SearchJournalKeywordsbtn.Hide()
            searchjournalauthorbtn.Show()
            Searchjournalauthorlbl.Show()
            Searchjournalauthortxt.Show()
            searchtxtname.Clear()
            searchjournalkeywordstxt.Clear()

        ElseIf ComboBox1.Text = "Journal Keywords" Then
            srchbuttonname.Hide()
            Searchlblname.Hide()
            searchtxtname.Hide()
            searchjournalkeywordstxt.Show()
            searchjournalkeywordslbl.Show()
            SearchJournalKeywordsbtn.Show()
            searchjournalauthorbtn.Hide()
            Searchjournalauthorlbl.Hide()
            Searchjournalauthortxt.Hide()
            Searchjournalauthortxt.Clear()
            searchtxtname.Clear()
        End If
    End Sub

    Private Sub searchjournalauthorbtn_Click(sender As Object, e As EventArgs) Handles searchjournalauthorbtn.Click
        ARTICLEDataGridView.DataSource = Me.DataSet1.ARTICLE.Select("ARTICLE_Author like'" & Searchjournalauthortxt.Text & "'")
    End Sub

    Private Sub SearchJournalKeywordsbtn_Click(sender As Object, e As EventArgs) Handles SearchJournalKeywordsbtn.Click
        ARTICLEDataGridView.DataSource = Me.DataSet1.ARTICLE.Select("Keywords like'" & searchjournalkeywordstxt.Text & "'")
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click

        ARTICLEDataGridView.DataSource = Me.DataSet1.ARTICLE

    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Helpform.Show()
    End Sub

    Private Sub Mainmenubtn_Click(sender As Object, e As EventArgs) Handles Mainmenubtn.Click
        Me.Close()
    End Sub
End Class