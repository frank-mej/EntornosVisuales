<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasificarNumeros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNumeros = New System.Windows.Forms.TextBox()
        Me.txtImpares = New System.Windows.Forms.TextBox()
        Me.txtPares = New System.Windows.Forms.TextBox()
        Me.txtNegativos = New System.Windows.Forms.TextBox()
        Me.txtPositivos = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbNumero = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtNumeros
        '
        Me.txtNumeros.Location = New System.Drawing.Point(136, 71)
        Me.txtNumeros.Name = "txtNumeros"
        Me.txtNumeros.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeros.TabIndex = 0
        '
        'txtImpares
        '
        Me.txtImpares.Location = New System.Drawing.Point(136, 129)
        Me.txtImpares.Name = "txtImpares"
        Me.txtImpares.Size = New System.Drawing.Size(100, 20)
        Me.txtImpares.TabIndex = 1
        '
        'txtPares
        '
        Me.txtPares.Location = New System.Drawing.Point(422, 129)
        Me.txtPares.Name = "txtPares"
        Me.txtPares.Size = New System.Drawing.Size(100, 20)
        Me.txtPares.TabIndex = 2
        '
        'txtNegativos
        '
        Me.txtNegativos.Location = New System.Drawing.Point(136, 182)
        Me.txtNegativos.Name = "txtNegativos"
        Me.txtNegativos.Size = New System.Drawing.Size(100, 20)
        Me.txtNegativos.TabIndex = 3
        '
        'txtPositivos
        '
        Me.txtPositivos.Location = New System.Drawing.Point(422, 186)
        Me.txtPositivos.Name = "txtPositivos"
        Me.txtPositivos.Size = New System.Drawing.Size(100, 20)
        Me.txtPositivos.TabIndex = 4
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(422, 68)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(100, 20)
        Me.txtSuma.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Impares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(317, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total Pares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Negativos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Positivos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Suma"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(351, 353)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 16
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(256, 353)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(161, 353)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 14
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Cantidad Numeros"
        '
        'cmbNumero
        '
        Me.cmbNumero.FormattingEnabled = True
        Me.cmbNumero.Location = New System.Drawing.Point(401, 237)
        Me.cmbNumero.Name = "cmbNumero"
        Me.cmbNumero.Size = New System.Drawing.Size(121, 21)
        Me.cmbNumero.TabIndex = 19
        '
        'ClasificarNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(631, 417)
        Me.Controls.Add(Me.cmbNumero)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.txtPositivos)
        Me.Controls.Add(Me.txtNegativos)
        Me.Controls.Add(Me.txtPares)
        Me.Controls.Add(Me.txtImpares)
        Me.Controls.Add(Me.txtNumeros)
        Me.Name = "ClasificarNumeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClasificarNumeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumeros As TextBox
    Friend WithEvents txtImpares As TextBox
    Friend WithEvents txtPares As TextBox
    Friend WithEvents txtNegativos As TextBox
    Friend WithEvents txtPositivos As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbNumero As ComboBox
End Class
