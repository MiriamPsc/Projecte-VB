Public Class CocktailSort

    Private vector As Integer()
    Private n As Integer
    Private min As Integer
    Private max As Integer
    Private i As Integer
    Private contador As Stopwatch = New Stopwatch()
    Private m As MenuAlgoritmos = New MenuAlgoritmos()

    Public Sub GenerarDatos(ByVal n As Integer, ByVal min As Integer, ByVal max As Integer)
        vector = New Integer(n - 1) {}
        Dim aleatorio As Random = New Random()

        For i = 0 To vector.Length - 1
            vector(i) = aleatorio.[Next](min, max)
        Next
    End Sub

    Public Sub BurbujaBidireccional(ByVal n As Integer)
        Dim der As Integer = vector.Length - 1
        Dim izq As Integer = 0
        Dim ultimo As Integer = 0
        Dim aux As Integer
        Dim comparaciones As Integer = 0
        Dim intercambio As Integer = 0

        Do

            For i As Integer = izq To der - 1
                comparaciones += 1

                If vector(i) > vector(i + 1) Then
                    aux = vector(i)
                    vector(i) = vector(i + 1)
                    vector(i + 1) = aux
                    ultimo = i
                    intercambio += 1
                End If
            Next

            der = ultimo

            For j As Integer = der To izq + 1 Step -1
                comparaciones += 1

                If vector(j - 1) > vector(j) Then
                    aux = vector(j)
                    vector(j) = vector(j - 1)
                    vector(j - 1) = aux
                    ultimo = j
                    intercambio += 1
                End If
            Next

            izq = ultimo
        Loop While izq < der


        lblComparaciones.Text = comparaciones.ToString() & " Comparaciones"
        lblIntercambios.Text = intercambio.ToString() & " Intercambios"
        Return
    End Sub

    Public Sub Mostrar(ByVal l As ListBox)
        For i = 0 To vector.Length - 1
            l.Items.Add(vector(i))
        Next
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            lbNum.Items.Clear()
            lbOrdenar.Items.Clear()
            n = Integer.Parse(txtNum.Text)
            min = Integer.Parse(txtMin.Text)
            max = Integer.Parse(txtMax.Text)
            GenerarDatos(n, min, max)
            Mostrar(lbNum)
            btnGenerar.Enabled = False
            btnOrdenar.Enabled = True
        Catch
            MessageBox.Show("Introduzca un numero valido")
        End Try

    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        contador.Restart()
        BurbujaBidireccional(n)
        contador.[Stop]()
        lblTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        Mostrar(lbOrdenar)
        btnGenerar.Enabled = True
        btnOrdenar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Array.Clear(vector, 0, vector.Length)
        lbNum.Items.Clear()
        lbOrdenar.Items.Clear()
        lblTiempoOrdenar.Text = ""
        lblIntercambios.Text = ""
        lblComparaciones.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim k As New MenuAlgoritmos()
        k.Show()
        Hide()
    End Sub

    Private Sub CocktailSort_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.[Exit]()
    End Sub
End Class