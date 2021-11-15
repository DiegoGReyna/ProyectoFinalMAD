Imports Proyecto_Entidades
Imports System.Data.SqlClient

Public Class Datos_Sucursal
    Inherits Conexion_A_sqlServer

    Public Function ComboBoxSucursal() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Sucursal_ComboBox", MyBase.conexion)
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

    Public Function ListaSucursal() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_SUCURSAL_Mostrar", MyBase.conexion)
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

    Public Sub Insertar(Sucursal_insertar As Sucursal)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_SUCURSAL_Agregar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Sucursal_insertar.Nombre
            Comando.Parameters.Add("@Id_EmpleadoEncargado", SqlDbType.Int).Value = Sucursal_insertar.Id_Encargado
            Comando.Parameters.Add("@Fecha_Creacion", SqlDbType.DateTime).Value = Sucursal_insertar.FechaCreacion
            Comando.Parameters.Add("@Direcion_Estado", SqlDbType.VarChar).Value = Sucursal_insertar.Estado
            Comando.Parameters.Add("@Direccion_Municipio", SqlDbType.VarChar).Value = Sucursal_insertar.Municipio
            Comando.Parameters.Add("@Direccion_Colonia", SqlDbType.VarChar).Value = Sucursal_insertar.Colonia
            Comando.Parameters.Add("@Direccion_Calle", SqlDbType.VarChar).Value = Sucursal_insertar.Calle
            Comando.Parameters.Add("@Direccion_Numero", SqlDbType.VarChar).Value = Sucursal_insertar.NumeroDomecilio
            Comando.Parameters.Add("@Codigo_Postal", SqlDbType.VarChar).Value = Sucursal_insertar.CodigoPostal

            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub Editar(Sucursal_Editar As Sucursal)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_SUCURSAL_Editar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int).Value = Sucursal_Editar.Id_sUCURSAL

            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Sucursal_Editar.Nombre
            Comando.Parameters.Add("@Id_EmpleadoEncargado", SqlDbType.Int).Value = Sucursal_Editar.Id_Encargado
            Comando.Parameters.Add("@Direcion_Estado", SqlDbType.VarChar).Value = Sucursal_Editar.Estado
            Comando.Parameters.Add("@Direccion_Municipio", SqlDbType.VarChar).Value = Sucursal_Editar.Municipio
            Comando.Parameters.Add("@Direccion_Colonia", SqlDbType.VarChar).Value = Sucursal_Editar.Colonia
            Comando.Parameters.Add("@Direccion_Calle", SqlDbType.VarChar).Value = Sucursal_Editar.Calle
            Comando.Parameters.Add("@Direccion_Numero", SqlDbType.VarChar).Value = Sucursal_Editar.NumeroDomecilio
            Comando.Parameters.Add("@Codigo_Postal", SqlDbType.VarChar).Value = Sucursal_Editar.CodigoPostal
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub Eliminar(Id As String)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_SUCURSAL_Eliminar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int).Value = Id
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub
    Public Function BuscarSucursal(Sucurdal_abuscar As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_SUCURSAL_Buscar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Sucursal", SqlDbType.VarChar).Value = Sucurdal_abuscar
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function CargarComboBoxSucursal() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_SucursalCombox_Almacen", MyBase.conexion)
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
