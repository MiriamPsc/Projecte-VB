<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cola
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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnDesencolar = New System.Windows.Forms.Button()
        Me.lblCola = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnEncolar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(451, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(191, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(158, 30)
        Me.lblTitulo.TabIndex = 56
        Me.lblTitulo.Text = "Cola Simple"
        '
        'btnEliminarLista
        '
        Me.btnEliminarLista.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminarLista.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarLista.Location = New System.Drawing.Point(133, 260)
        Me.btnEliminarLista.Name = "btnEliminarLista"
        Me.btnEliminarLista.Size = New System.Drawing.Size(112, 53)
        Me.btnEliminarLista.TabIndex = 55
        Me.btnEliminarLista.Text = "Eliminar Cola"
        Me.btnEliminarLista.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCargar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(133, 224)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(112, 30)
        Me.btnCargar.TabIndex = 54
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnGuardarArchivo
        '
        Me.btnGuardarArchivo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGuardarArchivo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarArchivo.Location = New System.Drawing.Point(133, 167)
        Me.btnGuardarArchivo.Name = "btnGuardarArchivo"
        Me.btnGuardarArchivo.Size = New System.Drawing.Size(112, 51)
        Me.btnGuardarArchivo.TabIndex = 53
        Me.btnGuardarArchivo.Text = "Guardar Archivo"
        Me.btnGuardarArchivo.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMostrar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(133, 131)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(112, 30)
        Me.btnMostrar.TabIndex = 52
        Me.btnMostrar.Text = "Consultar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'btnDesencolar
        '
        Me.btnDesencolar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDesencolar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesencolar.Location = New System.Drawing.Point(133, 95)
        Me.btnDesencolar.Name = "btnDesencolar"
        Me.btnDesencolar.Size = New System.Drawing.Size(112, 30)
        Me.btnDesencolar.TabIndex = 51
        Me.btnDesencolar.Text = "Desencolar"
        Me.btnDesencolar.UseVisualStyleBackColor = False
        '
        'lblCola
        '
        Me.lblCola.AutoSize = True
        Me.lblCola.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblCola.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCola.Location = New System.Drawing.Point(251, 64)
        Me.lblCola.Name = "lblCola"
        Me.lblCola.Size = New System.Drawing.Size(14, 20)
        Me.lblCola.TabIndex = 50
        Me.lblCola.Text = "-"
        '
        'txtNodo
        '
        Me.txtNodo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNodo.Location = New System.Drawing.Point(13, 61)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(114, 26)
        Me.txtNodo.TabIndex = 49
        '
        'btnEncolar
        '
        Me.btnEncolar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEncolar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncolar.Location = New System.Drawing.Point(133, 59)
        Me.btnEncolar.Name = "btnEncolar"
        Me.btnEncolar.Size = New System.Drawing.Size(112, 30)
        Me.btnEncolar.TabIndex = 48
        Me.btnEncolar.Text = "Encolar"
        Me.btnEncolar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEncolar.UseVisualStyleBackColor = False
        '
        'Cola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prjct2.My.Resources.Resources._4767f4310c161c0be977808247daca37
        Me.ClientSize = New System.Drawing.Size(549, 325)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnEliminarLista)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGuardarArchivo)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnDesencolar)
        Me.Controls.Add(Me.lblCola)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.btnEncolar)
        Me.MaximizeBox = False
        Me.Name = "Cola"
        Me.Text = "Cola"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button1 As Button
    Private WithEvents lblTitulo As Label
    Private WithEvents btnEliminarLista As Button
    Private WithEvents btnCargar As Button
    Private WithEvents btnGuardarArchivo As Button
    Private WithEvents btnMostrar As Button
    Private WithEvents btnDesencolar As Button
    Private WithEvents lblCola As Label
    Private WithEvents txtNodo As TextBox
    Private WithEvents btnEncolar As Button
End Class
