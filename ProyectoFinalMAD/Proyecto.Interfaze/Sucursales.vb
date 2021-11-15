Public Class FORM_SUCURSAL
    Private Sub Formato()
        DataGridView_ListaSucursal.Columns(0).Visible = False
        DataGridView_ListaSucursal.Columns(0).Width = 80
        DataGridView_ListaSucursal.Columns(1).Width = 100
        DataGridView_ListaSucursal.Columns(2).Width = 100
        DataGridView_ListaSucursal.Columns(3).Width = 100
        DataGridView_ListaSucursal.Columns(4).Width = 100
        DataGridView_ListaSucursal.Columns(5).Width = 100
        DataGridView_ListaSucursal.Columns(6).Width = 100
        DataGridView_ListaSucursal.Columns(7).Width = 100
        DataGridView_ListaSucursal.Columns(8).Width = 100
        DataGridView_ListaSucursal.Columns(9).Width = 100
        DataGridView_ListaSucursal.Columns(10).Width = 100
        DataGridView_ListaSucursal.Columns(11).Width = 100
        DataGridView_ListaSucursal.Columns(12).Width = 100
        DataGridView_ListaSucursal.Columns(13).Visible = False
        DataGridView_ListaSucursal.Columns(13).Width = 100
        Seleccionar_ListaSucursal_Empleado.CheckState = False
        DataGridView_ListaSucursal.Columns.Item("SeleccionarSucursal").Visible = False

    End Sub

    Private Sub Limpiar()

        BTN_ListaSucursal_ACEPTAR.Visible = True
        BTN_ListaSucursal_Editar.Visible = False
        TXT_ListaSucursal_NOMBRE.Text = ""
        TextBox_ListaSucursal_DireccionEstado.Text = ""
        TextBox_ListaSucursal_DirecccionMunicipio.Text = ""
        TXT_ListaSucursal_COLONIA.Text = ""
        TXT_ListaSucursal_CALLE.Text = ""
        TXT_SUC_NUM.Text = ""
        TXT_ListaSucursal_NUMERO.Text = ""
        TXT_ListaSucursal_CODPOS.Text = ""
        Seleccionar_ListaSucursal_Empleado.CheckState = False

    End Sub

    Private Sub Mostrar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Sucursal
            DataGridView_ListaSucursal.DataSource = Tienda.ListaSucursal()

            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargarComboBoxSucursales()
        Try
            Dim NewTienda As New Proyecto_Tienda.Tienda_Empleado
            ComboBox_ListaSucursal_Encargado.DataSource = NewTienda.ComboBoxEmpleado
            ComboBox_ListaSucursal_Encargado.ValueMember = "ID de empleado"
            ComboBox_ListaSucursal_Encargado.DisplayMember = "full_name"


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BTN_SUC_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ListaSucursal_ACEPTAR.Click
        If Me.ValidateChildren = True And TXT_ListaSucursal_NOMBRE.Text <> "" And ComboBox_ListaSucursal_Encargado.Text <> "" And TextBox_ListaSucursal_DireccionEstado.Text <> "" And TextBox_ListaSucursal_DirecccionMunicipio.Text <> "" And
            TXT_ListaSucursal_COLONIA.Text <> "" And TXT_ListaSucursal_CALLE.Text <> "" And TXT_ListaSucursal_NUMERO.Text <> "" And TXT_ListaSucursal_CODPOS.Text <> "" Then
            Dim Newtienda As New Proyecto_Tienda.Tienda_Sucursal
            Dim NewSucursal As New Proyecto_Entidades.Sucursal

            NewSucursal.Nombre = TXT_ListaSucursal_NOMBRE.Text
            NewSucursal.Id_Encargado = ComboBox_ListaSucursal_Encargado.SelectedValue

            NewSucursal.Estado = TextBox_ListaSucursal_DireccionEstado.Text
            NewSucursal.Municipio = TextBox_ListaSucursal_DirecccionMunicipio.Text
            NewSucursal.Colonia = TXT_ListaSucursal_COLONIA.Text
            NewSucursal.Calle = TXT_ListaSucursal_CALLE.Text
            NewSucursal.NumeroDomecilio = TXT_ListaSucursal_NUMERO.Text
            NewSucursal.CodigoPostal = TXT_ListaSucursal_CODPOS.Text



            NewSucursal.FechaCreacion = Today


            If (Newtienda.Insertar(NewSucursal)) Then
                MsgBox("La nueva sucursal se ingreso correctamente", vbOKOnly, "Ingreso Exitoso")
                Me.Mostrar()
                TabControl_ListaSucursales.SelectedIndex = 0
            Else
                MsgBox("No se a podido ingresar la nueva sucursal", vbOKOnly + vbCritical, "Error al ingresar")
            End If

        Else
            MsgBox("Ingrese todos los datos que son necesarios (*)", vbOKOnly + vbCritical, "No se a podido ingresar la nueva sucursal")



        End If
    End Sub

    Private Sub Buscar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Sucursal
            Dim ProductoAbuscar As String
            ProductoAbuscar = TextBox_ListaSucursal_TextAbuscar.Text
            DataGridView_ListaSucursal.DataSource = Tienda.BuscarSucursal(ProductoAbuscar)

            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TXT_ListaSucursal__NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_ListaSucursal_NOMBRE.TextChanged

    End Sub

    Private Sub TXT_SUC_NUM_TextChanged(sender As Object, e As EventArgs) Handles TXT_SUC_NUM.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_ListaSucursales_CargaMasiva.Click

    End Sub

    Private Sub BTN_LISTEMPLEADOS_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTN_LISTEMPLEADOS_IMPRIMIR.Click

    End Sub

    Private Sub DataGridView_ListaSucursal_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaSucursal.CellContentDoubleClick
        Try
            TXT_SUC_NUM.Text = DataGridView_ListaSucursal.SelectedCells.Item(1).Value
            TXT_ListaSucursal_NOMBRE.Text = DataGridView_ListaSucursal.SelectedCells.Item(2).Value
            ComboBox_ListaSucursal_Encargado.SelectedValue = DataGridView_ListaSucursal.SelectedCells.Item(3).Value
            TextBox_ListaSucursal_DireccionEstado.Text = DataGridView_ListaSucursal.SelectedCells.Item(6).Value
            TextBox_ListaSucursal_DirecccionMunicipio.Text = DataGridView_ListaSucursal.SelectedCells.Item(7).Value
            TXT_ListaSucursal_COLONIA.Text = DataGridView_ListaSucursal.SelectedCells.Item(8).Value
            TXT_ListaSucursal_CALLE.Text = DataGridView_ListaSucursal.SelectedCells.Item(9).Value
            TXT_ListaSucursal_NUMERO.Text = DataGridView_ListaSucursal.SelectedCells.Item(10).Value
            TXT_ListaSucursal_CODPOS.Text = DataGridView_ListaSucursal.SelectedCells.Item(11).Value
            Label_ListaSucursal_Fecha.Text = DataGridView_ListaSucursal.SelectedCells.Item(12).Value

            TabControl_ListaSucursales.SelectedIndex = 1
            BTN_ListaSucursal_ACEPTAR.Visible = False
            BTN_ListaSucursal_Editar.Visible = True


        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView_ListaSucursal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaSucursal.CellContentClick
        If e.ColumnIndex = DataGridView_ListaSucursal.Columns.Item("SeleccionarSucursal").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DataGridView_ListaSucursal.Rows(e.RowIndex).Cells("SeleccionarSucursal")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub FORM_SUCURSAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mostrar()
        Me.CargarComboBoxSucursales()

    End Sub

    Private Sub TXT_SUC_ENCARGADO_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Seleccionar_ListaSucursal_Empleado_CheckedChanged(sender As Object, e As EventArgs) Handles Seleccionar_ListaSucursal_Empleado.CheckedChanged
        If Seleccionar_ListaSucursal_Empleado.CheckState = CheckState.Checked Then
            DataGridView_ListaSucursal.Columns.Item("SeleccionarSucursal").Visible = True
            Button_ListaSucursal_Eliminar.Visible = True
            Button_ListaEmpleados_Activar.Visible = True
            Button_ListaEmpleados_Desactivar.Visible = True

        Else
            DataGridView_ListaSucursal.Columns.Item("SeleccionarSucursal").Visible = False
            Button_ListaSucursal_Eliminar.Visible = False
            Button_ListaEmpleados_Activar.Visible = False
            Button_ListaEmpleados_Desactivar.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_ListaSucursal_Editar.Click
        If Me.ValidateChildren = True And TXT_ListaSucursal_NOMBRE.Text <> "" And ComboBox_ListaSucursal_Encargado.Text <> "" And TextBox_ListaSucursal_DireccionEstado.Text <> "" And TextBox_ListaSucursal_DirecccionMunicipio.Text <> "" And
            TXT_ListaSucursal_COLONIA.Text <> "" And TXT_ListaSucursal_CALLE.Text <> "" And TXT_ListaSucursal_NUMERO.Text <> "" And TXT_ListaSucursal_CODPOS.Text <> "" Then
            Dim Newtienda As New Proyecto_Tienda.Tienda_Sucursal
            Dim NewSucursal As New Proyecto_Entidades.Sucursal

            NewSucursal.Id_sUCURSAL = TXT_SUC_NUM.Text
            NewSucursal.Nombre = TXT_ListaSucursal_NOMBRE.Text
            NewSucursal.Id_Encargado = ComboBox_ListaSucursal_Encargado.SelectedValue

            NewSucursal.Estado = TextBox_ListaSucursal_DireccionEstado.Text
            NewSucursal.Municipio = TextBox_ListaSucursal_DirecccionMunicipio.Text
            NewSucursal.Colonia = TXT_ListaSucursal_COLONIA.Text
            NewSucursal.Calle = TXT_ListaSucursal_CALLE.Text
            NewSucursal.NumeroDomecilio = TXT_ListaSucursal_NUMERO.Text
            NewSucursal.CodigoPostal = TXT_ListaSucursal_CODPOS.Text



            NewSucursal.FechaCreacion = Today


            If (Newtienda.Editar(NewSucursal)) Then
                MsgBox("La nueva sucursal se edito correctamente", vbOKOnly, "Edicion Exitosa")
                Me.Mostrar()

                TabControl_ListaSucursales.SelectedIndex = 0

            Else
                MsgBox("No se a podido Editar la sucursal", vbOKOnly + vbCritical, "Error al editar")
            End If

        Else
            MsgBox("Ingrese todos los datos que son necesarios (*)", vbOKOnly + vbCritical, "No se a podido editar la sucursal")



        End If
    End Sub

    Private Sub BTN_ListaSucursal_Cancelar_Click(sender As Object, e As EventArgs) Handles BTN_ListaSucursal_Cancelar.Click
        Me.Limpiar()
        TabControl_ListaSucursales.SelectedIndex = 0
    End Sub



    Private Sub Button_ListaSucursal_Buscar_Click(sender As Object, e As EventArgs) Handles Button_ListaSucursal_Buscar.Click
        Me.Buscar()
    End Sub

    Private Sub Button_ListaSucursal_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_ListaSucursal_Eliminar.Click
        If (MsgBox("¿Deseas eliminar la sucursal seleccionada?", vbYesNo, "Eliminar sucursal") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Sucursal

                For Each row As DataGridViewRow In DataGridView_ListaSucursal.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("SeleccionarSucursal").Value)
                    If seleccionado Then
                        Dim Llave As Integer = Convert.ToInt32(row.Cells("Numero de sucursal").Value)
                        NewTienda.Eliminar(Llave)
                    End If

                Next
                Me.Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class