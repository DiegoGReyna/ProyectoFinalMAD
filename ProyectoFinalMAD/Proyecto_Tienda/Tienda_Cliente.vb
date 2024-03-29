﻿Imports Proyecto_Datos
Imports Proyecto_Entidades

Public Class Tienda_Cliente
    Public Function Insertar(Cliente_A_insertar As Cliente) As Boolean
        Try
            Dim Datos As New Datos_Cliente
            Datos.Insertar(Cliente_A_insertar)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function logingCliente(correo As String, contrasena As String) As Cliente
        Try
            Dim Cliente As New Cliente
            Dim Datos As New Datos_Cliente
            Dim Tabla As New DataTable
            Tabla = Datos.logingCliente(correo, contrasena)
            If (Tabla.Rows.Count > 0) Then
                Cliente.Id_Cliente = Tabla.Rows(0).Item(0).ToString
                Cliente.Id_Usuario = Tabla.Rows(0).Item(1).ToString
                Cliente.Id_Direccion = Tabla.Rows(0).Item(2).ToString
                Cliente.Id_Carrito = Tabla.Rows(0).Item(3).ToString
                Cliente.CorreoElectronico = Tabla.Rows(0).Item(4).ToString
                Cliente.NumCelular = Tabla.Rows(0).Item(5).ToString
                Cliente.Contrasena = Tabla.Rows(0).Item(6).ToString
                Cliente.Nombre = Tabla.Rows(0).Item(7).ToString
                Cliente.ApellidoPaterno = Tabla.Rows(0).Item(8).ToString
                Cliente.ApellidoMaterno = Tabla.Rows(0).Item(9).ToString
                Cliente.DireccionCompleta = Tabla.Rows(0).Item(10).ToString
                Cliente.Estado = Tabla.Rows(0).Item(11).ToString
                Cliente.Municipio = Tabla.Rows(0).Item(12).ToString
                Cliente.Colonia = Tabla.Rows(0).Item(13).ToString
                Cliente.CodigoPostal = Tabla.Rows(0).Item(14).ToString
                Cliente.Calle = Tabla.Rows(0).Item(15).ToString
                Cliente.NumeroCasa = Tabla.Rows(0).Item(16).ToString
                Cliente.NombreCompleto = Tabla.Rows(0).Item(17).ToString
                Cliente.Activo = Tabla.Rows(0).Item(18).ToString

                Return Cliente
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function DesactivarCliente(Correo As String) As Boolean
        Try
            Dim Datos As New Datos_Cliente
            Datos.DesactivarCliente(Correo)
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Class
