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
        Me.pctPiedra = New System.Windows.Forms.PictureBox()
        Me.pctPapel = New System.Windows.Forms.PictureBox()
        Me.pctTijera = New System.Windows.Forms.PictureBox()
        Me.pctRival = New System.Windows.Forms.PictureBox()
        Me.txtScorePlayer = New System.Windows.Forms.TextBox()
        Me.txtScoreRival = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pctPiedra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPapel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTijera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRival, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPiedra
        '
        Me.pctPiedra.Image = CType(resources.GetObject("pctPiedra.Image"), System.Drawing.Image)
        Me.pctPiedra.Location = New System.Drawing.Point(12, 36)
        Me.pctPiedra.Name = "pctPiedra"
        Me.pctPiedra.Size = New System.Drawing.Size(100, 87)
        Me.pctPiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPiedra.TabIndex = 0
        Me.pctPiedra.TabStop = False
        Me.pctPiedra.Tag = "0"
        '
        'pctPapel
        '
        Me.pctPapel.Image = CType(resources.GetObject("pctPapel.Image"), System.Drawing.Image)
        Me.pctPapel.Location = New System.Drawing.Point(118, 36)
        Me.pctPapel.Name = "pctPapel"
        Me.pctPapel.Size = New System.Drawing.Size(100, 87)
        Me.pctPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPapel.TabIndex = 1
        Me.pctPapel.TabStop = False
        Me.pctPapel.Tag = "1"
        '
        'pctTijera
        '
        Me.pctTijera.Image = CType(resources.GetObject("pctTijera.Image"), System.Drawing.Image)
        Me.pctTijera.Location = New System.Drawing.Point(224, 36)
        Me.pctTijera.Name = "pctTijera"
        Me.pctTijera.Size = New System.Drawing.Size(100, 87)
        Me.pctTijera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctTijera.TabIndex = 2
        Me.pctTijera.TabStop = False
        Me.pctTijera.Tag = "2"
        '
        'pctRival
        '
        Me.pctRival.Location = New System.Drawing.Point(423, 36)
        Me.pctRival.Name = "pctRival"
        Me.pctRival.Size = New System.Drawing.Size(100, 87)
        Me.pctRival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctRival.TabIndex = 3
        Me.pctRival.TabStop = False
        '
        'txtScorePlayer
        '
        Me.txtScorePlayer.Location = New System.Drawing.Point(278, 138)
        Me.txtScorePlayer.Name = "txtScorePlayer"
        Me.txtScorePlayer.Size = New System.Drawing.Size(46, 20)
        Me.txtScorePlayer.TabIndex = 4
        '
        'txtScoreRival
        '
        Me.txtScoreRival.Location = New System.Drawing.Point(423, 138)
        Me.txtScoreRival.Name = "txtScoreRival"
        Me.txtScoreRival.Size = New System.Drawing.Size(46, 20)
        Me.txtScoreRival.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(354, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Puntos"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "piedra.png")
        Me.ImageList1.Images.SetKeyName(1, "papel.png")
        Me.ImageList1.Images.SetKeyName(2, "tijera.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(533, 190)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtScoreRival)
        Me.Controls.Add(Me.txtScorePlayer)
        Me.Controls.Add(Me.pctRival)
        Me.Controls.Add(Me.pctTijera)
        Me.Controls.Add(Me.pctPapel)
        Me.Controls.Add(Me.pctPiedra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctPiedra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPapel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTijera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRival, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctPiedra As System.Windows.Forms.PictureBox
    Friend WithEvents pctPapel As System.Windows.Forms.PictureBox
    Friend WithEvents pctTijera As System.Windows.Forms.PictureBox
    Friend WithEvents pctRival As System.Windows.Forms.PictureBox
    Friend WithEvents txtScorePlayer As System.Windows.Forms.TextBox
    Friend WithEvents txtScoreRival As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
