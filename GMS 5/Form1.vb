Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Dim connection As New SqlConnection("Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblMessage.Text = "Username and password are required."
            lblMessage.ForeColor = Color.Red
            Return
        End If

        Try
            connection.Open()
            Dim query As String = "SELECT PasswordHash FROM Admin WHERE Username = @username"
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                Dim storedHash As String = Convert.ToString(cmd.ExecuteScalar())


                If Not String.IsNullOrEmpty(storedHash) Then
                    Dim inputHash As String = HashPassword(txtPassword.Text)
                    If inputHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase) Then
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        OpenDashboard()
                    Else
                        ShowErrorMessage("Invalid password.")
                    End If
                Else
                    ShowErrorMessage("User not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Login Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    Private Sub OpenDashboard()
        Dim dashboard As New DashboardForm()
        AddHandler dashboard.FormClosed, AddressOf Dashboard_FormClosed
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Close()
    End Sub

    Private Sub ShowErrorMessage(message As String)
        lblMessage.Text = message
        lblMessage.ForeColor = Color.Red
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    ' ✅ Use HEX hashing for compatibility
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2")) ' lower-case hex
            Next
            Return sb.ToString()
        End Using
    End Function



End Class

