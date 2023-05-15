Public Class Form1
    Dim TimeElapsed = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeElapsed = TimeElapsed + 1
        If TimeElapsed = 2 Then
            leaptrack.Show()
            Me.Close()
        End If
    End Sub
End Class