Public Class Desktop

    Dim RemainSec As Integer


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.Close()
        PictureBox2.ImageLocation = My.Settings.wallpaper
        Quicknote.Text = My.Settings.quickNote
        TextBox1.Text = My.Settings.toDo1
        TextBox2.Text = My.Settings.toDo2
        TextBox3.Text = My.Settings.toDo3
        TextBox4.Text = My.Settings.toDo4
        TextBox5.Text = My.Settings.toDo5
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("hh:mm tt")
        Label4.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Start.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Start.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Hide()
        leapwrite.Hide()
        leaptable.Hide()
        Start.Hide()
        WebBrowser.Hide()

        Dialog1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        My.Settings.toDo1 = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        My.Settings.toDo2 = TextBox2.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        My.Settings.toDo3 = TextBox3.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        My.Settings.toDo4 = TextBox4.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        My.Settings.toDo5 = TextBox5.Text
        My.Settings.Save()
    End Sub

    Private Sub Quicknote_TextChanged(sender As Object, e As EventArgs) Handles Quicknote.TextChanged
        My.Settings.quickNote = Quicknote.Text
        My.Settings.Save()
    End Sub

End Class