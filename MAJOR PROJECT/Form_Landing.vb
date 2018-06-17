Public Class FormLanding
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNTeachLoad.Click

        'Pass in the user name
        Form_SignIn.TBusername.Text = TextBox_UserName.Text
        Form_SignIn.ShowDialog()

    End Sub

    Private Sub BTNStudentLoad_Click(sender As Object, e As EventArgs) Handles BTNStudentLoad.Click

        Form_StudentWord.UserName = TextBox_UserName.Text
        Form_StudentWord.ShowDialog()



    End Sub

    Private Sub FormLanding_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class