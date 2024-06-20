Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    ' Required designer variable
    Private components As System.ComponentModel.IContainer

    ' Note: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(16, 18)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(345, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(16, 58)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(345, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(16, 98)
        txtPhone.Margin = New Padding(4, 5, 4, 5)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(345, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(16, 138)
        txtGithubLink.Margin = New Padding(4, 5, 4, 5)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(345, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(16, 178)
        txtStopwatchTime.Margin = New Padding(4, 5, 4, 5)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(345, 27)
        txtStopwatchTime.TabIndex = 4
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(16, 218)
        btnToggleStopwatch.Margin = New Padding(4, 5, 4, 5)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(100, 35)
        btnToggleStopwatch.TabIndex = 5
        btnToggleStopwatch.Text = "Toggle"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(263, 218)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(98, 35)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 477)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
End Class
