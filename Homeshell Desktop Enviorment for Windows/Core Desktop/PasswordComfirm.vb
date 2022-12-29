Public Class PasswordComfirm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.password Then
            Settings.ChangePass()
        End If
    End Sub
End Class