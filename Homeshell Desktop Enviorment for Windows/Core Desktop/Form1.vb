Imports System
Imports System.Text
Imports System.Drawing
Imports System.Runtime.InteropServices


Public Class Form1
    Dim thisHour = DateTime.Now.TimeOfDay.Hours
    Dim timeElapse = 0
    Dim password As String
    Dim LoginReady As Boolean = False

    <DllImport("shell32", EntryPoint:="#261", CharSet:=CharSet.Unicode, PreserveSig:=False)>
    Public Shared Sub GetUserTilePath(username As String, whatever As UInt32, picpath As StringBuilder, maxLength As Integer)
    End Sub

    Public Function GetUserTilePath(username As String) As String
        Dim sb As StringBuilder
        sb = New StringBuilder(1000)
        GetUserTilePath(username, 2147483648, sb, sb.Capacity)
        Return sb.ToString()
    End Function

    Public Function GetUserTile(username As String) As Image
        Return Image.FromFile(GetUserTilePath(username))
    End Function

    Function Secret()
        If timeElapse = 10 Then
            Label6.Text = "Welcome to T1LeapDesk!"
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
            Label6.Text = "With T1Leap <3"
        ElseIf timeElapse = 27 Then
            Label6.Text = "From T1 Software!"
        ElseIf timeElapse = 29 Then
            Label6.Text = "t1leapdesk"
        End If
    End Function


    'Changes the Greeting based on Local Time, and Greets you by grabbing the Current Windows Username
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        UserText.Text = Environment.UserName
        PictureBox1.Image = GetUserTile(System.Security.Principal.WindowsIdentity.GetCurrent().Name)

        If My.Settings.passwordEnabled = True Then
            password = My.Settings.password
            TextBox1.PlaceholderText = "Enter your Password here"
            LoginReady = True
        ElseIf My.Settings.passwordEnabled = False Then
            TextBox1.PlaceholderText = "Press Enter or Login to Start, no password needed"
            LoginReady = True
        End If

        Dim MatchingNames As System.Diagnostics.Process()

        Dim TargetName As String

        TargetName = System.Diagnostics.Process.GetCurrentProcess.ProcessName

        MatchingNames = System.Diagnostics.Process.GetProcessesByName(TargetName)

        If (MatchingNames.Length = 1) Then

        Else
            MsgBox("T1LeapDesk is Already Running. Try to check for a Desktop Switch Prompt.")
            Application.Exit()
            End
        End If
    End Sub


    Function PasswordCheck()
        If My.Settings.passwordEnabled = True And LoginReady = True And TextBox1.Text = My.Settings.password Then
            Desktop.Show()
            Me.Hide()
        ElseIf My.Settings.passwordEnabled = False And LoginReady = True Then
            Desktop.Show()
            Me.Hide()
        Else
            TextBox1.Text = Nothing
            TextBox1.PlaceholderText = "Incorrect Password or Failed to Verify"
        End If
    End Function





    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            PasswordCheck()
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PasswordCheck()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeElapse = timeElapse + 1
        Secret()
    End Sub

End Class