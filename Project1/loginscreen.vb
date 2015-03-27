Public Class loginscreen


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim login = Me.UsernameTableAdapter1.UsernamePasswordstr(namebox.Text, Passwordbox.Text)

        If login Is Nothing Then
            MsgBox("Incorrect Details")
        Else
            mainmenu.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Username.Click
    End Sub
    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Password.Click
    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles loginsys.Click

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        namebox.Clear()
        Passwordbox.Clear()

    End Sub

    Private Sub CreateAccount_Click(sender As Object, e As EventArgs) Handles CreateAccount.Click

        createaccounts.Show()

    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Helpform.Show()
    End Sub

End Class
