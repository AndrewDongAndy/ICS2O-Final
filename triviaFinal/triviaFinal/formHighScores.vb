Public Class formHighScores

    Private numTabs As Integer = 4

    Private Sub formHighScores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        displayScores("Single")
    End Sub

    Private Sub btnSingle_Click(sender As System.Object, e As System.EventArgs) Handles btnSingle.Click
        displayScores("Single")
    End Sub

    Private Sub btnMulti_Click(sender As System.Object, e As System.EventArgs) Handles btnMulti.Click
        displayScores("Multi")
    End Sub

    Private Sub displayScores(ByVal category As String)

        'NOTE: category is only allowed to be "Single" or "Multi".

        Dim name As String
        Dim score As String
        Dim field As String
        Dim numEntries As Integer

        Dim scoresFile As New IO.StreamReader("High Scores/" & category & ".txt")

        'If the category is single player, the fields are name and score.
        'If the category is multiplayer, the fields are name and wins.
        Select Case category
            Case "Single"
                lblCategory.Text = "Single player"
                field = "Score"
            Case "Multi"
                lblCategory.Text = "Multiplayer"
                field = "Wins"
            Case Else
                Exit Sub
        End Select

        'Ensure the longest name is at most 28 characters
        txtScores.Text = "Name"
        For i As Integer = 1 To numTabs
            txtScores.AppendText(vbTab)
        Next
        txtScores.AppendText(field & vbCrLf)

        'Assume the high score file is always in sorted order, with the highest at the top.
        Do
            name = scoresFile.ReadLine()
            score = scoresFile.ReadLine()

            txtScores.AppendText(vbCrLf & name)
            'As above, hard-coded 3 tabs
            For i As Integer = 1 To numTabs - Math.Floor(name.Length / 8) 'each tab is 8 spaces
                txtScores.AppendText(vbTab)
            Next
            txtScores.AppendText(score)

            numEntries += 1
        Loop While Not scoresFile.EndOfStream() And numEntries < 10

    End Sub

End Class