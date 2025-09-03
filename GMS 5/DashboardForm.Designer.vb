<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Panel1 = New Panel()
        btnLogout = New Button()
        btnReportsForm = New Button()
        btnAttendanceForm = New Button()
        btnEquipmentForm = New Button()
        btnViewMembershipDetails = New Button()
        btnMembership = New Button()
        btnTrainer = New Button()
        btnMembers = New Button()
        lblTitle = New Label()
        HeaderPanel = New Panel()
        lblWelcome = New Label()
        DashboardPanel = New Panel()
        Panel1.SuspendLayout()
        HeaderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnReportsForm)
        Panel1.Controls.Add(btnAttendanceForm)
        Panel1.Controls.Add(btnEquipmentForm)
        Panel1.Controls.Add(btnViewMembershipDetails)
        Panel1.Controls.Add(btnMembership)
        Panel1.Controls.Add(btnTrainer)
        Panel1.Controls.Add(btnMembers)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 60)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(244, 815)
        Panel1.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 753)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(10, 0, 0, 0)
        btnLogout.Size = New Size(244, 62)
        btnLogout.TabIndex = 8
        btnLogout.Text = "   Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnReportsForm
        ' 
        btnReportsForm.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnReportsForm.Dock = DockStyle.Top
        btnReportsForm.FlatAppearance.BorderSize = 0
        btnReportsForm.FlatStyle = FlatStyle.Flat
        btnReportsForm.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReportsForm.ForeColor = Color.White
        btnReportsForm.ImageAlign = ContentAlignment.MiddleLeft
        btnReportsForm.Location = New Point(0, 517)
        btnReportsForm.Margin = New Padding(3, 4, 3, 4)
        btnReportsForm.Name = "btnReportsForm"
        btnReportsForm.Padding = New Padding(10, 0, 0, 0)
        btnReportsForm.Size = New Size(244, 62)
        btnReportsForm.TabIndex = 7
        btnReportsForm.Text = "   Reports"
        btnReportsForm.TextAlign = ContentAlignment.MiddleLeft
        btnReportsForm.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReportsForm.UseVisualStyleBackColor = False
        ' 
        ' btnAttendanceForm
        ' 
        btnAttendanceForm.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnAttendanceForm.Dock = DockStyle.Top
        btnAttendanceForm.FlatAppearance.BorderSize = 0
        btnAttendanceForm.FlatStyle = FlatStyle.Flat
        btnAttendanceForm.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAttendanceForm.ForeColor = Color.White
        btnAttendanceForm.ImageAlign = ContentAlignment.MiddleLeft
        btnAttendanceForm.Location = New Point(0, 455)
        btnAttendanceForm.Margin = New Padding(3, 4, 3, 4)
        btnAttendanceForm.Name = "btnAttendanceForm"
        btnAttendanceForm.Padding = New Padding(10, 0, 0, 0)
        btnAttendanceForm.Size = New Size(244, 62)
        btnAttendanceForm.TabIndex = 6
        btnAttendanceForm.Text = "   Attendance"
        btnAttendanceForm.TextAlign = ContentAlignment.MiddleLeft
        btnAttendanceForm.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAttendanceForm.UseVisualStyleBackColor = False
        ' 
        ' btnEquipmentForm
        ' 
        btnEquipmentForm.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnEquipmentForm.Dock = DockStyle.Top
        btnEquipmentForm.FlatAppearance.BorderSize = 0
        btnEquipmentForm.FlatStyle = FlatStyle.Flat
        btnEquipmentForm.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEquipmentForm.ForeColor = Color.White
        btnEquipmentForm.ImageAlign = ContentAlignment.MiddleLeft
        btnEquipmentForm.Location = New Point(0, 393)
        btnEquipmentForm.Margin = New Padding(3, 4, 3, 4)
        btnEquipmentForm.Name = "btnEquipmentForm"
        btnEquipmentForm.Padding = New Padding(10, 0, 0, 0)
        btnEquipmentForm.Size = New Size(244, 62)
        btnEquipmentForm.TabIndex = 5
        btnEquipmentForm.Text = "   Equipment"
        btnEquipmentForm.TextAlign = ContentAlignment.MiddleLeft
        btnEquipmentForm.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEquipmentForm.UseVisualStyleBackColor = False
        ' 
        ' btnViewMembershipDetails
        ' 
        btnViewMembershipDetails.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnViewMembershipDetails.Dock = DockStyle.Top
        btnViewMembershipDetails.FlatAppearance.BorderSize = 0
        btnViewMembershipDetails.FlatStyle = FlatStyle.Flat
        btnViewMembershipDetails.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewMembershipDetails.ForeColor = Color.White
        btnViewMembershipDetails.ImageAlign = ContentAlignment.MiddleLeft
        btnViewMembershipDetails.Location = New Point(0, 317)
        btnViewMembershipDetails.Margin = New Padding(3, 4, 3, 4)
        btnViewMembershipDetails.Name = "btnViewMembershipDetails"
        btnViewMembershipDetails.Padding = New Padding(10, 0, 0, 0)
        btnViewMembershipDetails.Size = New Size(244, 76)
        btnViewMembershipDetails.TabIndex = 4
        btnViewMembershipDetails.Text = "   Membership Details"
        btnViewMembershipDetails.TextAlign = ContentAlignment.MiddleLeft
        btnViewMembershipDetails.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewMembershipDetails.UseVisualStyleBackColor = False
        ' 
        ' btnMembership
        ' 
        btnMembership.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnMembership.Dock = DockStyle.Top
        btnMembership.FlatAppearance.BorderSize = 0
        btnMembership.FlatStyle = FlatStyle.Flat
        btnMembership.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMembership.ForeColor = Color.White
        btnMembership.ImageAlign = ContentAlignment.MiddleLeft
        btnMembership.Location = New Point(0, 259)
        btnMembership.Margin = New Padding(3, 4, 3, 4)
        btnMembership.Name = "btnMembership"
        btnMembership.Padding = New Padding(10, 0, 0, 0)
        btnMembership.Size = New Size(244, 58)
        btnMembership.TabIndex = 3
        btnMembership.Text = "   Membership"
        btnMembership.TextAlign = ContentAlignment.MiddleLeft
        btnMembership.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMembership.UseVisualStyleBackColor = False
        ' 
        ' btnTrainer
        ' 
        btnTrainer.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnTrainer.Dock = DockStyle.Top
        btnTrainer.FlatAppearance.BorderSize = 0
        btnTrainer.FlatStyle = FlatStyle.Flat
        btnTrainer.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTrainer.ForeColor = Color.White
        btnTrainer.ImageAlign = ContentAlignment.MiddleLeft
        btnTrainer.Location = New Point(0, 177)
        btnTrainer.Margin = New Padding(3, 4, 3, 4)
        btnTrainer.Name = "btnTrainer"
        btnTrainer.Padding = New Padding(10, 0, 0, 0)
        btnTrainer.Size = New Size(244, 82)
        btnTrainer.TabIndex = 2
        btnTrainer.Text = "   Trainers"
        btnTrainer.TextAlign = ContentAlignment.MiddleLeft
        btnTrainer.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTrainer.UseVisualStyleBackColor = False
        ' 
        ' btnMembers
        ' 
        btnMembers.BackColor = Color.FromArgb(CByte(57), CByte(62), CByte(70))
        btnMembers.Dock = DockStyle.Top
        btnMembers.FlatAppearance.BorderSize = 0
        btnMembers.FlatStyle = FlatStyle.Flat
        btnMembers.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMembers.ForeColor = Color.White
        btnMembers.ImageAlign = ContentAlignment.MiddleLeft
        btnMembers.Location = New Point(0, 125)
        btnMembers.Margin = New Padding(3, 4, 3, 4)
        btnMembers.Name = "btnMembers"
        btnMembers.Padding = New Padding(10, 0, 0, 0)
        btnMembers.Size = New Size(244, 52)
        btnMembers.TabIndex = 1
        btnMembers.Text = "   Members"
        btnMembers.TextAlign = ContentAlignment.MiddleLeft
        btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMembers.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(244, 125)
        lblTitle.TabIndex = 0
        lblTitle.Text = "KS FITNESS"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HeaderPanel
        ' 
        HeaderPanel.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        HeaderPanel.BorderStyle = BorderStyle.FixedSingle
        HeaderPanel.Controls.Add(lblWelcome)
        HeaderPanel.Dock = DockStyle.Top
        HeaderPanel.Location = New Point(0, 0)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.Size = New Size(1280, 60)
        HeaderPanel.TabIndex = 0
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(53, 27)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(110, 28)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "WELCOME"
        ' 
        ' DashboardPanel
        ' 
        DashboardPanel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        DashboardPanel.BackgroundImage = CType(resources.GetObject("DashboardPanel.BackgroundImage"), Image)
        DashboardPanel.Dock = DockStyle.Fill
        DashboardPanel.Location = New Point(244, 60)
        DashboardPanel.Name = "DashboardPanel"
        DashboardPanel.Size = New Size(1036, 815)
        DashboardPanel.TabIndex = 2
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 875)
        Controls.Add(DashboardPanel)
        Controls.Add(Panel1)
        Controls.Add(HeaderPanel)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "DashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardForm"
        Panel1.ResumeLayout(False)
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMembers As Button
    Friend WithEvents btnTrainer As Button
    Friend WithEvents btnMembership As Button
    Friend WithEvents btnViewMembershipDetails As Button
    Friend WithEvents btnAttendanceForm As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnEquipmentForm As Button
    Friend WithEvents btnReportsForm As Button
    Friend WithEvents Panel1 As Panel

    ' New Components
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents DashboardPanel As Panel
    Friend WithEvents lblTitle As Label
End Class