Imports System.IO

Public Class Cola
    Private MiCola As ColaOperaciones = New ColaOperaciones()
    Private n As NodoCola
    Private Sub btnEncolar_Click(sender As Object, e As EventArgs) Handles btnEncolar.Click
        Try
            n = New NodoCola()
            n.myDato = Integer.Parse(txtNodo.Text)
            MiCola.Encolar(n)
            lblCola.Text = MiCola.ToString()
            txtNodo.Clear()
        Catch
            MessageBox.Show("Bruh")
            txtNodo.Clear()
        End Try
    End Sub

    Private Sub btnDesencolar_Click(sender As Object, e As EventArgs) Handles btnDesencolar.Click
        MiCola.Desencolar()
        lblCola.Text = MiCola.ToString()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MessageBox.Show("El dato frontal es : " & MiCola.Front())
    End Sub

    Private Sub btnGuardarArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarArchivo.Click
        Dim Dialogo As FolderBrowserDialog = New FolderBrowserDialog()

        If Dialogo.ShowDialog() = DialogResult.OK Then
            Dim dato As String = lblCola.Text
            Dim ruta As String = Dialogo.SelectedPath & "\Cola.txt"

            Using writer = New StreamWriter(ruta)
                writer.Close()
            End Using

            File.WriteAllText(ruta, dato)
            MessageBox.Show("Datos guardados")
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim Seleccionar As OpenFileDialog = New OpenFileDialog()

            If Seleccionar.ShowDialog() = DialogResult.OK Then
                MiCola.myHead = Nothing
                Dim contador As Integer = 0
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = File.ReadAllText(ruta)
                Dim Lista As String() = linea.Split(","c)

                For Each i As String In Lista
                    n = New NodoCola()
                    n.myDato = Integer.Parse(Lista(contador))
                    MiCola.Encolar(n)
                    contador += 1
                Next

                lblCola.Text = MiCola.ToString()
            End If

        Catch
            MessageBox.Show("Error al cargar")
        End Try

    End Sub

    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        MiCola.myHead = Nothing
        lblCola.Text = MiCola.ToString()
    End Sub

    Private Sub Cola_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New MenuEstructuras()
        m.Show()
        Hide()
    End Sub
End Class