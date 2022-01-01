Public Class Desktop

    Dim menu As Integer
    Dim panelsizey As Integer



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.Close()
        panelsizey = 38
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
        If menu = 0 Then
            Panel2.Size = New Size(955, 564)
            menu = 1
        ElseIf menu = 1 Then
            Panel2.Size = New Size(955, 38)
            menu = 0
        ElseIf menu > 1 Then
            menu = 1
            MsgBox("Error Code MENU_VAR_OUT_OF_RANGE. Start Menu will now Refresh.")
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Button2.PerformClick()
    End Sub
End Class