Imports System.IO

Public Class Form_StudentWord

    Public UserName As String = "Rebecca"

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
        Dim closeText As ClozeText = ClozeText.ReadClozeText(fileName)

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

        Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple1.txt"

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


    End Sub
End Class