Public Class ClienteLogiado
    Private _Id_Usuario As Integer
    Private _Id_Cliente As Integer
    Private _Id_Carrito As Integer
    Private _Id_Direccion As Integer
    Private _CorreoElectronico As String
    Private _NumCelular As String
    Private _Nombre As String
    Private _ApellidoPaterno As String
    Private _ApellidoMaterno As String
    Private _Contrasena As String
    Private _CURP As String
    Private _FechaNacimiento As Date
    Private _FechaCreacion As Date
    Private _Estado As String
    Private _Municipio As String
    Private _Activo As Boolean
    Private _Colonia As String
    Private _CodigoPostal As String
    Private _Calle As String
    Private _NumeroCasa As String
    Private _FechaUltimaModificacion As Date
    Private _DireccionCompleta As String

    Public Property Id_Usuario As Integer
        Get
            Return _Id_Usuario
        End Get
        Set(value As Integer)
            _Id_Usuario = value
        End Set
    End Property

    Public Property Id_Cliente As Integer
        Get
            Return _Id_Cliente
        End Get
        Set(value As Integer)
            _Id_Cliente = value
        End Set
    End Property

    Public Property Id_Carrito As Integer
        Get
            Return _Id_Carrito
        End Get
        Set(value As Integer)
            _Id_Carrito = value
        End Set
    End Property

    Public Property Id_Direccion As Integer
        Get
            Return _Id_Direccion
        End Get
        Set(value As Integer)
            _Id_Direccion = value
        End Set
    End Property

    Public Property CorreoElectronico As String
        Get
            Return _CorreoElectronico
        End Get
        Set(value As String)
            _CorreoElectronico = value
        End Set
    End Property

    Public Property NumCelular As String
        Get
            Return _NumCelular
        End Get
        Set(value As String)
            _NumCelular = value
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

    Public Property ApellidoPaterno As String
        Get
            Return _ApellidoPaterno
        End Get
        Set(value As String)
            _ApellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno As String
        Get
            Return _ApellidoMaterno
        End Get
        Set(value As String)
            _ApellidoMaterno = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return _Contrasena
        End Get
        Set(value As String)
            _Contrasena = value
        End Set
    End Property

    Public Property CURP As String
        Get
            Return _CURP
        End Get
        Set(value As String)
            _CURP = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
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

    Public Property Activo As Boolean
        Get
            Return _Activo
        End Get
        Set(value As Boolean)
            _Activo = value
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

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(value As String)
            _CodigoPostal = value
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

    Public Property NumeroCasa As String
        Get
            Return _NumeroCasa
        End Get
        Set(value As String)
            _NumeroCasa = value
        End Set
    End Property

    Public Property FechaUltimaModificacion As Date
        Get
            Return _FechaUltimaModificacion
        End Get
        Set(value As Date)
            _FechaUltimaModificacion = value
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
