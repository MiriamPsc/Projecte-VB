Public Class Shell
    Private vector As Integer()
    Private n As Integer
    Private min As Integer
    Private max As Integer
    Private i As Integer
    Private salto As Integer = 0
    Private sw As Integer = 0
    Private auxiliar As Integer = 0
    Private e As Integer = 0
    Dim comparaciones As Integer = 0
    Dim intercambios As Integer = 0
    Private contador As Stopwatch = New Stopwatch()
    Private p As MenuAlgoritmos = New MenuAlgoritmos()
    Public Sub GenerarDatos(ByVal n As Integer, ByVal min As Integer, ByVal max As Integer)
        vector = New Integer(n - 1) {}
        Dim aleatorio As Random = New Random()
        i = 0

        While i < vector.Length
            vector(i) = aleatorio.[Next](min, max)
            i += 1
        End While
    End Sub

    Public Sub Mostrar(ByVal l As ListBox)
        i = 0

        While i < vector.Length
            l.Items.Add(vector(i))
            i += 1
        End While
    End Sub

    Public Function MetodoShell(ByVal arreglo As Integer()) As Integer
        salto = arreglo.Length / 2

        While salto > 0
            sw = 1

            While sw <> 0
                sw = 0
                e = 1

                While e <= arreglo.Length - salto
                    comparaciones += 1
                    If arreglo(e - 1) > arreglo(e - 1 + salto) Then
                        auxiliar = arreglo(e - 1 + salto)
                        arreglo(e - 1 + salto) = arreglo(e - 1)
                        arreglo(e - 1) = auxiliar
                        sw = 1
                        intercambios += 1
                    End If

                    e += 1
                End While
            End While
            salto = salto / 2 'salto /2... 5/2 = 2
            lblComparaciones.Text = comparaciones + ""
            lblIntercambios.Text = intercambios + ""
        End While
    End Function

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
        MetodoShell(vector)
        contador.[Stop]()
        lblTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        btnGenerar.Enabled = True
        Mostrar(lbOrdenar)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Array.Clear(vector, 0, vector.Length)
        lbNum.Items.Clear()
        lbOrdenar.Items.Clear()
        lblTiempoOrdenar.Text = ""
        lblIntercambios.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f As New MenuAlgoritmos()
        f.Show()
        Hide()
    End Sub

    Private Sub Shell_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class