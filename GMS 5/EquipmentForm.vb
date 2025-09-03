Imports Microsoft.Data.SqlClient

Public Class EquipmentForm
    Private connectionString As String = "Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadEquipment()
    End Sub

    Private Sub LoadEquipment()
        Dim query As String = "
            SELECT 
                EquipmentID,
                Name,
                Description,
                Cost,
                CASE 
                    WHEN Status = 1 THEN 'Available' 
                    ELSE 'Not Available' 
                END AS Status,
                DateAdded
            FROM Equipment"

        Using conn As New SqlConnection(connectionString)
            Try
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvEquipment.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading equipment: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtName.Text) OrElse
           String.IsNullOrEmpty(txtDescription.Text) OrElse
           Not Decimal.TryParse(txtCost.Text, Nothing) Then

            MessageBox.Show("Please fill all fields with valid data.")
            Return
        End If

        Dim status As Integer = If(cmbStatus.Text = "Available", 1, 0)

        Dim query As String = "
            INSERT INTO Equipment (Name, Description, Cost, Status)
            VALUES (@Name, @Description, @Cost, @Status)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
                cmd.Parameters.AddWithValue("@Cost", Decimal.Parse(txtCost.Text))
                cmd.Parameters.AddWithValue("@Status", status)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Equipment added successfully!")
                    LoadEquipment()
                Catch ex As Exception
                    MessageBox.Show("Error adding equipment: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvEquipment.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.")
            Return
        End If

        Dim selectedRow = dgvEquipment.SelectedRows(0)
        Dim equipmentID As Integer = CInt(selectedRow.Cells("EquipmentID").Value)

        Dim status As Integer = If(cmbStatus.Text = "Available", 1, 0)

        Dim query As String = "
            UPDATE Equipment 
            SET Name = @Name, 
                Description = @Description, 
                Cost = @Cost, 
                Status = @Status 
            WHERE EquipmentID = @EquipmentID"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EquipmentID", equipmentID)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
                cmd.Parameters.AddWithValue("@Cost", Decimal.Parse(txtCost.Text))
                cmd.Parameters.AddWithValue("@Status", status)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Equipment updated successfully!")
                    LoadEquipment()
                Catch ex As Exception
                    MessageBox.Show("Error updating equipment: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub dgvEquipment_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEquipment.SelectionChanged
        If dgvEquipment.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEquipment.SelectedRows(0)
            txtName.Text = selectedRow.Cells("Name").Value.ToString()
            txtDescription.Text = selectedRow.Cells("Description").Value.ToString()
            txtCost.Text = selectedRow.Cells("Cost").Value.ToString()
            cmbStatus.Text = selectedRow.Cells("Status").Value.ToString()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvEquipment.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        Dim equipmentID As Integer = CInt(dgvEquipment.SelectedRows(0).Cells("EquipmentID").Value)

        Dim query As String = "DELETE FROM Equipment WHERE EquipmentID = @EquipmentID"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EquipmentID", equipmentID)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Equipment deleted successfully!")
                    LoadEquipment()
                Catch ex As Exception
                    MessageBox.Show("Error deleting equipment: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm() ' Replace "Dashboard" with your actual dashboard form name
        dashboard.Show() ' Show the dashboard form
        Me.Close() ' Close the current member form
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub
End Class