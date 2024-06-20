Imports Newtonsoft.Json
Imports System.Net.Http

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission) ' Assuming Submission is a class or structure to hold submission data
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        Me.KeyPreview = True ' Set KeyPreview to True to handle keyboard shortcuts
    End Sub

    Private Async Sub LoadSubmissions()
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync("http://localhost:3000/read?index=-1") ' Assuming -1 fetches all submissions
                response.EnsureSuccessStatusCode()
                Dim json = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                ShowCurrentSubmission()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowCurrentSubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim currentSubmission = submissions(currentIndex)
            lblSubmissionDetails.Text = $"Name: {currentSubmission.Name}{Environment.NewLine}" &
                                        $"Email: {currentSubmission.Email}{Environment.NewLine}" &
                                        $"Phone: {currentSubmission.Phone}{Environment.NewLine}" &
                                        $"GitHub: {currentSubmission.GitHubLink}{Environment.NewLine}"
        Else
            lblSubmissionDetails.Text = "No submissions found."
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowCurrentSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowCurrentSubmission()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.Left Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.Right Then
            btnNext.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
End Class
