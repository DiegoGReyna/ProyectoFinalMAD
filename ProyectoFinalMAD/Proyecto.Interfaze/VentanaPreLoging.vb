Public Class FORM_INICIO_SESION
    Private Sub BTN_CLIENTE_Click(sender As Object, e As EventArgs) Handles BTN_CLIENTE.Click
        Me.Hide()
        LoginClientes.Show()


    End Sub

    Private Sub FORM_INICIO_SESION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_EMPLEADO.Click
        Me.Hide()
        FORM_INICIO_SESION_EMPLEADO.Show()

    End Sub
End Class