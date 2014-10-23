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
        Me.grpMotor = New System.Windows.Forms.GroupBox()
        Me.rbtGasolina = New System.Windows.Forms.RadioButton()
        Me.rbtDiesel = New System.Windows.Forms.RadioButton()
        Me.chkAbs = New System.Windows.Forms.CheckBox()
        Me.chkAlarma = New System.Windows.Forms.CheckBox()
        Me.chkGps = New System.Windows.Forms.CheckBox()
        Me.chkPintura = New System.Windows.Forms.CheckBox()
        Me.chkAsientosCuero = New System.Windows.Forms.CheckBox()
        Me.chkCambioAuto = New System.Windows.Forms.CheckBox()
        Me.chkAire = New System.Windows.Forms.CheckBox()
        Me.chkAirbag = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecioOpciones = New System.Windows.Forms.TextBox()
        Me.txtPrecioSinOp = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtPrecioFinal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.pctCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpModel.SuspendLayout()
        Me.grpMotor.SuspendLayout()
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
        Me.grpModel.Text = "Modelo"
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
        'grpMotor
        '
        Me.grpMotor.Controls.Add(Me.rbtGasolina)
        Me.grpMotor.Controls.Add(Me.rbtDiesel)
        Me.grpMotor.Location = New System.Drawing.Point(3, 156)
        Me.grpMotor.Name = "grpMotor"
        Me.grpMotor.Size = New System.Drawing.Size(317, 43)
        Me.grpMotor.TabIndex = 3
        Me.grpMotor.TabStop = False
        Me.grpMotor.Text = "Motor"
        '
        'rbtGasolina
        '
        Me.rbtGasolina.AutoSize = True
        Me.rbtGasolina.Location = New System.Drawing.Point(113, 19)
        Me.rbtGasolina.Name = "rbtGasolina"
        Me.rbtGasolina.Size = New System.Drawing.Size(66, 17)
        Me.rbtGasolina.TabIndex = 4
        Me.rbtGasolina.TabStop = True
        Me.rbtGasolina.Tag = "0"
        Me.rbtGasolina.Text = "Gasolina"
        Me.rbtGasolina.UseVisualStyleBackColor = True
        '
        'rbtDiesel
        '
        Me.rbtDiesel.AutoSize = True
        Me.rbtDiesel.Location = New System.Drawing.Point(9, 19)
        Me.rbtDiesel.Name = "rbtDiesel"
        Me.rbtDiesel.Size = New System.Drawing.Size(54, 17)
        Me.rbtDiesel.TabIndex = 3
        Me.rbtDiesel.TabStop = True
        Me.rbtDiesel.Tag = "0"
        Me.rbtDiesel.Text = "Diesel"
        Me.rbtDiesel.UseVisualStyleBackColor = True
        '
        'chkAbs
        '
        Me.chkAbs.AutoSize = True
        Me.chkAbs.Location = New System.Drawing.Point(12, 226)
        Me.chkAbs.Name = "chkAbs"
        Me.chkAbs.Size = New System.Drawing.Size(47, 17)
        Me.chkAbs.TabIndex = 4
        Me.chkAbs.Tag = "670"
        Me.chkAbs.Text = "ABS"
        Me.chkAbs.UseVisualStyleBackColor = True
        '
        'chkAlarma
        '
        Me.chkAlarma.AutoSize = True
        Me.chkAlarma.Location = New System.Drawing.Point(178, 226)
        Me.chkAlarma.Name = "chkAlarma"
        Me.chkAlarma.Size = New System.Drawing.Size(103, 17)
        Me.chkAlarma.TabIndex = 5
        Me.chkAlarma.Tag = "150"
        Me.chkAlarma.Text = "Alarma Antirrobo"
        Me.chkAlarma.UseVisualStyleBackColor = True
        '
        'chkGps
        '
        Me.chkGps.AutoSize = True
        Me.chkGps.Location = New System.Drawing.Point(178, 249)
        Me.chkGps.Name = "chkGps"
        Me.chkGps.Size = New System.Drawing.Size(48, 17)
        Me.chkGps.TabIndex = 6
        Me.chkGps.TabStop = False
        Me.chkGps.Tag = "400"
        Me.chkGps.Text = "GPS"
        Me.chkGps.UseVisualStyleBackColor = True
        '
        'chkPintura
        '
        Me.chkPintura.AutoSize = True
        Me.chkPintura.Location = New System.Drawing.Point(178, 272)
        Me.chkPintura.Name = "chkPintura"
        Me.chkPintura.Size = New System.Drawing.Size(113, 17)
        Me.chkPintura.TabIndex = 7
        Me.chkPintura.TabStop = False
        Me.chkPintura.Tag = "150"
        Me.chkPintura.Text = "Pintura Metalizada"
        Me.chkPintura.UseVisualStyleBackColor = True
        '
        'chkAsientosCuero
        '
        Me.chkAsientosCuero.AutoSize = True
        Me.chkAsientosCuero.Location = New System.Drawing.Point(178, 295)
        Me.chkAsientosCuero.Name = "chkAsientosCuero"
        Me.chkAsientosCuero.Size = New System.Drawing.Size(111, 17)
        Me.chkAsientosCuero.TabIndex = 8
        Me.chkAsientosCuero.Tag = "1600"
        Me.chkAsientosCuero.Text = "Asientos de cuero"
        Me.chkAsientosCuero.UseVisualStyleBackColor = True
        '
        'chkCambioAuto
        '
        Me.chkCambioAuto.AutoSize = True
        Me.chkCambioAuto.Location = New System.Drawing.Point(12, 295)
        Me.chkCambioAuto.Name = "chkCambioAuto"
        Me.chkCambioAuto.Size = New System.Drawing.Size(117, 17)
        Me.chkCambioAuto.TabIndex = 9
        Me.chkCambioAuto.Tag = "2100"
        Me.chkCambioAuto.Text = "Cambio Automático"
        Me.chkCambioAuto.UseVisualStyleBackColor = True
        '
        'chkAire
        '
        Me.chkAire.AutoSize = True
        Me.chkAire.Location = New System.Drawing.Point(12, 272)
        Me.chkAire.Name = "chkAire"
        Me.chkAire.Size = New System.Drawing.Size(118, 17)
        Me.chkAire.TabIndex = 10
        Me.chkAire.Tag = "1050"
        Me.chkAire.Text = "Aire Acondicionado"
        Me.chkAire.UseVisualStyleBackColor = True
        '
        'chkAirbag
        '
        Me.chkAirbag.AutoSize = True
        Me.chkAirbag.Location = New System.Drawing.Point(12, 249)
        Me.chkAirbag.Name = "chkAirbag"
        Me.chkAirbag.Size = New System.Drawing.Size(107, 17)
        Me.chkAirbag.TabIndex = 11
        Me.chkAirbag.Tag = "540"
        Me.chkAirbag.Text = "Airgabs Laterales"
        Me.chkAirbag.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "670"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "540"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "1050"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "2100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "150"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "400"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "150"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(295, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "1600"
        '
        'txtPrecioOpciones
        '
        Me.txtPrecioOpciones.Location = New System.Drawing.Point(160, 359)
        Me.txtPrecioOpciones.Name = "txtPrecioOpciones"
        Me.txtPrecioOpciones.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioOpciones.TabIndex = 20
        '
        'txtPrecioSinOp
        '
        Me.txtPrecioSinOp.Location = New System.Drawing.Point(160, 333)
        Me.txtPrecioSinOp.Name = "txtPrecioSinOp"
        Me.txtPrecioSinOp.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioSinOp.TabIndex = 21
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(160, 385)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 22
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.Location = New System.Drawing.Point(160, 411)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioFinal.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 336)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Precio sin opciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Opciones"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Descuento opciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 414)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Precio final"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 472)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrecioFinal)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtPrecioSinOp)
        Me.Controls.Add(Me.txtPrecioOpciones)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAirbag)
        Me.Controls.Add(Me.chkAire)
        Me.Controls.Add(Me.chkCambioAuto)
        Me.Controls.Add(Me.chkAsientosCuero)
        Me.Controls.Add(Me.chkPintura)
        Me.Controls.Add(Me.chkGps)
        Me.Controls.Add(Me.chkAlarma)
        Me.Controls.Add(Me.chkAbs)
        Me.Controls.Add(Me.grpMotor)
        Me.Controls.Add(Me.grpModel)
        Me.Controls.Add(Me.pctCar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        Me.grpMotor.ResumeLayout(False)
        Me.grpMotor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pctCar As System.Windows.Forms.PictureBox
    Friend WithEvents grpModel As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFamiliar As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMonovolumen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCoupe As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpMotor As System.Windows.Forms.GroupBox
    Friend WithEvents rbtGasolina As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDiesel As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbs As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlarma As System.Windows.Forms.CheckBox
    Friend WithEvents chkGps As System.Windows.Forms.CheckBox
    Friend WithEvents chkPintura As System.Windows.Forms.CheckBox
    Friend WithEvents chkAsientosCuero As System.Windows.Forms.CheckBox
    Friend WithEvents chkCambioAuto As System.Windows.Forms.CheckBox
    Friend WithEvents chkAire As System.Windows.Forms.CheckBox
    Friend WithEvents chkAirbag As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioOpciones As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioSinOp As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
