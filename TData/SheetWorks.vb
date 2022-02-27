Public Class SheetWorks

    'Homeshell Officeworks




#Region "Variables"

    'Store the filename of the document
    Dim filename As String = ""

    'Remember if the current document is dirty
    Dim dirty As Boolean

#End Region

#Region "Form/Control Settings"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sbTaRtf As New System.Text.StringBuilder
        sbTaRtf.Append("{\rtf1")
        For index As Integer = 0 To 1000
            sbTaRtf.Append("\trowd")
            sbTaRtf.Append("\cellx1000") 'set that cell width to 1000
            sbTaRtf.Append("\cellx2000")
            sbTaRtf.Append("\cellx3000")
            sbTaRtf.Append("\cellx4000")
            sbTaRtf.Append("\cellx5000")
            sbTaRtf.Append("\cellx6000")
            sbTaRtf.Append("\cellx7000")
            sbTaRtf.Append("\cellx8000")
            sbTaRtf.Append("\cellx9000")
            sbTaRtf.Append("\cellx10000")
            sbTaRtf.Append("\cellx11000")
            sbTaRtf.Append("\cellx12000")
            sbTaRtf.Append("\cellx13000")
            sbTaRtf.Append("\cellx14000")
            sbTaRtf.Append("\cellx15000")
            sbTaRtf.Append("\cellx16000")
            sbTaRtf.Append("\cellx17000")
            sbTaRtf.Append("\cellx18000")
            sbTaRtf.Append("\cellx19000")
            sbTaRtf.Append("\cellx20000")
            sbTaRtf.Append("\cellx21000")
            sbTaRtf.Append("\cellx22000")
            sbTaRtf.Append("\cellx23000")
            sbTaRtf.Append("\cellx24000")
            sbTaRtf.Append("\cellx25000")
            sbTaRtf.Append("\cellx26000")
            sbTaRtf.Append("\cellx27000")
            sbTaRtf.Append("\cellx28000")
            sbTaRtf.Append("\cellx29000")
            sbTaRtf.Append("\cellx30000")
            sbTaRtf.Append("\cellx31000")
            sbTaRtf.Append("\cellx32000")
            sbTaRtf.Append("\cellx33000")
            sbTaRtf.Append("\cellx34000")
            sbTaRtf.Append("\cellx35000")
            sbTaRtf.Append("\cellx36000")
            sbTaRtf.Append("\cellx37000")
            sbTaRtf.Append("\cellx38000")
            sbTaRtf.Append("\cellx39000")
            sbTaRtf.Append("\cellx40000")
            sbTaRtf.Append("\intbl \cell \row")
        Next
        sbTaRtf.Append("\pard")
        sbTaRtf.Append("}")
        rtbContent.Rtf = sbTaRtf.ToString()

        'Set the document to not dirty
        dirty = False

    End Sub


    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        'Resize the text box
        rtbContent.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - tsMain.Height - msMain.Height - 3)

    End Sub

    Private Sub rtbContent_TextChanged(sender As Object, e As EventArgs) Handles rtbContent.TextChanged

        'Set the document as dirty
        dirty = True

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'You could put a Select Case statement here and take action for all
        'different types of closing conditions.      
        If e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Then
            'Closed by the x on the form or Alt-F4
            CheckDirty()
        Else
            'Closed for some other reason       

        End If

    End Sub


#End Region

#Region "Edit"
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click

        rtbContent.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        rtbContent.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        rtbContent.Paste()

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click

        rtbContent.SelectAll()

    End Sub

#End Region

