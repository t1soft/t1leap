Imports System.ComponentModel
Imports VPKSoft.WinFormsRtfPrint

Public Class Form1

    Dim CurrentFont As String = "Calibri"
    Dim CurrentSize As String = "11"
    Dim documentname As String = ""
    Dim Edited As Boolean = False
    Dim StatusBullet As Integer = 0


#Region "File"
    Private Sub PictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureToolStripMenuItem.Click

        open_dialog1.Filter = "Image/Picture Files|*.jpg;*.gif;*.png;*.tiff;*.bmp"

        If open_dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image = Image.FromFile(open_dialog1.FileName)
            Clipboard.SetImage(img)
            documentBox.Paste()

        End If
    End Sub

    Private Sub newbutton1_Click(sender As Object, e As EventArgs) Handles newbutton1.Click
        If Edited = True Then
            Dim result As DialogResult = MessageBox.Show("Document has been Modified, Do you Want to Save?", "Question", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then
                documentBox.Clear()
                documentname1.Text = "New Document"
            ElseIf result = DialogResult.Yes Then
                savebutton1.PerformClick()
                documentBox.Clear()
                documentname1.Text = "New Document"
            End If
        End If

        If Edited = False Then
            documentBox.Clear()
            documentname1.Text = "New Document"
        End If


    End Sub

    Private Sub openbutton1_Click(sender As Object, e As EventArgs) Handles openbutton1.Click
        If Edited = True Then
            Dim result As DialogResult = MessageBox.Show("Document has been Modified, Do you Want to Save?", "Question", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then
                open_dialog1.Filter = "T1Leap DocWorks Documents|*.twdf"

                If open_dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    documentBox.LoadFile(open_dialog1.FileName)
                    documentname = open_dialog1.FileName
                    documentname1.Text = documentname
                End If
            ElseIf result = DialogResult.Yes Then
                savebutton1.PerformClick()
                open_dialog1.Filter = "T1Leap DocWorks Documents|*.twdf"

                If open_dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    documentBox.LoadFile(open_dialog1.FileName)
                    documentname = open_dialog1.FileName
                    documentname1.Text = documentname
                End If
            End If
        End If

        If Edited = False Then
            open_dialog1.Filter = "T1Leap DocWorks Documents|*.twdf"

            If open_dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                documentBox.LoadFile(open_dialog1.FileName)
                documentname = open_dialog1.FileName
                documentname1.Text = documentname
            End If
        End If
    End Sub

    Private Sub documentBox_TextChanged(sender As Object, e As EventArgs) Handles documentBox.TextChanged
        Edited = True
    End Sub

    Private Sub savebutton1_Click(sender As Object, e As EventArgs) Handles savebutton1.Click
        If documentname IsNot "" Then
            documentBox.SaveFile(documentname)
            documentname = save_dialog1.FileName
        Else
            save_dialog1.Filter = "T1Leap DocWorks Documents|*.twdf"

            If save_dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                documentBox.SaveFile(save_dialog1.FileName)
                documentname = save_dialog1.FileName
                documentname1.Text = documentname
            End If
        End If
    End Sub

    Private Sub saveasbutton1_Click(sender As Object, e As EventArgs) Handles saveasbutton1.Click
        save_dialog1.Filter = "T1Leap DocWorks Documents|*.twdf"

        If save_dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            documentBox.SaveFile(save_dialog1.FileName)
            documentname = save_dialog1.FileName
            documentname1.Text = documentname
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        newbutton1.PerformClick()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        openbutton1.PerformClick()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        savebutton1.PerformClick()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Edited = True Then
            Dim result As DialogResult = MessageBox.Show("Document has been Modified, Do you Want to Save?", "Question", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                savebutton1.PerformClick()
            End If
        End If

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        documentBox.PrintWithDialog
    End Sub

#End Region

#Region "Basic Edit"
    Private Sub undo2_Click(sender As Object, e As EventArgs) Handles undo2.Click
        documentBox.Undo()
    End Sub

    Private Sub redo2_Click(sender As Object, e As EventArgs) Handles redo2.Click
        documentBox.Redo()
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        documentBox.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        documentBox.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        documentBox.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        documentBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        documentBox.Redo()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        documentBox.SelectAll()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        documentBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        documentBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        documentBox.Paste()
    End Sub

#End Region

#Region "Font Settings"
    Private Sub fontselector_TextChanged(sender As Object, e As EventArgs) Handles fontselector.TextChanged
        CurrentFont = fontselector.Text
        Try
            documentBox.SelectionFont = New Font(CurrentFont, CurrentSize)
        Catch ex As Exception
            MsgBox("An Error has Occured While Applying Font", "Font Error", MessageBoxIcon.Error)
        End Try
        Try
            ToolStripLabel1.Font = New Font(CurrentFont, "11")
            ToolStripLabel2.Font = New Font(CurrentFont, "17")
            ToolStripLabel3.Font = New Font(CurrentFont, "15")
            ToolStripLabel4.Font = New Font(CurrentFont, "13")
            ToolStripLabel5.Font = New Font(CurrentFont, "9")
        Catch ex As Exception
            MsgBox("An Error has Occured While Applying Font Preview", "Font Preview Error", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sizeselector_TextChanged(sender As Object, e As EventArgs) Handles sizeselector.TextChanged
        CurrentSize = sizeselector.Text
        Try
            documentBox.SelectionFont = New Font(CurrentFont, CurrentSize)
        Catch ex As Exception
            MsgBox("An Error has Occured While Applying Font Size", "Font Error", MessageBoxIcon.Error)
        End Try
    End Sub

    Sub StyleChanger(style As FontStyle)


        Dim CurrentTextStyle As FontStyle = documentBox.SelectionFont.Style


        If style = FontStyle.Bold Then
            If documentBox.SelectionFont.Bold = False Then
                CurrentTextStyle += FontStyle.Bold
            Else
                CurrentTextStyle -= FontStyle.Bold
            End If
        ElseIf style = FontStyle.Italic Then

            If documentBox.SelectionFont.Italic = False Then
                CurrentTextStyle += FontStyle.Italic
            Else
                CurrentTextStyle -= FontStyle.Italic
            End If
        ElseIf style = FontStyle.Underline Then
            If documentBox.SelectionFont.Underline = False Then
                CurrentTextStyle += FontStyle.Underline
            Else
                CurrentTextStyle -= FontStyle.Underline
            End If
        ElseIf style = FontStyle.Strikeout Then
            If documentBox.SelectionFont.Strikeout = False Then
                CurrentTextStyle += FontStyle.Strikeout
            Else
                CurrentTextStyle -= FontStyle.Strikeout
            End If
        End If
        documentBox.SelectionFont = New Font(documentBox.SelectionFont, CurrentTextStyle)

    End Sub


    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        StyleChanger(FontStyle.Bold)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        StyleChanger(FontStyle.Italic)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        StyleChanger(FontStyle.Underline)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        StyleChanger(FontStyle.Strikeout)
    End Sub



    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        If StatusBullet = 0 Then
            documentBox.SelectionBullet = True
            StatusBullet = 1
        ElseIf StatusBullet = 1 Then
            documentBox.SelectionBullet = False
            StatusBullet = 0
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        documentBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        documentBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        documentBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        documentBox.SelectionFont = New Font(CurrentFont, "11")
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        documentBox.SelectionFont = New Font(CurrentFont, "17")
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        documentBox.SelectionFont = New Font(CurrentFont, "15")
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        documentBox.SelectionFont = New Font(CurrentFont, "13")
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        documentBox.SelectionFont = New Font(CurrentFont, "9")
    End Sub

#End Region

#Region "Highlighter"
    Private Sub YellowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.Yellow
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.Green
    End Sub

    Private Sub BlueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.LightBlue
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.Pink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        documentBox.SelectionBackColor = Color.Orange
    End Sub

    Private Sub DefaultnoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultnoneToolStripMenuItem.Click
        documentBox.SelectionBackColor = Color.Transparent
    End Sub




#End Region

#Region "Text Color"
    Private Sub DefaultBlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultBlackToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Black
    End Sub

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

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Pink
    End Sub

    Private Sub BrownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrownToolStripMenuItem.Click
        documentBox.SelectionColor = Color.Brown
    End Sub







#End Region
End Class
