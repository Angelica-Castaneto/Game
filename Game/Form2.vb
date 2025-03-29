Imports System.Windows

Public Class Form2
    ' Initialize the score variable
    Private score As Integer = 0



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton3.Checked Then
            MessageBox.Show("Correct!")
            ' Update the score for correct answer
            score += 1
        Else
            MessageBox.Show("Incorrect!")
            MessageBox.Show("CORRECT ANSWER: Shakespeare")
        End If

        ' Pass the score to Form3
        Dim form3 As New Form3()
        form3.UpdateScore(score)

        Me.Hide()
        form3.Show()
    End Sub


End Class