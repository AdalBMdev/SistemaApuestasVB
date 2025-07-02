Imports System.Data.SqlClient
Imports System.Configuration

Module ConexionSQL
    Public conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Sub AbrirConexion()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Sub

    Public Sub CerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Module
