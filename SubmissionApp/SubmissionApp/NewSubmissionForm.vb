Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class NewSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero

    ' Add a Timer control to the form and set its Interval property to 1000 (1 second)
    Private WithEvents timer As New Timer With {.Interval = 1000}

    Private Sub NewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the stopwatch display
        lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
        ' Set KeyPreview to True to handle keyboard shortcuts
        Me.KeyPreview = True
    End Sub

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If stopwatchRunning Then
            ' Pause the stopwatch
            timer.Stop()
            btnStartPause.Text = "Resume"
        Else
            ' Start the stopwatch
            timer.Start()
            btnStartPause.Text = "Pause"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Increment the elapsed time by 1 second
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        ' Update the stopwatch display
        lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Handle form submission
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithub.Text
        Dim stopwatchTime As String = lblStopwatch.Text ' Get the current stopwatch time

        ' Validate and submit the data
        If Not String.IsNullOrEmpty(name) AndAlso Not String.IsNullOrEmpty(email) Then
            Dim submission = New With {
                .name = name,
                .email = email,
                .phone = phone,
                .github_link = githubLink,
                .stopwatch_time = stopwatchTime
            }
            Await SubmitData(submission)
        Else
            MessageBox.Show("Please fill in Name and Email fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Async Function SubmitData(submission As Object) As Task
        Try
            Using client As New HttpClient()
                Dim json = JsonConvert.SerializeObject(submission)
                Dim content = New StringContent(json, Encoding.UTF8, "application/json")
                Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Form submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error submitting form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ClearForm()
        ' Clear all input fields and reset the stopwatch
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()
        elapsedTime = TimeSpan.Zero
        lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
        timer.Stop()
        btnStartPause.Text = "Start"
        stopwatchRunning = False
    End Sub

    Private Sub NewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            btnStartPause.PerformClick()
        End If
    End Sub
End Class
