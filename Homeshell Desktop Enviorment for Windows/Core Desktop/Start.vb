﻿Public Class Start
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser.WindowState = FormWindowState.Normal
        WebBrowser.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        leapwrite.WindowState = FormWindowState.Normal
        leapwrite.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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
        Help.WindowState = FormWindowState.Normal
        Help.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        leaptable.WindowState = FormWindowState.Normal
        leaptable.Show()
        Me.Close()
    End Sub
End Class