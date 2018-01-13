Public Class formMulti

    Private keysDict As Dictionary(Of String, List(Of Char))
    Private leftKeys As New List(Of Char) From {"1", "Q", "S", "X"}
    Private rightKeys As New List(Of Char) From {"9", "O", "P", "L"}

    '=====================Copied from formSingle=====================

    Private prompts As Dictionary(Of String, List(Of String))  'constant: prompts that can be displayed
    Private unplayed As List(Of Integer)  'stores which questions were not yet played

    'Constants: "shared" data
    Private Const maxPoints As Integer = 1000  'points given if user answered correctly "instantly"
    Private Const numQuestions As Integer = 10  'the number of questions we are allowed to choose from (randomly)
    Private Const questionsPerRound As Integer = 10  'how many questions per round
    Private Const autoStartRound As Boolean = True  'whether or not to start next round automatically

    'Data about the players for this round
    Private scores As Dictionary(Of String, Integer)

    'Data for a given question
    Private question As Question  'stores a question
    Private correct As Boolean  'if this question was answered correctly

    Private Sub formMulti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True

        initKeysAndDict()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        nextQuestion()
    End Sub

    Private Sub initKeysAndDict()

        'Initializes the keys dictionary and the PictureBox objects
        'for which keys correspond to which player and which option.

        'Initialize Dictionary directly from the leftKeys and rightKeys Lists
        keysDict = New Dictionary(Of String, List(Of Char))
        keysDict.Add("Left", leftKeys)
        keysDict.Add("Right", rightKeys)

        'Initialize Keys images
        For Each player As String In keysDict.Keys
            For c As Integer = 0 To keysDict(player).Count - 1
                Dim picBox As New PictureBox
                picBox = Controls(String.Format("pic{0}Key{1}", player, c))
                displayKey(keysDict(player)(c), picBox)
            Next
        Next

    End Sub

    Private Sub displayKey(ByVal key As Char, ByVal pic As PictureBox)
        'Displays the given character in the given PictureBox.
        pic.Image = Image.FromFile(String.Format("Keys/{0}.png", key))
    End Sub

    Private Sub nextQuestion()
        Dim currentQuestion As Integer

        'First, choose a random question, remove it, and load it.
        currentQuestion = unplayed(randInt(0, unplayed.Count - 1))
        unplayed.Remove(currentQuestion)
        loadQuestion(currentQuestion)

    End Sub

    Private Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Return Int((max - min + 1) * Rnd()) + min
    End Function

    Private Sub loadQuestion(ByVal questionID)
        'Loads a question into the proper controls.

        question = New Question(questionID)
        lblQuestion.Text = question.Question
        For i As Integer = 0 To 3
            Controls("lblOption" & i).Text = question.Options(i)
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

    Private Sub formMulti_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If leftKeys.Contains(e.KeyChar) Then

        End If
    End Sub

    Private Function selectionPlayer(ByVal c As Char) As String
        If leftKeys.Contains(c) Then
            Return "Left"
        ElseIf rightKeys.Contains(c) Then
            Return "Right"
        Else
            Return Nothing
        End If
    End Function

    Private Function selectionOption(ByVal c As Char) As String
        Return keysDict(selectionPlayer(c)).IndexOf(c)
    End Function
End Class