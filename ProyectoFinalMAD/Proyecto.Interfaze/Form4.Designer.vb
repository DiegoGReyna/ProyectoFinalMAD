<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_USUARIO
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
        Me.TXT_USUARIO_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTP_USUARIO_NACIMIENTO = New System.Windows.Forms.DateTimePicker()
        Me.TXT_USUARIO_CURP = New System.Windows.Forms.TextBox()
        Me.TXT_USUARIO_CORREO = New System.Windows.Forms.TextBox()
        Me.TXT_USUARIO_CELULAR = New System.Windows.Forms.TextBox()
        Me.TXT_USUARIO_CONTRA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTN_USUARIO_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_USUARIO_LISTA = New System.Windows.Forms.Button()
        Me.BTN_USUARIO_CARGA = New System.Windows.Forms.Button()
        Me.TXT_USUARIO_COLONIA = New System.Windows.Forms.TextBox()
        Me.TXT_USUARIO_CALLE = New System.Windows.Forms.TextBox()
        Me.CB_USUARIO_ESTADO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_MUNICIPIO = New System.Windows.Forms.ComboBox()
        Me.TXT_USUARIO_CODPOS = New System.Windows.Forms.TextBox()
        Me.TXT_USUARIO_NUMERO = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CURP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(458, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Nacimiento:"
        '
        'TXT_USUARIO_NOMBRE
        '
        Me.TXT_USUARIO_NOMBRE.Location = New System.Drawing.Point(117, 60)
        Me.TXT_USUARIO_NOMBRE.Name = "TXT_USUARIO_NOMBRE"
        Me.TXT_USUARIO_NOMBRE.Size = New System.Drawing.Size(309, 23)
        Me.TXT_USUARIO_NOMBRE.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(521, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(500, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(398, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "DIRECCION"
        '
        'DTP_USUARIO_NACIMIENTO
        '
        Me.DTP_USUARIO_NACIMIENTO.Location = New System.Drawing.Point(590, 60)
        Me.DTP_USUARIO_NACIMIENTO.Name = "DTP_USUARIO_NACIMIENTO"
        Me.DTP_USUARIO_NACIMIENTO.Size = New System.Drawing.Size(282, 23)
        Me.DTP_USUARIO_NACIMIENTO.TabIndex = 8
        '
        'TXT_USUARIO_CURP
        '
        Me.TXT_USUARIO_CURP.Location = New System.Drawing.Point(117, 107)
        Me.TXT_USUARIO_CURP.Name = "TXT_USUARIO_CURP"
        Me.TXT_USUARIO_CURP.Size = New System.Drawing.Size(309, 23)
        Me.TXT_USUARIO_CURP.TabIndex = 9
        '
        'TXT_USUARIO_CORREO
        '
        Me.TXT_USUARIO_CORREO.Location = New System.Drawing.Point(117, 148)
        Me.TXT_USUARIO_CORREO.Name = "TXT_USUARIO_CORREO"
        Me.TXT_USUARIO_CORREO.Size = New System.Drawing.Size(309, 23)
        Me.TXT_USUARIO_CORREO.TabIndex = 10
        '
        'TXT_USUARIO_CELULAR
        '
        Me.TXT_USUARIO_CELULAR.Location = New System.Drawing.Point(590, 99)
        Me.TXT_USUARIO_CELULAR.Name = "TXT_USUARIO_CELULAR"
        Me.TXT_USUARIO_CELULAR.Size = New System.Drawing.Size(216, 23)
        Me.TXT_USUARIO_CELULAR.TabIndex = 11
        '
        'TXT_USUARIO_CONTRA
        '
        Me.TXT_USUARIO_CONTRA.Location = New System.Drawing.Point(590, 148)
        Me.TXT_USUARIO_CONTRA.Name = "TXT_USUARIO_CONTRA"
        Me.TXT_USUARIO_CONTRA.Size = New System.Drawing.Size(216, 23)
        Me.TXT_USUARIO_CONTRA.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Estado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Colonia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Calle:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(507, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Municipio:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(479, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Codigo Postal:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(528, 310)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Numero:"
        '
        'BTN_USUARIO_ACEPTAR
        '
        Me.BTN_USUARIO_ACEPTAR.Location = New System.Drawing.Point(234, 377)
        Me.BTN_USUARIO_ACEPTAR.Name = "BTN_USUARIO_ACEPTAR"
        Me.BTN_USUARIO_ACEPTAR.Size = New System.Drawing.Size(109, 45)
        Me.BTN_USUARIO_ACEPTAR.TabIndex = 19
        Me.BTN_USUARIO_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_USUARIO_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_USUARIO_LISTA
        '
        Me.BTN_USUARIO_LISTA.Location = New System.Drawing.Point(381, 377)
        Me.BTN_USUARIO_LISTA.Name = "BTN_USUARIO_LISTA"
        Me.BTN_USUARIO_LISTA.Size = New System.Drawing.Size(109, 45)
        Me.BTN_USUARIO_LISTA.TabIndex = 20
        Me.BTN_USUARIO_LISTA.Text = "LISTA"
        Me.BTN_USUARIO_LISTA.UseVisualStyleBackColor = True
        '
        'BTN_USUARIO_CARGA
        '
        Me.BTN_USUARIO_CARGA.Location = New System.Drawing.Point(524, 377)
        Me.BTN_USUARIO_CARGA.Name = "BTN_USUARIO_CARGA"
        Me.BTN_USUARIO_CARGA.Size = New System.Drawing.Size(104, 45)
        Me.BTN_USUARIO_CARGA.TabIndex = 21
        Me.BTN_USUARIO_CARGA.Text = "CARGA"
        Me.BTN_USUARIO_CARGA.UseVisualStyleBackColor = True
        '
        'TXT_USUARIO_COLONIA
        '
        Me.TXT_USUARIO_COLONIA.Location = New System.Drawing.Point(117, 268)
        Me.TXT_USUARIO_COLONIA.Name = "TXT_USUARIO_COLONIA"
        Me.TXT_USUARIO_COLONIA.Size = New System.Drawing.Size(309, 23)
        Me.TXT_USUARIO_COLONIA.TabIndex = 22
        '
        'TXT_USUARIO_CALLE
        '
        Me.TXT_USUARIO_CALLE.Location = New System.Drawing.Point(117, 310)
        Me.TXT_USUARIO_CALLE.Name = "TXT_USUARIO_CALLE"
        Me.TXT_USUARIO_CALLE.Size = New System.Drawing.Size(309, 23)
        Me.TXT_USUARIO_CALLE.TabIndex = 23
        '
        'CB_USUARIO_ESTADO
        '
        Me.CB_USUARIO_ESTADO.FormattingEnabled = True
        Me.CB_USUARIO_ESTADO.Location = New System.Drawing.Point(117, 226)
        Me.CB_USUARIO_ESTADO.Name = "CB_USUARIO_ESTADO"
        Me.CB_USUARIO_ESTADO.Size = New System.Drawing.Size(194, 23)
        Me.CB_USUARIO_ESTADO.TabIndex = 24
        '
        'CB_USUARIO_MUNICIPIO
        '
        Me.CB_USUARIO_MUNICIPIO.FormattingEnabled = True
        Me.CB_USUARIO_MUNICIPIO.Location = New System.Drawing.Point(590, 226)
        Me.CB_USUARIO_MUNICIPIO.Name = "CB_USUARIO_MUNICIPIO"
        Me.CB_USUARIO_MUNICIPIO.Size = New System.Drawing.Size(194, 23)
        Me.CB_USUARIO_MUNICIPIO.TabIndex = 25
        '
        'TXT_USUARIO_CODPOS
        '
        Me.TXT_USUARIO_CODPOS.Location = New System.Drawing.Point(591, 268)
        Me.TXT_USUARIO_CODPOS.Name = "TXT_USUARIO_CODPOS"
        Me.TXT_USUARIO_CODPOS.Size = New System.Drawing.Size(100, 23)
        Me.TXT_USUARIO_CODPOS.TabIndex = 26
        '
        'TXT_USUARIO_NUMERO
        '
        Me.TXT_USUARIO_NUMERO.Location = New System.Drawing.Point(590, 307)
        Me.TXT_USUARIO_NUMERO.Name = "TXT_USUARIO_NUMERO"
        Me.TXT_USUARIO_NUMERO.Size = New System.Drawing.Size(100, 23)
        Me.TXT_USUARIO_NUMERO.TabIndex = 27
        '
        'FORM_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(923, 461)
        Me.Controls.Add(Me.TXT_USUARIO_NUMERO)
        Me.Controls.Add(Me.TXT_USUARIO_CODPOS)
        Me.Controls.Add(Me.CB_USUARIO_MUNICIPIO)
        Me.Controls.Add(Me.CB_USUARIO_ESTADO)
        Me.Controls.Add(Me.TXT_USUARIO_CALLE)
        Me.Controls.Add(Me.TXT_USUARIO_COLONIA)
        Me.Controls.Add(Me.BTN_USUARIO_CARGA)
        Me.Controls.Add(Me.BTN_USUARIO_LISTA)
        Me.Controls.Add(Me.BTN_USUARIO_ACEPTAR)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_USUARIO_CONTRA)
        Me.Controls.Add(Me.TXT_USUARIO_CELULAR)
        Me.Controls.Add(Me.TXT_USUARIO_CORREO)
        Me.Controls.Add(Me.TXT_USUARIO_CURP)
        Me.Controls.Add(Me.DTP_USUARIO_NACIMIENTO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_USUARIO_NOMBRE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_USUARIO"
        Me.Text = "USUARIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_USUARIO_NOMBRE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DTP_USUARIO_NACIMIENTO As DateTimePicker
    Friend WithEvents TXT_USUARIO_CURP As TextBox
    Friend WithEvents TXT_USUARIO_CORREO As TextBox
    Friend WithEvents TXT_USUARIO_CELULAR As TextBox
    Friend WithEvents TXT_USUARIO_CONTRA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BTN_USUARIO_ACEPTAR As Button
    Friend WithEvents BTN_USUARIO_LISTA As Button
    Friend WithEvents BTN_USUARIO_CARGA As Button
    Friend WithEvents TXT_USUARIO_COLONIA As TextBox
    Friend WithEvents TXT_USUARIO_CALLE As TextBox
    Friend WithEvents CB_USUARIO_ESTADO As ComboBox
    Friend WithEvents CB_USUARIO_MUNICIPIO As ComboBox
    Friend WithEvents TXT_USUARIO_CODPOS As TextBox
    Friend WithEvents TXT_USUARIO_NUMERO As TextBox
End Class
