Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarTransportistas
    Dim estado As Integer
    Private Sub RegistrarTransportistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Transportistas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
        Try
            Dim insertarSucursales As String = "INSERT INTO transportista (nombre_empresa_transportista,
            telefono_empresa_transportista,correo_empresa_transportista,nombre_transportista,
            telefono_transportista,estado_transportista) 
            VALUES('" & txt_nombreEmpresa.Text & "','" & txt_telefonoEmpresa.Text & "',
            '" & txt_correoEmpresa.Text & "','" & txt_nombreTransportista.Text & "',
            '" & txt_telefonoTransportista.Text & "'," & estado & ")"
            Dim cmd = New SqlCommand(insertarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Transportista guardado con éxito", vbReadOnly, "SisFerreteria")
            txt_nombreEmpresa.Text = ""
            txt_telefonoEmpresa.Text = ""
            txt_correoEmpresa.Text = ""
            txt_nombreTransportista.Text = ""
            txt_telefonoTransportista.Text = ""
            txt_nombreEmpresa.Focus()
            con.Close()
        End Try
    End Sub
End Class