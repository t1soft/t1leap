<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Button1 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(14, 55)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 132)
        Button1.TabIndex = 0
        Button1.Text = "Close Environment"
        Button1.TextAlign = ContentAlignment.BottomLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(197, 55)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(169, 233)
        Button3.TabIndex = 2
        Button3.Text = "Log Out"
        Button3.TextAlign = ContentAlignment.BottomLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(324, 20)
        Label1.TabIndex = 3
        Label1.Text = "Options - Log Out, Lock, and Close Environment"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(14, 176)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(189, 112)
        Button4.TabIndex = 5
        Button4.Text = "Cancel"
        Button4.TextAlign = ContentAlignment.BottomLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 322)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Button4)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
End Class
