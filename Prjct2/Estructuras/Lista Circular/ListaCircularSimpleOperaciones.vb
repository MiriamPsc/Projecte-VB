Public Class ListaCircularSimpleOperaciones
    Private head As NodoLCS

    Public Property myHead As NodoLCS
        Get
            Return head
        End Get
        Set(ByVal value As NodoLCS)
            head = value
        End Set
    End Property

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub New(ByVal n As NodoLCS)
        head = n
    End Sub

    Public Function Agregar(ByVal n As NodoLCS) As Boolean

        Dim h As NodoLCS = head

        If head Is Nothing Then
            n.mySiguiente = n
            head = n
            Return True
        End If

        If n.myDato < head.myDato Then

            While h.mySiguiente IsNot head
                h = h.mySiguiente
            End While

            h.mySiguiente = n
            n.mySiguiente = head
            head = n
            Return True
        End If

        While h.mySiguiente IsNot head

            If n.myDato < h.mySiguiente.myDato Then
                Exit While
            End If

            h = h.mySiguiente
        End While

        n.mySiguiente = h.mySiguiente
        h.mySiguiente = n
        Return True
    End Function

    Public Sub Borrar(ByVal dato As Integer)
        Dim h As NodoLCS = head

        If head IsNot Nothing Then

            If head.myDato = dato Then

                While h.mySiguiente IsNot head
                    h = h.mySiguiente
                End While

                head = head.mySiguiente
                h.mySiguiente = head
                Return
            Else

                While h.mySiguiente.myDato <> dato
                    h = h.mySiguiente
                End While

                h.mySiguiente = h.mySiguiente.mySiguiente
            End If
        End If
    End Sub

    Public Function BuscarDato(ByVal a As Integer) As Boolean
        Dim h As NodoLCS = head

        If h IsNot Nothing Then

            Do

                If h.myDato = a Then
                    Return True
                End If

                h = h.mySiguiente
            Loop While h IsNot head
        End If

        Return False
    End Function

    Public Function ContarNodos() As Integer
        Dim contador As Integer = 0
        Dim h As NodoLCS = head

        Do
            contador += 1
            h = h.mySiguiente
        Loop While h IsNot head

        Return contador
    End Function

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim h As NodoLCS = head

        If h IsNot Nothing Then

            Do
                lista += h.myDato & ", "
                h = h.mySiguiente
            Loop While h IsNot head

            lista += "."
            lista = lista.Replace(", .", "")
            Return lista
        Else
            Return "La lista está vacía"
        End If
    End Function
End Class
