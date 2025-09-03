<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MembershipDetailsForm
    Inherits System.Windows.Forms.Form

    Friend WithEvents dgvMembershipDetails As DataGridView

    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvMembershipDetails = New DataGridView()
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(dgvMembershipDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvMembershipDetails
        ' 
        dgvMembershipDetails.AllowUserToAddRows = False
        dgvMembershipDetails.AllowUserToDeleteRows = False
        dgvMembershipDetails.AllowUserToResizeRows = False
        dgvMembershipDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembershipDetails.BackgroundColor = Color.FromArgb(CByte(45), CByte(66), CByte(91))
        dgvMembershipDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.LightGray
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DataGridViewCellStyle3.SelectionForeColor = Color.LightGray
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvMembershipDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvMembershipDetails.ColumnHeadersHeight = 30
        dgvMembershipDetails.EnableHeadersVisualStyles = False
        dgvMembershipDetails.GridColor = Color.DimGray
        dgvMembershipDetails.Location = New Point(9, 40)
        dgvMembershipDetails.Margin = New Padding(4, 5, 4, 5)
        dgvMembershipDetails.Name = "dgvMembershipDetails"
        dgvMembershipDetails.ReadOnly = True
        dgvMembershipDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.LightGray
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvMembershipDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvMembershipDetails.RowHeadersVisible = False
        dgvMembershipDetails.RowHeadersWidth = 51
        dgvMembershipDetails.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(45), CByte(66), CByte(91))
        dgvMembershipDetails.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        dgvMembershipDetails.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue
        dgvMembershipDetails.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White
        dgvMembershipDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembershipDetails.Size = New Size(909, 500)
        dgvMembershipDetails.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnBack.FlatAppearance.BorderColor = Color.DimGray
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.LightGray
        btnBack.Location = New Point(820, 14)
        btnBack.Margin = New Padding(4, 5, 4, 5)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(98, 30)
        btnBack.TabIndex = 1
        btnBack.Text = "<Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(329, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 31)
        Label1.TabIndex = 2
        Label1.Text = "MEMBERSHIP DETAILS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(29, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 31)
        Label2.TabIndex = 3
        Label2.Text = "KS FITNESS"
        ' 
        ' MembershipDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        ClientSize = New Size(931, 580)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(dgvMembershipDetails)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MembershipDetailsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Membership Details"
        CType(dgvMembershipDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

        ' Columns (will be added dynamically)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class