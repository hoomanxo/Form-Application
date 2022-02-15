Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles WindowName.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        Dim NewWindow As New PopupForm(WindowName.Text)
        NewWindow.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
