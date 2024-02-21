Imports System.Data.SqlClient

Public Class Scholarshiptable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        welcomeform.Show()
        Me.Hide()
    End Sub

    Private Sub Scholarshiptable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportsDatabaseManagementSystemDataSet4.SCHOLARSHIP' table. You can move, or remove it, as needed.
        Me.SCHOLARSHIPTableAdapter.Fill(Me.SportsDatabaseManagementSystemDataSet4.SCHOLARSHIP)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=RISHIKA;Initial Catalog=SportsDatabaseManagementSystem;Persist Security Info=True;User ID=SA;Password=Rishika@7"
        Dim query As String = "SELECT ScholarshipID, ScholarshipAmount, ScholarshipStartDate, ScholarshipEndDate, ScholarshipType, ScholarshipStatus,PlayerID FROM Scholarship WHERE ScholarshipStatus = 'Pending';"

        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Set the DataGridView's DataSource to the DataTable
                DataGridView1.DataSource = table
            End Using
        End Using
    End Sub
End Class