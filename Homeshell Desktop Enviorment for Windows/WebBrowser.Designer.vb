<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WebBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowser))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WebboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiveFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabModesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudyModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourcesArticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoteAppAnd2SourcesArticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultitaskingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.WebView3 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.WebView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebboxToolStripMenuItem, Me.TabModesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WebboxToolStripMenuItem
        '
        Me.WebboxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.GiveFeedbackToolStripMenuItem})
        Me.WebboxToolStripMenuItem.Name = "WebboxToolStripMenuItem"
        Me.WebboxToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WebboxToolStripMenuItem.Text = "Webbox"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GiveFeedbackToolStripMenuItem
        '
        Me.GiveFeedbackToolStripMenuItem.Name = "GiveFeedbackToolStripMenuItem"
        Me.GiveFeedbackToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GiveFeedbackToolStripMenuItem.Text = "Give Feedback"
        '
        'TabModesToolStripMenuItem
        '
        Me.TabModesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.StudyModeToolStripMenuItem, Me.MultitaskingToolStripMenuItem})
        Me.TabModesToolStripMenuItem.Name = "TabModesToolStripMenuItem"
        Me.TabModesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.TabModesToolStripMenuItem.Text = "Tab Modes"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'StudyModeToolStripMenuItem
        '
        Me.StudyModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourcesArticlesToolStripMenuItem, Me.NoteAppAnd2SourcesArticlesToolStripMenuItem})
        Me.StudyModeToolStripMenuItem.Name = "StudyModeToolStripMenuItem"
        Me.StudyModeToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.StudyModeToolStripMenuItem.Text = "Study Mode"
        '
        'SourcesArticlesToolStripMenuItem
        '
        Me.SourcesArticlesToolStripMenuItem.Name = "SourcesArticlesToolStripMenuItem"
        Me.SourcesArticlesToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.SourcesArticlesToolStripMenuItem.Text = "3 Sources/Articles"
        '
        'NoteAppAnd2SourcesArticlesToolStripMenuItem
        '
        Me.NoteAppAnd2SourcesArticlesToolStripMenuItem.Name = "NoteAppAnd2SourcesArticlesToolStripMenuItem"
        Me.NoteAppAnd2SourcesArticlesToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.NoteAppAnd2SourcesArticlesToolStripMenuItem.Text = "Note App and 2 Sources/Articles"
        '
        'MultitaskingToolStripMenuItem
        '
        Me.MultitaskingToolStripMenuItem.Name = "MultitaskingToolStripMenuItem"
        Me.MultitaskingToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.MultitaskingToolStripMenuItem.Text = "Multitasking"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.WebView3)
        Me.TabPage3.Controls.Add(Me.ToolStrip3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1067, 591)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'WebView3
        '
        Me.WebView3.CreationProperties = Nothing
        Me.WebView3.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView3.Location = New System.Drawing.Point(3, 28)
        Me.WebView3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.WebView3.Name = "WebView3"
        Me.WebView3.Size = New System.Drawing.Size(1061, 560)
        Me.WebView3.Source = New System.Uri("https://google.com", System.UriKind.Absolute)
        Me.WebView3.TabIndex = 7
        Me.WebView3.ZoomFactor = 1.0R
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripTextBox3, Me.ToolStripButton12})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1061, 25)
        Me.ToolStrip3.TabIndex = 6
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton9.Text = "Back"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton10.Text = "Forward"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton11.Text = "Refresh"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(200, 25)
        Me.ToolStripTextBox3.Text = "https://"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripButton12.Text = "Go!"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebView2)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1067, 591)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebView2
        '
        Me.WebView2.CreationProperties = Nothing
        Me.WebView2.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView2.Location = New System.Drawing.Point(3, 28)
        Me.WebView2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.WebView2.Name = "WebView2"
        Me.WebView2.Size = New System.Drawing.Size(1061, 560)
        Me.WebView2.Source = New System.Uri("https://google.com", System.UriKind.Absolute)
        Me.WebView2.TabIndex = 6
        Me.WebView2.ZoomFactor = 1.0R
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripTextBox2, Me.ToolStripButton8})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1061, 25)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton5.Text = "Back"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton6.Text = "Forward"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton7.Text = "Refresh"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(200, 25)
        Me.ToolStripTextBox2.Text = "https://"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripButton8.Text = "Go!"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebView21)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1067, 591)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebView21
        '
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(3, 28)
        Me.WebView21.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(1061, 560)
        Me.WebView21.Source = New System.Uri("https://google.com", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 3
        Me.WebView21.ZoomFactor = 1.0R
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripTextBox1, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1061, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton1.Text = "Back"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton2.Text = "Forward"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton3.Text = "Refresh"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.ToolStripTextBox1.Text = "https://"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripButton4.Text = "Go!"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1075, 619)
        Me.TabControl1.TabIndex = 5
        '
        'WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 643)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "WebBrowser"
        Me.Text = "WebBox v1 Portal"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.WebView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WebboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiveFeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabModesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudyModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SourcesArticlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoteAppAnd2SourcesArticlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultitaskingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents WebView3 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents WebView2 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
End Class
