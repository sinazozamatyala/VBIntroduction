<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnClose = New Button()
        btnWelcome = New Button()
        lblProfession = New Label()
        lblSurname = New Label()
        lblName = New Label()
        lblAge = New Label()
        lblGender = New Label()
        txtAge = New TextBox()
        txtSurname = New TextBox()
        txtName = New TextBox()
        ComboBox1 = New ComboBox()
        RadioButtonFemale = New RadioButton()
        RadioButtonOther = New RadioButton()
        RadioButtonMale = New RadioButton()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(721, 481)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(144, 62)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnWelcome
        ' 
        btnWelcome.Location = New Point(360, 481)
        btnWelcome.Name = "btnWelcome"
        btnWelcome.Size = New Size(262, 62)
        btnWelcome.TabIndex = 1
        btnWelcome.Text = "Welcome Button"
        btnWelcome.UseVisualStyleBackColor = True
        ' 
        ' lblProfession
        ' 
        lblProfession.AutoSize = True
        lblProfession.Location = New Point(252, 192)
        lblProfession.Name = "lblProfession"
        lblProfession.Size = New Size(77, 20)
        lblProfession.TabIndex = 3
        lblProfession.Text = "Profession"
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(252, 107)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(67, 20)
        lblSurname.TabIndex = 5
        lblSurname.Text = "Surname"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(252, 69)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 7
        lblName.Text = "Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(252, 148)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(36, 20)
        lblAge.TabIndex = 9
        lblAge.Text = "Age"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(252, 357)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(57, 20)
        lblGender.TabIndex = 10
        lblGender.Text = "Gender"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(372, 148)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(100, 27)
        txtAge.TabIndex = 14
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(372, 107)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(230, 27)
        txtSurname.TabIndex = 15
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(372, 62)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 27)
        txtName.TabIndex = 17
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Accountant", "Doctor", "Lecturer", "Nurse", "Police"})
        ComboBox1.Location = New Point(372, 201)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' RadioButtonFemale
        ' 
        RadioButtonFemale.AutoSize = True
        RadioButtonFemale.Location = New Point(351, 377)
        RadioButtonFemale.Name = "RadioButtonFemale"
        RadioButtonFemale.Size = New Size(78, 24)
        RadioButtonFemale.TabIndex = 20
        RadioButtonFemale.TabStop = True
        RadioButtonFemale.Text = "Female"
        RadioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonOther
        ' 
        RadioButtonOther.AutoSize = True
        RadioButtonOther.Location = New Point(351, 407)
        RadioButtonOther.Name = "RadioButtonOther"
        RadioButtonOther.Size = New Size(67, 24)
        RadioButtonOther.TabIndex = 22
        RadioButtonOther.TabStop = True
        RadioButtonOther.Text = "Other"
        RadioButtonOther.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonMale
        ' 
        RadioButtonMale.AutoSize = True
        RadioButtonMale.Location = New Point(351, 341)
        RadioButtonMale.Name = "RadioButtonMale"
        RadioButtonMale.Size = New Size(63, 24)
        RadioButtonMale.TabIndex = 24
        RadioButtonMale.TabStop = True
        RadioButtonMale.Text = "Male"
        RadioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(360, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 23)
        Label1.TabIndex = 25
        Label1.Text = "Welcome to the Mindworx LMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1126, 589)
        Controls.Add(Label1)
        Controls.Add(RadioButtonMale)
        Controls.Add(RadioButtonOther)
        Controls.Add(RadioButtonFemale)
        Controls.Add(ComboBox1)
        Controls.Add(txtName)
        Controls.Add(txtSurname)
        Controls.Add(txtAge)
        Controls.Add(lblGender)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Controls.Add(lblSurname)
        Controls.Add(lblProfession)
        Controls.Add(btnWelcome)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Sign Up to LMS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnWelcome As Button
    Friend WithEvents lblProfession As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonOther As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents Label1 As Label

End Class
