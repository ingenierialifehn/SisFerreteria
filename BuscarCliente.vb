Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class BuscarCliente
    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BuscarCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaSucursales As String = "SELECT * FROM cliente"
        Dim cmd = New SqlCommand(consultaSucursales, Conexion.con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DgvBuscarCliente.DataSource = table
        Conexion.con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        AbrirConexion()
        If txt_buscar.Text = "" Then
            Dim consultaSucursales As String = "SELECT * FROM cliente"
            Dim cmd = New SqlCommand(consultaSucursales, Conexion.con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            DgvBuscarCliente.DataSource = table
            Conexion.con.Close()
        Else
            Dim consultaSucursales As String = "SELECT * FROM cliente WHERE nombre_cliente
        LIKE '%" & txt_buscar.Text & "'"
            Dim cmd = New SqlCommand(consultaSucursales, Conexion.con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            DgvBuscarCliente.DataSource = table
            Conexion.con.Close()
        End If
    End Sub



    Private Sub DgvBuscarCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBuscarCliente.CellDoubleClick
        Conexion.obtenerIdCliente = DgvBuscarCliente.CurrentRow.Cells(0).Value
        Conexion.obtenerTelefonoCliente = DgvBuscarCliente.CurrentRow.Cells(3).Value
        RegistroFacturas.Update()
        RegistroFacturas.Refresh()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegistrarClientes.Show()
        RegistrarClientes.ControlBox = True
        RegistrarClientes.Button2.Enabled = False
    End Sub

    Private Sub DgvBuscarCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBuscarCliente.CellContentClick

    End Sub
End Class