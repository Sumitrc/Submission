<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.lblSubmissionDetails = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(10, 12)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(193, 23)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.Location = New System.Drawing.Point(10, 50)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(193, 23)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "Create New Submission"
        Me.btnCreateSubmission.UseVisualStyleBackColor = True
        '
        'lblSubmissionDetails
        '
        Me.lblSubmissionDetails.AutoSize = True
        Me.lblSubmissionDetails.Location = New System.Drawing.Point(12, 89)
        Me.lblSubmissionDetails.Name = "lblSubmissionDetails"
        Me.lblSubmissionDetails.Size = New System.Drawing.Size(39, 13)
        Me.lblSubmissionDetails.TabIndex = 2
        Me.lblSubmissionDetails.Text = "Label1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSubmissionDetails)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "MainForm"
        Me.Text = "Submission App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents lblSubmissionDetails As Label
End Class
