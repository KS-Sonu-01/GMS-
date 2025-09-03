<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportForm
    Inherits System.Windows.Forms.Form

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents cmbFilter As ComboBox ' New control
    Friend WithEvents btnFilter As Button ' New control

    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        btnback = New Button()
        lblTitle = New Label()
        cmbReportType = New ComboBox()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        btnGenerate = New Button()
        cmbFilter = New ComboBox()
        btnFilter = New Button()
        dgvReport = New DataGridView()
        btnExportExcel = New Button()
        pnlHeader.SuspendLayout()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(71))
        pnlHeader.Controls.Add(btnback)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(cmbReportType)
        pnlHeader.Controls.Add(dtpStartDate)
        pnlHeader.Controls.Add(dtpEndDate)
        pnlHeader.Controls.Add(btnGenerate)
        pnlHeader.Controls.Add(cmbFilter)
        pnlHeader.Controls.Add(btnFilter)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1168, 120)
        pnlHeader.TabIndex = 0
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(1125, 35)
        btnback.Name = "btnback"
        btnback.Size = New Size(33, 29)
        btnback.TabIndex = 7
        btnback.Text = "<"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(344, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Gym Performance Report"
        ' 
        ' cmbReportType
        ' 
        cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbReportType.Items.AddRange(New Object() {"Member Statistics", "Attendance Summary", "Revenue Analysis", "Equipment Status"})
        cmbReportType.Location = New Point(400, 35)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(200, 28)
        cmbReportType.TabIndex = 1
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.CustomFormat = "dd-MM-yyyy"
        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.Location = New Point(620, 35)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(150, 27)
        dtpStartDate.TabIndex = 2
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.CustomFormat = "dd-MM-yyyy"
        dtpEndDate.Format = DateTimePickerFormat.Custom
        dtpEndDate.Location = New Point(800, 35)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(150, 27)
        dtpEndDate.TabIndex = 3
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnGenerate.ForeColor = Color.White
        btnGenerate.Location = New Point(969, 29)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(150, 40)
        btnGenerate.TabIndex = 4
        btnGenerate.Text = "Generate Report"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' cmbFilter
        ' 
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilter.Items.AddRange(New Object() {"All Members", "Expiring Soon", "Active Members", "Expired Members", "Absent Members", "UPI Payments", "Cash Payments", "Debit Card Payments", "Available Equipment", "Unavailable Equipment"})
        cmbFilter.Location = New Point(400, 80)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(200, 28)
        cmbFilter.TabIndex = 5
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btnFilter.FlatAppearance.BorderSize = 0
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnFilter.ForeColor = Color.White
        btnFilter.Location = New Point(620, 75)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(150, 40)
        btnFilter.TabIndex = 6
        btnFilter.Text = "Apply Filter"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' dgvReport
        ' 
        dgvReport.AllowUserToAddRows = False
        dgvReport.AllowUserToDeleteRows = False
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReport.BackgroundColor = Color.White
        dgvReport.BorderStyle = BorderStyle.None
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReport.Location = New Point(20, 142)
        dgvReport.Name = "dgvReport"
        dgvReport.RowHeadersWidth = 51
        dgvReport.Size = New Size(1138, 400)
        dgvReport.TabIndex = 1
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Location = New Point(0, 0)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(75, 23)
        btnExportExcel.TabIndex = 3
        ' 
        ' ReportForm
        ' 
        ClientSize = New Size(1168, 713)
        Controls.Add(pnlHeader)
        Controls.Add(dgvReport)
        Controls.Add(btnExportExcel)
        Name = "ReportForm"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnback As Button
End Class