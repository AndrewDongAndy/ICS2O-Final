Public Class formTitle

    Public Result As SingleResult

    Private Sub formTitle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Result = lastGame()
    End Sub

    Private Sub btnSingle_Click(sender As System.Object, e As System.EventArgs) Handles btnSingle.Click
        formSingle.Show()
    End Sub

    Private Sub btnMulti_Click(sender As System.Object, e As System.EventArgs) Handles btnMulti.Click
        formMulti.Show()
    End Sub

    Private Sub btnInstructions_Click(sender As System.Object, e As System.EventArgs) Handles btnInstructions.Click
        formInstructions.Show()
    End Sub

    Private Sub btnHighScores_Click(sender As System.Object, e As System.EventArgs) Handles btnHighScores.Click
        formHighScores.Show()
    End Sub

    Private Function lastGame() As SingleResult
        'Returns the result from the last save file called "lastSingleGame.txt".

        Dim f As IO.StreamReader
        f = New IO.StreamReader("lastSingleGame.txt")

        Dim PlayerName As String = f.ReadLine()
        Dim NumCorrect As Integer = f.ReadLine()
        Dim NumGuessed As Integer = f.ReadLine()
        Dim Score As Integer = f.ReadLine()

        Return New SingleResult(PlayerName, NumCorrect, NumGuessed, Score)
    End Function

End Class