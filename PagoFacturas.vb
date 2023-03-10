Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class PagoFacturas
    Dim Ttal As Double
    Dim resultado As Double
    Private Sub PagoFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_pago.Items.Add("Efectivo")
        cb_pago.Items.Add("Tarjeta")
        lbl_idCliente.Text = RegistroFacturas.lbl_codigoCliente.Text
        lbl_fecha.Text = RegistroFacturas.lbl_fecha.Text
        lbl_identidad.Text = RegistroFacturas.lbl_identidad.Text
        lbl_rtn.Text = RegistroFacturas.lbl_rtn.Text
        lbl_telefono.Text = RegistroFacturas.lbl_telefono.Text
        lbl_sucursal.Text = RegistroFacturas.lbl_sucursal.Text
        lbl_idcorrelativo.Text = RegistroFacturas.lbl_idCorrelativo.Text
    End Sub
    Private Sub PagoFacturas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Correlativo
        AbrirConexion()
        Dim Correlativo As String = "SELECT * FROM correlativo"
        Dim cmd4 = New SqlCommand(Correlativo, Conexion.con)
        Dim lector4 As SqlDataReader
        lector4 = cmd4.ExecuteReader
        lector4.Read()
        lbl_factura.Text = lector4.Item("numero_correlativo_inicial").ToString
        con.Close()
        'Transportista
        AbrirConexion()
        Dim consultaUnidadesdeMedida As String = "SELECT * FROM transportista"
        Dim cmd = New SqlCommand(consultaUnidadesdeMedida, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        While lector.Read
            cb_transportista.Items.Add(lector.Item("nombre_empresa_transportista").ToString)
        End While
        con.Close()
        cb_transportista.SelectedIndex = 0
        cb_pago.SelectedIndex = 0
        lbl_total.Text = RegistroFacturas.total
        'letras
        lbl_totalventasletras.Text = UCase(Letras(RegistroFacturas.lbl_total.Text)) + " LEMPIRAS"
    End Sub


    Private Sub txt_monto_TextChanged(sender As Object, e As EventArgs) Handles txt_monto.TextChanged
        Ttal = RegistroFacturas.total
        resultado = Val(txt_monto.Text) - Ttal
        lbl_cambio.Text = resultado
        If Val(lbl_cambio.Text) < 0 Then
            lbl_cambio.ForeColor = Color.Red
        Else
            lbl_cambio.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub cb_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pago.SelectedIndexChanged
        If cb_pago.SelectedIndex = 1 Then
            txt_monto.Text = RegistroFacturas.total
            lbl_cambio.Text = 0
        Else
            txt_monto.Text = ""
            lbl_cambio.Text = ""
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_totalventasletras.Click

    End Sub
    Dim trans As String
    Dim u, idfactura As Integer
    Dim NombreReporte As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirConexion()
        trans = Me.cb_transportista.SelectedItem
        Dim consultaTrans As String = "SELECT codigo_transportista FROM transportista
            WHERE nombre_empresa_transportista='" & trans & "'"
        Dim cmd12 = New SqlCommand(consultaTrans, Conexion.con)
        Dim lector12 As SqlDataReader
        lector12 = cmd12.ExecuteReader
        lector12.Read()
        u = lector12.Item("codigo_transportista").ToString()
        con.Close()
        If txt_monto.Text = "" Then
            MsgBox("¡No se puede pagar si no ha ingresado un monto!", vbReadOnly, "SisFerreteria")
        Else
            AbrirConexion()
            Try
                Dim insertarFactura As String = "INSERT INTO factura(codigo_correlativo_factura,
            codigo_cliente_factura,codigo_sucursal_factura, fecha_factura, direccion_factura,
            docIdentidad, telefono_factura, rtn_factura, asesor_venta_factura,
            condicion_pago_factura, total_venta_letras_factura, codigo_transportista_factura)
            VALUES(" & lbl_idcorrelativo.Text & ",'" & lbl_idCliente.Text & "',
            " & lbl_sucursal.Text & ",'" & lbl_fecha.Text & "','Comayagua, Honduras',
            '" & lbl_identidad.Text & "','" & lbl_telefono.Text & "','" & lbl_rtn.Text & "',
            " & Login.usuarioLogeado & ",'" & cb_pago.SelectedItem & "','" & lbl_totalventasletras.Text & "'," & u & ")"
                Dim cmd = New SqlCommand(insertarFactura, Conexion.con)
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            Finally
                AbrirConexion()
                'idfactura
                Dim consultaIdFactura As String = "SELECT MAX(codigo_factura) as idfactura FROM factura"
                Dim cmd121 = New SqlCommand(consultaIdFactura, Conexion.con)
                Dim lector121 As SqlDataReader
                lector121 = cmd121.ExecuteReader
                lector121.Read()
                idfactura = lector121.Item("idfactura").ToString()
                con.Close()
                For Each RegistroFacturas.fila In RegistroFacturas.DataGridView1.Rows
                    Dim cantidad As String = Convert.ToString(RegistroFacturas.fila.Cells("Col_Cantidad").Value)
                    'Dim unidad As String = Convert.ToString(RegistroFacturas.fila.Cells("Col_Unidad").Value)
                    Dim codigo As String = Convert.ToString(RegistroFacturas.fila.Cells("Col_codigo").Value)
                    Dim descripcion As String = Convert.ToString(RegistroFacturas.fila.Cells("Col_descripcion").Value)
                    Dim precio As String = Convert.ToString(RegistroFacturas.fila.Cells("Col_precio").Value)
                    Dim total As String = Convert.ToString(RegistroFacturas.fila.Cells("ColumnaTotal").Value)
                    Dim ventasAfectas As Double = Val(cantidad) * Val(precio)
                    Dim isv As Double = ventasAfectas * 0.15
                    Dim totalVentas As Double = ventasAfectas + isv
                    Dim cero As Double = 0.00
                    Dim insertarDetalleFactura As String = "INSERT INTO 
                    detalle_factura(codigo_factura_detalle_factura, cantidad_detalle_factura,
                    codigo_producto_detalle_factura, descripcion_produto__detalle_factura,
                    precio_unitario_factura_detalle_factura, ventas_exentas_factura_detalle_factura,
                    ventas_exonerada_factura_detalle_factura, ventas_afectas_factura_detalle_factura, 
                    sub_total_ventas_exentas_factura_detalle_factura,
                    sub_total_ventas_exonerada_factura_detalle_factura,
                    sub_total_ventas_afectas_factura_detalle_factura,
                    descuentos_sub_total_ventas_factura_detalle_factura,
                    total_ventas_afectas_factura_detalle_factura,
                    isv_ventas_afectas_factura_detalle_factura,
                    total_ventas_factura_detalle_factura)
                    VALUES(" & idfactura & ",
                    " & cantidad & ",
                    " & codigo & ",
                    '" & descripcion & "',
                    " & precio & ",
                    " & cero & ",
                    " & cero & ",
                    " & ventasAfectas & ",
                    " & cero & ",
                    " & cero & ",
                    " & ventasAfectas & ",
                    " & cero & ",
                    " & ventasAfectas & ",
                    " & isv & ",
                    " & totalVentas & ")"
                    AbrirConexion()
                    Dim cmd20 = New SqlCommand(insertarDetalleFactura, Conexion.con)
                    cmd20.BeginExecuteNonQuery()
                Next
                con.Close()
                MsgBox("Factura guardada con éxito", vbReadOnly, "SisFerreteria")
                ImprimirFactura.Show()
                Factura.rdlc.show()
                Me.Hide()
                RegistroFacturas.DataGridView1.Rows.Clear()
                RegistroFacturas.Refresh()
                RegistroFacturas.lbl_codigoCliente.Text = 1
                RegistroFacturas.lbl_cliente.Text = "Consumidor Final"
                RegistroFacturas.lbl_rtn.Text = ""
                RegistroFacturas.lbl_identidad.Text = ""
            End Try

        End If
    End Sub
End Class