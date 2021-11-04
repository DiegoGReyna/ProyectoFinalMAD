Public Class FORM_INICIO_SESION_EMPLEADO
    Private Sub Button_InicioSesionEmpleado_reregresar_Click(sender As Object, e As EventArgs) Handles Button_InicioSesionEmpleado_reregresar.Click
        Me.Hide()
        FORM_INICIO_SESION.Show()
    End Sub

    Private Sub BTN_ACEPTAR_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR_EMPLEADO.Click
        Me.Hide()
        FORM_HORARIO.Show()

    End Sub
End Class