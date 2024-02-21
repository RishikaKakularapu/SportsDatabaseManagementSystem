<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tournament
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TournamentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TournamentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TournamentStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TournamentLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TournamentSportNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TournamentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOURNAMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet6 = New Demo1.SportsDatabaseManagementSystemDataSet6()
        Me.TOURNAMENTTableAdapter = New Demo1.SportsDatabaseManagementSystemDataSet6TableAdapters.TOURNAMENTTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOURNAMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 503)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TournamentIDDataGridViewTextBoxColumn, Me.TournamentNameDataGridViewTextBoxColumn, Me.TournamentStartDateDataGridViewTextBoxColumn, Me.TournamentLocationDataGridViewTextBoxColumn, Me.TournamentSportNameDataGridViewTextBoxColumn, Me.TournamentTypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TOURNAMENTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(839, 190)
        Me.DataGridView1.TabIndex = 1
        '
        'TournamentIDDataGridViewTextBoxColumn
        '
        Me.TournamentIDDataGridViewTextBoxColumn.DataPropertyName = "TournamentID"
        Me.TournamentIDDataGridViewTextBoxColumn.HeaderText = "TournamentID"
        Me.TournamentIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TournamentIDDataGridViewTextBoxColumn.Name = "TournamentIDDataGridViewTextBoxColumn"
        Me.TournamentIDDataGridViewTextBoxColumn.Width = 150
        '
        'TournamentNameDataGridViewTextBoxColumn
        '
        Me.TournamentNameDataGridViewTextBoxColumn.DataPropertyName = "TournamentName"
        Me.TournamentNameDataGridViewTextBoxColumn.HeaderText = "TournamentName"
        Me.TournamentNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TournamentNameDataGridViewTextBoxColumn.Name = "TournamentNameDataGridViewTextBoxColumn"
        Me.TournamentNameDataGridViewTextBoxColumn.Width = 150
        '
        'TournamentStartDateDataGridViewTextBoxColumn
        '
        Me.TournamentStartDateDataGridViewTextBoxColumn.DataPropertyName = "TournamentStartDate"
        Me.TournamentStartDateDataGridViewTextBoxColumn.HeaderText = "TournamentStartDate"
        Me.TournamentStartDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TournamentStartDateDataGridViewTextBoxColumn.Name = "TournamentStartDateDataGridViewTextBoxColumn"
        Me.TournamentStartDateDataGridViewTextBoxColumn.Width = 150
        '
        'TournamentLocationDataGridViewTextBoxColumn
        '
        Me.TournamentLocationDataGridViewTextBoxColumn.DataPropertyName = "TournamentLocation"
        Me.TournamentLocationDataGridViewTextBoxColumn.HeaderText = "TournamentLocation"
        Me.TournamentLocationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TournamentLocationDataGridViewTextBoxColumn.Name = "TournamentLocationDataGridViewTextBoxColumn"
        Me.TournamentLocationDataGridViewTextBoxColumn.Width = 150
        '
        'TournamentSportNameDataGridViewTextBoxColumn
        '
        Me.TournamentSportNameDataGridViewTextBoxColumn.DataPropertyName = "TournamentSportName"
        Me.TournamentSportNameDataGridViewTextBoxColumn.HeaderText = "TournamentSportName"
        Me.TournamentSportNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TournamentSportNameDataGridViewTextBoxColumn.Name = "TournamentSportNameDataGridViewTextBoxColumn"
        Me.TournamentSportNameDataGridViewTextBoxColumn.Width = 150
        '
        'TournamentTypeDataGridViewTextBoxColumn
        '
        Me.TournamentTypeDataGridViewTextBoxColumn.DataPropertyName = "TournamentType"
        Me.TournamentTypeDataGridViewTextBoxColumn.HeaderText = "TournamentType"
        Me.TournamentTypeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TournamentTypeDataGridViewTextBoxColumn.Name = "TournamentTypeDataGridViewTextBoxColumn"
        Me.TournamentTypeDataGridViewTextBoxColumn.Width = 150
        '
        'TOURNAMENTBindingSource
        '
        Me.TOURNAMENTBindingSource.DataMember = "TOURNAMENT"
        Me.TOURNAMENTBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet6
        '
        'SportsDatabaseManagementSystemDataSet6
        '
        Me.SportsDatabaseManagementSystemDataSet6.DataSetName = "SportsDatabaseManagementSystemDataSet6"
        Me.SportsDatabaseManagementSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOURNAMENTTableAdapter
        '
        Me.TOURNAMENTTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(31, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(246, 93)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Functionality3_ListTournamentsGroupedbySport"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(356, 35)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(381, 180)
        Me.DataGridView2.TabIndex = 3
        '
        'Tournament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 593)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Tournament"
        Me.Text = "Tournament"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOURNAMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet6 As SportsDatabaseManagementSystemDataSet6
    Friend WithEvents TOURNAMENTBindingSource As BindingSource
    Friend WithEvents TOURNAMENTTableAdapter As SportsDatabaseManagementSystemDataSet6TableAdapters.TOURNAMENTTableAdapter
    Friend WithEvents TournamentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TournamentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TournamentStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TournamentLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TournamentSportNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TournamentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
