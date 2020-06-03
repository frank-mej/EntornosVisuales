Public Class FuncionesString
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cadena As String
        cadena = txtLongitud.Text
        txtLongitud.Text = cadena.Length
        txtUltimoCaracter.Text = cadena.Substring(cadena.Length - 1, 1)
        txtPirmerCaracter.Text = cadena.Substring(0, 1)
        txt3voA8vo.Text = cadena.Substring(2, 7)
        txtPosicion.Text = cadena.IndexOf("B", 0) + 1
        txtMayuscula.Text = cadena.ToUpper
        txtMinuscula.Text = cadena.ToLower
        txtBorrarEspacio.Text = cadena.Replace(" ", "")
    End Sub
End Class