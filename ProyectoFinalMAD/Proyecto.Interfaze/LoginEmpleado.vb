Public Class FORM_INICIO_SESION_EMPLEADO
    Dim Intentos As Integer = 0
    Private Sub Button_InicioSesionEmpleado_reregresar_Click(sender As Object, e As EventArgs) Handles Button_InicioSesionEmpleado_reregresar.Click
        Me.Hide()
        FORM_INICIO_SESION.Show()
    End Sub

    Private Sub BTN_ACEPTAR_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR_EMPLEADO.Click
        Try
            Dim Usuario As String
            Dim contrasena As String
            Dim LoginEmpleado As New Proyecto_Entidades.Empleado
            Dim NewTienda As New Proyecto_Tienda.Tienda_Empleado

            Usuario = TXT_USUARIO.Text.Trim()
            contrasena = TXT_CON_EMPLEADO.Text.Trim()

            If TXT_USUARIO.Text <> "" And TXT_CON_EMPLEADO.Text <> "" Then
                LoginEmpleado = NewTienda.logingEmpleado(Usuario, contrasena)

                If (LoginEmpleado Is Nothing) Then
                    If Intentos = 2 Then
                        MsgBox("Maximo de intentos, Se bloquera su acceso a su cuenta")
                        Me.Hide()
                        FORM_INICIO_SESION.Show()
                        Intentos = 0
                        TXT_USUARIO.Text = ""
                        TXT_CON_EMPLEADO.Text = ""
                        NewTienda.DesactivarEmpleado(Usuario)

                    Else
                        Intentos = Intentos + 1
                        MsgBox("Usuario y contraseña incorrectos, Intentos: " & Intentos & " de 3 ")
                    End If
                Else
                    If (LoginEmpleado.Activo = False) Then
                        MsgBox("Su cuenta esta bloqueada")

                    Else
                        MsgBox("Iniciando sesion")
                        Me.Hide()
                        FORM_HORARIO.Id_Empleado = LoginEmpleado.Id_Empleado
                        FORM_HORARIO.NombreUsuario = LoginEmpleado.Usuario
                        FORM_HORARIO.Show()
                    End If

                End If
            Else
                MsgBox("Ingrese los datos solicitados")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_REC_CONTRA_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_REC_CONTRA_EMPLEADO.Click
        Me.Hide()
        RecordarContraEmpleado.Show()

    End Sub
End Class