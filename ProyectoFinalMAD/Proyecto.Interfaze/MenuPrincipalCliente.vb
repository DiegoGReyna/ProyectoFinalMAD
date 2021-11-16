Public Class MenuPrincipalCliente
    Private Id_Cliente As Integer
    Private Id_Usuario As Integer
    Private Id_Direccion As Integer
    Private Id_Carrito As Integer
    Private CorreoElectronico As String
    Private NumCelular As String
    Private Contrasena As String
    Private Nombre As String
    Private ApellidoPaterno As String
    Private ApellidoMaterno As String
    Private DireccionCompleta As String
    Private Estado As String
    Private Municipio As String
    Private Colonia As String
    Private CodigoPostal As String
    Private Calle As String
    Private NumeroCasa As String
    Private Activo As String
    Private NombreCompleto As String

    Public Property Id_Cliente1 As Integer
        Get
            Return Id_Cliente
        End Get
        Set(value As Integer)
            Id_Cliente = value
        End Set
    End Property

    Public Property Id_Usuario1 As Integer
        Get
            Return Id_Usuario
        End Get
        Set(value As Integer)
            Id_Usuario = value
        End Set
    End Property

    Public Property Id_Direccion1 As Integer
        Get
            Return Id_Direccion
        End Get
        Set(value As Integer)
            Id_Direccion = value
        End Set
    End Property

    Public Property Id_Carrito1 As Integer
        Get
            Return Id_Carrito
        End Get
        Set(value As Integer)
            Id_Carrito = value
        End Set
    End Property

    Public Property CorreoElectronico1 As String
        Get
            Return CorreoElectronico
        End Get
        Set(value As String)
            CorreoElectronico = value
        End Set
    End Property

    Public Property NumCelular1 As String
        Get
            Return NumCelular
        End Get
        Set(value As String)
            NumCelular = value
        End Set
    End Property

    Public Property Contrasena1 As String
        Get
            Return Contrasena
        End Get
        Set(value As String)
            Contrasena = value
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

    Public Property ApellidoPaterno1 As String
        Get
            Return ApellidoPaterno
        End Get
        Set(value As String)
            ApellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno1 As String
        Get
            Return ApellidoMaterno
        End Get
        Set(value As String)
            ApellidoMaterno = value
        End Set
    End Property

    Public Property DireccionCompleta1 As String
        Get
            Return DireccionCompleta
        End Get
        Set(value As String)
            DireccionCompleta = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property

    Public Property Municipio1 As String
        Get
            Return Municipio
        End Get
        Set(value As String)
            Municipio = value
        End Set
    End Property

    Public Property Colonia1 As String
        Get
            Return Colonia
        End Get
        Set(value As String)
            Colonia = value
        End Set
    End Property

    Public Property CodigoPostal1 As String
        Get
            Return CodigoPostal
        End Get
        Set(value As String)
            CodigoPostal = value
        End Set
    End Property

    Public Property Calle1 As String
        Get
            Return Calle
        End Get
        Set(value As String)
            Calle = value
        End Set
    End Property

    Public Property NumeroCasa1 As String
        Get
            Return NumeroCasa
        End Get
        Set(value As String)
            NumeroCasa = value
        End Set
    End Property

    Public Property Activo1 As String
        Get
            Return Activo
        End Get
        Set(value As String)
            Activo = value
        End Set
    End Property

    Public Property NombreCompleto1 As String
        Get
            Return NombreCompleto
        End Get
        Set(value As String)
            NombreCompleto = value
        End Set
    End Property

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub MenuPrincipalCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_MenuCliente_Correo.Text = CorreoElectronico1
        TextBox_MenuCliente_Direccion.Text = DireccionCompleta1
        TextBox_MenuCliente_IdCliente.Text = Id_Cliente1
        TextBox_MenuCliente_IdCarrito.Text = Id_Carrito1
        TextBox_MenuCliente_IdUsuario.Text = Id_Usuario1
        TextBox_MenuCliente_IdDireccion.Text = Id_Direccion1



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button_MenuCliente_Salir_Click(sender As Object, e As EventArgs) Handles Button_MenuCliente_Salir.Click
        Me.Close()
        FORM_INICIO_SESION.Show()
    End Sub

    Private Sub Button_MenuCliente_Tienda_Click(sender As Object, e As EventArgs) Handles Button_MenuCliente_Tienda.Click
        Tienda.CorreoElectronico = CorreoElectronico1
        Tienda.DireccionCompleta = DireccionCompleta1
        Tienda.Id_Cliente = Id_Cliente1
        Tienda.Id_Carrito = Id_Carrito1
        Tienda.Id_Usuario = Id_Usuario1
        Tienda.Id_Direccion = Id_Direccion1
        Tienda.NumCelular = NumCelular1
        Tienda.NombreCompleto = NombreCompleto1
        Me.Hide()
        Tienda.Show()
    End Sub
End Class