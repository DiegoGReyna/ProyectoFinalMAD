Public Class DireccionEstado
    Private _Id_Estado As Integer
    Private _Nombre As String

    Public Property Id_Estado As Integer
        Get
            Return _Id_Estado
        End Get
        Set(value As Integer)
            _Id_Estado = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
End Class
