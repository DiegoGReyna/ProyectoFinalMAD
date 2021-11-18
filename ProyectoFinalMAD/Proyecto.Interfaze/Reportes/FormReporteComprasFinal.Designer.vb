<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteComprasFinal
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PR_Recivo_ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProyecto = New Proyecto.Interfaze.DataSetProyecto()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PR_Recivo_ComprasTableAdapter = New Proyecto.Interfaze.DataSetProyectoTableAdapters.PR_Recivo_ComprasTableAdapter()
        Me.PR_Recivo_Compras_FinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PR_Recivo_Compras_FinalTableAdapter = New Proyecto.Interfaze.DataSetProyectoTableAdapters.PR_Recivo_Compras_FinalTableAdapter()
        CType(Me.PR_Recivo_ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PR_Recivo_Compras_FinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PR_Recivo_ComprasBindingSource
        '
        Me.PR_Recivo_ComprasBindingSource.DataMember = "PR_Recivo_Compras"
        Me.PR_Recivo_ComprasBindingSource.DataSource = Me.DataSetProyecto
        '
        'DataSetProyecto
        '
        Me.DataSetProyecto.DataSetName = "DataSetProyecto"
        Me.DataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetCompras_Recivo_Final"
        ReportDataSource1.Value = Me.PR_Recivo_Compras_FinalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.Interfaze.ReportCompra_Recivo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'PR_Recivo_ComprasTableAdapter
        '
        Me.PR_Recivo_ComprasTableAdapter.ClearBeforeFill = True
        '
        'PR_Recivo_Compras_FinalBindingSource
        '
        Me.PR_Recivo_Compras_FinalBindingSource.DataMember = "PR_Recivo_Compras_Final"
        Me.PR_Recivo_Compras_FinalBindingSource.DataSource = Me.DataSetProyecto
        '
        'PR_Recivo_Compras_FinalTableAdapter
        '
        Me.PR_Recivo_Compras_FinalTableAdapter.ClearBeforeFill = True
        '
        'FormReporteComprasFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReporteComprasFinal"
        Me.Text = "FormReporteComprasFinal"
        CType(Me.PR_Recivo_ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PR_Recivo_Compras_FinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PR_Recivo_ComprasBindingSource As BindingSource
    Friend WithEvents DataSetProyecto As DataSetProyecto
    Friend WithEvents PR_Recivo_ComprasTableAdapter As DataSetProyectoTableAdapters.PR_Recivo_ComprasTableAdapter
    Friend WithEvents PR_Recivo_Compras_FinalBindingSource As BindingSource
    Friend WithEvents PR_Recivo_Compras_FinalTableAdapter As DataSetProyectoTableAdapters.PR_Recivo_Compras_FinalTableAdapter
End Class
