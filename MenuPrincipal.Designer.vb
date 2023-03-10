<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_factura = New System.Windows.Forms.Button()
        Me.btn_sucursal = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.btn_personas = New System.Windows.Forms.Button()
        Me.btn_correlativos = New System.Windows.Forms.Button()
        Me.btn_transportistas = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_factura
        '
        Me.btn_factura.Location = New System.Drawing.Point(43, 30)
        Me.btn_factura.Name = "btn_factura"
        Me.btn_factura.Size = New System.Drawing.Size(151, 102)
        Me.btn_factura.TabIndex = 0
        Me.btn_factura.Text = "Factura"
        Me.btn_factura.UseVisualStyleBackColor = True
        '
        'btn_sucursal
        '
        Me.btn_sucursal.Location = New System.Drawing.Point(256, 30)
        Me.btn_sucursal.Name = "btn_sucursal"
        Me.btn_sucursal.Size = New System.Drawing.Size(151, 102)
        Me.btn_sucursal.TabIndex = 1
        Me.btn_sucursal.Text = "Sucursal"
        Me.btn_sucursal.UseVisualStyleBackColor = True
        '
        'btn_productos
        '
        Me.btn_productos.Location = New System.Drawing.Point(492, 30)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(151, 102)
        Me.btn_productos.TabIndex = 2
        Me.btn_productos.Text = "Productos"
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'btn_personas
        '
        Me.btn_personas.Location = New System.Drawing.Point(43, 176)
        Me.btn_personas.Name = "btn_personas"
        Me.btn_personas.Size = New System.Drawing.Size(151, 102)
        Me.btn_personas.TabIndex = 3
        Me.btn_personas.Text = "Personas"
        Me.btn_personas.UseVisualStyleBackColor = True
        '
        'btn_correlativos
        '
        Me.btn_correlativos.Location = New System.Drawing.Point(256, 176)
        Me.btn_correlativos.Name = "btn_correlativos"
        Me.btn_correlativos.Size = New System.Drawing.Size(151, 102)
        Me.btn_correlativos.TabIndex = 4
        Me.btn_correlativos.Text = "Correlativos"
        Me.btn_correlativos.UseVisualStyleBackColor = True
        '
        'btn_transportistas
        '
        Me.btn_transportistas.Location = New System.Drawing.Point(492, 176)
        Me.btn_transportistas.Name = "btn_transportistas"
        Me.btn_transportistas.Size = New System.Drawing.Size(151, 102)
        Me.btn_transportistas.TabIndex = 5
        Me.btn_transportistas.Text = "Transportistas"
        Me.btn_transportistas.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(665, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.MenuToolStripMenuItem.Text = "Menu "
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 296)
        Me.Controls.Add(Me.btn_transportistas)
        Me.Controls.Add(Me.btn_correlativos)
        Me.Controls.Add(Me.btn_personas)
        Me.Controls.Add(Me.btn_productos)
        Me.Controls.Add(Me.btn_sucursal)
        Me.Controls.Add(Me.btn_factura)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_factura As Button
    Friend WithEvents btn_sucursal As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents btn_personas As Button
    Friend WithEvents btn_correlativos As Button
    Friend WithEvents btn_transportistas As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
