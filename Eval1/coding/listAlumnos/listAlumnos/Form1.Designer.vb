<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lstAlumnos = New System.Windows.Forms.ListBox()
        Me.lstParticipantes = New System.Windows.Forms.ListBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(13, 13)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(63, 10)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(335, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lstAlumnos
        '
        Me.lstAlumnos.FormattingEnabled = True
        Me.lstAlumnos.Location = New System.Drawing.Point(12, 36)
        Me.lstAlumnos.Name = "lstAlumnos"
        Me.lstAlumnos.Size = New System.Drawing.Size(120, 199)
        Me.lstAlumnos.TabIndex = 2
        '
        'lstParticipantes
        '
        Me.lstParticipantes.FormattingEnabled = True
        Me.lstParticipantes.Location = New System.Drawing.Point(278, 36)
        Me.lstParticipantes.Name = "lstParticipantes"
        Me.lstParticipantes.Size = New System.Drawing.Size(120, 199)
        Me.lstParticipantes.TabIndex = 3
        '
        'btnAnadir
        '
        Me.btnAnadir.Enabled = False
        Me.btnAnadir.Location = New System.Drawing.Point(138, 79)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(134, 34)
        Me.btnAnadir.TabIndex = 4
        Me.btnAnadir.Text = "Añadir >"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Enabled = False
        Me.btnQuitar.Location = New System.Drawing.Point(138, 136)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(134, 34)
        Me.btnQuitar.TabIndex = 5
        Me.btnQuitar.Text = "< Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(138, 192)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(134, 34)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 251)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.lstParticipantes)
        Me.Controls.Add(Me.lstAlumnos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lstAlumnos As System.Windows.Forms.ListBox
    Friend WithEvents lstParticipantes As System.Windows.Forms.ListBox
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button

End Class
