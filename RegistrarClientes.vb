Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RegistrarClientes
    Private Sub RegistrarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado.Items.Add("Activo")
        cb_estado.Items.Add("Inactivo")
        cb_libreISV.Items.Add("Si")
        cb_libreISV.Items.Add("No")
    End Sub
    Dim estado As Integer
    Dim libreDeISV As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cb_estado.SelectedItem = "Activo" Then
            estado = 1
        Else
            estado = 0
        End If
        If Me.cb_libreISV.SelectedItem = "Si" Then
            libreDeISV = 1
        Else
            libreDeISV = 0
        End If
        AbrirConexion()
        Try
            Dim insertarProductos As String = "INSERT INTO cliente(nombre_cliente,
            correo_cliente,telefono_cliente,identidad_cliente,rtn_cliente,libre_impuesto_cliente,
            estado_cliente)
            VALUES('" & txt_nombre.Text & "','" & txt_correo.Text & "',
            " & txt_telefono.Text & ",'" & txt_identidad.Text & "',
            '" & txt_rtn.Text & "','" & libreDeISV & "',
            '" & estado & "')"
            Dim cmd = New SqlCommand(insertarProductos, Conexion.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            MsgBox("Cliente guardado con éxito", vbReadOnly, "SisFerreteria")
            txt_nombre.Text = ""
            txt_telefono.Text = ""
            txt_identidad.Text = ""
            txt_rtn.Text = ""
            txt_correo.Text = ""
            txt_identidad.Focus()
            con.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Clientes.Show()
    End Sub
End Class