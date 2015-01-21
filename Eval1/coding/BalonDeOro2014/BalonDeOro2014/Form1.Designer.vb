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
        Me.lblOro = New System.Windows.Forms.Label()
        Me.lblPlata = New System.Windows.Forms.Label()
        Me.lblBronce = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOro
        '
        Me.lblOro.AutoSize = True
        Me.lblOro.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.lblOro.Location = New System.Drawing.Point(144, 62)
        Me.lblOro.Name = "lblOro"
        Me.lblOro.Size = New System.Drawing.Size(0, 36)
        Me.lblOro.TabIndex = 0
        Me.lblOro.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlata
        '
        Me.lblPlata.AutoSize = True
        Me.lblPlata.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.lblPlata.Location = New System.Drawing.Point(144, 113)
        Me.lblPlata.Name = "lblPlata"
        Me.lblPlata.Size = New System.Drawing.Size(0, 36)
        Me.lblPlata.TabIndex = 1
        Me.lblPlata.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBronce
        '
        Me.lblBronce.AutoSize = True
        Me.lblBronce.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.lblBronce.Location = New System.Drawing.Point(144, 164)
        Me.lblBronce.Name = "lblBronce"
        Me.lblBronce.Size = New System.Drawing.Size(0, 36)
        Me.lblBronce.TabIndex = 2
        Me.lblBronce.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 262)
        Me.Controls.Add(Me.lblBronce)
        Me.Controls.Add(Me.lblPlata)
        Me.Controls.Add(Me.lblOro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOro As System.Windows.Forms.Label
    Friend WithEvents lblPlata As System.Windows.Forms.Label
    Friend WithEvents lblBronce As System.Windows.Forms.Label

End Class
