﻿Public Class Desktop


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("hh:mm tt")
        Label4.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Start.Show()
    End Sub
End Class