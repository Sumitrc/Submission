<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnStartPause = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(10, 50)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.Text = "Email"
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(10, 130)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(100, 20)
        Me.txtGithub.TabIndex = 1
        Me.txtGithub.Text = "Github Link"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(10, 90)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 2
        Me.txtPhone.Text = "Phone Number"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(10, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = "Name"
        '
        'btnStartPause
        '
        Me.btnStartPause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStartPause.Location = New System.Drawing.Point(10, 170)
        Me.btnStartPause.Name = "btnStartPause"
        Me.btnStartPause.Size = New System.Drawing.Size(75, 23)
        Me.btnStartPause.TabIndex = 4
        Me.btnStartPause.Text = "Start"
        Me.btnStartPause.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(10, 210)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(120, 170)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(49, 13)
        Me.lblStopwatch.TabIndex = 6
        Me.lblStopwatch.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'NewSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStartPause)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "NewSubmissionForm"
        Me.Text = "NewSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnStartPause As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents Timer1 As Timer
End Class
