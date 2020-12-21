<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pilas
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.lblPila = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(465, 298)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(89, 26)
        Me.Button7.TabIndex = 70
        Me.Button7.Text = "Volver"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.Location = New System.Drawing.Point(104, 263)
        Me.button6.Margin = New System.Windows.Forms.Padding(2)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(85, 56)
        Me.button6.TabIndex = 69
        Me.button6.Text = "Eliminar pila"
        Me.button6.UseVisualStyleBackColor = False
        '
        'lblPila
        '
        Me.lblPila.AutoSize = True
        Me.lblPila.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblPila.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPila.Location = New System.Drawing.Point(194, 46)
        Me.lblPila.Name = "lblPila"
        Me.lblPila.Size = New System.Drawing.Size(21, 30)
        Me.lblPila.TabIndex = 68
        Me.lblPila.Text = "-"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.Location = New System.Drawing.Point(104, 203)
        Me.button5.Margin = New System.Windows.Forms.Padding(2)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(85, 56)
        Me.button5.TabIndex = 67
        Me.button5.Text = "Abrir archivo"
        Me.button5.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(104, 143)
        Me.button4.Margin = New System.Windows.Forms.Padding(2)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(85, 56)
        Me.button4.TabIndex = 66
        Me.button4.Text = "Guardar archivo"
        Me.button4.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(227, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(55, 30)
        Me.lblTitulo.TabIndex = 65
        Me.lblTitulo.Text = "Pila"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(104, 110)
        Me.button3.Margin = New System.Windows.Forms.Padding(2)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(85, 29)
        Me.button3.TabIndex = 64
        Me.button3.Text = "Contar"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(104, 77)
        Me.button2.Margin = New System.Windows.Forms.Padding(2)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(85, 29)
        Me.button2.TabIndex = 63
        Me.button2.Text = "Pop"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(104, 46)
        Me.button1.Margin = New System.Windows.Forms.Padding(2)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(85, 29)
        Me.button1.TabIndex = 62
        Me.button1.Text = "Push"
        Me.button1.UseVisualStyleBackColor = False
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(8, 48)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(92, 27)
        Me.textBox1.TabIndex = 61
        '
        'Pilas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(566, 336)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.lblPila)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.MaximizeBox = False
        Me.Name = "Pilas"
        Me.Text = "Pilas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents lblPila As Label
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents lblTitulo As Label
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
End Class
