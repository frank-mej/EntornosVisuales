Public Class CicloForClase
    Private Sub BindingNavigatorDeleteItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double

        valor = Val(txtIngresar.Text)

        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multiplicacion = valor * i
            division = Format((valor / i).ToString, 2)

            CmbSuma.Items.Add(valor & " + " & i & " = " & suma)
            CmbResta.Items.Add(valor & " - " & i & " = " & resta)
            CmbMultiplicacion.Items.Add(valor & " * " & i & " = " & multiplicacion)
            CmbDivision.Items.Add(valor & " / " & i & " = " & division)

        Next
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim Valor As Integer
        Valor = InputBox("Ingrese Numero", "Ingreso")
        txtIngresar.Text = Valor
    End Sub
End Class