Public Class AskToSaveFileForm
    Public buttonClicked As Integer
    Public safeClose As Boolean = False

    Private Sub AskToSaveFileForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not safeClose Then buttonClicked = 0
    End Sub

    Private Sub ButtonDesk_Click(sender As Object, e As EventArgs) Handles ButtonDesk.Click
        buttonClicked = 1
        Me.Hide()
    End Sub

    Private Sub ButtonDoc_Click(sender As Object, e As EventArgs) Handles ButtonDoc.Click
        buttonClicked = 2
        Me.Hide()
    End Sub

    Private Sub ButtonNot_Click(sender As Object, e As EventArgs) Handles ButtonNot.Click
        buttonClicked = 0
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class