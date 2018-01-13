Public Class formSummary

    Private highScores As New List(Of Tuple(Of String, Integer))

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
            highScores.Add(Tuple.Create(playerName, score))
        Loop
        highScoresInFile.Close()

        'Update the score only if the score is in the top 10 (hard-coded the number 10)
        If result.Total > highScores.Last.Item2 Then  'Assume the highScores data file is always sorted
            highScores.Add(Tuple.Create(result.PlayerName, result.Total))
            highScores.Sort(AddressOf compareEntriesByPoints)
            updateScores(10)  'NOTE: hard-coded 10 entries
            MsgBox("You made the hall of fame!")
        Else
            MsgBox("Aww... So close to making the hall of fame.")
        End If

    End Sub

    Private Function compareEntriesByPoints(ByVal entry1 As Tuple(Of String, Integer), ByVal entry2 As Tuple(Of String, Integer))
        'Comparison function: larger number of points goes higher
        Dim score1 As Integer = entry1.Item2
        Dim score2 As Integer = entry2.Item2

        'If one is larger than the other, put the larger one first. Otherwise, if they are equal,
        'leave them unchanged (so go by order of occurrence).
        If score1 < score2 Then
            Return 1
        ElseIf score1 > score2 Then
            Return -1
        Else
            Return 0
        End If
    End Function

    Private Sub updateScores(ByVal numEntries As Integer)
        'Updates the scores.
        'NOTE: hard-coded to write 10 entries
        Dim highScoresOutFile As New IO.StreamWriter("High Scores/Single.txt")

        'Loop to the smaller of the length or the number of entries
        For i As Integer = 0 To Math.Min(numEntries - 1, highScores.Count - 1)
            playerName = highScores(i).Item1
            score = highScores(i).Item2
            highScoresOutFile.WriteLine(playerName)
            highScoresOutFile.WriteLine(score)
        Next
        highScoresOutFile.Close()
    End Sub

    Private Sub formSummary_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        formTitle.Show()
    End Sub

End Class