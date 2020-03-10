Public Class Form4
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class