﻿Imports System.IO
Imports System.Text

Public Class Form4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()
        leapwrite.Close()
        leaptable.Close()
        Start.Close()
        WebBrowser.Close()

        Dialog1.Close()
        Desktop.Close()
        Settings.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class