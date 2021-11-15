<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_SUCURSAL
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTN_ListaSucursal_ACEPTAR = New System.Windows.Forms.Button()
        Me.TXT_ListaSucursal_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_SUC_NUM = New System.Windows.Forms.TextBox()
        Me.TXT_ListaSucursal_COLONIA = New System.Windows.Forms.TextBox()
        Me.TXT_ListaSucursal_CALLE = New System.Windows.Forms.TextBox()
        Me.TXT_ListaSucursal_NUMERO = New System.Windows.Forms.TextBox()
        Me.TXT_ListaSucursal_CODPOS = New System.Windows.Forms.TextBox()
        Me.DataGridView_ListaSucursal = New System.Windows.Forms.DataGridView()
        Me.SeleccionarSucursal = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControl_ListaSucursales = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_ListaSucursales_CargaMasiva = New System.Windows.Forms.Button()
        Me.Button_ListaEmpleados_Desactivar = New System.Windows.Forms.Button()
        Me.Button_ListaEmpleados_Activar = New System.Windows.Forms.Button()
        Me.Button_ListaSucursal_Eliminar = New System.Windows.Forms.Button()
        Me.Seleccionar_ListaSucursal_Empleado = New System.Windows.Forms.CheckBox()
        Me.BTN_LISTEMPLEADOS_IMPRIMIR = New System.Windows.Forms.Button()
        Me.Button_ListaSucursal_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_ListaSucursal_TextAbuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BTN_ListaSucursal_Cancelar = New System.Windows.Forms.Button()
        Me.BTN_ListaSucursal_Editar = New System.Windows.Forms.Button()
        Me.Label_ListaSucursal_Fecha = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox_ListaSucursal_DirecccionMunicipio = New System.Windows.Forms.TextBox()
        Me.TextBox_ListaSucursal_DireccionEstado = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_ListaSucursal_Encargado = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView_ListaSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_ListaSucursales.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero Sucursal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Creacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Encargado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DIRRECION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Colonia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Calle:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Municipio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(219, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Codigo Postal:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Numero:"
        '
        'BTN_ListaSucursal_ACEPTAR
        '
        Me.BTN_ListaSucursal_ACEPTAR.Location = New System.Drawing.Point(381, 424)
        Me.BTN_ListaSucursal_ACEPTAR.Name = "BTN_ListaSucursal_ACEPTAR"
        Me.BTN_ListaSucursal_ACEPTAR.Size = New System.Drawing.Size(116, 53)
        Me.BTN_ListaSucursal_ACEPTAR.TabIndex = 11
        Me.BTN_ListaSucursal_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ListaSucursal_ACEPTAR.UseVisualStyleBackColor = True
        '
        'TXT_ListaSucursal_NOMBRE
        '
        Me.TXT_ListaSucursal_NOMBRE.Location = New System.Drawing.Point(78, 83)
        Me.TXT_ListaSucursal_NOMBRE.Name = "TXT_ListaSucursal_NOMBRE"
        Me.TXT_ListaSucursal_NOMBRE.Size = New System.Drawing.Size(346, 23)
        Me.TXT_ListaSucursal_NOMBRE.TabIndex = 14
        '
        'TXT_SUC_NUM
        '
        Me.TXT_SUC_NUM.Location = New System.Drawing.Point(135, 34)
        Me.TXT_SUC_NUM.Name = "TXT_SUC_NUM"
        Me.TXT_SUC_NUM.ReadOnly = True
        Me.TXT_SUC_NUM.Size = New System.Drawing.Size(289, 23)
        Me.TXT_SUC_NUM.TabIndex = 15
        '
        'TXT_ListaSucursal_COLONIA
        '
        Me.TXT_ListaSucursal_COLONIA.Location = New System.Drawing.Point(71, 135)
        Me.TXT_ListaSucursal_COLONIA.Name = "TXT_ListaSucursal_COLONIA"
        Me.TXT_ListaSucursal_COLONIA.Size = New System.Drawing.Size(415, 23)
        Me.TXT_ListaSucursal_COLONIA.TabIndex = 18
        '
        'TXT_ListaSucursal_CALLE
        '
        Me.TXT_ListaSucursal_CALLE.Location = New System.Drawing.Point(71, 176)
        Me.TXT_ListaSucursal_CALLE.Name = "TXT_ListaSucursal_CALLE"
        Me.TXT_ListaSucursal_CALLE.Size = New System.Drawing.Size(415, 23)
        Me.TXT_ListaSucursal_CALLE.TabIndex = 20
        '
        'TXT_ListaSucursal_NUMERO
        '
        Me.TXT_ListaSucursal_NUMERO.Location = New System.Drawing.Point(71, 216)
        Me.TXT_ListaSucursal_NUMERO.Name = "TXT_ListaSucursal_NUMERO"
        Me.TXT_ListaSucursal_NUMERO.Size = New System.Drawing.Size(142, 23)
        Me.TXT_ListaSucursal_NUMERO.TabIndex = 21
        '
        'TXT_ListaSucursal_CODPOS
        '
        Me.TXT_ListaSucursal_CODPOS.Location = New System.Drawing.Point(330, 219)
        Me.TXT_ListaSucursal_CODPOS.Name = "TXT_ListaSucursal_CODPOS"
        Me.TXT_ListaSucursal_CODPOS.Size = New System.Drawing.Size(143, 23)
        Me.TXT_ListaSucursal_CODPOS.TabIndex = 22
        '
        'DataGridView_ListaSucursal
        '
        Me.DataGridView_ListaSucursal.AllowUserToAddRows = False
        Me.DataGridView_ListaSucursal.AllowUserToDeleteRows = False
        Me.DataGridView_ListaSucursal.AllowUserToOrderColumns = True
        Me.DataGridView_ListaSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ListaSucursal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeleccionarSucursal})
        Me.DataGridView_ListaSucursal.Location = New System.Drawing.Point(16, 70)
        Me.DataGridView_ListaSucursal.Name = "DataGridView_ListaSucursal"
        Me.DataGridView_ListaSucursal.ReadOnly = True
        Me.DataGridView_ListaSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_ListaSucursal.Size = New System.Drawing.Size(1014, 362)
        Me.DataGridView_ListaSucursal.TabIndex = 24
        '
        'SeleccionarSucursal
        '
        Me.SeleccionarSucursal.HeaderText = "Seleccionar"
        Me.SeleccionarSucursal.Name = "SeleccionarSucursal"
        Me.SeleccionarSucursal.ReadOnly = True
        '
        'TabControl_ListaSucursales
        '
        Me.TabControl_ListaSucursales.Controls.Add(Me.TabPage1)
        Me.TabControl_ListaSucursales.Controls.Add(Me.TabPage2)
        Me.TabControl_ListaSucursales.Location = New System.Drawing.Point(12, 12)
        Me.TabControl_ListaSucursales.Name = "TabControl_ListaSucursales"
        Me.TabControl_ListaSucursales.SelectedIndex = 0
        Me.TabControl_ListaSucursales.Size = New System.Drawing.Size(1070, 556)
        Me.TabControl_ListaSucursales.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button_ListaSucursales_CargaMasiva)
        Me.TabPage1.Controls.Add(Me.Button_ListaEmpleados_Desactivar)
        Me.TabPage1.Controls.Add(Me.Button_ListaEmpleados_Activar)
        Me.TabPage1.Controls.Add(Me.Button_ListaSucursal_Eliminar)
        Me.TabPage1.Controls.Add(Me.Seleccionar_ListaSucursal_Empleado)
        Me.TabPage1.Controls.Add(Me.BTN_LISTEMPLEADOS_IMPRIMIR)
        Me.TabPage1.Controls.Add(Me.Button_ListaSucursal_Buscar)
        Me.TabPage1.Controls.Add(Me.TextBox_ListaSucursal_TextAbuscar)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.DataGridView_ListaSucursal)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1062, 528)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de sucursales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button_ListaSucursales_CargaMasiva
        '
        Me.Button_ListaSucursales_CargaMasiva.Location = New System.Drawing.Point(156, 485)
        Me.Button_ListaSucursales_CargaMasiva.Name = "Button_ListaSucursales_CargaMasiva"
        Me.Button_ListaSucursales_CargaMasiva.Size = New System.Drawing.Size(120, 37)
        Me.Button_ListaSucursales_CargaMasiva.TabIndex = 33
        Me.Button_ListaSucursales_CargaMasiva.Text = "Carga Masiva"
        Me.Button_ListaSucursales_CargaMasiva.UseVisualStyleBackColor = True
        '
        'Button_ListaEmpleados_Desactivar
        '
        Me.Button_ListaEmpleados_Desactivar.Location = New System.Drawing.Point(382, 441)
        Me.Button_ListaEmpleados_Desactivar.Name = "Button_ListaEmpleados_Desactivar"
        Me.Button_ListaEmpleados_Desactivar.Size = New System.Drawing.Size(92, 23)
        Me.Button_ListaEmpleados_Desactivar.TabIndex = 32
        Me.Button_ListaEmpleados_Desactivar.Text = "Desactivar"
        Me.Button_ListaEmpleados_Desactivar.UseVisualStyleBackColor = True
        Me.Button_ListaEmpleados_Desactivar.Visible = False
        '
        'Button_ListaEmpleados_Activar
        '
        Me.Button_ListaEmpleados_Activar.Location = New System.Drawing.Point(269, 441)
        Me.Button_ListaEmpleados_Activar.Name = "Button_ListaEmpleados_Activar"
        Me.Button_ListaEmpleados_Activar.Size = New System.Drawing.Size(75, 23)
        Me.Button_ListaEmpleados_Activar.TabIndex = 31
        Me.Button_ListaEmpleados_Activar.Text = "Activar"
        Me.Button_ListaEmpleados_Activar.UseVisualStyleBackColor = True
        Me.Button_ListaEmpleados_Activar.Visible = False
        '
        'Button_ListaSucursal_Eliminar
        '
        Me.Button_ListaSucursal_Eliminar.Location = New System.Drawing.Point(145, 441)
        Me.Button_ListaSucursal_Eliminar.Name = "Button_ListaSucursal_Eliminar"
        Me.Button_ListaSucursal_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_ListaSucursal_Eliminar.TabIndex = 30
        Me.Button_ListaSucursal_Eliminar.Text = "Eliminar"
        Me.Button_ListaSucursal_Eliminar.UseVisualStyleBackColor = True
        Me.Button_ListaSucursal_Eliminar.Visible = False
        '
        'Seleccionar_ListaSucursal_Empleado
        '
        Me.Seleccionar_ListaSucursal_Empleado.AutoSize = True
        Me.Seleccionar_ListaSucursal_Empleado.Location = New System.Drawing.Point(20, 445)
        Me.Seleccionar_ListaSucursal_Empleado.Name = "Seleccionar_ListaSucursal_Empleado"
        Me.Seleccionar_ListaSucursal_Empleado.Size = New System.Drawing.Size(103, 19)
        Me.Seleccionar_ListaSucursal_Empleado.TabIndex = 29
        Me.Seleccionar_ListaSucursal_Empleado.Text = "Seleccionar"
        Me.Seleccionar_ListaSucursal_Empleado.UseVisualStyleBackColor = True
        '
        'BTN_LISTEMPLEADOS_IMPRIMIR
        '
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Location = New System.Drawing.Point(12, 485)
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Name = "BTN_LISTEMPLEADOS_IMPRIMIR"
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Size = New System.Drawing.Size(120, 37)
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.TabIndex = 28
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Text = "IMPRIMIR"
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'Button_ListaSucursal_Buscar
        '
        Me.Button_ListaSucursal_Buscar.Location = New System.Drawing.Point(324, 30)
        Me.Button_ListaSucursal_Buscar.Name = "Button_ListaSucursal_Buscar"
        Me.Button_ListaSucursal_Buscar.Size = New System.Drawing.Size(98, 24)
        Me.Button_ListaSucursal_Buscar.TabIndex = 27
        Me.Button_ListaSucursal_Buscar.Text = "Buscar"
        Me.Button_ListaSucursal_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_ListaSucursal_TextAbuscar
        '
        Me.TextBox_ListaSucursal_TextAbuscar.Location = New System.Drawing.Point(486, 30)
        Me.TextBox_ListaSucursal_TextAbuscar.Name = "TextBox_ListaSucursal_TextAbuscar"
        Me.TextBox_ListaSucursal_TextAbuscar.Size = New System.Drawing.Size(423, 23)
        Me.TextBox_ListaSucursal_TextAbuscar.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 24)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Lista Sucursal"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BTN_ListaSucursal_Cancelar)
        Me.TabPage2.Controls.Add(Me.BTN_ListaSucursal_Editar)
        Me.TabPage2.Controls.Add(Me.Label_ListaSucursal_Fecha)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.BTN_ListaSucursal_ACEPTAR)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1062, 528)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Crear y editar sucursales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BTN_ListaSucursal_Cancelar
        '
        Me.BTN_ListaSucursal_Cancelar.Location = New System.Drawing.Point(534, 424)
        Me.BTN_ListaSucursal_Cancelar.Name = "BTN_ListaSucursal_Cancelar"
        Me.BTN_ListaSucursal_Cancelar.Size = New System.Drawing.Size(116, 53)
        Me.BTN_ListaSucursal_Cancelar.TabIndex = 28
        Me.BTN_ListaSucursal_Cancelar.Text = "Cancelar"
        Me.BTN_ListaSucursal_Cancelar.UseVisualStyleBackColor = True
        '
        'BTN_ListaSucursal_Editar
        '
        Me.BTN_ListaSucursal_Editar.Location = New System.Drawing.Point(381, 424)
        Me.BTN_ListaSucursal_Editar.Name = "BTN_ListaSucursal_Editar"
        Me.BTN_ListaSucursal_Editar.Size = New System.Drawing.Size(116, 53)
        Me.BTN_ListaSucursal_Editar.TabIndex = 27
        Me.BTN_ListaSucursal_Editar.Text = "Editar"
        Me.BTN_ListaSucursal_Editar.UseVisualStyleBackColor = True
        '
        'Label_ListaSucursal_Fecha
        '
        Me.Label_ListaSucursal_Fecha.AutoSize = True
        Me.Label_ListaSucursal_Fecha.Location = New System.Drawing.Point(160, 34)
        Me.Label_ListaSucursal_Fecha.Name = "Label_ListaSucursal_Fecha"
        Me.Label_ListaSucursal_Fecha.Size = New System.Drawing.Size(42, 15)
        Me.Label_ListaSucursal_Fecha.TabIndex = 26
        Me.Label_ListaSucursal_Fecha.Text = "Fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox_ListaSucursal_DirecccionMunicipio)
        Me.GroupBox2.Controls.Add(Me.TextBox_ListaSucursal_DireccionEstado)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TXT_ListaSucursal_NUMERO)
        Me.GroupBox2.Controls.Add(Me.TXT_ListaSucursal_CODPOS)
        Me.GroupBox2.Controls.Add(Me.TXT_ListaSucursal_CALLE)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXT_ListaSucursal_COLONIA)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(493, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 278)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Direccion"
        '
        'TextBox_ListaSucursal_DirecccionMunicipio
        '
        Me.TextBox_ListaSucursal_DirecccionMunicipio.Location = New System.Drawing.Point(88, 97)
        Me.TextBox_ListaSucursal_DirecccionMunicipio.Name = "TextBox_ListaSucursal_DirecccionMunicipio"
        Me.TextBox_ListaSucursal_DirecccionMunicipio.Size = New System.Drawing.Size(398, 23)
        Me.TextBox_ListaSucursal_DirecccionMunicipio.TabIndex = 24
        '
        'TextBox_ListaSucursal_DireccionEstado
        '
        Me.TextBox_ListaSucursal_DireccionEstado.Location = New System.Drawing.Point(88, 63)
        Me.TextBox_ListaSucursal_DireccionEstado.Name = "TextBox_ListaSucursal_DireccionEstado"
        Me.TextBox_ListaSucursal_DireccionEstado.Size = New System.Drawing.Size(398, 23)
        Me.TextBox_ListaSucursal_DireccionEstado.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_ListaSucursal_Encargado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_ListaSucursal_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_SUC_NUM)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 278)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos sucursal"
        '
        'ComboBox_ListaSucursal_Encargado
        '
        Me.ComboBox_ListaSucursal_Encargado.FormattingEnabled = True
        Me.ComboBox_ListaSucursal_Encargado.Location = New System.Drawing.Point(100, 140)
        Me.ComboBox_ListaSucursal_Encargado.Name = "ComboBox_ListaSucursal_Encargado"
        Me.ComboBox_ListaSucursal_Encargado.Size = New System.Drawing.Size(324, 23)
        Me.ComboBox_ListaSucursal_Encargado.TabIndex = 16
        '
        'FORM_SUCURSAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 621)
        Me.Controls.Add(Me.TabControl_ListaSucursales)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_SUCURSAL"
        Me.Text = "SUCURSAL"
        CType(Me.DataGridView_ListaSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_ListaSucursales.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BTN_ListaSucursal_ACEPTAR As Button
    Friend WithEvents TXT_ListaSucursal_NOMBRE As TextBox
    Friend WithEvents TXT_SUC_NUM As TextBox
    Friend WithEvents TXT_ListaSucursal_COLONIA As TextBox
    Friend WithEvents TXT_ListaSucursal_CALLE As TextBox
    Friend WithEvents TXT_ListaSucursal_NUMERO As TextBox
    Friend WithEvents TXT_ListaSucursal_CODPOS As TextBox
    Friend WithEvents DataGridView_ListaSucursal As DataGridView
    Friend WithEvents TabControl_ListaSucursales As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button_ListaSucursal_Buscar As Button
    Friend WithEvents TextBox_ListaSucursal_TextAbuscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button_ListaSucursales_CargaMasiva As Button
    Friend WithEvents Button_ListaEmpleados_Desactivar As Button
    Friend WithEvents Button_ListaEmpleados_Activar As Button
    Friend WithEvents Button_ListaSucursal_Eliminar As Button
    Friend WithEvents Seleccionar_ListaSucursal_Empleado As CheckBox
    Friend WithEvents BTN_LISTEMPLEADOS_IMPRIMIR As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SeleccionarSucursal As DataGridViewCheckBoxColumn
    Friend WithEvents Label_ListaSucursal_Fecha As Label
    Friend WithEvents TextBox_ListaSucursal_DirecccionMunicipio As TextBox
    Friend WithEvents TextBox_ListaSucursal_DireccionEstado As TextBox
    Friend WithEvents ComboBox_ListaSucursal_Encargado As ComboBox
    Friend WithEvents BTN_ListaSucursal_Editar As Button
    Friend WithEvents BTN_ListaSucursal_Cancelar As Button
End Class
