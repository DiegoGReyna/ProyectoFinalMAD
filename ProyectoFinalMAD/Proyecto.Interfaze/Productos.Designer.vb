<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_LISTA_PRODUCTOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_LISTPROD_IMPRIMIR = New System.Windows.Forms.Button()
        Me.TabControl_Productos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label_Productos_TotalProductos = New System.Windows.Forms.Label()
        Me.TextBox_Producto_ProductoBuscar = New System.Windows.Forms.TextBox()
        Me.Button_Productos_Desactivar = New System.Windows.Forms.Button()
        Me.Button_Productos_Activar = New System.Windows.Forms.Button()
        Me.Button_Productos_Eliminar = New System.Windows.Forms.Button()
        Me.CheckBox_Productos_Seleccionar = New System.Windows.Forms.CheckBox()
        Me.Button_Productos_Buscar = New System.Windows.Forms.Button()
        Me.DataGridView_Productos = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox_Producto_Sucursal = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button_Producto_Editar = New System.Windows.Forms.Button()
        Me.Button_Producto_CargaMasiva = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Producto_IdProducto = New System.Windows.Forms.TextBox()
        Me.TextBox_Producto_IdEmpleado = New System.Windows.Forms.TextBox()
        Me.TextBox_Producto_Descripcion = New System.Windows.Forms.TextBox()
        Me.TextBox_Producto_Descuento = New System.Windows.Forms.TextBox()
        Me.TextBox_Producto_Stock = New System.Windows.Forms.TextBox()
        Me.TextBox_Producto_Precio = New System.Windows.Forms.TextBox()
        Me.ComboBox_Productos_Categorias = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Producto_Nombre = New System.Windows.Forms.TextBox()
        Me.Button_Producto_Cancelar = New System.Windows.Forms.Button()
        Me.Button_Producto_Insertar = New System.Windows.Forms.Button()
        Me.TabControl_Productos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista Productos"
        '
        'BTN_LISTPROD_IMPRIMIR
        '
        Me.BTN_LISTPROD_IMPRIMIR.Location = New System.Drawing.Point(19, 459)
        Me.BTN_LISTPROD_IMPRIMIR.Name = "BTN_LISTPROD_IMPRIMIR"
        Me.BTN_LISTPROD_IMPRIMIR.Size = New System.Drawing.Size(89, 36)
        Me.BTN_LISTPROD_IMPRIMIR.TabIndex = 2
        Me.BTN_LISTPROD_IMPRIMIR.Text = "IMPRIMIR"
        Me.BTN_LISTPROD_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'TabControl_Productos
        '
        Me.TabControl_Productos.Controls.Add(Me.TabPage1)
        Me.TabControl_Productos.Controls.Add(Me.TabPage2)
        Me.TabControl_Productos.Location = New System.Drawing.Point(27, 26)
        Me.TabControl_Productos.Name = "TabControl_Productos"
        Me.TabControl_Productos.SelectedIndex = 0
        Me.TabControl_Productos.Size = New System.Drawing.Size(1247, 551)
        Me.TabControl_Productos.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label_Productos_TotalProductos)
        Me.TabPage1.Controls.Add(Me.TextBox_Producto_ProductoBuscar)
        Me.TabPage1.Controls.Add(Me.Button_Productos_Desactivar)
        Me.TabPage1.Controls.Add(Me.Button_Productos_Activar)
        Me.TabPage1.Controls.Add(Me.Button_Productos_Eliminar)
        Me.TabPage1.Controls.Add(Me.CheckBox_Productos_Seleccionar)
        Me.TabPage1.Controls.Add(Me.Button_Productos_Buscar)
        Me.TabPage1.Controls.Add(Me.DataGridView_Productos)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BTN_LISTPROD_IMPRIMIR)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1239, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista Productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label_Productos_TotalProductos
        '
        Me.Label_Productos_TotalProductos.AutoSize = True
        Me.Label_Productos_TotalProductos.Location = New System.Drawing.Point(912, 406)
        Me.Label_Productos_TotalProductos.Name = "Label_Productos_TotalProductos"
        Me.Label_Productos_TotalProductos.Size = New System.Drawing.Size(42, 15)
        Me.Label_Productos_TotalProductos.TabIndex = 12
        Me.Label_Productos_TotalProductos.Text = "Total"
        '
        'TextBox_Producto_ProductoBuscar
        '
        Me.TextBox_Producto_ProductoBuscar.Location = New System.Drawing.Point(252, 34)
        Me.TextBox_Producto_ProductoBuscar.Name = "TextBox_Producto_ProductoBuscar"
        Me.TextBox_Producto_ProductoBuscar.Size = New System.Drawing.Size(420, 23)
        Me.TextBox_Producto_ProductoBuscar.TabIndex = 9
        '
        'Button_Productos_Desactivar
        '
        Me.Button_Productos_Desactivar.Location = New System.Drawing.Point(301, 398)
        Me.Button_Productos_Desactivar.Name = "Button_Productos_Desactivar"
        Me.Button_Productos_Desactivar.Size = New System.Drawing.Size(87, 23)
        Me.Button_Productos_Desactivar.TabIndex = 8
        Me.Button_Productos_Desactivar.Text = "Desactivar"
        Me.Button_Productos_Desactivar.UseVisualStyleBackColor = True
        '
        'Button_Productos_Activar
        '
        Me.Button_Productos_Activar.Location = New System.Drawing.Point(220, 398)
        Me.Button_Productos_Activar.Name = "Button_Productos_Activar"
        Me.Button_Productos_Activar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Productos_Activar.TabIndex = 7
        Me.Button_Productos_Activar.Text = "Activar"
        Me.Button_Productos_Activar.UseVisualStyleBackColor = True
        '
        'Button_Productos_Eliminar
        '
        Me.Button_Productos_Eliminar.Location = New System.Drawing.Point(139, 398)
        Me.Button_Productos_Eliminar.Name = "Button_Productos_Eliminar"
        Me.Button_Productos_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Productos_Eliminar.TabIndex = 6
        Me.Button_Productos_Eliminar.Text = "Eliminar"
        Me.Button_Productos_Eliminar.UseVisualStyleBackColor = True
        '
        'CheckBox_Productos_Seleccionar
        '
        Me.CheckBox_Productos_Seleccionar.AutoSize = True
        Me.CheckBox_Productos_Seleccionar.Location = New System.Drawing.Point(19, 402)
        Me.CheckBox_Productos_Seleccionar.Name = "CheckBox_Productos_Seleccionar"
        Me.CheckBox_Productos_Seleccionar.Size = New System.Drawing.Size(103, 19)
        Me.CheckBox_Productos_Seleccionar.TabIndex = 5
        Me.CheckBox_Productos_Seleccionar.Text = "Seleccionar"
        Me.CheckBox_Productos_Seleccionar.UseVisualStyleBackColor = True
        '
        'Button_Productos_Buscar
        '
        Me.Button_Productos_Buscar.Location = New System.Drawing.Point(160, 34)
        Me.Button_Productos_Buscar.Name = "Button_Productos_Buscar"
        Me.Button_Productos_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Productos_Buscar.TabIndex = 4
        Me.Button_Productos_Buscar.Text = "Buscar"
        Me.Button_Productos_Buscar.UseVisualStyleBackColor = True
        '
        'DataGridView_Productos
        '
        Me.DataGridView_Productos.AllowUserToAddRows = False
        Me.DataGridView_Productos.AllowUserToDeleteRows = False
        Me.DataGridView_Productos.AllowUserToOrderColumns = True
        Me.DataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DataGridView_Productos.Location = New System.Drawing.Point(19, 63)
        Me.DataGridView_Productos.Name = "DataGridView_Productos"
        Me.DataGridView_Productos.ReadOnly = True
        Me.DataGridView_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Productos.Size = New System.Drawing.Size(1205, 329)
        Me.DataGridView_Productos.TabIndex = 3
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox_Producto_Sucursal)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Button_Producto_Editar)
        Me.TabPage2.Controls.Add(Me.Button_Producto_CargaMasiva)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TextBox_Producto_IdProducto)
        Me.TabPage2.Controls.Add(Me.TextBox_Producto_IdEmpleado)
        Me.TabPage2.Controls.Add(Me.TextBox_Producto_Descripcion)
        Me.TabPage2.Controls.Add(Me.TextBox_Producto_Descuento)
        Me.TabPage2.Controls.Add(Me.TextBox_Producto_Stock)
        Me.TabPage2.Controls.Add(Me.TextBox_Producto_Precio)
        Me.TabPage2.Controls.Add(Me.ComboBox_Productos_Categorias)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TextBox_Producto_Nombre)
        Me.TabPage2.Controls.Add(Me.Button_Producto_Cancelar)
        Me.TabPage2.Controls.Add(Me.Button_Producto_Insertar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1239, 523)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Creacion y edicion de producto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox_Producto_Sucursal
        '
        Me.ComboBox_Producto_Sucursal.FormattingEnabled = True
        Me.ComboBox_Producto_Sucursal.Location = New System.Drawing.Point(332, 303)
        Me.ComboBox_Producto_Sucursal.Name = "ComboBox_Producto_Sucursal"
        Me.ComboBox_Producto_Sucursal.Size = New System.Drawing.Size(394, 23)
        Me.ComboBox_Producto_Sucursal.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(234, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Sucursal(*)"
        '
        'Button_Producto_Editar
        '
        Me.Button_Producto_Editar.Location = New System.Drawing.Point(270, 451)
        Me.Button_Producto_Editar.Name = "Button_Producto_Editar"
        Me.Button_Producto_Editar.Size = New System.Drawing.Size(105, 40)
        Me.Button_Producto_Editar.TabIndex = 19
        Me.Button_Producto_Editar.Text = "Editar"
        Me.Button_Producto_Editar.UseVisualStyleBackColor = True
        '
        'Button_Producto_CargaMasiva
        '
        Me.Button_Producto_CargaMasiva.Location = New System.Drawing.Point(10, 473)
        Me.Button_Producto_CargaMasiva.Name = "Button_Producto_CargaMasiva"
        Me.Button_Producto_CargaMasiva.Size = New System.Drawing.Size(121, 44)
        Me.Button_Producto_CargaMasiva.TabIndex = 18
        Me.Button_Producto_CargaMasiva.Text = "Carga Masiva"
        Me.Button_Producto_CargaMasiva.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(512, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Id_Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(233, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Id_Empleado"
        '
        'TextBox_Producto_IdProducto
        '
        Me.TextBox_Producto_IdProducto.Location = New System.Drawing.Point(602, 51)
        Me.TextBox_Producto_IdProducto.Name = "TextBox_Producto_IdProducto"
        Me.TextBox_Producto_IdProducto.ReadOnly = True
        Me.TextBox_Producto_IdProducto.Size = New System.Drawing.Size(117, 23)
        Me.TextBox_Producto_IdProducto.TabIndex = 15
        '
        'TextBox_Producto_IdEmpleado
        '
        Me.TextBox_Producto_IdEmpleado.Location = New System.Drawing.Point(332, 51)
        Me.TextBox_Producto_IdEmpleado.Name = "TextBox_Producto_IdEmpleado"
        Me.TextBox_Producto_IdEmpleado.Size = New System.Drawing.Size(117, 23)
        Me.TextBox_Producto_IdEmpleado.TabIndex = 14
        '
        'TextBox_Producto_Descripcion
        '
        Me.TextBox_Producto_Descripcion.Location = New System.Drawing.Point(332, 344)
        Me.TextBox_Producto_Descripcion.Multiline = True
        Me.TextBox_Producto_Descripcion.Name = "TextBox_Producto_Descripcion"
        Me.TextBox_Producto_Descripcion.Size = New System.Drawing.Size(394, 87)
        Me.TextBox_Producto_Descripcion.TabIndex = 13
        '
        'TextBox_Producto_Descuento
        '
        Me.TextBox_Producto_Descuento.Location = New System.Drawing.Point(332, 262)
        Me.TextBox_Producto_Descuento.Name = "TextBox_Producto_Descuento"
        Me.TextBox_Producto_Descuento.Size = New System.Drawing.Size(171, 23)
        Me.TextBox_Producto_Descuento.TabIndex = 12
        '
        'TextBox_Producto_Stock
        '
        Me.TextBox_Producto_Stock.Location = New System.Drawing.Point(573, 209)
        Me.TextBox_Producto_Stock.Name = "TextBox_Producto_Stock"
        Me.TextBox_Producto_Stock.Size = New System.Drawing.Size(153, 23)
        Me.TextBox_Producto_Stock.TabIndex = 11
        '
        'TextBox_Producto_Precio
        '
        Me.TextBox_Producto_Precio.Location = New System.Drawing.Point(332, 209)
        Me.TextBox_Producto_Precio.Name = "TextBox_Producto_Precio"
        Me.TextBox_Producto_Precio.Size = New System.Drawing.Size(164, 23)
        Me.TextBox_Producto_Precio.TabIndex = 10
        '
        'ComboBox_Productos_Categorias
        '
        Me.ComboBox_Productos_Categorias.FormattingEnabled = True
        Me.ComboBox_Productos_Categorias.Location = New System.Drawing.Point(332, 153)
        Me.ComboBox_Productos_Categorias.Name = "ComboBox_Productos_Categorias"
        Me.ComboBox_Productos_Categorias.Size = New System.Drawing.Size(387, 23)
        Me.ComboBox_Productos_Categorias.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descuento(*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Precio(*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(502, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Stock(*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Categoria(*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre(*)"
        '
        'TextBox_Producto_Nombre
        '
        Me.TextBox_Producto_Nombre.Location = New System.Drawing.Point(332, 94)
        Me.TextBox_Producto_Nombre.Name = "TextBox_Producto_Nombre"
        Me.TextBox_Producto_Nombre.Size = New System.Drawing.Size(387, 23)
        Me.TextBox_Producto_Nombre.TabIndex = 2
        '
        'Button_Producto_Cancelar
        '
        Me.Button_Producto_Cancelar.Location = New System.Drawing.Point(573, 451)
        Me.Button_Producto_Cancelar.Name = "Button_Producto_Cancelar"
        Me.Button_Producto_Cancelar.Size = New System.Drawing.Size(105, 40)
        Me.Button_Producto_Cancelar.TabIndex = 1
        Me.Button_Producto_Cancelar.Text = "Cancelar"
        Me.Button_Producto_Cancelar.UseVisualStyleBackColor = True
        '
        'Button_Producto_Insertar
        '
        Me.Button_Producto_Insertar.Location = New System.Drawing.Point(398, 451)
        Me.Button_Producto_Insertar.Name = "Button_Producto_Insertar"
        Me.Button_Producto_Insertar.Size = New System.Drawing.Size(105, 40)
        Me.Button_Producto_Insertar.TabIndex = 0
        Me.Button_Producto_Insertar.Text = "Insertar"
        Me.Button_Producto_Insertar.UseVisualStyleBackColor = True
        '
        'FORM_LISTA_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1304, 599)
        Me.Controls.Add(Me.TabControl_Productos)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_LISTA_PRODUCTOS"
        Me.Text = "LISTA PRODUCTOS"
        Me.TabControl_Productos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_LISTPROD_IMPRIMIR As Button
    Friend WithEvents TabControl_Productos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView_Productos As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox_Producto_ProductoBuscar As TextBox
    Friend WithEvents Button_Productos_Desactivar As Button
    Friend WithEvents Button_Productos_Activar As Button
    Friend WithEvents Button_Productos_Eliminar As Button
    Friend WithEvents CheckBox_Productos_Seleccionar As CheckBox
    Friend WithEvents Button_Productos_Buscar As Button
    Friend WithEvents Label_Productos_TotalProductos As Label
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Producto_Nombre As TextBox
    Friend WithEvents Button_Producto_Cancelar As Button
    Friend WithEvents Button_Producto_Insertar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Producto_IdProducto As TextBox
    Friend WithEvents TextBox_Producto_IdEmpleado As TextBox
    Friend WithEvents TextBox_Producto_Descripcion As TextBox
    Friend WithEvents TextBox_Producto_Descuento As TextBox
    Friend WithEvents TextBox_Producto_Stock As TextBox
    Friend WithEvents TextBox_Producto_Precio As TextBox
    Friend WithEvents ComboBox_Productos_Categorias As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_Producto_Editar As Button
    Friend WithEvents Button_Producto_CargaMasiva As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_Producto_Sucursal As ComboBox
    Friend WithEvents Label10 As Label
End Class
