<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_INICIO_SESION_EMPLEADO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_INICIO_SESION_EMPLEADO))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_ACEPTAR_EMPLEADO = New System.Windows.Forms.Button()
        Me.BTN_REC_CONTRA_EMPLEADO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_USUARIO = New System.Windows.Forms.TextBox()
        Me.TXT_CON_EMPLEADO = New System.Windows.Forms.TextBox()
        Me.LAB_SLOGAN = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(544, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BTN_ACEPTAR_EMPLEADO
        '
        Me.BTN_ACEPTAR_EMPLEADO.Location = New System.Drawing.Point(320, 233)
        Me.BTN_ACEPTAR_EMPLEADO.Name = "BTN_ACEPTAR_EMPLEADO"
        Me.BTN_ACEPTAR_EMPLEADO.Size = New System.Drawing.Size(111, 47)
        Me.BTN_ACEPTAR_EMPLEADO.TabIndex = 8
        Me.BTN_ACEPTAR_EMPLEADO.Text = "ACEPTAR"
        Me.BTN_ACEPTAR_EMPLEADO.UseVisualStyleBackColor = True
        '
        'BTN_REC_CONTRA_EMPLEADO
        '
        Me.BTN_REC_CONTRA_EMPLEADO.Location = New System.Drawing.Point(275, 286)
        Me.BTN_REC_CONTRA_EMPLEADO.Name = "BTN_REC_CONTRA_EMPLEADO"
        Me.BTN_REC_CONTRA_EMPLEADO.Size = New System.Drawing.Size(189, 50)
        Me.BTN_REC_CONTRA_EMPLEADO.TabIndex = 9
        Me.BTN_REC_CONTRA_EMPLEADO.Text = "RECORDAR CONTRASEÑA"
        Me.BTN_REC_CONTRA_EMPLEADO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contraseña:"
        '
        'TXT_USUARIO
        '
        Me.TXT_USUARIO.Location = New System.Drawing.Point(308, 141)
        Me.TXT_USUARIO.Name = "TXT_USUARIO"
        Me.TXT_USUARIO.Size = New System.Drawing.Size(178, 23)
        Me.TXT_USUARIO.TabIndex = 12
        '
        'TXT_CON_EMPLEADO
        '
        Me.TXT_CON_EMPLEADO.Location = New System.Drawing.Point(308, 185)
        Me.TXT_CON_EMPLEADO.Name = "TXT_CON_EMPLEADO"
        Me.TXT_CON_EMPLEADO.Size = New System.Drawing.Size(178, 23)
        Me.TXT_CON_EMPLEADO.TabIndex = 13
        '
        'LAB_SLOGAN
        '
        Me.LAB_SLOGAN.AutoSize = True
        Me.LAB_SLOGAN.Location = New System.Drawing.Point(226, 359)
        Me.LAB_SLOGAN.Name = "LAB_SLOGAN"
        Me.LAB_SLOGAN.Size = New System.Drawing.Size(294, 15)
        Me.LAB_SLOGAN.TabIndex = 14
        Me.LAB_SLOGAN.Text = "YOU HAVE NO IDEA WHAT´S IN-STORE FOR YOU!"
        '
        'FORM_INICIO_SESION_EMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(750, 390)
        Me.Controls.Add(Me.LAB_SLOGAN)
        Me.Controls.Add(Me.TXT_CON_EMPLEADO)
        Me.Controls.Add(Me.TXT_USUARIO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_REC_CONTRA_EMPLEADO)
        Me.Controls.Add(Me.BTN_ACEPTAR_EMPLEADO)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_INICIO_SESION_EMPLEADO"
        Me.Text = "INICIO SESION EMPLEADO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_ACEPTAR_EMPLEADO As Button
    Friend WithEvents BTN_REC_CONTRA_EMPLEADO As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_USUARIO As TextBox
    Friend WithEvents TXT_CON_EMPLEADO As TextBox
    Friend WithEvents LAB_SLOGAN As Label
End Class
