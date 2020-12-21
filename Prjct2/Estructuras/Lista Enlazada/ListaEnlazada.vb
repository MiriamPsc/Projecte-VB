Imports System.IO

Public Class ListaEnlazada
    Public n As NodoLES
    Public MiLista As LESOperaciones = New LESOperaciones()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If Not MiLista.BuscarDato(Integer.Parse(txtNodo.Text)) Then
                n = New NodoLES()
                n.myDato = Integer.Parse(txtNodo.Text)
                MiLista.Agregar(n)
                lblLista.Text = MiLista.ToString()
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
        Dim dato As Integer = Integer.Parse(txtEliminar.Text)

        If Not MiLista.BuscarDato(dato) Then
            MessageBox.Show("No se encontro el dato")
            lblLista.Text = MiLista.ToString()
            Return
        End If

        MiLista.Borrar(dato)
        lblLista.Text = MiLista.ToString()
        txtEliminar.Clear()
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Numero de nodos en la lista: " & MiLista.ContarNodos())
    End Sub

    Private Sub btnGuardarArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarArchivo.Click
        Try

            If Not MiLista.BuscarDato(Integer.Parse(txtNodo.Text)) Then
                n = New NodoLES()
                n.myDato = Integer.Parse(txtNodo.Text)
                MiLista.Agregar(n)
                lblLista.Text = MiLista.ToString()
                txtNodo.Clear()
                Return
            End If

            MessageBox.Show("El dato ya existe en la lista")
            txtNodo.Clear()
        Catch
            MessageBox.Show("Introduzca un numero valido")
        End Try
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
                n = New NodoLES()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k As New MenuEstructuras()
        k.Show()
        Hide()
    End Sub

    Private Sub ListaEnlazada_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class