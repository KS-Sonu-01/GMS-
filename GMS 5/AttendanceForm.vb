Imports Microsoft.Data.SqlClient

Public Class AttendanceForm
    Private connectionString As String = "Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True"

    Private Sub AttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTrainers()
        LoadStudents()
        cmbStatus.SelectedIndex = 0
    End Sub
    Private Function IsAttendanceAlreadyMarked(memberID As Integer, trainerID As Integer, attendanceDate As Date) As Boolean
        Dim query As String = "
        SELECT COUNT(*)
        FROM Attendance
        WHERE MemberID = @MemberID AND TrainerID = @TrainerID AND AttendanceDate = @AttendanceDate;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@MemberID", memberID)
                cmd.Parameters.AddWithValue("@TrainerID", trainerID)
                cmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate)

                Try
                    conn.Open()
                    ' ExecuteScalar returns the count of matching records
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    Return count > 0 ' Return True if a record exists
                Catch ex As Exception
                    MessageBox.Show("Error checking attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub LoadTrainers()
        Dim query As String = "SELECT TrainerID, Name FROM Trainers"
        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbTrainer.DataSource = dt
            cmbTrainer.DisplayMember = "Name"
            cmbTrainer.ValueMember = "TrainerID"
        End Using
    End Sub

    Private Sub LoadStudents()
        Dim query As String = "SELECT MemberID, FirstName + ' ' + LastName AS FullName FROM Members"
        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbMember.DataSource = dt
            cmbMember.DisplayMember = "FullName"
            cmbMember.ValueMember = "MemberID"
        End Using
    End Sub

    Private Sub btnMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnMarkAttendance.Click
        ' Validate input
        If cmbTrainer.SelectedIndex = -1 OrElse cmbMember.SelectedIndex = -1 Then
            MessageBox.Show("Please select trainer and student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get selected values
        Dim memberID As Integer = CInt(cmbMember.SelectedValue)
        Dim trainerID As Integer = CInt(cmbTrainer.SelectedValue)
        Dim attendanceDate As Date = dtpDate.Value

        ' Check if attendance is already marked
        If IsAttendanceAlreadyMarked(memberID, trainerID, attendanceDate) Then
            MessageBox.Show("This member has already been marked present for today.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proceed to mark attendance
        Dim status As String = cmbStatus.Text
        Dim query As String = "
        INSERT INTO Attendance (MemberID, TrainerID, AttendanceDate, Status)
        VALUES (@MemberID, @TrainerID, @AttendanceDate, @Status);"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MemberID", memberID)
                cmd.Parameters.AddWithValue("@TrainerID", trainerID)
                cmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate)
                cmd.Parameters.AddWithValue("@Status", status)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error marking attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        Dim query As String = "
            SELECT 
                a.AttendanceDate,
                m.FirstName + ' ' + m.LastName AS Member,
                t.Name AS Trainer,
                a.Status
            FROM Attendance a
            INNER JOIN Members m ON a.MemberID = m.MemberID
            INNER JOIN Trainers t ON a.TrainerID = t.TrainerID"

        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvAttendance.DataSource = dt
        End Using
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm() ' Replace "Dashboard" with your actual dashboard form name
        dashboard.Show() ' Show the dashboard form
        Me.Close()
    End Sub

    Private Sub lblMember_Click(sender As Object, e As EventArgs) Handles lblMember.Click

    End Sub
End Class