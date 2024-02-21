<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studenttable
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
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentMajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentGPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentClubDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentAdvisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentUniformNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet3 = New Demo1.SportsDatabaseManagementSystemDataSet3()
        Me.STUDENTTableAdapter = New Demo1.SportsDatabaseManagementSystemDataSet3TableAdapters.STUDENTTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 623)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.PlayerIDDataGridViewTextBoxColumn, Me.StudentMajorDataGridViewTextBoxColumn, Me.StudentGPADataGridViewTextBoxColumn, Me.StudentClubDataGridViewTextBoxColumn, Me.StudentAdvisorDataGridViewTextBoxColumn, Me.StudentUniformNumDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.STUDENTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(746, 321)
        Me.DataGridView1.TabIndex = 1
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerIDDataGridViewTextBoxColumn
        '
        Me.PlayerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerIDDataGridViewTextBoxColumn.Name = "PlayerIDDataGridViewTextBoxColumn"
        Me.PlayerIDDataGridViewTextBoxColumn.Width = 150
        '
        'StudentMajorDataGridViewTextBoxColumn
        '
        Me.StudentMajorDataGridViewTextBoxColumn.DataPropertyName = "StudentMajor"
        Me.StudentMajorDataGridViewTextBoxColumn.HeaderText = "StudentMajor"
        Me.StudentMajorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentMajorDataGridViewTextBoxColumn.Name = "StudentMajorDataGridViewTextBoxColumn"
        Me.StudentMajorDataGridViewTextBoxColumn.Width = 150
        '
        'StudentGPADataGridViewTextBoxColumn
        '
        Me.StudentGPADataGridViewTextBoxColumn.DataPropertyName = "StudentGPA"
        Me.StudentGPADataGridViewTextBoxColumn.HeaderText = "StudentGPA"
        Me.StudentGPADataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentGPADataGridViewTextBoxColumn.Name = "StudentGPADataGridViewTextBoxColumn"
        Me.StudentGPADataGridViewTextBoxColumn.Width = 150
        '
        'StudentClubDataGridViewTextBoxColumn
        '
        Me.StudentClubDataGridViewTextBoxColumn.DataPropertyName = "StudentClub"
        Me.StudentClubDataGridViewTextBoxColumn.HeaderText = "StudentClub"
        Me.StudentClubDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentClubDataGridViewTextBoxColumn.Name = "StudentClubDataGridViewTextBoxColumn"
        Me.StudentClubDataGridViewTextBoxColumn.Width = 150
        '
        'StudentAdvisorDataGridViewTextBoxColumn
        '
        Me.StudentAdvisorDataGridViewTextBoxColumn.DataPropertyName = "StudentAdvisor"
        Me.StudentAdvisorDataGridViewTextBoxColumn.HeaderText = "StudentAdvisor"
        Me.StudentAdvisorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentAdvisorDataGridViewTextBoxColumn.Name = "StudentAdvisorDataGridViewTextBoxColumn"
        Me.StudentAdvisorDataGridViewTextBoxColumn.Width = 150
        '
        'StudentUniformNumDataGridViewTextBoxColumn
        '
        Me.StudentUniformNumDataGridViewTextBoxColumn.DataPropertyName = "StudentUniformNum"
        Me.StudentUniformNumDataGridViewTextBoxColumn.HeaderText = "StudentUniformNum"
        Me.StudentUniformNumDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentUniformNumDataGridViewTextBoxColumn.Name = "StudentUniformNumDataGridViewTextBoxColumn"
        Me.StudentUniformNumDataGridViewTextBoxColumn.Width = 150
        '
        'STUDENTBindingSource
        '
        Me.STUDENTBindingSource.DataMember = "STUDENT"
        Me.STUDENTBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet3
        '
        'SportsDatabaseManagementSystemDataSet3
        '
        Me.SportsDatabaseManagementSystemDataSet3.DataSetName = "SportsDatabaseManagementSystemDataSet3"
        Me.SportsDatabaseManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Functionality9_studentssamemajor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(353, 39)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(419, 184)
        Me.DataGridView2.TabIndex = 3
        '
        'studenttable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 691)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "studenttable"
        Me.Text = "studenttable"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet3 As SportsDatabaseManagementSystemDataSet3
    Friend WithEvents STUDENTBindingSource As BindingSource
    Friend WithEvents STUDENTTableAdapter As SportsDatabaseManagementSystemDataSet3TableAdapters.STUDENTTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentMajorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentGPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentClubDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentAdvisorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentUniformNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
