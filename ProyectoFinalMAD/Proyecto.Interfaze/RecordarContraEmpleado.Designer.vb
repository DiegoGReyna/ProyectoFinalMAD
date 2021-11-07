<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordarContraEmpleado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_RecordarContraEmpleado_Atras = New System.Windows.Forms.Button()
        Me.TXT_RecordarContraEmpleado_Contrasena = New System.Windows.Forms.TextBox()
        Me.TXT_RecordarContraEmpleado_CorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label_RecordarContra_Celular = New System.Windows.Forms.Label()
        Me.Label_RecordarContra_CorreoElectronico = New System.Windows.Forms.Label()
        Me.BTN_RecordarContraEmpleado_ACEPTAR_ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 31)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Recordar contraseña empleado"
        '
        'Button_RecordarContraEmpleado_Atras
        '
        Me.Button_RecordarContraEmpleado_Atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button_RecordarContraEmpleado_Atras.Location = New System.Drawing.Point(9, 406)
        Me.Button_RecordarContraEmpleado_Atras.Name = "Button_RecordarContraEmpleado_Atras"
        Me.Button_RecordarContraEmpleado_Atras.Size = New System.Drawing.Size(75, 23)
        Me.Button_RecordarContraEmpleado_Atras.TabIndex = 46
        Me.Button_RecordarContraEmpleado_Atras.Text = "Atras"
        Me.Button_RecordarContraEmpleado_Atras.UseVisualStyleBackColor = True
        '
        'TXT_RecordarContraEmpleado_Contrasena
        '
        Me.TXT_RecordarContraEmpleado_Contrasena.Location = New System.Drawing.Point(304, 195)
        Me.TXT_RecordarContraEmpleado_Contrasena.Name = "TXT_RecordarContraEmpleado_Contrasena"
        Me.TXT_RecordarContraEmpleado_Contrasena.Size = New System.Drawing.Size(211, 20)
        Me.TXT_RecordarContraEmpleado_Contrasena.TabIndex = 45
        '
        'TXT_RecordarContraEmpleado_CorreoElectronico
        '
        Me.TXT_RecordarContraEmpleado_CorreoElectronico.Location = New System.Drawing.Point(304, 151)
        Me.TXT_RecordarContraEmpleado_CorreoElectronico.Name = "TXT_RecordarContraEmpleado_CorreoElectronico"
        Me.TXT_RecordarContraEmpleado_CorreoElectronico.Size = New System.Drawing.Size(211, 20)
        Me.TXT_RecordarContraEmpleado_CorreoElectronico.TabIndex = 44
        '
        'Label_RecordarContra_Celular
        '
        Me.Label_RecordarContra_Celular.AutoSize = True
        Me.Label_RecordarContra_Celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_RecordarContra_Celular.Location = New System.Drawing.Point(213, 190)
        Me.Label_RecordarContra_Celular.Name = "Label_RecordarContra_Celular"
        Me.Label_RecordarContra_Celular.Size = New System.Drawing.Size(58, 24)
        Me.Label_RecordarContra_Celular.TabIndex = 43
        Me.Label_RecordarContra_Celular.Text = "RFC: "
        '
        'Label_RecordarContra_CorreoElectronico
        '
        Me.Label_RecordarContra_CorreoElectronico.AutoSize = True
        Me.Label_RecordarContra_CorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_RecordarContra_CorreoElectronico.Location = New System.Drawing.Point(197, 146)
        Me.Label_RecordarContra_CorreoElectronico.Name = "Label_RecordarContra_CorreoElectronico"
        Me.Label_RecordarContra_CorreoElectronico.Size = New System.Drawing.Size(84, 24)
        Me.Label_RecordarContra_CorreoElectronico.TabIndex = 42
        Me.Label_RecordarContra_CorreoElectronico.Text = "Usuario: "
        '
        'BTN_RecordarContraEmpleado_ACEPTAR_
        '
        Me.BTN_RecordarContraEmpleado_ACEPTAR_.Location = New System.Drawing.Point(345, 236)
        Me.BTN_RecordarContraEmpleado_ACEPTAR_.Name = "BTN_RecordarContraEmpleado_ACEPTAR_"
        Me.BTN_RecordarContraEmpleado_ACEPTAR_.Size = New System.Drawing.Size(111, 47)
        Me.BTN_RecordarContraEmpleado_ACEPTAR_.TabIndex = 41
        Me.BTN_RecordarContraEmpleado_ACEPTAR_.Text = "ACEPTAR"
        Me.BTN_RecordarContraEmpleado_ACEPTAR_.UseVisualStyleBackColor = True
        '
        'RecordarContraEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_RecordarContraEmpleado_Atras)
        Me.Controls.Add(Me.TXT_RecordarContraEmpleado_Contrasena)
        Me.Controls.Add(Me.TXT_RecordarContraEmpleado_CorreoElectronico)
        Me.Controls.Add(Me.Label_RecordarContra_Celular)
        Me.Controls.Add(Me.Label_RecordarContra_CorreoElectronico)
        Me.Controls.Add(Me.BTN_RecordarContraEmpleado_ACEPTAR_)
        Me.Name = "RecordarContraEmpleado"
        Me.Text = "Recordar contraseña empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_RecordarContraEmpleado_Atras As Button
    Friend WithEvents TXT_RecordarContraEmpleado_Contrasena As TextBox
    Friend WithEvents TXT_RecordarContraEmpleado_CorreoElectronico As TextBox
    Friend WithEvents Label_RecordarContra_Celular As Label
    Friend WithEvents Label_RecordarContra_CorreoElectronico As Label
    Friend WithEvents BTN_RecordarContraEmpleado_ACEPTAR_ As Button
End Class
