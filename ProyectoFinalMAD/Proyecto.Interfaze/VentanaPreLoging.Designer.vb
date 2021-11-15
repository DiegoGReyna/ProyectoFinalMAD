<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_INICIO_SESION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_INICIO_SESION))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CLIENTE = New System.Windows.Forms.Button()
        Me.BTN_EMPLEADO = New System.Windows.Forms.Button()
        Me.LAB_SLOGAN = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(80, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BTN_CLIENTE
        '
        Me.BTN_CLIENTE.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BTN_CLIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BTN_CLIENTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_CLIENTE.Location = New System.Drawing.Point(210, 190)
        Me.BTN_CLIENTE.Name = "BTN_CLIENTE"
        Me.BTN_CLIENTE.Size = New System.Drawing.Size(127, 39)
        Me.BTN_CLIENTE.TabIndex = 1
        Me.BTN_CLIENTE.Text = "CLIENTE"
        Me.BTN_CLIENTE.UseVisualStyleBackColor = False
        '
        'BTN_EMPLEADO
        '
        Me.BTN_EMPLEADO.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BTN_EMPLEADO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_EMPLEADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BTN_EMPLEADO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_EMPLEADO.Location = New System.Drawing.Point(417, 190)
        Me.BTN_EMPLEADO.Name = "BTN_EMPLEADO"
        Me.BTN_EMPLEADO.Size = New System.Drawing.Size(139, 39)
        Me.BTN_EMPLEADO.TabIndex = 2
        Me.BTN_EMPLEADO.Text = "EMPLEADO"
        Me.BTN_EMPLEADO.UseVisualStyleBackColor = False
        '
        'LAB_SLOGAN
        '
        Me.LAB_SLOGAN.AutoSize = True
        Me.LAB_SLOGAN.Location = New System.Drawing.Point(224, 255)
        Me.LAB_SLOGAN.Name = "LAB_SLOGAN"
        Me.LAB_SLOGAN.Size = New System.Drawing.Size(294, 15)
        Me.LAB_SLOGAN.TabIndex = 3
        Me.LAB_SLOGAN.Text = "YOU HAVE NO IDEA WHAT´S IN-STORE FOR YOU!"
        '
        'FORM_INICIO_SESION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 376)
        Me.Controls.Add(Me.LAB_SLOGAN)
        Me.Controls.Add(Me.BTN_EMPLEADO)
        Me.Controls.Add(Me.BTN_CLIENTE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_INICIO_SESION"
        Me.Text = "INICIO SESION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_CLIENTE As Button
    Friend WithEvents BTN_EMPLEADO As Button
    Friend WithEvents LAB_SLOGAN As Label
End Class
