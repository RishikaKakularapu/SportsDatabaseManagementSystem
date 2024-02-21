Imports System.Data.SqlClient

Public Class studenttable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        welcomeform.Show()
        Me.Hide()
    End Sub

    Private Sub studenttable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportsDatabaseManagementSystemDataSet3.STUDENT' table. You can move, or remove it, as needed.
        Me.STUDENTTableAdapter.Fill(Me.SportsDatabaseManagementSystemDataSet3.STUDENT)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=RISHIKA;Initial Catalog=SportsDatabaseManagementSystem;Persist Security Info=True;User ID=SA;Password=Rishika@7"
        Dim query As String = "SELECT A.StudentID AS Student1ID, A.StudentMajor AS Student1Major, A.StudentGPA AS Student1GPA, A.StudentAdvisor AS Student1Advisor,B.StudentID AS Student2ID, B.StudentMajor AS Student2Major, B.StudentGPA AS Student2GPA, B.StudentAdvisor AS Student2Advisor FROM STUDENT A INNER JOIN STUDENT B ON A.StudentID <> B.StudentID AND A.StudentMajor = B.StudentMajor;"

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