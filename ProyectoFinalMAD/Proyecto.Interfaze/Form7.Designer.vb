<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_COMPRAS
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
        Me.TXT_COMPRA_PROD = New System.Windows.Forms.TextBox()
        Me.CB_COMPRA_ESTADOPAGO = New System.Windows.Forms.ComboBox()
        Me.DTP_COMPRA_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.CB_COMPRA_METODO = New System.Windows.Forms.ComboBox()
        Me.CB_COMPRA_EMVIO = New System.Windows.Forms.ComboBox()
        Me.LBL_COMPRA_TOTALPAGAR = New System.Windows.Forms.Label()
        Me.LBL_COMPRA_TOTALAHORRO = New System.Windows.Forms.Label()
        Me.BTN_COMPRA_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_COMPRA_RECIBO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado Pago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Metodo Pago:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total a Pagar:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Ahorrado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Forma Envio:"
        '
        'TXT_COMPRA_PROD
        '
        Me.TXT_COMPRA_PROD.Location = New System.Drawing.Point(174, 43)
        Me.TXT_COMPRA_PROD.Name = "TXT_COMPRA_PROD"
        Me.TXT_COMPRA_PROD.Size = New System.Drawing.Size(229, 23)
        Me.TXT_COMPRA_PROD.TabIndex = 7
        '
        'CB_COMPRA_ESTADOPAGO
        '
        Me.CB_COMPRA_ESTADOPAGO.FormattingEnabled = True
        Me.CB_COMPRA_ESTADOPAGO.Location = New System.Drawing.Point(174, 128)
        Me.CB_COMPRA_ESTADOPAGO.Name = "CB_COMPRA_ESTADOPAGO"
        Me.CB_COMPRA_ESTADOPAGO.Size = New System.Drawing.Size(172, 23)
        Me.CB_COMPRA_ESTADOPAGO.TabIndex = 8
        '
        'DTP_COMPRA_FECHA
        '
        Me.DTP_COMPRA_FECHA.Location = New System.Drawing.Point(174, 87)
        Me.DTP_COMPRA_FECHA.Name = "DTP_COMPRA_FECHA"
        Me.DTP_COMPRA_FECHA.Size = New System.Drawing.Size(289, 23)
        Me.DTP_COMPRA_FECHA.TabIndex = 9
        '
        'CB_COMPRA_METODO
        '
        Me.CB_COMPRA_METODO.FormattingEnabled = True
        Me.CB_COMPRA_METODO.Location = New System.Drawing.Point(174, 168)
        Me.CB_COMPRA_METODO.Name = "CB_COMPRA_METODO"
        Me.CB_COMPRA_METODO.Size = New System.Drawing.Size(172, 23)
        Me.CB_COMPRA_METODO.TabIndex = 10
        '
        'CB_COMPRA_EMVIO
        '
        Me.CB_COMPRA_EMVIO.FormattingEnabled = True
        Me.CB_COMPRA_EMVIO.Location = New System.Drawing.Point(174, 212)
        Me.CB_COMPRA_EMVIO.Name = "CB_COMPRA_EMVIO"
        Me.CB_COMPRA_EMVIO.Size = New System.Drawing.Size(172, 23)
        Me.CB_COMPRA_EMVIO.TabIndex = 11
        '
        'LBL_COMPRA_TOTALPAGAR
        '
        Me.LBL_COMPRA_TOTALPAGAR.AutoSize = True
        Me.LBL_COMPRA_TOTALPAGAR.Location = New System.Drawing.Point(171, 264)
        Me.LBL_COMPRA_TOTALPAGAR.Name = "LBL_COMPRA_TOTALPAGAR"
        Me.LBL_COMPRA_TOTALPAGAR.Size = New System.Drawing.Size(49, 15)
        Me.LBL_COMPRA_TOTALPAGAR.TabIndex = 12
        Me.LBL_COMPRA_TOTALPAGAR.Text = "Label8"
        '
        'LBL_COMPRA_TOTALAHORRO
        '
        Me.LBL_COMPRA_TOTALAHORRO.AutoSize = True
        Me.LBL_COMPRA_TOTALAHORRO.Location = New System.Drawing.Point(171, 309)
        Me.LBL_COMPRA_TOTALAHORRO.Name = "LBL_COMPRA_TOTALAHORRO"
        Me.LBL_COMPRA_TOTALAHORRO.Size = New System.Drawing.Size(49, 15)
        Me.LBL_COMPRA_TOTALAHORRO.TabIndex = 13
        Me.LBL_COMPRA_TOTALAHORRO.Text = "Label9"
        '
        'BTN_COMPRA_ACEPTAR
        '
        Me.BTN_COMPRA_ACEPTAR.Location = New System.Drawing.Point(148, 359)
        Me.BTN_COMPRA_ACEPTAR.Name = "BTN_COMPRA_ACEPTAR"
        Me.BTN_COMPRA_ACEPTAR.Size = New System.Drawing.Size(115, 59)
        Me.BTN_COMPRA_ACEPTAR.TabIndex = 14
        Me.BTN_COMPRA_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_COMPRA_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_COMPRA_RECIBO
        '
        Me.BTN_COMPRA_RECIBO.Location = New System.Drawing.Point(288, 359)
        Me.BTN_COMPRA_RECIBO.Name = "BTN_COMPRA_RECIBO"
        Me.BTN_COMPRA_RECIBO.Size = New System.Drawing.Size(115, 59)
        Me.BTN_COMPRA_RECIBO.TabIndex = 15
        Me.BTN_COMPRA_RECIBO.Text = "RECIBO"
        Me.BTN_COMPRA_RECIBO.UseVisualStyleBackColor = True
        '
        'FORM_COMPRAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(546, 454)
        Me.Controls.Add(Me.BTN_COMPRA_RECIBO)
        Me.Controls.Add(Me.BTN_COMPRA_ACEPTAR)
        Me.Controls.Add(Me.LBL_COMPRA_TOTALAHORRO)
        Me.Controls.Add(Me.LBL_COMPRA_TOTALPAGAR)
        Me.Controls.Add(Me.CB_COMPRA_EMVIO)
        Me.Controls.Add(Me.CB_COMPRA_METODO)
        Me.Controls.Add(Me.DTP_COMPRA_FECHA)
        Me.Controls.Add(Me.CB_COMPRA_ESTADOPAGO)
        Me.Controls.Add(Me.TXT_COMPRA_PROD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_COMPRAS"
        Me.Text = "COMPRAS"
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
    Friend WithEvents TXT_COMPRA_PROD As TextBox
    Friend WithEvents CB_COMPRA_ESTADOPAGO As ComboBox
    Friend WithEvents DTP_COMPRA_FECHA As DateTimePicker
    Friend WithEvents CB_COMPRA_METODO As ComboBox
    Friend WithEvents CB_COMPRA_EMVIO As ComboBox
    Friend WithEvents LBL_COMPRA_TOTALPAGAR As Label
    Friend WithEvents LBL_COMPRA_TOTALAHORRO As Label
    Friend WithEvents BTN_COMPRA_ACEPTAR As Button
    Friend WithEvents BTN_COMPRA_RECIBO As Button
End Class
