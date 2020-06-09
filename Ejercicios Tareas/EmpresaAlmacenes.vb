Public Class EmpresaAlmacenes
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Volver?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            MenuGuia.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Declaración de variables
        Dim numeroAlmacenes As Integer
        Dim ventas, sumaVentas, ventaMasAlta, mediaVentas As Double


        'Entrada de datos
        numeroAlmacenes = 10
        'Inicializamos las variables
        sumaVentas = 0
        ventaMasAlta = 0

        For i = 1 To numeroAlmacenes Step 1
            ventas = InputBox("Ingrese Ventas del Almacen " & i, "Registro de Ventas")
            sumaVentas = sumaVentas + ventas
            If (ventas > ventaMasAlta) Then
                ventaMasAlta = ventas
            End If

        Next
        mediaVentas = sumaVentas / numeroAlmacenes

        'Evaluamos las ventas mas altas de la media


        'Salida de Información
        txtMedia.Text = mediaVentas
        txtVentas.Text = ventaMasAlta


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtVentas.Clear()
        txtMedia.Clear()
    End Sub
End Class