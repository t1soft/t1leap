Public Class PresentWorks

#Region "Variables and Functions"

    'Store the filename of the document
    Dim filename As String = ""

    'Remember if the current document is changed
    Dim change As Boolean

    Dim StatusBullet As Integer
    Dim StatusMulti As Boolean = True
    Dim StatusAutoSave As Boolean
    Dim DocumentSaved As Boolean
    Dim DocumentReady As Boolean
    Dim DF15 As String = "Segoe UI"
    Dim DF23 As String = "Segoe UI Semibold"
    Dim DF4 As String = "Segoe UI Light"


    Function FontChanger(font)

        If font = "Segoe UI" Then
            DF15 = "Segoe UI"
            DF23 = "Segoe UI Semibold"
            DF4 = "Segoe UI Light"
        End If


        If font = "Times New Roman" Then
            DF15 = "Times New Roman"
            DF23 = "Times New Roman"
            DF4 = "Times New Roman"
        End If


        If font = "Arial" Then
            DF15 = "Arial"
            DF23 = "Arial"
            DF4 = "Arial"
        End If

    End Function

    Function StyleChanger()
        ToolStripLabel1.Font = New Font(DF15, 10)
        ToolStripLabel2.Font = New Font(DF23, 14)
        ToolStripLabel3.Font = New Font(DF23, 12)
        ToolStripLabel4.Font = New Font(DF4, 16)
        ToolStripLabel5.Font = New Font(DF15, 10, FontStyle.Italic)
    End Function


#End Region

#Region "Form/Control Settings"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set the document to not change
        change = False



    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        'Resize the text box
        documentBox.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - tsMain.Height - msMain.Height - 3)

    End Sub

    Private Sub documentBox_TextChanged(sender As Object, e As EventArgs) Handles documentBox.TextChanged

        'Set the document as change
        change = True


    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'You could put a Select Case statement here and take action for all
        'different types of closing conditions.      
        If e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Then
            'Closed by the x on the form or Alt-F4
            Checkchange()
        Else
            'Closed for some other reason       

        End If

    End Sub


#End Region

#Region "Edit"
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        documentBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        documentBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        documentBox.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        documentBox.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem1.Click
        documentBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        documentBox.Redo()
    End Sub

#End Region

