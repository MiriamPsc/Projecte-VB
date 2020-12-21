Imports System.IO

Public Class Pilas
    Private miPila As PilasOperaciones = New PilasOperaciones()
    Private n As NodoP = New NodoP()

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim n As NodoP = New NodoP(Integer.Parse(textBox1.Text))
        miPila.Push(n)
        lblPila.Text = miPila.ToString()
        textBox1.Clear()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        miPila.Pop()
        lblPila.Text = miPila.ToString()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        MessageBox.Show(miPila.Count & "")
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Try
            Dim Dialogo As FolderBrowserDialog = New FolderBrowserDialog()

            If Dialogo.ShowDialog() = DialogResult.OK Then
                Dim dato As String = lblPila.Text
                Dim ruta As String = Dialogo.SelectedPath & "\Pila.txt"

                Using writer = New StreamWriter(ruta)
                    writer.Close()
                End Using

                File.WriteAllText(ruta, dato)
                MessageBox.Show("Datos guardados en el archivo : " & "Pila.txt")
            End If

        Catch
            MessageBox.Show("Error al guardar")
        End Try
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Try
            Dim Seleccionar As OpenFileDialog = New OpenFileDialog()

            If Seleccionar.ShowDialog() = DialogResult.OK Then
                miPila.myTop = Nothing
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = File.ReadAllText(ruta)
                Dim Pila As String() = linea.Split(","c)
                Dim contador As Integer = Pila.Length - 1

                For Each i As String In Pila
                    n = New NodoP()
                    n.myDato = Integer.Parse(Pila(contador))
                    miPila.Push(n)
                    contador -= 1
                Next

                lblPila.Text = miPila.ToString()
            End If

        Catch
            MessageBox.Show("Error al cargar")
            miPila.myTop = Nothing
            lblPila.Text = miPila.ToString()
        End Try

    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        miPila.myTop = Nothing
        lblPila.Text = miPila.ToString()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim m As New MenuEstructuras()
        m.Show()
        Hide()
    End Sub

    Private Sub Pilas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class