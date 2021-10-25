﻿Public Class Producto
#Region "Variables"
    Private ID_CodigoProducto As Integer
    Private ID_Categoria As Integer
    Private ID_Empleado As Integer
    Private Nombre As String
    Private Descripcion As String
    Private Stock As Integer
    Private Precio As Decimal
    Private Estado As Boolean
    Private Descuento As Decimal
#End Region
#Region "Propiedades Productos"
    Public Property ID_CodigoProducto1 As Integer
        Get
            Return ID_CodigoProducto
        End Get
        Set(value As Integer)
            ID_CodigoProducto = value
        End Set
    End Property

    Public Property ID_Categoria1 As Integer
        Get
            Return ID_Categoria
        End Get
        Set(value As Integer)
            ID_Categoria = value
        End Set
    End Property

    Public Property ID_Empleado1 As Integer
        Get
            Return ID_Empleado
        End Get
        Set(value As Integer)
            ID_Empleado = value
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

    Public Property Descripcion1 As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    Public Property Stock1 As Integer
        Get
            Return Stock
        End Get
        Set(value As Integer)
            Stock = value
        End Set
    End Property

    Public Property Precio1 As Decimal
        Get
            Return Precio
        End Get
        Set(value As Decimal)
            Precio = value
        End Set
    End Property

    Public Property Estado1 As Boolean
        Get
            Return Estado
        End Get
        Set(value As Boolean)
            Estado = value
        End Set
    End Property

    Public Property Descuento1 As Decimal
        Get
            Return Descuento
        End Get
        Set(value As Decimal)
            Descuento = value
        End Set
    End Property
#End Region
End Class