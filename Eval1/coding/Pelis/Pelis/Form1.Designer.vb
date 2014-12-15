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
        Me.btnPelis = New System.Windows.Forms.Button()
        Me.btnDirectores = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPelis
        '
        Me.btnPelis.Location = New System.Drawing.Point(12, 12)
        Me.btnPelis.Name = "btnPelis"
        Me.btnPelis.Size = New System.Drawing.Size(190, 36)
        Me.btnPelis.TabIndex = 0
        Me.btnPelis.Text = "Películas"
        Me.btnPelis.UseVisualStyleBackColor = True
        '
        'btnDirectores
        '
        Me.btnDirectores.Location = New System.Drawing.Point(12, 54)
        Me.btnDirectores.Name = "btnDirectores"
        Me.btnDirectores.Size = New System.Drawing.Size(190, 36)
        Me.btnDirectores.TabIndex = 1
        Me.btnDirectores.Text = "Directores"
        Me.btnDirectores.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 96)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(190, 36)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 146)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDirectores)
        Me.Controls.Add(Me.btnPelis)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPelis As System.Windows.Forms.Button
    Friend WithEvents btnDirectores As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
