Public Class Compras_Y_ComprasFormaDepagoEnvio
    Private _Id_ComprasFormaDepagoYenvio As Integer
    Private _Id_Client As Integer
    Private _Id_Compras As Integer
    Private _Id_Carrito As Integer
    Private _Id_CarritoProducto As Integer
    Private _Id_FormaDePago As Integer
    Private _Id_FormaDeEnvio As Integer
    Private _FechaDeCompra As Date
    Private _EstadoPago As Boolean
    Private _DireccionEntrega As String
    Private _Total As Decimal
    Private _TotalSinDescuento As Decimal
    Private _TotalAhorrado As Decimal

    Public Property Id_ComprasFormaDepagoYenvio As Integer
        Get
            Return _Id_ComprasFormaDepagoYenvio
        End Get
        Set(value As Integer)
            _Id_ComprasFormaDepagoYenvio = value
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

    Public Property Id_CarritoProducto As Integer
        Get
            Return _Id_CarritoProducto
        End Get
        Set(value As Integer)
            _Id_CarritoProducto = value
        End Set
    End Property

    Public Property Id_FormaDePago As Integer
        Get
            Return _Id_FormaDePago
        End Get
        Set(value As Integer)
            _Id_FormaDePago = value
        End Set
    End Property

    Public Property Id_FormaDeEnvio As Integer
        Get
            Return _Id_FormaDeEnvio
        End Get
        Set(value As Integer)
            _Id_FormaDeEnvio = value
        End Set
    End Property

    Public Property FechaDeCompra As Date
        Get
            Return _FechaDeCompra
        End Get
        Set(value As Date)
            _FechaDeCompra = value
        End Set
    End Property

    Public Property EstadoPago As Boolean
        Get
            Return _EstadoPago
        End Get
        Set(value As Boolean)
            _EstadoPago = value
        End Set
    End Property

    Public Property DireccionEntrega As String
        Get
            Return _DireccionEntrega
        End Get
        Set(value As String)
            _DireccionEntrega = value
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

    Public Property TotalSinDescuento As Decimal
        Get
            Return _TotalSinDescuento
        End Get
        Set(value As Decimal)
            _TotalSinDescuento = value
        End Set
    End Property

    Public Property TotalAhorrado As Decimal
        Get
            Return _TotalAhorrado
        End Get
        Set(value As Decimal)
            _TotalAhorrado = value
        End Set
    End Property

    Public Property Id_Client As Integer
        Get
            Return _Id_Client
        End Get
        Set(value As Integer)
            _Id_Client = value
        End Set
    End Property
End Class
