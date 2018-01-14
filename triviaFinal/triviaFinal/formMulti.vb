Public Class formMulti

    '=====================Copied from formSingle=====================

    Private unplayed As List(Of Integer)  'stores which questions were not yet played

    'Data about the players for this round
    Private scores As Dictionary(Of String, Integer)
    Private player1 As String  'name of first player
    Private player2 As String  'name of second player

    'Data for a given question
    Private question As Question  'stores a question
    Private correct As Boolean  'if this question was answered correctly

    Private Sub formMulti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()

        KeyPreview = False
        initKeysPicBoxes()

        player1 = InputBox("Enter name of player 1.", "Name")
        player2 = InputBox("Enter name of player 2.", "Name")

        MsgBox(String.Format("{0} will be on the left, and {1} will be on the right.", player1, player2))

        'Initialize the unplayed list for a new match
        unplayed = range(0, triviaFinal.Question.NumQuestions)

        scores = New Dictionary(Of String, Integer)
        scores.Add("Left", 0)
        scores.Add("Right", 0)
        updateScores()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        nextQuestion()
    End Sub

    Private Sub initKeysPicBoxes()
        'Initializes the PictureBox objects of the form to display
        'which keys correspond to which player and which option.

        For Each player As String In keysDict.Keys
            For c As Integer = 0 To keysDict(player).Count - 1
                Dim picBox As New PictureBox
                picBox = Controls(String.Format("pic{0}Key{1}", player, c))
                displayKey(keysDict(player)(c), picBox)
            Next
        Next
    End Sub

    Private Sub nextQuestion()
        Dim currentQuestion As Integer

        'Choose a random question and remove it.
        currentQuestion = unplayed(randInt(0, unplayed.Count - 1))
        unplayed.Remove(currentQuestion)
        question = New Question(currentQuestion)

        'First, perform the countdown.
        Me.Hide()
        performCountdown(3)

        'Then, load the question (after performCountdown
        'automatically redisplays this form to the user)
        loadQuestion(question, lblQuestion, lblOption0, lblOption1, lblOption2, lblOption3)
        KeyPreview = True
    End Sub

    Private Sub formMulti_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'Do nothing if the entry is invalid.
        If IsNothing(selectionPlayer(e.KeyChar)) Then
            Exit Sub
        End If

        'Otherwise, the selection does indeed correspond to a selection
        'of a player, so no more input is allowed.
        KeyPreview = False

        'Get the name of the player who answered.
        Dim answeredPlayer As String
        answeredPlayer = If(selectionPlayer(e.KeyChar) = "Left", player1, player2)

        'Check if the answer is correct and display the corresponding message to the user.
        If selectionOption(e.KeyChar) = question.Correct Then
            MsgBox(String.Format("{0} {1} gains 1 point. The correct answer was {2}.",
                                 randPrompt("Correct"), answeredPlayer, question.CorrectAnswer))

            'Increment the score if it is correct.
            scores(selectionPlayer(e.KeyChar)) += 1
        Else
            MsgBox(String.Format("{0} {1} loses 1 point. The correct answer was {2}.",
                                 randPrompt("Incorrect"), answeredPlayer, question.CorrectAnswer))

            'Otherwise, the answer was incorrect, so decrement the score.
            scores(selectionPlayer(e.KeyChar)) -= 1
        End If

        updateScores()

        If Math.Max(scores.Values(0), scores.Values(1)) = 10 Then  'hard-coded first to 10 wins
            'redirect the user
        Else : nextQuestion()
        End If

    End Sub

    Private Sub updateScores()
        'Updates the scores to the user (through the labels).
        lblLeftScore.Text = player1 & ": " & scores("Left")
        lblRightScore.Text = player2 & ": " & scores("Right")
    End Sub

    Private Sub performCountdown(ByVal seconds As Integer)
        formCountdown.Show()
        formCountdown.countdownFrom(seconds)
    End Sub

End Class