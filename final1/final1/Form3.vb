Public Class Form3

    Dim n_items As Integer
    Dim preco_total As Double
    Dim n_pag As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
        Me.CenterToScreen()
        n_items = 0
        Label34.Text = "Bem vindo " & Form1.TextBox1.Text & "!"
        If Panelnovidades.Visible = True Then
            Panel2.Visible = True
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Indigo
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Indigo
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Indigo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelPedir.Visible = False
        Panelnovidades.Visible = True
        PanelCidades.Visible = False
        PanelPedir2.Visible = False
        PanelCarrinho.Visible = False

        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n_pag = 1

        If n_pag = 1 Then
            Button13.BackColor = Color.Indigo
            Button13.ForeColor = Color.White
            Button14.BackColor = Color.White
            Button14.ForeColor = Color.Black
        ElseIf n_pag = 2 Then
            Button14.BackColor = Color.Indigo
            Button14.ForeColor = Color.White
            Button13.BackColor = Color.White
            Button13.ForeColor = Color.Black
        End If

        Panelnovidades.Visible = False
        PanelPedir.Visible = True
        PanelCidades.Visible = False
        PanelCarrinho.Visible = False

        Panel3.Visible = True
        Panel2.Visible = False
        Panel4.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelCidades.Visible = True
        Panelnovidades.Visible = False
        PanelPedir.Visible = False
        PanelPedir2.Visible = False
        PanelCarrinho.Visible = False

        Panel3.Visible = False
        Panel2.Visible = False
        Panel4.Visible = True
        Panel7.Visible = False
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.Indigo
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelCidades.Visible = False
        Panelnovidades.Visible = False
        PanelPedir.Visible = False
        PanelPedir2.Visible = False
        PanelCarrinho.Visible = True

        For x = 0 To n_items - 1
            Form4.DataGridView1.Item(0, x).Value = ListBox1.Items(x)
            Form4.DataGridView1.Item(1, x).Value = ListBox2.Items(x)
            Form4.DataGridView1.Item(2, x).Value = ListBox3.Items(x)
        Next


        Panel7.Visible = True
        Panel3.Visible = False
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 1
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add(Label1.Text)
        ListBox3.Items.Add(1)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 12
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add(Label2.Text)
        ListBox3.Items.Add(12)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 10
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add(Label3.Text)
        ListBox3.Items.Add(10)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 7.5
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add(Label5.Text)
        ListBox3.Items.Add(7.5)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 6
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Menu Kebab")
        ListBox3.Items.Add(6)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 14
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Pizza Grande")
        ListBox3.Items.Add(14)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 2.5
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("10 Nuggets")
        ListBox3.Items.Add(2.5)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 10
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("KFC Bucket")
        ListBox3.Items.Add(10)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 1.5
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Coca cola")
        ListBox3.Items.Add(1.5)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        n_pag = 2

        Button18.BackColor = Color.Indigo
        Button18.ForeColor = Color.White
        Button19.BackColor = Color.White
        Button19.ForeColor = Color.Black

        PanelPedir.Visible = False
        PanelPedir2.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        n_pag = 1

        Button13.BackColor = Color.Indigo
        Button13.ForeColor = Color.White
        Button14.BackColor = Color.White
        Button14.ForeColor = Color.Black

        PanelPedir2.Visible = False
        PanelPedir.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 1
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Gelado")
        ListBox3.Items.Add(1)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        n_pag = 1

        If n_pag = 1 Then
            Button13.BackColor = Color.Indigo
            Button13.ForeColor = Color.White
            Button14.BackColor = Color.White
            Button14.ForeColor = Color.Black
        ElseIf n_pag = 2 Then
            Button18.BackColor = Color.Indigo
            Button18.ForeColor = Color.White
        End If

        PanelPedir.Visible = True
        PanelPedir2.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        n_pag = 2

        If n_pag = 1 Then
            Button19.BackColor = Color.Indigo
            Button19.ForeColor = Color.White
        ElseIf n_pag = 2 Then
            Button18.BackColor = Color.Indigo
            Button18.ForeColor = Color.White
        End If

        PanelPedir.Visible = False
        PanelPedir2.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 4
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Bitoque")
        ListBox3.Items.Add(4)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 3
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Salada")
        ListBox3.Items.Add(3)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 5
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Frango")
        ListBox3.Items.Add(5)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        n_items += 1
        Button5.Text = " Carrinho (" & n_items & ")"
        preco_total += 5
        Label23.Text = preco_total
        ListBox1.Items.Add(n_items)
        ListBox2.Items.Add("Bolo chocolate")
        ListBox3.Items.Add(5)
        Form4.DataGridView1.Rows.Add()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim cdd As String
        cdd = InputBox("Digite a sua cidade: ", "Cidade")
        If (cdd = "Lisboa") Or (cdd = "Leiria") Or (cdd = "Porto") Or (cdd = "Coimbra") Then
            MsgBox("Disponível! :D")
        Else
            MsgBox("Indisponível! :(")
            IMGleiria.Visible = False
            IMGlisboa.Visible = False
            IMGcoimbra.Visible = False
            IMGporto.Visible = False
        End If

        Select Case cdd
            Case "Leiria"
                IMGleiria.Visible = True
                IMGlisboa.Visible = False
                IMGcoimbra.Visible = False
                IMGporto.Visible = False
            Case "Lisboa"
                IMGleiria.Visible = False
                IMGlisboa.Visible = True
                IMGcoimbra.Visible = False
                IMGporto.Visible = False
            Case "Coimbra"
                IMGleiria.Visible = False
                IMGlisboa.Visible = False
                IMGcoimbra.Visible = True
                IMGporto.Visible = False
            Case "Porto"
                IMGleiria.Visible = False
                IMGlisboa.Visible = False
                IMGcoimbra.Visible = False
                IMGporto.Visible = True
        End Select
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        End
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

        If Not n_items = 0 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            preco_total = 0
            n_items = 0
            Button5.Text = "Carrinho"
            Label23.Text = preco_total
            Form4.DataGridView1.Rows.Clear()
        End If

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

        If Not ListBox2.SelectedIndex = -1 Then
            Dim n As Integer
            n = ListBox2.SelectedIndex

            Dim prec As Single
            prec = ListBox3.Items(n)

            ListBox1.Items.RemoveAt(n)
            ListBox2.Items.RemoveAt(n)
            ListBox3.Items.RemoveAt(n)

            Form4.DataGridView1.Rows.RemoveAt(n)

            n_items -= 1

            For x = 0 To n_items - 1
                ListBox1.Items(x) = x + 1
                Form4.DataGridView1.Item(0, x).Value = x + 1
            Next

            preco_total = preco_total - prec
            Button5.Text = " Carrinho (" & n_items & ")"
            Label23.Text = preco_total
        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        If Not n_items = 0 Then
            MsgBox("TOTAL: " & preco_total & "€")
            MsgBox("Pedido finalizado! Obrigado pela compra : )")
            End
        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index As Integer
        index = ListBox1.SelectedIndex
        ListBox2.SelectedIndex = index
        ListBox3.SelectedIndex = index
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim index As Integer
        index = ListBox2.SelectedIndex
        ListBox1.SelectedIndex = index
        ListBox3.SelectedIndex = index
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim index As Integer
        index = ListBox3.SelectedIndex
        ListBox2.SelectedIndex = index
        ListBox1.SelectedIndex = index
    End Sub
End Class