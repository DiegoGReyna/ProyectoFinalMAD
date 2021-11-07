Public Class RegistroHoras
    Private _Id_Horario As Integer
    Private _Id_Empleado As Integer
    Private _Fecha As String
    Private _HoraEntrada As String
    Private _HoraSalida As String
    Private _TotalHorasTrabajadas As String

    Public Property Id_Horario As Integer
        Get
            Return _Id_Horario
        End Get
        Set(value As Integer)
            _Id_Horario = value
        End Set
    End Property

    Public Property Id_Empleado As Integer
        Get
            Return _Id_Empleado
        End Get
        Set(value As Integer)
            _Id_Empleado = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property HoraEntrada As String
        Get
            Return _HoraEntrada
        End Get
        Set(value As String)
            _HoraEntrada = value
        End Set
    End Property

    Public Property HoraSalida As String
        Get
            Return _HoraSalida
        End Get
        Set(value As String)
            _HoraSalida = value
        End Set
    End Property

    Public Property TotalHorasTrabajadas As String
        Get
            Return _TotalHorasTrabajadas
        End Get
        Set(value As String)
            _TotalHorasTrabajadas = value
        End Set
    End Property
End Class
