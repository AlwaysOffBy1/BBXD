Public Class FormBBXD
    Public doColorChange As Boolean = False
#Region "META"
    Private Sub FormBBXD_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ImportBBXDDatabase()
        Call DatabaseToArray(BBXDdata)
        Me.Height = Me.MinimumSize.Height
        Call ImportBBXDDatabase()
    End Sub
    Private Sub FormBBXD_Move(sender As Object, e As EventArgs) Handles Me.Move
        Dim x, y As Integer
        Dim c1, c2 As Color
        If doColorChange Then
            x = Me.Location.X
            y = Me.Location.Y
            c1 = Color.FromArgb(255, (x / 2) Mod 255, (y / 2) Mod 255)
            c2 = Color.FromArgb(255, (x / 2) Mod 255 + 25, (y / 2) Mod 255 + 25)
            If x < 0 Then x = Math.Abs(x)
            If y < 0 Then y = Math.Abs(y)
            Try
                Me.LabelBB.BackColor = c1
                Me.PictureBox1.BackColor = c1
                Me.RichTextBoxBB.BackColor = Color.FromArgb(128, (x / 2) Mod 255, (y / 2) Mod 255)

                'Me.RichTextBoxBB.AppendText("TEST ")
                Try
                    Me.ButtonCopyB.BackColor = c2
                    Me.ButtonKeepColor.BackColor = c2
                Catch ex1 As Exception
                    Me.ButtonCopyB.BackColor = c1
                    Me.ButtonKeepColor.BackColor = c1
                End Try
            Catch ex As Exception
                Me.LabelBB.BackColor = Color.Black
                Me.PictureBox1.BackColor = Color.Black
                Me.ButtonCopyB.BackColor = Color.White
            End Try
        End If

    End Sub
#End Region
#Region "Buttons"
    Private Sub ButtonPaste_Click(sender As Object, e As EventArgs) Handles ButtonPasteV.Click
        Call PasteToVanillaForm()
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClearV.Click
        Call ClearVanillaForm()
    End Sub
    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopyV.Click
        Call CopyFromVanillaForm()
    End Sub
    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        Me.RichTextBoxBB.Text = ""
        Me.Height = 508
        Call BreakTextIntoLetters()
    End Sub
    Private Sub ButtonKeepColor_Click(sender As Object, e As EventArgs) Handles ButtonKeepColor.Click
        doColorChange = Not doColorChange
        If doColorChange Then
            Me.ButtonKeepColor.Text = "pretii col0r!"
        Else
            Me.ButtonKeepColor.Text = "again again!!"
        End If
    End Sub
#End Region
#Region "Menu Bar Handler"
    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        Call OpenDatabaseFromFile()
    End Sub
    Private Sub CreditsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem1.Click
        MsgBox("Bryan George")
        MsgBox("Yup... That's all the credits youre gonna get. Thanks!")
        If doColorChange Then
            MsgBox("Wait wait wait. You found the secret and STILL came back for the credits?" & vbNewLine & vbNewLine &
                   "OK. You deserve better. This idea was inspired by my friend Chris, who thought it would be " &
                   "funny to type like teenage girls. That thought inspired BBXO, a crude java program " &
                   "that found and replaced letters and words at random. " &
                   "It didn't do a great job, and all of the replacements had to be made in the physical program. " &
                   "Eventually, after starting work at Columbia University, my programming skills began to improve. " &
                   "I thought it would be funny to ressurect BBXO and make it look as dumb as possible. My goal was to get each " &
                   "person who used this to shake their head at least once at its idiocracy." & vbNewLine & vbNewLine &
                   "I'm not sure how many people I'm gonna release this to, but if you're not already a friend then " &
                   "thank you from the bottom of my heart for using this. Feel free to PM me on reddit at 'republicofcongo' " &
                   "without the apostrophes. I put a lot of hard work into this. 3nj0ii <3" & vbNewLine & vbNewLine &
                   "-Bryan George"
            )
        End If
        'If I released the source code and you're reading this, then HOLY CRAP!!! You've gone above and beyond to find this.
        'Also, I apologize for all the crumby code you may find.
        'If you wanna contact me, PM me on reddit at 'republicofcongo' without those apostrophes. I'd be MORE than happy
        'to answer any questions or take personally any, even the most minor criticisms.
        'Seriously. Contact me. I'm not great at programming and could use some tips
        'I actually wont get offended by advice.
        'That part about being offended was a joke. 

        'Again. Thanks for going above and beyond to look inside of me (the code)
        'If you didn't use the program and are just looking at the code then....um....cool, ya weirdo. Use this and you'll have fun.
        'buh-bye
    End Sub
    Private Sub SecretToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecretToolStripMenuItem.Click
        doColorChange = True
        Me.ButtonKeepColor.Visible = True
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Enter some text into the box, then hit convert to g3t BBXD txt lol")
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        DbEdit.ShowDialog()
    End Sub
#End Region
End Class
