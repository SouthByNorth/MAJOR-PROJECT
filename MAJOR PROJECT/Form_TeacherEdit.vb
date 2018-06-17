Imports System.IO
Imports System.Drawing.Printing

Public Class Form_TeacherEdit

    Dim word As List(Of String) = New List(Of String)
    Dim texts As String
    Dim FileReader As String

    'Stuff for printing
    Private printFont As Font




    Private Sub BTNLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNLoad.Click
        'FileReader = My.Computer.FileSystem.ReadAllText("c:\Users\rpren\Documents\ClozeTextFiles\Simple.txt")

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
            Me.LBRemove.Items.Add(thisWord)
        End If

    End Sub

    Private Sub LBremove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBRemove.DoubleClick
        Dim myListBox As ListBox = CType(sender, ListBox)
        Dim selectedIndex As Integer = myListBox.SelectedIndex
        myListBox.Items.RemoveAt(selectedIndex)
    End Sub

    Private Sub Form_TeacherEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''allows a bypass of the repettitive load for tests
        'Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple.txt"
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


        ' Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple1.txt"

        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            'Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple1.txt"
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
        Dim preview As New ClozeText()
        preview.MainText = RichTextBox1.Text
        For Each selection As String In LBRemove.Items
            preview.Selections.Add(selection)
        Next

        'Get the form to display the teacher entry by passing in the ClozeText object
        Form_StudentWord.DisplayClozeText(preview)

        Form_StudentWord.ShowDialog()

    End Sub

    Private Sub BTNprint_Click(sender As Object, e As EventArgs) Handles BTNprint.Click
        'PrintDialog1.ShowDialog()
        Dim textToPrint As String = RichTextBox1.Text.spilt(vbLf.ToString)

        If RichTextBox1.Text = "" Then
            MsgBox("You need to enter some text")
        Else

            'Build up a PrintDocument and then pass it to the Preview Dialog
            Dim pd As PrintDocument = New PrintDocument()
            printFont = New Font("Arial", 14)

            AddHandler pd.PrintPage, AddressOf Me.PrintPageHandler
            pd.DocumentName = "My Cloze Text"

            ' pd.Print()
            'Tell the Preview about the printDocument
            PrintPreviewDialog1.Document = pd
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As PrintPageEventArgs)
        'this is where we draw each page to print
        Console.WriteLine("PrintPageHandler")

        ' Create pen.
        Dim blackPen As New Pen(Color.Black, 3)

        ' Create points that define line.
        Dim point1 As New Point(100, 100)
        Dim point2 As New Point(500, 100)

        ' Draw line to screen.
        args.Graphics.DrawLine(blackPen, point1, point2)

        'We need to break up the Cloze Text and add to the print document word by word
        'The FLowPanel managed formatting on the UI - we need to do it ourselves here

        'Follow similar process as before, but more compliated
        ' Calculate the number of lines per page.
        Dim linesPerPage As Integer = args.MarginBounds.Height / printFont.GetHeight(args.Graphics)
        Dim linesOnThisPage As Integer = 0
        Dim xPos As Integer = 0
        Dim yPos As Integer = 0

        'textbox uses Lf to do a new line
        Dim paragraphs() As String = 

        For Each paragraph As String In paragraphs

            Dim words() As String = paragraph.Split(" ".ToCharArray)
            For Each word As String In words
                'remember , we need to clean punctuation
                Dim cleanWord As String = word.Trim(".,;!".ToCharArray)

                'we write the word to the page, but, before we can write it, we need to see if there is enough space left on this line.
                'get the size of the word were abouyt to write
                Dim stringSize As SizeF = args.Graphics.MeasureString(cleanWord, printFont)
                If (xPos + stringSize.Width < args.MarginBounds.Right) Then
                    'easy we just write the word
                Else
                    'we have run out of space on this line, so we will move to the next line
                    xPos = 0


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

                xPos += stringSize.Width
            Next 'word
            'have we decided we can't write any more to this page
            If args.HasMorePages = True Then
                Exit For
            End If


            'at the end of a paragraph we need reset xPos + yPoss increaments
            xPos = 0

            'we want to go down the page for a paragraph, but it there room?
            yPos += 25

        Next 'paragraph


    End Sub

End Class