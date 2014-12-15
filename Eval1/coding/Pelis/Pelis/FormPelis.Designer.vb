<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelis))
        Dim TituloLabel As System.Windows.Forms.Label
        Dim RepartoLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim ValoracionLabel As System.Windows.Forms.Label
        Dim DuracionLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim ArgumentoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PelisDataSet = New Pelis.pelisDataSet()
        Me.PelisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelisTableAdapter = New Pelis.pelisDataSetTableAdapters.PelisTableAdapter()
        Me.TableAdapterManager = New Pelis.pelisDataSetTableAdapters.TableAdapterManager()
        Me.PelisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PelisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PelisDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.RepartoTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox = New System.Windows.Forms.TextBox()
        Me.ValoracionTextBox = New System.Windows.Forms.TextBox()
        Me.DuracionTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.ArgumentoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DirectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirectoresTableAdapter = New Pelis.pelisDataSetTableAdapters.directoresTableAdapter()
        TituloLabel = New System.Windows.Forms.Label()
        RepartoLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        ValoracionLabel = New System.Windows.Forms.Label()
        DuracionLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        ArgumentoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PelisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PelisBindingNavigator.SuspendLayout()
        CType(Me.PelisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PelisDataSet
        '
        Me.PelisDataSet.DataSetName = "pelisDataSet"
        Me.PelisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PelisBindingSource
        '
        Me.PelisBindingSource.DataMember = "Pelis"
        Me.PelisBindingSource.DataSource = Me.PelisDataSet
        '
        'PelisTableAdapter
        '
        Me.PelisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.directoresTableAdapter = Me.DirectoresTableAdapter
        Me.TableAdapterManager.PelisTableAdapter = Me.PelisTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pelis.pelisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PelisBindingNavigator
        '
        Me.PelisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PelisBindingNavigator.BindingSource = Me.PelisBindingSource
        Me.PelisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PelisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PelisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PelisBindingNavigatorSaveItem})
        Me.PelisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PelisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PelisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PelisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PelisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PelisBindingNavigator.Name = "PelisBindingNavigator"
        Me.PelisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PelisBindingNavigator.Size = New System.Drawing.Size(725, 25)
        Me.PelisBindingNavigator.TabIndex = 0
        Me.PelisBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PelisBindingNavigatorSaveItem
        '
        Me.PelisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PelisBindingNavigatorSaveItem.Image = CType(resources.GetObject("PelisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PelisBindingNavigatorSaveItem.Name = "PelisBindingNavigatorSaveItem"
        Me.PelisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PelisBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PelisDataGridView
        '
        Me.PelisDataGridView.AutoGenerateColumns = False
        Me.PelisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PelisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PelisDataGridView.DataSource = Me.PelisBindingSource
        Me.PelisDataGridView.Location = New System.Drawing.Point(281, 28)
        Me.PelisDataGridView.Name = "PelisDataGridView"
        Me.PelisDataGridView.Size = New System.Drawing.Size(424, 367)
        Me.PelisDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "titulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "titulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "reparto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "reparto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "genero"
        Me.DataGridViewTextBoxColumn5.HeaderText = "genero"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "valoracion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "valoracion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "duracion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "duracion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "año"
        Me.DataGridViewTextBoxColumn8.HeaderText = "año"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Argumento"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Argumento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(37, 33)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(32, 13)
        TituloLabel.TabIndex = 2
        TituloLabel.Text = "titulo:"
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelisBindingSource, "titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(75, 30)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(185, 20)
        Me.TituloTextBox.TabIndex = 3
        '
        'RepartoLabel
        '
        RepartoLabel.AutoSize = True
        RepartoLabel.Location = New System.Drawing.Point(26, 82)
        RepartoLabel.Name = "RepartoLabel"
        RepartoLabel.Size = New System.Drawing.Size(43, 13)
        RepartoLabel.TabIndex = 4
        RepartoLabel.Text = "reparto:"
        '
        'RepartoTextBox
        '
        Me.RepartoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelisBindingSource, "reparto", True))
        Me.RepartoTextBox.Location = New System.Drawing.Point(75, 82)
        Me.RepartoTextBox.Multiline = True
        Me.RepartoTextBox.Name = "RepartoTextBox"
        Me.RepartoTextBox.Size = New System.Drawing.Size(185, 41)
        Me.RepartoTextBox.TabIndex = 5
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(26, 132)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(43, 13)
        GeneroLabel.TabIndex = 6
        GeneroLabel.Text = "genero:"
        '
        'GeneroTextBox
        '
        Me.GeneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelisBindingSource, "genero", True))
        Me.GeneroTextBox.Location = New System.Drawing.Point(75, 129)
        Me.GeneroTextBox.Name = "GeneroTextBox"
        Me.GeneroTextBox.Size = New System.Drawing.Size(185, 20)
        Me.GeneroTextBox.TabIndex = 7
        '
        'ValoracionLabel
        '
        ValoracionLabel.AutoSize = True
        ValoracionLabel.Location = New System.Drawing.Point(10, 158)
        ValoracionLabel.Name = "ValoracionLabel"
        ValoracionLabel.Size = New System.Drawing.Size(59, 13)
        ValoracionLabel.TabIndex = 8
        ValoracionLabel.Text = "valoracion:"
        '
        'ValoracionTextBox
        '
        Me.ValoracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelisBindingSource, "valoracion", True))
        Me.ValoracionTextBox.Location = New System.Drawing.Point(75, 155)
        Me.ValoracionTextBox.Name = "ValoracionTextBox"
        Me.ValoracionTextBox.Size = New System.Drawing.Size(185, 20)
        Me.ValoracionTextBox.TabIndex = 9
        '
        'DuracionLabel
        '
        DuracionLabel.AutoSize = True
        DuracionLabel.Location = New System.Drawing.Point(18, 184)
        DuracionLabel.Name = "DuracionLabel"
        DuracionLabel.Size = New System.Drawing.Size(51, 13)
        DuracionLabel.TabIndex = 10
        DuracionLabel.Text = "duracion:"
        '
        'DuracionTextBox
        '
        Me.DuracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelisBindingSource, "duracion", True))
        Me.DuracionTextBox.Location = New System.Drawing.Point(75, 181)
        Me.DuracionTextBox.Name = "DuracionTextBox"
        Me.DuracionTextBox.Size = New System.Drawing.Size(185, 20)
        Me.DuracionTextBox.TabIndex = 11
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(41, 210)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(28, 13)
        AñoLabel.TabIndex = 12
        AñoLabel.Text = "año:"
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelisBindingSource, "año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(75, 207)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(185, 20)
        Me.AñoTextBox.TabIndex = 13
        '
        'ArgumentoLabel
        '
        ArgumentoLabel.AutoSize = True
        ArgumentoLabel.Location = New System.Drawing.Point(8, 234)
        ArgumentoLabel.Name = "ArgumentoLabel"
        ArgumentoLabel.Size = New System.Drawing.Size(61, 13)
        ArgumentoLabel.TabIndex = 14
        ArgumentoLabel.Text = "Argumento:"
        '
        'ArgumentoTextBox
        '
        Me.ArgumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelisBindingSource, "Argumento", True))
        Me.ArgumentoTextBox.Location = New System.Drawing.Point(75, 234)
        Me.ArgumentoTextBox.Multiline = True
        Me.ArgumentoTextBox.Name = "ArgumentoTextBox"
        Me.ArgumentoTextBox.Size = New System.Drawing.Size(185, 161)
        Me.ArgumentoTextBox.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PelisBindingSource, "id_director", True))
        Me.ComboBox1.DataSource = Me.DirectoresBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(75, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 21)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.ValueMember = "id_director"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 58)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 17
        Label1.Text = "director:"
        '
        'DirectoresBindingSource
        '
        Me.DirectoresBindingSource.DataMember = "directores"
        Me.DirectoresBindingSource.DataSource = Me.PelisDataSet
        '
        'DirectoresTableAdapter
        '
        Me.DirectoresTableAdapter.ClearBeforeFill = True
        '
        'FormPelis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 407)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(ArgumentoLabel)
        Me.Controls.Add(Me.ArgumentoTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(DuracionLabel)
        Me.Controls.Add(Me.DuracionTextBox)
        Me.Controls.Add(ValoracionLabel)
        Me.Controls.Add(Me.ValoracionTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroTextBox)
        Me.Controls.Add(RepartoLabel)
        Me.Controls.Add(Me.RepartoTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(Me.PelisDataGridView)
        Me.Controls.Add(Me.PelisBindingNavigator)
        Me.Name = "FormPelis"
        Me.Text = "FormPelis"
        CType(Me.PelisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PelisBindingNavigator.ResumeLayout(False)
        Me.PelisBindingNavigator.PerformLayout()
        CType(Me.PelisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PelisDataSet As Pelis.pelisDataSet
    Friend WithEvents PelisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PelisTableAdapter As Pelis.pelisDataSetTableAdapters.PelisTableAdapter
    Friend WithEvents TableAdapterManager As Pelis.pelisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PelisBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PelisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PelisDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepartoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeneroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValoracionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DuracionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArgumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DirectoresTableAdapter As Pelis.pelisDataSetTableAdapters.directoresTableAdapter
    Friend WithEvents DirectoresBindingSource As System.Windows.Forms.BindingSource
End Class
