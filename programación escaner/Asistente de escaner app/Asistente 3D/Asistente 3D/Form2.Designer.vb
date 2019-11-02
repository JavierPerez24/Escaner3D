<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRLuz
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.TrackBar_Iluminacion = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SPEscaner = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar_Iluminacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.TrackBar_Iluminacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
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
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(222, 65)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox4.TabIndex = 5
        Me.CheckBox4.Text = "Manual"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'TrackBar_Iluminacion
        '
        Me.TrackBar_Iluminacion.Location = New System.Drawing.Point(133, 88)
        Me.TrackBar_Iluminacion.Maximum = 100
        Me.TrackBar_Iluminacion.Name = "TrackBar_Iluminacion"
        Me.TrackBar_Iluminacion.Size = New System.Drawing.Size(267, 45)
        Me.TrackBar_Iluminacion.TabIndex = 4
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(37, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(44, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Alto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(37, 116)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Bajo"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(37, 93)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Medio"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'FRLuz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 310)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRLuz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASISTENTE DE ESCANEO 3D"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar_Iluminacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents TrackBar_Iluminacion As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents SPEscaner As IO.Ports.SerialPort
End Class
