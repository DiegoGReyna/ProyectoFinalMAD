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

        DataGridView_ListaEmpleados.Columns.Item("SeleccionarEmpleado").Visible = False

    End Sub
    Private Sub Mostrar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Empleado
            DataGridView_ListaEmpleados.DataSource = Tienda.ListaEmpleado()

            Me.Formato()
            'Me.Limpiar()
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

    Private Sub BTN_LISTEMPLEADOS_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTN_LISTEMPLEADOS_IMPRIMIR.Click

    End Sub

    Private Sub DataGridView_Empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaEmpleados.CellContentClick

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
        If Me.ValidateChildren = True And TextBox_ListaEmpleado_DireccionEstado.Text <> "" Then
            If TextBox_ListaEmpleado_DireccionEstado.Text.Length > 5 Then
                MsgBox("Tamaño maximo de estado")

            End If
        End If

    End Sub
End Class