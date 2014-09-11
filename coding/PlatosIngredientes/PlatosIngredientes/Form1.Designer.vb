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
        Me.lstIngredientesOpc = New System.Windows.Forms.ListBox()
        Me.lstIngredientesAsign = New System.Windows.Forms.ListBox()
        Me.txtPlato = New System.Windows.Forms.TextBox()
        Me.lblPlato = New System.Windows.Forms.Label()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnEspecial = New System.Windows.Forms.Button()
        Me.btnNuevoPlato = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstIngredientesOpc
        '
        Me.lstIngredientesOpc.FormattingEnabled = True
        Me.lstIngredientesOpc.Location = New System.Drawing.Point(12, 42)
        Me.lstIngredientesOpc.Name = "lstIngredientesOpc"
        Me.lstIngredientesOpc.Size = New System.Drawing.Size(157, 160)
        Me.lstIngredientesOpc.TabIndex = 0
        '
        'lstIngredientesAsign
        '
        Me.lstIngredientesAsign.FormattingEnabled = True
        Me.lstIngredientesAsign.Location = New System.Drawing.Point(280, 42)
        Me.lstIngredientesAsign.Name = "lstIngredientesAsign"
        Me.lstIngredientesAsign.Size = New System.Drawing.Size(157, 160)
        Me.lstIngredientesAsign.TabIndex = 1
        '
        'txtPlato
        '
        Me.txtPlato.Location = New System.Drawing.Point(50, 12)
        Me.txtPlato.Name = "txtPlato"
        Me.txtPlato.Size = New System.Drawing.Size(387, 20)
        Me.txtPlato.TabIndex = 2
        '
        'lblPlato
        '
        Me.lblPlato.AutoSize = True
        Me.lblPlato.Location = New System.Drawing.Point(13, 18)
        Me.lblPlato.Name = "lblPlato"
        Me.lblPlato.Size = New System.Drawing.Size(31, 13)
        Me.lblPlato.TabIndex = 3
        Me.lblPlato.Text = "Plato"
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(175, 42)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(99, 36)
        Me.btnAnadir.TabIndex = 4
        Me.btnAnadir.Text = "Añadir >>"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(175, 84)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(99, 36)
        Me.btnQuitar.TabIndex = 5
        Me.btnQuitar.Text = "<< Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnEspecial
        '
        Me.btnEspecial.Location = New System.Drawing.Point(175, 126)
        Me.btnEspecial.Name = "btnEspecial"
        Me.btnEspecial.Size = New System.Drawing.Size(99, 36)
        Me.btnEspecial.TabIndex = 6
        Me.btnEspecial.Text = "Especial"
        Me.btnEspecial.UseVisualStyleBackColor = True
        '
        'btnNuevoPlato
        '
        Me.btnNuevoPlato.Location = New System.Drawing.Point(175, 168)
        Me.btnNuevoPlato.Name = "btnNuevoPlato"
        Me.btnNuevoPlato.Size = New System.Drawing.Size(99, 36)
        Me.btnNuevoPlato.TabIndex = 7
        Me.btnNuevoPlato.Text = "Nuevo Plato"
        Me.btnNuevoPlato.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 441)
        Me.Controls.Add(Me.btnNuevoPlato)
        Me.Controls.Add(Me.btnEspecial)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.lblPlato)
        Me.Controls.Add(Me.txtPlato)
        Me.Controls.Add(Me.lstIngredientesAsign)
        Me.Controls.Add(Me.lstIngredientesOpc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstIngredientesOpc As System.Windows.Forms.ListBox
    Friend WithEvents lstIngredientesAsign As System.Windows.Forms.ListBox
    Friend WithEvents txtPlato As System.Windows.Forms.TextBox
    Friend WithEvents lblPlato As System.Windows.Forms.Label
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnEspecial As System.Windows.Forms.Button
    Friend WithEvents btnNuevoPlato As System.Windows.Forms.Button

End Class
