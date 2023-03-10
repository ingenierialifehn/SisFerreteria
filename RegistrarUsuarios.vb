Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarUsuarios
    Dim estado As Integer
    Dim tipo As String
    Dim u As String
    Private Sub cb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo.SelectedIndexChanged

    End Sub

    Private Sub RegistrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Usuarios.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tipo = Trim(Me.cb_tipo.SelectedItem)
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
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
            Dim insertarUsuarios As String = "INSERT INTO usuario(usuario,contrasena_usuario,
            codigo_empleado_usuario,estado_usuario) VALUES('" & txt_usuario.Text & "',
            '" & txt_contraseña.Text & "'," & Val(u) & ",'" & estado & "')"
            Dim cmd = New SqlCommand(insertarUsuarios, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Usuario guardado con éxito", vbReadOnly, "SisFerreteria")
            txt_usuario.Text = ""
            txt_contraseña.Text = ""
            txt_usuario.Focus()
            con.Close()
        End Try
    End Sub
End Class