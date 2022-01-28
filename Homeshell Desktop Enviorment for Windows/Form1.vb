Public Class Form1
    Dim thisHour = DateTime.Now.TimeOfDay.Hours
    Dim timeElapse = 0

    Function Secret()
        If timeElapse = 10 Then
            Label6.Text = "Welcome to Homeshell Desktop!"
        ElseIf timeElapse = 15 Then
            Label6.Text = "Designed for Focus"
        ElseIf timeElapse = 17 Then
            Label6.Text = "Simple, Elegant"
        ElseIf timeElapse = 19 Then
            Label6.Text = "For Hard Workers"
        ElseIf timeElapse = 21 Then
            Label6.Text = "With Safety in Mind"
        ElseIf timeElapse = 23 Then
            Label6.Text = "Getting Ready for the Next Generation"
        ElseIf timeElapse = 25 Then
            Label6.Text = "With Homeshell Desktrop <3"
        ElseIf timeElapse = 27 Then
            Label6.Text = "From T1 Software!"
        ElseIf timeElapse = 29 Then
            Label6.Text = "Homeshell Desktop Environment Milestone 4"
        End If
    End Function


    'Changes the Greeting based on Local Time, and Greets you by grabbing the Current Windows Username
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If thisHour < 13 Then
            Greeting.Text = "Good Morning,"
        ElseIf thisHour > 12 And thisHour < 8 Then
            Greeting.Text = "Good Afternoon,"
        ElseIf thisHour > 7 Then
            Greeting.Text = "Good Evening,"
        End If

        UserText.Text = Environment.UserName
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
        timeElapse = timeElapse + 1
        Secret()
        ClockText.Text = DateTime.Now.ToString("hh:mm tt")
        DateText.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub
End Class