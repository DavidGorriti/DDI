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
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.grp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.chk5)
        Me.grp1.Controls.Add(Me.chk2)
        Me.grp1.Controls.Add(Me.chk3)
        Me.grp1.Controls.Add(Me.chk4)
        Me.grp1.Controls.Add(Me.chk1)
        Me.grp1.Location = New System.Drawing.Point(58, 58)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(118, 143)
        Me.grp1.TabIndex = 0
        Me.grp1.TabStop = False
        Me.grp1.Text = "GroupBox1"
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Location = New System.Drawing.Point(19, 112)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(81, 17)
        Me.chk5.TabIndex = 4
        Me.chk5.Text = "CheckBox5"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(19, 43)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(81, 17)
        Me.chk2.TabIndex = 3
        Me.chk2.Text = "CheckBox4"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(19, 66)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(81, 17)
        Me.chk3.TabIndex = 2
        Me.chk3.Text = "CheckBox3"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.Location = New System.Drawing.Point(19, 89)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(81, 17)
        Me.chk4.TabIndex = 1
        Me.chk4.Text = "CheckBox2"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(19, 20)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(81, 17)
        Me.chk1.TabIndex = 0
        Me.chk1.Text = "CheckBox1"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 317)
        Me.Controls.Add(Me.grp1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox

End Class
