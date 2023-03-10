Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarEmpleados
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RegistrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Personas.Show()
    End Sub
    Dim estado, sexo As Integer
    Dim nombre, u As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = Trim(Me.cb_tipo.SelectedItem)
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
        Dim consultaUnidad As String = "SELECT codigo_Tipo_Empleado FROM tipo_empleado WHERE 
        nombre_Tipo_Empleado='" & nombre & "'"
        Dim cmd2 = New SqlCommand(consultaUnidad, Conexion.con)
        Dim lector2 As SqlDataReader
        lector2 = cmd2.ExecuteReader
        lector2.Read()
        u = lector2.Item("codigo_Tipo_Empleado").ToString()
        con.Close()
        AbrirConexion()
        Try
            Dim insertarProductos As String = "INSERT INTO empleado(nombre_empleado,
            correo_empleado,telefono_empleado,sexo_empleado,tipo_empleado,estado_empleado)
            VALUES('" & txt_nombre.Text & "','" & txt_correo.Text & "',
            " & txt_telefono.Text & ",'" & sexo & "','" & Val(u) & "',
            '" & estado & "')"
            Dim cmd = New SqlCommand(insertarProductos, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Empleado guardado con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_telefono.Text = ""
            txt_correo.Text = ""
            txt_nombre.Focus()
            con.Close()
        End Try
    End Sub
End Class