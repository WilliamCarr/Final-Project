Public Class mainmenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Addjournal.Click
        addrecord.Show()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Close()

    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Helpform.Show()

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Searchjournal.Show()

    End Sub


    Private Sub reviewopen_Click(sender As Object, e As EventArgs) Handles reviewopen.Click
        review.Show()
    End Sub

    Private Sub Searchauthor_Click(sender As Object, e As EventArgs) Handles Searchauthor.Click
        Searchauthors.Show()
    End Sub
End Class