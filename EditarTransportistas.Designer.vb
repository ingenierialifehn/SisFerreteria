<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarTransportistas
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_telefonoTransportista = New System.Windows.Forms.TextBox()
        Me.txt_nombreTransportista = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telefonoEmpresa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_estado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombreEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_correoEmpresa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(96, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Datos de la Empresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(96, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 25)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Datos del Transportista"
        '
        'txt_telefonoTransportista
        '
        Me.txt_telefonoTransportista.Location = New System.Drawing.Point(154, 248)
        Me.txt_telefonoTransportista.Name = "txt_telefonoTransportista"
        Me.txt_telefonoTransportista.Size = New System.Drawing.Size(182, 23)
        Me.txt_telefonoTransportista.TabIndex = 48
        '
        'txt_nombreTransportista
        '
        Me.txt_nombreTransportista.Location = New System.Drawing.Point(154, 212)
        Me.txt_nombreTransportista.Name = "txt_nombreTransportista"
        Me.txt_nombreTransportista.Size = New System.Drawing.Size(182, 23)
        Me.txt_nombreTransportista.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 25)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Nombre"
        '
        'txt_telefonoEmpresa
        '
        Me.txt_telefonoEmpresa.Location = New System.Drawing.Point(154, 84)
        Me.txt_telefonoEmpresa.Name = "txt_telefonoEmpresa"
        Me.txt_telefonoEmpresa.Size = New System.Drawing.Size(182, 23)
        Me.txt_telefonoEmpresa.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 25)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Correo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 351)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 45)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 45)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_estado
        '
        Me.cb_estado.FormattingEnabled = True
        Me.cb_estado.Location = New System.Drawing.Point(154, 290)
        Me.cb_estado.Name = "cb_estado"
        Me.cb_estado.Size = New System.Drawing.Size(182, 23)
        Me.cb_estado.TabIndex = 40
        Me.cb_estado.Text = "Elija una opción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(14, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Estado"
        '
        'txt_nombreEmpresa
        '
        Me.txt_nombreEmpresa.Location = New System.Drawing.Point(154, 47)
        Me.txt_nombreEmpresa.Name = "txt_nombreEmpresa"
        Me.txt_nombreEmpresa.Size = New System.Drawing.Size(182, 23)
        Me.txt_nombreEmpresa.TabIndex = 38
        '
        'txt_correoEmpresa
        '
        Me.txt_correoEmpresa.Location = New System.Drawing.Point(154, 126)
        Me.txt_correoEmpresa.Name = "txt_correoEmpresa"
        Me.txt_correoEmpresa.Size = New System.Drawing.Size(182, 23)
        Me.txt_correoEmpresa.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Nombre"
        '
        'EditarTransportistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_telefonoTransportista)
        Me.Controls.Add(Me.txt_nombreTransportista)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_telefonoEmpresa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombreEmpresa)
        Me.Controls.Add(Me.txt_correoEmpresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditarTransportistas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Transportistas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_telefonoTransportista As TextBox
    Friend WithEvents txt_nombreTransportista As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_telefonoEmpresa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_estado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombreEmpresa As TextBox
    Friend WithEvents txt_correoEmpresa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
