
Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Tienda_FormaDepago_Y_Envio
    Public Function ComboBoxFormaDePago() As DataTable
        Try
            Dim Datos As New Datos_FormaDePagoEnvio
            Dim Tabla As New DataTable
            Tabla = Datos.ComboBoxFormaDePago()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ComboBoxFormaDeEnvio() As DataTable
        Try
            Dim Datos As New Datos_FormaDePagoEnvio
            Dim Tabla As New DataTable
            Tabla = Datos.ComboBoxFormaDeEnvio()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
