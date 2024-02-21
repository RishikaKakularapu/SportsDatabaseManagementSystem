<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Match
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MatchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatchDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatchOutcomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatchDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MATCHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet5 = New Demo1.SportsDatabaseManagementSystemDataSet5()
        Me.MATCHTableAdapter = New Demo1.SportsDatabaseManagementSystemDataSet5TableAdapters.MATCHTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATCHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatchIDDataGridViewTextBoxColumn, Me.MatchDateDataGridViewTextBoxColumn, Me.MatchOutcomeDataGridViewTextBoxColumn, Me.MatchDurationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MATCHBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(839, 231)
        Me.DataGridView1.TabIndex = 1
        '
        'MatchIDDataGridViewTextBoxColumn
        '
        Me.MatchIDDataGridViewTextBoxColumn.DataPropertyName = "MatchID"
        Me.MatchIDDataGridViewTextBoxColumn.HeaderText = "MatchID"
        Me.MatchIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MatchIDDataGridViewTextBoxColumn.Name = "MatchIDDataGridViewTextBoxColumn"
        Me.MatchIDDataGridViewTextBoxColumn.Width = 150
        '
        'MatchDateDataGridViewTextBoxColumn
        '
        Me.MatchDateDataGridViewTextBoxColumn.DataPropertyName = "MatchDate"
        Me.MatchDateDataGridViewTextBoxColumn.HeaderText = "MatchDate"
        Me.MatchDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MatchDateDataGridViewTextBoxColumn.Name = "MatchDateDataGridViewTextBoxColumn"
        Me.MatchDateDataGridViewTextBoxColumn.Width = 150
        '
        'MatchOutcomeDataGridViewTextBoxColumn
        '
        Me.MatchOutcomeDataGridViewTextBoxColumn.DataPropertyName = "MatchOutcome"
        Me.MatchOutcomeDataGridViewTextBoxColumn.HeaderText = "MatchOutcome"
        Me.MatchOutcomeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MatchOutcomeDataGridViewTextBoxColumn.Name = "MatchOutcomeDataGridViewTextBoxColumn"
        Me.MatchOutcomeDataGridViewTextBoxColumn.Width = 150
        '
        'MatchDurationDataGridViewTextBoxColumn
        '
        Me.MatchDurationDataGridViewTextBoxColumn.DataPropertyName = "MatchDuration"
        Me.MatchDurationDataGridViewTextBoxColumn.HeaderText = "MatchDuration"
        Me.MatchDurationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MatchDurationDataGridViewTextBoxColumn.Name = "MatchDurationDataGridViewTextBoxColumn"
        Me.MatchDurationDataGridViewTextBoxColumn.Width = 150
        '
        'MATCHBindingSource
        '
        Me.MATCHBindingSource.DataMember = "MATCH"
        Me.MATCHBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet5
        '
        'SportsDatabaseManagementSystemDataSet5
        '
        Me.SportsDatabaseManagementSystemDataSet5.DataSetName = "SportsDatabaseManagementSystemDataSet5"
        Me.SportsDatabaseManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MATCHTableAdapter
        '
        Me.MATCHTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(37, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Functionality4_Matcheswithdurationover2.0"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(375, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Match
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Match"
        Me.Text = "Match"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATCHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet5 As SportsDatabaseManagementSystemDataSet5
    Friend WithEvents MATCHBindingSource As BindingSource
    Friend WithEvents MATCHTableAdapter As SportsDatabaseManagementSystemDataSet5TableAdapters.MATCHTableAdapter
    Friend WithEvents MatchIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatchDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatchOutcomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatchDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
