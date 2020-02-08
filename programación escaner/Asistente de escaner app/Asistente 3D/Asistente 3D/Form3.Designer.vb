<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ESTADO = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NuevaPosicion = New System.Windows.Forms.Button()
        Me.ESTADO.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(314, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FINALIZADO"
        '
        'ESTADO
        '
        Me.ESTADO.Controls.Add(Me.ProgressBar1)
        Me.ESTADO.Controls.Add(Me.Label1)
        Me.ESTADO.Location = New System.Drawing.Point(157, 12)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(385, 89)
        Me.ESTADO.TabIndex = 5
        Me.ESTADO.TabStop = False
        Me.ESTADO.Text = "ESCANEANDO"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(78, 60)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(272, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Su pieza se esta escaneando." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cuando se le indique por favor seleccione la sigu" &
    "iente posición."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.NuevaPosicion)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 160)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POSICIONES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Finalizar captura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NuevaPosicion
        '
        Me.NuevaPosicion.Location = New System.Drawing.Point(30, 47)
        Me.NuevaPosicion.Name = "NuevaPosicion"
        Me.NuevaPosicion.Size = New System.Drawing.Size(91, 52)
        Me.NuevaPosicion.TabIndex = 0
        Me.NuevaPosicion.Text = "Nueva posición"
        Me.NuevaPosicion.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(701, 310)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ESTADO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "ASISTENTE DE ESCANEO 3D"
        Me.ESTADO.ResumeLayout(False)
        Me.ESTADO.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ESTADO As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NuevaPosicion As Button
End Class
