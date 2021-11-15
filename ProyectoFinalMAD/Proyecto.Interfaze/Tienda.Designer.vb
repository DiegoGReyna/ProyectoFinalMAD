<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tienda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Tienda_BuscarPorCategoria = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox_Tienda_ProductoAbuscar = New System.Windows.Forms.TextBox()
        Me.Button_Tienda_BuscarProducto_CategoriaYsucursal = New System.Windows.Forms.Button()
        Me.ComboBox_Tienda_Categoria = New System.Windows.Forms.ComboBox()
        Me.Button_Tienda_Atras = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_Tienda_BuscarCategoria = New System.Windows.Forms.Button()
        Me.Tabla_Tienda_ListaProductos = New System.Windows.Forms.DataGridView()
        Me.SeleccionarProductoTienda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_Carrito = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TextBox_Tienda__IdCarrito = New System.Windows.Forms.TextBox()
        Me.TextBox_Tienda_IdCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_Carrito_TotalSinDescuento = New System.Windows.Forms.TextBox()
        Me.TextBox_Carrito_TotalAhorrado = New System.Windows.Forms.TextBox()
        Me.TextBox_Carrito_TotalApagar = New System.Windows.Forms.TextBox()
        Me.Button_Carrito_EliminarSelect = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tabla_Tienda_ListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView_Carrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1338, 700)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Button_Tienda_Atras)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Button_Tienda_BuscarCategoria)
        Me.TabPage1.Controls.Add(Me.Tabla_Tienda_ListaProductos)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1330, 674)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tienda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1234, 167)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.ComboBox_Tienda_BuscarPorCategoria)
        Me.GroupBox3.Location = New System.Drawing.Point(625, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 135)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(377, 51)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox3.TabIndex = 9
        '
        'ComboBox_Tienda_BuscarPorCategoria
        '
        Me.ComboBox_Tienda_BuscarPorCategoria.FormattingEnabled = True
        Me.ComboBox_Tienda_BuscarPorCategoria.Location = New System.Drawing.Point(75, 52)
        Me.ComboBox_Tienda_BuscarPorCategoria.Name = "ComboBox_Tienda_BuscarPorCategoria"
        Me.ComboBox_Tienda_BuscarPorCategoria.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox_Tienda_BuscarPorCategoria.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox_Tienda_ProductoAbuscar)
        Me.GroupBox2.Controls.Add(Me.Button_Tienda_BuscarProducto_CategoriaYsucursal)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Tienda_Categoria)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(590, 140)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(83, 62)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'TextBox_Tienda_ProductoAbuscar
        '
        Me.TextBox_Tienda_ProductoAbuscar.Location = New System.Drawing.Point(359, 52)
        Me.TextBox_Tienda_ProductoAbuscar.Name = "TextBox_Tienda_ProductoAbuscar"
        Me.TextBox_Tienda_ProductoAbuscar.Size = New System.Drawing.Size(189, 20)
        Me.TextBox_Tienda_ProductoAbuscar.TabIndex = 7
        '
        'Button_Tienda_BuscarProducto_CategoriaYsucursal
        '
        Me.Button_Tienda_BuscarProducto_CategoriaYsucursal.Location = New System.Drawing.Point(187, 100)
        Me.Button_Tienda_BuscarProducto_CategoriaYsucursal.Name = "Button_Tienda_BuscarProducto_CategoriaYsucursal"
        Me.Button_Tienda_BuscarProducto_CategoriaYsucursal.Size = New System.Drawing.Size(190, 23)
        Me.Button_Tienda_BuscarProducto_CategoriaYsucursal.TabIndex = 6
        Me.Button_Tienda_BuscarProducto_CategoriaYsucursal.Text = "Buscar por categoria y sucursal"
        Me.Button_Tienda_BuscarProducto_CategoriaYsucursal.UseVisualStyleBackColor = True
        '
        'ComboBox_Tienda_Categoria
        '
        Me.ComboBox_Tienda_Categoria.FormattingEnabled = True
        Me.ComboBox_Tienda_Categoria.Location = New System.Drawing.Point(83, 35)
        Me.ComboBox_Tienda_Categoria.Name = "ComboBox_Tienda_Categoria"
        Me.ComboBox_Tienda_Categoria.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox_Tienda_Categoria.TabIndex = 5
        '
        'Button_Tienda_Atras
        '
        Me.Button_Tienda_Atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button_Tienda_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Tienda_Atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button_Tienda_Atras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Tienda_Atras.Location = New System.Drawing.Point(30, 627)
        Me.Button_Tienda_Atras.Name = "Button_Tienda_Atras"
        Me.Button_Tienda_Atras.Size = New System.Drawing.Size(97, 32)
        Me.Button_Tienda_Atras.TabIndex = 3
        Me.Button_Tienda_Atras.Text = "Atras"
        Me.Button_Tienda_Atras.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(568, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button_Tienda_BuscarCategoria
        '
        Me.Button_Tienda_BuscarCategoria.Location = New System.Drawing.Point(429, 24)
        Me.Button_Tienda_BuscarCategoria.Name = "Button_Tienda_BuscarCategoria"
        Me.Button_Tienda_BuscarCategoria.Size = New System.Drawing.Size(133, 23)
        Me.Button_Tienda_BuscarCategoria.TabIndex = 4
        Me.Button_Tienda_BuscarCategoria.Text = "Seleccionar categoria"
        Me.Button_Tienda_BuscarCategoria.UseVisualStyleBackColor = True
        '
        'Tabla_Tienda_ListaProductos
        '
        Me.Tabla_Tienda_ListaProductos.AllowUserToAddRows = False
        Me.Tabla_Tienda_ListaProductos.AllowUserToDeleteRows = False
        Me.Tabla_Tienda_ListaProductos.AllowUserToOrderColumns = True
        Me.Tabla_Tienda_ListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Tabla_Tienda_ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Tienda_ListaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeleccionarProductoTienda})
        Me.Tabla_Tienda_ListaProductos.Location = New System.Drawing.Point(30, 253)
        Me.Tabla_Tienda_ListaProductos.Name = "Tabla_Tienda_ListaProductos"
        Me.Tabla_Tienda_ListaProductos.ReadOnly = True
        Me.Tabla_Tienda_ListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla_Tienda_ListaProductos.Size = New System.Drawing.Size(1234, 293)
        Me.Tabla_Tienda_ListaProductos.TabIndex = 0
        '
        'SeleccionarProductoTienda
        '
        Me.SeleccionarProductoTienda.HeaderText = "Seleccionar"
        Me.SeleccionarProductoTienda.Name = "SeleccionarProductoTienda"
        Me.SeleccionarProductoTienda.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Seleccionar sucursal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button_Carrito_EliminarSelect)
        Me.TabPage2.Controls.Add(Me.TextBox_Carrito_TotalApagar)
        Me.TabPage2.Controls.Add(Me.TextBox_Carrito_TotalAhorrado)
        Me.TabPage2.Controls.Add(Me.TextBox_Carrito_TotalSinDescuento)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DataGridView_Carrito)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1330, 674)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Carrito"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(1169, 582)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 39)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Pagar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(33, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Carrito "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(22, 498)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 43)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Imprimir "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(22, 461)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Eliminar todo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(847, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total a pagar sin descuentos: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(979, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total a pagar: "
        '
        'DataGridView_Carrito
        '
        Me.DataGridView_Carrito.AllowUserToAddRows = False
        Me.DataGridView_Carrito.AllowUserToOrderColumns = True
        Me.DataGridView_Carrito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.DataGridView_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Carrito.Location = New System.Drawing.Point(22, 91)
        Me.DataGridView_Carrito.Name = "DataGridView_Carrito"
        Me.DataGridView_Carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Carrito.Size = New System.Drawing.Size(1266, 290)
        Me.DataGridView_Carrito.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1330, 674)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Forma de pago y envio"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(948, 440)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Pendiente"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(792, 440)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Pagar "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Forma de Pago"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total a pagar: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "forma de envio: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Celular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre completo"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1330, 674)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Historial de resivos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(20, 89)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(1080, 291)
        Me.DataGridView3.TabIndex = 0
        '
        'TextBox_Tienda__IdCarrito
        '
        Me.TextBox_Tienda__IdCarrito.Location = New System.Drawing.Point(921, 12)
        Me.TextBox_Tienda__IdCarrito.Name = "TextBox_Tienda__IdCarrito"
        Me.TextBox_Tienda__IdCarrito.ReadOnly = True
        Me.TextBox_Tienda__IdCarrito.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Tienda__IdCarrito.TabIndex = 3
        '
        'TextBox_Tienda_IdCliente
        '
        Me.TextBox_Tienda_IdCliente.Location = New System.Drawing.Point(792, 12)
        Me.TextBox_Tienda_IdCliente.Name = "TextBox_Tienda_IdCliente"
        Me.TextBox_Tienda_IdCliente.ReadOnly = True
        Me.TextBox_Tienda_IdCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Tienda_IdCliente.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label10.Location = New System.Drawing.Point(966, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 24)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total ahorrado: "
        '
        'TextBox_Carrito_TotalSinDescuento
        '
        Me.TextBox_Carrito_TotalSinDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox_Carrito_TotalSinDescuento.Location = New System.Drawing.Point(1105, 404)
        Me.TextBox_Carrito_TotalSinDescuento.Name = "TextBox_Carrito_TotalSinDescuento"
        Me.TextBox_Carrito_TotalSinDescuento.ReadOnly = True
        Me.TextBox_Carrito_TotalSinDescuento.Size = New System.Drawing.Size(163, 26)
        Me.TextBox_Carrito_TotalSinDescuento.TabIndex = 9
        '
        'TextBox_Carrito_TotalAhorrado
        '
        Me.TextBox_Carrito_TotalAhorrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox_Carrito_TotalAhorrado.Location = New System.Drawing.Point(1105, 446)
        Me.TextBox_Carrito_TotalAhorrado.Name = "TextBox_Carrito_TotalAhorrado"
        Me.TextBox_Carrito_TotalAhorrado.ReadOnly = True
        Me.TextBox_Carrito_TotalAhorrado.Size = New System.Drawing.Size(163, 26)
        Me.TextBox_Carrito_TotalAhorrado.TabIndex = 10
        '
        'TextBox_Carrito_TotalApagar
        '
        Me.TextBox_Carrito_TotalApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox_Carrito_TotalApagar.Location = New System.Drawing.Point(1105, 488)
        Me.TextBox_Carrito_TotalApagar.Name = "TextBox_Carrito_TotalApagar"
        Me.TextBox_Carrito_TotalApagar.Size = New System.Drawing.Size(163, 26)
        Me.TextBox_Carrito_TotalApagar.TabIndex = 11
        '
        'Button_Carrito_EliminarSelect
        '
        Me.Button_Carrito_EliminarSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button_Carrito_EliminarSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Carrito_EliminarSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button_Carrito_EliminarSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Carrito_EliminarSelect.Location = New System.Drawing.Point(22, 421)
        Me.Button_Carrito_EliminarSelect.Name = "Button_Carrito_EliminarSelect"
        Me.Button_Carrito_EliminarSelect.Size = New System.Drawing.Size(212, 34)
        Me.Button_Carrito_EliminarSelect.TabIndex = 12
        Me.Button_Carrito_EliminarSelect.Text = "Eliminar Seleccionado"
        Me.Button_Carrito_EliminarSelect.UseVisualStyleBackColor = False
        '
        'Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox_Tienda_IdCliente)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox_Tienda__IdCarrito)
        Me.Name = "Tienda"
        Me.Text = "Tienda"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tabla_Tienda_ListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView_Carrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Tabla_Tienda_ListaProductos As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_Carrito As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TextBox_Tienda__IdCarrito As TextBox
    Friend WithEvents TextBox_Tienda_IdCliente As TextBox
    Friend WithEvents Button_Tienda_Atras As Button
    Friend WithEvents SeleccionarProductoTienda As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox_Tienda_BuscarPorCategoria As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox_Tienda_ProductoAbuscar As TextBox
    Friend WithEvents Button_Tienda_BuscarProducto_CategoriaYsucursal As Button
    Friend WithEvents ComboBox_Tienda_Categoria As ComboBox
    Friend WithEvents Button_Tienda_BuscarCategoria As Button
    Friend WithEvents TextBox_Carrito_TotalApagar As TextBox
    Friend WithEvents TextBox_Carrito_TotalAhorrado As TextBox
    Friend WithEvents TextBox_Carrito_TotalSinDescuento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button_Carrito_EliminarSelect As Button
End Class
