<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Desktop))
        Timer1 = New Timer(components)
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Panel2 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label11 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Quicknote = New TextBox()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 943)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1399, 49)
        Panel2.TabIndex = 27
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(1170, 0)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(142, 49)
        Button3.TabIndex = 2
        Button3.Text = "Switch Desktop"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ImageAlign = ContentAlignment.BottomLeft
        Button2.Location = New Point(0, 0)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 51)
        Button2.TabIndex = 0
        Button2.Text = "Menu"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(1312, 0)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 49)
        Button1.TabIndex = 0
        Button1.Text = "Log Out"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1170, 943)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(231, 20)
        Label11.TabIndex = 26
        Label11.Text = "_____________________________________"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(18, 499)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(18, 532)
        CheckBox2.Margin = New Padding(3, 4, 3, 4)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(103, 24)
        CheckBox2.TabIndex = 11
        CheckBox2.Text = "CheckBox2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(18, 565)
        CheckBox3.Margin = New Padding(3, 4, 3, 4)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(103, 24)
        CheckBox3.TabIndex = 12
        CheckBox3.Text = "CheckBox3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(18, 599)
        CheckBox4.Margin = New Padding(3, 4, 3, 4)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(103, 24)
        CheckBox4.TabIndex = 13
        CheckBox4.Text = "CheckBox4"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(18, 632)
        CheckBox5.Margin = New Padding(3, 4, 3, 4)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(103, 24)
        CheckBox5.TabIndex = 14
        CheckBox5.Text = "CheckBox5"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(38, 493)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(38, 527)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(177, 27)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(38, 560)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(177, 27)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(38, 593)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(177, 27)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(38, 627)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(177, 27)
        TextBox5.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(16, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 23)
        Label5.TabIndex = 20
        Label5.Text = "Quick Note"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(18, 461)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 23)
        Label6.TabIndex = 21
        Label6.Text = "To-Do List"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(0, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(269, 23)
        Label8.TabIndex = 23
        Label8.Text = "_____________________________________"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(0, 431)
        Label9.Name = "Label9"
        Label9.Size = New Size(231, 20)
        Label9.TabIndex = 24
        Label9.Text = "_____________________________________"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 660)
        Label10.Name = "Label10"
        Label10.Size = New Size(231, 20)
        Label10.TabIndex = 25
        Label10.Text = "_____________________________________"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(7, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(222, 62)
        Label3.TabIndex = 8
        Label3.Text = "00:00 AM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(16, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 23)
        Label4.TabIndex = 9
        Label4.Text = "January 1, 2020"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(17, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 23)
        Label7.TabIndex = 28
        Label7.Text = "Clock"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Quicknote)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(CheckBox5)
        Panel1.Controls.Add(CheckBox4)
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label11)
        Panel1.Dock = DockStyle.Right
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(1170, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(229, 943)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(20, 888)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 48)
        Label1.TabIndex = 30
        Label1.Text = "t1leapdesk 2022 Preview Build" & vbCrLf & "Build 2021-23-0419" & vbCrLf & "Dev Build. May be Unstable"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Quicknote
        ' 
        Quicknote.Location = New Point(18, 215)
        Quicknote.Margin = New Padding(3, 4, 3, 4)
        Quicknote.Multiline = True
        Quicknote.Name = "Quicknote"
        Quicknote.Size = New Size(196, 211)
        Quicknote.TabIndex = 29
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1170, 943)
        Panel3.TabIndex = 28
        ' 
        ' Desktop
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1399, 992)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Desktop"
        Text = "Homeshell Desktop - Desktop"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Quicknote As TextBox
    Friend WithEvents Label1 As Label
End Class
