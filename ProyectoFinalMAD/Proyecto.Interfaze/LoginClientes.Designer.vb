<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginClientes))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente = New System.Windows.Forms.LinkLabel()
        Me.Button_InicioSesionEmpleado_reregresar = New System.Windows.Forms.Button()
        Me.LAB_SLOGAN = New System.Windows.Forms.Label()
        Me.TXT_LoginEmpleado_Contrasena = New System.Windows.Forms.TextBox()
        Me.TXT_LoginEmpleado_CorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label_LoginEmpleado_Contrasena = New System.Windows.Forms.Label()
        Me.Label_LoginEmpleado_CorreoElectronico = New System.Windows.Forms.Label()
        Me.BTN_REC_CONTRA_EMPLEADO = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR_EMPLEADO = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(92, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel_LoginEmpleado_IrAcrearCliente
        '
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.AutoSize = True
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.Location = New System.Drawing.Point(338, 369)
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.Name = "LinkLabel_LoginEmpleado_IrAcrearCliente"
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.Size = New System.Drawing.Size(121, 24)
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.TabIndex = 34
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.TabStop = True
        Me.LinkLabel_LoginEmpleado_IrAcrearCliente.Text = "Crear Cuenta"
        '
        'Button_InicioSesionEmpleado_reregresar
        '
        Me.Button_InicioSesionEmpleado_reregresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button_InicioSesionEmpleado_reregresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_InicioSesionEmpleado_reregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_InicioSesionEmpleado_reregresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_InicioSesionEmpleado_reregresar.Location = New System.Drawing.Point(12, 412)
        Me.Button_InicioSesionEmpleado_reregresar.Name = "Button_InicioSesionEmpleado_reregresar"
        Me.Button_InicioSesionEmpleado_reregresar.Size = New System.Drawing.Size(75, 26)
        Me.Button_InicioSesionEmpleado_reregresar.TabIndex = 33
        Me.Button_InicioSesionEmpleado_reregresar.Text = "Atras"
        Me.Button_InicioSesionEmpleado_reregresar.UseVisualStyleBackColor = False
        '
        'LAB_SLOGAN
        '
        Me.LAB_SLOGAN.AutoSize = True
        Me.LAB_SLOGAN.Location = New System.Drawing.Point(270, 412)
        Me.LAB_SLOGAN.Name = "LAB_SLOGAN"
        Me.LAB_SLOGAN.Size = New System.Drawing.Size(263, 13)
        Me.LAB_SLOGAN.TabIndex = 32
        Me.LAB_SLOGAN.Text = "YOU HAVE NO IDEA WHAT´S IN-STORE FOR YOU!"
        '
        'TXT_LoginEmpleado_Contrasena
        '
        Me.TXT_LoginEmpleado_Contrasena.Location = New System.Drawing.Point(292, 203)
        Me.TXT_LoginEmpleado_Contrasena.Name = "TXT_LoginEmpleado_Contrasena"
        Me.TXT_LoginEmpleado_Contrasena.Size = New System.Drawing.Size(211, 20)
        Me.TXT_LoginEmpleado_Contrasena.TabIndex = 31
        '
        'TXT_LoginEmpleado_CorreoElectronico
        '
        Me.TXT_LoginEmpleado_CorreoElectronico.Location = New System.Drawing.Point(292, 159)
        Me.TXT_LoginEmpleado_CorreoElectronico.Name = "TXT_LoginEmpleado_CorreoElectronico"
        Me.TXT_LoginEmpleado_CorreoElectronico.Size = New System.Drawing.Size(211, 20)
        Me.TXT_LoginEmpleado_CorreoElectronico.TabIndex = 30
        '
        'Label_LoginEmpleado_Contrasena
        '
        Me.Label_LoginEmpleado_Contrasena.AutoSize = True
        Me.Label_LoginEmpleado_Contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_LoginEmpleado_Contrasena.ForeColor = System.Drawing.Color.White
        Me.Label_LoginEmpleado_Contrasena.Location = New System.Drawing.Point(175, 198)
        Me.Label_LoginEmpleado_Contrasena.Name = "Label_LoginEmpleado_Contrasena"
        Me.Label_LoginEmpleado_Contrasena.Size = New System.Drawing.Size(111, 24)
        Me.Label_LoginEmpleado_Contrasena.TabIndex = 29
        Me.Label_LoginEmpleado_Contrasena.Text = "Contraseña:"
        '
        'Label_LoginEmpleado_CorreoElectronico
        '
        Me.Label_LoginEmpleado_CorreoElectronico.AutoSize = True
        Me.Label_LoginEmpleado_CorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_LoginEmpleado_CorreoElectronico.ForeColor = System.Drawing.Color.White
        Me.Label_LoginEmpleado_CorreoElectronico.Location = New System.Drawing.Point(112, 155)
        Me.Label_LoginEmpleado_CorreoElectronico.Name = "Label_LoginEmpleado_CorreoElectronico"
        Me.Label_LoginEmpleado_CorreoElectronico.Size = New System.Drawing.Size(178, 24)
        Me.Label_LoginEmpleado_CorreoElectronico.TabIndex = 28
        Me.Label_LoginEmpleado_CorreoElectronico.Text = "Correo Electronico: "
        '
        'BTN_REC_CONTRA_EMPLEADO
        '
        Me.BTN_REC_CONTRA_EMPLEADO.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BTN_REC_CONTRA_EMPLEADO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_REC_CONTRA_EMPLEADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTN_REC_CONTRA_EMPLEADO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_REC_CONTRA_EMPLEADO.Location = New System.Drawing.Point(292, 312)
        Me.BTN_REC_CONTRA_EMPLEADO.Name = "BTN_REC_CONTRA_EMPLEADO"
        Me.BTN_REC_CONTRA_EMPLEADO.Size = New System.Drawing.Size(226, 43)
        Me.BTN_REC_CONTRA_EMPLEADO.TabIndex = 27
        Me.BTN_REC_CONTRA_EMPLEADO.Text = "RECORDAR CONTRASEÑA"
        Me.BTN_REC_CONTRA_EMPLEADO.UseVisualStyleBackColor = False
        '
        'BTN_ACEPTAR_EMPLEADO
        '
        Me.BTN_ACEPTAR_EMPLEADO.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BTN_ACEPTAR_EMPLEADO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_ACEPTAR_EMPLEADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BTN_ACEPTAR_EMPLEADO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_ACEPTAR_EMPLEADO.Location = New System.Drawing.Point(348, 250)
        Me.BTN_ACEPTAR_EMPLEADO.Name = "BTN_ACEPTAR_EMPLEADO"
        Me.BTN_ACEPTAR_EMPLEADO.Size = New System.Drawing.Size(111, 47)
        Me.BTN_ACEPTAR_EMPLEADO.TabIndex = 26
        Me.BTN_ACEPTAR_EMPLEADO.Text = "ACEPTAR"
        Me.BTN_ACEPTAR_EMPLEADO.UseVisualStyleBackColor = False
        '
        'LoginClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel_LoginEmpleado_IrAcrearCliente)
        Me.Controls.Add(Me.Button_InicioSesionEmpleado_reregresar)
        Me.Controls.Add(Me.LAB_SLOGAN)
        Me.Controls.Add(Me.TXT_LoginEmpleado_Contrasena)
        Me.Controls.Add(Me.TXT_LoginEmpleado_CorreoElectronico)
        Me.Controls.Add(Me.Label_LoginEmpleado_Contrasena)
        Me.Controls.Add(Me.Label_LoginEmpleado_CorreoElectronico)
        Me.Controls.Add(Me.BTN_REC_CONTRA_EMPLEADO)
        Me.Controls.Add(Me.BTN_ACEPTAR_EMPLEADO)
        Me.Name = "LoginClientes"
        Me.Text = "LoginClientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel_LoginEmpleado_IrAcrearCliente As LinkLabel
    Friend WithEvents Button_InicioSesionEmpleado_reregresar As Button
    Friend WithEvents LAB_SLOGAN As Label
    Friend WithEvents TXT_LoginEmpleado_Contrasena As TextBox
    Friend WithEvents TXT_LoginEmpleado_CorreoElectronico As TextBox
    Friend WithEvents Label_LoginEmpleado_Contrasena As Label
    Friend WithEvents Label_LoginEmpleado_CorreoElectronico As Label
    Friend WithEvents BTN_REC_CONTRA_EMPLEADO As Button
    Friend WithEvents BTN_ACEPTAR_EMPLEADO As Button
End Class
