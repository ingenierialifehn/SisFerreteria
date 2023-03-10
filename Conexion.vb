Imports Microsoft.VisualBasic
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Conexion
    Public con As SqlConnection
    Public obtenerIdCliente As Integer = 1
    Public obtenerIdProducto As Integer
    Public obtenerTelefonoCliente As String
    Public unidad As Integer
    Public descripcion As String
    Public id_producto As Integer
    Public precio As Decimal
    Public nombreUnidad As String
    Sub AbrirConexion()
        Try
            con = New SqlConnection("Data Source=ANNONYMOUS\SQLEXPRESS;database=BDferreteria; Integrated Security=True")
            con.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub
End Module
