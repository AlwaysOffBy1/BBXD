<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskToSaveFileForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AskToSaveFileForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonDesk = New System.Windows.Forms.Button()
        Me.ButtonNot = New System.Windows.Forms.Button()
        Me.ButtonDoc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(451, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A question from your friendly neighborhood developer..."
        '
        'ButtonDesk
        '
        Me.ButtonDesk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDesk.Location = New System.Drawing.Point(12, 117)
        Me.ButtonDesk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonDesk.Name = "ButtonDesk"
        Me.ButtonDesk.Size = New System.Drawing.Size(126, 32)
        Me.ButtonDesk.TabIndex = 2
        Me.ButtonDesk.Text = "Save to 'Desktop'"
        Me.ButtonDesk.UseVisualStyleBackColor = True
        '
        'ButtonNot
        '
        Me.ButtonNot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonNot.Location = New System.Drawing.Point(320, 117)
        Me.ButtonNot.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonNot.Name = "ButtonNot"
        Me.ButtonNot.Size = New System.Drawing.Size(126, 32)
        Me.ButtonNot.TabIndex = 3
        Me.ButtonNot.Text = "Don't save file"
        Me.ButtonNot.UseVisualStyleBackColor = True
        '
        'ButtonDoc
        '
        Me.ButtonDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDoc.Location = New System.Drawing.Point(160, 117)
        Me.ButtonDoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonDoc.Name = "ButtonDoc"
        Me.ButtonDoc.Size = New System.Drawing.Size(136, 32)
        Me.ButtonDoc.TabIndex = 4
        Me.ButtonDoc.Text = "Save to 'My Documents'"
        Me.ButtonDoc.UseVisualStyleBackColor = True
        '
        'AskToSaveFileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 166)
        Me.Controls.Add(Me.ButtonDoc)
        Me.Controls.Add(Me.ButtonNot)
        Me.Controls.Add(Me.ButtonDesk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(484, 204)
        Me.Name = "AskToSaveFileForm"
        Me.Text = "Save Database for later editing?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonDesk As Button
    Friend WithEvents ButtonNot As Button
    Friend WithEvents ButtonDoc As Button
End Class
