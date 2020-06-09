Public Class FormulaCuadratica

    Dim a, b, c As String
    Dim valor1, valor2 As Double

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValorA.Clear()
        txtValorB.Clear()
        txtValorC.Clear()
        txtValorX1.Clear()
        txtValorX2.Clear()
        txtValorA.Focus()

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

        a = Val(txtValorA.Text)
        b = Val(txtValorB.Text)
        c = Val(txtValorC.Text)

        If txtValorA.Text = "" Then
            MsgBox("Digite un valor para la variable A", vbInformation)
            If txtValorB.Text = "" Then
                MsgBox("Digite un valor para la variable B", vbInformation)
            ElseIf txtValorC.Text = "" Then
                MsgBox("Digite un valor para la variable C", vbInformation)
            End If
        Else
            valor1 = (((b * (-1)) + (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a))
            valor2 = (((b * (-1)) - (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a))
        End If

        txtValorX1.Text = valor1
        txtValorX2.Text = valor2
    End Sub
End Class