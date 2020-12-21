<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Burbuja
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
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblTiempoOrdenar = New System.Windows.Forms.Label()
        Me.lblComparaciones = New System.Windows.Forms.Label()
        Me.txtMay = New System.Windows.Forms.TextBox()
        Me.lblO = New System.Windows.Forms.Label()
        Me.lblIntercambios = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtMen = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblI = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNumeros = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(338, 294)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 26)
        Me.Button6.TabIndex = 79
        Me.Button6.Text = "Volver"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(339, 260)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(88, 29)
        Me.btnEliminar.TabIndex = 78
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrden.Location = New System.Drawing.Point(258, 111)
        Me.lblOrden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(15, 21)
        Me.lblOrden.TabIndex = 77
        Me.lblOrden.Text = "-"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(258, 55)
        Me.lblNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(15, 21)
        Me.lblNum.TabIndex = 76
        Me.lblNum.Text = "-"
        '
        'lblTiempoOrdenar
        '
        Me.lblTiempoOrdenar.AutoSize = True
        Me.lblTiempoOrdenar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTiempoOrdenar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoOrdenar.Location = New System.Drawing.Point(158, 265)
        Me.lblTiempoOrdenar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTiempoOrdenar.Name = "lblTiempoOrdenar"
        Me.lblTiempoOrdenar.Size = New System.Drawing.Size(29, 20)
        Me.lblTiempoOrdenar.TabIndex = 62
        Me.lblTiempoOrdenar.Text = "0:0"
        '
        'lblComparaciones
        '
        Me.lblComparaciones.AutoSize = True
        Me.lblComparaciones.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblComparaciones.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComparaciones.Location = New System.Drawing.Point(169, 245)
        Me.lblComparaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComparaciones.Name = "lblComparaciones"
        Me.lblComparaciones.Size = New System.Drawing.Size(17, 20)
        Me.lblComparaciones.TabIndex = 66
        Me.lblComparaciones.Text = "0"
        '
        'txtMay
        '
        Me.txtMay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMay.Location = New System.Drawing.Point(160, 111)
        Me.txtMay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMay.Name = "txtMay"
        Me.txtMay.Size = New System.Drawing.Size(76, 27)
        Me.txtMay.TabIndex = 75
        '
        'lblO
        '
        Me.lblO.AutoSize = True
        Me.lblO.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblO.Location = New System.Drawing.Point(85, 265)
        Me.lblO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblO.Name = "lblO"
        Me.lblO.Size = New System.Drawing.Size(64, 20)
        Me.lblO.TabIndex = 64
        Me.lblO.Text = "Tiempo:"
        '
        'lblIntercambios
        '
        Me.lblIntercambios.AutoSize = True
        Me.lblIntercambios.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblIntercambios.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntercambios.Location = New System.Drawing.Point(169, 225)
        Me.lblIntercambios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntercambios.Name = "lblIntercambios"
        Me.lblIntercambios.Size = New System.Drawing.Size(17, 20)
        Me.lblIntercambios.TabIndex = 61
        Me.lblIntercambios.Text = "0"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblC.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(18, 245)
        Me.lblC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(131, 20)
        Me.lblC.TabIndex = 65
        Me.lblC.Text = "Comparaciones:"
        '
        'txtMen
        '
        Me.txtMen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMen.Location = New System.Drawing.Point(160, 80)
        Me.txtMen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMen.Name = "txtMen"
        Me.txtMen.Size = New System.Drawing.Size(76, 27)
        Me.txtMen.TabIndex = 74
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(24, 114)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(125, 21)
        Me.label2.TabIndex = 73
        Me.label2.Text = "Limite Maximo:"
        '
        'lblI
        '
        Me.lblI.AutoSize = True
        Me.lblI.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblI.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblI.Location = New System.Drawing.Point(44, 225)
        Me.lblI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(109, 20)
        Me.lblI.TabIndex = 63
        Me.lblI.Text = "Intercambios:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(30, 83)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(119, 21)
        Me.label1.TabIndex = 72
        Me.label1.Text = "Limite Minimo:"
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrdenar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenar.Location = New System.Drawing.Point(339, 216)
        Me.btnOrdenar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(88, 29)
        Me.btnOrdenar.TabIndex = 71
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGenerar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(98, 153)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(88, 29)
        Me.btnGenerar.TabIndex = 70
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(118, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(284, 30)
        Me.lblTitulo.TabIndex = 69
        Me.lblTitulo.Text = "Ordenamiento Burbuja"
        '
        'lblNumeros
        '
        Me.lblNumeros.AutoSize = True
        Me.lblNumeros.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblNumeros.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeros.Location = New System.Drawing.Point(67, 52)
        Me.lblNumeros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeros.Name = "lblNumeros"
        Me.lblNumeros.Size = New System.Drawing.Size(82, 21)
        Me.lblNumeros.TabIndex = 68
        Me.lblNumeros.Text = "Numeros:"
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(161, 49)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(76, 27)
        Me.txtNum.TabIndex = 67
        '
        'Burbuja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(542, 346)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblTiempoOrdenar)
        Me.Controls.Add(Me.lblComparaciones)
        Me.Controls.Add(Me.txtMay)
        Me.Controls.Add(Me.lblO)
        Me.Controls.Add(Me.lblIntercambios)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.txtMen)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lblI)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblNumeros)
        Me.Controls.Add(Me.txtNum)
        Me.MaximizeBox = False
        Me.Name = "Burbuja"
        Me.Text = "Burbuja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button6 As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents lblOrden As Label
    Private WithEvents lblNum As Label
    Private WithEvents lblTiempoOrdenar As Label
    Private WithEvents lblComparaciones As Label
    Private WithEvents txtMay As TextBox
    Private WithEvents lblO As Label
    Private WithEvents lblIntercambios As Label
    Private WithEvents lblC As Label
    Private WithEvents txtMen As TextBox
    Private WithEvents label2 As Label
    Private WithEvents lblI As Label
    Private WithEvents label1 As Label
    Private WithEvents btnOrdenar As Button
    Private WithEvents btnGenerar As Button
    Private WithEvents lblTitulo As Label
    Private WithEvents lblNumeros As Label
    Private WithEvents txtNum As TextBox
End Class
