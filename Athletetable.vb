Imports System.Data.SqlClient
Public Class Athletetable
    Private Sub Athletetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportsDatabaseManagementSystemDataSet1.ATHLETE' table. You can move, or remove it, as needed.
        Me.ATHLETETableAdapter.Fill(Me.SportsDatabaseManagementSystemDataSet1.ATHLETE)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        welcomeform.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=RISHIKA;Initial Catalog=SportsDatabaseManagementSystem;Persist Security Info=True;User ID=SA;Password=Rishika@7"
        Dim query As String = "SELECT AVG(CAST(REPLACE(REPLACE(AthleteSalary, '$', ''), ',', '') AS DECIMAL(10, 2))) AS AverageAthleteSalary FROM Athlete WHERE TRY_CAST(REPLACE(REPLACE(AthleteSalary, '$', ''), ',', '') AS DECIMAL(10, 2)) IS NOT NULL;"

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