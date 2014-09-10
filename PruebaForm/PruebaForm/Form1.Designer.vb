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
        Me.RBi3 = New System.Windows.Forms.RadioButton()
        Me.GBMicros = New System.Windows.Forms.GroupBox()
        Me.RBAMD = New System.Windows.Forms.RadioButton()
        Me.RBi5 = New System.Windows.Forms.RadioButton()
        Me.GBOpciones = New System.Windows.Forms.GroupBox()
        Me.CBTarjetaG = New System.Windows.Forms.CheckBox()
        Me.CBAltavoces = New System.Windows.Forms.CheckBox()
        Me.CBMonitor = New System.Windows.Forms.CheckBox()
        Me.GBTarjetaG = New System.Windows.Forms.GroupBox()
        Me.RBati = New System.Windows.Forms.RadioButton()
        Me.RBintel = New System.Windows.Forms.RadioButton()
        Me.RBNVidia = New System.Windows.Forms.RadioButton()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBMicros.SuspendLayout()
        Me.GBOpciones.SuspendLayout()
        Me.GBTarjetaG.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBi3
        '
        Me.RBi3.AutoSize = True
        Me.RBi3.Location = New System.Drawing.Point(24, 19)
        Me.RBi3.Name = "RBi3"
        Me.RBi3.Size = New System.Drawing.Size(33, 17)
        Me.RBi3.TabIndex = 0
        Me.RBi3.TabStop = True
        Me.RBi3.Text = "i3"
        Me.RBi3.UseVisualStyleBackColor = True
        '
        'GBMicros
        '
        Me.GBMicros.Controls.Add(Me.RBAMD)
        Me.GBMicros.Controls.Add(Me.RBi5)
        Me.GBMicros.Controls.Add(Me.RBi3)
        Me.GBMicros.Location = New System.Drawing.Point(12, 37)
        Me.GBMicros.Name = "GBMicros"
        Me.GBMicros.Size = New System.Drawing.Size(166, 100)
        Me.GBMicros.TabIndex = 1
        Me.GBMicros.TabStop = False
        Me.GBMicros.Text = "Micros"
        '
        'RBAMD
        '
        Me.RBAMD.AutoSize = True
        Me.RBAMD.Location = New System.Drawing.Point(24, 65)
        Me.RBAMD.Name = "RBAMD"
        Me.RBAMD.Size = New System.Drawing.Size(49, 17)
        Me.RBAMD.TabIndex = 2
        Me.RBAMD.TabStop = True
        Me.RBAMD.Text = "AMD"
        Me.RBAMD.UseVisualStyleBackColor = True
        '
        'RBi5
        '
        Me.RBi5.AutoSize = True
        Me.RBi5.Location = New System.Drawing.Point(24, 42)
        Me.RBi5.Name = "RBi5"
        Me.RBi5.Size = New System.Drawing.Size(33, 17)
        Me.RBi5.TabIndex = 1
        Me.RBi5.TabStop = True
        Me.RBi5.Text = "i5"
        Me.RBi5.UseVisualStyleBackColor = True
        '
        'GBOpciones
        '
        Me.GBOpciones.Controls.Add(Me.CBTarjetaG)
        Me.GBOpciones.Controls.Add(Me.CBAltavoces)
        Me.GBOpciones.Controls.Add(Me.CBMonitor)
        Me.GBOpciones.Location = New System.Drawing.Point(184, 37)
        Me.GBOpciones.Name = "GBOpciones"
        Me.GBOpciones.Size = New System.Drawing.Size(136, 100)
        Me.GBOpciones.TabIndex = 2
        Me.GBOpciones.TabStop = False
        Me.GBOpciones.Text = "GpOpciones"
        '
        'CBTarjetaG
        '
        Me.CBTarjetaG.AutoSize = True
        Me.CBTarjetaG.Location = New System.Drawing.Point(30, 66)
        Me.CBTarjetaG.Name = "CBTarjetaG"
        Me.CBTarjetaG.Size = New System.Drawing.Size(90, 17)
        Me.CBTarjetaG.TabIndex = 2
        Me.CBTarjetaG.Text = "tarjeta grafica"
        Me.CBTarjetaG.UseVisualStyleBackColor = True
        '
        'CBAltavoces
        '
        Me.CBAltavoces.AutoSize = True
        Me.CBAltavoces.Location = New System.Drawing.Point(30, 42)
        Me.CBAltavoces.Name = "CBAltavoces"
        Me.CBAltavoces.Size = New System.Drawing.Size(72, 17)
        Me.CBAltavoces.TabIndex = 1
        Me.CBAltavoces.Text = "altavoces"
        Me.CBAltavoces.UseVisualStyleBackColor = True
        '
        'CBMonitor
        '
        Me.CBMonitor.AutoSize = True
        Me.CBMonitor.Location = New System.Drawing.Point(30, 20)
        Me.CBMonitor.Name = "CBMonitor"
        Me.CBMonitor.Size = New System.Drawing.Size(61, 17)
        Me.CBMonitor.TabIndex = 0
        Me.CBMonitor.Text = "Monitor"
        Me.CBMonitor.UseVisualStyleBackColor = True
        '
        'GBTarjetaG
        '
        Me.GBTarjetaG.Controls.Add(Me.RBati)
        Me.GBTarjetaG.Controls.Add(Me.RBintel)
        Me.GBTarjetaG.Controls.Add(Me.RBNVidia)
        Me.GBTarjetaG.Enabled = False
        Me.GBTarjetaG.Location = New System.Drawing.Point(184, 160)
        Me.GBTarjetaG.Name = "GBTarjetaG"
        Me.GBTarjetaG.Size = New System.Drawing.Size(136, 94)
        Me.GBTarjetaG.TabIndex = 3
        Me.GBTarjetaG.TabStop = False
        Me.GBTarjetaG.Text = "Tarjeta Gráfica"
        '
        'RBati
        '
        Me.RBati.AutoSize = True
        Me.RBati.Location = New System.Drawing.Point(24, 65)
        Me.RBati.Name = "RBati"
        Me.RBati.Size = New System.Drawing.Size(37, 17)
        Me.RBati.TabIndex = 2
        Me.RBati.TabStop = True
        Me.RBati.Text = "Ati"
        Me.RBati.UseVisualStyleBackColor = True
        '
        'RBintel
        '
        Me.RBintel.AutoSize = True
        Me.RBintel.Location = New System.Drawing.Point(24, 42)
        Me.RBintel.Name = "RBintel"
        Me.RBintel.Size = New System.Drawing.Size(44, 17)
        Me.RBintel.TabIndex = 1
        Me.RBintel.TabStop = True
        Me.RBintel.Text = "intel"
        Me.RBintel.UseVisualStyleBackColor = True
        '
        'RBNVidia
        '
        Me.RBNVidia.AutoSize = True
        Me.RBNVidia.Location = New System.Drawing.Point(24, 19)
        Me.RBNVidia.Name = "RBNVidia"
        Me.RBNVidia.Size = New System.Drawing.Size(56, 17)
        Me.RBNVidia.TabIndex = 0
        Me.RBNVidia.TabStop = True
        Me.RBNVidia.Text = "NVidia"
        Me.RBNVidia.UseVisualStyleBackColor = True
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(72, 234)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.ReadOnly = True
        Me.TBPrecio.Size = New System.Drawing.Size(106, 20)
        Me.TBPrecio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Precio:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 264)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBPrecio)
        Me.Controls.Add(Me.GBTarjetaG)
        Me.Controls.Add(Me.GBOpciones)
        Me.Controls.Add(Me.GBMicros)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBMicros.ResumeLayout(False)
        Me.GBMicros.PerformLayout()
        Me.GBOpciones.ResumeLayout(False)
        Me.GBOpciones.PerformLayout()
        Me.GBTarjetaG.ResumeLayout(False)
        Me.GBTarjetaG.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RBi3 As System.Windows.Forms.RadioButton
    Friend WithEvents GBMicros As System.Windows.Forms.GroupBox
    Friend WithEvents RBAMD As System.Windows.Forms.RadioButton
    Friend WithEvents RBi5 As System.Windows.Forms.RadioButton
    Friend WithEvents GBOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents CBTarjetaG As System.Windows.Forms.CheckBox
    Friend WithEvents CBAltavoces As System.Windows.Forms.CheckBox
    Friend WithEvents CBMonitor As System.Windows.Forms.CheckBox
    Friend WithEvents GBTarjetaG As System.Windows.Forms.GroupBox
    Friend WithEvents RBati As System.Windows.Forms.RadioButton
    Friend WithEvents RBintel As System.Windows.Forms.RadioButton
    Friend WithEvents RBNVidia As System.Windows.Forms.RadioButton
    Friend WithEvents TBPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
