Imports System.Data.SqlClient

Public Class NationalTournament
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        welcomeform.Show()
        Me.Hide()
    End Sub

    Private Sub NationalTournament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportsDatabaseManagementSystemDataSet7.NATIONALTOURNAMENT' table. You can move, or remove it, as needed.
        Me.NATIONALTOURNAMENTTableAdapter.Fill(Me.SportsDatabaseManagementSystemDataSet7.NATIONALTOURNAMENT)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=RISHIKA;Initial Catalog=SportsDatabaseManagementSystem;Persist Security Info=True;User ID=SA;Password=Rishika@7"
        Dim query As String = "SELECT NatID, TournamentName, TournamentLocation FROM NATIONALTOURNAMENT INNER JOIN Tournament ON NATIONALTOURNAMENT.TourID = Tournament.TournamentID;"

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