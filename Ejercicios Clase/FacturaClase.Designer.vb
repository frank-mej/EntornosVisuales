<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaClase
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxISV = New System.Windows.Forms.ComboBox()
        Me.cbxDescuento = New System.Windows.Forms.ComboBox()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.chkISV = New System.Windows.Forms.CheckBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPunitario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(343, 119)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Location = New System.Drawing.Point(343, 79)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(343, 37)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtISV)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Location = New System.Drawing.Point(78, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 195)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ISV "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descuento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subtotal"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(104, 154)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 3
        '
        'txtISV
        '
        Me.txtISV.Location = New System.Drawing.Point(104, 109)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(100, 20)
        Me.txtISV.TabIndex = 2
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(104, 64)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 1
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(104, 19)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxISV)
        Me.GroupBox1.Controls.Add(Me.cbxDescuento)
        Me.GroupBox1.Controls.Add(Me.chkDescuento)
        Me.GroupBox1.Controls.Add(Me.chkISV)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtPunitario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 251)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'cbxISV
        '
        Me.cbxISV.Enabled = False
        Me.cbxISV.FormattingEnabled = True
        Me.cbxISV.Items.AddRange(New Object() {"ISV 15%", "ISV 17%"})
        Me.cbxISV.Location = New System.Drawing.Point(25, 204)
        Me.cbxISV.Name = "cbxISV"
        Me.cbxISV.Size = New System.Drawing.Size(201, 21)
        Me.cbxISV.TabIndex = 9
        Me.cbxISV.Text = "Selecciona tipo de impuesto"
        '
        'cbxDescuento
        '
        Me.cbxDescuento.Enabled = False
        Me.cbxDescuento.FormattingEnabled = True
        Me.cbxDescuento.Items.AddRange(New Object() {"Descuento de la tercera edad", "Descuento ordinario", "Descuento Forfait", "Descuento por volumen", "Descuento por pronto pago", "Descuento por navidad"})
        Me.cbxDescuento.Location = New System.Drawing.Point(25, 136)
        Me.cbxDescuento.Name = "cbxDescuento"
        Me.cbxDescuento.Size = New System.Drawing.Size(201, 21)
        Me.cbxDescuento.TabIndex = 8
        Me.cbxDescuento.Text = "Seleccionar un descuento"
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Location = New System.Drawing.Point(25, 113)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(113, 17)
        Me.chkDescuento.TabIndex = 7
        Me.chkDescuento.Text = "Aplicar Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'chkISV
        '
        Me.chkISV.AutoSize = True
        Me.chkISV.Location = New System.Drawing.Point(25, 181)
        Me.chkISV.Name = "chkISV"
        Me.chkISV.Size = New System.Drawing.Size(78, 17)
        Me.chkISV.TabIndex = 6
        Me.chkISV.Text = "Aplicar ISV"
        Me.chkISV.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(104, 70)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 5
        '
        'txtPunitario
        '
        Me.txtPunitario.Location = New System.Drawing.Point(104, 28)
        Me.txtPunitario.Name = "txtPunitario"
        Me.txtPunitario.Size = New System.Drawing.Size(100, 20)
        Me.txtPunitario.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "P. Unitario"
        '
        'FacturaClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 532)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FacturaClase"
        Me.Text = "FacturaClase"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxISV As ComboBox
    Friend WithEvents cbxDescuento As ComboBox
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents chkISV As CheckBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPunitario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
