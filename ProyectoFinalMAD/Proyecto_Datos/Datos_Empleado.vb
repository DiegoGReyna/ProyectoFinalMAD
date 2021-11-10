Imports Proyecto_Entidades
Imports System.Data.SqlClient


Public Class Datos_Empleado
    Inherits Conexion_A_sqlServer
    Public Function ListaEmpleado() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Mostrar_Empleados", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Sub Insertar(Empleado_A_insertar As Empleado)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Empleado_Agregar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Empleado_A_insertar.Usuario
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Empleado_A_insertar.Nombre
            Comando.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = Empleado_A_insertar.ApellidoPaterno
            Comando.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = Empleado_A_insertar.ApellidoMaterno
            Comando.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = Empleado_A_insertar.Contrasena
            Comando.Parameters.Add("@RFC", SqlDbType.VarChar).Value = Empleado_A_insertar.RFC
            Comando.Parameters.Add("@CURP", SqlDbType.VarChar).Value = Empleado_A_insertar.CURP
            Comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = Empleado_A_insertar.FechaNacimienro
            Comando.Parameters.Add("@Administrador", SqlDbType.Bit).Value = Empleado_A_insertar.EsAdministrador
            Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Empleado_A_insertar.Estado
            Comando.Parameters.Add("@Municipio", SqlDbType.VarChar).Value = Empleado_A_insertar.Municipio
            Comando.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = Empleado_A_insertar.Colonia
            Comando.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = Empleado_A_insertar.CodigoPostal
            Comando.Parameters.Add("@Calle", SqlDbType.VarChar).Value = Empleado_A_insertar.Calle
            Comando.Parameters.Add("@NumeroCasa", SqlDbType.VarChar).Value = Empleado_A_insertar.NumeroCasa
            Comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int).Value = Empleado_A_insertar.ID_Sucursal
            Comando.Parameters.Add("@FechaUltimaModificacion", SqlDbType.DateTime).Value = Empleado_A_insertar.FechaUltimaModificacion
            Comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = Empleado_A_insertar.FechaCreacion

            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub Editar(Empleado_A_Editar As Empleado)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Empleado_Editar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Empleado_A_Editar.Usuario
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Empleado_A_Editar.Nombre
            Comando.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = Empleado_A_Editar.ApellidoPaterno
            Comando.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = Empleado_A_Editar.ApellidoMaterno
            Comando.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = Empleado_A_Editar.Contrasena
            Comando.Parameters.Add("@RFC", SqlDbType.VarChar).Value = Empleado_A_Editar.RFC
            Comando.Parameters.Add("@CURP", SqlDbType.VarChar).Value = Empleado_A_Editar.CURP
            Comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = Empleado_A_Editar.FechaNacimienro
            Comando.Parameters.Add("@Administrador", SqlDbType.Bit).Value = Empleado_A_Editar.EsAdministrador
            Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Empleado_A_Editar.Estado
            Comando.Parameters.Add("@Municipio", SqlDbType.VarChar).Value = Empleado_A_Editar.Municipio
            Comando.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = Empleado_A_Editar.Colonia
            Comando.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = Empleado_A_Editar.CodigoPostal
            Comando.Parameters.Add("@Calle", SqlDbType.VarChar).Value = Empleado_A_Editar.Calle
            Comando.Parameters.Add("@NumeroCasa", SqlDbType.VarChar).Value = Empleado_A_Editar.NumeroCasa
            Comando.Parameters.Add("@FechaUltimaModificacion", SqlDbType.DateTime).Value = Empleado_A_Editar.FechaUltimaModificacion

            Comando.Parameters.Add("@Id_Direccion", SqlDbType.Int).Value = Empleado_A_Editar.Id_DireccionUsuario
            Comando.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = Empleado_A_Editar.Id_Usuario
            Comando.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = Empleado_A_Editar.Id_Empleado
            Comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int).Value = Empleado_A_Editar.ID_Sucursal
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub Eliminar(Id_Empleado As String, Id_Usuario As String, Id_Direccion As String)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Empleado_Eliminar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_Direccion", SqlDbType.Int).Value = Id_Direccion
            Comando.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = Id_Usuario
            Comando.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = Id_Empleado

            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public Sub Activar(Id As String)
        Try
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Usuario_Avtivar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = Id
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public Sub Desactivar(Id As String)
        Try

            Dim Comando As New SqlCommand("Usuario_Desactivar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = Id
            MyBase.conexion.Open()
            Comando.ExecuteNonQuery()
            MyBase.conexion.Close()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public Function BuscarEmpleado(Empleado_A_abuscar As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("Empleado_Buscar", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Empleado_A_abuscar
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function logingEmpleado(Usuario As String, Contrasena As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Login_Empleado", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario
            Comando.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = Contrasena
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function DesactivarEmpleado(Usuario As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Buscar_Desactivar_Empleado", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            'Obtenemos las variables creadas en sql y lo igualamos al parametro que deseamos buscar 
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Usuario
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function ComboBoxEmpleados() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            'debemos de pasar el stored procedured y nuestra direccion de la conexion con la base de datos
            Dim Comando As New SqlCommand("PR_Empleados_ComboBox", MyBase.conexion)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conexion.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conexion.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex

        End Try
    End Function

End Class
