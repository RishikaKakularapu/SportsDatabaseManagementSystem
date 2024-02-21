<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scholarshiptable
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
        Me.ScholarshipIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScholarshipAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScholarshipStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScholarshipEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScholarshipTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScholarshipStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCHOLARSHIPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet4 = New Demo1.SportsDatabaseManagementSystemDataSet4()
        Me.SCHOLARSHIPTableAdapter = New Demo1.SportsDatabaseManagementSystemDataSet4TableAdapters.SCHOLARSHIPTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCHOLARSHIPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ScholarshipIDDataGridViewTextBoxColumn, Me.PlayerIDDataGridViewTextBoxColumn, Me.ScholarshipAmountDataGridViewTextBoxColumn, Me.ScholarshipStartDateDataGridViewTextBoxColumn, Me.ScholarshipEndDateDataGridViewTextBoxColumn, Me.ScholarshipTypeDataGridViewTextBoxColumn, Me.ScholarshipStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SCHOLARSHIPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(50, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(691, 304)
        Me.DataGridView1.TabIndex = 1
        '
        'ScholarshipIDDataGridViewTextBoxColumn
        '
        Me.ScholarshipIDDataGridViewTextBoxColumn.DataPropertyName = "ScholarshipID"
        Me.ScholarshipIDDataGridViewTextBoxColumn.HeaderText = "ScholarshipID"
        Me.ScholarshipIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ScholarshipIDDataGridViewTextBoxColumn.Name = "ScholarshipIDDataGridViewTextBoxColumn"
        Me.ScholarshipIDDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerIDDataGridViewTextBoxColumn
        '
        Me.PlayerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerIDDataGridViewTextBoxColumn.Name = "PlayerIDDataGridViewTextBoxColumn"
        Me.PlayerIDDataGridViewTextBoxColumn.Width = 150
        '
        'ScholarshipAmountDataGridViewTextBoxColumn
        '
        Me.ScholarshipAmountDataGridViewTextBoxColumn.DataPropertyName = "ScholarshipAmount"
        Me.ScholarshipAmountDataGridViewTextBoxColumn.HeaderText = "ScholarshipAmount"
        Me.ScholarshipAmountDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ScholarshipAmountDataGridViewTextBoxColumn.Name = "ScholarshipAmountDataGridViewTextBoxColumn"
        Me.ScholarshipAmountDataGridViewTextBoxColumn.Width = 150
        '
        'ScholarshipStartDateDataGridViewTextBoxColumn
        '
        Me.ScholarshipStartDateDataGridViewTextBoxColumn.DataPropertyName = "ScholarshipStartDate"
        Me.ScholarshipStartDateDataGridViewTextBoxColumn.HeaderText = "ScholarshipStartDate"
        Me.ScholarshipStartDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ScholarshipStartDateDataGridViewTextBoxColumn.Name = "ScholarshipStartDateDataGridViewTextBoxColumn"
        Me.ScholarshipStartDateDataGridViewTextBoxColumn.Width = 150
        '
        'ScholarshipEndDateDataGridViewTextBoxColumn
        '
        Me.ScholarshipEndDateDataGridViewTextBoxColumn.DataPropertyName = "ScholarshipEndDate"
        Me.ScholarshipEndDateDataGridViewTextBoxColumn.HeaderText = "ScholarshipEndDate"
        Me.ScholarshipEndDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ScholarshipEndDateDataGridViewTextBoxColumn.Name = "ScholarshipEndDateDataGridViewTextBoxColumn"
        Me.ScholarshipEndDateDataGridViewTextBoxColumn.Width = 150
        '
        'ScholarshipTypeDataGridViewTextBoxColumn
        '
        Me.ScholarshipTypeDataGridViewTextBoxColumn.DataPropertyName = "ScholarshipType"
        Me.ScholarshipTypeDataGridViewTextBoxColumn.HeaderText = "ScholarshipType"
        Me.ScholarshipTypeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ScholarshipTypeDataGridViewTextBoxColumn.Name = "ScholarshipTypeDataGridViewTextBoxColumn"
        Me.ScholarshipTypeDataGridViewTextBoxColumn.Width = 150
        '
        'ScholarshipStatusDataGridViewTextBoxColumn
        '
        Me.ScholarshipStatusDataGridViewTextBoxColumn.DataPropertyName = "ScholarshipStatus"
        Me.ScholarshipStatusDataGridViewTextBoxColumn.HeaderText = "ScholarshipStatus"
        Me.ScholarshipStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ScholarshipStatusDataGridViewTextBoxColumn.Name = "ScholarshipStatusDataGridViewTextBoxColumn"
        Me.ScholarshipStatusDataGridViewTextBoxColumn.Width = 150
        '
        'SCHOLARSHIPBindingSource
        '
        Me.SCHOLARSHIPBindingSource.DataMember = "SCHOLARSHIP"
        Me.SCHOLARSHIPBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet4
        '
        'SportsDatabaseManagementSystemDataSet4
        '
        Me.SportsDatabaseManagementSystemDataSet4.DataSetName = "SportsDatabaseManagementSystemDataSet4"
        Me.SportsDatabaseManagementSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCHOLARSHIPTableAdapter
        '
        Me.SCHOLARSHIPTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(50, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(301, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Functionality8_scholarshippending"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Scholarshiptable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 538)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Scholarshiptable"
        Me.Text = "Scholarshiptable"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCHOLARSHIPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet4 As SportsDatabaseManagementSystemDataSet4
    Friend WithEvents SCHOLARSHIPBindingSource As BindingSource
    Friend WithEvents SCHOLARSHIPTableAdapter As SportsDatabaseManagementSystemDataSet4TableAdapters.SCHOLARSHIPTableAdapter
    Friend WithEvents ScholarshipIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScholarshipAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScholarshipStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScholarshipEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScholarshipTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScholarshipStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
