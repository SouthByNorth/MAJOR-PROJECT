Imports System.IO
Imports System.Drawing.Printing

Public Class Form_TeacherEdit

    Dim word As List(Of String) = New List(Of String)
    Dim texts As String
    Dim FileReader As String
    Dim clozeTextToPrint As ClozeText 'use this to manage the production of multiple print pages 
    Dim pageCount As Integer = 0

    'Stuff for printing
    Private printFont As Font




    Private Sub BTNLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNLoad.Click

        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\Users\rpren\Documents\ClozeTextFiles\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Loadfile(openFileDialog1.FileName)
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.DoubleClick

        'we have a double click event, let's see what words have been selected
        Dim thisWord As String = RichTextBox1.SelectedText.Trim(" ")

        'Avoid adding duplicates
        If (Not (LBRemove.Items.Contains(thisWord))) Then
            LBRemove.Items.Add(thisWord)
        End If

    End Sub

    Private Sub LBremove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBRemove.DoubleClick
        Dim myListBox As ListBox = CType(sender, ListBox)
        Dim selectedIndex As Integer = myListBox.SelectedIndex
        myListBox.Items.RemoveAt(selectedIndex)
    End Sub

    Private Sub Form_TeacherEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        'allows a bypass of the repettitive load for tests
        Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Winston Smith Big.txt"
        Loadfile(fileName)
    End Sub


    Private Sub Loadfile(fileName As String)
        'read the file to our dat structure, then transferr to the ui
        Dim closeText As ClozeText = ClozeText.ReadClozeText(fileName)

        'load controls, clear any earlier items
        RichTextBox1.Text = closeText.MainText
        LBRemove.Items.Clear()
        LBRemove.Items.AddRange(closeText.Selections.ToArray)

    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        'e.Graphics.DrawString()
    End Sub

    Private Sub BTNsave_Click(sender As Object, e As EventArgs) Handles BTNsave.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim fileName As String = saveFileDialog1.FileName

            ' get rid of file if already exosts 
            If File.Exists(fileName) Then
                File.Delete(fileName)
            End If

            Dim fileWrite As System.IO.StreamWriter

            fileWrite = My.Computer.FileSystem.OpenTextFileWriter(fileName, True)
            fileWrite.WriteLine(RichTextBox1.Text)
            fileWrite.WriteLine(ClozeText.SEPERATOR)

            For Each item As String In LBRemove.Items
                fileWrite.WriteLine(item)
            Next

            fileWrite.Close()
        End If

    End Sub

    Private Sub BTNpreview_Click(sender As Object, e As EventArgs) Handles BTNpreview.Click

        'to preview, open student form and disqablwe the controls, 
        'set the form up before we show it
        Form_StudentWord.BtnFilePick.Enabled = False
        Form_StudentWord.BTNSubmit.Enabled = False

        'we need to create a ClozeText object and pass this to the student form
        'the  Student form reads from a file and gets vbCrLf, but the RichTextBox gives is vbLf
        'so we will replace them

        Dim preview As New ClozeText()
        preview.MainText = RichTextBox1.Text
        preview.MainText = Strings.Replace(preview.MainText, vbLf, vbCrLf)
        For Each selection As String In LBRemove.Items
            preview.Selections.Add(selection)
        Next

        'Get the form to display the teacher entry by passing in the ClozeText object
        Form_StudentWord.DisplayClozeText(preview)

        Form_StudentWord.ShowDialog()

    End Sub

    Private Sub BTNprint_Click(sender As Object, e As EventArgs) Handles BTNprint.Click
        'cliocking the print button prepares a PrintDocument,
        'we have a seperate handler to construct each page
        PrintDialog1.ShowDialog()

        clozeTextToPrint = New ClozeText()
        clozeTextToPrint.MainText = RichTextBox1.Text

        For Each item As String In LBRemove.Items
            clozeTextToPrint.Selections.Add(item)
        Next

        If RichTextBox1.Text = "" Then
            MsgBox("You need to enter some text")
        Else

            'Build up a PrintDocument and then pass it to the Preview Dialog
            Dim pd As PrintDocument = New PrintDocument()
            printFont = New Font("Arial", 14)

            AddHandler pd.PrintPage, AddressOf Me.PrintPageHandler
            pd.DocumentName = "My Cloze Text"


            'Tell the Preview about the printDocument
            PrintPreviewDialog1.Document = pd
            PrintPreviewDialog1.ShowDialog()
            'pd.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As PrintPageEventArgs)
        'this is where we draw each page to print, we keep a counter for pages
        pageCount += 1


        ' Calculate the number of lines per page, page position and a pen.
        Dim linesPerPage As Integer = args.MarginBounds.Height / printFont.GetHeight(args.Graphics)
        Dim linesOnThisPage As Integer = 0
        Dim xPos As Integer = args.MarginBounds.Left
        Dim yPos As Integer = args.MarginBounds.Top
        Dim blackPen As New Pen(Color.Black, 2)

        'if this is our first page then we have the Name and Date for the student
        If pageCount < 2 Then
            'lets but a heading in, we find outthe sixze of the words names and date 
            Dim nameSize As SizeF = args.Graphics.MeasureString("Name", printFont)
            Dim dateSize As SizeF = args.Graphics.MeasureString("Date", printFont)
            'calculate the mid point of the [page, date goes here
            Dim xMid As Integer = ((args.MarginBounds.Right - args.MarginBounds.Left) / 2) + args.MarginBounds.Left

            'Name goes on the left, Date goes half way across the page
            args.Graphics.DrawString("Name:", printFont, Brushes.Black, xPos, yPos, New StringFormat())
            args.Graphics.DrawString("Date:", printFont, Brushes.Black, xMid, yPos, New StringFormat())

            'draw lines between the words
            Dim nameLineStart As New Point(nameSize.Width + args.MarginBounds.Left, yPos + nameSize.Height)
            Dim nameLineEnd As New Point(xMid, yPos + nameSize.Height)
            args.Graphics.DrawLine(blackPen, nameLineStart, nameLineEnd)

            Dim dateLineStart As New Point(nameSize.Width + xMid, yPos + dateSize.Height)
            Dim dateLineEnd As New Point(args.MarginBounds.Right, yPos + dateSize.Height)
            args.Graphics.DrawLine(blackPen, dateLineStart, dateLineEnd)

            yPos += 50
        End If

        'We need to break up the Cloze Text and add to the print document word by word
        'The FLowPanel managed formatting on the UI - we need to do it ourselves here
        'Follow similar process as before, but more compliated

        'textbox uses Lf to do a new line
        Dim paragraphs() As String = clozeTextToPrint.MainText.Split(vbLf)

        For Each paragraph As String In paragraphs

            Dim words() As String = paragraph.Split(" ".ToCharArray)
            For Each word As String In words
                'remember , we need to clean punctuation
                Dim cleanWord As String = word.Trim(".,;!".ToCharArray)

                'we write the word to the page, but, before we can write it, we need to see if there is enough space left on this line.
                'get the size of the word were abouyt to write
                Dim stringSize As SizeF = args.Graphics.MeasureString(word, printFont)
                If (xPos + stringSize.Width < args.MarginBounds.Right) Then
                    'easy we just write the word
                Else
                    'we have run out of space on this line, so we will move to the next line
                    xPos = args.MarginBounds.Left


                    'Is there any more space on the page for use to continue?
                    If yPos + stringSize.Height < args.MarginBounds.Bottom Then
                        'yes we can, so carry on
                        yPos = yPos + stringSize.Height
                    Else
                        'there is no more space on the page, we have to stop now....
                        args.HasMorePages = True
                        Exit For
                    End If
                End If

                If LBRemove.Items.Contains(cleanWord) Then
                    'this is word to show as a blank space
                    Dim rectangle As New Rectangle(xPos, yPos, stringSize.Width, stringSize.Height)
                    args.Graphics.DrawRectangle(blackPen, rectangle)
                Else
                    'Now write the word at xPos yPos
                    args.Graphics.DrawString(cleanWord, printFont, Brushes.Black, xPos, yPos, New StringFormat())
                End If

                'Do we have any punctuation to add?
                'we trimmed off puntuation do we need to add it again?
                If Not (word.Equals(cleanWord)) Then
                    'theres a difference between the word and what was printed, so we recover the punctaution 
                    Dim punctuation As String = Strings.Mid(word, word.Length)
                    Dim punctuationSize As SizeF = args.Graphics.MeasureString(punctuation, printFont)
                    args.Graphics.DrawString(punctuation, printFont, Brushes.Black, xPos + stringSize.Width, yPos, New StringFormat())
                    xPos += punctuationSize.Width

                End If


                xPos += stringSize.Width
                'we know we have written this word so we can delete it from the string textToPrint
                Dim wordLength As Integer = word.Length
                clozeTextToPrint.MainText = Strings.Mid(clozeTextToPrint.MainText, wordLength + 2)

            Next 'word
            'have we decided we can't write any more to this page
            If args.HasMorePages = True Then
                Exit For
            End If


            'at the end of a paragraph we need reset xPos + yPoss increaments
            xPos = args.MarginBounds.Left
            'we want to go down the page for a paragraph, but it there room?
            yPos += 25

        Next 'paragraph

        'finished writing the close text paragraphs, so we will print the selected words to be filled in. 
        ' and we want a seperated line to show the spilt between 

        'we only show the line if there is no more text to show
        If (clozeTextToPrint.MainText.Length = 0) Then
            ' Create points that define line.
            Dim point1 As New Point(args.MarginBounds.Left, yPos)
            Dim point2 As New Point(args.MarginBounds.Right, yPos)

            ' Draw line to screen.
            args.Graphics.DrawLine(blackPen, point1, point2)
        End If

        ' now to do the selected words 
        'we are going to send them across the page. 
        'only start printing the selection if there is space on the page
        'HasMorePages == True If we have hit the bottom Of the page
        If (args.HasMorePages <> True) Then
            'we still have some space on the page, but do we have enough to start the selections
            'We want at least 40 points left, otherwise - get a new page
            If (yPos + 50 > args.MarginBounds.Bottom) Then
                ' we dont have space
                args.HasMorePages = True
            Else

                'we have have atleast 40 point so we can satrt to write in the selected words 
                yPos += 15
                For Each selectedWord As String In clozeTextToPrint.Selections
                    'how big is this word going to be?
                    Dim stringSize As SizeF = args.Graphics.MeasureString(selectedWord, printFont)
                    ' havw we got the sapce to put the word and some trailing space on the line?
                    If (xPos + stringSize.Width + 10 < args.MarginBounds.Right) Then
                        ' we just wrote the word 
                    Else
                        ' we have run put of space so we move on to the next line. 
                        xPos = args.MarginBounds.Left
                        'Is there any more space on the page for use to continue?
                        If yPos + stringSize.Height < args.MarginBounds.Bottom Then
                            'yes we can, so carry on
                            yPos = yPos + stringSize.Height
                        Else
                            'there is no more space on the page, we have to stop now....
                            args.HasMorePages = True
                            Exit For
                        End If
                    End If

                    ' we know where to put the word so we print it now 
                    args.Graphics.DrawString(selectedWord, printFont, Brushes.Black, xPos, yPos, New StringFormat())

                    Dim rectangle As New Rectangle(xPos, yPos, stringSize.Width, stringSize.Height)
                    args.Graphics.DrawRectangle(blackPen, rectangle)


                    xPos += stringSize.Width + 10
                Next
            End If
        End If
    End Sub

End Class