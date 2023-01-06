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
            Label6.Text = "t1"
        ElseIf timeElapse = 15 Then
            Label6.Text = "leapdesk"
        ElseIf timeElapse = 17 Then
            Label6.Text = "milestone"
        ElseIf timeElapse = 19 Then
            Label6.Text = "seven"
        ElseIf timeElapse = 21 Then
            Label6.Text = "T1LeapDesk"
        End If
    End Function


    'Changes the Greeting based on Local Time, and Greets you by grabbing the Current Windows Username
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        UserText.Text = Environment.UserName
        Label2.Text = Environment.MachineName

        If My.Settings.passwordEnabled = True Then
            password = My.Settings.password
            Label3.Text = "Welcome! Enter your password, then Press Enter or Login to Start using t1leapdesk"
            LoginReady = True
        ElseIf My.Settings.passwordEnabled = False Then
            Label3.Text = "Welcome! Press Enter or Login to Start using t1leapdesk"
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