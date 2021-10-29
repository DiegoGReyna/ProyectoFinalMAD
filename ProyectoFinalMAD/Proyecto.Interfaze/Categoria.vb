Public Class FrmCategoria
    Private Sub Formato()
        DataGridView_ListaCategoria.Columns(0).Visible = False
        DataGridView_ListaCategoria.Columns(0).Width = 80
        DataGridView_ListaCategoria.Columns(1).Width = 365
        DataGridView_ListaCategoria.Columns(2).Width = 350
        DataGridView_ListaCategoria.Columns.Item("Seleccionar").Visible = False
        Button_Categoria_Eliminar.Visible = False
        CheckBox_Categoria_SeleccionarCategoria.CheckState = False
    End Sub
    Private Sub Mostrar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Categoria
            DataGridView_ListaCategoria.DataSource = Tienda.ListaCategoria()
            Label_TotalCategorias.Text = "Total De Categorias: " & DataGridView_ListaCategoria.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Categoria
            Dim categoriaAbuscar As String
            categoriaAbuscar = TextBox_Categoria_A_Buscar.Text
            DataGridView_ListaCategoria.DataSource = Tienda.BuscarCategoria(categoriaAbuscar)

            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        Button_Insertar_Categoria.Visible = True
        Button_Insertar_Categoria.Visible = True
        Button_Categoria_Editar.Visible = False
        TextBox_Categoria_Nombre.Text = ""
        TextBox_Categoria_IDcategoria.Text = ""
        TextBox_Categoria_A_Buscar.Text = ""

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mostrar()
    End Sub

    Private Sub Button_BuscarCategoria_Click(sender As Object, e As EventArgs) Handles Button_BuscarCategoria.Click
        Me.Buscar()
    End Sub

    Private Sub Button_Insertar_Categoria_Click(sender As Object, e As EventArgs) Handles Button_Insertar_Categoria.Click
        If Me.ValidateChildren = True And TextBox_Categoria_Nombre.Text <> "" Then
            Dim NewCategoria As New Proyecto_Entidades.CategoriaDeProducto
            Dim Newtienda As New Proyecto_Tienda.Tienda_Categoria

            NewCategoria.Nombre_Categoria = TextBox_Categoria_Nombre.Text
            If (Newtienda.Insertar(NewCategoria)) Then
                MsgBox("La Nueva Categoria se ingreso correctamente", vbOKOnly, "Ingreso Exitoso")
                Me.Mostrar()
            Else
                MsgBox("No se a podido ingresar una nueva categoria", vbOKOnly + vbCritical, "Error al ingresar")
            End If

        Else
                MsgBox("Ingrese un nombre para la categoria (*)", vbOKOnly + vbCritical, "No se a podido ingresar una categoria")
        End If
    End Sub

    Private Sub Button_Categoria_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Categoria_Cancelar.Click
        Me.Limpiar()
        TabControlGeneral_Categoria.SelectedIndex = 0
    End Sub

    Private Sub DataGridView_ListaCategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaCategoria.CellDoubleClick
        TextBox_Categoria_IDcategoria.Text = DataGridView_ListaCategoria.SelectedCells.Item(1).Value
        TextBox_Categoria_Nombre.Text = DataGridView_ListaCategoria.SelectedCells.Item(2).Value
        TabControlGeneral_Categoria.SelectedIndex = 1
        Button_Insertar_Categoria.Visible = False
        Button_Categoria_Editar.Visible = True
    End Sub

    Private Sub Button_Categoria_Editar_Click(sender As Object, e As EventArgs) Handles Button_Categoria_Editar.Click
        If Me.ValidateChildren = True And TextBox_Categoria_Nombre.Text <> "" And TextBox_Categoria_IDcategoria.Text <> "" Then
            Dim NewCategoria As New Proyecto_Entidades.CategoriaDeProducto
            Dim Newtienda As New Proyecto_Tienda.Tienda_Categoria
            NewCategoria.Id_CategoriaProducto_Categoria = TextBox_Categoria_IDcategoria.Text
            NewCategoria.Nombre_Categoria = TextBox_Categoria_Nombre.Text
            If (Newtienda.Editar(NewCategoria)) Then
                MsgBox("La Nueva Categoria se Edito correctamente", vbOKOnly, "Edicion Exitosa")
                Me.Mostrar()
                TabControlGeneral_Categoria.SelectedIndex = 0
            Else
                MsgBox("No se a podido Editar la categoria", vbOKOnly + vbCritical, "Error al Editar")
            End If

        Else
            MsgBox("Ingrese un nombre para la categoria (*)", vbOKOnly + vbCritical, "No se a podido Editar la categoria")
        End If
    End Sub

    Private Sub CheckBox_Categoria_SeleccionarCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Categoria_SeleccionarCategoria.CheckedChanged
        If CheckBox_Categoria_SeleccionarCategoria.CheckState = CheckState.Checked Then
            DataGridView_ListaCategoria.Columns.Item("Seleccionar").Visible = True
            Button_Categoria_Eliminar.Visible = True

        Else
            DataGridView_ListaCategoria.Columns.Item("Seleccionar").Visible = False
            Button_Categoria_Eliminar.Visible = False
        End If
    End Sub

    Private Sub DataGridView_ListaCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaCategoria.CellContentClick
        If e.ColumnIndex = DataGridView_ListaCategoria.Columns.Item("Seleccionar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DataGridView_ListaCategoria.Rows(e.RowIndex).Cells("Seleccionar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub Button_Categoria_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Categoria_Eliminar.Click
        If (MsgBox("¿Deseas eliminar la categoria seleccionada?", vbYesNo, "Eliminar categoria") = vbYes) Then
            Try
                Dim NewTienda As New Proyecto_Tienda.Tienda_Categoria

                For Each row As DataGridViewRow In DataGridView_ListaCategoria.Rows
                    Dim seleccionado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If seleccionado Then
                        Dim Llave As Integer = Convert.ToInt32(row.Cells("ID").Value)
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