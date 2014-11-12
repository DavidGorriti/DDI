<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExamen))
        Me.mstMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelículaMasVistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorcentajeOcupaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaDelDíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptbCartel = New System.Windows.Forms.PictureBox()
        Me.gbxPrecio = New System.Windows.Forms.GroupBox()
        Me.rbtJubilado = New System.Windows.Forms.RadioButton()
        Me.rbtGazteKutxa = New System.Windows.Forms.RadioButton()
        Me.rbtGazteTxartela = New System.Windows.Forms.RadioButton()
        Me.rbtNormal = New System.Windows.Forms.RadioButton()
        Me.cbxEspectador = New System.Windows.Forms.CheckBox()
        Me.gbxTicket = New System.Windows.Forms.GroupBox()
        Me.txtEntradas = New System.Windows.Forms.TextBox()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.lblImporteTot = New System.Windows.Forms.Label()
        Me.lblPrecioUnin = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.tmrMarquesina = New System.Windows.Forms.Timer(Me.components)
        Me.lbxPelis = New System.Windows.Forms.ListBox()
        Me.cbSesion = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.mstMenu.SuspendLayout()
        CType(Me.ptbCartel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrecio.SuspendLayout()
        Me.gbxTicket.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstMenu
        '
        Me.mstMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.mstMenu.Location = New System.Drawing.Point(0, 0)
        Me.mstMenu.Name = "mstMenu"
        Me.mstMenu.Size = New System.Drawing.Size(370, 24)
        Me.mstMenu.TabIndex = 0
        Me.mstMenu.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PelículaMasVistaToolStripMenuItem, Me.PorcentajeOcupaciónToolStripMenuItem, Me.CajaDelDíaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'PelículaMasVistaToolStripMenuItem
        '
        Me.PelículaMasVistaToolStripMenuItem.Name = "PelículaMasVistaToolStripMenuItem"
        Me.PelículaMasVistaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PelículaMasVistaToolStripMenuItem.Text = "Película mas vista"
        '
        'PorcentajeOcupaciónToolStripMenuItem
        '
        Me.PorcentajeOcupaciónToolStripMenuItem.Name = "PorcentajeOcupaciónToolStripMenuItem"
        Me.PorcentajeOcupaciónToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PorcentajeOcupaciónToolStripMenuItem.Text = "Porcentaje ocupación"
        '
        'CajaDelDíaToolStripMenuItem
        '
        Me.CajaDelDíaToolStripMenuItem.Name = "CajaDelDíaToolStripMenuItem"
        Me.CajaDelDíaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CajaDelDíaToolStripMenuItem.Text = "Caja del día"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ptbCartel
        '
        Me.ptbCartel.InitialImage = Nothing
        Me.ptbCartel.Location = New System.Drawing.Point(209, 48)
        Me.ptbCartel.Name = "ptbCartel"
        Me.ptbCartel.Size = New System.Drawing.Size(145, 208)
        Me.ptbCartel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbCartel.TabIndex = 1
        Me.ptbCartel.TabStop = False
        Me.ptbCartel.Tag = "1"
        '
        'gbxPrecio
        '
        Me.gbxPrecio.Controls.Add(Me.rbtJubilado)
        Me.gbxPrecio.Controls.Add(Me.rbtGazteKutxa)
        Me.gbxPrecio.Controls.Add(Me.rbtGazteTxartela)
        Me.gbxPrecio.Controls.Add(Me.rbtNormal)
        Me.gbxPrecio.Controls.Add(Me.cbxEspectador)
        Me.gbxPrecio.Location = New System.Drawing.Point(13, 275)
        Me.gbxPrecio.Name = "gbxPrecio"
        Me.gbxPrecio.Size = New System.Drawing.Size(160, 191)
        Me.gbxPrecio.TabIndex = 4
        Me.gbxPrecio.TabStop = False
        Me.gbxPrecio.Text = "Precio reducido"
        '
        'rbtJubilado
        '
        Me.rbtJubilado.AutoSize = True
        Me.rbtJubilado.Location = New System.Drawing.Point(16, 126)
        Me.rbtJubilado.Name = "rbtJubilado"
        Me.rbtJubilado.Size = New System.Drawing.Size(64, 17)
        Me.rbtJubilado.TabIndex = 4
        Me.rbtJubilado.TabStop = True
        Me.rbtJubilado.Tag = "1"
        Me.rbtJubilado.Text = "Jubilado"
        Me.rbtJubilado.UseVisualStyleBackColor = True
        '
        'rbtGazteKutxa
        '
        Me.rbtGazteKutxa.AutoSize = True
        Me.rbtGazteKutxa.Location = New System.Drawing.Point(16, 94)
        Me.rbtGazteKutxa.Name = "rbtGazteKutxa"
        Me.rbtGazteKutxa.Size = New System.Drawing.Size(83, 17)
        Me.rbtGazteKutxa.TabIndex = 3
        Me.rbtGazteKutxa.TabStop = True
        Me.rbtGazteKutxa.Tag = "1"
        Me.rbtGazteKutxa.Text = "Gazte Kutxa"
        Me.rbtGazteKutxa.UseVisualStyleBackColor = True
        '
        'rbtGazteTxartela
        '
        Me.rbtGazteTxartela.AutoSize = True
        Me.rbtGazteTxartela.Location = New System.Drawing.Point(16, 62)
        Me.rbtGazteTxartela.Name = "rbtGazteTxartela"
        Me.rbtGazteTxartela.Size = New System.Drawing.Size(94, 17)
        Me.rbtGazteTxartela.TabIndex = 2
        Me.rbtGazteTxartela.TabStop = True
        Me.rbtGazteTxartela.Tag = "1"
        Me.rbtGazteTxartela.Text = "Gazte Txartela"
        Me.rbtGazteTxartela.UseVisualStyleBackColor = True
        '
        'rbtNormal
        '
        Me.rbtNormal.AutoSize = True
        Me.rbtNormal.Location = New System.Drawing.Point(16, 30)
        Me.rbtNormal.Name = "rbtNormal"
        Me.rbtNormal.Size = New System.Drawing.Size(58, 17)
        Me.rbtNormal.TabIndex = 1
        Me.rbtNormal.TabStop = True
        Me.rbtNormal.Tag = "0"
        Me.rbtNormal.Text = "Normal"
        Me.rbtNormal.UseVisualStyleBackColor = True
        '
        'cbxEspectador
        '
        Me.cbxEspectador.AutoSize = True
        Me.cbxEspectador.Location = New System.Drawing.Point(16, 159)
        Me.cbxEspectador.Name = "cbxEspectador"
        Me.cbxEspectador.Size = New System.Drawing.Size(117, 17)
        Me.cbxEspectador.TabIndex = 0
        Me.cbxEspectador.Text = "Día del espectador"
        Me.cbxEspectador.UseVisualStyleBackColor = True
        '
        'gbxTicket
        '
        Me.gbxTicket.Controls.Add(Me.txtEntradas)
        Me.gbxTicket.Controls.Add(Me.btnVenta)
        Me.gbxTicket.Controls.Add(Me.lblImporteTot)
        Me.gbxTicket.Controls.Add(Me.lblPrecioUnin)
        Me.gbxTicket.Controls.Add(Me.lblImporte)
        Me.gbxTicket.Controls.Add(Me.lblUnidad)
        Me.gbxTicket.Controls.Add(Me.lblEntrada)
        Me.gbxTicket.Location = New System.Drawing.Point(209, 275)
        Me.gbxTicket.Name = "gbxTicket"
        Me.gbxTicket.Size = New System.Drawing.Size(145, 191)
        Me.gbxTicket.TabIndex = 5
        Me.gbxTicket.TabStop = False
        Me.gbxTicket.Text = "Tícket"
        '
        'txtEntradas
        '
        Me.txtEntradas.Location = New System.Drawing.Point(103, 27)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.Size = New System.Drawing.Size(36, 20)
        Me.txtEntradas.TabIndex = 7
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(64, 155)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnVenta.TabIndex = 6
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'lblImporteTot
        '
        Me.lblImporteTot.AutoSize = True
        Me.lblImporteTot.Location = New System.Drawing.Point(100, 94)
        Me.lblImporteTot.Name = "lblImporteTot"
        Me.lblImporteTot.Size = New System.Drawing.Size(0, 13)
        Me.lblImporteTot.TabIndex = 4
        Me.lblImporteTot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrecioUnin
        '
        Me.lblPrecioUnin.AutoSize = True
        Me.lblPrecioUnin.Location = New System.Drawing.Point(100, 62)
        Me.lblPrecioUnin.Name = "lblPrecioUnin"
        Me.lblPrecioUnin.Size = New System.Drawing.Size(0, 13)
        Me.lblPrecioUnin.TabIndex = 3
        Me.lblPrecioUnin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(17, 94)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 2
        Me.lblImporte.Text = "Importe"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(17, 62)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(44, 13)
        Me.lblUnidad.TabIndex = 1
        Me.lblUnidad.Text = "Unidad:"
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(17, 30)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(52, 13)
        Me.lblEntrada.TabIndex = 0
        Me.lblEntrada.Text = "Entradas:"
        '
        'tmrMarquesina
        '
        Me.tmrMarquesina.Interval = 1000
        Me.tmrMarquesina.Tag = "0"
        '
        'lbxPelis
        '
        Me.lbxPelis.FormattingEnabled = True
        Me.lbxPelis.Items.AddRange(New Object() {"Camino", "Disaster Movie", "El niño con el pijama de rayas", "El tren de las 3:10", "Hermanos por pelotas", "La comedia de la vida", "La boda de Rachel", "Los niños de Huang-Shi", "Sólo quiero caminar", "Transsiberian"})
        Me.lbxPelis.Location = New System.Drawing.Point(12, 83)
        Me.lbxPelis.Name = "lbxPelis"
        Me.lbxPelis.Size = New System.Drawing.Size(161, 173)
        Me.lbxPelis.TabIndex = 2
        '
        'cbSesion
        '
        Me.cbSesion.FormattingEnabled = True
        Me.cbSesion.Items.AddRange(New Object() {"Primera Sesión: 16:00", "Segunda Sesión: 18:15", "Tercera Sesión: 20:30", "Sesión Golfa: 22:45"})
        Me.cbSesion.Location = New System.Drawing.Point(13, 48)
        Me.cbSesion.Name = "cbSesion"
        Me.cbSesion.Size = New System.Drawing.Size(160, 21)
        Me.cbSesion.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "camino.jpg")
        Me.ImageList1.Images.SetKeyName(1, "disaster-movie.jpg")
        Me.ImageList1.Images.SetKeyName(2, "El niño con el pijama de rayas.jpg")
        Me.ImageList1.Images.SetKeyName(3, "El tren de las 3 y 10.jpg")
        Me.ImageList1.Images.SetKeyName(4, "hermanos-por-pelotas.jpg")
        Me.ImageList1.Images.SetKeyName(5, "La comedia de la vida.jpg")
        Me.ImageList1.Images.SetKeyName(6, "la-boda-de-rachel.jpg")
        Me.ImageList1.Images.SetKeyName(7, "los-ninos-de-huang-shi.jpg")
        Me.ImageList1.Images.SetKeyName(8, "solo-quiero-caminar.jpg")
        Me.ImageList1.Images.SetKeyName(9, "Transsiberian.jpg")
        '
        'frmExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 478)
        Me.Controls.Add(Me.cbSesion)
        Me.Controls.Add(Me.gbxTicket)
        Me.Controls.Add(Me.gbxPrecio)
        Me.Controls.Add(Me.lbxPelis)
        Me.Controls.Add(Me.ptbCartel)
        Me.Controls.Add(Me.mstMenu)
        Me.MainMenuStrip = Me.mstMenu
        Me.Name = "frmExamen"
        Me.Text = "Multicines"
        Me.mstMenu.ResumeLayout(False)
        Me.mstMenu.PerformLayout()
        CType(Me.ptbCartel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrecio.ResumeLayout(False)
        Me.gbxPrecio.PerformLayout()
        Me.gbxTicket.ResumeLayout(False)
        Me.gbxTicket.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mstMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelículaMasVistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorcentajeOcupaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaDelDíaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptbCartel As System.Windows.Forms.PictureBox
    Friend WithEvents gbxPrecio As System.Windows.Forms.GroupBox
    Friend WithEvents gbxTicket As System.Windows.Forms.GroupBox
    Friend WithEvents rbtJubilado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGazteKutxa As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGazteTxartela As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNormal As System.Windows.Forms.RadioButton
    Friend WithEvents cbxEspectador As System.Windows.Forms.CheckBox
    Friend WithEvents txtEntradas As System.Windows.Forms.TextBox
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents lblImporteTot As System.Windows.Forms.Label
    Friend WithEvents lblPrecioUnin As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents tmrMarquesina As System.Windows.Forms.Timer
    Friend WithEvents lbxPelis As System.Windows.Forms.ListBox
    Friend WithEvents cbSesion As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
