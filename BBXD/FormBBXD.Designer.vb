<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBBXD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBBXD))
        Me.TextBoxVanilla = New System.Windows.Forms.TextBox()
        Me.ButtonPasteV = New System.Windows.Forms.Button()
        Me.ButtonClearV = New System.Windows.Forms.Button()
        Me.ButtonCopyV = New System.Windows.Forms.Button()
        Me.ButtonCopyB = New System.Windows.Forms.Button()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.RichTextBoxBB = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelBB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeepGoingXDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmostThereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoPickMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecretToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonKeepColor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxVanilla
        '
        Me.TextBoxVanilla.AllowDrop = True
        Me.TextBoxVanilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxVanilla.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxVanilla.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVanilla.Location = New System.Drawing.Point(8, 24)
        Me.TextBoxVanilla.MaxLength = 32767000
        Me.TextBoxVanilla.Multiline = True
        Me.TextBoxVanilla.Name = "TextBoxVanilla"
        Me.TextBoxVanilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxVanilla.Size = New System.Drawing.Size(513, 152)
        Me.TextBoxVanilla.TabIndex = 0
        '
        'ButtonPasteV
        '
        Me.ButtonPasteV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPasteV.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPasteV.Location = New System.Drawing.Point(529, 104)
        Me.ButtonPasteV.Name = "ButtonPasteV"
        Me.ButtonPasteV.Size = New System.Drawing.Size(89, 32)
        Me.ButtonPasteV.TabIndex = 1
        Me.ButtonPasteV.Text = "Paste"
        Me.ButtonPasteV.UseVisualStyleBackColor = True
        '
        'ButtonClearV
        '
        Me.ButtonClearV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearV.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearV.Location = New System.Drawing.Point(529, 24)
        Me.ButtonClearV.Name = "ButtonClearV"
        Me.ButtonClearV.Size = New System.Drawing.Size(89, 32)
        Me.ButtonClearV.TabIndex = 3
        Me.ButtonClearV.Text = "Clear"
        Me.ButtonClearV.UseVisualStyleBackColor = True
        '
        'ButtonCopyV
        '
        Me.ButtonCopyV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCopyV.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCopyV.Location = New System.Drawing.Point(529, 64)
        Me.ButtonCopyV.Name = "ButtonCopyV"
        Me.ButtonCopyV.Size = New System.Drawing.Size(89, 32)
        Me.ButtonCopyV.TabIndex = 4
        Me.ButtonCopyV.Text = "Copy"
        Me.ButtonCopyV.UseVisualStyleBackColor = True
        '
        'ButtonCopyB
        '
        Me.ButtonCopyB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCopyB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonCopyB.BackColor = System.Drawing.Color.DeepPink
        Me.ButtonCopyB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonCopyB.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonCopyB.FlatAppearance.BorderSize = 50
        Me.ButtonCopyB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.ButtonCopyB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ButtonCopyB.Font = New System.Drawing.Font("Vladimir Script", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCopyB.ForeColor = System.Drawing.Color.Black
        Me.ButtonCopyB.Image = Global.BBXD.My.Resources.Resources.bbxdCopyButtonImage
        Me.ButtonCopyB.Location = New System.Drawing.Point(528, 256)
        Me.ButtonCopyB.Name = "ButtonCopyB"
        Me.ButtonCopyB.Size = New System.Drawing.Size(96, 192)
        Me.ButtonCopyB.TabIndex = 6
        Me.ButtonCopyB.Text = "Copy"
        Me.ButtonCopyB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonCopyB.UseVisualStyleBackColor = False
        '
        'ButtonConvert
        '
        Me.ButtonConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConvert.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConvert.Location = New System.Drawing.Point(529, 144)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(89, 32)
        Me.ButtonConvert.TabIndex = 7
        Me.ButtonConvert.Text = "Convert!"
        Me.ButtonConvert.UseVisualStyleBackColor = True
        '
        'RichTextBoxBB
        '
        Me.RichTextBoxBB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxBB.Location = New System.Drawing.Point(16, 312)
        Me.RichTextBoxBB.Name = "RichTextBoxBB"
        Me.RichTextBoxBB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxBB.Size = New System.Drawing.Size(504, 144)
        Me.RichTextBoxBB.TabIndex = 8
        Me.RichTextBoxBB.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonConvert)
        Me.GroupBox1.Controls.Add(Me.ButtonCopyV)
        Me.GroupBox1.Controls.Add(Me.ButtonClearV)
        Me.GroupBox1.Controls.Add(Me.ButtonPasteV)
        Me.GroupBox1.Controls.Add(Me.TextBoxVanilla)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 184)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Entered Text."
        '
        'LabelBB
        '
        Me.LabelBB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelBB.BackColor = System.Drawing.Color.HotPink
        Me.LabelBB.Location = New System.Drawing.Point(8, 240)
        Me.LabelBB.Name = "LabelBB"
        Me.LabelBB.Size = New System.Drawing.Size(625, 224)
        Me.LabelBB.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.HotPink
        Me.PictureBox1.Image = Global.BBXD.My.Resources.Resources.bbxdImage
        Me.PictureBox1.Location = New System.Drawing.Point(16, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 56)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(642, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.ImportToolStripMenuItem, Me.toolStripSeparator2, Me.CreditsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(325, 26)
        Me.OpenToolStripMenuItem.Text = "&Open Current Db For Editing"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(322, 6)
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(325, 26)
        Me.ImportToolStripMenuItem.Text = "Import Database From File"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(322, 6)
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeepGoingXDToolStripMenuItem})
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(325, 26)
        Me.CreditsToolStripMenuItem.Text = "Credits ;)"
        '
        'KeepGoingXDToolStripMenuItem
        '
        Me.KeepGoingXDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmostThereToolStripMenuItem})
        Me.KeepGoingXDToolStripMenuItem.Name = "KeepGoingXDToolStripMenuItem"
        Me.KeepGoingXDToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.KeepGoingXDToolStripMenuItem.Text = "Keep going XD"
        '
        'AlmostThereToolStripMenuItem
        '
        Me.AlmostThereToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickMeToolStripMenuItem, Me.NoPickMeToolStripMenuItem})
        Me.AlmostThereToolStripMenuItem.Name = "AlmostThereToolStripMenuItem"
        Me.AlmostThereToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.AlmostThereToolStripMenuItem.Text = "Almost there!"
        '
        'PickMeToolStripMenuItem
        '
        Me.PickMeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditsToolStripMenuItem1})
        Me.PickMeToolStripMenuItem.Name = "PickMeToolStripMenuItem"
        Me.PickMeToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.PickMeToolStripMenuItem.Text = "Pick me!"
        '
        'CreditsToolStripMenuItem1
        '
        Me.CreditsToolStripMenuItem1.Name = "CreditsToolStripMenuItem1"
        Me.CreditsToolStripMenuItem1.Size = New System.Drawing.Size(142, 26)
        Me.CreditsToolStripMenuItem1.Text = "Credits ;)"
        '
        'NoPickMeToolStripMenuItem
        '
        Me.NoPickMeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecretToolStripMenuItem})
        Me.NoPickMeToolStripMenuItem.Name = "NoPickMeToolStripMenuItem"
        Me.NoPickMeToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.NoPickMeToolStripMenuItem.Text = "No pick me!"
        '
        'SecretToolStripMenuItem
        '
        Me.SecretToolStripMenuItem.Name = "SecretToolStripMenuItem"
        Me.SecretToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.SecretToolStripMenuItem.Text = "Secret!"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(325, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.HelpToolStripMenuItem.Text = "Help!"
        '
        'ButtonKeepColor
        '
        Me.ButtonKeepColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonKeepColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonKeepColor.BackColor = System.Drawing.Color.DeepPink
        Me.ButtonKeepColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonKeepColor.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonKeepColor.FlatAppearance.BorderSize = 50
        Me.ButtonKeepColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.ButtonKeepColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ButtonKeepColor.Font = New System.Drawing.Font("Vladimir Script", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKeepColor.ForeColor = System.Drawing.Color.Black
        Me.ButtonKeepColor.Location = New System.Drawing.Point(296, 248)
        Me.ButtonKeepColor.Name = "ButtonKeepColor"
        Me.ButtonKeepColor.Size = New System.Drawing.Size(224, 56)
        Me.ButtonKeepColor.TabIndex = 13
        Me.ButtonKeepColor.Text = "pretii col0r!"
        Me.ButtonKeepColor.UseVisualStyleBackColor = False
        Me.ButtonKeepColor.Visible = False
        '
        'FormBBXD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 463)
        Me.Controls.Add(Me.ButtonKeepColor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBoxBB)
        Me.Controls.Add(Me.ButtonCopyB)
        Me.Controls.Add(Me.LabelBB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MinimumSize = New System.Drawing.Size(660, 278)
        Me.Name = "FormBBXD"
        Me.Text = "BBXD (lol)"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxVanilla As TextBox
    Friend WithEvents ButtonPasteV As Button
    Friend WithEvents ButtonClearV As Button
    Friend WithEvents ButtonCopyV As Button
    Friend WithEvents ButtonCopyB As Button
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents RichTextBoxBB As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelBB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeepGoingXDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmostThereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PickMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NoPickMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecretToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonKeepColor As Button
End Class
