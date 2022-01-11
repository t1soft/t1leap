Public Class Desktop

    Dim menu As Integer



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.Close()
        menu = 0
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
            Start.Show()
            menu = 1
        ElseIf menu = 1 Then
            Start.Hide()
            menu = 0
        ElseIf menu > 1 Then
            MsgBox("Error Result START_STATUS_OUT_OF_RANGE. Contact T1 Support.")
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Start.Hide()
        menu = 0
    End Sub
End Class