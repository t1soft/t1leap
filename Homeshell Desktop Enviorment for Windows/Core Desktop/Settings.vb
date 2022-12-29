Public Class Settings

    Dim IMG As String
    Dim passwordAuth As Boolean = False

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()
        leapwrite.Close()
        leaptable.Close()
        Start.Close()
        Tonline.Close()
        WebBrowser.Close()

        Dialog1.Close()
        Desktop.Close()
        Crash.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        open_dialog1.Filter = "Image/Picture Files|*.jpg;*.gif;*.png;*.tiff;*.bmp"

        If open_dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            IMG = open_dialog1.FileName
            My.Settings.wallpaper = IMG
            My.Settings.Save()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.wallpaper = Nothing
        My.Settings.Save()
    End Sub

    Function ChangePass()
        If passwordSetText.Text = Nothing Then
            My.Settings.password = Nothing
            My.Settings.Save()
            Label11.Text = "Account Password: Not Set"
            My.Settings.passwordEnabled = False
        Else
            My.Settings.password = passwordSetText.Text
            My.Settings.Save()
            Label11.Text = "Account Password: Set"
            My.Settings.passwordEnabled = True
        End If
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.passwordEnabled = False Then
            If passwordComfirmText.Text = passwordSetText.Text Then
                ChangePass()
            Else
                Label11.Text = "Passwords do not Match!"
            End If
        End If
        If My.Settings.passwordEnabled = True Then
            If passwordComfirmText.Text = passwordSetText.Text Then
                PasswordComfirm.ShowDialog()
            Else
                Label11.Text = "Passwords do not Match!"
            End If
        End If
    End Sub
End Class