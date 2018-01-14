Public Class Question

    'Blueprint for a question used in formSingle and formMulti.
    'See the README.txt file for instructions on the file format.

    Private questionFile As IO.StreamReader
    Private filePath As String
    Friend Question As String
    Friend Options As New List(Of String)
    Friend Correct As Integer

    'NOTE: this number (below) should be one more than the number of
    'the largest file number in the Built-in Questions directory.
    Private Const directory As String = "Built-in Questions"
    Friend Const NumQuestions As Integer = 16  'number of available questions available to choose from

    Friend Sub New(ByVal questionID)
        'Constructor for the Question class

        'Note that the question ID is the text proceeding the 'Q' prefix in the question file.
        'It can be either an integer or a String.
        filePath = String.Format("Built-in Questions/Q{0}.txt", questionID)

        'Read the data and shuffle the options to deter memorization of order
        Dim tmp As New List(Of String)
        Dim removedIndex As Integer
        Dim correctOption As String
        questionFile = New IO.StreamReader(filePath)

        'All attributes are of Me (this instance).
        With Me
            .Question = questionFile.ReadLine()
            For i As Integer = 1 To 4  'must have four options
                tmp.Add(questionFile.ReadLine())
            Next

            'The correct option is ALWAYS the first one in the data file (see README)
            correctOption = tmp(0)

            'Transfer the items in tmp to .Options in a random order (shuffle)
            Do While tmp.Count > 0
                removedIndex = randInt(0, tmp.Count - 1)
                .Options.Add(tmp(removedIndex))
                tmp.RemoveAt(removedIndex)
            Loop

            'Load the correct option index
            .Correct = .Options.IndexOf(correctOption)
        End With

        questionFile.Close()
    End Sub

    Friend Function IsCorrect(ByVal answer As Integer) As Boolean
        'Takes the entered index as an argument, and returns whether that index is the correct answer.
        Return (answer = Me.Correct)
    End Function

    Friend ReadOnly Property CorrectAnswer As String
        'Property of the correct answer for this question (not the correct index)
        Get
            Return Me.Options(Me.Correct)
        End Get
    End Property
End Class
