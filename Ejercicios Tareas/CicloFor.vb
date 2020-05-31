Public Class CicloFor
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1 As Integer
        Dim valor2, potencia As Integer

        potencia = 1
        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)


        For a = 1 To valor2

            potencia = potencia * valor1
        Next

        txtResultado.Text = potencia
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Text = ""
        txtValor1.Text = ""
        txtValor2.Text = ""
        txtValor1.Focus()
    End Sub
End Class