Public Class Form1
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim Valor1, Valor2, suma As Integer
        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        suma = Valor1 + Valor2

        txtResultado.Text = suma
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
