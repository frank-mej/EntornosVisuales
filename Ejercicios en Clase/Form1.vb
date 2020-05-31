Public Class Form1
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim valor1, valor2, suma As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        suma = valor1 + valor2

        txtResultado.Text = suma
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
