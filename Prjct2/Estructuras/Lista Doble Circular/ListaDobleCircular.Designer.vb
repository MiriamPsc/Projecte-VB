<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDobleCircular
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnEliminarLista = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnGuardarArchivo = New System.Windows.Forms.Button()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.txtEliminar = New System.Windows.Forms.TextBox()
        Me.btnEliminarNodo = New System.Windows.Forms.Button()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(471, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(87, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(437, 30)
        Me.lblTitulo.TabIndex = 68
        Me.lblTitulo.Text = "Lista Doblemente Enlazada Circular"
        '
        'btnEliminarLista
        '
        Me.btnEliminarLista.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminarLista.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarLista.Location = New System.Drawing.Point(130, 259)
        Me.btnEliminarLista.Name = "btnEliminarLista"
        Me.btnEliminarLista.Size = New System.Drawing.Size(89, 53)
        Me.btnEliminarLista.TabIndex = 67
        Me.btnEliminarLista.Text = "Eliminar lista"
        Me.btnEliminarLista.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCargar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(130, 223)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(89, 30)
        Me.btnCargar.TabIndex = 66
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnGuardarArchivo
        '
        Me.btnGuardarArchivo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGuardarArchivo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarArchivo.Location = New System.Drawing.Point(130, 166)
        Me.btnGuardarArchivo.Name = "btnGuardarArchivo"
        Me.btnGuardarArchivo.Size = New System.Drawing.Size(89, 51)
        Me.btnGuardarArchivo.TabIndex = 65
        Me.btnGuardarArchivo.Text = "Guardar Archivo"
        Me.btnGuardarArchivo.UseVisualStyleBackColor = False
        '
        'btnContar
        '
        Me.btnContar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnContar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContar.Location = New System.Drawing.Point(130, 130)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(89, 30)
        Me.btnContar.TabIndex = 64
        Me.btnContar.Text = "Contar"
        Me.btnContar.UseVisualStyleBackColor = False
        '
        'txtEliminar
        '
        Me.txtEliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEliminar.Location = New System.Drawing.Point(10, 97)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(114, 26)
        Me.txtEliminar.TabIndex = 63
        '
        'btnEliminarNodo
        '
        Me.btnEliminarNodo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminarNodo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarNodo.Location = New System.Drawing.Point(130, 94)
        Me.btnEliminarNodo.Name = "btnEliminarNodo"
        Me.btnEliminarNodo.Size = New System.Drawing.Size(89, 30)
        Me.btnEliminarNodo.TabIndex = 62
        Me.btnEliminarNodo.Text = "Eliminar dato"
        Me.btnEliminarNodo.UseVisualStyleBackColor = False
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblLista.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLista.Location = New System.Drawing.Point(230, 61)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(14, 20)
        Me.lblLista.TabIndex = 61
        Me.lblLista.Text = "-"
        '
        'txtNodo
        '
        Me.txtNodo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNodo.Location = New System.Drawing.Point(10, 58)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(114, 26)
        Me.txtNodo.TabIndex = 60
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(130, 58)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 30)
        Me.btnGuardar.TabIndex = 59
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'ListaDobleCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(570, 359)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnEliminarLista)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGuardarArchivo)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.btnEliminarNodo)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.btnGuardar)
        Me.MaximizeBox = False
        Me.Name = "ListaDobleCircular"
        Me.Text = "ListaDobleCircular"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button1 As Button
    Private WithEvents lblTitulo As Label
    Private WithEvents btnEliminarLista As Button
    Private WithEvents btnCargar As Button
    Private WithEvents btnGuardarArchivo As Button
    Private WithEvents btnContar As Button
    Private WithEvents txtEliminar As TextBox
    Private WithEvents btnEliminarNodo As Button
    Private WithEvents lblLista As Label
    Private WithEvents txtNodo As TextBox
    Private WithEvents btnGuardar As Button
End Class
