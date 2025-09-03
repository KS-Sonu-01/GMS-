<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EquipmentForm
    Inherits System.Windows.Forms.Form

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dgvEquipment As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLoad As Button

    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtDescription = New TextBox()
        txtCost = New TextBox()
        cmbStatus = New ComboBox()
        dgvEquipment = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnLoad = New Button()
        lblName = New Label()
        lblDescription = New Label()
        lblCost = New Label()
        lblStatus = New Label()
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(dgvEquipment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(123, 51)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 27)
        txtName.TabIndex = 1
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(123, 91)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(200, 27)
        txtDescription.TabIndex = 3
        ' 
        ' txtCost
        ' 
        txtCost.Location = New Point(123, 131)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(200, 27)
        txtCost.TabIndex = 5
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Items.AddRange(New Object() {"Available", "Not Available"})
        cmbStatus.Location = New Point(123, 171)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(200, 28)
        cmbStatus.TabIndex = 7
        ' 
        ' dgvEquipment
        ' 
        dgvEquipment.AllowUserToAddRows = False
        dgvEquipment.BackgroundColor = SystemColors.ButtonShadow
        dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEquipment.GridColor = Color.LightBlue
        dgvEquipment.Location = New Point(20, 252)
        dgvEquipment.Name = "dgvEquipment"
        dgvEquipment.ReadOnly = True
        dgvEquipment.RowHeadersWidth = 51
        dgvEquipment.Size = New Size(750, 350)
        dgvEquipment.TabIndex = 12
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(45, 213)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 33)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add Equipment"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(184, 213)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 33)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update Equipment"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(339, 213)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 33)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete Equipment"
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(506, 213)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(75, 33)
        btnLoad.TabIndex = 11
        btnLoad.Text = "Load Equipment"
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(23, 51)
        lblName.Name = "lblName"
        lblName.Size = New Size(100, 23)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblDescription
        ' 
        lblDescription.Location = New Point(23, 91)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(100, 23)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Description:"
        ' 
        ' lblCost
        ' 
        lblCost.Location = New Point(23, 131)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(100, 23)
        lblCost.TabIndex = 4
        lblCost.Text = "Cost:"
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(23, 171)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(100, 23)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status:"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ActiveCaptionText
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(632, 213)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 33)
        btnBack.TabIndex = 13
        btnBack.Text = "<Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(-1, -3)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 31)
        Label1.TabIndex = 14
        Label1.Text = "KS FITNESS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(218, -3)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 31)
        Label2.TabIndex = 15
        Label2.Text = "EQUIPMENT MANAGEMENT"
        ' 
        ' EquipmentForm
        ' 
        BackColor = Color.Azure
        ClientSize = New Size(800, 600)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(lblName)
        Controls.Add(txtName)
        Controls.Add(lblDescription)
        Controls.Add(txtDescription)
        Controls.Add(lblCost)
        Controls.Add(txtCost)
        Controls.Add(lblStatus)
        Controls.Add(cmbStatus)
        Controls.Add(btnAdd)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnLoad)
        Controls.Add(dgvEquipment)
        ForeColor = SystemColors.InactiveCaptionText
        Name = "EquipmentForm"
        Text = "Equipment Management"
        CType(dgvEquipment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class