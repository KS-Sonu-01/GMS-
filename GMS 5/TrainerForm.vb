Imports Microsoft.Data.SqlClient  ' Import SQL library

Public Class TrainerForm
    Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")

    ' Method to Load Trainer Data into DataGridView
    Private Sub LoadTrainerList()
        Try
            connection.Open()
            Dim query As String = "SELECT TrainerID, Name, Age, Experience, Specialization, ContactNumber, Address, Availability FROM Trainers"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvTrainers.DataSource = dt ' Bind DataTable to DataGridView
        Catch ex As Exception
            MessageBox.Show("Error loading trainer data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    Private Sub btnAddTrainer_Click(sender As Object, e As EventArgs) Handles btnAddTrainer.Click
        Dim addTrainer As New AddTrainerForm()
        addTrainer.ShowDialog() ' Show Add Trainer Form
        LoadTrainerList() ' Refresh DataGridView after adding
    End Sub
    Private Sub btnShowAllTrainers_Click(sender As Object, e As EventArgs) Handles btnShowAllTrainers.Click
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM Trainers"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvTrainers.DataSource = table ' Show all trainers
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub txtSearchTrainer_Enter(sender As Object, e As EventArgs) Handles txtSearchTrainer.Enter
        If txtSearchTrainer.Text = "Enter Trainer ID" Then
            txtSearchTrainer.Text = ""  ' Remove placeholder
            txtSearchTrainer.ForeColor = Color.Black ' Change text color to black
        End If
    End Sub

    Private Sub txtSearchTrainer_Leave(sender As Object, e As EventArgs) Handles txtSearchTrainer.Leave
        If txtSearchTrainer.Text.Trim() = "" Then
            txtSearchTrainer.Text = "Enter Trainer ID" ' Restore placeholder
            txtSearchTrainer.ForeColor = Color.Gray ' Change text color to gray
        End If
    End Sub




    Private Sub btnSearchTrainer_Click(sender As Object, e As EventArgs) Handles btnSearchTrainer.Click
        ' ✅ Step 1: Validate Trainer ID input
        If txtSearchTrainer.Text.Trim() = "" OrElse txtSearchTrainer.Text = "Enter Trainer ID" Then
            MessageBox.Show("Please enter a Trainer ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim trainerID As Integer
        If Not Integer.TryParse(txtSearchTrainer.Text, trainerID) Then
            MessageBox.Show("Trainer ID must be a number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Step 2: Search in Database
        Try
            connection.Open()
            Dim query As String = "SELECT TrainerID, Name, Age, Experience, Specialization, ContactNumber, Address, Availability FROM Trainers WHERE TrainerID = @TrainerID"
            Dim cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@TrainerID", trainerID)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' ✅ Step 3: Check if Trainer Exists
            If dt.Rows.Count > 0 Then
                dgvTrainers.DataSource = dt ' Show results in DataGridView
            Else
                MessageBox.Show("No trainer found with this ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub TrainerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTrainerList() ' Load trainer data when the form opens

        ' ✅ Set placeholder when the form loads
        txtSearchTrainer.Text = "Enter Trainer ID"
        txtSearchTrainer.ForeColor = Color.Gray
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm() ' Create an instance of Dashboard
        dashboard.Show()  ' Show Dashboard
        Me.Close()  ' Close Trainer Form
    End Sub



    Private Sub btnDeleteTrainer_Click(sender As Object, e As EventArgs) Handles btnDeleteTrainer.Click
        ' ✅ Step 1: Ensure a row is selected
        If dgvTrainers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a trainer to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Step 2: Get the TrainerID of the selected row
        Dim trainerID As Integer = Convert.ToInt32(dgvTrainers.SelectedRows(0).Cells("TrainerID").Value)

        ' ✅ Step 3: Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this trainer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then Exit Sub

        ' ✅ Step 4: Delete from database
        Try
            connection.Open()
            Dim query As String = "DELETE FROM Trainers WHERE TrainerID = @TrainerID"
            Dim cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@TrainerID", trainerID)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Trainer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting trainer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        ' ✅ Step 5: Refresh DataGridView
        LoadTrainerList()
    End Sub

    Private Sub btnUpdateTrainer_Click(sender As Object, e As EventArgs) Handles btnUpdateTrainer.Click
        ' Check if a row is selected
        If dgvTrainers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a trainer to update!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get selected Trainer details
        Dim trainerID As Integer = dgvTrainers.SelectedRows(0).Cells("TrainerID").Value
        Dim name As String = dgvTrainers.SelectedRows(0).Cells("Name").Value.ToString()
        Dim age As Integer = Convert.ToInt32(dgvTrainers.SelectedRows(0).Cells("Age").Value)
        Dim experience As Integer = Convert.ToInt32(dgvTrainers.SelectedRows(0).Cells("Experience").Value)
        Dim specialization As String = dgvTrainers.SelectedRows(0).Cells("Specialization").Value.ToString()
        Dim contactNumber As String = dgvTrainers.SelectedRows(0).Cells("ContactNumber").Value.ToString()
        Dim address As String = dgvTrainers.SelectedRows(0).Cells("Address").Value.ToString()
        Dim availability As String = dgvTrainers.SelectedRows(0).Cells("Availability").Value.ToString()

        ' Open Update Trainer Form and pass data
        Dim updateForm As New UpdateTrainer(trainerID, name, age, experience, specialization, contactNumber, address, availability)
        updateForm.ShowDialog()

        ' Refresh Trainer List after updating
        LoadTrainerList()
    End Sub

End Class
