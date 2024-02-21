<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Athletetable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AthleteIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AthleteSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AthletePositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AthleteAgentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AthleteUniformNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATHLETEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet1 = New Demo1.SportsDatabaseManagementSystemDataSet1()
        Me.ATHLETETableAdapter = New Demo1.SportsDatabaseManagementSystemDataSet1TableAdapters.ATHLETETableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATHLETEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AthleteIDDataGridViewTextBoxColumn, Me.PlayerIDDataGridViewTextBoxColumn, Me.AthleteSalaryDataGridViewTextBoxColumn, Me.AthletePositionDataGridViewTextBoxColumn, Me.AthleteAgentDataGridViewTextBoxColumn, Me.AthleteUniformNumDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ATHLETEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(755, 430)
        Me.DataGridView1.TabIndex = 0
        '
        'AthleteIDDataGridViewTextBoxColumn
        '
        Me.AthleteIDDataGridViewTextBoxColumn.DataPropertyName = "AthleteID"
        Me.AthleteIDDataGridViewTextBoxColumn.HeaderText = "AthleteID"
        Me.AthleteIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AthleteIDDataGridViewTextBoxColumn.Name = "AthleteIDDataGridViewTextBoxColumn"
        Me.AthleteIDDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerIDDataGridViewTextBoxColumn
        '
        Me.PlayerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerIDDataGridViewTextBoxColumn.Name = "PlayerIDDataGridViewTextBoxColumn"
        Me.PlayerIDDataGridViewTextBoxColumn.Width = 150
        '
        'AthleteSalaryDataGridViewTextBoxColumn
        '
        Me.AthleteSalaryDataGridViewTextBoxColumn.DataPropertyName = "AthleteSalary"
        Me.AthleteSalaryDataGridViewTextBoxColumn.HeaderText = "AthleteSalary"
        Me.AthleteSalaryDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AthleteSalaryDataGridViewTextBoxColumn.Name = "AthleteSalaryDataGridViewTextBoxColumn"
        Me.AthleteSalaryDataGridViewTextBoxColumn.Width = 150
        '
        'AthletePositionDataGridViewTextBoxColumn
        '
        Me.AthletePositionDataGridViewTextBoxColumn.DataPropertyName = "AthletePosition"
        Me.AthletePositionDataGridViewTextBoxColumn.HeaderText = "AthletePosition"
        Me.AthletePositionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AthletePositionDataGridViewTextBoxColumn.Name = "AthletePositionDataGridViewTextBoxColumn"
        Me.AthletePositionDataGridViewTextBoxColumn.Width = 150
        '
        'AthleteAgentDataGridViewTextBoxColumn
        '
        Me.AthleteAgentDataGridViewTextBoxColumn.DataPropertyName = "AthleteAgent"
        Me.AthleteAgentDataGridViewTextBoxColumn.HeaderText = "AthleteAgent"
        Me.AthleteAgentDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AthleteAgentDataGridViewTextBoxColumn.Name = "AthleteAgentDataGridViewTextBoxColumn"
        Me.AthleteAgentDataGridViewTextBoxColumn.Width = 150
        '
        'AthleteUniformNumDataGridViewTextBoxColumn
        '
        Me.AthleteUniformNumDataGridViewTextBoxColumn.DataPropertyName = "AthleteUniformNum"
        Me.AthleteUniformNumDataGridViewTextBoxColumn.HeaderText = "AthleteUniformNum"
        Me.AthleteUniformNumDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AthleteUniformNumDataGridViewTextBoxColumn.Name = "AthleteUniformNumDataGridViewTextBoxColumn"
        Me.AthleteUniformNumDataGridViewTextBoxColumn.Width = 150
        '
        'ATHLETEBindingSource
        '
        Me.ATHLETEBindingSource.DataMember = "ATHLETE"
        Me.ATHLETEBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet1
        '
        'SportsDatabaseManagementSystemDataSet1
        '
        Me.SportsDatabaseManagementSystemDataSet1.DataSetName = "SportsDatabaseManagementSystemDataSet1"
        Me.SportsDatabaseManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ATHLETETableAdapter
        '
        Me.ATHLETETableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(388, 38)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Functionality1_CalculateAverageAthleteSalary"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(466, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Athletetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 638)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Athletetable"
        Me.Text = "Athletetable"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATHLETEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet1 As SportsDatabaseManagementSystemDataSet1
    Friend WithEvents ATHLETEBindingSource As BindingSource
    Friend WithEvents ATHLETETableAdapter As SportsDatabaseManagementSystemDataSet1TableAdapters.ATHLETETableAdapter
    Friend WithEvents AthleteIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AthleteSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AthletePositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AthleteAgentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AthleteUniformNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
