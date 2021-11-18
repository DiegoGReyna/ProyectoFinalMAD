Public Class ReporteProductos
    Private Sub ReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProyecto.Producto_Mostrar' table. You can move, or remove it, as needed.
        Me.Producto_MostrarTableAdapter.Fill(Me.DataSetProyecto.Producto_Mostrar)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class