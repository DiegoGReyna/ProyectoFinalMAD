<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_LISTA_PRODUCTOS
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
        Me.LB_LISTA_PRODUCTOS = New System.Windows.Forms.ListBox()
        Me.BTN_LISTPROD_IMPRIMIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista Productos"
        '
        'LB_LISTA_PRODUCTOS
        '
        Me.LB_LISTA_PRODUCTOS.FormattingEnabled = True
        Me.LB_LISTA_PRODUCTOS.ItemHeight = 15
        Me.LB_LISTA_PRODUCTOS.Location = New System.Drawing.Point(64, 109)
        Me.LB_LISTA_PRODUCTOS.Name = "LB_LISTA_PRODUCTOS"
        Me.LB_LISTA_PRODUCTOS.Size = New System.Drawing.Size(393, 199)
        Me.LB_LISTA_PRODUCTOS.TabIndex = 1
        '
        'BTN_LISTPROD_IMPRIMIR
        '
        Me.BTN_LISTPROD_IMPRIMIR.Location = New System.Drawing.Point(210, 345)
        Me.BTN_LISTPROD_IMPRIMIR.Name = "BTN_LISTPROD_IMPRIMIR"
        Me.BTN_LISTPROD_IMPRIMIR.Size = New System.Drawing.Size(123, 60)
        Me.BTN_LISTPROD_IMPRIMIR.TabIndex = 2
        Me.BTN_LISTPROD_IMPRIMIR.Text = "IMPRIMIR"
        Me.BTN_LISTPROD_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'FORM_LISTA_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(537, 457)
        Me.Controls.Add(Me.BTN_LISTPROD_IMPRIMIR)
        Me.Controls.Add(Me.LB_LISTA_PRODUCTOS)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_LISTA_PRODUCTOS"
        Me.Text = "LISTA PRODUCTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LB_LISTA_PRODUCTOS As ListBox
    Friend WithEvents BTN_LISTPROD_IMPRIMIR As Button
End Class
