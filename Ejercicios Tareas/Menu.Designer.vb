﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLibreria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuLibreria))
        Me.btnClasicos = New System.Windows.Forms.Button()
        Me.btnRecientes = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClasicos
        '
        Me.btnClasicos.BackColor = System.Drawing.Color.Turquoise
        Me.btnClasicos.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClasicos.Location = New System.Drawing.Point(110, 102)
        Me.btnClasicos.Name = "btnClasicos"
        Me.btnClasicos.Size = New System.Drawing.Size(85, 31)
        Me.btnClasicos.TabIndex = 0
        Me.btnClasicos.Text = "Clasicos"
        Me.btnClasicos.UseVisualStyleBackColor = False
        '
        'btnRecientes
        '
        Me.btnRecientes.BackColor = System.Drawing.Color.Turquoise
        Me.btnRecientes.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecientes.Location = New System.Drawing.Point(110, 155)
        Me.btnRecientes.Name = "btnRecientes"
        Me.btnRecientes.Size = New System.Drawing.Size(85, 31)
        Me.btnRecientes.TabIndex = 1
        Me.btnRecientes.Text = "Recientes"
        Me.btnRecientes.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Turquoise
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(110, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Libreria"
        '
        'MenuLibreria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(334, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnRecientes)
        Me.Controls.Add(Me.btnClasicos)
        Me.Name = "MenuLibreria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClasicos As Button
    Friend WithEvents btnRecientes As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
End Class
