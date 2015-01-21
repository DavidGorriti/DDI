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
        Me.cmbPaises = New System.Windows.Forms.ComboBox()
        Me.cmbCargos = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cmbP1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbP2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbP3 = New System.Windows.Forms.ComboBox()
        Me.btnVotar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbPaises
        '
        Me.cmbPaises.FormattingEnabled = True
        Me.cmbPaises.Location = New System.Drawing.Point(82, 12)
        Me.cmbPaises.Name = "cmbPaises"
        Me.cmbPaises.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaises.TabIndex = 0
        '
        'cmbCargos
        '
        Me.cmbCargos.FormattingEnabled = True
        Me.cmbCargos.Location = New System.Drawing.Point(82, 39)
        Me.cmbCargos.Name = "cmbCargos"
        Me.cmbCargos.Size = New System.Drawing.Size(121, 21)
        Me.cmbCargos.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(82, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pais:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cargo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(230, 15)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(172, 71)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Acreditar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'cmbP1
        '
        Me.cmbP1.Enabled = False
        Me.cmbP1.FormattingEnabled = True
        Me.cmbP1.Location = New System.Drawing.Point(82, 125)
        Me.cmbP1.Name = "cmbP1"
        Me.cmbP1.Size = New System.Drawing.Size(121, 21)
        Me.cmbP1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "1º"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "2º"
        '
        'cmbP2
        '
        Me.cmbP2.Enabled = False
        Me.cmbP2.FormattingEnabled = True
        Me.cmbP2.Location = New System.Drawing.Point(82, 152)
        Me.cmbP2.Name = "cmbP2"
        Me.cmbP2.Size = New System.Drawing.Size(121, 21)
        Me.cmbP2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "3º"
        '
        'cmbP3
        '
        Me.cmbP3.Enabled = False
        Me.cmbP3.FormattingEnabled = True
        Me.cmbP3.Location = New System.Drawing.Point(82, 179)
        Me.cmbP3.Name = "cmbP3"
        Me.cmbP3.Size = New System.Drawing.Size(121, 21)
        Me.cmbP3.TabIndex = 11
        '
        'btnVotar
        '
        Me.btnVotar.Enabled = False
        Me.btnVotar.Location = New System.Drawing.Point(230, 124)
        Me.btnVotar.Name = "btnVotar"
        Me.btnVotar.Size = New System.Drawing.Size(172, 71)
        Me.btnVotar.TabIndex = 13
        Me.btnVotar.Text = "Votar"
        Me.btnVotar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 218)
        Me.Controls.Add(Me.btnVotar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbP3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbP2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbP1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmbCargos)
        Me.Controls.Add(Me.cmbPaises)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPaises As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCargos As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents cmbP1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbP2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbP3 As System.Windows.Forms.ComboBox
    Friend WithEvents btnVotar As System.Windows.Forms.Button

End Class
