Imports Microsoft.Data.SqlClient
Imports System.Drawing

Public Class MembershipDetailsForm
    Private connectionString As String = "Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True"

    Public Sub New()
        InitializeComponent()
        LoadMembershipData()
    End Sub

    Private Sub LoadMembershipData()
        Dim query As String = "
            SELECT 
                Members.FirstName + ' ' + Members.LastName AS FullName,
                Membership.MembershipType,
                fg.GoalName AS FitnessGoal,
                Membership.StartDate,
                Membership.ExpiryDate,
                DATEDIFF(DAY, GETDATE(), Membership.ExpiryDate) AS DaysLeft
            FROM Membership
            INNER JOIN Members ON Membership.MemberID = Members.MemberID
            LEFT JOIN FitnessGoals fg ON Membership.GoalID = fg.GoalID -- Join with FitnessGoals
            WHERE Membership.ExpiryDate >= GETDATE() OR Membership.ExpiryDate < GETDATE()
        "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Clear existing rows
                dgvMembershipDetails.Rows.Clear()

                ' Add columns if not already added
                If dgvMembershipDetails.Columns.Count = 0 Then
                    dgvMembershipDetails.Columns.Add("FullName", "Full Name")
                    dgvMembershipDetails.Columns.Add("MembershipType", "Membership Type")
                    dgvMembershipDetails.Columns.Add("FitnessGoal", "Fitness Goal")
                    dgvMembershipDetails.Columns.Add("StartDate", "Start Date")
                    dgvMembershipDetails.Columns.Add("ExpiryDate", "Expiry Date")
                    dgvMembershipDetails.Columns.Add("Status", "Status")
                End If

                ' Populate DataGridView
                While reader.Read()
                    Dim fullName As String = reader("FullName").ToString()
                    Dim membershipType As String = reader("MembershipType").ToString()
                    Dim fitnessGoal As String = If(reader("FitnessGoal") IsNot DBNull.Value, reader("FitnessGoal").ToString(), "N/A")
                    Dim startDate As DateTime = Convert.ToDateTime(reader("StartDate"))
                    Dim expiryDate As DateTime = Convert.ToDateTime(reader("ExpiryDate"))
                    Dim daysLeft As Integer = Convert.ToInt32(reader("DaysLeft"))

                    Dim status As String = GetMembershipStatus(daysLeft)

                    ' Add row to DataGridView
                    Dim rowIndex As Integer = dgvMembershipDetails.Rows.Add(fullName, membershipType, fitnessGoal, startDate.ToShortDateString(), expiryDate.ToShortDateString(), status)

                    ' Set cell style based on status
                    Select Case daysLeft
                        Case Is < 0
                            dgvMembershipDetails.Rows(rowIndex).Cells("Status").Style.BackColor = Color.Red
                            dgvMembershipDetails.Rows(rowIndex).Cells("Status").Style.ForeColor = Color.White
                        Case 0 To 7
                            dgvMembershipDetails.Rows(rowIndex).Cells("Status").Style.BackColor = Color.Yellow
                            dgvMembershipDetails.Rows(rowIndex).Cells("Status").Style.ForeColor = Color.Black
                        Case Else
                            dgvMembershipDetails.Rows(rowIndex).Cells("Status").Style.BackColor = Color.Green
                            dgvMembershipDetails.Rows(rowIndex).Cells("Status").Style.ForeColor = Color.White
                    End Select
                End While
            End Using
        End Using
    End Sub

    Private Function GetMembershipStatus(daysLeft As Integer) As String
        If daysLeft < 0 Then
            Return "Expired"
        ElseIf daysLeft <= 7 Then
            Return $"{daysLeft} day(s) left"
        Else
            Return "Active"
        End If
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm() ' Replace "Dashboard" with your actual dashboard form name
        dashboard.Show() ' Show the dashboard form
        Me.Close() ' Close the current member form
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub
End Class