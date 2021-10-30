<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_LISTA_EMPLEADO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_LISTEMPLEADOS_IMPRIMIR = New System.Windows.Forms.Button()
        Me.DataGridView_ListaEmpleados = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Seleccionar = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SeleccionarEmpleado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView_ListaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista Empleados"
        '
        'BTN_LISTEMPLEADOS_IMPRIMIR
        '
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Location = New System.Drawing.Point(10, 437)
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Name = "BTN_LISTEMPLEADOS_IMPRIMIR"
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Size = New System.Drawing.Size(120, 61)
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.TabIndex = 2
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.Text = "IMPRIMIR"
        Me.BTN_LISTEMPLEADOS_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'DataGridView_ListaEmpleados
        '
        Me.DataGridView_ListaEmpleados.AllowUserToAddRows = False
        Me.DataGridView_ListaEmpleados.AllowUserToDeleteRows = False
        Me.DataGridView_ListaEmpleados.AllowUserToOrderColumns = True
        Me.DataGridView_ListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ListaEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeleccionarEmpleado})
        Me.DataGridView_ListaEmpleados.Location = New System.Drawing.Point(10, 59)
        Me.DataGridView_ListaEmpleados.Name = "DataGridView_ListaEmpleados"
        Me.DataGridView_ListaEmpleados.ReadOnly = True
        Me.DataGridView_ListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_ListaEmpleados.Size = New System.Drawing.Size(1023, 329)
        Me.DataGridView_ListaEmpleados.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(22, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1061, 532)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Seleccionar)
        Me.TabPage1.Controls.Add(Me.DataGridView_ListaEmpleados)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BTN_LISTEMPLEADOS_IMPRIMIR)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1053, 504)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 72)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Seleccionar
        '
        Me.Seleccionar.AutoSize = True
        Me.Seleccionar.Location = New System.Drawing.Point(10, 398)
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(89, 19)
        Me.Seleccionar.TabIndex = 4
        Me.Seleccionar.Text = "CheckBox1"
        Me.Seleccionar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(372, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SeleccionarEmpleado
        '
        Me.SeleccionarEmpleado.HeaderText = "Seleccionar"
        Me.SeleccionarEmpleado.Name = "SeleccionarEmpleado"
        Me.SeleccionarEmpleado.ReadOnly = True
        '
        'FORM_LISTA_EMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 574)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FORM_LISTA_EMPLEADO"
        Me.Text = "LISTA EMPLEADO"
        CType(Me.DataGridView_ListaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_LISTEMPLEADOS_IMPRIMIR As Button
    Friend WithEvents DataGridView_ListaEmpleados As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Seleccionar As CheckBox
    Friend WithEvents SeleccionarEmpleado As DataGridViewCheckBoxColumn
End Class
