<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Playertable
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
        Me.PlayerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerLNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerGenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerHtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerWtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLAYERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SportsDatabaseManagementSystemDataSet = New Demo1.SportsDatabaseManagementSystemDataSet()
        Me.MaleToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PlayerFNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PlayerFNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PLAYERTableAdapter = New Demo1.SportsDatabaseManagementSystemDataSetTableAdapters.PLAYERTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLAYERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SportsDatabaseManagementSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerFNameToolStrip.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back to main form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlayerIDDataGridViewTextBoxColumn, Me.PlayerFNameDataGridViewTextBoxColumn, Me.PlayerLNameDataGridViewTextBoxColumn, Me.PlayerDOBDataGridViewTextBoxColumn, Me.PlayerGenDataGridViewTextBoxColumn, Me.PlayerHtDataGridViewTextBoxColumn, Me.PlayerWtDataGridViewTextBoxColumn, Me.PlayerPhoneDataGridViewTextBoxColumn, Me.PlayerEmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PLAYERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(969, 435)
        Me.DataGridView1.TabIndex = 1
        '
        'PlayerIDDataGridViewTextBoxColumn
        '
        Me.PlayerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID"
        Me.PlayerIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerIDDataGridViewTextBoxColumn.Name = "PlayerIDDataGridViewTextBoxColumn"
        Me.PlayerIDDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerFNameDataGridViewTextBoxColumn
        '
        Me.PlayerFNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerFName"
        Me.PlayerFNameDataGridViewTextBoxColumn.HeaderText = "PlayerFName"
        Me.PlayerFNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerFNameDataGridViewTextBoxColumn.Name = "PlayerFNameDataGridViewTextBoxColumn"
        Me.PlayerFNameDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerLNameDataGridViewTextBoxColumn
        '
        Me.PlayerLNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerLName"
        Me.PlayerLNameDataGridViewTextBoxColumn.HeaderText = "PlayerLName"
        Me.PlayerLNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerLNameDataGridViewTextBoxColumn.Name = "PlayerLNameDataGridViewTextBoxColumn"
        Me.PlayerLNameDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerDOBDataGridViewTextBoxColumn
        '
        Me.PlayerDOBDataGridViewTextBoxColumn.DataPropertyName = "PlayerDOB"
        Me.PlayerDOBDataGridViewTextBoxColumn.HeaderText = "PlayerDOB"
        Me.PlayerDOBDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerDOBDataGridViewTextBoxColumn.Name = "PlayerDOBDataGridViewTextBoxColumn"
        Me.PlayerDOBDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerGenDataGridViewTextBoxColumn
        '
        Me.PlayerGenDataGridViewTextBoxColumn.DataPropertyName = "PlayerGen"
        Me.PlayerGenDataGridViewTextBoxColumn.HeaderText = "PlayerGen"
        Me.PlayerGenDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerGenDataGridViewTextBoxColumn.Name = "PlayerGenDataGridViewTextBoxColumn"
        Me.PlayerGenDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerHtDataGridViewTextBoxColumn
        '
        Me.PlayerHtDataGridViewTextBoxColumn.DataPropertyName = "PlayerHt"
        Me.PlayerHtDataGridViewTextBoxColumn.HeaderText = "PlayerHt"
        Me.PlayerHtDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerHtDataGridViewTextBoxColumn.Name = "PlayerHtDataGridViewTextBoxColumn"
        Me.PlayerHtDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerWtDataGridViewTextBoxColumn
        '
        Me.PlayerWtDataGridViewTextBoxColumn.DataPropertyName = "PlayerWt"
        Me.PlayerWtDataGridViewTextBoxColumn.HeaderText = "PlayerWt"
        Me.PlayerWtDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerWtDataGridViewTextBoxColumn.Name = "PlayerWtDataGridViewTextBoxColumn"
        Me.PlayerWtDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerPhoneDataGridViewTextBoxColumn
        '
        Me.PlayerPhoneDataGridViewTextBoxColumn.DataPropertyName = "PlayerPhone"
        Me.PlayerPhoneDataGridViewTextBoxColumn.HeaderText = "PlayerPhone"
        Me.PlayerPhoneDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerPhoneDataGridViewTextBoxColumn.Name = "PlayerPhoneDataGridViewTextBoxColumn"
        Me.PlayerPhoneDataGridViewTextBoxColumn.Width = 150
        '
        'PlayerEmailDataGridViewTextBoxColumn
        '
        Me.PlayerEmailDataGridViewTextBoxColumn.DataPropertyName = "PlayerEmail"
        Me.PlayerEmailDataGridViewTextBoxColumn.HeaderText = "PlayerEmail"
        Me.PlayerEmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlayerEmailDataGridViewTextBoxColumn.Name = "PlayerEmailDataGridViewTextBoxColumn"
        Me.PlayerEmailDataGridViewTextBoxColumn.Width = 150
        '
        'PLAYERBindingSource
        '
        Me.PLAYERBindingSource.DataMember = "PLAYER"
        Me.PLAYERBindingSource.DataSource = Me.SportsDatabaseManagementSystemDataSet
        '
        'SportsDatabaseManagementSystemDataSet
        '
        Me.SportsDatabaseManagementSystemDataSet.DataSetName = "SportsDatabaseManagementSystemDataSet"
        Me.SportsDatabaseManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaleToolStrip
        '
        Me.MaleToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MaleToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MaleToolStrip.Name = "MaleToolStrip"
        Me.MaleToolStrip.Size = New System.Drawing.Size(1246, 25)
        Me.MaleToolStrip.TabIndex = 2
        Me.MaleToolStrip.Text = "MaleToolStrip"
        '
        'PlayerFNameToolStrip
        '
        Me.PlayerFNameToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PlayerFNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerFNameToolStripButton})
        Me.PlayerFNameToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.PlayerFNameToolStrip.Name = "PlayerFNameToolStrip"
        Me.PlayerFNameToolStrip.Size = New System.Drawing.Size(1246, 34)
        Me.PlayerFNameToolStrip.TabIndex = 3
        Me.PlayerFNameToolStrip.Text = "PlayerFNameToolStrip"
        '
        'PlayerFNameToolStripButton
        '
        Me.PlayerFNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PlayerFNameToolStripButton.Name = "PlayerFNameToolStripButton"
        Me.PlayerFNameToolStripButton.Size = New System.Drawing.Size(316, 29)
        Me.PlayerFNameToolStripButton.Text = "Functionality7_SearchPlayersbyFName"
        '
        'PLAYERTableAdapter
        '
        Me.PLAYERTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(372, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(226, 34)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Functionality5_avgweight"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(621, 25)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(394, 143)
        Me.DataGridView2.TabIndex = 5
        '
        'Playertable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 691)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PlayerFNameToolStrip)
        Me.Controls.Add(Me.MaleToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Playertable"
        Me.Text = "Playertable"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLAYERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SportsDatabaseManagementSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayerFNameToolStrip.ResumeLayout(False)
        Me.PlayerFNameToolStrip.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SportsDatabaseManagementSystemDataSet As SportsDatabaseManagementSystemDataSet
    Friend WithEvents PLAYERBindingSource As BindingSource
    Friend WithEvents PLAYERTableAdapter As SportsDatabaseManagementSystemDataSetTableAdapters.PLAYERTableAdapter
    Friend WithEvents PlayerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerLNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerDOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerGenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerHtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerWtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaleToolStrip As ToolStrip
    Friend WithEvents PlayerFNameToolStrip As ToolStrip
    Friend WithEvents PlayerFNameToolStripButton As ToolStripButton
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
