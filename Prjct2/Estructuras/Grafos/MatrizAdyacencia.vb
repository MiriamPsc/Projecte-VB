﻿Public Class MatrizAdyacencia
    Private grafo As List(Of NodoGrafos) = New List(Of NodoGrafos)()

    Public Sub New(ByVal gr As List(Of NodoGrafos))
        InitializeComponent()
        grafo = gr
    End Sub

    Private Sub MatrizAdyacencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGridView1.ColumnCount = 0
        dataGridView1.ColumnCount = grafo.Count
        dataGridView1.RowCount = 1
        dataGridView1.RowCount = grafo.Count

        For i As Integer = 0 To grafo.Count - 1
            dataGridView1.Columns(i).Name = i.ToString()
        Next

        For i As Integer = 0 To grafo.Count - 1

            For j As Integer = 0 To grafo.Count - 1
                dataGridView1.Rows(i).Cells(j).Value = 0
            Next
        Next

        For i As Integer = 0 To grafo.Count - 1

            For j As Integer = 0 To grafo(i).aristas.Count() - 1
                dataGridView1.Rows(i).Cells(grafo(i).aristas(j).getDestino()).Value = 1
            Next
        Next
    End Sub
End Class