Imports System.IO

Public Class Form_TeacherEdit

    Dim word As List(Of String) = New List(Of String)
    Dim texts As String
    Dim FileReader As String

    Const SEPERATOR As String = "}"

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
        Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple.txt"
        Loadfile(fileName)

    End Sub

    Private Sub Loadfile(fileName As String)
        Dim myStreamReader = New StreamReader(fileName)
        If (myStreamReader IsNot Nothing) Then
            'Read the file content to a holding string
            Dim fileContents As String = myStreamReader.ReadToEnd
            'Split the file by our special seperator to break the CLOZE test from the selections
            Dim splits() As String = fileContents.Split(SEPERATOR.ToCharArray)
            Dim mainText As String = splits(0)
            Dim selections As String = splits(1)

            'write main text to ui
            RichTextBox1.Text = mainText


            'convert the selection string to a list of items
            Dim items As String() = selections.Split(vbCrLf)

            For Each item As String In items
                'item = item.TrimStart(vbLf.ToCharArray)
                item = Strings.Mid(item, 2)
                If item.Length > 0 Then
                    LBRemove.Items.Add(item)
                End If

            Next


            '   LBRemove.Items.AddRange(items)
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim ont As New Font("Arial", 16, FontStyle.Regular)
        'e.Graphics.DrawString()
    End Sub

    Private Sub BTNsave_Click(sender As Object, e As EventArgs) Handles BTNsave.Click


        Dim fileName As String = "C:\Users\rpren\Documents\ClozeTextFiles\Simple1.txt"

        ' get rid of file if already exosts 
        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If


        Dim fileWrite As System.IO.StreamWriter

        fileWrite = My.Computer.FileSystem.OpenTextFileWriter(fileName, True)
        fileWrite.WriteLine(RichTextBox1.Text)
        fileWrite.WriteLine(SEPERATOR)

        For Each item As String In LBRemove.Items

            fileWrite.WriteLine(item)
        Next


        fileWrite.Close()

    End Sub
End Class