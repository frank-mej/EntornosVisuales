Imports System.ComponentModel

Public Class Usuario
    Dim usuario, contrasena As String

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If UCase(txtUsuario.Text) = usuario And UCase(txtContraseña.Text) = contrasena Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Datos Incorrectos")
        End If

        If txtUsuario.Text = "" Then
            MsgBox("Por favor llene la casilla Usuario", vbInformation)
            txtUsuario.Text = ""
        End If

        If txtContraseña.Text = "" Then
            MsgBox("Por favor llene la casilla Contraseña", vbInformation)
            txtContraseña.Text = ""
        End If

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        usuario = UCase(txtUsuario.Text)
        contrasena = UCase(txtContraseña.Text)

        If txtUsuario.Text = "" Then
            MsgBox("Por favor llene la casilla Usuario", vbInformation)
            txtUsuario.Text = ""
        End If

        If txtContraseña.Text = "" Then
            MsgBox("Por favor llene la casilla Contraseña", vbInformation)
            txtContraseña.Text = ""
        End If


        txtContraseña.Clear()
        txtUsuario.Clear()
        txtUsuario.Focus()

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip.SetToolTip(txtUsuario, "Ingrese un nombre de Usuario (Jose)")
        ToolTip.ToolTipTitle = "Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        ToolTip.SetToolTip(txtContraseña, "Ingrese una contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class