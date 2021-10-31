
Public Class Empleado
    Private _Id_Empleado As Integer
    Private Id_Usuario As Integer
    Private _Usuario As String
    Private _Nombre As String
    Private _ApellidoPaterno As String
    Private _ApellidoMaterno As String
    Private _Contrasena As String
    Private _RFC As String
    Private _CURP As String
    Private _FechaNacimienro As Date
    Private _EsAdministrador As Boolean
    Private _Estado As String
    Private _Municipio As String
    Private _Colonia As String
    Private _CodigoPostal As Integer
    Private _Calle As String
    Private _NumeroCasa As Integer
    Private _ID_Sucursal As Integer
    Private _FechaUltimaModificacion As String
    Private _Activo As Boolean


    Public Property Id_Empleado As Integer
        Get
            Return _Id_Empleado
        End Get
        Set(value As Integer)
            _Id_Empleado = value
        End Set
    End Property

    Public Property Id_Usuario1 As Integer
        Get
            Return Id_Usuario
        End Get
        Set(value As Integer)
            Id_Usuario = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
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

    Public Property RFC As String
        Get
            Return _RFC
        End Get
        Set(value As String)
            _RFC = value
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

    Public Property FechaNacimienro As Date
        Get
            Return _FechaNacimienro
        End Get
        Set(value As Date)
            _FechaNacimienro = value
        End Set
    End Property

    Public Property EsAdministrador As Boolean
        Get
            Return _EsAdministrador
        End Get
        Set(value As Boolean)
            _EsAdministrador = value
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

    Public Property CodigoPostal As Integer
        Get
            Return _CodigoPostal
        End Get
        Set(value As Integer)
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

    Public Property NumeroCasa As Integer
        Get
            Return _NumeroCasa
        End Get
        Set(value As Integer)
            _NumeroCasa = value
        End Set
    End Property

    Public Property ID_Sucursal As Integer
        Get
            Return _ID_Sucursal
        End Get
        Set(value As Integer)
            _ID_Sucursal = value
        End Set
    End Property

    Public Property FechaUltimaModificacion As String
        Get
            Return _FechaUltimaModificacion
        End Get
        Set(value As String)
            _FechaUltimaModificacion = value
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
End Class
