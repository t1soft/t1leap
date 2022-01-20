Public Class Start
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser.WindowState = FormWindowState.Normal
        WebBrowser.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMain.WindowState = FormWindowState.Normal
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AppLoader.WindowState = FormWindowState.Normal
        AppLoader.Show()
        Me.Close()
    End Sub



    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Environment.UserName
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Settings.WindowState = FormWindowState.Normal
        Settings.Show()
        Me.Close()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form4.WindowState = FormWindowState.Normal
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Organizer.WindowState = FormWindowState.Normal
        Organizer.Show()
        Me.Close()
    End Sub



End Class