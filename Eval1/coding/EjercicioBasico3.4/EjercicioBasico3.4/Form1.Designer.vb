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
        Me.btnFact = New System.Windows.Forms.Button()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFact
        '
        Me.btnFact.Location = New System.Drawing.Point(51, 48)
        Me.btnFact.Name = "btnFact"
        Me.btnFact.Size = New System.Drawing.Size(75, 23)
        Me.btnFact.TabIndex = 0
        Me.btnFact.Text = "Factorial"
        Me.btnFact.UseVisualStyleBackColor = True
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(37, 89)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(100, 20)
        Me.txtAns.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(169, 141)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.btnFact)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFact As System.Windows.Forms.Button
    Friend WithEvents txtAns As System.Windows.Forms.TextBox

End Class
