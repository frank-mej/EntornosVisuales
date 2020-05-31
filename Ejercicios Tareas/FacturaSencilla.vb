Public Class FacturaSencilla
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim pUnitario, cantidad As Integer
        Dim descuento, subtotal, total, ISV As Double
        Dim aplicaDescuento, aplicaIsv As Boolean

        pUnitario = Val(txtPunitario.Text)
        cantidad = Val(txtCantidad.Text)

        'chk Descuento.Checked= false 
        aplicaDescuento = chkDescuento.Checked
        aplicaIsv = chkISV.Checked
        descuento = 0
        ISV = 0
        subtotal = pUnitario * cantidad

        If cbxDescuento.Text = "Descuento de la tercera edad" Then
            descuento = subtotal * 0.4
            txtDescuento.Text = descuento
            total = subtotal - descuento
        End If

        If cbxDescuento.Text = "Descuento ordinario" Then
            descuento = subtotal * 0.35
            txtDescuento.Text = descuento
            total = subtotal - descuento
        End If

        If cbxDescuento.Text = "Descuento Forfait" Then
            descuento = subtotal * 0.3
            txtDescuento.Text = descuento
            total = subtotal - descuento
        End If

        If cbxDescuento.Text = "Descuento por volumen" Then
            descuento = subtotal * 0.25
            txtDescuento.Text = descuento
            total = subtotal - descuento
        End If

        If cbxDescuento.Text = "Descuento por pronto pago" Then
            descuento = subtotal * 0.2
            txtDescuento.Text = descuento
            total = subtotal - descuento
        End If

        If cbxDescuento.Text = "Descuento por navidad" Then
            descuento = subtotal * 0.15
            txtDescuento.Text = descuento
            total = subtotal - descuento
        End If

        If cbxISV.Text = "ISV 15%" Then
            ISV = subtotal * 0.15
            txtISV.Text = ISV
            total = subtotal + ISV
        End If

        If cbxISV.Text = "ISV 17%" Then
            ISV = subtotal * 0.17
            txtISV.Text = ISV
            total = subtotal + ISV
        End If

        Dim valor As Int16
        If txtPunitario.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtPunitario.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtPunitario.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtPunitario.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            End If
        End If

        If txtCantidad.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtCantidad.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtCantidad.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            End If
        End If

        btnNuevo.Enabled = True

        txtSubtotal.Text = subtotal
        txtDescuento.Text = descuento
        txtISV.Text = ISV
        txtTotal.Text = total
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        chkDescuento.Enabled = True
        chkISV.Enabled = True
        txtCantidad.Text = ""
        txtDescuento.Text = ""
        txtISV.Text = ""
        txtPunitario.Text = ""
        txtSubtotal.Text = ""
        txtTotal.Text = ""
        cbxDescuento.Enabled = False
        cbxISV.Enabled = False
        chkDescuento.Checked = False
        chkISV.Checked = False
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            cbxDescuento.Enabled = True
        End If

        If chkDescuento.Checked = True Then
            chkISV.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged
        If chkISV.Checked = True Then
            cbxISV.Enabled = True
        End If

        If chkISV.Checked = True Then
            chkDescuento.Enabled = False
        End If
    End Sub
End Class