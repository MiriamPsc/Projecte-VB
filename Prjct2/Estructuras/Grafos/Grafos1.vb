﻿Imports System.Drawing.Drawing2D

Public Class Grafos1
    Private nodos As List(Of NodoGrafos) = New List(Of NodoGrafos)()
    Private bandera As Integer
    Private dibujo As Graphics

    Public Sub dibuja()
        Dim aux As List(Of NodoGrafos) = New List(Of NodoGrafos)()
        aux = nodos

        If dibujo IsNot Nothing Then
            dibujo.Clear(Color.Aqua)
        End If

        dibujo = Me.pictureBox1.CreateGraphics()
        Dim fonnt1 As Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)

        For i As Integer = 0 To aux.Count() - 1
            Dim xletra As Single = CSng(aux(i).getX()) + 15
            Dim yletra As Single = CSng(aux(i).getY()) + 15
            dibujo.FillEllipse(Brushes.Pink, aux(i).getX(), aux(i).getY(), 40, 40)
            dibujo.DrawString(aux(i).getnombre().ToString(), fonnt1, Brushes.Purple, xletra, yletra)
        Next

        For i As Integer = 0 To aux.Count() - 1

            If aux(i).aristas IsNot Nothing Then

                For j As Integer = 0 To aux(i).aristas.Count() - 1

                    If aux(i).aristas(j).getTipo() = 0 Then
                        Dim pen As Pen = New Pen(Color.Black, 3)
                        pen.EndCap = LineCap.ArrowAnchor
                        Dim xletra As Single = Math.Abs((CSng(nodos(aux(i).aristas(j).getOrigen()).getX()) + CSng(nodos(aux(i).aristas(j).getDestino()).getX())) / 2)
                        Dim yletra As Single = Math.Abs((CSng(nodos(aux(i).aristas(j).getOrigen()).getY()) + CSng(nodos(aux(i).aristas(j).getDestino()).getY())) / 2)
                        dibujo.DrawLine(pen, aux(aux(i).aristas(j).getOrigen()).getX() + 20, aux(aux(i).aristas(j).getOrigen()).getY() + 20, aux(aux(i).aristas(j).getDestino()).getX() + 20, aux(aux(i).aristas(j).getDestino()).getY() + 20)
                        dibujo.DrawString(aux(i).aristas(j).getPeso().ToString(), fonnt1, Brushes.Purple, xletra, yletra)
                    ElseIf aux(i).aristas(j).getTipo() = 1 Then
                        Dim pen As Pen = New Pen(Color.Black, 3)
                        Dim xletra As Single = Math.Abs((CSng(nodos(aux(i).aristas(j).getOrigen()).getX()) + CSng(nodos(aux(i).aristas(j).getDestino()).getX())) / 2)
                        Dim yletra As Single = Math.Abs((CSng(nodos(aux(i).aristas(j).getOrigen()).getY()) + CSng(nodos(aux(i).aristas(j).getDestino()).getY())) / 2)
                        dibujo.DrawLine(pen, aux(aux(i).aristas(j).getOrigen()).getX() + 20, aux(aux(i).aristas(j).getOrigen()).getY() + 20, aux(aux(i).aristas(j).getDestino()).getX() + 20, aux(aux(i).aristas(j).getDestino()).getY() + 20)
                        dibujo.DrawString(aux(i).aristas(j).getPeso().ToString(), fonnt1, Brushes.Purple, xletra, yletra)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub grafo1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles grafo1ToolStripMenuItem.Click
        nodos = New List(Of NodoGrafos)()
        dibuja()
    End Sub

    Private Sub grafo1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles grafo1ToolStripMenuItem1.Click
        nodos = New List(Of NodoGrafos)()
        dibuja()
        pictureBox1.Image = Nothing
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim b As New MenuEstructuras()
        b.Show()
        Hide()
    End Sub

    Private Sub grafo1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles grafo1ToolStripMenuItem2.Click
        bandera = 1
    End Sub

    Private Sub moverTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles moverTodoToolStripMenuItem.Click
        bandera = 2
    End Sub

    Private Sub moverNodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles moverNodoToolStripMenuItem.Click
        bandera = 7
    End Sub

    Private Sub eliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles eliminarToolStripMenuItem.Click
        bandera = 3
    End Sub

    Private Sub dirigidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles dirigidaToolStripMenuItem.Click
        bandera = 4
    End Sub

    Private Sub noDirigidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles noDirigidaToolStripMenuItem.Click
        bandera = 5
    End Sub

    Private Sub eliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles eliminarToolStripMenuItem1.Click
        bandera = 6
    End Sub
    Private cordx As Integer = New Integer()
    Private cordy As Integer = New Integer()
    Private binicio As Boolean = False
    Private bfinal As Boolean = False
    Private inicio As Integer = 10000

    Public Sub acciones1()
        Dim eliminar As Integer = 1000

        If bandera = 1 Then
            Dim nod As NodoGrafos = New NodoGrafos()
            nod.llenaNodo(cordx - 20, cordy - 20)
            nod.llenanombre(nodos.Count())
            nodos.Add(nod)
            dibuja()
        End If

        If bandera = 2 Then
            dibuja()
        End If

        If bandera = 3 Then

            For i As Integer = 0 To nodos.Count() - 1

                If cordx > nodos(i).getX() - 40 AndAlso cordx < nodos(i).getX() + 40 AndAlso cordy > nodos(i).getY() - 40 AndAlso cordy < nodos(i).getY() + 40 Then
                    eliminar = i
                End If
            Next

            If eliminar <> 1000 Then
                nodos.RemoveAt(eliminar)
                dibuja()
            End If
        End If

        If bandera = 4 Then

            For i As Integer = 0 To nodos.Count() - 1

                If cordx > nodos(i).getX() - 40 AndAlso cordx < nodos(i).getX() + 40 AndAlso cordy > nodos(i).getY() - 40 AndAlso cordy < nodos(i).getY() + 40 Then
                    inicio = i
                    binicio = True
                End If
            Next

            If bfinal = True AndAlso binicio = True Then
                dibuja()
                bfinal = False
                binicio = False
            End If
        End If

        If bandera = 5 Then

            For i As Integer = 0 To nodos.Count() - 1

                If cordx > nodos(i).getX() - 40 AndAlso cordx < nodos(i).getX() + 40 AndAlso cordy > nodos(i).getY() - 40 AndAlso cordy < nodos(i).getY() + 40 Then
                    inicio = i
                    binicio = True
                End If
            Next

            If bfinal = True AndAlso binicio = True Then
                dibuja()
                bfinal = False
                binicio = False
            End If
        End If
    End Sub

    Dim minicio As Boolean = False
    Dim xinicio As Integer = 0
    Dim yinicio As Integer = 0
    Dim nodmover As Integer = 1000

    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles pictureBox1.MouseDown
        If bandera = 2 Then

            For i As Integer = 0 To nodos.Count() - 1

                If cordx > nodos(i).getX() - 40 AndAlso cordx < nodos(i).getX() + 40 Then
                    xinicio = cordx
                    yinicio = cordy
                    minicio = True
                    nodmover = i
                End If
            Next
        End If

        If bandera = 7 Then

            For i As Integer = 0 To nodos.Count() - 1

                If e.Location.X > nodos(i).getX() - 40 AndAlso e.Location.X < nodos(i).getX() + 40 AndAlso e.Location.Y > nodos(i).getY() - 40 AndAlso e.Location.Y < nodos(i).getY() + 40 Then
                    xinicio = cordx
                    yinicio = cordy
                    minicio = True
                    nodmover = i
                End If
            Next
        End If
    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles pictureBox1.MouseUp
        Dim xdif As Integer = 0
        Dim ydif As Integer = 0
        Dim nd As NodoGrafos = New NodoGrafos()

        If bandera = 2 AndAlso minicio = True Then
            xdif = e.Location.X - xinicio
            ydif = e.Location.Y - yinicio

            For i As Integer = 0 To nodos.Count - 1
                nodos(i).llenaNodo(nodos(i).getX() + xdif, nodos(i).getY() + ydif)
            Next

            dibuja()
            minicio = False
        End If

        If bandera = 7 AndAlso minicio = True Then
            xdif = e.Location.X - nodos(nodmover).getX()
            ydif = e.Location.Y - nodos(nodmover).getY()
            nodos(nodmover).llenaNodo(nodos(nodmover).getX() + xdif, nodos(nodmover).getY() + ydif)
            dibuja()
            minicio = False
        End If
    End Sub

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles pictureBox1.MouseMove
        Dim xxdif As Integer
        Dim yydif As Integer
        Dim auxnodo As List(Of NodoGrafos) = nodos

        If bandera = 2 AndAlso minicio = True Then
            xxdif = e.Location.X - xinicio
            yydif = e.Location.Y - yinicio

            For i As Integer = 0 To auxnodo.Count - 1
                auxnodo(i).llenaNodo(auxnodo(i).getX() + xxdif, auxnodo(i).getY() + yydif)
            Next

            dibuja()
        End If

        If bandera = 7 AndAlso minicio = True Then
            xxdif = e.Location.X - auxnodo(nodmover).getX()
            yydif = e.Location.Y - auxnodo(nodmover).getY()
            auxnodo(nodmover).llenaNodo(auxnodo(nodmover).getX() + xxdif, auxnodo(nodmover).getY() + yydif)
            dibuja()
        End If
    End Sub

    Private Sub grafo1ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles grafo1ToolStripMenuItem3.Click
        Dim md As MatrizAdyacencia = New MatrizAdyacencia(nodos)
        md.Show()
    End Sub

    Private Sub grafo1ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles grafo1ToolStripMenuItem4.Click
        Dim mp As MatrizPeso = New MatrizPeso(nodos)
        mp.Show()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As MouseEventArgs) Handles pictureBox1.Click
        cordx = e.Location.X
        cordy = e.Location.Y
        Dim final As Integer = 1000

        If bandera = 4 Then

            If binicio = True Then
                Dim arista As Arista = New Arista()

                For i As Integer = 0 To nodos.Count() - 1

                    If cordx > nodos(i).getX() - 40 AndAlso cordx < nodos(i).getX() + 40 AndAlso cordy > nodos(i).getY() - 40 AndAlso cordy < nodos(i).getY() + 40 Then
                        final = i
                        bfinal = True
                        arista.llenaArista(inicio, final, 0, 0)
                        nodos(inicio).llenararista(arista)
                    End If
                Next
            End If
        End If

        If bandera = 5 Then

            If binicio = True Then
                Dim arista As Arista = New Arista()

                For i As Integer = 0 To nodos.Count() - 1

                    If cordx > nodos(i).getX() - 40 AndAlso cordx < nodos(i).getX() + 40 AndAlso cordy > nodos(i).getY() - 40 AndAlso cordy < nodos(i).getY() + 40 Then
                        final = i
                        bfinal = True
                        arista.llenaArista(final, inicio, 0, 1)
                        nodos(final).llenararista(arista)
                    End If
                Next
            End If
        End If

        If bandera = 6 Then

            For i As Integer = 0 To nodos.Count - 1

                For j As Integer = 0 To nodos(i).aristas.Count - 1
                    Dim m As Integer = (nodos(nodos(i).aristas(j).getOrigen()).getX() - nodos(nodos(i).aristas(j).getDestino()).getX()) / (nodos(nodos(i).aristas(j).getOrigen()).getY() - nodos(nodos(i).aristas(j).getDestino()).getY())
                Next
            Next
        End If

        acciones1()
    End Sub

    Private Sub Grafos1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class