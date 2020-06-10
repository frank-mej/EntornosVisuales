Imports System.ComponentModel

Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If cmbDepartamentos.Text = "Comayagua" Then
            If chkNegativo.Checked = True Then
                txtReporte.Text = "Comayagua - Negativo"
            End If
        End If

        If cmbDepartamentos.Text = "Atlantida" Then
            If chkNegativo.Checked = True Then
                txtReporte.Text = "Atlantida - Negativo"
            End If
        End If

        If cmbDepartamentos.Text = "Comayagua" Then
            If chkFallecido.Checked = True Then
                txtReporte.Text = "Comayagua - Fallecido"
            End If
        End If

        If cmbDepartamentos.Text = "Comayagua" Then
            If chkActivo.Checked = True Then
                txtReporte.Text = "Comayagua - Activo"
            End If
        End If

        If cmbDepartamentos.Text = "Comayagua" Then
            If chkRecuperado.Checked = True Then
                txtReporte.Text = "Comayagua - Recuperado"
            End If
        End If

        If cmbDepartamentos.Text = "Francisco Morazan" Then
            If chkFallecido.Checked = True Then
                txtReporte.Text = "Francisco Morazan - Fallecido"
            End If
        End If

        If cmbDepartamentos.Text = "Francisco Morazan" Then
            If chkActivo.Checked = True Then
                txtReporte.Text = "Francisco Morazan - Activo"
            End If
        End If

        If cmbDepartamentos.Text = "Francisco Morazan" Then
            If chkRecuperado.Checked = True Then
                txtReporte.Text = "Francisco Morazan - Recuperado"
            End If
        End If


        If txtNombre.Text = "" Then
            MsgBox("Por favor llene la casilla Nombre", vbInformation)
            txtNombre.Text = ""
        End If

        If Not IsNumeric(txtEdad.Text) Then
            MsgBox("Ingrese valor numerico en Edad", vbInformation)
            txtEdad.Text = ""
        End If

        If cmbDepartamentos.Text = "" Then
            MsgBox("Por favor elija un departamento", vbInformation)
            cmbDepartamentos.Text = ""
        End If

        If txtMunicipio.Text = "" Then
            MsgBox("Por favor llene la casilla Municipio", vbInformation)
            txtMunicipio.Text = ""
        End If

        If txtDescripcion.Text = "" Then
            MsgBox("Por favor llene la casilla Descripcion", vbInformation)
            txtDescripcion.Text = ""
        End If



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDescripcion.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtNombre.Clear()
        chkFallecido.Enabled = False
        chkActivo.Enabled = False
        chkRecuperado.Enabled = False
        chkFallecido.Checked = False
        chkActivo.Checked = False
        chkRecuperado.Checked = False
        chkPositivo.Checked = False
        cmbDepartamentos.Text = ""
    End Sub

    Private Sub chkPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPositivo.CheckedChanged
        If chkPositivo.Checked = True Then
            chkFallecido.Enabled = True
            chkActivo.Enabled = True
            chkRecuperado.Enabled = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero entero para la edad")
        End If
    End Sub

    Private Sub cmbDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectedIndexChanged

    End Sub

    Private Sub cmbDepartamentos_Validating(sender As Object, e As CancelEventArgs) Handles cmbDepartamentos.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese un Nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Ingrese edad del paciente")
        ToolTip.ToolTipTitle = "Edad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepartamentos_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamentos.MouseHover
        ToolTip.SetToolTip(cmbDepartamentos, "Elija un departamento")
        ToolTip.ToolTipTitle = "Departamento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Ingrese nombre de municipio")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Ingrese informacion del paciente")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtReporte_TextChanged(sender As Object, e As EventArgs) Handles txtReporte.TextChanged

    End Sub

    Private Sub txtReporte_MouseHover(sender As Object, e As EventArgs) Handles txtReporte.MouseHover
        ToolTip.SetToolTip(txtReporte, "Historial de Pacientes")
        ToolTip.ToolTipTitle = "Historial"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNumRecuperados_TextChanged(sender As Object, e As EventArgs) Handles txtNumRecuperados.TextChanged

    End Sub

    Private Sub txtNumRecuperados_MouseHover(sender As Object, e As EventArgs) Handles txtNumRecuperados.MouseHover
        ToolTip.SetToolTip(txtNumFallecido, "Numero de pacientes recuperados")
        ToolTip.ToolTipTitle = "Recuperados"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNumActivos_TextChanged(sender As Object, e As EventArgs) Handles txtNumActivos.TextChanged

    End Sub

    Private Sub txtNumActivos_MouseHover(sender As Object, e As EventArgs) Handles txtNumActivos.MouseHover
        ToolTip.SetToolTip(txtNumActivos, "Numero de pacientes activos")
        ToolTip.ToolTipTitle = "Activos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNumFallecido_TextChanged(sender As Object, e As EventArgs) Handles txtNumFallecido.TextChanged

    End Sub

    Private Sub txtNumFallecido_MouseHover(sender As Object, e As EventArgs) Handles txtNumFallecido.MouseHover
        ToolTip.SetToolTip(txtNumFallecido, "Numero de pacientes fallecidos")
        ToolTip.ToolTipTitle = "Fallecidos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
