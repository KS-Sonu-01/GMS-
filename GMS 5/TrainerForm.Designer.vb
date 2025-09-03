<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrainerForm
    Inherits System.Windows.Forms.Form

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvTrainers As DataGridView
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearchTrainer As TextBox
    Friend WithEvents btnSearchTrainer As Button
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddTrainer As Button
    Friend WithEvents btnUpdateTrainer As Button
    Friend WithEvents btnDeleteTrainer As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblTitle = New Label()
        btnBack = New Button()
        dgvTrainers = New DataGridView()
        pnlSearch = New Panel()
        btnShowAllTrainers = New Button()
        txtSearchTrainer = New TextBox()
        btnSearchTrainer = New Button()
        pnlActions = New Panel()
        btnAddTrainer = New Button()
        btnUpdateTrainer = New Button()
        btnDeleteTrainer = New Button()
        Label1 = New Label()
        pnlHeader.SuspendLayout()
        CType(dgvTrainers, ComponentModel.ISupportInitialize).BeginInit()
        pnlActions.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(btnBack)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 60)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1200, 80)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.Gainsboro
        lblTitle.Location = New Point(80, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(285, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Trainer Management"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe MDL2 Assets", 14F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(20, 20)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(40, 40)
        btnBack.TabIndex = 1
        btnBack.Text = ""
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' dgvTrainers
        ' 
        dgvTrainers.AllowUserToAddRows = False
        dgvTrainers.AllowUserToDeleteRows = False
        dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTrainers.BackgroundColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        dgvTrainers.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTrainers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTrainers.DefaultCellStyle = DataGridViewCellStyle2
        dgvTrainers.EnableHeadersVisualStyles = False
        dgvTrainers.GridColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        dgvTrainers.Location = New Point(256, 204)
        dgvTrainers.Name = "dgvTrainers"
        dgvTrainers.RowHeadersWidth = 51
        dgvTrainers.Size = New Size(944, 546)
        dgvTrainers.TabIndex = 3
        ' 
        ' pnlSearch
        ' 
        pnlSearch.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        pnlSearch.Dock = DockStyle.Top
        pnlSearch.Location = New Point(0, 0)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(1200, 60)
        pnlSearch.TabIndex = 1
        ' 
        ' btnShowAllTrainers
        ' 
        btnShowAllTrainers.Location = New Point(853, 146)
        btnShowAllTrainers.Name = "btnShowAllTrainers"
        btnShowAllTrainers.Size = New Size(94, 29)
        btnShowAllTrainers.TabIndex = 2
        btnShowAllTrainers.Text = "Show All"
        btnShowAllTrainers.UseVisualStyleBackColor = True
        ' 
        ' txtSearchTrainer
        ' 
        txtSearchTrainer.BackColor = Color.WhiteSmoke
        txtSearchTrainer.BorderStyle = BorderStyle.FixedSingle
        txtSearchTrainer.Font = New Font("Segoe UI", 10F)
        txtSearchTrainer.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtSearchTrainer.Location = New Point(307, 146)
        txtSearchTrainer.Name = "txtSearchTrainer"
        txtSearchTrainer.PlaceholderText = "Search by name..."
        txtSearchTrainer.Size = New Size(400, 30)
        txtSearchTrainer.TabIndex = 0
        ' 
        ' btnSearchTrainer
        ' 
        btnSearchTrainer.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnSearchTrainer.FlatAppearance.BorderSize = 0
        btnSearchTrainer.FlatStyle = FlatStyle.Flat
        btnSearchTrainer.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSearchTrainer.ForeColor = Color.White
        btnSearchTrainer.Location = New Point(725, 146)
        btnSearchTrainer.Name = "btnSearchTrainer"
        btnSearchTrainer.Size = New Size(100, 30)
        btnSearchTrainer.TabIndex = 1
        btnSearchTrainer.Text = "Search"
        btnSearchTrainer.UseVisualStyleBackColor = False
        ' 
        ' pnlActions
        ' 
        pnlActions.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        pnlActions.Controls.Add(Label1)
        pnlActions.Controls.Add(btnAddTrainer)
        pnlActions.Controls.Add(btnUpdateTrainer)
        pnlActions.Controls.Add(btnDeleteTrainer)
        pnlActions.Dock = DockStyle.Left
        pnlActions.Location = New Point(0, 140)
        pnlActions.Name = "pnlActions"
        pnlActions.Size = New Size(250, 610)
        pnlActions.TabIndex = 2
        ' 
        ' btnAddTrainer
        ' 
        btnAddTrainer.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnAddTrainer.FlatAppearance.BorderSize = 0
        btnAddTrainer.FlatStyle = FlatStyle.Flat
        btnAddTrainer.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAddTrainer.ForeColor = Color.White
        btnAddTrainer.Location = New Point(50, 154)
        btnAddTrainer.Name = "btnAddTrainer"
        btnAddTrainer.Size = New Size(150, 45)
        btnAddTrainer.TabIndex = 0
        btnAddTrainer.Text = "Add Trainer"
        btnAddTrainer.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateTrainer
        ' 
        btnUpdateTrainer.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnUpdateTrainer.FlatAppearance.BorderSize = 0
        btnUpdateTrainer.FlatStyle = FlatStyle.Flat
        btnUpdateTrainer.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnUpdateTrainer.ForeColor = Color.White
        btnUpdateTrainer.Location = New Point(50, 261)
        btnUpdateTrainer.Name = "btnUpdateTrainer"
        btnUpdateTrainer.Size = New Size(150, 45)
        btnUpdateTrainer.TabIndex = 1
        btnUpdateTrainer.Text = "Update Trainer"
        btnUpdateTrainer.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteTrainer
        ' 
        btnDeleteTrainer.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnDeleteTrainer.FlatAppearance.BorderSize = 0
        btnDeleteTrainer.FlatStyle = FlatStyle.Flat
        btnDeleteTrainer.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnDeleteTrainer.ForeColor = Color.White
        btnDeleteTrainer.Location = New Point(50, 381)
        btnDeleteTrainer.Name = "btnDeleteTrainer"
        btnDeleteTrainer.Size = New Size(150, 45)
        btnDeleteTrainer.TabIndex = 2
        btnDeleteTrainer.Text = "Delete Trainer"
        btnDeleteTrainer.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 125)
        Label1.TabIndex = 3
        Label1.Text = "KS FITNESS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TrainerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        ClientSize = New Size(1200, 750)
        Controls.Add(btnShowAllTrainers)
        Controls.Add(pnlActions)
        Controls.Add(txtSearchTrainer)
        Controls.Add(btnSearchTrainer)
        Controls.Add(dgvTrainers)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSearch)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "TrainerForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Trainer Management"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(dgvTrainers, ComponentModel.ISupportInitialize).EndInit()
        pnlActions.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnShowAllTrainers As Button
    Friend WithEvents Label1 As Label
End Class