Public Class formSingle

    Private unplayed As List(Of Integer)  'stores which questions were not yet played

    'Data about the player for this round
    Private player As SingleResult
    Private playerName As String
    Private scores As New List(Of Integer)

    'Data for a given question
    Private question As Question  'stores a question
    Private answerTime As Double  'number of seconds taken for the user to answer
    Private correct As Boolean  'if this question was answered correctly
    Private pointsForRound As Integer  'points for this question
    Private message As String  'prompt (correct/incorrect) for this question

    Private Sub formSingle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()

        'Initialize the unplayed list for a new round
        unplayed = range(0, triviaFinal.Question.NumQuestions)

        'Get the player's name
        Do While True
            playerName = InputBox("What's your name?", "Name")
            If playerName <> Nothing Then
                Exit Do
            End If
            MsgBox("Sorry, invalid name.")
        Loop

        'Initial states of the buttons
        btnStart.Enabled = True
        btnSubmit.Enabled = False
    End Sub

    Private Sub nextQuestion()
        'Play the next question.
        Dim currentQuestion As Integer

        'First, choose a random question, remove it, and load it.
        currentQuestion = unplayed(randInt(0, unplayed.Count - 1))
        unplayed.Remove(currentQuestion)
        question = New Question(currentQuestion)
        loadQuestion(question, lblQuestion, rbOption0, rbOption1, rbOption2, rbOption3)

        'Then, reset the answer time and start the timer.
        answerTime = 0
        timerAnswer.Start()
    End Sub

    Private Sub timerAnswer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAnswer.Tick
        'Every tick, update the points they would win and increase the amount
        'of time the user is taking to answer the current question.
        lblTime.Text = pointsAfterTime(answerTime)
        answerTime += timerAnswer.Interval
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        btnSubmit.Enabled = True
        nextQuestion()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        'First, stop the timer.
        timerAnswer.Stop()
        lblTime.Text = Nothing

        'Handle the option selected, if any.
        Try
            correct = (selectedButton().Name = "rbOption" & question.Correct)
            selectedButton().Checked = False
        Catch ex As NullReferenceException
            correct = False
            'Regardless of the value of autoStartRound, display
            'the following message if no option was selected.
            MsgBox("Well, at least try... next time!")
        End Try

        'Add the score for this round
        pointsForRound = If(correct, pointsAfterTime(answerTime), 0)
        addScore(pointsForRound)

        'Display the result if the option autoStartRound is off.
        If Not autoStartRound Then
            'Ternary operator!
            message = If(correct,
                         String.Format("{0} You earned {1} points.", randPrompt("Correct"), pointsForRound),
                         String.Format("{0} The correct answer was {1}.", randPrompt("Incorrect"), question.CorrectAnswer))
            MsgBox(message)
        End If

        'Handle the end of the game.
        If scores.Count = questionsPerRound Then
            'If the user has already played the set number of questions, redirect the user.
            formSummary.displayInfo(New SingleResult(playerName, scores))
            formSummary.Show()
            Me.Close()
        Else : nextQuestion()  'Otherwise, continue on with the next round.
        End If

    End Sub

    Private Sub addScore(ByVal pts As Integer)
        'Adds the score to the list and updates the score to the user in lblScore.
        scores.Add(pts)
        lblScore.Text = "Score: " & scores.Sum()
    End Sub

    Private Function selectedButton() As RadioButton
        'Returns the selected radio button from the groupOptions control collection.
        'If no options are selected, a default RadioButton object is returned.
        Return groupOptions.Controls _
               .OfType(Of RadioButton)() _
               .FirstOrDefault(Function(r) r.Checked)  'lambda/anonymous function!
    End Function

End Class