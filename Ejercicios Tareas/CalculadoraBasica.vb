Public Class CalculadoraBasica

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim PresionarOperador As Boolean

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResultado.Text = txtHistorial.Text
        'Txt_Resultado.Text = "0"
        'Valor2 = Nothing
        'ValorResultado = Nothing
        'Txt_Resultado.Text = Txt_Historial.Text

    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        EvaluaHacerOperacion()
        Operacion = ""
    End Sub

    Public Sub EvaluaHacerOperacion()
        PresionarOperador = True
        Valor2 = Val(txtResultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            txtResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If PresionarOperador = True Then
            txtResultado.Text = ""
            PresionarOperador = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub

    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "1"
    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "2"
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "3"
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "4"
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "5"
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "6"
    End Sub

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "7"
    End Sub

    Private Sub btnOcho_Click(sender As Object, e As EventArgs) Handles btnOcho.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "8"
    End Sub

    Private Sub btnNueve_Click(sender As Object, e As EventArgs) Handles btnNueve.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "9"
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        EvaluaHacerOperacion()
        Operacion = "+"
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        EvaluaHacerOperacion()
        Operacion = "-"
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        EvaluaHacerOperacion()
        Operacion = "*"
    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        EvaluaHacerOperacion()
        Operacion = "/"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnTres.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Volver?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            MenuGuia.Show()
            Me.Hide()
        End If
    End Sub
End Class