Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_usuario.Focus()
    End Sub
    Public usuarioLogeado As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirConexion()
        Dim consultaUsuarios As String = "SELECT * FROM usuario WHERE 
        usuario='" & txt_usuario.Text & "' and contrasena_usuario='" & txt_contraseña.Text & "'"
        Dim cmd = New SqlCommand(consultaUsuarios, Conexion.con)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader
        lector.Read()
        If lector.HasRows Then
            Me.Hide()
            usuarioLogeado = lector.Item("codigo_empleado_usuario").ToString()
            MenuPrincipal.Show()
            txt_usuario.Text = ""
            txt_contraseña.Text = ""
            txt_usuario.Focus()
        Else
            MsgBox("Usuario y/o contraseña incorrectos. Por favor intente de nuevo")
            txt_usuario.Text = ""
            txt_contraseña.Text = ""
            txt_usuario.Focus()
        End If
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_usuario.Focus()
    End Sub

    Private Sub Login_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        txt_usuario.Focus()
    End Sub
End Class
