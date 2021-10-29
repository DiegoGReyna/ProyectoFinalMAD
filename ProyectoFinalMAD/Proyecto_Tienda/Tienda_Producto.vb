Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Tienda_Producto
    Public Function ListaProducto() As DataTable
        Try
            Dim Datos As New Datos_Productos
            Dim Tabla As New DataTable
            Tabla = Datos.ListaProducto()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function BuscarProducto(Productos_A_abuscar As String) As DataTable
        Try
            Dim Datos As New Datos_Productos
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarProducto(Productos_A_abuscar)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function Insertar(Productos_A_insertar As Producto) As Boolean
        Try
            Dim Datos As New Datos_Productos
            Datos.Insertar(Productos_A_insertar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Editar(Productos_A_Editar As Producto) As Boolean
        Try
            Dim Datos As New Datos_Productos
            Datos.Editar(Productos_A_Editar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As String) As Boolean
        Try
            Dim Datos As New Datos_Productos
            Datos.Eliminar(Id)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Activar(Id As String) As Boolean
        Try
            Dim Datos As New Datos_Productos
            Datos.Activar(Id)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As String) As Boolean
        Try
            Dim Datos As New Datos_Productos
            Datos.Desactivar(Id)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Class
