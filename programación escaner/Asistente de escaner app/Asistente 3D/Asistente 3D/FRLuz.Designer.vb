<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRLuz
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBManual = New System.Windows.Forms.CheckBox()
        Me.TBLuz = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBAlto = New System.Windows.Forms.CheckBox()
        Me.CBBajo = New System.Windows.Forms.CheckBox()
        Me.CBMedio = New System.Windows.Forms.CheckBox()
        Me.SPEscaner = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBLuz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 62)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBManual)
        Me.GroupBox1.Controls.Add(Me.TBLuz)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBAlto)
        Me.GroupBox1.Controls.Add(Me.CBBajo)
        Me.GroupBox1.Controls.Add(Me.CBMedio)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 189)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nivel de iluminación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Intensidad ="
        '
        'CBManual
        '
        Me.CBManual.AutoSize = True
        Me.CBManual.Location = New System.Drawing.Point(222, 65)
        Me.CBManual.Name = "CBManual"
        Me.CBManual.Size = New System.Drawing.Size(61, 17)
        Me.CBManual.TabIndex = 5
        Me.CBManual.Text = "Manual"
        Me.CBManual.UseVisualStyleBackColor = True
        '
        'TBLuz
        '
        Me.TBLuz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TBLuz.LargeChange = 10
        Me.TBLuz.Location = New System.Drawing.Point(142, 88)
        Me.TBLuz.Maximum = 255
        Me.TBLuz.Name = "TBLuz"
        Me.TBLuz.Size = New System.Drawing.Size(267, 45)
        Me.TBLuz.SmallChange = 5
        Me.TBLuz.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Indique el nivel de intensidad de luz que requiere."
        '
        'CBAlto
        '
        Me.CBAlto.AutoSize = True
        Me.CBAlto.Location = New System.Drawing.Point(37, 70)
        Me.CBAlto.Name = "CBAlto"
        Me.CBAlto.Size = New System.Drawing.Size(44, 17)
        Me.CBAlto.TabIndex = 0
        Me.CBAlto.Text = "Alto"
        Me.CBAlto.UseVisualStyleBackColor = True
        '
        'CBBajo
        '
        Me.CBBajo.AutoSize = True
        Me.CBBajo.Location = New System.Drawing.Point(37, 116)
        Me.CBBajo.Name = "CBBajo"
        Me.CBBajo.Size = New System.Drawing.Size(47, 17)
        Me.CBBajo.TabIndex = 2
        Me.CBBajo.Text = "Bajo"
        Me.CBBajo.UseVisualStyleBackColor = True
        '
        'CBMedio
        '
        Me.CBMedio.AutoSize = True
        Me.CBMedio.Location = New System.Drawing.Point(37, 93)
        Me.CBMedio.Name = "CBMedio"
        Me.CBMedio.Size = New System.Drawing.Size(55, 17)
        Me.CBMedio.TabIndex = 1
        Me.CBMedio.Text = "Medio"
        Me.CBMedio.UseVisualStyleBackColor = True
        '
        'SPEscaner
        '
        Me.SPEscaner.PortName = "COM3"
        '
        'FRLuz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(701, 310)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRLuz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASISTENTE DE ESCANEO 3D"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBLuz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBManual As CheckBox
    Friend WithEvents TBLuz As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents CBAlto As CheckBox
    Friend WithEvents CBBajo As CheckBox
    Friend WithEvents CBMedio As CheckBox
    Friend WithEvents SPEscaner As IO.Ports.SerialPort
End Class
