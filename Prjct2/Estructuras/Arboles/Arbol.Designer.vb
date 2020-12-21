<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arbol
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnAltura = New System.Windows.Forms.Button()
        Me.btnIdentificar = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnPostOrden = New System.Windows.Forms.RadioButton()
        Me.rbtnOrden = New System.Windows.Forms.RadioButton()
        Me.rbtnPreOrden = New System.Windows.Forms.RadioButton()
        Me.btnRecorrer = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(700, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(419, 407)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(157, 32)
        Me.btnGuardar.TabIndex = 57
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCargar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(419, 369)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(157, 32)
        Me.btnCargar.TabIndex = 56
        Me.btnCargar.Text = "CARGAR ÁRBOL"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnAltura
        '
        Me.btnAltura.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAltura.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltura.Location = New System.Drawing.Point(419, 331)
        Me.btnAltura.Name = "btnAltura"
        Me.btnAltura.Size = New System.Drawing.Size(157, 32)
        Me.btnAltura.TabIndex = 55
        Me.btnAltura.Text = "DETERMINAR ALTURA"
        Me.btnAltura.UseVisualStyleBackColor = False
        '
        'btnIdentificar
        '
        Me.btnIdentificar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnIdentificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIdentificar.Location = New System.Drawing.Point(419, 293)
        Me.btnIdentificar.Name = "btnIdentificar"
        Me.btnIdentificar.Size = New System.Drawing.Size(157, 32)
        Me.btnIdentificar.TabIndex = 54
        Me.btnIdentificar.Text = "IDENTIFICAR"
        Me.btnIdentificar.UseVisualStyleBackColor = False
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato.Location = New System.Drawing.Point(121, 277)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(100, 27)
        Me.txtDato.TabIndex = 52
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(415, 269)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(291, 21)
        Me.label1.TabIndex = 48
        Me.label1.Text = "ENCONTRAR EL MÁXIMO Y MÍNIMO"
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnInsertar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar.Location = New System.Drawing.Point(12, 274)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(103, 30)
        Me.btnInsertar.TabIndex = 49
        Me.btnInsertar.Text = "INSERTAR"
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(12, 346)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(103, 30)
        Me.btnEliminar.TabIndex = 50
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.groupBox1.Controls.Add(Me.rbtnPostOrden)
        Me.groupBox1.Controls.Add(Me.rbtnOrden)
        Me.groupBox1.Controls.Add(Me.rbtnPreOrden)
        Me.groupBox1.Controls.Add(Me.btnRecorrer)
        Me.groupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(227, 274)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(168, 159)
        Me.groupBox1.TabIndex = 53
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "RECORRER"
        '
        'rbtnPostOrden
        '
        Me.rbtnPostOrden.AutoSize = True
        Me.rbtnPostOrden.Location = New System.Drawing.Point(22, 77)
        Me.rbtnPostOrden.Name = "rbtnPostOrden"
        Me.rbtnPostOrden.Size = New System.Drawing.Size(137, 25)
        Me.rbtnPostOrden.TabIndex = 7
        Me.rbtnPostOrden.TabStop = True
        Me.rbtnPostOrden.Text = "POST - ORDEN"
        Me.rbtnPostOrden.UseVisualStyleBackColor = True
        '
        'rbtnOrden
        '
        Me.rbtnOrden.AutoSize = True
        Me.rbtnOrden.Location = New System.Drawing.Point(22, 26)
        Me.rbtnOrden.Name = "rbtnOrden"
        Me.rbtnOrden.Size = New System.Drawing.Size(85, 25)
        Me.rbtnOrden.TabIndex = 5
        Me.rbtnOrden.TabStop = True
        Me.rbtnOrden.Text = "ORDEN"
        Me.rbtnOrden.UseVisualStyleBackColor = True
        '
        'rbtnPreOrden
        '
        Me.rbtnPreOrden.AutoSize = True
        Me.rbtnPreOrden.Location = New System.Drawing.Point(22, 50)
        Me.rbtnPreOrden.Name = "rbtnPreOrden"
        Me.rbtnPreOrden.Size = New System.Drawing.Size(126, 25)
        Me.rbtnPreOrden.TabIndex = 6
        Me.rbtnPreOrden.TabStop = True
        Me.rbtnPreOrden.Text = "PRE - ORDEN"
        Me.rbtnPreOrden.UseVisualStyleBackColor = True
        '
        'btnRecorrer
        '
        Me.btnRecorrer.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRecorrer.Location = New System.Drawing.Point(31, 108)
        Me.btnRecorrer.Name = "btnRecorrer"
        Me.btnRecorrer.Size = New System.Drawing.Size(110, 34)
        Me.btnRecorrer.TabIndex = 4
        Me.btnRecorrer.Text = "RECORRER"
        Me.btnRecorrer.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(12, 310)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 30)
        Me.btnBuscar.TabIndex = 51
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Arbol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnAltura)
        Me.Controls.Add(Me.btnIdentificar)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.MaximizeBox = False
        Me.Name = "Arbol"
        Me.Text = "Arbol"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button1 As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnCargar As Button
    Private WithEvents btnAltura As Button
    Private WithEvents btnIdentificar As Button
    Private WithEvents txtDato As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btnInsertar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents rbtnPostOrden As RadioButton
    Private WithEvents rbtnOrden As RadioButton
    Private WithEvents rbtnPreOrden As RadioButton
    Private WithEvents btnRecorrer As Button
    Private WithEvents btnBuscar As Button
End Class
