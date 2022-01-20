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
        If Label3.Text = "none" Or Label3.Text = " " Then
            Form1.Hide()
            frmMain.Hide()
            Start.Hide()
            Tonline.Hide()
            WebBrowser.Hide()
            AppLoader.Hide()
            Dialog1.Hide()
            Desktop.Hide()
            LockNo.Show()
            Me.Hide()
        Else
            Form1.Hide()
            frmMain.Hide()
            Start.Hide()
            Tonline.Hide()
            WebBrowser.Hide()
            AppLoader.Hide()
            Dialog1.Hide()
            Desktop.Hide()
            LockKey.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "none" Then
            MsgBox("Password cannot be the word 'none'.", MsgBoxStyle.Critical, "HDEM4 - Error")
        Else
            Label3.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label3.Text = "none"
        TextBox1.Text = ""
    End Sub
End Class