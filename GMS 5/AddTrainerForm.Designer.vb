<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTrainerForm
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
        Label3 = New Label()
        Label4 = New Label()
        Label = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtAddress = New TextBox()
        txtExperience = New TextBox()
        txtSpecialization = New TextBox()
        txtContactNumber = New TextBox()
        txtAvailability = New ComboBox()
        btnSaveTrainer = New Button()
        btnCancelTrainer = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(77, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 2
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(64, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 3
        Label4.Text = "Address"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(419, 66)
        Label.Name = "Label"
        Label.Size = New Size(129, 20)
        Label.TabIndex = 5
        Label.Text = "Experience (Years)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(478, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(419, 134)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 20)
        Label7.TabIndex = 7
        Label7.Text = "Specialization"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(425, 196)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 20)
        Label8.TabIndex = 8
        Label8.Text = "Contact No"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(177, 66)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 10
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(177, 134)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 11
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(177, 196)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(125, 27)
        txtAddress.TabIndex = 12
        ' 
        ' txtExperience
        ' 
        txtExperience.Location = New Point(562, 59)
        txtExperience.Name = "txtExperience"
        txtExperience.Size = New Size(125, 27)
        txtExperience.TabIndex = 13
        ' 
        ' txtSpecialization
        ' 
        txtSpecialization.Location = New Point(562, 127)
        txtSpecialization.Name = "txtSpecialization"
        txtSpecialization.Size = New Size(125, 27)
        txtSpecialization.TabIndex = 14
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(562, 189)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(125, 27)
        txtContactNumber.TabIndex = 15
        ' 
        ' txtAvailability
        ' 
        txtAvailability.FormattingEnabled = True
        txtAvailability.Items.AddRange(New Object() {"Morning(6:00 AM TO 10:00 AM)", "Evening(4:00 PM to 10:00 PM)"})
        txtAvailability.Location = New Point(177, 268)
        txtAvailability.Name = "txtAvailability"
        txtAvailability.Size = New Size(151, 28)
        txtAvailability.TabIndex = 16
        ' 
        ' btnSaveTrainer
        ' 
        btnSaveTrainer.Location = New Point(234, 371)
        btnSaveTrainer.Name = "btnSaveTrainer"
        btnSaveTrainer.Size = New Size(94, 29)
        btnSaveTrainer.TabIndex = 17
        btnSaveTrainer.Text = "Save"
        btnSaveTrainer.UseVisualStyleBackColor = True
        ' 
        ' btnCancelTrainer
        ' 
        btnCancelTrainer.Location = New Point(419, 371)
        btnCancelTrainer.Name = "btnCancelTrainer"
        btnCancelTrainer.Size = New Size(94, 29)
        btnCancelTrainer.TabIndex = 18
        btnCancelTrainer.Text = "Cancel"
        btnCancelTrainer.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(64, 271)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 19
        Label6.Text = "Availability"
        ' 
        ' AddTrainerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(btnCancelTrainer)
        Controls.Add(btnSaveTrainer)
        Controls.Add(txtAvailability)
        Controls.Add(txtContactNumber)
        Controls.Add(txtSpecialization)
        Controls.Add(txtExperience)
        Controls.Add(txtAddress)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "AddTrainerForm"
        Text = "AddTrainerForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtExperience As TextBox
    Friend WithEvents txtSpecialization As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtAvailability As ComboBox
    Friend WithEvents btnSaveTrainer As Button
    Friend WithEvents btnCancelTrainer As Button
    Friend WithEvents Label6 As Label
End Class
