Public Class FORM_INICIO_SESION_CLIENTE
    Private Sub Button_LogingEmpleado_RegresarLoging_Click(sender As Object, e As EventArgs) Handles Button_LogingEmpleado_RegresarLoging.Click
        Me.Hide()
        FORM_INICIO_SESION.Show()
    End Sub

    Private Sub FORM_INICIO_SESION_CLIENTE_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_LoginCliente_CrearCuentaCliente.LinkClicked
        Me.Hide()
        FORM_CrearCliente.Show()
    End Sub
End Class