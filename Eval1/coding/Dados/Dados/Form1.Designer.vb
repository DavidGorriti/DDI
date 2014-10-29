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
        Me.pctPlayer1 = New System.Windows.Forms.PictureBox()
        Me.pctPlayer2 = New System.Windows.Forms.PictureBox()
        Me.btnTirar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtScoreP1 = New System.Windows.Forms.TextBox()
        Me.txtScoreP2 = New System.Windows.Forms.TextBox()
        CType(Me.pctPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPlayer1
        '
        Me.pctPlayer1.Location = New System.Drawing.Point(12, 12)
        Me.pctPlayer1.Name = "pctPlayer1"
        Me.pctPlayer1.Size = New System.Drawing.Size(100, 86)
        Me.pctPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPlayer1.TabIndex = 0
        Me.pctPlayer1.TabStop = False
        '
        'pctPlayer2
        '
        Me.pctPlayer2.Location = New System.Drawing.Point(172, 12)
        Me.pctPlayer2.Name = "pctPlayer2"
        Me.pctPlayer2.Size = New System.Drawing.Size(100, 86)
        Me.pctPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPlayer2.TabIndex = 1
        Me.pctPlayer2.TabStop = False
        '
        'btnTirar
        '
        Me.btnTirar.Location = New System.Drawing.Point(106, 120)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(75, 23)
        Me.btnTirar.TabIndex = 2
        Me.btnTirar.Text = "Tirar"
        Me.btnTirar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "dado1.gif")
        Me.ImageList1.Images.SetKeyName(1, "dado2.gif")
        Me.ImageList1.Images.SetKeyName(2, "dado3.gif")
        Me.ImageList1.Images.SetKeyName(3, "dado4.gif")
        Me.ImageList1.Images.SetKeyName(4, "dado5.gif")
        Me.ImageList1.Images.SetKeyName(5, "dado6.gif")
        '
        'txtScoreP1
        '
        Me.txtScoreP1.Location = New System.Drawing.Point(40, 123)
        Me.txtScoreP1.Name = "txtScoreP1"
        Me.txtScoreP1.Size = New System.Drawing.Size(31, 20)
        Me.txtScoreP1.TabIndex = 3
        '
        'txtScoreP2
        '
        Me.txtScoreP2.Location = New System.Drawing.Point(209, 122)
        Me.txtScoreP2.Name = "txtScoreP2"
        Me.txtScoreP2.Size = New System.Drawing.Size(31, 20)
        Me.txtScoreP2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.txtScoreP2)
        Me.Controls.Add(Me.txtScoreP1)
        Me.Controls.Add(Me.btnTirar)
        Me.Controls.Add(Me.pctPlayer2)
        Me.Controls.Add(Me.pctPlayer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnTirar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtScoreP1 As System.Windows.Forms.TextBox
    Friend WithEvents txtScoreP2 As System.Windows.Forms.TextBox

End Class
