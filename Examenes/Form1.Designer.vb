<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtReporte = New System.Windows.Forms.TextBox()
        Me.Reporte = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.chkRecuperado = New System.Windows.Forms.CheckBox()
        Me.chkFallecido = New System.Windows.Forms.CheckBox()
        Me.chkNegativo = New System.Windows.Forms.CheckBox()
        Me.chkPositivo = New System.Windows.Forms.CheckBox()
        Me.cmbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.txtNumRecuperados = New System.Windows.Forms.TextBox()
        Me.txtNumActivos = New System.Windows.Forms.TextBox()
        Me.txtNumFallecido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pruebas Realizadas en el Dia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Departamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Municipio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Descripcion"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(192, 63)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(192, 104)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 20)
        Me.txtEdad.TabIndex = 12
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(192, 217)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(100, 20)
        Me.txtMunicipio.TabIndex = 14
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 412)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(201, 81)
        Me.txtDescripcion.TabIndex = 16
        '
        'txtReporte
        '
        Me.txtReporte.Location = New System.Drawing.Point(395, 83)
        Me.txtReporte.Multiline = True
        Me.txtReporte.Name = "txtReporte"
        Me.txtReporte.Size = New System.Drawing.Size(253, 243)
        Me.txtReporte.TabIndex = 17
        '
        'Reporte
        '
        Me.Reporte.AutoSize = True
        Me.Reporte.Location = New System.Drawing.Point(436, 63)
        Me.Reporte.Name = "Reporte"
        Me.Reporte.Size = New System.Drawing.Size(45, 13)
        Me.Reporte.TabIndex = 18
        Me.Reporte.Text = "Reporte"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(393, 447)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 19
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(488, 447)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 20
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(585, 447)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkActivo)
        Me.GroupBox2.Controls.Add(Me.chkRecuperado)
        Me.GroupBox2.Controls.Add(Me.chkFallecido)
        Me.GroupBox2.Controls.Add(Me.chkNegativo)
        Me.GroupBox2.Controls.Add(Me.chkPositivo)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 106)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado Prueba"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(104, 66)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.TabStop = False
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkRecuperado
        '
        Me.chkRecuperado.AutoSize = True
        Me.chkRecuperado.Enabled = False
        Me.chkRecuperado.Location = New System.Drawing.Point(174, 66)
        Me.chkRecuperado.Name = "chkRecuperado"
        Me.chkRecuperado.Size = New System.Drawing.Size(85, 17)
        Me.chkRecuperado.TabIndex = 3
        Me.chkRecuperado.TabStop = False
        Me.chkRecuperado.Text = "Recuparado"
        Me.chkRecuperado.UseVisualStyleBackColor = True
        '
        'chkFallecido
        '
        Me.chkFallecido.AutoSize = True
        Me.chkFallecido.Enabled = False
        Me.chkFallecido.Location = New System.Drawing.Point(18, 66)
        Me.chkFallecido.Name = "chkFallecido"
        Me.chkFallecido.Size = New System.Drawing.Size(68, 17)
        Me.chkFallecido.TabIndex = 2
        Me.chkFallecido.TabStop = False
        Me.chkFallecido.Text = "Fallecido"
        Me.chkFallecido.UseVisualStyleBackColor = True
        '
        'chkNegativo
        '
        Me.chkNegativo.AutoSize = True
        Me.chkNegativo.Location = New System.Drawing.Point(153, 33)
        Me.chkNegativo.Name = "chkNegativo"
        Me.chkNegativo.Size = New System.Drawing.Size(69, 17)
        Me.chkNegativo.TabIndex = 1
        Me.chkNegativo.Text = "Negativo"
        Me.chkNegativo.UseVisualStyleBackColor = True
        '
        'chkPositivo
        '
        Me.chkPositivo.AutoSize = True
        Me.chkPositivo.Location = New System.Drawing.Point(19, 33)
        Me.chkPositivo.Name = "chkPositivo"
        Me.chkPositivo.Size = New System.Drawing.Size(63, 17)
        Me.chkPositivo.TabIndex = 0
        Me.chkPositivo.Text = "Positivo"
        Me.chkPositivo.UseVisualStyleBackColor = True
        '
        'cmbDepartamentos
        '
        Me.cmbDepartamentos.FormattingEnabled = True
        Me.cmbDepartamentos.Items.AddRange(New Object() {"Atlantida", "Choluteca", "Colon", "Comayagua", "Copan", "Cortes", "El Paraiso", "Francisco Morazan", "Gracias a Dios", "Intibuca", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Barbara", "Valle", "Yoro"})
        Me.cmbDepartamentos.Location = New System.Drawing.Point(192, 154)
        Me.cmbDepartamentos.Name = "cmbDepartamentos"
        Me.cmbDepartamentos.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepartamentos.TabIndex = 5
        '
        'txtNumRecuperados
        '
        Me.txtNumRecuperados.Location = New System.Drawing.Point(395, 373)
        Me.txtNumRecuperados.Name = "txtNumRecuperados"
        Me.txtNumRecuperados.Size = New System.Drawing.Size(80, 20)
        Me.txtNumRecuperados.TabIndex = 24
        '
        'txtNumActivos
        '
        Me.txtNumActivos.Location = New System.Drawing.Point(481, 373)
        Me.txtNumActivos.Name = "txtNumActivos"
        Me.txtNumActivos.Size = New System.Drawing.Size(78, 20)
        Me.txtNumActivos.TabIndex = 25
        '
        'txtNumFallecido
        '
        Me.txtNumFallecido.Location = New System.Drawing.Point(565, 373)
        Me.txtNumFallecido.Name = "txtNumFallecido"
        Me.txtNumFallecido.Size = New System.Drawing.Size(83, 20)
        Me.txtNumFallecido.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Recuperados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(501, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Activos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(585, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Fallecidos"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 505)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumFallecido)
        Me.Controls.Add(Me.txtNumActivos)
        Me.Controls.Add(Me.txtNumRecuperados)
        Me.Controls.Add(Me.cmbDepartamentos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Reporte)
        Me.Controls.Add(Me.txtReporte)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtReporte As TextBox
    Friend WithEvents Reporte As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents chkRecuperado As CheckBox
    Friend WithEvents chkFallecido As CheckBox
    Friend WithEvents chkNegativo As CheckBox
    Friend WithEvents chkPositivo As CheckBox
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents txtNumRecuperados As TextBox
    Friend WithEvents txtNumActivos As TextBox
    Friend WithEvents txtNumFallecido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
