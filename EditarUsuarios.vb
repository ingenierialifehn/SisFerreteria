Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditarUsuarios
    Dim estado As Integer
    Dim tipo As String
    Dim u As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub EditarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim consultaTipoEmpleado As String = "SELECT * FROM tipo_empleado"
        Dim cmd = New SqlCommand(consultaTipoEmpleado, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        While lector.Read
            cb_tipo.Items.Add(lector.Item("nombre_tipo_empleado").ToString)
        End While
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
        con.Close()
    End Sub
    Private Sub EditarUsuarios_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM usuario WHERE codigo_usuario=" & GestionarUsuarios.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_usuario.Text = lector.Item("usuario").ToString
        txt_contraseña.Text = lector.Item("contrasena_usuario").ToString
        Dim tipo As String = lector.Item("codigo_empleado_usuario")
        If lector.Item("estado_usuario").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_usuario").ToString = "False" Then
            cb_estado.SelectedIndex = 1
        End If
        con.Close()
        '
        AbrirConexion()
        Dim conMedida As String = "SELECT * FROM tipo_empleado WHERE codigo_Tipo_Empleado=" & tipo & ""
        Dim cd = New SqlCommand(conMedida, Conexion.con)
        Dim lector4 As SqlDataReader
        lector4 = cd.ExecuteReader
        lector4.Read()
        Dim valorTipo As String = lector4.Item("nombre_Tipo_Empleado").ToString
        For x = 0 To cb_tipo.Items.Count - 1
            If cb_tipo.Items(x) = valorTipo Then
                cb_tipo.SelectedIndex = x
            End If
        Next
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
        tipo = Trim(Me.cb_tipo.SelectedItem)
        Dim consultaUnidad As String = "SELECT codigo_Tipo_Empleado FROM tipo_empleado WHERE 
        nombre_Tipo_Empleado='" & tipo & "'"
        Dim cmd2 = New SqlCommand(consultaUnidad, Conexion.con)
        Dim lector2 As SqlDataReader
        lector2 = cmd2.ExecuteReader
        lector2.Read()
        u = lector2.Item("codigo_Tipo_Empleado").ToString()
        con.Close()
        AbrirConexion()
        Try
            Dim editarSucursales As String = "UPDATE usuario set 
            usuario='" & txt_usuario.Text & "', 
            contrasena_usuario='" & txt_contraseña.Text & "', 
            codigo_empleado_usuario=" & u & ",
            estado_usuario='" & estado & "'
            WHERE codigo_usuario=" & GestionarUsuarios.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Usuario editado con éxito", vbReadOnly, "SisFerreteria")
            Me.Hide()
            GestionarUsuarios.Show()
            con.Close()
        End Try
    End Sub
End Class