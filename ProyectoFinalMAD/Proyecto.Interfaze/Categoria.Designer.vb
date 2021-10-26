<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria
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
        Me.TabControlGeneral_Categoria = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_Categoria_Eliminar = New System.Windows.Forms.Button()
        Me.CheckBox_Categoria_SeleccionarCategoria = New System.Windows.Forms.CheckBox()
        Me.TextBox_Categoria_A_Buscar = New System.Windows.Forms.TextBox()
        Me.Button_BuscarCategoria = New System.Windows.Forms.Button()
        Me.Label_TotalCategorias = New System.Windows.Forms.Label()
        Me.DataGridView_ListaCategoria = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button_Categoria_Editar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_categoria_CargaMasiva = New System.Windows.Forms.Button()
        Me.Button_Insertar_Categoria = New System.Windows.Forms.Button()
        Me.Button_Categoria_Cancelar = New System.Windows.Forms.Button()
        Me.Label_Categoria_Nombre = New System.Windows.Forms.Label()
        Me.TextBox_Categoria_IDcategoria = New System.Windows.Forms.TextBox()
        Me.TextBox_Categoria_Nombre = New System.Windows.Forms.TextBox()
        Me.TabControlGeneral_Categoria.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView_ListaCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlGeneral_Categoria
        '
        Me.TabControlGeneral_Categoria.Controls.Add(Me.TabPage1)
        Me.TabControlGeneral_Categoria.Controls.Add(Me.TabPage2)
        Me.TabControlGeneral_Categoria.Location = New System.Drawing.Point(12, 12)
        Me.TabControlGeneral_Categoria.Name = "TabControlGeneral_Categoria"
        Me.TabControlGeneral_Categoria.SelectedIndex = 0
        Me.TabControlGeneral_Categoria.Size = New System.Drawing.Size(810, 427)
        Me.TabControlGeneral_Categoria.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Button_Categoria_Eliminar)
        Me.TabPage1.Controls.Add(Me.CheckBox_Categoria_SeleccionarCategoria)
        Me.TabPage1.Controls.Add(Me.TextBox_Categoria_A_Buscar)
        Me.TabPage1.Controls.Add(Me.Button_BuscarCategoria)
        Me.TabPage1.Controls.Add(Me.Label_TotalCategorias)
        Me.TabPage1.Controls.Add(Me.DataGridView_ListaCategoria)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(802, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Categorias"
        '
        'Button_Categoria_Eliminar
        '
        Me.Button_Categoria_Eliminar.Location = New System.Drawing.Point(128, 352)
        Me.Button_Categoria_Eliminar.Name = "Button_Categoria_Eliminar"
        Me.Button_Categoria_Eliminar.Size = New System.Drawing.Size(103, 20)
        Me.Button_Categoria_Eliminar.TabIndex = 5
        Me.Button_Categoria_Eliminar.Text = "Eliminar"
        Me.Button_Categoria_Eliminar.UseVisualStyleBackColor = True
        Me.Button_Categoria_Eliminar.Visible = False
        '
        'CheckBox_Categoria_SeleccionarCategoria
        '
        Me.CheckBox_Categoria_SeleccionarCategoria.AutoSize = True
        Me.CheckBox_Categoria_SeleccionarCategoria.Location = New System.Drawing.Point(17, 355)
        Me.CheckBox_Categoria_SeleccionarCategoria.Name = "CheckBox_Categoria_SeleccionarCategoria"
        Me.CheckBox_Categoria_SeleccionarCategoria.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox_Categoria_SeleccionarCategoria.TabIndex = 4
        Me.CheckBox_Categoria_SeleccionarCategoria.Text = "Seleccionar"
        Me.CheckBox_Categoria_SeleccionarCategoria.UseVisualStyleBackColor = True
        '
        'TextBox_Categoria_A_Buscar
        '
        Me.TextBox_Categoria_A_Buscar.Location = New System.Drawing.Point(257, 23)
        Me.TextBox_Categoria_A_Buscar.Name = "TextBox_Categoria_A_Buscar"
        Me.TextBox_Categoria_A_Buscar.Size = New System.Drawing.Size(461, 20)
        Me.TextBox_Categoria_A_Buscar.TabIndex = 3
        '
        'Button_BuscarCategoria
        '
        Me.Button_BuscarCategoria.Location = New System.Drawing.Point(89, 23)
        Me.Button_BuscarCategoria.Name = "Button_BuscarCategoria"
        Me.Button_BuscarCategoria.Size = New System.Drawing.Size(103, 20)
        Me.Button_BuscarCategoria.TabIndex = 2
        Me.Button_BuscarCategoria.Text = "Buscar"
        Me.Button_BuscarCategoria.UseVisualStyleBackColor = True
        '
        'Label_TotalCategorias
        '
        Me.Label_TotalCategorias.AutoSize = True
        Me.Label_TotalCategorias.Location = New System.Drawing.Point(641, 355)
        Me.Label_TotalCategorias.Name = "Label_TotalCategorias"
        Me.Label_TotalCategorias.Size = New System.Drawing.Size(39, 13)
        Me.Label_TotalCategorias.TabIndex = 1
        Me.Label_TotalCategorias.Text = "Label1"
        '
        'DataGridView_ListaCategoria
        '
        Me.DataGridView_ListaCategoria.AllowUserToAddRows = False
        Me.DataGridView_ListaCategoria.AllowUserToDeleteRows = False
        Me.DataGridView_ListaCategoria.AllowUserToOrderColumns = True
        Me.DataGridView_ListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ListaCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DataGridView_ListaCategoria.Location = New System.Drawing.Point(5, 66)
        Me.DataGridView_ListaCategoria.Name = "DataGridView_ListaCategoria"
        Me.DataGridView_ListaCategoria.ReadOnly = True
        Me.DataGridView_ListaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_ListaCategoria.Size = New System.Drawing.Size(782, 267)
        Me.DataGridView_ListaCategoria.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button_Categoria_Editar)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button_categoria_CargaMasiva)
        Me.TabPage2.Controls.Add(Me.Button_Insertar_Categoria)
        Me.TabPage2.Controls.Add(Me.Button_Categoria_Cancelar)
        Me.TabPage2.Controls.Add(Me.Label_Categoria_Nombre)
        Me.TabPage2.Controls.Add(Me.TextBox_Categoria_IDcategoria)
        Me.TabPage2.Controls.Add(Me.TextBox_Categoria_Nombre)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(802, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edicion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button_Categoria_Editar
        '
        Me.Button_Categoria_Editar.Location = New System.Drawing.Point(201, 162)
        Me.Button_Categoria_Editar.Name = "Button_Categoria_Editar"
        Me.Button_Categoria_Editar.Size = New System.Drawing.Size(113, 38)
        Me.Button_Categoria_Editar.TabIndex = 7
        Me.Button_Categoria_Editar.Text = "Editar"
        Me.Button_Categoria_Editar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(573, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id de la categoria:"
        '
        'Button_categoria_CargaMasiva
        '
        Me.Button_categoria_CargaMasiva.Location = New System.Drawing.Point(672, 332)
        Me.Button_categoria_CargaMasiva.Name = "Button_categoria_CargaMasiva"
        Me.Button_categoria_CargaMasiva.Size = New System.Drawing.Size(109, 48)
        Me.Button_categoria_CargaMasiva.TabIndex = 5
        Me.Button_categoria_CargaMasiva.Text = "Carga masiva"
        Me.Button_categoria_CargaMasiva.UseVisualStyleBackColor = True
        '
        'Button_Insertar_Categoria
        '
        Me.Button_Insertar_Categoria.Location = New System.Drawing.Point(201, 162)
        Me.Button_Insertar_Categoria.Name = "Button_Insertar_Categoria"
        Me.Button_Insertar_Categoria.Size = New System.Drawing.Size(113, 38)
        Me.Button_Insertar_Categoria.TabIndex = 4
        Me.Button_Insertar_Categoria.Text = "Insertar"
        Me.Button_Insertar_Categoria.UseVisualStyleBackColor = True
        '
        'Button_Categoria_Cancelar
        '
        Me.Button_Categoria_Cancelar.Location = New System.Drawing.Point(348, 162)
        Me.Button_Categoria_Cancelar.Name = "Button_Categoria_Cancelar"
        Me.Button_Categoria_Cancelar.Size = New System.Drawing.Size(113, 38)
        Me.Button_Categoria_Cancelar.TabIndex = 3
        Me.Button_Categoria_Cancelar.Text = "Cancelar"
        Me.Button_Categoria_Cancelar.UseVisualStyleBackColor = True
        '
        'Label_Categoria_Nombre
        '
        Me.Label_Categoria_Nombre.AutoSize = True
        Me.Label_Categoria_Nombre.Location = New System.Drawing.Point(99, 94)
        Me.Label_Categoria_Nombre.Name = "Label_Categoria_Nombre"
        Me.Label_Categoria_Nombre.Size = New System.Drawing.Size(54, 13)
        Me.Label_Categoria_Nombre.TabIndex = 2
        Me.Label_Categoria_Nombre.Text = "Nombre(*)"
        '
        'TextBox_Categoria_IDcategoria
        '
        Me.TextBox_Categoria_IDcategoria.Location = New System.Drawing.Point(681, 23)
        Me.TextBox_Categoria_IDcategoria.Name = "TextBox_Categoria_IDcategoria"
        Me.TextBox_Categoria_IDcategoria.ReadOnly = True
        Me.TextBox_Categoria_IDcategoria.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Categoria_IDcategoria.TabIndex = 1
        '
        'TextBox_Categoria_Nombre
        '
        Me.TextBox_Categoria_Nombre.Location = New System.Drawing.Point(159, 91)
        Me.TextBox_Categoria_Nombre.Name = "TextBox_Categoria_Nombre"
        Me.TextBox_Categoria_Nombre.Size = New System.Drawing.Size(348, 20)
        Me.TextBox_Categoria_Nombre.TabIndex = 0
        '
        'Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 462)
        Me.Controls.Add(Me.TabControlGeneral_Categoria)
        Me.MinimumSize = New System.Drawing.Size(850, 100)
        Me.Name = "Categoria"
        Me.Text = "Categoria"
        Me.TabControlGeneral_Categoria.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView_ListaCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlGeneral_Categoria As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView_ListaCategoria As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents Label_TotalCategorias As Label
    Friend WithEvents TextBox_Categoria_A_Buscar As TextBox
    Friend WithEvents Button_BuscarCategoria As Button
    Friend WithEvents Button_Insertar_Categoria As Button
    Friend WithEvents Button_Categoria_Cancelar As Button
    Friend WithEvents Label_Categoria_Nombre As Label
    Friend WithEvents TextBox_Categoria_IDcategoria As TextBox
    Friend WithEvents TextBox_Categoria_Nombre As TextBox
    Friend WithEvents Button_categoria_CargaMasiva As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Categoria_Editar As Button
    Friend WithEvents Button_Categoria_Eliminar As Button
    Friend WithEvents CheckBox_Categoria_SeleccionarCategoria As CheckBox
End Class
