Imports System.IO
Imports Microsoft.Toolkit.Uwp.Notifications

Public Class LockKey

    Dim thisHour = DateTime.Now.TimeOfDay.Hours
    Dim TempPass = Form4.Label3.Text



    'Changes the Greeting based on Local Time, and Greets you by grabbing the Current Windows Username
    Private Sub LockKey_Load(sender As Object, e As EventArgs) Handles Me.Load
        If thisHour < 13 Then
            Greeting.Text = "Good Morning,"
        ElseIf thisHour > 12 And thisHour < 8 Then
            Greeting.Text = "Good Afternoon,"
        ElseIf thisHour > 7 Then
            Greeting.Text = "Good Evening,"
        End If

        UserText.Text = Environment.UserName
    End Sub








    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = TempPass Then
            Application.Exit()
            End
        Else
            Incorrect()
            Label1.Text = "The Password is Incorrect. You will need to enter it to exit the environment."
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TempPass Then
            For Each form In My.Application.OpenForms
                If (form.name = leapwrite.Name) Then
                    leapwrite.Show()
                End If
            Next
            For Each form In My.Application.OpenForms
                If (form.name = leaptable.Name) Then
                    leaptable.Show()

                End If
            Next
            For Each form In My.Application.OpenForms
                If (form.name = WebBrowser.Name) Then
                    WebBrowser.Show()
                End If
            Next

            Desktop.Show()
            Me.Close()
        Else
            Label1.Text = "The Password is Incorrect. You will need to enter it to log back into the environment."
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If TextBox1.Text = TempPass Then
                For Each form In My.Application.OpenForms
                    If (form.name = leapwrite.Name) Then
                        leapwrite.Show()
                    End If
                Next
                For Each form In My.Application.OpenForms
                    If (form.name = leaptable.Name) Then
                        leaptable.Show()

                    End If
                Next
                For Each form In My.Application.OpenForms
                    If (form.name = WebBrowser.Name) Then
                        WebBrowser.Show()
                    End If
                Next

                Desktop.Show()
                Me.Close()
            Else
                Label1.Text = "The Password is Incorrect. You will need to enter it to log back into the environment."
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClockText.Text = DateTime.Now.ToString("hh:mm tt")
        DateText.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub


End Class


