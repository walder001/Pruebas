﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label1.Location = New System.Drawing.Point(26, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(50, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Nombre: "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label2.Location = New System.Drawing.Point(29, 55)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(50, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Apellido: "
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(83, 25)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 2
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(86, 55)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 20)
		Me.TextBox2.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(679, 468)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.ForeColor = System.Drawing.SystemColors.ControlLight
		Me.Name = "Form1"
		Me.Text = "eu"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
End Class
