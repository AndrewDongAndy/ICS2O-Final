Public Class Question

    'Blueprint for a question used in formSingle and formMulti.


    'Format for questions:

    'Question
    'Option 0
    'Option 1
    'Option 2
    'Option 3
    'Correct option number

    'Example:

    'What is 2 + 2?
    '3
    '3
    '4
    '5
    '1

    'Note: you must have four options, even for True or False questions.
    'If necessary, add "weird" choices such as "I'm not sure!", or
    'something like "How do you expect me to know Obama's last name?"

    Private questionFile As IO.StreamReader
    Private filePath As String
    Friend Question As String
    Friend Options As New List(Of String)
    Friend Correct As Integer

    Public Sub New(ByVal questionID)
        'Constructor for the Question class

        'Note that the question ID is the text proceeding the 'Q' prefix in the question file.
        'It can be either an integer or a String.
        filePath = "Built-in Questions/Q" & questionID & ".txt"

        questionFile = New IO.StreamReader(filePath)
        With Me
            .Question = questionFile.ReadLine()
            For i As Integer = 1 To 4  'must have four options
                .Options.Add(questionFile.ReadLine())
            Next
            .Correct = questionFile.ReadLine()
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

End Class
