Imports System.Text.RegularExpressions
Public Class LoginClientes
    Dim Intentos As Integer = 0
    Private Sub Button_InicioSesionEmpleado_reregresar_Click(sender As Object, e As EventArgs) Handles Button_InicioSesionEmpleado_reregresar.Click
        Me.Hide()
        FORM_INICIO_SESION.Show()

    End Sub

    Private Sub LinkLabel_LoginEmpleado_IrAcrearCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_LoginEmpleado_IrAcrearCliente.LinkClicked
        Me.Hide()
        FORM_CrearCliente.Show()
    End Sub

    Private Sub BTN_ACEPTAR_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR_EMPLEADO.Click
        Try
            Dim Correo As String
            Dim contrasena As String
            Dim LoginCliente As New Proyecto_Entidades.Cliente
            Dim NewTienda As New Proyecto_Tienda.Tienda_Cliente

            Correo = TXT_LoginEmpleado_CorreoElectronico.Text.Trim()
            contrasena = TXT_LoginEmpleado_Contrasena.Text.Trim()

            If TXT_LoginEmpleado_CorreoElectronico.Text <> "" And TXT_LoginEmpleado_Contrasena.Text <> "" Then
                LoginCliente = NewTienda.logingCliente(Correo, contrasena)
                If (LoginCliente Is Nothing) Then
                    If Intentos = 2 Then
                        MsgBox("Maximo de intentos, Se bloquera su acceso a su cuenta")
                        Me.Hide()
                        FORM_INICIO_SESION.Show()
                        Intentos = 0


                        TXT_LoginEmpleado_CorreoElectronico.Text = ""
                        TXT_LoginEmpleado_Contrasena.Text = ""
                        NewTienda.DesactivarCliente(Correo)

                    Else
                        Intentos = Intentos + 1
                        MsgBox("Usuario y contraseña incorrectos, Intentos: " & Intentos & " de 3 ")
                    End If
                Else
                    If (LoginCliente.Activo = False) Then
                        MsgBox("Su cuenta esta bloqueada")

                    Else
                        MsgBox("Iniciando sesion")
                    End If

                End If
            Else
                MsgBox("Ingrese los datos solicitados")
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoginClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_REC_CONTRA_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_REC_CONTRA_EMPLEADO.Click
        Me.Hide()
        RecordarContraCliente.Show()

    End Sub
End Class