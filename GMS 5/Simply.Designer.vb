<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simply
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simply))
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnBack = New Button()
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
        CType(pbQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(163, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 20)
        Label7.TabIndex = 47
        Label7.Text = "Payment Mode"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(163, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 46
        Label6.Text = "Status"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(163, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 45
        Label5.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(166, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 20)
        Label4.TabIndex = 44
        Label4.Text = "Fees"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(163, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 43
        Label3.Text = "Duration "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(163, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 42
        Label2.Text = "Fitness Goal"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(163, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 20)
        Label1.TabIndex = 41
        Label1.Text = "Member"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ControlText
        btnBack.ForeColor = Color.BlanchedAlmond
        btnBack.Location = New Point(768, 21)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 38)
        btnBack.TabIndex = 40
        btnBack.Text = "<Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' cmbMembers
        ' 
        cmbMembers.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMembers.FormattingEnabled = True
        cmbMembers.Location = New Point(301, 31)
        cmbMembers.Name = "cmbMembers"
        cmbMembers.Size = New Size(332, 28)
        cmbMembers.TabIndex = 25
        ' 
        ' cmbMembershipType
        ' 
        cmbMembershipType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMembershipType.FormattingEnabled = True
        cmbMembershipType.Location = New Point(301, 123)
        cmbMembershipType.Name = "cmbMembershipType"
        cmbMembershipType.Size = New Size(160, 28)
        cmbMembershipType.TabIndex = 26
        ' 
        ' txtFee
        ' 
        txtFee.Location = New Point(301, 170)
        txtFee.Name = "txtFee"
        txtFee.ReadOnly = True
        txtFee.Size = New Size(132, 27)
        txtFee.TabIndex = 27
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(301, 217)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(132, 27)
        dtpStartDate.TabIndex = 28
        ' 
        ' cmbPaymentStatus
        ' 
        cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentStatus.FormattingEnabled = True
        cmbPaymentStatus.Items.AddRange(New Object() {"Paid", "Pending"})
        cmbPaymentStatus.Location = New Point(301, 262)
        cmbPaymentStatus.Name = "cmbPaymentStatus"
        cmbPaymentStatus.Size = New Size(160, 28)
        cmbPaymentStatus.TabIndex = 29
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"Cash", "Debit Card", "UPI"})
        cmbPaymentMode.Location = New Point(301, 302)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(160, 28)
        cmbPaymentMode.TabIndex = 30
        ' 
        ' cmbFitnessGoal
        ' 
        cmbFitnessGoal.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFitnessGoal.FormattingEnabled = True
        cmbFitnessGoal.Location = New Point(301, 78)
        cmbFitnessGoal.Name = "cmbFitnessGoal"
        cmbFitnessGoal.Size = New Size(332, 28)
        cmbFitnessGoal.TabIndex = 31
        ' 
        ' lblCardNumber
        ' 
        lblCardNumber.AutoSize = True
        lblCardNumber.Location = New Point(150, 359)
        lblCardNumber.Name = "lblCardNumber"
        lblCardNumber.Size = New Size(101, 20)
        lblCardNumber.TabIndex = 33
        lblCardNumber.Text = "Card Number:"
        lblCardNumber.Visible = False
        ' 
        ' txtCardNumber
        ' 
        txtCardNumber.Location = New Point(301, 355)
        txtCardNumber.MaxLength = 16
        txtCardNumber.Name = "txtCardNumber"
        txtCardNumber.Size = New Size(199, 27)
        txtCardNumber.TabIndex = 34
        txtCardNumber.Visible = False
        ' 
        ' lblCVV
        ' 
        lblCVV.AutoSize = True
        lblCVV.Location = New Point(150, 405)
        lblCVV.Name = "lblCVV"
        lblCVV.Size = New Size(39, 20)
        lblCVV.TabIndex = 35
        lblCVV.Text = "CVV:"
        lblCVV.Visible = False
        ' 
        ' txtCVV
        ' 
        txtCVV.Location = New Point(301, 401)
        txtCVV.MaxLength = 3
        txtCVV.Name = "txtCVV"
        txtCVV.Size = New Size(65, 27)
        txtCVV.TabIndex = 36
        txtCVV.Visible = False
        ' 
        ' pbQRCode
        ' 
        pbQRCode.Image = CType(resources.GetObject("pbQRCode.Image"), Image)
        pbQRCode.Location = New Point(342, 374)
        pbQRCode.Name = "pbQRCode"
        pbQRCode.Size = New Size(200, 197)
        pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage
        pbQRCode.TabIndex = 37
        pbQRCode.TabStop = False
        pbQRCode.Visible = False
        ' 
        ' lblExpiryDate
        ' 
        lblExpiryDate.AutoSize = True
        lblExpiryDate.Location = New Point(150, 451)
        lblExpiryDate.Name = "lblExpiryDate"
        lblExpiryDate.Size = New Size(88, 20)
        lblExpiryDate.TabIndex = 38
        lblExpiryDate.Text = "Expiry Date:"
        lblExpiryDate.Visible = False
        ' 
        ' dtpExpiryDate
        ' 
        dtpExpiryDate.CustomFormat = "MM/yyyy"
        dtpExpiryDate.Format = DateTimePickerFormat.Custom
        dtpExpiryDate.Location = New Point(301, 447)
        dtpExpiryDate.Name = "dtpExpiryDate"
        dtpExpiryDate.Size = New Size(100, 27)
        dtpExpiryDate.TabIndex = 39
        dtpExpiryDate.Visible = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Black
        btnSave.Location = New Point(367, 600)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(133, 46)
        btnSave.TabIndex = 32
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Simply
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1013, 666)
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
        Name = "Simply"
        Text = "Simply"
        CType(pbQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
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
    Friend WithEvents btnSave As Button
End Class
