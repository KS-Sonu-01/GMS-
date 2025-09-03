<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTrainer
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
        Label2 = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        txtAvailability = New ComboBox()
        txtAddress = New TextBox()
        Label4 = New Label()
        txtContactNumber = New TextBox()
        txtSpecialization = New TextBox()
        txtExperience = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label = New Label()
        btnCancel = New Button()
        btnUpdate = New Button()
        Label1 = New Label()
        txtTrainerID = New TextBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(88, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(191, 136)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 11
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(191, 193)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(91, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 12
        Label3.Text = "Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(437, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 23
        Label6.Text = "Availability"
        ' 
        ' txtAvailability
        ' 
        txtAvailability.FormattingEnabled = True
        txtAvailability.Items.AddRange(New Object() {"Morning(6:00 AM TO 10:00 AM)", "Evening(4:00 PM to 10:00 PM)"})
        txtAvailability.Location = New Point(550, 262)
        txtAvailability.Name = "txtAvailability"
        txtAvailability.Size = New Size(151, 28)
        txtAvailability.TabIndex = 22
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(191, 252)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(125, 27)
        txtAddress.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(78, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 20
        Label4.Text = "Address"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(561, 202)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(125, 27)
        txtContactNumber.TabIndex = 29
        ' 
        ' txtSpecialization
        ' 
        txtSpecialization.Location = New Point(561, 140)
        txtSpecialization.Name = "txtSpecialization"
        txtSpecialization.Size = New Size(125, 27)
        txtSpecialization.TabIndex = 28
        ' 
        ' txtExperience
        ' 
        txtExperience.Location = New Point(561, 72)
        txtExperience.Name = "txtExperience"
        txtExperience.Size = New Size(125, 27)
        txtExperience.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(424, 209)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 20)
        Label8.TabIndex = 26
        Label8.Text = "Contact No"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(418, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 20)
        Label7.TabIndex = 25
        Label7.Text = "Specialization"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(418, 79)
        Label.Name = "Label"
        Label.Size = New Size(81, 20)
        Label.TabIndex = 24
        Label.Text = "Experience"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(427, 359)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 31
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(242, 359)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 30
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 32
        Label1.Text = "Trainer Id"
        ' 
        ' txtTrainerID
        ' 
        txtTrainerID.Location = New Point(191, 76)
        txtTrainerID.Name = "txtTrainerID"
        txtTrainerID.Size = New Size(125, 27)
        txtTrainerID.TabIndex = 33
        ' 
        ' UpdateTrainer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtTrainerID)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(txtContactNumber)
        Controls.Add(txtSpecialization)
        Controls.Add(txtExperience)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label)
        Controls.Add(Label6)
        Controls.Add(txtAvailability)
        Controls.Add(txtAddress)
        Controls.Add(Label4)
        Controls.Add(txtAge)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Name = "UpdateTrainer"
        Text = "UpdateTrainer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAvailability As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtSpecialization As TextBox
    Friend WithEvents txtExperience As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTrainerID As TextBox
End Class
