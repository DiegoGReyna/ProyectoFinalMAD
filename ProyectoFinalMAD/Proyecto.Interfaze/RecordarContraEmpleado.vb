Public Class RecordarContraEmpleado
    Private Sub BTN_RecordarContraEmpleado_ACEPTAR__Click(sender As Object, e As EventArgs) Handles BTN_RecordarContraEmpleado_ACEPTAR_.Click

    End Sub

    Private Sub Button_RecordarContraEmpleado_Atras_Click(sender As Object, e As EventArgs) Handles Button_RecordarContraEmpleado_Atras.Click
        Me.Hide()
        FORM_INICIO_SESION_EMPLEADO.Show()
    End Sub
End Class