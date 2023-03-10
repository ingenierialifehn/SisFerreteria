Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditarEmpleado
    Private Sub EditarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim consultaSexo As String = "SELECT * FROM sexo"
        Dim cmd = New SqlCommand(consultaSexo, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        While lector.Read
            cb_sexo.Items.Add(lector.Item("nombre_sexo").ToString)
        End While
        con.Close()
        AbrirConexion()
        Dim consultaTipoEmpleado As String = "SELECT * FROM tipo_empleado"
        Dim cmdTipoEmpleado = New SqlCommand(consultaTipoEmpleado, Conexion.con)
        Dim lectorTipoEmpleado As SqlDataReader
        lectorTipoEmpleado = cmdTipoEmpleado.ExecuteReader
        While lectorTipoEmpleado.Read
            cb_tipo.Items.Add(lectorTipoEmpleado.Item("nombre_Tipo_Empleado").ToString)
        End While
        con.Close()
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
        con.Close()
    End Sub

    Private Sub EditarEmpleado_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM empleado WHERE codigo_empleado=" & GestionarEmpleado.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_nombre.Text = lector.Item("nombre_empleado").ToString
        txt_telefono.Text = lector.Item("telefono_empleado").ToString
        txt_correo.Text = lector.Item("correo_empleado").ToString
        Dim tipo As String = lector.Item("tipo_empleado")
        If lector.Item("estado_empleado").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_empleado").ToString = "False" Then
            cb_estado.SelectedIndex = 1
        End If
        If lector.Item("sexo_empleado").ToString = 1 Then
            cb_sexo.SelectedIndex = 0
        End If
        If lector.Item("sexo_empleado").ToString = 2 Then
            cb_sexo.SelectedIndex = 1
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
    Dim estado As Integer
    Dim tipo As String
    Dim u As String
    Dim sexo As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        If Me.cb_sexo.SelectedItem = "Masculino" Then
            sexo = 1
        Else
            sexo = 2
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
            Dim editarSucursales As String = "UPDATE empleado set 
            nombre_empleado='" & txt_nombre.Text & "', 
            correo_empleado='" & txt_correo.Text & "', 
            tipo_empleado=" & u & ",
            telefono_empleado='" & txt_telefono.Text & "',
            sexo_empleado='" & sexo & "',
            estado_empleado='" & estado & "'
            WHERE codigo_empleado=" & GestionarEmpleado.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Empleado editado con éxito", vbReadOnly, "SisFerreteria")
            Me.Hide()
            GestionarEmpleado.Show()
            con.Close()
        End Try
    End Sub
End Class