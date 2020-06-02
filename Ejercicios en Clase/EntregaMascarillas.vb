Public Class EntregaMascarillas
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'For, Dowhile
        Dim departamento, mascarillas As Integer
        departamento = Val(txtDepartamento.Text)
        For i = 1 To departamento Step 1
            Do
                mascarillas = InputBox("Ingrese la cantidad de mascarillas", ",Ingresar")
            Loop While (mascarillas < 0 Or mascarillas > 1000)
            cmbDepartamento.Items.Add(mascarillas)
        Next
    End Sub

    Private Sub EntregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As String
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedIndex.ToString
        municipios = Val(txtMunicipios.Text)

        Select Case idDepartamento
            Case 0
                For i = 1 To municipios Step 1
                    While (itemDepartamento > 0)
                        cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                        If (itemDepartamento > cantEntrega) Then
                            municipios += 1
                            itemDepartamento = cantEntrega
                            txtStock.Text = itemDepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End While
                Next

        End Select

        txtStock.Text = itemDepartamento
    End Sub
End Class