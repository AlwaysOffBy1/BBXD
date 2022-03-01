
'!!!!!!!!!!!!!!HELLO AND THANK YOU FOR COMING PLEASE READ THIS!!!!!!!!!!!!!!!
'Database is a string
'Each line is seperated WITHIN database as "text" & vbnewline & "text2"
'text replace works word by word (seperated by space),  then letter by letter
'Reading database goes line by line, then word by word
'vanilla = v
'____________________________________________________________________________

Module Main
    Public vanilla_WordArr(), BBXD_WordArr(), chanceOf_WordArr(), footers(), listOfWords(), hashTag() As String
    Public wholeWord_WordArr() As Boolean
    Public BBXDdata, fileLocation As String
    Public isDatabaseReady As Boolean
    Public MASTERBB, MASTERV As String
    Public masterIndex As Integer



#Region "Form Logistics"

    Sub PasteToVanillaForm()
        FormBBXD.TextBoxVanilla.Text = FormBBXD.TextBoxVanilla.Text & My.Computer.Clipboard.GetText
    End Sub
    Sub ClearVanillaForm()
        FormBBXD.TextBoxVanilla.Text = ""
    End Sub
    Sub CopyFromVanillaForm()
        If FormBBXD.TextBoxVanilla.Text = "" Then
            My.Computer.Clipboard.SetText("")
        Else
            My.Computer.Clipboard.SetText(FormBBXD.TextBoxVanilla.Text)
        End If
    End Sub

