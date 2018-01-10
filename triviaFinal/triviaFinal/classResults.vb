Public Class SingleResult

    Implements IResult

    Friend PlayerName As String
    Friend NumCorrect As Integer
    Friend NumGuessed As Integer
    Friend Score As Integer


    Public Sub New(ByVal PlayerName As String, ByVal NumCorrect As Integer,
                   ByVal NumGuessed As Integer, ByVal Score As Integer)

        With Me
            .PlayerName = PlayerName
            .NumCorrect = NumCorrect
            .NumGuessed = NumGuessed
            .Score = Score
        End With

    End Sub

    Public Function Percentage() As Double Implements IResult.Percentage
        Return Me.NumCorrect / Me.NumGuessed
    End Function

End Class

Public Class MultiResult

    Implements IResult

    Public Function Percentage() As Double Implements IResult.Percentage
        Return Nothing
    End Function

End Class


Interface IResult
    Function Percentage() As Double
End Interface
