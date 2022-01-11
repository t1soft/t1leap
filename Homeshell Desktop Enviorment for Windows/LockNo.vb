Public Class LockNo
    Dim thisHour = DateTime.Now.TimeOfDay.Hours


    'Changes the Greeting based on Local Time, and Greets you by grabbing the Current Windows Username
    Private Sub LockNo_Load(sender As Object, e As EventArgs) Handles Me.Load
        If thisHour < 13 Then
            Label2.Text = "Good Morning,"
        ElseIf thisHour > 12 And thisHour < 8 Then
            Label2.Text = "Good Afternoon,"
        ElseIf thisHour > 7 Then
            Label2.Text = "Good Evening,"
        End If

        Label1.Text = Environment.UserName
    End Sub







    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Desktop.Show()
            Me.Hide()
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desktop.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClockText.Text = DateTime.Now.ToString("hh:mm tt")
        Label4.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub
End Class