Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarCorrelativos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Correlativos.Show()
    End Sub

    Private Sub RegistrarCorrelativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim insertarSucursales As String = "INSERT INTO correlativo (numero_correlativo_inicial,
            numero_correlativo_final,comentario_correlativo,estado_correlativo) 
            VALUES('" & txt_correlativoInicial.Text & "','" & txt_correlativoFinal.Text & "',
            '" & txt_comentario.Text & "'," & estado & ")"
            Dim cmd = New SqlCommand(insertarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Correlativo guardado con éxito", vbReadOnly, "SisFerreteria")
            txt_comentario.Text = ""
            txt_correlativoInicial.Text = ""
            txt_correlativoFinal.Text = ""
            txt_correlativoInicial.Focus()
            con.Close()
        End Try
    End Sub
End Class