#Region "Font Settings"
    Sub ToggleStyle(styleToToggle As FontStyle)

        'Backup the current font style
        Dim currentStyle As FontStyle = documentBox.SelectionFont.Style

        'Check what we want to toggle
        If styleToToggle = FontStyle.Bold Then

            'Check if bold is off
            If documentBox.SelectionFont.Bold = False Then
                'Add bold 
                currentStyle += FontStyle.Bold
            Else
                'Turn off bold
                currentStyle -= FontStyle.Bold
            End If

        ElseIf styleToToggle = FontStyle.Italic Then

            'Check if Italic is off
            If documentBox.SelectionFont.Italic = False Then
                'Add Italic 
                currentStyle += FontStyle.Italic
            Else
                'Turn off Italic
                currentStyle -= FontStyle.Italic
            End If

        ElseIf styleToToggle = FontStyle.Underline Then

            'Check if Underline is off
            If documentBox.SelectionFont.Underline = False Then
                'Add Underline 
                currentStyle += FontStyle.Underline
            Else
                'Turn off Underline
                currentStyle -= FontStyle.Underline
            End If

        ElseIf styleToToggle = FontStyle.Strikeout Then

            'Check if Strikeout is off
            If documentBox.SelectionFont.Strikeout = False Then
                'Add Strikeout 
                currentStyle += FontStyle.Strikeout
            Else
                'Turn off Strikeout
                currentStyle -= FontStyle.Strikeout
            End If

        End If

        'Replace the current font with the new style
        documentBox.SelectionFont = New Font(documentBox.SelectionFont, currentStyle)

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

    Private Sub fontSize_TextChanged(sender As Object, e As EventArgs) Handles fontSize.TextChanged

        'Capture what they selected
        Dim newSize As Single = Convert.ToSingle(fontSize.Text)

        'Change the font size
        documentBox.SelectionFont = New Font(documentBox.SelectionFont.FontFamily, newSize)

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
            documentBox.Paste()

        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        saveFile.Filter = "T1Leap DocWorks Documents|*.twdf"

        'Open the save file dialog
        If saveFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Save the file
            documentBox.SaveFile(saveFile.FileName)
            change = False


            'Remember the filename
            filename = saveFile.FileName

            'Set the form's title to the filename
            Me.Text = "T1Leap DocWorks - " & IO.Path.GetFileName(filename)

        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        'Check if the file has been saved
        If filename = "" Then

            'Call on the save button
            SaveAsToolStripMenuItem_Click(Nothing, Nothing)

        Else

            'Save the file
            documentBox.SaveFile(filename)
            change = False


        End If

    End Sub

    Sub Checkchange()

        'Check if the text box is change
        If change = True Then

            If MessageBox.Show("Do you want to save your changes?", "Confirm?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'Call on the save button
                SaveToolStripMenuItem_Click(Nothing, Nothing)

            End If

        End If

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        Checkchange()

        'Close the form
        Me.Close()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        Checkchange()

        'Setup the new text box
        filename = ""
        change = False
        Me.Text = "T1Leap DocWorks - New Document"
        documentBox.ResetText()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Checkchange()

        'Change the file filter
        openFile.Filter = "T1Leap DocWorks Documents|*.twdf"

        'Show open file dialog
        If openFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Open the file
            DocumentReady = False
            DocumentSaved = False
            documentBox.LoadFile(openFile.FileName)
            change = False
            filename = openFile.FileName
            Me.Text = "T1Leap DocWorks - " & IO.Path.GetFileName(filename)
            DocumentReady = True
            DocumentSaved = True

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
        documentBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        documentBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        documentBox.SelectionAlignment = HorizontalAlignment.Right

    End Sub

#End Region

#Region "Font Selector"

    Private Sub SegoeUIdefaultsystemFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegoeUIdefaultsystemFontToolStripMenuItem.Click
        FontChanger("Segoe UI")
        StyleChanger()
        documentBox.SelectionFont = New Font(DF15, 10)
    End Sub

    Private Sub TimesNewRomanessayCompatableFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimesNewRomanessayCompatableFontToolStripMenuItem.Click
        FontChanger("Times New Roman")
        StyleChanger()
        documentBox.SelectionFont = New Font(DF15, 10)
    End Sub

    Private Sub ArialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArialToolStripMenuItem.Click
        FontChanger("Arial")
        StyleChanger()
        documentBox.SelectionFont = New Font(DF15, 10)
    End Sub

#End Region

#Region "Styles"


    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        documentBox.SelectionFont = New Font(DF15, 10)
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        documentBox.SelectionFont = New Font(DF23, 14)
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        documentBox.SelectionFont = New Font(DF23, 12)
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        documentBox.SelectionFont = New Font(DF4, 16)
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        documentBox.SelectionFont = New Font(DF15, 10, FontStyle.Italic)
    End Sub



#End Region

#Region "Color Text"
    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Red
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Orange
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Yellow
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Green
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Blue
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Purple
    End Sub

    Private Sub BlackDefaultColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackDefaultColorToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Black
    End Sub

#End Region

#Region "Highlighter Tool"
    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        documentBox.SelectionBackColor = Color.Pink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.Orange
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.LimeGreen
    End Sub

    Private Sub YellowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.Yellow
    End Sub

    Private Sub NoHighlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoHighlightToolStripMenuItem.Click
        documentBox.SelectionBackColor = Color.White
    End Sub





#End Region

#Region "misc"
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If StatusBullet = 0 Then
            documentBox.SelectionBullet = True
            StatusBullet = 1
        ElseIf StatusBullet = 1 Then
            documentBox.SelectionBullet = False
            StatusBullet = 0
        End If

    End Sub
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs)

        Checkchange()

        'Close the form
        Me.Close()
    End Sub


#End Region

End Class
