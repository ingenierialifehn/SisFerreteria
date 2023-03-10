Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditarProductos
    Private Sub EditarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim consultaUnidadesdeMedida As String = "SELECT * FROM unidad_medida"
        Dim cmd = New SqlCommand(consultaUnidadesdeMedida, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        While lector.Read
            cb_unidad.Items.Add(lector.Item("nombre_unidad_medida").ToString)
        End While
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
        con.Close()
    End Sub

    Private Sub EditarProductos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM productos WHERE codigo_producto=" & GestionarProducto.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_idproducto.Text = lector.Item("id_producto").ToString
        txt_nombre.Text = lector.Item("nombre_producto").ToString
        txt_cantidad.Text = lector.Item("cantidad_producto").ToString
        txt_isv3.Text = lector.Item("isv_003_producto").ToString
        txt_isv5.Text = lector.Item("isv_005_producto").ToString
        Dim medida As String = lector.Item("unidad_medida_producto")
        If lector.Item("estado_producto").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_producto").ToString = "False" Then
            cb_estado.SelectedIndex = 1
        End If
        con.Close()
        '
        AbrirConexion()
        Dim conMedida As String = "SELECT * FROM unidad_medida WHERE codigo_unidad_medida=" & medida & ""
        Dim cd = New SqlCommand(conMedida, Conexion.con)
        Dim lector4 As SqlDataReader
        lector4 = cd.ExecuteReader
        lector4.Read()
        Dim valormedida As String = lector4.Item("nombre_unidad_medida").ToString
        For x = 0 To cb_unidad.Items.Count - 1
            If cb_unidad.Items(x) = valormedida Then
                cb_unidad.SelectedIndex = x
            End If
        Next
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Dim estado As Integer
    Dim u As String
    Dim unidad As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
        unidad = Trim(Me.cb_unidad.SelectedItem)
        Dim consultaUnidad As String = "SELECT codigo_unidad_medida FROM unidad_medida WHERE 
        nombre_unidad_medida='" & unidad & "'"
        Dim cmd2 = New SqlCommand(consultaUnidad, Conexion.con)
        Dim lector2 As SqlDataReader
        lector2 = cmd2.ExecuteReader
        lector2.Read()
        u = lector2.Item("codigo_unidad_medida").ToString()
        con.Close()
        AbrirConexion()
        Try
            Dim editarSucursales As String = "UPDATE productos set 
            id_producto='" & txt_idproducto.Text & "', 
            nombre_producto='" & txt_nombre.Text & "', 
            unidad_medida_producto=" & u & ",
            cantidad_producto='" & txt_cantidad.Text & "',
            isv_003_producto='" & txt_isv3.Text & "',
            isv_005_producto='" & txt_isv5.Text & "',
            estado_producto='" & estado & "',
            precio_producto=" & txt_precio.Text & "
            WHERE codigo_producto=" & GestionarProducto.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Producto editado con éxito", vbReadOnly, "SisFerreteria")
            Me.Hide()
            GestionarProducto.Show()
            con.Close()
        End Try
    End Sub
End Class