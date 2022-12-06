Public Class Settings

    Dim IMG As String

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
End Class