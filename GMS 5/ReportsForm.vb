Imports Microsoft.Data.SqlClient
Imports ClosedXML.Excel
Imports System.IO

Public Class ReportForm
    Private connectionString As String = "Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True"

    Public Sub New()
        InitializeComponent()
        dtpStartDate.Value = Date.Today.AddDays(-30)
        dtpEndDate.Value = Date.Today
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cmbReportType.SelectedIndex = -1 OrElse
           dtpStartDate.Value > dtpEndDate.Value Then
            MessageBox.Show("Please select valid dates and a report type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        GenerateReport(cmbReportType.Text, dtpStartDate.Value, dtpEndDate.Value)
    End Sub

    Private Sub GenerateReport(reportType As String, startDate As Date, endDate As Date)

        Dim query As String = ""
            Dim adapter As New SqlDataAdapter()
            Dim dt As New DataTable()

            Select Case reportType
                Case "Member Statistics"
                    query = "
                        SELECT 
                            m.FirstName + ' ' + m.LastName AS FullName,
                            ms.MembershipType,
                            CASE WHEN DATEDIFF(DAY, GETDATE(), ms.ExpiryDate) < 0 THEN 'Expired'
                                 WHEN DATEDIFF(DAY, GETDATE(), ms.ExpiryDate) BETWEEN 0 AND 7 THEN 'Expiring Soon'
                                 ELSE 'Active' END AS Status
                        FROM Membership ms
                        INNER JOIN Members m ON ms.MemberID = m.MemberID
                        WHERE StartDate BETWEEN @StartDate AND @EndDate;"
                Case "Attendance Summary"
                    query = "
                        SELECT 
                            m.FirstName + ' ' + m.LastName AS FullName,
                            COUNT(a.AttendanceID) AS TotalVisits
                        FROM Attendance a
                        INNER JOIN Members m ON a.MemberID = m.MemberID
                        WHERE a.AttendanceDate BETWEEN @StartDate AND @EndDate
                        GROUP BY m.FirstName, m.LastName;"
                Case "Revenue Analysis"
                    query = "
                        SELECT 
                            PaymentMode,
                            SUM(MembershipFee) AS TotalRevenue
                        FROM Membership
                        WHERE StartDate BETWEEN @StartDate AND @EndDate
                        GROUP BY PaymentMode;"
                Case "Equipment Status"
                    query = "
                        SELECT 
                            Name AS EquipmentName,
                            CASE WHEN Status = 1 THEN 'Available' ELSE 'Not Available' END AS Status
                        FROM Equipment;"
                Case Else
                    MessageBox.Show("Invalid report type selected.")
                    Return
            End Select

            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StartDate", startDate)
                    cmd.Parameters.AddWithValue("@EndDate", endDate)
                    conn.Open()
                    adapter.SelectCommand = cmd
                    adapter.Fill(dt)
                End Using
            End Using

            dgvReport.DataSource = dt

    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.")
            Return
        End If

        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim workbook As New XLWorkbook()
                    Dim worksheet = workbook.Worksheets.Add("Report")
                    worksheet.Cell(1, 1).Value = "Gym Performance Report"
                    worksheet.Cell(1, 1).Style.Font.Bold = True
                    worksheet.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.FromArgb(45, 52, 71)
                    worksheet.Cell(1, 1).Style.Font.FontColor = XLColor.White

                    ' Add DataGridView data
                    worksheet.Cell(3, 1).InsertTable(dgvReport.DataSource)
                    workbook.SaveAs(saveFileDialog.FileName)
                    MessageBox.Show("Report exported to Excel successfully!")
                Catch ex As Exception
                    MessageBox.Show("Export error: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If cmbFilter.SelectedIndex = -1 Then
            MessageBox.Show("Please select a filter option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ApplyFilter(cmbFilter.Text)
    End Sub

    Private Sub ApplyFilter(filterOption As String)
        Try
            Dim query As String = ""
            Dim adapter As New SqlDataAdapter()
            Dim dt As New DataTable()

            Select Case filterOption
                Case "All Members"
                    ' Use correct column names (e.g., "Phone" instead of "PhoneNumber")
                    query = "SELECT MemberID, FirstName + ' ' + LastName AS FullName, Email, Phone, JoinDate FROM Members;"

                Case "Expiring Soon"
                    query = "
                    SELECT 
                        m.FirstName + ' ' + m.LastName AS FullName,
                        ms.MembershipType,
                        ms.MembershipFee,
                        ms.StartDate,
                        ms.ExpiryDate,
                        ms.PaymentStatus,
                        ms.PaymentMode,
                        ms.PaymentReference
                    FROM Membership ms
                    INNER JOIN Members m ON ms.MemberID = m.MemberID
                    WHERE ms.ExpiryDate BETWEEN GETDATE() AND DATEADD(DAY, 7, GETDATE());"

                Case "Active Members"
                    query = "
                    SELECT 
                        m.FirstName + ' ' + m.LastName AS FullName,
                        ms.MembershipType,
                        ms.MembershipFee,
                        ms.StartDate,
                        ms.ExpiryDate,
                        ms.PaymentStatus,
                        ms.PaymentMode,
                        ms.PaymentReference
                    FROM Membership ms
                    INNER JOIN Members m ON ms.MemberID = m.MemberID
                    WHERE ms.ExpiryDate > GETDATE();"

                Case "Expired Members"
                    query = "
                    SELECT 
                        m.FirstName + ' ' + m.LastName AS FullName,
                        ms.MembershipType,
                        ms.MembershipFee,
                        ms.StartDate,
                        ms.ExpiryDate,
                        ms.PaymentStatus,
                        ms.PaymentMode,
                        ms.PaymentReference
                    FROM Membership ms
                    INNER JOIN Members m ON ms.MemberID = m.MemberID
                    WHERE ms.ExpiryDate < GETDATE();"

                Case "Absent Members"
                    query = "
                    SELECT 
                        m.FirstName + ' ' + m.LastName AS FullName,
                        m.Email,
                        m.Phone, -- Use correct column name here
                        m.JoinDate
                    FROM Members m
                    LEFT JOIN Attendance a ON m.MemberID = a.MemberID
                    WHERE a.AttendanceDate IS NULL;"

                Case "UPI Payments", "Cash Payments", "Debit Card Payments"
                    Dim paymentMode As String = filterOption.Replace(" Payments", "")
                    query = $"
                    SELECT 
                        m.FirstName + ' ' + m.LastName AS FullName,
                        ms.MembershipType,
                        ms.MembershipFee,
                        ms.StartDate,
                        ms.ExpiryDate,
                        ms.PaymentStatus,
                        ms.PaymentReference
                    FROM Membership ms
                    INNER JOIN Members m ON ms.MemberID = m.MemberID
                    WHERE ms.PaymentMode = '{paymentMode}';"

                Case "Available Equipment", "Unavailable Equipment"
                    Dim status As Integer = If(filterOption = "Available Equipment", 1, 0)
                    ' Use correct column name (e.g., "Name" instead of "EquipmentName")
                    query = $"SELECT EquipmentID, Name, Status FROM Equipment WHERE Status = {status};"

                Case Else
                    MessageBox.Show("Invalid filter option selected.")
                    Return
            End Select

            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    adapter.SelectCommand = cmd
                    adapter.Fill(dt)
                End Using
            End Using

            dgvReport.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error applying filter: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm() ' Replace "Dashboard" with your actual dashboard form name
        dashboard.Show() ' Show the dashboard form
        Me.Close() ' Close the current member form
    End Sub
End Class