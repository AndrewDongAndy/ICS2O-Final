Friend Module SinglePlayer

    'Functions for the Single Player mode.

    Private Const maxPoints As Integer = 1000
    'above: whether or not to start next round automatically, i.e. prompts on whether
    'the answer was correct, what the correct answer was if user's answer was wrong

    Friend Function pointsAfterTime(ByRef milliseconds As Integer) As Integer
        'Returns the number of points a player would receive.
        Return maxPoints * Math.Pow(Math.E, -milliseconds / 6000)
    End Function

End Module


Friend Module MultiPlayer

    'Functions for two-player mode.

    'The key characters MUST be lowercase!
    Private leftKeys As New List(Of Char) From {"1", "q", "s", "x"}
    Private rightKeys As New List(Of Char) From {"8", "i", "o", "k"}
    Friend keysDict As Dictionary(Of String, List(Of Char))

    Friend Sub initKeysDict()
        'Initializes the keysDict dictionary.
        keysDict = New Dictionary(Of String, List(Of Char))
        keysDict.Add("Left", leftKeys)
        keysDict.Add("Right", rightKeys)
    End Sub

    Friend Sub displayKey(ByVal c As Char, ByRef pic As PictureBox)
        'Displays the given character in the given PictureBox.
        pic.Image = Image.FromFile(String.Format("Keys/{0}.png", c))
    End Sub

    Friend Function selectionPlayer(ByVal c As Char) As String
        'Returns the player (Left or Right) of the given option.
        'If the given option is not in one of the two lists of characters
        'for each player, returns Nothing.
        If leftKeys.Contains(c) Then
            Return "Left"
        ElseIf rightKeys.Contains(c) Then
            Return "Right"
        Else
            Return Nothing
        End If
    End Function

    Friend Function selectionOption(ByVal c As Char) As String
        'Returns the selected option index of the given character.
        Return keysDict(selectionPlayer(c)).IndexOf(c)
    End Function

End Module


Friend Module Other

    'Shared data between the two game modes.

    Friend questionsPerRound As Integer = 10  'how many questions per round
    Friend autoStartRound As Boolean = False

    Friend highScoreEntries As Integer = 10

    Friend Function range(ByVal start As Integer, ByVal finish As Integer,
                           Optional ByVal skip As Integer = 1) As List(Of Integer)
        'Equivalent to list(range(start, finish, skip)) in Python.

        Dim lst As New List(Of Integer)
        For i As Integer = start To finish - 1 Step skip
            lst.Add(i)
        Next
        Return lst
    End Function

    Friend Sub loadQuestion(ByVal question As Question, ByVal questionControl As Control,
                            ByVal optionControl0 As Control, ByVal optionControl1 As Control,
                            ByVal optionControl2 As Control, ByVal optionControl3 As Control)

        'Loads the given Question object into the five given Controls:
        'one for the Question and four for the Options.
        questionControl.Text = question.Question
        optionControl0.Text = question.Options(0)
        optionControl1.Text = question.Options(1)
        optionControl2.Text = question.Options(2)
        optionControl3.Text = question.Options(3)

    End Sub

End Module