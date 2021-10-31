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

End Class
