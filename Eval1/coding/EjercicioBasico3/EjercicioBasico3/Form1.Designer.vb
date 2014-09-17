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
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(25, 99)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(107, 76)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "48"
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(104, 68)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(44, 31)
        Me.lblBase.TabIndex = 1
        Me.lblBase.Text = "48"
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes.Location = New System.Drawing.Point(210, 68)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(44, 31)
        Me.lblRes.TabIndex = 2
        Me.lblRes.Text = "48"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 231)
        Me.Controls.Add(Me.lblRes)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.lblNum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents lblRes As System.Windows.Forms.Label

End Class
