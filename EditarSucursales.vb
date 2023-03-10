Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory
Imports Azure
Public Class EditarSucursales
    Private Sub EditarSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
    End Sub

    Private Sub EditarSucursales_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM sucursales WHERE codigo_sucursal=" & GestionarSucursales.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_nombre.Text = lector.Item("nombre_sucursal").ToString
        txt_direccion.Text = lector.Item("direccion_sucursal").ToString
        If lector.Item("estado_sucursal").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_sucursal").ToString = "False" Then
            cb_estado.SelectedIndex = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        GestionarSucursales.Show()
    End Sub
    Dim estado As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
        Try
            Dim editarSucursales As String = "UPDATE sucursales set 
            nombre_sucursal='" & txt_nombre.Text & "', 
            direccion_sucursal='" & txt_direccion.Text & "', 
            estado_sucursal=" & estado & " WHERE codigo_sucursal=" & GestionarSucursales.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Sucursal editada con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_direccion.Text = ""
            txt_nombre.Focus()
            Me.Hide()
            GestionarSucursales.Show()
            con.Close()
        End Try
    End Sub
End Class