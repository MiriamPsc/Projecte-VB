Public Class NodoLEDC
    Private dato As Integer

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Private siguiente As NodoLEDC

    Public Property mySiguiente As NodoLEDC
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoLEDC)
            siguiente = value
        End Set
    End Property

    Private atras As NodoLEDC

    Public Property myAtras As NodoLEDC
        Get
            Return atras
        End Get
        Set(ByVal value As NodoLEDC)
            atras = value
        End Set
    End Property

    Public Sub New()
        dato = 0
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal dato As Integer, ByVal siguiente As NodoLEDC)
        Me.dato = dato
        Me.siguiente = siguiente
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
