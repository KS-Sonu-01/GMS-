Imports Microsoft.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class MembershipForm
    Private connectionString As String = "Server=LAPTOP-55M8BIHM\SQLEXPRESS;Database=GMS_DB;Integrated Security=True;TrustServerCertificate=True"
    Private isPaymentProcessed As Boolean = False

    Private Sub MembershipForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembersWithoutMembership()
        LoadMembershipTypes()
        LoadFitnessGoals()

        TogglePaymentFields()
        cmbPaymentMode.SelectedIndex = 0 ' Default to Cash
    End Sub


    Private Sub LoadMembersWithoutMembership()
        Dim query As String = "
        SELECT DISTINCT m.MemberID, m.FirstName + ' ' + m.LastName AS FullName
        FROM Members m
        WHERE NOT EXISTS (
            SELECT 1 FROM Membership ms 
            WHERE ms.MemberID = m.MemberID 
            AND ms.ExpiryDate >= GETDATE()
        )"
        Using conn As New SqlConnection(connectionString)
            Try
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbMembers.DataSource = dt
                cmbMembers.DisplayMember = "FullName"
                cmbMembers.ValueMember = "MemberID"
            Catch ex As Exception
                MessageBox.Show("Error loading members: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadMembershipTypes()
        Dim membershipTypes As New Dictionary(Of String, Decimal) From {
            {"1 Month", 500D},
            {"3 Months", 1400D},
            {"6 Months", 2500D},
            {"1 Year", 4500D}
        }

        cmbMembershipType.DataSource = New BindingSource(membershipTypes, Nothing)
        cmbMembershipType.DisplayMember = "Key"
        cmbMembershipType.ValueMember = "Value"
    End Sub

    Private Sub LoadFitnessGoals()
        Dim query As String = "SELECT GoalID, GoalName FROM FitnessGoals"

        Using conn As New SqlConnection(connectionString)
            Try
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbFitnessGoal.DataSource = dt
                cmbFitnessGoal.DisplayMember = "GoalName"
                cmbFitnessGoal.ValueMember = "GoalID"
            Catch ex As Exception
                MessageBox.Show("Error loading fitness goals: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cmbMembershipType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMembershipType.SelectedIndexChanged
        CalculateFee()
    End Sub

    Private Sub cmbFitnessGoal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFitnessGoal.SelectedIndexChanged
        CalculateFee()
    End Sub

    Private Sub CalculateFee()
        If cmbMembershipType.SelectedItem IsNot Nothing AndAlso cmbFitnessGoal.SelectedItem IsNot Nothing Then
            Dim membershipType As String = cmbMembershipType.Text
            Dim duration As Integer = GetDurationInMonths(membershipType)
            Dim baseFee As Decimal = 0D

            Select Case cmbFitnessGoal.Text
                Case "Weight Loss"
                    baseFee = 2500D
                Case "Weight Gain"
                    baseFee = 2000D
                Case Else
                    baseFee = 1000D
            End Select

            Dim totalFee As Decimal = baseFee * duration
            Select Case duration
                Case 3
                    totalFee *= 0.9D
                Case 6
                    totalFee *= 0.85D
                Case 12
                    totalFee *= 0.8D
            End Select

            txtFee.Text = totalFee.ToString("N2")
        End If
    End Sub

   


    Private Sub cmbPaymentMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMode.SelectedIndexChanged
        TogglePaymentFields()
    End Sub

    Private Sub TogglePaymentFields()
        ' Correct the condition for "Credit Card"
        Dim isCreditCard As Boolean = cmbPaymentMode.Text = "Credit Card"
        Dim isUPI As Boolean = cmbPaymentMode.Text = "UPI"

        ' Show/hide Credit Card fields
        lblCardNumber.Visible = isCreditCard
        txtCardNumber.Visible = isCreditCard
        lblCVV.Visible = isCreditCard
        txtCVV.Visible = isCreditCard
        lblExpiryDate.Visible = isCreditCard ' Show expiry date label
        dtpExpiryDate.Visible = isCreditCard ' Show expiry date picker

        ' Show/hide UPI QR code
        pbQRCode.Visible = isUPI
    End Sub


    Private Function ValidatePayment() As Boolean
        Select Case cmbPaymentMode.Text
            Case "Cash"
                Return True
            Case "Credit Card"
                ' Additional validation for Credit Card
                Dim cardPattern As New Regex("^\d{16}$") ' Updated to 16 digits
                If Not cardPattern.IsMatch(txtCardNumber.Text) Then
                    MessageBox.Show("Invalid 16-digit card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                ' Validate CVV (3 digits)
                Dim cvvPattern As New Regex("^\d{3}$")
                If Not cvvPattern.IsMatch(txtCVV.Text) Then
                    MessageBox.Show("Invalid 3-digit CVV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                ' Validate expiry date is not in the past
                If dtpExpiryDate.Value < Date.Today Then
                    MessageBox.Show("Card expiry date cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                Return True
            Case "UPI"
                Return True
            Case Else
                MessageBox.Show("Invalid payment mode selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
        End Select
    End Function
    ' Replace the existing btnSave_Click logic for renewals
    ' Inside btnSave_Click event handler
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate mandatory fields
        If cmbMembers.SelectedIndex = -1 OrElse
       cmbMembershipType.SelectedIndex = -1 OrElse
       cmbPaymentStatus.SelectedIndex = -1 OrElse
       cmbPaymentMode.SelectedIndex = -1 OrElse
       cmbFitnessGoal.SelectedIndex = -1 Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate payment details
        If Not ValidatePayment() Then Return

        Try
            Dim memberID As Integer = CInt(cmbMembers.SelectedValue)
            Dim membershipType As String = cmbMembershipType.Text
            Dim durationMonths As Integer = GetDurationInMonths(membershipType)
            Dim newExpiry As Date = dtpStartDate.Value.AddMonths(durationMonths)

            ' Check existing membership
            Dim existingMembershipQuery As String = "
            SELECT TOP 1 MembershipID, ExpiryDate 
            FROM Membership 
            WHERE MemberID = @MemberID 
            ORDER BY ExpiryDate DESC"

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using checkCmd As New SqlCommand(existingMembershipQuery, conn)
                    checkCmd.Parameters.AddWithValue("@MemberID", memberID)
                    Dim reader As SqlDataReader = checkCmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        Dim existingExpiry As Date = reader.GetDateTime(1)

                        If existingExpiry < Date.Today Then
                            ' Renew membership
                            reader.Close()
                            Dim updateQuery As String = "
                            UPDATE Membership 
                            SET ExpiryDate = @NewExpiry, 
                                MembershipType = @MembershipType,
                                MembershipFee = @MembershipFee,
                                PaymentStatus = @PaymentStatus,
                                PaymentMode = @PaymentMode,
                                PaymentReference = @PaymentReference
                            WHERE MemberID = @MemberID AND ExpiryDate = @ExistingExpiry"

                            Using updateCmd As New SqlCommand(updateQuery, conn)
                                updateCmd.Parameters.AddWithValue("@NewExpiry", newExpiry)
                                updateCmd.Parameters.AddWithValue("@MembershipType", membershipType)
                                updateCmd.Parameters.AddWithValue("@MembershipFee", CDec(txtFee.Text))
                                updateCmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text)
                                updateCmd.Parameters.AddWithValue("@PaymentMode", cmbPaymentMode.Text)
                                updateCmd.Parameters.AddWithValue("@PaymentReference", GetPaymentReference())
                                updateCmd.Parameters.AddWithValue("@MemberID", memberID)
                                updateCmd.Parameters.AddWithValue("@ExistingExpiry", existingExpiry)
                                updateCmd.ExecuteNonQuery()
                            End Using
                            MessageBox.Show("Membership renewed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Member already has an active membership.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If
                    Else
                        ' Create new membership
                        reader.Close()
                        Dim insertQuery As String = "
                        INSERT INTO Membership 
                        (MemberID, MembershipType, MembershipFee, StartDate, ExpiryDate, 
                         PaymentStatus, PaymentMode, GoalID, PaymentReference)
                        VALUES 
                        (@MemberID, @MembershipType, @MembershipFee, @StartDate, @ExpiryDate, 
                         @PaymentStatus, @PaymentMode, @GoalID, @PaymentReference)"

                        Using insertCmd As New SqlCommand(insertQuery, conn)
                            insertCmd.Parameters.AddWithValue("@MemberID", memberID)
                            insertCmd.Parameters.AddWithValue("@MembershipType", membershipType)
                            insertCmd.Parameters.AddWithValue("@MembershipFee", CDec(txtFee.Text))
                            insertCmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                            insertCmd.Parameters.AddWithValue("@ExpiryDate", newExpiry)
                            insertCmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text)
                            insertCmd.Parameters.AddWithValue("@PaymentMode", cmbPaymentMode.Text)
                            insertCmd.Parameters.AddWithValue("@GoalID", cmbFitnessGoal.SelectedValue)
                            insertCmd.Parameters.AddWithValue("@PaymentReference", GetPaymentReference())
                            insertCmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Membership created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

            LoadMembersWithoutMembership()
            ResetForm()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetForm()
        cmbMembers.SelectedIndex = -1
        cmbMembershipType.SelectedIndex = -1
        txtFee.Clear()
        dtpStartDate.Value = Date.Today
        cmbPaymentStatus.SelectedIndex = -1
        cmbPaymentMode.SelectedIndex = 0
        cmbFitnessGoal.SelectedIndex = -1
        txtCardNumber.Clear()
        txtCVV.Clear()
        dtpExpiryDate.Value = Date.Today ' Reset expiry date
        pbQRCode.Image = Nothing
        isPaymentProcessed = False
        btnSave.Enabled = False
    End Sub

    Private Function GetDurationInMonths(membershipType As String) As Integer
        Select Case membershipType
            Case "1 Month" : Return 1
            Case "3 Months" : Return 3
            Case "6 Months" : Return 6
            Case "1 Year" : Return 12
        End Select
        Return 0
    End Function



    Private Sub pbQRCode_Click(sender As Object, e As EventArgs) Handles pbQRCode.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm() ' Replace "Dashboard" with your actual dashboard form name
        dashboard.Show() ' Show the dashboard form
        Me.Close() ' Close the current member form
    End Sub

    Private Sub LoadPaymentModes()
        cmbPaymentMode.Items.Clear()
        cmbPaymentMode.Items.AddRange({"Cash", "Credit Card", "UPI"})
        cmbPaymentMode.SelectedIndex = 0 ' Default to Cash
    End Sub

    Private Function GetPaymentReference() As String
        Select Case cmbPaymentMode.Text
            Case "Cash"
                Return "CASH"
            Case "UPI"
                Return $"UPI-{Guid.NewGuid().ToString()}"
            Case "Credit Card"
                Return $"{txtCardNumber.Text}-{dtpExpiryDate.Value:MM/yyyy}-{txtCVV.Text}"
            Case Else
                Return String.Empty
        End Select
    End Function

    ' Add a new label for Trainer

End Class