Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_factura_Click(sender As Object, e As EventArgs) Handles btn_factura.Click
        Me.Hide()
        Facturas.Show()
    End Sub

    Private Sub btn_sucursal_Click(sender As Object, e As EventArgs) Handles btn_sucursal.Click
        Me.Hide()
        Sucursales.Show()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub btn_personas_Click(sender As Object, e As EventArgs) Handles btn_personas.Click
        Me.Hide()
        Personas.Show()
    End Sub

    Private Sub btn_correlativos_Click(sender As Object, e As EventArgs) Handles btn_correlativos.Click
        Me.Hide()
        Correlativos.Show()
    End Sub

    Private Sub btn_transportistas_Click(sender As Object, e As EventArgs) Handles btn_transportistas.Click
        Me.Hide()
        Transportistas.Show()
    End Sub
End Class