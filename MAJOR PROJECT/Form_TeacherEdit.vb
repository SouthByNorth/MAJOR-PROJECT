
Public Class Form_TeacherEdit

    Dim word As List(Of String) = New List(Of String)
    Dim text As String

    Private Sub BTNLoad_Click(sender As Object, e As EventArgs) Handles BTNLoad.Click



    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.DoubleClick

        'we have a double click event, let's see what words have been selected
        Dim myTextBox As TextBox = CType(sender, TextBox)
        Dim thisWord As String = myTextBox.SelectedText

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
End Class