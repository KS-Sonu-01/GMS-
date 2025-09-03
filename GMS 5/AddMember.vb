Imports Microsoft.Data.SqlClient

Public Class AddMember
    Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True")



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 1️⃣ Check if required fields are empty
        If txtFirstName.Text = "" Then
            MessageBox.Show("Please enter First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Exit Sub
        End If

        If txtLastName.Text = "" Then
            MessageBox.Show("Please enter Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Focus()
            Exit Sub
        End If

        ' 2️⃣ Validate email format
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern) Then
            MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Exit Sub
        End If

        ' 3️⃣ Validate phone number (only digits and 10 characters)
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "^[0-9]{10}$") Then
            MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Exit Sub
        End If

        ' 4️⃣ Ensure gender is selected
        If cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbGender.Focus()
            Exit Sub
        End If

        ' 5️⃣ Validate Date of Birth (DOB) - Should not be in the future
        If dtpDOB.Value.Date > DateTime.Now.Date Then
            MessageBox.Show("Date of Birth cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpDOB.Focus()
            Exit Sub
        End If

        ' 6️⃣ Validate Weight (Only numbers allowed)
        Dim weight As Integer
        If Not Integer.TryParse(txtWeight.Text, weight) OrElse weight <= 0 Then
            MessageBox.Show("Please enter a valid weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWeight.Focus()
            Exit Sub
        End If

        ' ✅ If all validations pass, proceed with database insertion
        Try
            Dim query As String = "INSERT INTO Members (FirstName, LastName, Email, Phone, Address, Gender, DOB, Weight, JoinDate) VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @Gender, @DOB, @Weight, GETDATE())"

            Using connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text)
                    command.Parameters.AddWithValue("@Address", txtAddress.Text)
                    command.Parameters.AddWithValue("@Gender", cmbGender.Text)
                    command.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                    command.Parameters.AddWithValue("@Join_date", dtpJoin_date.Value)
                    command.Parameters.AddWithValue("@Weight", txtWeight.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear form after successful insert
                    ClearForm()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub ClearForm()
        ' Clear text fields
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtWeight.Clear()

        ' Reset ComboBox (Gender)
        cmbGender.SelectedIndex = -1

        ' Reset Date Picker (Set to today's date)
        dtpDOB.Value = DateTime.Now
        dtpJoin_date.Value = DateTime.Now
    End Sub

    Private Sub AddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

