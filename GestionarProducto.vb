Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class GestionarProducto
    Private Sub GestionarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub GestionarProducto_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaSucursales As String = "SELECT * FROM productos"
        Dim cmd = New SqlCommand(consultaSucursales, Conexion.con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
        Conexion.con.Close()
    End Sub
    Public codigo_editar As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        codigo_editar = DataGridView1.CurrentRow.Cells(0).Value
        EditarProductos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codigo As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim respuesta As Integer
        respuesta = MsgBox("Estás seguro que deseas eliminar este Producto?", vbYesNo, "SisFerreteria")
        If respuesta = vbYes Then
            AbrirConexion()
            Dim borrarSucursal As String = "DELETE FROM productos WHERE codigo_producto=" & codigo & ""
            Dim cmd = New SqlCommand(borrarSucursal, Conexion.con)
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            Conexion.con.Close()
            MsgBox("Producto eliminado con éxito", vbReadOnly, "SisFerreteria")
            Me.Update()
            Me.Refresh()
        End If
    End Sub
End Class