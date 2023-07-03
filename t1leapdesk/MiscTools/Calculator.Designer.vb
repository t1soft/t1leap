<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        ButtonDec = New Button()
        ButtonNeg = New Button()
        ButtonMultiply = New Button()
        ButtonDivide = New Button()
        ButtonSubtract = New Button()
        Button13 = New Button()
        ButtonAdd = New Button()
        ButtonEqual = New Button()
        MenuStrip1 = New MenuStrip()
        CalculatorToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        InsertToolStripMenuItem = New ToolStripMenuItem()
        OtherOperationsToolStripMenuItem = New ToolStripMenuItem()
        Pi314159ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(12, 73)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(335, 36)
        TextBox1.TabIndex = 0
        TextBox1.Text = "3.14159"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(12, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(63, 59)
        Button1.TabIndex = 1
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(81, 126)
        Button2.Name = "Button2"
        Button2.Size = New Size(63, 59)
        Button2.TabIndex = 2
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(150, 126)
        Button3.Name = "Button3"
        Button3.Size = New Size(63, 59)
        Button3.TabIndex = 3
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(12, 191)
        Button4.Name = "Button4"
        Button4.Size = New Size(63, 59)
        Button4.TabIndex = 6
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(81, 191)
        Button5.Name = "Button5"
        Button5.Size = New Size(63, 59)
        Button5.TabIndex = 5
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(150, 191)
        Button6.Name = "Button6"
        Button6.Size = New Size(63, 59)
        Button6.TabIndex = 4
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.Location = New Point(12, 256)
        Button7.Name = "Button7"
        Button7.Size = New Size(63, 59)
        Button7.TabIndex = 7
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button8.Location = New Point(81, 256)
        Button8.Name = "Button8"
        Button8.Size = New Size(63, 59)
        Button8.TabIndex = 8
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button9.Location = New Point(150, 256)
        Button9.Name = "Button9"
        Button9.Size = New Size(63, 59)
        Button9.TabIndex = 9
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button10.Location = New Point(81, 321)
        Button10.Name = "Button10"
        Button10.Size = New Size(63, 59)
        Button10.TabIndex = 10
        Button10.Text = "0"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' ButtonDec
        ' 
        ButtonDec.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonDec.Location = New Point(150, 321)
        ButtonDec.Name = "ButtonDec"
        ButtonDec.Size = New Size(63, 59)
        ButtonDec.TabIndex = 11
        ButtonDec.Text = "."
        ButtonDec.UseVisualStyleBackColor = True
        ' 
        ' ButtonNeg
        ' 
        ButtonNeg.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonNeg.Location = New Point(12, 321)
        ButtonNeg.Name = "ButtonNeg"
        ButtonNeg.Size = New Size(63, 59)
        ButtonNeg.TabIndex = 12
        ButtonNeg.Text = "+/-"
        ButtonNeg.UseVisualStyleBackColor = True
        ' 
        ' ButtonMultiply
        ' 
        ButtonMultiply.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonMultiply.Location = New Point(288, 256)
        ButtonMultiply.Name = "ButtonMultiply"
        ButtonMultiply.Size = New Size(63, 59)
        ButtonMultiply.TabIndex = 13
        ButtonMultiply.Text = "*"
        ButtonMultiply.UseVisualStyleBackColor = True
        ' 
        ' ButtonDivide
        ' 
        ButtonDivide.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonDivide.Location = New Point(288, 191)
        ButtonDivide.Name = "ButtonDivide"
        ButtonDivide.Size = New Size(63, 59)
        ButtonDivide.TabIndex = 14
        ButtonDivide.Text = "/"
        ButtonDivide.UseVisualStyleBackColor = True
        ' 
        ' ButtonSubtract
        ' 
        ButtonSubtract.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSubtract.Location = New Point(219, 191)
        ButtonSubtract.Name = "ButtonSubtract"
        ButtonSubtract.Size = New Size(63, 59)
        ButtonSubtract.TabIndex = 15
        ButtonSubtract.Text = "-"
        ButtonSubtract.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button13.Location = New Point(219, 126)
        Button13.Name = "Button13"
        Button13.Size = New Size(132, 59)
        Button13.TabIndex = 16
        Button13.Text = "C"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonAdd.Location = New Point(219, 256)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(63, 59)
        ButtonAdd.TabIndex = 17
        ButtonAdd.Text = "+"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' ButtonEqual
        ' 
        ButtonEqual.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonEqual.Location = New Point(219, 321)
        ButtonEqual.Name = "ButtonEqual"
        ButtonEqual.Size = New Size(132, 59)
        ButtonEqual.TabIndex = 18
        ButtonEqual.Text = "="
        ButtonEqual.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CalculatorToolStripMenuItem, InsertToolStripMenuItem, OtherOperationsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(361, 28)
        MenuStrip1.TabIndex = 19
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CalculatorToolStripMenuItem
        ' 
        CalculatorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        CalculatorToolStripMenuItem.Size = New Size(90, 24)
        CalculatorToolStripMenuItem.Text = "Calculator"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' InsertToolStripMenuItem
        ' 
        InsertToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Pi314159ToolStripMenuItem})
        InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        InsertToolStripMenuItem.Size = New Size(59, 24)
        InsertToolStripMenuItem.Text = "Insert"
        ' 
        ' OtherOperationsToolStripMenuItem
        ' 
        OtherOperationsToolStripMenuItem.Name = "OtherOperationsToolStripMenuItem"
        OtherOperationsToolStripMenuItem.Size = New Size(137, 24)
        OtherOperationsToolStripMenuItem.Text = "Other Operations"
        ' 
        ' Pi314159ToolStripMenuItem
        ' 
        Pi314159ToolStripMenuItem.Name = "Pi314159ToolStripMenuItem"
        Pi314159ToolStripMenuItem.Size = New Size(224, 26)
        Pi314159ToolStripMenuItem.Text = "Pi (3.14159...)"
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(361, 397)
        Controls.Add(ButtonEqual)
        Controls.Add(ButtonAdd)
        Controls.Add(Button13)
        Controls.Add(ButtonSubtract)
        Controls.Add(ButtonDivide)
        Controls.Add(ButtonMultiply)
        Controls.Add(ButtonNeg)
        Controls.Add(ButtonDec)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Calculator"
        Text = "Calculator"
        TopMost = True
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents ButtonDec As Button
    Friend WithEvents ButtonNeg As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonEqual As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pi314159ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherOperationsToolStripMenuItem As ToolStripMenuItem
End Class
