Imports Microsoft.Data.SqlClient

Public Class UpdateMember
    Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")

    ' Method to Load Member Data
    Public Sub LoadMemberDetails(memberID As Integer)
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM Members WHERE MemberID = @MemberID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@MemberID", memberID)

            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                txtMemberID.Text = reader("MemberID").ToString()
                txtFirstName.Text = reader("FirstName").ToString()
                txtLastName.Text = reader("LastName").ToString()
                txtEmail.Text = reader("Email").ToString()
                txtPhone.Text = reader("Phone").ToString()
                txtAddress.Text = reader("Address").ToString()
                cmbGender.Text = reader("Gender").ToString()
                dtpDOB.Value = Convert.ToDateTime(reader("DOB"))
                txtWeight.Text = reader("Weight").ToString()
                dtpJoinDate.Value = Convert.ToDateTime(reader("JoinDate"))
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading member details: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Step 1: Connect to the database
            Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")
            connection.Open()

            ' Step 2: Corrected SQL Query
            Dim query As String = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, Address = @Address, Gender = @Gender, DOB = @DOB, Weight = @Weight, JoinDate = @JoinDate WHERE MemberID = @MemberID"
            Dim command As New SqlCommand(query, connection)

            ' Step 3: Corrected Parameter Assignments
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            command.Parameters.AddWithValue("@LastName", txtLastName.Text)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)
            command.Parameters.AddWithValue("@Phone", txtPhone.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Gender", cmbGender.Text)
            command.Parameters.AddWithValue("@DOB", dtpDOB.Value)
            command.Parameters.AddWithValue("@Weight", txtWeight.Text)
            command.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value)
            command.Parameters.AddWithValue("@MemberID", Convert.ToInt32(txtMemberID.Text)) ' FIXED: Convert to Integer

            command.ExecuteNonQuery()

            ' Step 4: Show success message
            MessageBox.Show("Update Successful!")

            ' Step 5: Refresh the Member List in MembersForm
            Dim memberForm As MembersForm = CType(Application.OpenForms("MembersForm"), MembersForm)
            If memberForm IsNot Nothing Then
                memberForm.LoadMemberDetails() ' Refresh DataGridView
            Else
                MessageBox.Show("Members Form not found!")
            End If

            ' Step 6: Close the update form
            Me.Close()

            ' Step 7: Close database connection
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close() ' Closes the Update Member form
    End Sub

End Class
