Imports Microsoft.Data.SqlClient

Public Class MembersForm
    Dim conn As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")

    Private Sub MembersForm(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
    End Sub

    Private Sub LoadMembers()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM Members"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvMembers.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub





    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addForm As New AddMember()
        addForm.ShowDialog()
        LoadMembers() ' Refresh the Grid after adding a member
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Ensure a row is selected
        If dgvMembers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a member to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected Member ID
        Dim memberID As Integer = Convert.ToInt32(dgvMembers.SelectedRows(0).Cells("MemberID").Value)

        ' Open UpdateMember Form and Pass Member ID
        Dim updateForm As New UpdateMember()
        updateForm.LoadMemberDetails(memberID) ' Load member data
        updateForm.ShowDialog() ' Open form as a dialog
    End Sub

    Public Sub LoadMemberListDetails()
        Try
            ' Establish connection to SQL Server
            Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")
            connection.Open()

            ' Query to fetch all members
            Dim query As String = "SELECT * FROM Members"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table) ' Fill the DataTable with data

            ' Bind the DataTable to DataGridView
            dgvMembers.DataSource = table ' Assuming your DataGridView name is dgvMembers

            connection.Close() ' Close the connection
        Catch ex As Exception
            MessageBox.Show("Error loading members: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadMemberDetails()
        Try
            ' Step 1: Create a database connection
            Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")
            connection.Open()

            ' Step 2: Get member data from the database
            Dim query As String = "SELECT * FROM Members"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Step 3: Update DataGridView with the latest data
            dgvMembers.DataSource = table

            ' Step 4: Close the connection
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading members: " & ex.Message)
        End Try
    End Sub
    Public Sub LoadMemberForm()
        Try
            ' Step 1: Create a database connection
            Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")
            connection.Open()

            ' Step 2: Get the latest member data from the database
            Dim query As String = "SELECT * FROM Members"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Step 3: Set the DataGridView DataSource
            dgvMembers.DataSource = table

            ' Step 4: Close the connection
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading members: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm() ' Replace "Dashboard" with your actual dashboard form name
        dashboard.Show() ' Show the dashboard form
        Me.Close() ' Close the current member form
    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Step 1: Check if a row is selected
            If dgvMembers.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a member to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Step 2: Get the selected MemberID
            Dim selectedMemberID As Integer = Convert.ToInt32(dgvMembers.SelectedRows(0).Cells("MemberID").Value)

            ' Step 3: Confirm deletion
            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.No Then Return

            ' Step 4: Connect to the database
            Using connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")
                connection.Open()

                ' Step 5: Execute the delete query
                Dim query As String = "DELETE FROM Members WHERE MemberID = @MemberID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MemberID", selectedMemberID)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Step 6: Refresh DataGridView after deletion
            LoadMemberListDetails()

            ' Step 7: Show success message
            MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error deleting member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs)
        If txtSearch.Text = "Please enter member ID" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black ' Change text color to black when typing
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs)
        If txtSearch.Text = "" Then
            txtSearch.Text = "Please enter member ID"
            txtSearch.ForeColor = Color.Gray ' Reset color to gray when empty
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Try
            ' Step 1: Check if the search box is empty or still has placeholder text
            If txtSearch.Text = "" Or txtSearch.Text = "Please enter member ID" Then
                MessageBox.Show("Please enter a valid Member ID to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Step 2: Get the Member ID from the textbox
            Dim memberID As Integer
            If Not Integer.TryParse(txtSearch.Text, memberID) Then
                MessageBox.Show("Invalid Member ID format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Step 3: Connect to the database
            Using connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")
                connection.Open()

                ' Step 4: Execute the search query
                Dim query = "SELECT * FROM Members WHERE MemberID = @MemberID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MemberID", memberID)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable
                    adapter.Fill(table)

                    ' Step 5: Check if any result found
                    If table.Rows.Count > 0 Then
                        dgvMembers.DataSource = table ' Show only the searched result
                    Else
                        MessageBox.Show("No member found with this ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching for member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs)
        LoadMemberListDetails() ' Reload full member list
        txtSearch.Text = "Please enter member ID"
        txtSearch.ForeColor = Color.Gray
    End Sub

    Private Sub MembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the full member list in DataGridView
        LoadMemberListDetails()

        ' Set placeholder in search box
        txtSearch.Text = "Please enter member ID"
        txtSearch.ForeColor = Color.Gray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellContentClick

    End Sub


End Class


