<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button2 = New Button()
        Label6 = New Label()
        UserText = New Label()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(0, 828)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 56)
        Button2.TabIndex = 20
        Button2.Text = " Exit Leapdesk"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Light", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ImageAlign = ContentAlignment.MiddleLeft
        Label6.Location = New Point(14, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 32)
        Label6.TabIndex = 19
        Label6.Text = "T1LeapDesk"
        ' 
        ' UserText
        ' 
        UserText.Anchor = AnchorStyles.Left
        UserText.AutoSize = True
        UserText.BackColor = Color.SkyBlue
        UserText.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        UserText.ForeColor = SystemColors.ControlText
        UserText.Location = New Point(205, 381)
        UserText.Name = "UserText"
        UserText.Size = New Size(87, 46)
        UserText.TabIndex = 16
        UserText.Text = "User"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Left
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(557, 435)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 36)
        Button1.TabIndex = 14
        Button1.Text = "Log In"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(149, 884)
        Panel1.TabIndex = 21
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left
        TextBox1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(205, 435)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(355, 32)
        TextBox1.TabIndex = 21
        TextBox1.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(888, 765)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 100)
        Label1.TabIndex = 23
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.SkyBlue
        Label2.Font = New Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.LightSeaGreen
        Label2.Location = New Point(155, 765)
        Label2.Name = "Label2"
        Label2.Size = New Size(304, 112)
        Label2.TabIndex = 24
        Label2.Text = "Label2"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(205, 475)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 20)
        Label3.TabIndex = 25
        Label3.Text = "Preparing Login, Please Wait"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1258, 884)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(UserText)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.Manual
        Text = "LockNoPass"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents UserText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
