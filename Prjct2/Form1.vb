Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim mES As New MenuEstructuras()
        mES.Show()
        Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim mAL As New MenuAlgoritmos()
        mAL.Show()
        Hide()
    End Sub
End Class
