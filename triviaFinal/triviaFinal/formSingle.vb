﻿Public Class formSingle

    Private prompts As Dictionary(Of String, List(Of String))  'constant: prompts that can be displayed
    Private unplayed As List(Of Integer)  'stores which questions were not yet played

    'Constants: "shared" data
    Private Const maxPoints As Integer = 1000  'points given if user answered correctly "instantly"
    Private Const numQuestions As Integer = 10  'the number of questions we are allowed to choose from (randomly)
    Private Const questionsPerRound As Integer = 10  'how many questions per round
    Private Const autoStartRound As Boolean = True  'whether or not to start next round automatically

    'Data about the player for this round
    Private player As SingleResult
    Private playerName As String
    Private scores As New List(Of Integer)

    'Data for a given question
    Private question As Question  'stores a question
    Private answerTime As Double  'number of seconds taken for the user to answer
    Private correct As Boolean  'if this question was answered correctly
    Private pointsForRound As Integer  'points for this question

    Private Sub formSingle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        initPrompts()

        'Initialize the unplayed list for a new round
        unplayed = range(0, numQuestions)

        'Get the player's name
        Do While True
            playerName = InputBox("What's your name?", "Name", "Player")
            If playerName <> Nothing Then
                Exit Do
            End If
            MsgBox("Sorry, invalid name.")
        Loop

        btnStart.Enabled = True
        btnSubmit.Enabled = False
    End Sub

    Private Sub nextQuestion()
        Dim currentQuestion As Integer

        'First, choose a random question, remove it, and load it.
        currentQuestion = unplayed(randInt(0, unplayed.Count - 1))
        unplayed.Remove(currentQuestion)
        loadQuestion(currentQuestion)

        'Then, start the timer.
        answerTime = 0
        timerAnswer.Start()

        btnSubmit.Enabled = True
    End Sub

    Private Sub timerAnswer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAnswer.Tick
        lblTime.Text = pointsAfterTime(answerTime)
        answerTime += timerAnswer.Interval
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        nextQuestion()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        pointsForRound = pointsAfterTime(answerTime)

        'First, stop the timer.
        timerAnswer.Stop()
        lblTime.Text = Nothing

        'Handle the option selected, if any.
        Try
            If selectedButton().Name = "rbOption" & question.Correct Then
                correct = True
            Else
                correct = False
            End If
        Catch ex As NullReferenceException
            correct = False
            MsgBox("Well, at least try... next time!")
        End Try

        'Add the score for this round
        If correct Then
            addScore(pointsForRound)
        Else
            addScore(0)
        End If

        'Display the result if the option autoStartRound is off.
        If Not autoStartRound Then
            If correct Then
                MsgBox(randMsg("Correct"))
            Else
                MsgBox(randMsg("Incorrect"))
            End If
        End If

        'If the user has already played the max number of questions, redirect.
        If scores.Count = questionsPerRound Then
            formSummary.displayInfo(New SingleResult(playerName, scores))
            formSummary.Show()
            Me.Close()
            Exit Sub
        End If

        nextQuestion()
    End Sub

    Private Sub initPrompts()
        'Initializes the prompts dictionary by reading from the files.

        prompts = New Dictionary(Of String, List(Of String))

        Dim promptFile As IO.StreamReader  'Load the prompts dictionary by reading from two data files
        For Each promptType As String In {"Correct", "Incorrect"}
            promptFile = New IO.StreamReader("Prompts/" & promptType & ".txt")
            prompts.Add(promptType, New List(Of String))
            Do While Not promptFile.EndOfStream()
                prompts(promptType).Add(promptFile.ReadLine())
            Loop
            promptFile.Close()
        Next
    End Sub

    Private Function range(ByVal start As Integer, ByVal finish As Integer,
                           Optional ByVal skip As Integer = 1) As List(Of Integer)
        'Equivalent to list(range(start, finish, skip)) in Python.

        Dim lst As New List(Of Integer)
        For i As Integer = start To finish - 1 Step skip
            lst.Add(i)
        Next
        Return lst
    End Function

    Private Sub loadQuestion(ByVal questionID)
        'Loads a question into the proper controls.

        question = New Question(questionID)
        lblQuestion.Text = question.Question
        For i As Integer = 0 To 3
            groupOptions.Controls(i).Text = question.Options(i)
        Next
    End Sub

    Private Sub addScore(ByVal pts As Integer)
        'Adds the score to the list and updates the score to the user in lblScore.
        scores.Add(pts)
        lblScore.Text = "Score: " & scores.Sum()
    End Sub

    Private Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Return Int((max - min + 1) * Rnd()) + min
    End Function

    Private Function randMsg(ByVal type As String) As String
        'Returns a random message corresponding to the given type.
        'NOTE: type must be either "Correct" or "Incorrect".
        Return prompts(type)(randInt(0, prompts(type).Count - 1))
    End Function

    Private Function pointsAfterTime(ByVal milliseconds As Integer) As Integer
        'Returns the number of points the user would have after a given number of seconds.
        Return maxPoints * Math.Pow(Math.E, -milliseconds / 6000)
    End Function

    Private Function selectedButton() As RadioButton
        'Returns the selected radio button from the groupOptions control collection.
        'If no options are selected, a default RadioButton object is returned.
        Return groupOptions.Controls _
               .OfType(Of RadioButton)() _
               .FirstOrDefault(Function(r) r.Checked)  'lambda/anonymous function!
    End Function

End Class