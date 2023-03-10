Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory
Imports Azure
Public Class EditarUnidades
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub EditarUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
    End Sub

    Private Sub EditarUnidades_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM unidad_medida WHERE codigo_unidad_medida=" & GestionarUnidades.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_nombre.Text = lector.Item("nombre_unidad_medida").ToString
        txt_descripcion.Text = lector.Item("descripcion_unidad_medida").ToString
        If lector.Item("estado_unidad_medida").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_unidad_medida").ToString = "False" Then
            cb_estado.SelectedIndex = 1
        End If
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
            Dim editarSucursales As String = "UPDATE unidad_medida set 
            nombre_unidad_medida='" & txt_nombre.Text & "', 
            descripcion_unidad_medida='" & txt_descripcion.Text & "', 
            estado_unidad_medida=" & estado & " WHERE codigo_unidad_medida=" & GestionarUnidades.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Unidad de medida editada con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_descripcion.Text = ""
            txt_nombre.Focus()
            Me.Hide()
            GestionarUnidades.Show()
            con.Close()
        End Try
    End Sub
End Class