Public Class ListaDobleCircularOperaciones
    Private head As NodoLEDC

    Public Property myHead As NodoLEDC
        Get
            Return head
        End Get
        Set(ByVal value As NodoLEDC)
            head = value
        End Set
    End Property

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub New(ByVal n As NodoLEDC)
        head = n
        n.myAtras = head
        n.mySiguiente = head
    End Sub

    Public Function Agregar(ByVal n As NodoLEDC) As Boolean
        Dim h As NodoLEDC = head

        If head Is Nothing Then
            n.myAtras = n
            n.mySiguiente = n
            head = n
            Return True
        End If

        If Buscar(n.myDato) Then
            Return False
        End If

        If n.myDato < head.myDato Then
            head.myAtras.mySiguiente = n
            n.myAtras = head.myAtras
            n.mySiguiente = head
            head.myAtras = n
            head = n
            Return True
        End If

        Do

            If n.myDato < h.mySiguiente.myDato Then
                Exit Do
            End If

            h = h.mySiguiente
        Loop While h IsNot head

        If n.myDato < h.mySiguiente.myDato Then
            h.mySiguiente.myAtras = n
            n.myAtras = h
            n.mySiguiente = h.mySiguiente
            h.mySiguiente = n
        Else
            n.mySiguiente = h
            n.myAtras = h.myAtras
            h.myAtras.mySiguiente = n
            h.myAtras = n
        End If

        Return True
    End Function

    Public Function Buscar(ByVal b As Integer) As Boolean
        Dim h As NodoLEDC = head

        If h IsNot Nothing Then

            Do
                If h.myDato = b Then
                    Return True
                End If

                h = h.mySiguiente
            Loop While h IsNot head
        End If

        Return False
    End Function

    Public Function ContarNodos() As Integer
        Dim cuenta As Integer = 0

        If head IsNot Nothing Then
            Dim h As NodoLEDC = head

            Do
                cuenta += 1
                h = h.mySiguiente
            Loop While h IsNot head
        End If

        Return cuenta
    End Function

    Public Function MostrarDatos() As String
        Dim h As NodoLEDC = head
        Dim s As String = ""

        Do
            s += h.myDato & "-"
            h = h.mySiguiente
        Loop While h IsNot head

        Return s
    End Function

    Public Function MostrarDatosAnt() As String
        Dim h As NodoLEDC = head
        Dim s As String = ""

        Do
            s += h.myAtras.myDato
            h = h.myAtras
        Loop While h IsNot head

        Return s
    End Function

    Public Sub Vaciar()
        head = Nothing
    End Sub

    Public Function Eliminar(ByVal b As Integer) As Boolean
        If Buscar(b) Then
            Dim h As NodoLEDC = head

            While h.mySiguiente IsNot head

                If h.myDato = b Then
                    Exit While
                End If

                h = h.mySiguiente
            End While

            h.myAtras.mySiguiente = h.mySiguiente
            h.mySiguiente.myAtras = h.myAtras

            If h Is head Then
                head = head.mySiguiente
            End If

            Return True
        End If

        Return False
    End Function

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim h As NodoLEDC = head

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
