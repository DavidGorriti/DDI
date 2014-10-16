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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pctCar = New System.Windows.Forms.PictureBox()
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.rbtFamiliar = New System.Windows.Forms.RadioButton()
        Me.rbtMonovolumen = New System.Windows.Forms.RadioButton()
        Me.rbtCoupe = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpModel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "coupe.png")
        Me.ImageList1.Images.SetKeyName(1, "monovolumen.png")
        Me.ImageList1.Images.SetKeyName(2, "familiar.png")
        '
        'pctCar
        '
        Me.pctCar.Location = New System.Drawing.Point(336, 34)
        Me.pctCar.Name = "pctCar"
        Me.pctCar.Size = New System.Drawing.Size(100, 50)
        Me.pctCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCar.TabIndex = 0
        Me.pctCar.TabStop = False
        '
        'grpModel
        '
        Me.grpModel.Controls.Add(Me.rbtFamiliar)
        Me.grpModel.Controls.Add(Me.rbtMonovolumen)
        Me.grpModel.Controls.Add(Me.rbtCoupe)
        Me.grpModel.Location = New System.Drawing.Point(3, 99)
        Me.grpModel.Name = "grpModel"
        Me.grpModel.Size = New System.Drawing.Size(317, 42)
        Me.grpModel.TabIndex = 1
        Me.grpModel.TabStop = False
        '
        'rbtFamiliar
        '
        Me.rbtFamiliar.AutoSize = True
        Me.rbtFamiliar.Location = New System.Drawing.Point(218, 13)
        Me.rbtFamiliar.Name = "rbtFamiliar"
        Me.rbtFamiliar.Size = New System.Drawing.Size(60, 17)
        Me.rbtFamiliar.TabIndex = 2
        Me.rbtFamiliar.TabStop = True
        Me.rbtFamiliar.Tag = "2"
        Me.rbtFamiliar.Text = "Familiar"
        Me.rbtFamiliar.UseVisualStyleBackColor = True
        '
        'rbtMonovolumen
        '
        Me.rbtMonovolumen.AutoSize = True
        Me.rbtMonovolumen.Location = New System.Drawing.Point(113, 13)
        Me.rbtMonovolumen.Name = "rbtMonovolumen"
        Me.rbtMonovolumen.Size = New System.Drawing.Size(92, 17)
        Me.rbtMonovolumen.TabIndex = 1
        Me.rbtMonovolumen.TabStop = True
        Me.rbtMonovolumen.Tag = "1"
        Me.rbtMonovolumen.Text = "Monovolumen"
        Me.rbtMonovolumen.UseVisualStyleBackColor = True
        '
        'rbtCoupe
        '
        Me.rbtCoupe.AutoSize = True
        Me.rbtCoupe.Location = New System.Drawing.Point(9, 13)
        Me.rbtCoupe.Name = "rbtCoupe"
        Me.rbtCoupe.Size = New System.Drawing.Size(56, 17)
        Me.rbtCoupe.TabIndex = 0
        Me.rbtCoupe.TabStop = True
        Me.rbtCoupe.Tag = "0"
        Me.rbtCoupe.Text = "Coupé"
        Me.rbtCoupe.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 472)
        Me.Controls.Add(Me.grpModel)
        Me.Controls.Add(Me.pctCar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pctCar As System.Windows.Forms.PictureBox
    Friend WithEvents grpModel As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFamiliar As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMonovolumen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCoupe As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
