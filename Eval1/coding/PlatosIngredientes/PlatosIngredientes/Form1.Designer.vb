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
        Me.grpLocal = New System.Windows.Forms.GroupBox()
        Me.rbLlevar = New System.Windows.Forms.RadioButton()
        Me.rbComerAqui = New System.Windows.Forms.RadioButton()
        Me.grpEnvase = New System.Windows.Forms.GroupBox()
        Me.cbIsopor = New System.Windows.Forms.CheckBox()
        Me.cbAluminio = New System.Windows.Forms.CheckBox()
        Me.cbPlastico = New System.Windows.Forms.CheckBox()
        Me.grpBebidas = New System.Windows.Forms.GroupBox()
        Me.cbVino = New System.Windows.Forms.CheckBox()
        Me.cbJugo = New System.Windows.Forms.CheckBox()
        Me.cbCerveza = New System.Windows.Forms.CheckBox()
        Me.cbGaseosa = New System.Windows.Forms.CheckBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.grpLocal.SuspendLayout()
        Me.grpEnvase.SuspendLayout()
        Me.grpBebidas.SuspendLayout()
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
        Me.btnAnadir.Enabled = False
        Me.btnAnadir.Location = New System.Drawing.Point(175, 42)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(99, 36)
        Me.btnAnadir.TabIndex = 4
        Me.btnAnadir.Text = "Añadir >>"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Enabled = False
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
        'grpLocal
        '
        Me.grpLocal.Controls.Add(Me.rbLlevar)
        Me.grpLocal.Controls.Add(Me.rbComerAqui)
        Me.grpLocal.Location = New System.Drawing.Point(12, 218)
        Me.grpLocal.Name = "grpLocal"
        Me.grpLocal.Size = New System.Drawing.Size(112, 100)
        Me.grpLocal.TabIndex = 8
        Me.grpLocal.TabStop = False
        Me.grpLocal.Text = "Local"
        '
        'rbLlevar
        '
        Me.rbLlevar.AutoSize = True
        Me.rbLlevar.Location = New System.Drawing.Point(6, 53)
        Me.rbLlevar.Name = "rbLlevar"
        Me.rbLlevar.Size = New System.Drawing.Size(75, 17)
        Me.rbLlevar.TabIndex = 1
        Me.rbLlevar.TabStop = True
        Me.rbLlevar.Text = "Para llevar"
        Me.rbLlevar.UseVisualStyleBackColor = True
        '
        'rbComerAqui
        '
        Me.rbComerAqui.AutoSize = True
        Me.rbComerAqui.Location = New System.Drawing.Point(6, 30)
        Me.rbComerAqui.Name = "rbComerAqui"
        Me.rbComerAqui.Size = New System.Drawing.Size(78, 17)
        Me.rbComerAqui.TabIndex = 0
        Me.rbComerAqui.TabStop = True
        Me.rbComerAqui.Text = "Comer aqui"
        Me.rbComerAqui.UseVisualStyleBackColor = True
        '
        'grpEnvase
        '
        Me.grpEnvase.Controls.Add(Me.cbIsopor)
        Me.grpEnvase.Controls.Add(Me.cbAluminio)
        Me.grpEnvase.Controls.Add(Me.cbPlastico)
        Me.grpEnvase.Enabled = False
        Me.grpEnvase.Location = New System.Drawing.Point(162, 218)
        Me.grpEnvase.Name = "grpEnvase"
        Me.grpEnvase.Size = New System.Drawing.Size(112, 100)
        Me.grpEnvase.TabIndex = 9
        Me.grpEnvase.TabStop = False
        Me.grpEnvase.Text = "Envase"
        '
        'cbIsopor
        '
        Me.cbIsopor.AutoSize = True
        Me.cbIsopor.Location = New System.Drawing.Point(13, 57)
        Me.cbIsopor.Name = "cbIsopor"
        Me.cbIsopor.Size = New System.Drawing.Size(55, 17)
        Me.cbIsopor.TabIndex = 2
        Me.cbIsopor.Text = "Isopor"
        Me.cbIsopor.UseVisualStyleBackColor = True
        '
        'cbAluminio
        '
        Me.cbAluminio.AutoSize = True
        Me.cbAluminio.Location = New System.Drawing.Point(13, 38)
        Me.cbAluminio.Name = "cbAluminio"
        Me.cbAluminio.Size = New System.Drawing.Size(65, 17)
        Me.cbAluminio.TabIndex = 1
        Me.cbAluminio.Text = "Aluminio"
        Me.cbAluminio.UseVisualStyleBackColor = True
        '
        'cbPlastico
        '
        Me.cbPlastico.AutoSize = True
        Me.cbPlastico.Location = New System.Drawing.Point(13, 20)
        Me.cbPlastico.Name = "cbPlastico"
        Me.cbPlastico.Size = New System.Drawing.Size(63, 17)
        Me.cbPlastico.TabIndex = 0
        Me.cbPlastico.Text = "Plastico"
        Me.cbPlastico.UseVisualStyleBackColor = True
        '
        'grpBebidas
        '
        Me.grpBebidas.Controls.Add(Me.cbVino)
        Me.grpBebidas.Controls.Add(Me.cbJugo)
        Me.grpBebidas.Controls.Add(Me.cbCerveza)
        Me.grpBebidas.Controls.Add(Me.cbGaseosa)
        Me.grpBebidas.Location = New System.Drawing.Point(291, 218)
        Me.grpBebidas.Name = "grpBebidas"
        Me.grpBebidas.Size = New System.Drawing.Size(112, 100)
        Me.grpBebidas.TabIndex = 10
        Me.grpBebidas.TabStop = False
        Me.grpBebidas.Text = "Bebidas"
        '
        'cbVino
        '
        Me.cbVino.AutoSize = True
        Me.cbVino.Location = New System.Drawing.Point(14, 74)
        Me.cbVino.Name = "cbVino"
        Me.cbVino.Size = New System.Drawing.Size(47, 17)
        Me.cbVino.TabIndex = 7
        Me.cbVino.Text = "Vino"
        Me.cbVino.UseVisualStyleBackColor = True
        '
        'cbJugo
        '
        Me.cbJugo.AutoSize = True
        Me.cbJugo.Location = New System.Drawing.Point(14, 17)
        Me.cbJugo.Name = "cbJugo"
        Me.cbJugo.Size = New System.Drawing.Size(49, 17)
        Me.cbJugo.TabIndex = 4
        Me.cbJugo.Text = "Jugo"
        Me.cbJugo.UseVisualStyleBackColor = True
        '
        'cbCerveza
        '
        Me.cbCerveza.AutoSize = True
        Me.cbCerveza.Location = New System.Drawing.Point(14, 54)
        Me.cbCerveza.Name = "cbCerveza"
        Me.cbCerveza.Size = New System.Drawing.Size(65, 17)
        Me.cbCerveza.TabIndex = 6
        Me.cbCerveza.Text = "Cerveza"
        Me.cbCerveza.UseVisualStyleBackColor = True
        '
        'cbGaseosa
        '
        Me.cbGaseosa.AutoSize = True
        Me.cbGaseosa.Location = New System.Drawing.Point(14, 35)
        Me.cbGaseosa.Name = "cbGaseosa"
        Me.cbGaseosa.Size = New System.Drawing.Size(68, 17)
        Me.cbGaseosa.TabIndex = 5
        Me.cbGaseosa.Text = "Gaseosa"
        Me.cbGaseosa.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(144, 342)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(162, 45)
        Me.btnFinalizar.TabIndex = 11
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 399)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.grpBebidas)
        Me.Controls.Add(Me.grpEnvase)
        Me.Controls.Add(Me.grpLocal)
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
        Me.grpLocal.ResumeLayout(False)
        Me.grpLocal.PerformLayout()
        Me.grpEnvase.ResumeLayout(False)
        Me.grpEnvase.PerformLayout()
        Me.grpBebidas.ResumeLayout(False)
        Me.grpBebidas.PerformLayout()
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
    Friend WithEvents grpLocal As System.Windows.Forms.GroupBox
    Friend WithEvents rbLlevar As System.Windows.Forms.RadioButton
    Friend WithEvents rbComerAqui As System.Windows.Forms.RadioButton
    Friend WithEvents grpEnvase As System.Windows.Forms.GroupBox
    Friend WithEvents cbIsopor As System.Windows.Forms.CheckBox
    Friend WithEvents cbAluminio As System.Windows.Forms.CheckBox
    Friend WithEvents cbPlastico As System.Windows.Forms.CheckBox
    Friend WithEvents grpBebidas As System.Windows.Forms.GroupBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents cbVino As System.Windows.Forms.CheckBox
    Friend WithEvents cbCerveza As System.Windows.Forms.CheckBox
    Friend WithEvents cbGaseosa As System.Windows.Forms.CheckBox
    Friend WithEvents cbJugo As System.Windows.Forms.CheckBox

End Class
