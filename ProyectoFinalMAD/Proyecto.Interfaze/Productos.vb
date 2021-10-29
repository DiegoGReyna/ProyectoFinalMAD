Public Class FORM_LISTA_PRODUCTOS
    Public Function SoloNumeros(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57 Or Key = 8 Or Key = 46 Or Key = 44) Then
            SoloNumeros = False
        Else
            SoloNumeros = True
            MsgBox("Ingrese solo numeros", vbOKOnly + vbCritical, "Error al ingresar")
        End If
    End Function
    Private Sub Formato()
        DataGridView_Productos.Columns(0).Visible = False
        DataGridView_Productos.Columns(0).Width = 80
        DataGridView_Productos.Columns(1).Width = 100
        DataGridView_Productos.Columns(2).Width = 100
        DataGridView_Productos.Columns(3).Width = 100
        DataGridView_Productos.Columns(4).Width = 100
        DataGridView_Productos.Columns(5).Width = 100
        DataGridView_Productos.Columns(6).Width = 100
        DataGridView_Productos.Columns(7).Width = 100
        DataGridView_Productos.Columns(8).Width = 360
        DataGridView_Productos.Columns(9).Width = 80

        DataGridView_Productos.Columns.Item("Seleccionar").Visible = False
        Button_Productos_Eliminar.Visible = False
        Button_Productos_Activar.Visible = False
        Button_Productos_Desactivar.Visible = False
        CheckBox_Productos_Seleccionar.CheckState = False
        Label_Productos_TotalProductos.Text = "Total De Productos Registrados: " & DataGridView_Productos.DataSource.Rows.Count
    End Sub
    Private Sub Mostrar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Producto
            DataGridView_Productos.DataSource = Tienda.ListaProducto()

            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Producto
            Dim ProductoAbuscar As String
            ProductoAbuscar = TextBox_Producto_ProductoBuscar.Text
            DataGridView_Productos.DataSource = Tienda.BuscarProducto(ProductoAbuscar)

            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()

        Button_Producto_Insertar.Visible = True
        Button_Producto_Editar.Visible = False
        TextBox_Producto_Nombre.Text = ""
        TextBox_Producto_Precio.Text = ""
        TextBox_Producto_Stock.Text = ""
        TextBox_Producto_Descuento.Text = ""
        TextBox_Producto_Descripcion.Text = ""

    End Sub
    Private Sub CargarComboBoxCategorias()
        Try
            Dim NewTienda As New Proyecto_Tienda.Tienda_Categoria
            ComboBox_Productos_Categorias.DataSource = NewTienda.ComboBoxCategorias
            ComboBox_Productos_Categorias.ValueMember = "Id_CategoriaProducto"
            ComboBox_Productos_Categorias.DisplayMember = "Nombre"

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub BTN_LISTPROD_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTN_LISTPROD_IMPRIMIR.Click

    End Sub

    Private Sub FORM_LISTA_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mostrar()
        Me.CargarComboBoxCategorias()
    End Sub

    Private Sub DataGridView_Productos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Productos.CellContentDoubleClick

    End Sub

    Private Sub Button_Productos_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Productos_Buscar.Click
        Me.Buscar()
    End Sub

    Private Sub Button_Producto_Insertar_Click(sender As Object, e As EventArgs) Handles Button_Producto_Insertar.Click

        If Me.ValidateChildren = True And TextBox_Producto_Nombre.Text <> "" And ComboBox_Productos_Categorias.Text <> "" And TextBox_Producto_IdEmpleado.Text <> "" And TextBox_Producto_Precio.Text <> "" Then
            Dim NewProducto As New Proyecto_Entidades.Producto
            Dim Newtienda As New Proyecto_Tienda.Tienda_Producto


            NewProducto.Nombre_ = TextBox_Producto_Nombre.Text
            NewProducto.ID_Categoria_ = ComboBox_Productos_Categorias.SelectedValue
            NewProducto.Precio_ = TextBox_Producto_Precio.Text
            NewProducto.Stock_ = TextBox_Producto_Stock.Text
            NewProducto.Descuento_ = TextBox_Producto_Descuento.Text
            NewProducto.Descripcion_ = TextBox_Producto_Descripcion.Text
            NewProducto.ID_Empleado_ = TextBox_Producto_IdEmpleado.Text

            If (Newtienda.Insertar(NewProducto)) Then
                MsgBox("El nuevo producto se ingreso correctamente", vbOKOnly, "Ingreso Exitoso")
                Me.Mostrar()
            Else
                MsgBox("No se a podido ingresar el nuevo producto", vbOKOnly + vbCritical, "Error al ingresar")
            End If

        Else
            MsgBox("Ingrese todos los datos que son necesarios (*)", vbOKOnly + vbCritical, "No se a podido ingresar el nuevo producto")
        End If
    End Sub

    Private Sub Button_Producto_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Producto_Cancelar.Click
        Me.Limpiar()
        TabControl_Productos.SelectedIndex = 0
    End Sub

    Private Sub TextBox_Producto_Nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Producto_Nombre.TextChanged

    End Sub

    Private Sub TextBox_Producto_Stock_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Producto_Stock.TextChanged

    End Sub

    Private Sub TextBox_Producto_Stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Producto_Stock.KeyPress
        e.Handled = SoloNumeros(Asc(e.KeyChar))
    End Sub

    Private Sub TextBox_Producto_Precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Producto_Precio.TextChanged

    End Sub

    Private Sub TextBox_Producto_Precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Producto_Precio.KeyPress
        e.Handled = SoloNumeros(Asc(e.KeyChar))
    End Sub

    Private Sub TextBox_Producto_Descuento_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Producto_Descuento.TextChanged

    End Sub

    Private Sub TextBox_Producto_Descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Producto_Descuento.KeyPress
        e.Handled = SoloNumeros(Asc(e.KeyChar))
    End Sub

    Private Sub DataGridView_Productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Productos.CellDoubleClick
        Try
            TextBox_Producto_IdEmpleado.Text = DataGridView_Productos.SelectedCells.Item(1).Value
            TextBox_Producto_IdProducto.Text = DataGridView_Productos.SelectedCells.Item(2).Value
            TextBox_Producto_Nombre.Text = DataGridView_Productos.SelectedCells.Item(3).Value
            TextBox_Producto_Precio.Text = DataGridView_Productos.SelectedCells.Item(5).Value
            TextBox_Producto_Descuento.Text = DataGridView_Productos.SelectedCells.Item(6).Value
            TextBox_Producto_Stock.Text = DataGridView_Productos.SelectedCells.Item(7).Value
            TextBox_Producto_Descripcion.Text = DataGridView_Productos.SelectedCells.Item(8).Value
            TabControl_Productos.SelectedIndex = 1
            Button_Producto_Insertar.Visible = False
            Button_Producto_Editar.Visible = True
            ComboBox_Productos_Categorias.SelectedValue = DataGridView_Productos.SelectedCells.Item(4).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Producto_Editar_Click(sender As Object, e As EventArgs) Handles Button_Producto_Editar.Click

        If Me.ValidateChildren = True And TextBox_Producto_Nombre.Text <> "" And ComboBox_Productos_Categorias.Text <> "" And TextBox_Producto_IdEmpleado.Text <> "" And TextBox_Producto_Precio.Text <> "" And TextBox_Producto_IdProducto.Text <> "" Then
            Dim NewProducto As New Proyecto_Entidades.Producto
            Dim Newtienda As New Proyecto_Tienda.Tienda_Producto

            NewProducto.ID_CodigoProducto_ = TextBox_Producto_IdProducto.Text
            NewProducto.Nombre_ = TextBox_Producto_Nombre.Text
            NewProducto.ID_Categoria_ = ComboBox_Productos_Categorias.SelectedValue
            NewProducto.Precio_ = TextBox_Producto_Precio.Text
            NewProducto.Stock_ = TextBox_Producto_Stock.Text
            NewProducto.Descuento_ = TextBox_Producto_Descuento.Text
            NewProducto.Descripcion_ = TextBox_Producto_Descripcion.Text
            NewProducto.ID_Empleado_ = TextBox_Producto_IdEmpleado.Text

            If (Newtienda.Editar(NewProducto)) Then
                MsgBox("La Nueva Categoria se Edito correctamente", vbOKOnly, "Edicion Exitoso")
                Me.Mostrar()
                TabControl_Productos.SelectedIndex = 0

            Else
                MsgBox("No se a podido ingresar una nueva categoria", vbOKOnly + vbCritical, "Error al Editar")
            End If

        Else
            MsgBox("Ingrese todos los datos que son necesarios (*)", vbOKOnly + vbCritical, "No se a podido Editar el producto")
        End If

    End Sub

    Private Sub DataGridView_Productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Productos.CellContentClick
        If e.ColumnIndex = DataGridView_Productos.Columns.Item("Seleccionar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DataGridView_Productos.Rows(e.RowIndex).Cells("Seleccionar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub CheckBox_Productos_Seleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Productos_Seleccionar.CheckedChanged
        If CheckBox_Productos_Seleccionar.CheckState = CheckState.Checked Then
            DataGridView_Productos.Columns.Item("Seleccionar").Visible = True
            Button_Productos_Eliminar.Visible = True
            Button_Productos_Activar.Visible = True
            Button_Productos_Desactivar.Visible = True

        Else
            DataGridView_Productos.Columns.Item("Seleccionar").Visible = False
            Button_Productos_Eliminar.Visible = False
            Button_Productos_Activar.Visible = False
            Button_Productos_Desactivar.Visible = False
        End If
    End Sub

    Private Sub Button_Productos_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Productos_Eliminar.Click
        If (MsgBox("¿Deseas eliminar el producto seleccionado?", vbYesNo, "Eliminar producto") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Producto

                For Each row As DataGridViewRow In DataGridView_Productos.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If seleccionado Then
                        Dim Llave As Integer = Convert.ToInt32(row.Cells("codigoProducto").Value)
                        NewTienda.Eliminar(Llave)
                    End If

                Next
                Me.Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button_Productos_Activar_Click(sender As Object, e As EventArgs) Handles Button_Productos_Activar.Click
        If (MsgBox("¿Deseas Activar el producto seleccionado?", vbYesNo, "Activar producto") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Producto

                For Each row As DataGridViewRow In DataGridView_Productos.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If seleccionado Then
                        Dim Llave As Integer = Convert.ToInt32(row.Cells("codigoProducto").Value)
                        NewTienda.Activar(Llave)
                    End If

                Next
                Me.Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button_Productos_Desactivar_Click(sender As Object, e As EventArgs) Handles Button_Productos_Desactivar.Click
        If (MsgBox("¿Deseas Activar el producto seleccionado?", vbYesNo, "Activar producto") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Producto

                For Each row As DataGridViewRow In DataGridView_Productos.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If seleccionado Then
                        Dim Llave As Integer = Convert.ToInt32(row.Cells("codigoProducto").Value)
                        NewTienda.Desactivar(Llave)
                    End If

                Next
                Me.Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class