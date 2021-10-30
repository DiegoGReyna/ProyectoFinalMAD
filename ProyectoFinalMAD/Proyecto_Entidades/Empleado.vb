
Public Class Empleado
    Private _ID_Empleado As Integer
    Private _ID_Usuario As Integer
    Private _Usuario As String
    Private _RFC As String
    Private _EsAdministrador As Boolean
    Private _Nombre As String
    Private _ApellidoPaterno As String
    Private _ApellidoMaterno As String
    Private _Contrasena As String
    Private _FechaNacimiento As Date
    Private _CURP As String
    Private _Id_Estado As Integer
    Private _Id_Municipio As Integer
    Private _CodigoPostal As Integer
    Private _Colonia As Integer
    Private _FechaModificacion As Date
    Private _Activo As Boolean

    Public Property ID_Empleado As Integer
        Get
            Return _ID_Empleado
        End Get
        Set(value As Integer)
            _ID_Empleado = value
        End Set
    End Property

    Public Property ID_Usuario As Integer
        Get
            Return _ID_Usuario
        End Get
        Set(value As Integer)
            _ID_Usuario = value
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

    Public Property RFC As String
        Get
            Return _RFC
        End Get
        Set(value As String)
            _RFC = value
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

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
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

    Public Property Id_Estado As Integer
        Get
            Return _Id_Estado
        End Get
        Set(value As Integer)
            _Id_Estado = value
        End Set
    End Property

    Public Property Id_Municipio As Integer
        Get
            Return _Id_Municipio
        End Get
        Set(value As Integer)
            _Id_Municipio = value
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

    Public Property Colonia As Integer
        Get
            Return _Colonia
        End Get
        Set(value As Integer)
            _Colonia = value
        End Set
    End Property

    Public Property FechaModificacion As Date
        Get
            Return _FechaModificacion
        End Get
        Set(value As Date)
            _FechaModificacion = value
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
