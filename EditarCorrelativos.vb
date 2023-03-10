Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditarCorrelativos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub EditarCorrelativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
    End Sub

    Private Sub EditarCorrelativos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM correlativo WHERE codigo_correlativo=" & GestionarCorrelativos.codigo_editar & ""
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        txt_correlativoInicial.Text = lector.Item("numero_correlativo_inicial").ToString
        txt_correlativoFinal.Text = lector.Item("numero_correlativo_final").ToString
        txt_comentario.Text = lector.Item("comentario_correlativo").ToString
        If lector.Item("estado_correlativo").ToString = "True" Then
            cb_estado.SelectedIndex = 0
        End If
        If lector.Item("estado_correlativo").ToString = "False" Then
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
            Dim editarSucursales As String = "UPDATE correlativo set 
            numero_correlativo_inicial='" & txt_correlativoInicial.Text & "', 
            numero_correlativo_final='" & txt_correlativoFinal.Text & "', 
            comentario_correlativo='" & txt_comentario.Text & "',
            estado_correlativo=" & estado & " 
            WHERE codigo_correlativo=" & GestionarCorrelativos.codigo_editar & ""
            Dim cmd = New SqlCommand(editarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Correlativo editado con éxito", vbReadOnly, "SisFerreteria")
            txt_comentario.Text = ""
            txt_correlativoInicial.Text = ""
            txt_correlativoFinal.Text = ""
            txt_correlativoInicial.Focus()
            Me.Hide()
            GestionarCorrelativos.Show()
            con.Close()
        End Try
    End Sub
End Class