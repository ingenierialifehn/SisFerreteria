<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCorrelativos
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_estado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_correlativoFinal = New System.Windows.Forms.TextBox()
        Me.txt_correlativoInicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 45)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 45)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_estado
        '
        Me.cb_estado.FormattingEnabled = True
        Me.cb_estado.Location = New System.Drawing.Point(178, 137)
        Me.cb_estado.Name = "cb_estado"
        Me.cb_estado.Size = New System.Drawing.Size(182, 23)
        Me.cb_estado.TabIndex = 13
        Me.cb_estado.Text = "Elija una opción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Estado"
        '
        'txt_correlativoFinal
        '
        Me.txt_correlativoFinal.Location = New System.Drawing.Point(178, 53)
        Me.txt_correlativoFinal.Name = "txt_correlativoFinal"
        Me.txt_correlativoFinal.Size = New System.Drawing.Size(182, 23)
        Me.txt_correlativoFinal.TabIndex = 11
        '
        'txt_correlativoInicial
        '
        Me.txt_correlativoInicial.Location = New System.Drawing.Point(178, 11)
        Me.txt_correlativoInicial.Name = "txt_correlativoInicial"
        Me.txt_correlativoInicial.Size = New System.Drawing.Size(182, 23)
        Me.txt_correlativoInicial.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Correlativo Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Correlativo Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Comentario"
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(178, 99)
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(182, 23)
        Me.txt_comentario.TabIndex = 17
        '
        'RegistrarCorrelativos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_comentario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_correlativoFinal)
        Me.Controls.Add(Me.txt_correlativoInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarCorrelativos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Correlativos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_estado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_correlativoFinal As TextBox
    Friend WithEvents txt_correlativoInicial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_comentario As TextBox
End Class
