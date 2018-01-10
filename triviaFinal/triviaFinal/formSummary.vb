Public Class formSummary

    Friend Sub displayInfo()
        'Regular font is safe here, as the left "headers" are fixed so we can control the tabbing.
        txtSummary.Text = "Summary for" & formTitle.Result.PlayerName & vbCrLf &
                          "Questions Correct" & vbTab & formTitle.Result.NumCorrect &
                          "Questions Answered" & vbTab & formTitle.Result.NumGuessed &
                          "Percentage Correct" & vbTab & formTitle.Result.Percentage() & vbCrLf &
                          "Final Score" & vbTab & vbTab & formTitle.Result.Score

    End Sub

End Class