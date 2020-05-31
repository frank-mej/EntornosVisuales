<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CicloForClase
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbDivision = New System.Windows.Forms.ComboBox()
        Me.CmbMultiplicacion = New System.Windows.Forms.ComboBox()
        Me.CmbResta = New System.Windows.Forms.ComboBox()
        Me.CmbSuma = New System.Windows.Forms.ComboBox()
        Me.Suma = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Resta = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIngresar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Valor"
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(102, 32)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtIngresar.TabIndex = 1
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(4, 29)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCalcular)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(6, 19)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(104, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbDivision)
        Me.GroupBox3.Controls.Add(Me.CmbMultiplicacion)
        Me.GroupBox3.Controls.Add(Me.CmbResta)
        Me.GroupBox3.Controls.Add(Me.CmbSuma)
        Me.GroupBox3.Controls.Add(Me.Suma)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Resta)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 210)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 158)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'CmbDivision
        '
        Me.CmbDivision.FormattingEnabled = True
        Me.CmbDivision.Location = New System.Drawing.Point(160, 115)
        Me.CmbDivision.Name = "CmbDivision"
        Me.CmbDivision.Size = New System.Drawing.Size(121, 21)
        Me.CmbDivision.TabIndex = 10
        Me.CmbDivision.Text = "Mostrar Division"
        '
        'CmbMultiplicacion
        '
        Me.CmbMultiplicacion.FormattingEnabled = True
        Me.CmbMultiplicacion.Location = New System.Drawing.Point(17, 115)
        Me.CmbMultiplicacion.Name = "CmbMultiplicacion"
        Me.CmbMultiplicacion.Size = New System.Drawing.Size(121, 21)
        Me.CmbMultiplicacion.TabIndex = 9
        Me.CmbMultiplicacion.Text = "Mostrar Multiplicacion"
        '
        'CmbResta
        '
        Me.CmbResta.FormattingEnabled = True
        Me.CmbResta.Location = New System.Drawing.Point(160, 47)
        Me.CmbResta.Name = "CmbResta"
        Me.CmbResta.Size = New System.Drawing.Size(121, 21)
        Me.CmbResta.TabIndex = 8
        Me.CmbResta.Text = "Mostrar Resta"
        '
        'CmbSuma
        '
        Me.CmbSuma.FormattingEnabled = True
        Me.CmbSuma.Location = New System.Drawing.Point(17, 47)
        Me.CmbSuma.Name = "CmbSuma"
        Me.CmbSuma.Size = New System.Drawing.Size(121, 21)
        Me.CmbSuma.TabIndex = 7
        Me.CmbSuma.Text = "Mostrar Suma"
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(18, 31)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(34, 13)
        Me.Suma.TabIndex = 3
        Me.Suma.Text = "Suma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Multiplicacion"
        '
        'Resta
        '
        Me.Resta.AutoSize = True
        Me.Resta.Location = New System.Drawing.Point(163, 31)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(35, 13)
        Me.Resta.TabIndex = 5
        Me.Resta.Text = "Resta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Division"
        '
        'CicloForClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 416)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CicloForClase"
        Me.Text = "CicloForClase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbDivision As ComboBox
    Friend WithEvents CmbMultiplicacion As ComboBox
    Friend WithEvents CmbResta As ComboBox
    Friend WithEvents CmbSuma As ComboBox
    Friend WithEvents Suma As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Resta As Label
    Friend WithEvents Label4 As Label
End Class
