Public Class FormaDeEnvio
    Private Id_FormaDePago As Integer
    Private Nombre As String

    Public Property Id_FormaDePago1 As Integer
        Get
            Return Id_FormaDePago
        End Get
        Set(value As Integer)
            Id_FormaDePago = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
End Class
