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
    Private H2 As Integer = 0
    Private H3 As Integer = 0

    Private M1 As Integer = 0
    Private M2 As Integer = 0
    Private M3 As Integer = 0

    Private Cal1 As Integer = 0
    Private Cal2 As Integer = 0
    Private Cal3 As Integer = 0

    Private Acc1 As Integer = 0
    Private Acc2 As Integer = 0


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

        Hombre = False
        Mujer = True
        Calzado = False
        Accesorios = False

        Mujer1 = 0
        txtCantidad.Text = M1
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
        lblT1.Text = "37"
        lblT2.Text = "38"
        lblT3.Text = "40"
        lblT4.Text = "41"
        lblT5.Text = "42"

        Hombre = False
        Mujer = False
        Calzado = True
        Accesorios = False

        Calzado1 = 0
        txtCantidad.Text = Cal1
    End Sub

    Private Sub btnAcces_Click(sender As Object, e As EventArgs) Handles btnAcces.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.SteelBlue

        lblTitulo.Text = "Strap Watch 1791"
        PictureBox1.Image = ImgAccP.Images.Item(0)
        PictureBox2.Image = ImgAccP.Images.Item(2)
        PictureBox3.Image = ImgAccP.Images.Item(2)
        PictureBox4.Image = ImgAccP.Images.Item(2)
        PictureBox5.Image = ImgAccP.Images.Item(0)

        lblPrecio.Text = "$175"
        lblT1.Text = "-"
        lblT1.ForeColor = Color.Gray
        lblT2.Text = "-"
        lblT2.ForeColor = Color.Gray
        lblT3.Text = "-"
        lblT3.ForeColor = Color.Gray
        lblT4.Text = "-"
        lblT4.ForeColor = Color.Gray
        lblT5.Text = "-"
        lblT5.ForeColor = Color.Gray

        Hombre = False
        Mujer = False
        Calzado = False
        Accesorios = True

        Accesorio1 = 0
        txtCantidad.Text = Acc1
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
                Case 1
                    H1 = txtCantidad.Text
                    Total = Total + (H2 * 85)
                    lblTotal.Text = Total
                Case 2
                    H3 = txtCantidad.Text
                    Total = Total + (H3 * 110)
                    lblTotal.Text = Total
            End Select
        End If
        If Mujer = True Then
            Select Case Mujer1
                Case 0
                    M1 = txtCantidad.Text
                    Total = Total + (M1 * 120)
                    lblTotal.Text = Total
                Case 1
                    M2 = txtCantidad.Text
                    Total = Total + (M2 * 190)
                    lblTotal.Text = Total
                Case 2
                    M3 = txtCantidad.Text
                    Total = Total + (M3 * 125)
                    lblTotal.Text = Total
            End Select
        End If
        If Calzado = True Then
            Select Case Calzado1
                Case 0
                    Cal1 = txtCantidad.Text
                    Total = Total + (Cal1 * 55)
                    lblTotal.Text = Total
                Case 1
                    Cal2 = txtCantidad.Text
                    Total = Total + (Cal2 * 80)
                    lblTotal.Text = Total
                Case 2
                    Cal3 = txtCantidad.Text
                    Total = Total + (Cal3 * 155)
                    lblTotal.Text = Total
            End Select
        End If
        If Accesorios = True Then
            Select Case Accesorio1
                Case 0
                    Acc1 = txtCantidad.Text
                    Total = Total + (Acc1 * 175)
                    lblTotal.Text = Total
                Case 0
                    Acc2 = txtCantidad.Text
                    Total = Total + (Acc2 * 25)
                    lblTotal.Text = Total
            End Select
        End If
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox("Su compra fue hecha con éxito")
    End Sub
    Public Sub ProH()

        Select Case Hombre1
            Case 0
                txtCantidad.Text = H1
                PictureBox1.Image = ImgPG.Images.Item(0)
                PictureBox2.Image = ImgPG.Images.Item(1)
                PictureBox3.Image = ImgPG.Images.Item(2)
                PictureBox4.Image = ImgPG.Images.Item(3)
                PictureBox5.Image = ImgPG.Images.Item(0)
                lblTitulo.Text = "Cotton Linen V-Neck Jumper"
                lblPrecio.Text = "$95"
                H1 = txtCantidad.Text
            Case 1
                txtCantidad.Text = H1
                PictureBox1.Image = ImgPG.Images.Item(4)
                PictureBox2.Image = ImgPG.Images.Item(5)
                PictureBox3.Image = ImgPG.Images.Item(6)
                PictureBox4.Image = ImgPG.Images.Item(7)
                PictureBox5.Image = ImgPG.Images.Item(4)
                lblTitulo.Text = "Eng Poplin Shirt"
                lblPrecio.Text = "$85"
                H2 = txtCantidad.Text
            Case 2
                txtCantidad.Text = H1
                PictureBox1.Image = ImgPG.Images.Item(8)
                PictureBox2.Image = ImgPG.Images.Item(9)
                PictureBox3.Image = ImgPG.Images.Item(10)
                PictureBox4.Image = ImgPG.Images.Item(11)
                PictureBox5.Image = ImgPG.Images.Item(8)
                lblTitulo.Text = "Plainted Sub Cashmere Blend Jumper"
                lblPrecio.Text = "$110"
                H3 = txtCantidad.Text
        End Select

    End Sub

    Public Sub ProM()

        Select Case Mujer1
            Case 0
                txtCantidad.Text = M1
                PictureBox1.Image = ImgGM.Images.Item(0)
                PictureBox2.Image = ImgGM.Images.Item(1)
                PictureBox3.Image = ImgGM.Images.Item(2)
                PictureBox4.Image = ImgGM.Images.Item(3)
                PictureBox5.Image = ImgGM.Images.Item(0)
                lblTitulo.Text = "Nicola Blouse"
                lblPrecio.Text = "$120"
                M1 = txtCantidad.Text
            Case 1
                txtCantidad.Text = M1
                PictureBox1.Image = ImgGM.Images.Item(4)
                PictureBox2.Image = ImgGM.Images.Item(5)
                PictureBox3.Image = ImgGM.Images.Item(6)
                PictureBox4.Image = ImgGM.Images.Item(7)
                PictureBox5.Image = ImgGM.Images.Item(4)
                lblTitulo.Text = "Jemma Blazer"
                lblPrecio.Text = "$190"
                M2 = txtCantidad.Text
            Case 2
                txtCantidad.Text = M1
                PictureBox1.Image = ImgGM.Images.Item(8)
                PictureBox2.Image = ImgGM.Images.Item(9)
                PictureBox3.Image = ImgGM.Images.Item(10)
                PictureBox4.Image = ImgGM.Images.Item(10)
                PictureBox5.Image = ImgGM.Images.Item(8)
                lblTitulo.Text = "Naige Dress"
                lblPrecio.Text = "$125"
                M3 = txtCantidad.Text
        End Select

    End Sub
    Public Sub ProC()

        Select Case Calzado1
            Case 0
                txtCantidad.Text = Cal1
                PictureBox1.Image = ImgCalzaG.Images.Item(0)
                PictureBox2.Image = ImgCalzaG.Images.Item(1)
                PictureBox3.Image = ImgCalzaG.Images.Item(2)
                PictureBox4.Image = ImgCalzaG.Images.Item(3)
                PictureBox5.Image = ImgCalzaG.Images.Item(0)
                lblTitulo.Text = "Philip 1d Trainer"
                lblPrecio.Text = "$55"
                Cal1 = txtCantidad.Text
            Case 1
                txtCantidad.Text = Cal1
                PictureBox1.Image = ImgCalzaG.Images.Item(4)
                PictureBox2.Image = ImgCalzaG.Images.Item(5)
                PictureBox3.Image = ImgCalzaG.Images.Item(6)
                PictureBox4.Image = ImgCalzaG.Images.Item(7)
                PictureBox5.Image = ImgCalzaG.Images.Item(4)
                lblTitulo.Text = "Deck 4d Mixed"
                lblPrecio.Text = "$80"
                Cal2 = txtCantidad.Text
            Case 2
                txtCantidad.Text = Cal1
                PictureBox1.Image = ImgCalzaG.Images.Item(8)
                PictureBox2.Image = ImgCalzaG.Images.Item(9)
                PictureBox3.Image = ImgCalzaG.Images.Item(10)
                PictureBox4.Image = ImgCalzaG.Images.Item(11)
                PictureBox5.Image = ImgCalzaG.Images.Item(8)
                lblTitulo.Text = "Parson 8n Mind Heel"
                lblPrecio.Text = "$155"
                Cal3 = txtCantidad.Text
        End Select

    End Sub

    Public Sub ProA()

        Select Case Accesorio1
            Case 0
                txtCantidad.Text = Acc1
                PictureBox1.Image = ImgAccP.Images.Item(0)
                PictureBox2.Image = ImgAccP.Images.Item(2)
                PictureBox3.Image = ImgAccP.Images.Item(2)
                PictureBox4.Image = ImgAccP.Images.Item(2)
                PictureBox5.Image = ImgAccP.Images.Item(0)
                lblTitulo.Text = "Strap Watch 1791"
                lblPrecio.Text = "$175"
                Acc1 = txtCantidad.Text
            Case 1
                txtCantidad.Text = Acc1
                PictureBox1.Image = ImgAccP.Images.Item(1)
                PictureBox2.Image = ImgAccP.Images.Item(2)
                PictureBox3.Image = ImgAccP.Images.Item(2)
                PictureBox4.Image = ImgAccP.Images.Item(2)
                PictureBox5.Image = ImgAccP.Images.Item(1)
                lblTitulo.Text = "Classic Logo Red Cap"
                lblPrecio.Text = "$25"
                Acc2 = txtCantidad.Text
        End Select

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        If Hombre = True Then
            Select Case Hombre1
                Case 0
                    Hombre1 = Hombre1 + 1
                    ProH()
                Case 1
                    Hombre1 = Hombre1 + 1
                    ProH()
                Case 2
                    Beep()
                    ProH()
            End Select
        End If
        If Mujer = True Then
            Select Case Mujer1
                Case 0
                    Mujer1 = Mujer1 + 1
                    ProM()
                Case 1
                    Mujer1 = Mujer1 + 1
                    ProM()
                Case 2
                    Beep()
                    ProM()
            End Select
        End If
        If Calzado = True Then
            Select Case Calzado1
                Case 0
                    Calzado1 = Calzado1 + 1
                    ProC()
                Case 1
                    Calzado1 = Calzado1 + 1
                    ProC()
                Case 2
                    Beep()
                    ProC()
            End Select
        End If
        If Accesorios = True Then
            Select Case Accesorio1
                Case 0
                    Accesorio1 = Accesorio1 + 1
                    ProA()
                Case 1
                    Accesorio1 = Accesorio1 + 1
                    ProA()
                Case 2
                    Beep()
                    ProA()
            End Select
        End If
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        If Hombre = True Then
            Select Case Hombre1
                Case 0
                    Beep()
                    ProH()
                Case 1
                    Hombre1 = Hombre1 - 1
                    ProH()
                Case 2
                    Hombre1 = Hombre1 - 1
                    ProH()
            End Select
        End If
        If Mujer = True Then
            Select Case Mujer1
                Case 0
                    Beep()
                    ProM()
                Case 1
                    Mujer1 = Mujer1 - 1
                    ProM()
                Case 2
                    Mujer1 = Mujer1 - 1
                    ProM()
            End Select
        End If
        If Calzado = True Then
            Select Case Calzado1
                Case 0
                    Beep()
                    ProC()
                Case 1
                    Calzado1 = Calzado1 - 1
                    ProC()
                Case 2
                    Calzado1 = Calzado1 - 1
                    ProC()
            End Select
        End If
        If Accesorios = True Then
            Select Case Accesorio1
                Case 0
                    Accesorio1 = Accesorio1 - 1
                    ProA()
                Case 1
                    Accesorio1 = Accesorio1 - 1
                    ProA()
                Case 2
                    Beep()
                    ProA()
            End Select
        End If
    End Sub
End Class