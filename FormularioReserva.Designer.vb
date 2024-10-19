<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioReserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReporte)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbTipoHabitacion)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSalida)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEntrada)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 511)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.LimeGreen
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReporte.Location = New System.Drawing.Point(281, 387)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(203, 67)
        Me.btnReporte.TabIndex = 10
        Me.btnReporte.Text = "Ver Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(281, 299)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(203, 67)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar Reserva"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Selecciona el tipo de habitación:"
        '
        'cmbTipoHabitacion
        '
        Me.cmbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoHabitacion.FormattingEnabled = True
        Me.cmbTipoHabitacion.Items.AddRange(New Object() {"Individual", "Doble", "Suite"})
        Me.cmbTipoHabitacion.Location = New System.Drawing.Point(406, 237)
        Me.cmbTipoHabitacion.Name = "cmbTipoHabitacion"
        Me.cmbTipoHabitacion.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipoHabitacion.TabIndex = 7
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Location = New System.Drawing.Point(406, 185)
        Me.dtpFechaSalida.MaxDate = New Date(2025, 10, 25, 23, 59, 0, 0)
        Me.dtpFechaSalida.MinDate = New Date(2024, 10, 19, 0, 0, 0, 0)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(267, 22)
        Me.dtpFechaSalida.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingrese fecha de salida deseada:"
        '
        'dtpFechaEntrada
        '
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(406, 130)
        Me.dtpFechaEntrada.MaxDate = New Date(2025, 10, 25, 23, 59, 0, 0)
        Me.dtpFechaEntrada.MinDate = New Date(2024, 10, 19, 0, 0, 0, 0)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(267, 22)
        Me.dtpFechaEntrada.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ingrese fecha de ingreso desea:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(406, 81)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(156, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese nombre de a quien se hará la reserva:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORMULARIO DE RESERVACIÓN"
        '
        'FormularioReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 587)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormularioReserva"
        Me.Text = "Formulario Reserva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoHabitacion As ComboBox
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaEntrada As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReporte As Button
End Class
