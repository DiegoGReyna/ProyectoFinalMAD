Public Class Producto

    Private _ID_CodigoProducto As Integer
    Private _ID_Categoria As Integer
    Private _ID_Empleado As Integer
    Private _ID_Sucursal As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Stock As Integer
    Private _Precio As Decimal
    Private _Estado As Boolean
    Private _Descuento As Decimal

    Public Property ID_CodigoProducto As Integer
        Get
            Return _ID_CodigoProducto
        End Get
        Set(value As Integer)
            _ID_CodigoProducto = value
        End Set
    End Property

    Public Property ID_Categoria As Integer
        Get
            Return _ID_Categoria
        End Get
        Set(value As Integer)
            _ID_Categoria = value
        End Set
    End Property

    Public Property ID_Empleado As Integer
        Get
            Return _ID_Empleado
        End Get
        Set(value As Integer)
            _ID_Empleado = value
        End Set
    End Property

    Public Property ID_Sucursal As Integer
        Get
            Return _ID_Sucursal
        End Get
        Set(value As Integer)
            _ID_Sucursal = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            _Precio = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _Estado
        End Get
        Set(value As Boolean)
            _Estado = value
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
End Class
