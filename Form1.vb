Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnWelcome.Click


        MessageBox.Show("Hello, you just signed up!")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()
    End Sub
End Class
