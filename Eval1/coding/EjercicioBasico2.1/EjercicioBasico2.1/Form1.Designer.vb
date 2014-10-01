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
        Me.chkFamilia = New System.Windows.Forms.CheckBox()
        Me.chkEstudiante = New System.Windows.Forms.CheckBox()
        Me.grp2 = New System.Windows.Forms.GroupBox()
        Me.rbInfantil = New System.Windows.Forms.RadioButton()
        Me.rbJubilados = New System.Windows.Forms.RadioButton()
        Me.rbJoven = New System.Windows.Forms.RadioButton()
        Me.rbIndividual = New System.Windows.Forms.RadioButton()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.grp1.SuspendLayout()
        Me.grp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.chkFamilia)
        Me.grp1.Controls.Add(Me.chkEstudiante)
        Me.grp1.Location = New System.Drawing.Point(170, 12)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(149, 69)
        Me.grp1.TabIndex = 0
        Me.grp1.TabStop = False
        '
        'chkFamilia
        '
        Me.chkFamilia.AutoSize = True
        Me.chkFamilia.Location = New System.Drawing.Point(7, 43)
        Me.chkFamilia.Name = "chkFamilia"
        Me.chkFamilia.Size = New System.Drawing.Size(136, 17)
        Me.chkFamilia.TabIndex = 1
        Me.chkFamilia.Tag = "fmln"
        Me.chkFamilia.Text = "Familia numerosa (20%)"
        Me.chkFamilia.UseVisualStyleBackColor = True
        '
        'chkEstudiante
        '
        Me.chkEstudiante.AutoSize = True
        Me.chkEstudiante.Location = New System.Drawing.Point(7, 20)
        Me.chkEstudiante.Name = "chkEstudiante"
        Me.chkEstudiante.Size = New System.Drawing.Size(105, 17)
        Me.chkEstudiante.TabIndex = 0
        Me.chkEstudiante.Tag = "est"
        Me.chkEstudiante.Text = "Estudiante (10%)"
        Me.chkEstudiante.UseVisualStyleBackColor = True
        '
        'grp2
        '
        Me.grp2.Controls.Add(Me.rbInfantil)
        Me.grp2.Controls.Add(Me.rbJubilados)
        Me.grp2.Controls.Add(Me.rbJoven)
        Me.grp2.Controls.Add(Me.rbIndividual)
        Me.grp2.Location = New System.Drawing.Point(170, 87)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(149, 117)
        Me.grp2.TabIndex = 1
        Me.grp2.TabStop = False
        '
        'rbInfantil
        '
        Me.rbInfantil.AutoSize = True
        Me.rbInfantil.Location = New System.Drawing.Point(7, 89)
        Me.rbInfantil.Name = "rbInfantil"
        Me.rbInfantil.Size = New System.Drawing.Size(56, 17)
        Me.rbInfantil.TabIndex = 3
        Me.rbInfantil.TabStop = True
        Me.rbInfantil.Tag = "95"
        Me.rbInfantil.Text = "Infantil"
        Me.rbInfantil.UseVisualStyleBackColor = True
        '
        'rbJubilados
        '
        Me.rbJubilados.AutoSize = True
        Me.rbJubilados.Location = New System.Drawing.Point(7, 66)
        Me.rbJubilados.Name = "rbJubilados"
        Me.rbJubilados.Size = New System.Drawing.Size(69, 17)
        Me.rbJubilados.TabIndex = 2
        Me.rbJubilados.TabStop = True
        Me.rbJubilados.Tag = "75"
        Me.rbJubilados.Text = "Jubilados"
        Me.rbJubilados.UseVisualStyleBackColor = True
        '
        'rbJoven
        '
        Me.rbJoven.AutoSize = True
        Me.rbJoven.Location = New System.Drawing.Point(7, 43)
        Me.rbJoven.Name = "rbJoven"
        Me.rbJoven.Size = New System.Drawing.Size(99, 17)
        Me.rbJoven.TabIndex = 1
        Me.rbJoven.TabStop = True
        Me.rbJoven.Tag = "80"
        Me.rbJoven.Text = "Individual joven"
        Me.rbJoven.UseVisualStyleBackColor = True
        '
        'rbIndividual
        '
        Me.rbIndividual.AutoSize = True
        Me.rbIndividual.Location = New System.Drawing.Point(6, 19)
        Me.rbIndividual.Name = "rbIndividual"
        Me.rbIndividual.Size = New System.Drawing.Size(70, 17)
        Me.rbIndividual.TabIndex = 0
        Me.rbIndividual.TabStop = True
        Me.rbIndividual.Tag = "100"
        Me.rbIndividual.Text = "Individual"
        Me.rbIndividual.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(38, 79)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 31)
        Me.lblResultado.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 208)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.grp2)
        Me.Controls.Add(Me.grp1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFamilia As System.Windows.Forms.CheckBox
    Friend WithEvents chkEstudiante As System.Windows.Forms.CheckBox
    Friend WithEvents grp2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbInfantil As System.Windows.Forms.RadioButton
    Friend WithEvents rbJubilados As System.Windows.Forms.RadioButton
    Friend WithEvents rbJoven As System.Windows.Forms.RadioButton
    Friend WithEvents rbIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents lblResultado As System.Windows.Forms.Label

End Class
