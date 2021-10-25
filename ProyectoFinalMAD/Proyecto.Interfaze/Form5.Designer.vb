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
        Me.BTN_SUC_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_SUC_LISTA = New System.Windows.Forms.Button()
        Me.BTN_SUC_CARGA = New System.Windows.Forms.Button()
        Me.TXT_SUC_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_SUC_NUM = New System.Windows.Forms.TextBox()
        Me.DTP_SUC_CREACION = New System.Windows.Forms.DateTimePicker()
        Me.TXT_SUC_ENCARGADO = New System.Windows.Forms.TextBox()
        Me.TXT_SUC_COLONIA = New System.Windows.Forms.TextBox()
        Me.CB_SUC_ESTADO = New System.Windows.Forms.ComboBox()
        Me.TXT_SUC_CALLE = New System.Windows.Forms.TextBox()
        Me.TXT_SUC_NUMERO = New System.Windows.Forms.TextBox()
        Me.TXT_SUC_CODPOS = New System.Windows.Forms.TextBox()
        Me.CB_SUC_MUNICIPIO = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero Sucursal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Creacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Encargado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DIRRECION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Colonia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Calle:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(519, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Municipio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(519, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Codigo Postal:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(519, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Numero:"
        '
        'BTN_SUC_ACEPTAR
        '
        Me.BTN_SUC_ACEPTAR.Location = New System.Drawing.Point(209, 365)
        Me.BTN_SUC_ACEPTAR.Name = "BTN_SUC_ACEPTAR"
        Me.BTN_SUC_ACEPTAR.Size = New System.Drawing.Size(116, 53)
        Me.BTN_SUC_ACEPTAR.TabIndex = 11
        Me.BTN_SUC_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_SUC_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_SUC_LISTA
        '
        Me.BTN_SUC_LISTA.Location = New System.Drawing.Point(352, 365)
        Me.BTN_SUC_LISTA.Name = "BTN_SUC_LISTA"
        Me.BTN_SUC_LISTA.Size = New System.Drawing.Size(116, 53)
        Me.BTN_SUC_LISTA.TabIndex = 12
        Me.BTN_SUC_LISTA.Text = "LISTA"
        Me.BTN_SUC_LISTA.UseVisualStyleBackColor = True
        '
        'BTN_SUC_CARGA
        '
        Me.BTN_SUC_CARGA.Location = New System.Drawing.Point(499, 365)
        Me.BTN_SUC_CARGA.Name = "BTN_SUC_CARGA"
        Me.BTN_SUC_CARGA.Size = New System.Drawing.Size(116, 53)
        Me.BTN_SUC_CARGA.TabIndex = 13
        Me.BTN_SUC_CARGA.Text = "CARGA"
        Me.BTN_SUC_CARGA.UseVisualStyleBackColor = True
        '
        'TXT_SUC_NOMBRE
        '
        Me.TXT_SUC_NOMBRE.Location = New System.Drawing.Point(115, 49)
        Me.TXT_SUC_NOMBRE.Name = "TXT_SUC_NOMBRE"
        Me.TXT_SUC_NOMBRE.Size = New System.Drawing.Size(271, 23)
        Me.TXT_SUC_NOMBRE.TabIndex = 14
        '
        'TXT_SUC_NUM
        '
        Me.TXT_SUC_NUM.Location = New System.Drawing.Point(543, 49)
        Me.TXT_SUC_NUM.Name = "TXT_SUC_NUM"
        Me.TXT_SUC_NUM.Size = New System.Drawing.Size(156, 23)
        Me.TXT_SUC_NUM.TabIndex = 15
        '
        'DTP_SUC_CREACION
        '
        Me.DTP_SUC_CREACION.Location = New System.Drawing.Point(172, 95)
        Me.DTP_SUC_CREACION.Name = "DTP_SUC_CREACION"
        Me.DTP_SUC_CREACION.Size = New System.Drawing.Size(289, 23)
        Me.DTP_SUC_CREACION.TabIndex = 16
        '
        'TXT_SUC_ENCARGADO
        '
        Me.TXT_SUC_ENCARGADO.Location = New System.Drawing.Point(136, 135)
        Me.TXT_SUC_ENCARGADO.Name = "TXT_SUC_ENCARGADO"
        Me.TXT_SUC_ENCARGADO.Size = New System.Drawing.Size(325, 23)
        Me.TXT_SUC_ENCARGADO.TabIndex = 17
        '
        'TXT_SUC_COLONIA
        '
        Me.TXT_SUC_COLONIA.Location = New System.Drawing.Point(115, 266)
        Me.TXT_SUC_COLONIA.Name = "TXT_SUC_COLONIA"
        Me.TXT_SUC_COLONIA.Size = New System.Drawing.Size(372, 23)
        Me.TXT_SUC_COLONIA.TabIndex = 18
        '
        'CB_SUC_ESTADO
        '
        Me.CB_SUC_ESTADO.FormattingEnabled = True
        Me.CB_SUC_ESTADO.Location = New System.Drawing.Point(115, 222)
        Me.CB_SUC_ESTADO.Name = "CB_SUC_ESTADO"
        Me.CB_SUC_ESTADO.Size = New System.Drawing.Size(183, 23)
        Me.CB_SUC_ESTADO.TabIndex = 19
        '
        'TXT_SUC_CALLE
        '
        Me.TXT_SUC_CALLE.Location = New System.Drawing.Point(115, 305)
        Me.TXT_SUC_CALLE.Name = "TXT_SUC_CALLE"
        Me.TXT_SUC_CALLE.Size = New System.Drawing.Size(372, 23)
        Me.TXT_SUC_CALLE.TabIndex = 20
        '
        'TXT_SUC_NUMERO
        '
        Me.TXT_SUC_NUMERO.Location = New System.Drawing.Point(581, 308)
        Me.TXT_SUC_NUMERO.Name = "TXT_SUC_NUMERO"
        Me.TXT_SUC_NUMERO.Size = New System.Drawing.Size(100, 23)
        Me.TXT_SUC_NUMERO.TabIndex = 21
        '
        'TXT_SUC_CODPOS
        '
        Me.TXT_SUC_CODPOS.Location = New System.Drawing.Point(630, 266)
        Me.TXT_SUC_CODPOS.Name = "TXT_SUC_CODPOS"
        Me.TXT_SUC_CODPOS.Size = New System.Drawing.Size(100, 23)
        Me.TXT_SUC_CODPOS.TabIndex = 22
        '
        'CB_SUC_MUNICIPIO
        '
        Me.CB_SUC_MUNICIPIO.FormattingEnabled = True
        Me.CB_SUC_MUNICIPIO.Location = New System.Drawing.Point(602, 222)
        Me.CB_SUC_MUNICIPIO.Name = "CB_SUC_MUNICIPIO"
        Me.CB_SUC_MUNICIPIO.Size = New System.Drawing.Size(183, 23)
        Me.CB_SUC_MUNICIPIO.TabIndex = 23
        '
        'FORM_SUCURSAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 456)
        Me.Controls.Add(Me.CB_SUC_MUNICIPIO)
        Me.Controls.Add(Me.TXT_SUC_CODPOS)
        Me.Controls.Add(Me.TXT_SUC_NUMERO)
        Me.Controls.Add(Me.TXT_SUC_CALLE)
        Me.Controls.Add(Me.CB_SUC_ESTADO)
        Me.Controls.Add(Me.TXT_SUC_COLONIA)
        Me.Controls.Add(Me.TXT_SUC_ENCARGADO)
        Me.Controls.Add(Me.DTP_SUC_CREACION)
        Me.Controls.Add(Me.TXT_SUC_NUM)
        Me.Controls.Add(Me.TXT_SUC_NOMBRE)
        Me.Controls.Add(Me.BTN_SUC_CARGA)
        Me.Controls.Add(Me.BTN_SUC_LISTA)
        Me.Controls.Add(Me.BTN_SUC_ACEPTAR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_SUCURSAL"
        Me.Text = "SUCURSAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BTN_SUC_ACEPTAR As Button
    Friend WithEvents BTN_SUC_LISTA As Button
    Friend WithEvents BTN_SUC_CARGA As Button
    Friend WithEvents TXT_SUC_NOMBRE As TextBox
    Friend WithEvents TXT_SUC_NUM As TextBox
    Friend WithEvents DTP_SUC_CREACION As DateTimePicker
    Friend WithEvents TXT_SUC_ENCARGADO As TextBox
    Friend WithEvents TXT_SUC_COLONIA As TextBox
    Friend WithEvents CB_SUC_ESTADO As ComboBox
    Friend WithEvents TXT_SUC_CALLE As TextBox
    Friend WithEvents TXT_SUC_NUMERO As TextBox
    Friend WithEvents TXT_SUC_CODPOS As TextBox
    Friend WithEvents CB_SUC_MUNICIPIO As ComboBox
End Class
