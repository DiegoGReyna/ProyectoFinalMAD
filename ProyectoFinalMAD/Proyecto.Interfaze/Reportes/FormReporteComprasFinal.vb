Public Class FormReporteComprasFinal
    Private Sub FormReporteComprasFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProyecto.PR_Recivo_Compras_Final' table. You can move, or remove it, as needed.
        Me.PR_Recivo_Compras_FinalTableAdapter.Fill(Me.DataSetProyecto.PR_Recivo_Compras_Final, VariablesCompartidas.idCompra)
        'TODO: This line of code loads data into the 'DataSetProyecto.PR_Recivo_Compras' table. You can move, or remove it, as needed.


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class