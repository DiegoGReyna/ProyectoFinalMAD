Imports Proyecto_Entidades
Imports System.Data.SqlClient
Public Class Datos_RegistroHoras
    Inherits Conexion_A_sqlServer
    Public Sub Insertar(Horario_Insertar As RegistroHoras)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_EmpleadoHorario_Asignar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = Horario_Insertar.Id_Empleado
            Comando.Parameters.Add("@FechaDeRegistro", SqlDbType.VarChar).Value = Horario_Insertar.Fecha
            Comando.Parameters.Add("@RegistroEntrada", SqlDbType.VarChar).Value = Horario_Insertar.HoraEntrada
            Comando.Parameters.Add("@RegistroSalida", SqlDbType.VarChar).Value = Horario_Insertar.HoraSalida
            Comando.Parameters.Add("@HorasTrabajadas", SqlDbType.VarChar).Value = Horario_Insertar.TotalHorasTrabajadas

            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub
End Class
