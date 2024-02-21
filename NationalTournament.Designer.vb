<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NationalTournament
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
        Me.NatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TourIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NatStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NATIONALTOURNAMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet7 = New Demo1.SportsDatabaseManagementSystemDataSet7()
        Me.NATIONALTOURNAMENTTableAdapter = New Demo1.SportsDatabaseManagementSystemDataSet7TableAdapters.NATIONALTOURNAMENTTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NATIONALTOURNAMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NatIDDataGridViewTextBoxColumn, Me.TourIDDataGridViewTextBoxColumn, Me.NatStateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NATIONALTOURNAMENTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(57, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(731, 225)
        Me.DataGridView1.TabIndex = 1
        '
        'NatIDDataGridViewTextBoxColumn
        '
        Me.NatIDDataGridViewTextBoxColumn.DataPropertyName = "NatID"
        Me.NatIDDataGridViewTextBoxColumn.HeaderText = "NatID"
        Me.NatIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NatIDDataGridViewTextBoxColumn.Name = "NatIDDataGridViewTextBoxColumn"
        Me.NatIDDataGridViewTextBoxColumn.Width = 150
        '
        'TourIDDataGridViewTextBoxColumn
        '
        Me.TourIDDataGridViewTextBoxColumn.DataPropertyName = "TourID"
        Me.TourIDDataGridViewTextBoxColumn.HeaderText = "TourID"
        Me.TourIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TourIDDataGridViewTextBoxColumn.Name = "TourIDDataGridViewTextBoxColumn"
        Me.TourIDDataGridViewTextBoxColumn.Width = 150
        '
        'NatStateDataGridViewTextBoxColumn
        '
        Me.NatStateDataGridViewTextBoxColumn.DataPropertyName = "NatState"
        Me.NatStateDataGridViewTextBoxColumn.HeaderText = "NatState"
        Me.NatStateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NatStateDataGridViewTextBoxColumn.Name = "NatStateDataGridViewTextBoxColumn"
        Me.NatStateDataGridViewTextBoxColumn.Width = 150
        '
        'NATIONALTOURNAMENTBindingSource
        '
        Me.NATIONALTOURNAMENTBindingSource.DataMember = "NATIONALTOURNAMENT"
        Me.NATIONALTOURNAMENTBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet7
        '
        'SportsDatabaseManagementSystemDataSet7
        '
        Me.SportsDatabaseManagementSystemDataSet7.DataSetName = "SportsDatabaseManagementSystemDataSet7"
        Me.SportsDatabaseManagementSystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NATIONALTOURNAMENTTableAdapter
        '
        Me.NATIONALTOURNAMENTTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(57, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Functionality10"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(303, 37)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(370, 150)
        Me.DataGridView2.TabIndex = 3
        '
        'NationalTournament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 647)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "NationalTournament"
        Me.Text = "NationalTournament"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NATIONALTOURNAMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet7 As SportsDatabaseManagementSystemDataSet7
    Friend WithEvents NATIONALTOURNAMENTBindingSource As BindingSource
    Friend WithEvents NATIONALTOURNAMENTTableAdapter As SportsDatabaseManagementSystemDataSet7TableAdapters.NATIONALTOURNAMENTTableAdapter
    Friend WithEvents NatIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TourIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NatStateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
