<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_LISTA_EMPLEADO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_LISTEMPLEADOS_IMPRIMIR = New System.Windows.Forms.Button()
        Me.DataGridView_ListaEmpleados = New System.Windows.Forms.DataGridView()
        Me.SeleccionarEmpleado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControl_ListaEmpleados = New System.Windows.Forms.TabControl()
        Me.ListaEmpleados = New System.Windows.Forms.TabPage()
        Me.Button_ListaEmpleados_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_ListaEmpleados_TextAbuscar = New System.Windows.Forms.TextBox()
        Me.Button_ListaEmpleados_Desactivar = New System.Windows.Forms.Button()
        Me.Button_ListaEmpleados_Activar = New System.Windows.Forms.Button()
        Me.Button_ListaEmpleados_Eliminar = New System.Windows.Forms.Button()
        Me.Seleccionar_Empleado = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox_ListaEmpleados_IdDireccion = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_IdDireccion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_ListaEmpleado_SucursalDondeTrabaja = New System.Windows.Forms.ComboBox()
        Me.Label_ListaEmpleado_Sucursal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_ListaEmpleado_EmpleadoRFC = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_EmpleadoNomUsuario = New System.Windows.Forms.TextBox()
        Me.CheckBox_ListaEmpleados_EsAdministrador = New System.Windows.Forms.CheckBox()
        Me.Label_ListaEmpleados_RFC = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_NombreUsuario = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleado_Empleados = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_IdUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_ListaEmpleado_FechaUltimaMod = New System.Windows.Forms.TextBox()
        Me.TextBoxTextBox_ListaEmpleado_IDUsuario = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_IDEmpleado = New System.Windows.Forms.TextBox()
        Me.Button_ListaEmpleado_Editar = New System.Windows.Forms.Button()
        Me.Button_ListaEmpleado_Cancelar = New System.Windows.Forms.Button()
        Me.Button_ListaEmpleado_Agregar = New System.Windows.Forms.Button()
        Me.GroupBox_ListaEmpleado_Usuarios = New System.Windows.Forms.GroupBox()
        Me.TextBox_ListaEmpleado_UsuarioContrasena = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_UsuarioCURP = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_usuarioApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_usuarioApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_UsuarioNombre = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_UsuarioCURP = New System.Windows.Forms.Label()
        Me.DateTimePicker1_ListaEmpleados_ = New System.Windows.Forms.DateTimePicker()
        Me.Label_ListaEmpleados_FechaNacimiento = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Contrasena = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_ApellidoMaterno = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_ApellidoPaterno = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Nombre = New System.Windows.Forms.Label()
        Me.GroupBox_ListaEmpleado_Direccion = New System.Windows.Forms.GroupBox()
        Me.TextBox_ListaEmpleado_NumDomicilio = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_DireccionCalle = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_DireccionCodigoPostal = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaEmpleado_DireccionColonia = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_NumeroDomicilio = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Calle = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_CodigoPostal = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Colonia = New System.Windows.Forms.Label()
        Me.TextBox_ListaEmpleado_DireccionMunicipio = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_Municipio = New System.Windows.Forms.Label()
        Me.TextBox_ListaEmpleado_DireccionEstado = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_Estado = New System.Windows.Forms.Label()
        CType(Me.DataGridView_ListaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_ListaEmpleados.SuspendLayout()
        Me.ListaEmpleados.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_ListaEmpleado_Usuarios.SuspendLayout()
        Me.GroupBox_ListaEmpleado_Direccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista Empleados"
        '
        'BTN_LISTEMPLEADOS_IMPRIMIR
        '
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Location = New System.Drawing.Point(6, 455)
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Name = "BTN_LISTEMPLEADOS_IMPRIMIR"
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Size = New System.Drawing.Size(120, 61)
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.TabIndex = 2
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Text = "IMPRIMIR"
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'DataGridView_ListaEmpleados
        '
        Me.DataGridView_ListaEmpleados.AllowUserToAddRows = False
        Me.DataGridView_ListaEmpleados.AllowUserToDeleteRows = False
        Me.DataGridView_ListaEmpleados.AllowUserToOrderColumns = True
        Me.DataGridView_ListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ListaEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeleccionarEmpleado})
        Me.DataGridView_ListaEmpleados.Location = New System.Drawing.Point(10, 59)
        Me.DataGridView_ListaEmpleados.Name = "DataGridView_ListaEmpleados"
        Me.DataGridView_ListaEmpleados.ReadOnly = True
        Me.DataGridView_ListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_ListaEmpleados.Size = New System.Drawing.Size(1250, 329)
        Me.DataGridView_ListaEmpleados.TabIndex = 3
        '
        'SeleccionarEmpleado
        '
        Me.SeleccionarEmpleado.HeaderText = "Seleccionar"
        Me.SeleccionarEmpleado.Name = "SeleccionarEmpleado"
        Me.SeleccionarEmpleado.ReadOnly = True
        '
        'TabControl_ListaEmpleados
        '
        Me.TabControl_ListaEmpleados.Controls.Add(Me.ListaEmpleados)
        Me.TabControl_ListaEmpleados.Controls.Add(Me.TabPage2)
        Me.TabControl_ListaEmpleados.Location = New System.Drawing.Point(12, 30)
        Me.TabControl_ListaEmpleados.Name = "TabControl_ListaEmpleados"
        Me.TabControl_ListaEmpleados.SelectedIndex = 0
        Me.TabControl_ListaEmpleados.Size = New System.Drawing.Size(1284, 550)
        Me.TabControl_ListaEmpleados.TabIndex = 4
        '
        'ListaEmpleados
        '
        Me.ListaEmpleados.Controls.Add(Me.Button_ListaEmpleados_Buscar)
        Me.ListaEmpleados.Controls.Add(Me.TextBox_ListaEmpleados_TextAbuscar)
        Me.ListaEmpleados.Controls.Add(Me.Button_ListaEmpleados_Desactivar)
        Me.ListaEmpleados.Controls.Add(Me.Button_ListaEmpleados_Activar)
        Me.ListaEmpleados.Controls.Add(Me.Button_ListaEmpleados_Eliminar)
        Me.ListaEmpleados.Controls.Add(Me.Seleccionar_Empleado)
        Me.ListaEmpleados.Controls.Add(Me.DataGridView_ListaEmpleados)
        Me.ListaEmpleados.Controls.Add(Me.Label1)
        Me.ListaEmpleados.Controls.Add(Me.BTN_LISTEMPLEADOS_IMPRIMIR)
        Me.ListaEmpleados.Location = New System.Drawing.Point(4, 24)
        Me.ListaEmpleados.Name = "ListaEmpleados"
        Me.ListaEmpleados.Padding = New System.Windows.Forms.Padding(3)
        Me.ListaEmpleados.Size = New System.Drawing.Size(1276, 522)
        Me.ListaEmpleados.TabIndex = 0
        Me.ListaEmpleados.Text = "ListaEmpleados"
        Me.ListaEmpleados.UseVisualStyleBackColor = True
        '
        'Button_ListaEmpleados_Buscar
        '
        Me.Button_ListaEmpleados_Buscar.Location = New System.Drawing.Point(303, 22)
        Me.Button_ListaEmpleados_Buscar.Name = "Button_ListaEmpleados_Buscar"
        Me.Button_ListaEmpleados_Buscar.Size = New System.Drawing.Size(98, 24)
        Me.Button_ListaEmpleados_Buscar.TabIndex = 9
        Me.Button_ListaEmpleados_Buscar.Text = "Buscar"
        Me.Button_ListaEmpleados_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_ListaEmpleados_TextAbuscar
        '
        Me.TextBox_ListaEmpleados_TextAbuscar.Location = New System.Drawing.Point(465, 22)
        Me.TextBox_ListaEmpleados_TextAbuscar.Name = "TextBox_ListaEmpleados_TextAbuscar"
        Me.TextBox_ListaEmpleados_TextAbuscar.Size = New System.Drawing.Size(423, 23)
        Me.TextBox_ListaEmpleados_TextAbuscar.TabIndex = 8
        '
        'Button_ListaEmpleados_Desactivar
        '
        Me.Button_ListaEmpleados_Desactivar.Location = New System.Drawing.Point(372, 394)
        Me.Button_ListaEmpleados_Desactivar.Name = "Button_ListaEmpleados_Desactivar"
        Me.Button_ListaEmpleados_Desactivar.Size = New System.Drawing.Size(92, 23)
        Me.Button_ListaEmpleados_Desactivar.TabIndex = 7
        Me.Button_ListaEmpleados_Desactivar.Text = "Desactivar"
        Me.Button_ListaEmpleados_Desactivar.UseVisualStyleBackColor = True
        Me.Button_ListaEmpleados_Desactivar.Visible = False
        '
        'Button_ListaEmpleados_Activar
        '
        Me.Button_ListaEmpleados_Activar.Location = New System.Drawing.Point(259, 394)
        Me.Button_ListaEmpleados_Activar.Name = "Button_ListaEmpleados_Activar"
        Me.Button_ListaEmpleados_Activar.Size = New System.Drawing.Size(75, 23)
        Me.Button_ListaEmpleados_Activar.TabIndex = 6
        Me.Button_ListaEmpleados_Activar.Text = "Activar"
        Me.Button_ListaEmpleados_Activar.UseVisualStyleBackColor = True
        Me.Button_ListaEmpleados_Activar.Visible = False
        '
        'Button_ListaEmpleados_Eliminar
        '
        Me.Button_ListaEmpleados_Eliminar.Location = New System.Drawing.Point(135, 394)
        Me.Button_ListaEmpleados_Eliminar.Name = "Button_ListaEmpleados_Eliminar"
        Me.Button_ListaEmpleados_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_ListaEmpleados_Eliminar.TabIndex = 5
        Me.Button_ListaEmpleados_Eliminar.Text = "Eliminar"
        Me.Button_ListaEmpleados_Eliminar.UseVisualStyleBackColor = True
        Me.Button_ListaEmpleados_Eliminar.Visible = False
        '
        'Seleccionar_Empleado
        '
        Me.Seleccionar_Empleado.AutoSize = True
        Me.Seleccionar_Empleado.Location = New System.Drawing.Point(10, 398)
        Me.Seleccionar_Empleado.Name = "Seleccionar_Empleado"
        Me.Seleccionar_Empleado.Size = New System.Drawing.Size(103, 19)
        Me.Seleccionar_Empleado.TabIndex = 4
        Me.Seleccionar_Empleado.Text = "Seleccionar"
        Me.Seleccionar_Empleado.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox_ListaEmpleados_IdDireccion)
        Me.TabPage2.Controls.Add(Me.Label_ListaEmpleados_IdDireccion)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label_ListaEmpleado_Empleados)
        Me.TabPage2.Controls.Add(Me.Label_ListaEmpleados_IdUsuario)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TextBox_ListaEmpleado_FechaUltimaMod)
        Me.TabPage2.Controls.Add(Me.TextBoxTextBox_ListaEmpleado_IDUsuario)
        Me.TabPage2.Controls.Add(Me.TextBox_ListaEmpleado_IDEmpleado)
        Me.TabPage2.Controls.Add(Me.Button_ListaEmpleado_Editar)
        Me.TabPage2.Controls.Add(Me.Button_ListaEmpleado_Cancelar)
        Me.TabPage2.Controls.Add(Me.Button_ListaEmpleado_Agregar)
        Me.TabPage2.Controls.Add(Me.GroupBox_ListaEmpleado_Usuarios)
        Me.TabPage2.Controls.Add(Me.GroupBox_ListaEmpleado_Direccion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1276, 522)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edicion Y agregar empleados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox_ListaEmpleados_IdDireccion
        '
        Me.TextBox_ListaEmpleados_IdDireccion.Location = New System.Drawing.Point(687, 24)
        Me.TextBox_ListaEmpleados_IdDireccion.Name = "TextBox_ListaEmpleados_IdDireccion"
        Me.TextBox_ListaEmpleados_IdDireccion.ReadOnly = True
        Me.TextBox_ListaEmpleados_IdDireccion.Size = New System.Drawing.Size(127, 23)
        Me.TextBox_ListaEmpleados_IdDireccion.TabIndex = 14
        '
        'Label_ListaEmpleados_IdDireccion
        '
        Me.Label_ListaEmpleados_IdDireccion.AutoSize = True
        Me.Label_ListaEmpleados_IdDireccion.Location = New System.Drawing.Point(580, 27)
        Me.Label_ListaEmpleados_IdDireccion.Name = "Label_ListaEmpleados_IdDireccion"
        Me.Label_ListaEmpleados_IdDireccion.Size = New System.Drawing.Size(98, 15)
        Me.Label_ListaEmpleados_IdDireccion.TabIndex = 13
        Me.Label_ListaEmpleados_IdDireccion.Text = "Id Direccion "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_ListaEmpleado_SucursalDondeTrabaja)
        Me.GroupBox2.Controls.Add(Me.Label_ListaEmpleado_Sucursal)
        Me.GroupBox2.Location = New System.Drawing.Point(603, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 170)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sucursal "
        '
        'ComboBox_ListaEmpleado_SucursalDondeTrabaja
        '
        Me.ComboBox_ListaEmpleado_SucursalDondeTrabaja.FormattingEnabled = True
        Me.ComboBox_ListaEmpleado_SucursalDondeTrabaja.Location = New System.Drawing.Point(196, 56)
        Me.ComboBox_ListaEmpleado_SucursalDondeTrabaja.Name = "ComboBox_ListaEmpleado_SucursalDondeTrabaja"
        Me.ComboBox_ListaEmpleado_SucursalDondeTrabaja.Size = New System.Drawing.Size(354, 23)
        Me.ComboBox_ListaEmpleado_SucursalDondeTrabaja.TabIndex = 1
        '
        'Label_ListaEmpleado_Sucursal
        '
        Me.Label_ListaEmpleado_Sucursal.AutoSize = True
        Me.Label_ListaEmpleado_Sucursal.Location = New System.Drawing.Point(26, 63)
        Me.Label_ListaEmpleado_Sucursal.Name = "Label_ListaEmpleado_Sucursal"
        Me.Label_ListaEmpleado_Sucursal.Size = New System.Drawing.Size(175, 15)
        Me.Label_ListaEmpleado_Sucursal.TabIndex = 0
        Me.Label_ListaEmpleado_Sucursal.Text = "Sucursal donde trabaja: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_ListaEmpleado_EmpleadoRFC)
        Me.GroupBox1.Controls.Add(Me.TextBox_ListaEmpleado_EmpleadoNomUsuario)
        Me.GroupBox1.Controls.Add(Me.CheckBox_ListaEmpleados_EsAdministrador)
        Me.GroupBox1.Controls.Add(Me.Label_ListaEmpleados_RFC)
        Me.GroupBox1.Controls.Add(Me.Label_ListaEmpleados_NombreUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 171)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Empleado"
        '
        'TextBox_ListaEmpleado_EmpleadoRFC
        '
        Me.TextBox_ListaEmpleado_EmpleadoRFC.Location = New System.Drawing.Point(54, 95)
        Me.TextBox_ListaEmpleado_EmpleadoRFC.Name = "TextBox_ListaEmpleado_EmpleadoRFC"
        Me.TextBox_ListaEmpleado_EmpleadoRFC.Size = New System.Drawing.Size(261, 23)
        Me.TextBox_ListaEmpleado_EmpleadoRFC.TabIndex = 5
        '
        'TextBox_ListaEmpleado_EmpleadoNomUsuario
        '
        Me.TextBox_ListaEmpleado_EmpleadoNomUsuario.Location = New System.Drawing.Point(132, 33)
        Me.TextBox_ListaEmpleado_EmpleadoNomUsuario.Name = "TextBox_ListaEmpleado_EmpleadoNomUsuario"
        Me.TextBox_ListaEmpleado_EmpleadoNomUsuario.Size = New System.Drawing.Size(183, 23)
        Me.TextBox_ListaEmpleado_EmpleadoNomUsuario.TabIndex = 4
        '
        'CheckBox_ListaEmpleados_EsAdministrador
        '
        Me.CheckBox_ListaEmpleados_EsAdministrador.AutoSize = True
        Me.CheckBox_ListaEmpleados_EsAdministrador.Location = New System.Drawing.Point(362, 63)
        Me.CheckBox_ListaEmpleados_EsAdministrador.Name = "CheckBox_ListaEmpleados_EsAdministrador"
        Me.CheckBox_ListaEmpleados_EsAdministrador.Size = New System.Drawing.Size(145, 19)
        Me.CheckBox_ListaEmpleados_EsAdministrador.TabIndex = 3
        Me.CheckBox_ListaEmpleados_EsAdministrador.Text = "Es administrador?"
        Me.CheckBox_ListaEmpleados_EsAdministrador.UseVisualStyleBackColor = True
        '
        'Label_ListaEmpleados_RFC
        '
        Me.Label_ListaEmpleados_RFC.AutoSize = True
        Me.Label_ListaEmpleados_RFC.Location = New System.Drawing.Point(6, 95)
        Me.Label_ListaEmpleados_RFC.Name = "Label_ListaEmpleados_RFC"
        Me.Label_ListaEmpleados_RFC.Size = New System.Drawing.Size(42, 15)
        Me.Label_ListaEmpleados_RFC.TabIndex = 1
        Me.Label_ListaEmpleados_RFC.Text = "RFC: "
        '
        'Label_ListaEmpleados_NombreUsuario
        '
        Me.Label_ListaEmpleados_NombreUsuario.AutoSize = True
        Me.Label_ListaEmpleados_NombreUsuario.Location = New System.Drawing.Point(6, 35)
        Me.Label_ListaEmpleados_NombreUsuario.Name = "Label_ListaEmpleados_NombreUsuario"
        Me.Label_ListaEmpleados_NombreUsuario.Size = New System.Drawing.Size(119, 15)
        Me.Label_ListaEmpleados_NombreUsuario.TabIndex = 0
        Me.Label_ListaEmpleados_NombreUsuario.Text = "Nombre usuario: "
        '
        'Label_ListaEmpleado_Empleados
        '
        Me.Label_ListaEmpleado_Empleados.AutoSize = True
        Me.Label_ListaEmpleado_Empleados.Location = New System.Drawing.Point(83, 27)
        Me.Label_ListaEmpleado_Empleados.Name = "Label_ListaEmpleado_Empleados"
        Me.Label_ListaEmpleado_Empleados.Size = New System.Drawing.Size(91, 15)
        Me.Label_ListaEmpleado_Empleados.TabIndex = 10
        Me.Label_ListaEmpleado_Empleados.Text = "Id empleados"
        '
        'Label_ListaEmpleados_IdUsuario
        '
        Me.Label_ListaEmpleados_IdUsuario.AutoSize = True
        Me.Label_ListaEmpleados_IdUsuario.Location = New System.Drawing.Point(335, 27)
        Me.Label_ListaEmpleados_IdUsuario.Name = "Label_ListaEmpleados_IdUsuario"
        Me.Label_ListaEmpleados_IdUsuario.Size = New System.Drawing.Size(77, 15)
        Me.Label_ListaEmpleados_IdUsuario.TabIndex = 9
        Me.Label_ListaEmpleados_IdUsuario.Text = "Id usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(820, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "fecha ultima modificacion"
        '
        'TextBox_ListaEmpleado_FechaUltimaMod
        '
        Me.TextBox_ListaEmpleado_FechaUltimaMod.Location = New System.Drawing.Point(1008, 24)
        Me.TextBox_ListaEmpleado_FechaUltimaMod.Name = "TextBox_ListaEmpleado_FechaUltimaMod"
        Me.TextBox_ListaEmpleado_FechaUltimaMod.ReadOnly = True
        Me.TextBox_ListaEmpleado_FechaUltimaMod.Size = New System.Drawing.Size(145, 23)
        Me.TextBox_ListaEmpleado_FechaUltimaMod.TabIndex = 7
        '
        'TextBoxTextBox_ListaEmpleado_IDUsuario
        '
        Me.TextBoxTextBox_ListaEmpleado_IDUsuario.Location = New System.Drawing.Point(418, 24)
        Me.TextBoxTextBox_ListaEmpleado_IDUsuario.Name = "TextBoxTextBox_ListaEmpleado_IDUsuario"
        Me.TextBoxTextBox_ListaEmpleado_IDUsuario.ReadOnly = True
        Me.TextBoxTextBox_ListaEmpleado_IDUsuario.Size = New System.Drawing.Size(145, 23)
        Me.TextBoxTextBox_ListaEmpleado_IDUsuario.TabIndex = 6
        '
        'TextBox_ListaEmpleado_IDEmpleado
        '
        Me.TextBox_ListaEmpleado_IDEmpleado.Location = New System.Drawing.Point(180, 24)
        Me.TextBox_ListaEmpleado_IDEmpleado.Name = "TextBox_ListaEmpleado_IDEmpleado"
        Me.TextBox_ListaEmpleado_IDEmpleado.ReadOnly = True
        Me.TextBox_ListaEmpleado_IDEmpleado.Size = New System.Drawing.Size(145, 23)
        Me.TextBox_ListaEmpleado_IDEmpleado.TabIndex = 5
        '
        'Button_ListaEmpleado_Editar
        '
        Me.Button_ListaEmpleado_Editar.Location = New System.Drawing.Point(376, 457)
        Me.Button_ListaEmpleado_Editar.Name = "Button_ListaEmpleado_Editar"
        Me.Button_ListaEmpleado_Editar.Size = New System.Drawing.Size(98, 45)
        Me.Button_ListaEmpleado_Editar.TabIndex = 4
        Me.Button_ListaEmpleado_Editar.Text = "Editar"
        Me.Button_ListaEmpleado_Editar.UseVisualStyleBackColor = True
        '
        'Button_ListaEmpleado_Cancelar
        '
        Me.Button_ListaEmpleado_Cancelar.Location = New System.Drawing.Point(596, 456)
        Me.Button_ListaEmpleado_Cancelar.Name = "Button_ListaEmpleado_Cancelar"
        Me.Button_ListaEmpleado_Cancelar.Size = New System.Drawing.Size(98, 45)
        Me.Button_ListaEmpleado_Cancelar.TabIndex = 3
        Me.Button_ListaEmpleado_Cancelar.Text = "Cancelar"
        Me.Button_ListaEmpleado_Cancelar.UseVisualStyleBackColor = True
        '
        'Button_ListaEmpleado_Agregar
        '
        Me.Button_ListaEmpleado_Agregar.Location = New System.Drawing.Point(480, 457)
        Me.Button_ListaEmpleado_Agregar.Name = "Button_ListaEmpleado_Agregar"
        Me.Button_ListaEmpleado_Agregar.Size = New System.Drawing.Size(98, 45)
        Me.Button_ListaEmpleado_Agregar.TabIndex = 2
        Me.Button_ListaEmpleado_Agregar.Text = "Agregar"
        Me.Button_ListaEmpleado_Agregar.UseVisualStyleBackColor = True
        '
        'GroupBox_ListaEmpleado_Usuarios
        '
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.TextBox_ListaEmpleado_UsuarioContrasena)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.TextBox_ListaEmpleado_UsuarioCURP)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.TextBox_ListaEmpleado_usuarioApellidoMaterno)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.TextBox_ListaEmpleado_usuarioApellidoPaterno)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.TextBox_ListaEmpleado_UsuarioNombre)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.Label_ListaEmpleados_UsuarioCURP)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.DateTimePicker1_ListaEmpleados_)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.Label_ListaEmpleados_FechaNacimiento)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.Label_ListaEmpleados_Contrasena)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.Label_ListaEmpleados_ApellidoMaterno)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.Label_ListaEmpleados_ApellidoPaterno)
        Me.GroupBox_ListaEmpleado_Usuarios.Controls.Add(Me.Label_ListaEmpleados_Nombre)
        Me.GroupBox_ListaEmpleado_Usuarios.Location = New System.Drawing.Point(603, 63)
        Me.GroupBox_ListaEmpleado_Usuarios.Name = "GroupBox_ListaEmpleado_Usuarios"
        Me.GroupBox_ListaEmpleado_Usuarios.Size = New System.Drawing.Size(599, 211)
        Me.GroupBox_ListaEmpleado_Usuarios.TabIndex = 1
        Me.GroupBox_ListaEmpleado_Usuarios.TabStop = False
        Me.GroupBox_ListaEmpleado_Usuarios.Text = "Datos de Usuario"
        '
        'TextBox_ListaEmpleado_UsuarioContrasena
        '
        Me.TextBox_ListaEmpleado_UsuarioContrasena.Location = New System.Drawing.Point(385, 85)
        Me.TextBox_ListaEmpleado_UsuarioContrasena.Name = "TextBox_ListaEmpleado_UsuarioContrasena"
        Me.TextBox_ListaEmpleado_UsuarioContrasena.Size = New System.Drawing.Size(145, 23)
        Me.TextBox_ListaEmpleado_UsuarioContrasena.TabIndex = 12
        '
        'TextBox_ListaEmpleado_UsuarioCURP
        '
        Me.TextBox_ListaEmpleado_UsuarioCURP.Location = New System.Drawing.Point(344, 46)
        Me.TextBox_ListaEmpleado_UsuarioCURP.Name = "TextBox_ListaEmpleado_UsuarioCURP"
        Me.TextBox_ListaEmpleado_UsuarioCURP.Size = New System.Drawing.Size(186, 23)
        Me.TextBox_ListaEmpleado_UsuarioCURP.TabIndex = 11
        '
        'TextBox_ListaEmpleado_usuarioApellidoMaterno
        '
        Me.TextBox_ListaEmpleado_usuarioApellidoMaterno.Location = New System.Drawing.Point(137, 121)
        Me.TextBox_ListaEmpleado_usuarioApellidoMaterno.Name = "TextBox_ListaEmpleado_usuarioApellidoMaterno"
        Me.TextBox_ListaEmpleado_usuarioApellidoMaterno.Size = New System.Drawing.Size(159, 23)
        Me.TextBox_ListaEmpleado_usuarioApellidoMaterno.TabIndex = 10
        '
        'TextBox_ListaEmpleado_usuarioApellidoPaterno
        '
        Me.TextBox_ListaEmpleado_usuarioApellidoPaterno.Location = New System.Drawing.Point(137, 82)
        Me.TextBox_ListaEmpleado_usuarioApellidoPaterno.Name = "TextBox_ListaEmpleado_usuarioApellidoPaterno"
        Me.TextBox_ListaEmpleado_usuarioApellidoPaterno.Size = New System.Drawing.Size(159, 23)
        Me.TextBox_ListaEmpleado_usuarioApellidoPaterno.TabIndex = 9
        '
        'TextBox_ListaEmpleado_UsuarioNombre
        '
        Me.TextBox_ListaEmpleado_UsuarioNombre.Location = New System.Drawing.Point(72, 46)
        Me.TextBox_ListaEmpleado_UsuarioNombre.Name = "TextBox_ListaEmpleado_UsuarioNombre"
        Me.TextBox_ListaEmpleado_UsuarioNombre.Size = New System.Drawing.Size(224, 23)
        Me.TextBox_ListaEmpleado_UsuarioNombre.TabIndex = 8
        '
        'Label_ListaEmpleados_UsuarioCURP
        '
        Me.Label_ListaEmpleados_UsuarioCURP.AutoSize = True
        Me.Label_ListaEmpleados_UsuarioCURP.Location = New System.Drawing.Point(302, 49)
        Me.Label_ListaEmpleados_UsuarioCURP.Name = "Label_ListaEmpleados_UsuarioCURP"
        Me.Label_ListaEmpleados_UsuarioCURP.Size = New System.Drawing.Size(49, 15)
        Me.Label_ListaEmpleados_UsuarioCURP.TabIndex = 7
        Me.Label_ListaEmpleados_UsuarioCURP.Text = "CURP: "
        '
        'DateTimePicker1_ListaEmpleados_
        '
        Me.DateTimePicker1_ListaEmpleados_.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1_ListaEmpleados_.Location = New System.Drawing.Point(97, 171)
        Me.DateTimePicker1_ListaEmpleados_.Name = "DateTimePicker1_ListaEmpleados_"
        Me.DateTimePicker1_ListaEmpleados_.Size = New System.Drawing.Size(199, 23)
        Me.DateTimePicker1_ListaEmpleados_.TabIndex = 6
        Me.DateTimePicker1_ListaEmpleados_.Value = New Date(2021, 11, 18, 0, 0, 0, 0)
        '
        'Label_ListaEmpleados_FechaNacimiento
        '
        Me.Label_ListaEmpleados_FechaNacimiento.AutoSize = True
        Me.Label_ListaEmpleados_FechaNacimiento.Location = New System.Drawing.Point(7, 164)
        Me.Label_ListaEmpleados_FechaNacimiento.Name = "Label_ListaEmpleados_FechaNacimiento"
        Me.Label_ListaEmpleados_FechaNacimiento.Size = New System.Drawing.Size(84, 30)
        Me.Label_ListaEmpleados_FechaNacimiento.TabIndex = 5
        Me.Label_ListaEmpleados_FechaNacimiento.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        '
        'Label_ListaEmpleados_Contrasena
        '
        Me.Label_ListaEmpleados_Contrasena.AutoSize = True
        Me.Label_ListaEmpleados_Contrasena.Location = New System.Drawing.Point(302, 88)
        Me.Label_ListaEmpleados_Contrasena.Name = "Label_ListaEmpleados_Contrasena"
        Me.Label_ListaEmpleados_Contrasena.Size = New System.Drawing.Size(91, 15)
        Me.Label_ListaEmpleados_Contrasena.TabIndex = 4
        Me.Label_ListaEmpleados_Contrasena.Text = "Contraseña: "
        '
        'Label_ListaEmpleados_ApellidoMaterno
        '
        Me.Label_ListaEmpleados_ApellidoMaterno.AutoSize = True
        Me.Label_ListaEmpleados_ApellidoMaterno.Location = New System.Drawing.Point(7, 129)
        Me.Label_ListaEmpleados_ApellidoMaterno.Name = "Label_ListaEmpleados_ApellidoMaterno"
        Me.Label_ListaEmpleados_ApellidoMaterno.Size = New System.Drawing.Size(133, 15)
        Me.Label_ListaEmpleados_ApellidoMaterno.TabIndex = 3
        Me.Label_ListaEmpleados_ApellidoMaterno.Text = "Apellido Materno: "
        '
        'Label_ListaEmpleados_ApellidoPaterno
        '
        Me.Label_ListaEmpleados_ApellidoPaterno.AutoSize = True
        Me.Label_ListaEmpleados_ApellidoPaterno.Location = New System.Drawing.Point(7, 88)
        Me.Label_ListaEmpleados_ApellidoPaterno.Name = "Label_ListaEmpleados_ApellidoPaterno"
        Me.Label_ListaEmpleados_ApellidoPaterno.Size = New System.Drawing.Size(133, 15)
        Me.Label_ListaEmpleados_ApellidoPaterno.TabIndex = 2
        Me.Label_ListaEmpleados_ApellidoPaterno.Text = "Apellido paterno: "
        '
        'Label_ListaEmpleados_Nombre
        '
        Me.Label_ListaEmpleados_Nombre.AutoSize = True
        Me.Label_ListaEmpleados_Nombre.Location = New System.Drawing.Point(3, 49)
        Me.Label_ListaEmpleados_Nombre.Name = "Label_ListaEmpleados_Nombre"
        Me.Label_ListaEmpleados_Nombre.Size = New System.Drawing.Size(63, 15)
        Me.Label_ListaEmpleados_Nombre.TabIndex = 1
        Me.Label_ListaEmpleados_Nombre.Text = "Nombre: "
        '
        'GroupBox_ListaEmpleado_Direccion
        '
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.TextBox_ListaEmpleado_NumDomicilio)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.TextBox_ListaEmpleado_DireccionCalle)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.TextBox_ListaEmpleado_DireccionCodigoPostal)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.TextBox_ListaEmpleado_DireccionColonia)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.Label_ListaEmpleados_NumeroDomicilio)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.Label_ListaEmpleados_Calle)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.Label_ListaEmpleados_CodigoPostal)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.Label_ListaEmpleados_Colonia)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.TextBox_ListaEmpleado_DireccionMunicipio)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.Label_ListaEmpleados_Municipio)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.TextBox_ListaEmpleado_DireccionEstado)
        Me.GroupBox_ListaEmpleado_Direccion.Controls.Add(Me.Label_ListaEmpleados_Estado)
        Me.GroupBox_ListaEmpleado_Direccion.Location = New System.Drawing.Point(32, 63)
        Me.GroupBox_ListaEmpleado_Direccion.Name = "GroupBox_ListaEmpleado_Direccion"
        Me.GroupBox_ListaEmpleado_Direccion.Size = New System.Drawing.Size(546, 211)
        Me.GroupBox_ListaEmpleado_Direccion.TabIndex = 0
        Me.GroupBox_ListaEmpleado_Direccion.TabStop = False
        Me.GroupBox_ListaEmpleado_Direccion.Text = "Direccion"
        '
        'TextBox_ListaEmpleado_NumDomicilio
        '
        Me.TextBox_ListaEmpleado_NumDomicilio.Location = New System.Drawing.Point(353, 82)
        Me.TextBox_ListaEmpleado_NumDomicilio.Name = "TextBox_ListaEmpleado_NumDomicilio"
        Me.TextBox_ListaEmpleado_NumDomicilio.Size = New System.Drawing.Size(178, 23)
        Me.TextBox_ListaEmpleado_NumDomicilio.TabIndex = 11
        '
        'TextBox_ListaEmpleado_DireccionCalle
        '
        Me.TextBox_ListaEmpleado_DireccionCalle.Location = New System.Drawing.Point(322, 46)
        Me.TextBox_ListaEmpleado_DireccionCalle.Name = "TextBox_ListaEmpleado_DireccionCalle"
        Me.TextBox_ListaEmpleado_DireccionCalle.Size = New System.Drawing.Size(209, 23)
        Me.TextBox_ListaEmpleado_DireccionCalle.TabIndex = 10
        '
        'TextBox_ListaEmpleado_DireccionCodigoPostal
        '
        Me.TextBox_ListaEmpleado_DireccionCodigoPostal.Location = New System.Drawing.Point(113, 161)
        Me.TextBox_ListaEmpleado_DireccionCodigoPostal.Name = "TextBox_ListaEmpleado_DireccionCodigoPostal"
        Me.TextBox_ListaEmpleado_DireccionCodigoPostal.Size = New System.Drawing.Size(154, 23)
        Me.TextBox_ListaEmpleado_DireccionCodigoPostal.TabIndex = 9
        '
        'TextBox_ListaEmpleado_DireccionColonia
        '
        Me.TextBox_ListaEmpleado_DireccionColonia.Location = New System.Drawing.Point(85, 121)
        Me.TextBox_ListaEmpleado_DireccionColonia.Name = "TextBox_ListaEmpleado_DireccionColonia"
        Me.TextBox_ListaEmpleado_DireccionColonia.Size = New System.Drawing.Size(182, 23)
        Me.TextBox_ListaEmpleado_DireccionColonia.TabIndex = 8
        '
        'Label_ListaEmpleados_NumeroDomicilio
        '
        Me.Label_ListaEmpleados_NumeroDomicilio.AutoSize = True
        Me.Label_ListaEmpleados_NumeroDomicilio.Location = New System.Drawing.Point(272, 75)
        Me.Label_ListaEmpleados_NumeroDomicilio.Name = "Label_ListaEmpleados_NumeroDomicilio"
        Me.Label_ListaEmpleados_NumeroDomicilio.Size = New System.Drawing.Size(84, 30)
        Me.Label_ListaEmpleados_NumeroDomicilio.TabIndex = 7
        Me.Label_ListaEmpleados_NumeroDomicilio.Text = "Numero " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "domicilio: "
        '
        'Label_ListaEmpleados_Calle
        '
        Me.Label_ListaEmpleados_Calle.AutoSize = True
        Me.Label_ListaEmpleados_Calle.Location = New System.Drawing.Point(272, 46)
        Me.Label_ListaEmpleados_Calle.Name = "Label_ListaEmpleados_Calle"
        Me.Label_ListaEmpleados_Calle.Size = New System.Drawing.Size(56, 15)
        Me.Label_ListaEmpleados_Calle.TabIndex = 6
        Me.Label_ListaEmpleados_Calle.Text = "Calle: "
        '
        'Label_ListaEmpleados_CodigoPostal
        '
        Me.Label_ListaEmpleados_CodigoPostal.AutoSize = True
        Me.Label_ListaEmpleados_CodigoPostal.Location = New System.Drawing.Point(6, 164)
        Me.Label_ListaEmpleados_CodigoPostal.Name = "Label_ListaEmpleados_CodigoPostal"
        Me.Label_ListaEmpleados_CodigoPostal.Size = New System.Drawing.Size(112, 15)
        Me.Label_ListaEmpleados_CodigoPostal.TabIndex = 5
        Me.Label_ListaEmpleados_CodigoPostal.Text = "codigo Postal: "
        '
        'Label_ListaEmpleados_Colonia
        '
        Me.Label_ListaEmpleados_Colonia.AutoSize = True
        Me.Label_ListaEmpleados_Colonia.Location = New System.Drawing.Point(6, 129)
        Me.Label_ListaEmpleados_Colonia.Name = "Label_ListaEmpleados_Colonia"
        Me.Label_ListaEmpleados_Colonia.Size = New System.Drawing.Size(70, 15)
        Me.Label_ListaEmpleados_Colonia.TabIndex = 4
        Me.Label_ListaEmpleados_Colonia.Text = "Colonia: "
        '
        'TextBox_ListaEmpleado_DireccionMunicipio
        '
        Me.TextBox_ListaEmpleado_DireccionMunicipio.Location = New System.Drawing.Point(84, 82)
        Me.TextBox_ListaEmpleado_DireccionMunicipio.Name = "TextBox_ListaEmpleado_DireccionMunicipio"
        Me.TextBox_ListaEmpleado_DireccionMunicipio.Size = New System.Drawing.Size(182, 23)
        Me.TextBox_ListaEmpleado_DireccionMunicipio.TabIndex = 3
        '
        'Label_ListaEmpleados_Municipio
        '
        Me.Label_ListaEmpleados_Municipio.AutoSize = True
        Me.Label_ListaEmpleados_Municipio.Location = New System.Drawing.Point(6, 85)
        Me.Label_ListaEmpleados_Municipio.Name = "Label_ListaEmpleados_Municipio"
        Me.Label_ListaEmpleados_Municipio.Size = New System.Drawing.Size(84, 15)
        Me.Label_ListaEmpleados_Municipio.TabIndex = 2
        Me.Label_ListaEmpleados_Municipio.Text = "Municipio: "
        '
        'TextBox_ListaEmpleado_DireccionEstado
        '
        Me.TextBox_ListaEmpleado_DireccionEstado.Location = New System.Drawing.Point(84, 43)
        Me.TextBox_ListaEmpleado_DireccionEstado.Name = "TextBox_ListaEmpleado_DireccionEstado"
        Me.TextBox_ListaEmpleado_DireccionEstado.Size = New System.Drawing.Size(182, 23)
        Me.TextBox_ListaEmpleado_DireccionEstado.TabIndex = 1
        '
        'Label_ListaEmpleados_Estado
        '
        Me.Label_ListaEmpleados_Estado.AutoSize = True
        Me.Label_ListaEmpleados_Estado.Location = New System.Drawing.Point(6, 46)
        Me.Label_ListaEmpleados_Estado.Name = "Label_ListaEmpleados_Estado"
        Me.Label_ListaEmpleados_Estado.Size = New System.Drawing.Size(63, 15)
        Me.Label_ListaEmpleados_Estado.TabIndex = 0
        Me.Label_ListaEmpleados_Estado.Text = "Estado: "
        '
        'FORM_LISTA_EMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1308, 590)
        Me.Controls.Add(Me.TabControl_ListaEmpleados)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_LISTA_EMPLEADO"
        Me.Text = "LISTA EMPLEADO"
        CType(Me.DataGridView_ListaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_ListaEmpleados.ResumeLayout(False)
        Me.ListaEmpleados.ResumeLayout(False)
        Me.ListaEmpleados.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox_ListaEmpleado_Usuarios.ResumeLayout(False)
        Me.GroupBox_ListaEmpleado_Usuarios.PerformLayout()
        Me.GroupBox_ListaEmpleado_Direccion.ResumeLayout(False)
        Me.GroupBox_ListaEmpleado_Direccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_LISTEMPLEADOS_IMPRIMIR As Button
    Friend WithEvents DataGridView_ListaEmpleados As DataGridView
    Friend WithEvents TabControl_ListaEmpleados As TabControl
    Friend WithEvents ListaEmpleados As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button_ListaEmpleados_Desactivar As Button
    Friend WithEvents Button_ListaEmpleados_Activar As Button
    Friend WithEvents Button_ListaEmpleados_Eliminar As Button
    Friend WithEvents Seleccionar_Empleado As CheckBox
    Friend WithEvents SeleccionarEmpleado As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox_ListaEmpleado_Direccion As GroupBox
    Friend WithEvents Button_ListaEmpleado_Editar As Button
    Friend WithEvents Button_ListaEmpleado_Cancelar As Button
    Friend WithEvents Button_ListaEmpleado_Agregar As Button
    Friend WithEvents GroupBox_ListaEmpleado_Usuarios As GroupBox
    Friend WithEvents TextBox_ListaEmpleado_DireccionEstado As TextBox
    Friend WithEvents Label_ListaEmpleados_Estado As Label
    Friend WithEvents Label_ListaEmpleados_Municipio As Label
    Friend WithEvents Label_ListaEmpleado_Empleados As Label
    Friend WithEvents Label_ListaEmpleados_IdUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ListaEmpleado_FechaUltimaMod As TextBox
    Friend WithEvents TextBoxTextBox_ListaEmpleado_IDUsuario As TextBox
    Friend WithEvents TextBox_ListaEmpleado_IDEmpleado As TextBox
    Friend WithEvents TextBox_ListaEmpleado_usuarioApellidoMaterno As TextBox
    Friend WithEvents TextBox_ListaEmpleado_usuarioApellidoPaterno As TextBox
    Friend WithEvents TextBox_ListaEmpleado_UsuarioNombre As TextBox
    Friend WithEvents Label_ListaEmpleados_UsuarioCURP As Label
    Friend WithEvents DateTimePicker1_ListaEmpleados_ As DateTimePicker
    Friend WithEvents Label_ListaEmpleados_FechaNacimiento As Label
    Friend WithEvents Label_ListaEmpleados_Contrasena As Label
    Friend WithEvents Label_ListaEmpleados_ApellidoMaterno As Label
    Friend WithEvents Label_ListaEmpleados_ApellidoPaterno As Label
    Friend WithEvents Label_ListaEmpleados_Nombre As Label
    Friend WithEvents TextBox_ListaEmpleado_NumDomicilio As TextBox
    Friend WithEvents TextBox_ListaEmpleado_DireccionCalle As TextBox
    Friend WithEvents TextBox_ListaEmpleado_DireccionCodigoPostal As TextBox
    Friend WithEvents TextBox_ListaEmpleado_DireccionColonia As TextBox
    Friend WithEvents Label_ListaEmpleados_NumeroDomicilio As Label
    Friend WithEvents Label_ListaEmpleados_Calle As Label
    Friend WithEvents Label_ListaEmpleados_CodigoPostal As Label
    Friend WithEvents Label_ListaEmpleados_Colonia As Label
    Friend WithEvents TextBox_ListaEmpleado_DireccionMunicipio As TextBox
    Friend WithEvents TextBox_ListaEmpleado_UsuarioContrasena As TextBox
    Friend WithEvents TextBox_ListaEmpleado_UsuarioCURP As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_ListaEmpleado_SucursalDondeTrabaja As ComboBox
    Friend WithEvents Label_ListaEmpleado_Sucursal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_ListaEmpleado_EmpleadoRFC As TextBox
    Friend WithEvents TextBox_ListaEmpleado_EmpleadoNomUsuario As TextBox
    Friend WithEvents CheckBox_ListaEmpleados_EsAdministrador As CheckBox
    Friend WithEvents Label_ListaEmpleados_RFC As Label
    Friend WithEvents Label_ListaEmpleados_NombreUsuario As Label
    Friend WithEvents TextBox_ListaEmpleados_IdDireccion As TextBox
    Friend WithEvents Label_ListaEmpleados_IdDireccion As Label
    Friend WithEvents Button_ListaEmpleados_Buscar As Button
    Friend WithEvents TextBox_ListaEmpleados_TextAbuscar As TextBox
End Class
