Public Class FORM_CrearCliente
    Private Sub BTN_USUARIO_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN__CrearCliente__ACEPTAR.Click

        If Me.ValidateChildren = True And TextBox_CrearCliente_DireccionEstado.Text <> "" And TextBox_CrearCliente_DireccionMunicipio.Text <> "" And TextBox_CrearCliente_DireccionColonia.Text <> "" And TextBox_CrearCliente_DireccionCodigoPostal.Text <> "" And
            TextBox_CrearCliente_DireccionCalle.Text <> "" And TextBox_CrearCliente_NumDomicilio.Text <> "" And TextBox_CrearCliente_ClienteCorreo.Text <> "" And TextBox_CrearCliente_Celular.Text <> "" And TextBox_CrearCliente_UsuarioNombre.Text <> "" And TextBox_CrearCliente_usuarioApellidoPaterno.Text <> "" And
            TextBox_CrearCliente_usuarioApellidoMaterno.Text <> "" And DateTimePicker_CrearCliente_FechaNacimiento.Text <> "" And TextBox_CrearCliente_UsuarioCURP.Text <> "" And TextBox__CrearCliente_UsuarioContrasena.Text <> "" Then
            Dim NewCliente As New Proyecto_Entidades.Cliente
            Dim Newtienda As New Proyecto_Tienda.Tienda_Cliente

            NewCliente.Estado = TextBox_CrearCliente_DireccionEstado.Text
            NewCliente.Municipio = TextBox_CrearCliente_DireccionMunicipio.Text
            NewCliente.Colonia = TextBox_CrearCliente_DireccionColonia.Text
            NewCliente.Calle = TextBox_CrearCliente_DireccionCalle.Text
            NewCliente.CodigoPostal = TextBox_CrearCliente_DireccionCodigoPostal.Text
            NewCliente.NumeroCasa = TextBox_CrearCliente_NumDomicilio.Text

            NewCliente.CorreoElectronico = TextBox_CrearCliente_ClienteCorreo.Text
            NewCliente.NumCelular = TextBox_CrearCliente_Celular.Text

            NewCliente.Nombre = TextBox_CrearCliente_UsuarioNombre.Text
            NewCliente.ApellidoPaterno = TextBox_CrearCliente_usuarioApellidoPaterno.Text
            NewCliente.ApellidoMaterno = TextBox_CrearCliente_usuarioApellidoMaterno.Text
            NewCliente.FechaNacimiento = DateTimePicker_CrearCliente_FechaNacimiento.Text
            NewCliente.CURP = TextBox_CrearCliente_UsuarioCURP.Text
            NewCliente.Contrasena = TextBox__CrearCliente_UsuarioContrasena.Text

            NewCliente.FechaUltimaModificacion = Today
            NewCliente.FechaCreacion = Today

            If (Newtienda.Insertar(NewCliente)) Then
                MsgBox("Se a creado la cuenta correctamente", vbOKOnly, "Ingreso Exitoso")
                Me.Hide()
                LoginClientes.Show()
            Else
                MsgBox("No se a podido crear la cuenta de cliente", vbOKOnly + vbCritical, "Error al crear la cuenta")
            End If

        Else
            MsgBox("Ingrese todos los datos que son necesarios (*)", vbOKOnly + vbCritical, "No se a podido crear la cuena")



        End If
    End Sub

    Private Sub BTN_USUARIO_LISTA_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BTN_USUARIO_CARGA_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label_ListaEmpleados_UsuarioCURP_Click(sender As Object, e As EventArgs) Handles Label_ListaEmpleados_UsuarioCURP.Click

    End Sub

    Private Sub Label_ListaEmpleados_Contrasena_Click(sender As Object, e As EventArgs) Handles Label_ListaEmpleados_Contrasena.Click

    End Sub

    Private Sub TextBox_ListaEmpleado_UsuarioCURP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_CrearCliente_UsuarioCURP.TextChanged

    End Sub

    Private Sub Label_CrearCliente_CorreoCliente_Click(sender As Object, e As EventArgs) Handles Label_CrearCliente_CorreoCliente.Click

    End Sub

    Private Sub TextBox_CrearCliente_ClienteCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_CrearCliente_ClienteCorreo.TextChanged

    End Sub

    Private Sub Button_CrearCliente_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_CrearCliente_Cancelar.Click
        Me.Hide()
        LoginClientes.Show()

    End Sub

    Private Sub Label_ListaEmpleados_FechaNacimiento_Click(sender As Object, e As EventArgs) Handles Label_ListaEmpleados_FechaNacimiento.Click

    End Sub
End Class