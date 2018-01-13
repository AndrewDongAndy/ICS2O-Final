Public Class formTitle

    'CALCULATION throughout code to find

    Public Result As SingleResult

    Private Sub formTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingle.Click
        Me.Hide()
        formSingle.Show()
    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        Me.Hide()
        formMulti.Show()
    End Sub

    Private Sub btnInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.Click
        Me.Hide()
        formInstructions.Show()
    End Sub

    Private Sub btnHighScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighScores.Click
        Me.Hide()
        formHighScores.Show()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        Me.Hide()
        formSettings.Show()
    End Sub
End Class