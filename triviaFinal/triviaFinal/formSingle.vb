Public Class formSingle

    Private question As Question
    Private prompts As Dictionary(Of String, List(Of String))
    Private notPlayed As List(Of Integer)
    Private answerTime As Double  'number of seconds taken for the user to answer
    Private Const maxPoints As Integer = 1000  'points given if user answered correctly instantly
    Private Const numQuestions As Integer = 4

    Private Sub formSingle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        initPrompts()
        notPlayed = New List(Of Integer)
        For i As Integer = 1 To numQuestions
            notPlayed.Add(i)
        Next
    End Sub

    Private Sub btnNewRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRound.Click

        loadQuestion(randInt(0, notPlayed.Count - 1))

        answerTime = 0
        timerAnswer.Start()
    End Sub

    Private Sub timerAnswer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAnswer.Tick
        lblTime.Text = pointsAfterTime(answerTime)
        answerTime += timerAnswer.Interval
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        timerAnswer.Stop()

        'For debugging
        MsgBox(pointsAfterTime(answerTime))

        'Get the button that was selected.
        Dim selectedButton As RadioButton
        selectedButton = groupOptions.Controls _
                         .OfType(Of RadioButton)() _
                         .FirstOrDefault(Function(r) r.Checked)

        Try
            If selectedButton.Name = "rbOption" & question.Correct Then
                MsgBox(randMsg("Correct"))
            Else
                MsgBox(randMsg("Incorrect"))
            End If
        Catch ex As NullReferenceException
            MsgBox("Well, at least try... !")
        End Try

    End Sub

    Private Sub initPrompts()
        'Initialize the prompts dictionary by reading from the files.

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

    Private Sub loadQuestion(ByVal questionID)
        question = New Question(questionID)

        'Load question
        lblQuestion.Text = question.Question

        'Load options
        For i As Integer = 0 To 3
            groupOptions.Controls(i).Text = question.Options(i)
        Next
    End Sub

    Private Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Return Int((max - min + 1) * Rnd()) + min
    End Function

    Private Function randMsg(ByVal type As String) As String
        'Returns a random message corresponding to the given type.
        'NOTE: type must be either "Correct" or "Incorrect".
        Return prompts(type)(randInt(0, prompts(type).Count - 1))
    End Function

    Private Function pointsAfterTime(ByVal milliseconds As Double) As Integer
        'Returns the number of points the user would have after a given number of seconds.
        Return maxPoints * Math.Pow(Math.E, -milliseconds / 4000)
    End Function

End Class