Public Class NodoLDE
    Private dato As Integer
    Private siguiente As NodoLDE
    Private anterior As NodoLDE

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Public Property mySiguiente As NodoLDE
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoLDE)
            siguiente = value
        End Set
    End Property

    Public Property myAnterior As NodoLDE
        Get
            Return anterior
        End Get
        Set(ByVal value As NodoLDE)
            anterior = value
        End Set
    End Property

    Public Sub New(ByVal dato As Integer, ByVal siguiente As NodoLDE, ByVal anterior As NodoLDE)
        Me.dato = dato
        Me.siguiente = siguiente
        Me.anterior = anterior
    End Sub

    Public Sub New()
        dato = 0
        siguiente = Nothing
        anterior = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
