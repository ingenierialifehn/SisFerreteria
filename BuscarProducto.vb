Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class BuscarProducto
    Private Sub BuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BuscarProducto_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaSucursales As String = "SELECT * FROM productos"
        Dim cmd = New SqlCommand(consultaSucursales, Conexion.con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DgvBuscarProducto.DataSource = table
        Conexion.con.Close()
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        AbrirConexion()
        Dim consultaSucursales As String = "SELECT * FROM productos WHERE id_producto
        LIKE '%" & txt_buscar.Text & "' OR nombre_producto LIKE '%" & txt_buscar.Text & "'"
        Dim cmd = New SqlCommand(consultaSucursales, Conexion.con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DgvBuscarProducto.DataSource = table
    End Sub



    Private Sub DgvBuscarProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBuscarProducto.CellDoubleClick
        Conexion.id_producto = DgvBuscarProducto.CurrentRow.Cells(0).Value
        Conexion.descripcion = DgvBuscarProducto.CurrentRow.Cells(2).Value
        Conexion.precio = DgvBuscarProducto.CurrentRow.Cells(8).Value
        Conexion.unidad = DgvBuscarProducto.CurrentRow.Cells(3).Value
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM unidad_medida WHERE 
        codigo_unidad_medida=" & Conexion.unidad & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        Conexion.nombreUnidad = lector.Item("nombre_unidad_medida").ToString
        RegistroFacturas.Update()
        RegistroFacturas.Refresh()
        Me.Hide()
        RegistroFacturas.DataGridView1.Rows.Add(1, Conexion.nombreUnidad, Conexion.id_producto,
        Conexion.descripcion, Conexion.precio)
    End Sub

    Private Sub DgvBuscarProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBuscarProducto.CellContentClick

    End Sub
End Class