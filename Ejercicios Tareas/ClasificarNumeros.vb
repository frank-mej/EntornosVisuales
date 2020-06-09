Public Class ClasificarNumeros
    Private Sub ClasificarNumeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Volver?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            MenuGuia.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero, numeroPar, numeroImpar, numeroPositivo, numeroNegativo, suma, cantidadNumeros As Integer

        cantidadNumeros = Val(txtNumeros.Text)

        For i = 1 To cantidadNumeros Step 1
            numero = InputBox("Ingrese un numero", "Ingreso de valores")

            cmbNumero.Items.Add(numero)

            If numero = Int(numero / 2) * 2 Then
                numeroPar = numeroPar + 1
            Else
                numeroImpar = numeroImpar + 1
            End If

            If numero < 0 Then
                numeroNegativo = numeroNegativo + 1
            Else
                numeroPositivo = numeroPositivo + 1
            End If

            suma = suma + numero
        Next
        txtImpares.Text = numeroImpar
        txtNegativos.Text = numeroNegativo
        txtPares.Text = numeroPar
        txtPositivos.Text = numeroPositivo
        txtSuma.Text = suma



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSuma.Clear()
        txtPositivos.Clear()
        txtPares.Clear()
        txtNumeros.Clear()
        txtNegativos.Clear()
        txtImpares.Clear()
        txtNumeros.Focus()
        cmbNumero.Items.Clear()
    End Sub
End Class