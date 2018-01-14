Public Class formSummary

    Private highScoresSingle As New List(Of SingleHighScoreEntry)

    'Temporary variables to store each entry/output value
    Dim playerName As String
    Dim score As Integer

    Friend Sub displayInfo(ByVal result As SingleResult)
        'Display the summary and update the high scores if appropriate.

        'Regular font is safe here, as the left "headers" are fixed so we can control the tabbing.
        txtSummary.Text = "Summary for " & result.PlayerName & vbCrLf & vbCrLf
        txtSummary.AppendText("Question" & vbTab & vbTab & "Score" & vbCrLf)

        For i As Integer = 1 To result.Scores.Count
            txtSummary.AppendText(i & vbTab & vbTab & result.Scores(i - 1) & vbCrLf)
        Next

        txtSummary.AppendText(vbCrLf)
        txtSummary.AppendText("Questions Correct" & vbTab & vbTab & result.NumCorrect() & vbCrLf &
                              "Questions Answered" & vbTab & result.NumGuessed() & vbCrLf &
                              "Percentage Correct" & vbTab & FormatPercent(result.Percentage()) & vbCrLf &
                              "Final Score" & vbTab & vbTab & result.Scores.Sum())

        'Get the high scores
        Dim highScoresInFile As New IO.StreamReader("High Scores/Single.txt")
        Do While Not highScoresInFile.EndOfStream()
            playerName = highScoresInFile.ReadLine()
            score = highScoresInFile.ReadLine()
            highScoresSingle.Add(New SingleHighScoreEntry(playerName, score))
        Loop
        highScoresInFile.Close()

        'Update the score only if the score is in the top highScoreEntries (variable).
        If result.Total > highScoresSingle.Last.Score Then  'Assume the highScores data file is always sorted
            highScoresSingle.Add(New SingleHighScoreEntry(result.PlayerName, result.Total))
            highScoresSingle.Sort(AddressOf compareEntriesByPoints)
            updateScores(highScoreEntries)
            MsgBox("You made the hall of fame!")
        Else
            MsgBox("Aww... So close to making the hall of fame.")
        End If

    End Sub

    Friend Sub displayInfo(ByVal result As MultiResult)
        'TODO: implement the display of the results for MultiResult
    End Sub

    Private Function compareEntriesByPoints(ByVal entry1 As SingleHighScoreEntry, ByVal entry2 As SingleHighScoreEntry)
        'Comparison function: larger number of points goes higher

        'OPTIMIZE: no need to compare EVERY pair if the read-in data is already sorted

        Dim score1 As Integer = entry1.Score
        Dim score2 As Integer = entry2.Score

        'If one is larger than the other, put the larger one first. Otherwise, if they are equal,
        'leave them unchanged (so go by order of occurrence).
        If score1 < score2 Then : Return 1
        ElseIf score1 > score2 Then : Return -1
        Else : Return 0
        End If
    End Function

    Private Sub updateScores(ByVal numEntries As Integer)
        'Updates the scores.
        Dim highScoresOutFile As New IO.StreamWriter("High Scores/Single.txt")

        'Loop to the smaller of the length or the number of entries
        For i As Integer = 0 To Math.Min(numEntries - 1, highScoresSingle.Count - 1)
            playerName = highScoresSingle(i).Name
            score = highScoresSingle(i).Score
            highScoresOutFile.WriteLine(playerName)
            highScoresOutFile.WriteLine(score)
        Next
        highScoresOutFile.Close()
    End Sub

    Private Sub formSummary_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        formTitle.Show()
    End Sub

End Class