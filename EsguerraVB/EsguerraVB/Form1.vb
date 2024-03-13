Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim Password As String

        username = TextBox1.Text
        Password = TextBox2.Text

        MsgBox("Username: " + username + vbCrLf +
               "Password: " + Password)

    End Sub
End Class
