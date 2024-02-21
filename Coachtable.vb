Imports System.Data.SqlClient
Public Class Coachtable
    Private Sub Coachtableform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportsDatabaseManagementSystemDataSet2.COACH' table. You can move, or remove it, as needed.
        Me.COACHTableAdapter.Fill(Me.SportsDatabaseManagementSystemDataSet2.COACH)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        welcomeform.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=RISHIKA;Initial Catalog=SportsDatabaseManagementSystem;Persist Security Info=True;User ID=SA;Password=Rishika@7"
        Dim query As String = "SELECT COUNT(*) AS ExperiencedCoachesCount FROM Coach WHERE CoachExp > 7;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                If result IsNot DBNull.Value Then
                    TextBox1.Text = result.ToString()
                Else
                    TextBox1.Text = "N/A"
                End If
            End Using
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class