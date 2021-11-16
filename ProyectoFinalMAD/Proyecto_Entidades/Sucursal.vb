Public Class Sucursal
    Private _Id_sUCURSAL As Integer
    Private _Nombre As String
    Private _Id_Encargado As Integer
    Private _FechaCreacion As Date
    Private _Estado As String
    Private _Municipio As String
    Private _Colonia As String
    Private _Calle As String
    Private _NumeroDomecilio As String
    Private _CodigoPostal As String
    Private _DireccionCompleta As String

    Public Property Id_sUCURSAL As Integer
        Get
            Return _Id_sUCURSAL
        End Get
        Set(value As Integer)
            _Id_sUCURSAL = value
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

    Public Property Id_Encargado As Integer
        Get
            Return _Id_Encargado
        End Get
        Set(value As Integer)
            _Id_Encargado = value
        End Set
    End Property

    Public Property FechaCreacion As Date
        Get
            Return _FechaCreacion
        End Get
        Set(value As Date)
            _FechaCreacion = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    Public Property Municipio As String
        Get
            Return _Municipio
        End Get
        Set(value As String)
            _Municipio = value
        End Set
    End Property

    Public Property Colonia As String
        Get
            Return _Colonia
        End Get
        Set(value As String)
            _Colonia = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property

    Public Property NumeroDomecilio As String
        Get
            Return _NumeroDomecilio
        End Get
        Set(value As String)
            _NumeroDomecilio = value
        End Set
    End Property

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(value As String)
            _CodigoPostal = value
        End Set
    End Property

    Public Property DireccionCompleta As String
        Get
            Return _DireccionCompleta
        End Get
        Set(value As String)
            _DireccionCompleta = value
        End Set
    End Property
End Class
