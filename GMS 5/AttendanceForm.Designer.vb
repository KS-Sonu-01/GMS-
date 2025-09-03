<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AttendanceForm
    Inherits System.Windows.Forms.Form

    Friend WithEvents cmbTrainer As ComboBox
    Friend WithEvents cmbMember As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents btnMarkAttendance As Button
    Friend WithEvents btnViewRecords As Button

    Private Sub InitializeComponent()
        cmbTrainer = New ComboBox()
        cmbMember = New ComboBox()
        dtpDate = New DateTimePicker()
        cmbStatus = New ComboBox()
        dgvAttendance = New DataGridView()
        btnMarkAttendance = New Button()
        btnViewRecords = New Button()
        lblTrainer = New Label()
        lblMember = New Label()
        lblDate = New Label()
        lblStatus = New Label()
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbTrainer
        ' 
        cmbTrainer.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTrainer.Location = New Point(120, 42)
        cmbTrainer.Name = "cmbTrainer"
        cmbTrainer.Size = New Size(200, 28)
        cmbTrainer.TabIndex = 0
        ' 
        ' cmbMember
        ' 
        cmbMember.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMember.Location = New Point(120, 82)
        cmbMember.Name = "cmbMember"
        cmbMember.Size = New Size(200, 28)
        cmbMember.TabIndex = 1
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(120, 122)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 27)
        dtpDate.TabIndex = 2
        dtpDate.Value = New Date(2025, 4, 3, 0, 0, 0, 0)
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Items.AddRange(New Object() {"Present", "Absent"})
        cmbStatus.Location = New Point(120, 162)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(120, 28)
        cmbStatus.TabIndex = 3
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Location = New Point(15, 238)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.ReadOnly = True
        dgvAttendance.RowHeadersWidth = 51
        dgvAttendance.Size = New Size(615, 244)
        dgvAttendance.TabIndex = 6
        ' 
        ' btnMarkAttendance
        ' 
        btnMarkAttendance.Location = New Point(120, 197)
        btnMarkAttendance.Name = "btnMarkAttendance"
        btnMarkAttendance.Size = New Size(150, 35)
        btnMarkAttendance.TabIndex = 4
        btnMarkAttendance.Text = "Mark Attendance"
        ' 
        ' btnViewRecords
        ' 
        btnViewRecords.Location = New Point(299, 197)
        btnViewRecords.Name = "btnViewRecords"
        btnViewRecords.Size = New Size(150, 35)
        btnViewRecords.TabIndex = 5
        btnViewRecords.Text = "View Records"
        ' 
        ' lblTrainer
        ' 
        lblTrainer.Location = New Point(15, 42)
        lblTrainer.Name = "lblTrainer"
        lblTrainer.Size = New Size(100, 23)
        lblTrainer.TabIndex = 7
        lblTrainer.Text = "Trainer:"
        ' 
        ' lblMember
        ' 
        lblMember.Location = New Point(15, 82)
        lblMember.Name = "lblMember"
        lblMember.Size = New Size(100, 23)
        lblMember.TabIndex = 8
        lblMember.Text = "Member:"
        ' 
        ' lblDate
        ' 
        lblDate.Location = New Point(15, 122)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(100, 23)
        lblDate.TabIndex = 9
        lblDate.Text = "Date:"
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(15, 162)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(100, 23)
        lblStatus.TabIndex = 10
        lblStatus.Text = "Status:"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonFace
        btnBack.Location = New Point(481, 197)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 35)
        btnBack.TabIndex = 11
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 31)
        Label1.TabIndex = 12
        Label1.Text = "KS FITNESS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Desktop
        Label2.Location = New Point(184, -2)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 31)
        Label2.TabIndex = 13
        Label2.Text = "ATTENDANCE FORM"
        ' 
        ' AttendanceForm
        ' 
        BackColor = Color.Azure
        ClientSize = New Size(647, 498)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(cmbTrainer)
        Controls.Add(cmbMember)
        Controls.Add(dtpDate)
        Controls.Add(cmbStatus)
        Controls.Add(btnMarkAttendance)
        Controls.Add(btnViewRecords)
        Controls.Add(dgvAttendance)
        Controls.Add(lblTrainer)
        Controls.Add(lblMember)
        Controls.Add(lblDate)
        Controls.Add(lblStatus)
        Name = "AttendanceForm"
        Text = "Attendance Management"
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTrainer As Label
    Friend WithEvents lblMember As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class