﻿Public Class Crash
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desktop.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
        Me.Close()
    End Sub
End Class