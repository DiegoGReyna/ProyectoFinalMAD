Imports Proyecto_Datos
Imports Proyecto_Entidades

Public Class Tienda_Comprar
    Public Function Insertar(Compras As Compras_Y_ComprasFormaDepagoEnvio, Carrito As DataTable) As Boolean
        Try
            Dim Datos As New Datos_Comprar
            Datos.Insertar(Compras, Carrito)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function MostarHistorialCompras(IdCliente As Integer) As DataTable
        Try
            Dim Datos As New Datos_Comprar
            Dim Tabla As New DataTable
            Tabla = Datos.MostarHistorialCompras(IdCliente)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


End Class
