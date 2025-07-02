<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSortearResultado
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
        Me.cbTipoSorteo = New System.Windows.Forms.ComboBox()
        Me.dtFechaSorteo = New System.Windows.Forms.DateTimePicker()
        Me.btnSortear = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbTipoSorteo
        '
        Me.cbTipoSorteo.FormattingEnabled = True
        Me.cbTipoSorteo.Location = New System.Drawing.Point(150, 163)
        Me.cbTipoSorteo.Name = "cbTipoSorteo"
        Me.cbTipoSorteo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoSorteo.TabIndex = 0
        '
        'dtFechaSorteo
        '
        Me.dtFechaSorteo.Location = New System.Drawing.Point(309, 164)
        Me.dtFechaSorteo.Name = "dtFechaSorteo"
        Me.dtFechaSorteo.Size = New System.Drawing.Size(217, 20)
        Me.dtFechaSorteo.TabIndex = 1
        '
        'btnSortear
        '
        Me.btnSortear.Location = New System.Drawing.Point(544, 161)
        Me.btnSortear.Name = "btnSortear"
        Me.btnSortear.Size = New System.Drawing.Size(90, 74)
        Me.btnSortear.TabIndex = 2
        Me.btnSortear.Text = "Sortear"
        Me.btnSortear.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(150, 215)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(376, 20)
        Me.txtResultado.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo de sorteo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha de resultado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Numeros ganadores"
        '
        'FrmSortearResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnSortear)
        Me.Controls.Add(Me.dtFechaSorteo)
        Me.Controls.Add(Me.cbTipoSorteo)
        Me.Name = "FrmSortearResultado"
        Me.Text = "FrmSortearResultado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbTipoSorteo As ComboBox
    Friend WithEvents dtFechaSorteo As DateTimePicker
    Friend WithEvents btnSortear As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