#Region "Font Settings"
    Sub ToggleStyle(styleToToggle As FontStyle)

        'Backup the current font style
        Dim currentStyle As FontStyle = rtbContent.SelectionFont.Style

        'Check what we want to toggle
        If styleToToggle = FontStyle.Bold Then

            'Check if bold is off
            If rtbContent.SelectionFont.Bold = False Then
                'Add bold 
                currentStyle += FontStyle.Bold
            Else
                'Turn off bold
                currentStyle -= FontStyle.Bold
            End If

        ElseIf styleToToggle = FontStyle.Italic Then

            'Check if Italic is off
            If rtbContent.SelectionFont.Italic = False Then
                'Add Italic 
                currentStyle += FontStyle.Italic
            Else
                'Turn off Italic
                currentStyle -= FontStyle.Italic
            End If

        ElseIf styleToToggle = FontStyle.Underline Then

            'Check if Underline is off
            If rtbContent.SelectionFont.Underline = False Then
                'Add Underline 
                currentStyle += FontStyle.Underline
            Else
                'Turn off Underline
                currentStyle -= FontStyle.Underline
            End If

        ElseIf styleToToggle = FontStyle.Strikeout Then

            'Check if Strikeout is off
            If rtbContent.SelectionFont.Strikeout = False Then
                'Add Strikeout 
                currentStyle += FontStyle.Strikeout
            Else
                'Turn off Strikeout
                currentStyle -= FontStyle.Strikeout
            End If

        End If

        'Replace the current font with the new style
        rtbContent.SelectionFont = New Font(rtbContent.SelectionFont, currentStyle)

    End Sub

    Private Sub tsbBold_Click(sender As Object, e As EventArgs) Handles tsbBold.Click

        ToggleStyle(FontStyle.Bold)

    End Sub

    Private Sub tsbItalic_Click(sender As Object, e As EventArgs) Handles tsbItalic.Click

        ToggleStyle(FontStyle.Italic)

    End Sub

    Private Sub tsbUnderline_Click(sender As Object, e As EventArgs) Handles tsbUnderline.Click

        ToggleStyle(FontStyle.Underline)

    End Sub

    Private Sub tsbStrikeout_Click(sender As Object, e As EventArgs) Handles tsbStrikeout.Click

        ToggleStyle(FontStyle.Strikeout)

    End Sub

    Private Sub tscSize_TextChanged(sender As Object, e As EventArgs) Handles tscSize.TextChanged

        'Capture what they selected
        Dim newSize As Single = Convert.ToSingle(tscSize.Text)

        'Change the font size
        rtbContent.SelectionFont = New Font(rtbContent.SelectionFont.FontFamily, newSize)

    End Sub

#End Region

