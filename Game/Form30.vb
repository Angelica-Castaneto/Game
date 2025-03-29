

Public Class Form30
    ' Initialize the score variable
    Private score As Integer

    ' Method to update the score
    Public Sub UpdateScore(newScore As Integer)
        score = newScore
        MessageBox.Show("Your score is: " & score)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton4.Checked Then
            MessageBox.Show("Correct!")
            ' Update the score for correct answer
            score += 1
        Else
            MessageBox.Show("Incorrect!")
            MessageBox.Show("CORRECT ANSWER: Secure")

        End If

        ' Pass the score to Form4
        Dim form32 As New Form32()
        form32.UpdateScore(score)
        Me.Hide()
        Form32.Show()

    End Sub


End Class