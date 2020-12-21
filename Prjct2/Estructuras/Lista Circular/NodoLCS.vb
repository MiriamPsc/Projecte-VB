Public Class NodoLCS
    Private dato As Integer
    Private siguiente As NodoLCS

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Public Property mySiguiente As NodoLCS
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoLCS)
            siguiente = value
        End Set
    End Property

    Public Sub New()
        dato = 0
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal dato As Integer, ByVal siguiente As NodoLCS)
        Me.dato = dato
        Me.siguiente = siguiente
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
