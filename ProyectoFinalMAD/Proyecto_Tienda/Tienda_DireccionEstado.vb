Public Class Tienda_DireccionEstado
    Public Function ComboBoxDireccionEstado() As DataTable
        Try
            Dim Datos As New Proyecto_Datos.Datos_DireccionEstado
            Dim Tabla As New DataTable
            Tabla = Datos.ComboBoxDireccionEstado
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
