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
        Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple1.txt"
        Loadfile(fileName)
    End Sub

    Private Sub Loadfile(fileName As String)

        'read the file to our dat structure, then transferr to the ui
        closeText = ClozeText.ReadClozeText(fileName)

        'we need to remember the source so we can construct the result 
        SourceFilePath = fileName

        ' loop through eah word in maintext, add either a label of a text box depending on the selections

        Dim words() As String = closeText.MainText.Split(" ".ToCharArray)
        For Each word As String In words

            If closeText.Selections.Contains(word) Then
                'this is a selected word, so we will create a text box, with length for the word
                Dim myTextBox As TextBox = New TextBox
                'we don't show the word, but we use the Tag to hold it for a compare later
                myTextBox.Tag = word

                FlowLayoutPanel1.Controls.Add(myTextBox)

            Else
                'we just put in a label, which cannopt be modified
                Dim myLabel As Label = New Label
                myLabel.Text = word
                myLabel.AutoSize = True

                FlowLayoutPanel1.Controls.Add(myLabel)


            End If

            ' add text box for eachselected word 


        Next

        ' adding selection items to user interface
        ListBox1.Items.AddRange(closeText.Selections.ToArray)


    End Sub

    Private Sub BTNSubmit_Click(sender As Object, e As EventArgs) Handles BTNSubmit.Click
        ' we add one to the counter, sve results and update interface 
        count += 1

        SaveResult()


    End Sub

    Private Sub SaveResult()

        'constructing file name 
        Dim resultPath As String = "C:\Users\rpren\Documents\ClozeTextFiles\Result\"
        Dim s As String = SourceFilePath
        'pick up the filename of our source
        Dim sourceFileName As String = Path.GetFileName(SourceFilePath)

        Dim parts() As String = sourceFileName.Split(".".ToCharArray)
        Dim fileNameBody As String = parts(0)

        ' buidld the file name to save to 

        Dim targetFileName As String = fileNameBody & "_" & UserName & "_" & count


        targetFileName = resultPath & targetFileName


        ' get rid of file if already exosts 
        If File.Exists(targetFileName) Then
            File.Delete(targetFileName)
        End If


        Dim fileWrite As System.IO.StreamWriter

        fileWrite = My.Computer.FileSystem.OpenTextFileWriter(targetFileName, True)
        fileWrite.WriteLine(closeText.MainText)
        fileWrite.WriteLine(ClozeText.SEPERATOR)


        For Each item As String In closeText.Selections

            fileWrite.WriteLine(item)
        Next


        fileWrite.Close()


    End Sub
    Private Sub ShowResults()





    End Sub


End Class