Public Class NodoCola
    Private dato As Integer
    Private siguiente As NodoCola

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Public Property mySiguiente As NodoCola
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoCola)
            siguiente = value
        End Set
    End Property

    Public Sub New()
        dato = 0
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal dato As Integer, ByVal siguiente As NodoCola)
        Me.dato = dato
        Me.siguiente = siguiente
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
