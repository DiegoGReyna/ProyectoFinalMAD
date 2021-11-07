Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Tienda_RegistroHoras
    Public Function Insertar(Horario_insertar As RegistroHoras) As Boolean
        Try
            Dim Datos As New Datos_RegistroHoras
            Datos.Insertar(Horario_insertar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
