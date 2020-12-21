Public Class NodoLES
    Private dato As Integer
    Private siguiente As NodoLES

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Public Property mySiguiente As NodoLES
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoLES)
            siguiente = value
        End Set
    End Property

    Public Sub New()
        dato = 0
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal dato As Integer, ByVal siguiente As NodoLES)
        Me.dato = dato
        Me.siguiente = siguiente
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
