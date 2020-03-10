Public Class Form1

    Dim x As String
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        x = TextBox1.Text

        If x = "Username" Then
            TextBox1.Clear()
        End If

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        x = TextBox1.Text

        If TextBox1.Text = "" Or TextBox1.Text = " " Then
            TextBox1.Text = "Username"
            TextBox1.ForeColor = Color.Gray
        Else
            TextBox1.Text = x
            TextBox1.ForeColor = Color.Black
        End If

    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        x = TextBox3.Text

        If x = "Password" Then
            TextBox3.Clear()
        End If

    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        x = TextBox3.Text

        If TextBox3.Text = "" Or TextBox3.Text = " " Then
            TextBox3.Text = "Password"
            TextBox3.ForeColor = Color.Gray
        Else
            TextBox3.Text = x
            TextBox3.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim u, p As String
        u = TextBox1.Text
        p = TextBox3.Text

        If u = "" Or u = " " Or u = "Username" Or p = "" Or p = " " Or p = "Password" Then
            Label1.Visible = True
        Else
            Label1.Visible = False
            Me.Hide()
            Form2.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        x = TextBox1.Text

        If x = "Username" Then
            TextBox1.ForeColor = Color.Gray
        Else
            TextBox1.ForeColor = Color.Black
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        Dim pass As String
        pass = TextBox3.Text

        If pass = "Password" Then
            TextBox3.ForeColor = Color.Gray
        Else
            TextBox3.ForeColor = Color.Black
        End If

    End Sub
End Class
