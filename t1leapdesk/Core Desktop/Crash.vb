Public Class Crash


    Dim SecondStatus As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SecondStatus = SecondStatus + 1
        If SecondStatus = 15 Then
            Application.Exit()
            End
        End If
    End Sub

    Private Sub Crash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Panel1.Parent.Width - Panel1.Width) / 2
        Panel1.Top = (Panel1.Parent.Height - Panel1.Height) / 2
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class