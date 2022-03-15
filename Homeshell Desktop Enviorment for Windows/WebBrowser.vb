Imports Microsoft.Web.WebView2.Core

Public Class WebBrowser

#Region "WebBoxToolStripMenu"
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub GiveFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveFeedbackToolStripMenuItem.Click

    End Sub


#End Region
    'This is for the WebBox Menu on the Tool Strip (for the Back, Forward, Refresh, and Navigation Controls, go to WebBox Browser controls instead.)


#Region "Tab1"


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        WebView21.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        WebView21.GoForward()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        WebView21.Reload()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        If WebView21?.CoreWebView2 Is Nothing Then
            MessageBox.Show("Error WebBox_NotReady. Don't Worry, Just Wait a Few Seconds before trying again.")
        Else
            Try
                'Navigate to the New URL From the Tool Strip Text Box (Only Applies to URL's That have "http(s)://" At the Beginning)
                WebView21.Source = New Uri(ToolStripTextBox1.Text)


            Catch ex As UriFormatException
                Try
                    'Add "http://" To the Beginning before Navigating to the New URL
                    Dim WebViewURL As String = ToolStripTextBox1.Text
                    Dim CorrectedURL As String = "http://" & WebViewURL
                    ToolStripTextBox1.Text = CorrectedURL
                    WebView21.Source = New Uri(ToolStripTextBox1.Text)
                Catch fy As Exception
                    MessageBox.Show("Error WebBox_Unable_ChangeUrl. Don't Worry, Just Add ''https://'' at the beginning before Pressing Go!")
                End Try
            Catch ex As Exception
                MessageBox.Show($"Error WebBox_Unable_Navigate_RandomEx. Another exception happened. Don't Worry, Just Wait a Few Seconds before trying again.: {ex}")
            End Try
        End If
    End Sub



#End Region
    'This is for the WebBox Browser Controls (Go Back, Go Forward, Refresh, and Navigate) For Tab 1

#Region "Tab2"

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        WebView2.GoBack()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        WebView2.GoForward()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        WebView2.Reload()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click

        If WebView2?.CoreWebView2 Is Nothing Then
            MessageBox.Show("Error WebBox_NotReady. Don't Worry, Just Wait a Few Seconds before trying again.")
        Else
            Try
                'Navigate to the New URL From the Tool Strip Text Box (Only Applies to URL's That have "http(s)://" At the Beginning)
                WebView2.Source = New Uri(ToolStripTextBox2.Text)


            Catch ex As UriFormatException
                Try
                    'Add "http://" To the Beginning before Navigating to the New URL
                    Dim WebViewURL2 As String = ToolStripTextBox2.Text
                    Dim CorrectedURL2 As String = "http://" & WebViewURL2
                    ToolStripTextBox2.Text = CorrectedURL2
                    WebView2.Source = New Uri(ToolStripTextBox2.Text)
                Catch fy As Exception
                    MessageBox.Show("Error WebBox_Unable_ChangeUrl. Don't Worry, Just Add ''https://'' at the beginning before Pressing Go!")
                End Try
            Catch ex As Exception
                MessageBox.Show($"Error WebBox_Unable_Navigate_RandomEx. Another exception happened. Don't Worry, Just Wait a Few Seconds before trying again.: {ex}")
            End Try
        End If
    End Sub


#End Region
    'This is for the WebBox Browser Controls (Go Back, Go Forward, Refresh, and Navigate) For Tab 2

#Region "Tab3"

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        WebView3.GoBack()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        WebView3.GoForward()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        WebView3.Reload()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click

        If WebView3?.CoreWebView2 Is Nothing Then
            MessageBox.Show("Error WebBox_NotReady. Don't Worry, Just Wait a Few Seconds before trying again.")
        Else
            Try
                'Navigate to the New URL From the Tool Strip Text Box (Only Applies to URL's That have "http(s)://" At the Beginning)
                WebView3.Source = New Uri(ToolStripTextBox3.Text)


            Catch ex As UriFormatException
                Try
                    'Add "http://" To the Beginning before Navigating to the New URL
                    Dim WebViewURL3 As String = ToolStripTextBox3.Text
                    Dim CorrectedURL3 As String = "http://" & WebViewURL3
                    ToolStripTextBox3.Text = CorrectedURL3
                    WebView3.Source = New Uri(ToolStripTextBox3.Text)
                Catch fy As Exception
                    MessageBox.Show("Error WebBox_Unable_ChangeUrl. Don't Worry, Just Add ''https://'' at the beginning before Pressing Go!")
                End Try
            Catch ex As Exception
                MessageBox.Show($"Error WebBox_Unable_Navigate_RandomEx. Another exception happened. Don't Worry, Just Wait a Few Seconds before trying again.: {ex}")
            End Try
        End If
    End Sub

#End Region
    'This is for the WebBox Browser Controls (Go Back, Go Forward, Refresh, and Navigate) For Tab 3
End Class