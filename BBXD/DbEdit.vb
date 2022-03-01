Public Class DbEdit
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Main.BBXDdata = Me.TextBoxEditor.Text
        My.Computer.FileSystem.WriteAllText(Main.fileLocation, Me.TextBoxEditor.Text, False)
    End Sub

    Private Sub DbEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TextBoxEditor.Text = Main.BBXDdata
    End Sub

    Private Sub TrackBarFont_Scroll(sender As Object, e As EventArgs) Handles TrackBarFont.Scroll
        Me.TextBoxEditor.Font = New Font(TextBoxEditor.Font.Name, Me.TrackBarFont.Value, FontStyle.Regular)
        Me.LabelFontSize.Font = New Font(LabelFontSize.Font.Name, Me.TrackBarFont.Value, FontStyle.Regular)
        Me.LabelFontSize.Text = "Font Size: " & Me.TrackBarFont.Value
    End Sub
End Class