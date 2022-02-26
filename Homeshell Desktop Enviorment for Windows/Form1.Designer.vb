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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DateText = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UserText = New System.Windows.Forms.Label()
        Me.ClockText = New System.Windows.Forms.Label()
        Me.Greeting = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'DateText
        '
        Me.DateText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateText.AutoSize = True
        Me.DateText.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateText.Location = New System.Drawing.Point(36, 615)
        Me.DateText.Name = "DateText"
        Me.DateText.Size = New System.Drawing.Size(135, 25)
        Me.DateText.TabIndex = 18
        Me.DateText.Text = "January 1, 2020"
        Me.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(952, 627)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 24)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = " Exit Enviorment"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "LeapDesk Milestone 4"
        '
        'UserText
        '
        Me.UserText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UserText.AutoSize = True
        Me.UserText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserText.Location = New System.Drawing.Point(36, 325)
        Me.UserText.Name = "UserText"
        Me.UserText.Size = New System.Drawing.Size(70, 37)
        Me.UserText.TabIndex = 16
        Me.UserText.Text = "User"
        '
        'ClockText
        '
        Me.ClockText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClockText.AutoSize = True
        Me.ClockText.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClockText.Location = New System.Drawing.Point(36, 565)
        Me.ClockText.Name = "ClockText"
        Me.ClockText.Size = New System.Drawing.Size(220, 50)
        Me.ClockText.TabIndex = 17
        Me.ClockText.Text = "00:00 AM     "
        Me.ClockText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Greeting
        '
        Me.Greeting.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Greeting.AutoSize = True
        Me.Greeting.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Greeting.Location = New System.Drawing.Point(36, 288)
        Me.Greeting.Name = "Greeting"
        Me.Greeting.Size = New System.Drawing.Size(199, 37)
        Me.Greeting.TabIndex = 15
        Me.Greeting.Text = "Good Morning,"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.Location = New System.Drawing.Point(37, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(289, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Click here to Log In."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1075, 663)
        Me.Controls.Add(Me.DateText)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.UserText)
        Me.Controls.Add(Me.ClockText)
        Me.Controls.Add(Me.Greeting)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LockNoPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateText As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents UserText As Label
    Friend WithEvents ClockText As Label
    Friend WithEvents Greeting As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
