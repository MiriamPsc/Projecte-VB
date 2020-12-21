Imports System.IO

Public Class ListaDobleSimple
    Private miLista As ListaDoblementeEnlazadaCircularOperaciones = New ListaDoblementeEnlazadaCircularOperaciones()
    Private n As NodoLDE

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If Not miLista.BuscarDato(Integer.Parse(txtNodo.Text)) Then
                n = New NodoLDE()
                n.myDato = Integer.Parse(txtNodo.Text)
                miLista.Insertar(n)
                lblLista.Text = miLista.ToString()
                txtNodo.Clear()
                Return
            End If

            MessageBox.Show("El dato ya existe en la lista")
            txtNodo.Clear()
        Catch
            MessageBox.Show("Introduzca un numero valido")
        End Try
    End Sub

    Private Sub btnEliminarNodo_Click(sender As Object, e As EventArgs) Handles btnEliminarNodo.Click
        Try
            Dim dato As Integer = Integer.Parse(txtEliminar.Text)

            If Not miLista.BuscarDato(dato) Then
                MessageBox.Show("No se encontró el dato")
                lblLista.Text = miLista.ToString()
                txtNodo.Clear()
                Return
            End If

            miLista.Eliminar(dato)
            lblLista.Text = miLista.ToString()
            txtEliminar.Clear()
        Catch __unusedException1__ As Exception
            MessageBox.Show("Introduzca un número válido.")
        End Try
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Numero de nodos en la lista: " & miLista.ContarNodos())
    End Sub

    Private Sub btnGuardarArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarArchivo.Click
        Dim Dialogo As FolderBrowserDialog = New FolderBrowserDialog()

        If Dialogo.ShowDialog() = DialogResult.OK Then
            Dim dato As String = lblLista.Text
            Dim ruta As String = Dialogo.SelectedPath & "\Lista.txt"

            Using writer = New StreamWriter(ruta)
                writer.Close()
            End Using

            File.WriteAllText(ruta, dato)
            MessageBox.Show("Datos guardados")
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim Seleccionar As OpenFileDialog = New OpenFileDialog()

        If Seleccionar.ShowDialog() = DialogResult.OK Then
            miLista.myHead = Nothing
            Dim contador As Integer = 0
            Dim ruta As String = Seleccionar.FileName
            Dim linea As String = File.ReadAllText(ruta)
            Dim Lista As String() = linea.Split(","c)

            For Each i As String In Lista
                n = New NodoLDE()
                n.myDato = Integer.Parse(Lista(contador))
                miLista.Insertar(n)
                lblLista.Text = miLista.ToString()
                contador += 1
            Next
        End If
    End Sub

    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        miLista.myHead = Nothing
        lblLista.Text = miLista.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k As New MenuEstructuras()
        k.Show()
        Hide()
    End Sub

    Private Sub ListaDobleSimple_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class