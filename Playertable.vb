Imports System.Data.SqlClient

Public Class Playertable
    Private Sub Playertableform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportsDatabaseManagementSystemDataSet.PLAYER' table. You can move, or remove it, as needed.
        Me.PLAYERTableAdapter.Fill(Me.SportsDatabaseManagementSystemDataSet.PLAYER)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        welcomeform.Show()
        Me.Hide()
    End Sub


    Private Sub PlayerFNameToolStripButton_Click(sender As Object, e As EventArgs) Handles PlayerFNameToolStripButton.Click
        Try
            Me.PLAYERTableAdapter.PlayerFName(Me.SportsDatabaseManagementSystemDataSet.PLAYER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=RISHIKA;Initial Catalog=SportsDatabaseManagementSystem;Persist Security Info=True;User ID=SA;Password=Rishika@7"
        Dim query As String = "SELECT PlayerGen, AVG(PlayerWt) AS AverageWeight FROM PLAYER GROUP BY PlayerGen HAVING AVG(PlayerWt) > 30;
"
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Set the DataGridView's DataSource to the DataTable
                DataGridView2.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class