Public Class Form1

    Dim failsafe As Boolean


    'Enables the Failsafe Feature (Do this if you are Testing)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        failsafe = False
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "password" Then
            If failsafe = True Then
                Crash.Show()

            Else
                Desktop.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Incorrect Password.")
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClockText.Text = DateTime.Now.ToString("hh:mm tt")
        Label4.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If TextBox1.Text = "password" Then
                If failsafe = True Then
                    Crash.Show()

                Else
                    Desktop.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Incorrect Password.")
            End If
        End If

    End Sub
End Class


