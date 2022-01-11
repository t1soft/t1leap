Imports System.IO
Imports System.Text

Public Class Form4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()
        frmMain.Close()
        Start.Close()
        Tonline.Close()
        WebBrowser.Close()
        AppLoader.Close()
        Dialog1.Close()
        Desktop.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Hide()
        frmMain.Hide()
        Start.Hide()
        Tonline.Hide()
        WebBrowser.Hide()
        AppLoader.Hide()
        Dialog1.Hide()
        Desktop.Hide()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class