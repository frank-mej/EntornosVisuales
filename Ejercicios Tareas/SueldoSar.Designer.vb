<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SueldoSar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.chkDeduccion = New System.Windows.Forms.CheckBox()
        Me.chkExento = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar Sueldo"
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(171, 69)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtIngresar.TabIndex = 1
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(171, 132)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 2
        '
        'chkDeduccion
        '
        Me.chkDeduccion.AutoSize = True
        Me.chkDeduccion.Location = New System.Drawing.Point(171, 181)
        Me.chkDeduccion.Name = "chkDeduccion"
        Me.chkDeduccion.Size = New System.Drawing.Size(78, 17)
        Me.chkDeduccion.TabIndex = 3
        Me.chkDeduccion.Text = "Deduccion"
        Me.chkDeduccion.UseVisualStyleBackColor = True
        '
        'chkExento
        '
        Me.chkExento.AutoSize = True
        Me.chkExento.Location = New System.Drawing.Point(171, 230)
        Me.chkExento.Name = "chkExento"
        Me.chkExento.Size = New System.Drawing.Size(59, 17)
        Me.chkExento.TabIndex = 4
        Me.chkExento.Text = "Exento"
        Me.chkExento.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sueldo Neto"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(269, 287)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(174, 287)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(79, 287)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 20
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'SueldoSar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(444, 362)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkExento)
        Me.Controls.Add(Me.chkDeduccion)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SueldoSar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SueldoSar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents chkDeduccion As CheckBox
    Friend WithEvents chkExento As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
End Class
