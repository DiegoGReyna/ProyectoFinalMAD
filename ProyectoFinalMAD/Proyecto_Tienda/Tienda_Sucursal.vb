Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Tienda_Sucursal
    Public Function ComboBoxCategorias() As DataTable
        Try
            Dim Datos As New Datos_Sucursal
            Dim Tabla As New DataTable
            Tabla = Datos.ComboBoxSucursal()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ListaSucursal() As DataTable
        Try
            Dim Datos As New Datos_Sucursal

            Dim Tabla As New DataTable
            Tabla = Datos.ListaSucursal()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Sucursal_incertar As Sucursal) As Boolean
        Try
            Dim Datos As New Datos_Sucursal
            Datos.Insertar(Sucursal_incertar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Editar(Sucursal_A_Editar As Sucursal) As Boolean
        Try
            Dim Datos As New Datos_Sucursal
            Datos.Editar(Sucursal_A_Editar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As String) As Boolean
        Try
            Dim Datos As New Datos_Sucursal
            Datos.Eliminar(Id)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarSucursal(Sucursal_abuscar As String) As DataTable
        Try
            Dim Datos As New Datos_Sucursal
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarSucursal(Sucursal_abuscar)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

End Class
