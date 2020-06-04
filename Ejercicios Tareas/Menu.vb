Public Class MenuLibreria
    Private Sub btnClasicos_Click(sender As Object, e As EventArgs) Handles btnClasicos.Click
        Libreria.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnRecientes_Click(sender As Object, e As EventArgs) Handles btnRecientes.Click
        LibreriaRecientes.Show()
        Me.Hide()

    End Sub
End Class