Public Class Settings
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
End Class