Public Class FormReporteCompras
    Private Sub FormReporteCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProyecto.PR_Recivo_Compras' table. You can move, or remove it, as needed.
        Me.PR_Recivo_ComprasTableAdapter.Fill(Me.DataSetProyecto.PR_Recivo_Compras, 1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class