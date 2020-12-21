Public Class Count
    Private r As Random = New Random()
    Private valorMayor As Integer = 0
    Private arregloInicial As Integer()
    Private arregloAuxiliar As Integer()
    Private arregloOrdenado As Integer()
    Private stopWatch As Stopwatch = New Stopwatch()

    Public Function ImprimirArreglo(ByVal arreglo As Integer()) As String
        Dim colaString As String
        colaString = arreglo(0)
        For z As Integer = 0 To arreglo.Length - 1 - 1
            colaString += "," & arreglo(z + 1)
        Next
        Return colaString
    End Function

    Public Sub OrdenarEInvertir(ByVal tamaño As Integer, ByVal minimo As Integer, ByVal maximo As Integer)
        stopWatch.Start()
        arregloInicial = New Integer(tamaño - 1) {}

        For j As Integer = 0 To arregloInicial.Length - 1
            arregloInicial(j) = r.[Next](minimo, maximo)
        Next

        lblOriginal.Text = ImprimirArreglo(arregloInicial)

        For a As Integer = 0 To arregloInicial.Length - 1
            If arregloInicial(a) > valorMayor Then
                valorMayor = arregloInicial(a)
            End If
        Next

        arregloAuxiliar = New Integer(valorMayor + 1 - 1) {}

        For b As Integer = 0 To arregloInicial.Length - 1
            Dim posicion As Integer = arregloInicial(b)
            arregloAuxiliar(posicion) += 1
        Next

        For c As Integer = 1 To arregloAuxiliar.Length - 1
            arregloAuxiliar(c) = arregloAuxiliar(c - 1) + arregloAuxiliar(c)
        Next

        Dim i As Integer = arregloAuxiliar.Length - 1

        While i <> 0
            arregloAuxiliar(i) = arregloAuxiliar(i - 1)
            i -= 1
        End While

        arregloAuxiliar(0) = 0
        arregloOrdenado = New Integer(arregloInicial.Length - 1) {}

        For d As Integer = 0 To arregloInicial.Length - 1
            Dim valor As Integer = arregloInicial(d)
            Dim posicion As Integer = arregloAuxiliar(valor)
            arregloOrdenado(posicion) = valor
            arregloAuxiliar(valor) += 1
        Next

        lblOrdenado.Text = ImprimirArreglo(arregloOrdenado)
        Array.Reverse(arregloOrdenado)
        lblInvertido.Text = ImprimirArreglo(arregloOrdenado)
        stopWatch.[Stop]()
        lblTiempo.Text = stopWatch.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Array.Clear(arregloInicial, 0, arregloInicial.Length)
        lblArregloDesordenado.Text = ""
        lblInvertido.Text = ""
        lblOrdenado.Text = ""
        lblTiempo.Text = ""
    End Sub

    Private Sub btnCrearArreglo_Click(sender As Object, e As EventArgs) Handles btnCrearArreglo.Click
        Try
            Dim maximo As Integer = Integer.Parse(txtMax.Text)
            Dim minimo As Integer = Integer.Parse(txtMin.Text)
            Dim tamaño As Integer = Integer.Parse(txTamaño.Text)

            If minimo < 0 Then
                MessageBox.Show("El minimo no puede ser menor que 0")
                Return
            End If

            If tamaño < 0 Then
                MessageBox.Show("El tamaño no puede ser un numero negativo")
                Return
            End If

            If maximo <= minimo Then
                MessageBox.Show("El maximo debe de ser mayor que el minimo")
                Return
            End If

            txtMax.Clear()
            txtMin.Clear()
            txTamaño.Clear()
            OrdenarEInvertir(tamaño, minimo, maximo)
        Catch
            MessageBox.Show("Introduzca datos validos")
            Return
        End Try
    End Sub

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        Dim tamaño As Integer = r.Next(3, 20)
        Dim minimo As Integer = r.Next(0, 5)
        Dim maximo As Integer = r.Next(minimo, 25)
        OrdenarEInvertir(tamaño, minimo, maximo)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim M As New MenuAlgoritmos()
        M.Show()
        Hide()
    End Sub
End Class