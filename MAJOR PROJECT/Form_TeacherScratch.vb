Public Class Form_TeacherScratch

    Dim word As List(Of String) = New List(Of String)


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick

        'we have a double click event, let's see what words have been selected
        Dim myTextBox As TextBox = CType(sender, TextBox)
        Dim thisWord As String = myTextBox.SelectedText

        'AVoid adding duplicates
        If (Not (ListBox1.Items.Contains(thisWord))) Then
            Me.ListBox1.Items.Add(thisWord)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim myListBox As ListBox = CType(sender, ListBox)
        Dim selectedIndex As Integer = myListBox.SelectedIndex
        myListBox.Items.RemoveAt(selectedIndex)

    End Sub
End Class