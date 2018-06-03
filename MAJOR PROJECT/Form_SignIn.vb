Public Class Form_SignIn


    Dim CorrectUser As String = "check"
    Dim CorrectPass As String = "check"
    ' () change this in future for a file to contian the allowed user name 

    Private Sub BTNcheck_Click(sender As Object, e As EventArgs) Handles BTNcheck.Click

        If CorrectUser = TBusername.Text And CorrectPass = TBpassword.Text Then
            Form_TeacherScratch.Show()
            Me.Visible = False

        ElseIf CorrectUser <> TBusername.Text Then
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Black

        ElseIf CorrectPass <> TBpassword.Text Then
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Red

        ElseIf CorrectUser <> TBusername.Text And CorrectPass <> TBpassword.Text Then
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
        End If

    End Sub
End Class