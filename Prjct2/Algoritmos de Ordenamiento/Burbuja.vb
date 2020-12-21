Public Class Burbuja
    Private aux As Integer
    Private comparaciones As Integer = 0
    Private intercambios As Integer = 0
    Private lista As Integer()
    Private m As MenuAlgoritmos = New MenuAlgoritmos()

    Public Sub Agregar(ByVal rango As Integer, ByVal may As Integer, ByVal men As Integer)
        lista = New Integer(rango - 1) {}
        Dim random As Random = New Random()

        For i As Integer = 0 To lista.Length - 1
            lista(i) = random.[Next](men, may)
        Next
    End Sub

    Public Function Mostrar() As String
        Dim numeros As String = ""

        If lista.Length <> 0 Then

            For i As Integer = 0 To lista.Length - 1
                numeros += lista(i) & ", "
            Next

            Return numeros
        Else
            Return "LA LISTA ESTÁ VACÍA."
        End If
    End Function

    Public Sub Ordenar()
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        For i As Integer = 1 To lista.Length - 1

            For j As Integer = 0 To lista.Length - 1 - 1
                comparaciones += 1

                If lista(j) > lista(j + 1) Then
                    aux = lista(j)
                    lista(j) = lista(j + 1)
                    lista(j + 1) = aux
                    intercambios += 1
                End If
            Next
        Next

        stopwatch.[Stop]()
        Dim time As String = $"{stopwatch.Elapsed.TotalMilliseconds} ms."
        lblComparaciones.Text = comparaciones & ""
        lblIntercambios.Text = intercambios & ""
        lblTiempoOrdenar.Text = time & ""
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim tam As Integer = Convert.ToInt32(txtNum.Text)
        Dim may As Integer = Convert.ToInt32(txtMay.Text)
        Dim men As Integer = Convert.ToInt32(txtMen.Text)
        Agregar(tam, may, men)
        lblNum.Text = Mostrar()
        txtNum.Clear()
        txtMen.Clear()
        txtMay.Clear()
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Ordenar()
        lblOrden.Text = Mostrar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Array.Clear(lista, 0, lista.Length)
        lblNum.Text = ""
        lblOrden.Text = ""
        lblTiempoOrdenar.Text = ""
        lblIntercambios.Text = ""
        lblComparaciones.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim p As New MenuAlgoritmos()
        p.Show()
        Hide()
    End Sub

    Private Sub Burbuja_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class