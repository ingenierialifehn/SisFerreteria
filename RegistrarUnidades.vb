﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarUnidades
    Dim estado As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UnidadesDeMedida.Show()
    End Sub

    Private Sub RegistrarUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        AbrirConexion()
        Try
            Dim insertarSucursales As String = "INSERT INTO unidad_medida (nombre_unidad_medida, descripcion_unidad_medida, estado_unidad_medida) 
            VALUES('" & txt_nombre.Text & "','" & txt_descripcion.Text & "'," & estado & ")"
            Dim cmd = New SqlCommand(insertarSucursales, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Unidad de Medida guardada con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_descripcion.Text = ""
            txt_nombre.Focus()
            con.Close()
        End Try
    End Sub
End Class