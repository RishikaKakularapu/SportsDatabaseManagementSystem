Imports System.Data.SqlClient
Public Class Tournament
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        welcomeform.Show()
        Me.Hide()
    End Sub

    Private Sub Tournament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportsDatabaseManagementSystemDataSet6.TOURNAMENT' table. You can move, or remove it, as needed.
        Me.TOURNAMENTTableAdapter.Fill(Me.SportsDatabaseManagementSystemDataSet6.TOURNAMENT)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=RISHIKA;Initial Catalog=SportsDatabaseManagementSystem;Persist Security Info=True;User ID=SA;Password=Rishika@7"
        Dim query As String = "SELECT TournamentSportName, COUNT(*) AS TournamentCount FROM Tournament GROUP BY TournamentSportName;"

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