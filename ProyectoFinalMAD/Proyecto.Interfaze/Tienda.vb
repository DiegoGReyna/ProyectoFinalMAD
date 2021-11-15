Public Class Tienda
    Private TablaCarrito As DataTable


    Private _Id_Cliente As Integer
    Private _Id_Usuario As Integer
    Private _Id_Direccion As Integer
    Private _Id_Carrito As Integer
    Private _CorreoElectronico As String
    Private _NumCelular As String
    Private _Contrasena As String
    Private _Nombre As String
    Private _ApellidoPaterno As String
    Private _ApellidoMaterno As String
    Private _DireccionCompleta As String
    Private _Estado As String
    Private _Municipio As String
    Private _Colonia As String
    Private _CodigoPostal As String
    Private _Calle As String
    Private _NumeroCasa As String
    Private _Activo As String

    Public Property Id_Cliente As Integer
        Get
            Return _Id_Cliente
        End Get
        Set(value As Integer)
            _Id_Cliente = value
        End Set
    End Property

    Public Property Id_Usuario As Integer
        Get
            Return _Id_Usuario
        End Get
        Set(value As Integer)
            _Id_Usuario = value
        End Set
    End Property

    Public Property Id_Direccion As Integer
        Get
            Return _Id_Direccion
        End Get
        Set(value As Integer)
            _Id_Direccion = value
        End Set
    End Property

    Public Property Id_Carrito As Integer
        Get
            Return _Id_Carrito
        End Get
        Set(value As Integer)
            _Id_Carrito = value
        End Set
    End Property

    Public Property CorreoElectronico As String
        Get
            Return _CorreoElectronico
        End Get
        Set(value As String)
            _CorreoElectronico = value
        End Set
    End Property

    Public Property NumCelular As String
        Get
            Return _NumCelular
        End Get
        Set(value As String)
            _NumCelular = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return _Contrasena
        End Get
        Set(value As String)
            _Contrasena = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property ApellidoPaterno As String
        Get
            Return _ApellidoPaterno
        End Get
        Set(value As String)
            _ApellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno As String
        Get
            Return _ApellidoMaterno
        End Get
        Set(value As String)
            _ApellidoMaterno = value
        End Set
    End Property

    Public Property DireccionCompleta As String
        Get
            Return _DireccionCompleta
        End Get
        Set(value As String)
            _DireccionCompleta = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    Public Property Municipio As String
        Get
            Return _Municipio
        End Get
        Set(value As String)
            _Municipio = value
        End Set
    End Property

    Public Property Colonia As String
        Get
            Return _Colonia
        End Get
        Set(value As String)
            _Colonia = value
        End Set
    End Property

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(value As String)
            _CodigoPostal = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property

    Public Property NumeroCasa As String
        Get
            Return _NumeroCasa
        End Get
        Set(value As String)
            _NumeroCasa = value
        End Set
    End Property

    Public Property Activo As String
        Get
            Return _Activo
        End Get
        Set(value As String)
            _Activo = value
        End Set
    End Property

    Private Sub CargarTablaCarrito()
        Me.TablaCarrito = New DataTable("Carrito")
        Me.TablaCarrito.Columns.Add("Id_Articulo", System.Type.GetType("System.Int32"))
        Me.TablaCarrito.Columns.Add("Nombre", System.Type.GetType("System.String"))
        Me.TablaCarrito.Columns.Add("stock", System.Type.GetType("System.Int32"))
        Me.TablaCarrito.Columns.Add("Precio", System.Type.GetType("System.Decimal"))
        Me.TablaCarrito.Columns.Add("cantidad", System.Type.GetType("System.Int32"))
        Me.TablaCarrito.Columns.Add("Descuento", System.Type.GetType("System.Decimal"))
        Me.TablaCarrito.Columns.Add("TotalSinDescuento", System.Type.GetType("System.Decimal"))
        Me.TablaCarrito.Columns.Add("ahorrado", System.Type.GetType("System.Decimal"))
        Me.TablaCarrito.Columns.Add("TotalConDescuento", System.Type.GetType("System.Decimal"))

        DataGridView_Carrito.DataSource = Me.TablaCarrito
        DataGridView_Carrito.Columns(0).HeaderText = "Codigo"
        DataGridView_Carrito.Columns(0).Width = 100
        DataGridView_Carrito.Columns(1).HeaderText = "Nombre producto"
        DataGridView_Carrito.Columns(1).Width = 200
        DataGridView_Carrito.Columns(2).HeaderText = "stock"
        DataGridView_Carrito.Columns(3).Width = 100

        DataGridView_Carrito.Columns(3).HeaderText = "Precio"
        DataGridView_Carrito.Columns(3).Width = 200
        DataGridView_Carrito.Columns(4).HeaderText = "cantidad"
        DataGridView_Carrito.Columns(4).Width = 90
        DataGridView_Carrito.Columns(5).HeaderText = "Descuento"
        DataGridView_Carrito.Columns(5).Width = 90
        DataGridView_Carrito.Columns(6).HeaderText = "TotalSinDescuento"
        DataGridView_Carrito.Columns(6).Width = 150
        DataGridView_Carrito.Columns(7).HeaderText = "ahorrado"
        DataGridView_Carrito.Columns(7).Width = 100
        DataGridView_Carrito.Columns(8).HeaderText = "TotalConDescuento"
        DataGridView_Carrito.Columns(8).Width = 150

        DataGridView_Carrito.Columns(0).ReadOnly = True
        DataGridView_Carrito.Columns(1).ReadOnly = True
        DataGridView_Carrito.Columns(2).ReadOnly = True
        DataGridView_Carrito.Columns(3).ReadOnly = True
        DataGridView_Carrito.Columns(5).ReadOnly = True
        DataGridView_Carrito.Columns(6).ReadOnly = True
        DataGridView_Carrito.Columns(7).ReadOnly = True
        DataGridView_Carrito.Columns(8).ReadOnly = True

    End Sub
    Private Sub Formato()
        Tabla_Tienda_ListaProductos.Columns(0).Visible = False
        Tabla_Tienda_ListaProductos.Columns(0).Width = 80
        Tabla_Tienda_ListaProductos.Columns(1).Visible = False
        Tabla_Tienda_ListaProductos.Columns(1).Width = 100
        Tabla_Tienda_ListaProductos.Columns(2).Visible = False
        Tabla_Tienda_ListaProductos.Columns(2).Width = 100
        Tabla_Tienda_ListaProductos.Columns(3).Visible = False
        Tabla_Tienda_ListaProductos.Columns(3).Width = 120
        Tabla_Tienda_ListaProductos.Columns(4).Width = 200
        Tabla_Tienda_ListaProductos.Columns(5).Width = 100
        Tabla_Tienda_ListaProductos.Columns(5).Visible = False
        Tabla_Tienda_ListaProductos.Columns(6).Width = 100
        Tabla_Tienda_ListaProductos.Columns(7).Width = 80
        Tabla_Tienda_ListaProductos.Columns(8).Width = 80
        Tabla_Tienda_ListaProductos.Columns(9).Width = 80
        Tabla_Tienda_ListaProductos.Columns(10).Width = 300
        Tabla_Tienda_ListaProductos.Columns(11).Visible = False
        Tabla_Tienda_ListaProductos.Columns(11).Width = 100
        Tabla_Tienda_ListaProductos.Columns(12).Width = 90
        Tabla_Tienda_ListaProductos.Columns(12).Visible = False
        Tabla_Tienda_ListaProductos.Columns(13).Width = 200
        Tabla_Tienda_ListaProductos.Columns(14).Width = 90
        Tabla_Tienda_ListaProductos.Columns(14).Visible = False

        '' DataGridView_Productos.Columns.Item("Seleccionar").Visible = False
        ''Button_Productos_Eliminar.Visible = False
        '' Button_Productos_Activar.Visible = False
        '' Button_Productos_Desactivar.Visible = False
        ''CheckBox_Productos_Seleccionar.CheckState = False
        '' Label_Productos_TotalProductos.Text = "Total De Productos Registrados: " & DataGridView_Productos.DataSource.Rows.Count
    End Sub
    Private Sub Mostrar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Producto
            Tabla_Tienda_ListaProductos.DataSource = Tienda.ListaProducto_Cliente()

            Me.Formato()
            '' Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarCarrito(Fila As Proyecto_Entidades.Producto)
        Dim Aregado As Boolean = True
        For Each FilaCarritoTemp As DataGridViewRow In DataGridView_Carrito.Rows
            If (Convert.ToInt32(FilaCarritoTemp.Cells("Id_Articulo").Value) = Convert.ToInt32(Fila.ID_CodigoProducto)) Then
                Aregado = False
                MsgBox("El producto ya se encuntra en tu carrito", vbOKOnly + vbCritical, "No se agrego el producto al carrito")
            End If
        Next
        If (Aregado) Then
            Dim FilaProducto As DataRow
            Dim Descuento As Decimal
            Dim ResiduoDescuento As Decimal
            FilaProducto = Me.TablaCarrito.NewRow()
            FilaProducto("Id_Articulo") = Convert.ToString(Fila.ID_CodigoProducto)
            FilaProducto("Nombre") = Convert.ToString(Fila.Nombre)
            FilaProducto("stock") = Convert.ToString(Fila.Stock)
            FilaProducto("Precio") = Convert.ToString(Fila.Precio)
            FilaProducto("cantidad") = Convert.ToString(1)
            FilaProducto("Descuento") = Convert.ToString(Fila.Descuento)
            Descuento = Math.Round((Fila.Descuento / 100), 2)
            ResiduoDescuento = Math.Round((Fila.Precio * Descuento), 2)
            FilaProducto("ahorrado") = Convert.ToString(ResiduoDescuento)
            FilaProducto("TotalSinDescuento") = Convert.ToString(Fila.Precio)

            FilaProducto("TotalConDescuento") = Convert.ToString(Math.Round((Fila.Precio - ResiduoDescuento), 2))

            Me.TablaCarrito.Rows.Add(FilaProducto)
            Me.CalcularTotal_Y_Totalahorrado()
        End If

    End Sub
    Private Sub CalcularTotal_Y_Totalahorrado()
        Dim Total As Decimal = 0
        Dim TotalSinDescuento As Decimal = 0
        Dim TotalAhorrado As Decimal = 0
        For Each RowTemporal As DataGridViewRow In DataGridView_Carrito.Rows
            Total = Total + CDec(RowTemporal.Cells("TotalConDescuento").Value)
            TotalSinDescuento = TotalSinDescuento + CDec(RowTemporal.Cells("TotalSinDescuento").Value)
            TotalAhorrado = TotalAhorrado + CDec(RowTemporal.Cells("ahorrado").Value)
        Next

        TextBox_Carrito_TotalSinDescuento.Text = TotalSinDescuento
        TextBox_Carrito_TotalAhorrado.Text = TotalAhorrado
        TextBox_Carrito_TotalApagar.Text = Total


    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button_Tienda_Atras_Click(sender As Object, e As EventArgs) Handles Button_Tienda_Atras.Click
        Me.Close()
        MenuPrincipalCliente.Show()

    End Sub

    Private Sub Tienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarTablaCarrito()
        Me.Mostrar()
        TextBox_Tienda_IdCliente.Text = Id_Cliente
        TextBox_Tienda__IdCarrito.Text = Id_Carrito
        ''=Id_Usuario
        ''=Id_Direccion

    End Sub

    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Carrito.CellContentDoubleClick

    End Sub

    Private Sub Tabla_Tienda_ListaProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Tienda_ListaProductos.CellDoubleClick
        Try
            Dim newProducto As New Proyecto_Entidades.Producto
            Dim IdCarrito As Integer

            newProducto.ID_CodigoProducto = Tabla_Tienda_ListaProductos.SelectedCells.Item(3).Value
            newProducto.Nombre = Tabla_Tienda_ListaProductos.SelectedCells.Item(4).Value
            newProducto.Precio = Tabla_Tienda_ListaProductos.SelectedCells.Item(7).Value
            newProducto.Descuento = Tabla_Tienda_ListaProductos.SelectedCells.Item(8).Value
            newProducto.Stock = Tabla_Tienda_ListaProductos.SelectedCells.Item(9).Value
            IdCarrito = TextBox_Tienda__IdCarrito.Text

            Me.AgregarCarrito(newProducto)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView_Carrito_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Carrito.CellEndEdit
        Dim RowProductos As DataGridViewRow = CType(DataGridView_Carrito.Rows(e.RowIndex), DataGridViewRow)
        Dim Precio As Decimal = RowProductos.Cells("Precio").Value
        Dim Descuento As Decimal = RowProductos.Cells("Descuento").Value
        Dim Cantidad As Integer = RowProductos.Cells("cantidad").Value
        Dim TotalSinDescuento As Decimal
        Dim DescuentoFinal As Decimal
        Dim ResiduoDescuento As Decimal
        Dim Ahorrado As Decimal
        Dim PrecioConDescuento As Decimal
        Dim TotalConDescuento As Decimal

        ''Dim ahorrado As Decimal = RowProductos.Cells("ahorrado").Value
        ''Dim TatalSinDescuento As Decimal = RowProductos.Cells("TotalSinDescuento").Value
        ''Dim TatalConDescuento As Decimal = RowProductos.Cells("TotalConDescuento").Value
        DescuentoFinal = Math.Round((Descuento / 100), 2)
        TotalSinDescuento = Precio * Cantidad
        ResiduoDescuento = Math.Round((Precio * DescuentoFinal), 2)

        Ahorrado = Math.Round((ResiduoDescuento * Cantidad), 2)

        PrecioConDescuento = Math.Round((Precio - ResiduoDescuento), 2)

        TotalConDescuento = Math.Round((PrecioConDescuento * Cantidad), 2)

        RowProductos.Cells("ahorrado").Value = Ahorrado
        RowProductos.Cells("TotalSinDescuento").Value = TotalSinDescuento
        RowProductos.Cells("TotalConDescuento").Value = TotalConDescuento
        Me.CalcularTotal_Y_Totalahorrado()

    End Sub

    Private Sub DataGridView_Carrito_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView_Carrito.RowsRemoved
        Me.CalcularTotal_Y_Totalahorrado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ''DataGridView_Carrito.DataSource = Nothing
        ''DataGridView_Carrito.Refresh()
        DataGridView_Carrito.DataSource = Nothing
        ''Me.CalcularTotal_Y_Totalahorrado()
        CargarTablaCarrito()


    End Sub

    Private Sub Button_Carrito_EliminarSelect_Click(sender As Object, e As EventArgs) Handles Button_Carrito_EliminarSelect.Click
        For Each FilaCarritoTemp As DataGridViewRow In DataGridView_Carrito.SelectedRows

            DataGridView_Carrito.Rows.Remove(FilaCarritoTemp)

        Next
    End Sub
End Class