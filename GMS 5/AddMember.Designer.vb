<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMember))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        txtFirstName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        txtLastName = New TextBox()
        cmbGender = New ComboBox()
        dtpDOB = New DateTimePicker()
        txtWeight = New TextBox()
        Label5 = New Label()
        dtpJoin_date = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 0
        Label1.Text = "First Name "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 2
        Label3.Text = "Phone No"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 3
        Label4.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(423, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 5
        Label6.Text = "Last Name "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(437, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 20)
        Label7.TabIndex = 6
        Label7.Text = "Gender"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(445, 166)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 20)
        Label8.TabIndex = 7
        Label8.Text = "DOB"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(438, 227)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 20)
        Label9.TabIndex = 8
        Label9.Text = "Weight"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(223, 366)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(391, 366)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 32)
        btnCancel.TabIndex = 11
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(146, 53)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(125, 27)
        txtFirstName.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(146, 106)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 13
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(146, 159)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 14
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(146, 220)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(159, 27)
        txtAddress.TabIndex = 15
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(556, 46)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(125, 27)
        txtLastName.TabIndex = 16
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male ", "Female"})
        cmbGender.Location = New Point(556, 103)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(125, 28)
        cmbGender.TabIndex = 17
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Location = New Point(556, 157)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(199, 27)
        dtpDOB.TabIndex = 18
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(556, 220)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(125, 27)
        txtWeight.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 20)
        Label5.TabIndex = 20
        Label5.Text = "Join Date"
        ' 
        ' dtpJoin_date
        ' 
        dtpJoin_date.Location = New Point(146, 273)
        dtpJoin_date.Name = "dtpJoin_date"
        dtpJoin_date.Size = New Size(250, 27)
        dtpJoin_date.TabIndex = 21
        ' 
        ' AddMember
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(dtpJoin_date)
        Controls.Add(Label5)
        Controls.Add(txtWeight)
        Controls.Add(dtpDOB)
        Controls.Add(cmbGender)
        Controls.Add(txtLastName)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtFirstName)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddMember"
        Text = "AddMemberForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpJoin_date As DateTimePicker
End Class
