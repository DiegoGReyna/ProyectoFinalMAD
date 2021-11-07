
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

    Public Function Insertar(Empleado_A_insertar As Empleado) As Boolean
        Try
            Dim Datos As New Datos_Empleado
            Datos.Insertar(Empleado_A_insertar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Editar(Empleado_A_Editar As Empleado) As Boolean
        Try
            Dim Datos As New Datos_Empleado

            Datos.Editar(Empleado_A_Editar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id_Empleado As String, Id_Usuario As String, Id_Direccion As String) As Boolean
        Try
            Dim Datos As New Datos_Empleado
            Datos.Eliminar(Id_Empleado, Id_Usuario, Id_Direccion)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(Id As String) As Boolean
        Try
            Dim Datos As New Datos_Empleado
            Datos.Activar(Id)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As String) As Boolean
        Try
            Dim Datos As New Datos_Empleado
            Datos.Desactivar(Id)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarEmpleado(Empleado_A_abuscar As String) As DataTable
        Try
            Dim Datos As New Datos_Empleado
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarEmpleado(Empleado_A_abuscar)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function logingEmpleado(Usuario As String, contrasena As String) As Empleado
        Try
            Dim Empleado As New Empleado
            Dim Datos As New Datos_Empleado
            Dim Tabla As New DataTable
            Tabla = Datos.logingEmpleado(Usuario, contrasena)
            If (Tabla.Rows.Count > 0) Then
                Empleado.Id_Empleado = Tabla.Rows(0).Item(0).ToString
                Empleado.Id_Usuario = Tabla.Rows(0).Item(1).ToString
                Empleado.Id_DireccionUsuario = Tabla.Rows(0).Item(2).ToString
                Empleado.Usuario = Tabla.Rows(0).Item(3).ToString
                Empleado.Contrasena = Tabla.Rows(0).Item(4).ToString
                Empleado.RFC = Tabla.Rows(0).Item(5).ToString
                Empleado.EsAdministrador = Tabla.Rows(0).Item(6).ToString
                Empleado.Activo = Tabla.Rows(0).Item(7).ToString
                Empleado.Nombre = Tabla.Rows(0).Item(8).ToString
                Empleado.ApellidoPaterno = Tabla.Rows(0).Item(9).ToString
                Empleado.ApellidoMaterno = Tabla.Rows(0).Item(10).ToString
                Empleado.CURP = Tabla.Rows(0).Item(11).ToString

                Return Empleado
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function DesactivarEmpleado(Usuario As String) As Boolean
        Try
            Dim Datos As New Datos_Empleado
            Datos.DesactivarEmpleado(Usuario)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
