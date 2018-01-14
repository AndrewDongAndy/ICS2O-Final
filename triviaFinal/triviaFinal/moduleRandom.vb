Friend Module Random

    'Provides the randInt(min, max) and randPrompt(type) functions.

    Private prompts As Dictionary(Of String, List(Of String))

    Friend Sub initPrompts()
        'Initializes the prompts dictionary by reading from the files.
        'Called when the application is launched.
        prompts = New Dictionary(Of String, List(Of String))

        Dim promptFile As IO.StreamReader  'Load the prompts dictionary by reading from two data files in the loop
        For Each promptType As String In {"Correct", "Incorrect"}
            promptFile = New IO.StreamReader(String.Format("Prompts/{0}.txt", promptType))
            prompts.Add(promptType, New List(Of String))
            Do While Not promptFile.EndOfStream()
                prompts(promptType).Add(promptFile.ReadLine())
            Loop
            promptFile.Close()
        Next
    End Sub

    Friend Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
        'Returns a random integer between the given arguments min and max, inclusive.
        Return Int((max - min + 1) * Rnd()) + min
    End Function

    Friend Function randPrompt(ByVal type As String) As String
        'Returns a random prompt of the given type.
        Return prompts(type)(randInt(0, prompts.Count - 1))
    End Function

End Module
