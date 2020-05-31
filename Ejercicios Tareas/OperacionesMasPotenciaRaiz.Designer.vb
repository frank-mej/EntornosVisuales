<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperacionesMasPotenciaRaiz
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.potencia = New System.Windows.Forms.CheckBox()
        Me.raiz = New System.Windows.Forms.CheckBox()
        Me.division = New System.Windows.Forms.CheckBox()
        Me.multiplicacion = New System.Windows.Forms.CheckBox()
        Me.resta = New System.Windows.Forms.CheckBox()
        Me.suma = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(84, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(167, 191)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Resultado"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(294, 254)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(167, 139)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 24
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(167, 69)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Valor2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Valor1"
        '
        'potencia
        '
        Me.potencia.AutoSize = True
        Me.potencia.Location = New System.Drawing.Point(301, 184)
        Me.potencia.Name = "potencia"
        Me.potencia.Size = New System.Drawing.Size(68, 17)
        Me.potencia.TabIndex = 20
        Me.potencia.Text = "Potencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.potencia.UseVisualStyleBackColor = True
        '
        'raiz
        '
        Me.raiz.AutoSize = True
        Me.raiz.Location = New System.Drawing.Point(301, 161)
        Me.raiz.Name = "raiz"
        Me.raiz.Size = New System.Drawing.Size(47, 17)
        Me.raiz.TabIndex = 19
        Me.raiz.Text = "Raiz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.raiz.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.AutoSize = True
        Me.division.Location = New System.Drawing.Point(301, 138)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(63, 17)
        Me.division.TabIndex = 18
        Me.division.Text = "Division"
        Me.division.UseVisualStyleBackColor = True
        '
        'multiplicacion
        '
        Me.multiplicacion.AutoSize = True
        Me.multiplicacion.Location = New System.Drawing.Point(301, 115)
        Me.multiplicacion.Name = "multiplicacion"
        Me.multiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.multiplicacion.TabIndex = 17
        Me.multiplicacion.Text = "Multiplicacion"
        Me.multiplicacion.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.Location = New System.Drawing.Point(301, 92)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(54, 17)
        Me.resta.TabIndex = 16
        Me.resta.Text = "Resta"
        Me.resta.UseVisualStyleBackColor = True
        '
        'suma
        '
        Me.suma.AutoSize = True
        Me.suma.Location = New System.Drawing.Point(302, 69)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(53, 17)
        Me.suma.TabIndex = 15
        Me.suma.Text = "Suma" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.suma.UseVisualStyleBackColor = True
        '
        'OperacionesMasPotenciaRaiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 343)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.potencia)
        Me.Controls.Add(Me.raiz)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.multiplicacion)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.suma)
        Me.Name = "OperacionesMasPotenciaRaiz"
        Me.Text = "OperacionesMasPotenciaRaiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents potencia As CheckBox
    Friend WithEvents raiz As CheckBox
    Friend WithEvents division As CheckBox
    Friend WithEvents multiplicacion As CheckBox
    Friend WithEvents resta As CheckBox
    Friend WithEvents suma As CheckBox
End Class
