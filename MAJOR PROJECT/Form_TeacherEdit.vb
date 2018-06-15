Imports System.IO


Public Class Form_TeacherEdit

    Dim word As List(Of String) = New List(Of String)
    Dim text As String
    Dim FileReader As String

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
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.

                End If
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

        Dim thisWord As String = RichTextBox1.SelectedText

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

    Private Sub BTNprint_Click(sender As Object, e As EventArgs) Handles BTNprint.Click




    End Sub
End Class

