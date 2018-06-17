Imports System.IO

Public Class Form_StudentWord
    Dim closeText As ClozeText
    Public UserName As String = "Rebecca"

    'we need to remeber the file the user is working on 
    Public SourceFilePath As String

    'We need a counter to show the attempst of the tests
    Dim count As Integer = 0

    Private Sub BtnFilePick_Click(sender As Object, e As EventArgs) Handles BtnFilePick.Click

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

    Private Sub Form_StudentWord_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple1.txt"
        Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Winston Smith.txt"
        Loadfile(fileName)
    End Sub

    Private Sub Loadfile(fileName As String)

        'read the file to our data structure, then transferr to the ui
        closeText = ClozeText.ReadClozeText(fileName)

        'we need to remember the source so we can construct the result 
        SourceFilePath = fileName

        'clear the ui - the Panel_ClozeText holds a collection of FlowLayoutPanels, one for each paragraph
        FlowLayoutPanel1.Controls.Clear()
        ListBox1.Items.Clear()

        ' loop through each word in maintext, add either a label of a text box depending on the selections

        'to keep format we break into paragraphs, vbCrLF gives the split
        Dim paragraphs() As String = closeText.MainText.Split(vbCrLf)

        For Each paragraph As String In paragraphs
            'loop through the words in the paragraph

            Dim words() As String = paragraph.Split(" ".ToCharArray)
            For Each word As String In words

                'punctuation is a problem, selected words with commas dont get matched woth the selection 
                'clean up words that are adjacent to puntuaction 
                Dim cleanWord As String = word.Trim(".,;!".ToCharArray)



                If closeText.Selections.Contains(cleanWord) Then
                    'this is a selected word, so we will create a text box
                    Dim myTextBox As TextBox = New TextBox
                    'we don't show the word, but we use the Tag to hold it for a compare later
                    myTextBox.Tag = cleanWord
                    FlowLayoutPanel1.Controls.Add(myTextBox)

                    'we trimmed off puntuation do we need to add it again?
                    If Not (word.Equals(cleanWord)) Then
                        'theres a difference between the word and what is in the textbox, so we recover the puntaution 
                        Dim myLabel As Label = New Label
                        myLabel.Text = Strings.Mid(word, word.Length)

                        myLabel.Height = 20
                        myLabel.Width = myLabel.PreferredWidth
                        myLabel.TextAlign = ContentAlignment.BottomLeft
                        FlowLayoutPanel1.Controls.Add(myLabel)
                    End If

                Else
                    'we just put in a label, which cannopt be modified
                    Dim myLabel As Label = New Label
                    myLabel.Text = word
                    myLabel.Height = 20
                    myLabel.Width = myLabel.PreferredWidth
                    myLabel.TextAlign = ContentAlignment.BottomLeft
                    FlowLayoutPanel1.Controls.Add(myLabel)
                End If
            Next
            'the is the end of the paragraph, so we need a break for the flow layout

            'get the last control we added to the flow panel and set the flow break property 
            Dim lastControlIndex As Integer = FlowLayoutPanel1.Controls.Count - 1
            Dim lastControl As Control = FlowLayoutPanel1.Controls.Item(lastControlIndex)

            FlowLayoutPanel1.SetFlowBreak(lastControl, True)



        Next

        ' adding selection items to user interface
        ListBox1.Items.AddRange(closeText.Selections.ToArray)


    End Sub

    Private Sub BTNSubmit_Click(sender As Object, e As EventArgs) Handles BTNSubmit.Click
        ' we add one to the counter, sve results and update interface 
        count += 1

        SaveResult()
        ShowResults()

    End Sub

    Private Sub SaveResult()

        'constructing file name 
        Dim resultPath As String = "C:\Users\rpren\Documents\ClozeTextFiles\Result\"
        Dim s As String = SourceFilePath
        'pick up the filename of our source
        Dim sourceFileName As String = Path.GetFileName(SourceFilePath)

        Dim parts() As String = sourceFileName.Split(".".ToCharArray)
        Dim fileNameBody As String = parts(0)

        ' buidld the file name to save to, mix with the path
        'file name is original file, username and a counter
        Dim resultFileName As String = fileNameBody & "_" & UserName & "_" & count
        resultFileName = resultPath & resultFileName & ".txt"

        ' get rid of file if already exosts 
        If File.Exists(resultFileName) Then
            File.Delete(resultFileName)
        End If

        'Write the results file
        Dim fileWrite As System.IO.StreamWriter
        fileWrite = My.Computer.FileSystem.OpenTextFileWriter(resultFileName, True)
        'Main text comes first, then our seperator
        fileWrite.WriteLine(closeText.MainText)
        fileWrite.WriteLine(ClozeText.SEPERATOR)

        'then it's the selection items, 1 each line
        For Each item As String In closeText.Selections
            fileWrite.WriteLine(item)
        Next
        'then another seperator and the user's entry
        fileWrite.WriteLine(ClozeText.SEPERATOR)

        'loop through the textbox controls and add each word to a new line 
        For Each control As Control In FlowLayoutPanel1.Controls
            'the flow panel has Labels and TextBoxes, we need to pick up the TextBox
            'got some help off internet here..
            Dim textBox As TextBox = TryCast(control, TextBox)
            If textBox IsNot Nothing Then
                'this is a textbox in the flow panel, pick up whsat the user entered
                'and write it to file with what it should be...
                Dim result As String = textBox.Tag & "=>" & textBox.Text
                fileWrite.WriteLine(result)
            End If
        Next

        'file needs closing
        fileWrite.Close()


    End Sub
    Private Sub ShowResults()

        'checking each textbox against the correct valcue of the word 

        For Each control As Control In FlowLayoutPanel1.Controls
            'the flow panel has Labels and TextBoxes, we need to pick up the TextBox
            'got some help off internet here..
            Dim textBox As TextBox = TryCast(control, TextBox)
            If textBox IsNot Nothing Then
                'this is a textbox in the flow panel, we are comapring whast entered to what it should be 
                If textBox.Tag.Equals(textBox.Text.Trim(" ".ToCharArray)) Then

                    textBox.BackColor = Color.LightGreen

                Else
                    textBox.BackColor = Color.LightPink



                End If
            End If
        Next


    End Sub


End Class