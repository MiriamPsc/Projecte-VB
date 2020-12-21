<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafos1
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.archivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.borrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.agregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.moverTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.moverNodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aristaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dirigidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.noDirigidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.matrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.adyacenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.LightBlue
        Me.menuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivoToolStripMenuItem, Me.nodoToolStripMenuItem, Me.aristaToolStripMenuItem, Me.matrizToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.menuStrip1.TabIndex = 5
        Me.menuStrip1.Text = "menuStrip1"
        '
        'archivoToolStripMenuItem
        '
        Me.archivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoToolStripMenuItem, Me.borrarToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem"
        Me.archivoToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.archivoToolStripMenuItem.Text = "Archivo"
        '
        'nuevoToolStripMenuItem
        '
        Me.nuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem})
        Me.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem"
        Me.nuevoToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.nuevoToolStripMenuItem.Text = "Nuevo"
        '
        'grafo1ToolStripMenuItem
        '
        Me.grafo1ToolStripMenuItem.Name = "grafo1ToolStripMenuItem"
        Me.grafo1ToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.grafo1ToolStripMenuItem.Text = "Grafo 1"
        '
        'borrarToolStripMenuItem
        '
        Me.borrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem1})
        Me.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem"
        Me.borrarToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.borrarToolStripMenuItem.Text = "Borrar"
        '
        'grafo1ToolStripMenuItem1
        '
        Me.grafo1ToolStripMenuItem1.Name = "grafo1ToolStripMenuItem1"
        Me.grafo1ToolStripMenuItem1.Size = New System.Drawing.Size(138, 26)
        Me.grafo1ToolStripMenuItem1.Text = "Grafo 1"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'nodoToolStripMenuItem
        '
        Me.nodoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.agregarToolStripMenuItem, Me.moverTodoToolStripMenuItem, Me.moverNodoToolStripMenuItem, Me.eliminarToolStripMenuItem})
        Me.nodoToolStripMenuItem.Name = "nodoToolStripMenuItem"
        Me.nodoToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.nodoToolStripMenuItem.Text = "Nodo"
        '
        'agregarToolStripMenuItem
        '
        Me.agregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem2})
        Me.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem"
        Me.agregarToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.agregarToolStripMenuItem.Text = "Agregar"
        '
        'grafo1ToolStripMenuItem2
        '
        Me.grafo1ToolStripMenuItem2.Name = "grafo1ToolStripMenuItem2"
        Me.grafo1ToolStripMenuItem2.Size = New System.Drawing.Size(138, 26)
        Me.grafo1ToolStripMenuItem2.Text = "Grafo 1"
        '
        'moverTodoToolStripMenuItem
        '
        Me.moverTodoToolStripMenuItem.Name = "moverTodoToolStripMenuItem"
        Me.moverTodoToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.moverTodoToolStripMenuItem.Text = "Mover Todo"
        '
        'moverNodoToolStripMenuItem
        '
        Me.moverNodoToolStripMenuItem.Name = "moverNodoToolStripMenuItem"
        Me.moverNodoToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.moverNodoToolStripMenuItem.Text = "Mover Nodo"
        '
        'eliminarToolStripMenuItem
        '
        Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
        Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.eliminarToolStripMenuItem.Text = "Eliminar"
        '
        'aristaToolStripMenuItem
        '
        Me.aristaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dirigidaToolStripMenuItem, Me.noDirigidaToolStripMenuItem, Me.eliminarToolStripMenuItem1})
        Me.aristaToolStripMenuItem.Name = "aristaToolStripMenuItem"
        Me.aristaToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
        Me.aristaToolStripMenuItem.Text = "Arista"
        '
        'dirigidaToolStripMenuItem
        '
        Me.dirigidaToolStripMenuItem.Name = "dirigidaToolStripMenuItem"
        Me.dirigidaToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.dirigidaToolStripMenuItem.Text = "Dirigida"
        '
        'noDirigidaToolStripMenuItem
        '
        Me.noDirigidaToolStripMenuItem.Name = "noDirigidaToolStripMenuItem"
        Me.noDirigidaToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.noDirigidaToolStripMenuItem.Text = "No Dirigida"
        '
        'eliminarToolStripMenuItem1
        '
        Me.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1"
        Me.eliminarToolStripMenuItem1.Size = New System.Drawing.Size(165, 26)
        Me.eliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'matrizToolStripMenuItem
        '
        Me.matrizToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.adyacenciaToolStripMenuItem, Me.pesoToolStripMenuItem})
        Me.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem"
        Me.matrizToolStripMenuItem.Size = New System.Drawing.Size(70, 25)
        Me.matrizToolStripMenuItem.Text = "Matriz"
        '
        'adyacenciaToolStripMenuItem
        '
        Me.adyacenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem3})
        Me.adyacenciaToolStripMenuItem.Name = "adyacenciaToolStripMenuItem"
        Me.adyacenciaToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.adyacenciaToolStripMenuItem.Text = "Adyacencia"
        '
        'grafo1ToolStripMenuItem3
        '
        Me.grafo1ToolStripMenuItem3.Name = "grafo1ToolStripMenuItem3"
        Me.grafo1ToolStripMenuItem3.Size = New System.Drawing.Size(138, 26)
        Me.grafo1ToolStripMenuItem3.Text = "Grafo 1"
        '
        'pesoToolStripMenuItem
        '
        Me.pesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem4})
        Me.pesoToolStripMenuItem.Name = "pesoToolStripMenuItem"
        Me.pesoToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.pesoToolStripMenuItem.Text = "Peso"
        '
        'grafo1ToolStripMenuItem4
        '
        Me.grafo1ToolStripMenuItem4.Name = "grafo1ToolStripMenuItem4"
        Me.grafo1ToolStripMenuItem4.Size = New System.Drawing.Size(138, 26)
        Me.grafo1ToolStripMenuItem4.Text = "Grafo 1"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(12, 48)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(776, 399)
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'Grafos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Grafos1"
        Me.Text = "Grafos1"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents archivoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents nuevoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents borrarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Private WithEvents nodoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents agregarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem2 As ToolStripMenuItem
    Private WithEvents moverTodoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents moverNodoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents aristaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents dirigidaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents noDirigidaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents matrizToolStripMenuItem As ToolStripMenuItem
    Private WithEvents adyacenciaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem3 As ToolStripMenuItem
    Private WithEvents pesoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem4 As ToolStripMenuItem
End Class
