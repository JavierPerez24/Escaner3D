<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CANCEL1 = New System.Windows.Forms.Button()
        Me.OK1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SPEscaner = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CANCEL1)
        Me.GroupBox2.Controls.Add(Me.OK1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 173)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ASISTENTE DE ESCANEO 3D"
        '
        'CANCEL1
        '
        Me.CANCEL1.Location = New System.Drawing.Point(463, 105)
        Me.CANCEL1.Name = "CANCEL1"
        Me.CANCEL1.Size = New System.Drawing.Size(119, 38)
        Me.CANCEL1.TabIndex = 5
        Me.CANCEL1.Text = "Cancelar"
        Me.CANCEL1.UseVisualStyleBackColor = True
        '
        'OK1
        '
        Me.OK1.Location = New System.Drawing.Point(316, 105)
        Me.OK1.Name = "OK1"
        Me.OK1.Size = New System.Drawing.Size(119, 38)
        Me.OK1.TabIndex = 4
        Me.OK1.Text = "OK"
        Me.OK1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "- Conecte el cabe USB al computador."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "- Conecte la fuente de energia externa."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(557, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "- Ubicar la pieza a escanear en la zona de escaneo, tenga en cuenta las  recomend" &
    "aciones expuestas en el manual."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Para iniciar el escaneo por favor siga las siguientes instrucciones, luego haga c" &
    "lick en OK."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 112)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BIENVENIDA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "escaneo, estos los puede encontrar en el manual de usuario."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(557, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Recuerde que las superficies brillantes y/o demasiado uniforme requieren de algun" &
    "os tratamientos  antes de iniciar el "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al asistente de escaneo 3D a continuación, encontrará el paso a paso p" &
    "ara realizar el escaneo."
        '
        'SPEscaner
        '
        Me.SPEscaner.PortName = "COM3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(701, 310)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASISTENTE DE ESCANEO 3D"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CANCEL1 As Button
    Friend WithEvents OK1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SPEscaner As IO.Ports.SerialPort
End Class
