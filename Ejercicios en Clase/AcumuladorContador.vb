Public Class AcumuladorContador
    Private Sub btnSolicitarOrden_Click(sender As Object, e As EventArgs) Handles btnSolicitarOrden.Click
        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = txtPedidos.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingrese el precio del platillo No." & i, "Precio del platillo")
                'Acumulador: Guarda los valores ingresados previamente
                totalPagar += precio
            Next
            total = totalPagar / orden
            txtTotalAPagar.Text = totalPagar
            txtIndividual.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPedidos.Clear()
        txtIndividual.Clear()
        txtTotalAPagar.Clear()
    End Sub
End Class