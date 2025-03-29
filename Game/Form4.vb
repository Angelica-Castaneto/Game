Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button


Public Class Form4
    ' Initialize the score variable
    Private score As Integer = 0

    ' Method to update the score
    Public Sub UpdateScore(newScore As Integer)
        score = newScore
        MessageBox.Show("Your score is: " & score)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked Then
            MessageBox.Show("Correct!")
            ' Update the score for correct answer
            score += 1
        Else
            MessageBox.Show("Incorrect!")
            MessageBox.Show("CORRECT ANSWER: Japan")
        End If

        ' Pass the score to Form4
        Dim form5 As New Form5()
        form5.UpdateScore(score)
        Me.Hide()
        form5.Show()


    End Sub
End Class