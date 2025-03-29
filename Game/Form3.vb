Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button


Public Class Form3

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
            MessageBox.Show("CORRECT ANSWER: 6")
        End If

        ' Pass the score to Form4
        Dim form4 As New Form4()
        form4.UpdateScore(score)
        Me.Hide()
        form4.Show()
    End Sub


End Class