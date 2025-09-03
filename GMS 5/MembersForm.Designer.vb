<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MembersForm
    Inherits System.Windows.Forms.Form

    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnShowAll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBack As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        btnBack = New Button()
        dgvMembers = New DataGridView()
        Panel2 = New Panel()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnShowAll = New Button()
        Panel3 = New Panel()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        lblTitle = New Label()
        Panel1.SuspendLayout()
        CType(dgvMembers, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnBack)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(250, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(950, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(80, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 37)
        Label1.TabIndex = 0
        Label1.Text = "Member Management"
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
        ' dgvMembers
        ' 
        dgvMembers.AllowUserToAddRows = False
        dgvMembers.AllowUserToDeleteRows = False
        dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembers.BackgroundColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        dgvMembers.BorderStyle = BorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvMembers.DefaultCellStyle = DataGridViewCellStyle4
        dgvMembers.Dock = DockStyle.Fill
        dgvMembers.EnableHeadersVisualStyles = False
        dgvMembers.GridColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        dgvMembers.Location = New Point(20, 20)
        dgvMembers.Name = "dgvMembers"
        dgvMembers.RowHeadersWidth = 51
        dgvMembers.Size = New Size(910, 630)
        dgvMembers.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        Panel2.Controls.Add(dgvMembers)
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(btnShowAll)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(250, 80)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20)
        Panel2.Size = New Size(950, 670)
        Panel2.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.WhiteSmoke
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtSearch.Location = New Point(20, 20)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by name..."
        txtSearch.Size = New Size(400, 30)
        txtSearch.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(430, 20)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 30)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnShowAll
        ' 
        btnShowAll.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnShowAll.FlatAppearance.BorderSize = 0
        btnShowAll.FlatStyle = FlatStyle.Flat
        btnShowAll.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnShowAll.ForeColor = Color.White
        btnShowAll.Location = New Point(540, 20)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(120, 30)
        btnShowAll.TabIndex = 3
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Panel3.Controls.Add(lblTitle)
        Panel3.Controls.Add(btnAdd)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnDelete)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 750)
        Panel3.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(50, 159)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 45)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add Member"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(50, 263)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(150, 45)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update Member"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(51), CByte(122), CByte(183))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(50, 368)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(150, 45)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete Member"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(250, 125)
        lblTitle.TabIndex = 3
        lblTitle.Text = "KS FITNESS"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MembersForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        ClientSize = New Size(1200, 750)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "MembersForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Member Management"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvMembers, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
End Class