<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagoFacturas
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cambio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_idCliente = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_identidad = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_rtn = New System.Windows.Forms.Label()
        Me.lbl_asesor = New System.Windows.Forms.Label()
        Me.lbl_totalventasletras = New System.Windows.Forms.Label()
        Me.lbl_idtransportista = New System.Windows.Forms.Label()
        Me.lbl_idcorrelativo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_pago = New System.Windows.Forms.ComboBox()
        Me.cb_transportista = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 25)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "No. Factura"
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_factura.ForeColor = System.Drawing.Color.Blue
        Me.lbl_factura.Location = New System.Drawing.Point(113, 9)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(0, 25)
        Me.lbl_factura.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Total"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_total.ForeColor = System.Drawing.Color.Blue
        Me.lbl_total.Location = New System.Drawing.Point(61, 46)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 25)
        Me.lbl_total.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Monto"
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(86, 89)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(99, 23)
        Me.txt_monto.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(7, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Cambio"
        '
        'lbl_cambio
        '
        Me.lbl_cambio.AutoSize = True
        Me.lbl_cambio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_cambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_cambio.Location = New System.Drawing.Point(95, 125)
        Me.lbl_cambio.Name = "lbl_cambio"
        Me.lbl_cambio.Size = New System.Drawing.Size(0, 25)
        Me.lbl_cambio.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(7, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 25)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Pago"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 53)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_cliente.Location = New System.Drawing.Point(349, 9)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(0, 25)
        Me.lbl_cliente.TabIndex = 46
        '
        'lbl_idCliente
        '
        Me.lbl_idCliente.AutoSize = True
        Me.lbl_idCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_idCliente.Location = New System.Drawing.Point(407, 65)
        Me.lbl_idCliente.Name = "lbl_idCliente"
        Me.lbl_idCliente.Size = New System.Drawing.Size(107, 25)
        Me.lbl_idCliente.TabIndex = 47
        Me.lbl_idCliente.Text = "No. Factura"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_sucursal.Location = New System.Drawing.Point(407, 105)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(107, 25)
        Me.lbl_sucursal.TabIndex = 48
        Me.lbl_sucursal.Text = "No. Factura"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_fecha.Location = New System.Drawing.Point(407, 147)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(107, 25)
        Me.lbl_fecha.TabIndex = 49
        Me.lbl_fecha.Text = "No. Factura"
        '
        'lbl_identidad
        '
        Me.lbl_identidad.AutoSize = True
        Me.lbl_identidad.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_identidad.Location = New System.Drawing.Point(407, 185)
        Me.lbl_identidad.Name = "lbl_identidad"
        Me.lbl_identidad.Size = New System.Drawing.Size(107, 25)
        Me.lbl_identidad.TabIndex = 50
        Me.lbl_identidad.Text = "No. Factura"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_telefono.Location = New System.Drawing.Point(407, 222)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(107, 25)
        Me.lbl_telefono.TabIndex = 51
        Me.lbl_telefono.Text = "No. Factura"
        '
        'lbl_rtn
        '
        Me.lbl_rtn.AutoSize = True
        Me.lbl_rtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_rtn.Location = New System.Drawing.Point(560, 65)
        Me.lbl_rtn.Name = "lbl_rtn"
        Me.lbl_rtn.Size = New System.Drawing.Size(107, 25)
        Me.lbl_rtn.TabIndex = 52
        Me.lbl_rtn.Text = "No. Factura"
        '
        'lbl_asesor
        '
        Me.lbl_asesor.AutoSize = True
        Me.lbl_asesor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_asesor.Location = New System.Drawing.Point(560, 115)
        Me.lbl_asesor.Name = "lbl_asesor"
        Me.lbl_asesor.Size = New System.Drawing.Size(22, 25)
        Me.lbl_asesor.TabIndex = 53
        Me.lbl_asesor.Text = "1"
        '
        'lbl_totalventasletras
        '
        Me.lbl_totalventasletras.AutoSize = True
        Me.lbl_totalventasletras.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_totalventasletras.Location = New System.Drawing.Point(560, 175)
        Me.lbl_totalventasletras.Name = "lbl_totalventasletras"
        Me.lbl_totalventasletras.Size = New System.Drawing.Size(107, 25)
        Me.lbl_totalventasletras.TabIndex = 54
        Me.lbl_totalventasletras.Text = "No. Factura"
        '
        'lbl_idtransportista
        '
        Me.lbl_idtransportista.AutoSize = True
        Me.lbl_idtransportista.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_idtransportista.Location = New System.Drawing.Point(560, 222)
        Me.lbl_idtransportista.Name = "lbl_idtransportista"
        Me.lbl_idtransportista.Size = New System.Drawing.Size(107, 25)
        Me.lbl_idtransportista.TabIndex = 55
        Me.lbl_idtransportista.Text = "No. Factura"
        '
        'lbl_idcorrelativo
        '
        Me.lbl_idcorrelativo.AutoSize = True
        Me.lbl_idcorrelativo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_idcorrelativo.Location = New System.Drawing.Point(407, 29)
        Me.lbl_idcorrelativo.Name = "lbl_idcorrelativo"
        Me.lbl_idcorrelativo.Size = New System.Drawing.Size(107, 25)
        Me.lbl_idcorrelativo.TabIndex = 56
        Me.lbl_idcorrelativo.Text = "No. Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(3, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Transportista"
        '
        'cb_pago
        '
        Me.cb_pago.FormattingEnabled = True
        Me.cb_pago.Location = New System.Drawing.Point(129, 205)
        Me.cb_pago.Name = "cb_pago"
        Me.cb_pago.Size = New System.Drawing.Size(121, 23)
        Me.cb_pago.TabIndex = 44
        '
        'cb_transportista
        '
        Me.cb_transportista.FormattingEnabled = True
        Me.cb_transportista.Location = New System.Drawing.Point(129, 163)
        Me.cb_transportista.Name = "cb_transportista"
        Me.cb_transportista.Size = New System.Drawing.Size(121, 23)
        Me.cb_transportista.TabIndex = 59
        Me.cb_transportista.Text = "Seleccione un transportista"
        '
        'PagoFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 327)
        Me.Controls.Add(Me.cb_transportista)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_idcorrelativo)
        Me.Controls.Add(Me.lbl_idtransportista)
        Me.Controls.Add(Me.lbl_totalventasletras)
        Me.Controls.Add(Me.lbl_asesor)
        Me.Controls.Add(Me.lbl_rtn)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_identidad)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Controls.Add(Me.lbl_idCliente)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_pago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_cambio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_factura)
        Me.Controls.Add(Me.Label9)
        Me.Name = "PagoFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago Facturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_factura As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_monto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cambio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_idCliente As Label
    Friend WithEvents lbl_sucursal As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_identidad As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_rtn As Label
    Friend WithEvents lbl_asesor As Label
    Friend WithEvents lbl_totalventasletras As Label
    Friend WithEvents lbl_idtransportista As Label
    Friend WithEvents lbl_idcorrelativo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_pago As ComboBox
    Friend WithEvents cb_transportista As ComboBox
End Class
