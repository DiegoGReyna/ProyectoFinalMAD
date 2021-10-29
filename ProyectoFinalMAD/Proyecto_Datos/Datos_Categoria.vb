Imports Proyecto_Entidades
Imports System.Data.SqlClient


Public Class Datos_Categoria
    Inherits Conexion_A_sqlServer
    Public Function ListaCategoria() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Categoria_Mostrar", MyBase.conexion)
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

    Public Function ComboBoxCategorias() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Categoria_ComboBox", MyBase.conexion)
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

    Public Function BuscarCategoria(categori_A_abuscar As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Categoria_Buscar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@NombreCategoria", SqlDbType.VarChar).Value = categori_A_abuscar
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function
    Public Sub Insertar(categoria_A_insertar As CategoriaDeProducto)
        Try

            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Categoria_Insertar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = categoria_A_insertar.Nombre_Categoria
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub
    Public Sub Editar(categoria_A_Editar As CategoriaDeProducto)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Categoria_Editar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_CategoriaProducto", SqlDbType.Int).Value = categoria_A_Editar.Id_CategoriaProducto_Categoria
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = categoria_A_Editar.Nombre_Categoria
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub
    Public Sub Eliminar(Id As String)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Categoria_Eliminar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_CategoriaProducto", SqlDbType.Int).Value = Id
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

End Class
