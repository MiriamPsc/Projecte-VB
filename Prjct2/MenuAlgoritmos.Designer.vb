<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAlgoritmos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.Location = New System.Drawing.Point(12, 12)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(160, 100)
        Me.button8.TabIndex = 30
        Me.button8.Text = "BURBUJA"
        Me.button8.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(101, 118)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(160, 100)
        Me.button4.TabIndex = 27
        Me.button4.Text = "COUNTINGSORT"
        Me.button4.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(267, 118)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(160, 100)
        Me.button3.TabIndex = 26
        Me.button3.Text = "RADIX"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(344, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(160, 100)
        Me.button2.TabIndex = 25
        Me.button2.Text = "INSERCIÓN (SHELLSORT)"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(178, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(160, 100)
        Me.button1.TabIndex = 24
        Me.button1.Text = "BURBUJA BIDIRECCIONAL (COCKTAILSORT)"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(460, 208)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 35)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "VOLVER"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MenuAlgoritmos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(562, 255)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "MenuAlgoritmos"
        Me.Text = "MenuAlgoritmos"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button8 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents Button6 As Button
End Class
