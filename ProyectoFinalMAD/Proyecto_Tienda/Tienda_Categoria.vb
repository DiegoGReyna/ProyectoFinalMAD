Imports Proyecto_Datos
Imports Proyecto_Entidades


Public Class Tienda_Categoria
    Public Function ListaCategoria() As DataTable
        Try
            Dim Datos As New Datos_Categoria
            Dim Tabla As New DataTable
            Tabla = Datos.ListaCategoria()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function BuscarCategoria(categori_A_abuscar As String) As DataTable
        Try
            Dim Datos As New Datos_Categoria
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarCategoria(categori_A_abuscar)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function Insertar(categoria_A_insertar As CategoriaDeProducto) As Boolean
        Try
            Dim Datos As New Datos_Categoria
            Datos.Insertar(categoria_A_insertar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Editar(categoria_A_Editar As CategoriaDeProducto) As Boolean
        Try
            Dim Datos As New Datos_Categoria
            Datos.Editar(categoria_A_Editar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As String) As Boolean
        Try
            Dim Datos As New Datos_Categoria
            Datos.Eliminar(Id)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
