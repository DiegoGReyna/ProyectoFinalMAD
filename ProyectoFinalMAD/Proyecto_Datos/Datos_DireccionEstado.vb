Imports Proyecto_Entidades
Imports System.Data.SqlClient
Public Class Datos_DireccionEstado
    Inherits Conexion_A_sqlServer
    Public Function ComboBoxDireccionEstado() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("SP_Estado_ComboBox", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function
End Class
