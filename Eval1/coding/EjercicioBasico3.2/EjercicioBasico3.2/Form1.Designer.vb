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
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.lblSimbolo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnRest = New System.Windows.Forms.Button()
        Me.bntMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(12, 35)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(43, 20)
        Me.txtN1.TabIndex = 0
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(89, 35)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(43, 20)
        Me.txtN2.TabIndex = 1
        '
        'lblSimbolo
        '
        Me.lblSimbolo.AutoSize = True
        Me.lblSimbolo.Location = New System.Drawing.Point(71, 38)
        Me.lblSimbolo.Name = "lblSimbolo"
        Me.lblSimbolo.Size = New System.Drawing.Size(0, 13)
        Me.lblSimbolo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "="
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(184, 35)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Size = New System.Drawing.Size(43, 20)
        Me.txtRes.TabIndex = 4
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(13, 80)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(43, 36)
        Me.btnSum.TabIndex = 5
        Me.btnSum.Text = "+"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnRest
        '
        Me.btnRest.Location = New System.Drawing.Point(75, 80)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(43, 36)
        Me.btnRest.TabIndex = 6
        Me.btnRest.Text = "-"
        Me.btnRest.UseVisualStyleBackColor = True
        '
        'bntMult
        '
        Me.bntMult.Location = New System.Drawing.Point(136, 80)
        Me.bntMult.Name = "bntMult"
        Me.bntMult.Size = New System.Drawing.Size(43, 36)
        Me.bntMult.TabIndex = 7
        Me.bntMult.Text = "x"
        Me.bntMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(195, 80)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(43, 36)
        Me.btnDiv.TabIndex = 8
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 125)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.bntMult)
        Me.Controls.Add(Me.btnRest)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSimbolo)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents lblSimbolo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRes As System.Windows.Forms.TextBox
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents btnRest As System.Windows.Forms.Button
    Friend WithEvents bntMult As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button

End Class
