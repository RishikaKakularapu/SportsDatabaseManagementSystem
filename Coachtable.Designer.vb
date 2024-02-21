<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Coachtable
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
        Me.CoachIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoachFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoachLNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoachExpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoachPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoachEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COACHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet2 = New Demo1.SportsDatabaseManagementSystemDataSet2()
        Me.COACHTableAdapter = New Demo1.SportsDatabaseManagementSystemDataSet2TableAdapters.COACHTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COACHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CoachIDDataGridViewTextBoxColumn, Me.CoachFNameDataGridViewTextBoxColumn, Me.CoachLNameDataGridViewTextBoxColumn, Me.PlayerIDDataGridViewTextBoxColumn, Me.CoachExpDataGridViewTextBoxColumn, Me.CoachPhoneDataGridViewTextBoxColumn, Me.CoachEmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.COACHBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(912, 336)
        Me.DataGridView1.TabIndex = 1
        '
        'CoachIDDataGridViewTextBoxColumn
        '
        Me.CoachIDDataGridViewTextBoxColumn.DataPropertyName = "CoachID"
        Me.CoachIDDataGridViewTextBoxColumn.HeaderText = "CoachID"
        Me.CoachIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CoachIDDataGridViewTextBoxColumn.Name = "CoachIDDataGridViewTextBoxColumn"
        Me.CoachIDDataGridViewTextBoxColumn.Width = 150
        '
        'CoachFNameDataGridViewTextBoxColumn
        '
        Me.CoachFNameDataGridViewTextBoxColumn.DataPropertyName = "CoachFName"
        Me.CoachFNameDataGridViewTextBoxColumn.HeaderText = "CoachFName"
        Me.CoachFNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CoachFNameDataGridViewTextBoxColumn.Name = "CoachFNameDataGridViewTextBoxColumn"
        Me.CoachFNameDataGridViewTextBoxColumn.Width = 150
        '
        'CoachLNameDataGridViewTextBoxColumn
        '
        Me.CoachLNameDataGridViewTextBoxColumn.DataPropertyName = "CoachLName"
        Me.CoachLNameDataGridViewTextBoxColumn.HeaderText = "CoachLName"
        Me.CoachLNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CoachLNameDataGridViewTextBoxColumn.Name = "CoachLNameDataGridViewTextBoxColumn"
        Me.CoachLNameDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerIDDataGridViewTextBoxColumn
        '
        Me.PlayerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerIDDataGridViewTextBoxColumn.Name = "PlayerIDDataGridViewTextBoxColumn"
        Me.PlayerIDDataGridViewTextBoxColumn.Width = 150
        '
        'CoachExpDataGridViewTextBoxColumn
        '
        Me.CoachExpDataGridViewTextBoxColumn.DataPropertyName = "CoachExp"
        Me.CoachExpDataGridViewTextBoxColumn.HeaderText = "CoachExp"
        Me.CoachExpDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CoachExpDataGridViewTextBoxColumn.Name = "CoachExpDataGridViewTextBoxColumn"
        Me.CoachExpDataGridViewTextBoxColumn.Width = 150
        '
        'CoachPhoneDataGridViewTextBoxColumn
        '
        Me.CoachPhoneDataGridViewTextBoxColumn.DataPropertyName = "CoachPhone"
        Me.CoachPhoneDataGridViewTextBoxColumn.HeaderText = "CoachPhone"
        Me.CoachPhoneDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CoachPhoneDataGridViewTextBoxColumn.Name = "CoachPhoneDataGridViewTextBoxColumn"
        Me.CoachPhoneDataGridViewTextBoxColumn.Width = 150
        '
        'CoachEmailDataGridViewTextBoxColumn
        '
        Me.CoachEmailDataGridViewTextBoxColumn.DataPropertyName = "CoachEmail"
        Me.CoachEmailDataGridViewTextBoxColumn.HeaderText = "CoachEmail"
        Me.CoachEmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CoachEmailDataGridViewTextBoxColumn.Name = "CoachEmailDataGridViewTextBoxColumn"
        Me.CoachEmailDataGridViewTextBoxColumn.Width = 150
        '
        'COACHBindingSource
        '
        Me.COACHBindingSource.DataMember = "COACH"
        Me.COACHBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet2
        '
        'SportsDatabaseManagementSystemDataSet2
        '
        Me.SportsDatabaseManagementSystemDataSet2.DataSetName = "SportsDatabaseManagementSystemDataSet2"
        Me.SportsDatabaseManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COACHTableAdapter
        '
        Me.COACHTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(40, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(407, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Functionality2_CountcoacheswithExpmorethan7years"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(516, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Coachtable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 632)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Coachtable"
        Me.Text = "Coachtable"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COACHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet2 As SportsDatabaseManagementSystemDataSet2
    Friend WithEvents COACHBindingSource As BindingSource
    Friend WithEvents COACHTableAdapter As SportsDatabaseManagementSystemDataSet2TableAdapters.COACHTableAdapter
    Friend WithEvents CoachIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoachFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoachLNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoachExpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoachPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoachEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
