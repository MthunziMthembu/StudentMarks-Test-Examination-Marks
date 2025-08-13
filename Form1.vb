Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        'Declare variables
        Dim learnername As String
        Dim testmark, assignmentmark, average As Double
        'Get information from textboxes
        learnername = txtName.Text
        testmark = txtTest.Text
        assignmentmark = txtAssignment.Text

        'Formula for average
        average = (testmark + assignmentmark) / 2
        'If condition and print result
        If average > 50 Then
            MessageBox.Show("Hello" & learnername & ",You qualify for an excursion")
        Else
            MessageBox.Show("Hello " & learnername & ",You do not qualify for an excursion")
        End If

    End Sub
End Class
