Public Class NodoP
    Private dato As Integer

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Private siguiente As NodoP

    Public Property mySiguiente As NodoP
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoP)
            siguiente = value
        End Set
    End Property

    Public Sub New()
        dato = 0
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal d As Integer)
        dato = d
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal d As Integer, ByVal s As NodoP)
        dato = d
        siguiente = s
    End Sub

    Public Sub New(ByVal n As NodoP)
        dato = n.dato
        siguiente = n.siguiente
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
