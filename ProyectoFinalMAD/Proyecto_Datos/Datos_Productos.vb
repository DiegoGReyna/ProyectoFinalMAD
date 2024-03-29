﻿Imports Proyecto_Entidades
Imports System.Data.SqlClient

Public Class Datos_Productos
    Inherits Conexion_A_sqlServer
    Public Function ListaProducto() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Producto_Mostrar", MyBase.conexion)
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

    Public Function ListaProducto_Cliente() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Producto_Mostrar_A_Cliente", MyBase.conexion)
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

    Public Function BuscarProducto(Producto_A_abuscar As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Producto_Buscar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Producto_A_abuscar
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function
    Public Sub Insertar(Producto_A_insertar As Producto)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Producto_Agregar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 

            Comando.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = Producto_A_insertar.ID_Empleado
            Comando.Parameters.Add("@IdAlmacen", SqlDbType.Int).Value = Producto_A_insertar.ID_Sucursal
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Producto_A_insertar.Nombre
            Comando.Parameters.Add("@Id_Categoria", SqlDbType.Int).Value = Producto_A_insertar.ID_Categoria
            Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Producto_A_insertar.Descripcion
            Comando.Parameters.Add("@Stock", SqlDbType.Int).Value = Producto_A_insertar.Stock
            Comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Producto_A_insertar.Precio
            Comando.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = Producto_A_insertar.Descuento
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub
    Public Sub Editar(Producto_A_Editar As Producto)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Producto_Editar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_CodigoProducto", SqlDbType.Int).Value = Producto_A_Editar.ID_CodigoProducto
            Comando.Parameters.Add("@Id_AlmacenSucursal", SqlDbType.Int).Value = Producto_A_Editar.ID_Sucursal
            Comando.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = Producto_A_Editar.ID_Empleado
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Producto_A_Editar.Nombre
            Comando.Parameters.Add("@Id_Categoria", SqlDbType.Int).Value = Producto_A_Editar.ID_Categoria
            Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Producto_A_Editar.Descripcion
            Comando.Parameters.Add("@Stock", SqlDbType.Int).Value = Producto_A_Editar.Stock
            Comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Producto_A_Editar.Precio
            Comando.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = Producto_A_Editar.Descuento
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub
    Public Sub Eliminar(Id As String)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Producto_Eliminar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_CodigoProducto", SqlDbType.Int).Value = Id
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public Sub Activar(Id As String)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Producto_Activar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_CodigoProducto", SqlDbType.Int).Value = Id
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub
    Public Sub Desactivar(Id As String)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Producto_Desactivar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_CodigoProducto", SqlDbType.Int).Value = Id
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub
End Class
