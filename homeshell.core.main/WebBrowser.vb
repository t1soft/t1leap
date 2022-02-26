

Public Class WebBrowser

#Region "WebBoxToolStripMenu"


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub GiveFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveFeedbackToolStripMenuItem.Click
        Feedback.Show()
    End Sub


#End Region

    'This is for the WebBox Menu on the Tool Strip (for the Back, Forward, Refresh Controld, go to WebBox Browser controls instead.)


#Region "WebBox Browser Controls"

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        WebView21.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        WebView21.GoForward()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        WebView21.Refresh()
    End Sub

#End Region

    'This is for the WebBox Browser Controls (Go Back, Go Forward, Refresh)
End Class