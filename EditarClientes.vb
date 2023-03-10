Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditarClientes
    Private Sub EditarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
        cb_libreISV.Items.Add("Si")
        cb_libreISV.Items.Add("No")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub EditarClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM cliente WHERE codigo_cliente=" & GestionarClientes.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_nombre.Text = lector.Item("nombre_cliente").ToString
        txt_identidad.Text = lector.Item("identidad_cliente").ToString
        txt_correo.Text = lector.Item("correo_cliente").ToString
        txt_telefono.Text = lector.Item("telefono_cliente").ToString
        txt_rtn.Text = lector.Item("rtn_cliente").ToString
        If lector.Item("libre_impuesto_cliente").ToString = "True" Then
            cb_libreISV.SelectedIndex = 0
        End If
        If lector.Item("libre_impuesto_cliente").ToString = "False" Then
            cb_libreISV.SelectedIndex = 1
        End If
        If lector.Item("estado_cliente").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_cliente").ToString = "False" Then
            cb_estado.SelectedIndex = 1
        End If
    End Sub
    Dim estado,isv As integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        If Me.cb_libreISV.SelectedItem = "Si" Then
            isv = 1
        Else
            isv = 0
        End If
        AbrirConexion()
        Try
            Dim editarSucursales As String = "UPDATE cliente set 
            nombre_cliente='" & txt_nombre.Text & "', 
            correo_cliente='" & txt_correo.Text & "', 
            telefono_cliente='" & txt_telefono.Text & "',
            identidad_cliente='" & txt_identidad.Text & "',
            rtn_cliente='" & txt_rtn.Text & "',
            libre_impuesto_cliente=" & isv & ",
            estado_cliente=" & estado & " 
            WHERE codigo_cliente=" & GestionarClientes.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Cliente editado con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_telefono.Text = ""
            txt_identidad.Text = ""
            txt_rtn.Text = ""
            txt_correo.Text = ""
            txt_identidad.Focus()
            Me.Hide()
            GestionarClientes.Show()
            con.Close()
        End Try
    End Sub
End Class