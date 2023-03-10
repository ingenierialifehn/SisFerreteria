<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarClientes
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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_estado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_rtn = New System.Windows.Forms.TextBox()
        Me.txt_identidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_libreISV = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(178, 109)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(182, 23)
        Me.txt_nombre.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Teléfono"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 45)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 45)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_estado
        '
        Me.cb_estado.FormattingEnabled = True
        Me.cb_estado.Location = New System.Drawing.Point(178, 317)
        Me.cb_estado.Name = "cb_estado"
        Me.cb_estado.Size = New System.Drawing.Size(182, 23)
        Me.cb_estado.TabIndex = 23
        Me.cb_estado.Text = "Elija una opción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(14, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Estado"
        '
        'txt_rtn
        '
        Me.txt_rtn.Location = New System.Drawing.Point(178, 63)
        Me.txt_rtn.Name = "txt_rtn"
        Me.txt_rtn.Size = New System.Drawing.Size(182, 23)
        Me.txt_rtn.TabIndex = 21
        '
        'txt_identidad
        '
        Me.txt_identidad.Location = New System.Drawing.Point(178, 21)
        Me.txt_identidad.Name = "txt_identidad"
        Me.txt_identidad.Size = New System.Drawing.Size(182, 23)
        Me.txt_identidad.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(9, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Correo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(9, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(14, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "RTN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(9, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 25)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Identidad"
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(178, 215)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(182, 23)
        Me.txt_correo.TabIndex = 30
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(178, 161)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(182, 23)
        Me.txt_telefono.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Libre de Impuesto"
        '
        'cb_libreISV
        '
        Me.cb_libreISV.FormattingEnabled = True
        Me.cb_libreISV.Location = New System.Drawing.Point(178, 261)
        Me.cb_libreISV.Name = "cb_libreISV"
        Me.cb_libreISV.Size = New System.Drawing.Size(182, 23)
        Me.cb_libreISV.TabIndex = 33
        Me.cb_libreISV.Text = "Elija una opción"
        '
        'RegistrarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.cb_libreISV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_rtn)
        Me.Controls.Add(Me.txt_identidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_estado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_rtn As TextBox
    Friend WithEvents txt_identidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_libreISV As ComboBox
End Class
