<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DbEdit
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
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxEditor = New System.Windows.Forms.RichTextBox()
        Me.TrackBarFont = New System.Windows.Forms.TrackBar()
        Me.LabelFontSize = New System.Windows.Forms.Label()
        CType(Me.TrackBarFont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(8, 438)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(337, 48)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBoxEditor
        '
        Me.TextBoxEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEditor.Location = New System.Drawing.Point(8, 8)
        Me.TextBoxEditor.Name = "TextBoxEditor"
        Me.TextBoxEditor.Size = New System.Drawing.Size(336, 360)
        Me.TextBoxEditor.TabIndex = 2
        Me.TextBoxEditor.Text = ""
        '
        'TrackBarFont
        '
        Me.TrackBarFont.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBarFont.Location = New System.Drawing.Point(16, 376)
        Me.TrackBarFont.Maximum = 24
        Me.TrackBarFont.Minimum = 4
        Me.TrackBarFont.Name = "TrackBarFont"
        Me.TrackBarFont.Size = New System.Drawing.Size(328, 56)
        Me.TrackBarFont.TabIndex = 3
        Me.TrackBarFont.Value = 8
        '
        'LabelFontSize
        '
        Me.LabelFontSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelFontSize.Location = New System.Drawing.Point(32, 400)
        Me.LabelFontSize.Name = "LabelFontSize"
        Me.LabelFontSize.Size = New System.Drawing.Size(304, 32)
        Me.LabelFontSize.TabIndex = 4
        Me.LabelFontSize.Text = "Font Size: 8"
        '
        'DbEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 494)
        Me.Controls.Add(Me.LabelFontSize)
        Me.Controls.Add(Me.TrackBarFont)
        Me.Controls.Add(Me.TextBoxEditor)
        Me.Controls.Add(Me.ButtonSave)
        Me.MinimumSize = New System.Drawing.Size(369, 539)
        Me.Name = "DbEdit"
        Me.Text = "Database Editor"
        CType(Me.TrackBarFont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxEditor As RichTextBox
    Friend WithEvents TrackBarFont As TrackBar
    Friend WithEvents LabelFontSize As Label
End Class
