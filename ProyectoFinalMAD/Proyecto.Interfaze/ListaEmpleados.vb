Public Class FORM_LISTA_EMPLEADO
    Private Sub Formato()
        DataGridView_ListaEmpleados.Columns(0).Visible = False
        DataGridView_ListaEmpleados.Columns(0).Width = 80
        DataGridView_ListaEmpleados.Columns(1).Width = 100
        DataGridView_ListaEmpleados.Columns(2).Width = 100
        DataGridView_ListaEmpleados.Columns(3).Width = 100
        DataGridView_ListaEmpleados.Columns(4).Width = 100
        DataGridView_ListaEmpleados.Columns(5).Width = 100
        DataGridView_ListaEmpleados.Columns(6).Width = 100
        DataGridView_ListaEmpleados.Columns(7).Width = 100
        DataGridView_ListaEmpleados.Columns(8).Width = 100
        DataGridView_ListaEmpleados.Columns(9).Width = 100
        DataGridView_ListaEmpleados.Columns(10).Width = 100
        DataGridView_ListaEmpleados.Columns(11).Width = 100
        DataGridView_ListaEmpleados.Columns(12).Width = 100
        DataGridView_ListaEmpleados.Columns(13).Width = 100
        DataGridView_ListaEmpleados.Columns(14).Width = 100
        DataGridView_ListaEmpleados.Columns(15).Width = 100
        DataGridView_ListaEmpleados.Columns(16).Width = 100
        DataGridView_ListaEmpleados.Columns(17).Width = 100
        DataGridView_ListaEmpleados.Columns(18).Width = 100
        DataGridView_ListaEmpleados.Columns(19).Width = 100
        DataGridView_ListaEmpleados.Columns(20).Width = 100

        DataGridView_ListaEmpleados.Columns.Item("SeleccionarEmpleado").Visible = False

    End Sub
    Private Sub Mostrar()
        Try
            Dim Tienda As New Proyecto_Tienda.Tienda_Empleado
            DataGridView_ListaEmpleados.DataSource = Tienda.ListaEmpleado()

            Me.Formato()
            'Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTN_LISTEMPLEADOS_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTN_LISTEMPLEADOS_IMPRIMIR.Click

    End Sub

    Private Sub DataGridView_Empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ListaEmpleados.CellContentClick

    End Sub

    Private Sub FORM_LISTA_EMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mostrar()

    End Sub
End Class