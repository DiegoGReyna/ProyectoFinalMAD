Imports System.Data.SqlClient
Public Class Conexion_A_sqlServer
    Private BaseDeDatos As String
    Private Servidor As String
    Private Usuario As String
    Private PassWord As String
    Private Seguridad As Boolean = True
    Public conexion As SqlConnection

    Public Property BaseDeDatos1 As String
        Get
            Return BaseDeDatos
        End Get
        Set(value As String)
            BaseDeDatos = value
        End Set
    End Property

    Public Property Servidor1 As String
        Get
            Return Servidor
        End Get
        Set(value As String)
            Servidor = value
        End Set
    End Property

    Public Property Usuario1 As String
        Get
            Return Usuario
        End Get
        Set(value As String)
            Usuario = value
        End Set
    End Property

    Public Property PassWord1 As String
        Get
            Return PassWord
        End Get
        Set(value As String)
            PassWord = value
        End Set
    End Property

    Public Property Seguridad1 As Boolean
        Get
            Return Seguridad
        End Get
        Set(value As Boolean)
            Seguridad = value
        End Set
    End Property
    Public Sub New()
        Me.BaseDeDatos = "Proyecto_MAD"
        Me.Servidor = "DESKTOP-FGJUFL8\SQLEXPRESS"
        Me.Usuario = "sa"
        Me.PassWord = "zim11223344"
        Me.conexion = New SqlConnection(CreacionCadenaConexion)

    End Sub
    Public Function CreacionCadenaConexion() As String
        Dim CadenaConexion As String
        CadenaConexion = "Server=" & Me.Servidor & "; Database=" & Me.BaseDeDatos & ";"
        If Me.Seguridad Then
            CadenaConexion = CadenaConexion & "Integrated Security= SSPI"
        Else
            CadenaConexion = CadenaConexion & "User Id=" & Me.Usuario & ";Password=" & Me.PassWord
        End If
        Return CadenaConexion
    End Function
End Class
