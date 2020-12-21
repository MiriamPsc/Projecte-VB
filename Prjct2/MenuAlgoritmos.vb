Public Class MenuAlgoritmos
    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Dim b As New Burbuja()
        b.Show()
        Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim bb As New CocktailSort()
        bb.Show()
        Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim ss As New CocktailSort()
        ss.Show()
        Hide()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim cs As New Count()
        cs.Show()
        Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim rd As New Radix()
        rd.Show()
        Hide()
    End Sub

    Private Sub MenuAlgoritmos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim mP As New Form1()
        mP.Show()
        Hide()
    End Sub
End Class