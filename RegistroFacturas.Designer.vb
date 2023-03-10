<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_identidad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_rtn = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_codigoCliente = New System.Windows.Forms.Label()
        Me.cb_sucursal = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_correlativo = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_idCorrelativo = New System.Windows.Forms.Label()
        Me.Col_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(788, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 43)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar Cliente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_fecha.Location = New System.Drawing.Point(83, 3)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(0, 25)
        Me.lbl_fecha.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cliente"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_cliente.Location = New System.Drawing.Point(110, 90)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(0, 25)
        Me.lbl_cliente.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Identidad"
        '
        'lbl_identidad
        '
        Me.lbl_identidad.AutoSize = True
        Me.lbl_identidad.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_identidad.Location = New System.Drawing.Point(110, 115)
        Me.lbl_identidad.Name = "lbl_identidad"
        Me.lbl_identidad.Size = New System.Drawing.Size(0, 25)
        Me.lbl_identidad.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "RTN"
        '
        'lbl_rtn
        '
        Me.lbl_rtn.AutoSize = True
        Me.lbl_rtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_rtn.Location = New System.Drawing.Point(114, 140)
        Me.lbl_rtn.Name = "lbl_rtn"
        Me.lbl_rtn.Size = New System.Drawing.Size(0, 25)
        Me.lbl_rtn.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Cantidad, Me.Col_Unidad, Me.Col_codigo, Me.Col_descripcion, Me.Col_precio, Me.ColumnaTotal})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(839, 332)
        Me.DataGridView1.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(627, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 43)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Agregar Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(711, 515)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Total L "
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_total.Location = New System.Drawing.Point(769, 515)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(52, 25)
        Me.lbl_total.TabIndex = 27
        Me.lbl_total.Text = "Total"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(742, 134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 43)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Facturar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(137, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Código Cliente"
        '
        'lbl_codigoCliente
        '
        Me.lbl_codigoCliente.AutoSize = True
        Me.lbl_codigoCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_codigoCliente.Location = New System.Drawing.Point(150, 65)
        Me.lbl_codigoCliente.Name = "lbl_codigoCliente"
        Me.lbl_codigoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_codigoCliente.Size = New System.Drawing.Size(22, 25)
        Me.lbl_codigoCliente.TabIndex = 30
        Me.lbl_codigoCliente.Text = "1"
        '
        'cb_sucursal
        '
        Me.cb_sucursal.FormattingEnabled = True
        Me.cb_sucursal.Location = New System.Drawing.Point(430, 5)
        Me.cb_sucursal.Name = "cb_sucursal"
        Me.cb_sucursal.Size = New System.Drawing.Size(109, 23)
        Me.cb_sucursal.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(341, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Sucursal"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_sucursal.Location = New System.Drawing.Point(545, 3)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sucursal.TabIndex = 33
        Me.lbl_sucursal.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(551, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 25)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "No. Factura"
        '
        'lbl_correlativo
        '
        Me.lbl_correlativo.AutoSize = True
        Me.lbl_correlativo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_correlativo.Location = New System.Drawing.Point(651, 3)
        Me.lbl_correlativo.Name = "lbl_correlativo"
        Me.lbl_correlativo.Size = New System.Drawing.Size(0, 25)
        Me.lbl_correlativo.TabIndex = 35
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_telefono.Location = New System.Drawing.Point(341, 65)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(0, 25)
        Me.lbl_telefono.TabIndex = 36
        Me.lbl_telefono.Visible = False
        '
        'lbl_idCorrelativo
        '
        Me.lbl_idCorrelativo.AutoSize = True
        Me.lbl_idCorrelativo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_idCorrelativo.Location = New System.Drawing.Point(363, 65)
        Me.lbl_idCorrelativo.Name = "lbl_idCorrelativo"
        Me.lbl_idCorrelativo.Size = New System.Drawing.Size(118, 25)
        Me.lbl_idCorrelativo.TabIndex = 37
        Me.lbl_idCorrelativo.Text = "idcorrelativo"
        Me.lbl_idCorrelativo.Visible = False
        '
        'Col_Cantidad
        '
        Me.Col_Cantidad.FillWeight = 1000.0!
        Me.Col_Cantidad.HeaderText = "Cantidad"
        Me.Col_Cantidad.Name = "Col_Cantidad"
        '
        'Col_Unidad
        '
        Me.Col_Unidad.HeaderText = "Unidad"
        Me.Col_Unidad.Name = "Col_Unidad"
        Me.Col_Unidad.ReadOnly = True
        '
        'Col_codigo
        '
        Me.Col_codigo.HeaderText = "Código"
        Me.Col_codigo.Name = "Col_codigo"
        Me.Col_codigo.ReadOnly = True
        '
        'Col_descripcion
        '
        Me.Col_descripcion.HeaderText = "Descripción"
        Me.Col_descripcion.Name = "Col_descripcion"
        Me.Col_descripcion.ReadOnly = True
        '
        'Col_precio
        '
        Me.Col_precio.HeaderText = "Precio Unitario"
        Me.Col_precio.Name = "Col_precio"
        Me.Col_precio.ReadOnly = True
        '
        'ColumnaTotal
        '
        Me.ColumnaTotal.HeaderText = "Total"
        Me.ColumnaTotal.Name = "ColumnaTotal"
        Me.ColumnaTotal.ReadOnly = True
        '
        'RegistroFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_idCorrelativo)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_correlativo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cb_sucursal)
        Me.Controls.Add(Me.lbl_codigoCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_rtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_identidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "RegistroFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Facturas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_identidad As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_rtn As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_codigoCliente As Label
    Friend WithEvents cb_sucursal As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_sucursal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_correlativo As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_idCorrelativo As Label
    Friend WithEvents Col_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Col_Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Col_codigo As DataGridViewTextBoxColumn
    Friend WithEvents Col_descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Col_precio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaTotal As DataGridViewTextBoxColumn
End Class
