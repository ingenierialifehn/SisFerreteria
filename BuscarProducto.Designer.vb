<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProducto
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
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvBuscarProducto = New System.Windows.Forms.DataGridView()
        CType(Me.DgvBuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(159, 4)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(142, 23)
        Me.txt_buscar.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Buscar Producto"
        '
        'DgvBuscarProducto
        '
        Me.DgvBuscarProducto.AllowUserToAddRows = False
        Me.DgvBuscarProducto.AllowUserToDeleteRows = False
        Me.DgvBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBuscarProducto.Location = New System.Drawing.Point(12, 38)
        Me.DgvBuscarProducto.Name = "DgvBuscarProducto"
        Me.DgvBuscarProducto.ReadOnly = True
        Me.DgvBuscarProducto.RowTemplate.Height = 25
        Me.DgvBuscarProducto.Size = New System.Drawing.Size(800, 312)
        Me.DgvBuscarProducto.TabIndex = 14
        '
        'BuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 370)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvBuscarProducto)
        Me.Name = "BuscarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Producto"
        CType(Me.DgvBuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvBuscarProducto As DataGridView
End Class
