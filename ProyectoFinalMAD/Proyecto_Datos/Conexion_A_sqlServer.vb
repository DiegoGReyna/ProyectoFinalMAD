Imports System.Data.SqlClient
Public Class Conexion_A_sqlServer

    Public conexion As SqlConnection


    Public Sub New()

        Me.conexion = New SqlConnection("Data Source=DIEGO\SQLEXPRESS;Initial Catalog=Proyecto_MAD;Persist Security Info=True;User ID=sa;Password=uciopA5D")

    End Sub

End Class
