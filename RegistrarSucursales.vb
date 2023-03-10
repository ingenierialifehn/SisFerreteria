Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarSucursales
    Dim estado As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RegistrarSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Sucursales.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
        Try
            Dim insertarSucursales As String = "INSERT INTO sucursales (nombre_sucursal, direccion_sucursal, estado_sucursal) 
            VALUES('" & txt_nombre.Text & "','" & txt_direccion.Text & "'," & estado & ")"
            Dim cmd = New SqlCommand(insertarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Sucursal guardada con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_direccion.Text = ""
            txt_nombre.Focus()
            con.Close()
        End Try
    End Sub

    Private Sub RegistrarSucursales_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class