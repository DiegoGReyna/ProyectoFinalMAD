<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_INICIO_SESION_CLIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_INICIO_SESION_CLIENTE))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_ACEPTARCLIENTE = New System.Windows.Forms.Button()
        Me.BTN_REC_CONTRA_CLIENTE = New System.Windows.Forms.Button()
        Me.TXT_CORREO_CLIENTE = New System.Windows.Forms.TextBox()
        Me.TXT_CONTRACLIENTE = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LAB_SLOGAN = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'BTN_ACEPTARCLIENTE
        '
        Me.BTN_ACEPTARCLIENTE.Location = New System.Drawing.Point(331, 239)
        Me.BTN_ACEPTARCLIENTE.Name = "BTN_ACEPTARCLIENTE"
        Me.BTN_ACEPTARCLIENTE.Size = New System.Drawing.Size(112, 62)
        Me.BTN_ACEPTARCLIENTE.TabIndex = 2
        Me.BTN_ACEPTARCLIENTE.Text = "ACEPTAR"
        Me.BTN_ACEPTARCLIENTE.UseVisualStyleBackColor = True
        '
        'BTN_REC_CONTRA_CLIENTE
        '
        Me.BTN_REC_CONTRA_CLIENTE.Location = New System.Drawing.Point(291, 319)
        Me.BTN_REC_CONTRA_CLIENTE.Name = "BTN_REC_CONTRA_CLIENTE"
        Me.BTN_REC_CONTRA_CLIENTE.Size = New System.Drawing.Size(197, 62)
        Me.BTN_REC_CONTRA_CLIENTE.TabIndex = 3
        Me.BTN_REC_CONTRA_CLIENTE.Text = "RECORDAR CONTRASEÑA"
        Me.BTN_REC_CONTRA_CLIENTE.UseVisualStyleBackColor = True
        '
        'TXT_CORREO_CLIENTE
        '
        Me.TXT_CORREO_CLIENTE.Location = New System.Drawing.Point(213, 142)
        Me.TXT_CORREO_CLIENTE.Name = "TXT_CORREO_CLIENTE"
        Me.TXT_CORREO_CLIENTE.Size = New System.Drawing.Size(394, 23)
        Me.TXT_CORREO_CLIENTE.TabIndex = 4
        '
        'TXT_CONTRACLIENTE
        '
        Me.TXT_CONTRACLIENTE.Location = New System.Drawing.Point(213, 193)
        Me.TXT_CONTRACLIENTE.Name = "TXT_CONTRACLIENTE"
        Me.TXT_CONTRACLIENTE.Size = New System.Drawing.Size(202, 23)
        Me.TXT_CONTRACLIENTE.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(544, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LAB_SLOGAN
        '
        Me.LAB_SLOGAN.AutoSize = True
        Me.LAB_SLOGAN.Location = New System.Drawing.Point(246, 403)
        Me.LAB_SLOGAN.Name = "LAB_SLOGAN"
        Me.LAB_SLOGAN.Size = New System.Drawing.Size(294, 15)
        Me.LAB_SLOGAN.TabIndex = 7
        Me.LAB_SLOGAN.Text = "YOU HAVE NO IDEA WHAT´S IN-STORE FOR YOU!"
        '
        'FORM_INICIO_SESION_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(751, 427)
        Me.Controls.Add(Me.LAB_SLOGAN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TXT_CONTRACLIENTE)
        Me.Controls.Add(Me.TXT_CORREO_CLIENTE)
        Me.Controls.Add(Me.BTN_REC_CONTRA_CLIENTE)
        Me.Controls.Add(Me.BTN_ACEPTARCLIENTE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_INICIO_SESION_CLIENTE"
        Me.Text = "INICIO SESION CLIENTE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_ACEPTARCLIENTE As Button
    Friend WithEvents BTN_REC_CONTRA_CLIENTE As Button
    Friend WithEvents TXT_CORREO_CLIENTE As TextBox
    Friend WithEvents TXT_CONTRACLIENTE As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LAB_SLOGAN As Label
End Class
