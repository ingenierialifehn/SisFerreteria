Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistroFacturas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Facturas.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegistroFacturas_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegistroFacturas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lbl_rtn.Text = ""
        lbl_cliente.Text = ""
        lbl_identidad.Text = ""
        Dim thisDate As Date
        thisDate = Today
        lbl_fecha.Text = thisDate
        AbrirConexion()
        If Conexion.obtenerIdCliente = 1 Then
            Dim consultaUsuarios As String = "SELECT * FROM cliente WHERE codigo_cliente=1"
            Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            lector.Read()
            lbl_codigoCliente.Text = 1
            lbl_cliente.Text = lector.Item("nombre_cliente").ToString
            lbl_telefono.Text = lector.Item("telefono_cliente").ToString
        Else
            Dim consultaUsuarios As String = "SELECT * FROM cliente WHERE codigo_cliente=" & Conexion.obtenerIdCliente & ""
            Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            lector.Read()
            lbl_codigoCliente.Text = Conexion.obtenerIdCliente
            lbl_telefono.Text = lector.Item("telefono_cliente").ToString
            lbl_cliente.Text = lector.Item("nombre_cliente").ToString
            lbl_identidad.Text = lector.Item("identidad_cliente").ToString
            lbl_rtn.Text = lector.Item("rtn_cliente").ToString
        End If
        con.Close()
        'Sucursales
        AbrirConexion()
        Dim consultaSucursales As String = "SELECT * FROM sucursales"
        Dim cmd2 = New SqlCommand(consultaSucursales, Conexion.con)
        Dim lector2 As SqlDataReader
        lector2 = cmd2.ExecuteReader
        While lector2.Read
            cb_sucursal.Items.Add(lector2.Item("nombre_sucursal").ToString)
        End While
        cb_sucursal.SelectedIndex = 0
        con.Close()
        'Correlativo
        AbrirConexion()
        Dim Correlativo As String = "SELECT * FROM correlativo WHERE estado_correlativo=1"
        Dim cmd4 = New SqlCommand(Correlativo, Conexion.con)
        Dim lector4 As SqlDataReader
        lector4 = cmd4.ExecuteReader
        lector4.Read()
        lbl_correlativo.Text = lector4.Item("numero_correlativo_inicial").ToString
        lbl_idCorrelativo.Text = lector4.Item("codigo_correlativo").ToString
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BuscarCliente.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BuscarProducto.Show()
    End Sub
    Public total As Double = 0
    Public detalle_factura As New List(Of Object)
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.CurrentRow.Cells(5).Value = DataGridView1.CurrentRow.Cells(0).Value * DataGridView1.CurrentRow.Cells(4).Value
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("ColumnaTotal").Value)
        Next
        lbl_total.Text = total
    End Sub
    Public fila As DataGridViewRow = New DataGridViewRow()
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.Rows.Count = 1 Then
            MsgBox("No se puede facturar, Agrega un Producto al menos", vbYesNo, "SisFerreteria")
        Else
            Dim respuesta As Integer
            respuesta = MsgBox("Estás seguro que deseas Facturar estos productos?", vbYesNo, "SisFerreteria")
            If respuesta = vbYes Then
                PagoFacturas.Show()

            End If
        End If
    End Sub

    Private Sub RegistroFacturas_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim unidad As String
    Private Sub cb_sucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_sucursal.SelectedIndexChanged
        unidad = Trim(Me.cb_sucursal.SelectedItem)
        AbrirConexion()
        Dim Sucursales As String = "SELECT * FROM sucursales WHERE 
        nombre_sucursal ='" & unidad & "'"
        Dim cmd3 = New SqlCommand(Sucursales, Conexion.con)
        Dim lector3 As SqlDataReader
        lector3 = cmd3.ExecuteReader
        lector3.Read()
        lbl_sucursal.Text = lector3.Item("codigo_sucursal").ToString
        con.Close()
    End Sub
End Class