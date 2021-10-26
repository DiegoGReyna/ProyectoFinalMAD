Public Class CategoriaDeProducto
#Region "Variables Productos"
    Private Id_CategoriaProducto As Integer
    Private Nombre As String
#End Region

#Region "Propiedades"
    Public Property Id_CategoriaProducto_Categoria As Integer
        Get
            Return Id_CategoriaProducto
        End Get
        Set(value As Integer)
            Id_CategoriaProducto = value
        End Set
    End Property

    Public Property Nombre_Categoria As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
#End Region

End Class
