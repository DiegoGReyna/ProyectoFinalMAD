Public Class ComprasPagoEnvio
    Private _Id_ComprasPagoEnvio As Integer
    Private _Id_Compras As Integer
    Private _Id_Carrito As Integer
    Private _Id_Cliente As Integer
    Private _Id_Forma_Pago As Integer
    Private _Id_Forma_Envio As Integer
    Private _FechaCompra As Date
    Private _Total As Decimal
    Private _Descuento As Decimal
    Private _EstadoPago As String

    Public Property Id_ComprasPagoEnvio As Integer
        Get
            Return _Id_ComprasPagoEnvio
        End Get
        Set(value As Integer)
            _Id_ComprasPagoEnvio = value
        End Set
    End Property

    Public Property Id_Compras As Integer
        Get
            Return _Id_Compras
        End Get
        Set(value As Integer)
            _Id_Compras = value
        End Set
    End Property

    Public Property Id_Carrito As Integer
        Get
            Return _Id_Carrito
        End Get
        Set(value As Integer)
            _Id_Carrito = value
        End Set
    End Property

    Public Property Id_Cliente As Integer
        Get
            Return _Id_Cliente
        End Get
        Set(value As Integer)
            _Id_Cliente = value
        End Set
    End Property

    Public Property Id_Forma_Pago As Integer
        Get
            Return _Id_Forma_Pago
        End Get
        Set(value As Integer)
            _Id_Forma_Pago = value
        End Set
    End Property

    Public Property Id_Forma_Envio As Integer
        Get
            Return _Id_Forma_Envio
        End Get
        Set(value As Integer)
            _Id_Forma_Envio = value
        End Set
    End Property

    Public Property FechaCompra As Date
        Get
            Return _FechaCompra
        End Get
        Set(value As Date)
            _FechaCompra = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property

    Public Property Descuento As Decimal
        Get
            Return _Descuento
        End Get
        Set(value As Decimal)
            _Descuento = value
        End Set
    End Property

    Public Property EstadoPago As String
        Get
            Return _EstadoPago
        End Get
        Set(value As String)
            _EstadoPago = value
        End Set
    End Property
End Class
