Public Class MenuEstructuras
    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Dim listaEnlazada As New ListaEnlazada()
        listaEnlazada.Show()
        Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim listaC As New ListaSimpleCircular()
        listaC.Show()
        Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim listaD As New ListaDobleSimple()
        listaD.Show()
        Hide()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim listaDC As New ListaDobleCircular()
        listaDC.Show()
        Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim listaC As New Cola()
        listaC.Show()
        Hide()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim p As New Pilas()
        p.Show()
        Hide()
    End Sub

    Private Sub MenuEstructuras_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Dim a As New Arbol()
        a.Show()
        Hide()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim g As New Grafos1()
        g.Show()
        Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim mPR As New Form1()
        mPR.Show()
        Hide()
    End Sub
End Class