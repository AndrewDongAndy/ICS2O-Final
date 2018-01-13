Public Class Question

    'Blueprint for a question used in formSingle and formMulti.
    'See the README.txt file for instructions on the file format.

    Private questionFile As IO.StreamReader
    Private filePath As String
    Friend Question As String
    Friend Options As New List(Of String)
    Friend Correct As Integer

    Public Sub New(ByVal questionID)
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

            'Load the correct option.
            .Correct = .Options.IndexOf(correctOption)
        End With

        questionFile.Close()
    End Sub

    Public Function IsCorrect(ByVal answer As Integer) As Boolean
        'Takes the entered index as an argument, and returns whether that index is the correct answer.
        If answer = Me.Correct Then
            Return True
        Else
            Return False
        End If
    End Function

    Public ReadOnly Property CorrectAnswer As String
        Get
            Return Me.Options(Me.Correct)
        End Get
    End Property

    Private Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Return Int((max - min + 1) * Rnd()) + min
    End Function
End Class
