Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditarTransportistas
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub EditarTransportistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
    End Sub

    Private Sub EditarTransportistas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM transportista WHERE codigo_transportista=" & GestionarTransportistas.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_nombreEmpresa.Text = lector.Item("nombre_empresa_transportista").ToString
        txt_telefonoEmpresa.Text = lector.Item("telefono_empresa_transportista").ToString
        txt_correoEmpresa.Text = lector.Item("correo_empresa_transportista").ToString
        txt_nombreTransportista.Text = lector.Item("nombre_transportista").ToString
        txt_telefonoTransportista.Text = lector.Item("telefono_transportista").ToString
        If lector.Item("estado_transportista").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_transportista").ToString = "False" Then
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
            Dim editarSucursales As String = "UPDATE transportista set 
            nombre_empresa_transportista='" & txt_nombreEmpresa.Text & "', 
            telefono_empresa_transportista='" & txt_telefonoEmpresa.Text & "', 
            correo_empresa_transportista='" & txt_correoEmpresa.Text & "',
            nombre_transportista='" & txt_nombreTransportista.Text & "',
            telefono_transportista='" & txt_telefonoTransportista.Text & "',
            estado_transportista=" & estado & " 
            WHERE codigo_transportista=" & GestionarTransportistas.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Transportista editado con éxito", vbReadOnly, "SisFerreteria")
            txt_nombreEmpresa.Text = ""
            txt_telefonoEmpresa.Text = ""
            txt_correoEmpresa.Text = ""
            txt_nombreTransportista.Text = ""
            txt_telefonoTransportista.Text = ""
            txt_nombreEmpresa.Focus()
            Me.Hide()
            GestionarTransportistas.Show()
            con.Close()
        End Try
    End Sub
End Class