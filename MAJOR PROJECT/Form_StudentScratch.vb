Public Class Form_StudentScratch

    Dim count As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myLabel As Label = New Label
        myLabel.Text = "Click:" + count.ToString
        myLabel.AutoSize = True
        'myLabel.Height = 12
        myLabel.TextAlign = ContentAlignment.BottomCenter


        count = count + 3

        FlowLayoutPanel1.Controls.Add(myLabel)

        Label3.Text = FlowLayoutPanel1.Controls.Count


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Create a textbox, set the text value
        Dim myTextBox As New TextBox
        myTextBox.Text = "Show" + count.ToString
        count += 1

        'now add the control to the flow panel
        FlowLayoutPanel1.Controls.Add(myTextBox)
    End Sub
End Class
