Public Class PilasOperaciones
    Private top As NodoP

    Public Property myTop As NodoP
        Get
            Return top
        End Get
        Set(ByVal value As NodoP)
            top = value
        End Set
    End Property

    Public ReadOnly Property Count As Integer
        Get
            Dim c As Integer = 0
            Dim t As NodoP = top

            While top IsNot Nothing
                c += 1
                t = t.mySiguiente
            End While

            Return c
        End Get
    End Property

    Public Sub New()
        top = Nothing
    End Sub

    Public Sub Push(ByVal n As NodoP)
        n.mySiguiente = top
        top = n
    End Sub

    Public Function Pop() As NodoP
        Dim regreso As NodoP = Nothing

        If top IsNot Nothing Then
            top = top.mySiguiente
        End If

        Return regreso
    End Function

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim t As NodoP = top

        If t IsNot Nothing Then
            lista += t.ToString()
            t = t.mySiguiente

            While t IsNot Nothing
                lista += "," & t.ToString()
                t = t.mySiguiente
            End While

            lista += "."
            lista = lista.Replace(".", "")
            Return lista
        Else
            Return "La lista esta vacia"
        End If
    End Function
End Class
