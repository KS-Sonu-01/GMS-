Public Class DashboardForm
    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        Dim membersForm As New MembersForm()
        membersForm.Show()
        Me.Hide() ' Hides the dashboard
    End Sub

    Private Sub btnTrainer_Click(sender As Object, e As EventArgs) Handles btnTrainer.Click
        Dim trainerForm As New TrainerForm() ' Create an instance of Trainer Form
        trainerForm.Show()  ' Show Trainer Form
        Me.Hide() ' Hide Dashboard Form
    End Sub
    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        Dim membershipForm As New MembershipForm()
        membershipForm.Show()
        Me.Hide()
    End Sub
    Private Sub btnViewMembershipDetails_Click(sender As Object, e As EventArgs) Handles btnViewMembershipDetails.Click
        Dim membershipDetailsForm As New MembershipDetailsForm()
        membershipDetailsForm.Show()
        Me.Hide()
    End Sub


    Private Sub btnAttendanceForm_Click(sender As Object, e As EventArgs) Handles btnAttendanceForm.Click
        Dim AttendanceForm As New AttendanceForm()
        AttendanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Confirm logout
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Hide Dashboard
            Me.Hide()

            ' Show Login Form
            Dim loginForm As New Form1() ' Replace with your actual login form name
            loginForm.Show()
        End If
    End Sub
    Private Sub btnEquipmentForm_Click(sender As Object, e As EventArgs) Handles btnEquipmentForm.Click
        Dim EquipmentForm As New EquipmentForm()
        EquipmentForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportsForm_Click(sender As Object, e As EventArgs) Handles btnReportsForm.Click
        Dim ReportsForm As New ReportForm()
        ReportsForm.Show()
        Me.Hide()
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DashboardPanel_Paint(sender As Object, e As PaintEventArgs) Handles DashboardPanel.Paint

    End Sub
End Class