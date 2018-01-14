'Includes the Class declarations for a result for single-player mode,
'a result for multiplayer mode, and a class to hold a single entry.


Public Class SingleResult

    Implements IResult

    Friend PlayerName As String
    Friend Scores As List(Of Integer)

    Public Sub New(ByVal PlayerName As String, Optional ByVal Scores As List(Of Integer) = Nothing)

        With Me
            .PlayerName = PlayerName
            If IsNothing(Scores) Then
                .Scores = New List(Of Integer)
            Else
                .Scores = Scores
            End If
        End With

    End Sub

    Public ReadOnly Property NumCorrect As Integer Implements IResult.NumCorrect
        'CALCULATION: gets the number of correct answers.
        Get
            Dim correctAnswers As Integer
            For Each i As Integer In Scores
                If i > 0 Then
                    correctAnswers += 1
                End If
            Next
            Return correctAnswers
        End Get
    End Property

    Public ReadOnly Property NumGuessed As Integer Implements IResult.NumGuessed
        'Gets the number of questions guessed.
        Get
            Return Me.Scores.Count
        End Get
    End Property

    Public ReadOnly Property Percentage As Double Implements IResult.Percentage
        'CALCULATION: gets the percentage of questions correct.
        Get
            Return Me.NumCorrect / Me.NumGuessed
        End Get
    End Property

    Public ReadOnly Property Total As Integer Implements IResult.Total
        'CALCULATION: gets the sum of the scores.
        Get
            Return Me.Scores.Sum()
        End Get
    End Property

End Class

Public Class MultiResult

End Class


Interface IResult
    ReadOnly Property NumCorrect As Integer
    ReadOnly Property NumGuessed As Integer
    ReadOnly Property Percentage As Double
    ReadOnly Property Total As Integer
End Interface


Class SingleHighScoreEntry

    'Scores a high score entry for the single-player mode.

    Inherits Tuple(Of String, Integer)

    Public Sub New(ByVal name As String, ByVal score As Integer)
        MyBase.New(name, score)
    End Sub

    Friend ReadOnly Property Name As String
        Get
            Return Me.Item1
        End Get
    End Property

    Friend ReadOnly Property Score As Integer
        Get
            Return Me.Item2
        End Get
    End Property


End Class