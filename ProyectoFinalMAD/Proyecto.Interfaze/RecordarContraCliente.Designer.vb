<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordarContraCliente
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
        Me.Button_RecordarContra_Atras = New System.Windows.Forms.Button()
        Me.TXT_RecordarContra_Contrasena = New System.Windows.Forms.TextBox()
        Me.TXT_RecordarContra_CorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label_RecordarContra_Celular = New System.Windows.Forms.Label()
        Me.Label_RecordarContra_CorreoElectronico = New System.Windows.Forms.Label()
        Me.BTN_RecordarContra__ACEPTAR_ = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_RecordarContra_Atras
        '
        Me.Button_RecordarContra_Atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button_RecordarContra_Atras.Location = New System.Drawing.Point(12, 415)
        Me.Button_RecordarContra_Atras.Name = "Button_RecordarContra_Atras"
        Me.Button_RecordarContra_Atras.Size = New System.Drawing.Size(75, 23)
        Me.Button_RecordarContra_Atras.TabIndex = 39
        Me.Button_RecordarContra_Atras.Text = "Atras"
        Me.Button_RecordarContra_Atras.UseVisualStyleBackColor = True
        '
        'TXT_RecordarContra_Contrasena
        '
        Me.TXT_RecordarContra_Contrasena.Location = New System.Drawing.Point(341, 202)
        Me.TXT_RecordarContra_Contrasena.Name = "TXT_RecordarContra_Contrasena"
        Me.TXT_RecordarContra_Contrasena.Size = New System.Drawing.Size(211, 20)
        Me.TXT_RecordarContra_Contrasena.TabIndex = 38
        '
        'TXT_RecordarContra_CorreoElectronico
        '
        Me.TXT_RecordarContra_CorreoElectronico.Location = New System.Drawing.Point(341, 158)
        Me.TXT_RecordarContra_CorreoElectronico.Name = "TXT_RecordarContra_CorreoElectronico"
        Me.TXT_RecordarContra_CorreoElectronico.Size = New System.Drawing.Size(211, 20)
        Me.TXT_RecordarContra_CorreoElectronico.TabIndex = 37
        '
        'Label_RecordarContra_Celular
        '
        Me.Label_RecordarContra_Celular.AutoSize = True
        Me.Label_RecordarContra_Celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_RecordarContra_Celular.Location = New System.Drawing.Point(224, 197)
        Me.Label_RecordarContra_Celular.Name = "Label_RecordarContra_Celular"
        Me.Label_RecordarContra_Celular.Size = New System.Drawing.Size(79, 24)
        Me.Label_RecordarContra_Celular.TabIndex = 36
        Me.Label_RecordarContra_Celular.Text = "Celular: "
        '
        'Label_RecordarContra_CorreoElectronico
        '
        Me.Label_RecordarContra_CorreoElectronico.AutoSize = True
        Me.Label_RecordarContra_CorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label_RecordarContra_CorreoElectronico.Location = New System.Drawing.Point(161, 154)
        Me.Label_RecordarContra_CorreoElectronico.Name = "Label_RecordarContra_CorreoElectronico"
        Me.Label_RecordarContra_CorreoElectronico.Size = New System.Drawing.Size(178, 24)
        Me.Label_RecordarContra_CorreoElectronico.TabIndex = 35
        Me.Label_RecordarContra_CorreoElectronico.Text = "Correo Electronico: "
        '
        'BTN_RecordarContra__ACEPTAR_
        '
        Me.BTN_RecordarContra__ACEPTAR_.Location = New System.Drawing.Point(394, 243)
        Me.BTN_RecordarContra__ACEPTAR_.Name = "BTN_RecordarContra__ACEPTAR_"
        Me.BTN_RecordarContra__ACEPTAR_.Size = New System.Drawing.Size(111, 47)
        Me.BTN_RecordarContra__ACEPTAR_.TabIndex = 34
        Me.BTN_RecordarContra__ACEPTAR_.Text = "ACEPTAR"
        Me.BTN_RecordarContra__ACEPTAR_.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 31)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Recordar contraseña cliente"
        '
        'RecordarContraCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_RecordarContra_Atras)
        Me.Controls.Add(Me.TXT_RecordarContra_Contrasena)
        Me.Controls.Add(Me.TXT_RecordarContra_CorreoElectronico)
        Me.Controls.Add(Me.Label_RecordarContra_Celular)
        Me.Controls.Add(Me.Label_RecordarContra_CorreoElectronico)
        Me.Controls.Add(Me.BTN_RecordarContra__ACEPTAR_)
        Me.Name = "RecordarContraCliente"
        Me.Text = "Recordar contrasena cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_RecordarContra_Atras As Button
    Friend WithEvents TXT_RecordarContra_Contrasena As TextBox
    Friend WithEvents TXT_RecordarContra_CorreoElectronico As TextBox
    Friend WithEvents Label_RecordarContra_Celular As Label
    Friend WithEvents Label_RecordarContra_CorreoElectronico As Label
    Friend WithEvents BTN_RecordarContra__ACEPTAR_ As Button
    Friend WithEvents Label1 As Label
End Class
