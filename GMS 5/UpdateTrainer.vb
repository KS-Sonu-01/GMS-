Imports Microsoft.Data.SqlClient

Public Class UpdateTrainer
    Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")

    ' Constructor to receive trainer data
    Private trainerID As Integer
    Public Sub New(id As Integer, name As String, age As Integer, experience As Integer, specialization As String, contactNumber As String, address As String, availability As String)
        InitializeComponent()
        trainerID = id
        txtTrainerID.Text = id.ToString()
        txtName.Text = name
        txtAge.Text = age.ToString()
        txtExperience.Text = experience.ToString()
        txtSpecialization.Text = specialization
        txtContactNumber.Text = contactNumber
        txtAddress.Text = address
        txtAvailability.Text = availability
    End Sub

    ' ✅ Button Click to Update Trainer Details
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE Trainers SET Name=@Name, Age=@Age, Experience=@Experience, Specialization=@Specialization, ContactNumber=@ContactNumber, Address=@Address, Availability=@Availability WHERE TrainerID=@TrainerID"
            Dim cmd As New SqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@TrainerID", trainerID)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text))
            cmd.Parameters.AddWithValue("@Experience", Convert.ToInt32(txtExperience.Text))
            cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Availability", txtAvailability.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Trainer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Close Update Form
            Else
                MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' ✅ Cancel Button to Close Form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
