Public Class Form24

    ' Initialize the score variable
    Private score As Integer

    ' Method to update the score
    Public Sub UpdateScore(newScore As Integer)
        score = newScore
        MessageBox.Show("Your score is: " & score)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            MessageBox.Show("Correct!")
            ' Update the score for correct answer
            score += 1
        Else
            MessageBox.Show("Incorrect!")
            MessageBox.Show("CORRECT ANSWER: Denmark")
        End If

        ' Pass the score to Form4
        Dim form25 As New Form25()
        form25.UpdateScore(score)
        Me.Hide()
        Form25.Show()
    End Sub


End Class