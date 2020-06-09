Public Class SueldoSar
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Volver?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            MenuGuia.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        If txtIngresar.Text <> "" Then
            txtIngresar.Clear()
            chkDeduccion.Enabled = True
            chkDeduccion.Checked = False
            chkExento.Enabled = True
            chkExento.Checked = False
            txtSueldo.Clear()
            txtIngresar.Focus()
        End If


    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Sueldo, SueldoNeto As Double

        Sueldo = Val(txtIngresar.Text)
        SueldoNeto = Val(txtSueldo.Text)

        If txtIngresar.Text = "" Then
            MsgBox("Usted debe Ingresar el Sueldo", vbInformation)
        ElseIf Sueldo <= 16582.92 Then
            chkExento.Checked = True
            chkDeduccion.Enabled = False
            MsgBox("Usted aplica a Excentos de Impuesto", vbInformation)
            txtSueldo.Text = 0
        ElseIf txtIngresar.Text >= 16528.93 And txtIngresar.Text <= 23536.61 Then
            chkDeduccion.Checked = True
            chkExento.Enabled = False
            MsgBox("Usted aplica a Deduccion del 15%", vbInformation)
            txtSueldo.Text = txtIngresar.Text * 0.15
        ElseIf txtIngresar.Text >= 23536.62 And txtIngresar.Text <= 50317.69 Then
            chkDeduccion.Checked = True
            chkExento.Enabled = False
            MsgBox("Usted aplica a Deduccion del 20%", vbInformation)
            txtSueldo.Text = txtIngresar.Text * 0.2
        ElseIf txtIngresar.Text > 50317.69 Then
            chkDeduccion.Checked = True
            chkExento.Enabled = False
            MsgBox("Usted aplica a Deduccion del 25%", vbInformation)
            txtSueldo.Text = txtIngresar.Text * 0.25
        End If

    End Sub

    Private Sub SueldoSar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class