<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCliente
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
        Me.DgvBuscarCliente = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBuscarCliente
        '
        Me.DgvBuscarCliente.AllowUserToAddRows = False
        Me.DgvBuscarCliente.AllowUserToDeleteRows = False
        Me.DgvBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBuscarCliente.Location = New System.Drawing.Point(12, 45)
        Me.DgvBuscarCliente.Name = "DgvBuscarCliente"
        Me.DgvBuscarCliente.ReadOnly = True
        Me.DgvBuscarCliente.RowTemplate.Height = 25
        Me.DgvBuscarCliente.Size = New System.Drawing.Size(800, 312)
        Me.DgvBuscarCliente.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Buscar Cliente"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(150, 12)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(142, 23)
        Me.txt_buscar.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 26)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Agregar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 376)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvBuscarCliente)
        Me.Name = "BuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        CType(Me.DgvBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvBuscarCliente As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Button1 As Button
End Class
