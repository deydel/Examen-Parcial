Public Class MainForm
    Private Hombre As Boolean = True
    Private Mujer As Boolean = False
    Private Calzado As Boolean = False
    Private Accesorios As Boolean = False

    Private Hombre1 As Integer = 0
    Private Mujer1 As Integer = 0
    Private Calzado1 As Integer = 0
    Private Accesorio1 As Integer = 0

    Private H1 As Integer = 0
    Private M1 As Integer = 0
    Private Cal1 As Integer = 0
    Private Acc1 As Integer = 0


    Private Total As Integer = 0
    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        btnHombre.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.Black

        PictureBox1.Image = ImgPG.Images.Item(0)
        PictureBox2.Image = ImgPG.Images.Item(1)
        PictureBox3.Image = ImgPG.Images.Item(2)
        PictureBox4.Image = ImgPG.Images.Item(3)

        PictureBox5.Image = ImgPG.Images.Item(0)

        lblTitulo.Text = "Cotton Line V-neck Jumper"

        lblPrecio.Text = "$95"
        lblT1.Text = "XS"
        lblT2.Text = "S"
        lblT3.Text = "M"
        lblT4.Text = "L"
        lblT5.Text = "XL"

        lblT1.ForeColor = Color.Gray
        lblT2.ForeColor = Color.Black
        lblT3.ForeColor = Color.Black
        lblT4.ForeColor = Color.Black
        lblT5.ForeColor = Color.Gray

        txtCantidad.Text = "0"
        Hombre = True
    End Sub

    Private Sub btnHombre_Click(sender As Object, e As EventArgs) Handles btnHombre.Click

        btnHombre.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.Black

        lblTitulo.Text = "Cotton Line V-neck Jumper"
        PictureBox1.Image = ImgPG.Images.Item(0)
        PictureBox2.Image = ImgPG.Images.Item(1)
        PictureBox3.Image = ImgPG.Images.Item(2)
        PictureBox4.Image = ImgPG.Images.Item(3)
        PictureBox5.Image = ImgPG.Images.Item(0)

        lblPrecio.Text = "$95"
        lblT1.Text = "XS"
        lblT2.Text = "S"
        lblT3.Text = "M"
        lblT4.Text = "L"
        lblT5.Text = "XL"

        lblT1.ForeColor = Color.Gray
        lblT2.ForeColor = Color.Black
        lblT3.ForeColor = Color.Black
        lblT4.ForeColor = Color.Black
        lblT5.ForeColor = Color.Gray

        Hombre = True
        Mujer = False
        Calzado = False
        Accesorios = False

        Hombre1 = 0

        txtCantidad.Text = H1
    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.Black

        lblTitulo.Text = "Nicola Blouse"
        PictureBox1.Image = ImgGM.Images.Item(0)
        PictureBox2.Image = ImgGM.Images.Item(1)
        PictureBox3.Image = ImgGM.Images.Item(2)
        PictureBox4.Image = ImgGM.Images.Item(3)
        PictureBox5.Image = ImgGM.Images.Item(0)

        lblPrecio.Text = "$120"

    End Sub

    Private Sub btnCalzad_Click(sender As Object, e As EventArgs) Handles btnCalzad.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.SteelBlue
        btnAcces.ForeColor = Color.Black

        lblTitulo.Text = "Phillipe 1d Trainers"
        PictureBox1.Image = ImgCalzaG.Images.Item(0)
        PictureBox2.Image = ImgCalzaG.Images.Item(1)
        PictureBox3.Image = ImgCalzaG.Images.Item(2)
        PictureBox4.Image = ImgCalzaG.Images.Item(3)
        PictureBox5.Image = ImgCalzaG.Images.Item(0)

        lblPrecio.Text = "$55"
    End Sub

    Private Sub btnAcces_Click(sender As Object, e As EventArgs) Handles btnAcces.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.SteelBlue

        lblTitulo.Text = "Strap Watch 1791"
        PictureBox1.Image = ImgAccP.Images.Item(0)
        PictureBox2.Image = ImgAccP.Images.Item(1)
        PictureBox3.Image = ImgAccP.Images.Item(1)
        PictureBox4.Image = ImgAccP.Images.Item(1)
        PictureBox5.Image = ImgAccP.Images.Item(0)

        lblPrecio.Text = "$175"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Hombre = True Then
            PictureBox5.Image = PictureBox1.Image
        Else
            If Mujer = True Then
                PictureBox5.Image = PictureBox1.Image
            Else
                If Calzado = True Then
                    PictureBox5.Image = PictureBox1.Image
                Else
                    If Accesorios = True Then
                        PictureBox5.Image = PictureBox1.Image
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Hombre = True Then
            PictureBox5.Image = PictureBox2.Image
        Else
            If Mujer = True Then
                PictureBox5.Image = PictureBox2.Image
            Else
                If Calzado = True Then
                    PictureBox5.Image = PictureBox2.Image
                Else
                    If Accesorios = True Then
                        PictureBox5.Image = PictureBox2.Image
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Hombre = True Then
            PictureBox5.Image = PictureBox3.Image
        Else
            If Mujer = True Then
                PictureBox5.Image = PictureBox3.Image
            Else
                If Calzado = True Then
                    PictureBox5.Image = PictureBox3.Image
                Else
                    If Accesorios = True Then
                        PictureBox5.Image = PictureBox3.Image
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Hombre = True Then
            PictureBox5.Image = PictureBox4.Image
        Else
            If Mujer = True Then
                PictureBox5.Image = PictureBox4.Image
            Else
                If Calzado = True Then
                    PictureBox5.Image = PictureBox4.Image
                Else
                    If Accesorios = True Then
                        PictureBox5.Image = PictureBox4.Image
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Hombre = True Then
            Select Case Hombre1
                Case 0
                    H1 = txtCantidad.Text
                    Total = Total + (H1 * 95)
                    lblTotal.Text = Total
            End Select
        End If
        If Mujer = True Then
            Select Case Mujer1
                Case 0
                    M1 = txtCantidad.Text
                    Total = Total + (M1 * 120)
                    lblTotal.Text = Total
            End Select
        End If
        If Calzado = True Then
            Select Case Calzado1
                Case 0
                    Cal1 = txtCantidad.Text
                    Total = Total + (Cal1 * 55)
                    lblTotal.Text = Total
            End Select
        End If
        If Accesorios = True Then
            Select Case Accesorio1
                Case 0
                    Acc1 = txtCantidad.Text
                    Total = Total + (Acc1 * 175)
                    lblTotal.Text = Total
            End Select
        End If
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox("Su compra fue hecha con exito")
    End Sub
    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        If Hombre = True Then
            Select Case Hombre1
                Case 0
                    lblTitulo.Text = "Eng Poplin Shirt"
                    PictureBox5.Image = ImgPG.Images.Item(4)
                    PictureBox1.Image = ImgPG.Images.Item(4)
                    PictureBox2.Image = ImgPG.Images.Item(5)
                    PictureBox3.Image = ImgPG.Images.Item(6)
                    PictureBox4.Image = ImgPG.Images.Item(7)
                    lblPrecio.Text = "$85"
                    H1 = txtCantidad.Text
                    txtCantidad.Text = H1
            End Select
        End If
        If Mujer = True Then
            Select Case Mujer1
                Case 0
                    lblTitulo.Text = "Nicola Blouse"
                    PictureBox5.Image = ImgGM.Images.Item(4)
                    PictureBox1.Image = ImgGM.Images.Item(4)
                    PictureBox2.Image = ImgGM.Images.Item(5)
                    PictureBox3.Image = ImgGM.Images.Item(6)
                    PictureBox4.Image = ImgGM.Images.Item(7)
                    lblPrecio.Text = "$85"
            End Select
        End If

        'lblTitulo.Text = "Plaited Sub Cashemer Blend Jumper"

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        lblTitulo.Text = "Eng Poplin Shirt"
        lblTitulo.Text = "Cotton Line V-neck Jumper"
    End Sub

End Class