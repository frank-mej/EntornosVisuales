Public Class OperacionesMasPotenciaRaiz
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtResultado.Text = ""
        txtValor1.Text = ""
        txtValor2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer

        If Me.suma.Checked = True Then

            Dim suma As Integer

            valor1 = Val(txtValor1.Text)
            valor2 = Val(txtValor2.Text)

            'Proceso
            suma = valor1 + valor2

            'Salidas
            txtResultado.Text = suma
        End If

        If Me.resta.Checked = True Then

            Dim resta As Integer

            valor1 = Val(txtValor1.Text)
            valor2 = Val(txtValor2.Text)

            'Proceso
            resta = valor1 - valor2

            'Salidas
            txtResultado.Text = resta
        End If

        If Me.multiplicacion.Checked = True Then

            Dim multiplicacion As Integer

            valor1 = Val(txtValor1.Text)
            valor2 = Val(txtValor2.Text)

            'Proceso
            multiplicacion = valor1 * valor2

            'Salidas
            txtResultado.Text = multiplicacion
        End If

        If Me.division.Checked = True Then

            Dim division As Integer

            valor1 = Val(txtValor1.Text)
            valor2 = Val(txtValor2.Text)

            'Proceso
            If valor2 = 0 Then
                MsgBox("No se puede dividir entre 0", vbInformation)
            End If
            If valor2 <> 0 Then
                division = valor1 / valor2
            End If

            'Salidas
            txtResultado.Text = division
        End If

        If Me.raiz.Checked = True Then

            Dim raiz, num As Integer
            Dim suma2 As Integer

            valor1 = Val(txtValor1.Text)
            valor2 = Val(txtValor2.Text)

            suma2 = valor1 + valor2

            'Proceso
            If suma2 <> 0 Then
                num = suma2
                raiz = num ^ (1 / 2)
            End If


            'Salidas
            txtResultado.Text = raiz
        End If

        If Me.potencia.Checked = True Then

            Dim potencia As Integer

            valor1 = Val(txtValor1.Text)
            valor2 = Val(txtValor2.Text)

            'Proceso
            potencia = valor1 ^ valor2


            'Salidas
            txtResultado.Text = potencia
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class