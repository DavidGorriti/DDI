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
        Dim PalabraLabel As System.Windows.Forms.Label
        Me.LingoDataSet = New WindowsApplication1.lingoDataSet()
        Me.PalabrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PalabrasTableAdapter = New WindowsApplication1.lingoDataSetTableAdapters.palabrasTableAdapter()
        Me.PalabraTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        PalabraLabel = New System.Windows.Forms.Label()
        CType(Me.LingoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalabrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LingoDataSet
        '
        Me.LingoDataSet.DataSetName = "lingoDataSet"
        Me.LingoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PalabrasBindingSource
        '
        Me.PalabrasBindingSource.DataMember = "palabras"
        Me.PalabrasBindingSource.DataSource = Me.LingoDataSet
        '
        'PalabrasTableAdapter
        '
        Me.PalabrasTableAdapter.ClearBeforeFill = True
        '
        'PalabraLabel
        '
        PalabraLabel.AutoSize = True
        PalabraLabel.Location = New System.Drawing.Point(16, 15)
        PalabraLabel.Name = "PalabraLabel"
        PalabraLabel.Size = New System.Drawing.Size(45, 13)
        PalabraLabel.TabIndex = 2
        PalabraLabel.Text = "palabra:"
        '
        'PalabraTextBox
        '
        Me.PalabraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PalabrasBindingSource, "palabra", True))
        Me.PalabraTextBox.Location = New System.Drawing.Point(67, 12)
        Me.PalabraTextBox.Name = "PalabraTextBox"
        Me.PalabraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PalabraTextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Randomize"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 43)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PalabraLabel)
        Me.Controls.Add(Me.PalabraTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LingoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalabrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LingoDataSet As WindowsApplication1.lingoDataSet
    Friend WithEvents PalabrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PalabrasTableAdapter As WindowsApplication1.lingoDataSetTableAdapters.palabrasTableAdapter
    Friend WithEvents PalabraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
