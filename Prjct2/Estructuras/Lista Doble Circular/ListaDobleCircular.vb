Imports System.IO

Public Class ListaDobleCircular
    Private MiLista As ListaDobleCircularOperaciones = New ListaDobleCircularOperaciones()
    Private n As NodoLEDC

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If Not MiLista.Buscar(Integer.Parse(txtNodo.Text)) Then
                n = New NodoLEDC()
                n.myDato = Integer.Parse(txtNodo.Text)
                MiLista.Agregar(n)
                lblLista.Text = MiLista.ToString()
                txtNodo.Clear()
            Else
                MessageBox.Show("El dato ya existe en la lista.")
                txtNodo.Clear()
            End If

        Catch
            MessageBox.Show("Introduzca un número válido.")
        End Try
    End Sub

    Private Sub btnEliminarNodo_Click(sender As Object, e As EventArgs) Handles btnEliminarNodo.Click
        Try
            Dim dato As Integer = Integer.Parse(txtEliminar.Text)

            If Not MiLista.Buscar(dato) Then
                MessageBox.Show("No se encontró el dato")
                lblLista.Text = MiLista.ToString()
                txtNodo.Clear()
                Return
            End If

            MiLista.Eliminar(dato)
            lblLista.Text = MiLista.ToString()
            txtEliminar.Clear()
        Catch __unusedException1__ As Exception
            MessageBox.Show("Introduzca un número válido.")
        End Try
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Número de nodos en la lista: " & MiLista.ContarNodos())
    End Sub

    Private Sub btnGuardarArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarArchivo.Click
        Dim Dialogo As FolderBrowserDialog = New FolderBrowserDialog()

        If Dialogo.ShowDialog() = DialogResult.OK Then
            Dim dato As String = lblLista.Text
            Dim ruta As String = Dialogo.SelectedPath & "\ListaN.txt"

            Using writer = New StreamWriter(ruta)
                writer.Close()
            End Using

            File.WriteAllText(ruta, dato)
            MessageBox.Show("Datos guardados.")
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim Seleccionar As OpenFileDialog = New OpenFileDialog()

        If Seleccionar.ShowDialog() = DialogResult.OK Then
            MiLista.myHead = Nothing
            Dim contador As Integer = 0
            Dim ruta As String = Seleccionar.FileName
            Dim linea As String = File.ReadAllText(ruta)
            Dim Lista As String() = linea.Split(","c)

            For Each i As String In Lista
                n = New NodoLEDC()
                n.myDato = Integer.Parse(Lista(contador))
                MiLista.Agregar(n)
                lblLista.Text = MiLista.ToString()
                contador += 1
            Next
        End If
    End Sub

    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        MiLista.myHead = Nothing
        lblLista.Text = MiLista.ToString()
    End Sub

    Private Sub ListaDobleCircular_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New MenuEstructuras()
        m.Show()
        Hide()
    End Sub
End Class