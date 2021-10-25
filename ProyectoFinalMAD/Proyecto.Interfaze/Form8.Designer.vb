<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_HORARIO
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
        Me.TXT_HORARIO_HORAS = New System.Windows.Forms.TextBox()
        Me.DTP_HORARIO_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.DTP_HORARIO_ENTRADA = New System.Windows.Forms.DateTimePicker()
        Me.DTP_HORARIO_SALIDA = New System.Windows.Forms.DateTimePicker()
        Me.LBL_HORARIO_EMPLEADO = New System.Windows.Forms.Label()
        Me.BTN_HORARIO_ACEPTAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(66, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hora Entrada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora Salida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Horas Trabajadas:"
        '
        'TXT_HORARIO_HORAS
        '
        Me.TXT_HORARIO_HORAS.Location = New System.Drawing.Point(198, 220)
        Me.TXT_HORARIO_HORAS.Name = "TXT_HORARIO_HORAS"
        Me.TXT_HORARIO_HORAS.Size = New System.Drawing.Size(100, 23)
        Me.TXT_HORARIO_HORAS.TabIndex = 5
        '
        'DTP_HORARIO_FECHA
        '
        Me.DTP_HORARIO_FECHA.Location = New System.Drawing.Point(122, 93)
        Me.DTP_HORARIO_FECHA.Name = "DTP_HORARIO_FECHA"
        Me.DTP_HORARIO_FECHA.Size = New System.Drawing.Size(303, 23)
        Me.DTP_HORARIO_FECHA.TabIndex = 6
        '
        'DTP_HORARIO_ENTRADA
        '
        Me.DTP_HORARIO_ENTRADA.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_HORARIO_ENTRADA.Location = New System.Drawing.Point(170, 135)
        Me.DTP_HORARIO_ENTRADA.Name = "DTP_HORARIO_ENTRADA"
        Me.DTP_HORARIO_ENTRADA.Size = New System.Drawing.Size(146, 23)
        Me.DTP_HORARIO_ENTRADA.TabIndex = 7
        '
        'DTP_HORARIO_SALIDA
        '
        Me.DTP_HORARIO_SALIDA.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_HORARIO_SALIDA.Location = New System.Drawing.Point(170, 179)
        Me.DTP_HORARIO_SALIDA.Name = "DTP_HORARIO_SALIDA"
        Me.DTP_HORARIO_SALIDA.Size = New System.Drawing.Size(146, 23)
        Me.DTP_HORARIO_SALIDA.TabIndex = 8
        '
        'LBL_HORARIO_EMPLEADO
        '
        Me.LBL_HORARIO_EMPLEADO.AutoSize = True
        Me.LBL_HORARIO_EMPLEADO.Location = New System.Drawing.Point(137, 49)
        Me.LBL_HORARIO_EMPLEADO.Name = "LBL_HORARIO_EMPLEADO"
        Me.LBL_HORARIO_EMPLEADO.Size = New System.Drawing.Size(49, 15)
        Me.LBL_HORARIO_EMPLEADO.TabIndex = 9
        Me.LBL_HORARIO_EMPLEADO.Text = "Label6"
        '
        'BTN_HORARIO_ACEPTAR
        '
        Me.BTN_HORARIO_ACEPTAR.Location = New System.Drawing.Point(193, 280)
        Me.BTN_HORARIO_ACEPTAR.Name = "BTN_HORARIO_ACEPTAR"
        Me.BTN_HORARIO_ACEPTAR.Size = New System.Drawing.Size(105, 55)
        Me.BTN_HORARIO_ACEPTAR.TabIndex = 10
        Me.BTN_HORARIO_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_HORARIO_ACEPTAR.UseVisualStyleBackColor = True
        '
        'FORM_HORARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 370)
        Me.Controls.Add(Me.BTN_HORARIO_ACEPTAR)
        Me.Controls.Add(Me.LBL_HORARIO_EMPLEADO)
        Me.Controls.Add(Me.DTP_HORARIO_SALIDA)
        Me.Controls.Add(Me.DTP_HORARIO_ENTRADA)
        Me.Controls.Add(Me.DTP_HORARIO_FECHA)
        Me.Controls.Add(Me.TXT_HORARIO_HORAS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_HORARIO"
        Me.Text = "HORARIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_HORARIO_HORAS As TextBox
    Friend WithEvents DTP_HORARIO_FECHA As DateTimePicker
    Friend WithEvents DTP_HORARIO_ENTRADA As DateTimePicker
    Friend WithEvents DTP_HORARIO_SALIDA As DateTimePicker
    Friend WithEvents LBL_HORARIO_EMPLEADO As Label
    Friend WithEvents BTN_HORARIO_ACEPTAR As Button
End Class
