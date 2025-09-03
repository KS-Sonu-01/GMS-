Imports Microsoft.Data.SqlClient

Public Class AddTrainerForm
    Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btnSaveTrainer_Click(sender As Object, e As EventArgs) Handles btnSaveTrainer.Click
        ' ✅ Step 1: Validate Inputs
        If txtName.Text.Trim() = "" Or txtAge.Text.Trim() = "" Or
           txtExperience.Text.Trim() = "" Or txtSpecialization.Text.Trim() = "" Or txtContactNumber.Text.Trim() = "" Or
           txtAddress.Text.Trim() = "" Or txtAvailability.Text.Trim() = "" Then

            MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Step 2: Validate Numeric Fields
        Dim age As Integer
        Dim experience As Integer
        If Not Integer.TryParse(txtAge.Text, age) Or Not Integer.TryParse(txtExperience.Text, experience) Then
            MessageBox.Show("Age and Experience must be valid numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Step 3: Validate Contact Number (10 digits)
        If txtContactNumber.Text.Length <> 10 Or Not IsNumeric(txtContactNumber.Text) Then
            MessageBox.Show("Enter a valid 10-digit Contact Number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Step 4: Insert Data into Database
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Trainers (Name, Age, Experience, Specialization, ContactNumber, Address, Availability) 
                                   VALUES (@Name, @Age, @Experience, @Specialization, @ContactNumber, @Address, @Availability)"

            Dim cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Age", age)
            cmd.Parameters.AddWithValue("@Experience", experience)
            cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Availability", txtAvailability.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Trainer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close() ' Close the form after adding
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnCancelTrainer_Click(sender As Object, e As EventArgs) Handles btnCancelTrainer.Click
        Me.Close() ' Closes the form
    End Sub

    Private Sub AddTrainerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
