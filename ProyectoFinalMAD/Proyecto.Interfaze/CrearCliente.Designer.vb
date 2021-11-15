<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_CrearCliente
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
        Me.BTN__CrearCliente__ACEPTAR = New System.Windows.Forms.Button()
        Me.GroupBox_CrearCliente_DatosCliente = New System.Windows.Forms.GroupBox()
        Me.TextBox_CrearCliente_Celular = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_ClienteCorreo = New System.Windows.Forms.TextBox()
        Me.Label_CrearCliente_NumeroCelular = New System.Windows.Forms.Label()
        Me.Label_CrearCliente_CorreoCliente = New System.Windows.Forms.Label()
        Me.GroupBox_CrearCliente_DatosUsuarios = New System.Windows.Forms.GroupBox()
        Me.TextBox__CrearCliente_UsuarioContrasena = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_UsuarioCURP = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_usuarioApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_usuarioApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_UsuarioNombre = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_UsuarioCURP = New System.Windows.Forms.Label()
        Me.DateTimePicker_CrearCliente_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label_ListaEmpleados_FechaNacimiento = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Contrasena = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_ApellidoMaterno = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_ApellidoPaterno = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Nombre = New System.Windows.Forms.Label()
        Me.GroupBox_CrearCliente_Direccion = New System.Windows.Forms.GroupBox()
        Me.TextBox_CrearCliente_NumDomicilio = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_DireccionCalle = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_DireccionCodigoPostal = New System.Windows.Forms.TextBox()
        Me.TextBox_CrearCliente_DireccionColonia = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_NumeroDomicilio = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Calle = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_CodigoPostal = New System.Windows.Forms.Label()
        Me.Label_ListaEmpleados_Colonia = New System.Windows.Forms.Label()
        Me.TextBox_CrearCliente_DireccionMunicipio = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_Municipio = New System.Windows.Forms.Label()
        Me.TextBox_CrearCliente_DireccionEstado = New System.Windows.Forms.TextBox()
        Me.Label_ListaEmpleados_Estado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_CrearCliente_Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox_CrearCliente_DatosCliente.SuspendLayout()
        Me.GroupBox_CrearCliente_DatosUsuarios.SuspendLayout()
        Me.GroupBox_CrearCliente_Direccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN__CrearCliente__ACEPTAR
        '
        Me.BTN__CrearCliente__ACEPTAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BTN__CrearCliente__ACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN__CrearCliente__ACEPTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BTN__CrearCliente__ACEPTAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN__CrearCliente__ACEPTAR.Location = New System.Drawing.Point(866, 360)
        Me.BTN__CrearCliente__ACEPTAR.Name = "BTN__CrearCliente__ACEPTAR"
        Me.BTN__CrearCliente__ACEPTAR.Size = New System.Drawing.Size(109, 45)
        Me.BTN__CrearCliente__ACEPTAR.TabIndex = 19
        Me.BTN__CrearCliente__ACEPTAR.Text = "ACEPTAR"
        Me.BTN__CrearCliente__ACEPTAR.UseVisualStyleBackColor = False
        '
        'GroupBox_CrearCliente_DatosCliente
        '
        Me.GroupBox_CrearCliente_DatosCliente.Controls.Add(Me.TextBox_CrearCliente_Celular)
        Me.GroupBox_CrearCliente_DatosCliente.Controls.Add(Me.TextBox_CrearCliente_ClienteCorreo)
        Me.GroupBox_CrearCliente_DatosCliente.Controls.Add(Me.Label_CrearCliente_NumeroCelular)
        Me.GroupBox_CrearCliente_DatosCliente.Controls.Add(Me.Label_CrearCliente_CorreoCliente)
        Me.GroupBox_CrearCliente_DatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox_CrearCliente_DatosCliente.Location = New System.Drawing.Point(21, 284)
        Me.GroupBox_CrearCliente_DatosCliente.Name = "GroupBox_CrearCliente_DatosCliente"
        Me.GroupBox_CrearCliente_DatosCliente.Size = New System.Drawing.Size(599, 171)
        Me.GroupBox_CrearCliente_DatosCliente.TabIndex = 24
        Me.GroupBox_CrearCliente_DatosCliente.TabStop = False
        Me.GroupBox_CrearCliente_DatosCliente.Text = "Datos de Empleado"
        '
        'TextBox_CrearCliente_Celular
        '
        Me.TextBox_CrearCliente_Celular.Location = New System.Drawing.Point(102, 95)
        Me.TextBox_CrearCliente_Celular.Name = "TextBox_CrearCliente_Celular"
        Me.TextBox_CrearCliente_Celular.Size = New System.Drawing.Size(382, 29)
        Me.TextBox_CrearCliente_Celular.TabIndex = 5
        '
        'TextBox_CrearCliente_ClienteCorreo
        '
        Me.TextBox_CrearCliente_ClienteCorreo.Location = New System.Drawing.Point(201, 39)
        Me.TextBox_CrearCliente_ClienteCorreo.Name = "TextBox_CrearCliente_ClienteCorreo"
        Me.TextBox_CrearCliente_ClienteCorreo.Size = New System.Drawing.Size(283, 29)
        Me.TextBox_CrearCliente_ClienteCorreo.TabIndex = 4
        '
        'Label_CrearCliente_NumeroCelular
        '
        Me.Label_CrearCliente_NumeroCelular.AutoSize = True
        Me.Label_CrearCliente_NumeroCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_CrearCliente_NumeroCelular.ForeColor = System.Drawing.Color.White
        Me.Label_CrearCliente_NumeroCelular.Location = New System.Drawing.Point(6, 97)
        Me.Label_CrearCliente_NumeroCelular.Name = "Label_CrearCliente_NumeroCelular"
        Me.Label_CrearCliente_NumeroCelular.Size = New System.Drawing.Size(79, 24)
        Me.Label_CrearCliente_NumeroCelular.TabIndex = 1
        Me.Label_CrearCliente_NumeroCelular.Text = "Celular: "
        '
        'Label_CrearCliente_CorreoCliente
        '
        Me.Label_CrearCliente_CorreoCliente.AutoSize = True
        Me.Label_CrearCliente_CorreoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_CrearCliente_CorreoCliente.ForeColor = System.Drawing.Color.White
        Me.Label_CrearCliente_CorreoCliente.Location = New System.Drawing.Point(6, 38)
        Me.Label_CrearCliente_CorreoCliente.Name = "Label_CrearCliente_CorreoCliente"
        Me.Label_CrearCliente_CorreoCliente.Size = New System.Drawing.Size(176, 24)
        Me.Label_CrearCliente_CorreoCliente.TabIndex = 0
        Me.Label_CrearCliente_CorreoCliente.Text = "Correo electronico: "
        '
        'GroupBox_CrearCliente_DatosUsuarios
        '
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.TextBox__CrearCliente_UsuarioContrasena)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.TextBox_CrearCliente_UsuarioCURP)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.TextBox_CrearCliente_usuarioApellidoMaterno)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.TextBox_CrearCliente_usuarioApellidoPaterno)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.TextBox_CrearCliente_UsuarioNombre)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.Label_ListaEmpleados_UsuarioCURP)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.DateTimePicker_CrearCliente_FechaNacimiento)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.Label_ListaEmpleados_FechaNacimiento)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.Label_ListaEmpleados_Contrasena)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.Label_ListaEmpleados_ApellidoMaterno)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.Label_ListaEmpleados_ApellidoPaterno)
        Me.GroupBox_CrearCliente_DatosUsuarios.Controls.Add(Me.Label_ListaEmpleados_Nombre)
        Me.GroupBox_CrearCliente_DatosUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox_CrearCliente_DatosUsuarios.Location = New System.Drawing.Point(648, 58)
        Me.GroupBox_CrearCliente_DatosUsuarios.Name = "GroupBox_CrearCliente_DatosUsuarios"
        Me.GroupBox_CrearCliente_DatosUsuarios.Size = New System.Drawing.Size(669, 220)
        Me.GroupBox_CrearCliente_DatosUsuarios.TabIndex = 23
        Me.GroupBox_CrearCliente_DatosUsuarios.TabStop = False
        Me.GroupBox_CrearCliente_DatosUsuarios.Text = "Datos de Usuario"
        '
        'TextBox__CrearCliente_UsuarioContrasena
        '
        Me.TextBox__CrearCliente_UsuarioContrasena.Location = New System.Drawing.Point(475, 85)
        Me.TextBox__CrearCliente_UsuarioContrasena.Name = "TextBox__CrearCliente_UsuarioContrasena"
        Me.TextBox__CrearCliente_UsuarioContrasena.Size = New System.Drawing.Size(145, 29)
        Me.TextBox__CrearCliente_UsuarioContrasena.TabIndex = 12
        '
        'TextBox_CrearCliente_UsuarioCURP
        '
        Me.TextBox_CrearCliente_UsuarioCURP.Location = New System.Drawing.Point(434, 46)
        Me.TextBox_CrearCliente_UsuarioCURP.Name = "TextBox_CrearCliente_UsuarioCURP"
        Me.TextBox_CrearCliente_UsuarioCURP.Size = New System.Drawing.Size(186, 29)
        Me.TextBox_CrearCliente_UsuarioCURP.TabIndex = 11
        '
        'TextBox_CrearCliente_usuarioApellidoMaterno
        '
        Me.TextBox_CrearCliente_usuarioApellidoMaterno.Location = New System.Drawing.Point(168, 122)
        Me.TextBox_CrearCliente_usuarioApellidoMaterno.Name = "TextBox_CrearCliente_usuarioApellidoMaterno"
        Me.TextBox_CrearCliente_usuarioApellidoMaterno.Size = New System.Drawing.Size(159, 29)
        Me.TextBox_CrearCliente_usuarioApellidoMaterno.TabIndex = 10
        '
        'TextBox_CrearCliente_usuarioApellidoPaterno
        '
        Me.TextBox_CrearCliente_usuarioApellidoPaterno.Location = New System.Drawing.Point(168, 82)
        Me.TextBox_CrearCliente_usuarioApellidoPaterno.Name = "TextBox_CrearCliente_usuarioApellidoPaterno"
        Me.TextBox_CrearCliente_usuarioApellidoPaterno.Size = New System.Drawing.Size(159, 29)
        Me.TextBox_CrearCliente_usuarioApellidoPaterno.TabIndex = 9
        '
        'TextBox_CrearCliente_UsuarioNombre
        '
        Me.TextBox_CrearCliente_UsuarioNombre.Location = New System.Drawing.Point(98, 46)
        Me.TextBox_CrearCliente_UsuarioNombre.Name = "TextBox_CrearCliente_UsuarioNombre"
        Me.TextBox_CrearCliente_UsuarioNombre.Size = New System.Drawing.Size(229, 29)
        Me.TextBox_CrearCliente_UsuarioNombre.TabIndex = 8
        '
        'Label_ListaEmpleados_UsuarioCURP
        '
        Me.Label_ListaEmpleados_UsuarioCURP.AutoSize = True
        Me.Label_ListaEmpleados_UsuarioCURP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_UsuarioCURP.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_UsuarioCURP.Location = New System.Drawing.Point(365, 49)
        Me.Label_ListaEmpleados_UsuarioCURP.Name = "Label_ListaEmpleados_UsuarioCURP"
        Me.Label_ListaEmpleados_UsuarioCURP.Size = New System.Drawing.Size(71, 24)
        Me.Label_ListaEmpleados_UsuarioCURP.TabIndex = 7
        Me.Label_ListaEmpleados_UsuarioCURP.Text = "CURP: "
        '
        'DateTimePicker_CrearCliente_FechaNacimiento
        '
        Me.DateTimePicker_CrearCliente_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_CrearCliente_FechaNacimiento.Location = New System.Drawing.Point(141, 183)
        Me.DateTimePicker_CrearCliente_FechaNacimiento.Name = "DateTimePicker_CrearCliente_FechaNacimiento"
        Me.DateTimePicker_CrearCliente_FechaNacimiento.Size = New System.Drawing.Size(199, 29)
        Me.DateTimePicker_CrearCliente_FechaNacimiento.TabIndex = 6
        Me.DateTimePicker_CrearCliente_FechaNacimiento.Value = New Date(2021, 11, 18, 0, 0, 0, 0)
        '
        'Label_ListaEmpleados_FechaNacimiento
        '
        Me.Label_ListaEmpleados_FechaNacimiento.AutoSize = True
        Me.Label_ListaEmpleados_FechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_FechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_FechaNacimiento.Location = New System.Drawing.Point(7, 161)
        Me.Label_ListaEmpleados_FechaNacimiento.Name = "Label_ListaEmpleados_FechaNacimiento"
        Me.Label_ListaEmpleados_FechaNacimiento.Size = New System.Drawing.Size(110, 48)
        Me.Label_ListaEmpleados_FechaNacimiento.TabIndex = 5
        Me.Label_ListaEmpleados_FechaNacimiento.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        '
        'Label_ListaEmpleados_Contrasena
        '
        Me.Label_ListaEmpleados_Contrasena.AutoSize = True
        Me.Label_ListaEmpleados_Contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_Contrasena.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_Contrasena.Location = New System.Drawing.Point(353, 87)
        Me.Label_ListaEmpleados_Contrasena.Name = "Label_ListaEmpleados_Contrasena"
        Me.Label_ListaEmpleados_Contrasena.Size = New System.Drawing.Size(116, 24)
        Me.Label_ListaEmpleados_Contrasena.TabIndex = 4
        Me.Label_ListaEmpleados_Contrasena.Text = "Contraseña: "
        '
        'Label_ListaEmpleados_ApellidoMaterno
        '
        Me.Label_ListaEmpleados_ApellidoMaterno.AutoSize = True
        Me.Label_ListaEmpleados_ApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_ApellidoMaterno.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_ApellidoMaterno.Location = New System.Drawing.Point(3, 124)
        Me.Label_ListaEmpleados_ApellidoMaterno.Name = "Label_ListaEmpleados_ApellidoMaterno"
        Me.Label_ListaEmpleados_ApellidoMaterno.Size = New System.Drawing.Size(163, 24)
        Me.Label_ListaEmpleados_ApellidoMaterno.TabIndex = 3
        Me.Label_ListaEmpleados_ApellidoMaterno.Text = "Apellido Materno: "
        '
        'Label_ListaEmpleados_ApellidoPaterno
        '
        Me.Label_ListaEmpleados_ApellidoPaterno.AutoSize = True
        Me.Label_ListaEmpleados_ApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_ApellidoPaterno.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_ApellidoPaterno.Location = New System.Drawing.Point(7, 88)
        Me.Label_ListaEmpleados_ApellidoPaterno.Name = "Label_ListaEmpleados_ApellidoPaterno"
        Me.Label_ListaEmpleados_ApellidoPaterno.Size = New System.Drawing.Size(158, 24)
        Me.Label_ListaEmpleados_ApellidoPaterno.TabIndex = 2
        Me.Label_ListaEmpleados_ApellidoPaterno.Text = "Apellido paterno: "
        '
        'Label_ListaEmpleados_Nombre
        '
        Me.Label_ListaEmpleados_Nombre.AutoSize = True
        Me.Label_ListaEmpleados_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_Nombre.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_Nombre.Location = New System.Drawing.Point(3, 49)
        Me.Label_ListaEmpleados_Nombre.Name = "Label_ListaEmpleados_Nombre"
        Me.Label_ListaEmpleados_Nombre.Size = New System.Drawing.Size(89, 24)
        Me.Label_ListaEmpleados_Nombre.TabIndex = 1
        Me.Label_ListaEmpleados_Nombre.Text = "Nombre: "
        '
        'GroupBox_CrearCliente_Direccion
        '
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.TextBox_CrearCliente_NumDomicilio)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.TextBox_CrearCliente_DireccionCalle)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.TextBox_CrearCliente_DireccionCodigoPostal)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.TextBox_CrearCliente_DireccionColonia)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.Label_ListaEmpleados_NumeroDomicilio)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.Label_ListaEmpleados_Calle)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.Label_ListaEmpleados_CodigoPostal)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.Label_ListaEmpleados_Colonia)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.TextBox_CrearCliente_DireccionMunicipio)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.Label_ListaEmpleados_Municipio)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.TextBox_CrearCliente_DireccionEstado)
        Me.GroupBox_CrearCliente_Direccion.Controls.Add(Me.Label_ListaEmpleados_Estado)
        Me.GroupBox_CrearCliente_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox_CrearCliente_Direccion.Location = New System.Drawing.Point(21, 58)
        Me.GroupBox_CrearCliente_Direccion.Name = "GroupBox_CrearCliente_Direccion"
        Me.GroupBox_CrearCliente_Direccion.Size = New System.Drawing.Size(599, 220)
        Me.GroupBox_CrearCliente_Direccion.TabIndex = 22
        Me.GroupBox_CrearCliente_Direccion.TabStop = False
        Me.GroupBox_CrearCliente_Direccion.Text = "Direccion"
        '
        'TextBox_CrearCliente_NumDomicilio
        '
        Me.TextBox_CrearCliente_NumDomicilio.Location = New System.Drawing.Point(406, 87)
        Me.TextBox_CrearCliente_NumDomicilio.Name = "TextBox_CrearCliente_NumDomicilio"
        Me.TextBox_CrearCliente_NumDomicilio.Size = New System.Drawing.Size(178, 29)
        Me.TextBox_CrearCliente_NumDomicilio.TabIndex = 11
        '
        'TextBox_CrearCliente_DireccionCalle
        '
        Me.TextBox_CrearCliente_DireccionCalle.Location = New System.Drawing.Point(375, 43)
        Me.TextBox_CrearCliente_DireccionCalle.Name = "TextBox_CrearCliente_DireccionCalle"
        Me.TextBox_CrearCliente_DireccionCalle.Size = New System.Drawing.Size(209, 29)
        Me.TextBox_CrearCliente_DireccionCalle.TabIndex = 10
        '
        'TextBox_CrearCliente_DireccionCodigoPostal
        '
        Me.TextBox_CrearCliente_DireccionCodigoPostal.Location = New System.Drawing.Point(137, 161)
        Me.TextBox_CrearCliente_DireccionCodigoPostal.Name = "TextBox_CrearCliente_DireccionCodigoPostal"
        Me.TextBox_CrearCliente_DireccionCodigoPostal.Size = New System.Drawing.Size(154, 29)
        Me.TextBox_CrearCliente_DireccionCodigoPostal.TabIndex = 9
        '
        'TextBox_CrearCliente_DireccionColonia
        '
        Me.TextBox_CrearCliente_DireccionColonia.Location = New System.Drawing.Point(85, 121)
        Me.TextBox_CrearCliente_DireccionColonia.Name = "TextBox_CrearCliente_DireccionColonia"
        Me.TextBox_CrearCliente_DireccionColonia.Size = New System.Drawing.Size(206, 29)
        Me.TextBox_CrearCliente_DireccionColonia.TabIndex = 8
        '
        'Label_ListaEmpleados_NumeroDomicilio
        '
        Me.Label_ListaEmpleados_NumeroDomicilio.AutoSize = True
        Me.Label_ListaEmpleados_NumeroDomicilio.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_NumeroDomicilio.Location = New System.Drawing.Point(297, 75)
        Me.Label_ListaEmpleados_NumeroDomicilio.Name = "Label_ListaEmpleados_NumeroDomicilio"
        Me.Label_ListaEmpleados_NumeroDomicilio.Size = New System.Drawing.Size(95, 48)
        Me.Label_ListaEmpleados_NumeroDomicilio.TabIndex = 7
        Me.Label_ListaEmpleados_NumeroDomicilio.Text = "Numero " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "domicilio: "
        '
        'Label_ListaEmpleados_Calle
        '
        Me.Label_ListaEmpleados_Calle.AutoSize = True
        Me.Label_ListaEmpleados_Calle.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_Calle.Location = New System.Drawing.Point(297, 46)
        Me.Label_ListaEmpleados_Calle.Name = "Label_ListaEmpleados_Calle"
        Me.Label_ListaEmpleados_Calle.Size = New System.Drawing.Size(62, 24)
        Me.Label_ListaEmpleados_Calle.TabIndex = 6
        Me.Label_ListaEmpleados_Calle.Text = "Calle: "
        '
        'Label_ListaEmpleados_CodigoPostal
        '
        Me.Label_ListaEmpleados_CodigoPostal.AutoSize = True
        Me.Label_ListaEmpleados_CodigoPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_CodigoPostal.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_CodigoPostal.Location = New System.Drawing.Point(6, 164)
        Me.Label_ListaEmpleados_CodigoPostal.Name = "Label_ListaEmpleados_CodigoPostal"
        Me.Label_ListaEmpleados_CodigoPostal.Size = New System.Drawing.Size(133, 24)
        Me.Label_ListaEmpleados_CodigoPostal.TabIndex = 5
        Me.Label_ListaEmpleados_CodigoPostal.Text = "codigo Postal: "
        '
        'Label_ListaEmpleados_Colonia
        '
        Me.Label_ListaEmpleados_Colonia.AutoSize = True
        Me.Label_ListaEmpleados_Colonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_ListaEmpleados_Colonia.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_Colonia.Location = New System.Drawing.Point(6, 129)
        Me.Label_ListaEmpleados_Colonia.Name = "Label_ListaEmpleados_Colonia"
        Me.Label_ListaEmpleados_Colonia.Size = New System.Drawing.Size(84, 24)
        Me.Label_ListaEmpleados_Colonia.TabIndex = 4
        Me.Label_ListaEmpleados_Colonia.Text = "Colonia: "
        '
        'TextBox_CrearCliente_DireccionMunicipio
        '
        Me.TextBox_CrearCliente_DireccionMunicipio.Location = New System.Drawing.Point(109, 81)
        Me.TextBox_CrearCliente_DireccionMunicipio.Name = "TextBox_CrearCliente_DireccionMunicipio"
        Me.TextBox_CrearCliente_DireccionMunicipio.Size = New System.Drawing.Size(182, 29)
        Me.TextBox_CrearCliente_DireccionMunicipio.TabIndex = 3
        '
        'Label_ListaEmpleados_Municipio
        '
        Me.Label_ListaEmpleados_Municipio.AutoSize = True
        Me.Label_ListaEmpleados_Municipio.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_Municipio.Location = New System.Drawing.Point(6, 85)
        Me.Label_ListaEmpleados_Municipio.Name = "Label_ListaEmpleados_Municipio"
        Me.Label_ListaEmpleados_Municipio.Size = New System.Drawing.Size(102, 24)
        Me.Label_ListaEmpleados_Municipio.TabIndex = 2
        Me.Label_ListaEmpleados_Municipio.Text = "Municipio: "
        '
        'TextBox_CrearCliente_DireccionEstado
        '
        Me.TextBox_CrearCliente_DireccionEstado.Location = New System.Drawing.Point(84, 43)
        Me.TextBox_CrearCliente_DireccionEstado.Name = "TextBox_CrearCliente_DireccionEstado"
        Me.TextBox_CrearCliente_DireccionEstado.Size = New System.Drawing.Size(207, 29)
        Me.TextBox_CrearCliente_DireccionEstado.TabIndex = 1
        '
        'Label_ListaEmpleados_Estado
        '
        Me.Label_ListaEmpleados_Estado.AutoSize = True
        Me.Label_ListaEmpleados_Estado.ForeColor = System.Drawing.Color.White
        Me.Label_ListaEmpleados_Estado.Location = New System.Drawing.Point(6, 46)
        Me.Label_ListaEmpleados_Estado.Name = "Label_ListaEmpleados_Estado"
        Me.Label_ListaEmpleados_Estado.Size = New System.Drawing.Size(78, 24)
        Me.Label_ListaEmpleados_Estado.TabIndex = 0
        Me.Label_ListaEmpleados_Estado.Text = "Estado: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Crear Cuenta de cliente"
        '
        'Button_CrearCliente_Cancelar
        '
        Me.Button_CrearCliente_Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button_CrearCliente_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_CrearCliente_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button_CrearCliente_Cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_CrearCliente_Cancelar.Location = New System.Drawing.Point(996, 360)
        Me.Button_CrearCliente_Cancelar.Name = "Button_CrearCliente_Cancelar"
        Me.Button_CrearCliente_Cancelar.Size = New System.Drawing.Size(104, 45)
        Me.Button_CrearCliente_Cancelar.TabIndex = 26
        Me.Button_CrearCliente_Cancelar.Text = "Cancelar"
        Me.Button_CrearCliente_Cancelar.UseVisualStyleBackColor = False
        '
        'FORM_CrearCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1329, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_CrearCliente_Cancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox_CrearCliente_DatosCliente)
        Me.Controls.Add(Me.GroupBox_CrearCliente_DatosUsuarios)
        Me.Controls.Add(Me.GroupBox_CrearCliente_Direccion)
        Me.Controls.Add(Me.BTN__CrearCliente__ACEPTAR)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_CrearCliente"
        Me.Text = "USUARIO"
        Me.GroupBox_CrearCliente_DatosCliente.ResumeLayout(False)
        Me.GroupBox_CrearCliente_DatosCliente.PerformLayout()
        Me.GroupBox_CrearCliente_DatosUsuarios.ResumeLayout(False)
        Me.GroupBox_CrearCliente_DatosUsuarios.PerformLayout()
        Me.GroupBox_CrearCliente_Direccion.ResumeLayout(False)
        Me.GroupBox_CrearCliente_Direccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN__CrearCliente__ACEPTAR As Button
    Friend WithEvents GroupBox_CrearCliente_DatosCliente As GroupBox
    Friend WithEvents TextBox_CrearCliente_Celular As TextBox
    Friend WithEvents TextBox_CrearCliente_ClienteCorreo As TextBox
    Friend WithEvents Label_CrearCliente_NumeroCelular As Label
    Friend WithEvents Label_CrearCliente_CorreoCliente As Label
    Friend WithEvents GroupBox_CrearCliente_DatosUsuarios As GroupBox
    Friend WithEvents TextBox__CrearCliente_UsuarioContrasena As TextBox
    Friend WithEvents TextBox_CrearCliente_UsuarioCURP As TextBox
    Friend WithEvents TextBox_CrearCliente_usuarioApellidoMaterno As TextBox
    Friend WithEvents TextBox_CrearCliente_usuarioApellidoPaterno As TextBox
    Friend WithEvents TextBox_CrearCliente_UsuarioNombre As TextBox
    Friend WithEvents Label_ListaEmpleados_UsuarioCURP As Label
    Friend WithEvents DateTimePicker_CrearCliente_FechaNacimiento As DateTimePicker
    Friend WithEvents Label_ListaEmpleados_FechaNacimiento As Label
    Friend WithEvents Label_ListaEmpleados_Contrasena As Label
    Friend WithEvents Label_ListaEmpleados_ApellidoMaterno As Label
    Friend WithEvents Label_ListaEmpleados_ApellidoPaterno As Label
    Friend WithEvents Label_ListaEmpleados_Nombre As Label
    Friend WithEvents GroupBox_CrearCliente_Direccion As GroupBox
    Friend WithEvents TextBox_CrearCliente_NumDomicilio As TextBox
    Friend WithEvents TextBox_CrearCliente_DireccionCalle As TextBox
    Friend WithEvents TextBox_CrearCliente_DireccionCodigoPostal As TextBox
    Friend WithEvents TextBox_CrearCliente_DireccionColonia As TextBox
    Friend WithEvents Label_ListaEmpleados_NumeroDomicilio As Label
    Friend WithEvents Label_ListaEmpleados_Calle As Label
    Friend WithEvents Label_ListaEmpleados_CodigoPostal As Label
    Friend WithEvents Label_ListaEmpleados_Colonia As Label
    Friend WithEvents TextBox_CrearCliente_DireccionMunicipio As TextBox
    Friend WithEvents Label_ListaEmpleados_Municipio As Label
    Friend WithEvents TextBox_CrearCliente_DireccionEstado As TextBox
    Friend WithEvents Label_ListaEmpleados_Estado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_CrearCliente_Cancelar As Button
End Class
