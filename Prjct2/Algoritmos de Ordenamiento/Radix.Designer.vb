<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Radix
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblComparaciones = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblO = New System.Windows.Forms.Label()
        Me.lblI = New System.Windows.Forms.Label()
        Me.lblTiempoOrdenar = New System.Windows.Forms.Label()
        Me.lblIntercambios = New System.Windows.Forms.Label()
        Me.lbOrdenar = New System.Windows.Forms.ListBox()
        Me.lbNum = New System.Windows.Forms.ListBox()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNumeros = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(341, 270)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(88, 29)
        Me.btnEliminar.TabIndex = 63
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtMax
        '
        Me.txtMax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(151, 127)
        Me.txtMax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(76, 27)
        Me.txtMax.TabIndex = 62
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(151, 96)
        Me.txtMin.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(76, 27)
        Me.txtMin.TabIndex = 61
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(17, 130)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(125, 21)
        Me.label2.TabIndex = 60
        Me.label2.Text = "Limite Maximo:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(23, 99)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(119, 21)
        Me.label1.TabIndex = 59
        Me.label1.Text = "Limite Minimo:"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.groupBox1.Controls.Add(Me.lblComparaciones)
        Me.groupBox1.Controls.Add(Me.lblC)
        Me.groupBox1.Controls.Add(Me.lblO)
        Me.groupBox1.Controls.Add(Me.lblI)
        Me.groupBox1.Controls.Add(Me.lblTiempoOrdenar)
        Me.groupBox1.Controls.Add(Me.lblIntercambios)
        Me.groupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(21, 242)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Size = New System.Drawing.Size(232, 112)
        Me.groupBox1.TabIndex = 58
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tiempo de ejecucion"
        '
        'lblComparaciones
        '
        Me.lblComparaciones.AutoSize = True
        Me.lblComparaciones.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblComparaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComparaciones.Location = New System.Drawing.Point(109, 51)
        Me.lblComparaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComparaciones.Name = "lblComparaciones"
        Me.lblComparaciones.Size = New System.Drawing.Size(14, 15)
        Me.lblComparaciones.TabIndex = 13
        Me.lblComparaciones.Text = "0"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(15, 51)
        Me.lblC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(97, 15)
        Me.lblC.TabIndex = 12
        Me.lblC.Text = "Comparaciones:"
        '
        'lblO
        '
        Me.lblO.AutoSize = True
        Me.lblO.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblO.Location = New System.Drawing.Point(15, 73)
        Me.lblO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblO.Name = "lblO"
        Me.lblO.Size = New System.Drawing.Size(55, 15)
        Me.lblO.TabIndex = 11
        Me.lblO.Text = "Ordenar:"
        '
        'lblI
        '
        Me.lblI.AutoSize = True
        Me.lblI.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblI.Location = New System.Drawing.Point(15, 28)
        Me.lblI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(78, 15)
        Me.lblI.TabIndex = 10
        Me.lblI.Text = "Intercambios"
        '
        'lblTiempoOrdenar
        '
        Me.lblTiempoOrdenar.AutoSize = True
        Me.lblTiempoOrdenar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTiempoOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoOrdenar.Location = New System.Drawing.Point(77, 73)
        Me.lblTiempoOrdenar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTiempoOrdenar.Name = "lblTiempoOrdenar"
        Me.lblTiempoOrdenar.Size = New System.Drawing.Size(24, 15)
        Me.lblTiempoOrdenar.TabIndex = 1
        Me.lblTiempoOrdenar.Text = "0:0"
        '
        'lblIntercambios
        '
        Me.lblIntercambios.AutoSize = True
        Me.lblIntercambios.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblIntercambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntercambios.Location = New System.Drawing.Point(110, 28)
        Me.lblIntercambios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntercambios.Name = "lblIntercambios"
        Me.lblIntercambios.Size = New System.Drawing.Size(14, 15)
        Me.lblIntercambios.TabIndex = 0
        Me.lblIntercambios.Text = "0"
        '
        'lbOrdenar
        '
        Me.lbOrdenar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOrdenar.FormattingEnabled = True
        Me.lbOrdenar.ItemHeight = 21
        Me.lbOrdenar.Location = New System.Drawing.Point(398, 55)
        Me.lbOrdenar.Margin = New System.Windows.Forms.Padding(2)
        Me.lbOrdenar.Name = "lbOrdenar"
        Me.lbOrdenar.Size = New System.Drawing.Size(101, 151)
        Me.lbOrdenar.TabIndex = 57
        '
        'lbNum
        '
        Me.lbNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNum.FormattingEnabled = True
        Me.lbNum.ItemHeight = 21
        Me.lbNum.Location = New System.Drawing.Point(279, 55)
        Me.lbNum.Margin = New System.Windows.Forms.Padding(2)
        Me.lbNum.Name = "lbNum"
        Me.lbNum.Size = New System.Drawing.Size(99, 151)
        Me.lbNum.TabIndex = 56
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrdenar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenar.Location = New System.Drawing.Point(341, 230)
        Me.btnOrdenar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(88, 29)
        Me.btnOrdenar.TabIndex = 55
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGenerar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(84, 177)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(88, 29)
        Me.btnGenerar.TabIndex = 54
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(220, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(78, 30)
        Me.lblTitulo.TabIndex = 53
        Me.lblTitulo.Text = "Radix"
        '
        'lblNumeros
        '
        Me.lblNumeros.AutoSize = True
        Me.lblNumeros.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblNumeros.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeros.Location = New System.Drawing.Point(60, 68)
        Me.lblNumeros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeros.Name = "lblNumeros"
        Me.lblNumeros.Size = New System.Drawing.Size(82, 21)
        Me.lblNumeros.TabIndex = 52
        Me.lblNumeros.Text = "Numeros:"
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(152, 65)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(76, 27)
        Me.txtNum.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(341, 307)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Radix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(632, 373)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.lbOrdenar)
        Me.Controls.Add(Me.lbNum)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblNumeros)
        Me.Controls.Add(Me.txtNum)
        Me.MaximizeBox = False
        Me.Name = "Radix"
        Me.Text = "Radix"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnEliminar As Button
    Private WithEvents txtMax As TextBox
    Private WithEvents txtMin As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblComparaciones As Label
    Private WithEvents lblC As Label
    Private WithEvents lblO As Label
    Private WithEvents lblI As Label
    Private WithEvents lblTiempoOrdenar As Label
    Private WithEvents lblIntercambios As Label
    Private WithEvents lbOrdenar As ListBox
    Private WithEvents lbNum As ListBox
    Private WithEvents btnOrdenar As Button
    Private WithEvents btnGenerar As Button
    Private WithEvents lblTitulo As Label
    Private WithEvents lblNumeros As Label
    Private WithEvents txtNum As TextBox
    Private WithEvents Button1 As Button
End Class
