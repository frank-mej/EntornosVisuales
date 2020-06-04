Public Class Libreria

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuLibreria.Show()


    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim cantidad, total As Integer

        cantidad = Val(txtCantidad.Text)
        total = Val(txtTotal.Text)

        If cmbClasicos.Text = "Crimen y castigo de Fyodor Dostoyevsky" Then
            total = cantidad * 400
            txtTotal.Text = total
        End If

        If cmbClasicos.Text = "La carretera de Cormac McCarthy" Then
            total = cantidad * 500
            txtTotal.Text = total
        End If

        If cmbClasicos.Text = "La mujer del viajero en el tiempo de Audrey Niffenegger" Then
            total = cantidad * 600
            txtTotal.Text = total
        End If

        If cmbClasicos.Text = "Cien años de soledad de Gabriel García Márquez" Then
            total = cantidad * 700
            txtTotal.Text = total
        End If

        If cmbClasicos.Text = "Los Pilares de la Tierra de Ken Follett" Then
            total = cantidad * 800
            txtTotal.Text = total
        End If

        Dim valor As Int16
        If txtCantidad.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtCantidad.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtCantidad.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")
            End If
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantidad.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip.SetToolTip(txtCantidad, "Ingrese una cantidad")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtTotal_MouseHover(sender As Object, e As EventArgs) Handles txtTotal.MouseHover
        ToolTip.SetToolTip(txtTotal, "Aqui se mostrara el total de su compra")
        ToolTip.ToolTipTitle = "Total"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbClasicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClasicos.SelectedIndexChanged

    End Sub

    Private Sub cmbClasicos_MouseHover(sender As Object, e As EventArgs) Handles cmbClasicos.MouseHover
        ToolTip.SetToolTip(cmbClasicos, "Elija una Opcion")
        ToolTip.ToolTipTitle = "Clasicos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class