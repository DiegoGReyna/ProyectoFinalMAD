Public Class FORM_LISTA_EMPLEADO
    Private Sub Formato()
        DataGridView_ListaEmpleados.Columns(0).Visible = False
        DataGridView_ListaEmpleados.Columns(0).Width = 80
        DataGridView_ListaEmpleados.Columns(1).Width = 100
        DataGridView_ListaEmpleados.Columns(2).Width = 100
        DataGridView_ListaEmpleados.Columns(3).Width = 100
        DataGridView_ListaEmpleados.Columns(4).Width = 100
        DataGridView_ListaEmpleados.Columns(5).Width = 100
        DataGridView_ListaEmpleados.Columns(6).Width = 100
        DataGridView_ListaEmpleados.Columns(7).Width = 100
        DataGridView_ListaEmpleados.Columns(8).Width = 100
        DataGridView_ListaEmpleados.Columns(9).Width = 100
        DataGridView_ListaEmpleados.Columns(10).Width = 100
        DataGridView_ListaEmpleados.Columns(11).Width = 100
        DataGridView_ListaEmpleados.Columns(12).Width = 100
        DataGridView_ListaEmpleados.Columns(13).Width = 100
        DataGridView_ListaEmpleados.Columns(14).Width = 100
        DataGridView_ListaEmpleados.Columns(15).Width = 100
        DataGridView_ListaEmpleados.Columns(16).Width = 100
        DataGridView_ListaEmpleados.Columns(17).Width = 100
        DataGridView_ListaEmpleados.Columns(18).Width = 100
        DataGridView_ListaEmpleados.Columns(19).Width = 100
        DataGridView_ListaEmpleados.Columns(20).Width = 100
        DataGridView_ListaEmpleados.Columns(21).Width = 100
        Seleccionar_Empleado.CheckState = False
        DataGridView_ListaEmpleados.Columns.Item("SeleccionarEmpleado").Visible = False

    End Sub
    Private Sub Mostrar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Empleado
            DataGridView_ListaEmpleados.DataSource = Tienda.ListaEmpleado()

            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargarComboBoxSucursales()
        Try
            Dim NewTienda As New Proyecto_Tienda.Tienda_Sucursal
            ComboBox_ListaEmpleado_SucursalDondeTrabaja.DataSource = NewTienda.ComboBoxCategorias
            ComboBox_ListaEmpleado_SucursalDondeTrabaja.ValueMember = "Id_Sucursal"
            ComboBox_ListaEmpleado_SucursalDondeTrabaja.DisplayMember = "Nombre"

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Empleado
            Dim EmpleadoAbuscar As String
            EmpleadoAbuscar = TextBox_ListaEmpleados_TextAbuscar.Text
            DataGridView_ListaEmpleados.DataSource = Tienda.BuscarEmpleado(EmpleadoAbuscar)

            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()

        Button_ListaEmpleado_Agregar.Visible = True
        Button_ListaEmpleado_Editar.Visible = False
        TextBox_ListaEmpleado_DireccionEstado.Text = ""
        TextBox_ListaEmpleado_DireccionMunicipio.Text = ""
        TextBox_ListaEmpleado_DireccionColonia.Text = ""
        TextBox_ListaEmpleado_DireccionCodigoPostal.Text = ""
        TextBox_ListaEmpleado_DireccionCalle.Text = ""
        TextBox_ListaEmpleado_NumDomicilio.Text = ""

        TextBox_ListaEmpleado_EmpleadoNomUsuario.Text = ""
        TextBox_ListaEmpleado_EmpleadoRFC.Text = ""
        CheckBox_ListaEmpleados_EsAdministrador.CheckState = False

        TextBox_ListaEmpleado_UsuarioNombre.Text = ""
        TextBox_ListaEmpleado_UsuarioCURP.Text = ""
        TextBox_ListaEmpleado_usuarioApellidoPaterno.Text = ""
        TextBox_ListaEmpleado_usuarioApellidoMaterno.Text = ""
        TextBox_ListaEmpleado_usuarioApellidoMaterno.Text = ""



    End Sub


    Private Sub BTN_LISTEMPLEADOS_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTN_LISTEMPLEADOS_IMPRIMIR.Click

    End Sub

    Private Sub DataGridView_Empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaEmpleados.CellContentClick
        If e.ColumnIndex = DataGridView_ListaEmpleados.Columns.Item("SeleccionarEmpleado").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DataGridView_ListaEmpleados.Rows(e.RowIndex).Cells("SeleccionarEmpleado")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub FORM_LISTA_EMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mostrar()
        Me.CargarComboBoxSucursales()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles ListaEmpleados.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox_ListaEmpleado_Direccion.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label_ListaEmpleados_Estado.Click

    End Sub

    Private Sub Label_ListaEmpleados_Nombre_Click(sender As Object, e As EventArgs) Handles Label_ListaEmpleados_Nombre.Click

    End Sub

    Private Sub TextBox_ListaEmpleado_UsuarioNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ListaEmpleado_UsuarioNombre.TextChanged

    End Sub

    Private Sub Label_ListaEmpleados_ApellidoMaterno_Click(sender As Object, e As EventArgs) Handles Label_ListaEmpleados_ApellidoMaterno.Click

    End Sub

    Private Sub TextBox_ListaEmpleado_usuarioApellidoMaterno_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ListaEmpleado_usuarioApellidoMaterno.TextChanged

    End Sub

    Private Sub Button_ListaEmpleado_Agregar_Click(sender As Object, e As EventArgs) Handles Button_ListaEmpleado_Agregar.Click





        If TextBox_ListaEmpleado_DireccionEstado.Text.Length > 5 Then
            MsgBox("Tamaño maximo de estado")

        End If


        If Me.ValidateChildren = True And TextBox_ListaEmpleado_DireccionEstado.Text <> "" And DateTimePicker1_ListaEmpleados_.Text <> "" And TextBox_ListaEmpleado_DireccionMunicipio.Text <> "" And TextBox_ListaEmpleado_DireccionColonia.Text <> "" And
            TextBox_ListaEmpleado_DireccionCodigoPostal.Text <> "" And TextBox_ListaEmpleado_DireccionCalle.Text <> "" And TextBox_ListaEmpleado_NumDomicilio.Text <> "" And TextBox_ListaEmpleado_EmpleadoNomUsuario.Text <> "" And TextBox_ListaEmpleado_EmpleadoRFC.Text <> "" And
            TextBox_ListaEmpleado_UsuarioNombre.Text <> "" And TextBox_ListaEmpleado_usuarioApellidoPaterno.Text <> "" And TextBox_ListaEmpleado_usuarioApellidoMaterno.Text <> "" And TextBox_ListaEmpleado_UsuarioCURP.Text <> "" And TextBox_ListaEmpleado_UsuarioContrasena.Text <> "" And ComboBox_ListaEmpleado_SucursalDondeTrabaja.Text <> "" Then
            Dim NewEmpleado As New Proyecto_Entidades.Empleado
            Dim Newtienda As New Proyecto_Tienda.Tienda_Empleado

            NewEmpleado.Estado = TextBox_ListaEmpleado_DireccionEstado.Text
            NewEmpleado.Municipio = TextBox_ListaEmpleado_DireccionMunicipio.Text
            NewEmpleado.Colonia = TextBox_ListaEmpleado_DireccionColonia.Text
            NewEmpleado.Calle = TextBox_ListaEmpleado_DireccionCalle.Text
            NewEmpleado.CodigoPostal = TextBox_ListaEmpleado_DireccionCodigoPostal.Text
            NewEmpleado.NumeroCasa = TextBox_ListaEmpleado_NumDomicilio.Text

            NewEmpleado.Usuario = TextBox_ListaEmpleado_EmpleadoNomUsuario.Text
            NewEmpleado.RFC = TextBox_ListaEmpleado_EmpleadoRFC.Text
            NewEmpleado.EsAdministrador = CheckBox_ListaEmpleados_EsAdministrador.CheckState

            NewEmpleado.Nombre = TextBox_ListaEmpleado_UsuarioNombre.Text
            NewEmpleado.ApellidoPaterno = TextBox_ListaEmpleado_usuarioApellidoPaterno.Text
            NewEmpleado.ApellidoMaterno = TextBox_ListaEmpleado_usuarioApellidoMaterno.Text
            NewEmpleado.FechaNacimienro = DateTimePicker1_ListaEmpleados_.Text
            NewEmpleado.CURP = TextBox_ListaEmpleado_UsuarioCURP.Text
            NewEmpleado.Contrasena = TextBox_ListaEmpleado_UsuarioContrasena.Text

            NewEmpleado.ID_Sucursal = ComboBox_ListaEmpleado_SucursalDondeTrabaja.SelectedValue


            NewEmpleado.FechaUltimaModificacion = Today

            If (Newtienda.Insertar(NewEmpleado)) Then
                MsgBox("El nuevo Empleado se ingreso correctamente", vbOKOnly, "Ingreso Exitoso")
                Me.Mostrar()
            Else
                MsgBox("No se a podido ingresar el nuevo Empleado", vbOKOnly + vbCritical, "Error al ingresar")
            End If

        Else
            MsgBox("Ingrese todos los datos que son necesarios (*)", vbOKOnly + vbCritical, "No se a podido ingresar el nuevo Empleado")



        End If

    End Sub

    Private Sub TextBox_ListaEmpleado_NumDomicilio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ListaEmpleado_NumDomicilio.TextChanged

    End Sub

    Private Sub Button_ListaEmpleado_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_ListaEmpleado_Cancelar.Click
        Me.Limpiar()
        TabControl_ListaEmpleados.SelectedIndex = 0
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub DataGridView_ListaEmpleados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaEmpleados.CellContentDoubleClick

    End Sub

    Private Sub DataGridView_ListaEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaEmpleados.CellDoubleClick
        Try

            TextBox_ListaEmpleado_IDEmpleado.Text = DataGridView_ListaEmpleados.SelectedCells.Item(1).Value
            TextBoxTextBox_ListaEmpleado_IDUsuario.Text = DataGridView_ListaEmpleados.SelectedCells.Item(2).Value
            TextBox_ListaEmpleados_IdDireccion.Text = DataGridView_ListaEmpleados.SelectedCells.Item(3).Value


            TextBox_ListaEmpleado_UsuarioNombre.Text = DataGridView_ListaEmpleados.SelectedCells.Item(5).Value
            TextBox_ListaEmpleado_usuarioApellidoPaterno.Text = DataGridView_ListaEmpleados.SelectedCells.Item(6).Value
            TextBox_ListaEmpleado_usuarioApellidoMaterno.Text = DataGridView_ListaEmpleados.SelectedCells.Item(7).Value
            TextBox_ListaEmpleado_UsuarioContrasena.Text = DataGridView_ListaEmpleados.SelectedCells.Item(8).Value
            TextBox_ListaEmpleado_UsuarioCURP.Text = DataGridView_ListaEmpleados.SelectedCells.Item(10).Value
            DateTimePicker1_ListaEmpleados_.Text = DataGridView_ListaEmpleados.SelectedCells.Item(11).Value


            TextBox_ListaEmpleado_EmpleadoRFC.Text = DataGridView_ListaEmpleados.SelectedCells.Item(9).Value
            TextBox_ListaEmpleado_EmpleadoNomUsuario.Text = DataGridView_ListaEmpleados.SelectedCells.Item(4).Value
            CheckBox_ListaEmpleados_EsAdministrador.Checked = DataGridView_ListaEmpleados.SelectedCells.Item(12).Value


            TextBox_ListaEmpleado_DireccionEstado.Text = DataGridView_ListaEmpleados.SelectedCells.Item(13).Value
            TextBox_ListaEmpleado_DireccionMunicipio.Text = DataGridView_ListaEmpleados.SelectedCells.Item(14).Value
            TextBox_ListaEmpleado_DireccionColonia.Text = DataGridView_ListaEmpleados.SelectedCells.Item(15).Value
            TextBox_ListaEmpleado_DireccionCodigoPostal.Text = DataGridView_ListaEmpleados.SelectedCells.Item(16).Value
            TextBox_ListaEmpleado_DireccionCalle.Text = DataGridView_ListaEmpleados.SelectedCells.Item(17).Value
            TextBox_ListaEmpleado_NumDomicilio.Text = DataGridView_ListaEmpleados.SelectedCells.Item(18).Value

            TextBox_ListaEmpleado_FechaUltimaMod.Text = DataGridView_ListaEmpleados.SelectedCells.Item(20).Value
            TabControl_ListaEmpleados.SelectedIndex = 1
            ComboBox_ListaEmpleado_SucursalDondeTrabaja.SelectedValue = DataGridView_ListaEmpleados.SelectedCells.Item(19).Value







        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button_ListaEmpleado_Editar_Click(sender As Object, e As EventArgs) Handles Button_ListaEmpleado_Editar.Click
        If Me.ValidateChildren = True And TextBox_ListaEmpleado_DireccionEstado.Text <> "" And DateTimePicker1_ListaEmpleados_.Text <> "" And TextBox_ListaEmpleado_DireccionMunicipio.Text <> "" And TextBox_ListaEmpleado_DireccionColonia.Text <> "" And
            TextBox_ListaEmpleado_DireccionCodigoPostal.Text <> "" And TextBox_ListaEmpleado_DireccionCalle.Text <> "" And TextBox_ListaEmpleado_NumDomicilio.Text <> "" And TextBox_ListaEmpleado_EmpleadoNomUsuario.Text <> "" And TextBox_ListaEmpleado_EmpleadoRFC.Text <> "" And
            TextBox_ListaEmpleado_UsuarioNombre.Text <> "" And TextBox_ListaEmpleado_usuarioApellidoPaterno.Text <> "" And TextBox_ListaEmpleado_usuarioApellidoMaterno.Text <> "" And TextBox_ListaEmpleado_UsuarioCURP.Text <> "" And TextBox_ListaEmpleado_UsuarioContrasena.Text <> "" And ComboBox_ListaEmpleado_SucursalDondeTrabaja.Text <> "" Then

            Dim NewEmpleado As New Proyecto_Entidades.Empleado
            Dim Newtienda As New Proyecto_Tienda.Tienda_Empleado

            NewEmpleado.Id_DireccionUsuario = TextBox_ListaEmpleados_IdDireccion.Text
            NewEmpleado.Id_Usuario = TextBoxTextBox_ListaEmpleado_IDUsuario.Text
            NewEmpleado.Id_Empleado = TextBox_ListaEmpleado_IDEmpleado.Text

            NewEmpleado.Estado = TextBox_ListaEmpleado_DireccionEstado.Text
            NewEmpleado.Municipio = TextBox_ListaEmpleado_DireccionMunicipio.Text
            NewEmpleado.Colonia = TextBox_ListaEmpleado_DireccionColonia.Text
            NewEmpleado.Calle = TextBox_ListaEmpleado_DireccionCalle.Text
            NewEmpleado.CodigoPostal = TextBox_ListaEmpleado_DireccionCodigoPostal.Text
            NewEmpleado.NumeroCasa = TextBox_ListaEmpleado_NumDomicilio.Text

            NewEmpleado.Usuario = TextBox_ListaEmpleado_EmpleadoNomUsuario.Text
            NewEmpleado.RFC = TextBox_ListaEmpleado_EmpleadoRFC.Text
            NewEmpleado.EsAdministrador = CheckBox_ListaEmpleados_EsAdministrador.CheckState

            NewEmpleado.Nombre = TextBox_ListaEmpleado_UsuarioNombre.Text
            NewEmpleado.ApellidoPaterno = TextBox_ListaEmpleado_usuarioApellidoPaterno.Text
            NewEmpleado.ApellidoMaterno = TextBox_ListaEmpleado_usuarioApellidoMaterno.Text
            NewEmpleado.FechaNacimienro = DateTimePicker1_ListaEmpleados_.Text
            NewEmpleado.CURP = TextBox_ListaEmpleado_UsuarioCURP.Text
            NewEmpleado.Contrasena = TextBox_ListaEmpleado_UsuarioContrasena.Text

            NewEmpleado.ID_Sucursal = ComboBox_ListaEmpleado_SucursalDondeTrabaja.SelectedValue


            NewEmpleado.FechaUltimaModificacion = Today



            If (Newtienda.Editar(NewEmpleado)) Then
                MsgBox("El empleado se edito correctamente", vbOKOnly, "Edicion Exitosa")
                Me.Mostrar()
                TabControl_ListaEmpleados.SelectedIndex = 0

            Else
                MsgBox("No se a podido editar una al empleado", vbOKOnly + vbCritical, "Error al Editar")
            End If

        Else
            MsgBox("Ingrese todos los datos que son necesarios (*)", vbOKOnly + vbCritical, "No se a podido Editar el empleado ")
        End If
    End Sub

    Private Sub Seleccionar_Empleado_CheckedChanged(sender As Object, e As EventArgs) Handles Seleccionar_Empleado.CheckedChanged
        If Seleccionar_Empleado.CheckState = CheckState.Checked Then
            DataGridView_ListaEmpleados.Columns.Item("SeleccionarEmpleado").Visible = True
            Button_ListaEmpleados_Eliminar.Visible = True
            Button_ListaEmpleados_Activar.Visible = True
            Button_ListaEmpleados_Desactivar.Visible = True

        Else
            DataGridView_ListaEmpleados.Columns.Item("SeleccionarEmpleado").Visible = False
            Button_ListaEmpleados_Eliminar.Visible = False
            Button_ListaEmpleados_Activar.Visible = False
            Button_ListaEmpleados_Desactivar.Visible = False
        End If
    End Sub

    Private Sub Button_ListaEmpleados_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_ListaEmpleados_Eliminar.Click
        If (MsgBox("¿Deseas eliminar al empleado seleccionado?", vbYesNo, "Eliminar producto") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Empleado

                For Each row As DataGridViewRow In DataGridView_ListaEmpleados.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("SeleccionarEmpleado").Value)
                    If seleccionado Then
                        Dim LlaveDireccion As Integer = Convert.ToInt32(row.Cells("ID Direccion").Value)
                        Dim LlaveUsuario As Integer = Convert.ToInt32(row.Cells("ID de usuario").Value)
                        Dim LlaveEmpleado As Integer = Convert.ToInt32(row.Cells("ID de empleado").Value)
                        NewTienda.Eliminar(LlaveEmpleado, LlaveUsuario, LlaveDireccion)
                    End If

                Next
                Me.Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button_ListaEmpleados_Activar_Click(sender As Object, e As EventArgs) Handles Button_ListaEmpleados_Activar.Click
        If (MsgBox("¿Deseas Activar al empleado seleccionado?", vbYesNo, "Activar empleado") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Empleado

                For Each row As DataGridViewRow In DataGridView_ListaEmpleados.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("SeleccionarEmpleado").Value)
                    If seleccionado Then
                        Dim Llave As Integer = Convert.ToInt32(row.Cells("ID de usuario").Value)
                        NewTienda.Activar(Llave)
                    End If

                Next
                Me.Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button_ListaEmpleados_Desactivar_Click(sender As Object, e As EventArgs) Handles Button_ListaEmpleados_Desactivar.Click
        If (MsgBox("¿Deseas Desactivar al empleado seleccionado?", vbYesNo, "Desactivar producto") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Empleado

                For Each row As DataGridViewRow In DataGridView_ListaEmpleados.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("SeleccionarEmpleado").Value)
                    If seleccionado Then
                        Dim Llave As Integer = Convert.ToInt32(row.Cells("ID de usuario").Value)
                        NewTienda.Desactivar(Llave)
                    End If

                Next
                Me.Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button_ListaEmpleados_Buscar_Click(sender As Object, e As EventArgs) Handles Button_ListaEmpleados_Buscar.Click
        Me.Buscar()
    End Sub
End Class