#Region "File"
    Private Sub PictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureToolStripMenuItem.Click

        'Set the file filter
        openFile.Filter = "Image Files|*.jpg;*.gif;*.png;*.tiff;*.bmp"

        'Check if the user presses OK button
        If openFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Load the picture
            Dim img As Image = Image.FromFile(openFile.FileName)

            'Copy into the clipboard and paste into textbox
            Clipboard.SetImage(img)
            rtbContent.Paste()

        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        'Change the file filter
        saveFile.Filter = "T1Leap DataWorks Datasheet File|*.tdsf"

        'Open the save file dialog
        If saveFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Save the file
            rtbContent.SaveFile(saveFile.FileName)
            dirty = False

            'Remember the filename
            filename = saveFile.FileName

            'Set the form's title to the filename
            Me.Text = "T1Leap DataWorks - " & IO.Path.GetFileName(filename)

        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        'Check if the file has been saved
        If filename = "" Then

            'Call on the save button
            SaveAsToolStripMenuItem_Click(Nothing, Nothing)

        Else

            'Save the file
            rtbContent.SaveFile(filename)
            dirty = False

        End If

    End Sub

    Sub CheckDirty()

        'Check if the text box is dirty
        If dirty = True Then

            If MessageBox.Show("Do you want to save your changes?", "Confirm?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'Call on the save button
                SaveToolStripMenuItem_Click(Nothing, Nothing)

            End If

        End If

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        CheckDirty()

        'Close the form
        Me.Close()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        CheckDirty()

        'Setup the new text box
        filename = ""
        dirty = False
        Me.Text = "T1Leap DataWorks - New Document"
        rtbContent.ResetText()


        Dim sbTaRtf As New System.Text.StringBuilder
        sbTaRtf.Append("{\rtf1")
        For index As Integer = 0 To 1000
            sbTaRtf.Append("\trowd")
            sbTaRtf.Append("\cellx1000") 'set that cell width to 1000
            sbTaRtf.Append("\cellx2000")
            sbTaRtf.Append("\cellx3000")
            sbTaRtf.Append("\cellx4000")
            sbTaRtf.Append("\cellx5000")
            sbTaRtf.Append("\cellx6000")
            sbTaRtf.Append("\cellx7000")
            sbTaRtf.Append("\cellx8000")
            sbTaRtf.Append("\cellx9000")
            sbTaRtf.Append("\cellx10000")
            sbTaRtf.Append("\cellx11000")
            sbTaRtf.Append("\cellx12000")
            sbTaRtf.Append("\cellx13000")
            sbTaRtf.Append("\cellx14000")
            sbTaRtf.Append("\cellx15000")
            sbTaRtf.Append("\cellx16000")
            sbTaRtf.Append("\cellx17000")
            sbTaRtf.Append("\cellx18000")
            sbTaRtf.Append("\cellx19000")
            sbTaRtf.Append("\cellx20000")
            sbTaRtf.Append("\cellx21000")
            sbTaRtf.Append("\cellx22000")
            sbTaRtf.Append("\cellx23000")
            sbTaRtf.Append("\cellx24000")
            sbTaRtf.Append("\cellx25000")
            sbTaRtf.Append("\cellx26000")
            sbTaRtf.Append("\cellx27000")
            sbTaRtf.Append("\cellx28000")
            sbTaRtf.Append("\cellx29000")
            sbTaRtf.Append("\cellx30000")
            sbTaRtf.Append("\cellx31000")
            sbTaRtf.Append("\cellx32000")
            sbTaRtf.Append("\cellx33000")
            sbTaRtf.Append("\cellx34000")
            sbTaRtf.Append("\cellx35000")
            sbTaRtf.Append("\cellx36000")
            sbTaRtf.Append("\cellx37000")
            sbTaRtf.Append("\cellx38000")
            sbTaRtf.Append("\cellx39000")
            sbTaRtf.Append("\cellx40000")
            sbTaRtf.Append("\intbl \cell \row")
        Next
        sbTaRtf.Append("\pard")
        sbTaRtf.Append("}")
        rtbContent.Rtf = sbTaRtf.ToString()

        'Set the document to not dirty
        dirty = False

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        CheckDirty()

        'Change the file filter
        openFile.Filter = "T1Leap DataWorks Datasheet File|*.tdsf"

        'Show open file dialog
        If openFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Open the file
            rtbContent.LoadFile(openFile.FileName)
            dirty = False
            filename = openFile.FileName
            Me.Text = "T1Leap DataWorks - " & IO.Path.GetFileName(filename)

        End If

    End Sub

    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click

        NewToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click

        OpenToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click

        SaveToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

#End Region

#Region "Paragraph Alignment"
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        rtbContent.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rtbContent.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        rtbContent.SelectionAlignment = HorizontalAlignment.Right

    End Sub

#End Region

#Region "Styles"


    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        rtbContent.SelectionFont = New Font("Segoe UI", 10)
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        rtbContent.SelectionFont = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        rtbContent.SelectionFont = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        rtbContent.SelectionFont = New Font("Segoe UI Light", 16)
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        rtbContent.SelectionFont = New Font("Segoe UI", 10, FontStyle.Italic)
    End Sub



#End Region

#Region "Help/About"
    Private Sub AboutOfficeworksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutOfficeworksToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs)

        CheckDirty()

        'Close the form
        Me.Close()
    End Sub



#End Region

End Class
