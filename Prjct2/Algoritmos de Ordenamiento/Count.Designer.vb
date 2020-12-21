<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Count
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAleatorio = New System.Windows.Forms.Button()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.txTamaño = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCrearArreglo = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblArregloDesordenado = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.lblInvertido = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblOrdenado = New System.Windows.Forms.Label()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(408, 109)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 35)
        Me.Button6.TabIndex = 78
        Me.Button6.Text = "Volver"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(408, 67)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 36)
        Me.btnEliminar.TabIndex = 77
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(217, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(87, 30)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.Text = "Count"
        '
        'btnAleatorio
        '
        Me.btnAleatorio.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAleatorio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAleatorio.Location = New System.Drawing.Point(308, 107)
        Me.btnAleatorio.Name = "btnAleatorio"
        Me.btnAleatorio.Size = New System.Drawing.Size(94, 36)
        Me.btnAleatorio.TabIndex = 66
        Me.btnAleatorio.Text = "Aleatorio"
        Me.btnAleatorio.UseVisualStyleBackColor = False
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTiempo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(218, 236)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(15, 21)
        Me.lblTiempo.TabIndex = 74
        Me.lblTiempo.Text = "-"
        '
        'txTamaño
        '
        Me.txTamaño.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTamaño.Location = New System.Drawing.Point(178, 72)
        Me.txTamaño.Name = "txTamaño"
        Me.txTamaño.Size = New System.Drawing.Size(63, 27)
        Me.txTamaño.TabIndex = 60
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(49, 236)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(146, 21)
        Me.label1.TabIndex = 73
        Me.label1.Text = "TIempo elapsado"
        '
        'btnCrearArreglo
        '
        Me.btnCrearArreglo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCrearArreglo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearArreglo.Location = New System.Drawing.Point(308, 67)
        Me.btnCrearArreglo.Name = "btnCrearArreglo"
        Me.btnCrearArreglo.Size = New System.Drawing.Size(94, 36)
        Me.btnCrearArreglo.TabIndex = 65
        Me.btnCrearArreglo.Text = "Crear"
        Me.btnCrearArreglo.UseVisualStyleBackColor = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(197, 107)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(44, 21)
        Me.label9.TabIndex = 64
        Me.label9.Text = "Max"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(46, 181)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(149, 21)
        Me.label11.TabIndex = 71
        Me.label11.Text = "Arreglo ordenado"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(12, 75)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(162, 21)
        Me.label5.TabIndex = 58
        Me.label5.Text = "Tamaño del arreglo"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(80, 108)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(38, 21)
        Me.label3.TabIndex = 63
        Me.label3.Text = "Min"
        '
        'lblArregloDesordenado
        '
        Me.lblArregloDesordenado.AutoSize = True
        Me.lblArregloDesordenado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArregloDesordenado.Location = New System.Drawing.Point(174, 106)
        Me.lblArregloDesordenado.Name = "lblArregloDesordenado"
        Me.lblArregloDesordenado.Size = New System.Drawing.Size(0, 21)
        Me.lblArregloDesordenado.TabIndex = 75
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(12, 108)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(62, 21)
        Me.label7.TabIndex = 59
        Me.label7.Text = "Rango"
        '
        'lblInvertido
        '
        Me.lblInvertido.AutoSize = True
        Me.lblInvertido.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblInvertido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvertido.Location = New System.Drawing.Point(218, 207)
        Me.lblInvertido.Name = "lblInvertido"
        Me.lblInvertido.Size = New System.Drawing.Size(15, 21)
        Me.lblInvertido.TabIndex = 67
        Me.lblInvertido.Text = "-"
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(124, 104)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(33, 27)
        Me.txtMin.TabIndex = 62
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(19, 155)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(176, 21)
        Me.label6.TabIndex = 69
        Me.label6.Text = "Arreglo desordenado"
        '
        'txtMax
        '
        Me.txtMax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(257, 104)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(33, 27)
        Me.txtMax.TabIndex = 61
        '
        'lblOrdenado
        '
        Me.lblOrdenado.AutoSize = True
        Me.lblOrdenado.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblOrdenado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenado.Location = New System.Drawing.Point(218, 181)
        Me.lblOrdenado.Name = "lblOrdenado"
        Me.lblOrdenado.Size = New System.Drawing.Size(15, 21)
        Me.lblOrdenado.TabIndex = 68
        Me.lblOrdenado.Text = "-"
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblOriginal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginal.Location = New System.Drawing.Point(218, 155)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(15, 21)
        Me.lblOriginal.TabIndex = 70
        Me.lblOriginal.Text = "-"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(55, 207)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(140, 21)
        Me.label12.TabIndex = 72
        Me.label12.Text = "Arreglo invertido"
        '
        'Count
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(526, 325)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnAleatorio)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.txTamaño)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnCrearArreglo)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblArregloDesordenado)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.lblInvertido)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.lblOrdenado)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.label12)
        Me.Name = "Count"
        Me.Text = "Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button6 As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents lblTitulo As Label
    Private WithEvents btnAleatorio As Button
    Private WithEvents lblTiempo As Label
    Private WithEvents txTamaño As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btnCrearArreglo As Button
    Private WithEvents label9 As Label
    Private WithEvents label11 As Label
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents lblArregloDesordenado As Label
    Private WithEvents label7 As Label
    Private WithEvents lblInvertido As Label
    Private WithEvents txtMin As TextBox
    Private WithEvents label6 As Label
    Private WithEvents txtMax As TextBox
    Private WithEvents lblOrdenado As Label
    Private WithEvents lblOriginal As Label
    Private WithEvents label12 As Label
End Class
