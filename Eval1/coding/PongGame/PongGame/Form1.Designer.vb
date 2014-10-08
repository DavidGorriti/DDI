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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.pnlPlayground = New System.Windows.Forms.Panel()
        Me.pctPaddle = New System.Windows.Forms.PictureBox()
        Me.pctBall = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPlayground.SuspendLayout()
        CType(Me.pctPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(78, 9)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(179, 9)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'pnlPlayground
        '
        Me.pnlPlayground.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlPlayground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPlayground.Controls.Add(Me.pctPaddle)
        Me.pnlPlayground.Controls.Add(Me.pctBall)
        Me.pnlPlayground.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlPlayground.Location = New System.Drawing.Point(12, 88)
        Me.pnlPlayground.Name = "pnlPlayground"
        Me.pnlPlayground.Size = New System.Drawing.Size(372, 211)
        Me.pnlPlayground.TabIndex = 3
        '
        'pctPaddle
        '
        Me.pctPaddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pctPaddle.Location = New System.Drawing.Point(343, 81)
        Me.pctPaddle.Name = "pctPaddle"
        Me.pctPaddle.Size = New System.Drawing.Size(14, 50)
        Me.pctPaddle.TabIndex = 1
        Me.pctPaddle.TabStop = False
        '
        'pctBall
        '
        Me.pctBall.Image = CType(resources.GetObject("pctBall.Image"), System.Drawing.Image)
        Me.pctBall.Location = New System.Drawing.Point(3, 97)
        Me.pctBall.Name = "pctBall"
        Me.pctBall.Size = New System.Drawing.Size(21, 21)
        Me.pctBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBall.TabIndex = 0
        Me.pctBall.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(104, 26)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 46)
        Me.lblScore.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(309, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pnlPlayground)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlPlayground.ResumeLayout(False)
        CType(Me.pctPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents pnlPlayground As System.Windows.Forms.Panel
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents pctPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents pctBall As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
