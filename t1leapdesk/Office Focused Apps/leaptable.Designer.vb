<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class leaptable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(leaptable))
        Panel1 = New Panel()
        documentname1 = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewTableToolStripMenuItem = New ToolStripMenuItem()
        ColunmToolStripMenuItem = New ToolStripMenuItem()
        ColunmToolStripMenuItem1 = New ToolStripMenuItem()
        ColunmToolStripMenuItem2 = New ToolStripMenuItem()
        ColunmToolStripMenuItem3 = New ToolStripMenuItem()
        ColunmToolStripMenuItem4 = New ToolStripMenuItem()
        openbutton1 = New ToolStripMenuItem()
        savebutton1 = New ToolStripMenuItem()
        saveasbutton1 = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        InsertToolStripMenuItem = New ToolStripMenuItem()
        PictureToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        BuildNumberToolStripMenuItem = New ToolStripMenuItem()
        SoftwareLicenceToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripButton()
        PrintToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        undo2 = New ToolStripButton()
        redo2 = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        CutToolStripButton = New ToolStripButton()
        CopyToolStripButton = New ToolStripButton()
        PasteToolStripButton = New ToolStripButton()
        ToolStripSeparator9 = New ToolStripSeparator()
        fontselector = New ToolStripComboBox()
        sizeselector = New ToolStripComboBox()
        ToolStripSeparator4 = New ToolStripSeparator()
        ToolStripButton4 = New ToolStripButton()
        ToolStripSeparator6 = New ToolStripSeparator()
        ToolStripButton5 = New ToolStripButton()
        ToolStripSeparator5 = New ToolStripSeparator()
        ToolStripButton6 = New ToolStripButton()
        ToolStripSeparator7 = New ToolStripSeparator()
        ToolStripButton7 = New ToolStripButton()
        ToolStripSeparator8 = New ToolStripSeparator()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        ToolStripSeparator11 = New ToolStripSeparator()
        ToolStripButton8 = New ToolStripButton()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        DefaultnoneToolStripMenuItem = New ToolStripMenuItem()
        YellowToolStripMenuItem1 = New ToolStripMenuItem()
        GreenToolStripMenuItem1 = New ToolStripMenuItem()
        BlueToolStripMenuItem1 = New ToolStripMenuItem()
        PinkToolStripMenuItem1 = New ToolStripMenuItem()
        OrangeToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSplitButton2 = New ToolStripSplitButton()
        DefaultBlackToolStripMenuItem = New ToolStripMenuItem()
        RedToolStripMenuItem = New ToolStripMenuItem()
        OrangeToolStripMenuItem = New ToolStripMenuItem()
        YellowToolStripMenuItem = New ToolStripMenuItem()
        GreenToolStripMenuItem = New ToolStripMenuItem()
        BlueToolStripMenuItem = New ToolStripMenuItem()
        PurpleToolStripMenuItem = New ToolStripMenuItem()
        PinkToolStripMenuItem = New ToolStripMenuItem()
        BrownToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator10 = New ToolStripSeparator()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripSeparator12 = New ToolStripSeparator()
        ToolStripLabel2 = New ToolStripLabel()
        ToolStripSeparator13 = New ToolStripSeparator()
        ToolStripLabel3 = New ToolStripLabel()
        ToolStripSeparator3 = New ToolStripSeparator()
        ToolStripLabel4 = New ToolStripLabel()
        ToolStripSeparator14 = New ToolStripSeparator()
        ToolStripLabel5 = New ToolStripLabel()
        ToolStripSeparator15 = New ToolStripSeparator()
        open_dialog1 = New OpenFileDialog()
        save_dialog1 = New SaveFileDialog()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        documentBox = New RichTextBox()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OliveDrab
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(documentname1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1513, 87)
        Panel1.TabIndex = 0
        ' 
        ' documentname1
        ' 
        documentname1.AutoSize = True
        documentname1.BackColor = Color.Transparent
        documentname1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        documentname1.ForeColor = Color.White
        documentname1.Location = New Point(0, 44)
        documentname1.Name = "documentname1"
        documentname1.Size = New Size(392, 41)
        documentname1.TabIndex = 0
        documentname1.Text = "Create or Open a Document"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightSkyBlue
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, InsertToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 87)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(1513, 30)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewTableToolStripMenuItem, openbutton1, savebutton1, saveasbutton1, PrintToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewTableToolStripMenuItem
        ' 
        NewTableToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ColunmToolStripMenuItem, ColunmToolStripMenuItem1, ColunmToolStripMenuItem2, ColunmToolStripMenuItem3, ColunmToolStripMenuItem4})
        NewTableToolStripMenuItem.Name = "NewTableToolStripMenuItem"
        NewTableToolStripMenuItem.Size = New Size(161, 26)
        NewTableToolStripMenuItem.Text = "New Table"
        ' 
        ' ColunmToolStripMenuItem
        ' 
        ColunmToolStripMenuItem.Name = "ColunmToolStripMenuItem"
        ColunmToolStripMenuItem.Size = New Size(163, 26)
        ColunmToolStripMenuItem.Text = "4 Colunm"
        ' 
        ' ColunmToolStripMenuItem1
        ' 
        ColunmToolStripMenuItem1.Name = "ColunmToolStripMenuItem1"
        ColunmToolStripMenuItem1.Size = New Size(163, 26)
        ColunmToolStripMenuItem1.Text = "5 Colunm"
        ' 
        ' ColunmToolStripMenuItem2
        ' 
        ColunmToolStripMenuItem2.Name = "ColunmToolStripMenuItem2"
        ColunmToolStripMenuItem2.Size = New Size(163, 26)
        ColunmToolStripMenuItem2.Text = "10 Colunm"
        ' 
        ' ColunmToolStripMenuItem3
        ' 
        ColunmToolStripMenuItem3.Name = "ColunmToolStripMenuItem3"
        ColunmToolStripMenuItem3.Size = New Size(163, 26)
        ColunmToolStripMenuItem3.Text = "20 Colunm"
        ' 
        ' ColunmToolStripMenuItem4
        ' 
        ColunmToolStripMenuItem4.Name = "ColunmToolStripMenuItem4"
        ColunmToolStripMenuItem4.Size = New Size(163, 26)
        ColunmToolStripMenuItem4.Text = "30 Colunm"
        ' 
        ' openbutton1
        ' 
        openbutton1.Name = "openbutton1"
        openbutton1.Size = New Size(161, 26)
        openbutton1.Text = "Open"
        ' 
        ' savebutton1
        ' 
        savebutton1.Name = "savebutton1"
        savebutton1.Size = New Size(161, 26)
        savebutton1.Text = "Save"
        ' 
        ' saveasbutton1
        ' 
        saveasbutton1.Name = "saveasbutton1"
        saveasbutton1.Size = New Size(161, 26)
        saveasbutton1.Text = "Save As"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(161, 26)
        PrintToolStripMenuItem.Text = "Print"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, SelectAllToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.Size = New Size(154, 26)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.Size = New Size(154, 26)
        RedoToolStripMenuItem.Text = "Redo"
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(154, 26)
        SelectAllToolStripMenuItem.Text = "Select All"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(154, 26)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(154, 26)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(154, 26)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' InsertToolStripMenuItem
        ' 
        InsertToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PictureToolStripMenuItem})
        InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        InsertToolStripMenuItem.Size = New Size(59, 24)
        InsertToolStripMenuItem.Text = "Insert"
        ' 
        ' PictureToolStripMenuItem
        ' 
        PictureToolStripMenuItem.Name = "PictureToolStripMenuItem"
        PictureToolStripMenuItem.Size = New Size(137, 26)
        PictureToolStripMenuItem.Text = "Picture"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem, SoftwareLicenceToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BuildNumberToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(224, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' BuildNumberToolStripMenuItem
        ' 
        BuildNumberToolStripMenuItem.Name = "BuildNumberToolStripMenuItem"
        BuildNumberToolStripMenuItem.Size = New Size(204, 26)
        BuildNumberToolStripMenuItem.Text = "Build 10242022A"
        ' 
        ' SoftwareLicenceToolStripMenuItem
        ' 
        SoftwareLicenceToolStripMenuItem.Name = "SoftwareLicenceToolStripMenuItem"
        SoftwareLicenceToolStripMenuItem.Size = New Size(224, 26)
        SoftwareLicenceToolStripMenuItem.Text = "Licences"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {OpenToolStripButton, SaveToolStripButton, PrintToolStripButton, ToolStripSeparator1, undo2, redo2, ToolStripSeparator2, CutToolStripButton, CopyToolStripButton, PasteToolStripButton, ToolStripSeparator9, fontselector, sizeselector, ToolStripSeparator4, ToolStripButton4, ToolStripSeparator6, ToolStripButton5, ToolStripSeparator5, ToolStripButton6, ToolStripSeparator7, ToolStripButton7, ToolStripSeparator8, ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator11, ToolStripButton8, ToolStripSplitButton1, ToolStripSplitButton2, ToolStripSeparator10, ToolStripLabel1, ToolStripSeparator12, ToolStripLabel2, ToolStripSeparator13, ToolStripLabel3, ToolStripSeparator3, ToolStripLabel4, ToolStripSeparator14, ToolStripLabel5, ToolStripSeparator15})
        ToolStrip1.Location = New Point(0, 117)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1513, 43)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        OpenToolStripButton.ImageTransparentColor = Color.Magenta
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(29, 40)
        OpenToolStripButton.Text = "&Open"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        SaveToolStripButton.ImageTransparentColor = Color.Magenta
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(29, 40)
        SaveToolStripButton.Text = "&Save"
        ' 
        ' PrintToolStripButton
        ' 
        PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), Image)
        PrintToolStripButton.ImageTransparentColor = Color.Magenta
        PrintToolStripButton.Name = "PrintToolStripButton"
        PrintToolStripButton.Size = New Size(29, 40)
        PrintToolStripButton.Text = "&Print"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 43)
        ' 
        ' undo2
        ' 
        undo2.DisplayStyle = ToolStripItemDisplayStyle.Image
        undo2.Image = CType(resources.GetObject("undo2.Image"), Image)
        undo2.ImageTransparentColor = Color.Magenta
        undo2.Name = "undo2"
        undo2.Size = New Size(29, 40)
        undo2.Text = "Undo"
        ' 
        ' redo2
        ' 
        redo2.DisplayStyle = ToolStripItemDisplayStyle.Image
        redo2.Image = CType(resources.GetObject("redo2.Image"), Image)
        redo2.ImageTransparentColor = Color.Magenta
        redo2.Name = "redo2"
        redo2.Size = New Size(29, 40)
        redo2.Text = "Redo"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 43)
        ' 
        ' CutToolStripButton
        ' 
        CutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), Image)
        CutToolStripButton.ImageTransparentColor = Color.Magenta
        CutToolStripButton.Name = "CutToolStripButton"
        CutToolStripButton.Size = New Size(29, 40)
        CutToolStripButton.Text = "C&ut"
        ' 
        ' CopyToolStripButton
        ' 
        CopyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), Image)
        CopyToolStripButton.ImageTransparentColor = Color.Magenta
        CopyToolStripButton.Name = "CopyToolStripButton"
        CopyToolStripButton.Size = New Size(29, 40)
        CopyToolStripButton.Text = "&Copy"
        ' 
        ' PasteToolStripButton
        ' 
        PasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), Image)
        PasteToolStripButton.ImageTransparentColor = Color.Magenta
        PasteToolStripButton.Name = "PasteToolStripButton"
        PasteToolStripButton.Size = New Size(29, 40)
        PasteToolStripButton.Text = "&Paste"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(6, 43)
        ' 
        ' fontselector
        ' 
        fontselector.Items.AddRange(New Object() {"Arial", "Calibri", "Segoe UI", "Times New Roman"})
        fontselector.Name = "fontselector"
        fontselector.Size = New Size(138, 43)
        fontselector.Text = "Calibri"
        ' 
        ' sizeselector
        ' 
        sizeselector.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "26", "36", "48", "72"})
        sizeselector.Name = "sizeselector"
        sizeselector.Size = New Size(85, 43)
        sizeselector.Text = "11"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 43)
        ' 
        ' ToolStripButton4
        ' 
        ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripButton4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        ToolStripButton4.ImageTransparentColor = Color.Magenta
        ToolStripButton4.Name = "ToolStripButton4"
        ToolStripButton4.Size = New Size(31, 40)
        ToolStripButton4.Text = " B "
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(6, 43)
        ' 
        ' ToolStripButton5
        ' 
        ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripButton5.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        ToolStripButton5.ImageTransparentColor = Color.Magenta
        ToolStripButton5.Name = "ToolStripButton5"
        ToolStripButton5.Size = New Size(29, 40)
        ToolStripButton5.Text = " I "
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(6, 43)
        ' 
        ' ToolStripButton6
        ' 
        ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripButton6.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point)
        ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), Image)
        ToolStripButton6.ImageTransparentColor = Color.Magenta
        ToolStripButton6.Name = "ToolStripButton6"
        ToolStripButton6.Size = New Size(31, 40)
        ToolStripButton6.Text = " U "
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(6, 43)
        ' 
        ' ToolStripButton7
        ' 
        ToolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripButton7.Font = New Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point)
        ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), Image)
        ToolStripButton7.ImageTransparentColor = Color.Magenta
        ToolStripButton7.Name = "ToolStripButton7"
        ToolStripButton7.Size = New Size(29, 40)
        ToolStripButton7.Text = " S "
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(6, 43)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(29, 40)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(29, 40)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(29, 40)
        ToolStripButton3.Text = "ToolStripButton3"
        ' 
        ' ToolStripSeparator11
        ' 
        ToolStripSeparator11.Name = "ToolStripSeparator11"
        ToolStripSeparator11.Size = New Size(6, 43)
        ' 
        ' ToolStripButton8
        ' 
        ToolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), Image)
        ToolStripButton8.ImageTransparentColor = Color.Magenta
        ToolStripButton8.Name = "ToolStripButton8"
        ToolStripButton8.Size = New Size(29, 40)
        ToolStripButton8.Text = "Bullet Points"
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.BackColor = SystemColors.ActiveCaption
        ToolStripSplitButton1.BackgroundImageLayout = ImageLayout.None
        ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripSplitButton1.DropDownItems.AddRange(New ToolStripItem() {DefaultnoneToolStripMenuItem, YellowToolStripMenuItem1, GreenToolStripMenuItem1, BlueToolStripMenuItem1, PinkToolStripMenuItem1, OrangeToolStripMenuItem1})
        ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(103, 40)
        ToolStripSplitButton1.Text = "Highlighter"
        ' 
        ' DefaultnoneToolStripMenuItem
        ' 
        DefaultnoneToolStripMenuItem.Name = "DefaultnoneToolStripMenuItem"
        DefaultnoneToolStripMenuItem.Size = New Size(188, 26)
        DefaultnoneToolStripMenuItem.Text = "Default (none)"
        ' 
        ' YellowToolStripMenuItem1
        ' 
        YellowToolStripMenuItem1.Name = "YellowToolStripMenuItem1"
        YellowToolStripMenuItem1.Size = New Size(188, 26)
        YellowToolStripMenuItem1.Text = "Yellow"
        ' 
        ' GreenToolStripMenuItem1
        ' 
        GreenToolStripMenuItem1.Name = "GreenToolStripMenuItem1"
        GreenToolStripMenuItem1.Size = New Size(188, 26)
        GreenToolStripMenuItem1.Text = "Green"
        ' 
        ' BlueToolStripMenuItem1
        ' 
        BlueToolStripMenuItem1.Name = "BlueToolStripMenuItem1"
        BlueToolStripMenuItem1.Size = New Size(188, 26)
        BlueToolStripMenuItem1.Text = "Light Blue"
        ' 
        ' PinkToolStripMenuItem1
        ' 
        PinkToolStripMenuItem1.Name = "PinkToolStripMenuItem1"
        PinkToolStripMenuItem1.Size = New Size(188, 26)
        PinkToolStripMenuItem1.Text = "Pink"
        ' 
        ' OrangeToolStripMenuItem1
        ' 
        OrangeToolStripMenuItem1.Name = "OrangeToolStripMenuItem1"
        OrangeToolStripMenuItem1.Size = New Size(188, 26)
        OrangeToolStripMenuItem1.Text = "Orange"
        ' 
        ' ToolStripSplitButton2
        ' 
        ToolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripSplitButton2.DropDownItems.AddRange(New ToolStripItem() {DefaultBlackToolStripMenuItem, RedToolStripMenuItem, OrangeToolStripMenuItem, YellowToolStripMenuItem, GreenToolStripMenuItem, BlueToolStripMenuItem, PurpleToolStripMenuItem, PinkToolStripMenuItem, BrownToolStripMenuItem})
        ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), Image)
        ToolStripSplitButton2.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        ToolStripSplitButton2.Size = New Size(95, 40)
        ToolStripSplitButton2.Text = "Text Color"
        ' 
        ' DefaultBlackToolStripMenuItem
        ' 
        DefaultBlackToolStripMenuItem.Name = "DefaultBlackToolStripMenuItem"
        DefaultBlackToolStripMenuItem.Size = New Size(190, 26)
        DefaultBlackToolStripMenuItem.Text = "Default (Black)"
        ' 
        ' RedToolStripMenuItem
        ' 
        RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        RedToolStripMenuItem.Size = New Size(190, 26)
        RedToolStripMenuItem.Text = "Red"
        ' 
        ' OrangeToolStripMenuItem
        ' 
        OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        OrangeToolStripMenuItem.Size = New Size(190, 26)
        OrangeToolStripMenuItem.Text = "Orange"
        ' 
        ' YellowToolStripMenuItem
        ' 
        YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        YellowToolStripMenuItem.Size = New Size(190, 26)
        YellowToolStripMenuItem.Text = "Yellow"
        ' 
        ' GreenToolStripMenuItem
        ' 
        GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        GreenToolStripMenuItem.Size = New Size(190, 26)
        GreenToolStripMenuItem.Text = "Green"
        ' 
        ' BlueToolStripMenuItem
        ' 
        BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        BlueToolStripMenuItem.Size = New Size(190, 26)
        BlueToolStripMenuItem.Text = "Blue"
        ' 
        ' PurpleToolStripMenuItem
        ' 
        PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        PurpleToolStripMenuItem.Size = New Size(190, 26)
        PurpleToolStripMenuItem.Text = "Purple"
        ' 
        ' PinkToolStripMenuItem
        ' 
        PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        PinkToolStripMenuItem.Size = New Size(190, 26)
        PinkToolStripMenuItem.Text = "Pink"
        ' 
        ' BrownToolStripMenuItem
        ' 
        BrownToolStripMenuItem.Name = "BrownToolStripMenuItem"
        BrownToolStripMenuItem.Size = New Size(190, 26)
        BrownToolStripMenuItem.Text = "Brown"
        ' 
        ' ToolStripSeparator10
        ' 
        ToolStripSeparator10.Name = "ToolStripSeparator10"
        ToolStripSeparator10.Size = New Size(6, 43)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(75, 40)
        ToolStripLabel1.Text = "Normal"
        ' 
        ' ToolStripSeparator12
        ' 
        ToolStripSeparator12.Name = "ToolStripSeparator12"
        ToolStripSeparator12.Size = New Size(6, 43)
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(71, 40)
        ToolStripLabel2.Text = "Title"
        ' 
        ' ToolStripSeparator13
        ' 
        ToolStripSeparator13.Name = "ToolStripSeparator13"
        ToolStripSeparator13.Size = New Size(6, 43)
        ' 
        ' ToolStripLabel3
        ' 
        ToolStripLabel3.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripLabel3.Name = "ToolStripLabel3"
        ToolStripLabel3.Size = New Size(109, 40)
        ToolStripLabel3.Text = "Heading"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 43)
        ' 
        ' ToolStripLabel4
        ' 
        ToolStripLabel4.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripLabel4.Name = "ToolStripLabel4"
        ToolStripLabel4.Size = New Size(141, 40)
        ToolStripLabel4.Text = "Sub-Heading"
        ' 
        ' ToolStripSeparator14
        ' 
        ToolStripSeparator14.Name = "ToolStripSeparator14"
        ToolStripSeparator14.Size = New Size(6, 43)
        ' 
        ' ToolStripLabel5
        ' 
        ToolStripLabel5.Name = "ToolStripLabel5"
        ToolStripLabel5.Size = New Size(62, 40)
        ToolStripLabel5.Text = "subnote"
        ' 
        ' ToolStripSeparator15
        ' 
        ToolStripSeparator15.Name = "ToolStripSeparator15"
        ToolStripSeparator15.Size = New Size(6, 43)
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' documentBox
        ' 
        documentBox.BorderStyle = BorderStyle.None
        documentBox.Dock = DockStyle.Fill
        documentBox.EnableAutoDragDrop = True
        documentBox.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        documentBox.Location = New Point(0, 160)
        documentBox.Margin = New Padding(2, 3, 2, 3)
        documentBox.Name = "documentBox"
        documentBox.ScrollBars = RichTextBoxScrollBars.Vertical
        documentBox.Size = New Size(1513, 700)
        documentBox.TabIndex = 6
        documentBox.Text = ""
        ' 
        ' leaptable
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1513, 860)
        Controls.Add(documentBox)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "leaptable"
        Text = "t1leapwrite"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents documentname1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents undo2 As ToolStripButton
    Friend WithEvents redo2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents fontselector As ToolStripComboBox
    Friend WithEvents sizeselector As ToolStripComboBox
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents openbutton1 As ToolStripMenuItem
    Friend WithEvents saveasbutton1 As ToolStripMenuItem
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents PictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripSplitButton2 As ToolStripSplitButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents open_dialog1 As OpenFileDialog
    Friend WithEvents save_dialog1 As SaveFileDialog
    Friend WithEvents savebutton1 As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents DefaultnoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DefaultBlackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents SoftwareLicenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents documentBox As RichTextBox
    Friend WithEvents ColunmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColunmToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ColunmToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ColunmToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ColunmToolStripMenuItem4 As ToolStripMenuItem
End Class
