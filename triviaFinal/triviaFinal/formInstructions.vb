Public Class formInstructions

    Private Sub formInstructions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        displayInstructions("Single")
    End Sub

    Private Sub btnSingle_Click(sender As System.Object, e As System.EventArgs) Handles btnSingle.Click
        displayInstructions("Single")
    End Sub

    Private Sub btnMulti_Click(sender As System.Object, e As System.EventArgs) Handles btnMulti.Click
        displayInstructions("Multi")
    End Sub

    Private Sub displayInstructions(ByVal category As String)

        'As in formHighScores, category can only be "Single" or "Multi".
        Select Case category
            Case "Single"
                lblCategory.Text = "Single player"
            Case "Multi"
                lblCategory.Text = "Multiplayer"
            Case Else
                Exit Sub
        End Select

        Dim instrFile As New IO.StreamReader("Instructions/" & category & ".txt")

        txtInstructions.Text = instrFile.ReadToEnd()

    End Sub


End Class