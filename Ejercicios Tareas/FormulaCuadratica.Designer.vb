<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaCuadratica
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
        Me.txtValorA = New System.Windows.Forms.TextBox()
        Me.txtValorB = New System.Windows.Forms.TextBox()
        Me.txtValorC = New System.Windows.Forms.TextBox()
        Me.txtValorX1 = New System.Windows.Forms.TextBox()
        Me.txtValorX2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formula General Cuadratica"
        '
        'txtValorA
        '
        Me.txtValorA.Location = New System.Drawing.Point(144, 79)
        Me.txtValorA.Name = "txtValorA"
        Me.txtValorA.Size = New System.Drawing.Size(100, 20)
        Me.txtValorA.TabIndex = 1
        '
        'txtValorB
        '
        Me.txtValorB.Location = New System.Drawing.Point(144, 130)
        Me.txtValorB.Name = "txtValorB"
        Me.txtValorB.Size = New System.Drawing.Size(100, 20)
        Me.txtValorB.TabIndex = 2
        '
        'txtValorC
        '
        Me.txtValorC.Location = New System.Drawing.Point(144, 174)
        Me.txtValorC.Name = "txtValorC"
        Me.txtValorC.Size = New System.Drawing.Size(100, 20)
        Me.txtValorC.TabIndex = 3
        '
        'txtValorX1
        '
        Me.txtValorX1.Location = New System.Drawing.Point(404, 92)
        Me.txtValorX1.Name = "txtValorX1"
        Me.txtValorX1.Size = New System.Drawing.Size(100, 20)
        Me.txtValorX1.TabIndex = 4
        '
        'txtValorX2
        '
        Me.txtValorX2.Location = New System.Drawing.Point(404, 158)
        Me.txtValorX2.Name = "txtValorX2"
        Me.txtValorX2.Size = New System.Drawing.Size(100, 20)
        Me.txtValorX2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Valor de A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Valor de B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Valor de C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Valor X1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Valor X2"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(144, 229)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(239, 229)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(334, 229)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FormulaCuadratica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(562, 283)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValorX2)
        Me.Controls.Add(Me.txtValorX1)
        Me.Controls.Add(Me.txtValorC)
        Me.Controls.Add(Me.txtValorB)
        Me.Controls.Add(Me.txtValorA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormulaCuadratica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormulaCuadratica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorA As TextBox
    Friend WithEvents txtValorB As TextBox
    Friend WithEvents txtValorC As TextBox
    Friend WithEvents txtValorX1 As TextBox
    Friend WithEvents txtValorX2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVolver As Button
End Class