#End Region

    Sub ImportBBXDDatabase()
        Dim saveAfterNotFindingMyDocs As Integer

        'Check to see if user computer already has BBXD database. If not, then ask if they want to download it
        With My.Computer.FileSystem.SpecialDirectories
            If System.IO.File.Exists(.Desktop & "\BBXDdatabase.txt") = True Then
                fileLocation = .Desktop & "\BBXDdatabase.txt"
                BBXDdata = My.Computer.FileSystem.ReadAllText(.Desktop & "\BBXDdatabase.txt")
                Exit Sub
            End If
            Try
                If System.IO.File.Exists(.MyDocuments & "\BBXDdatabase.txt") = True Then
                    fileLocation = .MyDocuments & "\BBXDdatabase.txt"
                    BBXDdata = My.Computer.FileSystem.ReadAllText(.MyDocuments & "\BBXDdatabase.txt")
                    Exit Sub
                End If
            Catch e As Exception
                'User doesnt have file on desktop or have a my documents folder
            End Try
            AskToSaveFileForm.ShowDialog()
            AskToSaveFileForm.safeClose = True
            If AskToSaveFileForm.buttonClicked = 1 Then 'User clicked "save to desktop"
                System.IO.File.Create(.Desktop & "\BBXDdatabase.txt").Close()
                My.Computer.FileSystem.WriteAllText(.Desktop & "\BBXDdatabase.txt", My.Resources.BBXDdatabaseLocal, False)
                fileLocation = .Desktop & "\BBXDdatabase.txt"
                BBXDdata = My.Computer.FileSystem.ReadAllText(.Desktop & "\BBXDdatabase.txt")
                Exit Sub
            End If
            Try
                If AskToSaveFileForm.buttonClicked = 2 Then 'User clicked "save to mydocs"
                    System.IO.File.Create(.MyDocuments & "\BBXDdatabase.txt").Close()
                    My.Computer.FileSystem.WriteAllText(.MyDocuments & "\BBXDdatabase.txt", My.Resources.BBXDdatabaseLocal, False)
                    BBXDdata = My.Computer.FileSystem.ReadAllText(.MyDocuments & "\BBXDdatabase.txt")
                    fileLocation = .MyDocuments & "\BBXDdatabase.txt"
                    Exit Sub
                End If
            Catch e As Exception 'User clicked "save to mydocs, but doesnt have mydocs"
                saveAfterNotFindingMyDocs = MsgBox("For some reason, 'My Documents' could not be found." & vbNewLine & vbNewLine &
                                                   "To save to desktop, click 'Ok'. To use default database, click 'Cancel'",
                                                   MsgBoxStyle.OkCancel, "Error")
                If saveAfterNotFindingMyDocs = 1 Then
                    System.IO.File.Create(.Desktop & "\BBXDdatabase.txt").Close()
                    My.Computer.FileSystem.WriteAllText(.Desktop & "\BBXDdatabase.txt", My.Resources.BBXDdatabaseLocal, False)
                    BBXDdata = My.Computer.FileSystem.ReadAllText(.Desktop & "\BBXDdatabase.txt")
                    fileLocation = .Desktop & "\BBXDdatabase.txt"
                    Exit Sub
                End If
            End Try
            FormBBXD.OpenToolStripMenuItem.Enabled = False
            BBXDdata = My.Resources.BBXDdatabaseLocal
        End With
        AskToSaveFileForm.Dispose()
    End Sub
    Sub OpenDatabaseFromFile()
        Dim d As New OpenFileDialog
        With d
            '.InitialDirectory = foundDirectory
            .Title = "Find me a file, bb"
            .Filter = "Cute files (*.txt)|*.txt"
        End With
        d.ShowDialog()
        If d.FileName <> "" Then BBXDdata = My.Computer.FileSystem.ReadAllText(d.FileName)
    End Sub

    Sub BreakTextIntoLetters()
        Dim tempString As String = ""
        tempString = WholeTextTransform(FormBBXD.TextBoxVanilla.Text)
        listOfWords = Split(tempString, " ")
        For masterIndex = 0 To UBound(listOfWords)
            If listOfWords(masterIndex) <> "" Then
                FormBBXD.RichTextBoxBB.SelectionColor = Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255)
                FormBBXD.RichTextBoxBB.AppendText(V2B(listOfWords(masterIndex)) & " ")
            End If
        Next
    End Sub
    Function WholeTextTransform(str As String) As String 'Gets rid of capitals and punctuation (other than ".")
        str = str.Replace(",", "")
        str = str.Replace(";", "")
        str = str.Replace("'", "")
        str = str.Replace("-", "~")
        str = str.Replace(vbNewLine, " ")
        str = LCase(str)
        Return str
    End Function
    Function RandomCapitalize(word As String)
        Dim letter As Char
        Dim buildWord As String = ""
        If Rnd() < 0.05 Then Return UCase(word)
        For i = 1 To Len(word)
            letter = Mid(word, i, 1)
            If Rnd() < 0.2 Then letter = UCase(letter)
            buildWord += letter
        Next
        Return buildWord
    End Function
    Sub AddToHashtagList(str As String, spot As Integer)
        str = str.Replace(" ", "")
        hashTag(spot) = str
    End Sub
    Function FinalizeHashtag() As String
        Dim i As Integer
        Dim str As String = ""
        For i = 0 To UBound(hashTag)
            str = str & hashTag(i)
        Next
        Return ""
    End Function
    Function V2B(vWord As String) As String
        Dim bWord As String = ""
        Dim addPeriodAtEndOfWord As Boolean = False
        Dim spacesInWord, j As Integer
        Dim shouldContinue As Boolean = True
        Dim vanilla_WWS() As String

        If Right(vWord, 1) = "." Then
            addPeriodAtEndOfWord = True
            vWord = Left(vWord, Len(vWord) - 1)
        End If

        'THIS DOES THE REPLACEMENTS!!! ---------------------------the whole program lies here---------------------------
        For i = 0 To UBound(vanilla_WordArr)
            j = 0
            If Not wholeWord_WordArr(i) Then
                If InStr(vanilla_WordArr(i), " ") <> 0 Then
                    spacesInWord = CountSubstringInString(vanilla_WordArr(i), " ")
                    vanilla_WWS = Split(vanilla_WordArr(i), " ")
                    Do While spacesInWord >= 0
                        If vanilla_WWS(j) = listOfWords(masterIndex + j) Then
                            spacesInWord -= 1
                            j += 1
                        Else
                            shouldContinue = False
                            Exit Do
                        End If
                    Loop
                    If shouldContinue Then
                        spacesInWord = j - 1
                        If Rnd() < CDbl(chanceOf_WordArr(i)) Then
                            bWord = BBXD_WordArr(i)
                            For j = 0 To spacesInWord
                                listOfWords(masterIndex + j) = ""
                            Next
                            listOfWords(masterIndex) = bWord
                        End If
                    Else
                        shouldContinue = True
                    End If
                Else
                    If InStr(vWord, vanilla_WordArr(i)) <> 0 Then
                        If Rnd() < CDbl(chanceOf_WordArr(i)) Then
                            bWord = vWord.Replace(vanilla_WordArr(i), BBXD_WordArr(i))
                            Exit For
                        End If
                    End If
                    If vanilla_WordArr(i) = vWord Then
                        If Rnd() < CDbl(chanceOf_WordArr(i)) Then
                            bWord = BBXD_WordArr(i)
                            Exit For
                        End If
                    End If
                End If
            End If
        Next
        If bWord = "" Then bWord = vWord
        bWord = RandomCapitalize(bWord)
        If addPeriodAtEndOfWord Then
            bWord = AddFooter(bWord, True)
        End If
        Return bWord
    End Function
    Sub RemoveWordFromVanilla_WordArr(spot As Integer)


    End Sub
    Function CountSubstringInString(input As String, searchFor As String) As Integer
        Try
            Return input.Split(searchFor).Length - 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function AddFooter(tempString As String, addPeriod As Boolean) As String
        Dim period As String = ""
        If addPeriod Then period = "."
        Return tempString & " " & footers(Int(Rnd() * UBound(footers)) & period)
    End Function
    Sub DatabaseToArray(db As String)
        Dim Lines(), tmpArr(4) As String
        Dim begin_top, footers_top As Integer
        isDatabaseReady = False
        BBXDdata = db.Replace(", ", "|")
        Lines = Split(BBXDdata, Chr(10))
        If UBound(Lines) < 2 Then Lines = Split(BBXDdata, Chr(12))

        'Locate BEGIN and FOOTER statements
        For i = 0 To UBound(Lines)
            If UCase(Lines(i)) Like "@@BEGIN*" Then
                begin_top = i
            End If
            If UCase(Lines(i)) Like "@@FOOTER*" Then
                footers_top = i
            End If
        Next
        If footers_top = 0 Or begin_top = 0 Then
            MsgBox("It seems that your database is missing the key '@@BEGIN' " &
                   "and/or '@@FOOTER' statements. " &
                   "Place them as headers above their data and try again.", MsgBoxStyle.Critical
            )
            Exit Sub
        End If

        'Set arr length to size of lines between begin and footer
        ReDim vanilla_WordArr(footers_top - begin_top)
        ReDim BBXD_WordArr(footers_top - begin_top)
        ReDim chanceOf_WordArr(footers_top - begin_top)
        ReDim wholeWord_WordArr(footers_top - begin_top)

        'Set footer to number of footers
        ReDim footers(UBound(Lines) - footers_top)

        'Adds main and footers to their arrays
        For i = 0 To UBound(Lines)
            If Left(Lines(i), 2) <> "//" And Left(Lines(i), 2) <> "@@" And Lines(i) <> "" And Lines(i) <> vbCr Then
                If i < footers_top Then
                    tmpArr = Split(Lines(i), "|", 4)
                    vanilla_WordArr(i - (begin_top + 1)) = tmpArr(0)
                    BBXD_WordArr(i - (begin_top + 1)) = tmpArr(1)
                    chanceOf_WordArr(i - (begin_top + 1)) = tmpArr(2)

                    'If line contains a ",t" then wholeword = true
                    If UBound(tmpArr) = 3 Then
                        If tmpArr(3) = "t" Then : wholeWord_WordArr(i - (begin_top + 1)) = True
                        Else : wholeWord_WordArr(i - (begin_top + 1)) = False : End If
                    End If
                Else
                    footers(i - footers_top) = Lines(i)
                End If
            End If
        Next
        isDatabaseReady = True
    End Sub
End Module
