
Imports Proyecto_Entidades
Imports System.Data.SqlClient
Public Class Datos_Cliente
    Inherits Conexion_A_sqlServer
    Public Sub Insertar(Cliente_A_insertar As Cliente)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Clinte_Agregar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Cliente_A_insertar.Estado
            Comando.Parameters.Add("@Municipio", SqlDbType.VarChar).Value = Cliente_A_insertar.Municipio
            Comando.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = Cliente_A_insertar.Colonia
            Comando.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = Cliente_A_insertar.CodigoPostal
            Comando.Parameters.Add("@Calle", SqlDbType.VarChar).Value = Cliente_A_insertar.Calle
            Comando.Parameters.Add("@NumeroCasa", SqlDbType.VarChar).Value = Cliente_A_insertar.NumeroCasa

            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Cliente_A_insertar.Nombre
            Comando.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = Cliente_A_insertar.ApellidoPaterno
            Comando.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = Cliente_A_insertar.ApellidoMaterno
            Comando.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = Cliente_A_insertar.Contrasena
            Comando.Parameters.Add("@CURP", SqlDbType.VarChar).Value = Cliente_A_insertar.CURP
            Comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = Cliente_A_insertar.FechaNacimiento

            Comando.Parameters.Add("@CorreoElectronico", SqlDbType.VarChar).Value = Cliente_A_insertar.CorreoElectronico
            Comando.Parameters.Add("@NumCelular", SqlDbType.VarChar).Value = Cliente_A_insertar.NumCelular

            Comando.Parameters.Add("@FechaUltimaModificacion", SqlDbType.DateTime).Value = Cliente_A_insertar.FechaUltimaModificacion

            Comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = Cliente_A_insertar.FechaCreacion

            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Function logingCliente(Correo As String, Contrasena As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Login_Cliente", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = Correo
            Comando.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = Contrasena
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function DesactivarCliente(Correo As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Buscar_Desactivar_Cliente", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Correo
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
