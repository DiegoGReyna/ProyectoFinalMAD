<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_PRODUCTO
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
        Me.TXT_PROD_COD_PROD = New System.Windows.Forms.TextBox()
        Me.CB_PROD_CATEGORIA_PROD = New System.Windows.Forms.ComboBox()
        Me.CB_PROD_DESCUENTO = New System.Windows.Forms.ComboBox()
        Me.TXT_PROD_PRECIO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_PROD_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.BTN_PROD_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_PROD_LISTA = New System.Windows.Forms.Button()
        Me.BTN_PROD_CARGA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Categoria Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descuento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripcion:"
        '
        'TXT_PROD_COD_PROD
        '
        Me.TXT_PROD_COD_PROD.Location = New System.Drawing.Point(164, 90)
        Me.TXT_PROD_COD_PROD.Name = "TXT_PROD_COD_PROD"
        Me.TXT_PROD_COD_PROD.Size = New System.Drawing.Size(237, 20)
        Me.TXT_PROD_COD_PROD.TabIndex = 6
        '
        'CB_PROD_CATEGORIA_PROD
        '
        Me.CB_PROD_CATEGORIA_PROD.FormattingEnabled = True
        Me.CB_PROD_CATEGORIA_PROD.Location = New System.Drawing.Point(164, 124)
        Me.CB_PROD_CATEGORIA_PROD.Name = "CB_PROD_CATEGORIA_PROD"
        Me.CB_PROD_CATEGORIA_PROD.Size = New System.Drawing.Size(224, 21)
        Me.CB_PROD_CATEGORIA_PROD.TabIndex = 7
        '
        'CB_PROD_DESCUENTO
        '
        Me.CB_PROD_DESCUENTO.FormattingEnabled = True
        Me.CB_PROD_DESCUENTO.Location = New System.Drawing.Point(164, 199)
        Me.CB_PROD_DESCUENTO.Name = "CB_PROD_DESCUENTO"
        Me.CB_PROD_DESCUENTO.Size = New System.Drawing.Size(121, 21)
        Me.CB_PROD_DESCUENTO.TabIndex = 8
        '
        'TXT_PROD_PRECIO
        '
        Me.TXT_PROD_PRECIO.Location = New System.Drawing.Point(164, 160)
        Me.TXT_PROD_PRECIO.Name = "TXT_PROD_PRECIO"
        Me.TXT_PROD_PRECIO.Size = New System.Drawing.Size(116, 20)
        Me.TXT_PROD_PRECIO.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Label7"
        '
        'TXT_PROD_DESCRIPCION
        '
        Me.TXT_PROD_DESCRIPCION.Location = New System.Drawing.Point(163, 241)
        Me.TXT_PROD_DESCRIPCION.Name = "TXT_PROD_DESCRIPCION"
        Me.TXT_PROD_DESCRIPCION.Size = New System.Drawing.Size(238, 20)
        Me.TXT_PROD_DESCRIPCION.TabIndex = 11
        '
        'BTN_PROD_ACEPTAR
        '
        Me.BTN_PROD_ACEPTAR.Location = New System.Drawing.Point(161, 294)
        Me.BTN_PROD_ACEPTAR.Name = "BTN_PROD_ACEPTAR"
        Me.BTN_PROD_ACEPTAR.Size = New System.Drawing.Size(93, 49)
        Me.BTN_PROD_ACEPTAR.TabIndex = 12
        Me.BTN_PROD_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_PROD_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_LISTA
        '
        Me.BTN_PROD_LISTA.Location = New System.Drawing.Point(282, 294)
        Me.BTN_PROD_LISTA.Name = "BTN_PROD_LISTA"
        Me.BTN_PROD_LISTA.Size = New System.Drawing.Size(93, 49)
        Me.BTN_PROD_LISTA.TabIndex = 13
        Me.BTN_PROD_LISTA.Text = "LISTA"
        Me.BTN_PROD_LISTA.UseVisualStyleBackColor = True
        '
        'BTN_PROD_CARGA
        '
        Me.BTN_PROD_CARGA.Location = New System.Drawing.Point(398, 294)
        Me.BTN_PROD_CARGA.Name = "BTN_PROD_CARGA"
        Me.BTN_PROD_CARGA.Size = New System.Drawing.Size(93, 49)
        Me.BTN_PROD_CARGA.TabIndex = 14
        Me.BTN_PROD_CARGA.Text = "CARGA"
        Me.BTN_PROD_CARGA.UseVisualStyleBackColor = True
        '
        'FORM_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 388)
        Me.Controls.Add(Me.BTN_PROD_CARGA)
        Me.Controls.Add(Me.BTN_PROD_LISTA)
        Me.Controls.Add(Me.BTN_PROD_ACEPTAR)
        Me.Controls.Add(Me.TXT_PROD_DESCRIPCION)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_PROD_PRECIO)
        Me.Controls.Add(Me.CB_PROD_DESCUENTO)
        Me.Controls.Add(Me.CB_PROD_CATEGORIA_PROD)
        Me.Controls.Add(Me.TXT_PROD_COD_PROD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORM_PRODUCTO"
        Me.Text = "PRODUCTO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_PROD_COD_PROD As TextBox
    Friend WithEvents CB_PROD_CATEGORIA_PROD As ComboBox
    Friend WithEvents CB_PROD_DESCUENTO As ComboBox
    Friend WithEvents TXT_PROD_PRECIO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_PROD_DESCRIPCION As TextBox
    Friend WithEvents BTN_PROD_ACEPTAR As Button
    Friend WithEvents BTN_PROD_LISTA As Button
    Friend WithEvents BTN_PROD_CARGA As Button
End Class
