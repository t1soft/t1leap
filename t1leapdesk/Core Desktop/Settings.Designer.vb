<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Settings))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label10 = New Label()
        TabPage3 = New TabPage()
        Label8 = New Label()
        Label5 = New Label()
        Button3 = New Button()
        Label3 = New Label()
        TabPage2 = New TabPage()
        Label16 = New Label()
        Panel2 = New Panel()
        Label14 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label9 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage5 = New TabPage()
        Label17 = New Label()
        Label15 = New Label()
        Panel1 = New Panel()
        Button4 = New Button()
        passwordComfirmText = New TextBox()
        Label11 = New Label()
        passwordSetText = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        TabPage4 = New TabPage()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        open_dialog1 = New OpenFileDialog()
        Button5 = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel2.SuspendLayout()
        TabPage5.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(14, 16)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(887, 568)
        TabControl1.TabIndex = 7
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label10)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(879, 535)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(22, 328)
        Label10.Name = "Label10"
        Label10.Size = New Size(737, 180)
        Label10.TabIndex = 18
        Label10.Text = resources.GetString("Label10.Text")
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label8)
        TabPage3.Controls.Add(Label5)
        TabPage3.Controls.Add(Button3)
        TabPage3.Controls.Add(Label3)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Margin = New Padding(3, 4, 3, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(879, 535)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Experimantal Features"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(21, 477)
        Label8.Name = "Label8"
        Label8.Size = New Size(532, 20)
        Label8.TabIndex = 17
        Label8.Text = "INSTABILITY WARNING: Read the Notice in the Home Tab for More Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(660, 20)
        Label5.TabIndex = 16
        Label5.Text = "Tests the User Interface if T1LeapDesk Crashes (will close all apps, so save work before continuing!)"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(21, 132)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(256, 31)
        Button3.TabIndex = 15
        Button3.Text = "Test Crash Screen"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(21, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(732, 41)
        Label3.TabIndex = 12
        Label3.Text = "You can Test Features soon to be added into leapdesk"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label16)
        TabPage2.Controls.Add(Panel2)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label1)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(879, 535)
        TabPage2.TabIndex = 4
        TabPage2.Text = "Personalisation"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(22, 473)
        Label16.Name = "Label16"
        Label16.Size = New Size(546, 20)
        Label16.TabIndex = 26
        Label16.Text = "Notice: You must close and reopen t1leapdesk for these changes to go into effect"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(7, 85)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 152)
        Panel2.TabIndex = 25
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(14, 15)
        Label14.Name = "Label14"
        Label14.Size = New Size(136, 20)
        Label14.TabIndex = 2
        Label14.Text = "Desktop Wallpaper"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(14, 97)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(235, 32)
        Button2.TabIndex = 21
        Button2.Text = "Clear Wallpaper"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(14, 59)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(235, 31)
        Button1.TabIndex = 20
        Button1.Text = "Select Photo for Wallpaper"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(7, 41)
        Label9.Name = "Label9"
        Label9.Size = New Size(261, 20)
        Label9.TabIndex = 19
        Label9.Text = "Personalize how t1leapdesk looks like!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(22, 493)
        Label2.Name = "Label2"
        Label2.Size = New Size(532, 20)
        Label2.TabIndex = 18
        Label2.Text = "INSTABILITY WARNING: Read the Notice in the Home Tab for More Information"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(7, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 35)
        Label1.TabIndex = 0
        Label1.Text = "Personalization"
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(Label17)
        TabPage5.Controls.Add(Label15)
        TabPage5.Controls.Add(Panel1)
        TabPage5.Controls.Add(Label12)
        TabPage5.Controls.Add(Label13)
        TabPage5.Location = New Point(4, 29)
        TabPage5.Margin = New Padding(3, 4, 3, 4)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3, 4, 3, 4)
        TabPage5.Size = New Size(879, 535)
        TabPage5.TabIndex = 5
        TabPage5.Text = "Security"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.ForeColor = Color.Red
        Label17.Location = New Point(8, 495)
        Label17.Name = "Label17"
        Label17.Size = New Size(532, 20)
        Label17.TabIndex = 26
        Label17.Text = "INSTABILITY WARNING: Read the Notice in the Home Tab for More Information"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(8, 475)
        Label15.Name = "Label15"
        Label15.Size = New Size(546, 20)
        Label15.TabIndex = 25
        Label15.Text = "Notice: You must close and reopen t1leapdesk for these changes to go into effect"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(passwordComfirmText)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(passwordSetText)
        Panel1.Location = New Point(8, 77)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(221, 177)
        Panel1.TabIndex = 24
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(14, 131)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(194, 31)
        Button4.TabIndex = 1
        Button4.Text = "Set Password"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' passwordComfirmText
        ' 
        passwordComfirmText.Location = New Point(14, 92)
        passwordComfirmText.Margin = New Padding(3, 4, 3, 4)
        passwordComfirmText.Name = "passwordComfirmText"
        passwordComfirmText.PasswordChar = "*"c
        passwordComfirmText.PlaceholderText = "Comfirm New Password"
        passwordComfirmText.Size = New Size(194, 27)
        passwordComfirmText.TabIndex = 23
        passwordComfirmText.UseSystemPasswordChar = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(14, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(135, 20)
        Label11.TabIndex = 2
        Label11.Text = "Account Password: "
        ' 
        ' passwordSetText
        ' 
        passwordSetText.Location = New Point(14, 53)
        passwordSetText.Margin = New Padding(3, 4, 3, 4)
        passwordSetText.Name = "passwordSetText"
        passwordSetText.PasswordChar = "*"c
        passwordSetText.PlaceholderText = "Enter New Password"
        passwordSetText.Size = New Size(194, 27)
        passwordSetText.TabIndex = 22
        passwordSetText.UseSystemPasswordChar = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(7, 41)
        Label12.Name = "Label12"
        Label12.Size = New Size(481, 20)
        Label12.TabIndex = 21
        Label12.Text = "Protect t1leapdesk from Unauthorized Usage by Setting Up a Password "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(7, 4)
        Label13.Name = "Label13"
        Label13.Size = New Size(197, 35)
        Label13.TabIndex = 20
        Label13.Text = "Security Settings"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Button5)
        TabPage4.Controls.Add(PictureBox1)
        TabPage4.Controls.Add(Label4)
        TabPage4.Controls.Add(Label7)
        TabPage4.Controls.Add(Label6)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Margin = New Padding(3, 4, 3, 4)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(879, 535)
        TabPage4.TabIndex = 3
        TabPage4.Text = "About"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 140)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(397, 100)
        Label4.TabIndex = 2
        Label4.Text = "(c) t1leapsoft 2023 " & vbCrLf & "Licences, including Third Party Notices/Licences" & vbCrLf & "are accessable by clicking on About -> Licences in Settings" & vbCrLf & "or by going to Help -> Licences in t1leapwrite/t1leaptable" & vbCrLf & vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(107, 140)
        Label7.Name = "Label7"
        Label7.Size = New Size(655, 41)
        Label7.TabIndex = 8
        Label7.Text = "T1LeapDesk Environment Codename ""snowball"""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(110, 183)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 20)
        Label6.TabIndex = 9
        Label6.Text = "For Windows 10/11"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(7, 493)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 12
        Button5.Text = "Licences"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Settings"
        Text = "Settings"
        TopMost = True
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents open_dialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents passwordComfirmText As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents passwordSetText As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button5 As Button
End Class
