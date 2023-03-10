Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditarTipoEmpleado
    Private Sub EditarTipoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
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
            Dim editarSucursales As String = "UPDATE tipo_empleado set 
            nombre_Tipo_Empleado='" & txt_nombre.Text & "', 
            estado_Tipo_Empleado=" & estado & " WHERE codigo_Tipo_Empleado=" & GestionarTipoEmpleado.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Tipo de Empleado editado con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_nombre.Focus()
            Me.Hide()
            GestionarTipoEmpleado.Show()
            con.Close()
        End Try
    End Sub

    Private Sub EditarTipoEmpleado_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM tipo_empleado WHERE codigo_Tipo_Empleado=" & GestionarTipoEmpleado.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_nombre.Text = lector.Item("nombre_Tipo_Empleado").ToString
        If lector.Item("estado_Tipo_Empleado").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_Tipo_Empleado").ToString = "False" Then
            cb_estado.SelectedIndex = 1
        End If
    End Sub
End Class