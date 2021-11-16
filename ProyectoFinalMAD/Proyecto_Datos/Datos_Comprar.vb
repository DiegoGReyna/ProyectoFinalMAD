
Imports Proyecto_Entidades
Imports System.Data.SqlClient

Public Class Datos_Comprar
    Inherits Conexion_A_sqlServer
    Public Sub Insertar(Comprar As Compras_Y_ComprasFormaDepagoEnvio, Carrito As DataTable)
        Try

            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_RealizarCompra", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@IdCarritoProductos", SqlDbType.Int).Value = Comprar.Id_CarritoProducto
            Comando.Parameters("@IdCarritoProductos").Direction = ParameterDirection.Output

            Comando.Parameters.Add("@IdCodigoDebarrasCompras", SqlDbType.Int).Value = Comprar.Id_Compras
            Comando.Parameters("@IdCodigoDebarrasCompras").Direction = ParameterDirection.Output

            Comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Comprar.Id_Client

            Comando.Parameters.Add("@IdFormaDePago", SqlDbType.Int).Value = Comprar.Id_FormaDePago
            Comando.Parameters.Add("@IdFormaDeEnvio", SqlDbType.Int).Value = Comprar.Id_FormaDeEnvio
            Comando.Parameters.Add("@EstadoDePago", SqlDbType.Bit).Value = Comprar.EstadoPago

            Comando.Parameters.Add("@DireccionEntrega", SqlDbType.VarChar).Value = Comprar.DireccionEntrega

            Comando.Parameters.Add("@TotalSinDescuento", SqlDbType.Decimal).Value = Comprar.TotalSinDescuento
            Comando.Parameters.Add("@TotalAhorrado", SqlDbType.Decimal).Value = Comprar.TotalAhorrado
            Comando.Parameters.Add("@TotalConDescuento", SqlDbType.Decimal).Value = Comprar.Total


            Comando.Parameters.Add("@productoCarrito", SqlDbType.Structured).Value = Carrito


            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub
End Class
