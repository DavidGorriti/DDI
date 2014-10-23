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
        Me.components = New System.ComponentModel.Container()
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.pctPatoRapido = New System.Windows.Forms.PictureBox()
        Me.pctPatoLento = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGame.SuspendLayout()
        CType(Me.pctPatoRapido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPatoLento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGame
        '
        Me.pnlGame.Controls.Add(Me.pctPatoRapido)
        Me.pnlGame.Controls.Add(Me.pctPatoLento)
        Me.pnlGame.Location = New System.Drawing.Point(0, 73)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(638, 344)
        Me.pnlGame.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(32, 25)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Iniciar"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(530, 25)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Fin"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(426, 28)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(57, 20)
        Me.txtScore.TabIndex = 3
        '
        'pctPatoRapido
        '
        Me.pctPatoRapido.Image = Global.WindowsApplication1.My.Resources.Resources.blackduck
        Me.pctPatoRapido.Location = New System.Drawing.Point(4, 60)
        Me.pctPatoRapido.Name = "pctPatoRapido"
        Me.pctPatoRapido.Size = New System.Drawing.Size(61, 50)
        Me.pctPatoRapido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPatoRapido.TabIndex = 1
        Me.pctPatoRapido.TabStop = False
        '
        'pctPatoLento
        '
        Me.pctPatoLento.Image = Global.WindowsApplication1.My.Resources.Resources.duck
        Me.pctPatoLento.Location = New System.Drawing.Point(3, 3)
        Me.pctPatoLento.Name = "pctPatoLento"
        Me.pctPatoLento.Size = New System.Drawing.Size(62, 50)
        Me.pctPatoLento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPatoLento.TabIndex = 0
        Me.pctPatoLento.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 416)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pnlGame)
        Me.Name = "Form1"
        Me.pnlGame.ResumeLayout(False)
        CType(Me.pctPatoRapido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPatoLento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlGame As System.Windows.Forms.Panel
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents pctPatoLento As System.Windows.Forms.PictureBox
    Friend WithEvents pctPatoRapido As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
