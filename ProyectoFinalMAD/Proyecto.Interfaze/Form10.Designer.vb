<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_LISTA_SUCURSALES
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
        Me.LB_LISTA_SUCURSALES = New System.Windows.Forms.ListBox()
        Me.BTN_LISTASUC_IMPRIMIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista Sucursales"
        '
        'LB_LISTA_SUCURSALES
        '
        Me.LB_LISTA_SUCURSALES.FormattingEnabled = True
        Me.LB_LISTA_SUCURSALES.ItemHeight = 15
        Me.LB_LISTA_SUCURSALES.Location = New System.Drawing.Point(60, 98)
        Me.LB_LISTA_SUCURSALES.Name = "LB_LISTA_SUCURSALES"
        Me.LB_LISTA_SUCURSALES.Size = New System.Drawing.Size(355, 184)
        Me.LB_LISTA_SUCURSALES.TabIndex = 1
        '
        'BTN_LISTASUC_IMPRIMIR
        '
        Me.BTN_LISTASUC_IMPRIMIR.Location = New System.Drawing.Point(170, 313)
        Me.BTN_LISTASUC_IMPRIMIR.Name = "BTN_LISTASUC_IMPRIMIR"
        Me.BTN_LISTASUC_IMPRIMIR.Size = New System.Drawing.Size(122, 58)
        Me.BTN_LISTASUC_IMPRIMIR.TabIndex = 2
        Me.BTN_LISTASUC_IMPRIMIR.Text = "IMPRIMIR"
        Me.BTN_LISTASUC_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'FORM_LISTA_SUCURSALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 413)
        Me.Controls.Add(Me.BTN_LISTASUC_IMPRIMIR)
        Me.Controls.Add(Me.LB_LISTA_SUCURSALES)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_LISTA_SUCURSALES"
        Me.Text = "LISTA SUCURSALES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LB_LISTA_SUCURSALES As ListBox
    Friend WithEvents BTN_LISTASUC_IMPRIMIR As Button
End Class
