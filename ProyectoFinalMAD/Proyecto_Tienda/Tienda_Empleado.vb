
Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Tienda_Empleado
    Public Function ListaEmpleado() As DataTable
        Try
            Dim Datos As New Datos_Empleado

            Dim Tabla As New DataTable
            Tabla = Datos.ListaEmpleado()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
