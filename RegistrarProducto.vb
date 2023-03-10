Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarProducto
    Private Sub cb_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_estado.SelectedIndexChanged

    End Sub

    Private Sub RegistrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Dim estado As Integer
    Dim unidad As String
    Dim u As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        unidad = Trim(Me.cb_unidad.SelectedItem)
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
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
            Dim insertarProductos As String = "INSERT INTO productos(id_producto,nombre_producto,
            unidad_medida_producto,cantidad_producto,isv_003_producto,isv_005_producto,
            estado_producto,precio_producto) VALUES('" & txt_idproducto.Text & "','" & txt_nombre.Text & "',
            " & Val(u) & ",'" & txt_cantidad.Text & "','" & Convert.ToDecimal(txt_isv3.Text) & "',
            '" & Convert.ToDecimal(txt_isv5.Text) & "',
            '" & estado & "'," & txt_precio.Text & ")"
            Dim cmd = New SqlCommand(insertarProductos, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Producto guardado con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_cantidad.Text = ""
            txt_isv3.Text = ""
            txt_isv5.Text = ""
            txt_idproducto.Text = ""
            txt_precio.Text = ""
            txt_idproducto.Focus()
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_idproducto_TextChanged(sender As Object, e As EventArgs) Handles txt_idproducto.TextChanged

    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub cb_unidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_unidad.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged

    End Sub
End Class