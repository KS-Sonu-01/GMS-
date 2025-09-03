<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MembershipForm
    Inherits System.Windows.Forms.Form

    ' Existing controls
    Friend WithEvents cmbMembers As ComboBox
    Friend WithEvents cmbMembershipType As ComboBox
    Friend WithEvents txtFee As TextBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents cmbPaymentStatus As ComboBox
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents cmbFitnessGoal As ComboBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents pbQRCode As PictureBox

    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents dtpExpiryDate As DateTimePicker



    ' New Save button (replaces Process Payment and Save buttons)
    Friend WithEvents btnSave As Button

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MembershipForm))
        cmbMembers = New ComboBox()
        cmbMembershipType = New ComboBox()
        txtFee = New TextBox()
        dtpStartDate = New DateTimePicker()
        cmbPaymentStatus = New ComboBox()
        cmbPaymentMode = New ComboBox()
        cmbFitnessGoal = New ComboBox()
        lblCardNumber = New Label()
        txtCardNumber = New TextBox()
        lblCVV = New Label()
        txtCVV = New TextBox()
        pbQRCode = New PictureBox()
        lblExpiryDate = New Label()
        dtpExpiryDate = New DateTimePicker()
        btnSave = New Button()
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(pbQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbMembers
        ' 
        cmbMembers.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMembers.FormattingEnabled = True
        cmbMembers.Location = New Point(167, 56)
        cmbMembers.Name = "cmbMembers"
        cmbMembers.Size = New Size(332, 28)
        cmbMembers.TabIndex = 0
        ' 
        ' cmbMembershipType
        ' 
        cmbMembershipType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMembershipType.FormattingEnabled = True
        cmbMembershipType.Location = New Point(167, 148)
        cmbMembershipType.Name = "cmbMembershipType"
        cmbMembershipType.Size = New Size(160, 28)
        cmbMembershipType.TabIndex = 1
        ' 
        ' txtFee
        ' 
        txtFee.Location = New Point(167, 195)
        txtFee.Name = "txtFee"
        txtFee.ReadOnly = True
        txtFee.Size = New Size(132, 27)
        txtFee.TabIndex = 2
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(167, 242)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(132, 27)
        dtpStartDate.TabIndex = 3
        ' 
        ' cmbPaymentStatus
        ' 
        cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentStatus.FormattingEnabled = True
        cmbPaymentStatus.Items.AddRange(New Object() {"Paid", "Pending"})
        cmbPaymentStatus.Location = New Point(167, 287)
        cmbPaymentStatus.Name = "cmbPaymentStatus"
        cmbPaymentStatus.Size = New Size(160, 28)
        cmbPaymentStatus.TabIndex = 4
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"Cash", "Credit Card", "UPI"})
        cmbPaymentMode.Location = New Point(167, 327)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(160, 28)
        cmbPaymentMode.TabIndex = 5
        ' 
        ' cmbFitnessGoal
        ' 
        cmbFitnessGoal.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFitnessGoal.FormattingEnabled = True
        cmbFitnessGoal.Location = New Point(167, 103)
        cmbFitnessGoal.Name = "cmbFitnessGoal"
        cmbFitnessGoal.Size = New Size(332, 28)
        cmbFitnessGoal.TabIndex = 6
        ' 
        ' lblCardNumber
        ' 
        lblCardNumber.AutoSize = True
        lblCardNumber.Location = New Point(16, 384)
        lblCardNumber.Name = "lblCardNumber"
        lblCardNumber.Size = New Size(101, 20)
        lblCardNumber.TabIndex = 8
        lblCardNumber.Text = "Card Number:"
        lblCardNumber.Visible = False
        ' 
        ' txtCardNumber
        ' 
        txtCardNumber.Location = New Point(167, 380)
        txtCardNumber.MaxLength = 16
        txtCardNumber.Name = "txtCardNumber"
        txtCardNumber.Size = New Size(199, 27)
        txtCardNumber.TabIndex = 9
        txtCardNumber.Visible = False
        ' 
        ' lblCVV
        ' 
        lblCVV.AutoSize = True
        lblCVV.Location = New Point(16, 430)
        lblCVV.Name = "lblCVV"
        lblCVV.Size = New Size(39, 20)
        lblCVV.TabIndex = 10
        lblCVV.Text = "CVV:"
        lblCVV.Visible = False
        ' 
        ' txtCVV
        ' 
        txtCVV.Location = New Point(167, 426)
        txtCVV.MaxLength = 3
        txtCVV.Name = "txtCVV"
        txtCVV.Size = New Size(65, 27)
        txtCVV.TabIndex = 11
        txtCVV.Visible = False
        ' 
        ' pbQRCode
        ' 
        pbQRCode.Image = CType(resources.GetObject("pbQRCode.Image"), Image)
        pbQRCode.Location = New Point(207, 380)
        pbQRCode.Name = "pbQRCode"
        pbQRCode.Size = New Size(200, 197)
        pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage
        pbQRCode.TabIndex = 14
        pbQRCode.TabStop = False
        pbQRCode.Visible = False
        ' 
        ' lblExpiryDate
        ' 
        lblExpiryDate.AutoSize = True
        lblExpiryDate.Location = New Point(16, 476)
        lblExpiryDate.Name = "lblExpiryDate"
        lblExpiryDate.Size = New Size(88, 20)
        lblExpiryDate.TabIndex = 15
        lblExpiryDate.Text = "Expiry Date:"
        lblExpiryDate.Visible = False
        ' 
        ' dtpExpiryDate
        ' 
        dtpExpiryDate.CustomFormat = "MM/yyyy"
        dtpExpiryDate.Format = DateTimePickerFormat.Custom
        dtpExpiryDate.Location = New Point(167, 472)
        dtpExpiryDate.Name = "dtpExpiryDate"
        dtpExpiryDate.Size = New Size(100, 27)
        dtpExpiryDate.TabIndex = 16
        dtpExpiryDate.Visible = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Black
        btnSave.Location = New Point(233, 587)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(133, 46)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ControlText
        btnBack.ForeColor = Color.BlanchedAlmond
        btnBack.Location = New Point(634, 8)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 38)
        btnBack.TabIndex = 17
        btnBack.Text = "<Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 20)
        Label1.TabIndex = 18
        Label1.Text = "Member"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 19
        Label2.Text = "Fitness Goal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 20
        Label3.Text = "Duration "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 20)
        Label4.TabIndex = 21
        Label4.Text = "Fees"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 22
        Label5.Text = "Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(29, 295)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 23
        Label6.Text = "Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(29, 335)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 20)
        Label7.TabIndex = 24
        Label7.Text = "Payment Mode"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(2, 8)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 31)
        Label8.TabIndex = 25
        Label8.Text = "KS FITNESS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(233, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(236, 31)
        Label9.TabIndex = 26
        Label9.Text = "MEMBERSHIP FORM"
        ' 
        ' MembershipForm
        ' 
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        CancelButton = btnBack
        ClientSize = New Size(731, 645)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(cmbMembers)
        Controls.Add(cmbMembershipType)
        Controls.Add(txtFee)
        Controls.Add(dtpStartDate)
        Controls.Add(cmbPaymentStatus)
        Controls.Add(cmbPaymentMode)
        Controls.Add(cmbFitnessGoal)
        Controls.Add(lblCardNumber)
        Controls.Add(txtCardNumber)
        Controls.Add(lblCVV)
        Controls.Add(txtCVV)
        Controls.Add(pbQRCode)
        Controls.Add(lblExpiryDate)
        Controls.Add(dtpExpiryDate)
        Controls.Add(btnSave)
        ForeColor = SystemColors.ButtonHighlight
        Name = "MembershipForm"
        Text = " "
        CType(pbQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class