Public Class PopupForm
    Public Sub New(ByVal text As String)


        InitializeComponent()
        NameLabel.Text = text
        MyBase.Text = text


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub PopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class