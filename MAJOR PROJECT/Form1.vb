Public Class FormLanding
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNTeachLoad.Click

        Form_SignIn.Show()
        Me.Visible = False

    End Sub

    Private Sub BTNStudentLoad_Click(sender As Object, e As EventArgs) Handles BTNStudentLoad.Click

        Form_StudentScratch.Show()
        Me.Visible = False


    End Sub


End Class