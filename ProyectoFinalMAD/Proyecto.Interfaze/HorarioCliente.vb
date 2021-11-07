Public Class FORM_HORARIO
    Private _Id_Empleado As Integer
    Private _Id_Usuario As Integer
    Private _Administrador As Boolean
    Private _NombreUsuario As String

    Public Property Id_Empleado As Integer
        Get
            Return _Id_Empleado
        End Get
        Set(value As Integer)
            _Id_Empleado = value
        End Set
    End Property

    Public Property Id_Usuario As Integer
        Get
            Return _Id_Usuario
        End Get
        Set(value As Integer)
            _Id_Usuario = value
        End Set
    End Property

    Public Property Administrador As Boolean
        Get
            Return _Administrador
        End Get
        Set(value As Boolean)
            _Administrador = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _NombreUsuario
        End Get
        Set(value As String)
            _NombreUsuario = value
        End Set
    End Property

    Private Sub BTN_HORARIO_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_HORARIO_ACEPTAR.Click



        Dim entrada As Date
        Dim Salida As Date

        entrada = DTP_HORARIO_SALIDA.Text
        Salida = DTP_HORARIO_ENTRADA.Text
        Dim resultado As Integer
        resultado = DateTime.Compare(entrada, Salida)

        If resultado < 0 Then
            MsgBox("Hora de entrada es menor a  la hora de salida")
        ElseIf resultado = 0 Then
            MsgBox("Hora de entrada y de salida son las mismas")
        Else
            MsgBox("Hora de salida mayor a la de entrada")

        End If
        If Me.ValidateChildren = True And resultado > 0 And TextBox_Horario_IdEmpleado.Text <> "" And DTP_HORARIO_SALIDA.Text <> "" And DTP_HORARIO_ENTRADA.Text <> "" Then
            Dim NewRegistroHorario As New Proyecto_Entidades.RegistroHoras
            Dim Newtienda As New Proyecto_Tienda.Tienda_RegistroHoras
            Dim TiempoTrabajadoTs As TimeSpan = entrada - Salida
            Dim TThoras As Integer = TiempoTrabajadoTs.Hours
            Dim TTMinutos As Integer = TiempoTrabajadoTs.Minutes
            Dim TTFinalString As String = (TThoras.ToString("00") & ":") + TTMinutos.ToString("00")
            TXT_HORARIO_HORAS.Text = TTFinalString

            NewRegistroHorario.Id_Empleado = TextBox_Horario_IdEmpleado.Text
            NewRegistroHorario.Fecha = Label_HorarioEmpleado.Text
            NewRegistroHorario.HoraEntrada = DTP_HORARIO_ENTRADA.Text
            NewRegistroHorario.HoraSalida = DTP_HORARIO_SALIDA.Text
            NewRegistroHorario.TotalHorasTrabajadas = TXT_HORARIO_HORAS.Text

            If (Newtienda.Insertar(NewRegistroHorario)) Then
                MsgBox("El Horario registrado correctamente", vbOKOnly, "Ingreso Exitoso")
                '' Me.Hide()
                ''MDIParent_MenuPrincipal_Empleado.Show()

            Else
                MsgBox("El horario no se a podido ingresar", vbOKOnly + vbCritical, "Error al ingresar")
            End If

        Else
            MsgBox("Horario falran datos por ingresar", vbOKOnly + vbCritical, "No se a podido ingresar horario por falta de datos")

        End If

    End Sub

    Private Sub DTP_HORARIO_ENTRADA_ValueChanged(sender As Object, e As EventArgs) Handles DTP_HORARIO_ENTRADA.ValueChanged

    End Sub

    Private Sub DTP_HORARIO_ENTRADA_MouseDown(sender As Object, e As MouseEventArgs) Handles DTP_HORARIO_ENTRADA.MouseDown
        DTP_HORARIO_ENTRADA.CustomFormat = "HH:mm"
    End Sub

    Private Sub FORM_HORARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Horario_IdEmpleado.Text = Id_Empleado
        LBL_HORARIO_EMPLEADO.Text = NombreUsuario
        Label_HorarioEmpleado.Text = Today

        DTP_HORARIO_ENTRADA.CustomFormat = "HH:mm"
        DTP_HORARIO_SALIDA.CustomFormat = "HH:mm"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Horario_Atras.Click

        Me.Close()
        FORM_INICIO_SESION_EMPLEADO.Show()
    End Sub
End Class