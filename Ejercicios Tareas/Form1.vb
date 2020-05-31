Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'comentarios

        'Inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'Proceso
        suma = valor1 + valor2
        resta = valor1 - valor2
        multiplicacion = valor1 * valor2

        If valor2 = 0 Then
            MsgBox("No se puede dividir entre 0")
        End If
        If valor2 <> 0 Then
            division = valor1 / valor2
        End If



        'Salidas
        txtSuma.Text = suma
        txtResta.Text = resta
        txtMultiplicacion.Text = multiplicacion
        txtDivision.Text = division
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtDivision.Text = " "
        txtMultiplicacion.Text = ""
        txtResta.Text = ""
        txtSuma.Text = ""
        txtValor1.Text = ""
        txtValor2.Text = ""
        txtValor1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
