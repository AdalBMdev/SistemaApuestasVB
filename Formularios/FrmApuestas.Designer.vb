<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApuestas
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTipoApuesta = New System.Windows.Forms.Label()
        Me.cbTipoApuesta = New System.Windows.Forms.ComboBox()
        Me.btnNum1 = New System.Windows.Forms.Button()
        Me.btnNum2 = New System.Windows.Forms.Button()
        Me.btnNum3 = New System.Windows.Forms.Button()
        Me.btnNum6 = New System.Windows.Forms.Button()
        Me.btnNum5 = New System.Windows.Forms.Button()
        Me.btnNum4 = New System.Windows.Forms.Button()
        Me.btnNum9 = New System.Windows.Forms.Button()
        Me.btnNum8 = New System.Windows.Forms.Button()
        Me.btnNum7 = New System.Windows.Forms.Button()
        Me.btnNum0 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumeros = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnSorteo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(342, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(108, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registro de Apuestas"
        '
        'lblTipoApuesta
        '
        Me.lblTipoApuesta.AutoSize = True
        Me.lblTipoApuesta.Location = New System.Drawing.Point(4, 32)
        Me.lblTipoApuesta.Name = "lblTipoApuesta"
        Me.lblTipoApuesta.Size = New System.Drawing.Size(87, 13)
        Me.lblTipoApuesta.TabIndex = 1
        Me.lblTipoApuesta.Text = "Tipo de apuesta:"
        '
        'cbTipoApuesta
        '
        Me.cbTipoApuesta.FormattingEnabled = True
        Me.cbTipoApuesta.Items.AddRange(New Object() {"Quiniela", "Pale", "Tripleta", "Super Pale"})
        Me.cbTipoApuesta.Location = New System.Drawing.Point(7, 47)
        Me.cbTipoApuesta.Name = "cbTipoApuesta"
        Me.cbTipoApuesta.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoApuesta.TabIndex = 2
        '
        'btnNum1
        '
        Me.btnNum1.Location = New System.Drawing.Point(5, 8)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(188, 81)
        Me.btnNum1.TabIndex = 4
        Me.btnNum1.Text = "1"
        Me.btnNum1.UseVisualStyleBackColor = True
        '
        'btnNum2
        '
        Me.btnNum2.Location = New System.Drawing.Point(199, 8)
        Me.btnNum2.Name = "btnNum2"
        Me.btnNum2.Size = New System.Drawing.Size(188, 83)
        Me.btnNum2.TabIndex = 5
        Me.btnNum2.Text = "2"
        Me.btnNum2.UseVisualStyleBackColor = True
        '
        'btnNum3
        '
        Me.btnNum3.Location = New System.Drawing.Point(393, 8)
        Me.btnNum3.Name = "btnNum3"
        Me.btnNum3.Size = New System.Drawing.Size(188, 83)
        Me.btnNum3.TabIndex = 6
        Me.btnNum3.Text = "3"
        Me.btnNum3.UseVisualStyleBackColor = True
        '
        'btnNum6
        '
        Me.btnNum6.Location = New System.Drawing.Point(393, 95)
        Me.btnNum6.Name = "btnNum6"
        Me.btnNum6.Size = New System.Drawing.Size(188, 84)
        Me.btnNum6.TabIndex = 9
        Me.btnNum6.Text = "6"
        Me.btnNum6.UseVisualStyleBackColor = True
        '
        'btnNum5
        '
        Me.btnNum5.Location = New System.Drawing.Point(199, 95)
        Me.btnNum5.Name = "btnNum5"
        Me.btnNum5.Size = New System.Drawing.Size(188, 84)
        Me.btnNum5.TabIndex = 8
        Me.btnNum5.Text = "5"
        Me.btnNum5.UseVisualStyleBackColor = True
        '
        'btnNum4
        '
        Me.btnNum4.Location = New System.Drawing.Point(5, 95)
        Me.btnNum4.Name = "btnNum4"
        Me.btnNum4.Size = New System.Drawing.Size(188, 83)
        Me.btnNum4.TabIndex = 7
        Me.btnNum4.Text = "4"
        Me.btnNum4.UseVisualStyleBackColor = True
        '
        'btnNum9
        '
        Me.btnNum9.Location = New System.Drawing.Point(393, 187)
        Me.btnNum9.Name = "btnNum9"
        Me.btnNum9.Size = New System.Drawing.Size(188, 81)
        Me.btnNum9.TabIndex = 12
        Me.btnNum9.Text = "9"
        Me.btnNum9.UseVisualStyleBackColor = True
        '
        'btnNum8
        '
        Me.btnNum8.Location = New System.Drawing.Point(199, 185)
        Me.btnNum8.Name = "btnNum8"
        Me.btnNum8.Size = New System.Drawing.Size(188, 83)
        Me.btnNum8.TabIndex = 11
        Me.btnNum8.Text = "8"
        Me.btnNum8.UseVisualStyleBackColor = True
        '
        'btnNum7
        '
        Me.btnNum7.Location = New System.Drawing.Point(5, 187)
        Me.btnNum7.Name = "btnNum7"
        Me.btnNum7.Size = New System.Drawing.Size(188, 81)
        Me.btnNum7.TabIndex = 10
        Me.btnNum7.Text = "7"
        Me.btnNum7.UseVisualStyleBackColor = True
        '
        'btnNum0
        '
        Me.btnNum0.Location = New System.Drawing.Point(199, 274)
        Me.btnNum0.Name = "btnNum0"
        Me.btnNum0.Size = New System.Drawing.Size(188, 84)
        Me.btnNum0.TabIndex = 13
        Me.btnNum0.Text = "0"
        Me.btnNum0.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnNum9)
        Me.Panel1.Controls.Add(Me.btnNum6)
        Me.Panel1.Controls.Add(Me.btnNum3)
        Me.Panel1.Controls.Add(Me.btnNum2)
        Me.Panel1.Controls.Add(Me.btnNum1)
        Me.Panel1.Controls.Add(Me.btnNum4)
        Me.Panel1.Controls.Add(Me.btnNum7)
        Me.Panel1.Controls.Add(Me.btnNum0)
        Me.Panel1.Controls.Add(Me.btnNum5)
        Me.Panel1.Controls.Add(Me.btnNum8)
        Me.Panel1.Location = New System.Drawing.Point(7, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 364)
        Me.Panel1.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(393, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(188, 84)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "<--"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(201, 48)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(391, 20)
        Me.txtNumero.TabIndex = 15
        Me.txtNumero.Tag = "Número seleccionado:"
        '
        'lblNumeros
        '
        Me.lblNumeros.AutoSize = True
        Me.lblNumeros.Location = New System.Drawing.Point(198, 32)
        Me.lblNumeros.Name = "lblNumeros"
        Me.lblNumeros.Size = New System.Drawing.Size(104, 13)
        Me.lblNumeros.TabIndex = 16
        Me.lblNumeros.Text = "Numeros apostados:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(610, 47)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(178, 20)
        Me.txtMonto.TabIndex = 17
        Me.txtMonto.Tag = "Introducir el monto apostado." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(611, 31)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(40, 13)
        Me.lblMonto.TabIndex = 18
        Me.lblMonto.Text = "Monto:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(610, 348)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(178, 84)
        Me.btnRegistrar.TabIndex = 19
        Me.btnRegistrar.Text = "Registrar apuesta"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(610, 261)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(178, 81)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Limpiar numeros"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(610, 82)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVer.Size = New System.Drawing.Size(178, 81)
        Me.btnVer.TabIndex = 21
        Me.btnVer.Text = "Ver apuestas"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnSorteo
        '
        Me.btnSorteo.Location = New System.Drawing.Point(610, 170)
        Me.btnSorteo.Name = "btnSorteo"
        Me.btnSorteo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSorteo.Size = New System.Drawing.Size(178, 82)
        Me.btnSorteo.TabIndex = 22
        Me.btnSorteo.Text = "Sortear numeros"
        Me.btnSorteo.UseVisualStyleBackColor = True
        '
        'FrmApuestas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSorteo)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblNumeros)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.cbTipoApuesta)
        Me.Controls.Add(Me.lblTipoApuesta)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmApuestas"
        Me.Text = "FrmApuestas"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTipoApuesta As Label
    Friend WithEvents cbTipoApuesta As ComboBox
    Friend WithEvents btnNum1 As Button
    Friend WithEvents btnNum2 As Button
    Friend WithEvents btnNum3 As Button
    Friend WithEvents btnNum6 As Button
    Friend WithEvents btnNum5 As Button
    Friend WithEvents btnNum4 As Button
    Friend WithEvents btnNum9 As Button
    Friend WithEvents btnNum8 As Button
    Friend WithEvents btnNum7 As Button
    Friend WithEvents btnNum0 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNumeros As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblMonto As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnSorteo As Button
End Class
